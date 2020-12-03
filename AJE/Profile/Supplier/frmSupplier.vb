Public Class frmSupplier
    Dim supplier As New clsSupplier
    Dim _id, _name, _address As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        With frmSupplierEntry
            .btn_Save.Enabled = True
            .btn_Update.Enabled = False
            .tb_Name.Clear()
            .tb_Name.ReadOnly = False
            .tb_Address.Clear()
            .lbl_Id.Text = vbNullString
            .tb_Name.Focus()
            .ShowDialog()
        End With
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer = DataGridView1.CurrentRow.Index
        _id = DataGridView1.Item(0, i).Value
        _name = DataGridView1.Item(2, i).Value
        _address = DataGridView1.Item(3, i).Value
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "col_Edit" Then
            With frmSupplierEntry
                .lbl_Id.Text = _id
                .tb_Name.Text = _name
                .tb_Name.ReadOnly = True
                .tb_Address.Text = _address
                .btn_Save.Enabled = False
                .btn_Update.Enabled = True
                .tb_Address.Focus()
                .ShowDialog()
            End With
        ElseIf colName = "col_Delete" Then
            Dim result = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
            If result = vbYes Then
                supplier.SupplierId = _id
                If supplier.checkSupplierExists = False Then
                    supplier.delete()
                    MsgBox("Record has been successfully deleted.", vbInformation)
                    supplier.loadRecord()
                Else
                    MsgBox("Record already in use and therefore can not be deleted.", vbInformation)
                End If
            End If
        End If
    End Sub
    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbo_Category.SelectedIndex = 0
        supplier.loadRecord()
    End Sub

    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If Trim(tb_Search.Text) <> "" Then
            supplier.SupplierSearch = Trim(tb_Search.Text)
            If cbo_Category.Text = "Name" Then
                supplier.searchSupplier("SELECT * FROM supplier WHERE supplier_name LIKE @0 ")
            ElseIf cbo_Category.Text = "Address" Then
                supplier.searchSupplier("SELECT * FROM supplier WHERE supplier_address LIKE @0 ")
            End If
        Else
            supplier.loadRecord()
        End If
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs)
        Me.Close()
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
End Class