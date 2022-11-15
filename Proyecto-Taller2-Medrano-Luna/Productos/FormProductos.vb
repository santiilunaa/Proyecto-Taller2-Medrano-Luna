Public Class FormProductos
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pnlAgregar.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlAgregar.Visible = False
    End Sub

    Private Sub btnGuardarP_Click(sender As Object, e As EventArgs) Handles btnGuardarP.Click
        If (CBCateg2.Text = "") Or (txtNom.Text = "") Or (txtPCos.Text = "") Or (txtPVent.Text = "") Or (txtStock.Text = "") Or (txtStockMin.Text = "") Then
            MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
        ElseIf IsNumeric(txtNom.Text) Then
            MsgBox("Complete con valores alfabeticos en nombre y categoria por favor", MsgBoxStyle.Critical, "Error")

        ElseIf Not IsNumeric(txtPCos.Text) Or Not IsNumeric(txtPVent.Text) Or IsNumeric(txtStock) Or IsNumeric(txtStockMin) Then
            MsgBox("solo valores numéricos en Precio Costo, Precio Venta, Stock y Stock Min por favor", MsgBoxStyle.Critical, "Error")
        Else
            dgvProductos.Rows.Add(
                txtNom.Text,
                CBCateg2.SelectedValue,
                txtPCos.Text,
                txtPVent.Text,
                txtStock.Text,
                txtStockMin.Text)
            txtNom.Clear()
            txtPCos.Clear()
            txtPVent.Clear()
            txtStock.Clear()
            txtStockMin.Clear()
        End If
    End Sub

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        txtNom.Clear()
        txtPCos.Clear()
        txtPVent.Clear()
        txtStock.Clear()
        txtStockMin.Clear()
    End Sub

    Private Sub FormProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        ''Try
        ''Producto1.MostrarProductos(CBCateg.SelectedValue, dgvProductos)
        ''Catch ex As Exception
        ''End Try

        Try
            Using contexto As New ProyectoTallerEntities
                Dim objetoPerfil = (From q In contexto.Categorias
                                    Select q).ToList

                CBCateg2.DataSource = objetoPerfil
                CBCateg2.DisplayMember = "descripcion"
                CBCateg2.ValueMember = "id_categoria"
                CBCateg2.SelectedValue = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al Cargar los Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class