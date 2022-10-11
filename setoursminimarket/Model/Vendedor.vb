Imports System.Data.SqlClient

Public Class Vendedor
    Inherits Connection

    Public Function GetVendedores() As DataTable
        Using sqlConn = GetConnection()
            sqlConn.Open()
            Using command As New SqlCommand
                command.Connection = sqlConn
                command.CommandText = "SELECT docIdentidad, nombreCompleto FROM Vendedor"

                Dim dt As New DataTable
                dt.Load(command.ExecuteReader)
                Return dt
            End Using
        End Using
    End Function
End Class
