Public Class agenda
    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Private mes, ano As String
    Private Sub GenerarDayPanel(ByVal dias As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()
        For i As Integer = 1 To dias
            Dim fl As New FlowLayoutPanel
            fl.Name = "flDay" + i.ToString()
            fl.Size = New Size(145, 90)
            'fl.Size = New Size(102, 84)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            AddHandler fl.Click, AddressOf addNewAppointment
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub
    Private Sub AddLabbelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next
        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = "lblDay" + i.ToString()
            lbl.AutoSize = False
            'lbl.Size = New Size(24, 22)
            lbl.Size = New Size(29, 27)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sams Serif", 11)
            Try
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)
            Catch ex As Exception
            End Try
            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.Aqua
            End If
        Next

    End Sub
    Private Sub addNewAppointment(ByVal sender As Object, e As EventArgs)
        Me.Refresh()
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then
            With DetalleDeAgenda
                .dtpDate.Value = New Date(currentDate.Year, currentDate.Month, day)
                .AppID = 0
                .Text = ""
                .tbTelefono.Text = ""
                .tbComentario.Text = ""
                .tbInfoExtra.Text = ""
                .cbActividad.Text = ""
                .cbBloque.Text = ""
                .cbTrabajador.Text = ""
                .txtSearch.Text = ""
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
    End Sub
    Private Sub showAppointmentDetail(sender As Object, e As EventArgs)
        Me.Refresh()
        Dim appID As Integer = CType(sender, LinkLabel).Tag
        Dim sql As String = "SELECT Agendas.ID,Agendas.Fecha,Agendas.NombreActividad,Agendas.Letrabloque,Agendas.NombreCliente,Trabajadores.Nombre,Agendas.Comentario From Agendas INNER JOIN Trabajadores ON Trabajadores.RutTrabajador = Agendas.RutTrabajador WHERE ID=" & appID
        Dim dt As DataTable = QueryAsDataTable(sql)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            With DetalleDeAgenda
                .AppID = appID
                .cbActividad.Text = row("NombreActividad")
                .cbBloque.Text = row("Letrabloque")
                .txtSearch.Text = row("NombreCliente")
                .cbTrabajador.Text = row("Nombre")
                .tbComentario.Text = row("Comentario")
                .dtpDate.Value = row("Fecha")
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
    End Sub
    Private Sub AddAppointmentToflDay(ByVal startDayAtFlNumber As Integer)

        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)
        Dim sql As String = "SELECT Agendas.ID,Agendas.Fecha,Agendas.NombreActividad,Agendas.Letrabloque,Agendas.NombreCliente,Agendas.RutTrabajador,Agendas.Comentario FROM Agendas WHERE (Agendas.Fecha >= #" + startDate.ToString("dd-MM-yyyy") + "#) AND (Agendas.fecha <= #" + endDate.ToString("dd-MM-yyyy") + "#)"
        Dim dt As DataTable = New DataTable
        dt = QueryAsDataTable(sql)
        Dim cont As Integer
        cont = dt.Rows.Count()
        Dim diai, mesi, anoi, diaf, mesf, anof As Integer
        diai = startDate.ToString("dd")
        mesi = startDate.ToString("MM")
        anoi = startDate.ToString("yyyy")
        diaf = endDate.ToString("dd")
        mesf = endDate.ToString("MM")
        anof = endDate.ToString("yyyy")
        For Each row As DataRow In dt.Rows
            Dim appDay As DateTime = DateTime.Parse(row("Fecha"))
            Dim dia, mes, ano As Integer
            dia = appDay.ToString("dd")
            mes = appDay.ToString("MM")
            ano = appDay.ToString("yyyy")
            If (dia >= diai And mes = mesi And ano = anoi) And (dia <= diaf And mes = mesf And ano = anof) Then
                Dim link As New LinkLabel
                link.Tag = row("ID")
                link.Name = "link" + row("ID").ToString()
                link.AutoSize = False
                link.Size = New Size(133, 20)
                Dim bloque As String = row("Letrabloque")
                link.Text = bloque + "- " + row("NombreCliente")
                AddHandler link.Click, AddressOf showAppointmentDetail
                listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link)
            End If
        Next
    End Sub

    Private Function GetFirstDayOfWeekdOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function
    Private Sub today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub
    Private Sub DisplayCurrentDate()
        lblMesAño.Text = currentDate.ToString("MMMM, yyyy")
        mes = currentDate.ToString("MM")
        ano = currentDate.ToString("yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekdOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabbelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToflDay(firstDayAtFlNumber)
    End Sub
    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub
    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub
    Private Sub Agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarDayPanel(37)
        DisplayCurrentDate()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMesAnterior.Click
        PrevMonth()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMesSiguiente.Click
        NextMonth()
    End Sub

    Private Sub BntHoy_Click(sender As Object, e As EventArgs) Handles bntHoy.Click
        today()
    End Sub
End Class