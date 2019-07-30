using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C_Sharp_Application;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace AutomatedLIBS {
    public partial class Plasma : Form {
        public List<List<TemperaturePoint>> mTemperatureLines;
        private List<Ion> mIons;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Plasma(List<Ion> ions) {
            InitializeComponent();

            mIons = ions;
            mTemperatureLines = new List<List<TemperaturePoint>>();

            clbLines.DisplayMember = "ShortName";
            foreach (var ion in mIons) {
                clbLines.Items.Add(ion);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void LinearApproximation(List<LinePoint> points, ref double a, ref double b) {
            double xSum = 0;
            double ySum = 0;
            double x2Sum = 0;
            double xySum = 0;
            for (int i = 0; i < points.Count; i++) {
                xSum += points[i].mX;
                ySum += points[i].mY;
                x2Sum += points[i].mX * points[i].mX;
                xySum += points[i].mX * points[i].mY;
            }
            a = (points.Count * xySum - (xSum * ySum)) / (points.Count * x2Sum - xSum * xSum);
            b = (ySum - a * xSum) / points.Count;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private double ComputeSlope(double a, double b) {
            double x1 = 0;
            double y1 = a * x1 + b;

            double x2 = 1;
            double y2 = a * x2 + b;

            return (y2 - y1) / (x2 - x1);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private double ComputeTemperature(double slope) {
            const double k = 0.000086173303; // eV/K
            return -1.0 / (k * slope);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private double ComputeLogarithm(double intensity, double wavelenght, double gA) {
            return Math.Log((intensity * wavelenght) / gA);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e) {
            mTemperatureLines.Clear();
            ResultsText.Clear();

            chrTemperatureDistr.Series.Clear();
            chrSahaBoltzmanPlot.Series.Clear();

            int measurementNum = 0;
            foreach (var measurement in MainWindow.mExperiments) {
                if (measurement.mSpectra.Count == 0) {
                    continue;
                }

                var line = new List<TemperaturePoint>();
                mTemperatureLines.Add(line);

                string name = "Measurement " + measurementNum;


                chrTemperatureDistr.Series.Add(name);
                chrTemperatureDistr.Series[name].ChartType = SeriesChartType.FastLine;

                ResultsText.Text += "Measurement " + measurementNum + Environment.NewLine;
                int spectrumNumber = 0;
                foreach (var spec in measurement.mSpectra) {
                    // get points in coordinates of [ E; ln(I/A*g) ]
                    var points = GetLogPoints(spec);

                    // plot points on Saha-Boltzman plane
                    var distributionName = "Distribution " + spectrumNumber;
                    LinePoint minPoint = points[0], maxPoint = points[0];
                    chrSahaBoltzmanPlot.Series.Add(distributionName);
                    StreamWriter of = new StreamWriter(distributionName + ".bdp");
                    foreach (var p in points) {
                        chrSahaBoltzmanPlot.Series[distributionName].Points.AddXY(Math.Round(p.mX,2), Math.Round(p.mY,2));
                        chrSahaBoltzmanPlot.Series[distributionName].ChartType = SeriesChartType.Point;
                        of.WriteLine("P\t" + p.mX + "\t" + p.mY);
                        if (p.mX > maxPoint.mX) {
                            maxPoint = p;
                        }
                        if (p.mX < minPoint.mX) {
                            minPoint = p;
                        }
                    }
                    of.Close();

                    // do linear approximation to get slope from points, for further temperature calculation
                    double a = 0.0f;
                    double b = 0.0f;
                    LinearApproximation(points, ref a, ref b);
                    double slope = ComputeSlope(a, b);

                    // plot approximation
                    var approxName = "Approximation " + spectrumNumber;
                    chrSahaBoltzmanPlot.Series.Add(approxName);
                    chrSahaBoltzmanPlot.Series[approxName].Points.AddXY(Math.Round(minPoint.mX, 2), Math.Round(a * minPoint.mX + b, 2));
                    chrSahaBoltzmanPlot.Series[approxName].Points.AddXY(Math.Round(maxPoint.mX,2), Math.Round(a * maxPoint.mX + b, 2));
                    chrSahaBoltzmanPlot.Series[approxName].ChartType = SeriesChartType.FastLine;

                    // calculate temperature using line slope
                    double temperature = ComputeTemperature(slope);

                    ResultsText.Text += "T: " + Math.Round(temperature, 2) + "; S: " + Math.Round(slope, 2) + Environment.NewLine;
                    line.Add(new TemperaturePoint(temperature, a, b, slope, spec.mIntegrationDelayMicroSec));

                    chrTemperatureDistr.Series[name].Points.AddXY(Math.Round(spec.mIntegrationDelayMicroSec, 1), temperature);

                    ++spectrumNumber;
                }

                ++measurementNum;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private List<LinePoint> GetLogPoints(Spectrum spec) {
            List<LinePoint> points = new List<LinePoint>();

            foreach (Ion ion in clbLines.CheckedItems) {
                double intensity = -9999999.0;

                for (int k = 0; k < spec.mIrradiance.Value.Count(); ++k) {
                    if ((int)spec.mWaveLengths.Value[k] == (int)ion.mWavelength) {
                        // find maximum
                        const int window = 3;
                        for (int j = k - window; j < k + window; ++j) {
                            if (j < 0) {
                                j = 0;
                            }
                            if (j >= MainWindow.mSpectrometerPixelsCount) {
                                j = MainWindow.mSpectrometerPixelsCount - 1;
                            }
                            if (spec.mIrradiance.Value[j] > intensity) {
                                intensity = spec.mIrradiance.Value[j];
                            }
                        }
                    }
                }

                points.Add(new LinePoint(ion.mEk, ComputeLogarithm(intensity, ion.mWavelength, ion.mgk * ion.mTransitionStrenghtAki)));
            }

            return points;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Plasma_Load(object sender, EventArgs e) {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ClearResults_Click(object sender, EventArgs e) {
            ResultsText.Clear();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SaveToFile_Click(object sender, EventArgs e) {
            SaveToFileDialog.Filter = "Plasma|*.pls";
            SaveToFileDialog.Title = "Save spectrum...";
            SaveToFileDialog.ShowDialog();

            if (SaveToFileDialog.FileName != "") {
                System.IO.FileStream fs = (System.IO.FileStream)SaveToFileDialog.OpenFile();
                System.IO.StreamWriter file = new System.IO.StreamWriter(fs);

                int lineNum = 0;
                foreach (var line in mTemperatureLines) {
                    file.WriteLine("Measurement " + lineNum++);
                    file.WriteLine("T\tDelay\tSlope\tK\tB");
                    foreach (var value in line) {
                        file.WriteLine(value.mTemperature.ToString() + "\t" + value.mDelay.ToString() + "\t" + value.mSlope.ToString() + "\t" + value.mA.ToString() + "\t" + value.mB.ToString());
                    }
                }

                file.Close();
                fs.Close();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Plasma_Resize(object sender, EventArgs e) {
            // MainChart.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 190);
        }
    }
};

public class LinePoint {
    public double mX, mY;

    public LinePoint() {
        mX = 0;
        mY = 0;
    }

    public LinePoint(double x, double y) {
        mX = x;
        mY = y;
    }
};

public class TemperaturePoint {
    public double mTemperature;
    public double mA, mB, mSlope;
    public double mDelay;

    public TemperaturePoint() {

    }

    public TemperaturePoint(double temp, double a, double b, double slope, double delay) {
        mTemperature = temp;
        mA = a;
        mB = b;
        mSlope = slope;
        mDelay = delay;
    }
}
