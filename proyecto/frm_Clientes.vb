Public Class frm_Clientes
    Dim obj_gestion As New gestion_db
    Dim dt_cliente As New DataTable
    Public idcliente As Integer
    Public Nombre As String
    Public Apellido As String
    Public telefono As String
    Public direccion As String
    Public ciudad As String
    Private Sub frm_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String
        cadena = "select * from clientes"
        obj_gestion.abrir_conexion()
        dt_cliente = obj_gestion.mostrar(cadena)
        dgv_data_cliente.DataSource = dt_cliente
        obj_gestion.cerrar_conexion()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        frm_Agregar_cliente.Show()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        dgv_data_cliente.CurrentRow.Selected = True
        idcliente = dgv_data_cliente.CurrentRow.Cells(0).Value
        Nombre = dgv_data_cliente.CurrentRow.Cells(1).Value
        Apellido = dgv_data_cliente.CurrentRow.Cells(2).Value
        telefono = dgv_data_cliente.CurrentRow.Cells(3).Value
        direccion = dgv_data_cliente.CurrentRow.Cells(4).Value
        ciudad = dgv_data_cliente.CurrentRow.Cells(5).Value
        Modificar_cliente.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub listardatos(ByVal micadena As String)
        dt_cliente.Clear()
        obj_gestion.abrir_conexion()
        dt_cliente = obj_gestion.mostrar(micadena)
        dgv_data_cliente.DataSource = dt_cliente
        obj_gestion.cerrar_conexion()
    End Sub

    Private Sub dgv_data_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data_cliente.CellContentClick

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As MsgBoxResult
        Dim cadena As String
        idcliente = dgv_data_cliente.CurrentRow.Cells(0).Value
        Nombre = dgv_data_cliente.CurrentRow.Cells(1).Value
        Apellido = dgv_data_cliente.CurrentRow.Cells(2).Value
        telefono = dgv_data_cliente.CurrentRow.Cells(3).Value
        direccion = dgv_data_cliente.CurrentRow.Cells(4).Value
        ciudad = dgv_data_cliente.CurrentRow.Cells(5).Value
        respuesta = MsgBox("desea eliminar el registro de cliente " & idcliente & " " & Nombre & " " & Apellido _
                          & " " & telefono & " " & direccion & " " & ciudad, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            cadena = "delete from clientes where Id_cliente =" & idcliente
            obj_gestion.abrir_conexion()
            obj_gestion.eliminar(cadena)
            obj_gestion.cerrar_conexion()
            Me.listardatos("select *from clientes")


        End If
    End Sub
End Class