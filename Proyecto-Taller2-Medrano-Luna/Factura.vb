Public Class Factura
#Region "Variables Globales"

    Public producto As New Producto1
    Public factura As New Factura1
    Public detalle As New Detalle1

    Public Tabla As New DataTable

    'Total de la Factura
    Public total As Integer = 0

#Region "Estructura del Detalle"

    Structure productoFactura
        Dim id_producto As Integer
        Dim descripcion As String
        Dim cantidad As Integer
        Dim precio As Decimal
        Dim total_venta As Decimal
    End Structure

#End Region

    Public mercaderia(100) As productoFactura

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles Me.Load
        LVendedor.Text = Module1.us
        LFecha.Text = Date.Now.ToString("dd-MM-yyyy")

        LSubTot.Text = 0

        Tabla.Columns.Add("IDProducto", GetType(Integer)) '0
        Tabla.Columns.Add("Descripcion", GetType(String)) '1
        Tabla.Columns.Add("Cantidad", GetType(Integer)) '2
        Tabla.Columns.Add("P/U $", GetType(Decimal)) '3
        Tabla.Columns.Add("Precio Total $", GetType(Decimal)) '4

        producto.MostrarProductos(dgvFact)

        Dim i As Integer
        i = dgvFact.CurrentRow.Index
        LPrecioUnit.Text = dgvFact.Item(4, i).Value
        LPrecioCant.Text = dgvFact.Item(4, i).Value
        LID.Text = dgvFact.Item(0, i).Value
        LDescr.Text = dgvFact.Item(2, i).Value
        LCant.Text = 1
    End Sub




#End Region

#Region "Buscar"
    Private Sub BSumar_Click(sender As Object, e As EventArgs) Handles BSumar.Click
        LCant.Text += 1
        LPrecioCant.Text = LPrecioUnit.Text * LCant.Text
    End Sub

    Private Sub BRestar_Click(sender As Object, e As EventArgs) Handles BRestar.Click
        If LCant.Text <> 1 Then
            LCant.Text -= 1
            LPrecioCant.Text = LPrecioUnit.Text * LCant.Text
        End If
    End Sub

    Private Sub dgvFact_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFact.CellClick
        Dim i As Integer
        i = dgvFact.CurrentRow.Index
        LPrecioUnit.Text = dgvFact.Item(4, i).Value
        LPrecioCant.Text = dgvFact.Item(4, i).Value
        LID.Text = dgvFact.Item(0, i).Value
        LDescr.Text = dgvFact.Item(2, i).Value
        LCant.Text = 1
    End Sub

    Private Sub txtNomProd_TextChanged(sender As Object, e As EventArgs) Handles txtNomProd.TextChanged
        producto.MostrarNombre(txtNomProd.Text, dgvFact)
    End Sub

#End Region

#Region "Detalle"
    Private Sub btnGuardarPro_Click(sender As Object, e As EventArgs) Handles btnGuardarPro.Click
        'Cargamos a la tabla detalle el producto seleccionado
        Dim i As Integer = dgvFact.CurrentRow.Index
        Dim j As Integer
        Dim carga As Boolean = False

        'Controlamos si el producto seleccionado ya se encuentra cargado o no verificando ademas si al tabla esta vacia
        If dgvDetalle.Rows.Count > 0 Then
            For j = 0 To (dgvDetalle.Rows.Count - 1)
                If dgvDetalle.Item(0, j).Value = LID.Text Then
                    carga = True
                End If
            Next
        End If
        If carga = False Then

            'Controlamos el Stock, si es mayor o igual que la cantidad establecida
            If producto.ConsultarStock(Me.dgvFact.Item(0, i).Value, LCant.Text) Then

                'Se carga la estructura
                mercaderia(0).id_producto = LID.Text
                mercaderia(0).descripcion = LDescr.Text
                mercaderia(0).cantidad = LCant.Text
                mercaderia(0).precio = LPrecioUnit.Text
                mercaderia(0).total_venta = LPrecioCant.Text

                'agregamos a la tabla
                Tabla.Rows.Add(mercaderia(0).id_producto, mercaderia(0).descripcion, mercaderia(0).cantidad, mercaderia(0).precio, mercaderia(0).total_venta)

                dgvDetalle.DataSource = Tabla

                'Actualizamos el total y SubTotal
                total = LPrecioCant.Text + total
                LSubTot.Text = total
            Else
                'Si el stock es menor a la cantidad seleccionada, el sistema nos avisa
                MessageBox.Show("La cantidad seleccionada supera el stock disponible", "Stock no Disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            'Si el producto ya se encuentra cargado, el sistema nos avisa
            MessageBox.Show("El producto ya se encuentra cargado en detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BEliminProd_Click(sender As Object, e As EventArgs) Handles BEliminProd.Click
        'Procedimiento para eliminar un producto de la tabla detalle
        If dgvDetalle.Rows.Count = 0 Then

            'Si ya se encuentra vacio, el sistema nos avisa
            MessageBox.Show("El detalle de factura se encuentra vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Eliminamos el producto seleccionado y actualizamos el total y subtotal
            total = total - dgvDetalle.Item(4, dgvDetalle.CurrentRow.Index).Value
            LSubTot.Text = total

            dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index)
            dgvDetalle.Refresh()
        End If
    End Sub


#End Region

#Region "Facturacion"
    Private Sub BConfir_Click(sender As System.Object, e As System.EventArgs) Handles BConfir.Click
        'Verificamos si la tabla de detalle se encuentra vacia
        If dgvDetalle.Rows.Count = 0 Then
            MsgBox("La tabla detalles se encuentra vacia", MsgBoxStyle.Critical)
        Else
            If MsgBox("¿Confirmar Operacion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Factura") = MsgBoxResult.Yes Then
                Try
                    Using confir As New ProyectoTallerEntities5
                        'Creamos una factura auxiliar para obtener el ultimo numero registrado y el ultimo identificador 
                        '(Esta factura auxiliar no se registra)

                        Dim auxFactura As New Factura1()
                        Dim ultimaFactura As Integer = factura.UltimaFactura()
                        Dim ultimoNumero As Integer = factura.UltimoNumero()

                        'Creamos la factura real 
                        'Esta factura se registra en la base de datos

                        Dim facturaNueva As New Factura1((ultimaFactura + 1), Module1.id_usuario, ultimoNumero, LFecha.Text, total)


                        'Recorremos la tabla "detalle" 
                        'Vamos agregando a los detalles de la factura recien creada

                        Dim i As Integer = 0
                        Dim row As System.Windows.Forms.DataGridViewRow
                        Dim ultimo As Integer = detalle.UltimoDetalle()
                        While i < (Me.dgvDetalle.Rows.Count)
                            row = Me.dgvDetalle.Rows(i)
                            Dim detalle As New Ventas_detalle
                            With detalle
                                .id_detalle = (ultimo + 1)
                                .id_venta = facturaNueva.GetIdFactu()
                                .id_producto = Me.dgvDetalle.Item(0, i).Value
                                .cantidad = Me.dgvDetalle.Item(2, i).Value
                                .sub_total = LSubTot.Text
                            End With
                            confir.Ventas_detalle.Add(detalle)
                            ultimo += 1

                            producto.ActualizarStock(Me.dgvDetalle.Item(0, i).Value, Me.dgvDetalle.Item(2, i).Value)
                            i += 1

                        End While
                        facturaNueva.Agregar()
                        factura.ActualizarUltimo()
                        confir.SaveChanges()

                        'Confirmamos el exito de la Operacion
                        MessageBox.Show("La operacion se realizo con exito", "Venta Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Actualizamos la lista de Productos
                        producto.MostrarProductos(dgvFact)

                        'Reinicializamos el formulario
                        dgvDetalle.DataSource = Nothing
                        LSubTot.Text = 0
                        total = 0

                    End Using
                Catch Ex As Exception
                    'En caso de Error
                    MessageBox.Show("Error en la operacion")
                End Try
            End If
        End If
    End Sub

#End Region

End Class