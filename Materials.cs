using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatedLIBS {
    public partial class Materials : Form {
        public Materials() {
            InitializeComponent();
        }

        private void Materials_Load(object sender, EventArgs e) {
            Material.LoadBaseFromFile();

            UpdateMaterialList();
        }

        void UpdateMaterialList() {
            int selected = MaterialsList.SelectedIndex;

            MaterialsList.Items.Clear();

            if (Material.All != null) {
                for (int i = 0; i < Material.All.Count(); ++i) {
                    MaterialsList.Items.Add(Material.All[i].mName);
                }
            }

            if (selected < MaterialsList.Items.Count) {
                MaterialsList.SelectedIndex = selected;
            }
        }

        private void AddMaterial_Click(object sender, EventArgs e) {
            Material mat = new Material();

            if (MaterialName.Text.Count() > 0) {
                mat.mName = MaterialName.Text;
            }


            UpdateMaterialList();
        }

        private void RemoveMaterial_Click(object sender, EventArgs e) {
            if (Material.All != null) {
                if (MaterialsList.SelectedIndex >= 0) {
                    Material.All.Remove(Material.All[MaterialsList.SelectedIndex]);
                }
            }
            UpdateMaterialList();
        }

        private void Apply_Click(object sender, EventArgs e) {
            Close();
        }

        private void MaterialsList_SelectedIndexChanged(object sender, EventArgs e) {
            IntervalList.Items.Clear();
            if (MaterialsList.SelectedIndex >= 0) {
                if (Material.All != null) {
                    if (Material.All.Count() > 0) {
                        MaterialName.Text = Material.All[MaterialsList.SelectedIndex].mName;
                        UpdateIntervalList(Material.All[MaterialsList.SelectedIndex]);
                    }
                }
            }
        }

        private void MaterialName_TextChanged(object sender, EventArgs e) {
            if (MaterialsList.SelectedIndex >= 0) {
                if (Material.All != null) {
                    if (Material.All.Count() > 0) {
                        Material.All[MaterialsList.SelectedIndex].mName = MaterialName.Text;
                    }
                }
                UpdateMaterialList();
            }
        }

        void UpdateIntervalList(Material mat) {
            int selected = IntervalList.SelectedIndex;

            IntervalList.Items.Clear();
            for (int i = 0; i < mat.mRanges.Count(); ++i) {
                IntervalList.Items.Add(String.Format("{0} - {1} nm", mat.mRanges[i].from, mat.mRanges[i].to));
            }

            if (selected < IntervalList.Items.Count) {
                IntervalList.SelectedIndex = selected;
            }
        }

        private void AddInterval_Click(object sender, EventArgs e) {
            if (MaterialsList.SelectedIndex >= 0) {
                Material.All[MaterialsList.SelectedIndex].mRanges.Add(new Range((double)RangeFrom.Value, (double)RangeTo.Value));
                UpdateIntervalList(Material.All[MaterialsList.SelectedIndex]);
            }
        }

        private void RemoveInterval_Click_1(object sender, EventArgs e) {
            if (MaterialsList.SelectedIndex >= 0) {
                if (IntervalList.SelectedIndex >= 0) {
                    Material.All[MaterialsList.SelectedIndex].mRanges.Remove(Material.All[MaterialsList.SelectedIndex].mRanges[IntervalList.SelectedIndex]);
                }
                UpdateIntervalList(Material.All[MaterialsList.SelectedIndex]);
            }
        }

        private void IntervalList_SelectedIndexChanged(object sender, EventArgs e) {
            if (MaterialsList.SelectedIndex >= 0) {
                if (IntervalList.SelectedIndex >= 0) {
                    RangeFrom.Value = (decimal)Material.All[MaterialsList.SelectedIndex].mRanges[IntervalList.SelectedIndex].from;
                    RangeTo.Value = (decimal)Material.All[MaterialsList.SelectedIndex].mRanges[IntervalList.SelectedIndex].to;
                }
            }
        }

        private void Materials_FormClosed(object sender, FormClosedEventArgs e) {
            Material.WriteBaseToFile();
        }

        private void groupBox2_Enter(object sender, EventArgs e) {
            //MaterialsList.
        }
    }
}

class Range {
    public double from = 0.0;
    public double to = 0.0;
    public double mIntegral = 0.0;
    public bool mSingleLine = false;

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public Range(double f, double t) {
        from = f;
        to = t;
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public Range(double line) {
        from = line;
        mSingleLine = true;
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public string ShortName {
        get {
            if (mSingleLine) {
                return "Single Line: " + Math.Round(from, 2) + " nm";
            } else {
                return Math.Round(from, 2) + " - " + Math.Round(to, 2) + " nm";
            }
        }
    }
};

class Material {
    public string mName;
    public List<Range> mRanges;
    public double mIntegral;

    public static List<Material> All;

    public Material() {
        mName = "New material";
        mRanges = new List<Range>();

        if (All == null) {
            All = new List<Material>();
        }

        All.Add(this);
    }

    public static void WriteBaseToFile() {
        System.IO.StreamWriter file = new System.IO.StreamWriter("materials.dat");

        if (Material.All != null) {
            file.WriteLine(Material.All.Count());
            for (int i = 0; i < Material.All.Count(); ++i) {
                Material mat = Material.All[i];
                file.WriteLine(mat.mName);
                file.WriteLine(mat.mRanges.Count());
                for (int k = 0; k < mat.mRanges.Count(); ++k) {
                    file.WriteLine(mat.mRanges[k].from);
                    file.WriteLine(mat.mRanges[k].to);
                }
            }
        }

        file.Close();
    }

    public static void LoadBaseFromFile() {
        if (Material.All != null) {
            Material.All.Clear();
        }

        try {
            System.IO.StreamReader file = new System.IO.StreamReader("materials.dat");

            int materialCount = System.Convert.ToInt32(file.ReadLine());
            for (int i = 0; i < materialCount; ++i) {
                Material mat = new Material();

                mat.mName = file.ReadLine();
                int rangeCount = System.Convert.ToInt32(file.ReadLine());
                for (int j = 0; j < rangeCount; ++j) {
                    double from = System.Convert.ToDouble(file.ReadLine());
                    double to = System.Convert.ToDouble(file.ReadLine());
                    mat.mRanges.Add(new Range(from, to));
                }
            }

            file.Close();
        } catch (System.Exception) {
            MessageBox.Show("Unable to read materials database!");
        }
    }
}
