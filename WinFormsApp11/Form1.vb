Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Form5()
        newForm.Show() ' This opens Form2
        Me.Hide()      ' This hides Form1 (optional)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim newForm As New Form3
        newForm.Show() ' This opens Form2
        Hide()      ' This hides Form1 (optional)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim newForm As New Form4
        newForm.Show() ' This opens Form2
        Hide()      ' This hides Form1 (optional)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

