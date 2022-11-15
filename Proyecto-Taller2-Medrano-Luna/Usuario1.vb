Public Class Usuario1
    Private id_perfil As Integer
    Private dni As Integer
    Private nombre As String
    Private apellido As String
    Private usuario As String
    Private contraseña As String
    Private email As String
    Private telefono As Integer

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_perfil As Integer, ByVal p_dni As Integer, ByVal p_nombre As String, ByVal p_ape As String, ByVal p_usua As String, ByVal p_contra As String, ByVal p_email As String, ByVal p_tel As Integer)
        setPerfil(p_perfil)
        setDni(p_dni)
        setNombre(p_nombre)
        setApe(p_ape)
        setUsua(p_usua)
        setContra(p_contra)
        setEmail(p_email)
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

    Public Function getPerfil()
        Return id_perfil
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

    Public Function getusua()
        Return usuario
    End Function

    Public Function getContra()
        Return contraseña
    End Function

    Public Function getEmail()
        Return email
    End Function

    Public Function getTel()
        Return telefono
    End Function

#End Region

#Region "Set"

    Private Sub setPerfil(ByVal p_perfil As Integer)
        id_perfil = p_perfil
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

    Private Sub setUsua(ByVal p_usua As String)
        usuario = p_usua
    End Sub

    Private Sub setContra(ByVal p_contra As String)
        contraseña = p_contra
    End Sub

    Private Sub setEmail(ByVal p_email As String)
        email = p_email
    End Sub

    Private Sub setTel(ByVal p_tel As Integer)
        telefono = p_tel
    End Sub

#End Region

#End Region

#Region "Procedimientos"

    Public Function mostrarusuarios(ByVal grid As DataGridView)
        Try
            Using mstr As New ProyectoTallerEntities
                Dim objetoMostrar = (From q In mstr.Usuarios
                                     Select Perfil = q.id_perfil,
                                     DNI = q.dni,
                                     Nombre = q.nombre,
                                     Apellido = q.apellido,
                                     Usuario = q.usuario,
                                     Contraseña = q.contraseña,
                                     Email = q.email,
                                     Telefono = q.telefono).ToList

                grid.DataSource = objetoMostrar
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Verificar(ByVal p_dni As Integer)
        Try
            Using verif As New ProyectoTallerEntities
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
            Using Agg As New ProyectoTallerEntities
                Dim datos As New Usuarios
                With datos
                    .id_perfil = getPerfil()
                    .dni = getDni()
                    .nombre = getNombre()
                    .apellido = getApe()
                    .usuario = getusua()
                    .contraseña = getContra()
                    .email = getEmail()
                    .telefono = getTel()
                End With

                Agg.Usuarios.Add(datos)
                Agg.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Modificar(ByVal p_id_usuario As Integer, ByVal p_perfil As Integer, ByVal p_dni As Integer, ByVal p_nombre As String, ByVal p_ape As String, ByVal p_usuario As String, ByVal p_contraseña As String, ByVal p_email As String, ByVal p_tel As Integer)
        Try
            Using MDF As New ProyectoTallerEntities
                Dim objetoModificar = (From q In MDF.Usuarios
                                       Where q.id_usuario = p_id_usuario
                                       Select q).First
                objetoModificar.id_perfil = p_perfil
                objetoModificar.dni = p_dni
                objetoModificar.nombre = p_nombre
                objetoModificar.apellido = p_ape
                objetoModificar.usuario = p_usuario
                objetoModificar.contraseña = p_contraseña
                objetoModificar.email = p_email
                objetoModificar.telefono = p_tel

                MDF.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Borrar(ByVal p_dni As Integer)
        Try
            Using borr As New ProyectoTallerEntities
                Dim objetoBorrar = (From q In borr.Usuarios
                                    Where q.dni = p_dni
                                    Select q).First()

                ''borr.Usuarios.DeleteObject(objetoBorrar)
                borr.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CargarBorrar(ByVal combo As ComboBox)
        Try
            Using Base As New ProyectoTallerEntities
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

    Public Function ObtenerDatos(ByVal p_dni As Integer)
        Try
            Using dts As New ProyectoTallerEntities
                Dim datos As Usuarios = (From q In dts.Usuarios Where (p_dni = q.dni) Select q).First()

                setPerfil(datos.id_perfil)
                setDni(datos.dni)
                setNombre(datos.nombre)
                setApe(datos.apellido)
                setUsua(datos.usuario)
                setContra(datos.contraseña)
                setEmail(datos.email)
                setTel(datos.telefono)

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function MostrarPerfiles(ByVal p_id As Integer, ByVal grid As DataGridView)
        Try
            Using Mostrar As New ProyectoTallerEntities
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

#End Region
End Class
