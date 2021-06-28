<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetalleDeAgenda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbBloque = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbActividad = New System.Windows.Forms.ComboBox()
        Me.cbTrabajador = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbInfoExtra = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(17, 420)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(408, 420)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(126, 23)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(221, 420)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(126, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbComentario
        '
        Me.tbComentario.Location = New System.Drawing.Point(163, 362)
        Me.tbComentario.Multiline = True
        Me.tbComentario.Name = "tbComentario"
        Me.tbComentario.Size = New System.Drawing.Size(204, 49)
        Me.tbComentario.TabIndex = 18
        '
        'tbTelefono
        '
        Me.tbTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tbTelefono.Location = New System.Drawing.Point(163, 168)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.ReadOnly = True
        Me.tbTelefono.Size = New System.Drawing.Size(200, 20)
        Me.tbTelefono.TabIndex = 17
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(163, 28)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Comentario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Telefono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Trabajador:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Bloque:"
        '
        'cbBloque
        '
        Me.cbBloque.FormattingEnabled = True
        Me.cbBloque.Location = New System.Drawing.Point(163, 97)
        Me.cbBloque.Name = "cbBloque"
        Me.cbBloque.Size = New System.Drawing.Size(200, 21)
        Me.cbBloque.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Actividad:"
        '
        'cbActividad
        '
        Me.cbActividad.FormattingEnabled = True
        Me.cbActividad.Location = New System.Drawing.Point(163, 62)
        Me.cbActividad.Name = "cbActividad"
        Me.cbActividad.Size = New System.Drawing.Size(200, 21)
        Me.cbActividad.TabIndex = 27
        '
        'cbTrabajador
        '
        Me.cbTrabajador.FormattingEnabled = True
        Me.cbTrabajador.Location = New System.Drawing.Point(159, 266)
        Me.cbTrabajador.Name = "cbTrabajador"
        Me.cbTrabajador.Size = New System.Drawing.Size(204, 21)
        Me.cbTrabajador.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Informacion Del Cliente:"
        '
        'tbInfoExtra
        '
        Me.tbInfoExtra.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tbInfoExtra.Location = New System.Drawing.Point(163, 208)
        Me.tbInfoExtra.Multiline = True
        Me.tbInfoExtra.Name = "tbInfoExtra"
        Me.tbInfoExtra.ReadOnly = True
        Me.tbInfoExtra.Size = New System.Drawing.Size(200, 43)
        Me.tbInfoExtra.TabIndex = 30
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(163, 132)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.TabIndex = 31
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(382, 130)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(87, 23)
        Me.btnAgregarCliente.TabIndex = 32
        Me.btnAgregarCliente.Text = "Agregar Cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 62)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNo)
        Me.GroupBox1.Controls.Add(Me.rbSi)
        Me.GroupBox1.Location = New System.Drawing.Point(159, 302)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 37)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Checked = True
        Me.rbNo.Location = New System.Drawing.Point(62, 14)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(39, 17)
        Me.rbNo.TabIndex = 1
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Location = New System.Drawing.Point(16, 14)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(34, 17)
        Me.rbSi.TabIndex = 0
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Si"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Calentamiento Smooth:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(408, 392)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 19)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Refrescar "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 48)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Label9"
        Me.Label9.Visible = False
        '
        'DetalleDeAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 455)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.tbInfoExtra)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbTrabajador)
        Me.Controls.Add(Me.cbActividad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbBloque)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
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
        Me.Name = "DetalleDeAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle De Cita"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbBloque As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbActividad As ComboBox
    Friend WithEvents cbTrabajador As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbInfoExtra As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
End Class
