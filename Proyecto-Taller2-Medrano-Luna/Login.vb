Public Class Login

    Public us As String
    Public contr As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Public Function Verificar(ByVal p_usuario As String, ByVal p_pass As String, ByVal p_tipo As String)
        Try
            Dim tipouser As New ProyectoTallerEntities5
            Dim verif = (From q In tipouser.Usuarios
                         Where (p_usuario = q.usuario And p_pass = q.contraseña And q.id_perfil = p_tipo And q.elim = "no")
                         Select q).First()
            Module1.id_usuario = verif.id_usuario
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub btnIngresar_Click() Handles btnIngresar.Click

        If Verificar(txtUsuar.Text, txtContr.Text, "1") Then
            Me.Hide()
            Module1.us = txtUsuar.Text
            Module1.contr = txtContr.Text
            Form1.ShowDialog()


        ElseIf Verificar(txtUsuar.Text, txtContr.Text, "3") Then
            Me.Hide()
            Module1.us = txtUsuar.Text
            Module1.contr = txtContr.Text
            MenuVendedor.ShowDialog()


        ElseIf Verificar(txtUsuar.Text, txtContr.Text, "2") Then
            Me.Hide()
            Module1.us = txtUsuar.Text
            Module1.contr = txtContr.Text
            MenuGerente.ShowDialog()
        Else
            MessageBox.Show("Nombre de Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        txtUsuar.Clear()
        txtContr.Clear()
    End Sub

End Class