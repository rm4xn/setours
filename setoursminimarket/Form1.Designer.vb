<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnConsult = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DgvColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvColSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvColNeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvColIGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvColTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvColTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvColCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvColVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 48)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mantenimiento de comprobantes"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnAgregar)
        Me.Panel2.Controls.Add(Me.BtnConsult)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 395)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 55)
        Me.Panel2.TabIndex = 2
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(12, 14)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(94, 29)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnConsult
        '
        Me.BtnConsult.Location = New System.Drawing.Point(403, 14)
        Me.BtnConsult.Name = "BtnConsult"
        Me.BtnConsult.Size = New System.Drawing.Size(94, 29)
        Me.BtnConsult.TabIndex = 3
        Me.BtnConsult.Text = "Consultar"
        Me.BtnConsult.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(503, 14)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(94, 29)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Editar"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(603, 14)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(94, 29)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "Eliminar"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(703, 14)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(94, 29)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "Salir"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvColCodigo, Me.DgvColSucursal, Me.DgvColNeto, Me.DgvColIGV, Me.DgvColTotal, Me.DgvColTipo, Me.DgvColCliente, Me.DgvColVendedor})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(800, 347)
        Me.DataGridView1.TabIndex = 3
        '
        'DgvColCodigo
        '
        Me.DgvColCodigo.DataPropertyName = "id"
        Me.DgvColCodigo.HeaderText = "Codigo"
        Me.DgvColCodigo.MinimumWidth = 6
        Me.DgvColCodigo.Name = "DgvColCodigo"
        Me.DgvColCodigo.ReadOnly = True
        Me.DgvColCodigo.Width = 125
        '
        'DgvColSucursal
        '
        Me.DgvColSucursal.DataPropertyName = "sucursal"
        Me.DgvColSucursal.HeaderText = "Sucursal"
        Me.DgvColSucursal.MinimumWidth = 6
        Me.DgvColSucursal.Name = "DgvColSucursal"
        Me.DgvColSucursal.ReadOnly = True
        Me.DgvColSucursal.Width = 125
        '
        'DgvColNeto
        '
        Me.DgvColNeto.DataPropertyName = "Neto"
        Me.DgvColNeto.HeaderText = "Neto"
        Me.DgvColNeto.MinimumWidth = 6
        Me.DgvColNeto.Name = "DgvColNeto"
        Me.DgvColNeto.ReadOnly = True
        Me.DgvColNeto.Width = 125
        '
        'DgvColIGV
        '
        Me.DgvColIGV.DataPropertyName = "IGV"
        Me.DgvColIGV.HeaderText = "IGV"
        Me.DgvColIGV.MinimumWidth = 6
        Me.DgvColIGV.Name = "DgvColIGV"
        Me.DgvColIGV.ReadOnly = True
        Me.DgvColIGV.Width = 125
        '
        'DgvColTotal
        '
        Me.DgvColTotal.DataPropertyName = "Total"
        Me.DgvColTotal.HeaderText = "Total"
        Me.DgvColTotal.MinimumWidth = 6
        Me.DgvColTotal.Name = "DgvColTotal"
        Me.DgvColTotal.ReadOnly = True
        Me.DgvColTotal.Width = 125
        '
        'DgvColTipo
        '
        Me.DgvColTipo.DataPropertyName = "tipo"
        Me.DgvColTipo.HeaderText = "Tipo"
        Me.DgvColTipo.MinimumWidth = 6
        Me.DgvColTipo.Name = "DgvColTipo"
        Me.DgvColTipo.ReadOnly = True
        Me.DgvColTipo.Width = 125
        '
        'DgvColCliente
        '
        Me.DgvColCliente.DataPropertyName = "cliente"
        Me.DgvColCliente.HeaderText = "Cliente"
        Me.DgvColCliente.MinimumWidth = 6
        Me.DgvColCliente.Name = "DgvColCliente"
        Me.DgvColCliente.ReadOnly = True
        Me.DgvColCliente.Width = 125
        '
        'DgvColVendedor
        '
        Me.DgvColVendedor.DataPropertyName = "vendedor"
        Me.DgvColVendedor.HeaderText = "Vendedor"
        Me.DgvColVendedor.MinimumWidth = 6
        Me.DgvColVendedor.Name = "DgvColVendedor"
        Me.DgvColVendedor.ReadOnly = True
        Me.DgvColVendedor.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnConsult As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DgvColCodigo As DataGridViewTextBoxColumn
    Friend WithEvents DgvColSucursal As DataGridViewTextBoxColumn
    Friend WithEvents DgvColNeto As DataGridViewTextBoxColumn
    Friend WithEvents DgvColIGV As DataGridViewTextBoxColumn
    Friend WithEvents DgvColTotal As DataGridViewTextBoxColumn
    Friend WithEvents DgvColTipo As DataGridViewTextBoxColumn
    Friend WithEvents DgvColCliente As DataGridViewTextBoxColumn
    Friend WithEvents DgvColVendedor As DataGridViewTextBoxColumn
    Friend WithEvents BtnAgregar As Button
End Class
