Public Class Trabajadores
    Dim contador As Integer = 0


    Public Sub jiji()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT ConAdelantos.RutTrabajador, ConAdelantos.Nombre, ConAdelantos.Generado, ConAdelantos.Adelantado, ConAdelantos.Pagar FROM ConAdelantos WHERE Month(ConAdelantos.Fecha) = " & Date.Today.Month & " and Year(ConAdelantos.Fecha) = " & Date.Today.Year.ToString, Module1.con)
        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        ODA.Fill(ds, Module1.rst, "tabla1")
        DataGridView1.DataSource = ds.Tables("tabla1").DefaultView



    End Sub



    Private Sub AgregarTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jiji()
    End Sub

    Private Sub BtnMuestraAgregaTrbajador_Click(sender As Object, e As EventArgs) Handles btnMuestraAgregaTrbajador.Click
        AgregarTrabajadores.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'lblCantidad.Show()
        'cbRutTrabajador.Show()
        'tbCantidad.Show()
        'lblElijaTrab.Show()
        'Button1.Show()
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        contador = 1
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
End Class