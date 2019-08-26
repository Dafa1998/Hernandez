Public Class modificar_Proveedor
    Dim obj_gestion As New gestion_db
    Private Sub modificar_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidproveedor.Text = frm_proveedor.idproveedor
        Txtnombre.Text = frm_proveedor.nombreProveedor
        txttelefono.Text = frm_proveedor.telefono
        txtdireccion.Text = frm_proveedor.direccion
        txtciudad.Text = frm_proveedor.ciudad
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim cadena As String
        cadena = "update proveedor set Nomb_proveedor=" & Txtnombre.Text & ", direccion=" & _
            txtdireccion.Text & ", ciudad=" & txtciudad.Text & ", telefono=" & txttelefono.Text & _
            ", Email=" & txtemail.Text & "where id_proveedor=" & txtidproveedor.Text
        obj_gestion.abrir_conexion()
        obj_gestion.modificar(cadena)
        obj_gestion.cerrar_conexion()
        frm_Producto.listardatos("select * from proveedores")
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class