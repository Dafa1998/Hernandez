Public Class frm_usuario
    Dim obj_gestion As New gestion_db
    Dim dt_usuario As New DataTable
    Public Nombre_usuario As String
    Public contrasenia As String
    Public id_usuario As Integer
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        agregar_usuario.Show()
    End Sub

    Private Sub frm_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String
        cadena = "select * from usuarios"
        obj_gestion.abrir_conexion()
        dt_usuario = obj_gestion.mostrar(cadena)
        dgv_data_usuario.DataSource = dt_usuario
        obj_gestion.cerrar_conexion()
    End Sub

    Public Sub listardatos(ByVal micadena As String)
        dt_usuario.Clear()
        obj_gestion.abrir_conexion()
        dt_usuario = obj_gestion.mostrar(micadena)
        dgv_data_usuario.DataSource = dt_usuario
        obj_gestion.cerrar_conexion()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As MsgBoxResult
        Dim cadena As String
        dgv_data_usuario.CurrentRow.Selected = True
        id_usuario = dgv_data_usuario.CurrentRow.Cells(0).Value
        Nombre_usuario = dgv_data_usuario.CurrentRow.Cells(1).Value
        contrasenia = dgv_data_usuario.CurrentRow.Cells(2).Value
        respuesta = MsgBox("desea eliminar el registro de usuario " _
                          & Nombre_usuario & " " & contrasenia, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            cadena = "delete from usuarios where id_usuario =" & id_usuario
            obj_gestion.abrir_conexion()
            obj_gestion.eliminar(cadena)
            obj_gestion.cerrar_conexion()
            Me.listardatos("select *from usuarios")
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        dgv_data_usuario.CurrentRow.Selected = True
        id_usuario = dgv_data_usuario.CurrentRow.Cells(0).Value
        Nombre_usuario = dgv_data_usuario.CurrentRow.Cells(1).Value
        contrasenia = dgv_data_usuario.CurrentRow.Cells(2).Value
        modificar_usuario.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class