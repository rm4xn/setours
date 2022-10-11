Imports System.Data.SqlClient

Public Class DetalleDeComprobante
    Inherits Connection

    Public Function Insertar(id As Integer,
                             producto As Integer,
                             cantidad As Double,
                             precio As Double) As Integer

        Using sqlConn = GetConnection()
            sqlConn.Open()
            Using command As New SqlCommand
                command.Connection = sqlConn
                command.CommandText =
                    "INSERT INTO DetalleDeComprobante
                    VALUES (@id, 0, @producto, @cantidad, @precio)"
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@producto", producto)
                command.Parameters.AddWithValue("@cantidad", cantidad)
                command.Parameters.AddWithValue("@precio", precio)

                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function
End Class
