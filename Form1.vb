Imports System.Runtime.InteropServices
Public Class Form1
    Public llenado As Single = 1
    Public oculto As Boolean = False

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub pnlTop_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'Private Sub BtnSlide_Click(sender As Object, e As EventArgs) Handles btnSlide.Click
    '   Timer1.Enabled = True
    '  Timer1.Start()
    'End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Application.Exit()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Public Sub abrirFormulario(frmHijo As Object)
        If (pnlMid.Controls.Count) > 0 Then
            pnlMid.Controls.RemoveAt(0)
        End If
        Dim frm As Form
        frm = frmHijo
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        pnlMid.Controls.Add(frm)
        pnlMid.Tag = frm
        frm.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retroceder = 1
        Module1.poder = 1
        Module1.poder1 = 1
        Try
            Module1.conectar()

        Catch ex As Exception
            MsgBox("No se pudo conectar a la BD", vbCritical, "Error!")

            MsgBox(ex.ToString())
            Application.Exit()
            Me.Close()
        End Try

        'Licencia()
        abrirFormulario(agenda)
        If My.Settings.AutoUpdate = True Then
            TimerCheckUpdates.Enabled = True
            TimerCheckUpdates.Start()
            Button1.FlatStyle = FlatStyle.Flat
            Button1.FlatAppearance.BorderColor = Color.DodgerBlue
            Button2.FlatAppearance.BorderColor = Color.DodgerBlue
        End If

        tbRut.Focus()
    End Sub
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    'If oculto = False Then
    '       pnlOnleft.Width -= 8
    'If pnlOnleft.Width <= 56 Then
    '           pnlOnleft.Width = 56
    '          Label2.Text = "© 2019"
    '         lblFecha.Visible = False
    '        Timer1.Stop()
    '       oculto = True
    '      BtnInicio.Hide()
    '
    'End If
    'Else
    '       lblFecha.Visible = True
    '      pnlOnleft.Width += 8
    'If pnlOnleft.Width >= 209 Then
    '           pnlOnleft.Width = 209
    ''          Label2.Text = "Copyright © 2019 by BDCoding."
    '        Timer1.Stop()
    '       oculto = False
    '           BtnInicio.Show()
    '  End If
    'End ' If
    'End Sub '
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        pnlTop.Height -= 2
        If pnlTop.Height <= 35 Then
            pnlTop.Height = 35
            Timer2.Stop()
        End If
        'LineShape3.Show()
    End Sub
    Private Sub FechaYhora_Tick(sender As Object, e As EventArgs) Handles fechaYhora.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString
        lblFecha.Text = DateTime.Now.ToLongDateString
    End Sub
    Dim con As Integer = 0
    Private Sub TimerCheckUpdates_Tick(sender As Object, e As EventArgs) Handles TimerCheckUpdates.Tick
        con += 1
        If con = 2 Then
            TimerCheckUpdates.Stop()
            CheckUpdates("https://sites.google.com/site/vibrasurf2019bdcoding/updates/vibrasurf-update.txt?attredirects=0&d=1")
        End If
    End Sub
    Private Sub tbContraseña_Click(sender As Object, e As EventArgs) Handles tbContraseña.Click
        tbContraseña.Text = ""
    End Sub
    Private Sub tbRut_Click(sender As Object, e As EventArgs) Handles tbRut.Click
        tbRut.Text = ""
    End Sub
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT Trabajadores.RutTrabajador,Trabajadores.Contraseña FROM Trabajadores WHERE (Trabajadores.RutTrabajador=+" & tbRut.Text & " AND STRCOMP (Trabajadores.Contraseña,'" & tbContraseña.Text & "',0)=0 AND Trabajadores.TipoTrabajador=1)", Module1.con)
            If Not rst.EOF Then
                Module1.estado = 1
                btnIngresar.Hide()
                tbContraseña.Hide()
                tbRut.Hide()
                LineShape1.Hide()
                LineShape2.Hide()
                Timer2.Enabled = True
                Timer2.Start()
                LineShape3.Show()
            Else
                MsgBox("Ingrese valores correctos")
            End If
        Catch ex As Exception
            MsgBox("No encontramos esos valores en nuestros Registros")
        End Try
        Module1.Rut = Me.tbRut.Text


    End Sub
    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        abrirFormulario(agenda)
    End Sub
    Private Sub ErrorIniciarSesion(sender As Object, e As EventArgs) Handles btnVentas.Click, btnAgenda.Click, btnArrendar.Click, btnAgregaTrabajador.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, btnConfig.Click, btnSoporte.Click
        If estado = 0 Then
            MsgBox("Debe iniciar sesion!", vbCritical)
        End If
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click, PictureBox2.Click
        Dim ssql As String
        Dim idnew As String
        Dim PEDSQL As String
        Carrito.tbCuantoPaga.Hide()
        Carrito.lblVuelto.Hide()
        Carrito.tbCuantoPaga.ResetText()
        Carrito.lblVuelto.ResetText()
        If Module1.estado = 1 Then
            abrirFormulario(EleccionProductos)
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT * FROM Trabajadores WHERE RutTrabajador=" & Module1.Rut, Module1.con)
            Module1.Nombre = rst.Fields("Nombre").Value()
            EleccionProductos.lblNombreAtendedor.Text = Module1.Nombre
            rst.Close()
            If Module1.retroceder <> 2 Then
                Module1.rst = New ADODB.Recordset
                ssql = "SELECT IIF(MAX(IdVenta)<>NULL,MAX(IdVenta)+1,1) as maximo FROM Ventas"
                rst.Open(ssql, Module1.con)
                idnew = rst.Fields("maximo").Value()
                Module1.rst = New ADODB.Recordset
                Dim IdElimina As String = CSng(idnew) - 1
                rst.Open("SELECT * FROM Ventas WHERE Ventas.IdVenta=" & IdElimina, Module1.con)
                Dim total As String = rst.Fields("Total").Value()
                Dim metodoPago As String = rst.Fields("MetodoPago").Value()
                If total = "0" And metodoPago = "0" Then
                    Module1.rst = New ADODB.Recordset
                    rst.Open("DELETE FROM Ventas WHERE Ventas.IdVenta=" & IdElimina, Module1.con)
                    Module1.idVenta = IdElimina
                    Module1.rst = New ADODB.Recordset
                    PEDSQL = "INSERT INTO Ventas VALUES (" + IdElimina + ",'" + Module1.Rut + "',DATE(),TIME(),0,0)"
                    rst.Open(PEDSQL, Module1.con)
                Else
                    Module1.idVenta = idnew
                    Module1.rst = New ADODB.Recordset
                    PEDSQL = "INSERT INTO Ventas VALUES (" + idnew + ",'" + Module1.Rut + "',DATE(),TIME(),0,0)"
                    rst.Open(PEDSQL, Module1.con)
                End If
            End If
            Module1.llenarDGV()
            Module1.retroceder = 2
        End If
        EleccionProductos.tbSearch.Focus()
        EleccionProductos.lbNumPedido.Text = Module1.idVenta
    End Sub
    Private Sub BtnAgenda_Click(sender As Object, e As EventArgs) Handles btnAgenda.Click, PictureBox3.Click
        If estado = 1 Then
            abrirFormulario(agenda)
        End If
    End Sub
    Private Sub BtnArrendar_Click(sender As Object, e As EventArgs) Handles btnArrendar.Click, PictureBox4.Click
        If estado = 1 Then
            abrirFormulario(Arriendo)
        End If
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click, PictureBox5.Click
        If estado = 1 Then
            Me.abrirFormulario(Productos)
            Productos.llenar_productos()
        End If
    End Sub
    Private Sub BtnAgregaTrabajador_Click(sender As Object, e As EventArgs) Handles btnAgregaTrabajador.Click, PictureBox6.Click
        If estado = 1 Then
            abrirFormulario(Trabajadores)
        End If
    End Sub
    Private Sub BtnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click, PictureBox7.Click
        If estado = 1 Then
            abrirFormulario(Configuracion)
        End If
    End Sub
    Private Sub BtnSoporte_Click(sender As Object, e As EventArgs) Handles btnSoporte.Click, PictureBox8.Click
        If estado = 1 Then
            abrirFormulario(Soporte)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReporteDiario.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReporteMensual.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown


        If estado = 1 Then
            If e.KeyData = Keys.F1 Then
                abrirFormulario(EleccionProductos)
            End If
            If e.KeyData = Keys.F2 Then
                abrirFormulario(agenda)
            End If
            If e.KeyData = Keys.F3 Then
                abrirFormulario(Arriendo)
            End If
            If e.KeyData = Keys.F4 Then
                abrirFormulario(Productos)
            End If
            If e.KeyData = Keys.F5 Then
                abrirFormulario(Trabajadores)
            End If
            If e.KeyData = Keys.F6 Then
                abrirFormulario(Configuracion)
            End If
            If e.KeyData = Keys.F7 Then
                abrirFormulario(Soporte)
            End If

        End If

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)

    End Sub
End Class
