<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tbRut = New System.Windows.Forms.TextBox()
        Me.tbContraseña = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnSlide = New System.Windows.Forms.PictureBox()
        Me.pbMinimizar = New System.Windows.Forms.PictureBox()
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        Me.pnlMid = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.fechaYhora = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCheckUpdates = New System.Windows.Forms.Timer(Me.components)
        Me.btnAgenda = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnAgregaTrabajador = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnSoporte = New System.Windows.Forms.Button()
        Me.btnArrendar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnlOnleft = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOnleft.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbRut
        '
        Me.tbRut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRut.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbRut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.tbRut.ForeColor = System.Drawing.Color.Black
        Me.tbRut.Location = New System.Drawing.Point(8, 41)
        Me.tbRut.Name = "tbRut"
        Me.tbRut.Size = New System.Drawing.Size(169, 22)
        Me.tbRut.TabIndex = 4
        Me.tbRut.Text = "Usuario"
        Me.tbRut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbContraseña
        '
        Me.tbContraseña.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbContraseña.BackColor = System.Drawing.SystemColors.ControlDark
        Me.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.tbContraseña.ForeColor = System.Drawing.Color.Black
        Me.tbContraseña.Location = New System.Drawing.Point(171, 41)
        Me.tbContraseña.Name = "tbContraseña"
        Me.tbContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbContraseña.Size = New System.Drawing.Size(120, 22)
        Me.tbContraseña.TabIndex = 5
        Me.tbContraseña.Text = "Contraseña"
        Me.tbContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIngresar.BackColor = System.Drawing.Color.White
        Me.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnIngresar.FlatAppearance.BorderSize = 2
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Image = CType(resources.GetObject("btnIngresar.Image"), System.Drawing.Image)
        Me.btnIngresar.Location = New System.Drawing.Point(297, 31)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(79, 47)
        Me.btnIngresar.TabIndex = 7
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Controls.Add(Me.lblFecha)
        Me.pnlTop.Controls.Add(Me.lblHora)
        Me.pnlTop.Controls.Add(Me.tbRut)
        Me.pnlTop.Controls.Add(Me.tbContraseña)
        Me.pnlTop.Controls.Add(Me.btnIngresar)
        Me.pnlTop.Controls.Add(Me.ShapeContainer2)
        Me.pnlTop.Controls.Add(Me.btnSlide)
        Me.pnlTop.Controls.Add(Me.pbMinimizar)
        Me.pnlTop.Controls.Add(Me.pbCerrar)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(209, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1097, 85)
        Me.pnlTop.TabIndex = 11
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(43, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(64, 22)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "Label4"
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(910, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(64, 22)
        Me.lblHora.TabIndex = 16
        Me.lblHora.Text = "Label3"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1097, 85)
        Me.ShapeContainer2.TabIndex = 14
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape3.BorderColor = System.Drawing.Color.Black
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.Visible = False
        Me.LineShape3.X1 = 0
        Me.LineShape3.X2 = 1102
        Me.LineShape3.Y1 = 34
        Me.LineShape3.Y2 = 34
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape2.BorderColor = System.Drawing.Color.Black
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 179
        Me.LineShape2.X2 = 279
        Me.LineShape2.Y1 = 68
        Me.LineShape2.Y2 = 68
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.Color.Black
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 47
        Me.LineShape1.X2 = 147
        Me.LineShape1.Y1 = 68
        Me.LineShape1.Y2 = 68
        '
        'btnSlide
        '
        Me.btnSlide.Image = CType(resources.GetObject("btnSlide.Image"), System.Drawing.Image)
        Me.btnSlide.Location = New System.Drawing.Point(4, 1)
        Me.btnSlide.Name = "btnSlide"
        Me.btnSlide.Size = New System.Drawing.Size(35, 34)
        Me.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSlide.TabIndex = 8
        Me.btnSlide.TabStop = False
        '
        'pbMinimizar
        '
        Me.pbMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMinimizar.Image = CType(resources.GetObject("pbMinimizar.Image"), System.Drawing.Image)
        Me.pbMinimizar.Location = New System.Drawing.Point(1021, 0)
        Me.pbMinimizar.Name = "pbMinimizar"
        Me.pbMinimizar.Size = New System.Drawing.Size(36, 34)
        Me.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMinimizar.TabIndex = 12
        Me.pbMinimizar.TabStop = False
        '
        'pbCerrar
        '
        Me.pbCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCerrar.Image = CType(resources.GetObject("pbCerrar.Image"), System.Drawing.Image)
        Me.pbCerrar.Location = New System.Drawing.Point(1063, 1)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(34, 33)
        Me.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCerrar.TabIndex = 13
        Me.pbCerrar.TabStop = False
        '
        'pnlMid
        '
        Me.pnlMid.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMid.Location = New System.Drawing.Point(209, 85)
        Me.pnlMid.Name = "pnlMid"
        Me.pnlMid.Size = New System.Drawing.Size(1097, 703)
        Me.pnlMid.TabIndex = 12
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'fechaYhora
        '
        Me.fechaYhora.Enabled = True
        '
        'TimerCheckUpdates
        '
        '
        'btnAgenda
        '
        Me.btnAgenda.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgenda.FlatAppearance.BorderSize = 0
        Me.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgenda.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgenda.Location = New System.Drawing.Point(0, 241)
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(210, 53)
        Me.btnAgenda.TabIndex = 1
        Me.btnAgenda.Text = " Agenda (F2)"
        Me.btnAgenda.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVentas.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVentas.Location = New System.Drawing.Point(0, 172)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(210, 63)
        Me.btnVentas.TabIndex = 0
        Me.btnVentas.Text = "Venta (F1)"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'BtnInicio
        '
        Me.BtnInicio.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnInicio.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnInicio.FlatAppearance.BorderSize = 0
        Me.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInicio.Font = New System.Drawing.Font("Microsoft JhengHei UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.BtnInicio.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnInicio.Location = New System.Drawing.Point(0, 81)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(210, 50)
        Me.BtnInicio.TabIndex = 0
        Me.BtnInicio.Text = "Vibra Surf"
        Me.BtnInicio.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.SteelBlue
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.btnProductos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProductos.Location = New System.Drawing.Point(-2, 353)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(211, 62)
        Me.btnProductos.TabIndex = 8
        Me.btnProductos.Text = "    Productos (F4)"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnAgregaTrabajador
        '
        Me.btnAgregaTrabajador.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregaTrabajador.FlatAppearance.BorderSize = 0
        Me.btnAgregaTrabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregaTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaTrabajador.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregaTrabajador.Location = New System.Drawing.Point(0, 421)
        Me.btnAgregaTrabajador.Name = "btnAgregaTrabajador"
        Me.btnAgregaTrabajador.Size = New System.Drawing.Size(210, 60)
        Me.btnAgregaTrabajador.TabIndex = 6
        Me.btnAgregaTrabajador.Text = "         Trabajadores (F5)"
        Me.btnAgregaTrabajador.UseVisualStyleBackColor = False
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.SteelBlue
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfig.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConfig.Location = New System.Drawing.Point(0, 477)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(210, 63)
        Me.btnConfig.TabIndex = 6
        Me.btnConfig.Text = "           Configuración (F6)"
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'btnSoporte
        '
        Me.btnSoporte.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSoporte.FlatAppearance.BorderSize = 0
        Me.btnSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoporte.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSoporte.Location = New System.Drawing.Point(-2, 537)
        Me.btnSoporte.Name = "btnSoporte"
        Me.btnSoporte.Size = New System.Drawing.Size(210, 65)
        Me.btnSoporte.TabIndex = 6
        Me.btnSoporte.Text = "Soporte (F7)"
        Me.btnSoporte.UseVisualStyleBackColor = False
        '
        'btnArrendar
        '
        Me.btnArrendar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnArrendar.FlatAppearance.BorderSize = 0
        Me.btnArrendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArrendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.btnArrendar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnArrendar.Location = New System.Drawing.Point(3, 300)
        Me.btnArrendar.Name = "btnArrendar"
        Me.btnArrendar.Size = New System.Drawing.Size(210, 59)
        Me.btnArrendar.TabIndex = 9
        Me.btnArrendar.Text = "  Arriendo (F3)"
        Me.btnArrendar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 185)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 244)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 309)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(42, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(12, 365)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(12, 431)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(12, 487)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(42, 44)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 14
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(12, 546)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(42, 44)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 14
        Me.PictureBox8.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 749)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Copyright © 2019 by BdCodingLS."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(1, 595)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 59)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Reporte Diario"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(-2, 647)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 59)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Reporte Mensual"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'pnlOnleft
        '
        Me.pnlOnleft.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlOnleft.Controls.Add(Me.Button2)
        Me.pnlOnleft.Controls.Add(Me.PictureBox1)
        Me.pnlOnleft.Controls.Add(Me.Button1)
        Me.pnlOnleft.Controls.Add(Me.Label2)
        Me.pnlOnleft.Controls.Add(Me.PictureBox8)
        Me.pnlOnleft.Controls.Add(Me.PictureBox7)
        Me.pnlOnleft.Controls.Add(Me.PictureBox6)
        Me.pnlOnleft.Controls.Add(Me.PictureBox5)
        Me.pnlOnleft.Controls.Add(Me.PictureBox4)
        Me.pnlOnleft.Controls.Add(Me.PictureBox3)
        Me.pnlOnleft.Controls.Add(Me.PictureBox2)
        Me.pnlOnleft.Controls.Add(Me.btnArrendar)
        Me.pnlOnleft.Controls.Add(Me.btnSoporte)
        Me.pnlOnleft.Controls.Add(Me.btnConfig)
        Me.pnlOnleft.Controls.Add(Me.btnAgregaTrabajador)
        Me.pnlOnleft.Controls.Add(Me.btnProductos)
        Me.pnlOnleft.Controls.Add(Me.BtnInicio)
        Me.pnlOnleft.Controls.Add(Me.btnVentas)
        Me.pnlOnleft.Controls.Add(Me.btnAgenda)
        Me.pnlOnleft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlOnleft.Location = New System.Drawing.Point(0, 0)
        Me.pnlOnleft.Name = "pnlOnleft"
        Me.pnlOnleft.Size = New System.Drawing.Size(209, 788)
        Me.pnlOnleft.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1306, 788)
        Me.Controls.Add(Me.pnlMid)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlOnleft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOnleft.ResumeLayout(False)
        Me.pnlOnleft.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbRut As TextBox
    Friend WithEvents tbContraseña As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnSlide As PictureBox
    Friend WithEvents pbMinimizar As PictureBox
    Friend WithEvents pbCerrar As PictureBox
    Friend WithEvents pnlMid As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents Timer2 As Timer
    Friend WithEvents fechaYhora As Timer
    Friend WithEvents TimerCheckUpdates As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAgenda As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents BtnInicio As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnAgregaTrabajador As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents btnSoporte As Button
    Friend WithEvents btnArrendar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents pnlOnleft As Panel
    Friend WithEvents LineShape3 As PowerPacks.LineShape
End Class
