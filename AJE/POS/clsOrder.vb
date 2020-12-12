Imports MySql.Data.MySqlClient
Public Class clsOrder
    Private _ItemSearch As Object
    Private _BranchId As Object
    Private _OrderTransDate As Object
    Private _GrossAmount As Object
    Private _TransDate As Object
    Private _PayAmount As Object
    Private _Receipt As Object
    Private _Invoice As Object
    Private _TransCode As Object
    Private _ItemCode As Object

    Public Sub SetBranchId(AutoPropertyValue As Object)
        _BranchId = AutoPropertyValue
    End Sub

    Public Sub SetItemSearch(AutoPropertyValue As Object)
        _ItemSearch = AutoPropertyValue
    End Sub
    Public Sub SetOrderTransDate(AutoPropertyValue As Object)
        _OrderTransDate = AutoPropertyValue
    End Sub
    Public Sub SetGrossAmount(AutoPropertyValue As Object)
        _GrossAmount = AutoPropertyValue
    End Sub
    Public Sub SetTransDate(AutoPropertyValue As Object)
        _TransDate = AutoPropertyValue
    End Sub
    Public Sub SetPayAmount(AutoPropertyValue As Object)
        _PayAmount = AutoPropertyValue
    End Sub
    Public Sub SetReceipt(AutoPropertyValue As Object)
        _Receipt = AutoPropertyValue
    End Sub
    Public Sub SetInvoice(AutoPropertyValue As Object)
        _Invoice = AutoPropertyValue
    End Sub
    Public Sub SetTransCode(AutoPropertyValue As Object)
        _TransCode = AutoPropertyValue
    End Sub
    Public Sub SetItemCode(AutoPropertyValue As Object)
        _ItemCode = AutoPropertyValue
    End Sub

    Public Sub saveOrder()
        ConnectDatabase()
        Dim query = "INSERT INTO orders (trans_date, gross_amount, trans_code, branch_id) VALUES (@trans_date, @gross_amount, @trans_code, @branch_id); SELECT LAST_INSERT_ID();"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@trans_date", _OrderTransDate)
        cm.Parameters.AddWithValue("@gross_amount", _GrossAmount)
        cm.Parameters.AddWithValue("@trans_code", _TransCode)
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        Dim _order_id = cm.ExecuteScalar()
        cm.Dispose()

        Dim _service_code, _id, _qty, _price, _line_total
        For i = 0 To frmPos.dg_Order.RowCount - 1
            _service_code = frmPos.dg_Order.Item(1, i).Value
            _id = frmPos.dg_Order.Item(0, i).Value
            _price = frmPos.dg_Order.Item(4, i).Value
            _qty = frmPos.dg_Order.Item(5, i).Value
            _line_total = frmPos.dg_Order.Item(6, i).Value
            query = "SELECT EXISTS(SELECT service_code FROM service WHERE service_code = @service_code)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@service_code", _service_code)
            Dim count = cm.ExecuteScalar()

            If count = 1 Then
                query = "INSERT INTO order_svc_dtls (order_id, service_id, qty, price, line_total) VALUES (@order_id, @service_id, @qty, @price, @line_total)"
                cm = New MySqlCommand(query, con)
                cm.Parameters.AddWithValue("@order_id", _order_id)
                cm.Parameters.AddWithValue("@service_id", _id)
                cm.Parameters.AddWithValue("@price", _price)
                cm.Parameters.AddWithValue("@qty", _qty)
                cm.Parameters.AddWithValue("@line_total", _line_total)
                cm.ExecuteScalar()
                cm.Dispose()

            Else
                query = "SELECT inventory_id FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id"
                cm = New MySqlCommand(query, con)
                cm.Parameters.AddWithValue("@item_id", _id)
                cm.Parameters.AddWithValue("@branch_id", _BranchId)
                Dim _inventoryId = cm.ExecuteScalar()
                cm.Dispose()

                query = "INSERT INTO order_item_dtls (order_id, inventory_id, qty, price, line_total) VALUES (@order_id, @inventory_id, @qty, @price, @line_total)"
                cm = New MySqlCommand(query, con)
                cm.Parameters.AddWithValue("@order_id", _order_id)
                cm.Parameters.AddWithValue("@inventory_id", _inventoryId)
                cm.Parameters.AddWithValue("@price", _price)
                cm.Parameters.AddWithValue("@qty", _qty)
                cm.Parameters.AddWithValue("@line_total", _line_total)
                cm.ExecuteScalar()
                cm.Dispose()

                query = "SELECT qty FROM inventory WHERE inventory_id = @inventory_id"
                cm = New MySqlCommand(query, con)
                cm.Parameters.AddWithValue("@inventory_id", _inventoryId)
                Dim prevQty = cm.ExecuteScalar()

                Dim newQty = prevQty - _qty

                query = "UPDATE inventory SET qty = @qty WHERE inventory_id = @inventory_id"
                cm = New MySqlCommand(query, con)
                cm.Parameters.AddWithValue("@inventory_id", _inventoryId)
                cm.Parameters.AddWithValue("@qty", newQty)
                cm.ExecuteScalar()
            End If
        Next

        If frmPos.lbl_pay_Type.Text = "Cash" Then
            query = "INSERT INTO cash_payment (order_id, cashier_id, trans_date, pay_amount, receipt) " &
                    "VALUES ('" & _order_id & "', '" & frmPos.lbl_user_Id.Text & "', @trans_date, @pay_amount, @receipt)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@trans_date", _TransDate)
            cm.Parameters.AddWithValue("@pay_amount", _PayAmount)
            cm.Parameters.AddWithValue("@receipt", _Receipt)
            cm.ExecuteScalar()
            cm.Dispose()

        ElseIf frmPos.lbl_pay_Type.Text = "Credit" Then
            query = "INSERT INTO credit_payment (order_id, cashier_id, customer_id, trans_date, pay_amount, invoice) " &
                    "VALUES ('" & _order_id & "', '" & frmPos.lbl_user_Id.Text & "', '" & frmPos.lbl_customer_Id.Text & "', @trans_date, @pay_amount, @invoice)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@trans_date", _TransDate)
            cm.Parameters.AddWithValue("@pay_amount", _PayAmount)
            cm.Parameters.AddWithValue("@invoice", _Invoice)
            cm.ExecuteScalar()

            query = "SELECT balance FROM customer WHERE customer_id = @customer_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_id", frmPos.lbl_customer_Id.Text)
            Dim prevBal = cm.ExecuteScalar()

            Dim newBal = prevBal + _GrossAmount - _PayAmount

            query = "UPDATE customer SET balance = @balance WHERE customer_id = @customer_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_id", frmPos.lbl_customer_Id.Text)
            cm.Parameters.AddWithValue("@balance", newBal)
            cm.ExecuteScalar()

        End If
        DisconnectDatabase()
    End Sub
    'Public Function getReceipt()
    '    ConnectDatabase()
    '    Dim query = "SELECT EXISTS(SELECT receipt FROM cash_payment WHERE trans_date = @trans_date)"
    '    cm = New MySqlCommand(query, con)
    '    cm.Parameters.AddWithValue("@trans_date", _TransDate)
    '    Dim count = cm.ExecuteScalar()
    '    cm.Dispose()

    '    If count = 1 Then
    '        query = "SELECT MAX(receipt) FROM cash_payment WHERE trans_date = @trans_date"
    '        cm = New MySqlCommand(query, con)
    '        cm.Parameters.AddWithValue("@trans_date", _TransDate)
    '        Dim receipt = Val(cm.ExecuteScalar()) + 1
    '        cm.Dispose()
    '        DisconnectDatabase()
    '        Return receipt

    '    Else
    '        DisconnectDatabase()
    '        Return 1
    '    End If
    'End Function

    'Public Function getInvoice()
    '    ConnectDatabase()
    '    Dim query = "SELECT EXISTS(SELECT invoice FROM credit_payment WHERE trans_date = @trans_date)"
    '    cm = New MySqlCommand(query, con)
    '    cm.Parameters.AddWithValue("@trans_date", _TransDate)
    '    Dim count = cm.ExecuteScalar()
    '    cm.Dispose()

    '    If count = 1 Then
    '        query = "SELECT MAX(invoice) FROM credit_payment WHERE trans_date = @trans_date"
    '        cm = New MySqlCommand(query, con)
    '        cm.Parameters.AddWithValue("@trans_date", _TransDate)
    '        Dim invoice = Val(cm.ExecuteScalar()) + 1
    '        cm.Dispose()
    '        DisconnectDatabase()
    '        Return invoice

    '    Else
    '        DisconnectDatabase()
    '        Return 1
    '    End If
    'End Function
    Public Function getTransCode()
        ConnectDatabase()
        Dim dateToday = Date.Now.ToString("yyyy-MM-dd")
        Dim query = "SELECT EXISTS(SELECT trans_code FROM orders WHERE trans_date = @trans_date AND branch_id = @branch_id)"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@trans_date", dateToday)
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        Dim count = cm.ExecuteScalar()
        cm.Dispose()

        If count = 1 Then
            query = "SELECT MAX(trans_code) FROM orders WHERE trans_date = @trans_date AND branch_id = @branch_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@trans_date", dateToday)
            cm.Parameters.AddWithValue("@branch_id", _BranchId)
            Dim code = Val(cm.ExecuteScalar()) + 1
            cm.Dispose()
            DisconnectDatabase()
            Return code

        Else
            DisconnectDatabase()
            Return 1
        End If
    End Function
    Public Sub searchItem(query As String) 'dg_Search item populate
        frmPos.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        dr = cm.ExecuteReader()
        While dr.Read
            frmPos.dg_Search.Rows.Add(dr.Item("item_id").ToString, dr.Item("item_code").ToString, dr.Item("brand_name").ToString & " | " & dr.Item("item_desc").ToString & " | " & dr.Item("item_add_desc").ToString & " | " &
                                      dr.Item("category_name").ToString, dr.Item("unit_name").ToString, dr.Item("item_price_A").ToString, dr.Item("item_price_B").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub searchService(query As String) 'dg_Search service populate
        frmPos.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ItemSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            frmPos.dg_Search.Rows.Add(dr.Item("service_id").ToString, dr.Item("service_code").ToString, dr.Item("service_desc").ToString, dr.Item("").ToString, dr.Item("service_fee_A").ToString, dr.Item("service_fee_B").ToString, "ADD")
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Function getCreditLimit()
        ConnectDatabase()
        Dim query = "SELECT credit_limit FROM customer WHERE customer_id = @customer_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@customer_id", frmPos.lbl_customer_Id.Text)
        getCreditLimit = cm.ExecuteScalar()
        DisconnectDatabase()
        Return getCreditLimit
    End Function
    Public Function getBalance()
        ConnectDatabase()
        Dim query = "SELECT balance FROM customer WHERE customer_id = @customer_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@customer_id", frmPos.lbl_customer_Id.Text)
        getBalance = cm.ExecuteScalar()
        DisconnectDatabase()
        Return getBalance
    End Function
    Public Function checkItemQty()
        ConnectDatabase()
        Dim query = "SELECT qty FROM inventory INNER JOIN item ON item.item_id = inventory.item_id WHERE item_code = @item_code"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_code", _ItemCode)
        Dim qty = cm.ExecuteScalar
        DisconnectDatabase()
        Return qty
    End Function

End Class
