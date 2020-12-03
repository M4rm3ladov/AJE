Public Class frmReport
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
        With frmMain
            .btn_Pos.Enabled = True
            .btn_Inventory.Enabled = True
            .btn_Customer.Enabled = True
            .btn_Logout.Enabled = True
            .KeyPreview = True
        End With
    End Sub

    Private Sub btn_Sales_Click(sender As Object, e As EventArgs) Handles btn_Sales.Click
        'With frmSales
        '    .TopLevel = False
        '    pnlMid.Controls.Add(frmSales)
        '    .BringToFront()
        '    .Show()
        'End With
        'btn_Sales.BackColor = Color.FromArgb(44, 62, 80)
        'btn_Inventory.BackColor = Color.FromArgb(127, 140, 141)
        'btn_Cashier.BackColor = Color.FromArgb(127, 140, 141)
        'btn_Customer.BackColor = Color.FromArgb(127, 140, 141)
        frmSales.ShowDialog()
    End Sub

    Private Sub btn_Customer_Click(sender As Object, e As EventArgs) Handles btn_Customer.Click
        frmCustomerTransacs.ShowDialog()
    End Sub

    Private Sub btn_Cashier_Click(sender As Object, e As EventArgs) Handles btn_Cashier.Click
        frmCashierReport.ShowDialog()
    End Sub
End Class