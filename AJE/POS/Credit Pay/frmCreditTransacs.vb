Public Class frmCreditTransacs
    Dim credPay As New clsCreditPay

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub frmCreditTransacs_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim orderId = frmCreditPay.dg_Transactions.Item(0, frmCreditPay.dg_Transactions.CurrentRow.Index).Value
        credPay.loadTransactions(orderId)
        lbl_due_Total.Text = Format(credPay.loadOrderTotal(orderId), "0.00")
    End Sub

    Private Sub cbo_Type_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim orderId = frmCreditPay.dg_Transactions.Item(0, frmCreditPay.dg_Transactions.CurrentRow.Index).Value
        credPay.loadTransactions(orderId)
    End Sub
End Class