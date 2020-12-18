Public Class frmRefund
    Dim refund As New clsRefund
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        If MsgBox("Transaction will be cleared, Do you wish to exit?", vbYesNo + vbInformation) = vbNo Then
            Exit Sub
        End If
        dg_Search.Rows.Clear()
        dg_Refund.Rows.Clear()
        tb_receiptNo.Clear()
        tb_Orders.Clear()
        tb_Orders.Enabled = False
        cbo_Orders.Enabled = False
        lbl_due_Total.Text = "0.00"
        cbo_Receipt.SelectedIndex = 0
        dtp_Date.Value = Date.Now
        GroupBox1.Enabled = True
        Me.Close()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If dg_Search.RowCount = 0 Then
            MsgBox("No Item or Service has been selected", vbExclamation)
            Exit Sub
        End If

        If dg_Refund.RowCount <> 0 Then
            Dim iSearch As Integer = dg_Search.CurrentRow.Index 'sets the current selected row of dg_Search
            For i = 0 To dg_Refund.RowCount - 1
                Dim orderCode = dg_Refund.Rows(i).Cells(1).Value 'sets service Id or item Id of dg_Order and dg_Search
                Dim searchCode = dg_Search.Item(1, iSearch).Value

                If orderCode = searchCode Then                     'checks if item or service has already been added to list to prevent entry duplication
                    MsgBox("Item has already been added.", vbExclamation)
                    Exit Sub
                End If

            Next
        End If
        frmPriceRefund.btn_Add.Text = "Add"
        frmPriceRefund.lbl_Type.Text = 1
        frmPriceRefund.ShowDialog()
    End Sub

    Private Sub btn_Confirm_Click(sender As Object, e As EventArgs) Handles btn_Confirm.Click
        If dg_Refund.Rows.Count = 0 Then
            MsgBox("Please add items/services in cart before checking out.", vbExclamation)
            Exit Sub
        End If
        frmRefundTransDate.ShowDialog()
    End Sub

    Private Sub frmRefund_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtp_Date.Value = DateTime.Now
        cbo_Receipt.SelectedIndex = 0
        KeyPreview = True
    End Sub

    Private Sub frmRefund_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                btn_Add_Click(sender, e)
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
            dg_Refund.Rows.Clear()
            tb_receiptNo.Clear()
            tb_Orders.Clear()
            lbl_due_Total.Text = "0.00"
            tb_Orders.Enabled = False
            cbo_Orders.Enabled = False
            cbo_Receipt.SelectedIndex = 0
            dtp_Date.Value = Date.Now
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub tb_Search_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tb_invoiceNo_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_receiptNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        dg_Search.Rows.Clear()
        tb_Orders.Clear()
        cbo_Orders.SelectedIndex = 0
        refund.SetTransDate(dtp_Date.Value.ToString("yyyy-MM-dd"))
        refund.SetBranchId(frmPos.lbl_branch_Id.Text)
        If cbo_Receipt.SelectedIndex = 0 Then
            refund.SetReceiptNo(tb_receiptNo.Text.Trim)
            If refund.loadFromReceipt() = False Then
                cbo_Orders.Enabled = False
                tb_Orders.Enabled = False
                MsgBox("No record found!", vbExclamation)

            ElseIf refund.loadFromReceipt() = True Then
                cbo_Orders.Enabled = True
                tb_Orders.Enabled = True
                GroupBox1.Enabled = False
                lbl_OrderId.Text = refund.loadOrderIdReceipt()
            End If
        ElseIf cbo_Receipt.SelectedIndex = 1 Then
            refund.SetInvoiceNo(tb_receiptNo.Text.Trim)
            If refund.loadFromInvoice = False Then

                cbo_Orders.Enabled = False
                tb_Orders.Enabled = False
                MsgBox("No record found!", vbExclamation)

            ElseIf refund.loadFromInvoice() = True Then
                cbo_Orders.Enabled = True
                tb_Orders.Enabled = True
                GroupBox1.Enabled = False
                lbl_OrderId.Text = refund.loadOrderIdInvoice()
            End If
            dg_Refund.Rows.Clear()
        End If
    End Sub

    Private Sub tb_Orders_TextChanged(sender As Object, e As EventArgs) Handles tb_Orders.TextChanged
        If tb_Orders.Text.Trim = "" Then
            dg_Search.Rows.Clear()
            Exit Sub
        End If
        refund.SetItemSearch(Trim(tb_Orders.Text))

        If cbo_Receipt.SelectedIndex = 0 Then
            If refund.loadFromReceipt = True Then
                cbo_Orders.Enabled = True
                tb_Orders.Enabled = True
                If cbo_Orders.SelectedIndex = 0 Then
                    refund.searchItem("SELECT item.item_id, item.item_code, order_item_dtls.qty, order_item_dtls.price, order_item_dtls.line_total, CONCAT(brand_name, ' | ', item_desc, ' | ', item_add_desc, ' | ', category_name) As description, unit_name FROM order_item_dtls " &
                                    "INNER JOIN orders on orders.`order_id` = order_item_dtls.`order_id` " &
                                    "INNER JOIN cash_payment ON cash_payment.order_id = orders.order_id " &
                                    "INNER JOIN inventory on inventory.`inventory_id` = order_item_dtls.`inventory_id` " &
                                    "INNER JOIN item on item.`item_id` = inventory.`item_id` " &
                                    "INNER JOIN unit on unit.unit_id= item.unit_id " &
                                    "INNER JOIN brand on brand.`brand_id` = item.`brand_id` " &
                                    "INNER JOIN category on category.`category_id` = item.`category_id` WHERE (inventory.branch_id = @branch_id) AND (item_code LIKE @0 OR item_desc LIKE @0 OR item_add_desc LIKE @0 OR brand_name LIKE @0 OR category_name LIKE @0 OR " &
                                    "CONCAT(brand_name, ' ', item_desc, ' ', item_add_desc, ' ', category_name, ' ', unit_name) LIKE @0 or unit_name LIKE @0) AND (receipt = @receipt) AND (cash_payment.trans_date = @trans_date)")

                ElseIf cbo_Orders.SelectedIndex = 1 Then
                    refund.searchService("SELECT service.service_id, service_code, service_desc, '',  order_svc_dtls.qty, order_svc_dtls.price, order_svc_dtls.line_total FROM order_svc_dtls " &
                                    "INNER JOIN orders ON orders.order_id = order_svc_dtls.order_id " &
                                    "INNER JOIN cash_payment ON cash_payment.order_id = orders.order_id " &
                                    "INNER JOIN service ON service.service_id = order_svc_dtls.service_id " &
                                    "WHERE service_code LIKE @0 OR service_desc LIKE @0 AND (receipt = @receipt) AND (cash_payment.trans_date = @trans_date)")
                End If
            End If
        ElseIf cbo_Receipt.SelectedIndex = 1 Then
            If refund.loadFromInvoice = True Then
                cbo_Orders.Enabled = True
                tb_Orders.Enabled = True
                If cbo_Orders.SelectedIndex = 0 Then
                    refund.searchItemInvoice("SELECT item.item_id, item_code, order_item_dtls.qty, order_item_dtls.price, order_item_dtls.line_total, CONCAT(brand_name, ' | ', item_desc, ' | ', item_add_desc, ' | ', category_name) As description, unit_name FROM order_item_dtls " &
                                    "INNER JOIN orders on orders.`order_id` = order_item_dtls.`order_id` " &
                                    "INNER JOIN credit_payment ON credit_payment.order_id = orders.order_id " &
                                    "INNER JOIN inventory on inventory.`inventory_id` = order_item_dtls.`inventory_id` " &
                                    "INNER JOIN item on item.`item_id` = inventory.`item_id` " &
                                    "INNER JOIN unit on unit.unit_id = item.unit_id " &
                                    "INNER JOIN brand on brand.`brand_id` = item.`brand_id` " &
                                    "INNER JOIN category on category.`category_id` = item.`category_id` WHERE (inventory.branch_id = @branch_id) AND (item_code LIKE @0 OR item_desc LIKE @0 OR item_add_desc LIKE @0 OR brand_name LIKE @0 OR category_name LIKE @0 OR " &
                                    "unit_name LIKE @0 OR CONCAT(brand_name, ' ', item_desc, ' ', item_add_desc, ' ', category_name, ' ', unit_name) LIKE @0) AND (invoice = @invoice) AND (credit_payment.trans_date = @trans_date)")
                ElseIf cbo_Orders.SelectedIndex = 1 Then
                    refund.searchServiceInvoice("SELECT service.service_id, service_code, service_desc, '', order_svc_dtls.qty, order_svc_dtls.price, order_svc_dtls.line_total FROM order_svc_dtls " &
                                        "INNER JOIN orders ON orders.order_id = order_svc_dtls.order_id " &
                                        "INNER JOIN credit_payment ON credit_payment.order_id = orders.order_id " &
                                        "INNER JOIN service ON service.service_id = order_svc_dtls.service_id " &
                                        "WHERE service_code LIKE @0 OR service_desc LIKE @0 AND (invoice = @invoice) AND (credit_payment.trans_date = @trans_date)")
                End If
            End If
        End If

    End Sub

    Private Sub dg_Search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Search.CellContentClick
        Dim colName As String = dg_Search.Columns(e.ColumnIndex).Name
        If colName = "col_Add" Then
            If dg_Search.RowCount = 0 Then
                MsgBox("No Item or Service has been selected", vbExclamation)
                Exit Sub
            End If

            If dg_Refund.RowCount <> 0 Then
                Dim iSearch As Integer = dg_Search.CurrentRow.Index 'sets the current selected row of dg_Search
                For i = 0 To dg_Refund.RowCount - 1
                    Dim orderId = dg_Refund.Rows(i).Cells(0).Value 'sets service Id or item Id of dg_Order and dg_Search
                    Dim searchId = dg_Search.Item(0, iSearch).Value

                    If orderId = searchId Then                     'checks if item or service has already been added to list to prevent entry duplication
                        MsgBox("Item has already been added.", vbExclamation)
                        Exit Sub
                    End If

                Next
            End If
            frmPriceRefund.btn_Add.Text = "Add"
            frmPriceRefund.lbl_Type.Text = 1
            frmPriceRefund.ShowDialog()
        End If
    End Sub

    Private Sub dg_Refund_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Refund.CellContentClick
        Dim colName As String = dg_Refund.Columns(e.ColumnIndex).Name
        Dim i As Integer = dg_Refund.CurrentRow.Index
        If colName = "col_Edit" Then
            frmPriceRefund.tb_Price.Text = dg_Refund.Item(4, i).Value
            frmPriceRefund.tb_Qty.Text = dg_Refund.Item(5, i).Value
            frmPriceRefund.lbl_Type.Text = 2
            frmPriceRefund.btn_Add.Text = "Save"
            frmPriceRefund.ShowDialog()
        ElseIf colName = "col_Remove" Then
            If MsgBox("Do you wish to remove item from the list?", vbQuestion + vbYesNo) = vbYes Then
                dg_Refund.Rows.RemoveAt(dg_Refund.SelectedRows(0).Index)
                For i = 0 To dg_Refund.RowCount - 1
                    dg_Refund.Rows(i).Cells(1).Value = i + 1
                Next
                MsgBox("Item has been removed.", vbInformation)

                Dim due_total As Decimal = 0.00
                For i = 0 To dg_Refund.RowCount - 1
                    due_total = due_total + dg_Refund.Item(6, i).Value
                Next
                lbl_due_Total.Text = Format(due_total, "0.00") 'set due total
            End If
        End If
    End Sub
End Class