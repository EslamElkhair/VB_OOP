Public Class Form1

    Dim firstnum, secondnum As Double
    Dim operation As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox1.Text += "1"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text += "2"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        TextBox1.Text += "3"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TextBox1.Text += "4"
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        TextBox1.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TextBox1.Text += "6"
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        TextBox1.Text += "7"
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        TextBox1.Text += "8"
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        TextBox1.Text += "9"
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        TextBox1.Text += "0"
    End Sub

    Private Sub Button_add_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        firstnum = CDbl(TextBox1.Text)
        operation = "+"
        TextBox1.Text = ""
    End Sub

    Private Sub Button_sub_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        firstnum = CDbl(TextBox1.Text)
        operation = "-"
        TextBox1.Text = ""
    End Sub

    Private Sub Button_mul_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        firstnum = CDbl(TextBox1.Text)
        operation = "*"
        TextBox1.Text = ""
    End Sub

    Private Sub Button_div_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        firstnum = CDbl(TextBox1.Text)
        operation = "/"
        TextBox1.Text = ""
    End Sub

    Private Sub Button_equal_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        secondnum = CDbl(TextBox1.Text)
        TextBox1.Text = ""

        Select Case operation
            Case "+"
                TextBox1.Text = firstnum + secondnum
            Case "-"
                TextBox1.Text = firstnum - secondnum
            Case "*"
                TextBox1.Text = firstnum * secondnum
            Case "/"
                TextBox1.Text = firstnum / secondnum
        End Select
    End Sub

    Private Sub Button_clear_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = ""
    End Sub
End Class
