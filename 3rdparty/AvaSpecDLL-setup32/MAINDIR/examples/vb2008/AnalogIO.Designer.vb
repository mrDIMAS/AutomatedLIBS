<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnalogIO
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
        Me.gbAnalogOut = New System.Windows.Forms.GroupBox
        Me.btnSetAnalogOut = New System.Windows.Forms.Button
        Me.edtAO2 = New System.Windows.Forms.TextBox
        Me.edtAO1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbAnalogInput26 = New System.Windows.Forms.GroupBox
        Me.btnGetAnalogInClick = New System.Windows.Forms.Button
        Me.edtAI4 = New System.Windows.Forms.TextBox
        Me.edtAI5 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbAnalogInOnboard = New System.Windows.Forms.GroupBox
        Me.edtAI7 = New System.Windows.Forms.TextBox
        Me.edtAI6 = New System.Windows.Forms.TextBox
        Me.edtAI3 = New System.Windows.Forms.TextBox
        Me.edtAI2 = New System.Windows.Forms.TextBox
        Me.btnGetOnboardAI = New System.Windows.Forms.Button
        Me.edtAI1 = New System.Windows.Forms.TextBox
        Me.edtAI0 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbAnalogOut.SuspendLayout()
        Me.gbAnalogInput26.SuspendLayout()
        Me.gbAnalogInOnboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(123, 436)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(68, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(3, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(62, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'gbAnalogOut
        '
        Me.gbAnalogOut.Controls.Add(Me.btnSetAnalogOut)
        Me.gbAnalogOut.Controls.Add(Me.edtAO2)
        Me.gbAnalogOut.Controls.Add(Me.edtAO1)
        Me.gbAnalogOut.Controls.Add(Me.Label2)
        Me.gbAnalogOut.Controls.Add(Me.Label1)
        Me.gbAnalogOut.Location = New System.Drawing.Point(15, 16)
        Me.gbAnalogOut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbAnalogOut.Name = "gbAnalogOut"
        Me.gbAnalogOut.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbAnalogOut.Size = New System.Drawing.Size(303, 89)
        Me.gbAnalogOut.TabIndex = 1
        Me.gbAnalogOut.TabStop = False
        Me.gbAnalogOut.Text = "Analog Output"
        '
        'btnSetAnalogOut
        '
        Me.btnSetAnalogOut.Location = New System.Drawing.Point(189, 32)
        Me.btnSetAnalogOut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSetAnalogOut.Name = "btnSetAnalogOut"
        Me.btnSetAnalogOut.Size = New System.Drawing.Size(93, 25)
        Me.btnSetAnalogOut.TabIndex = 4
        Me.btnSetAnalogOut.Text = "Set Analog Out"
        Me.btnSetAnalogOut.UseVisualStyleBackColor = True
        '
        'edtAO2
        '
        Me.edtAO2.Location = New System.Drawing.Point(93, 56)
        Me.edtAO2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtAO2.Name = "edtAO2"
        Me.edtAO2.Size = New System.Drawing.Size(68, 20)
        Me.edtAO2.TabIndex = 3
        Me.edtAO2.Text = "0"
        '
        'edtAO1
        '
        Me.edtAO1.Location = New System.Drawing.Point(93, 32)
        Me.edtAO1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtAO1.Name = "edtAO1"
        Me.edtAO1.Size = New System.Drawing.Size(68, 20)
        Me.edtAO1.TabIndex = 2
        Me.edtAO1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "pin 26 (AO2)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "pin 17 (AO1)"
        '
        'gbAnalogInput26
        '
        Me.gbAnalogInput26.Controls.Add(Me.btnGetAnalogInClick)
        Me.gbAnalogInput26.Controls.Add(Me.edtAI4)
        Me.gbAnalogInput26.Controls.Add(Me.edtAI5)
        Me.gbAnalogInput26.Controls.Add(Me.Label3)
        Me.gbAnalogInput26.Controls.Add(Me.Label4)
        Me.gbAnalogInput26.Location = New System.Drawing.Point(15, 124)
        Me.gbAnalogInput26.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbAnalogInput26.Name = "gbAnalogInput26"
        Me.gbAnalogInput26.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbAnalogInput26.Size = New System.Drawing.Size(303, 89)
        Me.gbAnalogInput26.TabIndex = 2
        Me.gbAnalogInput26.TabStop = False
        Me.gbAnalogInput26.Text = "Analog Input SUBD26-F connector"
        '
        'btnGetAnalogInClick
        '
        Me.btnGetAnalogInClick.Location = New System.Drawing.Point(189, 32)
        Me.btnGetAnalogInClick.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGetAnalogInClick.Name = "btnGetAnalogInClick"
        Me.btnGetAnalogInClick.Size = New System.Drawing.Size(93, 25)
        Me.btnGetAnalogInClick.TabIndex = 4
        Me.btnGetAnalogInClick.Text = "Get Analog In"
        Me.btnGetAnalogInClick.UseVisualStyleBackColor = True
        '
        'edtAI4
        '
        Me.edtAI4.Location = New System.Drawing.Point(93, 56)
        Me.edtAI4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtAI4.Name = "edtAI4"
        Me.edtAI4.Size = New System.Drawing.Size(68, 20)
        Me.edtAI4.TabIndex = 3
        '
        'edtAI5
        '
        Me.edtAI5.Location = New System.Drawing.Point(93, 32)
        Me.edtAI5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtAI5.Name = "edtAI5"
        Me.edtAI5.Size = New System.Drawing.Size(68, 20)
        Me.edtAI5.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "pin 18 (AI2)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "pin 9 (AI1)"
        '
        'gbAnalogInOnboard
        '
        Me.gbAnalogInOnboard.Controls.Add(Me.edtAI7)
        Me.gbAnalogInOnboard.Controls.Add(Me.edtAI6)
        Me.gbAnalogInOnboard.Controls.Add(Me.edtAI3)
        Me.gbAnalogInOnboard.Controls.Add(Me.edtAI2)
        Me.gbAnalogInOnboard.Controls.Add(Me.btnGetOnboardAI)
        Me.gbAnalogInOnboard.Controls.Add(Me.edtAI1)
        Me.gbAnalogInOnboard.Controls.Add(Me.edtAI0)
        Me.gbAnalogInOnboard.Controls.Add(Me.Label10)
        Me.gbAnalogInOnboard.Controls.Add(Me.Label8)
        Me.gbAnalogInOnboard.Controls.Add(Me.Label5)
        Me.gbAnalogInOnboard.Controls.Add(Me.Label9)
        Me.gbAnalogInOnboard.Controls.Add(Me.Label7)
        Me.gbAnalogInOnboard.Controls.Add(Me.Label6)
        Me.gbAnalogInOnboard.Location = New System.Drawing.Point(15, 235)
        Me.gbAnalogInOnboard.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbAnalogInOnboard.Name = "gbAnalogInOnboard"
        Me.gbAnalogInOnboard.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbAnalogInOnboard.Size = New System.Drawing.Size(303, 176)
        Me.gbAnalogInOnboard.TabIndex = 3
        Me.gbAnalogInOnboard.TabStop = False
        Me.gbAnalogInOnboard.Text = "Onboard Analog Input"
        '
        'edtAI7
        '
        Me.edtAI7.Location = New System.Drawing.Point(93, 152)
        Me.edtAI7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtAI7.Name = "edtAI7"
        Me.edtAI7.Size = New System.Drawing.Size(68, 20)
        Me.edtAI7.TabIndex = 8
        '
        'edtAI6
        '
        Me.edtAI6.Location = New System.Drawing.Point(93, 128)
        Me.edtAI6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtAI6.Name = "edtAI6"
        Me.edtAI6.Size = New System.Drawing.Size(68, 20)
        Me.edtAI6.TabIndex = 7
        '
        'edtAI3
        '
        Me.edtAI3.Location = New System.Drawing.Point(93, 104)
        Me.edtAI3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtAI3.Name = "edtAI3"
        Me.edtAI3.Size = New System.Drawing.Size(68, 20)
        Me.edtAI3.TabIndex = 6
        '
        'edtAI2
        '
        Me.edtAI2.Location = New System.Drawing.Point(93, 80)
        Me.edtAI2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtAI2.Name = "edtAI2"
        Me.edtAI2.Size = New System.Drawing.Size(68, 20)
        Me.edtAI2.TabIndex = 5
        '
        'btnGetOnboardAI
        '
        Me.btnGetOnboardAI.Location = New System.Drawing.Point(189, 32)
        Me.btnGetOnboardAI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGetOnboardAI.Name = "btnGetOnboardAI"
        Me.btnGetOnboardAI.Size = New System.Drawing.Size(93, 25)
        Me.btnGetOnboardAI.TabIndex = 4
        Me.btnGetOnboardAI.Text = "Get Onboard AI"
        Me.btnGetOnboardAI.UseVisualStyleBackColor = True
        '
        'edtAI1
        '
        Me.edtAI1.Location = New System.Drawing.Point(93, 56)
        Me.edtAI1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtAI1.Name = "edtAI1"
        Me.edtAI1.Size = New System.Drawing.Size(68, 20)
        Me.edtAI1.TabIndex = 3
        '
        'edtAI0
        '
        Me.edtAI0.Location = New System.Drawing.Point(93, 32)
        Me.edtAI0.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.edtAI0.Name = "edtAI0"
        Me.edtAI0.Size = New System.Drawing.Size(68, 20)
        Me.edtAI0.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 152)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "NTC2 X9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 104)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "5VUSB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "1V2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 128)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "NTC1 X8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 80)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "5VIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Thermistor X11"
        '
        'AnalogIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 476)
        Me.Controls.Add(Me.gbAnalogInOnboard)
        Me.Controls.Add(Me.gbAnalogInput26)
        Me.Controls.Add(Me.gbAnalogOut)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AnalogIO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AnalogIO"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbAnalogOut.ResumeLayout(False)
        Me.gbAnalogOut.PerformLayout()
        Me.gbAnalogInput26.ResumeLayout(False)
        Me.gbAnalogInput26.PerformLayout()
        Me.gbAnalogInOnboard.ResumeLayout(False)
        Me.gbAnalogInOnboard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gbAnalogOut As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents edtAO2 As System.Windows.Forms.TextBox
    Friend WithEvents edtAO1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSetAnalogOut As System.Windows.Forms.Button
    Friend WithEvents gbAnalogInput26 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetAnalogInClick As System.Windows.Forms.Button
    Friend WithEvents edtAI4 As System.Windows.Forms.TextBox
    Friend WithEvents edtAI5 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbAnalogInOnboard As System.Windows.Forms.GroupBox
    Friend WithEvents btnGetOnboardAI As System.Windows.Forms.Button
    Friend WithEvents edtAI1 As System.Windows.Forms.TextBox
    Friend WithEvents edtAI0 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents edtAI7 As System.Windows.Forms.TextBox
    Friend WithEvents edtAI6 As System.Windows.Forms.TextBox
    Friend WithEvents edtAI3 As System.Windows.Forms.TextBox
    Friend WithEvents edtAI2 As System.Windows.Forms.TextBox

End Class
