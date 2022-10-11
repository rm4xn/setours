Public Class Agregar

    Public id As Integer = 0

    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tipoDeComprobante As New TipoDeComprobante
        Dim cliente As New Cliente
        Dim vendedor As New Vendedor
        Dim sucursal As New Sucursal

        LlenarComboBox(CboTipo, tipoDeComprobante.GetAll(), "codigo", "descripcion")
        LlenarComboBox(CboCliente, cliente.GetAll(), "docIdentidad", "nombreCompleto")
        LlenarComboBox(CboVendedor, vendedor.GetVendedores(), "docIdentidad", "nombreCompleto")
        LlenarComboBox(CboSucursal, sucursal.GetCodigos(), "codigo", "codigo")

        If id = 0 Then Exit Sub

        Dim comprobanteMapper As New Comprobante()
        Dim comprobante = comprobanteMapper.GetComprobante(id)
        CboTipo.SelectedValue = comprobante.Rows(0).Item("tipo").ToString
        CboCliente.SelectedValue = comprobante.Rows(0).Item("cliente").ToString()
        CboVendedor.SelectedValue = comprobante.Rows(0).Item("vendedor").ToString
        CboSucursal.SelectedValue = comprobante.Rows(0).Item("sucursal").ToString
        TxtNeto.Text = comprobante.Rows(0).Item("Neto").ToString
        TxtIgv.Text = comprobante.Rows(0).Item("IGV").ToString
        TxtTotal.Text = comprobante.Rows(0).Item("Total").ToString
    End Sub

    Private Sub LlenarComboBox(ByRef cbo As ComboBox, dt As DataTable, valor As String, texto As String)
        cbo.DataSource = dt
        cbo.DisplayMember = texto
        cbo.ValueMember = valor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comprobante As New Comprobante

        If id = 0 Then
            comprobante.Insertar(
                CboTipo.SelectedValue,
                CboCliente.SelectedValue,
                CboVendedor.SelectedValue,
                CboSucursal.SelectedValue,
                TxtNeto.Text,
                TxtIgv.Text,
                TxtTotal.Text
            )
        Else
            comprobante.Editar(
                id,
                CboTipo.SelectedValue,
                CboCliente.SelectedValue,
                CboVendedor.SelectedValue,
                CboSucursal.SelectedValue,
                TxtNeto.Text,
                TxtIgv.Text,
                TxtTotal.Text
            )
        End If

        ' Insertar detalles

        'Dim detalleDeComprobante As New DetalleDeComprobante

        Form1.CargarComprobantes()
        Close()
    End Sub
End Class