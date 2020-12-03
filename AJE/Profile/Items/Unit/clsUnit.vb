Imports MySql.Data.MySqlClient
Public Class clsUnit
    Private _UnitName As Object
    Private _UnitId As Object
    Private _UnitSearch As Object
    Public Sub SetUnitName(AutoPropertyValue As Object)
        _UnitName = AutoPropertyValue
    End Sub
    Public Sub SetUnitId(AutoPropertyValue As Object)
        _UnitId = AutoPropertyValue
    End Sub
    Public Sub SetUnitSearch(AutoPropertyValue As Object)
        _UnitSearch = AutoPropertyValue
    End Sub
    Public Function save()
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO unit (unit_name) VALUES (@unit_name)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@unit_name", _UnitName)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            loadAutosuggest()
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
            Dim query = "UPDATE unit SET unit_name = @unit_name WHERE unit_id = @unit_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@unit_id", _UnitId)
            cm.Parameters.AddWithValue("@unit_name", _UnitName)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            loadAutosuggest()
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
            Dim query = "DELETE FROM unit WHERE unit_id = @unit_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@unit_id", _UnitId)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            loadAutosuggest()
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Sub loadRecord()
        Dim i As Integer
        frmItem.dg_Unit.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM unit"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            frmItem.dg_Unit.Rows.Add(dr.Item("unit_id").ToString, i, dr.Item("unit_name").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmItem.lbl_row_count_Unit.Text = "(" & frmItem.dg_Unit.RowCount & ") Record(s) found."
    End Sub
    Public Sub loadAutosuggest()
        ConnectDatabase()
        Dim query = "SELECT * FROM unit ORDER BY unit_name"
        cm = New MySqlCommand(query, con)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "unit_name")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("unit_name").ToString)
        Next
        frmItem.tb_search_Unit.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmItem.tb_search_Unit.AutoCompleteCustomSource = col
        frmItem.tb_search_Unit.AutoCompleteMode = AutoCompleteMode.Suggest

        frmItemEntry.tb_Unit.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmItemEntry.tb_Unit.AutoCompleteCustomSource = col
        frmItemEntry.tb_Unit.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        DisconnectDatabase()
    End Sub
    Public Sub searchUnit(query As String)
        Dim i As Integer
        frmItem.dg_Unit.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _UnitSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmItem.dg_Unit.Rows.Add(dr.Item("unit_id").ToString, i, dr.Item("unit_name").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmItem.lbl_row_count_Unit.Text = "(" & frmItem.dg_Unit.RowCount & ") Record(s) found."
    End Sub
    Public Function checkUnitExists() 'checks if branch is already in use in other tables(user, stock)
        Try
            ConnectDatabase()
            Dim query = "SELECT unit_id FROM item WHERE unit_id = @unit_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@unit_id", _UnitId)
            Dim count = Convert.ToInt16(cm.ExecuteScalar())
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
    Public Function checkUnitDuplicate()
        Try
            ConnectDatabase()
            Dim query = "SELECT unit_name FROM unit WHERE unit_name = @unit_name"
            Dim cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@unit_name", _UnitName)
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
    Public Function UnitId()
        Try
            ConnectDatabase()
            Dim query = "SELECT unit_id FROM unit WHERE unit_name = @unit_name"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@unit_name", _UnitName)
            dr = cm.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                Dim _id = dr.Item("unit_id")
                DisconnectDatabase()
                Return _id
            End If
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return -1
    End Function
End Class
