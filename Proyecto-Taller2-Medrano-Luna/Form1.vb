﻿Public Class Form1

    Private currentForm As Form = Nothing
    Private Sub AbrirFormHijo(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        pnlContenedor.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub btnBkp_Click(sender As Object, e As EventArgs) Handles btnBkp.Click
        AbrirFormHijo(New FormBkp())
        lblPrincip.Text = "Back Up"
        btnBkp.BackColor = Color.White
        btnReport.BackColor = Color.CornflowerBlue
        btnUsuarios.BackColor = Color.CornflowerBlue
        btnProduc.BackColor = Color.CornflowerBlue
        btnClientes.BackColor = Color.CornflowerBlue
        btnVentas.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub btnCerrPrinc_Click(sender As Object, e As EventArgs) Handles btnCerrPrinc.Click
        End

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        AbrirFormHijo(New FormReportes())
        lblPrincip.Text = "Reportes"
        btnReport.BackColor = Color.White
        btnBkp.BackColor = Color.CornflowerBlue
        btnUsuarios.BackColor = Color.CornflowerBlue
        btnProduc.BackColor = Color.CornflowerBlue
        btnClientes.BackColor = Color.CornflowerBlue
        btnVentas.BackColor = Color.CornflowerBlue

    End Sub
    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        AbrirFormHijo(New FormUsuarios())
        lblPrincip.Text = "Usuarios"
        btnUsuarios.BackColor = Color.White
        btnBkp.BackColor = Color.CornflowerBlue
        btnReport.BackColor = Color.CornflowerBlue
        btnProduc.BackColor = Color.CornflowerBlue
        btnClientes.BackColor = Color.CornflowerBlue
        btnVentas.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub btnProduc_Click(sender As Object, e As EventArgs) Handles btnProduc.Click
        AbrirFormHijo(New FormProductos())
        lblPrincip.Text = "Productos"
        btnProduc.BackColor = Color.White
        btnBkp.BackColor = Color.CornflowerBlue
        btnReport.BackColor = Color.CornflowerBlue
        btnUsuarios.BackColor = Color.CornflowerBlue
        btnClientes.BackColor = Color.CornflowerBlue
        btnVentas.BackColor = Color.CornflowerBlue

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormHijo(New FormClientes())
        lblPrincip.Text = "Clientes"
        btnClientes.BackColor = Color.White
        btnBkp.BackColor = Color.CornflowerBlue
        btnReport.BackColor = Color.CornflowerBlue
        btnProduc.BackColor = Color.CornflowerBlue
        btnVentas.BackColor = Color.CornflowerBlue
        btnUsuarios.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormHijo(New Ventas())
        lblPrincip.Text = "Ventas"
        btnVentas.BackColor = Color.White
        btnClientes.BackColor = Color.CornflowerBlue
        btnBkp.BackColor = Color.CornflowerBlue
        btnReport.BackColor = Color.CornflowerBlue
        btnProduc.BackColor = Color.CornflowerBlue
        btnUsuarios.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        lblBienvenido.Text = "Bienvenido: " + Module1.us
    End Sub

End Class
