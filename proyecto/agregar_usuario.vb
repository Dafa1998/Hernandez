Public Class agregar_usuario
    Dim obj_gestion As New gestion_db
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cadena As String

        cadena = "insert into usuarios (nombre_usuario, contrasenia) values ('" & txtusuario.Text & "','" & txtpass.Text & "')"
        obj_gestion.abrir_conexion()
        obj_gestion.agregar(cadena)
        obj_gestion.cerrar_conexion()
        frm_usuario.listardatos("select * from usuarios")
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()

    End Sub
End Class