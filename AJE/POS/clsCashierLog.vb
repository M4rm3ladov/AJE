 Imports MySql.Data.MySqlClient
Public Class clsCashierLog
    Dim cashP, creditS, creditP, voidA, refundA, cashIn, cashOut
    Private _CashierLogId As Object
    Private _CashierId As Object
    Private _ManagerId As Object
    Private _LogDate As Object
    Private _TimeIn As Object
    Private _TimeOut As Object
    Private _InBal As Object
    Private _EndBal As Object
    Public Sub SetCashierLogId(AutoPropertyValue As String)
        _CashierLogId = AutoPropertyValue
    End Sub
    Public Sub SetCashierId(AutoPropertyValue As String)
        _CashierId = AutoPropertyValue
    End Sub
    Public Sub SetManagerId(AutoPropertyValue As String)
        _ManagerId = AutoPropertyValue
    End Sub
    Public Sub SetLogDate(AutoPropertyValue As String)
        _LogDate = AutoPropertyValue
    End Sub
    Public Sub SetTimeIn(AutoPropertyValue As String)
        _TimeIn = AutoPropertyValue
    End Sub
    Public Sub SetTimeOut(AutoPropertyValue As String)
        _TimeOut = AutoPropertyValue
    End Sub
    Public Sub SetInBal(AutoPropertyValue As String)
        _InBal = AutoPropertyValue
    End Sub
    Public Sub SetEndBal(AutoPropertyValue As String)
        _EndBal = AutoPropertyValue
    End Sub
    Public Function setCashierIn()
        ConnectDatabase()
        Dim query = "INSERT INTO cashier_log (cashier_id, manager_id, log_date, time_from, begin_bal) VALUES (@cashier_id, @manager_id, @log_date, @time_from, @begin_bal); " &
                    "SELECT LAST_INSERT_ID()"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        cm.Parameters.AddWithValue("@manager_id", _ManagerId)
        cm.Parameters.AddWithValue("@log_date", _LogDate)
        cm.Parameters.AddWithValue("@time_from", _TimeIn)
        cm.Parameters.AddWithValue("@begin_bal", _InBal)
        Return cm.ExecuteScalar()
        DisconnectDatabase()
    End Function
    Public Sub setCashierOut()
        ConnectDatabase()
        Dim query = "UPDATE cashier_log SET time_to = @time_to, end_bal = @end_bal WHERE cashier_log_id = @cashier_log_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@cashier_log_id", _CashierLogId)
        cm.Parameters.AddWithValue("@time_to", _TimeOut)
        cm.Parameters.AddWithValue("@end_bal", _EndBal)
        cm.ExecuteScalar()
        DisconnectDatabase()
    End Sub
    Public Function calcEndBal()
        ConnectDatabase()
        Dim query = "SELECT SUM(gross_amount) AS gross FROM orders " &
                    "INNER JOIN cash_payment ON orders.order_id = cash_payment.order_id " &
                    "WHERE orders.trans_date = @trans_date AND cash_payment.cashier_id = @cashier_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@trans_date", Date.Now.ToString("yyyy-MM-dd"))
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        dr = cm.ExecuteReader
        While dr.Read
            If dr.IsDBNull(0) Then
                cashP = 0
            Else
                cashP = dr.Item("gross")
            End If
        End While
        dr.Close()

        query = "SELECT SUM(pay_amount) AS gross FROM credit_payment WHERE trans_date = @trans_date AND cashier_id = @cashier_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@trans_date", Date.Now.ToString("yyyy-MM-dd"))
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        dr = cm.ExecuteReader
        While dr.Read
            If dr.IsDBNull(0) Then
                creditP = 0
            Else
                creditP = dr.Item("gross")
            End If
        End While
        dr.Close()

        query = "SELECT SUM(pay_amount) AS gross FROM credit_settle WHERE trans_date = @trans_date AND cashier_id = @cashier_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@trans_date", Date.Now.ToString("yyyy-MM-dd"))
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        dr = cm.ExecuteReader
        While dr.Read
            If dr.IsDBNull(0) Then
                creditS = 0
            Else
                creditS = dr.Item("gross")
            End If
        End While
        dr.Close()

        query = "SELECT SUM(orders.gross_amount) AS gross FROM void 
                INNER JOIN orders ON orders.order_id = void.order_id 
                WHERE trans_date = @trans_date AND cashier_id = @cashier_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@trans_date", Date.Now.ToString("yyyy-MM-dd"))
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        dr = cm.ExecuteReader
        While dr.Read
            If dr.IsDBNull(0) Then
                voidA = 0
            Else
                voidA = dr.Item("gross")
            End If
        End While
        dr.Close()

        query = "SELECT SUM(amount) AS gross FROM refund WHERE trans_date = @trans_date AND cashier_id = @cashier_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@trans_date", Date.Now.ToString("yyyy-MM-dd"))
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        dr = cm.ExecuteReader
        While dr.Read
            If dr.IsDBNull(0) Then
                refundA = 0
            Else
                refundA = dr.Item("gross")
            End If
        End While
        dr.Close()

        query = "SELECT begin_bal FROM cashier_log WHERE cashier_log_id = @cashier_log_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@cashier_log_id", _CashierLogId)
        Dim begbal = cm.ExecuteScalar()

        query = "SELECT SUM(amount) AS gross FROM cash_in WHERE trans_date = @trans_date AND cashier_id = @cashier_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@trans_date", Date.Now.ToString("yyyy-MM-dd"))
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        dr = cm.ExecuteReader
        While dr.Read
            If dr.IsDBNull(0) Then
                cashIn = 0
            Else
                cashIn = dr.Item("gross")
            End If
        End While
        dr.Close()

        query = "SELECT SUM(amount) AS gross FROM cash_out WHERE trans_date = @trans_date AND cashier_id = @cashier_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@trans_date", Date.Now.ToString("yyyy-MM-dd"))
        cm.Parameters.AddWithValue("@cashier_id", _CashierId)
        dr = cm.ExecuteReader
        While dr.Read
            If dr.IsDBNull(0) Then
                cashOut = 0
            Else
                cashOut = dr.Item("gross")
            End If
        End While
        dr.Close()

        Dim total = begbal + (cashP + creditS + creditP - (refundA + voidA)) + cashIn - cashOut
        DisconnectDatabase()
        Return total
    End Function
End Class
