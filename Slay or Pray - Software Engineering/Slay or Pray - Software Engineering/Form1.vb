Public Class Form1


    Dim counter As Integer = 0
    Dim counter2 As Double = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.Opacity = 0
        PictureBox1.Image = My.Resources.img1
        PictureBox2.Image = My.Resources.title
        PictureBox2.Visible = False
        scenedimin.Enabled = True


    End Sub

    Private Sub timerscene_Tick(sender As Object, e As EventArgs) Handles scenedimin.Tick

        Me.Opacity += 0.1
        If Me.Opacity = 1 Then
            scenedimin.Stop()
            storychange.Start()
        End If

    End Sub

    Private Sub storychange_Tick(sender As Object, e As EventArgs) Handles storychange.Tick
        counter += 1000


        Select Case counter
            Case 3000
                PictureBox1.Image = My.Resources.img2
            Case 6000
                PictureBox1.Image = My.Resources.img3
            Case 9000
                PictureBox1.Image = My.Resources.img4
            Case 12000
                PictureBox1.Image = My.Resources.bgstart
                PictureBox2.Visible = True
                storychange.Stop()
                title.Start()
        End Select


    End Sub

    Private Sub title_Tick(sender As Object, e As EventArgs) Handles title.Tick
        counter2 += 1
        If (counter2 Mod 2 > 0) Then
            Label1.Text = True

        Else
            Label1.Text = False
        End If
    End Sub
End Class
