Public Class frmCriticalStock
    Dim criticalStock As New clsCriticalStock
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

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        criticalStock.Qty = Trim(tb_Qty.Text)
        If criticalStock.save() = True Then
            MsgBox("Critical stock updated successfully.", vbInformation)
        End If
        tb_Qty.Clear()
        Me.Close()
    End Sub
    Private Sub tb_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Qty.KeyPress
        If IsNumeric(e.KeyChar.ToString()) Or e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class