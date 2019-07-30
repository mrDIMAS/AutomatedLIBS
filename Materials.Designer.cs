namespace AutomatedLIBS
{
    partial class Materials
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveInterval = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddInterval = new System.Windows.Forms.Button();
            this.IntervalList = new System.Windows.Forms.ListBox();
            this.RangeTo = new System.Windows.Forms.NumericUpDown();
            this.RangeFrom = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MaterialsList = new System.Windows.Forms.ListBox();
            this.Apply = new System.Windows.Forms.Button();
            this.AddMaterial = new System.Windows.Forms.Button();
            this.RemoveMaterial = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MaterialName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RangeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeFrom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RemoveInterval);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddInterval);
            this.groupBox1.Controls.Add(this.IntervalList);
            this.groupBox1.Controls.Add(this.RangeTo);
            this.groupBox1.Controls.Add(this.RangeFrom);
            this.groupBox1.Location = new System.Drawing.Point(252, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 163);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Integration Intervals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "nm";
            // 
            // RemoveInterval
            // 
            this.RemoveInterval.Location = new System.Drawing.Point(132, 122);
            this.RemoveInterval.Name = "RemoveInterval";
            this.RemoveInterval.Size = new System.Drawing.Size(118, 23);
            this.RemoveInterval.TabIndex = 24;
            this.RemoveInterval.Text = "Remove Interval";
            this.RemoveInterval.UseVisualStyleBackColor = true;
            this.RemoveInterval.Click += new System.EventHandler(this.RemoveInterval_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "from";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "nm";
            // 
            // AddInterval
            // 
            this.AddInterval.Location = new System.Drawing.Point(132, 93);
            this.AddInterval.Name = "AddInterval";
            this.AddInterval.Size = new System.Drawing.Size(118, 23);
            this.AddInterval.TabIndex = 20;
            this.AddInterval.Text = "Add Interval";
            this.AddInterval.UseVisualStyleBackColor = true;
            this.AddInterval.Click += new System.EventHandler(this.AddInterval_Click);
            // 
            // IntervalList
            // 
            this.IntervalList.FormattingEnabled = true;
            this.IntervalList.Location = new System.Drawing.Point(6, 19);
            this.IntervalList.Name = "IntervalList";
            this.IntervalList.Size = new System.Drawing.Size(120, 134);
            this.IntervalList.TabIndex = 17;
            this.IntervalList.SelectedIndexChanged += new System.EventHandler(this.IntervalList_SelectedIndexChanged);
            // 
            // RangeTo
            // 
            this.RangeTo.Location = new System.Drawing.Point(168, 46);
            this.RangeTo.Maximum = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            this.RangeTo.Minimum = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.RangeTo.Name = "RangeTo";
            this.RangeTo.Size = new System.Drawing.Size(55, 20);
            this.RangeTo.TabIndex = 16;
            this.RangeTo.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // RangeFrom
            // 
            this.RangeFrom.Location = new System.Drawing.Point(168, 20);
            this.RangeFrom.Maximum = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            this.RangeFrom.Minimum = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.RangeFrom.Name = "RangeFrom";
            this.RangeFrom.Size = new System.Drawing.Size(55, 20);
            this.RangeFrom.TabIndex = 15;
            this.RangeFrom.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MaterialsList);
            this.groupBox2.Controls.Add(this.Apply);
            this.groupBox2.Controls.Add(this.AddMaterial);
            this.groupBox2.Controls.Add(this.RemoveMaterial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.MaterialName);
            this.groupBox2.Location = new System.Drawing.Point(4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 163);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material List";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // MaterialsList
            // 
            this.MaterialsList.FormattingEnabled = true;
            this.MaterialsList.Location = new System.Drawing.Point(6, 19);
            this.MaterialsList.Name = "MaterialsList";
            this.MaterialsList.Size = new System.Drawing.Size(107, 134);
            this.MaterialsList.TabIndex = 0;
            this.MaterialsList.SelectedIndexChanged += new System.EventHandler(this.MaterialsList_SelectedIndexChanged);
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(126, 122);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(107, 23);
            this.Apply.TabIndex = 18;
            this.Apply.Text = "Save and Close";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // AddMaterial
            // 
            this.AddMaterial.Location = new System.Drawing.Point(126, 64);
            this.AddMaterial.Name = "AddMaterial";
            this.AddMaterial.Size = new System.Drawing.Size(107, 23);
            this.AddMaterial.TabIndex = 12;
            this.AddMaterial.Text = "Add Material";
            this.AddMaterial.UseVisualStyleBackColor = true;
            this.AddMaterial.Click += new System.EventHandler(this.AddMaterial_Click);
            // 
            // RemoveMaterial
            // 
            this.RemoveMaterial.Location = new System.Drawing.Point(126, 93);
            this.RemoveMaterial.Name = "RemoveMaterial";
            this.RemoveMaterial.Size = new System.Drawing.Size(107, 23);
            this.RemoveMaterial.TabIndex = 13;
            this.RemoveMaterial.Text = "Remove Material";
            this.RemoveMaterial.UseVisualStyleBackColor = true;
            this.RemoveMaterial.Click += new System.EventHandler(this.RemoveMaterial_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Material Name";
            // 
            // MaterialName
            // 
            this.MaterialName.Location = new System.Drawing.Point(127, 38);
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Size = new System.Drawing.Size(107, 20);
            this.MaterialName.TabIndex = 15;
            this.MaterialName.TextChanged += new System.EventHandler(this.MaterialName_TextChanged);
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 174);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Materials";
            this.Text = "Materials";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Materials_FormClosed);
            this.Load += new System.EventHandler(this.Materials_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RangeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RangeFrom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddInterval;
        private System.Windows.Forms.ListBox IntervalList;
        private System.Windows.Forms.NumericUpDown RangeTo;
        private System.Windows.Forms.NumericUpDown RangeFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox MaterialsList;
        private System.Windows.Forms.Button AddMaterial;
        private System.Windows.Forms.Button RemoveMaterial;
        private System.Windows.Forms.TextBox MaterialName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Apply;
    }
}