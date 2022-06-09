Public Class frmVoid
    Dim void As New clsVoid
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        If MsgBox("Transaction will be cleared, Do you wish to exit?", vbYesNo + vbInformation) = vbNo Then
            Exit Sub
        End If
        dg_Search.Rows.Clear()
        dg_History.Rows.Clear()
        lbl_due_Total.Text = "0.00"
        dtp_From.Value = Date.Now
        dtp_To.Value = Date.Now
        Me.Close()
    End Sub

    Private Sub btn_Confirm_Click(sender As Object, e As EventArgs) Handles btn_Confirm.Click
        If dg_Search.Rows.Count = 0 Then
            MsgBox("There are no item order to be voided.", vbInformation)
            Exit Sub
        End If
        Dim orderId = dg_Search.Item(0, dg_Search.CurrentRow.Index).Value
        void.SetOrderId(orderId)
        If void.checkRefundExists() = True Then
            MsgBox("The selected transaction has an existing refund record and cannot be voided.", vbInformation)
            Exit Sub
        End If
        If void.checkVoidExists() = True Then
            MsgBox("The selected transaction has already been voided before.", vbInformation)
            Exit Sub
        End If
        frmVoidTransdate.ShowDialog()
    End Sub

    Private Sub frmVoid_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbo_history_Type.SelectedIndex = 0
        cbo_cb_Search.SelectedIndex = 0
        lbl_due_Total.Text = "0.00"
        dtp_From.Value = DateTime.Now
        dtp_To.Value = DateTime.Now
        KeyPreview = True
    End Sub
    Private Sub frmRefund_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btn_Load_Click(sender, e)
            Case Keys.F2
                btn_New_Click(sender, e)
            Case Keys.F5
                btn_Confirm_Click(sender, e)
            Case Keys.Escape
                btn_Back_Click(sender, e)
        End Select
    End Sub
    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        If MsgBox("All inputs will be cleared. Do you wish to continue?", vbYesNo + vbInformation) = vbYes Then
            dg_Search.Rows.Clear()
            lbl_due_Total.Text = "0.00"
            dtp_From.Value = Date.Now
            dtp_To.Value = Date.Now
        End If
    End Sub
    Private Sub tb_Orders_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tb_receiptNo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btn_History_Click(sender As Object, e As EventArgs) Handles btn_History.Click

    End Sub

    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        void.SetBranchId(frmPos.lbl_branch_Id.Text)
        If cbo_cb_Search.SelectedIndex = 0 Then
            void.searchOrders("SELECT orders.order_id, orders.trans_date AS transDate, credit_payment.trans_date AS InputedDate, invoice,  pay_amount, gross_amount 
                               FROM credit_payment 
                               INNER JOIN orders ON orders.order_id = credit_payment.order_id 
                               WHERE orders.branch_id = @branch_id AND (credit_payment.trans_date BETWEEN '" & dtp_cb_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_cb_To.Value.ToString("yyyy-MM-dd") & "')  
                               UNION 
                               SELECT orders.order_id, orders.trans_date AS transDate, cash_payment.trans_date AS InputedDate, receipt,  pay_amount, gross_amount 
                               FROM cash_payment 
                               INNER JOIN orders ON orders.order_id = cash_payment.order_id 
                               WHERE orders.branch_id = @branch_id AND (cash_payment.trans_date BETWEEN '" & dtp_cb_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_cb_To.Value.ToString("yyyy-MM-dd") & "')")
        ElseIf cbo_cb_Search.SelectedIndex = 1 Then
            void.searchOrders("SELECT orders.order_id, orders.trans_date AS transDate, credit_payment.trans_date AS InputedDate, invoice,  pay_amount, gross_amount 
                               FROM credit_payment 
                               INNER JOIN orders ON orders.order_id = credit_payment.order_id 
                               WHERE orders.branch_id = @branch_id AND (orders.trans_date BETWEEN '" & dtp_cb_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_cb_To.Value.ToString("yyyy-MM-dd") & "')  
                               UNION 
                               SELECT orders.order_id, orders.trans_date AS transDate, cash_payment.trans_date AS InputedDate, receipt,  pay_amount, gross_amount 
                               FROM cash_payment 
                               INNER JOIN orders ON orders.order_id = cash_payment.order_id 
                               WHERE orders.branch_id = @branch_id AND (orders.trans_date BETWEEN '" & dtp_cb_From.Value.ToString("yyyy-MM-dd") & "' AND '" & dtp_cb_To.Value.ToString("yyyy-MM-dd") & "')")
        End If

        If dg_Search.RowCount = 0 Then
            MsgBox("No available orders to load for the given dates.", vbInformation)
        Else
            lbl_due_Total.Text = dg_Search.Item(5, 0).Value
            lbl_OrderId.Text = dg_Search.Item(0, dg_Search.CurrentRow.Index).Value
        End If
    End Sub

    Private Sub btn_View_Click(sender As Object, e As EventArgs) Handles btn_View.Click
        If dg_Search.Rows.Count = 0 Then
            MsgBox("No Transactions to be loaded.", vbExclamation)
            Exit Sub
        End If
        frmOrderTransacs.ShowDialog()
    End Sub

    Private Sub dg_Search_SelectionChanged(sender As Object, e As EventArgs) Handles dg_Search.SelectionChanged
        lbl_due_Total.Text = dg_Search.Item(5, dg_Search.CurrentRow.Index).Value
        lbl_OrderId.Text = dg_Search.Item(0, dg_Search.CurrentRow.Index).Value
    End Sub
End Class