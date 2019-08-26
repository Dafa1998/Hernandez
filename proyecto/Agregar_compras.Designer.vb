<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_compras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbxproveedor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcanCompra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtuni = New System.Windows.Forms.TextBox()
        Me.cbxproducto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtidCompras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxproveedor
        '
        Me.cbxproveedor.FormattingEnabled = True
        Me.cbxproveedor.Location = New System.Drawing.Point(115, 94)
        Me.cbxproveedor.Name = "cbxproveedor"
        Me.cbxproveedor.Size = New System.Drawing.Size(161, 21)
        Me.cbxproveedor.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "proveedor"
        '
        'txtcanCompra
        '
        Me.txtcanCompra.Location = New System.Drawing.Point(132, 154)
        Me.txtcanCompra.Name = "txtcanCompra"
        Me.txtcanCompra.Size = New System.Drawing.Size(144, 20)
        Me.txtcanCompra.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Cantidad compra"
        '
        'txtuni
        '
        Me.txtuni.Location = New System.Drawing.Point(115, 128)
        Me.txtuni.Name = "txtuni"
        Me.txtuni.Size = New System.Drawing.Size(161, 20)
        Me.txtuni.TabIndex = 84
        '
        'cbxproducto
        '
        Me.cbxproducto.FormattingEnabled = True
        Me.cbxproducto.Location = New System.Drawing.Point(115, 57)
        Me.cbxproducto.Name = "cbxproducto"
        Me.cbxproducto.Size = New System.Drawing.Size(161, 21)
        Me.cbxproducto.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "valor unitario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "valor total"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(115, 220)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(161, 45)
        Me.txtdescripcion.TabIndex = 78
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(115, 183)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(161, 20)
        Me.txttotal.TabIndex = 79
        '
        'txtidCompras
        '
        Me.txtidCompras.Location = New System.Drawing.Point(115, 19)
        Me.txtidCompras.Name = "txtidCompras"
        Me.txtidCompras.Size = New System.Drawing.Size(161, 20)
        Me.txtidCompras.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Id_Compras"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.proyecto.My.Resources.Resources.cancelar
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(179, 294)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(70, 51)
        Me.btnSalir.TabIndex = 74
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Image = Global.proyecto.My.Resources.Resources.guardar
        Me.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregar.Location = New System.Drawing.Point(37, 294)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(94, 51)
        Me.btnagregar.TabIndex = 73
        Me.btnagregar.Text = "Guardar"
        Me.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Agregar_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 364)
        Me.Controls.Add(Me.cbxproveedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcanCompra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtuni)
        Me.Controls.Add(Me.cbxproducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtidCompras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnagregar)
        Me.Name = "Agregar_compras"
        Me.Text = "Agregar_compras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcanCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtuni As System.Windows.Forms.TextBox
    Friend WithEvents cbxproducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtidCompras As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnagregar As System.Windows.Forms.Button
End Class
