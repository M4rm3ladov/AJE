Public Class frmNewTransaction
    Private Sub btn_Cash_Click(sender As Object, e As EventArgs) Handles btn_Cash.Click
        frmPos.lbl_pay_Type.Text = "Cash"
        frmPos.dg_Order.Rows.Clear()
        frmPos.lbl_due_Total.Text = "0.00"
        frmPos.lbl_customer_Id.Text = vbNullString
        frmPos.tb_customer_Name.Text = vbNullString
        frmPos.lbl_Customer.Enabled = False
        Me.Close()
    End Sub

    Private Sub btn_Credit_Click(sender As Object, e As EventArgs) Handles btn_Credit.Click
        frmPos.lbl_pay_Type.Text = "Credit"
        frmPos.dg_Order.Rows.Clear()
        frmPos.lbl_due_Total.Text = "0.00"
        frmPos.lbl_customer_Id.Text = vbNullString
        frmPos.tb_customer_Name.Text = vbNullString
        frmPos.lbl_Customer.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class