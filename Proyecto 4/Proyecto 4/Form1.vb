Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Numero1 As Integer = Integer.Parse(TextBox1.Text)
        Dim Numero2 As Integer = Integer.Parse(TextBox2.Text)
        Dim resultado As Integer = Numero1 + Numero2
        Label4.Text = resultado.ToString()
    End Sub
End Class
