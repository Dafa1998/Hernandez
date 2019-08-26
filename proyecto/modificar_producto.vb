Public Class modificar_producto
    Dim obj_gestion As New gestion_db
    Dim dt_proveedor As New DataTable
    Dim dt_categoria As New DataTable
    
    Private Sub modificar_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidproducto.Text = frm_Producto.idproducto
        txtdescripcion.Text = frm_Producto.descripcion
        txtprecio.Text = frm_Producto.precio
        txtexistencia.Text = frm_Producto.nExistencia

        Dim cadena As String

        cadena = "select * from proveedores "
        obj_gestion.abrir_conexion()
        dt_proveedor = obj_gestion.mostrar(cadena)
        obj_gestion.cerrar_conexion()
        cbxid_proveedor.DataSource = dt_proveedor
        cbxid_proveedor.DisplayMember = "nomb_proveedor"
        cbxid_proveedor.ValueMember = "id_proveedor"

        cadena = "select * from categorias "
        obj_gestion.abrir_conexion()
        dt_categoria = obj_gestion.mostrar(cadena)
        obj_gestion.cerrar_conexion()
        cbxidCategoria.DataSource = dt_categoria
        cbxidCategoria.DisplayMember = "nomb_categoria"
        cbxidCategoria.ValueMember = "id_categoria"

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim cadena As String
        cadena = "update productos set id_proveedor=" & cbxid_proveedor.SelectedValue & _
            ", id_categoria" & cbxidCategoria.SelectedValue & ", descripcion=" & txtdescripcion.Text & _
            ", precio=" & txtprecio.Text & ",N_Existencias=" & txtexistencia.Text & "where id_producto=" & txtidproducto.Text
        obj_gestion.abrir_conexion()
        obj_gestion.modificar(cadena)
        obj_gestion.cerrar_conexion()
        frm_Producto.listardatos("select * from productos")
        Me.Close()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class