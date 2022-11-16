Public Class Ventas
    Public producto As New Producto1
    Public factura As New Factura1
    Public tabla As New DataTable

    Private Sub btnExportar_clic(sender As Object, e As EventArgs) Handles btnExportar.Click
        llenarExcel(DataGridView1)
    End Sub

    Private Sub btnFilt_Click(sender As Object, e As EventArgs) Handles btnFilt.Click
        Dim desde As Date = DThasta.Text
        Dim hasta As Date = DThasta.Text
        factura.MostrarFecha(DataGridView1, desde, hasta)
    End Sub
End Class