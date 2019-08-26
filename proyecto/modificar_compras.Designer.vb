<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificar_compras
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
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtidCompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxproducto = New System.Windows.Forms.ComboBox()
        Me.txtuni = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcantCompra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxproveedor = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(100, 209)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(161, 45)
        Me.txtdescripcion.TabIndex = 62
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(100, 172)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(161, 20)
        Me.txttotal.TabIndex = 63
        '
        'txtidCompra
        '
        Me.txtidCompra.Location = New System.Drawing.Point(100, 8)
        Me.txtidCompra.Name = "txtidCompra"
        Me.txtidCompra.Size = New System.Drawing.Size(161, 20)
        Me.txtidCompra.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Id_Compras"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.proyecto.My.Resources.Resources.cancelar
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(164, 283)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 51)
        Me.btnSalir.TabIndex = 58
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Image = Global.proyecto.My.Resources.Resources.guardar
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.Location = New System.Drawing.Point(22, 283)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(94, 51)
        Me.btnmodificar.TabIndex = 57
        Me.btnmodificar.Text = "Guardar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "valor total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "valor unitario"
        '
        'cbxproducto
        '
        Me.cbxproducto.FormattingEnabled = True
        Me.cbxproducto.Location = New System.Drawing.Point(100, 46)
        Me.cbxproducto.Name = "cbxproducto"
        Me.cbxproducto.Size = New System.Drawing.Size(161, 21)
        Me.cbxproducto.TabIndex = 67
        '
        'txtuni
        '
        Me.txtuni.Location = New System.Drawing.Point(100, 117)
        Me.txtuni.Name = "txtuni"
        Me.txtuni.Size = New System.Drawing.Size(161, 20)
        Me.txtuni.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Cantidad compra"
        '
        'txtcantCompra
        '
        Me.txtcantCompra.Location = New System.Drawing.Point(117, 143)
        Me.txtcantCompra.Name = "txtcantCompra"
        Me.txtcantCompra.Size = New System.Drawing.Size(144, 20)
        Me.txtcantCompra.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "proveedor"
        '
        'cbxproveedor
        '
        Me.cbxproveedor.FormattingEnabled = True
        Me.cbxproveedor.Location = New System.Drawing.Point(100, 83)
        Me.cbxproveedor.Name = "cbxproveedor"
        Me.cbxproveedor.Size = New System.Drawing.Size(161, 21)
        Me.cbxproveedor.TabIndex = 72
        '
        'modificar_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 361)
        Me.Controls.Add(Me.cbxproveedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcantCompra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtuni)
        Me.Controls.Add(Me.cbxproducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtidCompra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnmodificar)
        Me.Name = "modificar_compras"
        Me.Text = "modificar_compras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtidCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxproducto As System.Windows.Forms.ComboBox
    Friend WithEvents txtuni As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcantCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxproveedor As System.Windows.Forms.ComboBox
End Class
