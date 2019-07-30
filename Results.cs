using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C_Sharp_Application;
using System.IO;

namespace AutomatedLIBS {
    public partial class Results : Form {
        List<RelativeIntegralList> mRelativeIntegralList;
        avaspec.PixelArrayType mWavelengths;

        public Results() {
            InitializeComponent();

            mRelativeIntegralList = new List<RelativeIntegralList>();

            StreamReader file = new StreamReader("matrixranges.tbl");
            while (!file.EndOfStream) {
                string[] ranges = file.ReadLine().Split(' ');
                if (ranges.Count() == 2) {
                    if (Convert.ToDouble(ranges[1]) == 0) {
                        ExistingMatrixRanges.Items.Add(new Range(Convert.ToDouble(ranges[0])));
                    } else {
                        ExistingMatrixRanges.Items.Add(new Range(Convert.ToDouble(ranges[0]), Convert.ToDouble(ranges[1])));
                    }
                }
            }
            file.Close();

            file = new StreamReader("materialranges.tbl");
            while (!file.EndOfStream) {
                string[] ranges = file.ReadLine().Split(' ');
                if (ranges.Count() == 2) {
                    if (Convert.ToDouble(ranges[1]) == 0) {
                        ExistingMaterialRanges.Items.Add(new Range(Convert.ToDouble(ranges[0])));
                    } else {
                        ExistingMaterialRanges.Items.Add(new Range(Convert.ToDouble(ranges[0]), Convert.ToDouble(ranges[1])));
                    }
                }

            }
            file.Close();
        }

        private void MatrixAddRange_Click(object sender, EventArgs e) {
            Range newRange;
            if (chkMatrixUseSingleLine.Checked) {
                newRange = new Range((double)nudMatrixRangeFrom.Value);
            } else {
                newRange = new Range((double)nudMatrixRangeFrom.Value, (double)nudMatrixRangeTo.Value);
            }

            MatrixRanges.Items.Add(newRange);

            bool exist = false;
            for (int i = 0; i < ExistingMatrixRanges.Items.Count; ++i) {
                var r = (Range)ExistingMatrixRanges.Items[i];
                if (r.from == newRange.from && r.to == newRange.to) {
                    exist = true;
                    break;
                }
            }

            if (!exist) {
                ExistingMatrixRanges.Items.Add(newRange);
            }
        }

        private void UpdateChart() {
            MainChart.Series.Clear();

            MainChart.ChartAreas[0].AxisY.Title = "Relative integral";
            MainChart.ChartAreas[0].AxisX.CustomLabels.Clear();


            int number = 0;
            foreach (var intList in mRelativeIntegralList) {
                string name = "Measurement " + number;

                MainChart.Series.Add(name);
                MainChart.Series[name].ChartType = XMaterialNumber.Checked ? System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar : System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                MainChart.Series[name]["ErrorBarCenterMarkerStyle"] = "Square";
                if (XMaterialNumber.Checked) {
                    MainChart.ChartAreas[0].AxisX.Title = "Material number";
                    MainChart.ChartAreas[0].AxisX.CustomLabels.Add(number - 0.5, number + 0.5, intList.mMeasurementNumber.ToString());
                    MainChart.Series[name].Points.AddXY((double)number, intList.mAverage, intList.mAverage - intList.mStandardDeviation, intList.mAverage + intList.mStandardDeviation);
                } else {
                    MainChart.ChartAreas[0].AxisX.Title = "Delay, μs";
                    foreach (var integral in intList.mElements) {
                        MainChart.Series[name].Points.AddXY(integral.mDelta, integral.mIntegral);
                    }
                }
                ++number;
            }
        }


        private void Calculate_Click(object sender, EventArgs e) {
            if (MatrixRanges.Items.Count == 0) {
                MessageBox.Show("You must add integration intervals for matrix first!");
                return;
            }
            if (MaterialRanges.Items.Count == 0) {
                MessageBox.Show("You must add integration intervals for material first!");
                return;
            }

            ErrorsText.Clear();
            mRelativeIntegralList.Clear();

            var measurements = AutomatedLIBS.MainWindow.mExperiments;
            for (int measurementNum = 0; measurementNum < measurements.Count; ++measurementNum) {
                RelativeIntegralList intList = new RelativeIntegralList();

                var spectrums = measurements[measurementNum].mSpectra;
                for (int spectrumNum = 0; spectrumNum < spectrums.Count; ++spectrumNum) {
                    var spectrum = spectrums[spectrumNum];

                    // calculate matrix integral
                    double matrixIntegral = 0.0f;
                    for (int i = 0; i < MatrixRanges.Items.Count; ++i) {
                        var range = (Range)MatrixRanges.Items[i];
                        if (range.mSingleLine) {
                            int index = GetClosestWavelengthMatchIndex(range.from);
                            matrixIntegral += spectrum.mAbsoluteIntensities.Value[index];
                        } else {
                            matrixIntegral += CalculateIntegral(spectrum, range.from, range.to);                            
                        }
                    }

                    // calculate material integral
                    double materialIntegral = 0.0f;
                    for (int i = 0; i < MaterialRanges.Items.Count; ++i) {
                        var range = (Range)MaterialRanges.Items[i];
                        if (range.mSingleLine) {
                            int index = GetClosestWavelengthMatchIndex(range.from);
                            materialIntegral += spectrum.mAbsoluteIntensities.Value[index];
                        } else {
                            materialIntegral += CalculateIntegral(spectrum, range.from, range.to);
                        }
                    }

                    // calculate relative integral
                    double relativeIntegral = materialIntegral / matrixIntegral;

                    // IntegralResults.Text += relativeIntegral.ToString() + '\n';

                    intList.mElements.Add(new RelativeIntegral(relativeIntegral, spectrum.mIntegrationDelayMicroSec, spectrum.mName));
                }

                if (intList.mElements.Count > 0) {
                    intList.mMeasurementNumber = measurementNum + 1;
                    mRelativeIntegralList.Add(intList);

                    ///////////////////////
                    // calculate error

                    // calculate average
                    intList.mAverage = 0.0;
                    for (int i = 0; i < intList.mElements.Count; ++i) {
                        intList.mAverage += intList.mElements[i].mIntegral;
                    }
                    if (intList.mElements.Count > 0) {
                        intList.mAverage /= intList.mElements.Count;
                    }

                    // calculate standard deviation
                    intList.mStandardDeviation = 0.0;
                    for (int i = 0; i < intList.mElements.Count; ++i) {
                        intList.mStandardDeviation += Math.Pow(intList.mElements[i].mIntegral - intList.mAverage, 2);
                    }
                    if (intList.mElements.Count > 1) {
                        intList.mStandardDeviation /= intList.mElements.Count - 1;
                        intList.mStandardDeviation = Math.Sqrt(intList.mStandardDeviation);
                    }

                    ErrorsText.Text += "M" + measurementNum + " - μ: " + Math.Round(intList.mAverage, 4) + "; σ: " + Math.Round(intList.mStandardDeviation, 4) + Environment.NewLine;
                }
            }

            UpdateChart();
        }

        private void MatrixRemoveRange_Click(object sender, EventArgs e) {
            if (MatrixRanges.SelectedIndex >= 0) {               
                MatrixRanges.Items.RemoveAt(MatrixRanges.SelectedIndex);
            }
        }

        private void Results_Load(object sender, EventArgs e) {
            mWavelengths = MainWindow.mExperiments[0].mSpectra[0].mWaveLengths;

            double averageWlDelta = mWavelengths.Value[mWavelengths.Value.Length - 1] - mWavelengths.Value[mWavelengths.Value.Length - 2];
            averageWlDelta *= 2;

            nudMaterialRangeTo.Minimum = (decimal)mWavelengths.Value.First();
            nudMaterialRangeTo.Maximum = (decimal)mWavelengths.Value.Last();
            nudMaterialRangeTo.Value = nudMaterialRangeTo.Maximum;
            nudMaterialRangeTo.Increment = (decimal)averageWlDelta;

            nudMaterialRangeFrom.Minimum = (decimal)mWavelengths.Value.First();
            nudMaterialRangeFrom.Maximum = (decimal)mWavelengths.Value.Last();
            nudMaterialRangeFrom.Value = nudMaterialRangeFrom.Minimum;
            nudMaterialRangeFrom.Increment = (decimal)averageWlDelta;

            nudMatrixRangeTo.Minimum = (decimal)mWavelengths.Value.First();
            nudMatrixRangeTo.Maximum = (decimal)mWavelengths.Value.Last();
            nudMatrixRangeTo.Value = nudMatrixRangeTo.Maximum;
            nudMatrixRangeTo.Increment = (decimal)averageWlDelta;

            nudMatrixRangeFrom.Minimum = (decimal)mWavelengths.Value.First();
            nudMatrixRangeFrom.Maximum = (decimal)mWavelengths.Value.Last();
            nudMatrixRangeFrom.Value = nudMatrixRangeFrom.Minimum;
            nudMatrixRangeFrom.Increment = (decimal)averageWlDelta;

            MatrixRanges.DisplayMember = "ShortName";
            MaterialRanges.DisplayMember = "ShortName";
            ExistingMatrixRanges.DisplayMember = "ShortName";
            ExistingMaterialRanges.DisplayMember = "ShortName";
        }

        private void MaterialAddRange_Click(object sender, EventArgs e) {
            Range newRange;

            if (chkMaterialUseSingleLine.Checked) {
                newRange = new Range((double)nudMaterialRangeFrom.Value);
            } else {
                newRange = new Range((double)nudMaterialRangeFrom.Value, (double)nudMaterialRangeTo.Value);
            }

            MaterialRanges.Items.Add(newRange);
            
            bool exist = false;
            for (int i = 0; i < ExistingMaterialRanges.Items.Count; ++i) {
                var r = (Range)ExistingMaterialRanges.Items[i];
                if (r.from == newRange.from && r.to == newRange.to) {
                    exist = true;
                    break;
                }
            }

            if (!exist) {
                ExistingMaterialRanges.Items.Add(newRange);
            }
        }

        private void MaterialRemoveRange_Click(object sender, EventArgs e) {
            if (MaterialRanges.SelectedIndex >= 0) {
                MaterialRanges.Items.RemoveAt(MaterialRanges.SelectedIndex);
            }
        }

        private double CalculateIntegral(Spectrum spectrum, double from, double to) {
            int indexFrom = 0;
            int indexTo = 0;

            var wl = spectrum.mWaveLengths.Value;
            for (int i = 0; i < spectrum.mWaveLengths.Value.Length; ++i) {
                if (Math.Abs(wl[i] - from) < Math.Abs(wl[i] - wl[indexFrom])) {
                    indexFrom = i;
                }
                if (Math.Abs(wl[i] - to) < Math.Abs(wl[i] - wl[indexTo])) {
                    indexTo = i;
                }
            }

            double integral = 0.0;

            for (int i = indexFrom; i < indexTo; ++i) {
                if (chkUseIrradiance.Checked) {
                    integral += spectrum.mIrradiance.Value[i];
                } else {
                    integral += spectrum.mAbsoluteIntensities.Value[i];
                }
            }

            return integral;
        }

        private void ClearResults_Click(object sender, EventArgs e) {
            mRelativeIntegralList.Clear();
            ErrorsText.Clear();
            UpdateChart();
        }

        private void SaveAsTable_Click(object sender, EventArgs e) {
            SaveAsTableDialog.Filter = "Table|*.txt";
            SaveAsTableDialog.Title = "Save as table...";
            SaveAsTableDialog.ShowDialog();

            if (SaveAsTableDialog.FileName != "") {
                System.IO.FileStream fs = (System.IO.FileStream)SaveAsTableDialog.OpenFile();

                System.IO.StreamWriter file = new System.IO.StreamWriter(fs);

                file.WriteLine("Matrix ranges");
                for (int i = 0; i < MatrixRanges.Items.Count; ++i) {
                    var range = (Range)MatrixRanges.Items[i];
                    file.WriteLine(range.from + "\t" + range.to);
                }

                file.WriteLine("Material ranges");
                for (int i = 0; i < MaterialRanges.Items.Count; ++i) {
                    var range = (Range)MaterialRanges.Items[i];
                    file.WriteLine(range.from + "\t" + range.to);
                }
                file.WriteLine("Integral list");



                if (XMaterialNumber.Checked) {
                    for (int i = 0; i < mRelativeIntegralList.Count; ++i) {
                        var intList = mRelativeIntegralList[i].mElements;

                        if (intList.Count > 0) {
                            file.WriteLine("===============================================================");
                            file.WriteLine("Measurement " + i);
                            file.WriteLine("Average" + "\t" + mRelativeIntegralList[i].mAverage);
                            file.WriteLine("Standard Deviation" + "\t" + mRelativeIntegralList[i].mStandardDeviation + Environment.NewLine);
                        }

                        for (int j = 0; j < intList.Count; ++j) {
                            file.WriteLine(mRelativeIntegralList[i].mMeasurementNumber.ToString() + "\t" + intList[j].mIntegral + "\t" + intList[j].mName);
                        }
                    }
                } else {
                    for (int i = 0; i < mRelativeIntegralList.Count; ++i) {
                        var intList = mRelativeIntegralList[i].mElements;

                        if (intList.Count > 0) {
                            file.WriteLine("===============================================================");
                            file.WriteLine("Measurement " + i);
                            file.WriteLine("Average" + "\t" + mRelativeIntegralList[i].mAverage);
                            file.WriteLine("Standard Deviation" + "\t" + mRelativeIntegralList[i].mStandardDeviation + Environment.NewLine);
                        }

                        for (int j = 0; j < intList.Count; ++j) {
                            file.WriteLine(intList[j].mDelta.ToString() + "\t" + intList[j].mIntegral + "\t" + intList[j].mName);
                        }
                    }
                }

                file.Close();
            }
        }

        private void Results_ResizeEnd(object sender, EventArgs e) {

        }

        private void Results_Resize(object sender, EventArgs e) {
            MainChart.Size = new Size(ClientSize.Width - 380, ClientSize.Height - 20);
        }

        private void ExistingMatrixRanges_SelectedIndexChanged(object sender, EventArgs e) {
            if (ExistingMatrixRanges.SelectedIndex >= 0 && ExistingMatrixRanges.SelectedIndex < ExistingMatrixRanges.Items.Count) {
                var range = (Range)ExistingMatrixRanges.Items[ExistingMatrixRanges.SelectedIndex];
                decimal from = (decimal)range.from;
                decimal to = (decimal)range.to;

                if (from > nudMatrixRangeFrom.Maximum) from = nudMatrixRangeFrom.Maximum;
                if (from < nudMatrixRangeFrom.Minimum) from = nudMatrixRangeFrom.Minimum;

                if (to > nudMatrixRangeTo.Maximum) to = nudMatrixRangeTo.Maximum;
                if (to < nudMatrixRangeTo.Minimum) to = nudMatrixRangeTo.Minimum;

                nudMatrixRangeFrom.Value = from;
                nudMatrixRangeTo.Value = to;
            }
        }

        private void Results_FormClosed(object sender, FormClosedEventArgs e) {
            StreamWriter file = new StreamWriter("materialranges.tbl");
            for (int i = 0; i < ExistingMaterialRanges.Items.Count; ++i) {
                file.WriteLine(((Range)ExistingMaterialRanges.Items[i]).from.ToString() + " " + ((Range)ExistingMaterialRanges.Items[i]).to.ToString());
            }
            file.Close();
            file = new StreamWriter("matrixranges.tbl");
            for (int i = 0; i < ExistingMatrixRanges.Items.Count; ++i) {
                file.WriteLine(((Range)ExistingMatrixRanges.Items[i]).from.ToString() + " " + ((Range)ExistingMatrixRanges.Items[i]).to.ToString());
            }
            file.Close();
        }

        private void ExistingMaterialRanges_SelectedIndexChanged(object sender, EventArgs e) {
            if (ExistingMaterialRanges.SelectedIndex >= 0 && ExistingMaterialRanges.SelectedIndex < ExistingMaterialRanges.Items.Count) {
                var range = (Range)ExistingMaterialRanges.Items[ExistingMaterialRanges.SelectedIndex];
                nudMaterialRangeFrom.Value = (decimal)range.from;
                if (!range.mSingleLine) {
                    nudMaterialRangeTo.Value = (decimal)range.to;
                }
            }
        }

        private void SortByAverage_Click(object sender, EventArgs e) {
            mRelativeIntegralList.Sort(new IntListComparer());
            UpdateChart();
        }

        private void XMaterialNumber_CheckedChanged(object sender, EventArgs e) {
            UpdateChart();
        }

        private void XDelta_CheckedChanged(object sender, EventArgs e) {
            UpdateChart();
        }

        private void LoadIntegrals_Click(object sender, EventArgs e) {

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

        private void btnLinearFitting_Click(object sender, EventArgs e) {
            double a = 0, b = 0;

            List<LinePoint> points = new List<LinePoint>();
            for (int i = 0; i < mRelativeIntegralList.Count; ++i) {
                points.Add(new LinePoint(i, mRelativeIntegralList[i].mAverage));
            }
            LinearApproximation(points, ref a, ref b);

            UpdateChart();

            // plot linear approx
            string name = "Linear Fitting";
            MainChart.Series.Add(name);
            MainChart.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

            for (int i = 0; i < mRelativeIntegralList.Count; ++i) {
                double x = i;
                double y = a * x + b;
                MainChart.Series[name].Points.AddXY(x, y);
            }

            double slope = ComputeSlope(a, b);
            double angle = Math.Atan(slope);

            lblSlope.Text = (angle * 180.0 / Math.PI).ToString();
        }

        private void btnPartialSave_Click(object sender, EventArgs e) {
            SaveAsTableDialog.Filter = "Table|*.txt";
            SaveAsTableDialog.Title = "Save as table...";
            SaveAsTableDialog.ShowDialog();

            if (SaveAsTableDialog.FileName != "") {
                System.IO.FileStream fs = (System.IO.FileStream)SaveAsTableDialog.OpenFile();

                System.IO.StreamWriter file = new System.IO.StreamWriter(fs);

                file.WriteLine("Matrix ranges");
                for (int i = 0; i < MatrixRanges.Items.Count; ++i) {
                    var range = (Range)MatrixRanges.Items[i];
                    file.WriteLine(range.from + "\t" + range.to);
                }

                file.WriteLine("Material ranges");
                for (int i = 0; i < MaterialRanges.Items.Count; ++i) {
                    var range = (Range)MaterialRanges.Items[i];
                    file.WriteLine(range.from + "\t" + range.to);
                }
                file.WriteLine("Measurement\tAverage\tStandard Deviation");
                for (int i = 0; i < mRelativeIntegralList.Count; ++i) {
                    file.WriteLine(i + "\t" + mRelativeIntegralList[i].mAverage + "\t" + mRelativeIntegralList[i].mStandardDeviation);
                }

                file.Close();
            }
        }

        private void chkMatrixUseSingleLine_CheckedChanged(object sender, EventArgs e) {
            if (chkMatrixUseSingleLine.Checked) {
                nudMatrixRangeTo.Enabled = false;
            } else {
                nudMatrixRangeTo.Enabled = true;
            }
        }

        private void chkMaterialUseSingleLine_CheckedChanged(object sender, EventArgs e) {
            if (chkMaterialUseSingleLine.Checked) {
                nudMaterialRangeTo.Enabled = false;
            } else {
                nudMaterialRangeTo.Enabled = true;
            }
        }

        private int GetClosestWavelengthMatchIndex(double wavelength) {
            int index = 0;
            for (int i = 0; i < mWavelengths.Value.Length; ++i) {
                if (Math.Abs(mWavelengths.Value[i] - wavelength) < Math.Abs(mWavelengths.Value[i] - mWavelengths.Value[index])) {
                    index = i;
                }
            }
            return index;
        }

        private void nudMatrixRangeFrom_ValueChanged(object sender, EventArgs e) {
            int index = GetClosestWavelengthMatchIndex((double)nudMatrixRangeFrom.Value);
            nudMatrixRangeFrom.Value = (decimal)mWavelengths.Value[index];
            //if (index > 0 && index < mWavelengths.Value.Length) {
            //    double av = ((mWavelengths.Value[index] - mWavelengths.Value[index - 1]) + (mWavelengths.Value[index] - mWavelengths.Value[index + 1])) / 2;
            //    nudMatrixRangeFrom.Increment = (decimal)av;
            //}
        }

        private void nudMaterialRangeFrom_ValueChanged(object sender, EventArgs e) {
            int index = GetClosestWavelengthMatchIndex((double)nudMaterialRangeFrom.Value);
            nudMaterialRangeFrom.Value = (decimal)mWavelengths.Value[index];
            //if (index > 0 && index < mWavelengths.Value.Length) {
            //    double av = ((mWavelengths.Value[index] - mWavelengths.Value[index - 1]) + (mWavelengths.Value[index] - mWavelengths.Value[index + 1])) / 2;
            //    nudMaterialRangeFrom.Increment = (decimal)av;
            //}
        }

        private void nudMatrixRangeTo_ValueChanged(object sender, EventArgs e) {
            int index = GetClosestWavelengthMatchIndex((double)nudMatrixRangeTo.Value);
            nudMatrixRangeTo.Value = (decimal)mWavelengths.Value[index];
            //if (index > 0 && index < mWavelengths.Value.Length) {
            //    double av = ((mWavelengths.Value[index] - mWavelengths.Value[index - 1]) + (mWavelengths.Value[index] - mWavelengths.Value[index + 1])) / 2;
            //    nudMatrixRangeTo.Increment = (decimal)av;
            //}
        }

        private void nudMaterialRangeTo_ValueChanged(object sender, EventArgs e) {
            int index = GetClosestWavelengthMatchIndex((double)nudMaterialRangeTo.Value);
            nudMaterialRangeTo.Value = (decimal)mWavelengths.Value[index];
            //if (index > 0 && index < mWavelengths.Value.Length) {
            //    double av = ((mWavelengths.Value[index] - mWavelengths.Value[index - 1]) + (mWavelengths.Value[index] - mWavelengths.Value[index + 1])) / 2;
            //    nudMaterialRangeTo.Increment = (decimal)av;
            //}
        }
    }
}

public class RelativeIntegral {
    public float mDelta;
    public double mIntegral;
    public string mName;

    public RelativeIntegral(double integral, float delta, string name) {
        mIntegral = integral;
        mDelta = delta;
        mName = name;
    }
}

public class RelativeIntegralList {
    public List<RelativeIntegral> mElements = new List<RelativeIntegral>();
    public int mMeasurementNumber = -1;
    public double mAverage;
    public double mStandardDeviation;
    public RelativeIntegralList() {

    }
}

public class IntListComparer : IComparer<RelativeIntegralList> {
    public int Compare(RelativeIntegralList x, RelativeIntegralList y) {
        if (x.mAverage > y.mAverage) {
            return 1;
        }
        if (x.mAverage < y.mAverage) {
            return -1;
        }
        return 0;
    }
}
