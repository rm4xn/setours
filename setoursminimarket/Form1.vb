Public Class Form1
    Dim comprobanteMapper As New Comprobante()

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComprobantes()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Agregar.id = 0
        Panel1.Enabled = True
        Panel2.Enabled = True
        Agregar.ShowDialog()
    End Sub

    Public Sub CargarComprobantes()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = comprobanteMapper.GetComprobantes()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        comprobanteMapper.Eliminar(DataGridView1.CurrentRow.Cells("DgvColCodigo").Value)
        CargarComprobantes()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Agregar.id = DataGridView1.CurrentRow.Cells("DgvColCodigo").Value
        Panel1.Enabled = True
        Panel2.Enabled = True
        Agregar.ShowDialog()
    End Sub

    Private Sub BtnConsult_Click(sender As Object, e As EventArgs) Handles BtnConsult.Click
        Agregar.id = DataGridView1.CurrentRow.Cells("DgvColCodigo").Value
        Panel1.Enabled = False
        Panel2.Enabled = False
        Agregar.ShowDialog()
    End Sub
End Class
