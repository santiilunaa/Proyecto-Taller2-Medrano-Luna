<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgvid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.LClientes = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 460)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LBuscar)
        Me.Panel2.Controls.Add(Me.txtBuscar)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.LClientes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 460)
        Me.Panel2.TabIndex = 0
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscar.Location = New System.Drawing.Point(130, 64)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(97, 16)
        Me.LBuscar.TabIndex = 7
        Me.LBuscar.Text = "Buscar Cliente:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(236, 61)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(351, 22)
        Me.txtBuscar.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvid, Me.dgvNombre, Me.dgvApellido, Me.dgvDNI, Me.dgvEmail, Me.dgvTelefono})
        Me.DataGridView1.Location = New System.Drawing.Point(63, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(524, 299)
        Me.DataGridView1.TabIndex = 5
        '
        'dgvid
        '
        Me.dgvid.HeaderText = "id_Cliente"
        Me.dgvid.Name = "dgvid"
        Me.dgvid.Width = 80
        '
        'dgvNombre
        '
        Me.dgvNombre.HeaderText = "Nombre"
        Me.dgvNombre.Name = "dgvNombre"
        Me.dgvNombre.Width = 80
        '
        'dgvApellido
        '
        Me.dgvApellido.HeaderText = "Apellido"
        Me.dgvApellido.Name = "dgvApellido"
        Me.dgvApellido.Width = 80
        '
        'dgvDNI
        '
        Me.dgvDNI.HeaderText = "DNI"
        Me.dgvDNI.Name = "dgvDNI"
        Me.dgvDNI.Width = 80
        '
        'dgvEmail
        '
        Me.dgvEmail.HeaderText = "Email"
        Me.dgvEmail.Name = "dgvEmail"
        Me.dgvEmail.Width = 80
        '
        'dgvTelefono
        '
        Me.dgvTelefono.HeaderText = "Telefono"
        Me.dgvTelefono.Name = "dgvTelefono"
        Me.dgvTelefono.Width = 80
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(623, 148)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(152, 34)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(623, 228)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(152, 34)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(623, 112)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(152, 30)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Cliente"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'LClientes
        '
        Me.LClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LClientes.AutoSize = True
        Me.LClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LClientes.Location = New System.Drawing.Point(345, 21)
        Me.LClientes.Name = "LClientes"
        Me.LClientes.Size = New System.Drawing.Size(131, 37)
        Me.LClientes.TabIndex = 1
        Me.LClientes.Text = "Clientes"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LClientes As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvid As DataGridViewTextBoxColumn
    Friend WithEvents dgvNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvApellido As DataGridViewTextBoxColumn
    Friend WithEvents dgvDNI As DataGridViewTextBoxColumn
    Friend WithEvents dgvEmail As DataGridViewTextBoxColumn
    Friend WithEvents dgvTelefono As DataGridViewTextBoxColumn
End Class
