Public Class Agregar_compras
    Dim obj_gestion As New gestion_db
    Dim dt_productos As DataTable
    Dim dt_proveedores As DataTable
    Private Sub Agregar_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim val_uni As Double
        Dim can_compra As Integer
        Dim total As Double
        val_uni = CDbl(txtuni.Text)
        can_compra = CDbl(txtcanCompra.Text)
        total = val_uni * can_compra
        Dim cadena As String
        cadena = "insert into compras values (" & txtidCompras.Text & "," & cbxproveedor.SelectedValue & "," _
              & cbxproducto.SelectedValue & "," & txtuni.Text & "," & txtcanCompra.Text & ",'" & txtdescripcion.Text & "'," & CStr(total) & ")"
        obj_gestion.abrir_conexion()
        obj_gestion.agregar(cadena)
        obj_gestion.cerrar_conexion()
        Frm_compras.listardatos("select * from compras ")
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class