Imports MySql.Data.MySqlClient
Public Class clsVoid
    Private _OrderId As Object
    Private _BranchId As Object
    Private _CashierId As Object
    Private _ManagerId As Object
    Private _Remarks As Object
    Private _InvoiceNo As Object
    Private _Gross As Object
    Private _VoidDate As Object
    Private _DateFrom As Object
    Private _DateTo As Object
    Public Sub SetGross(AutoPropertyValue As Object)
        _Gross = AutoPropertyValue
    End Sub
    Public Sub SetInvoiceNo(AutoPropertyValue As Object)
        _InvoiceNo = AutoPropertyValue
    End Sub
    Public Sub SetOrderId(AutoPropertyValue As Object)
        _OrderId = AutoPropertyValue
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
    Public Sub SetRemarks(AutoPropertyValue As Object)
        _Remarks = AutoPropertyValue
    End Sub
    Public Sub SetVoidDate(AutoPropertyValue As Object)
        _VoidDate = AutoPropertyValue
    End Sub
    Public Sub SetDateFrom(AutoPropertyValue As Object)
        _DateFrom = AutoPropertyValue
    End Sub
    Public Sub SetDateTo(AutoPropertyValue As Object)
        _DateTo = AutoPropertyValue
    End Sub
    Public Sub loadHistory()
        Dim transDate As String
        frmVoid.dg_History.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT cash_payment.receipt, CONCAT(c.user_gname,' ',c.user_surname) AS Cashiers, CONCAT(m.user_gname,' ',m.user_surname) AS Managers, 'Cash' AS payType,
                    void.trans_date, void.remarks 
                    FROM void
                    INNER JOIN orders ON orders.order_id = void.order_id
                    INNER JOIN cash_payment ON cash_payment.order_id = void.order_id
                    INNER JOIN manager ON manager.manager_id = void.manager_id
                    INNER JOIN user_details AS m ON m.user_id = manager.user_id
                    INNER JOIN cashier ON cashier.cashier_id = void.cashier_id
                    INNER JOIN user_details AS c ON c.user_id = cashier.user_id
                    WHERE void.trans_date BETWEEN @date_from AND @date_to AND orders.branch_id = @branch_id
                    UNION
                    SELECT credit_payment.invoice , CONCAT(c.user_gname,' ',c.user_surname) AS Cashiers, CONCAT(m.user_gname,' ',m.user_surname) AS Managers, 'Credit' AS payType,
                    void.trans_date, void.remarks 
                    FROM void
                    INNER JOIN orders ON orders.order_id = void.order_id
                    INNER JOIN credit_payment ON credit_payment.order_id = void.order_id
                    INNER JOIN manager ON manager.manager_id = void.manager_id
                    INNER JOIN user_details AS m ON m.user_id = manager.user_id
                    INNER JOIN cashier ON cashier.cashier_id = void.cashier_id
                    INNER JOIN user_details AS c ON c.user_id = cashier.user_id
                    WHERE void.trans_date BETWEEN @date_from AND @date_to AND orders.branch_id = @branch_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@date_from", _DateFrom)
        cm.Parameters.AddWithValue("@date_to", _DateTo)
        cm.Parameters.AddWithValue("@branch_id", _BranchId)

        dr = cm.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                transDate = Format(dr.Item("trans_date"), "MM/dd/yyyy")
                frmVoid.dg_History.Rows.Add(transDate, dr.Item("receipt").ToString, dr.Item("payType").ToString, dr.Item("Cashiers").ToString, dr.Item("Managers").ToString,
                                               dr.Item("remarks").ToString)
            End While
        Else
            MsgBox("No data available on given parameters.", vbInformation)
        End If
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub searchOrders(query As String) 'dg_Search item populate
        frmVoid.dg_Search.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        dr = cm.ExecuteReader()
        While dr.Read
            frmVoid.dg_Search.Rows.Add(dr.Item("order_id").ToString, Format(dr.Item("transDate"), "MM/dd/yyyy"), Format(dr.Item("InputedDate"), "MM/dd/yyyy"), dr.Item("invoice").ToString, dr.Item("pay_amount"), dr.Item("gross_amount").ToString)
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Sub loadTransactions()
        frmOrderTransacs.dg_Transac.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT u.id, u.description, u.quantity, u.p, u.total FROM (SELECT order_item_dtls.order_id AS id, CONCAT(brand_name, ' | ', item_desc, ' | ', item_add_desc, ' | ', category_name) AS description, order_item_dtls.qty AS quantity, price AS p, line_total AS total 
                    FROM order_item_dtls 
                    INNER JOIN orders ON orders.`order_id` = order_item_dtls.`order_id` 
                    INNER JOIN inventory ON inventory.`inventory_id` = order_item_dtls.`inventory_id` 
                    INNER JOIN item ON item.`item_id` = inventory.`item_id` 
                    INNER JOIN brand ON brand.`brand_id` = item.`brand_id` 
                    INNER JOIN category ON category.`category_id` = item.`category_id` 
                    UNION ALL 
                    SELECT order_svc_dtls.order_id AS id, service_desc AS description, order_svc_dtls.`qty` AS quantity, price AS p, line_total AS total 
                    FROM order_svc_dtls 
                    INNER JOIN orders ON orders.`order_id` = order_svc_dtls.`order_id` 
                    INNER JOIN service ON service.`service_id` = order_svc_dtls.`service_id`) AS u WHERE u.id = @order_id "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@order_id", _OrderId)
        dr = cm.ExecuteReader
        While dr.Read
            frmOrderTransacs.dg_Transac.Rows.Add(dr.Item("description").ToString, dr.Item("p").ToString, dr.Item("quantity").ToString, dr.Item("total").ToString)
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Function loadOrderTotal()
        ConnectDatabase()
        Dim query = "SELECT gross_amount FROM orders WHERE order_id = @order_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@order_id", _OrderId)
        Dim gross = cm.ExecuteScalar()
        DisconnectDatabase()
        Return gross
    End Function
    Public Function checkRefundExists()
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT refund.order_id FROM refund WHERE refund.order_id = @order_id)"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@order_id", _OrderId)
        Dim count = cm.ExecuteScalar()
        DisconnectDatabase()
        If count > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function checkVoidExists()
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT void.order_id FROM void WHERE void.order_id = @order_id)"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@order_id", _OrderId)
        Dim count = cm.ExecuteScalar()
        DisconnectDatabase()
        If count > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Sub saveVoid()
        ConnectDatabase()
        Dim query = "INSERT INTO void (order_id, cashier_id, manager_id, trans_date, remarks) VALUE(@order_id, @cashier_id, @manager_id, @trans_date, @remarks)"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@order_id", _OrderId)
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        cm.Parameters.AddWithValue("@manager_id", _ManagerId)
        cm.Parameters.AddWithValue("@trans_date", _VoidDate)
        cm.Parameters.AddWithValue("@remarks", _Remarks)
        cm.ExecuteScalar()

        query = "SELECT order_item_dtls.inventory_id, inventory.qty, order_item_dtls.qty, (inventory.qty + order_item_dtls.qty) AS newQty FROM inventory
                INNER JOIN order_item_dtls ON order_item_dtls.inventory_id = inventory.inventory_id 
                INNER JOIN orders ON order_item_dtls.order_id = orders.order_id
                WHERE orders.order_id = @order_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@order_id", _OrderId)
        dr = cm.ExecuteReader()

        Dim items As New Dictionary(Of Integer, Integer)
        If dr.HasRows Then
            While dr.Read
                items.Add(dr.Item("inventory_id"), (dr.Item("newQty")))
            End While
            dr.Close()

            For Each kvp As KeyValuePair(Of Integer, Integer) In items
                query = "UPDATE inventory SET inventory.qty = '" & kvp.Value & "' WHERE inventory.inventory_id = '" & kvp.Key & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteScalar()
            Next
        End If

        Dim cust_bal As Decimal
        Dim cust_id

        query = "SELECT EXISTS(SELECT order_id FROM credit_payment WHERE order_id = @order_id)"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@order_id", _OrderId)
        Dim count = cm.ExecuteScalar()

        If count = 0 Then
            cm.Dispose()
            DisconnectDatabase()
            Exit Sub
        End If

        query = "SELECT customer.balance FROM customer 
                    INNER JOIN credit_payment ON credit_payment.customer_id = customer.customer_id 
                    WHERE credit_payment.invoice = @invoice_no"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@invoice_no", _InvoiceNo)
        cust_bal = cm.ExecuteScalar()
        cm.Dispose()

        query = "SELECT customer.customer_id FROM customer 
                    INNER JOIN credit_payment ON credit_payment.customer_id = customer.customer_id 
                    WHERE credit_payment.invoice = @invoice_no"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@invoice_no", _InvoiceNo)
        cust_id = cm.ExecuteScalar()
        cm.Dispose()

        Dim new_cust_bal As Decimal

        new_cust_bal = cust_bal - _Gross

        query = "UPDATE customer SET customer.balance = '" & new_cust_bal & "' WHERE customer.customer_id = '" & cust_id & "'"
        cm = New MySqlCommand(query, con)
        cm.ExecuteScalar()
        cm.Dispose()

        DisconnectDatabase()
    End Sub
End Class
