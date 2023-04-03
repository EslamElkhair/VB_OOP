Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim length, width, area As Integer

        length = TextBox1.Text
        width = TextBox2.Text

        area = width * length

        TextBox3.Text = area



    End Sub

End Class
