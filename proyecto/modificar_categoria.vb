Public Class modificar_categoria
    Dim obj_gestion As New gestion_db
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cadena As String
        cadena = "update categoria set id_categoria=" & txtidCategoria.Text & ", Nombre_categoria=" & Txtnombre.Text & ", descripcion=" _
               & txtdescripcion.Text & "where id_categoria =" & txtidCategoria.Text
        obj_gestion.abrir_conexion()
        obj_gestion.modificar(cadena)
        obj_gestion.cerrar_conexion()
        frm_categoria.listardatos("select * from categoria ")
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub modificar_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidCategoria.Text = frm_categoria.idcategoria
        Txtnombre.Text = frm_categoria.Nombre
        txtdescripcion.Text = frm_categoria.Descripcion

    End Sub
End Class