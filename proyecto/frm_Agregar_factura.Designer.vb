<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Agregar_factura
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
        Me.cbxproducto = New System.Windows.Forms.ComboBox()
        Me.txttotalvta = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxidcliente = New System.Windows.Forms.ComboBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcantvta = New System.Windows.Forms.TextBox()
        Me.txtidfactura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtfechavta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxproducto
        '
        Me.cbxproducto.FormattingEnabled = True
        Me.cbxproducto.Location = New System.Drawing.Point(88, 131)
        Me.cbxproducto.Name = "cbxproducto"
        Me.cbxproducto.Size = New System.Drawing.Size(104, 21)
        Me.cbxproducto.TabIndex = 82
        '
        'txttotalvta
        '
        Me.txttotalvta.Location = New System.Drawing.Point(284, 60)
        Me.txttotalvta.Name = "txttotalvta"
        Me.txttotalvta.Size = New System.Drawing.Size(81, 20)
        Me.txttotalvta.TabIndex = 81
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(284, 22)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(81, 20)
        Me.txtdescuento.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Total venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Descuento"
        '
        'cbxidcliente
        '
        Me.cbxidcliente.FormattingEnabled = True
        Me.cbxidcliente.Location = New System.Drawing.Point(88, 51)
        Me.cbxidcliente.Name = "cbxidcliente"
        Me.cbxidcliente.Size = New System.Drawing.Size(104, 21)
        Me.cbxidcliente.TabIndex = 77
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(88, 176)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(104, 20)
        Me.txtprecio.TabIndex = 73
        '
        'txtcantvta
        '
        Me.txtcantvta.Location = New System.Drawing.Point(111, 220)
        Me.txtcantvta.Name = "txtcantvta"
        Me.txtcantvta.Size = New System.Drawing.Size(81, 20)
        Me.txtcantvta.TabIndex = 74
        '
        'txtidfactura
        '
        Me.txtidfactura.Location = New System.Drawing.Point(88, 19)
        Me.txtidfactura.Name = "txtidfactura"
        Me.txtidfactura.Size = New System.Drawing.Size(104, 20)
        Me.txtidfactura.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Cantidad de venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Fecha venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Id_factura"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.proyecto.My.Resources.Resources.cancelar
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(222, 277)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 51)
        Me.btnSalir.TabIndex = 66
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.proyecto.My.Resources.Resources.guardar
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(58, 277)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 51)
        Me.btnAgregar.TabIndex = 65
        Me.btnAgregar.Text = "Guardar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtfechavta
        '
        Me.txtfechavta.Location = New System.Drawing.Point(88, 94)
        Me.txtfechavta.Name = "txtfechavta"
        Me.txtfechavta.Size = New System.Drawing.Size(104, 20)
        Me.txtfechavta.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(99, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "AAAA-MM-DD"
        '
        'frm_Agregar_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 347)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbxproducto)
        Me.Controls.Add(Me.txttotalvta)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxidcliente)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtcantvta)
        Me.Controls.Add(Me.txtfechavta)
        Me.Controls.Add(Me.txtidfactura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "frm_Agregar_factura"
        Me.Text = "Agregar_factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxproducto As System.Windows.Forms.ComboBox
    Friend WithEvents txttotalvta As System.Windows.Forms.TextBox
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxidcliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtcantvta As System.Windows.Forms.TextBox
    Friend WithEvents txtidfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtfechavta As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
