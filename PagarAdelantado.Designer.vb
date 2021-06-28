<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblElijaTrab = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbRutTrabajador = New System.Windows.Forms.ComboBox()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(67, 185)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 30
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblElijaTrab
        '
        Me.lblElijaTrab.AutoSize = True
        Me.lblElijaTrab.Location = New System.Drawing.Point(36, 69)
        Me.lblElijaTrab.Name = "lblElijaTrab"
        Me.lblElijaTrab.Size = New System.Drawing.Size(83, 13)
        Me.lblElijaTrab.TabIndex = 29
        Me.lblElijaTrab.Text = "Elija Trabajador:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(228, 215)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 30)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Pagar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbRutTrabajador
        '
        Me.cbRutTrabajador.FormattingEnabled = True
        Me.cbRutTrabajador.Location = New System.Drawing.Point(125, 66)
        Me.cbRutTrabajador.Margin = New System.Windows.Forms.Padding(2)
        Me.cbRutTrabajador.Name = "cbRutTrabajador"
        Me.cbRutTrabajador.Size = New System.Drawing.Size(157, 21)
        Me.cbRutTrabajador.TabIndex = 27
        '
        'tbCantidad
        '
        Me.tbCantidad.Location = New System.Drawing.Point(125, 182)
        Me.tbCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(157, 20)
        Me.tbCantidad.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Label1"
        Me.Label8.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nombre Trabajador:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(125, 107)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 20)
        Me.TextBox1.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Deuda Total:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(125, 143)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(157, 20)
        Me.TextBox2.TabIndex = 35
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 339)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblElijaTrab)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbRutTrabajador)
        Me.Controls.Add(Me.tbCantidad)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adelantos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblElijaTrab As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cbRutTrabajador As ComboBox
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
