<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.lblPrincip = New System.Windows.Forms.Label()
        Me.btnCerrPrinc = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProduc = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnBkp = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlGerente = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.pnlVendedor = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.pnlAdmin.SuspendLayout()
        Me.pnlGerente.SuspendLayout()
        Me.pnlVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblBienvenido)
        Me.Panel1.Controls.Add(Me.lblPrincip)
        Me.Panel1.Controls.Add(Me.btnCerrPrinc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 32)
        Me.Panel1.TabIndex = 1
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Location = New System.Drawing.Point(22, 9)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(63, 13)
        Me.lblBienvenido.TabIndex = 11
        Me.lblBienvenido.Text = "Bienvenido:"
        '
        'lblPrincip
        '
        Me.lblPrincip.AutoSize = True
        Me.lblPrincip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincip.Location = New System.Drawing.Point(488, 9)
        Me.lblPrincip.Name = "lblPrincip"
        Me.lblPrincip.Size = New System.Drawing.Size(46, 17)
        Me.lblPrincip.TabIndex = 4
        Me.lblPrincip.Text = "Inicio"
        '
        'btnCerrPrinc
        '
        Me.btnCerrPrinc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrPrinc.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrPrinc.FlatAppearance.BorderSize = 0
        Me.btnCerrPrinc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrPrinc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrPrinc.Location = New System.Drawing.Point(967, 3)
        Me.btnCerrPrinc.Name = "btnCerrPrinc"
        Me.btnCerrPrinc.Size = New System.Drawing.Size(33, 26)
        Me.btnCerrPrinc.TabIndex = 3
        Me.btnCerrPrinc.Text = "X"
        Me.btnCerrPrinc.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUsuarios.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.Location = New System.Drawing.Point(8, 38)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(135, 50)
        Me.btnUsuarios.TabIndex = 4
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClientes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Location = New System.Drawing.Point(8, 94)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(135, 50)
        Me.btnClientes.TabIndex = 5
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnProduc
        '
        Me.btnProduc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProduc.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnProduc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnProduc.FlatAppearance.BorderSize = 0
        Me.btnProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduc.Location = New System.Drawing.Point(8, 150)
        Me.btnProduc.Name = "btnProduc"
        Me.btnProduc.Size = New System.Drawing.Size(135, 50)
        Me.btnProduc.TabIndex = 6
        Me.btnProduc.Text = "Productos"
        Me.btnProduc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProduc.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVentas.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Location = New System.Drawing.Point(8, 206)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(135, 50)
        Me.btnVentas.TabIndex = 7
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReport.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(8, 262)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(135, 50)
        Me.btnReport.TabIndex = 8
        Me.btnReport.Text = "Reportes"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnBkp
        '
        Me.btnBkp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBkp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBkp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBkp.FlatAppearance.BorderSize = 0
        Me.btnBkp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBkp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBkp.Location = New System.Drawing.Point(8, 318)
        Me.btnBkp.Name = "btnBkp"
        Me.btnBkp.Size = New System.Drawing.Size(135, 50)
        Me.btnBkp.TabIndex = 9
        Me.btnBkp.Text = "BackUP"
        Me.btnBkp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBkp.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(8, 486)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 50)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'pnlAdmin
        '
        Me.pnlAdmin.BackColor = System.Drawing.Color.White
        Me.pnlAdmin.Controls.Add(Me.btnSalir)
        Me.pnlAdmin.Controls.Add(Me.btnUsuarios)
        Me.pnlAdmin.Controls.Add(Me.btnClientes)
        Me.pnlAdmin.Controls.Add(Me.btnProduc)
        Me.pnlAdmin.Controls.Add(Me.btnVentas)
        Me.pnlAdmin.Controls.Add(Me.btnReport)
        Me.pnlAdmin.Controls.Add(Me.btnBkp)
        Me.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlAdmin.Location = New System.Drawing.Point(0, 32)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(143, 555)
        Me.pnlAdmin.TabIndex = 11
        Me.pnlAdmin.Visible = False
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(143, 32)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(860, 555)
        Me.pnlContenedor.TabIndex = 13
        '
        'pnlGerente
        '
        Me.pnlGerente.BackColor = System.Drawing.Color.White
        Me.pnlGerente.Controls.Add(Me.Button9)
        Me.pnlGerente.Controls.Add(Me.Button14)
        Me.pnlGerente.Controls.Add(Me.Button15)
        Me.pnlGerente.Controls.Add(Me.Button16)
        Me.pnlGerente.Controls.Add(Me.Button17)
        Me.pnlGerente.Controls.Add(Me.Button18)
        Me.pnlGerente.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlGerente.Location = New System.Drawing.Point(143, 32)
        Me.pnlGerente.Name = "pnlGerente"
        Me.pnlGerente.Size = New System.Drawing.Size(165, 555)
        Me.pnlGerente.TabIndex = 13
        Me.pnlGerente.Visible = False
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(30, 486)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(135, 50)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Salir"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button14.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(30, 38)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(135, 50)
        Me.Button14.TabIndex = 5
        Me.Button14.Text = "Clientes"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button15.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button15.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(30, 94)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(135, 50)
        Me.Button15.TabIndex = 6
        Me.Button15.Text = "Productos"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button16.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button16.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(30, 150)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(135, 50)
        Me.Button16.TabIndex = 7
        Me.Button16.Text = "Ventas"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button17.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button17.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(30, 206)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(135, 50)
        Me.Button17.TabIndex = 8
        Me.Button17.Text = "Reportes"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button18.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button18.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(30, 262)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(135, 50)
        Me.Button18.TabIndex = 9
        Me.Button18.Text = "BackUP"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button18.UseVisualStyleBackColor = False
        '
        'pnlVendedor
        '
        Me.pnlVendedor.BackColor = System.Drawing.Color.White
        Me.pnlVendedor.Controls.Add(Me.Button1)
        Me.pnlVendedor.Controls.Add(Me.Button2)
        Me.pnlVendedor.Controls.Add(Me.Button3)
        Me.pnlVendedor.Controls.Add(Me.Button4)
        Me.pnlVendedor.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlVendedor.Location = New System.Drawing.Point(308, 32)
        Me.pnlVendedor.Name = "pnlVendedor"
        Me.pnlVendedor.Size = New System.Drawing.Size(174, 555)
        Me.pnlVendedor.TabIndex = 12
        Me.pnlVendedor.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(37, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 50)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Ventas"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(47, 486)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 50)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(39, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 50)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Clientes"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(39, 38)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 50)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Facturas"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 587)
        Me.Controls.Add(Me.pnlVendedor)
        Me.Controls.Add(Me.pnlGerente)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlAdmin)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlAdmin.ResumeLayout(False)
        Me.pnlGerente.ResumeLayout(False)
        Me.pnlVendedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrPrinc As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProduc As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnBkp As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnlAdmin As Panel
    Friend WithEvents lblPrincip As Label
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents pnlGerente As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents pnlVendedor As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
