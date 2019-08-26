Public Class frm_reporte_ventas
    Dim obj_gestion As New gestion_db
    Dim dt_datos As New DataTable
    Private Sub frm_reporte_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String

        cadena = "select enc_factura.id_venta, clientes.nomb_cliente," & _
            " enc_factura.fecha_vta, productos.descripcion, proveedores.nomb_proveedor, " & _
            "categorias.nombre_cat, det_factura.total from enc_factura " & _
            "inner join det_factura on (enc_factura.id_venta = det_factura.id_venta)" & _
            "inner join clientes on (enc_factura.id_cliente = clientes.id_cliente)" & _
            "inner join productos on (det_factura.id_producto = productos.id_producto)" & _
            "inner join proveedores on (productos.id_proveedor = proveedores.id_proveedor)" & _
            "inner join categorias on (productos.id_categoria = categorias.id_categoria)"

        obj_gestion.abrir_conexion()
        dt_datos = obj_gestion.mostrar(cadena)
        dgv_reporte_fact.DataSource = dt_datos
        obj_gestion.cerrar_conexion()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub dgv_reporte_fact_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_reporte_fact.CellContentClick

    End Sub
End Class