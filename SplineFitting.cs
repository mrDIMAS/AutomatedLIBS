using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace AutomatedLIBS {
    public partial class SplineFitting : Form {
        private List<Spectrum> mSpectra;
        public List<RawSpectrum> mSplines = new List<RawSpectrum>();
        public bool mApplyResult = false;

        public SplineFitting(List<Spectrum> spectra) {
            InitializeComponent();
            mSpectra = spectra;
            nudShowSpectrumNumber.Minimum = 1;
            nudShowSpectrumNumber.Maximum = spectra.Count;
            lblSpectrumCount.Text = spectra.Count.ToString();

            foreach(var spectrum in spectra) {
                mSplines.Add(spectrum.GetFittingSpline((int)nudSubdivisionsCount.Value));
            }
            
            UpdateChart();
        }

        void UpdateChart() {
            chrMainChart.Series.Clear();
            int number = (int)nudShowSpectrumNumber.Value - 1;
            PlotSpectrum(mSpectra[number], number);
            PlotSpline(mSplines[number], number);
        }

        void PlotSpectrum(Spectrum spec, int n) {
            var name = "Spectrum " + n;
            var series = chrMainChart.Series.Add(name);
            series.ChartType = SeriesChartType.FastLine;
            for (int i = 0; i < spec.mAbsoluteIntensities.Value.Count(); ++i) {
                series.Points.AddXY(Math.Round(spec.mWaveLengths.Value[i], 2), spec.mAbsoluteIntensities.Value[i]);
            }           
        }

        void PlotSpline(RawSpectrum spec, int n) {
            var name = "Spline " + n;
            var series = chrMainChart.Series.Add(name);
            series.ChartType = SeriesChartType.FastLine;
            for (int i = 0; i < spec.mAbsoluteIntensities.Count; ++i) {
                series.Points.AddXY(Math.Round(spec.mWavelengths[i], 2), spec.mAbsoluteIntensities[i]);
            }
        }

        private void SplineFitting_Load(object sender, EventArgs e) {

        }

        private void nudShowSpectrumNumber_ValueChanged(object sender, EventArgs e) {
            UpdateChart();
        }

        private void nudSubdivisionsCount_ValueChanged(object sender, EventArgs e) {
            for (int i = 0; i < mSpectra.Count; ++i) {
                mSplines[i] = mSpectra[i].GetFittingSpline((int)nudSubdivisionsCount.Value);
            }
            UpdateChart();
        }

        private void SplineFitting_Resize(object sender, EventArgs e) {
            int px = 20;
            int py = 50;

            if (ClientSize.Width > px && ClientSize.Height > py) {
                chrMainChart.Size = new Size(ClientSize.Width - px, ClientSize.Height - py);
            }
        }

        private void btnApply_Click(object sender, EventArgs e) {
            mApplyResult = true;
            Close();
        }

        private void btnSaveSplines_Click(object sender, EventArgs e) {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK) {
                var basePath = dlg.SelectedPath;
                if (basePath != "") {
                    for (int i = 0; i < mSplines.Count; ++i) {
                        StreamWriter s = new StreamWriter(basePath + "/" + "spline" + i + ".txt");
                        for(int j = 0; j < mSplines[i].mAbsoluteIntensities.Count; ++j) {
                            s.WriteLine(mSplines[i].mWavelengths[j] + "\t" + mSplines[i].mAbsoluteIntensities[j]);
                        }
                        s.Close();
                    }
                }
            }
        }
    }
}
