Public Class EditarProducto
    Private Sub TbCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                Module1.rst = New ADODB.Recordset
                rst.Open("SELECT Productos.NombreProducto,Productos.PrecioProducto,Productos.Descripcion,Productos.Talla FROM Productos WHERE IdProducto='" + tbCodigo.Text + "'", Module1.con)
                tbNombre.Text = rst.Fields("NombreProducto").Value()
                tbPrecio.Text = rst.Fields("PrecioProducto").Value()
                tbDescripcion.Text = rst.Fields("Descripcion").Value()
                TextBox1.Text = rst.Fields("Talla").Value()
            Catch ex As Exception
                MsgBox("Ingrese un codigo valido", vbCritical)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Module1.rst = New ADODB.Recordset
        'rst.Open("UPDATE Productos SET (Productos.NombreProducto,Productos.PrecioProducto,Productos.Descripcion,Productos.Talla)=('" + tbNombre.Text + "','" + tbPrecio.Text + "','" + tbDescripcion.Text + "','" + TextBox1.Text + "') WHERE IdProducto='" + tbCodigo.Text + "'", Module1.con)
        'MsgBox("Productos Editados Correctamente")
        If tbNombre.Text <> "" And tbCodigo.Text <> "" And tbDescripcion.Text <> "" And tbPrecio.Text <> "" And TextBox1.Text <> "" Then
            Try
                Module1.rst = New ADODB.Recordset
                rst.Open("UPDATE Productos SET Productos.NombreProducto='" + tbNombre.Text + "',Productos.PrecioProducto='" + tbPrecio.Text + "',Productos.Descripcion='" + tbDescripcion.Text + "',Productos.Talla='" + TextBox1.Text + "' WHERE IdProducto ='" + tbCodigo.Text + "'", Module1.con)
                MsgBox("Producto editado correctamente")
                Me.Hide()
                Productos.llenar_productos()
            Catch ex As Exception
                MsgBox("Algo salio mal, Intente nuevamente", vbCritical)
            End Try
            MsgBox("Rellene todos los campos.")
        End If
    End Sub

    Private Sub TbCodigo_Leave(sender As Object, e As EventArgs) Handles tbCodigo.Leave
        Try
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT Productos.NombreProducto,Productos.PrecioProducto,Productos.Descripcion,Productos.Talla FROM Productos WHERE IdProducto='" + tbCodigo.Text + "'", Module1.con)
            tbNombre.Text = rst.Fields("NombreProducto").Value()
            tbPrecio.Text = rst.Fields("PrecioProducto").Value()
            tbDescripcion.Text = rst.Fields("Descripcion").Value()
            TextBox1.Text = rst.Fields("Talla").Value()
        Catch ex As Exception
            MsgBox("Ingrese un código valido", vbCritical)
        End Try
    End Sub
End Class