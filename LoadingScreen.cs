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
    public partial class LoadingScreen : Form {
        public LoadingScreen(string loadingText) {            
            InitializeComponent();
            lblLoadingText.Text = loadingText;
        }

        private void LoadingScreen_Load(object sender, EventArgs e) {

        }

        public void SetProgress(int value) {
            if (value > pbProgress.Maximum) {
                value = pbProgress.Maximum;
            }

            pbProgress.Value = value; 
        }

        public void SetText(string loadingText) {
            lblLoadingText.Text = loadingText;
        }
    }
}
