Public Class Carrito
    Dim pago As String
    Private Sub Carrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btnAceptar.Hide()

        Label4.Hide()
        tbCuantoPaga.Hide()
        lblVuelto.Hide()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label4.Show()
        tbCuantoPaga.Show()
        Button1.Show()
        Label6.Show()
        lblVuelto.Show()
        tbCuantoPaga.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Module1.retroceder = 3
        Me.Hide()
        EleccionProductos.Hide()
        Form1.Show()
        If RadioButton1.Checked Then
            pago = "Debito"
        ElseIf RadioButton2.Checked Then
            pago = "Credito"
        ElseIf RadioButton3.Checked Then
            pago = "Efectivo"
        End If
        Module1.rst = New ADODB.Recordset
        rst.Open("UPDATE Ventas SET MetodoPago='" + pago + "' WHERE IdVenta=" & Module1.idVenta, Module1.con)
        ReporteDiario.llenar3()
        retroceder = 1
        tbCuantoPaga.Hide()
        Label4.Hide()
        Label6.Hide()
        Button1.Hide()
        lblVuelto.Hide()
        tbCuantoPaga.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            lblVuelto.Text = tbCuantoPaga.Text - EleccionProductos.lblTotal.Text
        Catch ex As Exception
            MsgBox("Ingrese un valor valido!", vbCritical)
        End Try
        Button2.Focus()
    End Sub
End Class