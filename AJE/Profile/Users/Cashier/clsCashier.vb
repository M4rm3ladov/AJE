Imports MySql.Data.MySqlClient
Public Class clsCashier
    Public Property Username
    Public Property Password
    Public Property Salt
    Public Property Active
    Public Property Id
    Public Property CashierSearch
    Public Function save()
        Try
            ConnectDatabase()
            Dim query = "INSERT INTO cashier (user_id, username, password, salt, is_active) " &
                            "VALUES (@user_id, @username, @password, @salt, @is_active)"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_id", Id)
            cm.Parameters.AddWithValue("@username", Username)
            cm.Parameters.AddWithValue("@password", Password)
            cm.Parameters.AddWithValue("@salt", Salt)
            cm.Parameters.AddWithValue("@is_active", Active)
            cm.ExecuteScalar()
            cm.Dispose()
            'loadAutosuggest()
            Return True
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function edit()
        Try
            ConnectDatabase()
            Dim query = "UPDATE cashier SET is_active = @is_active WHERE user_id=@user_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_id", Id)
            cm.Parameters.AddWithValue("@password", Password)
            cm.Parameters.AddWithValue("salt", Salt)
            cm.Parameters.AddWithValue("@is_active", Active)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function delete()
        Try
            ConnectDatabase()
            Dim query = "DELETE FROM cashier WHERE user_id = @user_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_id", Id)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function checkCashierExists() 'checks if item is already in use in other tables(user, stock)
        Try
            ConnectDatabase()
            Dim query = "SELECT COUNT(*) FROM cashier_log INNER JOIN cashier ON cashier.cashier_id = cashier_log.cashier_id WHERE cashier.user_id = @user_id"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@user_id", Id)
            Dim count = cm.ExecuteScalar()
            If count > 0 Then
                Return True
                DisconnectDatabase()
            End If
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function changePass()
        Try
            ConnectDatabase()
            Dim query = "UPDATE cashier SET password = @password, salt = @salt WHERE username = @username"
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@password", Password)
            cm.Parameters.AddWithValue("@salt", Salt)
            cm.Parameters.AddWithValue("@username", Username)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            'loadAutosuggest()
            Return True
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Sub loadRecord()
        Dim i As Integer
        frmUser.DataGridView2.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT users.user_id,  user_surname, user_gname, user_mi, user_suffix, CAST(cashier.username AS CHAR) AS _c_username, cashier.is_active FROM users " &
                    "INNER JOIN user_details ON users.user_id = user_details.user_id " &
                    "INNER JOIN cashier ON cashier.user_id = users.user_id"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmUser.DataGridView2.Rows.Add(dr.Item("user_id").ToString, i, dr.Item("user_gname").ToString, dr.Item("user_mi").ToString, dr.Item("user_surname").ToString, dr.Item("user_suffix").ToString, dr.Item("_c_username").ToString, dr.Item("is_active"), "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmUser.lbl_row_count_Cashier.Text = "(" & frmUser.DataGridView2.RowCount & ") Record(s) found."
    End Sub
    Public Function checkCashierDuplicate()
        Try
            ConnectDatabase()
            Dim query = "SELECT username, user_id FROM cashier WHERE username = @username OR user_id = @user_id"
            Dim cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@username", Username)
            cm.Parameters.AddWithValue("@user_id", Id)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                dr.Close()
                DisconnectDatabase()
                Return True
            End If
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        DisconnectDatabase()
        Return False
    End Function
    Public Sub searchUser(query As String)
        Dim i As Integer
        frmUser.DataGridView2.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", CashierSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmUser.DataGridView2.Rows.Add(dr.Item("user_id").ToString, i, dr.Item("user_gname").ToString, dr.Item("user_mi").ToString, dr.Item("user_surname").ToString, dr.Item("user_suffix").ToString, dr.Item("_c_username").ToString, dr.Item("is_active"), "EDIT", "DELETE")
        End While
        dr.Close()
        DisconnectDatabase()
        frmUser.lbl_row_count_Cashier.Text = "(" & frmUser.DataGridView2.RowCount & ") Record(s) found."
    End Sub
End Class
