Public Class Form1

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If Username.Text = "" Or Password.Text = "" Then
            MsgBox("Enter Username and Password")

        ElseIf Username.Text = "4 Aces" And Password.Text = "Sofaset" Then
            Dim Obj = New Receipt
            Obj.Show()
            Me.Hide()

        Else
            MsgBox("Wrong Username or Password")
            Username.Text = ""
            Password.Text = ""

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
