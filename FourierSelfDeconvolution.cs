using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutomatedLIBS {
    public partial class FourierSelfDeconvolution : Form {
        private List<Spectrum> mSpectra;
        public List<RawSpectrum> mDeconvolutedSpectra = new List<RawSpectrum>();
        private List<RawSpectrum> mFourierTransforms = new List<RawSpectrum>();
        private List<RawSpectrum> mFittingCurves = new List<RawSpectrum>();
        private List<RawSpectrum> mModifiedFourierTransforms = new List<RawSpectrum>();

        public bool mApply = false;

        public FourierSelfDeconvolution(List<Spectrum> spectra) {
            mSpectra = spectra;
            InitializeComponent();
            nudSpectrumNumber.Minimum = 1;
            nudSpectrumNumber.Maximum = spectra.Count;
        }

        // J.K. Kauppinen, 1981
        private double InverseFourierTransformOfLorentzianProfile(double widthAtHalfHeight, double x) {
            return Math.Exp(-widthAtHalfHeight * 2 * Math.PI * Math.Abs(x));
        }

        private double ExponentialDeconvolution(double L, double x) {
            return Math.Exp(-2 * Math.PI * Math.Abs(x) / L);
        }

        private double Apodization(double L, double x) {
            if (Math.Abs(x) <= L) {
                return 1.0 - Math.Abs(x) / L;
            } else {
                return 0;
            }
        }

        private double BlackmanNutallApodization(double L, double n) {
            double a0 = 0.3635819;
            double a1 = 0.4891775;
            double a2 = 0.1365995;
            double a3 = 0.0106411;

            return a0 - a1 * Math.Cos(2 * Math.PI * n / (L - 1)) + a2 * Math.Cos(4 * Math.PI * n / (L - 1)) + a3 * Math.Cos(6 * Math.PI * n / (L - 1));
        }

        private RawSpectrum ExponentialFitting(RawSpectrum spectrum) {
            int n = spectrum.mAbsoluteIntensities.Count;
            var x = spectrum.mWavelengths;
            var y = spectrum.mAbsoluteIntensities;

            double xsum = 0, x2sum = 0, ysum = 0, xysum = 0;
            for (int i = 0; i < n; ++i) {
                if (y[i] > 0) {
                    double lny = Math.Log(y[i]);
                    xsum += x[i];
                    ysum += lny;
                    x2sum += x[i] * x[i];
                    xysum += x[i] * lny;
                }
            }

            double a = (n * xysum - xsum * ysum) / (n * x2sum - xsum * xsum);
            double b = (x2sum * ysum - xsum * xysum) / (x2sum * n - xsum * xsum);
            double c = Math.Exp(b);

            var fittingCurve = new RawSpectrum();

            for (int i = 0; i < n; ++i) {
                fittingCurve.mWavelengths.Add(x[i]);
                fittingCurve.mAbsoluteIntensities.Add(c * Math.Exp(a * x[i]));
            }

            return fittingCurve;
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            double ka = (double)nudFWHM.Value;

            // remove all computed curves
            mDeconvolutedSpectra.Clear();
            mFourierTransforms.Clear();
            mModifiedFourierTransforms.Clear();
            mFittingCurves.Clear();



            foreach (var experimentalSpectrum in mSpectra) {
                // define cutoff position using narrowing factor
                int cutoffPosition = (int)(experimentalSpectrum.mAbsoluteIntensities.Value.Length / (double)nudNarrowingFactor.Value);

                // absolute intensities alias
                var spectrum = experimentalSpectrum.mAbsoluteIntensities.Value;

                // copy spectrum absolute intensities into array of complex numbers
                Complex[] cdata = new Complex[spectrum.Length];
                for (int i = 0; i < spectrum.Length; ++i) {
                    cdata[i] = spectrum[i];
                }

                // do inverse fourier transform to go to time domain
                FourierTransform.DFT(cdata, FourierTransform.Direction.Backward);

                // add inverse fourier transform plot to the fourier chart
                var fourierTransform = new RawSpectrum();
                for (int i = 0; i < spectrum.Length; ++i) {
                    fourierTransform.mAbsoluteIntensities.Add(cdata[i].Real);
                    fourierTransform.mWavelengths.Add(i);
                }
                mFourierTransforms.Add(fourierTransform);

                // deconvolve exponential decay
                for (int i = 0; i < spectrum.Length; ++i) {
                    cdata[i] /= ExponentialDeconvolution(cutoffPosition * ka, i);
                }

                // apply apodization function
                double constantScaler = 2.0f;
                for (int i = 0; i < spectrum.Length; ++i) {
                    double a = Apodization(cutoffPosition, i);
                    cdata[i] *= a * a * constantScaler;
                }

                // add modified fourier transform plot to the fourier chart
                var modifiedFourierTransform = new RawSpectrum();
                for (int i = 0; i < spectrum.Length; ++i) {
                    modifiedFourierTransform.mAbsoluteIntensities.Add(cdata[i].Real);
                    modifiedFourierTransform.mWavelengths.Add(i);
                }
                mModifiedFourierTransforms.Add(modifiedFourierTransform);

                // do forward fourier transform to go back to frequency domain
                FourierTransform.DFT(cdata, FourierTransform.Direction.Forward);

                // add deconvolved spectrum to the chart
                var deconvolution = new RawSpectrum();
                for (int i = 0; i < spectrum.Length; ++i) {
                    deconvolution.mAbsoluteIntensities.Add(cdata[i].Real);
                    deconvolution.mWavelengths.Add(experimentalSpectrum.mWaveLengths.Value[i]);
                }
                mDeconvolutedSpectra.Add(deconvolution);
            }
            UpdateChart();
        }

        void UpdateChart() {
            chrMainChart.Series.Clear();
            chrFourierTransform.Series.Clear();
            int number = (int)nudSpectrumNumber.Value - 1;
            PlotSpectrum(mSpectra[number], number);
            PlotDeconvolution(mDeconvolutedSpectra[number], number, "Deconvolution");
            PlotFourierTransform(mFourierTransforms[number], number, "Fourier Transform");
            PlotFourierTransform(mModifiedFourierTransforms[number], number, "Modified Fourier Transform");
        }

        void PlotSpectrum(Spectrum spec, int n) {
            var name = "Spectrum " + n;
            var series = chrMainChart.Series.Add(name);
            series.ChartType = SeriesChartType.FastLine;
            for (int i = 0; i < spec.mAbsoluteIntensities.Value.Length; ++i) {
                series.Points.AddXY(Math.Round(spec.mWaveLengths.Value[i], 2), spec.mAbsoluteIntensities.Value[i]);
            }
        }

        void PlotDeconvolution(RawSpectrum spec, int n, string name) {
            var series = chrMainChart.Series.Add(name);
            series.ChartType = SeriesChartType.FastLine;
            for (int i = 0; i < spec.mAbsoluteIntensities.Count; ++i) {
                series.Points.AddXY(Math.Round(spec.mWavelengths[i], 2), spec.mAbsoluteIntensities[i]);
            }
        }

        void PlotFourierTransform(RawSpectrum spec, int n, string name) {
            var series = chrFourierTransform.Series.Add(name);
            series.ChartType = SeriesChartType.FastLine;
            for (int i = 0; i < spec.mAbsoluteIntensities.Count; ++i) {
                series.Points.AddXY(Math.Round(spec.mWavelengths[i], 2), spec.mAbsoluteIntensities[i]);
            }
        }

        private void FourierSelfDeconvolution_Resize(object sender, EventArgs e) {
            int px = 20;
            int py = 50;

            if (ClientSize.Width > px && ClientSize.Height > py) {
                chrMainChart.Size = new Size(ClientSize.Width / 2, ClientSize.Height - py);
                chrFourierTransform.Location = new Point(ClientSize.Width / 2 + px, chrFourierTransform.Location.Y);
                chrFourierTransform.Size = new Size(ClientSize.Width / 2 - 2 * px, ClientSize.Height - py);
            }
        }

        private void btnApplyAndClose_Click(object sender, EventArgs e) {
            Close();
            mApply = true;
        }
    }
}
