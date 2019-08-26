Public Class usuario
    Dim obj_gestion As New gestion_db
    Dim dt_usuario As New DataTable
    Private Sub btninicio_Click(sender As Object, e As EventArgs) Handles btninicio.Click
        If String.IsNullOrEmpty(Me.txtusuario.Text) Then
            MsgBox("ingrese un nombre de usuario", MsgBoxStyle.Information)
        ElseIf String.IsNullOrEmpty(Me.txtpass.Text) Then
            MsgBox("Ingrese una contraseña", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim cadena As String
        cadena = "select * from usuarios"
        cadena += " where nombre_usuario ='" + txtusuario.Text + "' "
        cadena += " and contrasenia = '" + txtpass.Text + "' "
        obj_gestion.abrir_conexion()
        Me.dt_usuario = obj_gestion.mostrar(cadena)
        obj_gestion.cerrar_conexion()

        If Me.dt_usuario.Rows.Count = 0 Then
            MsgBox("usuario y/o contraseña incorrectos ", MsgBoxStyle.Information)

        ElseIf Me.dt_usuario.Rows.Count = 1 Then
            Form1.MenuStrip1.Enabled = True
            Me.Hide()
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Form1.Close()
    End Sub

    Private Sub usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class