Imports System.Threading

Public Class Login
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If MetroTextBox1.Text = "tyleraustinabel@gmail.com" And MetroTextBox2.Text = "Waylon2022!" Then
            Home.Show()
        Else
            MessageBox.Show("Incorrect Email/Password", "Please try again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        End
    End Sub
End Class