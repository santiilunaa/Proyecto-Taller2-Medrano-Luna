<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.lvlidsel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelef2 = New System.Windows.Forms.TextBox()
        Me.txtDomic2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.txtNom2 = New System.Windows.Forms.TextBox()
        Me.txtDni2 = New System.Windows.Forms.TextBox()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.btnGuarMod = New System.Windows.Forms.Button()
        Me.btnCanceMod = New System.Windows.Forms.Button()
        Me.pnlModCli = New System.Windows.Forms.Label()
        Me.pnlAgregar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelef = New System.Windows.Forms.TextBox()
        Me.txtDomic = New System.Windows.Forms.TextBox()
        Me.LStockMin = New System.Windows.Forms.Label()
        Me.LStock = New System.Windows.Forms.Label()
        Me.LPrecCos = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.btnGuardarC = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.LAgreClien = New System.Windows.Forms.Label()
        Me.LBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.LClientes = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.rbActivos = New System.Windows.Forms.RadioButton()
        Me.rbElimin = New System.Windows.Forms.RadioButton()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlAgregar.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.btnActivar)
        Me.Panel2.Controls.Add(Me.lvlidsel)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.pnlAgregar)
        Me.Panel2.Controls.Add(Me.LBuscar)
        Me.Panel2.Controls.Add(Me.txtBuscar)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.LClientes)
        Me.Panel2.Controls.Add(Me.dgvClientes)
        Me.Panel2.Controls.Add(Me.rbActivos)
        Me.Panel2.Controls.Add(Me.rbElimin)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 460)
        Me.Panel2.TabIndex = 0
        '
        'btnActivar
        '
        Me.btnActivar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnActivar.FlatAppearance.BorderSize = 0
        Me.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivar.Location = New System.Drawing.Point(636, 291)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(152, 34)
        Me.btnActivar.TabIndex = 22
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseVisualStyleBackColor = False
        '
        'lvlidsel
        '
        Me.lvlidsel.AutoSize = True
        Me.lvlidsel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlidsel.Location = New System.Drawing.Point(632, 31)
        Me.lvlidsel.Name = "lvlidsel"
        Me.lvlidsel.Size = New System.Drawing.Size(25, 24)
        Me.lvlidsel.TabIndex = 21
        Me.lvlidsel.Text = "id"
        Me.lvlidsel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtTelef2)
        Me.Panel1.Controls.Add(Me.txtDomic2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtEmail2)
        Me.Panel1.Controls.Add(Me.txtNom2)
        Me.Panel1.Controls.Add(Me.txtDni2)
        Me.Panel1.Controls.Add(Me.txtApe2)
        Me.Panel1.Controls.Add(Me.btnGuarMod)
        Me.Panel1.Controls.Add(Me.btnCanceMod)
        Me.Panel1.Controls.Add(Me.pnlModCli)
        Me.Panel1.Location = New System.Drawing.Point(317, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 413)
        Me.Panel1.TabIndex = 9
        Me.Panel1.Visible = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(46, 59)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(17, 13)
        Me.lblId.TabIndex = 18
        Me.lblId.Text = "id"
        Me.lblId.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Telefono"
        '
        'txtTelef2
        '
        Me.txtTelef2.Location = New System.Drawing.Point(137, 293)
        Me.txtTelef2.Name = "txtTelef2"
        Me.txtTelef2.Size = New System.Drawing.Size(100, 20)
        Me.txtTelef2.TabIndex = 17
        '
        'txtDomic2
        '
        Me.txtDomic2.Location = New System.Drawing.Point(137, 257)
        Me.txtDomic2.Name = "txtDomic2"
        Me.txtDomic2.Size = New System.Drawing.Size(100, 20)
        Me.txtDomic2.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "DNI"
        '
        'txtEmail2
        '
        Me.txtEmail2.Location = New System.Drawing.Point(137, 220)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail2.TabIndex = 9
        '
        'txtNom2
        '
        Me.txtNom2.Location = New System.Drawing.Point(137, 149)
        Me.txtNom2.Name = "txtNom2"
        Me.txtNom2.Size = New System.Drawing.Size(100, 20)
        Me.txtNom2.TabIndex = 8
        '
        'txtDni2
        '
        Me.txtDni2.Location = New System.Drawing.Point(137, 113)
        Me.txtDni2.Name = "txtDni2"
        Me.txtDni2.Size = New System.Drawing.Size(100, 20)
        Me.txtDni2.TabIndex = 7
        '
        'txtApe2
        '
        Me.txtApe2.Location = New System.Drawing.Point(137, 184)
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.Size = New System.Drawing.Size(100, 20)
        Me.txtApe2.TabIndex = 4
        '
        'btnGuarMod
        '
        Me.btnGuarMod.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuarMod.FlatAppearance.BorderSize = 0
        Me.btnGuarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuarMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuarMod.Location = New System.Drawing.Point(40, 366)
        Me.btnGuarMod.Name = "btnGuarMod"
        Me.btnGuarMod.Size = New System.Drawing.Size(75, 23)
        Me.btnGuarMod.TabIndex = 1
        Me.btnGuarMod.Text = "Guardar"
        Me.btnGuarMod.UseVisualStyleBackColor = False
        '
        'btnCanceMod
        '
        Me.btnCanceMod.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCanceMod.FlatAppearance.BorderSize = 0
        Me.btnCanceMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanceMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCanceMod.Location = New System.Drawing.Point(182, 366)
        Me.btnCanceMod.Name = "btnCanceMod"
        Me.btnCanceMod.Size = New System.Drawing.Size(75, 23)
        Me.btnCanceMod.TabIndex = 2
        Me.btnCanceMod.Text = "Cancelar"
        Me.btnCanceMod.UseVisualStyleBackColor = False
        '
        'pnlModCli
        '
        Me.pnlModCli.AutoSize = True
        Me.pnlModCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlModCli.Location = New System.Drawing.Point(78, 23)
        Me.pnlModCli.Name = "pnlModCli"
        Me.pnlModCli.Size = New System.Drawing.Size(149, 24)
        Me.pnlModCli.TabIndex = 3
        Me.pnlModCli.Text = "Modificar Cliente"
        '
        'pnlAgregar
        '
        Me.pnlAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAgregar.Controls.Add(Me.Label1)
        Me.pnlAgregar.Controls.Add(Me.txtTelef)
        Me.pnlAgregar.Controls.Add(Me.txtDomic)
        Me.pnlAgregar.Controls.Add(Me.LStockMin)
        Me.pnlAgregar.Controls.Add(Me.LStock)
        Me.pnlAgregar.Controls.Add(Me.LPrecCos)
        Me.pnlAgregar.Controls.Add(Me.LCategoria)
        Me.pnlAgregar.Controls.Add(Me.LDni)
        Me.pnlAgregar.Controls.Add(Me.txtEmail)
        Me.pnlAgregar.Controls.Add(Me.txtNom)
        Me.pnlAgregar.Controls.Add(Me.txtDni)
        Me.pnlAgregar.Controls.Add(Me.txtApe)
        Me.pnlAgregar.Controls.Add(Me.btnGuardarC)
        Me.pnlAgregar.Controls.Add(Me.btnCancelar)
        Me.pnlAgregar.Controls.Add(Me.LAgreClien)
        Me.pnlAgregar.Location = New System.Drawing.Point(12, 15)
        Me.pnlAgregar.Name = "pnlAgregar"
        Me.pnlAgregar.Size = New System.Drawing.Size(299, 413)
        Me.pnlAgregar.TabIndex = 8
        Me.pnlAgregar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Telefono"
        '
        'txtTelef
        '
        Me.txtTelef.Location = New System.Drawing.Point(137, 293)
        Me.txtTelef.Name = "txtTelef"
        Me.txtTelef.Size = New System.Drawing.Size(100, 20)
        Me.txtTelef.TabIndex = 17
        '
        'txtDomic
        '
        Me.txtDomic.Location = New System.Drawing.Point(137, 257)
        Me.txtDomic.Name = "txtDomic"
        Me.txtDomic.Size = New System.Drawing.Size(100, 20)
        Me.txtDomic.TabIndex = 16
        '
        'LStockMin
        '
        Me.LStockMin.AutoSize = True
        Me.LStockMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStockMin.Location = New System.Drawing.Point(46, 260)
        Me.LStockMin.Name = "LStockMin"
        Me.LStockMin.Size = New System.Drawing.Size(58, 13)
        Me.LStockMin.TabIndex = 15
        Me.LStockMin.Text = "Domicilio"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.Location = New System.Drawing.Point(46, 223)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(37, 13)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Email"
        '
        'LPrecCos
        '
        Me.LPrecCos.AutoSize = True
        Me.LPrecCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrecCos.Location = New System.Drawing.Point(46, 187)
        Me.LPrecCos.Name = "LPrecCos"
        Me.LPrecCos.Size = New System.Drawing.Size(52, 13)
        Me.LPrecCos.TabIndex = 13
        Me.LPrecCos.Text = "Apellido"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.Location = New System.Drawing.Point(46, 152)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(50, 13)
        Me.LCategoria.TabIndex = 11
        Me.LCategoria.Text = "Nombre"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.Location = New System.Drawing.Point(46, 116)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(29, 13)
        Me.LDni.TabIndex = 10
        Me.LDni.Text = "DNI"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(137, 220)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(137, 149)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 8
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(137, 113)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 7
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(137, 184)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(100, 20)
        Me.txtApe.TabIndex = 4
        '
        'btnGuardarC
        '
        Me.btnGuardarC.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardarC.FlatAppearance.BorderSize = 0
        Me.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarC.Location = New System.Drawing.Point(40, 366)
        Me.btnGuardarC.Name = "btnGuardarC"
        Me.btnGuardarC.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarC.TabIndex = 1
        Me.btnGuardarC.Text = "Guardar"
        Me.btnGuardarC.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(182, 366)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'LAgreClien
        '
        Me.LAgreClien.AutoSize = True
        Me.LAgreClien.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAgreClien.Location = New System.Drawing.Point(78, 23)
        Me.LAgreClien.Name = "LAgreClien"
        Me.LAgreClien.Size = New System.Drawing.Size(141, 24)
        Me.LAgreClien.TabIndex = 3
        Me.LAgreClien.Text = "Agregar Cliente"
        '
        'LBuscar
        '
        Me.LBuscar.AutoSize = True
        Me.LBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscar.Location = New System.Drawing.Point(60, 90)
        Me.LBuscar.Name = "LBuscar"
        Me.LBuscar.Size = New System.Drawing.Size(60, 16)
        Me.LBuscar.TabIndex = 7
        Me.LBuscar.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(124, 87)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(258, 22)
        Me.txtBuscar.TabIndex = 6
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(636, 163)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(152, 34)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.IndianRed
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(636, 331)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(152, 34)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(636, 112)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(152, 30)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Cliente"
        Me.btnAgregar.UseVisualStyleBackColor = False
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
        'dgvClientes
        '
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(63, 112)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(524, 299)
        Me.dgvClientes.TabIndex = 5
        '
        'rbActivos
        '
        Me.rbActivos.AutoSize = True
        Me.rbActivos.Checked = True
        Me.rbActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbActivos.Location = New System.Drawing.Point(399, 89)
        Me.rbActivos.Name = "rbActivos"
        Me.rbActivos.Size = New System.Drawing.Size(67, 17)
        Me.rbActivos.TabIndex = 19
        Me.rbActivos.TabStop = True
        Me.rbActivos.Text = "Activos"
        Me.rbActivos.UseVisualStyleBackColor = True
        '
        'rbElimin
        '
        Me.rbElimin.AutoSize = True
        Me.rbElimin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbElimin.Location = New System.Drawing.Point(497, 89)
        Me.rbElimin.Name = "rbElimin"
        Me.rbElimin.Size = New System.Drawing.Size(85, 17)
        Me.rbElimin.TabIndex = 20
        Me.rbElimin.Text = "Eliminados"
        Me.rbElimin.UseVisualStyleBackColor = True
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormClientes"
        Me.Text = "Clientes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlAgregar.ResumeLayout(False)
        Me.pnlAgregar.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlAgregar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTelef As TextBox
    Friend WithEvents txtDomic As TextBox
    Friend WithEvents LStockMin As Label
    Friend WithEvents LStock As Label
    Friend WithEvents LPrecCos As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents LDni As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents btnGuardarC As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents LAgreClien As Label
    Friend WithEvents LBuscar As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents LClientes As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelef2 As TextBox
    Friend WithEvents txtDomic2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail2 As TextBox
    Friend WithEvents txtNom2 As TextBox
    Friend WithEvents txtDni2 As TextBox
    Friend WithEvents txtApe2 As TextBox
    Friend WithEvents btnGuarMod As Button
    Friend WithEvents btnCanceMod As Button
    Friend WithEvents pnlModCli As Label
    Friend WithEvents lblId As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents rbElimin As RadioButton
    Friend WithEvents rbActivos As RadioButton
    Friend WithEvents lvlidsel As Label
    Friend WithEvents btnActivar As Button
End Class
