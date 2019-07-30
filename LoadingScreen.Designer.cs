namespace AutomatedLIBS {
    partial class LoadingScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblLoadingText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(12, 50);
            this.pbProgress.MarqueeAnimationSpeed = 2;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(266, 23);
            this.pbProgress.TabIndex = 0;
            // 
            // lblLoadingText
            // 
            this.lblLoadingText.Location = new System.Drawing.Point(13, 13);
            this.lblLoadingText.Name = "lblLoadingText";
            this.lblLoadingText.Size = new System.Drawing.Size(265, 35);
            this.lblLoadingText.TabIndex = 1;
            this.lblLoadingText.Text = "Loading Text";
            this.lblLoadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(290, 79);
            this.Controls.Add(this.lblLoadingText);
            this.Controls.Add(this.pbProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(290, 79);
            this.MinimumSize = new System.Drawing.Size(290, 79);
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadingScreen";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblLoadingText;
    }
}