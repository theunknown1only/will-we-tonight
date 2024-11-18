Public Class Form4
    ' Declare an array to hold the names of the top 10 celebrities
    Dim celebrities As String() = {"Taylor Swift", "Dwayne Johnson", "Kim Kardashian", "Lionel Messi", "Cristiano Ronaldo",
                                   "Beyoncé", "Selena Gomez", "Tom Cruise", "Jennifer Lawrence", "Robert Downey Jr."}

    ' Form load event
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initially, hide the ListBox and show a message to click the button
        ListBox1.Visible = False
        Label1.Text = "Click the button to see the Top 10 Celebrities!"

        ' Customize the button and label styles
        CustomizeButton(Button1)
        CustomizeLabel(Label1)
    End Sub

    ' Method to customize the button style
    Private Sub CustomizeButton(button As Button)
        button.Size = New Size(250, 50)
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.BackColor = Color.FromArgb(100, 0, 0, 0) ' Black tint with transparency
        button.ForeColor = Color.White ' White text
        button.Font = New Font(button.Font.FontFamily, 12, FontStyle.Bold) ' Bold text
    End Sub

    ' Method to customize the label style
    Private Sub CustomizeLabel(label As Label)
        label.AutoSize = True
        label.Font = New Font("Arial", 14, FontStyle.Bold)
        label.ForeColor = Color.White
    End Sub

    ' Button click event to reveal celebrities
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Toggle visibility of the ListBox and update the label text
        If ListBox1.Visible Then
            ' Hide the ListBox and reset the label text
            ListBox1.Visible = False
            Label1.Text = "Click the button to see the Top 10 Celebrities!"
        Else
            ' Show the ListBox and populate it with celebrities from the array
            ListBox1.Visible = True
            ListBox1.Items.Clear() ' Clear any existing items in the ListBox
            ' Add the celebrity names from the array into the ListBox
            ListBox1.Items.AddRange(celebrities)
            Label1.Text = "Here are the Top 10 Celebrities!"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New Form1
        newForm.Show() ' This opens Form2
        Hide()      ' This hides Form1 (optional)
    End Sub
End Class
