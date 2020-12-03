Public Class frmCustomerSearch
    Dim customerSrch As New clsCustomerList
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
    Private Sub frmCustomerSearch_Load(sender As Object, e As EventArgs) Handles Me.Load
        customerSrch.loadRecord()
    End Sub
    Private Sub dataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim _balance As Double = DataGridView1.Item(7, i).Value
        Dim _credLimit As Double = DataGridView1.Item(6, i).Value
        lbl_Expendable.Text = Format(Val(_credLimit) - Val(_balance), "0.00")
        lbl_Balance.Text = Format(_balance, "0.00")
    End Sub
    Private Sub tb_Search_TextChanged(sender As Object, e As EventArgs) Handles tb_Search.TextChanged
        If Trim(tb_Search.Text) <> "" Then
            customerSrch.SetcustomerSearch(Trim(tb_Search.Text))
            customerSrch.searchCustomer("SELECT customer.customer_id, customer_code, customer_gname, customer_mi, customer_surname, customer_suffix, credit_limit, balance FROM customer " &
                                   "INNER JOIN customer_details ON customer_details.customer_id = customer.customer_id WHERE customer_gname LIKE @0 OR customer_surname LIKE @0 OR " &
                                   "customer_code LIKE @0 OR CONCAT(customer_gname, ' ', customer_mi, ' ', customer_surname, ' ', customer_suffix ) LIKE @0")
        Else
            customerSrch.loadRecord()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        Dim i As Integer = DataGridView1.CurrentRow.Index
        If colName = "col_Add" Then
            If lbl_Type.Text = 1 Then
                frmPos.tb_customer_Name.Text = DataGridView1.Item(2, i).Value & " " & DataGridView1.Item(3, i).Value & " " & DataGridView1.Item(4, i).Value & " " & DataGridView1.Item(5, i).Value
                frmPos.lbl_customer_Id.Text = DataGridView1.Item(0, i).Value
            ElseIf lbl_Type.Text = 2 Then
                frmCreditPay.lbl_customer_Id.Text = DataGridView1.Item(0, i).Value
                frmCreditPay.tb_Name.Text = DataGridView1.Item(2, i).Value & " " & DataGridView1.Item(3, i).Value & " " & DataGridView1.Item(4, i).Value & " " & DataGridView1.Item(5, i).Value
            ElseIf lbl_Type.Text = 3 Then
                frmCreditPay.lbl_custId.Text = DataGridView1.Item(0, i).Value
                frmCreditPay.tb_CustName.Text = DataGridView1.Item(2, i).Value & " " & DataGridView1.Item(3, i).Value & " " & DataGridView1.Item(4, i).Value & " " & DataGridView1.Item(5, i).Value
            ElseIf lbl_Type.Text = 4 Then
                frmCustomerTransacs.lbl_transac_customer_Id.Text = DataGridView1.Item(0, i).Value
                frmCustomerTransacs.tb_transac_Customer.Text = DataGridView1.Item(2, i).Value & " " & DataGridView1.Item(3, i).Value & " " & DataGridView1.Item(4, i).Value & " " & DataGridView1.Item(5, i).Value
            End If

            Me.Close()
        End If
    End Sub
End Class