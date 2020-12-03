Imports MySql.Data.MySqlClient
Public Class clsUserList
    Public Property CashierId
    Public Property ManagerId
    Public Property UserSearch
    Public Sub loadRecord()
        Dim i As Integer
        frmUserList.DataGridView1.Rows.Clear()
        ConnectDatabase()
        Dim query = "SELECT users.user_id, branch.branch_address, user_surname, user_gname, user_mi, user_suffix, CAST(username AS CHAR) AS username, user_type, is_active FROM users " &
                    "INNER JOIN user_details ON users.user_id = user_details.user_id " &
                    "INNER JOIN branch ON branch.branch_id = users.branch_id"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmUserList.DataGridView1.Rows.Add(dr.Item("user_id").ToString, i, dr.Item("branch_address").ToString, dr.Item("user_gname").ToString, dr.Item("user_mi").ToString, dr.Item("user_surname").ToString, dr.Item("user_suffix").ToString, dr.Item("username").ToString, dr.Item("user_type").ToString, dr.Item("is_active"), "SELECT")
        End While
        dr.Close()
        DisconnectDatabase()
        frmUserList.lbl_row_Count.Text = "(" & frmUserList.DataGridView1.RowCount & ") Record(s) found."
    End Sub
    Public Sub searchUser(query As String)
        Dim i As Integer
        frmUserList.DataGridView1.Rows.Clear()
        ConnectDatabase()
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@0", UserSearch & "%")
        dr = cm.ExecuteReader()
        While dr.Read
            i += 1
            frmUserList.DataGridView1.Rows.Add(dr.Item("user_id").ToString, i, dr.Item("branch_address").ToString, dr.Item("user_gname").ToString, dr.Item("user_mi").ToString, dr.Item("user_surname").ToString, dr.Item("user_suffix").ToString, dr.Item("username").ToString, dr.Item("user_type").ToString, dr.Item("is_active"), "SELECT")
        End While
        dr.Close()
        DisconnectDatabase()
        frmUserList.lbl_row_Count.Text = "(" & frmUserList.DataGridView1.RowCount & ") Record(s) found."
    End Sub
    Public Function checkDuplicateCashier()
        ConnectDatabase()
        Dim query = "SELECT user_id FROM cashier WHERE @user_id = user_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@user_id", CashierId)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            dr.Close()
            DisconnectDatabase()
            Return True
        End If
        dr.Close()
        DisconnectDatabase()
        Return False
    End Function
    Public Function checkDuplicateManager()
        ConnectDatabase()
        Dim query = "SELECT user_id FROM manager WHERE @user_id = user_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@user_id", ManagerId)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            dr.Close()
            DisconnectDatabase()
            Return True
        End If
        dr.Close()
        DisconnectDatabase()
        Return False
    End Function
    Public Function checkUserTypeManager()
        ConnectDatabase()
        Dim query = "SELECT user_type FROM users WHERE @user_id = user_id"
        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@user_id", ManagerId)
        dr = cm.ExecuteReader()
        While dr.Read
            If dr.Item("user_type").ToString = "Cashier" Then
                DisconnectDatabase()
                Return True
            End If
        End While
        DisconnectDatabase()
        Return False
    End Function
End Class
