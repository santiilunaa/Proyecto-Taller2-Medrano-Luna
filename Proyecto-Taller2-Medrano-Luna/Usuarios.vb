'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Usuarios
    Public Property id_usuario As Integer
    Public Property id_perfil As Integer
    Public Property dni As Integer
    Public Property nombre As String
    Public Property apellido As String
    Public Property usuario As String
    Public Property contraseña As String
    Public Property email As String
    Public Property telefono As Integer
    Public Property eliminado As Boolean

    Public Overridable Property Perfiles As Perfiles
    Public Overridable Property Ventas_cabecera As ICollection(Of Ventas_cabecera) = New HashSet(Of Ventas_cabecera)

End Class
