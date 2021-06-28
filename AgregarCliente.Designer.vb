<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAgregaNombre = New System.Windows.Forms.TextBox()
        Me.tbAgregaTelefono = New System.Windows.Forms.TextBox()
        Me.tbAgregaInfoExtra = New System.Windows.Forms.TextBox()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Completo Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Informacion Extra:"
        '
        'tbAgregaNombre
        '
        Me.tbAgregaNombre.Location = New System.Drawing.Point(157, 54)
        Me.tbAgregaNombre.Name = "tbAgregaNombre"
        Me.tbAgregaNombre.Size = New System.Drawing.Size(200, 20)
        Me.tbAgregaNombre.TabIndex = 3
        '
        'tbAgregaTelefono
        '
        Me.tbAgregaTelefono.Location = New System.Drawing.Point(157, 88)
        Me.tbAgregaTelefono.Name = "tbAgregaTelefono"
        Me.tbAgregaTelefono.Size = New System.Drawing.Size(200, 20)
        Me.tbAgregaTelefono.TabIndex = 4
        '
        'tbAgregaInfoExtra
        '
        Me.tbAgregaInfoExtra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbAgregaInfoExtra.Location = New System.Drawing.Point(157, 125)
        Me.tbAgregaInfoExtra.Multiline = True
        Me.tbAgregaInfoExtra.Name = "tbAgregaInfoExtra"
        Me.tbAgregaInfoExtra.Size = New System.Drawing.Size(200, 43)
        Me.tbAgregaInfoExtra.TabIndex = 31
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(337, 189)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarCliente.TabIndex = 32
        Me.btnAgregarCliente.Text = "Agregar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 277)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.tbAgregaInfoExtra)
        Me.Controls.Add(Me.tbAgregaTelefono)
        Me.Controls.Add(Me.tbAgregaNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAgregaNombre As TextBox
    Friend WithEvents tbAgregaTelefono As TextBox
    Friend WithEvents tbAgregaInfoExtra As TextBox
    Friend WithEvents btnAgregarCliente As Button
End Class
