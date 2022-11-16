Public Class Factura1
    Private id_venta As Integer
    Private id_usuario As Integer
    Private id_numero As Integer
    Private fecha_venta As Date
    Private total_venta As Decimal

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_id_fact As Integer, ByVal p_usuar As Integer, ByVal p_num As Integer, ByVal p_fech As Date, ByVal p_total As Decimal)
        SetIdFactu(p_id_fact)
        SetidUsuario(p_usuar)
        setNum(p_num)
        SetFecha(p_fech)
        SetTotal(p_total)
    End Sub

#End Region

#Region "Get/Set"

#Region "Get"

    Public Function GetIdFactu()
        Return id_venta
    End Function

    Public Function GetUsuario()
        Return id_usuario
    End Function

    Public Function GetNum()
        Return id_numero
    End Function

    Public Function GetFecha()
        Return fecha_venta
    End Function

    Public Function GetTotal()
        Return total_venta
    End Function

#End Region

#Region "Set"

    Private Sub SetIdFactu(ByVal p_id_fact As Integer)
        id_venta = p_id_fact
    End Sub

    Private Sub SetidUsuario(ByVal p_usuar As Integer)
        id_usuario = p_usuar
    End Sub

    Private Sub setNum(ByVal p_num As Integer)
        id_numero = p_num
    End Sub

    Private Sub SetFecha(ByVal p_fech As Date)
        fecha_venta = p_fech
    End Sub

    Private Sub SetTotal(ByVal p_total As Decimal)
        total_venta = p_total
    End Sub

#End Region

#End Region

#Region "Procedimientos"

    Public Function UltimoNumero()
        Try
            Using UltNum As New ProyectoTallerEntities5
                Dim qUltimo = (From q In UltNum.NroFactura Select q).ToList
                Dim contador As Integer = qUltimo.Count
                Return qUltimo.Item(contador - 1).id_numero
            End Using
        Catch Ex As Exception
            Return MessageBox.Show("Error al obtener ultimo numero")
        End Try
    End Function

    Public Function UltimaFactura()
        Try
            Using DBF As New ProyectoTallerEntities5
                Dim qUltimo = (From q In DBF.Ventas_cabecera Select q).ToList
                Dim contador As Integer = qUltimo.Count
                If contador = 0 Then
                    Return 0
                Else
                    Return qUltimo.Item(contador - 1).id_venta
                End If
            End Using
        Catch ex As Exception
            Return MessageBox.Show("Error al obtener ultima factura")
        End Try
    End Function

    Public Function Agregar()
        Try
            Using AgfFac As New ProyectoTallerEntities5
                Dim datos As New Ventas_cabecera
                With datos
                    .id_venta = GetIdFactu()
                    .id_usuario = GetUsuario()
                    .id_numero = GetNum()
                    .fecha_venta = GetFecha()
                    .total_venta = GetTotal()
                End With

                AgfFac.Ventas_cabecera.Add(datos)
                AgfFac.SaveChanges()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ActualizarUltimo()
        Try
            Using ActUlt As New ProyectoTallerEntities5
                Dim qUltimo = (From q In ActUlt.NroFactura Select q).ToList
                Dim contador As Integer = qUltimo.Count

                Dim nuevo As New NroFactura
                With nuevo
                    .id_numero = (qUltimo.Item(contador - 1).id_numero) + 1
                    .ultimo = (qUltimo.Item(contador - 1).ultimo) + 1
                End With

                ActUlt.NroFactura.Add(nuevo)
                ActUlt.SaveChanges()
            End Using
            Return True
        Catch e As Exception
            Return MessageBox.Show("Error al actualizar ultimo numero")
        End Try
    End Function

    Public Function UltimoDetalle()
        Try
            Using ultDet As New ProyectoTallerEntities5
                Dim qUltimo = (From q In ultDet.Ventas_detalle Select q).ToList
                Dim contador As Integer = qUltimo.Count

                If contador = 0 Then
                    Return 0
                Else
                    Return qUltimo.Item(contador - 1).id_detalle
                End If
            End Using
        Catch Ex As Exception
            Return MessageBox.Show("Error al obtener ultimo detalle")
        End Try
    End Function

    Public Function AgregarDetalle(ByVal p_numero As Integer, ByVal p_id_prod As Integer, ByVal p_cantidad As Integer, ByVal p_factura As Integer, ByVal p_subtotal As Decimal)
        Try
            Using DBF As New ProyectoTallerEntities5
                Dim detalle As New Ventas_detalle
                With detalle
                    .id_detalle = p_numero
                    .id_venta = p_factura
                    .id_producto = p_id_prod
                    .cantidad = p_cantidad
                    .sub_total = p_subtotal
                End With

                DBF.Ventas_detalle.Add(detalle)
                DBF.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function MostrarFecha(ByVal grid As DataGridView, ByVal desde As Date, ByVal hasta As Date)
        Try
            Using DBF As New ProyectoTallerEntities5
                Dim objMostrar = (From q In DBF.Ventas_cabecera Where (q.fecha_venta >= desde And q.fecha_venta <= hasta)
                                  Select Numero = q.id_numero, Fecha = q.fecha_venta, Total = q.total_venta, Vendedor = (q.Usuarios.usuario)).ToList

                grid.DataSource = objMostrar
            End Using
        Catch ex As Exception

        End Try
    End Function
#End Region
End Class
