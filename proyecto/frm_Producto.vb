Public Class frm_Producto
    Dim obj_gestion As New gestion_db
    Dim dt_producto As New DataTable
    Public idproducto As Integer
    Public idproveedor As Integer
    Public idcategoria As Integer
    Public descripcion As String
    Public precio As Double
    Public nExistencia As Integer
    Public cadena As String
   
    Private Sub frm_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String
        cadena = "select * from productos"
        obj_gestion.abrir_conexion()
        dt_producto = obj_gestion.mostrar(cadena)
        dgv_data_producto.DataSource = dt_producto
        obj_gestion.cerrar_conexion()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        frm_agregar_producto.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub listardatos(ByVal micadena As String)
        dt_producto.Clear()
        obj_gestion.abrir_conexion()
        dt_producto = obj_gestion.mostrar(micadena)
        dgv_data_producto.DataSource = dt_producto
        obj_gestion.cerrar_conexion()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        dgv_data_producto.CurrentRow.Selected = True
        idproducto = dgv_data_producto.CurrentRow.Cells(0).Value
        idcategoria = dgv_data_producto.CurrentRow.Cells(1).Value
        idproveedor = dgv_data_producto.CurrentRow.Cells(2).Value
        descripcion = dgv_data_producto.CurrentRow.Cells(3).Value
        precio = dgv_data_producto.CurrentRow.Cells(4).Value
        nExistencia = dgv_data_producto.CurrentRow.Cells(5).Value
        modificar_producto.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As MsgBoxResult
        Dim cadena As String
        dgv_data_producto.CurrentRow.Selected = True
        idproducto = dgv_data_producto.CurrentRow.Cells(0).Value
        idcategoria = dgv_data_producto.CurrentRow.Cells(1).Value
        idproveedor = dgv_data_producto.CurrentRow.Cells(2).Value
        descripcion = dgv_data_producto.CurrentRow.Cells(3).Value
        precio = dgv_data_producto.CurrentRow.Cells(4).Value
        nExistencia = dgv_data_producto.CurrentRow.Cells(5).Value
        respuesta = MsgBox("desea eliminar el registro de producto " _
                          & idproducto & " " & idcategoria & " " & idproveedor & " " & descripcion & _
                          " " & precio & " " & nExistencia, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            cadena = "delete from productos where Id_producto =" & idproducto
            obj_gestion.abrir_conexion()
            obj_gestion.eliminar(cadena)
            obj_gestion.cerrar_conexion()
            Me.listardatos("select *from productos")


        End If
    End Sub
End Class