
Imports System.Data
Imports System.Data.OleDb
Public Class inicio
    Private con As New OleDb.OleDbConnection
    Private command As OleDb.OleDbCommand
    Private adapter As OleDbDataAdapter
    Private reader As OleDbDataReader
    Private dataSt As DataSet
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EscuelaSurfDataSet.Crecioomientos' table. You can move, or remove it, as needed.
        ' Me.CrecimientosTableAdapter.Fill(Me.EscuelaSurfDataSet.Crecimientos)
        InstructoresPro(ListBox1)
        CantidadActividadesAlumno()
        ActividadesTotalMes()
    End Sub
    Public Sub ActividadesTotalMes()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT  Sueldo.Nombre AS Instructor, Sueldo.NombreActividad, Sueldo.CuentaDeNombreActividad1 AS Cantidad FROM Sueldo WHERE Month(Sueldo.Fecha)= " & DateTime.Today.Month & " AND Year(Sueldo.Fecha) =  " & DateTime.Today.Year, Module1.con)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        ODA.Fill(ds, Module1.rst, "tabla1")
        DataGridView2.DataSource = ds.Tables("tabla1").DefaultView
    End Sub
    Public Sub CantidadActividadesAlumno()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT * FROM ACTporClientes", Module1.con)
        Dim oda As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        oda.Fill(ds, Module1.rst, "tabla1")
        DataGridView1.DataSource = ds.Tables("tabla1").DefaultView

    End Sub

    Public Sub InstructoresPro(lista)
        Module1.rst = New ADODB.Recordset
        Dim sql As String = ""
        sql = "SELECT top 3 nombre, count(nombre) AS realizadas FROM trabajadores INNER JOIN agendas ON agendas.ruttrabajador=trabajadores.ruttrabajador GROUP BY nombre order by 2 desc" 'where fecha between #15-09-2019# and #20-12-2019#
        rst.Open(sql, Module1.con)
        If Not rst.EOF Then
            While Not rst.EOF
                lista.items.add(rst.Fields("nombre").Value() + Chr(9) + Chr(9) + CStr(rst.Fields("realizadas").Value()))
                rst.MoveNext()
            End While
        End If
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            CantidadActividadesAlumno()
        Else

            Module1.rst = New ADODB.Recordset
            rst.Open("SELECT * FROM ACTporClientes WHERE ACTporClientes.NombreCliente Like '" + TextBox1.Text + "%'", Module1.con)
            Dim oda As New OleDb.OleDbDataAdapter
            Dim tb As New DataTable
            Dim ds As DataSet = New DataSet
            oda.Fill(ds, Module1.rst, "tabla1")
            DataGridView1.DataSource = ds.Tables("tabla1").DefaultView
        End If
    End Sub


End Class