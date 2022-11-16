Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormClientes
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pnlAgregar.Visible = True
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlAgregar.Visible = False
    End Sub

    Private Sub btnGuardarC_Click(sender As Object, e As EventArgs) Handles btnGuardarC.Click
        Using connection As New SqlConnection("Data Source=DESKTOP-GQ798UG\SQLEXPRESS_INST;Initial Catalog=ProyectoTaller;Integrated Security=True")
            Dim consultaSql As String = "SELECT COUNT(*) FROM Clientes WHERE (dni=@dni)"
            Dim comando As New SqlCommand(consultaSql, connection)
            comando.Parameters.AddWithValue("@dni", txtDni.Text)
            connection.Open()
            Dim Existe As Boolean = Convert.ToInt32(comando.ExecuteScalar) > 0


            If (txtDni.Text = "") Or (txtNom.Text = "") Or (txtApe.Text = "") Or (txtEmail.Text = "") Or (txtDomic.Text = "") Or (txtTelef.Text = "") Then
                MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
            ElseIf IsNumeric(txtNom.Text) Or IsNumeric(txtApe.Text) Or IsNumeric(txtEmail.Text) Or IsNumeric(txtDomic.Text) Then
                MsgBox("Complete con valores alfabeticos en nombre, apellido, email y domicilio por favor", MsgBoxStyle.Critical, "Error")

            ElseIf Not IsNumeric(txtDni.Text) Or Not IsNumeric(txtTelef.Text) Then
                MsgBox("solo valores numéricos en dni y telefono por favor", MsgBoxStyle.Critical, "Error")
            Else

                If Existe Then
                    MsgBox("El dni ingresado ya existe", vbCritical, "Error")
                Else
                    Dim result As MsgBoxResult
                    result = MsgBox("¿Desea terminar y registrar el nuevo cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Confirmación")
                    If result = vbYes Then
                        Try
                            Dim cmd As New SqlCommand
                            abrir()
                            cmd = New SqlCommand("INSERTAR_CLIENTES", connection)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@dni", txtDni.Text)
                            cmd.Parameters.AddWithValue("@nombre", txtNom.Text)
                            cmd.Parameters.AddWithValue("@apellido", txtApe.Text)
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                            cmd.Parameters.AddWithValue("@domicilio", txtDomic.Text)
                            cmd.Parameters.AddWithValue("@telefono", txtTelef.Text)
                            cmd.ExecuteNonQuery()
                            MsgBox("Cliente registrado", MsgBoxStyle.OkOnly)
                            cerrar()
                            txtDni.Clear()
                            txtNom.Clear()
                            txtApe.Clear()
                            txtEmail.Clear()
                            txtDomic.Clear()
                            txtTelef.Clear()
                            Mostrar()
                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try

                    End If
                End If
            End If
        End Using
    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        abrir()
        da = New SqlDataAdapter("MOSTRAR_CLIENTES", connection)
        da.Fill(dt)
        dgvClientes.DataSource = dt
        cerrar()

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        abrir()
        Dim entrada As String = "SELECT * FROM Clientes WHERE dni LIKE '%" & txtBuscar.Text & "%' or nombre LIKE '%" & txtBuscar.Text & "%'"
        Dim datos As New DataSet
        Dim adaptador As New SqlDataAdapter(entrada, connection)
        adaptador.Fill(datos)
        cerrar()
        Try
            dgvClientes.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Panel1.Visible = True
        Using clien As New ProyectoTallerEntities5
            Dim cli As New Usuarios
            Dim id As String


            id = dgvClientes.CurrentRow.Cells(0).Value.ToString()
            lblId.Text = Integer.Parse(id)
            lvlidsel.Text = Integer.Parse(id)
            txtDni2.Text = dgvClientes.CurrentRow.Cells(1).Value.ToString()
            txtNom2.Text = dgvClientes.CurrentRow.Cells(2).Value.ToString()
            txtApe2.Text = dgvClientes.CurrentRow.Cells(3).Value.ToString()
            txtEmail2.Text = dgvClientes.CurrentRow.Cells(4).Value.ToString()
            txtDomic2.Text = dgvClientes.CurrentRow.Cells(5).Value.ToString()
            txtTelef2.Text = dgvClientes.CurrentRow.Cells(6).Value.ToString()

        End Using
    End Sub

    Private Sub btnGuarMod_Click(sender As Object, e As EventArgs) Handles btnGuarMod.Click
        If (txtDni2.Text = "") Or (txtNom2.Text = "") Or (txtApe2.Text = "") Or (txtDomic2.Text = "") Or (txtEmail2.Text = "") Or (txtTelef2.Text = "") Then
            MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
        ElseIf IsNumeric(txtNom2.Text) Or IsNumeric(txtApe2.Text) Or IsNumeric(txtEmail2.Text) Then
            MsgBox("Complete con valores alfabeticos en nombre, apellido, usuario y email por favor", MsgBoxStyle.Critical, "Error")

        ElseIf Not IsNumeric(txtDni2.Text) Or Not IsNumeric(txtTelef2.Text) Then
            MsgBox("solo valores numéricos en dni y telefono por favor", MsgBoxStyle.Critical, "Error")
        Else
            Dim result As MsgBoxResult = MsgBox("¿Desea modificar un nuevo Cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Modificar Usuario")
            If result = MsgBoxResult.Yes Then
                Dim cliente As New Cliente1()
                If cliente.Modificar(lblId.Text, txtDni2.Text, txtNom2.Text, txtApe2.Text, txtEmail2.Text, txtDomic2.Text, txtTelef2.Text) Then
                    MessageBox.Show("El Cliente ha sido modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtDni2.Clear()
                    txtNom2.Clear()
                    txtApe2.Clear()
                    txtEmail2.Clear()
                    txtDomic2.Clear()
                    txtTelef2.Clear()
                    Panel1.Visible = False
                    Mostrar()
                Else
                    MessageBox.Show("Error al Modificar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Panel1.Visible = False
            End If
        End If
    End Sub

    Private Sub btnCanceMod_Click(sender As Object, e As EventArgs) Handles btnCanceMod.Click
        Panel1.Visible = False
    End Sub


    Private Sub rbElimin_CheckedChanged(sender As Object, e As EventArgs) Handles rbElimin.CheckedChanged
        abrir()
        Dim entrada As String = "SELECT * FROM Clientes WHERE elim='si'"
        Dim datos As New DataSet
        Dim adaptador As New SqlDataAdapter(entrada, connection)
        adaptador.Fill(datos)
        cerrar()
        Try
            dgvClientes.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbActivos_CheckedChanged(sender As Object, e As EventArgs) Handles rbActivos.CheckedChanged
        abrir()
        Dim entrada As String = "SELECT * FROM Clientes WHERE elim='no'"
        Dim datos As New DataSet
        Dim adaptador As New SqlDataAdapter(entrada, connection)
        adaptador.Fill(datos)
        cerrar()
        Try
            dgvClientes.DataSource = datos.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Using clien As New ProyectoTallerEntities5
            Dim cli As New Usuarios
            Dim id As String


            id = dgvClientes.CurrentRow.Cells(0).Value.ToString()
            lvlidsel.Text = Integer.Parse(id)
            Dim result As MsgBoxResult = MsgBox("¿Desea eliminar el Cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Eliminar")
            If result = MsgBoxResult.Yes Then
                Dim cliente As New Cliente1()
                If cliente.Eliminar(lvlidsel.Text) Then
                    MessageBox.Show("El Cliente ha sido modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                Else
                    MessageBox.Show("Error al eliminar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        Using clien As New ProyectoTallerEntities5
            Dim cli As New Usuarios
            Dim id As String


            id = dgvClientes.CurrentRow.Cells(0).Value.ToString()
            lvlidsel.Text = Integer.Parse(id)
            Dim result As MsgBoxResult = MsgBox("¿Desea activar el Cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + vbDefaultButton2, "Eliminar")
            If result = MsgBoxResult.Yes Then
                Dim cliente As New Cliente1()
                If cliente.Activar(lvlidsel.Text) Then
                    MessageBox.Show("El Cliente ha sido activado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar()
                Else
                    MessageBox.Show("Error al activar cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Using
    End Sub

End Class