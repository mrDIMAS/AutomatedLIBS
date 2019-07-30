using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace C_Sharp_Application
{
	/// <summary>
	/// Zusammendfassende Beschreibung für DigitalIO.
	/// </summary>
	public class AnalogIO : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbAnalogOut;
		private System.Windows.Forms.GroupBox gbAnalogInput26;
		private System.Windows.Forms.GroupBox gbAnalogInOnboard;
		private System.Windows.Forms.TextBox edtAI1;
		private System.Windows.Forms.TextBox edtAI0;
		private System.Windows.Forms.TextBox edtAI2;
		private System.Windows.Forms.TextBox edtAI3;
		private System.Windows.Forms.TextBox edtAI6;
		private System.Windows.Forms.TextBox edtAI7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnGetOnboardAI;
		private System.Windows.Forms.Button btnGetAnalogIn;
		private System.Windows.Forms.Button btnSetAnalogOut;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox edtAI5;
		private System.Windows.Forms.TextBox edtAI4;
		private System.Windows.Forms.TextBox edtAO1;
		private System.Windows.Forms.TextBox edtAO2;
		private System.Windows.Forms.Button btnClose;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		
		public long m_DeviceHandle;	

		private System.ComponentModel.Container components = null;

		public AnalogIO()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.gbAnalogOut = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edtAO2 = new System.Windows.Forms.TextBox();
            this.edtAO1 = new System.Windows.Forms.TextBox();
            this.btnSetAnalogOut = new System.Windows.Forms.Button();
            this.gbAnalogInput26 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edtAI4 = new System.Windows.Forms.TextBox();
            this.edtAI5 = new System.Windows.Forms.TextBox();
            this.btnGetAnalogIn = new System.Windows.Forms.Button();
            this.gbAnalogInOnboard = new System.Windows.Forms.GroupBox();
            this.btnGetOnboardAI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edtAI1 = new System.Windows.Forms.TextBox();
            this.edtAI0 = new System.Windows.Forms.TextBox();
            this.edtAI2 = new System.Windows.Forms.TextBox();
            this.edtAI3 = new System.Windows.Forms.TextBox();
            this.edtAI6 = new System.Windows.Forms.TextBox();
            this.edtAI7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbAnalogOut.SuspendLayout();
            this.gbAnalogInput26.SuspendLayout();
            this.gbAnalogInOnboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAnalogOut
            // 
            this.gbAnalogOut.Controls.Add(this.label10);
            this.gbAnalogOut.Controls.Add(this.label9);
            this.gbAnalogOut.Controls.Add(this.edtAO2);
            this.gbAnalogOut.Controls.Add(this.edtAO1);
            this.gbAnalogOut.Controls.Add(this.btnSetAnalogOut);
            this.gbAnalogOut.Location = new System.Drawing.Point(7, 7);
            this.gbAnalogOut.Name = "gbAnalogOut";
            this.gbAnalogOut.Size = new System.Drawing.Size(316, 69);
            this.gbAnalogOut.TabIndex = 0;
            this.gbAnalogOut.TabStop = false;
            this.gbAnalogOut.Text = "Analog Output";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "pin 26 (AO2)";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 14);
            this.label9.TabIndex = 6;
            this.label9.Text = "pin 17 (AO1)";
            // 
            // edtAO2
            // 
            this.edtAO2.Location = new System.Drawing.Point(93, 42);
            this.edtAO2.Name = "edtAO2";
            this.edtAO2.Size = new System.Drawing.Size(87, 20);
            this.edtAO2.TabIndex = 5;
            this.edtAO2.Text = "0";
            // 
            // edtAO1
            // 
            this.edtAO1.Location = new System.Drawing.Point(93, 21);
            this.edtAO1.Name = "edtAO1";
            this.edtAO1.Size = new System.Drawing.Size(87, 20);
            this.edtAO1.TabIndex = 4;
            this.edtAO1.Text = "0";
            // 
            // btnSetAnalogOut
            // 
            this.btnSetAnalogOut.Location = new System.Drawing.Point(217, 28);
            this.btnSetAnalogOut.Name = "btnSetAnalogOut";
            this.btnSetAnalogOut.Size = new System.Drawing.Size(93, 27);
            this.btnSetAnalogOut.TabIndex = 3;
            this.btnSetAnalogOut.Text = "Set Analog Out";
            this.btnSetAnalogOut.Click += new System.EventHandler(this.btnSetAnalogOut_Click);
            // 
            // gbAnalogInput26
            // 
            this.gbAnalogInput26.Controls.Add(this.label8);
            this.gbAnalogInput26.Controls.Add(this.label7);
            this.gbAnalogInput26.Controls.Add(this.edtAI4);
            this.gbAnalogInput26.Controls.Add(this.edtAI5);
            this.gbAnalogInput26.Controls.Add(this.btnGetAnalogIn);
            this.gbAnalogInput26.Location = new System.Drawing.Point(7, 83);
            this.gbAnalogInput26.Name = "gbAnalogInput26";
            this.gbAnalogInput26.Size = new System.Drawing.Size(316, 70);
            this.gbAnalogInput26.TabIndex = 0;
            this.gbAnalogInput26.TabStop = false;
            this.gbAnalogInput26.Text = "Analog Input SUBD26-F connector";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "pin 18 (AI2)";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "pin 9 (AI1)";
            // 
            // edtAI4
            // 
            this.edtAI4.Location = new System.Drawing.Point(93, 42);
            this.edtAI4.Name = "edtAI4";
            this.edtAI4.Size = new System.Drawing.Size(87, 20);
            this.edtAI4.TabIndex = 5;
            // 
            // edtAI5
            // 
            this.edtAI5.Location = new System.Drawing.Point(93, 21);
            this.edtAI5.Name = "edtAI5";
            this.edtAI5.Size = new System.Drawing.Size(87, 20);
            this.edtAI5.TabIndex = 4;
            // 
            // btnGetAnalogIn
            // 
            this.btnGetAnalogIn.Location = new System.Drawing.Point(217, 28);
            this.btnGetAnalogIn.Name = "btnGetAnalogIn";
            this.btnGetAnalogIn.Size = new System.Drawing.Size(93, 27);
            this.btnGetAnalogIn.TabIndex = 3;
            this.btnGetAnalogIn.Text = "Get Analog In";
            this.btnGetAnalogIn.Click += new System.EventHandler(this.btnGetAnalogIn_Click);
            // 
            // gbAnalogInOnboard
            // 
            this.gbAnalogInOnboard.Controls.Add(this.btnGetOnboardAI);
            this.gbAnalogInOnboard.Controls.Add(this.label1);
            this.gbAnalogInOnboard.Controls.Add(this.edtAI1);
            this.gbAnalogInOnboard.Controls.Add(this.edtAI0);
            this.gbAnalogInOnboard.Controls.Add(this.edtAI2);
            this.gbAnalogInOnboard.Controls.Add(this.edtAI3);
            this.gbAnalogInOnboard.Controls.Add(this.edtAI6);
            this.gbAnalogInOnboard.Controls.Add(this.edtAI7);
            this.gbAnalogInOnboard.Controls.Add(this.label2);
            this.gbAnalogInOnboard.Controls.Add(this.label3);
            this.gbAnalogInOnboard.Controls.Add(this.label4);
            this.gbAnalogInOnboard.Controls.Add(this.label5);
            this.gbAnalogInOnboard.Controls.Add(this.label6);
            this.gbAnalogInOnboard.Location = new System.Drawing.Point(7, 159);
            this.gbAnalogInOnboard.Name = "gbAnalogInOnboard";
            this.gbAnalogInOnboard.Size = new System.Drawing.Size(316, 160);
            this.gbAnalogInOnboard.TabIndex = 1;
            this.gbAnalogInOnboard.TabStop = false;
            this.gbAnalogInOnboard.Text = "Onboard Analog Input";
            // 
            // btnGetOnboardAI
            // 
            this.btnGetOnboardAI.Location = new System.Drawing.Point(217, 69);
            this.btnGetOnboardAI.Name = "btnGetOnboardAI";
            this.btnGetOnboardAI.Size = new System.Drawing.Size(93, 28);
            this.btnGetOnboardAI.TabIndex = 2;
            this.btnGetOnboardAI.Text = "Get Onboard AI";
            this.btnGetOnboardAI.Click += new System.EventHandler(this.btnGetOnboardAI_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thermistor X11";
            // 
            // edtAI1
            // 
            this.edtAI1.Location = new System.Drawing.Point(93, 42);
            this.edtAI1.Name = "edtAI1";
            this.edtAI1.Size = new System.Drawing.Size(87, 20);
            this.edtAI1.TabIndex = 0;
            // 
            // edtAI0
            // 
            this.edtAI0.Location = new System.Drawing.Point(93, 21);
            this.edtAI0.Name = "edtAI0";
            this.edtAI0.Size = new System.Drawing.Size(87, 20);
            this.edtAI0.TabIndex = 0;
            // 
            // edtAI2
            // 
            this.edtAI2.Location = new System.Drawing.Point(93, 62);
            this.edtAI2.Name = "edtAI2";
            this.edtAI2.Size = new System.Drawing.Size(87, 20);
            this.edtAI2.TabIndex = 0;
            // 
            // edtAI3
            // 
            this.edtAI3.Location = new System.Drawing.Point(93, 83);
            this.edtAI3.Name = "edtAI3";
            this.edtAI3.Size = new System.Drawing.Size(87, 20);
            this.edtAI3.TabIndex = 0;
            // 
            // edtAI6
            // 
            this.edtAI6.Location = new System.Drawing.Point(93, 104);
            this.edtAI6.Name = "edtAI6";
            this.edtAI6.Size = new System.Drawing.Size(87, 20);
            this.edtAI6.TabIndex = 0;
            // 
            // edtAI7
            // 
            this.edtAI7.Location = new System.Drawing.Point(93, 125);
            this.edtAI7.Name = "edtAI7";
            this.edtAI7.Size = new System.Drawing.Size(87, 20);
            this.edtAI7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1V2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "5VIO";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "5VUSB";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "NTC1 X8";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "NTC2 X9";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(117, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AnalogIO
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(329, 410);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbAnalogOut);
            this.Controls.Add(this.gbAnalogInput26);
            this.Controls.Add(this.gbAnalogInOnboard);
            this.Name = "AnalogIO";
            this.Text = "AnalogIO";
            this.gbAnalogOut.ResumeLayout(false);
            this.gbAnalogOut.PerformLayout();
            this.gbAnalogInput26.ResumeLayout(false);
            this.gbAnalogInput26.PerformLayout();
            this.gbAnalogInOnboard.ResumeLayout(false);
            this.gbAnalogInOnboard.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
		/*******************************************************************/
		private void btnSetAnalogOut_Click(object sender, System.EventArgs e)
		{
			const int NR_OF_ANALOG_OUTPUTS = 2;
			float[] l_Value = new float[NR_OF_ANALOG_OUTPUTS];
			bool	l_bNoError = true;
			
			l_Value[0] = 0;
			l_Value[1] = 0; 

			if((edtAO1.Text.Length != 0))
			{
				l_Value[0] = System.Convert.ToSingle(edtAO1.Text);
			}

			if((edtAO2.Text.Length != 0))
			{
				l_Value[1] = System.Convert.ToSingle(edtAO2.Text);
			}

			for (byte i = 0; (i < NR_OF_ANALOG_OUTPUTS) && l_bNoError; ++i)
			{
				int l_Res = avaspec.AVS_SetAnalogOut((IntPtr)m_DeviceHandle, i, l_Value[i]);
				if (l_Res != avaspec.ERR_SUCCESS)
				{
					l_bNoError = false;
					MessageBox.Show ("Writing AO1/2 failed!", "AnalogIO", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);					
				}
			}
		}
		/*******************************************************************/
		private void btnGetAnalogIn_Click(object sender, System.EventArgs e)
		{
			const int NR_OF_ANALOG_INPUTS = 2;
			float[] l_Value = new float[NR_OF_ANALOG_INPUTS];

			int l_Res = avaspec.AVS_GetAnalogIn((IntPtr)m_DeviceHandle, 5, ref l_Value[0]);			
			if (l_Res != avaspec.ERR_SUCCESS)
			{
				MessageBox.Show ("Reading AI1 failed!", "AnalogIO", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else	
				edtAI5.Text = String.Format("{0:F2}",System.Convert.ToString(l_Value[0]));
			
			l_Res = avaspec.AVS_GetAnalogIn((IntPtr)m_DeviceHandle, 4, ref l_Value[1]);
			if (l_Res != avaspec.ERR_SUCCESS)
			{
				MessageBox.Show ("Reading AI2 failed!", "AnalogIO", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				edtAI4.Text =String.Format("{0:F2}",System.Convert.ToString(l_Value[1]));

		}
		/*******************************************************************/
		private void btnGetOnboardAI_Click(object sender, System.EventArgs e)
		{
			float   l_Value = 0;
			int l_Res = avaspec.AVS_GetAnalogIn((IntPtr)m_DeviceHandle, 0, ref l_Value);
			switch(l_Res)
            {
                case avaspec.ERR_SUCCESS:
                    edtAI0.Text = String.Format("{0:F2}",System.Convert.ToString(l_Value));
                    break;
                case avaspec.ERR_INVALID_PARAMETER:
                    edtAI0.Text = "Not Available";
                    break;
                default:
			        MessageBox.Show ("Reading AI0 failed!", "AnalogIO", 
					    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
			}

            l_Res = avaspec.AVS_GetAnalogIn((IntPtr)m_DeviceHandle, 1, ref l_Value);
            switch (l_Res)
            {
                case avaspec.ERR_SUCCESS:
                    edtAI1.Text = String.Format("{0:F2}", System.Convert.ToString(l_Value));
                    break;
                case avaspec.ERR_INVALID_PARAMETER:
                    edtAI1.Text = "Not Available";
                    break;
                default:
                    MessageBox.Show("Reading AI1 failed!", "AnalogIO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

			l_Res = avaspec.AVS_GetAnalogIn((IntPtr)m_DeviceHandle, 2, ref l_Value);
            switch (l_Res)
            {
                case avaspec.ERR_SUCCESS:
                    edtAI2.Text = String.Format("{0:F2}", System.Convert.ToString(l_Value));
                    break;
                case avaspec.ERR_INVALID_PARAMETER:
                    edtAI2.Text = "Not Available";
                    break;
                default:
                    MessageBox.Show("Reading AI2 failed!", "AnalogIO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

			l_Res = avaspec.AVS_GetAnalogIn((IntPtr)m_DeviceHandle, 3, ref l_Value);
            switch (l_Res)
            {
                case avaspec.ERR_SUCCESS:
                    edtAI3.Text = String.Format("{0:F2}", System.Convert.ToString(l_Value));
                    break;
                case avaspec.ERR_INVALID_PARAMETER:
                    edtAI3.Text = "Not Available";
                    break;
                default:
                    MessageBox.Show("Reading AI3 failed!", "AnalogIO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

			l_Res = avaspec.AVS_GetAnalogIn((IntPtr)m_DeviceHandle, 6, ref l_Value);
            switch (l_Res)
            {
                case avaspec.ERR_SUCCESS:
                    edtAI6.Text = String.Format("{0:F2}", System.Convert.ToString(l_Value));
                    break;
                case avaspec.ERR_INVALID_PARAMETER:
                    edtAI6.Text = "Not Available";
                    break;
                default:
                    MessageBox.Show("Reading AI6 failed!", "AnalogIO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

			l_Res = avaspec.AVS_GetAnalogIn((IntPtr)m_DeviceHandle, 7, ref l_Value);
            switch (l_Res)
            {
                case avaspec.ERR_SUCCESS:
                    edtAI7.Text = String.Format("{0:F2}", System.Convert.ToString(l_Value));
                    break;
                case avaspec.ERR_INVALID_PARAMETER:
                    edtAI7.Text = "Not Available";
                    break;
                default:
                    MessageBox.Show("Reading AI7 failed!", "AnalogIO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
		}
		/*******************************************************************/
		
		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		

	}
}
