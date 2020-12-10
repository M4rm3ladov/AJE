Imports MySql.Data.MySqlClient
Public Class clsCustomer
    Private _GName As Object
    Private _Mi As Object
    Private _Surname As Object
    Private _Suffix As Object
    Private _Id As Object
    Private _Code As Object
    Private _CreditLimit As Object
    Private _CustomerSearch As Object
    Public Sub SetGName(AutoPropertyValue As Object)
        _GName = AutoPropertyValue
    End Sub

    Public Sub SetMi(AutoPropertyValue As Object)
        _Mi = AutoPropertyValue
    End Sub

    Public Sub SetSurname(AutoPropertyValue As Object)
        _Surname = AutoPropertyValue
    End Sub

    Public Sub SetSuffix(AutoPropertyValue As Object)
        _Suffix = AutoPropertyValue
    End Sub

    Public Sub SetId(AutoPropertyValue As Object)
        _Id = AutoPropertyValue
    End Sub

    Public Sub SetCode(AutoPropertyValue As Object)
        _Code = AutoPropertyValue
    End Sub
    Public Sub SetCreditLimit(AutoPropertyValue As Object)
        _CreditLimit = AutoPropertyValue
    End Sub

    Public Sub SetCustomerSearch(AutoPropertyValue As Object)
        _CustomerSearch = AutoPropertyValue
    End Sub

    Public Function save()
        Dim _id As Integer
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO customer (customer_code, credit_limit) " &
                            "VALUES (@customer_code, @credit_limit); " &
                            "SELECT LAST_INSERT_ID(); "
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_code", _Code)
            cm.Parameters.AddWithValue("@credit_limit", _CreditLimit)
            _id = CInt(cm.ExecuteScalar)
            cm.Dispose()

            query = "INSERT INTO customer_details (customer_id, customer_surname, customer_gname, customer_mi, customer_suffix) " &
                "VALUES (" & _id & ", @customer_surname, @customer_gname, @customer_mi, @customer_suffix)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_surname", _Surname)
            cm.Parameters.AddWithValue("@customer_gname", _GName)
            cm.Parameters.AddWithValue("@customer_mi", _Mi)
            cm.Parameters.AddWithValue("@customer_suffix", _Suffix)
            cm.ExecuteScalar()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function edit()
        Try
            ConnectDatabase()
            Dim query = "UPDATE customer SET credit_limit = @credit_limit WHERE customer_id = @customer_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_id", _Id)
            cm.Parameters.AddWithValue("@credit_limit", _CreditLimit)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function delete()
        Try
            ConnectDatabase()
            Dim query = "DELETE FROM customer_details WHERE customer_id = @customer_id
                        ;DELETE FROM customer WHERE customer_id = @customer_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_id", _Id)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function checkCustomerExists() 'checks if item is already in use in other tables(user, stock)
        Try
            ConnectDatabase()
            Dim query = "SELECT COUNT(*) FROM credit_payment WHERE credit_payment.customer_id= @customer_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_id", _Id)
            Dim count = cm.ExecuteScalar()
            If count > 0 Then
                Return True
                DisconnectDatabase()
            End If
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Sub loadRecord() 'HERE'
        Dim i As Integer
        frmCustomers.dgCustomers.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT customer.customer_id, customer_code, credit_limit, customer_gname, customer_mi, customer_surname, customer_suffix, credit_limit, balance FROM customer " &
                    "INNER JOIN customer_details ON customer.customer_id = customer_details.customer_id "
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                i += 1
                frmCustomers.dgCustomers.Rows.Add(dr.Item("customer_id").ToString, i, dr.Item("customer_code").ToString, dr.Item("customer_gname").ToString, dr.Item("customer_mi").ToString, dr.Item("customer_surname").ToString, dr.Item("customer_suffix").ToString, dr.Item("credit_limit").ToString, dr.Item("balance").ToString, "EDIT", "DELETE")
            End While
        Else
            MsgBox("No available data to display", vbExclamation)
        End If

        dr.Close()
        frmCustomers.lbl_row_Count.Text = "(" & frmCustomers.dgCustomers.RowCount & ") Record(s) found."

        If frmCustomers.dgCustomers.RowCount > 0 Then
            query = "SELECT SUM(balance) FROM customer"
            cm = New MySqlCommand(query, con)
            Dim total = cm.ExecuteScalar
            frmCustomers.lbl_amount_Receivable.Text = total
        ElseIf frmCustomers.dgcustomers.RowCount = 0 Then
            frmCustomers.lbl_amount_Receivable.Text = "0.00"
        End If
        DisconnectDatabase()
    End Sub

    Public Function checkCustomerDuplicate()
        Try
            ConnectDatabase()
            Dim query = "SELECT customer_code FROM customer WHERE customer_code = @customer_code"
            Dim cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@customer_code", _Code)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                dr.Close()
                DisconnectDatabase()
                Return True
            End If
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        DisconnectDatabase()
        Return False
    End Function
    Public Sub searchCustomer(query As String)
        Dim i As Integer
        frmCustomers.dgCustomers.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _CustomerSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmCustomers.dgCustomers.Rows.Add(dr.Item("customer_id").ToString, i, dr.Item("customer_code").ToString, dr.Item("customer_gname").ToString, dr.Item("customer_mi").ToString, dr.Item("customer_surname").ToString, dr.Item("customer_suffix").ToString, dr.Item("credit_limit").ToString, dr.Item("balance").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        frmCustomers.lbl_row_Count.Text = "(" & frmCustomers.dgCustomers.RowCount & ") Record(s) found."

        query = "SELECT SUM(balance) FROM customer"
        cm = New MySqlCommand(query, con)
        Dim total = cm.ExecuteScalar
        dr.Close()
        DisconnectDatabase()
        frmCustomers.lbl_amount_Receivable.Text = total
    End Sub

End Class
