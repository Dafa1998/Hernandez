Public Class frm_reporte_compras
    Dim obj_gestion As New gestion_db
    Dim dt_datos As New DataTable
    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub frm_reporte_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String

        cadena = "select compras.id_compra, proveedores.nomb_proveedor, productos.descripcion, " & _
            "compras.valor_unitario, compras.cant_compra, compras.descripcion, compras.total_comp " & _
            "from compras  inner join proveedores on (compras.id_proveedor = proveedores.id_proveedor) " & _
            "inner join productos on (compras.id_producto = productos.id_producto)"

        obj_gestion.abrir_conexion()
        dt_datos = obj_gestion.mostrar(cadena)
        dgv_reporte_compra.DataSource = dt_datos
        obj_gestion.cerrar_conexion()
    End Sub
End Class