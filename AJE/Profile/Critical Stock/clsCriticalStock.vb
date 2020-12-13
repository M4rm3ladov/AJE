Imports MySql.Data.MySqlClient
Public Class clsCriticalStock
    Public Property Qty
    Public Function save()
        Try
            ConnectDatabase()
            Dim query = "UPDATE misc SET critical_stock = @critical_stock WHERE misc_id = 1 "
            cm = New MySqlCommand(query, con)
            cm.Parameters.AddWithValue("@critical_stock", Qty)
            cm.ExecuteNonQuery()
            DisconnectDatabase()
            Return True

        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
    Public Function getCriticalStock()
        Try
            ConnectDatabase()
            Dim query = "SELECT critical_stock FROM misc WHERE misc_id = 1"
            cm = New MySqlCommand(query, con)
            Dim count = Convert.ToInt16(cm.ExecuteScalar())
            DisconnectDatabase()
            Return count
        Catch ex As Exception
            DisconnectDatabase()
            MsgBox(ex.Message, vbCritical)
        End Try
        DisconnectDatabase()
        Return False
    End Function
End Class
