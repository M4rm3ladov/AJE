Imports MySql.Data.MySqlClient
Public Class clsStockAdjustment
    Private _ItemId As Object
    Private _BranchId As Object
    Private _CountDate As Object
    Private _DateFrom As Object
    Private _DateTo As Object
    Private _ItemQty As Object
    Private _RefNo As Object
    Private _Remarks As Object
    Public WriteOnly Property ItemId
        Set
            _ItemId = Value
        End Set
    End Property
    Public WriteOnly Property BranchId
        Set
            _BranchId = Value
        End Set
    End Property
    Public WriteOnly Property CountDate
        Set
            _CountDate = Value
        End Set
    End Property
    Public WriteOnly Property DateFrom
        Set
            _DateFrom = Value
        End Set
    End Property
    Public WriteOnly Property DateTo
        Set
            _DateTo = Value
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
    Public WriteOnly Property RefNo
        Set
            _RefNo = Value
        End Set
    End Property

    Dim stocklist As New clsStockList
    Public Sub save()
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT inventory_id FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id) "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.Parameters.AddWithValue("@branch_id", _BranchId)
        Dim count = cm.ExecuteScalar
        cm.Dispose()

        Dim inventory_id As Int64
        If count = 1 Then
            query = "SELECT inventory_id FROM inventory WHERE item_id = @item_id AND branch_id = @branch_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@item_id", _ItemId)
            cm.Parameters.AddWithValue("@branch_id", _BranchId)
            inventory_id = cm.ExecuteScalar()
            cm.Dispose()

            query = "UPDATE inventory SET qty = @qty WHERE item_id = @item_id AND branch_id = @branch_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@item_id", _ItemId)
            cm.Parameters.AddWithValue("@qty", _ItemQty)
            cm.Parameters.AddWithValue("@branch_id", _BranchId)
            cm.ExecuteScalar()
            cm.Dispose()

        Else
            MsgBox("Item from branch is non existent", vbExclamation)
            Exit Sub
        End If

        query = "INSERT INTO inventory_period (period_from, period_to) VALUES (@date_From, @date_To); SELECT LAST_INSERT_ID()"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@date_From", _DateFrom)
        cm.Parameters.AddWithValue("@date_To", _DateTo)
        Dim _inv_period_Id = cm.ExecuteScalar()
        cm.Dispose()

        query = "INSERT INTO physical_count (inv_period_id, inventory_id, ref_no, qty, count_date, remarks) " &
            "VALUES (@inv_period_id, @inventory_id, @ref_no, @qty, @count_date, @remarks); "
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@inventory_id", inventory_id)
        cm.Parameters.AddWithValue("@inv_period_id", _inv_period_Id)
        cm.Parameters.AddWithValue("@ref_no", _RefNo)
        cm.Parameters.AddWithValue("@qty", _ItemQty)
        cm.Parameters.AddWithValue("@count_date", _CountDate)
        cm.Parameters.AddWithValue("@remarks", _Remarks)
        cm.Parameters.AddWithValue("@item_id", _ItemId)
        cm.ExecuteScalar()
        cm.Dispose()
        DisconnectDatabase()

    End Sub
    Public Function getRefNo() As Integer  'checks table is empty with return of count = 1 else if empty count = 0
        ConnectDatabase()
        Dim query = "SELECT EXISTS(SELECT ref_no FROM physical_count)"
        cm = New MySqlCommand(query, con)
        Dim count = cm.ExecuteScalar()
        cm.Dispose()

        If count = 1 Then
            query = "SELECT MAX(ref_No) AS refNo FROM physical_count"
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
End Class
