<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.LProductos = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgvIdProdu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.LProductos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 396)
        Me.Panel1.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(159, 315)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(162, 34)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(403, 315)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(162, 34)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(486, 64)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(162, 34)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Producto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'LProductos
        '
        Me.LProductos.AutoSize = True
        Me.LProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProductos.Location = New System.Drawing.Point(289, 18)
        Me.LProductos.Name = "LProductos"
        Me.LProductos.Size = New System.Drawing.Size(137, 31)
        Me.LProductos.TabIndex = 0
        Me.LProductos.Text = "Productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvIdProdu, Me.dgvNombre, Me.dgvCategoria, Me.dgvPrecioVenta, Me.dgvPrecioCompra, Me.dgvStock})
        Me.DataGridView1.Location = New System.Drawing.Point(98, 125)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(519, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'dgvIdProdu
        '
        Me.dgvIdProdu.HeaderText = "id_producto"
        Me.dgvIdProdu.Name = "dgvIdProdu"
        Me.dgvIdProdu.Width = 80
        '
        'dgvNombre
        '
        Me.dgvNombre.HeaderText = "Nombre"
        Me.dgvNombre.Name = "dgvNombre"
        Me.dgvNombre.Width = 80
        '
        'dgvCategoria
        '
        Me.dgvCategoria.HeaderText = "Categoria"
        Me.dgvCategoria.Name = "dgvCategoria"
        Me.dgvCategoria.Width = 80
        '
        'dgvPrecioVenta
        '
        Me.dgvPrecioVenta.HeaderText = "Precio_Venta"
        Me.dgvPrecioVenta.Name = "dgvPrecioVenta"
        Me.dgvPrecioVenta.Width = 80
        '
        'dgvPrecioCompra
        '
        Me.dgvPrecioCompra.HeaderText = "Precio_Compra"
        Me.dgvPrecioCompra.Name = "dgvPrecioCompra"
        Me.dgvPrecioCompra.Width = 80
        '
        'dgvStock
        '
        Me.dgvStock.HeaderText = "Stock"
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.Width = 80
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 396)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LProductos As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgvIdProdu As DataGridViewTextBoxColumn
    Friend WithEvents dgvNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvCategoria As DataGridViewTextBoxColumn
    Friend WithEvents dgvPrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents dgvPrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents dgvStock As DataGridViewTextBoxColumn
End Class
