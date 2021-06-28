Public Class AgregarCliente
    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        If tbAgregaNombre.Text <> "" And tbAgregaTelefono.Text <> "" Then
            Module1.rst = New ADODB.Recordset
            rst.Open("Select Personas.NombreCliente from Personas WHERE Personas.NombreCliente='" + tbAgregaNombre.Text + "'", Module1.con)
            If Not rst.EOF Then
                MsgBox("Ya existe un Cliente con ese Nombre, Ingrese Nombre Completo del Cliente")
                rst.Close()
            Else
                Module1.rst = New ADODB.Recordset
                rst.Open("INSERT INTO Personas(NombreCliente,Telefono,InformacionExtra) VALUES ('" + tbAgregaNombre.Text + "','" + tbAgregaTelefono.Text + "','" + tbAgregaInfoExtra.Text + "')", Module1.con)
                With DetalleDeAgenda
                    .txtSearch.Text = Me.tbAgregaNombre.Text
                    .tbTelefono.Text = Me.tbAgregaTelefono.Text
                    .tbInfoExtra.Text = Me.tbAgregaInfoExtra.Text
                End With
                With DetalleDeArriendo
                    .txtSearch.Text = Me.tbAgregaNombre.Text
                    .tbTelefono.Text = Me.tbAgregaTelefono.Text
                    .tbInfoExtra.Text = Me.tbAgregaInfoExtra.Text
                End With
                Me.Close()
            End If
            tbAgregaInfoExtra.Text = ""
            tbAgregaNombre.Text = ""
            tbAgregaTelefono.Text = ""
        End If
    End Sub
End Class