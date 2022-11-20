<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PFactura = New System.Windows.Forms.Panel()
        Me.LSubTot = New System.Windows.Forms.Label()
        Me.BCancel = New System.Windows.Forms.Button()
        Me.BEliminProd = New System.Windows.Forms.Button()
        Me.LTitDetalle = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.LBSubTot = New System.Windows.Forms.Label()
        Me.dgvFact = New System.Windows.Forms.DataGridView()
        Me.BConfir = New System.Windows.Forms.Button()
        Me.PProducto = New System.Windows.Forms.Panel()
        Me.BSumar = New System.Windows.Forms.Button()
        Me.BRestar = New System.Windows.Forms.Button()
        Me.LID = New System.Windows.Forms.Label()
        Me.LBID = New System.Windows.Forms.Label()
        Me.txtNomProd = New System.Windows.Forms.TextBox()
        Me.LPrecioCant = New System.Windows.Forms.Label()
        Me.LPrecioUnit = New System.Windows.Forms.Label()
        Me.LCant = New System.Windows.Forms.Label()
        Me.LDescr = New System.Windows.Forms.Label()
        Me.LBPrecioCant = New System.Windows.Forms.Label()
        Me.LBPrecio = New System.Windows.Forms.Label()
        Me.LAgregarProd = New System.Windows.Forms.Label()
        Me.LBDescrip = New System.Windows.Forms.Label()
        Me.LBCant = New System.Windows.Forms.Label()
        Me.btnGuardarPro = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LBVendedor = New System.Windows.Forms.Label()
        Me.LBFecha = New System.Windows.Forms.Label()
        Me.LFactura = New System.Windows.Forms.Label()
        Me.LBCliente = New System.Windows.Forms.Label()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.PFactura.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PProducto.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PFactura
        '
        Me.PFactura.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PFactura.Controls.Add(Me.LSubTot)
        Me.PFactura.Controls.Add(Me.BCancel)
        Me.PFactura.Controls.Add(Me.BEliminProd)
        Me.PFactura.Controls.Add(Me.LTitDetalle)
        Me.PFactura.Controls.Add(Me.dgvDetalle)
        Me.PFactura.Controls.Add(Me.LBSubTot)
        Me.PFactura.Controls.Add(Me.dgvFact)
        Me.PFactura.Controls.Add(Me.BConfir)
        Me.PFactura.Controls.Add(Me.PProducto)
        Me.PFactura.Controls.Add(Me.Panel2)
        Me.PFactura.Controls.Add(Me.LFactura)
        Me.PFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PFactura.Location = New System.Drawing.Point(0, 0)
        Me.PFactura.Name = "PFactura"
        Me.PFactura.Size = New System.Drawing.Size(874, 556)
        Me.PFactura.TabIndex = 0
        '
        'LSubTot
        '
        Me.LSubTot.AutoSize = True
        Me.LSubTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LSubTot.Location = New System.Drawing.Point(461, 523)
        Me.LSubTot.Name = "LSubTot"
        Me.LSubTot.Size = New System.Drawing.Size(17, 18)
        Me.LSubTot.TabIndex = 38
        Me.LSubTot.Text = "0"
        '
        'BCancel
        '
        Me.BCancel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BCancel.FlatAppearance.BorderSize = 0
        Me.BCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancel.Location = New System.Drawing.Point(740, 521)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(75, 23)
        Me.BCancel.TabIndex = 25
        Me.BCancel.Text = "Cancelar"
        Me.BCancel.UseVisualStyleBackColor = False
        '
        'BEliminProd
        '
        Me.BEliminProd.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BEliminProd.FlatAppearance.BorderSize = 0
        Me.BEliminProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminProd.Location = New System.Drawing.Point(297, 465)
        Me.BEliminProd.Name = "BEliminProd"
        Me.BEliminProd.Size = New System.Drawing.Size(215, 27)
        Me.BEliminProd.TabIndex = 24
        Me.BEliminProd.Text = "Eliminar Producto Seleccionado"
        Me.BEliminProd.UseVisualStyleBackColor = False
        '
        'LTitDetalle
        '
        Me.LTitDetalle.AutoSize = True
        Me.LTitDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitDetalle.Location = New System.Drawing.Point(274, 255)
        Me.LTitDetalle.Name = "LTitDetalle"
        Me.LTitDetalle.Size = New System.Drawing.Size(57, 15)
        Me.LTitDetalle.TabIndex = 24
        Me.LTitDetalle.Text = "Detalle:"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AllowUserToResizeRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(239, 273)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.Size = New System.Drawing.Size(623, 180)
        Me.dgvDetalle.TabIndex = 23
        '
        'LBSubTot
        '
        Me.LBSubTot.AutoSize = True
        Me.LBSubTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LBSubTot.Location = New System.Drawing.Point(351, 523)
        Me.LBSubTot.Name = "LBSubTot"
        Me.LBSubTot.Size = New System.Drawing.Size(89, 18)
        Me.LBSubTot.TabIndex = 22
        Me.LBSubTot.Text = "Subtotal: $"
        '
        'dgvFact
        '
        Me.dgvFact.AllowUserToAddRows = False
        Me.dgvFact.AllowUserToOrderColumns = True
        Me.dgvFact.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.dgvFact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFact.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFact.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvFact.Location = New System.Drawing.Point(239, 73)
        Me.dgvFact.MultiSelect = False
        Me.dgvFact.Name = "dgvFact"
        Me.dgvFact.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvFact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFact.Size = New System.Drawing.Size(623, 163)
        Me.dgvFact.TabIndex = 11
        '
        'BConfir
        '
        Me.BConfir.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BConfir.FlatAppearance.BorderSize = 0
        Me.BConfir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BConfir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BConfir.Location = New System.Drawing.Point(648, 521)
        Me.BConfir.Name = "BConfir"
        Me.BConfir.Size = New System.Drawing.Size(75, 23)
        Me.BConfir.TabIndex = 10
        Me.BConfir.Text = "Confirmar"
        Me.BConfir.UseVisualStyleBackColor = False
        '
        'PProducto
        '
        Me.PProducto.Controls.Add(Me.BSumar)
        Me.PProducto.Controls.Add(Me.BRestar)
        Me.PProducto.Controls.Add(Me.LID)
        Me.PProducto.Controls.Add(Me.LBID)
        Me.PProducto.Controls.Add(Me.txtNomProd)
        Me.PProducto.Controls.Add(Me.LPrecioCant)
        Me.PProducto.Controls.Add(Me.LPrecioUnit)
        Me.PProducto.Controls.Add(Me.LCant)
        Me.PProducto.Controls.Add(Me.LDescr)
        Me.PProducto.Controls.Add(Me.LBPrecioCant)
        Me.PProducto.Controls.Add(Me.LBPrecio)
        Me.PProducto.Controls.Add(Me.LAgregarProd)
        Me.PProducto.Controls.Add(Me.LBDescrip)
        Me.PProducto.Controls.Add(Me.LBCant)
        Me.PProducto.Controls.Add(Me.btnGuardarPro)
        Me.PProducto.Location = New System.Drawing.Point(3, 139)
        Me.PProducto.Name = "PProducto"
        Me.PProducto.Size = New System.Drawing.Size(217, 245)
        Me.PProducto.TabIndex = 5
        '
        'BSumar
        '
        Me.BSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSumar.Location = New System.Drawing.Point(100, 163)
        Me.BSumar.Name = "BSumar"
        Me.BSumar.Size = New System.Drawing.Size(29, 29)
        Me.BSumar.TabIndex = 36
        Me.BSumar.Text = "+"
        Me.BSumar.UseVisualStyleBackColor = True
        '
        'BRestar
        '
        Me.BRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRestar.Location = New System.Drawing.Point(148, 163)
        Me.BRestar.Name = "BRestar"
        Me.BRestar.Size = New System.Drawing.Size(28, 29)
        Me.BRestar.TabIndex = 35
        Me.BRestar.Text = "-"
        Me.BRestar.UseVisualStyleBackColor = True
        '
        'LID
        '
        Me.LID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LID.AutoSize = True
        Me.LID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LID.Location = New System.Drawing.Point(87, 68)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(14, 13)
        Me.LID.TabIndex = 34
        Me.LID.Text = "0"
        '
        'LBID
        '
        Me.LBID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LBID.AutoSize = True
        Me.LBID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBID.Location = New System.Drawing.Point(4, 68)
        Me.LBID.Name = "LBID"
        Me.LBID.Size = New System.Drawing.Size(79, 13)
        Me.LBID.TabIndex = 33
        Me.LBID.Text = "ID Producto:"
        '
        'txtNomProd
        '
        Me.txtNomProd.Location = New System.Drawing.Point(115, 25)
        Me.txtNomProd.Name = "txtNomProd"
        Me.txtNomProd.Size = New System.Drawing.Size(79, 20)
        Me.txtNomProd.TabIndex = 32
        '
        'LPrecioCant
        '
        Me.LPrecioCant.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LPrecioCant.AutoSize = True
        Me.LPrecioCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecioCant.Location = New System.Drawing.Point(116, 134)
        Me.LPrecioCant.Name = "LPrecioCant"
        Me.LPrecioCant.Size = New System.Drawing.Size(14, 13)
        Me.LPrecioCant.TabIndex = 31
        Me.LPrecioCant.Text = "0"
        '
        'LPrecioUnit
        '
        Me.LPrecioUnit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LPrecioUnit.AutoSize = True
        Me.LPrecioUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecioUnit.Location = New System.Drawing.Point(116, 109)
        Me.LPrecioUnit.Name = "LPrecioUnit"
        Me.LPrecioUnit.Size = New System.Drawing.Size(14, 13)
        Me.LPrecioUnit.TabIndex = 30
        Me.LPrecioUnit.Text = "0"
        '
        'LCant
        '
        Me.LCant.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LCant.AutoSize = True
        Me.LCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCant.Location = New System.Drawing.Point(67, 172)
        Me.LCant.Name = "LCant"
        Me.LCant.Size = New System.Drawing.Size(14, 13)
        Me.LCant.TabIndex = 29
        Me.LCant.Text = "0"
        '
        'LDescr
        '
        Me.LDescr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LDescr.AutoSize = True
        Me.LDescr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescr.Location = New System.Drawing.Point(64, 90)
        Me.LDescr.Name = "LDescr"
        Me.LDescr.Size = New System.Drawing.Size(72, 13)
        Me.LDescr.TabIndex = 28
        Me.LDescr.Text = "descripcion"
        '
        'LBPrecioCant
        '
        Me.LBPrecioCant.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LBPrecioCant.AutoSize = True
        Me.LBPrecioCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPrecioCant.Location = New System.Drawing.Point(4, 134)
        Me.LBPrecioCant.Name = "LBPrecioCant"
        Me.LBPrecioCant.Size = New System.Drawing.Size(112, 13)
        Me.LBPrecioCant.TabIndex = 27
        Me.LBPrecioCant.Text = "Precio Cantidad: $"
        '
        'LBPrecio
        '
        Me.LBPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LBPrecio.AutoSize = True
        Me.LBPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPrecio.Location = New System.Drawing.Point(4, 109)
        Me.LBPrecio.Name = "LBPrecio"
        Me.LBPrecio.Size = New System.Drawing.Size(106, 13)
        Me.LBPrecio.TabIndex = 26
        Me.LBPrecio.Text = "Precio Unitario: $"
        '
        'LAgregarProd
        '
        Me.LAgregarProd.AutoSize = True
        Me.LAgregarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAgregarProd.Location = New System.Drawing.Point(0, 28)
        Me.LAgregarProd.Name = "LAgregarProd"
        Me.LAgregarProd.Size = New System.Drawing.Size(109, 13)
        Me.LAgregarProd.TabIndex = 24
        Me.LAgregarProd.Text = "Nombre Producto:"
        '
        'LBDescrip
        '
        Me.LBDescrip.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LBDescrip.AutoSize = True
        Me.LBDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBDescrip.Location = New System.Drawing.Point(4, 90)
        Me.LBDescrip.Name = "LBDescrip"
        Me.LBDescrip.Size = New System.Drawing.Size(54, 13)
        Me.LBDescrip.TabIndex = 14
        Me.LBDescrip.Text = "Nombre:"
        '
        'LBCant
        '
        Me.LBCant.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LBCant.AutoSize = True
        Me.LBCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCant.Location = New System.Drawing.Point(4, 172)
        Me.LBCant.Name = "LBCant"
        Me.LBCant.Size = New System.Drawing.Size(61, 13)
        Me.LBCant.TabIndex = 13
        Me.LBCant.Text = "Cantidad:"
        '
        'btnGuardarPro
        '
        Me.btnGuardarPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarPro.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardarPro.FlatAppearance.BorderSize = 0
        Me.btnGuardarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPro.Location = New System.Drawing.Point(13, 208)
        Me.btnGuardarPro.Name = "btnGuardarPro"
        Me.btnGuardarPro.Size = New System.Drawing.Size(115, 23)
        Me.btnGuardarPro.TabIndex = 7
        Me.btnGuardarPro.Text = "Agregar Producto"
        Me.btnGuardarPro.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LCliente)
        Me.Panel2.Controls.Add(Me.LVendedor)
        Me.Panel2.Controls.Add(Me.LFecha)
        Me.Panel2.Controls.Add(Me.LBVendedor)
        Me.Panel2.Controls.Add(Me.LBCliente)
        Me.Panel2.Controls.Add(Me.LBFecha)
        Me.Panel2.Location = New System.Drawing.Point(262, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 35)
        Me.Panel2.TabIndex = 4
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendedor.Location = New System.Drawing.Point(247, 12)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(60, 13)
        Me.LVendedor.TabIndex = 23
        Me.LVendedor.Text = "vendedor"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.Location = New System.Drawing.Point(55, 12)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(39, 13)
        Me.LFecha.TabIndex = 22
        Me.LFecha.Text = "fecha"
        '
        'LBVendedor
        '
        Me.LBVendedor.AutoSize = True
        Me.LBVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBVendedor.Location = New System.Drawing.Point(176, 12)
        Me.LBVendedor.Name = "LBVendedor"
        Me.LBVendedor.Size = New System.Drawing.Size(65, 13)
        Me.LBVendedor.TabIndex = 1
        Me.LBVendedor.Text = "Vendedor:"
        '
        'LBFecha
        '
        Me.LBFecha.AutoSize = True
        Me.LBFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFecha.Location = New System.Drawing.Point(3, 12)
        Me.LBFecha.Name = "LBFecha"
        Me.LBFecha.Size = New System.Drawing.Size(46, 13)
        Me.LBFecha.TabIndex = 0
        Me.LBFecha.Text = "Fecha:"
        '
        'LFactura
        '
        Me.LFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LFactura.AutoSize = True
        Me.LFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFactura.Location = New System.Drawing.Point(42, 9)
        Me.LFactura.Name = "LFactura"
        Me.LFactura.Size = New System.Drawing.Size(107, 31)
        Me.LFactura.TabIndex = 3
        Me.LFactura.Text = "Factura"
        '
        'LBCliente
        '
        Me.LBCliente.AutoSize = True
        Me.LBCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBCliente.Location = New System.Drawing.Point(419, 12)
        Me.LBCliente.Name = "LBCliente"
        Me.LBCliente.Size = New System.Drawing.Size(50, 13)
        Me.LBCliente.TabIndex = 21
        Me.LBCliente.Text = "Cliente:"
        '
        'LCliente
        '
        Me.LCliente.AutoSize = True
        Me.LCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCliente.Location = New System.Drawing.Point(475, 12)
        Me.LCliente.Name = "LCliente"
        Me.LCliente.Size = New System.Drawing.Size(45, 13)
        Me.LCliente.TabIndex = 24
        Me.LCliente.Text = "cliente"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 556)
        Me.Controls.Add(Me.PFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.PFactura.ResumeLayout(False)
        Me.PFactura.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PProducto.ResumeLayout(False)
        Me.PProducto.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PFactura As Panel
    Friend WithEvents LFactura As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBVendedor As Label
    Friend WithEvents LBFecha As Label
    Friend WithEvents BConfir As Button
    Friend WithEvents PProducto As Panel
    Friend WithEvents btnGuardarPro As Button
    Friend WithEvents LBDescrip As Label
    Friend WithEvents LBCant As Label
    Friend WithEvents LBSubTot As Label
    Friend WithEvents dgvFact As DataGridView
    Friend WithEvents LAgregarProd As Label
    Friend WithEvents LBPrecio As Label
    Friend WithEvents BEliminProd As Button
    Friend WithEvents LTitDetalle As Label
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents LBPrecioCant As Label
    Friend WithEvents LPrecioCant As Label
    Friend WithEvents LPrecioUnit As Label
    Friend WithEvents LCant As Label
    Friend WithEvents LDescr As Label
    Friend WithEvents txtNomProd As TextBox
    Friend WithEvents BCancel As Button
    Friend WithEvents LSubTot As Label
    Friend WithEvents LVendedor As Label
    Friend WithEvents LID As Label
    Friend WithEvents LBID As Label
    Friend WithEvents BSumar As Button
    Friend WithEvents BRestar As Button
    Friend WithEvents LFecha As Label
    Friend WithEvents LCliente As Label
    Friend WithEvents LBCliente As Label
End Class
