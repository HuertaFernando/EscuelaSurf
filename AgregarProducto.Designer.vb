<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarProducto))
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbVenta = New System.Windows.Forms.RadioButton()
        Me.rbArriendo = New System.Windows.Forms.RadioButton()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblAgregaProducto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(47, 270)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(41, 18)
        Me.lblTipo.TabIndex = 34
        Me.lblTipo.Text = "Tipo:"
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbVenta)
        Me.gbTipo.Controls.Add(Me.rbArriendo)
        Me.gbTipo.Location = New System.Drawing.Point(110, 253)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(168, 52)
        Me.gbTipo.TabIndex = 33
        Me.gbTipo.TabStop = False
        '
        'rbVenta
        '
        Me.rbVenta.AutoSize = True
        Me.rbVenta.Checked = True
        Me.rbVenta.Location = New System.Drawing.Point(97, 19)
        Me.rbVenta.Name = "rbVenta"
        Me.rbVenta.Size = New System.Drawing.Size(53, 17)
        Me.rbVenta.TabIndex = 1
        Me.rbVenta.TabStop = True
        Me.rbVenta.Text = "Venta"
        Me.rbVenta.UseVisualStyleBackColor = True
        '
        'rbArriendo
        '
        Me.rbArriendo.AutoSize = True
        Me.rbArriendo.Location = New System.Drawing.Point(15, 19)
        Me.rbArriendo.Name = "rbArriendo"
        Me.rbArriendo.Size = New System.Drawing.Size(64, 17)
        Me.rbArriendo.TabIndex = 0
        Me.rbArriendo.Text = "Arriendo"
        Me.rbArriendo.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Image = CType(resources.GetObject("btnAgregarProducto.Image"), System.Drawing.Image)
        Me.btnAgregarProducto.Location = New System.Drawing.Point(250, 311)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(122, 77)
        Me.btnAgregarProducto.TabIndex = 32
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'tbStock
        '
        Me.tbStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStock.Location = New System.Drawing.Point(110, 223)
        Me.tbStock.Name = "tbStock"
        Me.tbStock.Size = New System.Drawing.Size(156, 24)
        Me.tbStock.TabIndex = 31
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescripcion.Location = New System.Drawing.Point(110, 163)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.Size = New System.Drawing.Size(156, 24)
        Me.tbDescripcion.TabIndex = 30
        '
        'tbPrecio
        '
        Me.tbPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrecio.Location = New System.Drawing.Point(110, 133)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(156, 24)
        Me.tbPrecio.TabIndex = 29
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(110, 101)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(156, 26)
        Me.tbNombre.TabIndex = 28
        Me.tbNombre.WordWrap = False
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(47, 226)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(51, 18)
        Me.lblStock.TabIndex = 27
        Me.lblStock.Text = "Stock:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 166)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(91, 18)
        Me.lblDescripcion.TabIndex = 26
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(49, 136)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(55, 18)
        Me.lblPrecio.TabIndex = 25
        Me.lblPrecio.Text = "Precio:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(35, 104)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 24
        Me.lblNombre.Text = "Nombre:"
        '
        'lblAgregaProducto
        '
        Me.lblAgregaProducto.AutoSize = True
        Me.lblAgregaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregaProducto.Location = New System.Drawing.Point(27, 23)
        Me.lblAgregaProducto.Name = "lblAgregaProducto"
        Me.lblAgregaProducto.Size = New System.Drawing.Size(151, 22)
        Me.lblAgregaProducto.TabIndex = 23
        Me.lblAgregaProducto.Text = "Agregar Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Código:"
        '
        'tbCodigo
        '
        Me.tbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo.Location = New System.Drawing.Point(110, 72)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(156, 23)
        Me.tbCodigo.TabIndex = 36
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(110, 193)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 24)
        Me.TextBox1.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Talla:"
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(416, 390)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tbCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.tbStock)
        Me.Controls.Add(Me.tbDescripcion)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblAgregaProducto)
        Me.Name = "AgregarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agrega Producto"
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTipo As Label
    Friend WithEvents gbTipo As GroupBox
    Friend WithEvents rbVenta As RadioButton
    Friend WithEvents rbArriendo As RadioButton
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents tbStock As TextBox
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblAgregaProducto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbCodigo As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
