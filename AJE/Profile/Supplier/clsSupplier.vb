Imports MySql.Data.MySqlClient
Public Class clsSupplier
    Public Property SupplierName
    Public Property SupplierAddress
    Public Property SupplierId
    Public Property SupplierSearch
    Public Function save()
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO supplier (supplier_name, supplier_address) VALUES (@supplier_name, @supplier_address)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@supplier_name", SupplierName)
            cm.Parameters.AddWithValue("@supplier_address", SupplierAddress)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
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
            Dim query = "UPDATE supplier SET supplier_name = @supplier_name, supplier_address = @supplier_address WHERE supplier_id = @supplier_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@supplier_id", SupplierId)
            cm.Parameters.AddWithValue("@supplier_name", SupplierName)
            cm.Parameters.AddWithValue("@supplier_address", SupplierAddress)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
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
            Dim query = "DELETE FROM supplier WHERE supplier_id = @supplier_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@supplier_id", SupplierId)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Sub loadRecord()
        Dim i As Integer
        frmSupplier.DataGridView1.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM supplier"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            frmSupplier.DataGridView1.Rows.Add(dr.Item("supplier_id").ToString, i, dr.Item("supplier_name").ToString, dr.Item("supplier_address").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmSupplier.lbl_row_Count.Text = "(" & frmSupplier.DataGridView1.RowCount & ") Record(s) found."
    End Sub
    Public Sub searchSupplier(query As String)
        Dim i As Integer
        frmSupplier.DataGridView1.Rows.Clear()
        ConnectDatabase()
        Dim cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", SupplierSearch & "%")
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            frmSupplier.DataGridView1.Rows.Add(dr.Item("supplier_id").ToString, i, dr.Item("supplier_name").ToString, dr.Item("supplier_address").ToString, "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmSupplier.lbl_row_Count.Text = "(" & frmSupplier.DataGridView1.RowCount & ") Record(s) found."
    End Sub
    Public Function checkSupplierExists() 'checks if branch is already in use in other tables(user, stock)
        Try
            ConnectDatabase()
            Dim query = "SELECT supplier_id FROM stock_in WHERE supplier_id = @supplier_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@supplier_id", SupplierId)
            Dim count = Convert.ToInt16(cm.ExecuteScalar())

            query = "SELECT supplier_id FROM stock_return WHERE supplier_id = @supplier_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@supplier_id", SupplierId)
            count += Convert.ToInt16(cm.ExecuteScalar())

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
    Public Function checkSupplierDuplicate(flag As String)
        Try
            ConnectDatabase()
            Dim query
            If flag = "save" Then
                query = "SELECT supplier_name FROM supplier WHERE supplier_name = @supplier_name"
                Dim cm = New MySqlCommand(query, con)

                cm.Parameters.AddWithValue("@supplier_name", SupplierName)
                dr = cm.ExecuteReader
                If dr.HasRows Then
                    dr.Close()
                    DisconnectDatabase()
                    Return True
                End If
            ElseIf flag = "update" Then
                query = "SELECT COUNT(supplier_name) FROM supplier WHERE supplier_name = @supplier_name"
                Dim cm = New MySqlCommand(query, con)

                cm.Parameters.AddWithValue("@supplier_name", SupplierName)
                Dim count = cm.ExecuteScalar
                If count > 1 Then
                    dr.Close()
                    DisconnectDatabase()
                    Return True
                End If
            End If

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        DisconnectDatabase()
        Return False
    End Function
    Public Sub loadAutosuggest()
        ConnectDatabase()
        Dim query = "SELECT * FROM supplier ORDER BY supplier_name"
        cm = New MySqlCommand(query, con)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "supplier_name")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("supplier_name").ToString)
        Next
        frmStock.tb_supplier_stock_In.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmStock.tb_supplier_stock_In.AutoCompleteCustomSource = col
        frmStock.tb_supplier_stock_In.AutoCompleteMode = AutoCompleteMode.Suggest

        frmStock.tb_supplier_sR.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmStock.tb_supplier_sR.AutoCompleteCustomSource = col
        frmStock.tb_supplier_sR.AutoCompleteMode = AutoCompleteMode.Suggest
        DisconnectDatabase()
    End Sub
    Public Function loadSupplierId()
        ConnectDatabase()
        Dim query = "SELECT supplier_id FROM supplier WHERE supplier_name = @supplier_name"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@supplier_name", _SupplierName)
        Dim dr As MySqlDataReader = cm.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Dim id = dr(0).ToString
            dr.Close()
            DisconnectDatabase()
            Return id
        Else
            dr.Close()
            DisconnectDatabase()
            Return -1
        End If
        DisconnectDatabase()
    End Function

End Class
