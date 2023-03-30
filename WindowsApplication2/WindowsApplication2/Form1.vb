Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim sum As Integer

        For x = 1 To 100
            sum += x

        Next

        TextBox1.Text = sum
    End Sub
End Class
