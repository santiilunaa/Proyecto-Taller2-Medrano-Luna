Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FormBkp

    Private Sub btnBkp_Click(sender As Object, e As EventArgs) Handles btnBkp.Click
        Try
            connection.Open()
            Dim bkp As New SaveFileDialog() With {
                .Filter = "Backup File | *.bak",
                .FileName = "" + Date.Now.ToString("dd-MM-yyyy")
            }

            If bkp.ShowDialog = DialogResult.OK Then
                Dim sql As String = $"BACKUP DATABASE ProyectoTaller TO DISK = '{bkp.FileName}'"
                Dim cmd As New SqlCommand(sql, connection)
                cmd.ExecuteNonQuery()
                MessageBox.Show("El Back Up se ha generado correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'lblActual.Text = "Ultima ACtualizacion: " + Date.Now.ToString("dd-MM-yyyy")
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo crear el Back Up", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connection.Close()
        End Try

    End Sub

End Class