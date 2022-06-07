Public Class frmPos
    Dim loginPos As New clsLoginPos
    Dim cashLog As New clsCashierLog
    Dim order As New clsOrder
    Private Sub frmPos_Load(sender As Object, e As EventArgs) Handles Me.Load
        tb_Search.Focus()
        lbl_transac_Date.Text = Date.Now.ToString("MM/dd/yyy")

        order.SetBranchId(lbl_branch_Id.Text)
        Dim transCode = order.getTransCode()
        Dim transCodeLegnth As String = transCode.ToString()
        Dim zero = ""
        For i = 0 To 5 - transCodeLegnth.Length
            zero &= "0"
            i += 1
        Next

        lbl_transaction_Code.Text = Date.Now.ToString("yyyyMMdd") & zero & transCode
        frmNewTransaction.btn_Close.Visible = False
        'load items inside cbo_Desc
        cbo_Type.SelectedIndex = 0
        'enable shortcut keys
        KeyPreview = True
    End Sub
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If dg_Search.RowCount = 0 Then
            MsgBox("No Item or Service has been selected", vbExclamation)
            Exit Sub
        End If

        If dg_Order.RowCount <> 0 Then
            Dim iSearch As Integer = dg_Search.CurrentRow.Index 'sets the current selected row of dg_Search
            For i = 0 To dg_Order.RowCount - 1
                Dim orderCode = dg_Order.Rows(i).Cells(1).Value 'sets service Id or item Id of dg_Order and dg_Search
                Dim searchCode = dg_Search.Item(1, iSearch).Value

                If orderCode = searchCode Then                     'checks if item or service has already been added to list to prevent entry duplication
                    MsgBox("Item has already been added.", vbExclamation)
                    Exit Sub
                End If

            Next
        End If
        frmPrice.btn_Add.Text = "Add"
        frmPrice.lbl_Type.Text = 1
        frmPrice.ShowDialog()
    End Sub

    Private Sub btn_Checkout_Click(sender As Object, e As EventArgs) Handles btn_Checkout.Click
        If dg_Order.Rows.Count = 0 Then
            MsgBox("Please add items/services in cart before checking out.", vbExclamation)
            Exit Sub
        End If
        If lbl_pay_Type.Text = "Credit" Then
            If tb_customer_Name.Text = vbNullString Then
                MsgBox("Please add a customer before checking out.", vbExclamation)
                Exit Sub
            End If
            If order.getCreditLimit < (Val(order.getBalance) + Val(lbl_due_Total.Text)) Then
                MsgBox("The amount exceeds the alloted credit limit." & vbNewLine & vbNewLine & "Amount expendable for user: " & tb_customer_Name.Text & " is PHP " & Val(order.getCreditLimit) - Val(order.getBalance) & " ", vbExclamation)
                Exit Sub
            End If
            frmCheckout.lbl_Receipt.Text = "Invoice Number:"
        ElseIf lbl_pay_Type.Text = "Cash" Then
            frmCheckout.lbl_Receipt.Text = "Receipt Number:"
        End If
        frmCheckout.lbl_Due.Text = "Due Total:"
        frmCheckout.ShowDialog()
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        frmNewTransaction.btn_Close.Visible = True
        Dim ans = MsgBox("The Current Transaction will be Canceled, Do You Wish to Continue?", vbQuestion + vbYesNo, "Warning!")
        If ans = vbYes Then
            frmNewTransaction.ShowDialog()
        End If

    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        If MsgBox("Do you wish to logout?", vbQuestion + vbYesNo) = vbYes Then
            cashLog.SetCashierLogId(cashier_log_id.Text)
            cashLog.SetCashierId(Me.lbl_user_Id.Text)
            cashLog.SetTimeOut(TimeOfDay.ToString(("HH:mm:ss")))
            cashLog.SetEndBal(cashLog.calcEndBal())
            cashLog.setCashierOut()
            loginPos.SetUsername(lbl_Username.Text)
            loginPos.setUserLogin(0)
            frmMain.Show()
            frmMain.KeyPreview = True
            Me.Close()
        End If
    End Sub

    Private Sub btn_CashIn_Click(sender As Object, e As EventArgs) Handles btn_CashIn.Click
        With frmCash_in
            .lbl_cash_In.Visible = True
            .lbl_cash_Out.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_CashOut_Click(sender As Object, e As EventArgs) Handles btn_CashOut.Click
        With frmCash_in
            .lbl_cash_Out.Visible = True
            .lbl_cash_In.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_Refund_Click(sender As Object, e As EventArgs) Handles btn_Refund.Click
        frmRefund.ShowDialog()
    End Sub

    Private Sub btn_Balance_Click(sender As Object, e As EventArgs) Handles btn_Balance.Click
        frmCreditPay.ShowDialog()
    End Sub

    Private Sub cbo_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Type.SelectedIndexChanged
        tb_Search.Text = vbNullString
        If cbo_Type.SelectedIndex = 0 Then

        ElseIf cbo_Type.SelectedIndex = 1 Then

        End If
    End Sub

    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        'set branch to retreive items/services
        order.SetBranchId(lbl_branch_Id.Text)
        If Trim(tb_Search.Text) <> "" Then
            'assigns search text
            order.SetItemSearch(Trim(tb_Search.Text))
            'search for item
            If cbo_Type.SelectedIndex = 0 Then
                order.searchItem("SELECT inventory.item_id, item_code, item_desc, item_add_desc, unit_name, item_price_A, item_price_B, brand.brand_name, category.category_name FROM inventory " &
                            "INNER JOIN item ON item.item_id = inventory.item_id " &
                            "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                            "INNER JOIN category ON category.category_id = item.category_id " &
                            "INNER JOIN branch ON branch.branch_id = inventory.branch_id " &
                            "INNER JOIN unit ON unit.unit_id = item.unit_id " &
                            "WHERE (inventory.branch_id = @branch_id) AND (item_code LIKE @0 OR item_desc LIKE @0 OR item_add_desc LIKE @0 OR brand_name LIKE @0 OR category_name LIKE @0 OR " &
                            "CONCAT(brand_name, ' ', item_desc, ' ', item_add_desc, ' ', category_name) LIKE @0) ")
                'search for services
            ElseIf cbo_Type.SelectedIndex = 1 Then
                order.searchService("SELECT service_id, service_code, service_desc, '', service_fee_A, service_fee_B FROM service WHERE service_code LIKE @0 OR service_desc LIKE @0")
            End If
        Else
            'if text search is empty string 
            dg_Search.Rows.Clear()
        End If
    End Sub

    Private Sub frmPos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btn_Add_Click(sender, e)
            Case Keys.F2
                btn_New_Click(sender, e)
            Case Keys.F3
                btn_Refund_Click(sender, e)
            Case Keys.F4
                btn_Balance_Click(sender, e)
            Case Keys.F5
                btn_Checkout_Click(sender, e)
            Case Keys.F6
                btn_Void_Click(sender, e)
            Case Keys.Escape
                btn_Logout_Click(sender, e)
            Case Keys.F8
                btn_CashIn_Click(sender, e)
            Case Keys.F9
                btn_CashOut_Click(sender, e)

        End Select
    End Sub

    Private Sub dg_Search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Search.CellContentClick
        Dim colName As String = dg_Search.Columns(e.ColumnIndex).Name
        If colName = "col_Add" Then
            If dg_Search.RowCount = 0 Then
                MsgBox("No Item or Service has been selected", vbExclamation)
                Exit Sub
            End If

            If dg_Order.RowCount <> 0 Then
                Dim iSearch As Integer = dg_Search.CurrentRow.Index 'sets the current selected row of dg_Search
                For i = 0 To dg_Order.RowCount - 1
                    Dim orderId = dg_Order.Rows(i).Cells(0).Value 'sets service Id or item Id of dg_Order and dg_Search
                    Dim searchId = dg_Search.Item(0, iSearch).Value

                    If orderId = searchId Then                     'checks if item or service has already been added to list to prevent entry duplication
                        MsgBox("Item has already been added.", vbExclamation)
                        Exit Sub
                    End If

                Next
            End If
            frmPrice.btn_Add.Text = "Add"
            frmPrice.lbl_Type.Text = 1
            frmPrice.ShowDialog()
        End If

    End Sub

    Private Sub dg_Order_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Order.CellContentClick
        Dim colName As String = dg_Order.Columns(e.ColumnIndex).Name
        Dim i As Integer = dg_Order.CurrentRow.Index
        If colName = "col_Edit" Then
            frmPrice.tb_Price.Text = dg_Order.Item(4, i).Value
            frmPrice.tb_Qty.Text = dg_Order.Item(5, i).Value
            frmPrice.lbl_Type.Text = 2
            frmPrice.btn_Add.Text = "Save"
            frmPrice.ShowDialog()
        ElseIf colName = "col_Remove" Then
            If MsgBox("Do you wish to remove item from the list?", vbQuestion + vbYesNo) = vbYes Then
                dg_Order.Rows.RemoveAt(dg_Order.SelectedRows(0).Index)
                For i = 0 To dg_Order.RowCount - 1
                    dg_Order.Rows(i).Cells(1).Value = i + 1
                Next
                MsgBox("Item has been removed.", vbInformation)

                Dim due_total As Decimal = 0.00
                For i = 0 To dg_Order.RowCount - 1
                    due_total = due_total + dg_Order.Item(5, i).Value
                Next
                lbl_due_Total.Text = Format(due_total, "0.00") 'set due total
            End If
        End If
    End Sub
    Private Sub lbl_Customer_MouseHover(sender As Object, e As EventArgs) Handles lbl_Customer.MouseHover
        lbl_Customer.ForeColor = Color.Blue
    End Sub

    Private Sub lbl_Customer_MouseLeave(sender As Object, e As EventArgs) Handles lbl_Customer.MouseLeave
        lbl_Customer.ForeColor = Color.Black
    End Sub

    Private Sub lbl_Customer_Click(sender As Object, e As EventArgs) Handles lbl_Customer.Click
        frmCustomerSearch.lbl_Type.Text = 1
        frmCustomerSearch.ShowDialog()
    End Sub

    Private Sub tb_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btn_Void_Click(sender As Object, e As EventArgs) Handles btn_Void.Click
        frmVoid.ShowDialog()
    End Sub
End Class