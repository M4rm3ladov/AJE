Public Class frmAuthenticate
    Dim cashInOut As New clsCashInOut
    Dim cashLog As New clsCashierLog
    Dim credPay As New clsCreditPay
    Dim refund As New clsRefund
    Dim auth As New clsAuth
    Dim authKey As Integer
    Private Sub btn_Ok_Click_(sender As Object, e As EventArgs) Handles btn_Ok.Click
        auth.SetUsername(tb_Username.Text) 'authkey: 1 if inactive, 2 signed-in, 3 if valid
        auth.SetPassword(tb_Password.Text)
        authKey = auth.authLogin()
        If authKey = 0 Then
            MsgBox("Username or Password incorrect.", vbCritical)
            Exit Sub
        ElseIf authKey = 1 Then
            MsgBox("User is currently inactive.", vbCritical)
            Exit Sub
        ElseIf authKey = 3 Then
            tb_Username.Clear()
            tb_Password.Clear()
            MsgBox("Verfied by manager.", vbInformation)
        End If

        If lbl_Type.Text = 1 Then
            cashLog.SetCashierId(frmPos.lbl_user_Id.Text)
            cashLog.SetManagerId(auth.setUserId)
            cashLog.SetLogDate(Date.Now.ToString("yyyy-MM-dd"))
            cashLog.SetTimeIn(TimeOfDay.ToString("HH:mm:ss"))
            cashLog.SetInBal(frmBalance.tb_initial_Bal.Text)
            frmPos.cashier_log_id.Text = cashLog.setCashierIn()
            frmBalance.tb_initial_Bal.Clear()
            frmBalance.Close()

        ElseIf lbl_Type.Text = 2 Then
            cashInOut.SetManagerId(auth.setUserId)
            cashInOut.SetTrans_Date(frmCash_in.dtp_transDate.Value.ToString("yyyy-MM-dd"))
            cashInOut.SetAmount(frmCash_in.tb_Amount.Text)
            cashInOut.SetRemarks(frmCash_in.tb_Remarks.Text)
            If frmCash_in.lbl_cash_In.Visible = True Then
                cashInOut.saveCashIn()

            ElseIf frmCash_in.lbl_cash_Out.Visible = True Then
                cashInOut.saveCashOut()

            End If
        ElseIf lbl_Type.Text = 3 Then
            credPay.SetCashierId(frmPos.lbl_user_Id.Text)
            credPay.SetManagerId(auth.setUserId)
            credPay.SetPayAmount(frmCheckoutCred.tb_cash_Tendered.Text)
            credPay.SetPayTransDate(frmCheckoutCred.dtp_Date.Value.ToString("yyyy-MM-dd"))
            credPay.SetReceipt(frmCheckoutCred.tb_Receipt.Text)
            Dim updatedBal = Math.Max(0, Val(credPay.setCustomerBalance) - Val(frmCheckoutCred.tb_cash_Tendered.Text))
            credPay.SetBalance(updatedBal)
            credPay.savePayment()
            MsgBox("Payment saved. User: " & frmCreditPay.tb_Name.Text & " balance is Php: " & updatedBal, vbInformation)

            With frmCheckoutCred
                .tb_Receipt.Clear()
                .tb_cash_Tendered.Clear()
                .tb_Change.Text = Format(0.00, "0.00")
            End With
            With frmCreditPay
                .dg_Transactions.Rows.Clear()
                .tb_Name.Clear()
                .lbl_customer_Id.Text = ""
                .lbl_Balance.Text = Format(0.00, "0.00")
            End With

        ElseIf lbl_Type.Text = 4 Then
            refund.SetTransDate(frmRefundTransDate.dtp_Date.Value.ToString("yyyy-MM-dd"))
            refund.SetCashierId(frmPos.lbl_user_Id.Text)
            refund.SetManagerId(auth.setUserId)
            refund.SetAmount(frmRefund.lbl_due_Total.Text)
            refund.SetRemarks(frmRefundTransDate.tb_Remarks.Text)
            refund.SetOrderId(frmRefund.lbl_OrderId.Text)
            refund.SetBranchId(frmPos.lbl_branch_Id.Text)
            refund.saveRefund()
            MsgBox("Transaction saved successfully.")

            frmRefund.dg_Search.Rows.Clear()
            frmRefund.dg_Refund.Rows.Clear()
            frmRefund.tb_receiptNo.Clear()
            frmRefund.tb_Orders.Clear()
            frmRefund.lbl_due_Total.Text = ""
            frmRefund.cbo_Receipt.SelectedIndex = 0
            frmRefund.dtp_Date.Value = Date.Now
        End If

        Me.Close()
    End Sub

    Private Sub tb_username_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Username.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tb_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        tb_Password.Clear()
        tb_Username.Clear()
        Me.Close()
    End Sub

End Class