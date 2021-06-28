Public Class AgregarStock
    Private Sub BtnAgregaStockFinal_Click(sender As Object, e As EventArgs) Handles btnAgregaStockFinal.Click
        If TextBox1.Text <> "" Then
            Try
                Dim stock1 As Single
                Module1.rst = New ADODB.Recordset
                rst.Open("SELECT Productos.Stock From Productos WHERE IdProducto='" + TextBox1.Text + "'", Module1.con)
                If Not rst.EOF Then
                    stock1 = rst.Fields("Stock").Value()
                    rst.Close()
                End If
                Module1.rst = New ADODB.Recordset
                rst.Open("UPDATE Productos SET Stock=" & nudCantidadStock.Text + stock1 & " WHERE IdProducto='" + TextBox1.Text + "'", Module1.con)
                Me.Hide()
            Catch ex As Exception
                MsgBox("Ingrese un Codigo Existente")
            End Try
        Else
            MsgBox("Ingrese algun código")
            TextBox1.Focus()
        End If

        nudCantidadStock.Text = 1
        Productos.llenar_productos()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                Module1.rst = New ADODB.Recordset
                rst.Open("SELECT Productos.NombreProducto,Productos.Stock FROM Productos WHERE IdProducto='" + TextBox1.Text + "'", Module1.con)
                TextBox2.Text = rst.Fields("NombreProducto").Value()
                TextBox3.Text = rst.Fields("Stock").Value()
                nudCantidadStock.Focus()
            Catch ex As Exception
                MsgBox("Ese producto no existe!, intente nuevamente", vbCritical)
                TextBox1.Clear()
            End Try
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Try
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT Productos.NombreProducto,Productos.Stock FROM Productos WHERE IdProducto='" + TextBox1.Text + "'", Module1.con)
            TextBox2.Text = rst.Fields("NombreProducto").Value()
            TextBox3.Text = rst.Fields("Stock").Value()
            nudCantidadStock.Focus()
        Catch ex As Exception
            MsgBox("Ese producto no existe!, intente nuevamente", vbCritical)
            TextBox1.Clear()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class