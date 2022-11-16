Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class FormProductos

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        abrir()
        da = New SqlDataAdapter("MOSTRAR_PRODUCTOS", connection)
        da.Fill(dt)
        dgvProductos.DataSource = dt
        cerrar()

    End Sub


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

        ElseIf Not IsNumeric(txtPCos.Text) Or Not IsNumeric(txtPVent.Text) Or Not IsNumeric(txtStock.Text) Or Not IsNumeric(txtStockMin.Text) Then
            MsgBox("solo valores numéricos en Precio Costo, Precio Venta, Stock y Stock Min por favor", MsgBoxStyle.Critical, "Error")
        Else
            Dim result As MsgBoxResult = MsgBox("¿Desea agregar un nuevo producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Agregar Producto")
            If result = MsgBoxResult.Yes Then
                Dim producto As New Producto1(CBCateg2.SelectedValue, txtNom.Text, txtPCos.Text, txtPVent.Text, txtStock.Text, txtStockMin.Text, 0, "no")
                If producto.Agregar() Then
                    MessageBox.Show("El Producto ha sido agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    CBCateg2.Text = ""
                    txtPCos.Clear()
                    txtNom.Clear()
                    txtPVent.Clear()
                    txtStock.Clear()
                    txtStockMin.Clear()
                    pnlAgregar.Visible = False
                    Mostrar()
                Else
                    MessageBox.Show("Error al Agregar el Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                pnlAgregar.Visible = False
            End If
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
        Mostrar()

        Try
            Using contexto As New ProyectoTallerEntities5
                Dim objetoPerfil = (From q In contexto.Categorias
                                    Select q).ToList

                CBCateg2.DataSource = objetoPerfil
                CBCateg2.DisplayMember = "descripcion"
                CBCateg2.ValueMember = "id_categoria"
                CBCateg2.SelectedValue = -1

                CBCateg3.DataSource = objetoPerfil
                CBCateg3.DisplayMember = "descripcion"
                CBCateg3.ValueMember = "id_categoria"
                CBCateg3.SelectedValue = -1


            End Using
        Catch ex As Exception
            MessageBox.Show("Error al Cargar los Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        pnlModPRo.Visible = True
        Using produ As New ProyectoTallerEntities5
            Dim prod As New Productos
            Dim id As String


            id = dgvProductos.CurrentRow.Cells(0).Value.ToString()
            lblId.Text = id
            CBCateg3.Text = dgvProductos.CurrentRow.Cells(1).Value.ToString()
            txtNom2.Text = dgvProductos.CurrentRow.Cells(2).Value.ToString()
            txtPCos2.Text = dgvProductos.CurrentRow.Cells(3).Value
            txtPVent2.Text = dgvProductos.CurrentRow.Cells(4).Value
            txtStock2.Text = dgvProductos.CurrentRow.Cells(5).Value
            txtStockMin2.Text = dgvProductos.CurrentRow.Cells(6).Value

        End Using

    End Sub

    Private Sub btnGuarMod_Click(sender As Object, e As EventArgs) Handles btnGuarMod.Click
        If (CBCateg3.Text = "") Or (txtNom2.Text = "") Or (txtPCos2.Text = "") Or (txtPVent2.Text = "") Or (txtStock2.Text = "") Or (txtStockMin2.Text = "") Then
            MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
        ElseIf IsNumeric(txtNom2.Text) Then
            MsgBox("Complete con valores alfabeticos en nombre y categoria por favor", MsgBoxStyle.Critical, "Error")

        ElseIf Not IsNumeric(txtPCos2.Text) Or Not IsNumeric(txtPVent2.Text) Or Not IsNumeric(txtStock2.Text) Or Not IsNumeric(txtStockMin2.Text) Then
            MsgBox("solo valores numéricos en Precio Costo, Precio Venta, Stock y Stock Min por favor", MsgBoxStyle.Critical, "Error")
        Else
            Dim result As MsgBoxResult = MsgBox("¿Desea modificar el producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Agregar Usuario")
            If result = MsgBoxResult.Yes Then
                Dim producto As New Producto1()
                If producto.Modificar(lblId.Text, CBCateg2.SelectedValue, txtNom2.Text, txtPCos2.Text, txtPVent2.Text, txtStock2.Text, txtStockMin2.Text) Then
                    MessageBox.Show("El Producto ha sido agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    CBCateg3.Text = ""
                    txtPCos2.Clear()
                    txtNom2.Clear()
                    txtPVent2.Clear()
                    txtStock2.Clear()
                    txtStockMin2.Clear()
                    pnlModPRo.Visible = False
                    Mostrar()

                Else
                    MessageBox.Show("Error al Agregar el Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                pnlModPRo.Visible = False
            End If
        End If
    End Sub

    Private Sub btnCance2_Click(sender As Object, e As EventArgs) Handles btnCance2.Click
        pnlModPRo.Visible = False
    End Sub

    Private Sub btnLimp2_Click(sender As Object, e As EventArgs) Handles btnLimp2.Click
        CBCateg3.Text = ""
        txtPCos2.Clear()
        txtNom2.Clear()
        txtPVent2.Clear()
        txtStock2.Clear()
        txtStockMin2.Clear()
    End Sub

    Private Sub rbActivos_Checked(sender As Object, e As EventArgs) Handles rbActivos.CheckedChanged
        If rbActivos.Checked = True Then
            abrir()
            Dim entrada As String = "SELECT * FROM Productos WHERE elim='no'"
            Dim datos As New DataSet
            Dim adaptador As New SqlDataAdapter(entrada, connection)
            adaptador.Fill(datos)
            cerrar()
            Try
                dgvProductos.DataSource = datos.Tables(0)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub rbElimin_CheckedChanged(sender As Object, e As EventArgs) Handles rbElimin.CheckedChanged
        abrir()
        Dim entrada As String = "SELECT * FROM Productos WHERE elim='si'"
        Dim datos As New DataSet
        Dim adaptador As New SqlDataAdapter(entrada, connection)
        adaptador.Fill(datos)
        cerrar()
        Try
            dgvProductos.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Using produ As New ProyectoTallerEntities5
            Dim pro As New Productos
            Dim id As String


            id = dgvProductos.CurrentRow.Cells(0).Value.ToString()
            lvlidsel.Text = Integer.Parse(id)

            Dim result As MsgBoxResult = MsgBox("¿Desea eliminar el producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Eliminar")
            If result = MsgBoxResult.Yes Then
                Dim producto As New Producto1()
                If producto.Borrar(lvlidsel.Text) Then
                    MessageBox.Show("El producto ha sido eliminado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                Else
                    MessageBox.Show("Error al eliminar producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        abrir()
        Dim entrada As String = "SELECT * FROM Productos WHERE descripcion LIKE '%" & txtBuscar.Text & "%'"
        Dim datos As New DataSet
        Dim adaptador As New SqlDataAdapter(entrada, connection)
        adaptador.Fill(datos)
        cerrar()
        Try
            dgvProductos.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        Using produ As New ProyectoTallerEntities5
            Dim pro As New Productos
            Dim id As String


            id = dgvProductos.CurrentRow.Cells(0).Value.ToString()
            lvlidsel.Text = Integer.Parse(id)

            Dim result As MsgBoxResult = MsgBox("¿Desea activar el producto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Eliminar")
            If result = MsgBoxResult.Yes Then
                Dim producto As New Producto1()
                If producto.activar(lvlidsel.Text) Then
                    MessageBox.Show("El producto ha sido activado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                Else
                    MessageBox.Show("Error al activar producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub
End Class