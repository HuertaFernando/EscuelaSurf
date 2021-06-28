Imports System.Data
Imports System.Data.OleDb
Imports System.Net.Mail
Module Module1
    Public poder As Single
    Public poder1 As Single
    Public estado As Single
    Public retroceder As Single
    Public idVenta As String
    Public Rut As String
    Public Nombre As String
    Public Completar As Single
    Public con As New ADODB.Connection
    Public rst As ADODB.Recordset
    Public alerta As Boolean
    Public cantidad As String
    Public alertaP As Boolean


    Public Sub EnviaMail()
        Dim message As New MailMessage
        Dim smtp As New SmtpClient

        With message
            .From = New System.Net.Mail.MailAddress("suppbdcodingls@gmail.com")
            'para .add
            .To.Add("bdcodingls@gmail.com")
            .Body = Soporte.RichTextBox1.Text + " " + Soporte.TextBox1.Text
            .Subject = "Aviso de error"
            .Priority = System.Net.Mail.MailPriority.Normal
        End With

        With smtp
            .EnableSsl = True
            .Port = "587"
            .Host = "smtp.gmail.com"
            .Credentials = New Net.NetworkCredential("suppbdcodingls@gmail.com", "2019support1BD")
            .Send(message)
        End With

        Try
            MessageBox.Show("Su mensaje de correo ha sido enviado.", "Correo enviado",
                                 MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error al enviar correo",
                                 MessageBoxButtons.OK)
        End Try
    End Sub
    Public Sub Licencia()
        If My.Settings.Dia < DateTime.Today.ToString("dd-MM-yyyy") Then
            My.Settings.Cont_Dias += 1
        End If
        My.Settings.Save()
        Form1.BtnInicio.Text = My.Settings.Cont_Dias.ToString()
        MsgBox(My.Settings.Cont_Dias)
        If My.Settings.Cont_Dias >= 355 And My.Settings.Cont_Dias <> 365 Then
            MsgBox("El programa dejara de funcionar ya que caducara la licencia", vbCritical)
            MsgBox("Contacte con BDCoding antes de que el programa deje de funcionar", vbInformation)
        End If
        If My.Settings.Cont_Dias = 365 Then
            Form1.Enabled = False
            Form2.Enabled = False
            Carrito.Enabled = False
            Configuracion.Enabled = False
            EleccionProductos.Enabled = False
            Arriendo.Enabled = False
            agenda.Enabled = False
            Productos.Enabled = False
        End If
    End Sub
    Public Sub CheckUpdates(link)
        Dim archivo As String = ""
        Dim web As New Net.WebClient
        Dim site As String = link
        Try
            archivo = web.DownloadString(site)
        Catch ex As Exception
        End Try
        Dim version As String = ""
        Dim linea As Double = 0
        Dim delimitadores() As String = {vbCrLf, vbLf}
        For Each texto As String In archivo.Split(delimitadores, StringSplitOptions.None)
            If linea = 0 Then
                version += texto
                linea += 1
            End If
        Next
        If version > Application.ProductVersion = True Then
            If MsgBox("Actualización Disponible, si desea actualizar el programa se cerrara.", vbYesNo + vbInformation) = vbYes Then
                Application.Exit()
                Process.Start(My.Computer.FileSystem.CurrentDirectory + "\Updater.exe")
            End If
        End If
    End Sub

    Public Function IsConfirm(ByVal message As String) As Boolean
        Return MessageBox.Show(message, "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Public Function conectar()
        con.ConnectionString = "DSN=EscuelaSurf1"
        con.Open()
        conectar = con
    End Function

    Public Sub llenarDGV()
        If estado = 1 Then
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT Cantidad, NombreProducto as Nombre, PrecioProducto as Precio, IdProducto FROM DetalleBoleta WHERE ID=" + Module1.idVenta, Module1.con)
            Dim ODA As New OleDb.OleDbDataAdapter
            Dim tb As New DataTable
            Dim ds As DataSet = New DataSet
            ODA.Fill(ds, Module1.rst, "Table1")
            EleccionProductos.DataGridView1.DataSource = ds.Tables("Table1").DefaultView
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT SUM(PrecioProducto*Cantidad) AS Total FROM DetalleBoleta WHERE ID=" + Module1.idVenta + " GROUP BY ID", Module1.con)
            If Not rst.EOF Then
                EleccionProductos.lblTotal.Text = rst.Fields("Total").Value()
                rst.Close()
                Module1.rst = New ADODB.Recordset
                rst.Open("UPDATE Ventas SET Total=" + EleccionProductos.lblTotal.Text + " WHERE IdVenta=" + Module1.idVenta, Module1.con)
            Else
                Module1.rst = New ADODB.Recordset
                rst.Open("UPDATE Ventas SET Total= 0 WHERE IdVenta=" + Module1.idVenta, Module1.con)
                EleccionProductos.lblTotal.Text = "0"
            End If
        End If


    End Sub

    Public Sub Email(emisor, clave, receptor, asunto1, asunto2, cuerpo, archivo)  'Esta en Pago
        Dim Mensaje As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient
        'CONFIGURACIÓN DEL STMP
        _SMTP.Credentials = New System.Net.NetworkCredential(emisor, clave.ToString())
        _SMTP.Host = "smtp.gmail.com"
        _SMTP.Port = 587
        _SMTP.EnableSsl = True
        ' CONFIGURACION DEL MENSAJE
        Mensaje.[To].Add(receptor) 'Cuenta de Correo al que se le quiere enviar el e-mail
        Mensaje.From = New System.Net.Mail.MailAddress(emisor, asunto1, System.Text.Encoding.UTF8) 'Quien lo envía
        Mensaje.Subject = asunto2 'Sujeto del e-mail
        Mensaje.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        Mensaje.Body = cuerpo 'contenido del mail
        If archivo <> Nothing Then
            Mensaje.Attachments.Add(New System.Net.Mail.Attachment(archivo))
        End If
        Mensaje.BodyEncoding = System.Text.Encoding.UTF8
        Mensaje.Priority = System.Net.Mail.MailPriority.Normal
        Mensaje.IsBodyHtml = False
        Try
            _SMTP.Send(Mensaje)
            MessageBox.Show("Mensaje enviado correctamente", "Exito!", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show("Error, Conectese a internet para poder enviar el correo.")
        End Try
    End Sub
    Public x As Integer
    Public posicion, valor, mult, sum, num As Integer
    Public rutaux, digito As String
    Public verificar As Boolean
    Public Sub rutificador()
        sum = 0
        'rutaux = 'texto del rut
        posicion = CInt(rutaux.Length()) - 1
        mult = 2
        While posicion >= 0
            valor = CInt(rutaux.Substring(posicion, 1))
            posicion -= 1
            If mult > 7 Then
                mult = 2
            End If
            sum += (valor * mult)
            mult += 1
        End While
        num = 11 - (sum Mod 11)
        digito = num
        If num = 11 Then
            digito = "0"
        ElseIf num = 10 Then
            digito = "K"
        End If
        '  If rutaux + digito = Register.rut Then
        ' verificar = True
        '  Else
        '  verificar = False
        '  End If
    End Sub
    Public Function QueryAsDataTable(ByVal sql As String) As DataTable
        Module1.rst = New ADODB.Recordset

        rst.Open(sql, Module1.con)
        Dim da As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        da.Fill(ds, Module1.rst, "result")
        Return ds.Tables("result")
    End Function




End Module
