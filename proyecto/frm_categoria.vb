Public Class frm_categoria
    Dim obj_gestion As New gestion_db
    Dim dt_categoria As New DataTable
    Public idcategoria As Integer
    Public Nombre As String
    Public Descripcion As String
    Private Sub frm_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadena As String
        cadena = "select * from categorias"
        obj_gestion.abrir_conexion()
        dt_categoria = obj_gestion.mostrar(cadena)
        dgv_data_Categoria.DataSource = dt_categoria
        obj_gestion.cerrar_conexion()
    End Sub

    Public Sub listardatos(ByVal micadena As String)
        dt_categoria.Clear()
        obj_gestion.abrir_conexion()
        dt_categoria = obj_gestion.mostrar(micadena)
        dgv_data_Categoria.DataSource = dt_categoria
        obj_gestion.cerrar_conexion()
    End Sub


    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        frm_agregar_categoria.Show()

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
       
        dgv_data_Categoria.CurrentRow.Selected = True
        idcategoria = dgv_data_Categoria.CurrentRow.Cells(0).Value
        Nombre = dgv_data_Categoria.CurrentRow.Cells(1).Value
        Descripcion = dgv_data_Categoria.CurrentRow.Cells(2).Value
        modificar_categoria.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim respuesta As MsgBoxResult
        Dim cadena As String
        dgv_data_Categoria.CurrentRow.Selected = True
        idcategoria = dgv_data_Categoria.CurrentRow.Cells(0).Value
        Nombre = dgv_data_Categoria.CurrentRow.Cells(1).Value
        Descripcion = dgv_data_Categoria.CurrentRow.Cells(2).Value
        respuesta = MsgBox("desea eliminar el registro de categoria " _
                          & idcategoria & " " & Nombre & " " & Descripcion, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            cadena = "delete from categorias where Id_categoria =" & idcategoria
            obj_gestion.abrir_conexion()
            obj_gestion.eliminar(cadena)
            obj_gestion.cerrar_conexion()
            Me.listardatos("select *from categorias")


        End If
    End Sub
End Class