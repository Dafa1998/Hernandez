Public Class modificar_compras
    Dim obj_gestion As New gestion_db
    Dim dt_productos As New DataTable
    Dim dt_proveedores As New DataTable
    Private Sub modificar_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidCompra.Text = Frm_compras.idcompra
        txtuni.Text = Frm_compras.val_uni
        txtcantCompra.Text = Frm_compras.cant_compra
        txttotal.Text = Frm_compras.val_total
        txtdescripcion.Text = Frm_compras.descripcion

        Dim cadena As String
        cadena = "select * from productos"
        obj_gestion.abrir_conexion()
        dt_productos = obj_gestion.mostrar(cadena)
        obj_gestion.cerrar_conexion()
        cbxproducto.DataSource = dt_productos
        cbxproducto.DisplayMember = "descripcion"
        cbxproducto.ValueMember = "id_producto"

        cadena = "select * from proveedores"
        obj_gestion.abrir_conexion()
        dt_proveedores = obj_gestion.mostrar(cadena)
        obj_gestion.cerrar_conexion()
        cbxproveedor.DataSource = dt_proveedores
        cbxproveedor.DisplayMember = "nomb_proveedor"
        cbxproveedor.ValueMember = "id_proveedor"

        cbxproveedor.SelectedValue = Frm_compras.idproveedor
        cbxproducto.SelectedValue = Frm_compras.idproducto
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim cantCompra As Integer
        Dim val_uni As Double
        Dim val_total As Double
        cantCompra = CInt(txtcantCompra.Text)
        val_uni = CDbl(txtuni.Text)
        val_total = cantCompra * val_uni
        Dim cadena As String
        cadena = "update compras set id_proveedor=" & cbxproveedor.SelectedValue & ", id_producto=" & cbxproducto.SelectedValue & ", valor_unitario=" _
               & txtuni.Text & ", cant_compra=" & txtcantCompra.Text & ", descripcion='" & txtdescripcion.Text & "', total_comp=" & CStr(val_total) & " where id_compra=" & txtidCompra.Text
        obj_gestion.abrir_conexion()
        obj_gestion.modificar(cadena)
        obj_gestion.cerrar_conexion()
        Frm_compras.listardatos("select * from compras")
        Me.Close()
    End Sub
  
End Class