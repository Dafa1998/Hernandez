Public Class modificar_usuario
    Dim obj_gestion As New gestion_db
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cadena As String

        cadena = "update usuarios set nombre_usuario='" & txtusuario.Text & "', contrasenia='" & txtpass.Text & "' " & _
            "where id_usuario=" & frm_usuario.id_usuario
        obj_gestion.abrir_conexion()
        obj_gestion.modificar(cadena)
        obj_gestion.cerrar_conexion()
        frm_usuario.listardatos("select * from usuarios")
        Me.Close()
    End Sub

    Private Sub modificar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusuario.Text = frm_usuario.Nombre_usuario
        txtpass.Text = frm_usuario.contrasenia
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class