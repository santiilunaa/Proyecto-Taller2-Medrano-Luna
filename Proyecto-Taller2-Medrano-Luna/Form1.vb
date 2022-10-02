Public Class Form1


    Private Sub btnBkp_Click(sender As Object, e As EventArgs) Handles btnBkp.Click, Button18.Click
        AbrirFormHijo(New FormBkp())


    End Sub

    Private Sub btnCerrPrinc_Click(sender As Object, e As EventArgs) Handles btnCerrPrinc.Click
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        AbrirFormHijo(New FormReportes())


    End Sub

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim perfil As Integer
        perfil = 1
        If perfil = 1 Then
            pnlAdmin.Visible = True
            pnlVendedor.Visible = False
            pnlGerente.Visible = False
        ElseIf perfil = 2 Then
            pnlAdmin.Visible = False
            pnlVendedor.Visible = True
            pnlGerente.Visible = False
        ElseIf perfil = 3 Then
            pnlAdmin.Visible = False
            pnlVendedor.Visible = False
            pnlGerente.Visible = True
        End If
    End Sub
End Class
