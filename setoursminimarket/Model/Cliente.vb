Imports System.Data.SqlClient

Public Class Cliente
    Inherits Connection

    Public Function GetAll() As DataTable
        Using sqlConn = GetConnection()
            sqlConn.Open()
            Using command As New SqlCommand
                command.Connection = sqlConn
                command.CommandText = "SELECT * FROM Cliente"

                Dim dt As New DataTable
                dt.Load(command.ExecuteReader)
                Return dt
            End Using
        End Using
    End Function
End Class
