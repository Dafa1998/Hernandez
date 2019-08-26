Imports System.Data
Imports System.Data.SqlClient
Public Class gestion_db
    Private _sqlconexion As New SqlConnection
    Private _sqldataadapter As New SqlDataAdapter
    Private _datatable As New DataTable
    Private _sqlcomando As New SqlCommand
    Private user As String
    Private pass As String

    Sub abrir_conexion()
        _sqlconexion = New SqlConnection("data source=KEYBLADE-PC ;initial catalog=proyecto ; integrated security=true")
        _sqlconexion.Open()
    End Sub

    Sub cerrar_conexion()
        _sqlconexion.Close()
    End Sub

    Public Function mostrar(ByVal paPalabra As String) As DataTable
        Dim dt_dato As New DataTable
        _sqldataadapter = New SqlDataAdapter(paPalabra, _sqlconexion)
        _sqldataadapter.Fill(dt_dato)
        Return dt_dato
    End Function

    Public Sub agregar(ByVal comando As String)
        _sqlcomando = New SqlCommand(comando, _sqlconexion)
        _sqlcomando.ExecuteNonQuery()
        MsgBox("Los datos han sido agregados exitosamente")

    End Sub
    Public Sub eliminar(ByVal comando As String)
        _sqlcomando = New SqlCommand(comando, _sqlconexion)
        _sqlcomando.ExecuteNonQuery()
        MsgBox("Los datos han sido eliminados exitosamente")
    End Sub
    Public Sub modificar(ByVal comando As String)
        _sqlcomando = New SqlCommand(comando, _sqlconexion)
        _sqlcomando.ExecuteNonQuery()
        MsgBox("Los datos han sido modificados exitosamente")
    End Sub

    Public Function confirmar(ByVal usuario As String, ByVal contra As String)
        user = "admin"
        pass = "admin12"
        Dim respuesta1 As String
        Dim respuesta2 As String
        Dim resp As String
        If user = usuario Then
            respuesta1 = "correcto"
        Else
            respuesta1 = "falso"
        End If
        If pass = contra Then
            respuesta2 = "correcto"
        Else
            respuesta2 = "falso"
        End If

        If respuesta1 = "correcto" And respuesta2 = "correcto" Then
            resp = "correcto"
        Else
            resp = "falso"
        End If
        Return resp
    End Function

End Class
