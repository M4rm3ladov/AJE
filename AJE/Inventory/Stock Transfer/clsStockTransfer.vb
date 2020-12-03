Imports MySql.Data.MySqlClient
Public Class clsStockTransfer
    Private _ItemId As Object
    Private _RefNo As Object
    Private _BranchFromId As Object
    Private _BranchToId As Object
    Private _TransacDate As Object
    Private _ItemQty As Object
    Private _Remarks As Object
    Public WriteOnly Property ItemId
        Set
            _ItemId = Value
        End Set
    End Property
    Public WriteOnly Property RefNo
        Set
            _RefNo = Value
        End Set
    End Property
    Public WriteOnly Property BranchToId
        Set
            _BranchToId = Value
        End Set
    End Property
    Public WriteOnly Property BranchFromId
        Set
            _BranchFromId = Value
        End Set
    End Property
    Public WriteOnly Property TransacDate
        Set
            _TransacDate = Value
        End Set
    End Property
    Public WriteOnly Property ItemQty
        Set
            _ItemQty = Value
        End Set
    End Property
    Public WriteOnly Property Remarks
        Set
            _Remarks = Value
        End Set
    End Property
    Public Sub save()
        'Try
        Dim inventory_id_from, inventory_id_to As Int64
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT inventory_id FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id)"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchToId)
        Dim exist = cm.ExecuteScalar()
        cm.Dispose()

        If exist <> 1 Then
            query = "INSERT INTO inventory (item_id, branch_id) VALUES (@item_id, @branch_id)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@item_id", _ItemId)
            cm.Parameters.AddWithValue("@branch_id", _BranchToId)
            cm.ExecuteScalar()
            cm.Dispose()
        End If

        query = "SELECT inventory_id, qty FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchToId)
        dr = cm.ExecuteReader
        dr.Read()
        inventory_id_to = dr.Item("inventory_id")
        Dim initialQtyTo = dr.Item("qty")
        dr.Close()
        cm.Dispose()

        query = "SELECT inventory_id, qty FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchFromId)
        dr = cm.ExecuteReader
        dr.Read()
        inventory_id_from = dr.Item("inventory_id")
        Dim initialQtyFrom = dr.Item("qty")
        dr.Close()
        cm.Dispose()

        Dim newStockQtyTo = _ItemQty + initialQtyTo  'computes the sum of initial item qty with stock entry qty
        query = "UPDATE inventory SET qty = " & newStockQtyTo & " WHERE item_id = @item_id AND branch_id = @branch_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchToId)
        cm.ExecuteScalar()
        cm.Dispose()

        Dim newStockQtyFrom = initialQtyFrom - _ItemQty  'computes the difference of initial item qty with stock entry qty
        query = "UPDATE inventory SET qty = " & newStockQtyFrom & " WHERE item_id = @item_id AND branch_id = @branch_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchFromId)
        cm.ExecuteScalar()
        cm.Dispose()

        query = "INSERT INTO stock_transfer (inventory_id, ref_no, branch_to_id, branch_from_id, qty, trans_date, remarks) " &
                "VALUES (@inventory_id, @ref_no, @branch_to_id, @branch_from_id, @qty, @trans_date, @remarks) "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@inventory_id", inventory_id_from)
        cm.Parameters.AddWithValue("@ref_no", _RefNo)
        cm.Parameters.AddWithValue("@qty", _ItemQty)
        cm.Parameters.AddWithValue("@trans_date", _TransacDate)
        cm.Parameters.AddWithValue("@remarks", _Remarks)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_from_id", _BranchFromId)
        cm.Parameters.AddWithValue("@branch_to_id", _BranchToId)
        cm.ExecuteScalar()
        cm.Dispose()
        DisconnectDatabase()
        'Catch ex As Exception
        '    DisconnectDatabase()
        '    MsgBox(ex.Message, vbCritical)
        'End Try
    End Sub
    Public Function getRefNo() As Integer  'checks table is empty with return of count = 1 else if empty count = 0
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT ref_no FROM stock_transfer)"
        cm = New MySqlCommand(query, con)
        Dim count = cm.ExecuteScalar()
        cm.Dispose()

        If count = 1 Then
            query = "SELECT MAX(ref_No) AS refNo FROM stock_transfer"
            cm = New MySqlCommand(query, con)
            Dim ret = cm.ExecuteScalar() + 1
            cm.Dispose()
            DisconnectDatabase()
            Return ret
        Else
            Return 1
        End If
        DisconnectDatabase()
    End Function
    Public Function checkItemBranchExists() As Boolean
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT item_id FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id)"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchFromId)
        Dim ret = cm.ExecuteScalar()
        DisconnectDatabase()
        Return ret
    End Function
    Public Function getItemBranchQty() As Integer
        ConnectDatabase()
        Dim query = "SELECT qty FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchFromId)
        Dim qty = cm.ExecuteScalar()
        DisconnectDatabase()
        Return qty
    End Function
    Public Sub loadAutoSuggestBranch()
        ConnectDatabase()
        Dim query = "SELECT * FROM branch ORDER BY branch_address"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@branch_id", _BranchToId)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "branch_address")
        Dim col As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("branch_address").ToString)
        Next
        frmStock.tb_branch_to_sT.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmStock.tb_branch_to_sT.AutoCompleteCustomSource = col
        frmStock.tb_branch_to_sT.AutoCompleteMode = AutoCompleteMode.Suggest
        DisconnectDatabase()
    End Sub

End Class
