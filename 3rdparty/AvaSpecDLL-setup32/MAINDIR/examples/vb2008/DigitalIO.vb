Imports System.Windows.Forms

Public Class DigitalIO
    Private Sub OutputClick(ByVal a_Id As Byte, ByVal a_Value As Byte)

        Dim l_Res As Integer
        Dim l_Freq As UInteger
        Dim l_Perc As Byte

        If a_Value > 0 Then
            a_Value = 1
        End If

        If (((a_Id = 0) Or (a_Id = 1) Or (a_Id = 2) Or (a_Id = 4) Or (a_Id = 5) Or (a_Id = 6)) And (a_Value = 1)) Then

            Select Case a_Id
                Case 0
                    If (chkPWM1.Checked = True) Then
                        l_Perc = CByte(edtDuty1.Text)
                        l_Freq = CUInt(edtFreq123.Text)
                        l_Res = AVS_SetPwmOut(Form1.m_DeviceHandle, a_Id, l_Freq, l_Perc)
                    Else
                        l_Res = AVS_SetDigOut(Form1.m_DeviceHandle, a_Id, a_Value)

                    End If

                Case 1
                    If (chkPWM2.Checked = True) Then
                        l_Perc = CByte(edtDuty2.Text)
                        l_Freq = CUInt(edtFreq123.Text)
                        l_Res = AVS_SetPwmOut(Form1.m_DeviceHandle, a_Id, l_Freq, l_Perc)
                    Else
                        l_Res = AVS_SetDigOut(Form1.m_DeviceHandle, a_Id, a_Value)
                    End If

                Case 2
                    If (chkPWM3.Checked = True) Then

                        l_Perc = CByte(edtDuty3.Text)
                        l_Freq = CUInt(edtFreq123.Text)
                        l_Res = AVS_SetPwmOut(Form1.m_DeviceHandle, a_Id, l_Freq, l_Perc)
                    Else
                        l_Res = AVS_SetDigOut(Form1.m_DeviceHandle, a_Id, a_Value)
                    End If

                Case 4
                    If (chkPWM5.Checked = True) Then
                        l_Perc = CByte(edtDuty5.Text)
                        l_Freq = CUInt(edtFreq567.Text)
                        l_Res = AVS_SetPwmOut(Form1.m_DeviceHandle, a_Id, l_Freq, l_Perc)
                    Else
                        l_Res = AVS_SetDigOut(Form1.m_DeviceHandle, a_Id, a_Value)
                    End If

                Case 5
                    If (chkPWM6.Checked) Then
                        l_Perc = CByte(edtDuty6.Text)
                        l_Freq = CUInt(edtFreq567.Text)
                        l_Res = AVS_SetPwmOut(Form1.m_DeviceHandle, a_Id, l_Freq, l_Perc)
                    Else
                        l_Res = AVS_SetDigOut(Form1.m_DeviceHandle, a_Id, a_Value)
                    End If

                Case 6
                    If (chkPWM7.Checked) Then
                        l_Perc = CByte(edtDuty7.Text)
                        l_Freq = CUInt(edtFreq567.Text)
                        l_Res = AVS_SetPwmOut(Form1.m_DeviceHandle, a_Id, l_Freq, l_Perc)
                    Else
                        l_Res = AVS_SetDigOut(Form1.m_DeviceHandle, a_Id, a_Value)
                    End If

                Case Else

            End Select

        Else
            l_Res = AVS_SetDigOut(Form1.m_DeviceHandle, a_Id, a_Value)
        End If

        If (l_Res <> ERR_SUCCESS) Then
            MsgBox("Error:" & Str(l_Res), MsgBoxStyle.OkOnly, "Error")
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnGetDigIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDigIn.Click

        Const NR_OF_DIGITAL_INPUTS As Byte = 3
        Const DIG_IN0 As Byte = 0
        Const DIG_IN1 As Byte = 1
        Const DIG_IN2 As Byte = 2

        Dim l_bNoError As Boolean = True
        Dim l_Value(NR_OF_DIGITAL_INPUTS - 1) As Byte


        For i As Integer = 0 To (NR_OF_DIGITAL_INPUTS - 1)
            If (ERR_SUCCESS <> AVS_GetDigIn(Form1.m_DeviceHandle, i, l_Value(i))) Then
                l_bNoError = False
                Exit For
            End If
        Next i

        If (l_bNoError) Then

            chkDI1.Enabled = True

            If (l_Value(DIG_IN0) = 1) Then
                chkDI1.CheckState = CheckState.Checked
            Else
                chkDI1.CheckState = CheckState.Unchecked
            End If
            'chkDI1.CheckState = (l_Value(DIG_IN0) & &H01) ? cbChecked : cbUnchecked;
            chkDI1.Enabled = False

            chkDI2.Enabled = True
            If (l_Value(DIG_IN1) = 1) Then
                chkDI2.CheckState = CheckState.Checked
            Else
                chkDI2.CheckState = CheckState.Unchecked
            End If
            'chkDI2.State = (l_Value[DIG_IN1] & 0x01) ? cbChecked : cbUnchecked;
            chkDI2.Enabled = False

            chkDI3.Enabled = True
            If (l_Value(DIG_IN2) = 1) Then
                chkDI3.CheckState = CheckState.Checked
            Else
                chkDI3.CheckState = CheckState.Unchecked
            End If
            'chkDI3.State = (l_Value[DIG_IN2] & 0x01) ? cbChecked : cbUnchecked;
            chkDI3.Enabled = False

        Else
            MsgBox("Communication Error", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub chkDO1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDO1.CheckedChanged
        OutputClick(0, chkDO1.Checked)
    End Sub

    Private Sub chkPWM1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPWM1.CheckedChanged
        OutputClick(0, chkDO1.Checked)
    End Sub

    Private Sub chkDO2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDO2.CheckedChanged
        OutputClick(1, chkDO2.Checked)
    End Sub

    Private Sub chkPWM2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPWM2.CheckedChanged
        OutputClick(1, chkDO2.Checked)
    End Sub

    Private Sub chkDO3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDO3.CheckedChanged
        OutputClick(2, chkDO3.Checked)
    End Sub

    Private Sub chkPWM3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPWM3.CheckedChanged
        OutputClick(2, chkDO3.Checked)
    End Sub

    Private Sub chkDO4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDO4.CheckedChanged
        OutputClick(3, chkDO4.Checked)
    End Sub

    Private Sub chkDO5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDO5.CheckedChanged
        OutputClick(4, chkDO5.Checked)
    End Sub

    Private Sub chkPWM5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPWM5.CheckedChanged
        OutputClick(4, chkDO5.Checked)
    End Sub

    Private Sub chkDO6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDO6.CheckedChanged
        OutputClick(5, chkDO6.Checked)
    End Sub

    Private Sub chkPWM6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPWM6.CheckedChanged
        OutputClick(5, chkDO6.Checked)
    End Sub

    Private Sub chkDO7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDO7.CheckedChanged
        OutputClick(6, chkDO7.Checked)
    End Sub

    Private Sub chkPWM7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPWM7.CheckedChanged
        OutputClick(6, chkDO7.Checked)
    End Sub

    Private Sub chkDO8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDO8.CheckedChanged
        OutputClick(7, chkDO8.Checked)
    End Sub

    Private Sub chkDO9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDO9.CheckedChanged
        OutputClick(8, chkDO9.Checked)
    End Sub

    Private Sub chkDO10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDO10.CheckedChanged
        OutputClick(9, chkDO10.Checked)
    End Sub
   

End Class
