Imports MySql.Data.MySqlClient
Public Class clsCashInOut
    Private _ManagerId As Object
    Public Sub SetManagerId(AutoPropertyValue As Object)
        _ManagerId = AutoPropertyValue
    End Sub
    Private _Trans_Date As Object

    Public Sub SetTrans_Date(AutoPropertyValue As Object)
        _Trans_Date = AutoPropertyValue
    End Sub

    Private _Amount As Object

    Public Sub SetAmount(AutoPropertyValue As Object)
        _Amount = AutoPropertyValue
    End Sub

    Private _Remarks As Object

    Public Sub SetRemarks(AutoPropertyValue As Object)
        _Remarks = AutoPropertyValue
    End Sub

    Public Sub saveCashIn()
        ConnectDatabase()
        Dim query = "INSERT INTO cash_in (cashier_id, manager_id, trans_date, amount, remarks)" &
                    " VALUES (@cashier_id, @manager_id, @trans_date, @amount, @remarks)"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@cashier_id", frmPos.lbl_user_Id.Text)
        cm.Parameters.AddWithValue("@manager_id", _ManagerId)
        cm.Parameters.AddWithValue("@trans_date", _Trans_Date)
        cm.Parameters.AddWithValue("@amount", _Amount)
        cm.Parameters.AddWithValue("@remarks", _Remarks)
        cm.ExecuteScalar()

        DisconnectDatabase()
    End Sub
    Public Sub saveCashOut()
        ConnectDatabase()
        Dim query = "INSERT INTO cash_out (cashier_id, manager_id, trans_date, amount, remarks)" &
                    " VALUES (@cashier_id, @manager_id, @trans_date, @amount, @remarks)"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@cashier_id", frmPos.lbl_user_Id.Text)
        cm.Parameters.AddWithValue("@manager_id", _ManagerId)
        cm.Parameters.AddWithValue("@trans_date", _Trans_Date)
        cm.Parameters.AddWithValue("@amount", _Amount)
        cm.Parameters.AddWithValue("@remarks", _Remarks)
        cm.ExecuteScalar()

        DisconnectDatabase()
    End Sub
End Class
