Public Class EleccionProductos
    Public Sub DGV_llenarProductos()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT Productos.IdProducto, Productos.NombreProducto , Productos.Talla,Productos.Stock, Productos.PrecioProducto FROM Productos", Module1.con)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        ODA.Fill(ds, Module1.rst, "tabla1")
        DataGridView1.DataSource = ds.Tables("tabla1").DefaultView
    End Sub
    Private Sub BtnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        Try
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT DetalleVentas.Cantidad FROM DetalleVentas WHERE IdVenta=" + Module1.idVenta + "AND IdProducto='" + DataGridView1.CurrentRow.Cells(3).Value().ToString + "'", Module1.con)
            Module1.cantidad = CSng(rst.Fields("Cantidad").Value()) - 1
        Catch ex As Exception
            MsgBox("No hay nada en el carrito")
            Module1.cantidad = -2
        End Try
        If Module1.cantidad > 0 Then
            Module1.rst = New ADODB.Recordset
            rst.Open("UPDATE DetalleVentas SET Cantidad='" + Module1.cantidad + "' WHERE IdVenta=" + Module1.idVenta + " AND IdProducto='" + DataGridView1.CurrentRow.Cells(3).Value().ToString + "'", Module1.con)
            Module1.rst = New ADODB.Recordset
            rst.Open("Select Productos.Stock From Productos WHERE IdProducto='" + DataGridView1.CurrentRow.Cells(3).Value().ToString + "'", Module1.con)
            Dim stock As String = CSng(rst.Fields("Stock").Value()) + 1
            Module1.rst = New ADODB.Recordset
            rst.Open("UPDATE Productos SET Stock='" + stock + "' WHERE IdProducto='" + DataGridView1.CurrentRow.Cells(3).Value().ToString + "'", Module1.con)
        ElseIf Module1.cantidad = 0 Then
            Module1.rst = New ADODB.Recordset
            rst.Open("DELETE FROM DetalleVentas WHERE DetalleVentas.IdVenta=" + Module1.idVenta + "AND IdProducto='" + DataGridView1.CurrentRow.Cells(3).Value().ToString + "'", Module1.con)
        End If
        Module1.llenarDGV()
        ReporteDiario.llenar3()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If lblTotal.Text <> "0" Then
            Carrito.Show()
        Else
            MsgBox("Ingrese algún producto")
        End If
    End Sub

    Private Sub TbSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim consulta As String
            Dim suma As String
            Dim CodSQL1 As String
            Dim CodSQL2 As String
            Dim puede As Boolean
            Try
                Module1.rst = New ADODB.Recordset
                'rst.Open("SELECT Productos.Stock From Productos WHERE IdProducto=" + DataGridView1.CurrentRow.Cells(0).Value().ToString, Module1.con)
                rst.Open("SELECT Productos.Stock From Productos WHERE IdProducto='" + tbSearch.Text + "'", Module1.con)
                Dim Stockk As String = CSng(rst.Fields("Stock").Value()) - 1
                Label6.Text = Stockk
                If Stockk >= 0 Then
                    puede = True
                End If
                If Stockk = "" Then
                    Module1.alertaP = False
                Else
                    Module1.alertaP = True
                End If
            Catch ex As Exception
                MsgBox("Ingrese un producto valido!")
            End Try
            If puede = True Then
                Module1.rst = New ADODB.Recordset
                consulta = "SELECT * FROM DetalleVentas WHERE IdVenta=" + Module1.idVenta + " AND IdProducto='" + tbSearch.Text + "'"
                'consulta = "SELECT * FROM DetalleVentas WHERE IdVenta=" + Module1.idVenta + " AND IdProducto=" + DataGridView1.CurrentRow.Cells(0).Value().ToString
                rst.Open(consulta, Module1.con)
                If Not rst.EOF Then 'si encuentro el mismo producto en el pedido
                    'suma = rst.Fields("Cantidad").Value() + udCantidadProductos.Text
                    suma = rst.Fields("Cantidad").Value() + 1
                    rst.Close()
                    'CodSQL1 = "UPDATE DetalleVentas SET Cantidad=" + CStr(suma) + " WHERE IdVenta=" + Module1.idVenta + "AND IdProducto=" + DataGridView1.CurrentRow.Cells(0).Value().ToString
                    CodSQL1 = "UPDATE DetalleVentas SET Cantidad=" + CStr(suma) + " WHERE IdVenta=" + Module1.idVenta + "AND IdProducto='" + tbSearch.Text + "'"
                    rst.Open(CodSQL1, Module1.con)
                Else
                    rst.Close()
                    'CodSQL2 = "INSERT INTO DetalleVentas (IdVenta,IdProducto,Cantidad) VALUES ('" + Module1.idVenta + "','" + DataGridView1.CurrentRow.Cells(0).Value().ToString + "','" + udCantidadProductos.Text + "')"
                    'CodSQL2 = "INSERT INTO DetalleVentas (IdVenta,IdProducto,Cantidad) VALUES ('" + Module1.idVenta + "','" + DataGridView1.CurrentRow.Cells(0).Value().ToString + "',1)"
                    CodSQL2 = "INSERT INTO DetalleVentas (IdVenta,IdProducto,Cantidad) VALUES ('" + Module1.idVenta + "','" + tbSearch.Text + "',1)"
                    rst.Open(CodSQL2, Module1.con)
                End If
                'rst.Open("UPDATE Productos SET Stock='" + Label6.Text + "' WHERE Productos.IdProducto=" & DataGridView1.CurrentRow.Cells(0).Value().ToString, Module1.con)
                rst.Open("UPDATE Productos SET Stock='" + Label6.Text + "' WHERE Productos.IdProducto='" + tbSearch.Text + "'", Module1.con)
                Module1.llenarDGV()
            Else
                If Module1.alertaP <> False Then
                    MsgBox("No hay Stock suficiente!")
                End If
            End If
            tbSearch.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta As String
        Dim suma As String
        Dim CodSQL1 As String
        Dim CodSQL2 As String
        Dim puede As Boolean
        Try
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT Productos.Stock From Productos WHERE IdProducto='" + tbSearch.Text.ToString + "'", Module1.con)
            Dim Stockk As String = CSng(rst.Fields("Stock").Value()) - 1
            Label6.Text = Stockk
            If Stockk >= 0 Then
                puede = True
            End If
            If Stockk = "" Then
                Module1.alerta = False
            Else
                Module1.alerta = True
            End If
        Catch ex As Exception
            MsgBox("Ingrese un producto valido!")
        End Try
        If puede = True Then
            Module1.rst = New ADODB.Recordset
            consulta = "SELECT * FROM DetalleVentas WHERE IdVenta=" + Module1.idVenta + " AND IdProducto='" + tbSearch.Text + "'"
            'consulta = "SELECT * FROM DetalleVentas WHERE IdVenta=" + Module1.idVenta + " AND IdProducto=" + DataGridView1.CurrentRow.Cells(0).Value().ToString
            rst.Open(consulta, Module1.con)
            If Not rst.EOF Then 'si encuentro el mismo producto en el pedido
                suma = rst.Fields("Cantidad").Value() + 1
                rst.Close()
                'CodSQL1 = "UPDATE DetalleVentas SET Cantidad=" + CStr(suma) + " WHERE IdVenta=" + Module1.idVenta + "AND IdProducto=" + DataGridView1.CurrentRow.Cells(0).Value().ToString
                CodSQL1 = "UPDATE DetalleVentas SET Cantidad=" + CStr(suma) + " WHERE IdVenta=" + Module1.idVenta + "AND IdProducto='" + tbSearch.Text + "'"
                rst.Open(CodSQL1, Module1.con)
            Else
                rst.Close()
                'CodSQL2 = "INSERT INTO DetalleVentas (IdVenta,IdProducto,Cantidad) VALUES ('" + Module1.idVenta + "','" + DataGridView1.CurrentRow.Cells(0).Value().ToString + "','" + udCantidadProductos.Text + "')"
                'CodSQL2 = "INSERT INTO DetalleVentas (IdVenta,IdProducto,Cantidad) VALUES ('" + Module1.idVenta + "','" + DataGridView1.CurrentRow.Cells(0).Value().ToString + "',1)"
                CodSQL2 = "INSERT INTO DetalleVentas (IdVenta,IdProducto,Cantidad) VALUES ('" + Module1.idVenta + "','" + tbSearch.Text + "',1)"
                rst.Open(CodSQL2, Module1.con)
            End If
            'rst.Open("UPDATE Productos SET Stock='" + Label6.Text + "' WHERE Productos.IdProducto=" & DataGridView1.CurrentRow.Cells(0).Value().ToString, Module1.con)
            rst.Open("UPDATE Productos SET Stock='" + Label6.Text + "' WHERE Productos.IdProducto='" + tbSearch.Text + "'", Module1.con)
            Module1.llenarDGV()
        Else
            If Module1.alerta <> False Then
                MsgBox("No hay Stock suficiente!")
            End If

        End If
        tbSearch.Text = ""
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged

    End Sub
End Class