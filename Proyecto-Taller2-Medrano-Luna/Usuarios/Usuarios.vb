Public Class Usuarios
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pnlAgregarUs.Visible = True
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        pnlAgregarUs.Visible = False
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        dgvUsuarios.Rows.Add(
                txtNombre.Text,
                txtApe.Text,
                txtDNI.Text,
                txtEmail.Text,
                txtTel.Text,
                txtDirec.Text)
        txtNombre.Clear()
        txtApe.Clear()
        txtDNI.Clear()
        txtEmail.Clear()
        txtTel.Clear()
        txtDirec.Clear()
    End Sub
End Class