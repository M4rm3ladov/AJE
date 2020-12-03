Imports MySql.Data.MySqlClient
Public Class clsBrand
    Private _BrandName As Object
    Private _BrandId As Object
    Private _BrandSearch As Object
    Public Sub SetBrandName(AutoPropertyValue As Object)
        _BrandName = AutoPropertyValue
    End Sub
    Public Sub SetBrandId(AutoPropertyValue As Object)
        _BrandId = AutoPropertyValue
    End Sub
    Public Sub SetBrandSearch(AutoPropertyValue As Object)
        _BrandSearch = AutoPropertyValue
    End Sub
    Public Function save()
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO brand (brand_name) VALUES (@brand_name)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@brand_name", _BrandName)
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
            Dim query = "UPDATE brand SET brand_name = @brand_name WHERE brand_id = @brand_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@brand_id", _BrandId)
            cm.Parameters.AddWithValue("@brand_name", _BrandName)
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
            Dim query = "DELETE FROM brand WHERE brand_id = @brand_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@brand_id", _BrandId)
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
        frmItem.dg_Brand.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM brand"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            frmItem.dg_Brand.Rows.Add(dr.Item("brand_id").ToString, i, dr.Item("brand_name").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmItem.lbl_row_count_Brand.Text = "(" & frmItem.dg_Brand.RowCount & ") Record(s) found."
    End Sub
    Public Sub loadAutosuggest()
        ConnectDatabase()
        Dim query = "SELECT * FROM brand ORDER BY brand_name"
        cm = New MySqlCommand(query, con)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "brand_name")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("brand_name").ToString)
        Next
        frmItem.tb_search_Brand.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmItem.tb_search_Brand.AutoCompleteCustomSource = col
        frmItem.tb_search_Brand.AutoCompleteMode = AutoCompleteMode.Suggest

        frmItemEntry.tb_Brand.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmItemEntry.tb_Brand.AutoCompleteCustomSource = col
        frmItemEntry.tb_Brand.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        DisconnectDatabase()
    End Sub
    Public Sub searchBrand(query As String)
        Dim i As Integer
        frmItem.dg_Brand.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _BrandSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmItem.dg_Brand.Rows.Add(dr.Item("brand_id").ToString, i, dr.Item("brand_name").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmItem.lbl_row_count_Brand.Text = "(" & frmItem.dg_Brand.RowCount & ") Record(s) found."
    End Sub
    Public Function checkBrandExists() 'checks if branch is already in use in other tables(user, stock)
        Try
            ConnectDatabase()
            Dim query = "SELECT brand_id FROM item WHERE brand_id = @brand_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@brand_id", _BrandId)
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
    Public Function checkBrandDuplicate()
        Try
            ConnectDatabase()
            Dim query = "SELECT brand_name FROM brand WHERE brand_name = @brand_name"
            Dim cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@brand_id", _BrandId)
            cm.Parameters.AddWithValue("@brand_name", _BrandName)
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
    Public Function BrandId()
        Try
            ConnectDatabase()
            Dim query = "SELECT brand_id FROM brand WHERE brand_name = @brand_name"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@brand_name", _BrandName)
            dr = cm.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                Dim _id = dr.Item("brand_id")
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
