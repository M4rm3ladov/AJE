Public Class frmBalance
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Dim loginPos As New clsLoginPos
    Private Sub btn_Verify_Click(sender As Object, e As EventArgs) Handles btn_Verify.Click
        frmAuthenticate.lbl_Type.Text = 1
        frmAuthenticate.ShowDialog()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        If MsgBox("Cashier will be logged out. Continue?", vbQuestion + vbYesNo) = vbYes Then
            loginPos.SetUsername(frmPos.lbl_Username.Text)
            loginPos.setUserLogin(0)
            frmMain.Show()
            frmMain.KeyPreview = True
            frmPos.Close()
            Me.Close()
        End If
    End Sub
    Private Sub tb_initial_Bal_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_initial_Bal.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If

    End Sub

    Private Sub tb_initial_Bal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_initial_Bal.KeyPress
        If tb_initial_Bal.Text.Length > 7 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = Char.IsNumber(e.KeyChar) Or Not Char.IsNumber(e.KeyChar)
                Exit Sub
            End If
        End If
        ' Check for the flag being set in the KeyDown event.
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If

            If strCurrency.Length = 0 Then
                tb_initial_Bal.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_initial_Bal.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_initial_Bal.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_initial_Bal.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_initial_Bal.Select(tb_initial_Bal.Text.Length, 0)

        End If
        e.Handled = True

    End Sub
    Private Sub tb_initial_Bal_Leave(sender As Object, e As EventArgs) Handles tb_initial_Bal.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub

    Private Sub frmBalance_Load(sender As Object, e As EventArgs) Handles Me.Load
        tb_initial_Bal.Focus()
    End Sub
End Class