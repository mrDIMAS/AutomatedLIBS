using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace C_Sharp_Application
{
	/// <summary>
	/// Zusammendfassende Beschreibung für AnalogIO.
	/// </summary>
	public class DigitalIO : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gbOutputs;
		private System.Windows.Forms.GroupBox gbInputs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox chkPWM1;
		private System.Windows.Forms.CheckBox chkPWM3;
		private System.Windows.Forms.CheckBox chkPWM2;
		private System.Windows.Forms.CheckBox chkPWM5;
		private System.Windows.Forms.CheckBox chkPWM7;
		private System.Windows.Forms.CheckBox chkPWM6;
		private System.Windows.Forms.TextBox edtDuty1;
		private System.Windows.Forms.TextBox edtDuty2;
		private System.Windows.Forms.TextBox edtDuty3;
		private System.Windows.Forms.TextBox edtDuty5;
		private System.Windows.Forms.TextBox edtDuty6;
		private System.Windows.Forms.TextBox edtDuty7;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox edtFreq123;
		private System.Windows.Forms.TextBox edtFreq567;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.CheckBox chkDI3;
		private System.Windows.Forms.CheckBox chkDI1;
		private System.Windows.Forms.CheckBox chkDI2;
		private System.Windows.Forms.Button btnGetDigIn;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.CheckBox chkDO1;
		private System.Windows.Forms.CheckBox chkDO2;
		private System.Windows.Forms.CheckBox chkDO3;
		private System.Windows.Forms.CheckBox chkDO4;
		private System.Windows.Forms.CheckBox chkDO5;
		private System.Windows.Forms.CheckBox chkDO10;
		private System.Windows.Forms.CheckBox chkDO6;
		private System.Windows.Forms.CheckBox chkDO7;
		private System.Windows.Forms.CheckBox chkDO8;
		private System.Windows.Forms.CheckBox chkDO9;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		public long m_DeviceHandle;	
		private System.ComponentModel.Container components = null;

		public DigitalIO()
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
			this.gbOutputs = new System.Windows.Forms.GroupBox();
			this.gbInputs = new System.Windows.Forms.GroupBox();
			this.chkDO1 = new System.Windows.Forms.CheckBox();
			this.chkDO2 = new System.Windows.Forms.CheckBox();
			this.chkDO3 = new System.Windows.Forms.CheckBox();
			this.chkDO4 = new System.Windows.Forms.CheckBox();
			this.chkDO5 = new System.Windows.Forms.CheckBox();
			this.chkDO10 = new System.Windows.Forms.CheckBox();
			this.chkDO6 = new System.Windows.Forms.CheckBox();
			this.chkDO7 = new System.Windows.Forms.CheckBox();
			this.chkDO8 = new System.Windows.Forms.CheckBox();
			this.chkDO9 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.chkPWM1 = new System.Windows.Forms.CheckBox();
			this.chkPWM3 = new System.Windows.Forms.CheckBox();
			this.chkPWM2 = new System.Windows.Forms.CheckBox();
			this.chkPWM5 = new System.Windows.Forms.CheckBox();
			this.chkPWM7 = new System.Windows.Forms.CheckBox();
			this.chkPWM6 = new System.Windows.Forms.CheckBox();
			this.edtDuty1 = new System.Windows.Forms.TextBox();
			this.edtDuty2 = new System.Windows.Forms.TextBox();
			this.edtDuty3 = new System.Windows.Forms.TextBox();
			this.edtDuty5 = new System.Windows.Forms.TextBox();
			this.edtDuty6 = new System.Windows.Forms.TextBox();
			this.edtDuty7 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.edtFreq123 = new System.Windows.Forms.TextBox();
			this.edtFreq567 = new System.Windows.Forms.TextBox();
			this.chkDI3 = new System.Windows.Forms.CheckBox();
			this.chkDI1 = new System.Windows.Forms.CheckBox();
			this.chkDI2 = new System.Windows.Forms.CheckBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.btnGetDigIn = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.gbOutputs.SuspendLayout();
			this.gbInputs.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbOutputs
			// 
			this.gbOutputs.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label12,
																					this.label11,
																					this.edtDuty1,
																					this.label2,
																					this.label1,
																					this.chkDO1,
																					this.chkDO2,
																					this.chkDO3,
																					this.chkDO4,
																					this.chkDO5,
																					this.chkDO10,
																					this.chkDO6,
																					this.chkDO7,
																					this.chkDO8,
																					this.chkDO9,
																					this.label3,
																					this.label4,
																					this.label5,
																					this.label6,
																					this.label7,
																					this.label8,
																					this.label9,
																					this.label10,
																					this.chkPWM1,
																					this.chkPWM3,
																					this.chkPWM2,
																					this.chkPWM5,
																					this.chkPWM7,
																					this.chkPWM6,
																					this.edtDuty2,
																					this.edtDuty3,
																					this.edtDuty5,
																					this.edtDuty6,
																					this.edtDuty7,
																					this.edtFreq123,
																					this.edtFreq567});
			this.gbOutputs.Location = new System.Drawing.Point(8, 16);
			this.gbOutputs.Name = "gbOutputs";
			this.gbOutputs.Size = new System.Drawing.Size(440, 304);
			this.gbOutputs.TabIndex = 0;
			this.gbOutputs.TabStop = false;
			this.gbOutputs.Text = "Digital Outputs";
			// 
			// gbInputs
			// 
			this.gbInputs.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.btnGetDigIn,
																				   this.chkDI3,
																				   this.chkDI1,
																				   this.chkDI2,
																				   this.label13,
																				   this.label14,
																				   this.label15});
			this.gbInputs.Location = new System.Drawing.Point(8, 328);
			this.gbInputs.Name = "gbInputs";
			this.gbInputs.Size = new System.Drawing.Size(448, 112);
			this.gbInputs.TabIndex = 1;
			this.gbInputs.TabStop = false;
			this.gbInputs.Text = "Digital Inputs";
			// 
			// chkDO1
			// 
			this.chkDO1.Location = new System.Drawing.Point(72, 56);
			this.chkDO1.Name = "chkDO1";
			this.chkDO1.Size = new System.Drawing.Size(64, 16);
			this.chkDO1.TabIndex = 0;
			this.chkDO1.Text = "DO1";
			this.chkDO1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// chkDO2
			// 
			this.chkDO2.Location = new System.Drawing.Point(72, 80);
			this.chkDO2.Name = "chkDO2";
			this.chkDO2.Size = new System.Drawing.Size(56, 16);
			this.chkDO2.TabIndex = 0;
			this.chkDO2.Text = "DO2";
			this.chkDO2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// chkDO3
			// 
			this.chkDO3.Location = new System.Drawing.Point(72, 104);
			this.chkDO3.Name = "chkDO3";
			this.chkDO3.Size = new System.Drawing.Size(56, 16);
			this.chkDO3.TabIndex = 0;
			this.chkDO3.Text = "DO3";
			this.chkDO3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// chkDO4
			// 
			this.chkDO4.Location = new System.Drawing.Point(72, 128);
			this.chkDO4.Name = "chkDO4";
			this.chkDO4.Size = new System.Drawing.Size(56, 16);
			this.chkDO4.TabIndex = 0;
			this.chkDO4.Text = "DO4";
			this.chkDO4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// chkDO5
			// 
			this.chkDO5.Location = new System.Drawing.Point(72, 152);
			this.chkDO5.Name = "chkDO5";
			this.chkDO5.Size = new System.Drawing.Size(64, 16);
			this.chkDO5.TabIndex = 0;
			this.chkDO5.Text = "DO5";
			this.chkDO5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// chkDO10
			// 
			this.chkDO10.Location = new System.Drawing.Point(72, 272);
			this.chkDO10.Name = "chkDO10";
			this.chkDO10.Size = new System.Drawing.Size(88, 16);
			this.chkDO10.TabIndex = 0;
			this.chkDO10.Text = "DO10";
			this.chkDO10.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
			// 
			// chkDO6
			// 
			this.chkDO6.Location = new System.Drawing.Point(72, 176);
			this.chkDO6.Name = "chkDO6";
			this.chkDO6.Size = new System.Drawing.Size(56, 16);
			this.chkDO6.TabIndex = 0;
			this.chkDO6.Text = "DO6";
			this.chkDO6.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
			// 
			// chkDO7
			// 
			this.chkDO7.Location = new System.Drawing.Point(72, 200);
			this.chkDO7.Name = "chkDO7";
			this.chkDO7.Size = new System.Drawing.Size(56, 16);
			this.chkDO7.TabIndex = 0;
			this.chkDO7.Text = "DO7";
			this.chkDO7.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
			// 
			// chkDO8
			// 
			this.chkDO8.Location = new System.Drawing.Point(72, 224);
			this.chkDO8.Name = "chkDO8";
			this.chkDO8.Size = new System.Drawing.Size(88, 16);
			this.chkDO8.TabIndex = 0;
			this.chkDO8.Text = "DO8";
			this.chkDO8.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
			// 
			// chkDO9
			// 
			this.chkDO9.Location = new System.Drawing.Point(72, 248);
			this.chkDO9.Name = "chkDO9";
			this.chkDO9.Size = new System.Drawing.Size(88, 16);
			this.chkDO9.TabIndex = 0;
			this.chkDO9.Text = "DO9";
			this.chkDO9.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "pin 11";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "pin 2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "pin 20";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "pin 12";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "pin 3";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "pin 21";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 200);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.TabIndex = 2;
			this.label7.Text = "pin 13";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 224);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "pin 4";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 248);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 16);
			this.label9.TabIndex = 2;
			this.label9.Text = "pin 22";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 272);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 16);
			this.label10.TabIndex = 2;
			this.label10.Text = "pin 25";
			// 
			// chkPWM1
			// 
			this.chkPWM1.Location = new System.Drawing.Point(152, 56);
			this.chkPWM1.Name = "chkPWM1";
			this.chkPWM1.Size = new System.Drawing.Size(64, 16);
			this.chkPWM1.TabIndex = 0;
			this.chkPWM1.Text = "PWM";
			this.chkPWM1.CheckedChanged += new System.EventHandler(this.chkPWM1_CheckedChanged);
			// 
			// chkPWM3
			// 
			this.chkPWM3.Location = new System.Drawing.Point(152, 104);
			this.chkPWM3.Name = "chkPWM3";
			this.chkPWM3.Size = new System.Drawing.Size(64, 16);
			this.chkPWM3.TabIndex = 0;
			this.chkPWM3.Text = "PWM";
			this.chkPWM3.CheckedChanged += new System.EventHandler(this.chkPWM3_CheckedChanged);
			// 
			// chkPWM2
			// 
			this.chkPWM2.Location = new System.Drawing.Point(152, 80);
			this.chkPWM2.Name = "chkPWM2";
			this.chkPWM2.Size = new System.Drawing.Size(64, 16);
			this.chkPWM2.TabIndex = 0;
			this.chkPWM2.Text = "PWM";
			this.chkPWM2.CheckedChanged += new System.EventHandler(this.chkPWM2_CheckedChanged);
			// 
			// chkPWM5
			// 
			this.chkPWM5.Location = new System.Drawing.Point(152, 152);
			this.chkPWM5.Name = "chkPWM5";
			this.chkPWM5.Size = new System.Drawing.Size(64, 16);
			this.chkPWM5.TabIndex = 0;
			this.chkPWM5.Text = "PWM";
			this.chkPWM5.CheckedChanged += new System.EventHandler(this.chkPWM5_CheckedChanged);
			// 
			// chkPWM7
			// 
			this.chkPWM7.Location = new System.Drawing.Point(152, 200);
			this.chkPWM7.Name = "chkPWM7";
			this.chkPWM7.Size = new System.Drawing.Size(64, 16);
			this.chkPWM7.TabIndex = 0;
			this.chkPWM7.Text = "PWM";
			this.chkPWM7.CheckedChanged += new System.EventHandler(this.chkPWM7_CheckedChanged);
			// 
			// chkPWM6
			// 
			this.chkPWM6.Location = new System.Drawing.Point(152, 176);
			this.chkPWM6.Name = "chkPWM6";
			this.chkPWM6.Size = new System.Drawing.Size(64, 16);
			this.chkPWM6.TabIndex = 0;
			this.chkPWM6.Text = "PWM";
			this.chkPWM6.CheckedChanged += new System.EventHandler(this.chkPWM6_CheckedChanged);
			// 
			// edtDuty1
			// 
			this.edtDuty1.Location = new System.Drawing.Point(224, 56);
			this.edtDuty1.Name = "edtDuty1";
			this.edtDuty1.Size = new System.Drawing.Size(72, 22);
			this.edtDuty1.TabIndex = 3;
			this.edtDuty1.Text = "50";
			// 
			// edtDuty2
			// 
			this.edtDuty2.Location = new System.Drawing.Point(224, 80);
			this.edtDuty2.Name = "edtDuty2";
			this.edtDuty2.Size = new System.Drawing.Size(72, 22);
			this.edtDuty2.TabIndex = 3;
			this.edtDuty2.Text = "50";
			// 
			// edtDuty3
			// 
			this.edtDuty3.Location = new System.Drawing.Point(224, 104);
			this.edtDuty3.Name = "edtDuty3";
			this.edtDuty3.Size = new System.Drawing.Size(72, 22);
			this.edtDuty3.TabIndex = 3;
			this.edtDuty3.Text = "50";
			// 
			// edtDuty5
			// 
			this.edtDuty5.Location = new System.Drawing.Point(224, 152);
			this.edtDuty5.Name = "edtDuty5";
			this.edtDuty5.Size = new System.Drawing.Size(72, 22);
			this.edtDuty5.TabIndex = 3;
			this.edtDuty5.Text = "50";
			// 
			// edtDuty6
			// 
			this.edtDuty6.Location = new System.Drawing.Point(224, 176);
			this.edtDuty6.Name = "edtDuty6";
			this.edtDuty6.Size = new System.Drawing.Size(72, 22);
			this.edtDuty6.TabIndex = 3;
			this.edtDuty6.Text = "50";
			// 
			// edtDuty7
			// 
			this.edtDuty7.Location = new System.Drawing.Point(224, 200);
			this.edtDuty7.Name = "edtDuty7";
			this.edtDuty7.Size = new System.Drawing.Size(72, 22);
			this.edtDuty7.TabIndex = 3;
			this.edtDuty7.Text = "50";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(224, 24);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 16);
			this.label11.TabIndex = 4;
			this.label11.Text = "DutyCycle %";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(328, 24);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 32);
			this.label12.TabIndex = 5;
			this.label12.Text = "Frequency (500-300000 Hz)";
			// 
			// edtFreq123
			// 
			this.edtFreq123.Location = new System.Drawing.Point(336, 80);
			this.edtFreq123.Name = "edtFreq123";
			this.edtFreq123.Size = new System.Drawing.Size(72, 22);
			this.edtFreq123.TabIndex = 3;
			this.edtFreq123.Text = "1000";
			// 
			// edtFreq567
			// 
			this.edtFreq567.Location = new System.Drawing.Point(336, 176);
			this.edtFreq567.Name = "edtFreq567";
			this.edtFreq567.Size = new System.Drawing.Size(72, 22);
			this.edtFreq567.TabIndex = 3;
			this.edtFreq567.Text = "1000";
			// 
			// chkDI3
			// 
			this.chkDI3.Location = new System.Drawing.Point(72, 84);
			this.chkDI3.Name = "chkDI3";
			this.chkDI3.Size = new System.Drawing.Size(64, 16);
			this.chkDI3.TabIndex = 5;
			this.chkDI3.Text = "DI3";
			// 
			// chkDI1
			// 
			this.chkDI1.Location = new System.Drawing.Point(72, 36);
			this.chkDI1.Name = "chkDI1";
			this.chkDI1.Size = new System.Drawing.Size(64, 16);
			this.chkDI1.TabIndex = 4;
			this.chkDI1.Text = "DI1";
			// 
			// chkDI2
			// 
			this.chkDI2.Location = new System.Drawing.Point(72, 60);
			this.chkDI2.Name = "chkDI2";
			this.chkDI2.Size = new System.Drawing.Size(64, 16);
			this.chkDI2.TabIndex = 3;
			this.chkDI2.Text = "DI2";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(16, 36);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 16);
			this.label13.TabIndex = 8;
			this.label13.Text = "pin 24";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(16, 60);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(48, 16);
			this.label14.TabIndex = 7;
			this.label14.Text = "pin 7";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(16, 84);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(48, 16);
			this.label15.TabIndex = 6;
			this.label15.Text = "pin 16";
			// 
			// btnGetDigIn
			// 
			this.btnGetDigIn.Location = new System.Drawing.Point(152, 56);
			this.btnGetDigIn.Name = "btnGetDigIn";
			this.btnGetDigIn.Size = new System.Drawing.Size(120, 23);
			this.btnGetDigIn.TabIndex = 9;
			this.btnGetDigIn.Text = "Get Digital Inputs";
			this.btnGetDigIn.Click += new System.EventHandler(this.btnGetDigIn_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(184, 456);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// DigitalIO
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(464, 488);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnClose,
																		  this.gbInputs,
																		  this.gbOutputs});
			this.Name = "DigitalIO";
			this.Text = "DigitalIO";
			this.gbOutputs.ResumeLayout(false);
			this.gbInputs.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		/**********************************************************************/
		private void OutputClick(byte a_Id, byte a_Value)
		{
			int l_Res = 0;
			uint l_Freq;
			byte l_Perc;

			if (((a_Id==0)||(a_Id==1)||(a_Id==2)||(a_Id==4)||(a_Id==5)||(a_Id==6)) && (a_Value==1))
			{
				switch (a_Id)
				{
					case 0 : 
						if (chkPWM1.Checked)
						{
							l_Perc = System.Convert.ToByte(edtDuty1.Text);
							l_Freq = System.Convert.ToUInt32(edtFreq123.Text);
							l_Res = avaspec.AVS_SetPwmOut((IntPtr)m_DeviceHandle, a_Id, l_Freq, l_Perc);
						}
						else
							l_Res = avaspec.AVS_SetDigOut((IntPtr)m_DeviceHandle, a_Id, a_Value);
					break;
						/////////////
					case 1 : 
						if (chkPWM2.Checked)
						{
							l_Perc = System.Convert.ToByte(edtDuty2.Text);
							l_Freq = System.Convert.ToUInt32(edtFreq123.Text);
							l_Res = avaspec.AVS_SetPwmOut((IntPtr)m_DeviceHandle, a_Id, l_Freq, l_Perc);
						}
						else
							l_Res = avaspec.AVS_SetDigOut((IntPtr)m_DeviceHandle, a_Id, a_Value);
					break;
						/////////////
					case 2 : 
						if (chkPWM3.Checked)
						{
							l_Perc = System.Convert.ToByte(edtDuty3.Text);
							l_Freq = System.Convert.ToUInt32(edtFreq123.Text);

							l_Res = avaspec.AVS_SetPwmOut((IntPtr)m_DeviceHandle, a_Id, l_Freq, l_Perc);
						}
						else
							l_Res = avaspec.AVS_SetDigOut((IntPtr)m_DeviceHandle, a_Id, a_Value);
					break;
					case 4 : 
						if (chkPWM5.Checked)
						{
							l_Perc = System.Convert.ToByte(edtDuty5.Text);
							l_Freq = System.Convert.ToUInt32(edtFreq567.Text);
							l_Res = avaspec.AVS_SetPwmOut((IntPtr)m_DeviceHandle, a_Id, l_Freq, l_Perc);
						}
						else
							l_Res = avaspec.AVS_SetDigOut((IntPtr)m_DeviceHandle, a_Id, a_Value);
					break;
					case 5 : 
						if (chkPWM6.Checked)
						{
							l_Perc = System.Convert.ToByte(edtDuty6.Text);
							l_Freq = System.Convert.ToUInt32(edtFreq567.Text);
							l_Res = avaspec.AVS_SetPwmOut((IntPtr)m_DeviceHandle, a_Id, l_Freq, l_Perc);
						}
						else
							l_Res = avaspec.AVS_SetDigOut((IntPtr)m_DeviceHandle, a_Id, a_Value);
					break;
					case 6 : 
						if (chkPWM7.Checked)
						{
							l_Perc = System.Convert.ToByte(edtDuty7.Text);
							l_Freq = System.Convert.ToUInt32(edtFreq567.Text);
							l_Res = avaspec.AVS_SetPwmOut((IntPtr)m_DeviceHandle, a_Id, l_Freq, l_Perc);
						}
						else
							l_Res = avaspec.AVS_SetDigOut((IntPtr)m_DeviceHandle, a_Id, a_Value);
						break;
			}
			}
			else
			{
				l_Res = avaspec.AVS_SetDigOut((IntPtr)m_DeviceHandle, a_Id, a_Value);
			}

			if (l_Res != avaspec.ERR_SUCCESS)
			{
				MessageBox.Show ("Communication Error", "DigitalIO", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
	
			}
		}

		/**********************************************************************/
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(0, System.Convert.ToByte(chkDO1.Checked));
			
		}
		/**********************************************************************/
		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(1, System.Convert.ToByte(chkDO2.Checked));
		}
		/**********************************************************************/
		
		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(2, System.Convert.ToByte(chkDO3.Checked));
		}
		/**********************************************************************/
		
		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(3, System.Convert.ToByte(chkDO4.Checked));
		}
		/**********************************************************************/
		
		private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(4, System.Convert.ToByte(chkDO5.Checked));
		}
		/**********************************************************************/
		
		private void checkBox6_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(5, System.Convert.ToByte(chkDO6.Checked));
		}
		/**********************************************************************/
		
		private void checkBox7_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(6, System.Convert.ToByte(chkDO7.Checked));
		}
		/**********************************************************************/
		
		private void checkBox8_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(7, System.Convert.ToByte(chkDO8.Checked));
		}
		/**********************************************************************/
		
		private void checkBox9_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(8, System.Convert.ToByte(chkDO9.Checked));
		}
		/**********************************************************************/
		private void checkBox10_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(9, System.Convert.ToByte(chkDO10.Checked));
		}
		/**********************************************************************/
		private void chkPWM1_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(0, System.Convert.ToByte(chkDO1.Checked));
		}
		/**********************************************************************/
		private void chkPWM2_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(1, System.Convert.ToByte(chkDO2.Checked));
		}
		/**********************************************************************/
		private void chkPWM3_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(2, System.Convert.ToByte(chkDO3.Checked));
		}
		/**********************************************************************/
		private void chkPWM5_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(4, System.Convert.ToByte(chkDO5.Checked));
		}
		/**********************************************************************/
		private void chkPWM6_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(5, System.Convert.ToByte(chkDO6.Checked));
		}
		/**********************************************************************/
		private void chkPWM7_CheckedChanged(object sender, System.EventArgs e)
		{
			OutputClick(6, System.Convert.ToByte(chkDO7.Checked));
		}


		/**********************************************************************/
		private void btnGetDigIn_Click(object sender, System.EventArgs e)
		{
			const byte  NR_OF_DIGITAL_INPUTS    = 3;
			const byte  DIG_IN0                 = 0;
			const byte  DIG_IN1                 = 1;
			const byte  DIG_IN2                 = 2;

			byte[]  l_Value = new byte[NR_OF_DIGITAL_INPUTS];
			bool    l_bNoError = true;

			for (byte i = 0; (i < NR_OF_DIGITAL_INPUTS) && l_bNoError; ++i)
			{
				l_bNoError = (avaspec.ERR_SUCCESS == avaspec.AVS_GetDigIn((IntPtr)m_DeviceHandle, i, ref l_Value[i]));
			}

			if (l_bNoError)
			{
				chkDI1.Enabled = true;
				if(l_Value[DIG_IN0] > 0)
					chkDI1.Checked = true; 
				else
					chkDI1.Checked = false;
				chkDI1.Enabled = false;
				
				chkDI2.Enabled = true;
				if(l_Value[DIG_IN1] > 0)
					chkDI2.Checked = true; 
				else
					chkDI2.Checked = false;
				chkDI2.Enabled = false;

				chkDI3.Enabled = true;
				if(l_Value[DIG_IN2] > 0)
					chkDI3.Checked = true; 
				else
					chkDI3.Checked = false;
				chkDI3.Enabled = false;
			}
			else
			{
				MessageBox.Show ("Writting Digital Output failt!", "DigitalIO", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		/**********************************************************************/
		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
	}
}
