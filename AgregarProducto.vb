Public Class AgregarProducto
    Private Sub BtnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        'Dim ssql As String
        'Dim idnew As String        
        'Module1.rst = New ADODB.Recordset
        'ssql = "SELECT IIF(MAX(IdProducto)<>NULL,MAX(IdProducto)+1,1) as maximo FROM Productos"
        'rst.Open(ssql, Module1.con)
        'idnew = rst.Fields("maximo").Value()
        If tbCodigo.Text <> "" And tbDescripcion.Text <> "" And tbNombre.Text <> "" And tbPrecio.Text <> "" And TextBox1.Text <> "" And tbStock.Text <> "" Then
            Dim PEDSQL As String = ""
            Module1.rst = New ADODB.Recordset
            If rbVenta.Checked Then
                PEDSQL = "INSERT INTO Productos(IdProducto,NombreProducto,PrecioProducto,Descripcion,Stock,TipoProducto,Talla) VALUES ('" + tbCodigo.Text + "','" + tbNombre.Text + "','" + tbPrecio.Text + "','" + tbDescripcion.Text + "','" + tbStock.Text + "',1,'" + TextBox1.Text + "')"
            ElseIf rbArriendo.Checked Then
                PEDSQL = "INSERT INTO Productos(IdProducto,NombreProducto,PrecioProducto,Descripcion,Stock,TipoProducto,Talla) VALUES ('" + tbCodigo.Text + "','" + tbNombre.Text + "','" + tbPrecio.Text + "','" + tbDescripcion.Text + "','" + tbStock.Text + "',2,'" + TextBox1.Text + "')"
            End If
            Try
                rst.Open(PEDSQL, Module1.con)
            Catch ex As Exception
                MsgBox("Ingrese todos los campos requeridos")
            End Try
            Me.Hide()
            tbDescripcion.Clear()
            tbNombre.Clear()
            tbStock.Clear()
            tbPrecio.Clear()
            tbCodigo.Clear()
            TextBox1.Clear()
            Productos.llenar_productos()
        Else
            MsgBox("Rellene todos los campos")
        End If
    End Sub

End Class