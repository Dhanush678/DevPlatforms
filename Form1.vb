Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles TextBox2.MouseEnter

        Dim colortext As Color
        colortext = Color.FromArgb(120, 120, 120)
        If TextBox2.Text = "Password" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = colortext

        End If
    End Sub
    Private Sub TextBox2_MouseLeave(sender As Object, e As EventArgs) Handles TextBox2.MouseLeave

        Dim colorHint As Color
        colorHint = Color.FromArgb(200, 200, 200)
        If TextBox2.Text = "" Then
            TextBox2.Text = "Password"
            TextBox2.ForeColor = colorHint


        End If
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter

        Dim colortext As Color
        colortext = Color.FromArgb(120, 120, 120)
        If TextBox1.Text = "Username or Email ID" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = colortext

        End If
    End Sub
    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave

        Dim colorHint As Color
        colorHint = Color.FromArgb(200, 200, 200)
        If TextBox1.Text = "" Then
            TextBox1.Text = "Username or Email ID"
            TextBox1.ForeColor = colorHint

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Registry_Click(sender As Object, e As EventArgs) Handles Registry.Click
        Dim Form2 As New Form2
        Me.Hide()
        Form2.Show()

    End Sub
End Class
