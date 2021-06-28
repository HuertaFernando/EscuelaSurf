Imports System.Data
Imports System.Data.OleDb
Public Class DetalleDeAgenda
    Private con As New OleDb.OleDbConnection
    Private command As OleDb.OleDbCommand
    Private adapter As OleDbDataAdapter
    Private reader As OleDbDataReader
    Private dataSt As DataSet


    Public AppID As Integer = 0
    Dim contador As Integer = 0

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (cbActividad.Text <> "" And txtSearch.Text <> "" And cbBloque.Text <> "" And tbTelefono.Text <> "" And cbTrabajador.Text <> "") Then
            If IsConfirm("Quieres guardar la cita?") Then
                If AppID = 0 Then
                    Dim rut As String = ""
                    Dim ssql As String
                    Dim idnew As String
                    Dim sql As String
                    Module1.rst = New ADODB.Recordset
                    rst.Open("Select Trabajadores.RutTrabajador from Trabajadores where Nombre='" + cbTrabajador.Text + "'", Module1.con)
                    If Not rst.EOF Then
                        rut = rst.Fields("RutTrabajador").Value()
                    End If

                    Module1.rst = New ADODB.Recordset
                    ssql = "SELECT IIF(MAX(ID)<>NULL,MAX(ID)+1,1) as maximo FROM Agendas"
                    rst.Open(ssql, Module1.con)
                    idnew = rst.Fields("maximo").Value()
                    Module1.rst = New ADODB.Recordset
                    If contador = 1 Then
                        rst.Open("SELECT TipoTrabajador FROM Trabajadores WHERE RutTrabajador = " + rut + "", Module1.con)

                        If Not rst.EOF Then
                            If rst.Fields("TipoTrabajador").Value = 3 Then
                                Module1.rst = New ADODB.Recordset

                                If cbActividad.Text = "Surf" Or cbActividad.Text = "Surf Electrico" Then  '''''1
                                    sql = "INSERT INTO Agendas(ID,Fecha,NombreActividad,LetraBloque,NombreCliente,RutTrabajador,Comentario,smooth, agregado) Values ('" + idnew + "','" + dtpDate.Value.ToShortDateString() + "','" + cbActividad.Text + "','" + cbBloque.Text + "','" + txtSearch.Text + "','" + rut + "','" + tbComentario.Text + "', 1,1000)"
                                    rst.Open(sql, Module1.con)
                                    MsgBox("Cita Guardada.")
                                Else
                                    sql = "INSERT INTO Agendas(ID,Fecha,NombreActividad,LetraBloque,NombreCliente,RutTrabajador,Comentario,smooth, agregado) Values ('" + idnew + "','" + dtpDate.Value.ToShortDateString() + "','" + cbActividad.Text + "','" + cbBloque.Text + "','" + txtSearch.Text + "','" + rut + "','" + tbComentario.Text + "', 1,0)"
                                    rst.Open(sql, Module1.con)
                                    MsgBox("Cita Guardada.")

                                End If

                            Else
                                Module1.rst = New ADODB.Recordset
                                sql = "INSERT INTO Agendas(ID,Fecha,NombreActividad,LetraBloque,NombreCliente,RutTrabajador,Comentario,smooth, agregado) Values ('" + idnew + "','" + dtpDate.Value.ToShortDateString() + "','" + cbActividad.Text + "','" + cbBloque.Text + "','" + txtSearch.Text + "','" + rut + "','" + tbComentario.Text + "', 1,0)"
                                rst.Open(sql, Module1.con)
                                MsgBox("Cita Guardada.")
                            End If

                        End If

                    Else
                        rst.Open("SELECT TipoTrabajador FROM Trabajadores WHERE RutTrabajador = " + rut + "", Module1.con)

                        If Not rst.EOF Then
                            If rst.Fields("TipoTrabajador").Value = 3 Then
                                Module1.rst = New ADODB.Recordset

                                If cbActividad.Text = "Surf" Or cbActividad.Text = "Surf electrico" Then            '''''''''''''2
                                    sql = "INSERT INTO Agendas(ID,Fecha,NombreActividad,LetraBloque,NombreCliente,RutTrabajador,Comentario,smooth, agregado) Values ('" + idnew + "','" + dtpDate.Value.ToShortDateString() + "','" + cbActividad.Text + "','" + cbBloque.Text + "','" + txtSearch.Text + "','" + rut + "','" + tbComentario.Text + "', 0,1000)"
                                    rst.Open(sql, Module1.con)
                                    MsgBox("Cita Guardada.")
                                Else
                                    sql = "INSERT INTO Agendas(ID,Fecha,NombreActividad,LetraBloque,NombreCliente,RutTrabajador,Comentario,smooth, agregado) Values ('" + idnew + "','" + dtpDate.Value.ToShortDateString() + "','" + cbActividad.Text + "','" + cbBloque.Text + "','" + txtSearch.Text + "','" + rut + "','" + tbComentario.Text + "', 0,0)"
                                    rst.Open(sql, Module1.con)
                                    MsgBox("Cita Guardada.")

                                End If

                            Else
                                Module1.rst = New ADODB.Recordset
                                sql = "INSERT INTO Agendas(ID,Fecha,NombreActividad,LetraBloque,NombreCliente,RutTrabajador,Comentario,smooth, agregado) Values ('" + idnew + "','" + dtpDate.Value.ToShortDateString() + "','" + cbActividad.Text + "','" + cbBloque.Text + "','" + txtSearch.Text + "','" + rut + "','" + tbComentario.Text + "', 0,0)"
                                rst.Open(sql, Module1.con)
                                MsgBox("Cita Guardada.")
                            End If

                        End If

                    End If
                    Trabajadores.jiji()
                    ReporteDiario.llenar2()
                    Me.Hide()
                Else
                    If dtpDate.Value.Day < 13 Then
                        Dim rutt As String = ""
                        Module1.rst = New ADODB.Recordset
                        rst.Open("Select Trabajadores.RutTrabajador,Trabajadores.Nombre,Trabajadores.Contraseña FROM Trabajadores WHERE Nombre='" + cbTrabajador.Text + "'", Module1.con)
                        If Not rst.EOF Then
                            rutt = rst.Fields("RutTrabajador").Value
                        End If
                        Dim peo1 As String
                        Module1.rst = New ADODB.Recordset


                        rst.Open("SELECT TipoTrabajador FROM Trabajadores WHERE RutTrabajador = " + rutt + "", Module1.con)

                        If Not rst.EOF Then
                            If rst.Fields("TipoTrabajador").Value = 3 Then
                                Module1.rst = New ADODB.Recordset

                                If cbActividad.Text = "Surf" Or cbActividad.Text = "Surf Electrico" Then                     '3

                                    peo1 = "UPDATE Agendas SET Agendas.ID =" + AppID.ToString() + ", Agendas.Fecha= #" + dtpDate.Value.ToString("MM/dd/yyyy") + "#, Agendas.NombreActividad ='" & cbActividad.Text.ToString() & "', Agendas.Letrabloque='" & cbBloque.Text.ToString() & "', Agendas.NombreCliente= '" & txtSearch.Text.ToString() & "', Agendas.RutTrabajador=" & rutt.ToString() & ", Agendas.Comentario='" & tbComentario.Text.ToString() & "', Agendas.smooth= " & contador & ", Agendas.agregado = 1000 WHERE Agendas.ID=" & AppID.ToString() & ""
                                    rst.Open(peo1, Module1.con)
                                    MsgBox("Cita Actualizada")
                                Else
                                    peo1 = "UPDATE Agendas SET Agendas.ID =" + AppID.ToString() + ", Agendas.Fecha= #" + dtpDate.Value.ToString("MM/dd/yyyy") + "#, Agendas.NombreActividad ='" & cbActividad.Text.ToString() & "', Agendas.Letrabloque='" & cbBloque.Text.ToString() & "', Agendas.NombreCliente= '" & txtSearch.Text.ToString() & "', Agendas.RutTrabajador=" & rutt.ToString() & ", Agendas.Comentario='" & tbComentario.Text.ToString() & "', Agendas.smooth= " & contador & ", Agendas.agregado = 0 WHERE Agendas.ID=" & AppID.ToString() & ""
                                    rst.Open(peo1, Module1.con)
                                    MsgBox("Cita Actualizada")
                                End If

                            Else
                                Module1.rst = New ADODB.Recordset
                                peo1 = "UPDATE Agendas SET Agendas.ID =" + AppID.ToString() + ", Agendas.Fecha= #" + dtpDate.Value.ToString("MM/dd/yyyy") + "#, Agendas.NombreActividad ='" & cbActividad.Text.ToString() & "', Agendas.Letrabloque='" & cbBloque.Text.ToString() & "', Agendas.NombreCliente= '" & txtSearch.Text.ToString() & "', Agendas.RutTrabajador=" & rutt.ToString() & ", Agendas.Comentario='" & tbComentario.Text.ToString() & "', Agendas.smooth= " & contador & ", Agendas.agregado = 0 WHERE Agendas.ID=" & AppID.ToString() & ""
                                rst.Open(peo1, Module1.con)
                                MsgBox("Cita Actualizada")
                            End If

                        End If
                        Trabajadores.jiji()
                        ReporteDiario.llenar2()
                        Me.Hide()
                    Else


                        Dim rutt As String = ""
                        Module1.rst = New ADODB.Recordset
                        rst.Open("Select Trabajadores.RutTrabajador,Trabajadores.Nombre,Trabajadores.Contraseña FROM Trabajadores WHERE Nombre='" + cbTrabajador.Text + "'", Module1.con)
                        If Not rst.EOF Then
                            rutt = rst.Fields("RutTrabajador").Value
                        End If
                        Dim peo1 As String
                        Module1.rst = New ADODB.Recordset



                        rst.Open("SELECT TipoTrabajador FROM Trabajadores WHERE RutTrabajador = " + rutt + "", Module1.con)

                        If Not rst.EOF Then
                            If rst.Fields("TipoTrabajador").Value = 3 Then
                                Module1.rst = New ADODB.Recordset

                                If cbActividad.Text = "Surf" Or cbActividad.Text = "Surf Electrico" Then               '4
                                    peo1 = "UPDATE Agendas SET Agendas.ID =" + AppID.ToString() + ", Agendas.Fecha= #" + dtpDate.Value.ToShortDateString + "#, Agendas.NombreActividad ='" & cbActividad.Text.ToString() & "', Agendas.Letrabloque='" & cbBloque.Text.ToString() & "', Agendas.NombreCliente= '" & txtSearch.Text.ToString() & "', Agendas.RutTrabajador=" & rutt.ToString() & ", Agendas.Comentario='" & tbComentario.Text.ToString() & "', Agendas.smooth = " & contador & ", Agendas.agregado = 1000 WHERE Agendas.ID=" & AppID.ToString() & ""
                                    rst.Open(peo1, Module1.con)
                                    MsgBox("Cita Actualizada")

                                Else
                                    peo1 = "UPDATE Agendas SET Agendas.ID =" + AppID.ToString() + ", Agendas.Fecha= #" + dtpDate.Value.ToShortDateString + "#, Agendas.NombreActividad ='" & cbActividad.Text.ToString() & "', Agendas.Letrabloque='" & cbBloque.Text.ToString() & "', Agendas.NombreCliente= '" & txtSearch.Text.ToString() & "', Agendas.RutTrabajador=" & rutt.ToString() & ", Agendas.Comentario='" & tbComentario.Text.ToString() & "', Agendas.smooth = " & contador & ", Agendas.agregado = 0 WHERE Agendas.ID=" & AppID.ToString() & ""
                                    rst.Open(peo1, Module1.con)
                                    MsgBox("Cita Actualizada")
                                End If

                            Else
                                peo1 = "UPDATE Agendas SET Agendas.ID =" + AppID.ToString() + ", Agendas.Fecha= #" + dtpDate.Value.ToShortDateString + "#, Agendas.NombreActividad ='" & cbActividad.Text.ToString() & "', Agendas.Letrabloque='" & cbBloque.Text.ToString() & "', Agendas.NombreCliente= '" & txtSearch.Text.ToString() & "', Agendas.RutTrabajador=" & rutt.ToString() & ", Agendas.Comentario='" & tbComentario.Text.ToString() & "', Agendas.smooth = " & contador & ", Agendas.agregado = 0 WHERE Agendas.ID=" & AppID.ToString() & ""
                                rst.Open(peo1, Module1.con)
                                MsgBox("Cita Actualizada")
                            End If

                        End If




                        Trabajadores.jiji()
                        ReporteDiario.llenar2()


                        Me.Hide()
                    End If
                End If
            Else
                MsgBox("Todos los Campos son requeridos!")
            End If
        End If
        Me.Refresh()
        cbActividad.Text = "0"
        cbBloque.Text = "0"
        cbTrabajador.Text = "0"
        txtSearch.ResetText()
        tbComentario.Text = ""
#esto es una prueba
    End Sub

    Private Sub DetalleDeAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + My.Computer.FileSystem.CurrentDirectory + "/EscuelaSurf.mdb"
        With con
            If .State = ConnectionState.Closed Then
                .ConnectionString = strcon
                .Open()
            End If
        End With
        If Module1.poder = 1 Then
            Module1.rst = New ADODB.Recordset
            rst.Open("Select Actividades.NombreActividad from Actividades", Module1.con)
            While Not rst.EOF
                cbActividad.Items.Add(rst.Fields("NombreActividad").Value())
                rst.MoveNext()
            End While
            Module1.rst = New ADODB.Recordset
            rst.Open("Select Bloques.LetraBloque from Bloques", Module1.con)
            While Not rst.EOF
                cbBloque.Items.Add(rst.Fields("LetraBloque").Value())

                rst.MoveNext()

            End While
            Module1.poder = 2
        End If

        If AppID = 0 Then
            Me.Refresh()
            cbActividad.Text = "0"
            cbBloque.Text = "0"
            cbTrabajador.Text = "0"
            txtSearch.Text = ""
            tbTelefono.Text = ""
            tbComentario.Text = ""
            btnDelete.Visible = False
        Else
            Me.Refresh()
            btnDelete.Visible = True
        End If
        AutoComplete()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
        Module1.poder = 2
        Me.Refresh()
        cbActividad.Text = "0"
        cbBloque.Text = "0"
        cbTrabajador.Text = "0"
        txtSearch.ResetText()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Module1.poder = 2
        If IsConfirm("Quiere eliminar esta cita?") Then
            Module1.rst = New ADODB.Recordset
            rst.Open("DELETE FROM Agendas WHERE Agendas.ID=" & AppID.ToString() & "", Module1.con)
            MsgBox("Cita Borrada")
            Me.Refresh()
            Me.Close()
        End If
        Me.Refresh()
        cbActividad.Text = ""
        cbBloque.Text = ""
        cbTrabajador.Text = ""
        txtSearch.ResetText()
        Trabajadores.jiji()
        ReporteDiario.llenar2()

    End Sub
    Private Sub AutoComplete()
        Dim sql As String
        sql = "Select Personas.NombreCliente from Personas"
        command = New OleDbCommand(sql, con)
        reader = command.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()
        While reader.Read()
            autocomp.Add(reader("NombreCLiente"))

        End While
        reader.Close()
        txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest
        txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSearch.AutoCompleteCustomSource = autocomp
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Module1.rst = New ADODB.Recordset
            rst.Open("Select Personas.NombreCliente,Personas.Telefono,Personas.InformacionExtra FROM Personas WHERE Personas.NombreCliente='" + txtSearch.Text + "'", Module1.con)
            Dim numero As String
            Dim Info As String
            numero = rst.Fields("Telefono").Value()
            Info = rst.Fields("InformacionExtra").Value()
            tbInfoExtra.Text = Info
            tbTelefono.Text = numero
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        AgregarCliente.Show()
    End Sub
    Private Sub cbBloque_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBloque.SelectedIndexChanged
        Label9.Text = cbBloque.Text
        cbTrabajador.Items.Clear()
        Dim strcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + My.Computer.FileSystem.CurrentDirectory + "/EscuelaSurf.mdb"
        With con

            If .State = ConnectionState.Closed Then
                .ConnectionString = strcon
                .Open()
            End If
        End With
        If dtpDate.Value.Day < 13 Then
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT Trabajadores.Nombre FROM Trabajadores WHERE Trabajadores.RutTrabajador NOT IN (SELECT Agendas.RutTrabajador FROM Agendas WHERE (Agendas.Letrabloque='" + Label9.Text + "') AND  (Agendas.Fecha = #" + dtpDate.Value.ToString("MM/dd/yyyy") + "#) GROUP BY Agendas.RutTrabajador) AND (Trabajadores.TipoTrabajador = 2 OR Trabajadores.TipoTrabajador = 3 ) GROUP BY Trabajadores.Nombre", Module1.con)
            While Not rst.EOF
                cbTrabajador.Items.Add(rst.Fields("Nombre").Value.ToString)
                rst.MoveNext()
            End While
            Module1.poder = 2
        Else
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT Trabajadores.Nombre FROM Trabajadores WHERE Trabajadores.RutTrabajador NOT IN (SELECT Agendas.RutTrabajador FROM Agendas WHERE (Agendas.Letrabloque='" + Label9.Text + "') AND  (Agendas.Fecha = #" + dtpDate.Value.Date.ToShortDateString + "#) GROUP BY Agendas.RutTrabajador) AND (Trabajadores.TipoTrabajador = 2  OR Trabajadores.TipoTrabajador = 3 ) GROUP BY Trabajadores.Nombre", Module1.con)
            While Not rst.EOF
                cbTrabajador.Items.Add(rst.Fields("Nombre").Value.ToString)
                rst.MoveNext()
            End While
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbTrabajador.Text = ""
        cbBloque.Text = ""
    End Sub
    Private Sub rbSi_CheckedChanged(sender As Object, e As EventArgs) Handles rbSi.CheckedChanged
        contador = 1
    End Sub
    Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged
        contador = 0
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class