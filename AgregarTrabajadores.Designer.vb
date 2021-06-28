<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarTrabajadores
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bnAgregaTrabajador = New System.Windows.Forms.Button()
        Me.gbEleccion = New System.Windows.Forms.GroupBox()
        Me.rbCajero = New System.Windows.Forms.RadioButton()
        Me.rbProf = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbReAgregaContra = New System.Windows.Forms.TextBox()
        Me.tbAgregaContra = New System.Windows.Forms.TextBox()
        Me.tbAgregaNombre = New System.Windows.Forms.TextBox()
        Me.tbAgregaRut = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbEleccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bnAgregaTrabajador)
        Me.GroupBox1.Location = New System.Drawing.Point(292, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 41)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'bnAgregaTrabajador
        '
        Me.bnAgregaTrabajador.Location = New System.Drawing.Point(28, 0)
        Me.bnAgregaTrabajador.Name = "bnAgregaTrabajador"
        Me.bnAgregaTrabajador.Size = New System.Drawing.Size(160, 39)
        Me.bnAgregaTrabajador.TabIndex = 42
        Me.bnAgregaTrabajador.Text = "Agregar Trabajador"
        Me.bnAgregaTrabajador.UseVisualStyleBackColor = True
        '
        'gbEleccion
        '
        Me.gbEleccion.Controls.Add(Me.rbCajero)
        Me.gbEleccion.Controls.Add(Me.rbProf)
        Me.gbEleccion.Location = New System.Drawing.Point(200, 145)
        Me.gbEleccion.Name = "gbEleccion"
        Me.gbEleccion.Size = New System.Drawing.Size(194, 41)
        Me.gbEleccion.TabIndex = 53
        Me.gbEleccion.TabStop = False
        '
        'rbCajero
        '
        Me.rbCajero.AutoSize = True
        Me.rbCajero.Checked = True
        Me.rbCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbCajero.Location = New System.Drawing.Point(105, 11)
        Me.rbCajero.Name = "rbCajero"
        Me.rbCajero.Size = New System.Drawing.Size(73, 24)
        Me.rbCajero.TabIndex = 13
        Me.rbCajero.TabStop = True
        Me.rbCajero.Text = "Cajero"
        Me.rbCajero.UseVisualStyleBackColor = True
        '
        'rbProf
        '
        Me.rbProf.AutoSize = True
        Me.rbProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.rbProf.Location = New System.Drawing.Point(4, 11)
        Me.rbProf.Name = "rbProf"
        Me.rbProf.Size = New System.Drawing.Size(95, 24)
        Me.rbProf.TabIndex = 12
        Me.rbProf.Text = "Instructor"
        Me.rbProf.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 20)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Tipo De Trabajador:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label5.Location = New System.Drawing.Point(207, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Datos Del Trabajdor"
        '
        'tbReAgregaContra
        '
        Me.tbReAgregaContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.tbReAgregaContra.Location = New System.Drawing.Point(200, 240)
        Me.tbReAgregaContra.Name = "tbReAgregaContra"
        Me.tbReAgregaContra.Size = New System.Drawing.Size(145, 26)
        Me.tbReAgregaContra.TabIndex = 50
        '
        'tbAgregaContra
        '
        Me.tbAgregaContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.tbAgregaContra.Location = New System.Drawing.Point(200, 192)
        Me.tbAgregaContra.Name = "tbAgregaContra"
        Me.tbAgregaContra.Size = New System.Drawing.Size(145, 26)
        Me.tbAgregaContra.TabIndex = 49
        '
        'tbAgregaNombre
        '
        Me.tbAgregaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.tbAgregaNombre.Location = New System.Drawing.Point(200, 113)
        Me.tbAgregaNombre.Name = "tbAgregaNombre"
        Me.tbAgregaNombre.Size = New System.Drawing.Size(145, 26)
        Me.tbAgregaNombre.TabIndex = 48
        '
        'tbAgregaRut
        '
        Me.tbAgregaRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.tbAgregaRut.Location = New System.Drawing.Point(200, 79)
        Me.tbAgregaRut.Name = "tbAgregaRut"
        Me.tbAgregaRut.Size = New System.Drawing.Size(145, 26)
        Me.tbAgregaRut.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Reingrese Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Rut:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(383, 156)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(149, 24)
        Me.CheckBox1.TabIndex = 56
        Me.CheckBox1.Text = "Curso Salvavidas"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(351, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "*Si termina en k reemplace por 0"
        '
        'AgregarTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 350)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbEleccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbReAgregaContra)
        Me.Controls.Add(Me.tbAgregaContra)
        Me.Controls.Add(Me.tbAgregaNombre)
        Me.Controls.Add(Me.tbAgregaRut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarTrabajadores"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbEleccion.ResumeLayout(False)
        Me.gbEleccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbEleccion As GroupBox
    Friend WithEvents rbCajero As RadioButton
    Friend WithEvents rbProf As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbReAgregaContra As TextBox
    Friend WithEvents tbAgregaContra As TextBox
    Friend WithEvents tbAgregaNombre As TextBox
    Friend WithEvents tbAgregaRut As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bnAgregaTrabajador As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label7 As Label
End Class
