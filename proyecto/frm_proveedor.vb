Public Class frm_proveedor
    Dim obj_gestion As New gestion_db
    Dim dt_proveedor As New DataTable
    Public idproveedor As Integer
    Public nombreProveedor As String
    Public direccion As String
    Public ciudad As String
    Public telefono As String
    Public email As String

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frm_proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String
        cadena = "select * from proveedores"
        obj_gestion.abrir_conexion()
        dt_proveedor = obj_gestion.mostrar(cadena)
        dgv_data_proveedor.DataSource = dt_proveedor
        obj_gestion.cerrar_conexion()
    End Sub
    Public Sub listardatos(ByVal micadena As String)
        dt_proveedor.Clear()
        obj_gestion.abrir_conexion()
        dt_proveedor = obj_gestion.mostrar(micadena)
        dgv_data_proveedor.DataSource = dt_proveedor
        obj_gestion.cerrar_conexion()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        dgv_data_proveedor.CurrentRow.Selected = True
        idproveedor = dgv_data_proveedor.CurrentRow.Cells(0).Value
        nombreProveedor = dgv_data_proveedor.CurrentRow.Cells(1).Value
        direccion = dgv_data_proveedor.CurrentRow.Cells(2).Value
        ciudad = dgv_data_proveedor.CurrentRow.Cells(3).Value
        telefono = dgv_data_proveedor.CurrentRow.Cells(4).Value
        email = dgv_data_proveedor.CurrentRow.Cells(5).Value
        modificar_Proveedor.Show()

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        frm_agregar_proveedor.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As MsgBoxResult
        Dim cadena As String
        dgv_data_proveedor.CurrentRow.Selected = True
        idproveedor = dgv_data_proveedor.CurrentRow.Cells(0).Value
        nombreProveedor = dgv_data_proveedor.CurrentRow.Cells(1).Value
        direccion = dgv_data_proveedor.CurrentRow.Cells(2).Value
        ciudad = dgv_data_proveedor.CurrentRow.Cells(3).Value
        telefono = dgv_data_proveedor.CurrentRow.Cells(4).Value
        respuesta = MsgBox("desea eliminar el registro de proveedor " _
                          & idproveedor & " " & nombreProveedor & " " & direccion & " " & ciudad & _
                          " " & telefono, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            cadena = "delete from proveedores where Id_proveedor =" & idproveedor
            obj_gestion.abrir_conexion()
            obj_gestion.eliminar(cadena)
            obj_gestion.cerrar_conexion()
            Me.listardatos("select *from proveedores")


        End If
    End Sub
End Class