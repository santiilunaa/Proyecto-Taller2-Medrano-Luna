Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FormBkp
    Private Sub btnBkp_Click(sender As Object, e As EventArgs) Handles btnBkp.Click

        Using connection As New SqlConnection("Data Source=SANTI\PROYECTO;Initial Catalog=ProyectoTaller;Integrated Security=True")

            Dim nombre_copia As String = (Date.Today.Day.ToString & "-" & Date.Today.Month.ToString & "-" & Date.Today.Year.ToString & "-" & "Copia de Seguridad")

            Dim copia_comando As String = "BACKUP DATABASE [ProyectoTaller] TO  DISK = N'C:\" & nombre_copia & "' WITH NOFORMAT, NOINIT,  NAME = N'ProyectoTaller-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"

            Dim cmd As SqlCommand = New SqlCommand(copia_comando, connection)

            Try
                abrir()
                cmd.ExecuteNonQuery()
                lblActual.Text = "Ultima Actualización: " & Date.Today.ToString & " "
                MsgBox("La Copia de Seguridad se ha realizado correctamente")
            Catch ex As Exception
                MsgBox("Si desea realizar otra copia reinicie el programa")
            Finally
                Close()
                Dispose()
            End Try
        End Using
    End Sub
End Class