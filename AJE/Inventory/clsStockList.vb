Imports MySql.Data.MySqlClient
Public Class clsStockList
    Private _BranchAddress As Object
    Private _CategoryName As Object
    Private _BrandName As Object
    Private _ItemSearch As Object

    Public Sub SetBranchAddress(AutoPropertyValue As Object)
        _BranchAddress = AutoPropertyValue
    End Sub

    Public Sub SetCategoryName(AutoPropertyValue As Object)
        _CategoryName = AutoPropertyValue
    End Sub
    Public Sub SetBrandName(AutoPropertyValue As Object)
        _BrandName = AutoPropertyValue
    End Sub
    Public Sub SetItemSearch(AutoPropertyValue As Object)
        _ItemSearch = AutoPropertyValue
    End Sub
    Public Sub loadStockList()
        Dim i As Integer
        frmStock.dg_stock_List.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT * FROM vw_stock_list WHERE branch_address = @branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_address", _BranchAddress)
        dr = cm.ExecuteReader()
        While dr.Read()
            i += 1
            frmStock.dg_stock_List.Rows.Add(dr.Item("item_id").ToString, i, dr.Item("branch_address").ToString,
                                               dr.Item("item_code").ToString, dr.Item("brand_name").ToString, dr.Item("item_desc").ToString, dr.Item("item_add_desc").ToString,
                                               dr.Item("category_name").ToString, dr.Item("unit_name").ToString, dr.Item("qty").ToString)
        End While
        DisconnectDatabase()
        frmStock.lbl_row_count_stock_List.Text = "(" & frmStock.dg_stock_List.RowCount & ") Record(s) found."
    End Sub
    Public Sub loadStock(query As String)
        Dim i As Integer
        frmStock.dg_stock_List.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@category_name", _CategoryName)
        cm.Parameters.AddWithValue("@brand_name", _BrandName)
        cm.Parameters.AddWithValue("@item_search", _ItemSearch & "%")
        cm.Parameters.AddWithValue("@branch_address", _BranchAddress)
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmStock.dg_stock_List.Rows.Add(dr.Item("item_id").ToString, i, dr.Item("branch_address").ToString,
                                               dr.Item("item_code").ToString, dr.Item("brand_name").ToString, dr.Item("item_desc").ToString, dr.Item("item_add_desc").ToString,
                                               dr.Item("category_name").ToString, dr.Item("unit_name").ToString, dr.Item("qty").ToString)
        End While
        dr.Close()
        DisconnectDatabase()
        frmStock.lbl_row_count_stock_List.Text = "(" & frmStock.dg_stock_List.RowCount & ") Record(s) found."
    End Sub
    Public Sub loadCategory()
        ConnectDatabase()
        Dim query = "SELECT category_name FROM category ORDER BY category_name"
        cm = New MySqlCommand(query, con)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "category_name")
        frmStock.cbo_Category.Items.Add("All Category")
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            With frmStock.cbo_Category
                .Items.Add(ds.Tables(0).Rows(i)("category_name").ToString)
            End With
        Next
        DisconnectDatabase()
    End Sub
    Public Sub loadBrand()
        ConnectDatabase()
        Dim query = "SELECT brand_name FROM brand ORDER BY brand_name"
        cm = New MySqlCommand(query, con)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "brand_name")
        frmStock.cbo_Brand.Items.Add("All Brand")
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            With frmStock.cbo_Brand
                .Items.Add(ds.Tables(0).Rows(i)("brand_name").ToString)
            End With
        Next
        DisconnectDatabase()
    End Sub
End Class
