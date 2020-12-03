Imports MySql.Data.MySqlClient
Public Class clsStockOut
    Private _ItemId As Object
    Private _RefNo As Object
    Private _BranchId As Object
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
    Public WriteOnly Property BranchId
        Set
            _BranchId = Value
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
        Dim inventory_id As Int64
        ConnectDatabase()
        Dim query = "SELECT inventory_id, qty FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        dr = cm.ExecuteReader
        dr.Read()
        inventory_id = dr.Item("inventory_id")
        Dim initialQty = dr.Item("qty")
        dr.Close()
        cm.Dispose()

        Dim newStockQty = initialQty - _ItemQty  'computes the difference of initial item qty with stock entry qty
        query = "UPDATE inventory SET qty = " & newStockQty & " WHERE item_id = @item_id AND branch_id = @branch_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        cm.ExecuteScalar()
        cm.Dispose()

        query = "INSERT INTO stock_out (inventory_id, ref_no, branch_id, qty, trans_date, remarks) " &
                "VALUES (@inventory_id, @ref_no, @branch_id, @qty, @trans_date, @remarks) "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@inventory_id", inventory_id)
        cm.Parameters.AddWithValue("@ref_no", _RefNo)
        cm.Parameters.AddWithValue("@qty", _ItemQty)
        cm.Parameters.AddWithValue("@trans_date", _TransacDate)
        cm.Parameters.AddWithValue("@remarks", _Remarks)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        cm.ExecuteScalar()
        cm.Dispose()
        DisconnectDatabase()
    End Sub
    Public Function getRefNo() As Integer  'checks table is empty with return of count = 1 else if empty count = 0
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT ref_no FROM stock_out)"
        cm = New MySqlCommand(query, con)
        Dim count = cm.ExecuteScalar()
        cm.Dispose()

        If count = 1 Then
            query = "SELECT MAX(ref_No) AS refNo FROM stock_out"
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
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        Dim ret = cm.ExecuteScalar()
        DisconnectDatabase()
        Return ret
    End Function
    Public Function getItemBranchQty() As Integer
        ConnectDatabase()
        Dim query = "SELECT qty FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        Dim qty = cm.ExecuteScalar()
        DisconnectDatabase()
        Return qty
    End Function
End Class
