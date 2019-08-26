Public Class frm_agregar_producto
    Dim obj_gestion As New gestion_db
    Dim dt_proveedor As New DataTable
    Dim dt_categoria As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cadena As String
        cadena = "insert into productos values (" & txtidproducto.Text & "," & cbxidCategoria.SelectedValue & "," & cbxid_proveedor.SelectedValue & _
            "," & txtdescripcion & "," & txtprecio & "," & txtexistencia & ")"
        obj_gestion.abrir_conexion()
        obj_gestion.agregar(cadena)
        obj_gestion.cerrar_conexion()
        frm_Producto.listardatos("select * from productos")
        Me.Close()

    End Sub

    Private Sub frm_agregar_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class