Imports MySql.Data.MySqlClient
Public Class clsItemList
    Public Property ItemId
    Public Property ItemSearch
    Public Sub loadRecord()
        Dim i As Integer
        frmItemList.dg_Items.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT item_id, item_code, item_desc, item_add_desc, brand.brand_name, category.category_name, unit.unit_name FROM item " &
                    "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                    "INNER JOIN category ON category.category_id = item.category_id " &
                    "INNER JOIN unit ON unit.unit_id = item.unit_id"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmItemList.dg_Items.Rows.Add(dr.Item("item_id").ToString, i, dr.Item("item_code").ToString, dr.Item("brand_name").ToString, dr.Item("item_desc").ToString, dr.Item("item_add_desc").ToString, dr.Item("category_name").ToString, dr.Item("unit_name").ToString, "SELECT")
        End While
        dr.Close()
        DisconnectDatabase()
        frmItemList.lbl_row_Count.Text = "(" & frmItemList.dg_Items.RowCount & ") Record(s) found."
    End Sub
    Public Sub searchItem(query As String)
        Dim i As Integer
        frmItemList.dg_Items.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", ItemSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmItemList.dg_Items.Rows.Add(dr.Item("item_id").ToString, i, dr.Item("item_code").ToString, dr.Item("brand_name").ToString, dr.Item("item_desc").ToString, dr.Item("item_add_desc").ToString, dr.Item("category_name").ToString, dr.Item("unit_name"), "SELECT")
        End While
        dr.Close()
        DisconnectDatabase()
        frmItemList.lbl_row_Count.Text = "(" & frmItemList.dg_Items.RowCount & ") Record(s) found."
    End Sub

End Class
