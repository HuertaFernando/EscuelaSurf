Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text <> "0" And tbCantidad.Text <> "" Then
            If CSng(tbCantidad.Text) <= CSng(TextBox2.Text) Then
                Module1.rst = New ADODB.Recordset
                rst.Open("SELECT Adelantos.RutTrabajador FROM Adelantos WHERE Adelantos.RutTrabajador = " + cbRutTrabajador.Text + " AND Month(Adelantos.Fecha) = " & DateTime.Today.Month & " AND Year(Adelantos.Fecha) = " & DateTime.Today.Year, Module1.con)
                If Not rst.EOF Then
                    Module1.rst = New ADODB.Recordset
                    Dim sql2 As String
                    sql2 = "UPDATE Adelantos SET Adelantos.Adelanto = Adelantos.Adelanto + " + tbCantidad.Text + " WHERE Adelantos.RutTrabajador = " + cbRutTrabajador.Text + " AND Month(Adelantos.Fecha) = " & DateTime.Today.Month & " AND Year(Adelantos.Fecha) = " & DateTime.Today.Year & ""
                    rst.Open(sql2, Module1.con)
                    MsgBox("Adelanto Exitoso")
                    Trabajadores.jiji()
                Else
                    Module1.rst = New ADODB.Recordset
                    Dim sql As String
                    sql = "INSERT INTO Adelantos (RutTrabajador,Adelanto,Fecha) Values ('" + cbRutTrabajador.Text + "' , '" + tbCantidad.Text + "', '" + DateTime.Today.ToShortDateString + "')"
                    rst.Open(sql, Module1.con)
                    MsgBox("Adelanto Exitoso")
                    Trabajadores.jiji()
                End If
            Else
                MsgBox("Esta Adelantando mas de lo permitido", vbCritical)
            End If
        Else
            MsgBox("La deuda con el trabajador es 0", vbCritical)
        End If
        tbCantidad.Text = ""
        cbRutTrabajador.ResetText()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub CbRutTrabajador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRutTrabajador.SelectedIndexChanged
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT Trabajadores.Nombre FROM Trabajadores WHERE Trabajadores.RutTrabajador =" + cbRutTrabajador.Text, Module1.con)
        If Not rst.EOF Then
            TextBox1.Text = rst.Fields("Nombre").Value
        End If
        Try
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT ConAdelantos.RutTrabajador, ConAdelantos.Nombre, ConAdelantos.Generado, ConAdelantos.Adelantado, ConAdelantos.Pagar FROM ConAdelantos WHERE  ConAdelantos.RutTrabajador = " + cbRutTrabajador.Text + " AND  Month(ConAdelantos.Fecha) = " & Date.Today.Month & " and Year(ConAdelantos.Fecha) = " & Date.Today.Year.ToString, Module1.con)
            TextBox2.Text = rst.Fields("Pagar").Value
        Catch ex As Exception

        End Try

        'If rst.Fields("Pagar").Value = 0 Then
        'tbCantidad.Visible = False
        'lblCantidad.Visible = False
        'End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT Trabajadores.RutTrabajador FROM Trabajadores WHERE TipoTrabajador=2", Module1.con)

        While Not rst.EOF
            cbRutTrabajador.Items.Add(rst.Fields("RutTrabajador").Value)
            rst.MoveNext()

        End While
    End Sub
End Class