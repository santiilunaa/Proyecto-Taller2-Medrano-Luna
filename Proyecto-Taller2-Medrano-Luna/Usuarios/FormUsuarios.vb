Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormUsuarios
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pnlAgregarUs.Visible = True
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        pnlAgregarUs.Visible = False
    End Sub

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        CBPerfil.Text = ""
        txtDNI.Clear()
        txtNom.Clear()
        txtApe.Clear()
        txtUsua.Clear()
        txtContr.Clear()
        txtEmail.Clear()
        txtTel.Clear()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        pnlModifUs.Visible = True
        Using usua As New ProyectoTallerEntities
            Dim usu As New Usuarios
            Dim id As String
            ''Dim idUsuario As Integer

            id = dgvUsuarios.CurrentRow.Cells(0).Value.ToString()
            LblId.Text = Integer.Parse(id)
            CBPerfil2.Text = dgvUsuarios.CurrentRow.Cells(1).Value.ToString()
            txtDNI2.Text = dgvUsuarios.CurrentRow.Cells(2).Value.ToString()
            txtNom2.Text = dgvUsuarios.CurrentRow.Cells(3).Value.ToString()
            txtApe2.Text = dgvUsuarios.CurrentRow.Cells(4).Value.ToString()
            txtUsua2.Text = dgvUsuarios.CurrentRow.Cells(5).Value.ToString()
            txtContr2.Text = dgvUsuarios.CurrentRow.Cells(6).Value.ToString()
            txtEmail2.Text = dgvUsuarios.CurrentRow.Cells(7).Value.ToString()
            txtTel2.Text = dgvUsuarios.CurrentRow.Cells(8).Value.ToString()

        End Using

    End Sub
    Private Sub BBorrarModif_Click(sender As Object, e As EventArgs) Handles BBorrarModif.Click
        CBPerfil.Text = ""
        txtDNI.Clear()
        txtNom.Clear()
        txtApe.Clear()
        txtUsua.Clear()
        txtContr.Clear()
        txtEmail.Clear()
        txtTel.Clear()
    End Sub
    Private Sub BCancelModif_Click(sender As Object, e As EventArgs) Handles BCancelModif.Click
        pnlModifUs.Visible = False
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (txtDNI.Text = "") Or (txtNom.Text = "") Or (txtApe.Text = "") Or (txtUsua.Text = "") Or (txtContr.Text = "") Or (txtEmail.Text = "") Or (txtTel.Text = "") Then
            MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
        ElseIf IsNumeric(txtNom.Text) Or IsNumeric(txtApe.Text) Or IsNumeric(txtEmail.Text) Or IsNumeric(txtUsua.Text) Then
            MsgBox("Complete con valores alfabeticos en nombre, apellido, usuario y email por favor", MsgBoxStyle.Critical, "Error")

        ElseIf Not IsNumeric(txtDNI.Text) Or Not IsNumeric(txtTel.Text) Then
            MsgBox("solo valores numéricos en dni y telefono por favor", MsgBoxStyle.Critical, "Error")
        Else
            If MsgBox("¿Desea agregar un nuevo usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Agregar Usuario") Then
                Dim usuario As New Usuario1(CBPerfil.SelectedValue, txtDNI.Text, txtNom.Text, txtApe.Text, txtUsua.Text, txtContr.Text, txtEmail.Text, txtTel.Text)
                If usuario.Agregar() Then
                    MessageBox.Show("El Usuario ha sido agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    CBPerfil.Text = ""
                    txtDNI.Clear()
                    txtNom.Clear()
                    txtApe.Clear()
                    txtUsua.Clear()
                    txtContr.Clear()
                    txtEmail.Clear()
                    txtTel.Clear()
                Else
                    MessageBox.Show("Error al Agregar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        abrir()
        da = New SqlDataAdapter("MOSTRAR_USUARIOS", connection)
        da.Fill(dt)
        dgvUsuarios.DataSource = dt
        cerrar()

    End Sub

    Private Sub FormUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Mostrar()
        Try
            Using perfiles As New ProyectoTallerEntities
                Dim objetoPerfil = (From q In perfiles.Perfiles
                                    Select q).ToList

                CBPerfil.DataSource = objetoPerfil
                CBPerfil.DisplayMember = "descripcion"
                CBPerfil.ValueMember = "id_perfil"
                CBPerfil.SelectedValue = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al Cargar los Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            Using perfiles As New ProyectoTallerEntities
                Dim objetoPerfil = (From q In perfiles.Perfiles
                                    Select q).ToList

                CBPerfil2.DataSource = objetoPerfil
                CBPerfil2.DisplayMember = "descripcion"
                CBPerfil2.ValueMember = "id_perfil"
                CBPerfil2.SelectedValue = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al Cargar los Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BGuardarModif_Click(sender As Object, e As EventArgs) Handles BGuardarModif.Click
        If (txtDNI2.Text = "") Or (txtNom2.Text = "") Or (txtApe2.Text = "") Or (txtUsua2.Text = "") Or (txtContr2.Text = "") Or (txtEmail2.Text = "") Or (txtTel2.Text = "") Then
            MsgBox("Debe completar todos los campos", 0 + 0 + 64, "Alerta")
        ElseIf IsNumeric(txtNom2.Text) Or IsNumeric(txtApe2.Text) Or IsNumeric(txtEmail2.Text) Or IsNumeric(txtUsua2.Text) Then
            MsgBox("Complete con valores alfabeticos en nombre, apellido, usuario y email por favor", MsgBoxStyle.Critical, "Error")

        ElseIf Not IsNumeric(txtDNI2.Text) Or Not IsNumeric(txtTel2.Text) Then
            MsgBox("solo valores numéricos en dni y telefono por favor", MsgBoxStyle.Critical, "Error")
        Else
            If MsgBox("¿Desea modificar un nuevo usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar Usuario") Then
                Dim usuario As New Usuario1()
                If usuario.Modificar(LblId.Text, CBPerfil2.SelectedValue, txtDNI2.Text, txtNom2.Text, txtApe2.Text, txtUsua2.Text, txtContr2.Text, txtEmail2.Text, txtTel2.Text) Then
                    MessageBox.Show("El Usuario ha sido modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    CBPerfil.Text = ""
                    txtDNI.Clear()
                    txtNom.Clear()
                    txtApe.Clear()
                    txtUsua.Clear()
                    txtContr.Clear()
                    txtEmail.Clear()
                    txtTel.Clear()
                Else
                    MessageBox.Show("Error al Modificar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick
        '' Dim dgv As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)
        '' LblId.Text = dgv.Cells(0).Value.ToString()
    End Sub
End Class