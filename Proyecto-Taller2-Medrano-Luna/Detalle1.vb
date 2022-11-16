Public Class Detalle1
    Public id_detalle As Integer
    Public id_venta As Integer
    Public id_producto As Integer
    Public cantidad As Integer
    Public sub_total As Decimal

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_id As Integer, ByVal p_id_venta As Integer, ByVal p_producto As Integer, ByVal p_cantidad As Integer, ByVal p_factura As Integer)
        SetId_detalle(p_id)
        SetId_venta(p_id_venta)
        setid_producto(p_producto)
        SetCantidad(p_cantidad)
        Setsub_total(p_factura)
    End Sub

#End Region

#Region "Get/Set"

#Region "Get"

    Public Function GetIdDetalle()
        Return id_detalle
    End Function
    Public Function Getid_venta()
        Return id_venta
    End Function

    Public Function getId_producto()
        Return id_producto
    End Function
    Public Function GetCantidad()
        Return cantidad
    End Function
    Public Function GetSub_total()
        Return sub_total
    End Function

#End Region

#Region "Set"

    Private Sub SetId_detalle(ByVal p_id As Integer)
        id_detalle = p_id
    End Sub
    Private Sub SetId_venta(ByVal p_id_venta As Integer)
        id_venta = p_id_venta
    End Sub

    Private Sub setid_producto(ByVal p_id_producto As Integer)
        id_producto = p_id_producto
    End Sub
    Private Sub SetCantidad(ByVal p_cantidad As Integer)
        cantidad = p_cantidad
    End Sub
    Private Sub Setsub_total(ByVal p_factura As Integer)
        sub_total = p_factura
    End Sub

#End Region

#End Region

#Region "Procedimientos"

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


#End Region
End Class