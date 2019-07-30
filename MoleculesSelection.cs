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
    public partial class MoleculesSelection : Form {
        private MainWindow mMainWindow;
        public MoleculesSelection(MainWindow mainWindow) {
            mMainWindow = mainWindow;
            InitializeComponent();
        }

        private void MoleculesSelection_Load(object sender, EventArgs e) {

        }

        private void btnOK_Click(object sender, EventArgs e) {
            mMainWindow.mMolecules.Clear();
            foreach (var chk in lstMolecules.CheckedItems) {
                string[] tokens = chk.ToString().Split(' ');
                mMainWindow.mMolecules.Add(tokens[0] + ' ' + tokens[1], Convert.ToDouble(tokens[2]));
            }

            Close();
        }
    }
}
