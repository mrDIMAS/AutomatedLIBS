<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DigitalIO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.gbOutputs = New System.Windows.Forms.GroupBox
        Me.edtFreq567 = New System.Windows.Forms.TextBox
        Me.edtFreq123 = New System.Windows.Forms.TextBox
        Me.edtDuty7 = New System.Windows.Forms.TextBox
        Me.edtDuty3 = New System.Windows.Forms.TextBox
        Me.edtDuty6 = New System.Windows.Forms.TextBox
        Me.edtDuty2 = New System.Windows.Forms.TextBox
        Me.edtDuty5 = New System.Windows.Forms.TextBox
        Me.edtDuty1 = New System.Windows.Forms.TextBox
        Me.chkDO10 = New System.Windows.Forms.CheckBox
        Me.chkDO8 = New System.Windows.Forms.CheckBox
        Me.chkDO9 = New System.Windows.Forms.CheckBox
        Me.chkPWM7 = New System.Windows.Forms.CheckBox
        Me.chkDO7 = New System.Windows.Forms.CheckBox
        Me.chkPWM6 = New System.Windows.Forms.CheckBox
        Me.chkDO6 = New System.Windows.Forms.CheckBox
        Me.chkPWM5 = New System.Windows.Forms.CheckBox
        Me.chkDO5 = New System.Windows.Forms.CheckBox
        Me.chkDO4 = New System.Windows.Forms.CheckBox
        Me.chkPWM3 = New System.Windows.Forms.CheckBox
        Me.chkDO3 = New System.Windows.Forms.CheckBox
        Me.chkPWM2 = New System.Windows.Forms.CheckBox
        Me.chkDO2 = New System.Windows.Forms.CheckBox
        Me.chkPWM1 = New System.Windows.Forms.CheckBox
        Me.chkDO1 = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbInputs = New System.Windows.Forms.GroupBox
        Me.btnGetDigIn = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.chkDI2 = New System.Windows.Forms.CheckBox
        Me.chkDI1 = New System.Windows.Forms.CheckBox
        Me.chkDI3 = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbOutputs.SuspendLayout()
        Me.gbInputs.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(164, 448)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(112, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(22, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'gbOutputs
        '
        Me.gbOutputs.Controls.Add(Me.edtFreq567)
        Me.gbOutputs.Controls.Add(Me.edtFreq123)
        Me.gbOutputs.Controls.Add(Me.edtDuty7)
        Me.gbOutputs.Controls.Add(Me.edtDuty3)
        Me.gbOutputs.Controls.Add(Me.edtDuty6)
        Me.gbOutputs.Controls.Add(Me.edtDuty2)
        Me.gbOutputs.Controls.Add(Me.edtDuty5)
        Me.gbOutputs.Controls.Add(Me.edtDuty1)
        Me.gbOutputs.Controls.Add(Me.chkDO10)
        Me.gbOutputs.Controls.Add(Me.chkDO8)
        Me.gbOutputs.Controls.Add(Me.chkDO9)
        Me.gbOutputs.Controls.Add(Me.chkPWM7)
        Me.gbOutputs.Controls.Add(Me.chkDO7)
        Me.gbOutputs.Controls.Add(Me.chkPWM6)
        Me.gbOutputs.Controls.Add(Me.chkDO6)
        Me.gbOutputs.Controls.Add(Me.chkPWM5)
        Me.gbOutputs.Controls.Add(Me.chkDO5)
        Me.gbOutputs.Controls.Add(Me.chkDO4)
        Me.gbOutputs.Controls.Add(Me.chkPWM3)
        Me.gbOutputs.Controls.Add(Me.chkDO3)
        Me.gbOutputs.Controls.Add(Me.chkPWM2)
        Me.gbOutputs.Controls.Add(Me.chkDO2)
        Me.gbOutputs.Controls.Add(Me.chkPWM1)
        Me.gbOutputs.Controls.Add(Me.chkDO1)
        Me.gbOutputs.Controls.Add(Me.Label12)
        Me.gbOutputs.Controls.Add(Me.Label8)
        Me.gbOutputs.Controls.Add(Me.Label11)
        Me.gbOutputs.Controls.Add(Me.Label7)
        Me.gbOutputs.Controls.Add(Me.Label10)
        Me.gbOutputs.Controls.Add(Me.Label9)
        Me.gbOutputs.Controls.Add(Me.Label5)
        Me.gbOutputs.Controls.Add(Me.Label6)
        Me.gbOutputs.Controls.Add(Me.Label4)
        Me.gbOutputs.Controls.Add(Me.Label3)
        Me.gbOutputs.Controls.Add(Me.Label2)
        Me.gbOutputs.Controls.Add(Me.Label1)
        Me.gbOutputs.Location = New System.Drawing.Point(15, 16)
        Me.gbOutputs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbOutputs.Name = "gbOutputs"
        Me.gbOutputs.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbOutputs.Size = New System.Drawing.Size(385, 281)
        Me.gbOutputs.TabIndex = 1
        Me.gbOutputs.TabStop = False
        Me.gbOutputs.Text = "Digital Outputs"
        '
        'edtFreq567
        '
        Me.edtFreq567.Location = New System.Drawing.Point(266, 153)
        Me.edtFreq567.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtFreq567.Name = "edtFreq567"
        Me.edtFreq567.Size = New System.Drawing.Size(67, 20)
        Me.edtFreq567.TabIndex = 4
        Me.edtFreq567.Text = "1000"
        '
        'edtFreq123
        '
        Me.edtFreq123.Location = New System.Drawing.Point(266, 56)
        Me.edtFreq123.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtFreq123.Name = "edtFreq123"
        Me.edtFreq123.Size = New System.Drawing.Size(67, 20)
        Me.edtFreq123.TabIndex = 4
        Me.edtFreq123.Text = "1000"
        '
        'edtDuty7
        '
        Me.edtDuty7.Location = New System.Drawing.Point(170, 176)
        Me.edtDuty7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtDuty7.Name = "edtDuty7"
        Me.edtDuty7.Size = New System.Drawing.Size(67, 20)
        Me.edtDuty7.TabIndex = 4
        Me.edtDuty7.Text = "50"
        '
        'edtDuty3
        '
        Me.edtDuty3.Location = New System.Drawing.Point(170, 80)
        Me.edtDuty3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtDuty3.Name = "edtDuty3"
        Me.edtDuty3.Size = New System.Drawing.Size(67, 20)
        Me.edtDuty3.TabIndex = 4
        Me.edtDuty3.Text = "50"
        '
        'edtDuty6
        '
        Me.edtDuty6.Location = New System.Drawing.Point(170, 153)
        Me.edtDuty6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtDuty6.Name = "edtDuty6"
        Me.edtDuty6.Size = New System.Drawing.Size(67, 20)
        Me.edtDuty6.TabIndex = 4
        Me.edtDuty6.Text = "50"
        '
        'edtDuty2
        '
        Me.edtDuty2.Location = New System.Drawing.Point(170, 56)
        Me.edtDuty2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtDuty2.Name = "edtDuty2"
        Me.edtDuty2.Size = New System.Drawing.Size(67, 20)
        Me.edtDuty2.TabIndex = 4
        Me.edtDuty2.Text = "50"
        '
        'edtDuty5
        '
        Me.edtDuty5.Location = New System.Drawing.Point(170, 128)
        Me.edtDuty5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtDuty5.Name = "edtDuty5"
        Me.edtDuty5.Size = New System.Drawing.Size(67, 20)
        Me.edtDuty5.TabIndex = 4
        Me.edtDuty5.Text = "50"
        '
        'edtDuty1
        '
        Me.edtDuty1.Location = New System.Drawing.Point(170, 32)
        Me.edtDuty1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtDuty1.Name = "edtDuty1"
        Me.edtDuty1.Size = New System.Drawing.Size(67, 20)
        Me.edtDuty1.TabIndex = 4
        Me.edtDuty1.Text = "50"
        '
        'chkDO10
        '
        Me.chkDO10.AutoSize = True
        Me.chkDO10.Location = New System.Drawing.Point(52, 248)
        Me.chkDO10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDO10.Name = "chkDO10"
        Me.chkDO10.Size = New System.Drawing.Size(54, 17)
        Me.chkDO10.TabIndex = 3
        Me.chkDO10.Text = "DO10"
        Me.chkDO10.UseVisualStyleBackColor = True
        '
        'chkDO8
        '
        Me.chkDO8.AutoSize = True
        Me.chkDO8.Location = New System.Drawing.Point(52, 200)
        Me.chkDO8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDO8.Name = "chkDO8"
        Me.chkDO8.Size = New System.Drawing.Size(48, 17)
        Me.chkDO8.TabIndex = 3
        Me.chkDO8.Text = "DO8"
        Me.chkDO8.UseVisualStyleBackColor = True
        '
        'chkDO9
        '
        Me.chkDO9.AutoSize = True
        Me.chkDO9.Location = New System.Drawing.Point(52, 224)
        Me.chkDO9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDO9.Name = "chkDO9"
        Me.chkDO9.Size = New System.Drawing.Size(48, 17)
        Me.chkDO9.TabIndex = 3
        Me.chkDO9.Text = "DO9"
        Me.chkDO9.UseVisualStyleBackColor = True
        '
        'chkPWM7
        '
        Me.chkPWM7.AutoSize = True
        Me.chkPWM7.Location = New System.Drawing.Point(111, 176)
        Me.chkPWM7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPWM7.Name = "chkPWM7"
        Me.chkPWM7.Size = New System.Drawing.Size(53, 17)
        Me.chkPWM7.TabIndex = 3
        Me.chkPWM7.Text = "PWM"
        Me.chkPWM7.UseVisualStyleBackColor = True
        '
        'chkDO7
        '
        Me.chkDO7.AutoSize = True
        Me.chkDO7.Location = New System.Drawing.Point(52, 176)
        Me.chkDO7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDO7.Name = "chkDO7"
        Me.chkDO7.Size = New System.Drawing.Size(48, 17)
        Me.chkDO7.TabIndex = 3
        Me.chkDO7.Text = "DO7"
        Me.chkDO7.UseVisualStyleBackColor = True
        '
        'chkPWM6
        '
        Me.chkPWM6.AutoSize = True
        Me.chkPWM6.Location = New System.Drawing.Point(111, 152)
        Me.chkPWM6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPWM6.Name = "chkPWM6"
        Me.chkPWM6.Size = New System.Drawing.Size(53, 17)
        Me.chkPWM6.TabIndex = 3
        Me.chkPWM6.Text = "PWM"
        Me.chkPWM6.UseVisualStyleBackColor = True
        '
        'chkDO6
        '
        Me.chkDO6.AutoSize = True
        Me.chkDO6.Location = New System.Drawing.Point(52, 152)
        Me.chkDO6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDO6.Name = "chkDO6"
        Me.chkDO6.Size = New System.Drawing.Size(48, 17)
        Me.chkDO6.TabIndex = 3
        Me.chkDO6.Text = "DO6"
        Me.chkDO6.UseVisualStyleBackColor = True
        '
        'chkPWM5
        '
        Me.chkPWM5.AutoSize = True
        Me.chkPWM5.Location = New System.Drawing.Point(111, 128)
        Me.chkPWM5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPWM5.Name = "chkPWM5"
        Me.chkPWM5.Size = New System.Drawing.Size(53, 17)
        Me.chkPWM5.TabIndex = 3
        Me.chkPWM5.Text = "PWM"
        Me.chkPWM5.UseVisualStyleBackColor = True
        '
        'chkDO5
        '
        Me.chkDO5.AutoSize = True
        Me.chkDO5.Location = New System.Drawing.Point(52, 128)
        Me.chkDO5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDO5.Name = "chkDO5"
        Me.chkDO5.Size = New System.Drawing.Size(48, 17)
        Me.chkDO5.TabIndex = 3
        Me.chkDO5.Text = "DO5"
        Me.chkDO5.UseVisualStyleBackColor = True
        '
        'chkDO4
        '
        Me.chkDO4.AutoSize = True
        Me.chkDO4.Location = New System.Drawing.Point(52, 104)
        Me.chkDO4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDO4.Name = "chkDO4"
        Me.chkDO4.Size = New System.Drawing.Size(48, 17)
        Me.chkDO4.TabIndex = 3
        Me.chkDO4.Text = "DO4"
        Me.chkDO4.UseVisualStyleBackColor = True
        '
        'chkPWM3
        '
        Me.chkPWM3.AutoSize = True
        Me.chkPWM3.Location = New System.Drawing.Point(111, 80)
        Me.chkPWM3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPWM3.Name = "chkPWM3"
        Me.chkPWM3.Size = New System.Drawing.Size(53, 17)
        Me.chkPWM3.TabIndex = 3
        Me.chkPWM3.Text = "PWM"
        Me.chkPWM3.UseVisualStyleBackColor = True
        '
        'chkDO3
        '
        Me.chkDO3.AutoSize = True
        Me.chkDO3.Location = New System.Drawing.Point(52, 80)
        Me.chkDO3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDO3.Name = "chkDO3"
        Me.chkDO3.Size = New System.Drawing.Size(48, 17)
        Me.chkDO3.TabIndex = 3
        Me.chkDO3.Text = "DO3"
        Me.chkDO3.UseVisualStyleBackColor = True
        '
        'chkPWM2
        '
        Me.chkPWM2.AutoSize = True
        Me.chkPWM2.Location = New System.Drawing.Point(111, 52)
        Me.chkPWM2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPWM2.Name = "chkPWM2"
        Me.chkPWM2.Size = New System.Drawing.Size(53, 17)
        Me.chkPWM2.TabIndex = 3
        Me.chkPWM2.Text = "PWM"
        Me.chkPWM2.UseVisualStyleBackColor = True
        '
        'chkDO2
        '
        Me.chkDO2.AutoSize = True
        Me.chkDO2.Location = New System.Drawing.Point(52, 56)
        Me.chkDO2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDO2.Name = "chkDO2"
        Me.chkDO2.Size = New System.Drawing.Size(48, 17)
        Me.chkDO2.TabIndex = 3
        Me.chkDO2.Text = "DO2"
        Me.chkDO2.UseVisualStyleBackColor = True
        '
        'chkPWM1
        '
        Me.chkPWM1.AutoSize = True
        Me.chkPWM1.Location = New System.Drawing.Point(111, 32)
        Me.chkPWM1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPWM1.Name = "chkPWM1"
        Me.chkPWM1.Size = New System.Drawing.Size(53, 17)
        Me.chkPWM1.TabIndex = 3
        Me.chkPWM1.Text = "PWM"
        Me.chkPWM1.UseVisualStyleBackColor = True
        '
        'chkDO1
        '
        Me.chkDO1.AutoSize = True
        Me.chkDO1.Location = New System.Drawing.Point(52, 32)
        Me.chkDO1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDO1.Name = "chkDO1"
        Me.chkDO1.Size = New System.Drawing.Size(48, 17)
        Me.chkDO1.TabIndex = 3
        Me.chkDO1.Text = "DO1"
        Me.chkDO1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 248)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "pin 25"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 152)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "pin 21"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 224)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "pin 22"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 128)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "pin 3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 176)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "pin 13"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 200)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "pin 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 80)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "pin 20"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 104)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "pin 12"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "pin 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "pin 11"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DutyCycle %"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Frequency (500-300000 Hz)"
        '
        'gbInputs
        '
        Me.gbInputs.Controls.Add(Me.btnGetDigIn)
        Me.gbInputs.Controls.Add(Me.Label15)
        Me.gbInputs.Controls.Add(Me.Label13)
        Me.gbInputs.Controls.Add(Me.Label14)
        Me.gbInputs.Controls.Add(Me.chkDI2)
        Me.gbInputs.Controls.Add(Me.chkDI1)
        Me.gbInputs.Controls.Add(Me.chkDI3)
        Me.gbInputs.Location = New System.Drawing.Point(15, 320)
        Me.gbInputs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbInputs.Name = "gbInputs"
        Me.gbInputs.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbInputs.Size = New System.Drawing.Size(385, 105)
        Me.gbInputs.TabIndex = 2
        Me.gbInputs.TabStop = False
        Me.gbInputs.Text = "Digital Inputs"
        '
        'btnGetDigIn
        '
        Me.btnGetDigIn.Location = New System.Drawing.Point(148, 56)
        Me.btnGetDigIn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGetDigIn.Name = "btnGetDigIn"
        Me.btnGetDigIn.Size = New System.Drawing.Size(112, 23)
        Me.btnGetDigIn.TabIndex = 4
        Me.btnGetDigIn.Text = "Get Digital Inputs"
        Me.btnGetDigIn.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 80)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "pin 16"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 32)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "pin 24"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 56)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "pin 7"
        '
        'chkDI2
        '
        Me.chkDI2.AutoSize = True
        Me.chkDI2.Enabled = False
        Me.chkDI2.Location = New System.Drawing.Point(52, 56)
        Me.chkDI2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDI2.Name = "chkDI2"
        Me.chkDI2.Size = New System.Drawing.Size(43, 17)
        Me.chkDI2.TabIndex = 3
        Me.chkDI2.Text = "DI2"
        Me.chkDI2.UseVisualStyleBackColor = True
        '
        'chkDI1
        '
        Me.chkDI1.AutoSize = True
        Me.chkDI1.Enabled = False
        Me.chkDI1.Location = New System.Drawing.Point(52, 32)
        Me.chkDI1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDI1.Name = "chkDI1"
        Me.chkDI1.Size = New System.Drawing.Size(43, 17)
        Me.chkDI1.TabIndex = 3
        Me.chkDI1.Text = "DI1"
        Me.chkDI1.UseVisualStyleBackColor = True
        '
        'chkDI3
        '
        Me.chkDI3.AutoSize = True
        Me.chkDI3.Enabled = False
        Me.chkDI3.Location = New System.Drawing.Point(52, 80)
        Me.chkDI3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDI3.Name = "chkDI3"
        Me.chkDI3.Size = New System.Drawing.Size(43, 17)
        Me.chkDI3.TabIndex = 3
        Me.chkDI3.Text = "DI3"
        Me.chkDI3.UseVisualStyleBackColor = True
        '
        'DigitalIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(417, 488)
        Me.Controls.Add(Me.gbInputs)
        Me.Controls.Add(Me.gbOutputs)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DigitalIO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Digital IO"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbOutputs.ResumeLayout(False)
        Me.gbOutputs.PerformLayout()
        Me.gbInputs.ResumeLayout(False)
        Me.gbInputs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gbOutputs As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkDO9 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDO7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDO6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDO5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDO4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDO3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDO2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDO1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkDO10 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDO8 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPWM7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPWM6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPWM5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPWM3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPWM2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPWM1 As System.Windows.Forms.CheckBox
    Friend WithEvents edtDuty7 As System.Windows.Forms.TextBox
    Friend WithEvents edtDuty3 As System.Windows.Forms.TextBox
    Friend WithEvents edtDuty6 As System.Windows.Forms.TextBox
    Friend WithEvents edtDuty2 As System.Windows.Forms.TextBox
    Friend WithEvents edtDuty5 As System.Windows.Forms.TextBox
    Friend WithEvents edtDuty1 As System.Windows.Forms.TextBox
    Friend WithEvents edtFreq567 As System.Windows.Forms.TextBox
    Friend WithEvents edtFreq123 As System.Windows.Forms.TextBox
    Friend WithEvents gbInputs As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkDI2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDI1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkDI3 As System.Windows.Forms.CheckBox
    Friend WithEvents btnGetDigIn As System.Windows.Forms.Button

End Class
