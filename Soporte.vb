Public Class Soporte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.EnviaMail()
    End Sub
    Dim colorr As Color
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

        If RichTextBox1.Text.Count() >= 235 Then
            Label2.ForeColor = Color.Red
        Else
            Label2.ForeColor = colorr
        End If
        Label2.Text = RichTextBox1.Text.Count().ToString() + "/" + "250"
    End Sub

    Private Sub Soporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class