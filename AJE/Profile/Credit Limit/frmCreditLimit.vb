Public Class frmCreditLimit
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Dim creditLimit As New clsCreditLimit
    Private Sub tb_credit_Limit_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_credit_Limit.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub tb_credit_Limit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_credit_Limit.KeyPress
        If tb_credit_Limit.Text.Length > 10 Then
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
                tb_credit_Limit.Text = ""
            ElseIf strCurrency.Length = 1 Then
                tb_credit_Limit.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                tb_credit_Limit.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                tb_credit_Limit.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            tb_credit_Limit.Select(tb_credit_Limit.Text.Length, 0)

        End If
        e.Handled = True
    End Sub

    Private Sub tb_credit_Limit_Leave(sender As Object, e As EventArgs) Handles tb_credit_Limit.Leave
        strCurrency = ""
        acceptableKey = False
    End Sub
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        creditLimit.CreditLimit = Trim(tb_credit_Limit.Text)
        If creditLimit.save() = True Then
            MsgBox("Credit limit updated successfully.", vbInformation)
        End If
        tb_credit_Limit.Clear()
        Me.Close()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        With frmProfiling
            .btn_credit_Limit.BackColor = Color.FromArgb(127, 140, 141)
            .btn_User.BackColor = Color.FromArgb(127, 140, 141)
            .btn_Item.BackColor = Color.FromArgb(127, 140, 141)
            .btn_Supplier.BackColor = Color.FromArgb(127, 140, 141)
            .btn_Branch.BackColor = Color.FromArgb(127, 140, 141)
            .btn_Service.BackColor = Color.FromArgb(127, 140, 141)
            .btn_critical_Stock.BackColor = Color.FromArgb(127, 140, 141)
        End With
        Me.Close()
    End Sub
End Class