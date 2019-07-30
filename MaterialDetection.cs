using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomatedLIBS {
    public partial class MaterialDetection : Form {
        public MaterialDetection() {
            InitializeComponent();

            RebuildMaterialList();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e) {
            if (MaterialList.SelectedIndex >= 0) {
                MaterialInfo.Items.Clear();
                try {
                    var mat = Material.All[MaterialList.SelectedIndex];

                    MaterialInfo.Items.Add("Total integral is " + (Math.Round(mat.mIntegral, 5).ToString()));

                    foreach (Range range in mat.mRanges) {
                        float from = (float)range.from;
                        float to = (float)range.to;
                        MaterialInfo.Items.Add(from.ToString() + "nm - " + to.ToString() + " nm is " + Math.Round(range.mIntegral, 5));
                    }
                } catch (System.Exception) {

                }
            }
        }

        private void RebuildMaterialList() {
            MaterialList.Items.Clear();
            if (Material.All != null) {
                foreach (Material mat in Material.All) {
                    MaterialList.Items.Add(mat.mName);
                }
            }
        }

        private void MaterialList_MouseClick(object sender, MouseEventArgs e) {
            RebuildMaterialList();
        }

        private void MaterialList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void MaterialDetection_Load(object sender, EventArgs e) {

        }
    }
}
