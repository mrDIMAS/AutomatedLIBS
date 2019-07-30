namespace AutomatedLIBS
{
    partial class MaterialDetection
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
            this.components = new System.ComponentModel.Container();
            this.MaterialInfo = new System.Windows.Forms.ListBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.MaterialList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MaterialInfo
            // 
            this.MaterialInfo.FormattingEnabled = true;
            this.MaterialInfo.Location = new System.Drawing.Point(8, 48);
            this.MaterialInfo.Name = "MaterialInfo";
            this.MaterialInfo.Size = new System.Drawing.Size(205, 160);
            this.MaterialInfo.TabIndex = 0;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // MaterialList
            // 
            this.MaterialList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialList.FormattingEnabled = true;
            this.MaterialList.Location = new System.Drawing.Point(8, 13);
            this.MaterialList.Name = "MaterialList";
            this.MaterialList.Size = new System.Drawing.Size(205, 21);
            this.MaterialList.TabIndex = 1;
            this.MaterialList.SelectionChangeCommitted += new System.EventHandler(this.MaterialList_SelectedIndexChanged);
            this.MaterialList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaterialList_MouseClick);
            // 
            // MaterialDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 221);
            this.Controls.Add(this.MaterialList);
            this.Controls.Add(this.MaterialInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(231, 245);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(231, 245);
            this.Name = "MaterialDetection";
            this.Text = "Material Detection Info";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MaterialDetection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MaterialInfo;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.ComboBox MaterialList;
    }
}