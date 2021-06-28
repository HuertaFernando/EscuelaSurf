Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data
Public Class ReporteDiario
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function


    Public Sub llenar()
        Module1.rst = New ADODB.Recordset
        If DateTime.Today.Day < 13 Then
            rst.Open("SELECT Productos.NombreProducto AS Producto, SUM(Productos.PrecioProducto) AS Total FROM Productos, Arriendos WHERE Productos.IdProducto = Arriendos.IdProducto AND (Arriendos.Fecha = #" + DateTime.Today.ToString("MM/dd/yyyy") + "#)  GROUP BY Productos.NombreProducto", Module1.con)
            Dim ODA As New OleDb.OleDbDataAdapter
            Dim TB As New DataTable
            Dim ds As DataSet = New DataSet
            ODA.Fill(ds, Module1.rst, "Table1")
            DataGridView2.DataSource = ds.Tables("Table1").DefaultView
        Else
            rst.Open("SELECT Productos.NombreProducto AS Producto, SUM(Productos.PrecioProducto) AS Total FROM Productos, Arriendos WHERE Productos.IdProducto = Arriendos.IdProducto AND (Arriendos.Fecha = #" + DateTime.Today + "#)  GROUP BY Productos.NombreProducto", Module1.con)
            Dim ODA As New OleDb.OleDbDataAdapter
            Dim TB As New DataTable
            Dim ds As DataSet = New DataSet
            ODA.Fill(ds, Module1.rst, "Table1")
            DataGridView2.DataSource = ds.Tables("Table1").DefaultView
        End If
    End Sub
    Public Sub llenar2()
        Module1.rst = New ADODB.Recordset
        If DateTime.Today.Day < 13 Then
            rst.Open("SELECT Actividades.NombreActividad AS Actividad, SUM(Actividades.Precio) AS Total FROM Agendas, Actividades WHERE Agendas.NombreActividad = Actividades.NombreActividad AND (Agendas.Fecha = #" + DateTime.Today.ToString("MM/dd/yyyy") + "#) GROUP BY Actividades.NombreActividad ", Module1.con)
            Dim ODA As New OleDb.OleDbDataAdapter
            Dim TB As New DataTable
            Dim ds As DataSet = New DataSet
            ODA.Fill(ds, Module1.rst, "Table1")
            DataGridView1.DataSource = ds.Tables("Table1").DefaultView
        Else
            rst.Open("SELECT Actividades.NombreActividad AS Actividad, SUM(Actividades.Precio) AS Total FROM Agendas, Actividades WHERE Agendas.NombreActividad = Actividades.NombreActividad AND (Agendas.Fecha = #" + DateTime.Today.ToShortDateString + "#) GROUP BY Actividades.NombreActividad ", Module1.con)
            Dim ODA As New OleDb.OleDbDataAdapter
            Dim TB As New DataTable
            Dim ds As DataSet = New DataSet
            ODA.Fill(ds, Module1.rst, "Table1")
            DataGridView1.DataSource = ds.Tables("Table1").DefaultView
        End If
    End Sub
    Public Sub llenar3()
        Module1.rst = New ADODB.Recordset
        If DateTime.Today.Day < 13 Then
            rst.Open("SELECT Productos.NombreProducto AS Producto, SUM (DetalleVentas.Cantidad) AS Cantidad, Productos.PrecioProducto AS Unidad, Cantidad * Unidad AS Total FROM Productos, DetalleVentas, Ventas WHERE Productos.IdProducto = DetalleVentas.IdProducto AND DetalleVentas.IdVenta = Ventas.IdVenta AND Ventas.Fecha = #" & DateTime.Today.ToString("MM/dd/yyyy") & "# GROUP BY Productos.NombreProducto, Productos.PrecioProducto ", Module1.con)
            Dim ODA As New OleDb.OleDbDataAdapter
            Dim TB As New DataTable
            Dim ds As DataSet = New DataSet
            ODA.Fill(ds, Module1.rst, "Table1")
            DataGridView3.DataSource = ds.Tables("Table1").DefaultView
        Else
            rst.Open("SELECT Productos.NombreProducto AS Producto, SUM (DetalleVentas.Cantidad) AS Cantidad, Productos.PrecioProducto AS Unidad, Cantidad * Unidad AS Total FROM Productos, DetalleVentas, Ventas WHERE Productos.IdProducto = DetalleVentas.IdProducto AND DetalleVentas.IdVenta = Ventas.IdVenta AND Ventas.Fecha = #" & DateTime.Today.ToShortDateString & "# GROUP BY Productos.NombreProducto, Productos.PrecioProducto ", Module1.con)
            Dim ODA As New OleDb.OleDbDataAdapter
            Dim TB As New DataTable
            Dim ds As DataSet = New DataSet
            ODA.Fill(ds, Module1.rst, "Table1")
            DataGridView3.DataSource = ds.Tables("Table1").DefaultView
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = DateTime.Today.ToShortDateString
        If DateTime.Today.Day < 13 Then
            Module1.rst = New ADODB.Recordset
            Dim a As Decimal
            Dim b As Decimal
            Dim c As Decimal
            a = 0
            a = 0
            rst.Open("SELECT SUM(Productos.PrecioProducto) FROM Productos,Arriendos WHERE Productos.IdProducto = Arriendos.IdProducto AND (Arriendos.Fecha = #" + DateTime.Today.ToString("MM/dd/yyyy") + "#) GROUP BY Arriendos.Fecha", Module1.con)
            If Not rst.EOF Then

                Label2.Text = rst.GetString
                If Label2.Text = "0" Then
                    a = 0
                Else
                    a = CInt("" + Label2.Text + "")
                End If
            Else
                Label2.Text = "0"
            End If
            Module1.rst = New ADODB.Recordset
            rst.Open("Select Sum(Actividades.precio) as total From Agendas, Actividades Where Agendas.NombreActividad = Actividades.NombreActividad And (Agendas.Fecha = #" & DateTime.Today.ToString("MM/dd/yyyy") & "#) GROUP BY Agendas.Fecha", Module1.con)
            If Not rst.EOF Then
                Label1.Text = rst.GetString
                If Label1.Text = "0" Then
                    b = 0
                Else
                    b = CInt("" + Label1.Text + "")
                End If
            Else
                Label1.Text = "0"
            End If
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT SUM(Productos.PrecioProducto*DetalleVentas.Cantidad) FROM Productos, DetalleVentas, Ventas WHERE Productos.IdProducto = DetalleVentas.IdProducto AND DetalleVentas.IdVenta = Ventas.IdVenta AND (Ventas.Fecha = #" & DateTime.Today.ToString("MM/dd/yyyy") & "#) GROUP BY Ventas.Fecha", Module1.con)
            If Not rst.EOF Then
                Label9.Text = rst.GetString
                If Label9.Text = "0" Then
                    c = 0
                Else
                    c = CInt("" + Label9.Text + "")
                End If
            Else
                Label9.Text = "0"
            End If
            Label3.Text = a + b + c
        Else
            Module1.rst = New ADODB.Recordset
            Dim a As Decimal
            Dim b As Decimal
            Dim c As Decimal
            a = 0
            a = 0
            rst.Open("SELECT SUM(Productos.PrecioProducto) FROM Productos,Arriendos WHERE Productos.IdProducto = Arriendos.IdProducto AND (Arriendos.Fecha = #" + DateTime.Today + "#) GROUP BY Arriendos.Fecha", Module1.con)
            If Not rst.EOF Then
                Label2.Text = rst.GetString
                If Label2.Text = "0" Then
                    a = 0
                Else
                    a = CInt("" + Label2.Text + "")
                End If
            Else
                Label2.Text = "0"
            End If
            Module1.rst = New ADODB.Recordset
            rst.Open("Select Sum(Actividades.precio) as total From Agendas, Actividades Where Agendas.NombreActividad = Actividades.NombreActividad And (Agendas.Fecha = #" & DateTime.Today & "#) GROUP BY Agendas.Fecha", Module1.con)
            If Not rst.EOF Then
                Label1.Text = rst.GetString
                If Label1.Text = "0" Then
                    b = 0
                Else
                    b = CInt("" + Label1.Text + "")
                End If
            Else
                Label1.Text = "0"
            End If
            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT SUM(Productos.PrecioProducto*DetalleVentas.Cantidad) FROM Productos, DetalleVentas, Ventas WHERE Productos.IdProducto = DetalleVentas.IdProducto AND DetalleVentas.IdVenta = Ventas.IdVenta AND (Ventas.Fecha = #" & DateTime.Today.ToShortDateString & "#) GROUP BY Ventas.Fecha", Module1.con)
            If Not rst.EOF Then
                Label9.Text = rst.GetString
                If Label9.Text = "0" Then
                    c = 0
                Else
                    c = CInt("" + Label9.Text + "")
                End If
            Else
                Label9.Text = "0"
            End If
            Label3.Text = a + b + c
        End If
        llenar()
        llenar2()
        llenar3()
    End Sub
    Public Sub espacios(ByVal document As Document)
        Dim espacios As New Paragraph("                                                                                                        ", New Font(Font.Name = "Tahoma", 5, Font.Bold))
        document.Add(espacios)
    End Sub
    Public Sub Enunciado(ByVal document As Document)
        Dim encabezado As New Paragraph("Reporte Diario", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        Dim texto As New Paragraph("Reporte de ventas realizadas día: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim total As New Paragraph("Total generado: " + Label3.Text, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim espacios As New Paragraph("                                                                                                        ", New Font(Font.Name = "Tahoma", 5, Font.Bold))
        document.Add(encabezado)
        document.Add(espacios)
        document.Add(texto)
        document.Add(espacios)
        document.Add(total)
        document.Add(espacios)
    End Sub
    Public Sub ExportarDatosPdf(ByVal document As Document, ByVal dg As DataGridView)
        Dim datatable As New PdfPTable(dg.ColumnCount)
        datatable.DefaultCell.Padding = 2
        Dim headerwidth As Single() = GetColumnasSize(dg)
        datatable.SetWidths(headerwidth)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = dg.ColumnCount
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        Try
            For i As Integer = 0 To dg.ColumnCount - 1
                datatable.AddCell(dg.Columns(i).HeaderText)
            Next
        Catch ex As Exception
            MsgBox("no se puedo agregar")
        End Try
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        Try
            llenar()
            For i As Integer = 0 To dg.RowCount - 1
                For j As Integer = 0 To dg.ColumnCount - 1
                    datatable.AddCell(dg(j, i).Value().ToString())
                Next
                datatable.CompleteRow()
            Next
        Catch ex As Exception
        End Try
        document.Add(datatable)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
        'CREA UNA CARPETA SI NO EXISTE
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "/Reporte Diario") = False Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CurrentDirectory + "/Reporte Diario")
        End If
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory + "/Reporte Diario/Reporte Diario " + DateTime.Today.ToString("dd-MM-yyyy") + ".pdf"
        Try
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            Enunciado(doc)
            ExportarDatosPdf(doc, DataGridView1)
            espacios(doc)
            ExportarDatosPdf(doc, DataGridView2)
            espacios(doc)
            ExportarDatosPdf(doc, DataGridView3)
            doc.Close()
            Process.Start(filename)
            Module1.Email("suppbdcodingls@gmail.com", "2019support1BD", "fernando.huerta@alumnos.ucn.cl", "BDCoding", "Reporte Diario", "Reporte Diario " + DateTime.Today.ToString("dd-MM-yyyy"), filename)
        Catch ex As Exception
            MsgBox("Cierre El PDF de Reporte Dia")
        End Try
        'c.valverde.borquez@gmail.com
    End Sub

End Class