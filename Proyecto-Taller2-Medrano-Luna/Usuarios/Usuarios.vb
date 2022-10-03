Public Class Usuarios
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pnlAgregarUs.Visible = True
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        pnlAgregarUs.Visible = False
    End Sub
End Class