Imports System.Data.SqlClient

Public Class Comprobante
    Inherits Connection

    Public Function GetComprobante(id As Integer) As DataTable
        Using sqlConn = GetConnection()
            sqlConn.Open()
            Using command As New SqlCommand
                command.Connection = sqlConn
                command.CommandText =
                    "SELECT * FROM Comprobante
                    WHERE id = @id"
                command.Parameters.AddWithValue("@id", id)

                Dim dt As New DataTable
                dt.Load(command.ExecuteReader)
                Return dt
            End Using
        End Using
    End Function

    Public Function GetComprobantes() As DataTable
        Using sqlConn = GetConnection()
            sqlConn.Open()
            Using command As New SqlCommand
                command.Connection = sqlConn
                command.CommandText = "SELECT * FROM Comprobante"

                Dim dt As New DataTable
                dt.Load(command.ExecuteReader)
                Return dt
            End Using
        End Using
    End Function

    Public Function Eliminar(id As Integer) As Integer
        Using sqlConn = GetConnection()
            sqlConn.Open()
            Using command As New SqlCommand
                command.Connection = sqlConn
                command.CommandText = "DELETE FROM Comprobante WHERE id = @id"
                command.Parameters.AddWithValue("@id", id)

                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function Editar(id As Integer,
                           tipo As Integer,
                             cliente As Integer,
                             vendedor As Integer,
                             sucursal As Integer,
                             neto As Double,
                             igv As Double,
                             total As Double) As Integer

        Using sqlConn = GetConnection()
            sqlConn.Open()
            Using command As New SqlCommand
                command.Connection = sqlConn
                command.CommandText =
                    "UPDATE Comprobante
                    SET tipo = @tipo, 
                        cliente = @cliente, 
                        vendedor = @vendedor, 
                        sucursal = @sucursal, 
                        Neto = @neto, 
                        IGV = @igv, 
                        Total = @total
                    WHERE id = @id"
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@tipo", tipo)
                command.Parameters.AddWithValue("@cliente", cliente)
                command.Parameters.AddWithValue("@vendedor", vendedor)
                command.Parameters.AddWithValue("@sucursal", sucursal)
                command.Parameters.AddWithValue("@neto", neto)
                command.Parameters.AddWithValue("@igv", igv)
                command.Parameters.AddWithValue("@total", total)

                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function Insertar(tipo As Integer,
                             cliente As Integer,
                             vendedor As Integer,
                             sucursal As Integer,
                             neto As Double,
                             igv As Double,
                             total As Double) As Integer

        Using sqlConn = GetConnection()
            sqlConn.Open()
            Using command As New SqlCommand
                command.Connection = sqlConn
                command.CommandText =
                    "INSERT INTO Comprobante
                    VALUES (@tipo, @cliente, @vendedor, @sucursal, @neto, @igv, @total)"
                command.Parameters.AddWithValue("@tipo", tipo)
                command.Parameters.AddWithValue("@cliente", cliente)
                command.Parameters.AddWithValue("@vendedor", vendedor)
                command.Parameters.AddWithValue("@sucursal", sucursal)
                command.Parameters.AddWithValue("@neto", neto)
                command.Parameters.AddWithValue("@igv", igv)
                command.Parameters.AddWithValue("@total", total)

                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function
End Class
