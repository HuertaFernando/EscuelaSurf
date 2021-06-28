<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleDeArriendo
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
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.tbInfoExtra = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbProductosArriendo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbBloque = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbComentario = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(477, 180)
        Me.btnAgregarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(116, 28)
        Me.btnAgregarCliente.TabIndex = 52
        Me.btnAgregarCliente.Text = "Agregar Cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(185, 182)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(265, 22)
        Me.txtSearch.TabIndex = 51
        '
        'tbInfoExtra
        '
        Me.tbInfoExtra.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tbInfoExtra.Location = New System.Drawing.Point(185, 276)
        Me.tbInfoExtra.Margin = New System.Windows.Forms.Padding(4)
        Me.tbInfoExtra.Multiline = True
        Me.tbInfoExtra.Name = "tbInfoExtra"
        Me.tbInfoExtra.ReadOnly = True
        Me.tbInfoExtra.Size = New System.Drawing.Size(265, 52)
        Me.tbInfoExtra.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 279)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 17)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Informacion Del Cliente:"
        '
        'cbProductosArriendo
        '
        Me.cbProductosArriendo.FormattingEnabled = True
        Me.cbProductosArriendo.Location = New System.Drawing.Point(185, 96)
        Me.cbProductosArriendo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbProductosArriendo.Name = "cbProductosArriendo"
        Me.cbProductosArriendo.Size = New System.Drawing.Size(265, 24)
        Me.cbProductosArriendo.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 100)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Producto:"
        '
        'cbBloque
        '
        Me.cbBloque.FormattingEnabled = True
        Me.cbBloque.Location = New System.Drawing.Point(185, 139)
        Me.cbBloque.Margin = New System.Windows.Forms.Padding(4)
        Me.cbBloque.Name = "cbBloque"
        Me.cbBloque.Size = New System.Drawing.Size(265, 24)
        Me.cbBloque.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Bloque:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(56, 426)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 28)
        Me.btnDelete.TabIndex = 42
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(477, 426)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 41
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(264, 426)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbComentario
        '
        Me.tbComentario.Location = New System.Drawing.Point(180, 348)
        Me.tbComentario.Margin = New System.Windows.Forms.Padding(4)
        Me.tbComentario.Multiline = True
        Me.tbComentario.Name = "tbComentario"
        Me.tbComentario.Size = New System.Drawing.Size(271, 59)
        Me.tbComentario.TabIndex = 39
        '
        'tbTelefono
        '
        Me.tbTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tbTelefono.Location = New System.Drawing.Point(185, 226)
        Me.tbTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.ReadOnly = True
        Me.tbTelefono.Size = New System.Drawing.Size(265, 22)
        Me.tbTelefono.TabIndex = 38
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(185, 54)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(265, 22)
        Me.dtpDate.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 352)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Comment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 230)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Telefono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nombre Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Fecha:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Label9"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Label5"
        '
        'DetalleDeArriendo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 570)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.tbInfoExtra)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbProductosArriendo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbBloque)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbComentario)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DetalleDeArriendo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents tbInfoExtra As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbProductosArriendo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbBloque As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents tbComentario As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
End Class
