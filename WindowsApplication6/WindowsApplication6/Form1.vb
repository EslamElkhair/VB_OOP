Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim totalSeconds As Integer

        totalSeconds = TextBox1.Text


        Label2.Text = totalSeconds \ 60
        Label3.Text = totalSeconds Mod 60
    End Sub
End Class
