Imports MySql.Data.MySqlClient
Public Class clsCustomerList
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
    Public Sub loadRecord() 'HERE'
        Dim i As Integer
        frmCustomerSearch.DataGridView1.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT customer.customer_id, customer_code, credit_limit, customer_gname, customer_mi, customer_surname, customer_suffix, credit_limit, balance FROM customer " &
                    "INNER JOIN customer_details ON customer.customer_id = customer_details.customer_id "
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmCustomerSearch.DataGridView1.Rows.Add(dr.Item("customer_id").ToString, dr.Item("customer_code").ToString, dr.Item("customer_gname").ToString, dr.Item("customer_mi").ToString, dr.Item("customer_surname").ToString, dr.Item("customer_suffix").ToString, dr.Item("credit_limit").ToString, dr.Item("balance").ToString, "SELECT")
        End While
        dr.Close()
        frmCustomerSearch.lbl_row_Count.Text = "(" & frmCustomerSearch.DataGridView1.RowCount & ") Record(s) found."
    End Sub
    Public Sub searchCustomer(query As String)
        Dim i As Integer
        frmCustomerSearch.DataGridView1.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _CustomerSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmCustomerSearch.DataGridView1.Rows.Add(dr.Item("customer_id").ToString, dr.Item("customer_code").ToString, dr.Item("customer_gname").ToString, dr.Item("customer_mi").ToString, dr.Item("customer_surname").ToString, dr.Item("customer_suffix").ToString, dr.Item("credit_limit").ToString, dr.Item("balance").ToString, "SELECT")
        End While
        dr.Close()
        frmCustomerSearch.lbl_row_Count.Text = "(" & frmCustomerSearch.DataGridView1.RowCount & ") Record(s) found."
    End Sub
End Class
