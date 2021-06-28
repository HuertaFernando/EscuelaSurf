Imports System.Data
Imports System.Data.OleDb
Public Class DetalleDeArriendo
    Private con As New OleDb.OleDbConnection
    Private command As OleDb.OleDbCommand
    Private adapter As OleDbDataAdapter
    Private reader As OleDbDataReader
    Private dataSt As DataSet
    Public AppID1 As Integer = 0

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtSearch.Text <> "" And cbBloque.Text <> "" And tbTelefono.Text <> "" And cbProductosArriendo.Text <> "" And tbComentario.Text <> "") Then
            If IsConfirm("Quieres arrendar el producto?") Then
                If AppID1 = 0 Then



                    Module1.rst = New ADODB.Recordset
                    rst.Open("Select Productos.IdProducto from Productos where NombreProducto='" + cbProductosArriendo.Text + "'", Module1.con)
                    Dim IdProducto As String = rst.Fields("Idproducto").Value()
                    Module1.rst = New ADODB.Recordset
                    rst.Open("SELECT IIF(MAX(ID)<>NULL,MAX(ID)+1,1) as maximo FROM Arriendos", Module1.con)
                    Dim idnew As String = rst.Fields("maximo").Value()



                    Dim n_descuento, stock As Integer
                    Module1.rst = New ADODB.Recordset
                    rst.Open("select * from productos where idproducto=" + IdProducto, Module1.con)
                    If Not rst.EOF Then
                        stock = rst.Fields("stock").Value()
                    End If

                    Module1.rst = New ADODB.Recordset
                    rst.Open("Select count(idproducto)as descuento from arriendos where letrabloque='" + cbBloque.Text + "' and fecha=#" + dtpDate.Value.ToShortDateString() + "# and idproducto=" + IdProducto, Module1.con)
                    If Not rst.EOF Then
                        n_descuento = rst.Fields("descuento").Value()
                    End If


                    If stock > n_descuento Then
                        'MsgBox("puede agendar" + Chr(9) + CStr(stock) + Chr(9) + CStr(n_descuento))


                        Module1.rst = New ADODB.Recordset
                        Dim Sql As String = "INSERT INTO Arriendos(ID,Fecha,IdProducto,Letrabloque,NombreCliente,Comentario) Values ('" + idnew + "','" + dtpDate.Value.ToShortDateString() + "','" + IdProducto + "','" + cbBloque.Text + "','" + txtSearch.Text + "','" + tbComentario.Text + "')"
                        rst.Open(Sql, Module1.con)
                        MsgBox("Arriendo Exitoso!")
                        ReporteDiario.llenar()

                        Me.Hide()

                    Else
                        MsgBox("No hay Stock suficiente", vbCritical)
                    End If
                Else
                    If dtpDate.Value.Day < 13 Then
                        Module1.rst = New ADODB.Recordset
                        rst.Open("SELECT * FROM Productos WHERE NombreProducto='" + cbProductosArriendo.Text + "'", Module1.con)
                        Dim IdProducto1 As String = rst.Fields("IdProducto").Value()
                        Module1.rst = New ADODB.Recordset
                        rst.Open("UPDATE Arriendos SET Arriendos.ID=" + AppID1.ToString() + ",Arriendos.Fecha=#" + dtpDate.Value.ToString("MM/dd/yyyy") + "#,Arriendos.IdProducto='" + IdProducto1 + "',Arriendos.Letrabloque='" + cbBloque.Text + "',Arriendos.NombreCLiente='" + txtSearch.Text + "',Arriendos.Comentario='" + tbComentario.Text + "' WHERE Arriendos.ID=" & AppID1.ToString(), Module1.con)
                        MsgBox("Arriendo Actualizado")
                        ReporteDiario.llenar()
                        Me.Hide()
                    Else
                        Module1.rst = New ADODB.Recordset
                        rst.Open("SELECT * FROM Productos WHERE NombreProducto='" + cbProductosArriendo.Text + "'", Module1.con)
                        Dim IdProducto1 As String = rst.Fields("IdProducto").Value()
                        Module1.rst = New ADODB.Recordset
                        rst.Open("UPDATE Arriendos SET Arriendos.ID=" + AppID1.ToString() + ",Arriendos.Fecha=#" + dtpDate.Value.Date.ToShortDateString + "#,Arriendos.IdProducto='" + IdProducto1 + "',Arriendos.Letrabloque='" + cbBloque.Text + "',Arriendos.NombreCLiente='" + txtSearch.Text + "',Arriendos.Comentario='" + tbComentario.Text + "' WHERE Arriendos.ID=" & AppID1.ToString(), Module1.con)
                        MsgBox("Arriendo Actualizado")
                        ReporteDiario.llenar()

                        Me.Hide()
                    End If
                End If
            End If

        Else
            MsgBox("Todos los Campos son requeridos!")
        End If
        tbComentario.Text = ""
        tbInfoExtra.Text = ""
        tbTelefono.Text = ""

    End Sub

    Private Sub DetalleDeArriendo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbProductosArriendo.Items.Clear()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT Productos.NombreProducto,Productos.stock FROM Productos WHERE Productos.TipoProducto=2", Module1.con)
        While Not rst.EOF
            Dim stocc As Single = CSng(rst.Fields("Stock").Value())
            If stocc > 0 Then
                cbProductosArriendo.Items.Add(rst.Fields("NombreProducto").Value())
            End If
            rst.MoveNext()
        End While
        Dim strcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + My.Computer.FileSystem.CurrentDirectory + "/EscuelaSurf.mdb"
        ' Dim strcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + My.Computer.FileSystem.CurrentDirectory + "/Debug/EscuelaSurf.mdb"
        With con
            If .State = ConnectionState.Closed Then
                .ConnectionString = strcon
                .Open()
            End If
        End With
        If Module1.poder1 = 1 Then
            Module1.rst = New ADODB.Recordset
            rst.Open("Select Bloques.LetraBloque from Bloques", Module1.con)
            While Not rst.EOF
                cbBloque.Items.Add(rst.Fields("LetraBloque").Value())
                rst.MoveNext()
            End While

            Module1.poder1 = 2
            btnDelete.Visible = AppID1 <> 0
            If AppID1 = 0 Then
                Me.Refresh()
                cbBloque.ResetText()
                txtSearch.ResetText()
                tbInfoExtra.Text = ""
                tbTelefono.Text = ""
                tbComentario.Text = ""
                btnDelete.Visible = False
            Else
                btnDelete.Visible = True
            End If
            AutoComplete()
        End If
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
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Module1.poder1 = 2
        If IsConfirm("Quiere eliminar este Arriendo?") Then
            Module1.rst = New ADODB.Recordset
            rst.Open("DELETE FROM Arriendos WHERE Arriendos.ID=" & AppID1.ToString() & "", Module1.con)
            MsgBox("Arriendo Borrado")


            Close()
        End If
        ReporteDiario.llenar()

        cbBloque.ResetText()
        txtSearch.ResetText()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
        Module1.poder1 = 2
        cbBloque.ResetText()
        txtSearch.ResetText()
    End Sub
    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        Label5.Text = dtpDate.Value.Date.ToShortDateString
    End Sub

    Private Sub cbBloque_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBloque.SelectedIndexChanged
        Label9.Text = cbBloque.Text
    End Sub
End Class