Public Class frm_ventas
    Dim obj_gestion As New gestion_db
    Dim dt_ventas As New DataTable
    Public id_factura As Integer
    Public id_cliente As Integer
    Public fecha_vta As Date
    Public id_producto As Integer
    Public precio As Double
    Public cant_vnta As Integer
    Public total_vta As Double
    Public descuento As Integer

    Private Sub frm_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String
        cadena = "select enc_factura.Id_venta, enc_factura.id_cliente, " & _
            "enc_factura.fecha_vta, det_factura.id_producto, det_factura.precio, det_factura.cant_venta, " & _
            "det_factura.total, det_factura.descuento " & _
            "from ENC_factura,DET_factura where ENC_FACTURA.Id_venta = DET_FACTURA.Id_venta"
        'MsgBox(cadena)
        obj_gestion.abrir_conexion()
        dt_ventas = obj_gestion.mostrar(cadena)
        dgv_data_ventas.DataSource = dt_ventas
        obj_gestion.cerrar_conexion()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        frm_Agregar_factura.Show()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        dgv_data_ventas.CurrentRow.Selected = True
        id_factura = dgv_data_ventas.CurrentRow.Cells(0).Value
        id_cliente = dgv_data_ventas.CurrentRow.Cells(1).Value
        fecha_vta = dgv_data_ventas.CurrentRow.Cells(2).Value
        id_producto = dgv_data_ventas.CurrentRow.Cells(3).Value
        precio = dgv_data_ventas.CurrentRow.Cells(4).Value
        cant_vnta = dgv_data_ventas.CurrentRow.Cells(5).Value
        total_vta = dgv_data_ventas.CurrentRow.Cells(6).Value
        descuento = dgv_data_ventas.CurrentRow.Cells(7).Value
        modificar_factura.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As MsgBoxResult
        Dim cadena As String
        dgv_data_ventas.CurrentRow.Selected = True
        id_factura = dgv_data_ventas.CurrentRow.Cells(0).Value
        id_cliente = dgv_data_ventas.CurrentRow.Cells(1).Value
        fecha_vta = dgv_data_ventas.CurrentRow.Cells(2).Value
        id_producto = dgv_data_ventas.CurrentRow.Cells(3).Value
        precio = dgv_data_ventas.CurrentRow.Cells(4).Value
        cant_vnta = dgv_data_ventas.CurrentRow.Cells(5).Value
        total_vta = dgv_data_ventas.CurrentRow.Cells(6).Value
        descuento = dgv_data_ventas.CurrentRow.Cells(7).Value
        respuesta = MsgBox("desea eliminar el registro de factura " _
                          & id_factura & " " & id_cliente & " " & fecha_vta & " " & id_producto & _
                          " " & precio & " " & cant_vnta & " " & total_vta & " " & descuento, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            cadena = "   delete from det_factura where id_venta = " & id_factura & _
                "delete from enc_factura where Id_venta = " & id_factura

            obj_gestion.abrir_conexion()
            obj_gestion.eliminar(cadena)
            obj_gestion.cerrar_conexion()
            Me.listardatos("select enc_factura.Id_venta, enc_factura.id_cliente, " & _
            "enc_factura.fecha_vta, det_factura.id_producto, det_factura.precio, det_factura.cant_venta, " & _
            "det_factura.total, det_factura.descuento " & _
            "from ENC_factura,DET_factura where ENC_FACTURA.Id_venta = DET_FACTURA.Id_venta")


        End If
    End Sub
    Public Sub listardatos(ByVal micadena As String)
        dt_ventas.Clear()
        obj_gestion.abrir_conexion()
        dt_ventas = obj_gestion.mostrar(micadena)
        dgv_data_ventas.DataSource = dt_ventas
        obj_gestion.cerrar_conexion()
    End Sub
End Class