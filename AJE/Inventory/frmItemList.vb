Public Class frmItemList
    Dim itemList As New clsItemList
    Dim _id, _code, _desc, _brand, _category
    Private _stockType As Object

    Public Sub SetstockType(AutoPropertyValue As Object)
        _stockType = AutoPropertyValue
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
    Private Sub dg_Items_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Items.CellContentClick
        Dim colName As String = dg_Items.Columns(e.ColumnIndex).Name
        Dim itemId = dg_Items.Rows(e.RowIndex).Cells(0).Value
        If frmStock.lbl_stock_Type.Text = 1 Then
            If frmStock.dg_stock_In.RowCount <> 0 Then   'checks if item has already been added to queue stock in
                For i = 0 To frmStock.dg_stock_In.RowCount - 1
                    Dim stock_in_Id = frmStock.dg_stock_In.Rows(i).Cells(0).Value
                    If itemId = stock_in_Id Then
                        MsgBox("Item has already been added.", vbExclamation)
                        Exit Sub
                    End If
                Next
            End If
            If colName = "col_Select" Then
                If MsgBox("Add item to list?", vbYesNo + vbInformation) = vbYes Then
                    frmStock.dg_stock_In.Rows.Add(dg_Items.Rows(e.RowIndex).Cells(0).Value.ToString, frmStock.dg_stock_In.Rows.Count + 1.ToString, dg_Items.Rows(e.RowIndex).Cells(2).Value.ToString,
                                                  dg_Items.Rows(e.RowIndex).Cells(3).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(4).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(5).Value.ToString,
                                                  dg_Items.Rows(e.RowIndex).Cells(6).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(7).Value.ToString, 0.ToString, "REMOVE")
                    MsgBox("Item is added to the list.", vbInformation)
                End If
            End If
        ElseIf frmStock.lbl_stock_Type.Text = 2 Then
            If frmStock.dg_stock_Transfer.RowCount <> 0 Then   'checks if item has already been added to queue stock in
                For i = 0 To frmStock.dg_stock_Transfer.RowCount - 1
                    Dim stock_in_Id = frmStock.dg_stock_Transfer.Rows(i).Cells(0).Value
                    If itemId = stock_in_Id Then
                        MsgBox("Item has already been added.", vbExclamation)
                        Exit Sub
                    End If
                Next
            End If
            If colName = "col_Select" Then
                If MsgBox("Add item to list?", vbYesNo + vbInformation) = vbYes Then
                    frmStock.dg_stock_Transfer.Rows.Add(dg_Items.Rows(e.RowIndex).Cells(0).Value.ToString, frmStock.dg_stock_Transfer.Rows.Count + 1.ToString, dg_Items.Rows(e.RowIndex).Cells(2).Value.ToString,
                                                  dg_Items.Rows(e.RowIndex).Cells(3).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(4).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(5).Value.ToString,
                                                  dg_Items.Rows(e.RowIndex).Cells(6).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(7).Value.ToString, 0.ToString, "REMOVE")
                    MsgBox("Item is added to the list.", vbInformation)
                End If
            End If
        ElseIf frmStock.lbl_stock_Type.Text = 3 Then
            If frmStock.dg_stock_Return.RowCount <> 0 Then   'checks if item has already been added to queue stock in
                For i = 0 To frmStock.dg_stock_Return.RowCount - 1
                    Dim stock_in_Id = frmStock.dg_stock_Return.Rows(i).Cells(0).Value
                    If itemId = stock_in_Id Then
                        MsgBox("Item has already been added.", vbExclamation)
                        Exit Sub
                    End If
                Next
            End If
            If colName = "col_Select" Then
                If MsgBox("Add item to list?", vbYesNo + vbInformation) = vbYes Then
                    frmStock.dg_stock_Return.Rows.Add(dg_Items.Rows(e.RowIndex).Cells(0).Value.ToString, frmStock.dg_stock_Return.Rows.Count + 1.ToString, dg_Items.Rows(e.RowIndex).Cells(2).Value.ToString,
                                                  dg_Items.Rows(e.RowIndex).Cells(3).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(4).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(5).Value.ToString,
                                                  dg_Items.Rows(e.RowIndex).Cells(6).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(7).Value.ToString, 0.ToString, "REMOVE")
                    MsgBox("Item is added to the list.", vbInformation)
                End If
            End If
        ElseIf frmStock.lbl_stock_Type.Text = 4 Then
            If frmStock.dg_stock_Out.RowCount <> 0 Then   'checks if item has already been added to queue stock in
                For i = 0 To frmStock.dg_stock_Out.RowCount - 1
                    Dim stock_in_Id = frmStock.dg_stock_Out.Rows(i).Cells(0).Value
                    If itemId = stock_in_Id Then
                        MsgBox("Item has already been added.", vbExclamation)
                        Exit Sub
                    End If
                Next
            End If
            If colName = "col_Select" Then
                If MsgBox("Add item to list?", vbYesNo + vbInformation) = vbYes Then
                    frmStock.dg_stock_Out.Rows.Add(dg_Items.Rows(e.RowIndex).Cells(0).Value.ToString, frmStock.dg_stock_Out.Rows.Count + 1.ToString, dg_Items.Rows(e.RowIndex).Cells(2).Value.ToString,
                                                  dg_Items.Rows(e.RowIndex).Cells(3).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(4).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(5).Value.ToString,
                                                  dg_Items.Rows(e.RowIndex).Cells(6).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(7).Value.ToString, 0.ToString, "REMOVE")
                    MsgBox("Item is added to the list.", vbInformation)
                End If
            End If
        ElseIf frmStock.lbl_stock_Type.Text = 5 Then
            If frmStock.dg_stock_Adjustment.RowCount <> 0 Then   'checks if item has already been added to queue stock in
                For i = 0 To frmStock.dg_stock_Adjustment.RowCount - 1
                    Dim stock_in_Id = frmStock.dg_stock_Adjustment.Rows(i).Cells(0).Value
                    If itemId = stock_in_Id Then
                        MsgBox("Item has already been added.", vbExclamation)
                        Exit Sub
                    End If
                Next
            End If
            If colName = "col_Select" Then
                If MsgBox("Add item to list?", vbYesNo + vbInformation) = vbYes Then
                    frmStock.dg_stock_Adjustment.Rows.Add(dg_Items.Rows(e.RowIndex).Cells(0).Value.ToString, frmStock.dg_stock_Out.Rows.Count + 1.ToString, dg_Items.Rows(e.RowIndex).Cells(2).Value.ToString,
                                                  dg_Items.Rows(e.RowIndex).Cells(3).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(4).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(5).Value.ToString,
                                                  dg_Items.Rows(e.RowIndex).Cells(6).Value.ToString, dg_Items.Rows(e.RowIndex).Cells(7).Value.ToString, 0.ToString, "REMOVE")
                    MsgBox("Item is added to the list.", vbInformation)
                End If
            End If
        End If
    End Sub
    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If Trim(tb_Search.Text) <> "" Then
            Select Case cbo_Filter.Text
                Case "Code"
                    itemList.ItemSearch = Trim(tb_Search.Text)
                    itemList.searchItem("SELECT item_id, item_code, item_desc, item_add_desc, brand.brand_name, category.category_name, unit.unit_name FROM item " &
                                    "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                                    "INNER JOIN category ON category.category_id = item.category_id INNER JOIN unit ON unit.unit_id = item.unit_id WHERE item_code LIKE @0")
                Case "Description"
                    itemList.ItemSearch = Trim(tb_Search.Text)
                    itemList.searchItem("SELECT item_id, item_code, item_desc, item_add_desc, brand.brand_name, category.category_name, unit.unit_name FROM item " &
                                    "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                                    "INNER JOIN category ON category.category_id = item.category_id INNER JOIN unit ON unit.unit_id = item.unit_id WHERE item_desc LIKE @0 OR item_add_desc LIKE @0")
                Case "Brand"
                    itemList.ItemSearch = Trim(tb_Search.Text)
                    itemList.searchItem("SELECT item_id, item_code, item_desc, item_add_desc, brand.brand_name, category.category_name, unit.unit_name FROM item " &
                                    "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                                    "INNER JOIN category ON category.category_id = item.category_id INNER JOIN unit ON unit.unit_id = item.unit_id WHERE brand_name LIKE @0")
                Case "Category"
                    itemList.ItemSearch = Trim(tb_Search.Text)
                    itemList.searchItem("SELECT item_id, item_code, item_desc, item_add_desc, brand.brand_name, category.category_name, unit.unit_name FROM item " &
                                    "INNER JOIN brand ON brand.brand_id = item.brand_id " &
                                    "INNER JOIN category ON category.category_id = item.category_id INNER JOIN unit ON unit.unit_id = item.unit_id WHERE category_name LIKE @0")
            End Select
        Else
            itemList.loadRecord()
        End If
    End Sub
    Private Sub tb_Search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Search.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "',- .abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmItemList_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbo_Filter.Text = "Description"
        itemList.loadRecord()
    End Sub
End Class