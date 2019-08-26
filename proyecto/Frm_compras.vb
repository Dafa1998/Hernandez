Public Class Frm_compras
    Dim obj_gestion As New gestion_db
    Dim dt_compras As New DataTable
    Public idcompra As Integer
    Public idproveedor As Integer
    Public idproducto As Integer
    Public val_uni As Double
    Public cant_compra As Integer
    Public val_total As Double
    Public descripcion As String

    Private Sub Frm_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String
        cadena = "select * from compras"
        obj_gestion.abrir_conexion()
        dt_compras = obj_gestion.mostrar(cadena)
        dgv_data_Compras.DataSource = dt_compras
        obj_gestion.cerrar_conexion()
    End Sub
    Public Sub listardatos(ByVal micadena As String)
        dt_compras.Clear()
        obj_gestion.abrir_conexion()
        dt_compras = obj_gestion.mostrar(micadena)
        dgv_data_Compras.DataSource = dt_compras
        obj_gestion.cerrar_conexion()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        dgv_data_Compras.CurrentRow.Selected = True
        idcompra = dgv_data_Compras.CurrentRow.Cells(0).Value
        idproveedor = dgv_data_Compras.CurrentRow.Cells(1).Value
        idproducto = dgv_data_Compras.CurrentRow.Cells(2).Value
        val_uni = dgv_data_Compras.CurrentRow.Cells(3).Value
        cant_compra = dgv_data_Compras.CurrentRow.Cells(4).Value
        descripcion = dgv_data_Compras.CurrentRow.Cells(5).Value
        val_total = dgv_data_Compras.CurrentRow.Cells(6).Value
        modificar_compras.Show()
        Dim cadena As String
        cadena = "select * from compras"
        listardatos(cadena)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Agregar_compras.Show()
        Dim cadena As String
        cadena = "select * from compras"
        listardatos(cadena)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As MsgBoxResult
        Dim cadena As String
        dgv_data_Compras.CurrentRow.Selected = True
        idcompra = dgv_data_Compras.CurrentRow.Cells(0).Value
        idproveedor = dgv_data_Compras.CurrentRow.Cells(1).Value
        idproducto = dgv_data_Compras.CurrentRow.Cells(2).Value
        val_uni = dgv_data_Compras.CurrentRow.Cells(3).Value
        cant_compra = dgv_data_Compras.CurrentRow.Cells(4).Value
        descripcion = dgv_data_Compras.CurrentRow.Cells(5).Value
        val_total = dgv_data_Compras.CurrentRow.Cells(6).Value
        respuesta = MsgBox("desea eliminar el registro de compra " & idcompra & " " & idproveedor & " " & idproducto _
                          & " " & val_uni & " " & cant_compra & " " & descripcion & " " & val_total, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            cadena = "delete from compras where Id_compra =" & idcompra
            obj_gestion.abrir_conexion()
            obj_gestion.eliminar(cadena)
            obj_gestion.cerrar_conexion()
            Me.listardatos("select *from compras")


        End If
    End Sub
End Class