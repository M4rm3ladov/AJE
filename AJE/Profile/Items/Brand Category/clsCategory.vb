Imports MySql.Data.MySqlClient
Public Class clsCategory
    Private _CategoryName As Object
    Private _CategoryId As Object
    Private _CategorySearch As Object
    Public Sub SetCategoryName(AutoPropertyValue As Object)
        _CategoryName = AutoPropertyValue
    End Sub
    Public Sub SetCategoryId(AutoPropertyValue As Object)
        _CategoryId = AutoPropertyValue
    End Sub
    Public Sub SetCategorySearch(AutoPropertyValue As Object)
        _CategorySearch = AutoPropertyValue
    End Sub
    Public Function save()
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO category (category_name) VALUES (@category_name)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@category_name", _CategoryName)
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
            Dim query = "UPDATE category SET category_name = @category_name WHERE category_id = @category_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@category_id", _CategoryId)
            cm.Parameters.AddWithValue("@category_name", _CategoryName)
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
            Dim query = "DELETE FROM category WHERE category_id = @category_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@category_id", _CategoryId)
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
        frmItem.dg_Category.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM category"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            frmItem.dg_Category.Rows.Add(dr.Item("category_id").ToString, i, dr.Item("category_name").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmItem.lbl_row_count_Category.Text = "(" & frmItem.dg_Category.RowCount & ") Record(s) found."
    End Sub
    Public Sub loadAutosuggest()
        ConnectDatabase()
        Dim query = "SELECT * FROM category ORDER BY category_name"
        cm = New MySqlCommand(query, con)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "category_name")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("category_name").ToString)
        Next
        frmItem.tb_search_Category.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmItem.tb_search_Category.AutoCompleteCustomSource = col
        frmItem.tb_search_Category.AutoCompleteMode = AutoCompleteMode.Suggest

        frmItemEntry.tb_Category.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmItemEntry.tb_Category.AutoCompleteCustomSource = col
        frmItemEntry.tb_Category.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        DisconnectDatabase()
    End Sub
    Public Function checkCategoryExists() 'checks if branch is already in use in other tables(user, stock)
        Try
            ConnectDatabase()
            Dim query = "SELECT category_id FROM item WHERE category_id = @category_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@category_id", _CategoryId)
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
    Public Function categoryId()
        Try
            ConnectDatabase()
            Dim query = "SELECT category_id FROM category WHERE category_name = @category_name"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@category_name", _CategoryName)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Dim _id = dr.Item("category_id")
                dr.Close()
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
    Public Function checkCategoryDuplicate()
        Try
            ConnectDatabase()
            Dim query = "SELECT category_name FROM category WHERE category_name = @category_name"
            Dim cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@category_id", _CategoryId)
            cm.Parameters.AddWithValue("@category_name", _CategoryName)
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
    Public Sub searchCategory(query As String)
        Dim i As Integer
        frmItem.dg_Category.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", _CategorySearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmItem.dg_Category.Rows.Add(dr.Item("category_id").ToString, i, dr.Item("category_name").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmItem.lbl_row_count_Category.Text = "(" & frmItem.dg_Category.RowCount & ") Record(s) found."
    End Sub
End Class
