﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.LTotal = New System.Windows.Forms.Label()
        Me.LCliente = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.elim = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LTel = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LApe = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LStock = New System.Windows.Forms.Label()
        Me.Lcant = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBusProd = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LFactura = New System.Windows.Forms.Label()
        Me.LSelCllien = New System.Windows.Forms.Label()
        Me.LAgregarProd = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.LTotal)
        Me.Panel1.Controls.Add(Me.LCliente)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.LFactura)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 467)
        Me.Panel1.TabIndex = 0
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.Location = New System.Drawing.Point(626, 361)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(36, 13)
        Me.LTotal.TabIndex = 22
        Me.LTotal.Text = "Total"
        '
        'LCliente
        '
        Me.LCliente.AutoSize = True
        Me.LCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCliente.Location = New System.Drawing.Point(316, 361)
        Me.LCliente.Name = "LCliente"
        Me.LCliente.Size = New System.Drawing.Size(46, 13)
        Me.LCliente.TabIndex = 21
        Me.LCliente.Text = "Cliente"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod, Me.cant, Me.prec, Me.elim})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(304, 56)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(440, 280)
        Me.DataGridView1.TabIndex = 11
        '
        'prod
        '
        Me.prod.HeaderText = "Producto"
        Me.prod.Name = "prod"
        '
        'cant
        '
        Me.cant.HeaderText = "Cantidad"
        Me.cant.Name = "cant"
        '
        'prec
        '
        Me.prec.HeaderText = "Precio"
        Me.prec.Name = "prec"
        '
        'elim
        '
        Me.elim.HeaderText = ""
        Me.elim.Name = "elim"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(653, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Confirmar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LSelCllien)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.LTel)
        Me.Panel4.Controls.Add(Me.LNom)
        Me.Panel4.Controls.Add(Me.LApe)
        Me.Panel4.Controls.Add(Me.LDNI)
        Me.Panel4.Controls.Add(Me.TextBox7)
        Me.Panel4.Controls.Add(Me.TextBox6)
        Me.Panel4.Controls.Add(Me.TextBox5)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Location = New System.Drawing.Point(12, 56)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(286, 205)
        Me.Panel4.TabIndex = 6
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(161, 164)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Cancelar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(36, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Agregar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'LTel
        '
        Me.LTel.AutoSize = True
        Me.LTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTel.Location = New System.Drawing.Point(24, 128)
        Me.LTel.Name = "LTel"
        Me.LTel.Size = New System.Drawing.Size(57, 13)
        Me.LTel.TabIndex = 20
        Me.LTel.Text = "Teléfono"
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom.Location = New System.Drawing.Point(24, 43)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(50, 13)
        Me.LNom.TabIndex = 19
        Me.LNom.Text = "Nombre"
        '
        'LApe
        '
        Me.LApe.AutoSize = True
        Me.LApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApe.Location = New System.Drawing.Point(24, 69)
        Me.LApe.Name = "LApe"
        Me.LApe.Size = New System.Drawing.Size(52, 13)
        Me.LApe.TabIndex = 18
        Me.LApe.Text = "Apellido"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDNI.Location = New System.Drawing.Point(24, 98)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(29, 13)
        Me.LDNI.TabIndex = 17
        Me.LDNI.Text = "DNI"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(139, 69)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(139, 95)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(139, 121)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(139, 43)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LAgregarProd)
        Me.Panel3.Controls.Add(Me.LStock)
        Me.Panel3.Controls.Add(Me.Lcant)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.LBusProd)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Location = New System.Drawing.Point(12, 283)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(286, 172)
        Me.Panel3.TabIndex = 5
        '
        'LStock
        '
        Me.LStock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStock.Location = New System.Drawing.Point(3, 84)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(40, 13)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'Lcant
        '
        Me.Lcant.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lcant.AutoSize = True
        Me.Lcant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcant.Location = New System.Drawing.Point(127, 84)
        Me.Lcant.Name = "Lcant"
        Me.Lcant.Size = New System.Drawing.Size(57, 13)
        Me.Lcant.TabIndex = 13
        Me.Lcant.Text = "Cantidad"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox3.Location = New System.Drawing.Point(59, 81)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(59, 20)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.Location = New System.Drawing.Point(199, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Location = New System.Drawing.Point(113, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'LBusProd
        '
        Me.LBusProd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LBusProd.AutoSize = True
        Me.LBusProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBusProd.Location = New System.Drawing.Point(3, 40)
        Me.LBusProd.Name = "LBusProd"
        Me.LBusProd.Size = New System.Drawing.Size(58, 13)
        Me.LBusProd.TabIndex = 9
        Me.LBusProd.Text = "Producto"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(36, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(161, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LVendedor)
        Me.Panel2.Controls.Add(Me.LFecha)
        Me.Panel2.Location = New System.Drawing.Point(255, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(359, 35)
        Me.Panel2.TabIndex = 4
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendedor.Location = New System.Drawing.Point(159, 9)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(61, 13)
        Me.LVendedor.TabIndex = 1
        Me.LVendedor.Text = "Vendedor"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.Location = New System.Drawing.Point(3, 9)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(46, 13)
        Me.LFecha.TabIndex = 0
        Me.LFecha.Text = "Fecha:"
        '
        'LFactura
        '
        Me.LFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LFactura.AutoSize = True
        Me.LFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFactura.Location = New System.Drawing.Point(76, 9)
        Me.LFactura.Name = "LFactura"
        Me.LFactura.Size = New System.Drawing.Size(107, 31)
        Me.LFactura.TabIndex = 3
        Me.LFactura.Text = "Factura"
        '
        'LSelCllien
        '
        Me.LSelCllien.AutoSize = True
        Me.LSelCllien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSelCllien.Location = New System.Drawing.Point(110, 15)
        Me.LSelCllien.Name = "LSelCllien"
        Me.LSelCllien.Size = New System.Drawing.Size(46, 13)
        Me.LSelCllien.TabIndex = 23
        Me.LSelCllien.Text = "Cliente"
        '
        'LAgregarProd
        '
        Me.LAgregarProd.AutoSize = True
        Me.LAgregarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAgregarProd.Location = New System.Drawing.Point(110, 14)
        Me.LAgregarProd.Name = "LAgregarProd"
        Me.LAgregarProd.Size = New System.Drawing.Size(106, 13)
        Me.LAgregarProd.TabIndex = 24
        Me.LAgregarProd.Text = "Agregar Producto"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 467)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LFactura As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LVendedor As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents prod As DataGridViewTextBoxColumn
    Friend WithEvents cant As DataGridViewTextBoxColumn
    Friend WithEvents prec As DataGridViewTextBoxColumn
    Friend WithEvents elim As DataGridViewImageColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LBusProd As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LTel As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LApe As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents LCliente As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LStock As Label
    Friend WithEvents Lcant As Label
    Friend WithEvents LTotal As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LSelCllien As Label
    Friend WithEvents LAgregarProd As Label
End Class
