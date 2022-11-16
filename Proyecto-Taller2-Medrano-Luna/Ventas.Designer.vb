<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.PVentas = New System.Windows.Forms.Panel()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnFilt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTdesde = New System.Windows.Forms.DateTimePicker()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.DThasta = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LRepoVentas = New System.Windows.Forms.Label()
        Me.PVentas.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PVentas
        '
        Me.PVentas.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PVentas.Controls.Add(Me.btnExportar)
        Me.PVentas.Controls.Add(Me.btnFilt)
        Me.PVentas.Controls.Add(Me.Label2)
        Me.PVentas.Controls.Add(Me.DTdesde)
        Me.PVentas.Controls.Add(Me.LFecha)
        Me.PVentas.Controls.Add(Me.DThasta)
        Me.PVentas.Controls.Add(Me.DataGridView1)
        Me.PVentas.Controls.Add(Me.LRepoVentas)
        Me.PVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PVentas.Location = New System.Drawing.Point(0, 0)
        Me.PVentas.Name = "PVentas"
        Me.PVentas.Size = New System.Drawing.Size(800, 460)
        Me.PVentas.TabIndex = 0
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(687, 393)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(101, 40)
        Me.btnExportar.TabIndex = 19
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnFilt
        '
        Me.btnFilt.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnFilt.FlatAppearance.BorderSize = 0
        Me.btnFilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilt.Location = New System.Drawing.Point(353, 316)
        Me.btnFilt.Name = "btnFilt"
        Me.btnFilt.Size = New System.Drawing.Size(75, 23)
        Me.btnFilt.TabIndex = 18
        Me.btnFilt.Text = "Buscar"
        Me.btnFilt.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Desde:"
        '
        'DTdesde
        '
        Me.DTdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTdesde.Location = New System.Drawing.Point(219, 120)
        Me.DTdesde.Name = "DTdesde"
        Me.DTdesde.Size = New System.Drawing.Size(104, 20)
        Me.DTdesde.TabIndex = 16
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.Location = New System.Drawing.Point(458, 126)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(44, 13)
        Me.LFecha.TabIndex = 15
        Me.LFecha.Text = "Hasta:"
        '
        'DThasta
        '
        Me.DThasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DThasta.Location = New System.Drawing.Point(508, 120)
        Me.DThasta.Name = "DThasta"
        Me.DThasta.Size = New System.Drawing.Size(104, 20)
        Me.DThasta.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(138, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(491, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'LRepoVentas
        '
        Me.LRepoVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LRepoVentas.AutoSize = True
        Me.LRepoVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRepoVentas.Location = New System.Drawing.Point(280, 22)
        Me.LRepoVentas.Name = "LRepoVentas"
        Me.LRepoVentas.Size = New System.Drawing.Size(298, 37)
        Me.LRepoVentas.TabIndex = 2
        Me.LRepoVentas.Text = "Reportes de Ventas"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.PVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.PVentas.ResumeLayout(False)
        Me.PVentas.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PVentas As Panel
    Friend WithEvents LRepoVentas As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LFecha As Label
    Friend WithEvents DThasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DTdesde As DateTimePicker
    Friend WithEvents btnFilt As Button
    Friend WithEvents btnExportar As Button
End Class
