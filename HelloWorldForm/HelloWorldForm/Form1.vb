Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hello World!")
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        PictureBox1.Image = HelloWorldForm.My.Resources.Resources.Horse
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        PictureBox1.Image = HelloWorldForm.My.Resources.Resources.flower
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        PictureBox1.Image = HelloWorldForm.My.Resources.Resources.bird
    End Sub
End Class
