Public Class Form2
    Public Sub jiji()
        Module1.rst = New ADODB.Recordset
        rst.Open("SELECT * FROM Pagar", Module1.con)


        Dim ODA As New OleDb.OleDbDataAdapter
        Dim tb As New DataTable
        Dim ds As DataSet = New DataSet
        ODA.Fill(ds, Module1.rst, "tabla1")
        DataGridView1.DataSource = ds.Tables("tabla1").DefaultView



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jiji()
        Form1.abrirFormulario(Trabajadores)


    End Sub
End Class