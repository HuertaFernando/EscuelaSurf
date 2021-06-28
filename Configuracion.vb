Imports System.Net
Public Class Configuracion
    Public WithEvents Upload As WebClient
    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "v " + Application.ProductVersion
        If My.Settings.AutoUpdate = True Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If

        TextBox1.Text = My.Settings.rojo
        TextBox2.Text = My.Settings.amarillo
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckUpdates("https://sites.google.com/site/bdcodingls/updates/vibrasurf-update.txt?attredirects=0&d=1")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            My.Settings.AutoUpdate = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            My.Settings.AutoUpdate = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("¡Se guardara la configuracion que usted desea!", vbInformation) = vbOK Then
            My.Settings.rojo = CInt(TextBox1.Text)
            My.Settings.amarillo = CInt(TextBox2.Text)
            My.Settings.Save()
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox3.Text = "" Or NumericUpDown1.Text = "" Or NumericUpDown2.Text = "" Or NumericUpDown3.Text = "" Then
            MsgBox("Debes completar todos los campos")

        Else





            Dim ask As MsgBoxResult
            Dim sql As String

            sql = "INSERT INTO Actividades (NombreActividad,Duracion,Precio,Porcentaje) VALUES( '" + TextBox3.Text + "','" + NumericUpDown1.Text + "','" + NumericUpDown2.Text + "','" + NumericUpDown3.Text + "')"


            Module1.rst = New ADODB.Recordset
            rst.Open(sql, Module1.con)
            ask = MsgBox("¿Esta seguro de agregar estos datos?", MsgBoxStyle.YesNo, "")
            If ask = MsgBoxResult.Yes Then
                MsgBox("Datos agregados")
                TextBox3.Clear()
                NumericUpDown1.ResetText()
                NumericUpDown2.ResetText()
                NumericUpDown3.ResetText()
            Else
                If ask = MsgBoxResult.No Then
                    MsgBox("Operacion cancelada")
                    TextBox3.Clear()
                    NumericUpDown1.ResetText()
                    NumericUpDown2.ResetText()
                    NumericUpDown3.ResetText()

                End If
            End If
        End If

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class


