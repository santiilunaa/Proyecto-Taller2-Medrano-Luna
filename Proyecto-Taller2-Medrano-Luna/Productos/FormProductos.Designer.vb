<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Me.PProductos = New System.Windows.Forms.Panel()
        Me.pnlAgregar = New System.Windows.Forms.Panel()
        Me.CBCateg2 = New System.Windows.Forms.ComboBox()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.txtStockMin = New System.Windows.Forms.TextBox()
        Me.LStockMin = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPrecCos = New System.Windows.Forms.Label()
        Me.LPrecioVen = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LNombrePro = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPVent = New System.Windows.Forms.TextBox()
        Me.txtPCos = New System.Windows.Forms.TextBox()
        Me.btnGuardarP = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.CBCateg = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.LProductos = New System.Windows.Forms.Label()
        Me.pnlModPRo = New System.Windows.Forms.Panel()
        Me.CBCateg3 = New System.Windows.Forms.ComboBox()
        Me.btnLimp2 = New System.Windows.Forms.Button()
        Me.txtStockMin2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStock2 = New System.Windows.Forms.TextBox()
        Me.txtNom2 = New System.Windows.Forms.TextBox()
        Me.txtPVent2 = New System.Windows.Forms.TextBox()
        Me.txtPCos2 = New System.Windows.Forms.TextBox()
        Me.btnGuarMod = New System.Windows.Forms.Button()
        Me.btnCance2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.PProductos.SuspendLayout()
        Me.pnlAgregar.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlModPRo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PProductos
        '
        Me.PProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PProductos.Controls.Add(Me.pnlModPRo)
        Me.PProductos.Controls.Add(Me.pnlAgregar)
        Me.PProductos.Controls.Add(Me.Label2)
        Me.PProductos.Controls.Add(Me.LBuscar)
        Me.PProductos.Controls.Add(Me.CBCateg)
        Me.PProductos.Controls.Add(Me.txtBuscar)
        Me.PProductos.Controls.Add(Me.dgvProductos)
        Me.PProductos.Controls.Add(Me.btnEliminar)
        Me.PProductos.Controls.Add(Me.btnModificar)
        Me.PProductos.Controls.Add(Me.btnAgregar)
        Me.PProductos.Controls.Add(Me.LProductos)
        Me.PProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PProductos.Location = New System.Drawing.Point(0, 0)
        Me.PProductos.Name = "PProductos"
        Me.PProductos.Size = New System.Drawing.Size(800, 460)
        Me.PProductos.TabIndex = 0
        '
        'pnlAgregar
        '
        Me.pnlAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAgregar.Controls.Add(Me.CBCateg2)
        Me.pnlAgregar.Controls.Add(Me.BBorrar)
        Me.pnlAgregar.Controls.Add(Me.txtStockMin)
        Me.pnlAgregar.Controls.Add(Me.LStockMin)
        Me.pnlAgregar.Controls.Add(Me.LStock)
        Me.pnlAgregar.Controls.Add(Me.LPrecCos)
        Me.pnlAgregar.Controls.Add(Me.LPrecioVen)
        Me.pnlAgregar.Controls.Add(Me.LCategoria)
        Me.pnlAgregar.Controls.Add(Me.LNombrePro)
        Me.pnlAgregar.Controls.Add(Me.txtStock)
        Me.pnlAgregar.Controls.Add(Me.txtNom)
        Me.pnlAgregar.Controls.Add(Me.txtPVent)
        Me.pnlAgregar.Controls.Add(Me.txtPCos)
        Me.pnlAgregar.Controls.Add(Me.btnGuardarP)
        Me.pnlAgregar.Controls.Add(Me.btnCancelar)
        Me.pnlAgregar.Controls.Add(Me.Label1)
        Me.pnlAgregar.Location = New System.Drawing.Point(12, 33)
        Me.pnlAgregar.Name = "pnlAgregar"
        Me.pnlAgregar.Size = New System.Drawing.Size(299, 393)
        Me.pnlAgregar.TabIndex = 6
        Me.pnlAgregar.Visible = False
        '
        'CBCateg2
        '
        Me.CBCateg2.FormattingEnabled = True
        Me.CBCateg2.Location = New System.Drawing.Point(137, 132)
        Me.CBCateg2.Name = "CBCateg2"
        Me.CBCateg2.Size = New System.Drawing.Size(101, 21)
        Me.CBCateg2.TabIndex = 20
        '
        'BBorrar
        '
        Me.BBorrar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BBorrar.FlatAppearance.BorderSize = 0
        Me.BBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBorrar.Location = New System.Drawing.Point(112, 347)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BBorrar.TabIndex = 17
        Me.BBorrar.Text = "Borrar"
        Me.BBorrar.UseVisualStyleBackColor = False
        '
        'txtStockMin
        '
        Me.txtStockMin.Location = New System.Drawing.Point(137, 276)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Size = New System.Drawing.Size(100, 20)
        Me.txtStockMin.TabIndex = 16
        '
        'LStockMin
        '
        Me.LStockMin.AutoSize = True
        Me.LStockMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStockMin.Location = New System.Drawing.Point(46, 279)
        Me.LStockMin.Name = "LStockMin"
        Me.LStockMin.Size = New System.Drawing.Size(64, 13)
        Me.LStockMin.TabIndex = 15
        Me.LStockMin.Text = "Stock Min"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.Location = New System.Drawing.Point(46, 242)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(40, 13)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'LPrecCos
        '
        Me.LPrecCos.AutoSize = True
        Me.LPrecCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecCos.Location = New System.Drawing.Point(46, 171)
        Me.LPrecCos.Name = "LPrecCos"
        Me.LPrecCos.Size = New System.Drawing.Size(79, 13)
        Me.LPrecCos.TabIndex = 13
        Me.LPrecCos.Text = "Precio Costo"
        '
        'LPrecioVen
        '
        Me.LPrecioVen.AutoSize = True
        Me.LPrecioVen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecioVen.Location = New System.Drawing.Point(46, 206)
        Me.LPrecioVen.Name = "LPrecioVen"
        Me.LPrecioVen.Size = New System.Drawing.Size(80, 13)
        Me.LPrecioVen.TabIndex = 12
        Me.LPrecioVen.Text = "Precio Venta"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.Location = New System.Drawing.Point(46, 135)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(63, 13)
        Me.LCategoria.TabIndex = 11
        Me.LCategoria.Text = "Categoría"
        '
        'LNombrePro
        '
        Me.LNombrePro.AutoSize = True
        Me.LNombrePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombrePro.Location = New System.Drawing.Point(46, 99)
        Me.LNombrePro.Name = "LNombrePro"
        Me.LNombrePro.Size = New System.Drawing.Size(50, 13)
        Me.LNombrePro.TabIndex = 10
        Me.LNombrePro.Text = "Nombre"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(137, 239)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 9
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(137, 96)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 7
        '
        'txtPVent
        '
        Me.txtPVent.Location = New System.Drawing.Point(137, 203)
        Me.txtPVent.Name = "txtPVent"
        Me.txtPVent.Size = New System.Drawing.Size(100, 20)
        Me.txtPVent.TabIndex = 6
        '
        'txtPCos
        '
        Me.txtPCos.Location = New System.Drawing.Point(137, 168)
        Me.txtPCos.Name = "txtPCos"
        Me.txtPCos.Size = New System.Drawing.Size(100, 20)
        Me.txtPCos.TabIndex = 4
        '
        'btnGuardarP
        '
        Me.btnGuardarP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardarP.FlatAppearance.BorderSize = 0
        Me.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarP.Location = New System.Drawing.Point(21, 347)
        Me.btnGuardarP.Name = "btnGuardarP"
        Me.btnGuardarP.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarP.TabIndex = 1
        Me.btnGuardarP.Text = "Guardar"
        Me.btnGuardarP.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(203, 347)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Agregar Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.Label2.Location = New System.Drawing.Point(381, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Seleccionar Categoria:"
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.LBuscar.Location = New System.Drawing.Point(34, 89)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(118, 15)
        Me.LBuscar.TabIndex = 22
        Me.LBuscar.Text = "Buscar Por Nombre:"
        '
        'CBCateg
        '
        Me.CBCateg.FormattingEnabled = True
        Me.CBCateg.Location = New System.Drawing.Point(518, 87)
        Me.CBCateg.Name = "CBCateg"
        Me.CBCateg.Size = New System.Drawing.Size(142, 21)
        Me.CBCateg.TabIndex = 21
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(158, 86)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(174, 22)
        Me.txtBuscar.TabIndex = 7
        '
        'dgvProductos
        '
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(27, 114)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(571, 329)
        Me.dgvProductos.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(626, 332)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(162, 34)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(626, 266)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(162, 34)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(626, 201)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(162, 34)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Producto"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'LProductos
        '
        Me.LProductos.AutoSize = True
        Me.LProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProductos.Location = New System.Drawing.Point(316, 18)
        Me.LProductos.Name = "LProductos"
        Me.LProductos.Size = New System.Drawing.Size(137, 31)
        Me.LProductos.TabIndex = 0
        Me.LProductos.Text = "Productos"
        '
        'pnlModPRo
        '
        Me.pnlModPRo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlModPRo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlModPRo.Controls.Add(Me.lblId)
        Me.pnlModPRo.Controls.Add(Me.CBCateg3)
        Me.pnlModPRo.Controls.Add(Me.btnLimp2)
        Me.pnlModPRo.Controls.Add(Me.txtStockMin2)
        Me.pnlModPRo.Controls.Add(Me.Label3)
        Me.pnlModPRo.Controls.Add(Me.Label4)
        Me.pnlModPRo.Controls.Add(Me.Label5)
        Me.pnlModPRo.Controls.Add(Me.Label6)
        Me.pnlModPRo.Controls.Add(Me.Label7)
        Me.pnlModPRo.Controls.Add(Me.Label8)
        Me.pnlModPRo.Controls.Add(Me.txtStock2)
        Me.pnlModPRo.Controls.Add(Me.txtNom2)
        Me.pnlModPRo.Controls.Add(Me.txtPVent2)
        Me.pnlModPRo.Controls.Add(Me.txtPCos2)
        Me.pnlModPRo.Controls.Add(Me.btnGuarMod)
        Me.pnlModPRo.Controls.Add(Me.btnCance2)
        Me.pnlModPRo.Controls.Add(Me.Label9)
        Me.pnlModPRo.Location = New System.Drawing.Point(406, 33)
        Me.pnlModPRo.Name = "pnlModPRo"
        Me.pnlModPRo.Size = New System.Drawing.Size(299, 393)
        Me.pnlModPRo.TabIndex = 24
        Me.pnlModPRo.Visible = False
        '
        'CBCateg3
        '
        Me.CBCateg3.FormattingEnabled = True
        Me.CBCateg3.Location = New System.Drawing.Point(137, 132)
        Me.CBCateg3.Name = "CBCateg3"
        Me.CBCateg3.Size = New System.Drawing.Size(101, 21)
        Me.CBCateg3.TabIndex = 20
        '
        'btnLimp2
        '
        Me.btnLimp2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnLimp2.FlatAppearance.BorderSize = 0
        Me.btnLimp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimp2.Location = New System.Drawing.Point(112, 347)
        Me.btnLimp2.Name = "btnLimp2"
        Me.btnLimp2.Size = New System.Drawing.Size(75, 23)
        Me.btnLimp2.TabIndex = 17
        Me.btnLimp2.Text = "Borrar"
        Me.btnLimp2.UseVisualStyleBackColor = False
        '
        'txtStockMin2
        '
        Me.txtStockMin2.Location = New System.Drawing.Point(137, 276)
        Me.txtStockMin2.Name = "txtStockMin2"
        Me.txtStockMin2.Size = New System.Drawing.Size(100, 20)
        Me.txtStockMin2.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Stock Min"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Precio Costo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Precio Venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Categoría"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Nombre"
        '
        'txtStock2
        '
        Me.txtStock2.Location = New System.Drawing.Point(137, 239)
        Me.txtStock2.Name = "txtStock2"
        Me.txtStock2.Size = New System.Drawing.Size(100, 20)
        Me.txtStock2.TabIndex = 9
        '
        'txtNom2
        '
        Me.txtNom2.Location = New System.Drawing.Point(137, 96)
        Me.txtNom2.Name = "txtNom2"
        Me.txtNom2.Size = New System.Drawing.Size(100, 20)
        Me.txtNom2.TabIndex = 7
        '
        'txtPVent2
        '
        Me.txtPVent2.Location = New System.Drawing.Point(137, 203)
        Me.txtPVent2.Name = "txtPVent2"
        Me.txtPVent2.Size = New System.Drawing.Size(100, 20)
        Me.txtPVent2.TabIndex = 6
        '
        'txtPCos2
        '
        Me.txtPCos2.Location = New System.Drawing.Point(137, 168)
        Me.txtPCos2.Name = "txtPCos2"
        Me.txtPCos2.Size = New System.Drawing.Size(100, 20)
        Me.txtPCos2.TabIndex = 4
        '
        'btnGuarMod
        '
        Me.btnGuarMod.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuarMod.FlatAppearance.BorderSize = 0
        Me.btnGuarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuarMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuarMod.Location = New System.Drawing.Point(21, 347)
        Me.btnGuarMod.Name = "btnGuarMod"
        Me.btnGuarMod.Size = New System.Drawing.Size(75, 23)
        Me.btnGuarMod.TabIndex = 1
        Me.btnGuarMod.Text = "Guardar"
        Me.btnGuarMod.UseVisualStyleBackColor = False
        '
        'btnCance2
        '
        Me.btnCance2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCance2.FlatAppearance.BorderSize = 0
        Me.btnCance2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCance2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCance2.Location = New System.Drawing.Point(203, 347)
        Me.btnCance2.Name = "btnCance2"
        Me.btnCance2.Size = New System.Drawing.Size(75, 23)
        Me.btnCance2.TabIndex = 2
        Me.btnCance2.Text = "Cancelar"
        Me.btnCance2.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(66, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 24)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Modificar Producto"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(46, 61)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(50, 13)
        Me.lblId.TabIndex = 21
        Me.lblId.Text = "Nombre"
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.PProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormProductos"
        Me.Text = "Productos"
        Me.PProductos.ResumeLayout(False)
        Me.PProductos.PerformLayout()
        Me.pnlAgregar.ResumeLayout(False)
        Me.pnlAgregar.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlModPRo.ResumeLayout(False)
        Me.pnlModPRo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PProductos As Panel
    Friend WithEvents LProductos As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents pnlAgregar As Panel
    Friend WithEvents LStock As Label
    Friend WithEvents LPrecCos As Label
    Friend WithEvents LPrecioVen As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents LNombrePro As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPVent As TextBox
    Friend WithEvents txtPCos As TextBox
    Friend WithEvents btnGuardarP As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStockMin As TextBox
    Friend WithEvents LStockMin As Label
    Friend WithEvents BBorrar As Button
    Friend WithEvents CBCateg2 As ComboBox
    Friend WithEvents CBCateg As ComboBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LBuscar As Label
    Friend WithEvents pnlModPRo As Panel
    Friend WithEvents CBCateg3 As ComboBox
    Friend WithEvents btnLimp2 As Button
    Friend WithEvents txtStockMin2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStock2 As TextBox
    Friend WithEvents txtNom2 As TextBox
    Friend WithEvents txtPVent2 As TextBox
    Friend WithEvents txtPCos2 As TextBox
    Friend WithEvents btnGuarMod As Button
    Friend WithEvents btnCance2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblId As Label
End Class
