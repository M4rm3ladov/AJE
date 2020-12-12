Imports MySql.Data.MySqlClient
Public Class clsCreditPay
    Private _CashierId As Object
    Private _ManagerId As Object
    Private _PayTransDate As Object
    Private _PayAmount As Object
    Private _Receipt As Object
    Private _Balance As Object
    Private _DateFrom As Object
    Private _DateTo As Object
    Private _Customer As Object

    Public Sub SetCashierId(AutoPropertyValue As Object)
        _CashierId = AutoPropertyValue
    End Sub

    Public Sub SetManagerId(AutoPropertyValue As Object)
        _ManagerId = AutoPropertyValue
    End Sub

    Public Sub SetPayTransDate(AutoPropertyValue As Object)
        _PayTransDate = AutoPropertyValue
    End Sub
    Public Sub SetPayAmount(AutoPropertyValue As Object)
        _PayAmount = AutoPropertyValue
    End Sub
    Public Sub SetReceipt(AutoPropertyValue As Object)
        _Receipt = AutoPropertyValue
    End Sub
    Public Sub SetBalance(AutoPropertyValue As Object)
        _Balance = AutoPropertyValue
    End Sub
    Private _CustomerSearch As Object
    Public Sub SetCustomerSearch(AutoPropertyValue As Object)
        _CustomerSearch = AutoPropertyValue
    End Sub
    Public Sub SetDateFrom(AutoPropertyValue As Object)
        _DateFrom = AutoPropertyValue
    End Sub
    Public Sub SetDateTo(AutoPropertyValue As Object)
        _DateTo = AutoPropertyValue
    End Sub
    Public Sub SetCustomer(AutoPropertyValue As Object)
        _Customer = AutoPropertyValue
    End Sub

    Public Sub savePayment()
        ConnectDatabase()
        Dim query = "INSERT INTO credit_settle (customer_id, cashier_id, manager_id, trans_date, pay_amount, receipt) " &
                    "VALUES (@customer_id, @cashier_id, @manager_id, @trans_date, @pay_amount, @receipt)"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@customer_id", frmCreditPay.lbl_customer_Id.Text)
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        cm.Parameters.AddWithValue("@manager_id", _ManagerId)
        cm.Parameters.AddWithValue("@trans_date", _PayTransDate)
        cm.Parameters.AddWithValue("@pay_amount", _PayAmount)
        cm.Parameters.AddWithValue("@receipt", _Receipt)
        cm.ExecuteScalar()

        query = "UPDATE customer SET balance = @balance WHERE customer_id = @customer_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@customer_id", frmCreditPay.lbl_customer_Id.Text)
        cm.Parameters.AddWithValue("@balance", _Balance)
        cm.ExecuteScalar()
        DisconnectDatabase()
    End Sub
    Public Sub searchCustomerCredit(query As String) 'dg_Search item populate
        frmCreditPay.dg_Transactions.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _CustomerSearch)
        dr = cm.ExecuteReader()
        While dr.Read
            frmCreditPay.dg_Transactions.Rows.Add(dr.Item("order_id").ToString, Format(dr.Item("transDate"), "MM/dd/yyyy"), Format(dr.Item("InputedDate"), "MM/dd/yyyy"), dr.Item("invoice").ToString, dr.Item("pay_amount"), dr.Item("gross_amount").ToString)
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Function setCustomerBalance()
        ConnectDatabase()
        Dim query = "SELECT balance FROM customer WHERE customer_id = @customer_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@customer_id", frmCreditPay.lbl_customer_Id.Text)
        Dim _bal = cm.ExecuteScalar()
        DisconnectDatabase()
        Return _bal
    End Function
    Public Sub loadPayHistory()
        Dim transDate As String
        frmCreditPay.dg_History.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT credit_settle_id, user_gname, user_mi, user_surname, user_suffix, trans_date, pay_amount, receipt FROM credit_settle " &
                    "INNER JOIN cashier ON cashier.cashier_id = credit_settle.cashier_id " &
                    "INNER JOIN users ON users.user_id = cashier.user_id " &
                    "INNER JOIN user_details ON user_details.user_id = users.user_id " &
                    "WHERE trans_date BETWEEN @date_from AND @date_to AND customer_id = @customer_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@date_from", _DateFrom)
        cm.Parameters.AddWithValue("@date_to", _DateTo)
        cm.Parameters.AddWithValue("@customer_id", _Customer)
        dr = cm.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                transDate = Format(dr.Item("trans_date"), "MM/dd/yyyy")
                frmCreditPay.dg_History.Rows.Add(dr.Item("credit_settle_id").ToString, dr.Item("receipt").ToString, transDate, dr.Item("pay_amount").ToString,
                                                  dr.Item("user_gname").ToString & " " & dr.Item("user_mi").ToString & " " & dr.Item("user_surname").ToString & " " & dr.Item("user_suffix").ToString)

            End While
        Else
            MsgBox("No data available on given parameters.", vbInformation)
        End If
        dr.Close()
        DisconnectDatabase()
    End Sub
    'Public Sub loadItems(orderId)
    '    frmCreditTransacs.dg_Cred_Transac.Rows.Clear()
    '    ConnectDatabase()
    '    Dim query = "SELECT brand_name, item_desc, item_add_desc, category_name, order_item_dtls.qty, order_item_dtls.price, order_item_dtls.line_total FROM order_item_dtls " &
    '                "INNER JOIN inventory ON inventory.inventory_id = order_item_dtls.inventory_id " &
    '                "INNER JOIN item ON item.item_id = inventory.item_id " &
    '                "INNER JOIN brand ON brand.brand_id = item.brand_id " &
    '                "INNER JOIN category ON category.category_id = item.category_id WHERE order_id = @order_id"
    '    cm = New MySqlCommand(query, con)
    '    cm.Parameters.AddWithValue("@order_id", orderId)
    '    dr = cm.ExecuteReader()
    '    While dr.Read
    '        frmCreditTransacs.dg_Cred_Transac.Rows.Add(dr.Item("brand_name").ToString & " | " & dr.Item("item_desc").ToString & " | " & dr.Item("item_add_desc").ToString & " | " & dr.Item("category_name").ToString, dr.Item("qty").ToString, dr.Item("price").ToString, dr.Item("line_total").ToString)
    '    End While
    '    dr.Close()
    '    DisconnectDatabase()
    'End Sub
    'Public Sub loadServices(orderId)
    '    frmCreditTransacs.dg_Cred_Transac.Rows.Clear()
    '    ConnectDatabase()
    '    Dim query = "SELECT service_desc, qty, price, line_total FROM order_svc_dtls " &
    '                "INNER JOIN service ON service.service_id = order_svc_dtls.service_id WHERE order_id = @order_id"
    '    cm = New MySqlCommand(query, con)
    '    cm.Parameters.AddWithValue("@order_id", orderId)
    '    dr = cm.ExecuteReader()
    '    While dr.Read
    '        frmCreditTransacs.dg_Cred_Transac.Rows.Add(dr.Item("service_desc").ToString, dr.Item("qty").ToString, dr.Item("price").ToString, dr.Item("line_total").ToString)
    '    End While
    '    dr.Close()
    '    DisconnectDatabase()
    'End Sub
    Public Sub loadTransactions(orderId)
        frmCreditTransacs.dg_Cred_Transac.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT u.id, u.description, u.quantity, u.p, u.total FROM (select order_item_dtls.order_id AS id, CONCAT(brand_name, ' | ', item_desc, ' | ', item_add_desc, ' | ', category_name) As description, order_item_dtls.qty as quantity, price as p, line_total as total from order_item_dtls " &
                    "INNER JOIN orders on orders.`order_id` = order_item_dtls.`order_id` " &
                    "INNER JOIN inventory on inventory.`inventory_id` = order_item_dtls.`inventory_id` " &
                    "INNER JOIN item on item.`item_id` = inventory.`item_id` " &
                    "INNER JOIN brand on brand.`brand_id` = item.`brand_id` " &
                    "INNER JOIN category on category.`category_id` = item.`category_id` " &
                    "UNION all " &
                    "SELECT order_svc_dtls.order_id as id, service_desc AS description, order_svc_dtls.`qty` as quantity, price as p, line_total as total FROM order_svc_dtls " &
                    "INNER JOIN orders ON orders.`order_id` = order_svc_dtls.`order_id` " &
                    "INNER JOIN service ON service.`service_id` = order_svc_dtls.`service_id` ) as u WHERE u.id = @order_id "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@order_id", orderId)
        dr = cm.ExecuteReader
        While dr.Read
            frmCreditTransacs.dg_Cred_Transac.Rows.Add(dr.Item("description").ToString, dr.Item("p").ToString, dr.Item("quantity").ToString, dr.Item("total").ToString)
        End While
        dr.Close()
        DisconnectDatabase()
    End Sub
    Public Function loadOrderTotal(orderId)
        ConnectDatabase()
        Dim query = "SELECT gross_amount FROM orders WHERE order_id = @order_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@order_id", orderId)
        Dim gross = cm.ExecuteScalar()
        DisconnectDatabase()
        Return gross
    End Function
End Class
