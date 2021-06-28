Public Class AgregarTrabajadores
    Dim contador As Integer = 0

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        contador = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bnAgregaTrabajador.Click
        If rbProf.Checked Then
            If tbAgregaRut.Text <> "" And tbAgregaNombre.Text <> "" Then
                Module1.rst = New ADODB.Recordset
                rst.Open("SELECT Trabajadores.rutTrabajador FROM Trabajadores WHERE Trabajadores.RutTrabajador=" & tbAgregaRut.Text, Module1.con)
                If Not rst.EOF Then
                    MsgBox("Ya hay datos asociados a ese Rut!")
                    rst.Close()
                Else
                    If contador = 1 Then
                        rst.Close()
                        Dim sql As String
                        sql = "INSERT INTO Trabajadores (RutTrabajador,Nombre,Contraseña,TipoTrabajador) VALUES( '" + tbAgregaRut.Text + "','" + tbAgregaNombre.Text + "',0,3)"
                        Module1.rst = New ADODB.Recordset
                        rst.Open(sql, Module1.con)
                        Module1.estado = 1

                    Else
                        rst.Close()
                        Dim sql As String
                        sql = "INSERT INTO Trabajadores (RutTrabajador,Nombre,Contraseña,TipoTrabajador) VALUES( '" + tbAgregaRut.Text + "','" + tbAgregaNombre.Text + "',0,2)"
                        Module1.rst = New ADODB.Recordset
                        rst.Open(sql, Module1.con)
                        Module1.estado = 1
                    End If

                End If
            Else
                MsgBox("No Ingrese Casillas Vacias")
            End If
        ElseIf rbCajero.Checked Then
            If tbAgregaRut.Text <> "" And tbAgregaNombre.Text <> "" And tbAgregaContra.Text <> "" And tbReAgregaContra.Text <> "" Then
                Module1.rst = New ADODB.Recordset
                rst.Open("SELECT Trabajadores.rutTrabajador FROM Trabajadores WHERE Trabajadores.RutTrabajador=" & tbAgregaRut.Text, Module1.con)
                If Not rst.EOF Then
                    MsgBox("Ya hay datos asociados a ese Rut!")
                    rst.Close()
                Else
                    rst.Close()
                    Dim sql As String
                    sql = "INSERT INTO Trabajadores (RutTrabajador,Nombre,Contraseña,TipoTrabajador) VALUES( '" + tbAgregaRut.Text + "','" + tbAgregaNombre.Text + "','" + tbAgregaContra.Text + "',1)"
                    If tbAgregaContra.Text = tbReAgregaContra.Text Then
                        Module1.rst = New ADODB.Recordset
                        rst.Open(sql, Module1.con)
                        Module1.estado = 1
                        tbAgregaRut.ResetText()
                        tbAgregaNombre.ResetText()
                        tbAgregaContra.ResetText()
                        tbReAgregaContra.ResetText()
                        tbReAgregaContra.Visible = False
                        tbAgregaContra.Visible = False
                        Label3.Visible = False
                        Label4.Visible = False
                        'bnAgregaTrabajador.Location = New Point(369, 203)
                    Else
                        MsgBox("Contraseñas Distintas!", vbCritical, "Error!")
                    End If
                End If
            End If

        End If
        tbAgregaRut.ResetText()
        tbAgregaNombre.ResetText()
        tbAgregaContra.ResetText()
        tbReAgregaContra.ResetText()
        Me.Hide()
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbCajero.CheckedChanged
        If rbCajero.Checked Then
            tbReAgregaContra.Visible = True
            tbAgregaContra.Visible = True
            Label3.Visible = True
            Label4.Visible = True

        ElseIf rbProf.Checked = True Then
            tbReAgregaContra.Visible = False
            tbAgregaContra.Visible = False
            Label3.Visible = False
            Label4.Visible = False

            tbAgregaContra.Text = ""
            tbReAgregaContra.Text = ""
        End If
        CheckBox1.Visible = False
    End Sub
    Private Sub rbProf_CheckedChanged(sender As Object, e As EventArgs) Handles rbProf.CheckedChanged
        CheckBox1.Visible = True
    End Sub
End Class