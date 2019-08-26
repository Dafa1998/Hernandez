Public Class modificar_factura
    Dim obj_gestion As New gestion_db
    Dim dt_clientes As New DataTable
    Dim dt_producto As New DataTable
    Private Sub modificar_factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidfactura.Text = frm_ventas.id_factura
        txtfechavta.Text = frm_ventas.fecha_vta
        txtcantvta.Text = frm_ventas.cant_vnta
        txtprecio.Text = frm_ventas.precio
        txtdescuento.Text = frm_ventas.descuento
        txttotalvta.Text = frm_ventas.total_vta

        Dim cadena As String

        cadena = "select * FROM clientes"
        obj_gestion.abrir_conexion()
        dt_clientes = obj_gestion.mostrar(cadena)
        obj_gestion.cerrar_conexion()
        cbxidcliente.DataSource = dt_clientes
        cbxidcliente.DisplayMember = "nomb_cliente " & "apellido_cliente"
        cbxidcliente.ValueMember = "id_cliente"

        cadena = "select * FROM productos"
        obj_gestion.abrir_conexion()
        dt_producto = obj_gestion.mostrar(cadena)
        obj_gestion.cerrar_conexion()
        cbxproducto.DataSource = dt_producto
        cbxproducto.DisplayMember = "DESCRIPCION"
        cbxproducto.ValueMember = "id_producto"

        cbxidcliente.SelectedValue = frm_ventas.id_cliente
        cbxproducto.SelectedValue = frm_ventas.id_producto

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim cadena As String
        txttotalvta.Text = txtcantvta.Text * txtprecio.Text
        cadena = "update enc_factura set id_cliente=" & cbxidcliente.SelectedValue & _
            ", fecha_vta = {d'" & txtfechavta.Text & "'} where id_venta=" & txtidfactura.Text & _
            "   update det_factura set id_producto=" & cbxproducto.SelectedValue & _
            ", precio=" & txtprecio.Text & ",cant_venta=" & txtcantvta.Text & _
            ", total=" & txttotalvta.Text & ", descuento=" & txtdescuento.Text & " where id_venta=" & txtidfactura.Text
        obj_gestion.abrir_conexion()
        obj_gestion.modificar(cadena)
        obj_gestion.cerrar_conexion()
        frm_ventas.listardatos("select enc_factura.Id_venta, enc_factura.id_cliente, " & _
            "enc_factura.fecha_vta, det_factura.id_producto, det_factura.precio, det_factura.cant_venta, " & _
            "det_factura.total, det_factura.descuento " & _
            "from ENC_factura,DET_factura where ENC_FACTURA.Id_venta = DET_FACTURA.Id_venta")
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class