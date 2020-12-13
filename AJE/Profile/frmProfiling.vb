Public Class frmProfiling
    Private Sub btn_Item_Click(sender As Object, e As EventArgs) Handles btn_Item.Click
        With frmItem
            .TopLevel = False
            pnlMid.Controls.Add(frmItem)
            .BringToFront()
            .Show()
        End With
        btn_Item.BackColor = Color.FromArgb(44, 62, 80)
        btn_User.BackColor = Color.FromArgb(127, 140, 141)
        btn_Service.BackColor = Color.FromArgb(127, 140, 141)
        btn_Supplier.BackColor = Color.FromArgb(127, 140, 141)
        btn_Branch.BackColor = Color.FromArgb(127, 140, 141)
        btn_credit_Limit.BackColor = Color.FromArgb(127, 140, 141)
        btn_critical_Stock.BackColor = Color.FromArgb(127, 140, 141)
    End Sub

    Private Sub btn_User_Click(sender As Object, e As EventArgs) Handles btn_User.Click
        With frmUser
            .TopLevel = False
            pnlMid.Controls.Add(frmUser)
            .BringToFront()
            .Show()
        End With
        btn_User.BackColor = Color.FromArgb(44, 62, 80)
        btn_Item.BackColor = Color.FromArgb(127, 140, 141)
        btn_Service.BackColor = Color.FromArgb(127, 140, 141)
        btn_Supplier.BackColor = Color.FromArgb(127, 140, 141)
        btn_Branch.BackColor = Color.FromArgb(127, 140, 141)
        btn_credit_Limit.BackColor = Color.FromArgb(127, 140, 141)
        btn_critical_Stock.BackColor = Color.FromArgb(127, 140, 141)
    End Sub

    Private Sub btn_Service_Click(sender As Object, e As EventArgs) Handles btn_Service.Click
        With frmServices
            .TopLevel = False
            pnlMid.Controls.Add(frmServices)
            .BringToFront()
            .Show()
        End With
        btn_Service.BackColor = Color.FromArgb(44, 62, 80)
        btn_User.BackColor = Color.FromArgb(127, 140, 141)
        btn_Item.BackColor = Color.FromArgb(127, 140, 141)
        btn_Supplier.BackColor = Color.FromArgb(127, 140, 141)
        btn_Branch.BackColor = Color.FromArgb(127, 140, 141)
        btn_credit_Limit.BackColor = Color.FromArgb(127, 140, 141)
        btn_critical_Stock.BackColor = Color.FromArgb(127, 140, 141)
    End Sub

    Private Sub btn_Branch_Click(sender As Object, e As EventArgs) Handles btn_Branch.Click
        With frmBranch
            .TopLevel = False
            pnlMid.Controls.Add(frmBranch)
            .BringToFront()
            .Show()
        End With
        btn_Branch.BackColor = Color.FromArgb(44, 62, 80)
        btn_User.BackColor = Color.FromArgb(127, 140, 141)
        btn_Item.BackColor = Color.FromArgb(127, 140, 141)
        btn_Service.BackColor = Color.FromArgb(127, 140, 141)
        btn_Supplier.BackColor = Color.FromArgb(127, 140, 141)
        btn_credit_Limit.BackColor = Color.FromArgb(127, 140, 141)
        btn_critical_Stock.BackColor = Color.FromArgb(127, 140, 141)
    End Sub

    Private Sub btn_Supplier_Click(sender As Object, e As EventArgs) Handles btn_Supplier.Click
        With frmSupplier
            .TopLevel = False
            pnlMid.Controls.Add(frmSupplier)
            .BringToFront()
            .Show()
        End With
        btn_Supplier.BackColor = Color.FromArgb(44, 62, 80)
        btn_Branch.BackColor = Color.FromArgb(127, 140, 141)
        btn_User.BackColor = Color.FromArgb(127, 140, 141)
        btn_Item.BackColor = Color.FromArgb(127, 140, 141)
        btn_Service.BackColor = Color.FromArgb(127, 140, 141)
        btn_credit_Limit.BackColor = Color.FromArgb(127, 140, 141)
        btn_critical_Stock.BackColor = Color.FromArgb(127, 140, 141)
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        frmMain.KeyPreview = True
        If frmMain.lbl_Type.Text = "Admin" Then
            With frmMain
                .btn_Pos.Enabled = False
                .btn_Inventory.Enabled = False
                .btn_Customer.Enabled = False
                .btn_Reports.Enabled = False
                .btn_Logout.Enabled = True
            End With
        End If
        Me.Close()
    End Sub

    Private Sub btn_credit_Limit_Click(sender As Object, e As EventArgs) Handles btn_credit_Limit.Click
        With pbImage
            pnlMid.Controls.Add(pbImage)
            .BringToFront()
            .Show()
        End With
        btn_credit_Limit.BackColor = Color.FromArgb(44, 62, 80)
        btn_User.BackColor = Color.FromArgb(127, 140, 141)
        btn_Item.BackColor = Color.FromArgb(127, 140, 141)
        btn_Supplier.BackColor = Color.FromArgb(127, 140, 141)
        btn_Branch.BackColor = Color.FromArgb(127, 140, 141)
        btn_Service.BackColor = Color.FromArgb(127, 140, 141)
        btn_critical_Stock.BackColor = Color.FromArgb(127, 140, 141)
        frmCreditLimit.ShowDialog()
    End Sub

    Private Sub btn_critical_Stock_Click(sender As Object, e As EventArgs) Handles btn_critical_Stock.Click
        With pbImage
            pnlMid.Controls.Add(pbImage)
            .BringToFront()
            .Show()
        End With
        btn_critical_Stock.BackColor = Color.FromArgb(44, 62, 80)
        btn_User.BackColor = Color.FromArgb(127, 140, 141)
        btn_Item.BackColor = Color.FromArgb(127, 140, 141)
        btn_Supplier.BackColor = Color.FromArgb(127, 140, 141)
        btn_Branch.BackColor = Color.FromArgb(127, 140, 141)
        btn_Service.BackColor = Color.FromArgb(127, 140, 141)
        btn_credit_Limit.BackColor = Color.FromArgb(127, 140, 141)
        frmCriticalStock.ShowDialog()
    End Sub
End Class