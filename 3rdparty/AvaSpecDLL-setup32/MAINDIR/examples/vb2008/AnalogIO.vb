Imports System.Windows.Forms

Public Class AnalogIO



    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSetAnalogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetAnalogOut.Click

        Const NR_OF_ANALOG_OUTPUTS As Byte = 2

        Dim l_Value(NR_OF_ANALOG_OUTPUTS - 1) As Single
        Dim l_bNoError As Boolean = True

        l_Value(0) = CSng(edtAO1.Text)
        l_Value(1) = CSng(edtAO2.Text)

        For i As Integer = 0 To (NR_OF_ANALOG_OUTPUTS - 1)

            Dim l_Res As Integer = AVS_SetAnalogOut(Form1.m_DeviceHandle, i, l_Value(i))

            If (l_Res <> ERR_SUCCESS) Then
                l_bNoError = False
                MsgBox("Communication Error" & Str(l_Res), MsgBoxStyle.Exclamation, "Error")
                Exit For
            End If

        Next i

    End Sub

    Private Sub btnGetAnalogInClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetAnalogInClick.Click

        Const NR_OF_ANALOG_INPUTS As Byte = 2
        Dim l_Value(NR_OF_ANALOG_INPUTS - 1) As Single

        Dim l_Res As Integer = AVS_GetAnalogIn(Form1.m_DeviceHandle, 5, l_Value(0))

        If (l_Res <> ERR_SUCCESS) Then
            MsgBox("Error ID=5 (pin 9): " & Str(l_Res), MsgBoxStyle.Exclamation, "Error")
        Else
            edtAI5.Text = Format(l_Value(0), "0.00") & " V"
        End If

        l_Res = AVS_GetAnalogIn(Form1.m_DeviceHandle, 4, l_Value(1))

        If (l_Res <> ERR_SUCCESS) Then
            MsgBox("Error ID=4 (pin 18): " & Str(l_Res), MsgBoxStyle.Exclamation, "Error")
        Else
            edtAI4.Text = Format(l_Value(1), "0.00") & " V"
        End If

    End Sub

    Private Sub btnGetOnboardAI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetOnboardAI.Click

        Dim l_Value As Single
        Dim l_Res As Integer = AVS_GetAnalogIn(Form1.m_DeviceHandle, 0, l_Value)
        Select Case l_Res
            Case ERR_SUCCESS
                edtAI0.Text = Format(l_Value, "0.00") & " V"
            Case ERR_INVALID_PARAMETER
                edtAI0.Text = "Not Available"
            Case Else
                MsgBox("Error ID=0: " & Str(l_Res), MsgBoxStyle.Exclamation, "Error")
        End Select

        l_Res = AVS_GetAnalogIn(Form1.m_DeviceHandle, 1, l_Value)
        Select Case l_Res
            Case ERR_SUCCESS
                edtAI1.Text = Format(l_Value, "0.00") & " V"
            Case ERR_INVALID_PARAMETER
                edtAI1.Text = "Not Available"
            Case Else
                MsgBox("Error ID=1: " & Str(l_Res), MsgBoxStyle.Exclamation, "Error")
        End Select

        l_Res = AVS_GetAnalogIn(Form1.m_DeviceHandle, 2, l_Value)
        Select Case l_Res
            Case ERR_SUCCESS
                edtAI2.Text = Format(l_Value, "0.00") & " V"
            Case ERR_INVALID_PARAMETER
                edtAI2.Text = "Not Available"
            Case Else
                MsgBox("Error ID=2: " & Str(l_Res), MsgBoxStyle.Exclamation, "Error")
        End Select

        l_Res = AVS_GetAnalogIn(Form1.m_DeviceHandle, 3, l_Value)
        Select Case l_Res
            Case ERR_SUCCESS
                edtAI3.Text = Format(l_Value, "0.00") & " V"
            Case ERR_INVALID_PARAMETER
                edtAI3.Text = "Not Available"
            Case Else
                MsgBox("Error ID=3: " & Str(l_Res), MsgBoxStyle.Exclamation, "Error")
        End Select

        l_Res = AVS_GetAnalogIn(Form1.m_DeviceHandle, 6, l_Value)
        Select Case l_Res
            Case ERR_SUCCESS
                edtAI6.Text = Format(l_Value, "0.00") & " V"
            Case ERR_INVALID_PARAMETER
                edtAI6.Text = "Not Available"
            Case Else
                MsgBox("Error ID=6: " & Str(l_Res), MsgBoxStyle.Exclamation, "Error")
        End Select

        l_Res = AVS_GetAnalogIn(Form1.m_DeviceHandle, 7, l_Value)
        Select Case l_Res
            Case ERR_SUCCESS
                edtAI7.Text = Format(l_Value, "0.00") & " V"
            Case ERR_INVALID_PARAMETER
                edtAI7.Text = "Not Available"
            Case Else
                MsgBox("Error ID=7: " & Str(l_Res), MsgBoxStyle.Exclamation, "Error")
        End Select
    End Sub
End Class
