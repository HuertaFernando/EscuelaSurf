Public Class Stock
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        If Me.DataGridView2.Columns(e.ColumnIndex).Name = "Stock" Then
            If Convert.ToInt32(e.Value) >= 20 Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.LightGreen
            End If
            If Convert.ToInt32(e.Value) < 20 Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.Yellow
                If Convert.ToInt32(e.Value) < 10 Then
                    e.CellStyle.ForeColor = Color.Black
                    e.CellStyle.BackColor = Color.IndianRed
                End If
            End If

        End If
    End Sub


End Class