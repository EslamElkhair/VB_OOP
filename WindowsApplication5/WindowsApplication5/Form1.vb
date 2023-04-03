Public Class Form1

  
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim totalCents As Integer


        totalCents = TextBox1.Text



        Label3.Text = totalCents \ 100
        Label4.Text = totalCents Mod 100



    End Sub

 
End Class
