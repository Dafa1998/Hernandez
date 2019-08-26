Public Class frm_Agregar_factura
    Dim obj_gestion As New gestion_db
    Dim dt_cliente As New DataTable
    Dim dt_producto As New DataTable
    Private Sub frm_Agregar_factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String

        cadena = "select * from clientes"
        obj_gestion.abrir_conexion()
        dt_cliente = obj_gestion.mostrar(cadena)
        obj_gestion.cerrar_conexion()
        cbxidcliente.DataSource = dt_cliente
        cbxidcliente.DisplayMember = "Cliente_Nombre " & "cliente_Apellido"
        cbxidcliente.ValueMember = "id_cliente"

        cadena = "select * from productos"
        obj_gestion.abrir_conexion()
        dt_producto = obj_gestion.mostrar(cadena)
        obj_gestion.cerrar_conexion()
        cbxproducto.DataSource = dt_producto
        cbxproducto.DisplayMember = "Descripcion"
        cbxproducto.ValueMember = "id_producto"

    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cant_vta As Integer
        Dim precio As Double
        Dim total_vta As Double
        Dim cadena As String
        cant_vta = CInt(txtcantvta.Text)
        precio = CDbl(txtprecio.Text)
        total_vta = precio * cant_vta
        
        cadena = "insert into enc_factura values (" & txtidfactura.Text & "," & _
            cbxidcliente.SelectedValue & ",{d'" & txtfechavta.Text & "'})  " & _
            "insert into det_factura values (" & txtidfactura.Text & "," & cbxproducto.SelectedValue & _
            "," & txtprecio.Text & _
            "," & txtcantvta.Text & "," & total_vta & "," & txtdescuento.Text & ")"
        MsgBox(cadena)
        obj_gestion.abrir_conexion()
        obj_gestion.agregar(cadena)
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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class