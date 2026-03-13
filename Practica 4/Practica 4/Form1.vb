Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim time_o = DateTime.Now.ToString("HH:mm")

        Dim time_mod = time_o.Split(":")

        Horas.text = time_mod(0)
        Minutos.text = time_mod(1)
        Dia.Text = Day_o
        Fecha.text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label3.Text = "." Then
            Label3.Text = ""
        ElseIf Label3.Text = "" Then
            Label3.Text = "."
        End If
    End Sub
    Private Sub Fecha_Click(sender As Object, e As EventArgs) Handles Fecha.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub
End Class
