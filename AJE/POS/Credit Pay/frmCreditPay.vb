Public Class frmCreditPay
    Dim creditPay As New clsCreditPay
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        dg_Transactions.Rows.Clear()
        tb_Name.Clear()
        lbl_customer_Id.Text = vbNullString
        lbl_Balance.Text = Format(0.00, "0.00")
        'history clear
        dg_History.Rows.Clear()
        tb_CustName.Clear()
        lbl_custId.Text = vbNullString
        dtp_From.Value = Date.Now
        dtp_To.Value = Date.Now
        Me.Close()
    End Sub

    Private Sub btn_Checkout_Click(sender As Object, e As EventArgs) Handles btn_Checkout.Click
        If Val(lbl_Balance.Text) = 0.00 Then
            MsgBox("Customer has no existing balance.", vbExclamation)
            Exit Sub
        End If

        If tb_Name.Text = vbNullString Then
            MsgBox("Please add a customer befor checking out.", vbExclamation)
            Exit Sub
        End If
        frmCheckoutCred.ShowDialog()
    End Sub

    Private Sub frmCreditPay_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_From.Value = Date.Now
        dtp_To.Value = Date.Now
        KeyPreview = True
    End Sub

    Private Sub frmCreditPay_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If tc_Credit.SelectedIndex = 0 Then
            Select Case e.KeyCode
                Case Keys.F1
                    btn_Load_Click(sender, e)
                Case Keys.F2
                    btn_New_Click(sender, e)
                Case Keys.F5
                    btn_Checkout_Click(sender, e)
                Case Keys.Escape
                    btn_Back_Click(sender, e)

            End Select
        ElseIf tc_Credit.SelectedIndex = 1 Then
            If e.KeyCode = Keys.Escape Then
                btn_Back_Click(sender, e)
            End If
        End If

    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        frmNewTransaction.btn_Close.Visible = True
        Dim ans = MsgBox("The Current Transaction will be Canceled, Do You Wish to Continue?", vbQuestion + vbYesNo, "Warning!")
        If ans = vbYes Then
            tb_Name.Clear()
            dg_Transactions.Rows.Clear()
            lbl_Balance.Text = Format(0.00, "0.00")
        End If
    End Sub

    Private Sub lbl_Customer_MouseHover(sender As Object, e As EventArgs) Handles lbl_Customer.MouseHover
        lbl_Customer.ForeColor = Color.Blue
    End Sub

    Private Sub lbl_Customer_MouseLeave(sender As Object, e As EventArgs) Handles lbl_Customer.MouseLeave
        lbl_Customer.ForeColor = Color.Black
    End Sub

    Private Sub lbl_Customer_Click(sender As Object, e As EventArgs) Handles lbl_Customer.Click
        frmCustomerSearch.lbl_Type.Text = 2
        frmCustomerSearch.ShowDialog()
    End Sub

    Private Sub lbl_custSearch_MouseHover(sender As Object, e As EventArgs) Handles lbl_custSearch.MouseHover
        lbl_custSearch.ForeColor = Color.Blue
    End Sub

    Private Sub lbl_custSearch_MouseLeave(sender As Object, e As EventArgs) Handles lbl_custSearch.MouseLeave
        lbl_custSearch.ForeColor = Color.Black
    End Sub

    Private Sub lbl_custSearch_Click(sender As Object, e As EventArgs) Handles lbl_custSearch.Click
        frmCustomerSearch.lbl_Type.Text = 3
        frmCustomerSearch.ShowDialog()
    End Sub

    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        If dg_Transactions.Rows.Count = 0 Then
            MsgBox("No Transactions to be loaded.", vbExclamation)
            Exit Sub
        End If
        frmCreditTransacs.ShowDialog()
    End Sub

    Private Sub tb_Name_TextChanged(sender As Object, e As EventArgs) Handles tb_Name.TextChanged
        lbl_Balance.Text = creditPay.setCustomerBalance()

        If Trim(tb_Name.Text) <> "" Then
            'assigns search text
            creditPay.SetCustomerSearch(Trim(lbl_customer_Id.Text))
            'search for item
            creditPay.searchCustomerCredit("SELECT orders.order_id, invoice, orders.trans_date, gross_amount FROM credit_payment INNER JOIN 
                                            orders ON orders.order_id = credit_payment.order_id WHERE customer_id = @0")

        Else
            'if text search is empty string 
            dg_Transactions.Rows.Clear()
        End If
    End Sub

    Private Sub btn_load_History_Click(sender As Object, e As EventArgs) Handles btn_load_History.Click
        creditPay.SetDateFrom(dtp_From.Value.ToString("yyyy-MM-dd"))
        creditPay.SetDateTo(dtp_To.Value.ToString("yyyy-MM-dd"))
        creditPay.SetCustomer(lbl_custId.Text)
        creditPay.loadPayHistory()
    End Sub

End Class