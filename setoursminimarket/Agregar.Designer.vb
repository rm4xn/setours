<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtIgv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CboVendedor = New System.Windows.Forms.ComboBox()
        Me.CboSucursal = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboCliente = New System.Windows.Forms.ComboBox()
        Me.CboTipo = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNeto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DgvColProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvColPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvColCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.Location = New System.Drawing.Point(427, 51)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(125, 27)
        Me.TxtTotal.TabIndex = 1
        '
        'TxtIgv
        '
        Me.TxtIgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIgv.Location = New System.Drawing.Point(248, 51)
        Me.TxtIgv.Name = "TxtIgv"
        Me.TxtIgv.Size = New System.Drawing.Size(125, 27)
        Me.TxtIgv.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(379, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "IGV"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CboVendedor)
        Me.Panel1.Controls.Add(Me.CboSucursal)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CboCliente)
        Me.Panel1.Controls.Add(Me.CboTipo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 147)
        Me.Panel1.TabIndex = 22
        '
        'CboVendedor
        '
        Me.CboVendedor.FormattingEnabled = True
        Me.CboVendedor.Location = New System.Drawing.Point(112, 79)
        Me.CboVendedor.Name = "CboVendedor"
        Me.CboVendedor.Size = New System.Drawing.Size(151, 28)
        Me.CboVendedor.TabIndex = 29
        '
        'CboSucursal
        '
        Me.CboSucursal.FormattingEnabled = True
        Me.CboSucursal.Location = New System.Drawing.Point(112, 113)
        Me.CboSucursal.Name = "CboSucursal"
        Me.CboSucursal.Size = New System.Drawing.Size(151, 28)
        Me.CboSucursal.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Vendedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Sucursal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tipo"
        '
        'CboCliente
        '
        Me.CboCliente.FormattingEnabled = True
        Me.CboCliente.Location = New System.Drawing.Point(112, 46)
        Me.CboCliente.Name = "CboCliente"
        Me.CboCliente.Size = New System.Drawing.Size(151, 28)
        Me.CboCliente.TabIndex = 23
        '
        'CboTipo
        '
        Me.CboTipo.FormattingEnabled = True
        Me.CboTipo.Location = New System.Drawing.Point(112, 12)
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.Size = New System.Drawing.Size(151, 28)
        Me.CboTipo.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtNeto)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TxtTotal)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxtIgv)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 488)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 125)
        Me.Panel2.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Neto"
        '
        'TxtNeto
        '
        Me.TxtNeto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNeto.Location = New System.Drawing.Point(79, 51)
        Me.TxtNeto.Name = "TxtNeto"
        Me.TxtNeto.Size = New System.Drawing.Size(125, 27)
        Me.TxtNeto.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(458, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Grabar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvColProducto, Me.DgvColPrecio, Me.DgvColCantidad})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(568, 341)
        Me.DataGridView1.TabIndex = 25
        '
        'DgvColProducto
        '
        Me.DgvColProducto.HeaderText = "Producto"
        Me.DgvColProducto.MinimumWidth = 6
        Me.DgvColProducto.Name = "DgvColProducto"
        Me.DgvColProducto.Width = 125
        '
        'DgvColPrecio
        '
        Me.DgvColPrecio.HeaderText = "Precio"
        Me.DgvColPrecio.MinimumWidth = 6
        Me.DgvColPrecio.Name = "DgvColPrecio"
        Me.DgvColPrecio.Width = 125
        '
        'DgvColCantidad
        '
        Me.DgvColCantidad.HeaderText = "Cantidad"
        Me.DgvColCantidad.MinimumWidth = 6
        Me.DgvColCantidad.Name = "DgvColCantidad"
        Me.DgvColCantidad.Width = 125
        '
        'Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 613)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Agregar"
        Me.Text = "Agregar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtIgv As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CboVendedor As ComboBox
    Friend WithEvents CboSucursal As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CboCliente As ComboBox
    Friend WithEvents CboTipo As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DgvColProducto As DataGridViewTextBoxColumn
    Friend WithEvents DgvColPrecio As DataGridViewTextBoxColumn
    Friend WithEvents DgvColCantidad As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNeto As TextBox
End Class
