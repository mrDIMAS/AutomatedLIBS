using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C_Sharp_Application;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
using System.Numerics;

////////////////////////////////////////////////////////////////////////////////////////////////////
// WARNING! Grim code ahead :)
namespace AutomatedLIBS {
    public partial class MainWindow : Form {
        // Spectrometer Stuff
        // AVS Window Messages
        private const int WM_USER = 0x400;
        private const int WM_MEAS_READY = WM_USER + 1;
        private const int WM_DBG_INFOAs = WM_USER + 2;
        private const int WM_DEVICE_RESET = WM_USER + 3;
        private IntPtr mSpectrometerHandle;

        private Spectrum mCurrentSpectrum;
        private avaspec.SaturatedArrayType mSaturated;
        private double mIrradianceIntTime;
        private double[] mIrradianceCalCoeff;
        public static int mSpectrometerPixelsCount;
        private bool mSpectrometerConnected = false;

        private int mMeasureCount = 0;
        private bool mPaused = false;
        private float mIntegrationDelay = 0.0f;
        private List<Range> mLinearIntervals;
        public static List<Experiment> mExperiments;
        private List<Ion> mIonsBase = new List<Ion>();
        Dictionary<string, CheckBox> mElements;
        public Spectrum mCalibration;
        public Dictionary<string, double> mMolecules = new Dictionary<string, double>();
        private Experiment mCurrentExperiment = null;
        List<Peak> mEmissionPeaks = new List<Peak>();
        BackgroundWorker mAsyncLoader = new BackgroundWorker();
        private string[] mFilesToLoad;
        private LoadingScreen mLoadingScreen;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AVSCheckError(int errorCode) {
            if (errorCode < 0) {
                MessageBox.Show("Error " + errorCode.ToString(), "Automated LIBS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public MainWindow() {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e) {
            int errorCode = avaspec.AVS_Init(0);
            AVSCheckError(errorCode);

            Pause.Enabled = false;
            Stop.Enabled = false;
            nudIntegrationEndDelay.Enabled = !SingleMeasure.Enabled;

            avaspec.AVS_Register(this.Handle);

            Material.LoadBaseFromFile();

            mLinearIntervals = new List<Range>();
            mExperiments = new List<Experiment>();
            for (int i = 0; i < 1000; ++i) {
                mExperiments.Add(new Experiment());
            }
            nudMeasurementNumber.Maximum = mExperiments.Count;

            mCurrentExperiment = mExperiments[0];

            MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            mElements = new Dictionary<string, CheckBox>() {
                { "H", chkHydrogen },
                { "He", chkHelium },
                { "Li", chkLithium },
                { "Be", chkBerillium },
                { "B", chkBorum },
                { "C", chkCarboneum },
                { "N", chkNitrogenium },
                { "O", chkOxygenium },
                { "F", chkFluorum },
                { "Ne", chkNeon },
                { "Na", chkNatrium },
                { "Mg", chkMagnesium },
                { "Al", chkAluminium },
                { "Si", chkSilicium },
                { "P", chkPhosphorus },
                { "S", chkSulfur },
                { "Cl", chkChlorum },
                { "Ar", chkArgon },
                { "K", chkKalium },
                { "Ca", chkCalcium },
                { "Sc", chkScandium },
                { "Ti", chkTitanium },
                { "V", chkVanadium },
                { "Cr", chkChromium },
                { "Mn", chkManganum },
                { "Fe", chkFerrum },
                { "Co", chkCobaltum },
                { "Ni", chkNiccolum },
                { "Cu", chkCuprum },
                { "Zn", chkZincum },
                { "Ga", chkGallium },
                { "Ge", chkGermanium },
                { "As", chkArsenicum },
                { "Se", chkSelenium },
                { "Br", chkBromum },
                { "Kr", chkKrypton },
                { "Rb", chkRubidium },
                { "Sr", chkStrontium },
                { "Y", chkYttrium },
                { "Zr", chkZirconium },
                { "Nb", chkNiobium },
                { "Mo", chkMolybdaenum },
                { "Tc", chkTechnetium },
                { "Ru", chkRuthenium },
                { "Rh", chkRhodium },
                { "Pd", chkPalladium },
                { "Ag", chkArgentum },
                { "Cd", chkCadmium },
                { "In", chkIndium },
                { "Sn", chkStannum },
                { "Sb", chkStibium },
                { "Te", chkTellurium },
                { "I", chkIodum },
                { "Xe", chkXenon },
                { "Cs", chkCaesium },
                { "Ba", chkBarium },
                { "La", chkLanthanum },
                { "Ce", chkCerium },
                { "Pr", chkPraseodymium },
                { "Nd", chkNeodymium },
                { "Pm", chkPromethium },
                { "Sm", chkSamarium },
                { "Eu", chkEuropium },
                { "Gd", chkGadolinium },
                { "Tb", chkTerbium },
                { "Dy", chkDysprosium },
                { "Ho", chkHolmium },
                { "Er", chkErbium },
                { "Tm", chkThulium },
                { "Yb", chkYtterbium },
                { "Lu", chkLutetium },
                { "Hf", chkHafnium },
                { "Ta", chkTantalum },
                { "W", chkWolframium },
                { "Re", chkRhenium },
                { "Os", chkOsmium },
                { "Ir", chkIridium },
                { "Pt", chkPlatinum },
                { "Au", chkAurum },
                { "Hg", chkHydrargyrum },
                { "Tl", chkThallium },
                { "Pb", chkPlumbum },
                { "Bi", chkBismuthum },
                { "Po", chkPolonium },
                { "At", chkAstatium },
                { "Rn", chkRadon },
                { "U", chkUranium }
                // add rest of radioactive elements if needed
            };

            // load base
            var baseFile = new StreamReader("base.tbl");

            while (!baseFile.EndOfStream) {

                var token = baseFile.ReadLine().Split('\t');
                float obsWavelength = 0.0f;
                float relInt = 0.0f;
                float transitionStrenght = 0.0f;

                if (token[0].Contains("Na")) {
                    int efs = 0;
                }

                // if element found, enable check box of it
                for (int i = 0; i < token[0].Count(); ++i) {
                    if (token[0][i] == ' ') {
                        var el = token[0].Substring(0, i);
                        if (mElements.ContainsKey(el)) {
                            var element = mElements[el];
                            if (element != null) {
                                element.Enabled = true;
                            }
                            break;
                        }
                    }
                }

                float.TryParse(token[1], out obsWavelength);
                float.TryParse(token[2], out relInt);

                var ion = new Ion(token[0], obsWavelength, relInt, token[3]);
                float.TryParse(token[5], out ion.mEi);
                float.TryParse(token[7], out ion.mEk);
                if (token.Count() > 16) {
                    int.TryParse(token[14], out ion.mgi);
                    int.TryParse(token[16], out ion.mgk);
                }
                mIonsBase.Add(ion);
            }

            baseFile.Close();

            lblLinesInBase.Text = mIonsBase.Count.ToString();

            // setup async workers
            bgwIdentification.ProgressChanged += IdentificationProgressChanged;
            bgwIdentification.RunWorkerCompleted += IdentificationDone;

            mAsyncLoader.WorkerReportsProgress = true;
            mAsyncLoader.DoWork += AsyncSpectraLoaderDoWork;
            mAsyncLoader.RunWorkerCompleted += AsyncSpectraLoaderDone;
            mAsyncLoader.ProgressChanged += AsyncSpectraLoaderProgress;

            clbAdditionalSpectraPlot.DisplayMember = "ShortName"; // calls Name method of Spectra class

            LoadIrradianceCalibrationFromFile("irradiance.cal", true);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DisconnectSpectrometer() {
            if (mSpectrometerConnected) {
                int errorCode = (int)avaspec.AVS_Deactivate(mSpectrometerHandle);
                AVSCheckError(errorCode);
                mSpectrometerConnected = false;
                StartPause.Enabled = false;
                Pause.Enabled = false;
                Stop.Enabled = false;
                connectToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            DisconnectSpectrometer();

            int errorCode = avaspec.AVS_Done();
            AVSCheckError(errorCode);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) {
            Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
            if (mSpectrometerConnected == false) {
                int deviceCount = avaspec.AVS_GetNrOfDevices();
                if (deviceCount > 0) {
                    uint reqSize = ((uint)deviceCount) * (uint)Marshal.SizeOf(typeof(avaspec.AvsIdentityType));

                    avaspec.AvsIdentityType[] id = new avaspec.AvsIdentityType[deviceCount];

                    int errorCode = avaspec.AVS_GetList(reqSize, ref reqSize, id);
                    AVSCheckError(errorCode);

                    if (id[0].m_Status == avaspec.DEVICE_STATUS.USB_AVAILABLE) {
                        mSpectrometerHandle = avaspec.AVS_Activate(ref id[0]);

                        ushort numberOfPixels = 0;
                        errorCode = (int)avaspec.AVS_GetNumPixels(mSpectrometerHandle, ref numberOfPixels);
                        AVSCheckError(errorCode);

                        mSpectrometerPixelsCount = numberOfPixels;

                        mSpectrometerConnected = true;

                        StatusText.Text = "Connection established!";

                        StartPause.Enabled = true;
                        disconnectToolStripMenuItem.Enabled = true;
                        connectToolStripMenuItem.Enabled = false;
                    } else {
                        MessageBox.Show("Spectrometer already in use!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        bool IsSpectrumLinear() {
            double zeroLevel = 0;
            foreach (var val in mCurrentSpectrum.mAbsoluteIntensities.Value) {
                zeroLevel += val;
            }
            zeroLevel /= mCurrentSpectrum.mAbsoluteIntensities.Value.Count();
            zeroLevel *= 2;

            int maxLineWidth = 20;
            bool isLinear = false;
            int lastZeroPoint = -1;
            int goodCount = 0;
            int linearThreshold = 3;
            int linearCount = 0;
            mLinearIntervals.Clear();
            for (int i = 0; i < mCurrentSpectrum.mAbsoluteIntensities.Value.Count(); ++i) {
                if (lastZeroPoint < 0) {
                    if (mCurrentSpectrum.mAbsoluteIntensities.Value[i] > zeroLevel) {
                        lastZeroPoint = i;
                        goodCount = 0;
                    }
                } else {
                    if (mCurrentSpectrum.mAbsoluteIntensities.Value[i] > zeroLevel) {
                        ++goodCount;
                    } else {
                        if (goodCount <= maxLineWidth) {
                            ++linearCount;

                            mLinearIntervals.Add(new Range(mCurrentSpectrum.mWaveLengths.Value[lastZeroPoint], mCurrentSpectrum.mWaveLengths.Value[i]));

                            lastZeroPoint = -1;
                            goodCount = 0;

                            if (linearCount > linearThreshold) {
                                isLinear = true;
                            }
                        }
                    }
                }
            }
            return isLinear;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SmoothSpectrum(Spectrum spec) {


            double[] gaussian = { 0.000003, 0.000229, 0.005977, 0.060598, 0.24173, 0.382925, 0.24173, 0.060598, 0.005977, 0.000229, 0.000003 };
            double[] values = new double[spec.mAbsoluteIntensities.Value.Count()];

            int window = 2;
            for (int i = 0; i < spec.mAbsoluteIntensities.Value.Count(); ++i) {
                int count = 0;
                double average = 0.0f;
                for (int k = -window; k < window; ++k) {
                    int index = i + k;
                    if (index < spec.mAbsoluteIntensities.Value.Count() && index >= 0) {
                        average += gaussian[6 + k] * spec.mAbsoluteIntensities.Value[index];
                        ++count;
                    }
                }
                //average /= (double)count;
                values[i] = average;
            }

            spec.mAbsoluteIntensities.Value = values;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private double CalculateIntegral(Spectrum spec, double from, double to) {
            int indexFrom = 0;
            int indexTo = 0;

            var wavelenghts = spec.mWaveLengths.Value;
            for (int i = 0; i < spec.mAbsoluteIntensities.Value.Count(); ++i) {
                if ((int)wavelenghts[i] == (int)from) {
                    indexFrom = i;
                }
                if ((int)wavelenghts[i] == (int)to) {
                    indexTo = i;
                }
            }

            double integral = 0.0;

            for (int i = indexFrom; i < indexTo; ++i) {
                integral += spec.mAbsoluteIntensities.Value[i];
            }

            return integral;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DoMeasure() {
            avaspec.MeasConfigType measData = new avaspec.MeasConfigType();

            double integrationDelay_ns = mIntegrationDelay * 1000.0;
            uint integrationDelay = (uint)(6.0 * (integrationDelay_ns + 20.84) / 125.0);

            measData.m_StartPixel = 0;
            measData.m_StopPixel = (ushort)(mSpectrometerPixelsCount - 1);
            measData.m_IntegrationTime = (float)IntegrationTime.Value;

            measData.m_IntegrationDelay = integrationDelay;
            measData.m_NrAverages = 1;

            measData.m_Trigger.m_Mode = 0;
            measData.m_Trigger.m_Source = 1;
            measData.m_Trigger.m_SourceType = 0;

            measData.m_SaturationDetection = 1;

            measData.m_CorDynDark.m_Enable = 1;
            measData.m_CorDynDark.m_ForgetPercentage = 0;

            measData.m_Smoothing.m_SmoothPix = 0;
            measData.m_Smoothing.m_SmoothModel = 0;
            measData.m_Control.m_StrobeControl = 0;

            double laserDelay_ns = (double)LaserDelay.Value * 1000000.0;
            uint laserDelay = (uint)(6.0 * laserDelay_ns / 125.0);
            measData.m_Control.m_LaserDelay = laserDelay;

            double laserWidth_ns = (double)LaserWidth.Value * 1000000.0f;
            uint laserWidth = (uint)(6.0 * laserWidth_ns / 125.0);
            measData.m_Control.m_LaserWidth = laserWidth;

            measData.m_Control.m_LaserWaveLength = 532.0f;
            measData.m_Control.m_StoreToRam = 0;

            int errorCode = (int)avaspec.AVS_PrepareMeasure(mSpectrometerHandle, ref measData);
            AVSCheckError(errorCode);

            errorCode = (int)avaspec.AVS_Measure(mSpectrometerHandle, this.Handle, 1);
            AVSCheckError(errorCode);

            ++mMeasureCount;

            if (SeriesMeasure.Checked) {
                float step = (float)(nudIntegrationEndDelay.Value - nudIntegrationBeginDelay.Value) / (float)MeasurementCount.Value;
                mIntegrationDelay += step;
            } else {
                mIntegrationDelay = (float)nudPowerSupplyLag.Value + (float)nudIntegrationBeginDelay.Value;
            }

            StatusText.Text = "Doing measurement...";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        protected override void WndProc(ref Message message) {
            if (message.Msg == WM_MEAS_READY) {
                uint timeLabel = 0;

                avaspec.PixelArrayType avsSpectrum = new avaspec.PixelArrayType();
                int errorCode = avaspec.AVS_GetScopeData(mSpectrometerHandle, ref timeLabel, ref avsSpectrum);
                AVSCheckError(errorCode);

                avaspec.PixelArrayType avsWavelenghts = new avaspec.PixelArrayType();
                errorCode = (int)avaspec.AVS_GetLambda(mSpectrometerHandle, ref avsWavelenghts);
                AVSCheckError(errorCode);

                errorCode = (int)avaspec.AVS_GetSaturatedPixels(mSpectrometerHandle, ref mSaturated);
                AVSCheckError(errorCode);

                int saturatedCount = 0;
                if (mSaturated.Value != null) {
                    for (int i = 0; i < mSaturated.Value.Count(); ++i) {
                        if (mSaturated.Value[i] > 0) {
                            ++saturatedCount;
                        }
                    }
                }

                // crop arrays
                avaspec.PixelArrayType wavelengths = new avaspec.PixelArrayType(); wavelengths.Value = new double[mSpectrometerPixelsCount];
                avaspec.PixelArrayType spectrum = new avaspec.PixelArrayType(); spectrum.Value = new double[mSpectrometerPixelsCount];
                for (int i = 0; i < mSpectrometerPixelsCount; ++i) {
                    wavelengths.Value[i] = avsWavelenghts.Value[i];
                    spectrum.Value[i] = avsSpectrum.Value[i];
                }


                mCurrentSpectrum = new Spectrum(spectrum, wavelengths, mIntegrationDelay);
                mCurrentExperiment.mSpectra.Add(mCurrentSpectrum);
                CalibrateSpectrum(mCurrentSpectrum);
                mCurrentSpectrum.mName = "Spectrum " + mCurrentExperiment.mSpectra.Count;
                StatusText.Text = "Measurement done!";

                UpdateChart();

                if (mMeasureCount < (int)MeasurementCount.Value && !mPaused) {
                    DoMeasure();
                } else {
                    if (!mPaused) {
                        nudSpectrumNumber.Enabled = true;
                        StartPause.Enabled = true;
                        mPaused = false;
                        Pause.Enabled = false;
                        Stop.Enabled = false;
                    }
                }
                nudSpectrumNumber.Maximum = mCurrentExperiment.mSpectra.Count;
                nudSpectrumNumber.Value = nudSpectrumNumber.Maximum;

                pbExperimentProgress.Value = (int)((float)pbExperimentProgress.Maximum * (mMeasureCount / (float)MeasurementCount.Value));
            } else {
                base.WndProc(ref message);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DoMaterialRecognition() {
            if (mCurrentSpectrum != null) {
                Material maxIntegralMaterial = null;
                double maxIntegral = 0.0;
                double totalIntegral = CalculateIntegral(mCurrentSpectrum, mCurrentSpectrum.mWaveLengths.Value[0], mCurrentSpectrum.mWaveLengths.Value[mSpectrometerPixelsCount - 1]);
                foreach (var material in Material.All) {
                    double linesIntegral = 0.0;
                    foreach (var range in material.mRanges) {
                        linesIntegral += CalculateIntegral(mCurrentSpectrum, range.from, range.to);
                    }

                    double ratio = linesIntegral / totalIntegral;
                    if (ratio > maxIntegral) {
                        maxIntegral = ratio;
                        maxIntegralMaterial = material;
                    }
                }

                if (maxIntegral >= (double)DetectionThreshold.Value) {
                    DetectedMaterial.Text = maxIntegralMaterial.mName;
                } else {
                    DetectedMaterial.Text = "Unknown Material";
                }

                SpectrumLinear.Text = IsSpectrumLinear() ? "Spectrum Linear" : "Spectrum Non-Linear";
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e) {
            DisconnectSpectrometer();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Form1_Resize(object sender, EventArgs e) {
            float scale = 1.00f;

            int px = (int)(260 * scale);
            int py = (int)(50 * scale);

            if (ClientSize.Width > px && ClientSize.Height > py) {
                mMainChart.Size = new Size(ClientSize.Width - px, ClientSize.Height - py);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SingleMeasure_CheckedChanged(object sender, EventArgs e) {
            nudIntegrationEndDelay.Enabled = !SingleMeasure.Checked;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void StartPause_Click(object sender, EventArgs e) {
            if (mCurrentExperiment.mSpectra.Count > 0) {
                if (chkAskMeBeforeNewExp.Checked) {
                    if (MessageBox.Show("Current Experiment already contains spectra, if you continue all spectra will be discarded! Do you wish to continue", "Question", MessageBoxButtons.YesNo) == DialogResult.No) {
                        return;
                    }
                }
            }
            mCurrentExperiment.mSpectra.Clear();
            if (!mPaused) {
                mMeasureCount = 0;
                mIntegrationDelay = (float)nudIntegrationBeginDelay.Value + (float)nudPowerSupplyLag.Value;
                nudSpectrumNumber.Value = nudSpectrumNumber.Minimum;
            }
            nudSpectrumNumber.Enabled = false;
            mPaused = false;
            DoMeasure();
            Pause.Enabled = true;
            StartPause.Enabled = false;
            Stop.Enabled = true;
            pbExperimentProgress.Value = pbExperimentProgress.Minimum;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Stop_Click(object sender, EventArgs e) {
            mMeasureCount = (int)MeasurementCount.Value;
            Pause.Enabled = false;
            Stop.Enabled = false;
            nudSpectrumNumber.Enabled = true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Pause_Click(object sender, EventArgs e) {
            mPaused = true;
            StartPause.Enabled = true;
            Pause.Enabled = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void configureToolStripMenuItem_Click(object sender, EventArgs e) {
            Materials materials = new Materials();
            materials.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void detectionInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            MaterialDetection md = new MaterialDetection();
            md.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SaveSpectrums_Click(object sender, EventArgs e) {
            var spectrums = mCurrentExperiment.mSpectra;
            if (spectrums.Count == 0) {
                MessageBox.Show("Nothing to save!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                if (SaveSpectrumDialog.ShowDialog() == DialogResult.OK) {
                    if (SaveSpectrumDialog.SelectedPath != "") {
                        try {
                            int n = 1;
                            foreach (Spectrum spectra in spectrums) {
                                string filename = spectra.mName;
                                // newly created spectra saved with order number
                                int slashPos = spectra.mName.LastIndexOf('\\');
                                if (slashPos < 0) {
                                    filename = "/spectrum_" + (n < 10 ? "0" + n.ToString() : n.ToString()) + ".spec";
                                } else { // existing spectra (i.e. loaded from file) - must be saved with same file name

                                    if (slashPos >= 0) {
                                        filename = spectra.mName.Substring(slashPos);
                                    }
                                }
                                System.IO.StreamWriter file = new System.IO.StreamWriter(SaveSpectrumDialog.SelectedPath + filename);
                                SaveSpectrumToFile(spectra, file);
                                file.Close();
                                ++n;
                            }
                            MessageBox.Show("Successfully saved " + spectrums.Count + " spectrums to " + SaveSpectrumDialog.SelectedPath + "!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch (Exception) {
                            MessageBox.Show("Unable to save spectra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MeasurementCount_ValueChanged(object sender, EventArgs e) {
            //SpectrumNumber.Maximum = MeasurementCount.Value;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void PlotSpectrum(Spectrum spec) {
            try {
                var name = spec.ShortName + " - " + mMainChart.Series.Count;
                mMainChart.Series.Add(name);
                for (int i = 0; i < spec.mAbsoluteIntensities.Value.Count(); ++i) {
                    double y = spec.mAbsoluteIntensities.Value[i];
                    if (chkEnableCalibratedYAxis.Checked && chkEnableCalibratedYAxis.Enabled) {
                        y = spec.mIrradiance.Value[i];
                    }
                    mMainChart.Series[name].Points.AddXY(Math.Round(spec.mWaveLengths.Value[i], 2), y);
                }
                mMainChart.Series[name].ChartType = SeriesChartType.FastLine;
                mMainChart.Series[name].LegendToolTip = "Spectrum: " + spec.mName + "; Delay: " + spec.mIntegrationDelayMicroSec + "μs";
                mMainChart.Series[name].ToolTip = "#VALX nm; #VALY a.u.";
            } catch (Exception) {
                MessageBox.Show("This spectrum is already plotted! Select another one", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void UpdateChart() {


            mMainChart.Annotations.Clear();
            mMainChart.Series.Clear();
            if (mCurrentSpectrum != null && mCurrentSpectrum.mAbsoluteIntensities.Value != null) {

                PlotSpectrum(mCurrentSpectrum);
                foreach (var s in mCurrentExperiment.mSpectra) {
                    if (s != mCurrentSpectrum && s.mPlot) {
                        PlotSpectrum(s);
                    }
                }

                // plot fitting curves
                foreach (var fc in mCurrentExperiment.mFittingCurves) {
                    PlotSpectrum(fc);
                }

                DoMaterialRecognition();

                lblSpectrumCount.Text = "of " + mCurrentExperiment.mSpectra.Count;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SpectrumNumber_ValueChanged(object sender, EventArgs e) {
            if (mCurrentExperiment.mSpectra.Count > 0) {
                if (nudSpectrumNumber.Value > 0) {
                    mCurrentSpectrum = mCurrentExperiment.mSpectra[(int)nudSpectrumNumber.Value - 1];
                }
            } else {
                nudSpectrumNumber.Value = nudSpectrumNumber.Minimum;
            }

            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void RemoveAllSpectrumsFromCurrentMeasurement() {
            clbAdditionalSpectraPlot.Items.Clear();
            mCurrentExperiment.mSpectra.Clear();
            nudSpectrumNumber.Maximum = 0;
            nudSpectrumNumber.Minimum = 0;
            nudSpectrumNumber.Value = 0;
            if (mCurrentSpectrum != null) {
                mCurrentSpectrum.mAbsoluteIntensities.Value = null;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void CleanCurrentExperiment() {
            RemoveAllSpectrumsFromCurrentMeasurement();
            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ClearSpectrums_Click(object sender, EventArgs e) {
            CleanCurrentExperiment();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SaveSpectrumToFile(Spectrum spec, System.IO.StreamWriter file) {
            file.WriteLine(spec.mIntegrationDelayMicroSec);
            file.WriteLine(spec.mAbsoluteIntensities.Value.Count());
            for (int i = 0; i < spec.mAbsoluteIntensities.Value.Count(); ++i) {
                file.WriteLine(spec.mWaveLengths.Value[i].ToString() + "\t" + spec.mAbsoluteIntensities.Value[i].ToString());
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SaveCurrentSpectrum_Click(object sender, EventArgs e) {
            if (mCurrentSpectrum == null) {
                return;
            }

            dlgSaveCurrentSpectrum.Filter = "Spectrum|*.spec";
            dlgSaveCurrentSpectrum.Title = "Save spectrum...";
            if (dlgSaveCurrentSpectrum.ShowDialog() == DialogResult.OK) {
                if (dlgSaveCurrentSpectrum.FileName != "") {
                    try {
                        System.IO.FileStream fs = (System.IO.FileStream)dlgSaveCurrentSpectrum.OpenFile();
                        System.IO.StreamWriter file = new System.IO.StreamWriter(fs);
                        SaveSpectrumToFile(mCurrentSpectrum, file);
                        file.Close();
                        fs.Close();
                        MessageBox.Show("Spectrum successfully saved to " + dlgSaveCurrentSpectrum.FileName + "!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch (Exception) {
                        MessageBox.Show("Unable to save spectrum!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MeasurementNumber_ValueChanged(object sender, EventArgs e) {
            mCurrentExperiment = mExperiments[(int)nudMeasurementNumber.Value - 1];

            nudSpectrumNumber.Value = nudSpectrumNumber.Minimum;
            nudSpectrumNumber.Maximum = mCurrentExperiment.mSpectra.Count;

            if (mCurrentExperiment.mSpectra.Count > 0) {
                nudSpectrumNumber.Value = 1;
                nudSpectrumNumber.Minimum = 1;
                if (nudSpectrumNumber.Value > 0) {
                    mCurrentSpectrum = mCurrentExperiment.mSpectra[(int)nudSpectrumNumber.Value - 1];
                }
            }
            gbMeasurementResultsGroup.Text = "Experiment " + nudMeasurementNumber.Value + " Actions";
            if (mCurrentSpectrum != null) {
                CalibrateSpectrum(mCurrentSpectrum);
            }
            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Normalize_Click(object sender, EventArgs e) {
            foreach (var spec in mCurrentExperiment.mSpectra) {
                // calculate integral
                double integral = 0.0;
                for (int k = 0; k < spec.mAbsoluteIntensities.Value.Count(); ++k) {
                    integral += spec.mAbsoluteIntensities.Value[k];
                }
                // normalize
                for (int k = 0; k < spec.mAbsoluteIntensities.Value.Count(); ++k) {
                    spec.mAbsoluteIntensities.Value[k] /= integral;
                }
            }

            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            About about = new About();
            about.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void UpdateExperiment() {
            nudSpectrumNumber.Maximum = mCurrentExperiment.mSpectra.Count;
            nudSpectrumNumber.Value = nudSpectrumNumber.Maximum;

            UpdateChart();

            bool sameDelay = true;
            for (int i = 0; i < mCurrentExperiment.mSpectra.Count; ++i) {
                if (mCurrentExperiment.mSpectra[i].mIntegrationDelayMicroSec != mCurrentExperiment.mSpectra[0].mIntegrationDelayMicroSec) {
                    sameDelay = false;
                    break;
                }
            }

            if (!sameDelay) {
                mCurrentExperiment.mSpectra.Sort();
            }

            clbAdditionalSpectraPlot.Items.Clear();
            foreach (var spec in mCurrentExperiment.mSpectra) {
                clbAdditionalSpectraPlot.Items.Add(spec);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AddNewSpectrumToCurrentMeasurement(Spectrum newSpectrum) {
            mCurrentExperiment.mSpectra.Add(newSpectrum);
            mCurrentSpectrum = newSpectrum;
            CalibrateSpectrum(mCurrentSpectrum); // overhead
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Spectrum LoadSpectrumFromFile(System.IO.FileStream fs) {
            System.IO.StreamReader file = new System.IO.StreamReader(fs);

            Spectrum newSpectrum = new Spectrum();
            newSpectrum.mName = fs.Name;
            newSpectrum.mAbsoluteIntensities = new avaspec.PixelArrayType();
            newSpectrum.mIntegrationDelayMicroSec = System.Convert.ToSingle(file.ReadLine());
            mSpectrometerPixelsCount = System.Convert.ToInt32(file.ReadLine());

            newSpectrum.mAbsoluteIntensities.Value = new double[mSpectrometerPixelsCount];
            newSpectrum.mWaveLengths.Value = new double[mSpectrometerPixelsCount];

            for (int i = 0; i < mSpectrometerPixelsCount; ++i) {
                string value = file.ReadLine();

                char[] delimiterChars = { '\t', '\n', ' ' };

                string[] words = value.Split(delimiterChars);

                int t = 0;
                for (int j = 0; j < words.Count(); ++j) {
                    if (words[j].Count() > 1) {
                        if (t == 0) {
                            newSpectrum.mWaveLengths.Value[i] = System.Convert.ToDouble(words[j]);
                        } else {
                            newSpectrum.mAbsoluteIntensities.Value[i] = System.Convert.ToDouble(words[j]);
                            break;
                        }
                        t++;
                    }
                }
            }

            file.Close();

            return newSpectrum;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AddSpectrumFromFile(System.IO.FileStream fs) {
            AddNewSpectrumToCurrentMeasurement(LoadSpectrumFromFile(fs));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AddSpectrum_Click(object sender, EventArgs e) {
            AddNewSpectrumDialog.Filter = "Spectrum|*.spec";
            AddNewSpectrumDialog.Title = "Add spectrum...";
            if (AddNewSpectrumDialog.ShowDialog() == DialogResult.OK) {
                if (AddNewSpectrumDialog.FileName != "") {
                    try {
                        System.IO.FileStream fs = (System.IO.FileStream)AddNewSpectrumDialog.OpenFile();
                        AddSpectrumFromFile(fs);
                        UpdateExperiment();
                        fs.Close();
                    } catch (Exception) {
                        MessageBox.Show("Unable to load " + AddNewSpectrumDialog.FileName + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AsyncSpectraLoaderDoWork(object sender, DoWorkEventArgs e) {
            int countLoaded = 0;
            foreach (string fn in mFilesToLoad) {
                FileStream fs = new FileStream(fn, FileMode.Open);
                AddSpectrumFromFile(fs);
                fs.Close();
                ++countLoaded;
                mAsyncLoader.ReportProgress((int)(100 * ((float)countLoaded / mFilesToLoad.Count())), fn.ToString());
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AsyncSpectraLoaderProgress(object sender, ProgressChangedEventArgs e) {
            mLoadingScreen.SetProgress(e.ProgressPercentage);
            mLoadingScreen.SetText((string)e.UserState);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AsyncSpectraLoaderDone(object sender, RunWorkerCompletedEventArgs e) {
            UpdateExperiment();
            mLoadingScreen.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void LoadSpectrumSeriesFromFolder(string path) {
            mFilesToLoad = System.IO.Directory.GetFiles(path);
            Array.Sort(mFilesToLoad, StringComparer.Ordinal);
            mAsyncLoader.RunWorkerAsync();
            mLoadingScreen = new LoadingScreen("Loading spectra series...");
            mLoadingScreen.ShowDialog();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AddSpectrumSeries_Click(object sender, EventArgs e) {
            try {
                if (mCurrentExperiment.mSpectra.Count > 0) {
                    DialogResult result = MessageBox.Show("Experiment already contains spectrums. Would you like to clear current experiment, before load new series?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) {
                        CleanCurrentExperiment();
                    }
                }
                if (AddSpectrumSeriesDialog.ShowDialog() == DialogResult.OK) {
                    if (AddSpectrumSeriesDialog.SelectedPath != "") {
                        LoadSpectrumSeriesFromFolder(AddSpectrumSeriesDialog.SelectedPath);
                    }
                }
                RecalibrateEachExperiment();
            } catch (Exception) {
                MessageBox.Show("Unable to load series from " + AddSpectrumSeriesDialog.SelectedPath + "!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void AverageSpectrums_Click(object sender, EventArgs e) {
            if (mCurrentExperiment.mSpectra.Count == 0) {
                MessageBox.Show("Unable to average spectra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double lastDelay = mCurrentExperiment.mSpectra[0].mIntegrationDelayMicroSec;
            foreach (var spec in mCurrentExperiment.mSpectra) {
                if (spec.mIntegrationDelayMicroSec != lastDelay) {
                    if (MessageBox.Show("You trying to average spectra with different integration times! Would you like to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                        return;
                    }
                }
            }

            avaspec.PixelArrayType averaged = new avaspec.PixelArrayType();
            avaspec.PixelArrayType wavelenghts = mCurrentExperiment.mSpectra[0].mWaveLengths;
            averaged.Value = new double[mSpectrometerPixelsCount];
            var spectrums = mCurrentExperiment.mSpectra;
            double avDelay = 0.0;
            for (int i = 0; i < spectrums.Count; ++i) {
                for (int k = 0; k < mSpectrometerPixelsCount; ++k) {
                    averaged.Value[k] += spectrums[i].mAbsoluteIntensities.Value[k];
                }
                avDelay += spectrums[i].mIntegrationDelayMicroSec;
            }
            for (int k = 0; k < mSpectrometerPixelsCount; ++k) {
                averaged.Value[k] /= spectrums.Count;
            }
            avDelay /= spectrums.Count;
            RemoveAllSpectrumsFromCurrentMeasurement();
            AddNewSpectrumToCurrentMeasurement(new Spectrum(averaged, wavelenghts, (float)avDelay));
            UpdateExperiment();
            RecalibrateEachExperiment();
            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void resultsToolStripMenuItem_Click(object sender, EventArgs e) {
            RecalibrateEachExperiment();
            bool haveAnyExperiment = false;
            foreach (var exp in mExperiments) {
                if (exp.mSpectra.Count > 0) {
                    haveAnyExperiment = true;
                }
            }
            if (haveAnyExperiment) {
                Results results = new Results();
                results.Show();
            } else {
                MessageBox.Show("Nothing to do!");
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnBaselineMin_Click(object sender, EventArgs e) {
            var spectrums = mCurrentExperiment.mSpectra;
            for (int i = 0; i < spectrums.Count; ++i) {
                var spectrum = spectrums[i];
                double minimal = 9999999.0;
                for (int k = 0; k < mSpectrometerPixelsCount; ++k) {
                    if (spectrum.mAbsoluteIntensities.Value[k] < minimal) {
                        minimal = spectrum.mAbsoluteIntensities.Value[k];
                    }
                }

                for (int k = 0; k < mSpectrometerPixelsCount; ++k) {
                    spectrum.mAbsoluteIntensities.Value[k] -= minimal;
                }
            }

            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SaveTable_Click(object sender, EventArgs e) {
            var spectrums = mCurrentExperiment.mSpectra;
            if (spectrums.Count == 0) {
                MessageBox.Show("Nothing to save!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dlgSaveCurrentSpectrum.Filter = "Spectrum table|*.spectable";
            dlgSaveCurrentSpectrum.Title = "Save spectrum table...";
            dlgSaveCurrentSpectrum.ShowDialog();
            if (dlgSaveCurrentSpectrum.FileName != "") {
                System.IO.StreamWriter file = new System.IO.StreamWriter((System.IO.FileStream)dlgSaveCurrentSpectrum.OpenFile());
                file.WriteLine(mSpectrometerPixelsCount);
                file.Write("Wavelenght\t");
                for (int k = 0; k < spectrums.Count; ++k) {
                    string onlyName = "Spectrum ";
                    if (spectrums[k].mName != null) {
                        if (spectrums[k].mName.Length > 0) {
                            int delim = spectrums[k].mName.LastIndexOf('\\');
                            if (delim > 0) {
                                string past = spectrums[k].mName.Substring(0, delim);
                                int delim2 = past.LastIndexOf('\\');
                                if (delim2 > 0) {
                                    past = past.Substring(delim2);
                                }
                                onlyName = past + spectrums[k].mName.Substring(delim);
                            }
                        } else {
                            onlyName += k;
                        }
                    } else {
                        onlyName += k;
                    }
                    file.Write(onlyName + "\t");
                }
                // also write delays
                file.Write(file.NewLine);
                file.Write("Integration delay\t");
                for (int k = 0; k < spectrums.Count; ++k) {
                    file.Write(spectrums[k].mIntegrationDelayMicroSec + "\t");
                }
                // write wavelenght and values from each spectrum
                file.Write(file.NewLine);
                for (int i = 0; i < mSpectrometerPixelsCount; ++i) {
                    file.Write(spectrums[0].mWaveLengths.Value[i] + "\t");
                    for (int k = 0; k < spectrums.Count; ++k) {
                        file.Write(spectrums[k].mAbsoluteIntensities.Value[i] + "\t");
                    }
                    file.Write(file.NewLine);
                }
                file.Close();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void LoadTable_Click(object sender, EventArgs e) {
            MessageBox.Show("Not implemented yet!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SmoothSpectrumButton_Click(object sender, EventArgs e) {
            foreach (var spectrum in mCurrentExperiment.mSpectra) {
                SmoothSpectrum(mCurrentSpectrum);
            }

            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnBaselineSpline_Click(object sender, EventArgs e) {
            SplineFitting splFit = new SplineFitting(mCurrentExperiment.mSpectra);
            splFit.ShowDialog();

            if (splFit.mApplyResult) {
                for (int i = 0; i < splFit.mSplines.Count; ++i) {
                    mCurrentExperiment.mSpectra[i].RemoveBaselineBySpline(splFit.mSplines[i]);
                }
            }

            UpdateExperiment();
            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MainWindow_DragDrop(object sender, DragEventArgs e) {
            var paths = ((string[])e.Data.GetData(DataFormats.FileDrop));

            foreach (var path in paths) {
                if (path.Length > 0) {
                    LoadSpectrumSeriesFromFolder(path);
                    ++nudMeasurementNumber.Value;
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MainWindow_DragEnter(object sender, DragEventArgs e) {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                var paths = ((string[])e.Data.GetData(DataFormats.FileDrop));
                if (Directory.Exists(paths[0])) {
                    effects = DragDropEffects.Copy;
                }
            }

            e.Effect = effects;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void plasmaToolStripMenuItem_Click(object sender, EventArgs e) {
            if (mIrradianceCalCoeff != null) {
                Plasma plasma = new Plasma(mIonsBase);
                plasma.Show();
            } else {
                MessageBox.Show("Spectra wasn't irradiance calibrated! Load irradiance calibration first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void RemoveSaturatedSpectrums_Click(object sender, EventArgs e) {
            int before = mCurrentExperiment.mSpectra.Count;
            for (int i = mCurrentExperiment.mSpectra.Count - 1; i >= 0; i--) {
                if (mCurrentExperiment.mSpectra[i].IsSaturated()) {
                    mCurrentExperiment.mSpectra.RemoveAt(i);
                }
            }
            if (mCurrentExperiment.mSpectra.Count > 0) {
                mCurrentSpectrum = mCurrentExperiment.mSpectra[0];
            }
            nudSpectrumNumber.Maximum = mCurrentExperiment.mSpectra.Count;
            int after = mCurrentExperiment.mSpectra.Count;
            UpdateChart();
            MessageBox.Show((before - after).ToString() + " saturated spectrums removed! Before: " + before + "; After: " + after, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnRemoveFirstNSpectrums_Click(object sender, EventArgs e) {
            if ((int)SpectrumCountToRemove.Value < mCurrentExperiment.mSpectra.Count) {
                var spectrums = mCurrentExperiment.mSpectra;
                mCurrentExperiment.mSpectra.RemoveRange(0, (int)SpectrumCountToRemove.Value);
                mCurrentSpectrum = spectrums[0];
                UpdateChart();
                nudSpectrumNumber.Maximum = mCurrentExperiment.mSpectra.Count;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnRemoveWithMaxLower_Click(object sender, EventArgs e) {
            int before = mCurrentExperiment.mSpectra.Count;
            for (int i = mCurrentExperiment.mSpectra.Count - 1; i >= 0; --i) {
                double max = 0.0f;
                foreach (var value in mCurrentExperiment.mSpectra[i].mAbsoluteIntensities.Value) {
                    if (value > max) {
                        max = value;
                    }
                }
                if (max < (double)nudLowerLimit.Value) {
                    mCurrentExperiment.mSpectra.RemoveAt(i);
                }
            }

            int removedCount = before - mCurrentExperiment.mSpectra.Count;
            MessageBox.Show("Removed " + removedCount + " spectra with max value lower " + nudLowerLimit.Value, "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateExperiment();
            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void DetectionThreshold_ValueChanged(object sender, EventArgs e) {
            DoMaterialRecognition();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void PrintPeakInfo(Peak peak) {
            string additionalInfo = Math.Round(peak.mWavelength, 2) + " nm; " + Math.Round(peak.mIntensity, 2) + " a.u.; FWHM: " + Math.Round(peak.mFWHM, 2) + " nm\n";

            TextAnnotation annotation = new TextAnnotation();

            if (chkShowPeakInfo.Checked) {
                annotation.Text = additionalInfo + peak.mText;
            } else {
                annotation.Text = peak.mText;
            }

            annotation.AxisX = mMainChart.ChartAreas[0].AxisX;
            annotation.AxisY = mMainChart.ChartAreas[0].AxisY;
            annotation.AnchorX = peak.mWavelength;
            annotation.AnchorY = peak.mIntensity;
            annotation.SmartLabelStyle.Enabled = false;
            annotation.SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Top | LabelAlignmentStyles.Bottom;
            annotation.ForeColor = peak.mColor;
            mMainChart.Annotations.Add(annotation);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MarkPeak(Peak peak) {
            float w = 0.45f;
            float h = 0.55f;

            EllipseAnnotation ellipseAnnotaion = new EllipseAnnotation();
            ellipseAnnotaion.AxisX = mMainChart.ChartAreas[0].AxisX;
            ellipseAnnotaion.AxisY = mMainChart.ChartAreas[0].AxisY;
            ellipseAnnotaion.AnchorX = peak.mWavelength;
            ellipseAnnotaion.AnchorY = peak.mIntensity;
            ellipseAnnotaion.Alignment = ContentAlignment.MiddleCenter;
            ellipseAnnotaion.AnchorAlignment = ContentAlignment.MiddleCenter;
            ellipseAnnotaion.Width = w;
            ellipseAnnotaion.Height = h;
            ellipseAnnotaion.SmartLabelStyle.Enabled = false;
            ellipseAnnotaion.BackColor = peak.mColor;
            mMainChart.Annotations.Add(ellipseAnnotaion);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        // Empirical Formulae for Electron Density Diagnostics from Hα and Hβ Line Profiles
        // DAVID M. SURMICK AND CHRISTIAN G. PARIGGER
        // International Review of Atomic and Molecular Physics, 5 (2), July-December 2014         
        private double ComputeElectronDensity(double peakFWHM) {
            return 65578820401913032.0 * Math.Pow(peakFWHM, 25.0 / 16.0);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private double ComputeStarkRedShift(double electronDensity) {
            return 0.55 * Math.Pow(electronDensity / 10e17, 0.97);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        // Separate thread for peak and line identification
        private void bgwIdentification_DoWork(object sender, DoWorkEventArgs e) {
            mEmissionPeaks.Clear();

            List<Peak> absorptionPeaks = new List<Peak>();
            mCurrentSpectrum.FindPeaks(ref mEmissionPeaks, ref absorptionPeaks, (float)nudPeakThreshold.Value);

            if (mEmissionPeaks.Count > 150) {
                if (MessageBox.Show("There is over " + mEmissionPeaks.Count + " peaks found in spectrum, probably you trying to recognize too noisy signal. Are you want to continue? This procedure can take a lot of time", "Probably too noisy signal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                    return;
                }
            }

            int recognizedCount = 0;

            int peakNumber = 0;
            foreach (var peak in mEmissionPeaks) {
                peak.mFWHM = mCurrentSpectrum.ComputeFWHM(peak.mPixelNumber);

                // recognize peaks for elements
                foreach (var ion in mIonsBase) {
                    // check, if user select recognition of this ion\element
                    int k = 2;
                    for (int i = 0; i < ion.mName.Count(); ++i) {
                        if (ion.mName[i] == ' ') {
                            k = i;
                            break;
                        }
                    }
                    string element = ion.mName.Substring(0, k);
                    if (mElements.ContainsKey(element)) {
                        if (!mElements[element].Checked) {
                            continue;
                        }
                    }

                    double leftLimit = peak.mWavelength - (double)nudLeftAccuracyLimit.Value;
                    double rightLimit = peak.mWavelength + (double)nudRightAccuracyLimit.Value;
                    if (ion.mWavelength >= leftLimit && ion.mWavelength <= rightLimit) {
                        if (ion.mTransitionStrenghtAki != 0.0f) {
                            peak.mText = peak.mText.Insert(0, ion.mName + ": " + Math.Round(ion.mWavelength, 3) + " nm; " + ion.mTransitionStrenghtStr + "\n");
                        } else {
                            peak.mText += ion.mName + ": " + Math.Round(ion.mWavelength, 3) + " nm\n";
                        }
                        // test test test
                        if (ion.mTransitionStrenghtAki > 0) {
                            peak.mIons.Add(ion);
                        }
                        peak.mLines++;
                        ++recognizedCount;
                    }
                }

                // recognize peaks for molecules
                foreach (var pair in mMolecules) {
                    bool wavelenghtMatch = Math.Abs(pair.Value - peak.mWavelength) < (double)nudLeftAccuracyLimit.Value;
                    if (wavelenghtMatch) {
                        // todo: add peak.mIons.Add(ion) for molecules
                        peak.mText += pair.Key + ": " + Math.Round(pair.Value, 3) + " nm\n";
                        peak.mLines++;
                        ++recognizedCount;
                    }
                }
                string progressString = "Identifying peak at " + peak.mWavelength + " nm...";
                bgwIdentification.ReportProgress((int)(100 * ((float)peakNumber / mEmissionPeaks.Count)), progressString);
                ++peakNumber;

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        void IdentificationProgressChanged(object sender, ProgressChangedEventArgs e) {
            mLoadingScreen.SetProgress(e.ProgressPercentage);
            mLoadingScreen.SetText((string)e.UserState);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        void IdentificationDone(object sender, RunWorkerCompletedEventArgs e) {
            mMainChart.Annotations.Clear();
            int totalLinesIdentified = 0;
            foreach (var peak in mEmissionPeaks) {
                PrintPeakInfo(peak);
                if (peak.mLines > 0) {
                    totalLinesIdentified += peak.mLines;
                }
            }
            foreach (var peak in mEmissionPeaks) {
                MarkPeak(peak);
            }
            RecognizedLinesCountText.Text = totalLinesIdentified + " lines identified on " + mEmissionPeaks.Count + " peaks";
            mLoadingScreen.Close();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnRecognizeLines_Click_1(object sender, EventArgs e) {
            if (mCurrentSpectrum == null) {
                MessageBox.Show("There is no spectrum for identification! Load or capture spectrum first!", "No spectrum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bgwIdentification.RunWorkerAsync();
            mLoadingScreen = new LoadingScreen("Identifying...");
            mLoadingScreen.ShowDialog();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnClearRecognized_Click(object sender, EventArgs e) {
            mMainChart.Annotations.Clear();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnMolecules_Click(object sender, EventArgs e) {
            MoleculesSelection ms = new MoleculesSelection(this);
            ms.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnAll_CheckedChanged(object sender, EventArgs e) {
            foreach (var keyValue in mElements) {
                if (keyValue.Value.Enabled) {
                    keyValue.Value.Checked = !keyValue.Value.Checked;
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void clbAdditionalSpectraPlot_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void clbAdditionalSpectraPlot_ItemCheck(object sender, ItemCheckEventArgs e) {
            var s = clbAdditionalSpectraPlot.Items[e.Index] as Spectrum;
            if (s != null) {
                s.mPlot = e.NewValue == CheckState.Checked;
            }
            UpdateChart();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnCalculateIntergralRatios_Click(object sender, EventArgs e) {
            if (mCurrentSpectrum == null || mEmissionPeaks.Count == 0) {
                MessageBox.Show("Do identification first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double totalIntegral = CalculateIntegral(mCurrentSpectrum, mCurrentSpectrum.mWaveLengths.Value.First(), mCurrentSpectrum.mWaveLengths.Value.Last());
            Dictionary<string, double> integrals = new Dictionary<string, double>();
            foreach (var peak in mEmissionPeaks) {
                foreach (var ion in peak.mIons) {
                    if (!integrals.ContainsKey(ion.mName.Substring(0, 2))) {
                        integrals.Add(ion.mName.Substring(0, 2), 0);
                    }

                    integrals[ion.mName.Substring(0, 2)] += CalculateIntegral(mCurrentSpectrum, peak.mWavelength - 1, peak.mWavelength + 1) / totalIntegral;
                }
            }

            var visualizer = new ElementVisualizer(integrals);
            visualizer.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnMergeIntegrals_Click(object sender, EventArgs e) {
            // select folder with integrals lists
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                if (dlg.SelectedPath != "") {
                    var files = System.IO.Directory.GetFiles(dlg.SelectedPath);
                    if (files.Count() > 0) {
                        // let user to choose destination file
                        SaveFileDialog saveDlg = new SaveFileDialog();
                        saveDlg.Filter = "txt files (*.txt)|*.txt";
                        if (saveDlg.ShowDialog() == DialogResult.OK) {
                            // read integrals from each file and put it to dictionary
                            Dictionary<string, List<double>> mIntegrals = new Dictionary<string, List<double>>();
                            foreach (var fn in files) {
                                StreamReader input = new StreamReader(fn);
                                // read file line by line
                                while (!input.EndOfStream) {
                                    string line = input.ReadLine();
                                    // split string into name - integral pair
                                    var tokens = line.Split('\t');
                                    // readable aliases
                                    var name = tokens[0];
                                    var integral = Convert.ToDouble(tokens[1]);
                                    // add list if not added before
                                    if (!mIntegrals.ContainsKey(name)) {
                                        mIntegrals.Add(name, new List<double>());
                                    }
                                    // and finally place integral into list
                                    mIntegrals[name].Add(integral);
                                }
                                input.Close();
                            }
                            // write whole dictionary 
                            StreamWriter output = new StreamWriter(saveDlg.FileName);
                            foreach (var kv in mIntegrals) {
                                output.Write(kv.Key + '\t');
                                foreach (var integral in kv.Value) {
                                    output.Write(integral.ToString() + '\t');
                                }
                                output.WriteLine();
                            }
                            output.Close();
                        }
                    }
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnGetCalibration_Click(object sender, EventArgs e) {
            ushort count = 0;
            avaspec.AVS_GetNumPixels(mSpectrometerHandle, ref count);
            avaspec.DeviceConfigType devData = new avaspec.DeviceConfigType();
            uint size = (uint)Marshal.SizeOf(typeof(avaspec.DeviceConfigType));
            avaspec.AVS_GetParameter((IntPtr)mSpectrometerHandle, size, ref size, ref devData);
            mIrradianceIntTime = devData.m_Irradiance.m_IntensityCalib.m_CalInttime;
            mIrradianceCalCoeff = new double[count];
            // dump to file
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                StreamWriter calibFile = new StreamWriter(dlg.FileName);
                calibFile.WriteLine("#irradiance");
                calibFile.WriteLine(devData.m_Irradiance.m_IntensityCalib.m_CalInttime);
                calibFile.WriteLine(devData.m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothModel);
                calibFile.WriteLine(devData.m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothPix);
                calibFile.WriteLine(count);
                for (int i = 0; i < count; ++i) {
                    calibFile.WriteLine(devData.m_Irradiance.m_IntensityCalib.m_aCalibConvers[i]);
                    mIrradianceCalCoeff[i] = devData.m_Irradiance.m_IntensityCalib.m_aCalibConvers[i];
                }
                calibFile.Close();
            }
        }

        private void LoadIrradianceCalibrationFromFile(string file, bool onLoad) {
            StreamReader irr = new StreamReader(file);
            var header = irr.ReadLine();
            if (header != "#irradiance") {
                MessageBox.Show(file + " is not a calibration file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {
                mIrradianceIntTime = Convert.ToDouble(irr.ReadLine());
                var smoothModel = irr.ReadLine();
                var smoothPix = irr.ReadLine();
                int pixelCount = Convert.ToInt32(irr.ReadLine());
                mIrradianceCalCoeff = new double[pixelCount];
                for (int i = 0; i < pixelCount; ++i) {
                    var v = irr.ReadLine().Split('\t');
                    mIrradianceCalCoeff[i] = Convert.ToDouble(v[1]);
                }
            }
            irr.Close();
            // suppress message on app startup
            if (!onLoad) {
                MessageBox.Show("Irradiance calibration from " + file + " was successfully loaded!", "Irradiance Calibration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            chkEnableCalibratedYAxis.Enabled = true;
            RecalibrateEachExperiment();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void doIrradianceCalibrationToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                LoadIrradianceCalibrationFromFile(dlg.FileName, false);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        void CalibrateSpectrum(Spectrum spectrum) {
            spectrum.mIrradiance = new avaspec.PixelArrayType();
            spectrum.mIrradiance.Value = new double[spectrum.mAbsoluteIntensities.Value.Count()];
            for (int i = 0; i < spectrum.mAbsoluteIntensities.Value.Count(); ++i) {
                const double dark = 0.0;
                spectrum.mIrradiance.Value[i] = (mIrradianceIntTime / spectrum.mIntegrationDelayMicroSec) * ((spectrum.mAbsoluteIntensities.Value[i] - dark) / mIrradianceCalCoeff[i]);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void RecalibrateEachExperiment() {
            if (mIrradianceCalCoeff != null) {
                foreach (var experiment in mExperiments) {
                    foreach (var spectrum in experiment.mSpectra) {
                        CalibrateSpectrum(spectrum);
                    }
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void chkEnableCalibratedYAxis_CheckedChanged(object sender, EventArgs e) {
            if (mIrradianceCalCoeff != null) {
                CheckBox chk = (CheckBox)sender;
                if (chk.Checked) {
                    mMainChart.ChartAreas[0].AxisY.Title = "Irradiance, μW/(cm²*nm)";
                } else {
                    mMainChart.ChartAreas[0].AxisY.Title = "Intensity, a.u.";
                }
                UpdateChart();
                RecalibrateEachExperiment();
            }
        }

        private void btnShowLineBase_Click(object sender, EventArgs e) {
            LineBaseVisualizer lbv = new LineBaseVisualizer(mIonsBase);
            lbv.Show();
        }

        private void btnSavePlotToFile_Click(object sender, EventArgs e) {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                var lastSize = mMainChart.Size;
                mMainChart.Size = new Size(3000, 2000);
                mMainChart.SaveImage(dlg.FileName, ChartImageFormat.Emf);
                mMainChart.Size = lastSize;
            }
        }

        private void chkShowPeakInfo_CheckedChanged(object sender, EventArgs e) {

        }

        private void btnDiscardOutlier_Click(object sender, EventArgs e) {
            if (mCurrentExperiment.mSpectra.Count <= 1) {
                MessageBox.Show("Nothing to do!");
                return;
            }

            int removed = 0;
            var countBefore = mCurrentExperiment.mSpectra.Count;
            for (int iteration = 0; iteration < 5; ++iteration) {
                List<double> maxValues = new List<double>();
                foreach (var spectrum in mCurrentExperiment.mSpectra) {
                    double max = 0.0;
                    foreach (var value in spectrum.mAbsoluteIntensities.Value) {
                        if (value > max) {
                            max = value;
                        }
                    }
                    maxValues.Add(max);
                }


                // calculate average
                double average = 0.0;
                foreach (var max in maxValues) {
                    average += max;
                }
                average /= maxValues.Count;

                // calculate standard deviation
                double standardDeviation = 0.0;
                for (int i = 0; i < maxValues.Count; ++i) {
                    standardDeviation += Math.Pow(maxValues[i] - average, 2);
                }
                standardDeviation /= maxValues.Count - 1;
                standardDeviation = Math.Sqrt(standardDeviation);

                // Sobron et. al Extraction of compositional and hydration information of sulfates from laser-induced
                // plasma spectra recorded under Mars atmospheric conditions — Implications for ChemCam investigations on Curiosity rover              
                const double n = 0.75;
                bool done = false;
                for (int i = maxValues.Count - 1; i >= 0; i--) {
                    double upperLimit = average + n * standardDeviation;
                    double lowerLimit = average - n * standardDeviation;
                    bool inside = maxValues[i] >= lowerLimit && maxValues[i] <= upperLimit;
                    if (!inside) {
                        maxValues.RemoveAt(i);
                        mCurrentExperiment.mSpectra.RemoveAt(i);
                        ++removed;
                        if (mCurrentExperiment.mSpectra.Count < (int)countBefore * 0.6) {
                            done = true;
                            break;
                        }
                    }
                }

                if (done) {
                    MessageBox.Show("Removed " + removed + " outliers! In " + (iteration + 1) + " iteration(s)", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nudSpectrumNumber.Maximum = mCurrentExperiment.mSpectra.Count;
                    UpdateChart();
                    // stop algorithm
                    break;
                }
            }
        }

        private void btnRemoveWithMaxOver_Click(object sender, EventArgs e) {
            int before = mCurrentExperiment.mSpectra.Count;
            for (int i = mCurrentExperiment.mSpectra.Count - 1; i >= 0; --i) {
                foreach (var value in mCurrentExperiment.mSpectra[i].mAbsoluteIntensities.Value) {
                    if (value > (double)nudMaxRemoveNumber.Value) {
                        mCurrentExperiment.mSpectra.RemoveAt(i);
                        break;
                    }
                }
            }
            int removedCount = before - mCurrentExperiment.mSpectra.Count;
            MessageBox.Show("Removed " + removedCount + " spectra with max value over " + nudMaxRemoveNumber.Value, "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateExperiment();
            UpdateChart();
        }

        private void btnFourierSelfDeconvolution_Click(object sender, EventArgs e) {
            if (mCurrentExperiment.mSpectra.Count > 0) {
                FourierSelfDeconvolution fsd = new FourierSelfDeconvolution(mCurrentExperiment.mSpectra);
                fsd.ShowDialog();
                if (fsd.mApply) {
                    for (int i = 0; i < mCurrentExperiment.mSpectra.Count; ++i) {
                        var spectrum = mCurrentExperiment.mSpectra[i];
                        for (int j = 0; j < spectrum.mAbsoluteIntensities.Value.Length; ++j) {
                            spectrum.mAbsoluteIntensities.Value[j] = fsd.mDeconvolutedSpectra[i].mAbsoluteIntensities[j];
                        }
                    }
                }
            }
            UpdateChart();
        }

        private int GetClosestWavelengthMatchIndex(Spectrum s, double wavelength) {
            int index = 0;
            for (int i = 0; i < s.mWaveLengths.Value.Length; ++i) {
                if (Math.Abs(s.mWaveLengths.Value[i] - wavelength) < Math.Abs(s.mWaveLengths.Value[i] - s.mWaveLengths.Value[index])) {
                    index = i;
                }
            }
            return index;
        }

        private void btnBoringStuff_Click(object sender, EventArgs e) {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                /*
                StreamWriter wr = new StreamWriter(dlg.FileName);
                double w1 = 387.83;
                double w2 = 515.81;
                wr.WriteLine("Wavelengths: " + w1 + '\t' + w2);
                foreach (var spec in mCurrentExperiment.mSpectra) {
                    int i1 = GetClosestWavelengthMatchIndex(spec, w1);
                    int i2 = GetClosestWavelengthMatchIndex(spec, w2);

                    wr.WriteLine(spec.mAbsoluteIntensities.Value[i1] + "\t" + spec.mAbsoluteIntensities.Value[i2]);
                }
                wr.Close();
                */
                StreamWriter wr = new StreamWriter(dlg.FileName);
                double c2_1_1 = 526.8;
                double c2_1_2 = 563.8;
                wr.WriteLine("C2" + c2_1_1 + "-" + c2_1_2);
                foreach (var spec in mCurrentExperiment.mSpectra) {
                    int i1 = GetClosestWavelengthMatchIndex(spec, c2_1_1);
                    int i2 = GetClosestWavelengthMatchIndex(spec, c2_1_2);
                    double total1 = 0;
                    for (int i = i1; i < i2; ++i) {
                        total1 += spec.mAbsoluteIntensities.Value[i];
                    }
                    wr.WriteLine(total1);
                }
                wr.Close();
            }
        }

        private void btnSaveCalibrated_Click(object sender, EventArgs e) {
            if (mCurrentExperiment.mSpectra.Count == 0) {
                MessageBox.Show("Nothing to save!");
                return;
            }
            RecalibrateEachExperiment();
            int n = 0;
            if (SaveSpectrumDialog.ShowDialog() == DialogResult.OK) {
                if (SaveSpectrumDialog.SelectedPath != "") {
                    foreach (var spec in mCurrentExperiment.mSpectra) {
                        string filename = spec.mName;
                        // newly created spectra saved with order number
                        int slashPos = spec.mName.LastIndexOf('\\');
                        if (slashPos < 0) {
                            filename = "/spectrum_" + (n < 10 ? "0" + n.ToString() : n.ToString()) + ".spec";
                        } else { // existing spectra (i.e. loaded from file) - must be saved with same file name
                            if (slashPos >= 0) {
                                filename = spec.mName.Substring(slashPos);
                            }
                        }
                        System.IO.StreamWriter file = new System.IO.StreamWriter(SaveSpectrumDialog.SelectedPath + filename);
                        file.WriteLine(spec.mIntegrationDelayMicroSec);
                        file.WriteLine(spec.mIrradiance.Value.Count());
                        for (int i = 0; i < spec.mIrradiance.Value.Count(); ++i) {
                            file.WriteLine(spec.mWaveLengths.Value[i].ToString() + "\t" + spec.mIrradiance.Value[i].ToString());
                        }
                        file.Close();
                        ++n;
                    }
                }
            }
        }
    }
}

/*
var spectrum = mCurrentSpectrum;

int windowWidth = 8;
for(int i = 0; i < spectrum.mAbsoluteIntensities.Value.Count(); i += windowWidth) {
    Complex[] data = new Complex[windowWidth];
    for(int j = 0; j < windowWidth; ++j) {
        data[j] = spectrum.mAbsoluteIntensities.Value[i + j];
    }

    FourierTransform.DFT(data, FourierTransform.Direction.Backward);


    double width = 2e-2;
    for (int j = 0; j < windowWidth; ++j) {
        double ap = GeneralApodization(windowWidth, j);
        double iftlp = InverseFourierTransformOfLorentzianProfile(width, j);

        data[j] = data[j] * ap / iftlp;
    }

    FourierTransform.DFT(data, FourierTransform.Direction.Forward);


    for (int j = 0; j < windowWidth; ++j) {
        spectrum.mAbsoluteIntensities.Value[i + j] = data[j].Real >= 0 ? data[j].Real : 0;

    }
}

UpdateChart();
*/

/// <summary>
/// Fourier transformation.
/// </summary>
/// 
/// <remarks>The class implements one dimensional and two dimensional
/// Discrete and Fast Fourier Transformation.</remarks>
/// 
public static class FourierTransform {
    /// <summary>
    /// Fourier transformation direction.
    /// </summary>
    public enum Direction {
        /// <summary>
        /// Forward direction of Fourier transformation.
        /// </summary>
        Forward = 1,

        /// <summary>
        /// Backward direction of Fourier transformation.
        /// </summary>
        Backward = -1
    };

    /// <summary>
    /// One dimensional Discrete Fourier Transform.
    /// </summary>
    /// 
    /// <param name="data">Data to transform.</param>
    /// <param name="direction">Transformation direction.</param>
    /// 
    public static void DFT(Complex[] data, Direction direction) {
        int n = data.Length;
        double arg, cos, sin;
        Complex[] dst = new Complex[n];

        // for each destination element
        for (int i = 0; i < n; i++) {
            dst[i] = Complex.Zero;

            arg = -(int)direction * 2.0 * Math.PI * (double)i / (double)n;

            // sum source elements
            for (int j = 0; j < n; j++) {
                cos = Math.Cos(j * arg);
                sin = Math.Sin(j * arg);

                dst[i] += new Complex(data[j].Real * cos - data[j].Imaginary * sin, data[j].Real * sin + data[j].Imaginary * cos);
            }
        }

        // copy elements
        if (direction == Direction.Forward) {
            // devide also for forward transform
            for (int i = 0; i < n; i++) {
                data[i] = new Complex(dst[i].Real / n, dst[i].Imaginary / n);
            }
        } else {
            for (int i = 0; i < n; i++) {
                data[i] = dst[i];
            }
        }
    }



}

public class SplineFitter {
    private readonly double[] mKeys;
    private readonly double[] mValues;
    private readonly double[] mH;
    private readonly double[] mA;

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public SplineFitter(IDictionary<double, double> nodes) {
        if (nodes == null) {
            throw new ArgumentNullException("nodes");
        }

        var n = nodes.Count;

        if (n < 2) {
            throw new ArgumentException("At least two point required for interpolation.");
        }

        mKeys = nodes.Keys.ToArray();
        mValues = nodes.Values.ToArray();
        mA = new double[n];
        mH = new double[n];

        for (int i = 1; i < n; i++) {
            mH[i] = mKeys[i] - mKeys[i - 1];
        }

        if (n > 2) {
            var sub = new double[n - 1];
            var diag = new double[n - 1];
            var sup = new double[n - 1];

            for (int i = 1; i <= n - 2; i++) {
                diag[i] = (mH[i] + mH[i + 1]) / 3;
                sup[i] = mH[i + 1] / 6;
                sub[i] = mH[i] / 6;
                mA[i] = (mValues[i + 1] - mValues[i]) / mH[i + 1] - (mValues[i] - mValues[i - 1]) / mH[i];
            }

            SolveTridiag(sub, diag, sup, ref mA, n - 2);
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public double GetValue(double key) {
        int gap = 0;
        var previous = double.MinValue;

        // At the end of this iteration, "gap" will contain the index of the interval
        // between two known values, which contains the unknown z, and "previous" will
        // contain the biggest z value among the known samples, left of the unknown z
        for (int i = 0; i < mKeys.Length; i++) {
            if (mKeys[i] < key && mKeys[i] > previous) {
                previous = mKeys[i];
                gap = i + 1;
            }
        }

        if (gap == 0) {
            gap = 1;
        }

        var x1 = key - previous;
        var x2 = mH[gap] - x1;

        return ((-mA[gap - 1] / 6 * (x2 + mH[gap]) * x1 + mValues[gap - 1]) * x2 +
            (-mA[gap] / 6 * (x1 + mH[gap]) * x2 + mValues[gap]) * x1) / mH[gap];
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    private static void SolveTridiag(double[] sub, double[] diag, double[] sup, ref double[] b, int n) {
        for (int i = 2; i <= n; i++) {
            sub[i] = sub[i] / diag[i - 1];
            diag[i] = diag[i] - sub[i] * sup[i - 1];
            b[i] = b[i] - sub[i] * b[i - 1];
        }

        b[n] = b[n] / diag[n];

        for (int i = n - 1; i >= 1; i--) {
            b[i] = (b[i] - sup[i] * b[i + 1]) / diag[i];
        }
    }
}

// Raw spectrum
public class RawSpectrum {
    public List<double> mWavelengths = new List<double>();
    public List<double> mAbsoluteIntensities = new List<double>();
    public RawSpectrum() {

    }
}

public class Spectrum : IComparable<Spectrum> {
    public avaspec.PixelArrayType mAbsoluteIntensities;
    public avaspec.PixelArrayType mIrradiance;
    public avaspec.PixelArrayType mWaveLengths;
    public float mIntegrationDelayMicroSec;
    public string mName;
    public bool mPlot = false;
    public static string mDefaultName = "(unknown)";
    public bool mUserFlag;

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public Spectrum() {
        mIntegrationDelayMicroSec = 1.0f;
        mName = mDefaultName;
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public Spectrum(avaspec.PixelArrayType value, avaspec.PixelArrayType wavelengths, float delay) {
        mIntegrationDelayMicroSec = delay;
        mAbsoluteIntensities = value;
        mWaveLengths = wavelengths;
        mName = mDefaultName;
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public override bool Equals(object obj) {
        if (obj == null) {
            return false;
        }

        Spectrum objAsPart = obj as Spectrum;

        if (objAsPart == null) {
            return false;
        } else {
            return Equals(objAsPart);
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public bool Equals(Spectrum other) {
        if (other == null) {
            return false;
        }

        return (mIntegrationDelayMicroSec.Equals(other.mIntegrationDelayMicroSec));
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public int CompareTo(Spectrum comparePart) {
        if (comparePart == null) {
            return 1;
        } else {
            return mIntegrationDelayMicroSec.CompareTo(comparePart.mIntegrationDelayMicroSec);
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public override int GetHashCode() {
        return (int)mIntegrationDelayMicroSec;
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public string ShortName {
        get {
            var p = mName.LastIndexOf('\\');
            if (p < 0) {
                return mName;
            } else {
                return mName.Substring(p + 1);
            }
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public double GetIntensity(double wavelenght) {
        double delta = mWaveLengths.Value[1] - mWaveLengths.Value[0];
        for (int i = 0; i < mWaveLengths.Value.Count(); ++i) {
            double d1 = Math.Abs(mWaveLengths.Value[i] - wavelenght);
            double d2 = Math.Abs(mWaveLengths.Value[i + 1] - wavelenght);
            if (d1 < d2 && d1 < delta) {
                return mAbsoluteIntensities.Value[i];
            } else if (d2 < d1 && d2 < delta) {
                return mAbsoluteIntensities.Value[i + 1];
            }
        }

        return 0.0;
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public void FindPeaks(ref List<Peak> emissionPeaks, ref List<Peak> absorptionPeaks, double delta) {
        bool isDetectingPulse = true;
        double mx = mAbsoluteIntensities.Value[0];
        double mn = mAbsoluteIntensities.Value[0];
        int mxPos = 0, mnPos = 0;
        for (int i = 1; i < mAbsoluteIntensities.Value.Count(); ++i) {
            if (mAbsoluteIntensities.Value[i] > mx) {
                mxPos = i;
                mx = mAbsoluteIntensities.Value[i];
            }
            if (mAbsoluteIntensities.Value[i] < mn) {
                mnPos = i;
                mn = mAbsoluteIntensities.Value[i];
            }
            if (isDetectingPulse && mAbsoluteIntensities.Value[i] < mx - delta) {
                emissionPeaks.Add(new Peak(mxPos, mAbsoluteIntensities.Value[mxPos], mWaveLengths.Value[mxPos]));
                isDetectingPulse = false;
                i = mxPos - 1;
                mn = mAbsoluteIntensities.Value[mxPos];
                mnPos = mxPos;
            } else if ((!isDetectingPulse) && mAbsoluteIntensities.Value[i] > mn + delta) {
                absorptionPeaks.Add(new Peak(mnPos, mAbsoluteIntensities.Value[mnPos], mWaveLengths.Value[mnPos]));
                isDetectingPulse = true;
                i = mnPos - 1;
                mx = mAbsoluteIntensities.Value[mnPos];
                mxPos = mnPos;
            }
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public void RemoveBaselineBySpline(RawSpectrum spline) {
        for (int i = 0; i < mAbsoluteIntensities.Value.Count(); ++i) {
            mAbsoluteIntensities.Value[i] -= spline.mAbsoluteIntensities[i];
            if (mAbsoluteIntensities.Value[i] < 0) mAbsoluteIntensities.Value[i] = 0;
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public RawSpectrum GetFittingSpline(int rangeCount) {
        // create spectrum for spline
        int pixelCount = mAbsoluteIntensities.Value.Count();
        RawSpectrum splineSpectrum = new RawSpectrum();

        Dictionary<double, double> splinePoints = new Dictionary<double, double>();
        splinePoints.Add(0, mAbsoluteIntensities.Value[0]);
        int range = mAbsoluteIntensities.Value.Count() / rangeCount;
        for (int i = 0; i < rangeCount - 1; ++i) {
            double min = Double.MaxValue;
            for (int k = i * range; k < (i + 1) * range; ++k) {
                if (mAbsoluteIntensities.Value[k] < min) {
                    min = mAbsoluteIntensities.Value[k];
                }
            }
            splinePoints.Add((2 * i + 1) * range / 2, min);
        }
        splinePoints.Add(mAbsoluteIntensities.Value.Count() - 1, mAbsoluteIntensities.Value[mAbsoluteIntensities.Value.Count() - 1]);
        SplineFitter spline = new SplineFitter(splinePoints);

        int start = (int)splinePoints.First().Key;
        int end = (int)splinePoints.Last().Key;

        for (int x = start; x < end + 1; ++x) {
            var y = spline.GetValue(x);
            if (double.IsInfinity(y)) {
                y = 0;
            }
            splineSpectrum.mWavelengths.Add(mWaveLengths.Value[x]);
            splineSpectrum.mAbsoluteIntensities.Add(y);
        }

        return splineSpectrum;
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public bool IsSaturated() {
        // find max value
        double max = -999999.0;
        foreach (var value in mAbsoluteIntensities.Value) {
            if (value > max) {
                max = value;
            }
        }

        // count pixels that in maximum
        int saturatedCount = 0;
        foreach (var value in mAbsoluteIntensities.Value) {
            if (value == max) {
                ++saturatedCount;
            }
        }

        return saturatedCount > 1;
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    // compute FWHM (full width at half maximum)
    public double ComputeFWHM(int pixelNumber) {
        double halfIntensity = mAbsoluteIntensities.Value[pixelNumber] / 2;

        // descend left
        double leftWavelength = 0;
        {
            int left = pixelNumber;
            while (mAbsoluteIntensities.Value[left] > halfIntensity && left > 1) {
                --left;
            }
            double leftIntepolator = 0.0;
            for (double dI = mAbsoluteIntensities.Value[left - 1]; dI > halfIntensity; dI -= 0.01) {
                leftIntepolator = (dI - mAbsoluteIntensities.Value[left]) / (mAbsoluteIntensities.Value[left - 1] - mAbsoluteIntensities.Value[left]);
            }
            leftWavelength = mWaveLengths.Value[left] + (mWaveLengths.Value[left - 1] - mWaveLengths.Value[left]) * leftIntepolator;
        }

        // descend right
        double rightWavelength = 0;
        {
            int right = pixelNumber;
            while (mAbsoluteIntensities.Value[right] > halfIntensity && right < (mAbsoluteIntensities.Value.Count() - 1)) {
                ++right;
            }
            double rightIntepolator = 0.0;
            for (double dI = mAbsoluteIntensities.Value[right - 1]; dI > halfIntensity; dI -= 0.01) {
                rightIntepolator = (dI - mAbsoluteIntensities.Value[right]) / (mAbsoluteIntensities.Value[right - 1] - mAbsoluteIntensities.Value[right]);
            }
            rightWavelength = mWaveLengths.Value[right] + (mWaveLengths.Value[right - 1] - mWaveLengths.Value[right]) * rightIntepolator;
        }

        return rightWavelength - leftWavelength;
    }
}

public class Experiment {
    public int mCompareSpectrumNumber = 0;
    public List<Spectrum> mSpectra = new List<Spectrum>();
    public List<Spectrum> mFittingCurves = new List<Spectrum>();

    public Experiment() {

    }
}

public class Peak {
    public int mPixelNumber = 0; // index in array of intensities
    public double mIntensity;
    public double mWavelength;
    public double mFWHM;
    public Color mColor;
    public List<Ion> mIons = new List<Ion>();
    public static Random randomGen = new Random();
    public string mText = "";
    public int mLines;
    public Peak(int id, double intensity, double wavelength) {
        mPixelNumber = id;
        mIntensity = intensity;
        mWavelength = wavelength;
        mColor = Color.FromArgb(randomGen.Next(60, 255), randomGen.Next(60, 200), randomGen.Next(60, 200));
    }
}

public class Ion {
    public string mName; // ion name, i.e. Cu II, Lu I and so on
    public float mWavelength; // wavelength
    public float mRelativeIntensity; // relative intensity from NIST base
    public float mTransitionStrenghtAki; // transition probability for k-i, s^-1
    public string mTransitionStrenghtStr; // same, but in string
    public float mEk; // energy of upper state, eV
    public float mEi; // energy of lower state, eV
    public int mgi; // lower state degeneracy
    public int mgk; // upper state degeneracy

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public Ion(string name, float obsWavelength, float relInt, string transitionStrenght) {
        mName = name;
        mWavelength = obsWavelength;
        mRelativeIntensity = relInt;
        mTransitionStrenghtStr = transitionStrenght;
        float.TryParse(mTransitionStrenghtStr, System.Globalization.NumberStyles.Float | System.Globalization.NumberStyles.AllowExponent, System.Globalization.CultureInfo.InvariantCulture, out mTransitionStrenghtAki);
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public string ShortName {
        get {
            return mName + " " + mWavelength + " nm;" + "gk " + mgk + "; Aki " + mTransitionStrenghtStr;
        }
    }
}
