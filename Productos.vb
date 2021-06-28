Public Class Productos
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        If Me.DataGridView2.Columns(e.ColumnIndex).Name = "Stock" Then
            If Convert.ToInt32(e.Value) >= My.Settings.amarillo Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.LightGreen
            End If
            If Convert.ToInt32(e.Value) < My.Settings.amarillo Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.Yellow
                If Convert.ToInt32(e.Value) < My.Settings.rojo Then
                    e.CellStyle.ForeColor = Color.Black
                    e.CellStyle.BackColor = Color.IndianRed
                End If
            End If
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AgregarProducto.Show()
        AgregarProducto.tbCodigo.Focus()
    End Sub

    Public Sub llenar_productos()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT IdProducto,NombreProducto,Talla,PrecioProducto,Descripcion,Stock FROM Productos", Module1.con)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        ODA.Fill(ds, Module1.rst, "Table1")
        Me.DataGridView2.DataSource = ds.Tables("Table1").DefaultView
    End Sub
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_productos()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            llenar_productos()
        Else
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT IdProducto,NombreProducto,Talla,PrecioProducto,Descripcion,Stock From Productos WHERE Productos.NombreProducto Like '" + TextBox1.Text + "%'", Module1.con)
            Dim oda As New OleDb.OleDbDataAdapter
            Dim tb As New DataTable
            Dim ds As DataSet = New DataSet
            oda.Fill(ds, Module1.rst, "tabla1")
            DataGridView2.DataSource = ds.Tables("tabla1").DefaultView
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AgregarStock.Show()
        AgregarStock.TextBox1.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        EditarProducto.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class