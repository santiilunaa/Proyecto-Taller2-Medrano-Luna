<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuarios))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlModifUs = New System.Windows.Forms.Panel()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LUsua2 = New System.Windows.Forms.Label()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.CBPerfil2 = New System.Windows.Forms.ComboBox()
        Me.LPerfil2 = New System.Windows.Forms.Label()
        Me.BBorrarModif = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LContr2 = New System.Windows.Forms.Label()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.txtContr2 = New System.Windows.Forms.TextBox()
        Me.txtUsua2 = New System.Windows.Forms.TextBox()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.txtNom2 = New System.Windows.Forms.TextBox()
        Me.txtDNI2 = New System.Windows.Forms.TextBox()
        Me.LTel2 = New System.Windows.Forms.Label()
        Me.LEmail2 = New System.Windows.Forms.Label()
        Me.LApe2 = New System.Windows.Forms.Label()
        Me.LNom2 = New System.Windows.Forms.Label()
        Me.LDNI2 = New System.Windows.Forms.Label()
        Me.LModif = New System.Windows.Forms.Label()
        Me.BCancelModif = New System.Windows.Forms.Button()
        Me.BGuardarModif = New System.Windows.Forms.Button()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.lvlidsel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlAgregarUs = New System.Windows.Forms.Panel()
        Me.LUsua = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.CBPerfil = New System.Windows.Forms.ComboBox()
        Me.LPerfil = New System.Windows.Forms.Label()
        Me.BBorrar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LContr = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContr = New System.Windows.Forms.TextBox()
        Me.txtUsua = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.LTelef = New System.Windows.Forms.Label()
        Me.LEmail = New System.Windows.Forms.Label()
        Me.LApe = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.LAgregar = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rbActivos = New System.Windows.Forms.RadioButton()
        Me.rbElimin = New System.Windows.Forms.RadioButton()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlModifUs.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAgregarUs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuarios "
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(59, 397)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(122, 38)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar Usuario"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(189, 397)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(122, 38)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.IndianRed
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(620, 397)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 38)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar "
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(59, 122)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.Size = New System.Drawing.Size(683, 251)
        Me.dgvUsuarios.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.pnlModifUs)
        Me.Panel1.Controls.Add(Me.btnActivar)
        Me.Panel1.Controls.Add(Me.lvlidsel)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.pnlAgregarUs)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.dgvUsuarios)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.rbActivos)
        Me.Panel1.Controls.Add(Me.rbElimin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 460)
        Me.Panel1.TabIndex = 5
        '
        'pnlModifUs
        '
        Me.pnlModifUs.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlModifUs.Controls.Add(Me.LblId)
        Me.pnlModifUs.Controls.Add(Me.LUsua2)
        Me.pnlModifUs.Controls.Add(Me.txtTel2)
        Me.pnlModifUs.Controls.Add(Me.CBPerfil2)
        Me.pnlModifUs.Controls.Add(Me.LPerfil2)
        Me.pnlModifUs.Controls.Add(Me.BBorrarModif)
        Me.pnlModifUs.Controls.Add(Me.Panel5)
        Me.pnlModifUs.Controls.Add(Me.Panel6)
        Me.pnlModifUs.Controls.Add(Me.LContr2)
        Me.pnlModifUs.Controls.Add(Me.txtEmail2)
        Me.pnlModifUs.Controls.Add(Me.txtContr2)
        Me.pnlModifUs.Controls.Add(Me.txtUsua2)
        Me.pnlModifUs.Controls.Add(Me.txtApe2)
        Me.pnlModifUs.Controls.Add(Me.txtNom2)
        Me.pnlModifUs.Controls.Add(Me.txtDNI2)
        Me.pnlModifUs.Controls.Add(Me.LTel2)
        Me.pnlModifUs.Controls.Add(Me.LEmail2)
        Me.pnlModifUs.Controls.Add(Me.LApe2)
        Me.pnlModifUs.Controls.Add(Me.LNom2)
        Me.pnlModifUs.Controls.Add(Me.LDNI2)
        Me.pnlModifUs.Controls.Add(Me.LModif)
        Me.pnlModifUs.Controls.Add(Me.BCancelModif)
        Me.pnlModifUs.Controls.Add(Me.BGuardarModif)
        Me.pnlModifUs.Location = New System.Drawing.Point(443, 39)
        Me.pnlModifUs.Name = "pnlModifUs"
        Me.pnlModifUs.Size = New System.Drawing.Size(299, 409)
        Me.pnlModifUs.TabIndex = 23
        Me.pnlModifUs.Visible = False
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(31, 40)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(45, 13)
        Me.LblId.TabIndex = 23
        Me.LblId.Text = "Label2"
        Me.LblId.Visible = False
        '
        'LUsua2
        '
        Me.LUsua2.AutoSize = True
        Me.LUsua2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsua2.Location = New System.Drawing.Point(50, 210)
        Me.LUsua2.Name = "LUsua2"
        Me.LUsua2.Size = New System.Drawing.Size(50, 13)
        Me.LUsua2.TabIndex = 22
        Me.LUsua2.Text = "Usuario"
        '
        'txtTel2
        '
        Me.txtTel2.Location = New System.Drawing.Point(128, 312)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(101, 20)
        Me.txtTel2.TabIndex = 21
        '
        'CBPerfil2
        '
        Me.CBPerfil2.FormattingEnabled = True
        Me.CBPerfil2.Location = New System.Drawing.Point(128, 66)
        Me.CBPerfil2.Name = "CBPerfil2"
        Me.CBPerfil2.Size = New System.Drawing.Size(101, 21)
        Me.CBPerfil2.TabIndex = 19
        '
        'LPerfil2
        '
        Me.LPerfil2.AutoSize = True
        Me.LPerfil2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPerfil2.Location = New System.Drawing.Point(51, 69)
        Me.LPerfil2.Name = "LPerfil2"
        Me.LPerfil2.Size = New System.Drawing.Size(36, 13)
        Me.LPerfil2.TabIndex = 18
        Me.LPerfil2.Text = "Perfil"
        '
        'BBorrarModif
        '
        Me.BBorrarModif.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BBorrarModif.FlatAppearance.BorderSize = 0
        Me.BBorrarModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBorrarModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBorrarModif.Location = New System.Drawing.Point(110, 362)
        Me.BBorrarModif.Name = "BBorrarModif"
        Me.BBorrarModif.Size = New System.Drawing.Size(75, 23)
        Me.BBorrarModif.TabIndex = 17
        Me.BBorrarModif.Text = "Borrar"
        Me.BBorrarModif.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(294, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 404)
        Me.Panel5.TabIndex = 16
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 404)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(299, 5)
        Me.Panel6.TabIndex = 15
        '
        'LContr2
        '
        Me.LContr2.AutoSize = True
        Me.LContr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContr2.Location = New System.Drawing.Point(37, 245)
        Me.LContr2.Name = "LContr2"
        Me.LContr2.Size = New System.Drawing.Size(71, 13)
        Me.LContr2.TabIndex = 14
        Me.LContr2.Text = "Contraseña"
        '
        'txtEmail2
        '
        Me.txtEmail2.Location = New System.Drawing.Point(128, 277)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(101, 20)
        Me.txtEmail2.TabIndex = 13
        '
        'txtContr2
        '
        Me.txtContr2.Location = New System.Drawing.Point(128, 242)
        Me.txtContr2.Name = "txtContr2"
        Me.txtContr2.Size = New System.Drawing.Size(101, 20)
        Me.txtContr2.TabIndex = 12
        '
        'txtUsua2
        '
        Me.txtUsua2.Location = New System.Drawing.Point(128, 207)
        Me.txtUsua2.Name = "txtUsua2"
        Me.txtUsua2.Size = New System.Drawing.Size(100, 20)
        Me.txtUsua2.TabIndex = 11
        '
        'txtApe2
        '
        Me.txtApe2.Location = New System.Drawing.Point(129, 171)
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.Size = New System.Drawing.Size(100, 20)
        Me.txtApe2.TabIndex = 10
        '
        'txtNom2
        '
        Me.txtNom2.Location = New System.Drawing.Point(128, 136)
        Me.txtNom2.Name = "txtNom2"
        Me.txtNom2.Size = New System.Drawing.Size(101, 20)
        Me.txtNom2.TabIndex = 9
        '
        'txtDNI2
        '
        Me.txtDNI2.Location = New System.Drawing.Point(128, 101)
        Me.txtDNI2.Name = "txtDNI2"
        Me.txtDNI2.Size = New System.Drawing.Size(101, 20)
        Me.txtDNI2.TabIndex = 8
        '
        'LTel2
        '
        Me.LTel2.AutoSize = True
        Me.LTel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTel2.Location = New System.Drawing.Point(51, 315)
        Me.LTel2.Name = "LTel2"
        Me.LTel2.Size = New System.Drawing.Size(57, 13)
        Me.LTel2.TabIndex = 7
        Me.LTel2.Text = "Telefono"
        '
        'LEmail2
        '
        Me.LEmail2.AutoSize = True
        Me.LEmail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmail2.Location = New System.Drawing.Point(51, 280)
        Me.LEmail2.Name = "LEmail2"
        Me.LEmail2.Size = New System.Drawing.Size(37, 13)
        Me.LEmail2.TabIndex = 6
        Me.LEmail2.Text = "Email"
        '
        'LApe2
        '
        Me.LApe2.AutoSize = True
        Me.LApe2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApe2.Location = New System.Drawing.Point(50, 174)
        Me.LApe2.Name = "LApe2"
        Me.LApe2.Size = New System.Drawing.Size(52, 13)
        Me.LApe2.TabIndex = 5
        Me.LApe2.Text = "Apellido"
        '
        'LNom2
        '
        Me.LNom2.AutoSize = True
        Me.LNom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom2.Location = New System.Drawing.Point(50, 139)
        Me.LNom2.Name = "LNom2"
        Me.LNom2.Size = New System.Drawing.Size(50, 13)
        Me.LNom2.TabIndex = 4
        Me.LNom2.Text = "Nombre"
        '
        'LDNI2
        '
        Me.LDNI2.AutoSize = True
        Me.LDNI2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDNI2.Location = New System.Drawing.Point(50, 104)
        Me.LDNI2.Name = "LDNI2"
        Me.LDNI2.Size = New System.Drawing.Size(29, 13)
        Me.LDNI2.TabIndex = 3
        Me.LDNI2.Text = "DNI"
        '
        'LModif
        '
        Me.LModif.AutoSize = True
        Me.LModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModif.Location = New System.Drawing.Point(81, 14)
        Me.LModif.Name = "LModif"
        Me.LModif.Size = New System.Drawing.Size(155, 24)
        Me.LModif.TabIndex = 2
        Me.LModif.Text = "Modificar Usuario"
        '
        'BCancelModif
        '
        Me.BCancelModif.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BCancelModif.FlatAppearance.BorderSize = 0
        Me.BCancelModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelModif.Location = New System.Drawing.Point(201, 362)
        Me.BCancelModif.Name = "BCancelModif"
        Me.BCancelModif.Size = New System.Drawing.Size(75, 23)
        Me.BCancelModif.TabIndex = 1
        Me.BCancelModif.Text = "Cancelar"
        Me.BCancelModif.UseVisualStyleBackColor = False
        '
        'BGuardarModif
        '
        Me.BGuardarModif.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BGuardarModif.FlatAppearance.BorderSize = 0
        Me.BGuardarModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGuardarModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardarModif.Location = New System.Drawing.Point(19, 362)
        Me.BGuardarModif.Name = "BGuardarModif"
        Me.BGuardarModif.Size = New System.Drawing.Size(75, 23)
        Me.BGuardarModif.TabIndex = 0
        Me.BGuardarModif.Text = "Guardar"
        Me.BGuardarModif.UseVisualStyleBackColor = False
        '
        'btnActivar
        '
        Me.btnActivar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnActivar.FlatAppearance.BorderSize = 0
        Me.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivar.Location = New System.Drawing.Point(492, 397)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(122, 38)
        Me.btnActivar.TabIndex = 30
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseVisualStyleBackColor = False
        '
        'lvlidsel
        '
        Me.lvlidsel.AutoSize = True
        Me.lvlidsel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlidsel.Location = New System.Drawing.Point(772, 9)
        Me.lvlidsel.Name = "lvlidsel"
        Me.lvlidsel.Size = New System.Drawing.Size(25, 24)
        Me.lvlidsel.TabIndex = 26
        Me.lvlidsel.Text = "id"
        Me.lvlidsel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(87, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pnlAgregarUs
        '
        Me.pnlAgregarUs.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlAgregarUs.Controls.Add(Me.LUsua)
        Me.pnlAgregarUs.Controls.Add(Me.txtTel)
        Me.pnlAgregarUs.Controls.Add(Me.CBPerfil)
        Me.pnlAgregarUs.Controls.Add(Me.LPerfil)
        Me.pnlAgregarUs.Controls.Add(Me.BBorrar)
        Me.pnlAgregarUs.Controls.Add(Me.Panel3)
        Me.pnlAgregarUs.Controls.Add(Me.Panel2)
        Me.pnlAgregarUs.Controls.Add(Me.LContr)
        Me.pnlAgregarUs.Controls.Add(Me.txtEmail)
        Me.pnlAgregarUs.Controls.Add(Me.txtContr)
        Me.pnlAgregarUs.Controls.Add(Me.txtUsua)
        Me.pnlAgregarUs.Controls.Add(Me.txtApe)
        Me.pnlAgregarUs.Controls.Add(Me.txtNom)
        Me.pnlAgregarUs.Controls.Add(Me.txtDNI)
        Me.pnlAgregarUs.Controls.Add(Me.LTelef)
        Me.pnlAgregarUs.Controls.Add(Me.LEmail)
        Me.pnlAgregarUs.Controls.Add(Me.LApe)
        Me.pnlAgregarUs.Controls.Add(Me.LNom)
        Me.pnlAgregarUs.Controls.Add(Me.LDNI)
        Me.pnlAgregarUs.Controls.Add(Me.LAgregar)
        Me.pnlAgregarUs.Controls.Add(Me.BCancelar)
        Me.pnlAgregarUs.Controls.Add(Me.BGuardar)
        Me.pnlAgregarUs.Location = New System.Drawing.Point(46, 39)
        Me.pnlAgregarUs.Name = "pnlAgregarUs"
        Me.pnlAgregarUs.Size = New System.Drawing.Size(299, 409)
        Me.pnlAgregarUs.TabIndex = 6
        Me.pnlAgregarUs.Visible = False
        '
        'LUsua
        '
        Me.LUsua.AutoSize = True
        Me.LUsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsua.Location = New System.Drawing.Point(50, 210)
        Me.LUsua.Name = "LUsua"
        Me.LUsua.Size = New System.Drawing.Size(50, 13)
        Me.LUsua.TabIndex = 22
        Me.LUsua.Text = "Usuario"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(128, 312)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(101, 20)
        Me.txtTel.TabIndex = 21
        '
        'CBPerfil
        '
        Me.CBPerfil.FormattingEnabled = True
        Me.CBPerfil.Location = New System.Drawing.Point(128, 66)
        Me.CBPerfil.Name = "CBPerfil"
        Me.CBPerfil.Size = New System.Drawing.Size(101, 21)
        Me.CBPerfil.TabIndex = 19
        '
        'LPerfil
        '
        Me.LPerfil.AutoSize = True
        Me.LPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPerfil.Location = New System.Drawing.Point(51, 69)
        Me.LPerfil.Name = "LPerfil"
        Me.LPerfil.Size = New System.Drawing.Size(36, 13)
        Me.LPerfil.TabIndex = 18
        Me.LPerfil.Text = "Perfil"
        '
        'BBorrar
        '
        Me.BBorrar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BBorrar.FlatAppearance.BorderSize = 0
        Me.BBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBorrar.Location = New System.Drawing.Point(110, 362)
        Me.BBorrar.Name = "BBorrar"
        Me.BBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BBorrar.TabIndex = 17
        Me.BBorrar.Text = "Borrar"
        Me.BBorrar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(294, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 404)
        Me.Panel3.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 404)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(299, 5)
        Me.Panel2.TabIndex = 15
        '
        'LContr
        '
        Me.LContr.AutoSize = True
        Me.LContr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContr.Location = New System.Drawing.Point(37, 245)
        Me.LContr.Name = "LContr"
        Me.LContr.Size = New System.Drawing.Size(71, 13)
        Me.LContr.TabIndex = 14
        Me.LContr.Text = "Contraseña"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(128, 277)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(101, 20)
        Me.txtEmail.TabIndex = 13
        '
        'txtContr
        '
        Me.txtContr.Location = New System.Drawing.Point(128, 242)
        Me.txtContr.Name = "txtContr"
        Me.txtContr.Size = New System.Drawing.Size(101, 20)
        Me.txtContr.TabIndex = 12
        '
        'txtUsua
        '
        Me.txtUsua.Location = New System.Drawing.Point(128, 207)
        Me.txtUsua.Name = "txtUsua"
        Me.txtUsua.Size = New System.Drawing.Size(100, 20)
        Me.txtUsua.TabIndex = 11
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(129, 171)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(100, 20)
        Me.txtApe.TabIndex = 10
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(128, 136)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(101, 20)
        Me.txtNom.TabIndex = 9
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(128, 101)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(101, 20)
        Me.txtDNI.TabIndex = 8
        '
        'LTelef
        '
        Me.LTelef.AutoSize = True
        Me.LTelef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelef.Location = New System.Drawing.Point(51, 315)
        Me.LTelef.Name = "LTelef"
        Me.LTelef.Size = New System.Drawing.Size(57, 13)
        Me.LTelef.TabIndex = 7
        Me.LTelef.Text = "Telefono"
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmail.Location = New System.Drawing.Point(51, 280)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(37, 13)
        Me.LEmail.TabIndex = 6
        Me.LEmail.Text = "Email"
        '
        'LApe
        '
        Me.LApe.AutoSize = True
        Me.LApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApe.Location = New System.Drawing.Point(50, 174)
        Me.LApe.Name = "LApe"
        Me.LApe.Size = New System.Drawing.Size(52, 13)
        Me.LApe.TabIndex = 5
        Me.LApe.Text = "Apellido"
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom.Location = New System.Drawing.Point(50, 139)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(50, 13)
        Me.LNom.TabIndex = 4
        Me.LNom.Text = "Nombre"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDNI.Location = New System.Drawing.Point(50, 104)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(29, 13)
        Me.LDNI.TabIndex = 3
        Me.LDNI.Text = "DNI"
        '
        'LAgregar
        '
        Me.LAgregar.AutoSize = True
        Me.LAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAgregar.Location = New System.Drawing.Point(81, 14)
        Me.LAgregar.Name = "LAgregar"
        Me.LAgregar.Size = New System.Drawing.Size(147, 24)
        Me.LAgregar.TabIndex = 2
        Me.LAgregar.Text = "Agregar Usuario"
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BCancelar.FlatAppearance.BorderSize = 0
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.Location = New System.Drawing.Point(201, 362)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 1
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BGuardar.FlatAppearance.BorderSize = 0
        Me.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.Location = New System.Drawing.Point(19, 362)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BGuardar.TabIndex = 0
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(139, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(505, 23)
        Me.TextBox1.TabIndex = 5
        '
        'rbActivos
        '
        Me.rbActivos.AutoSize = True
        Me.rbActivos.Checked = True
        Me.rbActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbActivos.Location = New System.Drawing.Point(307, 99)
        Me.rbActivos.Name = "rbActivos"
        Me.rbActivos.Size = New System.Drawing.Size(67, 17)
        Me.rbActivos.TabIndex = 24
        Me.rbActivos.TabStop = True
        Me.rbActivos.Text = "Activos"
        Me.rbActivos.UseVisualStyleBackColor = True
        '
        'rbElimin
        '
        Me.rbElimin.AutoSize = True
        Me.rbElimin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbElimin.Location = New System.Drawing.Point(405, 99)
        Me.rbElimin.Name = "rbElimin"
        Me.rbElimin.Size = New System.Drawing.Size(85, 17)
        Me.rbElimin.TabIndex = 25
        Me.rbElimin.Text = "Eliminados"
        Me.rbElimin.UseVisualStyleBackColor = True
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUsuarios"
        Me.Text = "Usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlModifUs.ResumeLayout(False)
        Me.pnlModifUs.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAgregarUs.ResumeLayout(False)
        Me.pnlAgregarUs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlAgregarUs As Panel
    Friend WithEvents LContr As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContr As TextBox
    Friend WithEvents txtUsua As TextBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents LTelef As Label
    Friend WithEvents LEmail As Label
    Friend WithEvents LApe As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LAgregar As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BBorrar As Button
    Friend WithEvents CBPerfil As ComboBox
    Friend WithEvents LPerfil As Label
    Friend WithEvents LUsua As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents pnlModifUs As Panel
    Friend WithEvents LUsua2 As Label
    Friend WithEvents txtTel2 As TextBox
    Friend WithEvents CBPerfil2 As ComboBox
    Friend WithEvents LPerfil2 As Label
    Friend WithEvents BBorrarModif As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LContr2 As Label
    Friend WithEvents txtEmail2 As TextBox
    Friend WithEvents txtContr2 As TextBox
    Friend WithEvents txtUsua2 As TextBox
    Friend WithEvents txtApe2 As TextBox
    Friend WithEvents txtNom2 As TextBox
    Friend WithEvents txtDNI2 As TextBox
    Friend WithEvents LTel2 As Label
    Friend WithEvents LEmail2 As Label
    Friend WithEvents LApe2 As Label
    Friend WithEvents LNom2 As Label
    Friend WithEvents LDNI2 As Label
    Friend WithEvents LModif As Label
    Friend WithEvents BCancelModif As Button
    Friend WithEvents BGuardarModif As Button
    Friend WithEvents LblId As Label
    Friend WithEvents rbElimin As RadioButton
    Friend WithEvents rbActivos As RadioButton
    Friend WithEvents lvlidsel As Label
    Friend WithEvents btnActivar As Button
End Class
