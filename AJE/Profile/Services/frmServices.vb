Public Class frmServices
    Dim service As New clsServices
    Dim _id As Integer
    Dim _code, _desc As String
    Dim _price_A, _price_B As Double
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        frmServiceEntry.btn_Update.Enabled = False
        frmServiceEntry.btn_Save.Enabled = True
        frmServiceEntry.tb_service_Code.ReadOnly = False
        frmServiceEntry.ShowDialog()
    End Sub
    Private Sub frmItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbo_Category.SelectedIndex = 1
        service.loadRecord()
    End Sub
    Private Sub dataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer = DataGridView1.CurrentRow.Index
        _id = DataGridView1.Item(0, i).Value
        _code = DataGridView1.Item(2, i).Value
        _desc = DataGridView1.Item(3, i).Value
        _price_A = DataGridView1.Item(4, i).Value
        _price_B = DataGridView1.Item(5, i).Value
    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "col_Edit" Then
            With frmServiceEntry
                .lbl_Id.Text = _id
                .tb_service_Code.Text = _code
                .tb_Desc.Text = _desc
                .tb_fee_A.Text = _price_A
                .tb_fee_B.Text = _price_B
                .tb_service_Code.ReadOnly = True
                .btn_Save.Enabled = False
                .btn_Update.Enabled = True
                .ShowDialog()
            End With

        ElseIf colName = "col_Delete" Then
            Dim result = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
            If result = vbYes Then
                service.SetCode(_code)
                If service.checkServiceExists = False Then
                    service.delete()
                    MsgBox("Record has been successfully deleted.", vbInformation)
                    service.loadRecord()
                Else
                    MsgBox("Record already in use and therefore can not be deleted.", vbInformation)
                End If
            End If

        End If
    End Sub
    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If Trim(tb_Search.Text) <> "" Then
            Select Case cbo_Category.Text
                Case "Code"
                    service.SetServiceSearch(Trim(tb_Search.Text))
                    service.searchService("SELECT service_id, service_code, service_desc, service_fee_A, service_fee_B FROM service WHERE service_code LIKE @0")
                Case "Description"
                    service.SetServiceSearch(Trim(tb_Search.Text))
                    service.searchService("SELECT service_id, service_code, service_desc, service_fee_A, service_fee_B FROM service WHERE service_desc LIKE @0")
            End Select
        Else
            service.loadRecord()
        End If
    End Sub
End Class