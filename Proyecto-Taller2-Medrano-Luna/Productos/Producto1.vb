﻿Public Class Producto1
    Private id_producto As Integer
    Private id_categoria As Integer
    Private descripcion As String
    Private precio_costo As Integer
    Private precio_venta As Integer
    Private stock As Integer
    Private stock_min As Integer
    Private eliminado As Integer
    Private elim As String

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_categ As Integer, ByVal p_descrip As String, ByVal p_costo As Integer, ByVal p_venta As Integer, ByVal p_stock As Integer, ByVal p_stockmin As Integer, ByVal p_eliminado As Integer, ByVal p_elim As String)
        setCateg(p_categ)
        setDescrip(p_descrip)
        setCosto(p_costo)
        setVenta(p_venta)
        setStock(p_stock)
        setStockMin(p_stockmin)
        setEliminado(p_eliminado)
        SetElim(p_elim)

    End Sub


#End Region

#Region "Get/Set"

#Region "Get"

    Public Function getIdProd()
        Return id_producto
    End Function

    Public Function getCateg()
        Return id_categoria
    End Function
    Public Function getDescrip()
        Return descripcion
    End Function

    Public Function getCosto()
        Return precio_costo
    End Function

    Public Function getVenta()
        Return precio_venta
    End Function

    Public Function getStock()
        Return stock
    End Function

    Public Function getStockMin()
        Return stock_min
    End Function

    Public Function getEliminado()
        Return eliminado
    End Function

    Public Function getElim()
        Return elim
    End Function

#End Region

#Region "Set"

    Private Sub setIdProducto(ByRef p_id_producto As Integer)
        id_producto = p_id_producto
    End Sub
    Private Sub setCateg(ByVal p_categ As Integer)
        id_categoria = p_categ
    End Sub

    Private Sub setDescrip(ByVal p_descrip As String)
        descripcion = p_descrip
    End Sub

    Private Sub setCosto(ByVal p_costo As Integer)
        precio_costo = p_costo
    End Sub

    Private Sub setVenta(ByVal p_venta As Integer)
        precio_venta = p_venta
    End Sub

    Private Sub setStock(ByVal p_stock As Integer)
        stock = p_stock
    End Sub

    Private Sub setStockMin(ByVal p_stockmin As Integer)
        stock_min = p_stockmin
    End Sub

    Private Sub setEliminado(ByVal p_eliminado As Integer)
        eliminado = p_eliminado
    End Sub

    Private Sub setElim(ByVal p_elim As String)
        elim = p_elim
    End Sub
#End Region

#End Region

#Region "Procedimientos"



    Public Function Verificar(ByVal p_dni As Integer)
        Try
            Using verif As New ProyectoTallerEntities5
                Dim objetoVerificar = (From q In verif.Usuarios
                                       Where q.dni = p_dni
                                       Select q).First
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Agregar()
        Try
            Using Agg As New ProyectoTallerEntities5
                Dim datos As New Productos
                With datos
                    .id_categoria = getCateg()
                    .descripcion = getDescrip()
                    .precio_costo = getCosto()
                    .precio_venta = getVenta()
                    .stock = getStock()
                    .stock_min = getStockMin()
                    .eliminado = 0
                    .elim = "no"
                End With

                Agg.Productos.Add(datos)
                Agg.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Modificar(ByVal p_prod As Integer, ByVal p_categ As Integer, ByVal p_descrip As String, ByVal p_costo As Integer, ByVal p_venta As Integer, ByVal p_stock As Integer, ByVal p_stockmin As Integer)
        Try
            Using modif As New ProyectoTallerEntities5
                Dim objetoModificar = (From q In modif.Productos
                                       Where q.id_producto = p_prod
                                       Select q).First

                objetoModificar.id_categoria = p_categ
                objetoModificar.descripcion = p_descrip
                objetoModificar.precio_costo = p_costo
                objetoModificar.precio_venta = p_venta
                objetoModificar.stock = p_stock
                objetoModificar.stock_min = p_stockmin

                modif.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Borrar(ByVal p_prod As Integer)
        Try
            Using borr As New ProyectoTallerEntities5
                Dim objetoBorrar = (From q In borr.Productos
                                    Where q.id_producto = p_prod
                                    Select q).First()

                objetoBorrar.elim = "si"
                borr.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function ObtenerDatos(ByVal p_prod As Integer)
        Try
            Using dts As New ProyectoTallerEntities5
                Dim datos As Productos = (From q In dts.Productos Where (p_prod = q.id_producto) Select q).First()

                setCateg(datos.id_categoria)
                setDescrip(datos.descripcion)
                setCosto(datos.precio_costo)
                setVenta(datos.precio_venta)
                setStock(datos.stock)
                setStockMin(datos.stock_min)

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ConsultarStock(ByVal p_prod As Integer, ByVal p_cantidad As Integer)
        Using consulstock As New ProyectoTallerEntities5
            Dim producto = (From q In consulstock.Productos Where q.id_producto = p_prod Select q).First

            If producto.stock >= p_cantidad Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function



    Public Function ActualizarStock(ByVal p_prod As Integer, ByVal p_cantidad As Integer)
        Try
            Using ActStock As New ProyectoTallerEntities5
                Dim producto = (From q In ActStock.Productos Where q.id_producto = p_prod Select q).First

                Dim nuevo = producto.stock - p_cantidad
                producto.stock = nuevo
                ActStock.SaveChanges()
                Return True
            End Using
        Catch Ex As Exception
            Return False
        End Try
    End Function

    Public Function MostrarProductos(ByVal grid As DataGridView)
        Try
            Using mostr As New ProyectoTallerEntities5
                Dim objetoMostrar = (From q In mostr.Productos
                                     Select IDProducto = q.id_producto,
                                     Categoria = q.id_categoria,
                                     Nombre = q.descripcion,
                                     Precio_Costo = q.precio_costo,
                                     Precio_Venta = q.precio_venta,
                                     Stock = q.stock,
                                     Stock_Min = q.stock_min,
                                     Eliminado = q.elim).ToList

                grid.DataSource = objetoMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function MostrarNombre(ByVal p_nombre As String, ByVal grid As DataGridView)
        Try
            Using Mostrar As New ProyectoTallerEntities5
                Dim objMostrar = (From q In Mostrar.Productos Where q.descripcion.StartsWith(p_nombre)
                                  Select IDProducto = q.id_producto, Nombre = q.descripcion, Precio_Costo = q.precio_costo,
                                      Precio_Venta = q.precio_venta, Stock = q.stock, Stock_Min = q.stock_min).ToList

                If objMostrar.Count <> 0 Then
                    grid.DataSource = objMostrar
                Else
                    grid.DataSource = Nothing
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function MostrarCategorias(ByVal p_id As Integer, ByVal grid As DataGridView)
        Try
            Using Mostrar As New ProyectoTallerEntities5
                Dim objMostrar = (From q In Mostrar.Usuarios Where p_id = q.Perfiles.id_perfil
                                  Select DNI = q.dni, Nombre = q.nombre, Apellido = q.apellido, Usuario = q.usuario,
                                  Contraseña = q.contraseña, Email = q.email, Telefono = q.telefono).ToList

                If objMostrar.Count <> 0 Then
                    grid.DataSource = objMostrar
                Else
                    grid.DataSource = Nothing
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function activar(ByVal p_id As Integer)
        Try
            Using borr As New ProyectoTallerEntities5
                Dim objetoBorrar = (From q In borr.Productos
                                    Where q.id_producto = p_id
                                    Select q).First()

                objetoBorrar.elim = "no"
                borr.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

End Class