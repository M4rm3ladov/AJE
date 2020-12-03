Imports MySql.Data.MySqlClient
Public Class clsServices
    Private _ServiceCode As Object
    Private _ServiceDesc As Object
    Private _ServiceFeeA As Object
    Private _ServiceFeeB As Object
    Private _ServiceSearch As Object
    Public Sub SetCode(AutoPropertyValue As Object)
        _ServiceCode = AutoPropertyValue
    End Sub
    Public Sub SetDesc(AutoPropertyValue As Object)
        _ServiceDesc = AutoPropertyValue
    End Sub
    Public Sub SetFeeA(AutoPropertyValue As Object)
        _ServiceFeeA = AutoPropertyValue
    End Sub
    Public Sub SetFeeB(AutoPropertyValue As Object)
        _ServiceFeeB = AutoPropertyValue
    End Sub
    Public Sub SetServiceSearch(AutoPropertyValue As Object)
        _ServiceSearch = AutoPropertyValue
    End Sub
    Public Function save()
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO service (service_code, service_desc, service_fee_A, service_fee_B) " &
                        "VALUES (@service_code, @service_desc, @service_fee_A, @service_fee_B)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@service_code", _ServiceCode)
            cm.Parameters.AddWithValue("@service_desc", _ServiceDesc)
            cm.Parameters.AddWithValue("@service_fee_A", _ServiceFeeA)
            cm.Parameters.AddWithValue("@service_fee_B", _ServiceFeeB)
            cm.Dispose()
            cm.ExecuteScalar()
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
            Dim query = "UPDATE service SET service_desc = @service_desc, service_fee_A = @service_fee_A, service_fee_B = @service_fee_B WHERE service_code = @service_code"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@service_code", _ServiceCode)
            cm.Parameters.AddWithValue("@service_desc", _ServiceDesc)
            cm.Parameters.AddWithValue("@service_fee_A", _ServiceFeeA)
            cm.Parameters.AddWithValue("@service_fee_B", _ServiceFeeB)
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
            Dim query = "DELETE FROM service WHERE service_code = @service_code"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@service_code", _ServiceCode)
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
    Public Function checkServiceExists() 'checks if item is already in use in other tables(user, stock)
        Try
            ConnectDatabase()
            Dim query = "SELECT COUNT(*) FROM service WHERE service_code = @service_code"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@service_code", _ServiceCode)
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
    Public Function checkServiceDuplicate()
        Try
            ConnectDatabase()
            Dim query = "SELECT service_code FROM service WHERE service_code = @service_code"
            Dim cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@service_code", _ServiceCode)
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
    Public Sub loadRecord()
        Dim i As Integer
        frmServices.DataGridView1.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT service_id, service_code, service_desc, service_fee_A, service_fee_B FROM service"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmServices.DataGridView1.Rows.Add(dr.Item("service_id").ToString, i, dr.Item("service_code").ToString, dr.Item("service_desc").ToString, dr.Item("service_fee_A").ToString, dr.Item("service_fee_B"), "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmServices.lbl_row_Count.Text = "(" & frmServices.DataGridView1.RowCount & ") Record(s) found."
    End Sub
    Public Sub searchService(query As String)
        Dim i As Integer
        frmServices.DataGridView1.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _ServiceSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmServices.DataGridView1.Rows.Add(dr.Item("service_id").ToString, i, dr.Item("service_code").ToString, dr.Item("service_desc").ToString, dr.Item("service_fee_A").ToString, dr.Item("service_fee_B"), "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmServices.lbl_row_Count.Text = "(" & frmServices.DataGridView1.RowCount & ") Record(s) found."
    End Sub
End Class
