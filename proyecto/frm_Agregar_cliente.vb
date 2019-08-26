Public Class frm_Agregar_cliente
    Dim obj_gestion As New gestion_db
    Dim dt_clientes As New DataTable
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cadena As String
        cadena = "insert into productos values (" & txtidcliente.Text & "," & Txtnombre.Text & _
            "," & txtapellido.Text & "," & txttelefono.Text & "," & txtdireccion.Text & "," & txtciudad.Text & ")"
        obj_gestion.abrir_conexion()
        obj_gestion.agregar(cadena)
        obj_gestion.cerrar_conexion()
        frm_Producto.listardatos("select * from clientes")
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frm_Agregar_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class