Public Class frm_agregar_categoria
    Dim obj_gestion As New gestion_db
    Dim dt_categoria As New DataTable
    
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cadena As String
        cadena = "insert into categorias values (" & txtidCategoria.Text & ",'" & Txtnombre.Text & "','" _
               & txtdescripcion.Text & "')"
        obj_gestion.abrir_conexion()
        obj_gestion.agregar(cadena)
        obj_gestion.cerrar_conexion()
        frm_categoria.listardatos("select * from categorias")
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class