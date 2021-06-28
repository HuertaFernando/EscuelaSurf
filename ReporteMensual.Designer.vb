<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteMensual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteMensual))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewProductosMes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.DataGridViewPyC = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVProductosArriendo = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MediosDePagos = New System.Windows.Forms.DataGridView()
        Me.SueldosConAdelantos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVCantidadxMes = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PDF = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewProductosMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewPyC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVProductosArriendo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediosDePagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SueldosConAdelantos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCantidadxMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reporte Mensual"
        '
        'DataGridViewProductosMes
        '
        Me.DataGridViewProductosMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductosMes.Location = New System.Drawing.Point(452, 37)
        Me.DataGridViewProductosMes.Name = "DataGridViewProductosMes"
        Me.DataGridViewProductosMes.RowHeadersWidth = 51
        Me.DataGridViewProductosMes.Size = New System.Drawing.Size(368, 204)
        Me.DataGridViewProductosMes.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(476, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad de productos vendidos"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.Location = New System.Drawing.Point(10, 47)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(77, 26)
        Me.LabelFecha.TabIndex = 4
        Me.LabelFecha.Text = "Label3"
        '
        'DataGridViewPyC
        '
        Me.DataGridViewPyC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPyC.Location = New System.Drawing.Point(10, 37)
        Me.DataGridViewPyC.Name = "DataGridViewPyC"
        Me.DataGridViewPyC.RowHeadersWidth = 51
        Me.DataGridViewPyC.Size = New System.Drawing.Size(339, 204)
        Me.DataGridViewPyC.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total actividades por mes"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.DGVProductosArriendo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.MediosDePagos)
        Me.Panel2.Controls.Add(Me.SueldosConAdelantos)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DGVCantidadxMes)
        Me.Panel2.Controls.Add(Me.DataGridViewProductosMes)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DataGridViewPyC)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1547, 576)
        Me.Panel2.TabIndex = 8
        '
        'DGVProductosArriendo
        '
        Me.DGVProductosArriendo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductosArriendo.Location = New System.Drawing.Point(916, 303)
        Me.DGVProductosArriendo.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVProductosArriendo.Name = "DGVProductosArriendo"
        Me.DGVProductosArriendo.RowHeadersWidth = 51
        Me.DGVProductosArriendo.RowTemplate.Height = 24
        Me.DGVProductosArriendo.Size = New System.Drawing.Size(362, 186)
        Me.DGVProductosArriendo.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(901, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(377, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Monto generado con productos arrendados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(518, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(262, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Medios de pagos mas usados"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sueldos con adelantos"
        '
        'MediosDePagos
        '
        Me.MediosDePagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MediosDePagos.Location = New System.Drawing.Point(786, 265)
        Me.MediosDePagos.Name = "MediosDePagos"
        Me.MediosDePagos.RowHeadersWidth = 51
        Me.MediosDePagos.Size = New System.Drawing.Size(34, 21)
        Me.MediosDePagos.TabIndex = 13
        Me.MediosDePagos.Visible = False
        '
        'SueldosConAdelantos
        '
        Me.SueldosConAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SueldosConAdelantos.Location = New System.Drawing.Point(10, 292)
        Me.SueldosConAdelantos.Name = "SueldosConAdelantos"
        Me.SueldosConAdelantos.RowHeadersWidth = 51
        Me.SueldosConAdelantos.Size = New System.Drawing.Size(543, 197)
        Me.SueldosConAdelantos.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(933, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(323, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cantidad de actividades por instructor"
        '
        'DGVCantidadxMes
        '
        Me.DGVCantidadxMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCantidadxMes.Location = New System.Drawing.Point(916, 37)
        Me.DGVCantidadxMes.Name = "DGVCantidadxMes"
        Me.DGVCantidadxMes.RowHeadersWidth = 51
        Me.DGVCantidadxMes.Size = New System.Drawing.Size(368, 204)
        Me.DGVCantidadxMes.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Location = New System.Drawing.Point(1, 706)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1665, 21)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(173, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PDF
        '
        Me.PDF.Location = New System.Drawing.Point(1234, 15)
        Me.PDF.Name = "PDF"
        Me.PDF.Size = New System.Drawing.Size(134, 86)
        Me.PDF.TabIndex = 37
        Me.PDF.Text = "Generar PDF"
        Me.PDF.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(807, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 29)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Label5"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1036, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 29)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Label13"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(807, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 29)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(421, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(386, 29)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Generado por productos vendidos:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(421, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(296, 29)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Generado por actividades:"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(421, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(411, 29)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Generado por productos arrendados:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(807, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 29)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Label12"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1004, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(182, 29)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Total Generado"
        '
        'ReporteMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PDF)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteMensual"
        Me.Text = "ReporteMensual"
        CType(Me.DataGridViewProductosMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewPyC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVProductosArriendo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediosDePagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SueldosConAdelantos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCantidadxMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewProductosMes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents DataGridViewPyC As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents DGVCantidadxMes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MediosDePagos As DataGridView
    Friend WithEvents SueldosConAdelantos As DataGridView
    Friend WithEvents PDF As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVProductosArriendo As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
End Class
