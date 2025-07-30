Imports System.ComponentModel

Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        Login.Hide()
    End Sub

    Private Sub Home_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        End
    End Sub

    Private Sub MetroCheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox5.CheckedChanged

    End Sub

    Private Sub MetroToggle1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle1.CheckedChanged
        MetroCheckBox1.Checked = MetroToggle1.Checked
    End Sub

    Private Sub MetroToggle2_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle2.CheckedChanged
        MetroCheckBox2.Checked = MetroToggle2.Checked
    End Sub

    Private Sub MetroToggle3_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle3.CheckedChanged
        MetroCheckBox3.Checked = MetroToggle3.Checked
    End Sub

    Private Sub MetroToggle4_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle4.CheckedChanged
        MetroCheckBox4.Checked = MetroToggle4.Checked
    End Sub

    Private Sub MetroToggle5_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle5.CheckedChanged
        MetroCheckBox5.Checked = MetroToggle5.Checked
    End Sub
End Class
