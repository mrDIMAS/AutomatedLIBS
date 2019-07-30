using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedLIBS {
    public partial class LineBaseVisualizer : Form {
        private List<Ion> mIonsBase;

        public LineBaseVisualizer(List<Ion> ionsBase) {
            mIonsBase = ionsBase;

            InitializeComponent();
        }

        private void LineBaseVisualizer_Load(object sender, EventArgs e) {
            dgwIons.Columns.Add("Name", "Name");
            dgwIons.Columns.Add("Wavelength", "Wavelength, nm");
            dgwIons.Columns.Add("RelInt", "Relative Intensity");
            dgwIons.Columns.Add("Transition", "Transition Probability Aki, s^-1");
            dgwIons.Columns.Add("Ei", "Ei, eV");
            dgwIons.Columns.Add("Ek", "Ek, eV");
            dgwIons.Columns.Add("gi", "gi");
            dgwIons.Columns.Add("gk", "gk");

            foreach (var ion in mIonsBase) {
                int row = dgwIons.Rows.Add();
                dgwIons.Rows[row].Cells[0].Value = ion.mName;
                dgwIons.Rows[row].Cells[1].Value = ion.mWavelength;
                dgwIons.Rows[row].Cells[2].Value = ion.mRelativeIntensity;
                dgwIons.Rows[row].Cells[3].Value = ion.mTransitionStrenghtStr;
                dgwIons.Rows[row].Cells[4].Value = ion.mEi;
                dgwIons.Rows[row].Cells[5].Value = ion.mEk;
                dgwIons.Rows[row].Cells[6].Value = ion.mgi;
                dgwIons.Rows[row].Cells[7].Value = ion.mgk;
            }
        }

        private void LineBaseVisualizer_Resize(object sender, EventArgs e) {

            dgwIons.Size = new Size(ClientSize.Width - 30, ClientSize.Height - 35);

        }

        private void dgwIons_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
