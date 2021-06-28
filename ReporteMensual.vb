Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
'CARLOS
Public Class ReporteMensual
    Dim sum As Decimal
    Dim sumProductos As Decimal
    Dim sumaa As Decimal
    Public Function Tamañocolumnas(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Public Sub ExportarDatosPdf(ByVal document As Document, ByVal dg As DataGridView)
        Dim datatable As New PdfPTable(dg.ColumnCount)
        datatable.DefaultCell.Padding = 2
        Dim headerwidth As Single() = Tamañocolumnas(dg)
        datatable.SetWidths(headerwidth)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = dg.ColumnCount
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        document.Add(datatable)
    End Sub
    Public Sub Enunciado(ByVal document As Document)
        Dim encabezado As New Paragraph("Reporte Mensual", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        Dim texto As New Paragraph("Reporte de ventas : " + Now.Date().ToString("MM/yyyy"), New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim total As New Paragraph("Total generado: " + Label13.Text, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim espacios As New Paragraph("                                                                                                        ", New Font(Font.Name = "Tahoma", 5, Font.Bold))
        document.Add(encabezado)
        document.Add(espacios)
        document.Add(texto)
        document.Add(espacios)
        document.Add(total)
        document.Add(espacios)
    End Sub
    'ESPACIOS ENTRE CADA REPORTE
    Public Sub Generarespacios(ByVal document As Document)
        Dim espacios As New Paragraph("                                                                                                        ", New Font(Font.Name = "Tahoma", 10, Font.Bold))
        document.Add(espacios)
    End Sub
    ' Con un count necesitas saber cuatas columnas hay
    ': Y despues le hacer un For
    ' Y pones por ef
    ' Ej
    ' Datagridview.rows(i).cell(lugar de la celda cual quiere sumar).value()
    ' Se parte de 0 como en pyton

    Public Sub DGV_ActividadesPlusVendus()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT Agendas.NombreActividad, COUNT(Agendas.NombreActividad) AS Cantidad, Actividades.Precio*Count(Agendas.NombreActividad) AS Total FROM Agendas, Actividades WHERE Month(Agendas.Fecha) = " & DateTime.Today.Month & " AND Year(Agendas.Fecha) = " & DateTime.Today.Year & " AND Agendas.NombreActividad=Actividades.NombreActividad GROUP BY Agendas.NombreActividad,Actividades.Precio", Module1.con)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        ODA.Fill(ds, Module1.rst, "tabla1")
        DataGridViewPyC.DataSource = ds.Tables("tabla1").DefaultView
    End Sub

    'CANTIDADES DE LOS PRODUCTOS MAS VENDIDOS
    Public Sub DGV_ProductsPlusVendus()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT Productos.NombreProducto, SUM(DetalleVentas.Cantidad) AS TotalVendido,SUM((DetalleVentas.cantidad)*(Productos.PrecioProducto)) AS DineroGenerado FROM Productos,DetalleVentas,Ventas WHERE Month(Ventas.Fecha)= " & DateTime.Today.Month & " AND Year(Ventas.Fecha) = " & DateTime.Today.Year & "  AND Productos.IdProducto=DetalleVentas.IdProducto AND DetalleVentas.IdVenta=Ventas.IdVenta GROUP BY Productos.NombreProducto ORDER BY SUM(DetalleVentas.Cantidad) DESC", Module1.con)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        ODA.Fill(ds, Module1.rst, "tabla1")
        DataGridViewProductosMes.DataSource = ds.Tables("tabla1").DefaultView
    End Sub
    'CANTIDAD DE ACTIVIDADES HECHAS POR INSTRUCTOR
    Public Sub CountActividadesPorInstructor()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT  Sueldo.Nombre AS Instructor, Sueldo.NombreActividad, Sueldo.CuentaDeNombreActividad1 AS Cantidad FROM Sueldo WHERE Month(Sueldo.Fecha)= " & DateTime.Today.Month & " AND Year(Sueldo.Fecha) =  " & DateTime.Today.Year, Module1.con)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        ODA.Fill(ds, Module1.rst, "tabla1")
        DGVCantidadxMes.DataSource = ds.Tables("tabla1").DefaultView
    End Sub
    'SUELDOS SIN ADELANTOS
    Public Sub PagosInstructores()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT ConAdelantos.RutTrabajador, ConAdelantos.Nombre, (ConAdelantos.Generado) AS Generado, (ConAdelantos.Adelantado) as ADELANTO, (ConAdelantos.Pagar) as TOTAL_PAGAR FROM ConAdelantos WHERE Month(ConAdelantos.Fecha) = " & Date.Today.Month & " and Year(ConAdelantos.Fecha) = " & Date.Today.Year.ToString, Module1.con)
        Dim oda As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        oda.Fill(ds, Module1.rst, "tabla1")
        SueldosConAdelantos.DataSource = ds.Tables("tabla1").DefaultView
    End Sub


    Public Sub MetodosPagos()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT Trabajadores.Nombre, Ventas.MetodoPago,COUNT(Ventas.MetodoPago) AS Usado, SUM(Ventas.total) AS DineroGenerado  FROM Trabajadores,Ventas WHERE Month(Ventas.Fecha)=" & DateTime.Today.Month & "AND Year(Ventas.Fecha)=" & DateTime.Today.Year & "AND Trabajadores.RutTrabajador=Ventas.RutTrabajador GROUP BY Ventas.MetodoPago,Trabajadores.Nombre", Module1.con)
        Dim oda As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        oda.Fill(ds, Module1.rst, "tabla1")
        MediosDePagos.DataSource = ds.Tables("tabla1").DefaultView
    End Sub

    Public Sub MontoProductosArriendo()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT Productos.NombreProducto AS Producto, COUNT(Arriendos.IdProducto) AS Cantidad ,SUM(Productos.PrecioProducto) AS Total FROM Productos, Arriendos WHERE Productos.IdProducto = Arriendos.IdProducto AND Month(Arriendos.Fecha) = " & DateTime.Today.Month & " And Year(Arriendos.Fecha)=" & DateTime.Today.Year & " GROUP BY Productos.NombreProducto", Module1.con)
        Dim oda As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        oda.Fill(ds, Module1.rst, "tabla1")
        DGVProductosArriendo.DataSource = ds.Tables("tabla1").DefaultView

    End Sub

    Private Sub ReporteMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelFecha.Text = Date.Now.Date



        DGV_ActividadesPlusVendus()
        DGV_ProductsPlusVendus()
        CountActividadesPorInstructor()
        PagosInstructores()
        MetodosPagos()
        MontoProductosArriendo()

        'RECORRER LA 3°COLUMNA DE EL DATAGRIDVIEW (MONTO GENERADO POR LAS VENTAS DE LOS PRODUCTOS)
        'RECORRE LA COLUMNA DE LOS PRECIOS (INDEX=2) y suma los valores hacia abajo
        For i = 0 To DataGridViewPyC.Rows.Count - 1
            sum += DataGridViewPyC.Rows(i).Cells(2).Value()
        Next
        Label6.Text = sum
        For x = 0 To DataGridViewProductosMes.Rows.Count - 1
            sumProductos += DataGridViewProductosMes.Rows(x).Cells(2).Value()
        Next


        For z = 0 To DGVProductosArriendo.Rows.Count - 1
            sumaa += DGVProductosArriendo.Rows(z).Cells(2).Value()
        Next
        Label12.Text = sumaa
        Label11.Text = sumProductos
        Label13.Text = Val(Label6.Text) + Val(Label11.Text) + Val(Label12.Text)



    End Sub
    Public Sub llenarBoleta()
        Me.ReportViewer1.LocalReport.ReportPath = "C:\BDCodingLS\VibraSurf\EscuelaSurf\ReportMensual.rdlc"
        Me.ReportViewer1.RefreshReport()
        'CODIGO SEBA
        Dim dt As DataTable = New DataTable
        dt.Columns.Add("NombreActividad", Type.GetType("System.String"))
        dt.Columns.Add("Cantidad", Type.GetType("System.String"))
        dt.Columns.Add("Total", Type.GetType("System.String"))
        Dim dete As DataTable = New DataTable
        dete.Columns.Add("NombreProducto", Type.GetType("System.String"))
        dete.Columns.Add("Cantidad", Type.GetType("System.String"))
        dete.Columns.Add("Total", Type.GetType("System.String"))
        Dim z As Integer = 0
        For Each row As DataGridView In DataGridViewProductosMes.Rows
            Dim dere As DataRow = dete.NewRow
            dere("NombreProductos") = DataGridViewProductosMes(0, z).Value()
            dere("Cantidad") = DataGridViewProductosMes(1, z).Value()
            dere("Total") = DataGridViewProductosMes(2, z).Value()
            dete.Rows.Add(dere)
            z += 1
        Next
        Dim x As Integer = 0
        For Each row As DataGridViewRow In DataGridViewPyC.Rows
            Dim dr As DataRow = dt.NewRow
            dr("NombreActividad") = DataGridViewPyC(0, x).Value()
            dr("Cantidad") = DataGridViewPyC(1, x).Value()
            dr("Total") = DataGridViewPyC(2, x).Value()
            dt.Rows.Add(dr)
            x += 1
        Next
        Dim rds As New ReportDataSource
        rds.Name = "DataSet1"
        rds.Value = dt
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.RefreshReport()
    End Sub
    Dim pdfPath As String
    Public Sub ExpData() 'Esta en pago
        Dim pdfContent As Byte() = ReportViewer1.LocalReport.Render("PDF", Nothing)
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "/Reporte Mensual") = False Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CurrentDirectory + "/Reporte Mensual")
        End If
        pdfPath = My.Computer.FileSystem.CurrentDirectory + "/Reporte Mensual/ReporteMensual " + DateTime.Now.ToString("MM-yyyy") + ".pdf"
        If My.Computer.FileSystem.FileExists(pdfPath) = True Then
            My.Computer.FileSystem.DeleteFile(pdfPath)
        End If
        Dim pdfFile As New System.IO.FileStream(pdfPath, System.IO.FileMode.Create)
        pdfFile.Write(pdfContent, 0, pdfContent.Length)
        pdfFile.Close()
    End Sub
    Private Sub PDF_Click(sender As Object, e As EventArgs) Handles PDF.Click
        Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
        'CREA UNA CARPETA SI NO EXISTE
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "/Reporte Mensual") = False Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CurrentDirectory + "/Reporte Mensual")
        End If
        Dim filename As String = My.Computer.FileSystem.CurrentDirectory + "/Reporte Mensual/Reporte Mensual " + DateTime.Today.ToString("MM-yyyy") + ".pdf"
        Try
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            Enunciado(doc)
            ReporteDiario.ExportarDatosPdf(doc, DataGridViewPyC)
            ReporteDiario.espacios(doc)
            ReporteDiario.ExportarDatosPdf(doc, DataGridViewProductosMes)
            ReporteDiario.espacios(doc)
            ReporteDiario.ExportarDatosPdf(doc, DGVCantidadxMes)
            ReporteDiario.espacios(doc)
            ReporteDiario.ExportarDatosPdf(doc, SueldosConAdelantos)
            ReporteDiario.espacios(doc)
            ReporteDiario.ExportarDatosPdf(doc, MediosDePagos)
            doc.Close()
            Process.Start(filename)
            Module1.Email("suppbdcodingls@gmail.com", "2019support1BD", "c.valverde.borquez@gmail.com", "BDCoding", "Reporte Mensual", "Reporte Mensual " + DateTime.Today.ToString("MM/yyyy"), filename)
        Catch ex As Exception
            MsgBox("Cierre El PDF de Reporte Mensual")
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub


End Class