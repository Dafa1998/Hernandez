Public Class Modificar_cliente
    Dim obj_gestion As New gestion_db

    Private Sub Modificar_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtidcliente.Text = frm_Clientes.idcliente
        Txtnombre.Text = frm_Clientes.Nombre
        txtapellido.Text = frm_Clientes.Apellido
        txttelefono.Text = frm_Clientes.telefono
        txtdireccion.Text = frm_Clientes.direccion
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Dim cadena As String
        cadena = "update clientes set id_cliente=" & txtidcliente.Text & ", nombre_cliente=" & Txtnombre.Text & ", Apellido_cliente=" & txtapellido.Text & _
            ", telefono=" & txttelefono.Text & ", direccion=" & txtdireccion.Text & ", ciudad=" & txtciudad.Text & " where id_cliente= " & txtidcliente.Text
        obj_gestion.abrir_conexion()
        obj_gestion.modificar(cadena)
        obj_gestion.cerrar_conexion()
        frm_Producto.listardatos("select * from clientes")
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class