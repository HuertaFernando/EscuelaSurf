<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarStock))
        Me.lblAgregarStock = New System.Windows.Forms.Label()
        Me.btnAgregaStockFinal = New System.Windows.Forms.Button()
        Me.lblCantidadStock = New System.Windows.Forms.Label()
        Me.nudCantidadStock = New System.Windows.Forms.NumericUpDown()
        Me.lblElegirProducto = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.nudCantidadStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAgregarStock
        '
        Me.lblAgregarStock.AutoSize = True
        Me.lblAgregarStock.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAgregarStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblAgregarStock.Location = New System.Drawing.Point(12, 18)
        Me.lblAgregarStock.Name = "lblAgregarStock"
        Me.lblAgregarStock.Size = New System.Drawing.Size(137, 25)
        Me.lblAgregarStock.TabIndex = 16
        Me.lblAgregarStock.Text = "Agregar Stock"
        '
        'btnAgregaStockFinal
        '
        Me.btnAgregaStockFinal.FlatAppearance.BorderSize = 0
        Me.btnAgregaStockFinal.Image = CType(resources.GetObject("btnAgregaStockFinal.Image"), System.Drawing.Image)
        Me.btnAgregaStockFinal.Location = New System.Drawing.Point(297, 279)
        Me.btnAgregaStockFinal.Name = "btnAgregaStockFinal"
        Me.btnAgregaStockFinal.Size = New System.Drawing.Size(111, 59)
        Me.btnAgregaStockFinal.TabIndex = 15
        Me.btnAgregaStockFinal.UseVisualStyleBackColor = True
        '
        'lblCantidadStock
        '
        Me.lblCantidadStock.AutoSize = True
        Me.lblCantidadStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadStock.Location = New System.Drawing.Point(27, 222)
        Me.lblCantidadStock.Name = "lblCantidadStock"
        Me.lblCantidadStock.Size = New System.Drawing.Size(122, 20)
        Me.lblCantidadStock.TabIndex = 14
        Me.lblCantidadStock.Text = "Cantidad Stock:"
        '
        'nudCantidadStock
        '
        Me.nudCantidadStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCantidadStock.Location = New System.Drawing.Point(182, 220)
        Me.nudCantidadStock.Name = "nudCantidadStock"
        Me.nudCantidadStock.Size = New System.Drawing.Size(181, 26)
        Me.nudCantidadStock.TabIndex = 13
        Me.nudCantidadStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudCantidadStock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblElegirProducto
        '
        Me.lblElegirProducto.AutoSize = True
        Me.lblElegirProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElegirProducto.Location = New System.Drawing.Point(17, 123)
        Me.lblElegirProducto.Name = "lblElegirProducto"
        Me.lblElegirProducto.Size = New System.Drawing.Size(137, 20)
        Me.lblElegirProducto.TabIndex = 12
        Me.lblElegirProducto.Text = "Nombre Producto:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(182, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 23)
        Me.TextBox1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Ingrese Código:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(182, 123)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(181, 23)
        Me.TextBox2.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Stock Actual:"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(182, 171)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(181, 23)
        Me.TextBox3.TabIndex = 21
        '
        'AgregarStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 350)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblAgregarStock)
        Me.Controls.Add(Me.btnAgregaStockFinal)
        Me.Controls.Add(Me.lblCantidadStock)
        Me.Controls.Add(Me.nudCantidadStock)
        Me.Controls.Add(Me.lblElegirProducto)
        Me.Name = "AgregarStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Producto"
        CType(Me.nudCantidadStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAgregarStock As Label
    Friend WithEvents btnAgregaStockFinal As Button
    Friend WithEvents lblCantidadStock As Label
    Friend WithEvents nudCantidadStock As NumericUpDown
    Friend WithEvents lblElegirProducto As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
