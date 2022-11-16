Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Resguardo

    Private nombre As String
    Private ubicacion As String
    Private fecha As Date
    Private estado As Integer
    Private direccion As String

#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal p_nombreResg As String, ByVal p_ubi As String, ByVal p_fech As Date, ByVal p_est As Integer, ByVal p_direc As String)
        setNombreResg(p_nombreResg)
        setUbi(p_ubi)
        setFech(p_fech)
        setEstad(p_est)
        setDirec(p_direc)
    End Sub

#End Region

#Region "Get/Set"

#Region "Get"

    Public Function getNombreResg()
        Return nombre
    End Function
    Public Function getUbi()
        Return ubicacion
    End Function

    Public Function getFech()
        Return fecha
    End Function

    Public Function getEstad()
        Return estado
    End Function

    Public Function getDirec()
        Return direccion
    End Function
#End Region

#Region "Set"

    Private Sub setNombreResg(ByVal p_nombreResg As String)
        nombre = p_nombreResg
    End Sub

    Private Sub setUbi(ByVal p_ubi As String)
        ubicacion = p_ubi
    End Sub

    Private Sub setFech(ByVal p_fech As String)
        fecha = p_fech
    End Sub

    Private Sub setEstad(ByVal p_est As String)
        estado = p_est
    End Sub

    Private Sub setDirec(ByVal p_direc As String)
        direccion = p_direc
    End Sub
#End Region

#End Region

#Region "Procedimientos"
    Public Function resguardaDatos(p_nombreResg As String, p_ubi As String)
        Try
            Dim connection As New SqlConnection("Data Source=DESKTOP-GQ798UG\SQLEXPRESS_INST;Initial Catalog=ProyectoTaller;Integrated Security=True")
            Using connection
                connection.Open()
                Dim cmd As New SqlCommand("RESGUARDAR")
                cmd.Parameters().Add(New SqlParameter("@nombre", p_nombreResg))
                cmd.Parameters().Add(New SqlParameter("@ubicacion", p_ubi))
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = connection
                connection.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class
