<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarUsuario
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
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LApe = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.LEmail = New System.Windows.Forms.Label()
        Me.LTelef = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelef = New System.Windows.Forms.TextBox()
        Me.txtDirec = New System.Windows.Forms.TextBox()
        Me.LDirec = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LDirec)
        Me.Panel1.Controls.Add(Me.txtDirec)
        Me.Panel1.Controls.Add(Me.txtTelef)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtDNI)
        Me.Panel1.Controls.Add(Me.txtApe)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.LTelef)
        Me.Panel1.Controls.Add(Me.LEmail)
        Me.Panel1.Controls.Add(Me.LDNI)
        Me.Panel1.Controls.Add(Me.LApe)
        Me.Panel1.Controls.Add(Me.LNom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BCancelar)
        Me.Panel1.Controls.Add(Me.BAgregar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 451)
        Me.Panel1.TabIndex = 0
        '
        'BAgregar
        '
        Me.BAgregar.Location = New System.Drawing.Point(30, 354)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BAgregar.TabIndex = 0
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(182, 354)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 1
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Agregar Usuario"
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Location = New System.Drawing.Point(61, 92)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(44, 13)
        Me.LNom.TabIndex = 3
        Me.LNom.Text = "Nombre"
        '
        'LApe
        '
        Me.LApe.AutoSize = True
        Me.LApe.Location = New System.Drawing.Point(61, 130)
        Me.LApe.Name = "LApe"
        Me.LApe.Size = New System.Drawing.Size(44, 13)
        Me.LApe.TabIndex = 4
        Me.LApe.Text = "Apellido"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Location = New System.Drawing.Point(62, 168)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(26, 13)
        Me.LDNI.TabIndex = 5
        Me.LDNI.Text = "DNI"
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Location = New System.Drawing.Point(62, 206)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(32, 13)
        Me.LEmail.TabIndex = 6
        Me.LEmail.Text = "Email"
        '
        'LTelef
        '
        Me.LTelef.AutoSize = True
        Me.LTelef.Location = New System.Drawing.Point(61, 244)
        Me.LTelef.Name = "LTelef"
        Me.LTelef.Size = New System.Drawing.Size(49, 13)
        Me.LTelef.TabIndex = 7
        Me.LTelef.Text = "Telefono"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(147, 89)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 8
        '
        'txtApe
        '
        Me.txtApe.Location = New System.Drawing.Point(147, 127)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(100, 20)
        Me.txtApe.TabIndex = 9
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(147, 165)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(147, 203)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 11
        '
        'txtTelef
        '
        Me.txtTelef.Location = New System.Drawing.Point(147, 241)
        Me.txtTelef.Name = "txtTelef"
        Me.txtTelef.Size = New System.Drawing.Size(100, 20)
        Me.txtTelef.TabIndex = 12
        '
        'txtDirec
        '
        Me.txtDirec.Location = New System.Drawing.Point(147, 278)
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(100, 20)
        Me.txtDirec.TabIndex = 13
        '
        'LDirec
        '
        Me.LDirec.AutoSize = True
        Me.LDirec.Location = New System.Drawing.Point(61, 281)
        Me.LDirec.Name = "LDirec"
        Me.LDirec.Size = New System.Drawing.Size(52, 13)
        Me.LDirec.TabIndex = 14
        Me.LDirec.Text = "Direccion"
        '
        'AgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 451)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarUsuario"
        Me.Text = "AgregarUsuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LEmail As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LApe As Label
    Friend WithEvents LNom As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents LDirec As Label
    Friend WithEvents txtDirec As TextBox
    Friend WithEvents txtTelef As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents LTelef As Label
End Class
