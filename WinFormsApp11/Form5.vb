Imports AxWMPLib

Public Class Form5
    ' Form load event
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the media player
        AxWindowsMediaPlayer1.URL = "C:\Users\wally pua\source\repos\WinFormsApp11\chemistry.mp4" ' Specify the correct path
        AxWindowsMediaPlayer1.settings.setMode("loop", True) ' Enable looping
        AxWindowsMediaPlayer1.Ctlcontrols.play() ' Start playing the video

        ' Set media player size
        AxWindowsMediaPlayer1.Size = New Size(1940, 1150)

        ' Customize all buttons
        CustomizeButton(Button1)
        CustomizeButton(Button2)
        CustomizeButton(Button3)
        CustomizeButton(Button4)
        CustomizeButton(Button5)
    End Sub

    ' Method to customize button size and style
    Private Sub CustomizeButton(button As Button)
        ' Set button size
        button.Size = New Size(300, 100)

        ' Customize button style
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.BackColor = Color.FromArgb(100, 0, 0, 0) ' Black tint with transparency
        button.ForeColor = Color.White ' White text
        button.Font = New Font(button.Font.FontFamily, button.Font.Size, FontStyle.Bold) ' Bold text
    End Sub

    ' Custom paint event to add black outline to the text
    Private Sub Button_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint, Button2.Paint, Button3.Paint, Button4.Paint, Button5.Paint
        Dim button As Button = CType(sender, Button)
        e.Graphics.DrawString(button.Text, button.Font, Brushes.Black, New PointF(1, 1)) ' Black outline
        e.Graphics.DrawString(button.Text, button.Font, Brushes.White, New PointF(0, 0)) ' White text
    End Sub

    ' Button click events for media player controls
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause() ' Pause the video
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play() ' Play the video
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 5 ' Rewind 5 seconds
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition += 5 ' Forward 5 seconds
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim newForm As New Form1()
        newForm.Show() ' Open Form1
        Me.Hide()      ' Hide Form5 (optional)
    End Sub

    ' Form closing event
    Private Sub Form5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Add any cleanup code here if needed
    End Sub
End Class
