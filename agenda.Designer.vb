<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agenda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMesAño = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bntHoy = New System.Windows.Forms.Button()
        Me.btnMesSiguiente = New System.Windows.Forms.Button()
        Me.btnMesAnterior = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.flDays = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Domingo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(171, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Lunes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(322, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Martes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(473, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Miercoles"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(624, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jueves"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMesAño
        '
        Me.lblMesAño.AutoSize = True
        Me.lblMesAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblMesAño.Location = New System.Drawing.Point(19, 9)
        Me.lblMesAño.Name = "lblMesAño"
        Me.lblMesAño.Size = New System.Drawing.Size(152, 29)
        Me.lblMesAño.TabIndex = 1
        Me.lblMesAño.Text = "octubre 2019"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblMesAño)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 50)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bntHoy)
        Me.Panel2.Controls.Add(Me.btnMesSiguiente)
        Me.Panel2.Controls.Add(Me.btnMesAnterior)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(914, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 50)
        Me.Panel2.TabIndex = 2
        '
        'bntHoy
        '
        Me.bntHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.bntHoy.Location = New System.Drawing.Point(66, 15)
        Me.bntHoy.Name = "bntHoy"
        Me.bntHoy.Size = New System.Drawing.Size(54, 23)
        Me.bntHoy.TabIndex = 1
        Me.bntHoy.Text = "Hoy"
        Me.bntHoy.UseVisualStyleBackColor = True
        '
        'btnMesSiguiente
        '
        Me.btnMesSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnMesSiguiente.Location = New System.Drawing.Point(126, 15)
        Me.btnMesSiguiente.Name = "btnMesSiguiente"
        Me.btnMesSiguiente.Size = New System.Drawing.Size(54, 23)
        Me.btnMesSiguiente.TabIndex = 0
        Me.btnMesSiguiente.Text = ">"
        Me.btnMesSiguiente.UseVisualStyleBackColor = True
        '
        'btnMesAnterior
        '
        Me.btnMesAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnMesAnterior.Location = New System.Drawing.Point(3, 15)
        Me.btnMesAnterior.Name = "btnMesAnterior"
        Me.btnMesAnterior.Size = New System.Drawing.Size(54, 23)
        Me.btnMesAnterior.TabIndex = 0
        Me.btnMesAnterior.Text = "<"
        Me.btnMesAnterior.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1097, 26)
        Me.Panel3.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(775, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Viernes"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(926, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Sabado"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flDays
        '
        Me.flDays.BackColor = System.Drawing.SystemColors.ControlDark
        Me.flDays.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flDays.Location = New System.Drawing.Point(0, 76)
        Me.flDays.Name = "flDays"
        Me.flDays.Padding = New System.Windows.Forms.Padding(20, 3, 20, 20)
        Me.flDays.Size = New System.Drawing.Size(1097, 627)
        Me.flDays.TabIndex = 4
        '
        'agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 703)
        Me.Controls.Add(Me.flDays)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "agenda"
        Me.Text = "agenda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMesAño As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents flDays As FlowLayoutPanel
    Friend WithEvents btnMesSiguiente As Button
    Friend WithEvents btnMesAnterior As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents bntHoy As Button
End Class
