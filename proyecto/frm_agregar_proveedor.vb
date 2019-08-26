Public Class frm_agregar_proveedor
    Dim obj_gestion As New gestion_db
    Dim dt_proveedor As New DataTable
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cadena As String
        cadena = "insert into proveedores values (" & txtidproveedor.Text & "," & Txtnombre.Text & "," _
               & txtdireccion.Text & "," & txtciudad.Text & "," & txttelefono.Text & "," & txtemail.Text & ")"
        obj_gestion.abrir_conexion()
        obj_gestion.agregar(cadena)
        obj_gestion.cerrar_conexion()
        frm_Producto.listardatos("select * from proveedores")
        Me.Close()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class