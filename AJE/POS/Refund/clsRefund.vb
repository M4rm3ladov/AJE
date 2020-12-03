Imports MySql.Data.MySqlClient
Public Class clsRefund
    Private _TransDate As Object
    Private _ReceiptNo As Object
    Private _InvoiceNo As Object
    Private _ItemSearch As Object
    Private _BranchId As Object
    Private _CashierId As Object
    Private _ManagerId As Object
    Private _Amount As Object
    Private _Remarks As Object
    Private _OrderId As Object
    Public Sub SetTransDate(AutoPropertyValue As Object)
        _TransDate = AutoPropertyValue
    End Sub
    Public Sub SetReceiptNo(AutoPropertyValue As Object)
        _ReceiptNo = AutoPropertyValue
    End Sub
    Public Sub SetInvoiceNo(AutoPropertyValue As Object)
        _InvoiceNo = AutoPropertyValue
    End Sub
    Public Sub SetItemSearch(AutoPropertyValue As Object)
        _ItemSearch = AutoPropertyValue
    End Sub
    Public Sub SetBranchId(AutoPropertyValue As Object)
        _BranchId = AutoPropertyValue
    End Sub
    Public Sub SetCashierId(AutoPropertyValue As Object)
        _CashierId = AutoPropertyValue
    End Sub
    Public Sub SetManagerId(AutoPropertyValue As Object)
        _ManagerId = AutoPropertyValue
    End Sub
    Public Sub SetAmount(AutoPropertyValue As Object)
        _Amount = AutoPropertyValue
    End Sub
    Public Sub SetRemarks(AutoPropertyValue As Object)
        _Remarks = AutoPropertyValue
    End Sub
    Public Sub SetOrderId(AutoPropertyValue As Object)
        _OrderId = AutoPropertyValue
    End Sub
    Public Function loadFromReceipt()
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT receipt FROM cash_payment WHERE receipt = @receipt AND trans_date = @trans_date) "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@receipt", _ReceiptNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        Dim count = cm.ExecuteScalar()

        If count = 1 Then
            DisconnectDatabase()
            Return True
        Else
            DisconnectDatabase()
            Return False
        End If
    End Function
    Public Function loadFromInvoice()
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT invoice FROM credit_payment WHERE invoice = @invoice AND trans_date = @trans_date) "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@invoice", _InvoiceNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        Dim count = cm.ExecuteScalar()

        If count = 1 Then
            DisconnectDatabase()
            Return True
        Else
            DisconnectDatabase()
            Return False
        End If
    End Function

    Public Sub searchItem(query As String) 'dg_Search item populate
        frmRefund.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        cm.Parameters.AddWithValue("@receipt", _ReceiptNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        dr = cm.ExecuteReader()
        While dr.Read
            frmRefund.dg_Search.Rows.Add(dr.Item("item_id").ToString, dr.Item("item_code").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("line_total").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub searchService(query As String) 'dg_Search service populate
        frmRefund.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@receipt", _ReceiptNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        dr = cm.ExecuteReader()
        While dr.Read
            frmRefund.dg_Search.Rows.Add(dr.Item("service_id").ToString, dr.Item("service_code"), dr.Item("service_desc").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("line_total").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub searchItemInvoice(query As String) 'dg_Search item populate
        frmRefund.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        cm.Parameters.AddWithValue("@invoice", _InvoiceNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        dr = cm.ExecuteReader()
        While dr.Read
            frmRefund.dg_Search.Rows.Add(dr.Item("item_id").ToString, dr.Item("item_code").ToString, dr.Item("description"), dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("line_total").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub searchServiceInvoice(query As String) 'dg_Search service populate
        frmRefund.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@invoice", _InvoiceNo)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        dr = cm.ExecuteReader()
        While dr.Read
            frmRefund.dg_Search.Rows.Add(dr.Item("service_id").ToString, dr.Item("service_code"), dr.Item("service_desc").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("line_total").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub saveRefund()
        ConnectDatabase()
        Dim query = "INSERT INTO refund (order_id, cashier_id, manager_id, amount, trans_date, remarks) VALUE(@order_id, @cashier_id, @manager_id, @amount, @trans_date, @remarks); SELECT LAST_INSERT_ID();"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@order_id", _OrderId)
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        cm.Parameters.AddWithValue("@manager_id", _ManagerId)
        cm.Parameters.AddWithValue("@amount", _Amount)
        cm.Parameters.AddWithValue("@trans_date", _TransDate)
        cm.Parameters.AddWithValue("@remarks", _Remarks)
        Dim refId = cm.ExecuteScalar()

        Dim _service_code, _id, _qty, _price, _line_total
        For i = 0 To frmRefund.dg_Refund.RowCount - 1
            _service_code = frmRefund.dg_Refund.Item(1, i).Value
            _id = frmRefund.dg_Refund.Item(0, i).Value
            _qty = frmRefund.dg_Refund.Item(4, i).Value
            _price = frmRefund.dg_Refund.Item(3, i).Value
            _line_total = frmRefund.dg_Refund.Item(5, i).Value
            query = "SELECT EXISTS(SELECT service_code FROM service WHERE service_code = @service_code)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@service_code", _service_code)
            Dim count = cm.ExecuteScalar()

            If count = 1 Then
                query = "INSERT INTO refund_svc_dtls (refund_id, service_id, qty, price, sub_total) VALUES (@refund_id, @service_id, @qty, @price, @sub_total)"
                cm = New MySqlCommand(query, con)
                cm.Parameters.AddWithValue("@refund_id", refId)
                cm.Parameters.AddWithValue("@service_id", _id)
                cm.Parameters.AddWithValue("@qty", _qty)
                cm.Parameters.AddWithValue("@price", _price)
                cm.Parameters.AddWithValue("@sub_total", _line_total)
                cm.ExecuteScalar()
                cm.Dispose()

            Else
                query = "SELECT inventory_id FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id"
                cm = New MySqlCommand(query, con)
                cm.Parameters.AddWithValue("@item_id", _id)
                cm.Parameters.AddWithValue("@branch_id", _BranchId)
                Dim _inventoryId = cm.ExecuteScalar()
                cm.Dispose()

                query = "INSERT INTO refund_item_dtls (refund_id, inventory_id, qty, price, sub_total) VALUES (@refund_id, @inventory_id, @qty, @price, @sub_total)"
                cm = New MySqlCommand(query, con)
                cm.Parameters.AddWithValue("@refund_id", refId)
                cm.Parameters.AddWithValue("@inventory_id", _inventoryId)
                cm.Parameters.AddWithValue("@qty", _qty)
                cm.Parameters.AddWithValue("@price", _price)
                cm.Parameters.AddWithValue("@sub_total", _line_total)
                cm.ExecuteScalar()
                cm.Dispose()

                query = "SELECT qty FROM inventory WHERE inventory_id = @inventory_id"
                cm = New MySqlCommand(query, con)
                cm.Parameters.AddWithValue("@inventory_id", _inventoryId)
                Dim prevQty = cm.ExecuteScalar()

                Dim newQty = prevQty + _qty

                query = "UPDATE inventory SET qty = @qty WHERE inventory_id = @inventory_id"
                cm = New MySqlCommand(query, con)
                cm.Parameters.AddWithValue("@inventory_id", _inventoryId)
                cm.Parameters.AddWithValue("@qty", newQty)
                cm.ExecuteScalar()
            End If
        Next

        DisconnectDatabase()
    End Sub
    Public Function loadOrderIdReceipt()
        ConnectDatabase()
        Dim query = "SELECT order_id FROM cash_payment WHERE receipt = @0 "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ReceiptNo)
        Dim ordId = cm.ExecuteScalar
        DisconnectDatabase()
        Return ordId
    End Function
    Public Function loadOrderIdInvoice()
        ConnectDatabase()
        Dim query = "SELECT order_id FROM credit_payment WHERE invoice = @0 "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _InvoiceNo)
        Dim ordId = cm.ExecuteScalar
        DisconnectDatabase()
        Return ordId
    End Function
    'Public Function checkRefundExists()
    '    ConnectDatabase()
    '    Dim query = "SELECT EXISTS(SELECT order_id FROM refund WHERE order_id = @order_id)"
    '    cm = New MySqlCommand(query, con)
    '    cm.Parameters.AddWithValue("@order_id", _OrderId)
    '    Dim result = cm.ExecuteScalar
    '    DisconnectDatabase()
    '    If result = 1 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    'Public Function RefundItemQty()
    '    ConnectDatabase()
    '    Dim query = "SELECT qty FROM refund_item_dtls INNER JOIN refund ON refund.refund_id = refund_item_dtls.refund_id WHERE order_id = @order_id"
    '    cm = New MySqlCommand(query, con)
    '    cm.Parameters.AddWithValue("@order_id", _OrderId)
    '    Dim result = cm.ExecuteScalar
    '    DisconnectDatabase()
    '    Return result
    'End Function
    'Public Function RefundServiceQty()
    '    ConnectDatabase()
    '    Dim query = "SELECT qty FROM refund_svc_dtls INNER JOIN refund ON refund.refund_id = refund_svc_dtls.refund_id WHERE order_id = @order_id"
    '    cm = New MySqlCommand(query, con)
    '    cm.Parameters.AddWithValue("@order_id", _OrderId)
    '    Dim result = cm.ExecuteScalar
    '    DisconnectDatabase()
    '    Return result
    'End Function
End Class
