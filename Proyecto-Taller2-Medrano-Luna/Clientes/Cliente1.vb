Public Class Cliente1
    Private id_cliente As Integer
    Private dni As Integer
    Private nombre As String
    Private apellido As String
    Private email As String
    Private domicilio As String
    Private telefono As Integer
    Private elim As String

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_id As Integer, ByVal p_dni As Integer, ByVal p_nombre As String, ByVal p_ape As String, ByVal p_email As String, ByVal p_domicilio As String, ByVal p_tel As Integer)
        setId(p_id)
        setDni(p_dni)
        setNombre(p_nombre)
        setApe(p_ape)
        setEmail(p_email)
        setDomicilio(p_domicilio)
        setTel(p_tel)
    End Sub

    Public Sub New(ByVal p_isbn As Integer)
        ''setIsbn(p_isbn)
        ''setNombre("")
        ''setAutor(0)
        ''setAnio(0)
        ''setGenero(0)
        ''setEditorial(0)
        '' setPais(0)
        ''   setPrecio(0)
        ''     setStock(0)
    End Sub

#End Region

#Region "Get/Set"

#Region "Get"

    Public Function getId()
        Return id_cliente
    End Function
    Public Function getDni()
        Return dni
    End Function

    Public Function getNombre()
        Return nombre
    End Function

    Public Function getApe()
        Return apellido
    End Function

    Public Function getEmail()
        Return email
    End Function

    Public Function getDomicilio()
        Return domicilio
    End Function

    Public Function getTel()
        Return telefono
    End Function

#End Region

#Region "Set"

    Private Sub setId(ByVal p_id As Integer)
        id_cliente = p_id
    End Sub
    Private Sub setDni(ByVal p_dni As Integer)
        dni = p_dni
    End Sub

    Private Sub setNombre(ByVal p_nombre As String)
        nombre = p_nombre
    End Sub

    Private Sub setApe(ByVal p_ape As String)
        apellido = p_ape
    End Sub

    Private Sub setEmail(ByVal p_email As String)
        email = p_email
    End Sub

    Private Sub setDomicilio(ByVal p_domicilio As String)
        domicilio = p_domicilio
    End Sub

    Private Sub setTel(ByVal p_tel As Integer)
        telefono = p_tel
    End Sub

#End Region

#End Region

#Region "Procedimientos"
    Public Function Modificar(ByVal p_id_cliente As Integer, ByVal p_dni As Integer, ByVal p_nombre As String, ByVal p_ape As String, ByVal p_email As String, ByVal p_domicilio As String, ByVal p_tel As Integer)
        Try
            Using MDF As New ProyectoTallerEntities5
                Dim objetoModificar = (From q In MDF.Clientes
                                       Where q.id_cliente = p_id_cliente
                                       Select q).First

                objetoModificar.dni = p_dni
                objetoModificar.nombre = p_nombre
                objetoModificar.apellido = p_ape
                objetoModificar.email = p_email
                objetoModificar.domicilio = p_domicilio
                objetoModificar.telefono = p_tel

                MDF.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal p_id_cliente As Integer)
        Try
            Using MDF As New ProyectoTallerEntities5
                Dim objetoModificar = (From q In MDF.Clientes
                                       Where q.id_cliente = p_id_cliente
                                       Select q).First

                objetoModificar.elim = "si"

                MDF.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Activar(ByVal p_id_cliente As Integer)
        Try
            Using MDF As New ProyectoTallerEntities5
                Dim objetoModificar = (From q In MDF.Clientes
                                       Where q.id_cliente = p_id_cliente
                                       Select q).First

                objetoModificar.elim = "no"

                MDF.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CargarBorrar(ByVal combo As ComboBox)
        Try
            Using Base As New ProyectoTallerEntities5
                ''Dim qLibros = (From q In Base.Usuarios Select New With {.idef = q.isbn, .nombrel = q.isbn & ": " & q.nombre}).ToList

                ''combo.DataSource = qLibros
                combo.DisplayMember = "nombrel"
                combo.ValueMember = "idef"
                combo.SelectedValue = -1
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function MostrarNombre(ByVal p_nombre As String, ByVal grid As DataGridView)
        Try
            Using Mostrar As New ProyectoTallerEntities5
                Dim objMostrar = (From q In Mostrar.Clientes Where q.nombre.StartsWith(p_nombre)
                                  Select IDProducto = q.id_cliente, Nombre = q.nombre, Apellido = q.apellido,
                                      Email = q.email, Domicilio = q.domicilio, Telefono = q.telefono).ToList

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

#End Region
End Class
