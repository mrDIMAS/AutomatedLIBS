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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AutomatedLIBS {
    public partial class ElementVisualizer : Form {
        private Dictionary<string, double> mIntegrals;

        public ElementVisualizer(Dictionary<string, double> integrals) {
            InitializeComponent();
            mIntegrals = integrals;
        }

        private void ElementVisualizer_Load(object sender, EventArgs e) {
            chrElements.Series.Clear();
            chrElements.Series.Add("Elements");
            foreach(var kv in mIntegrals) { 
                chrElements.Series["Elements"].Points.AddXY(kv.Key, kv.Value);
            }
            chrElements.Series["Elements"].ChartType = SeriesChartType.Column;           
        }

        private void ElementVisualizer_Resize(object sender, EventArgs e) {

            chrElements.Size = new Size(ClientSize.Width, ClientSize.Height);
            
        }

        private void chrElements_Click(object sender, EventArgs e) {

        }

        private void btnSave_Click(object sender, EventArgs e) {
            var dlg = new SaveFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK) {
                var s = new StreamWriter(dlg.FileName);
                foreach(var kv in mIntegrals) {
                    s.WriteLine(kv.Key + "\t" + kv.Value);
                }
                s.Close();
            }
        }
    }
}
