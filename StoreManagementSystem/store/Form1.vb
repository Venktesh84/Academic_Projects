Public Class Form1
    Dim p As Integer = 1
    Private Sub LOGIN_Click_1(sender As Object, e As EventArgs) Handles LOGIN.Click
        If txtname.Text = "admin" And txtpass.Text = "welcome" Then
            Main.Show()
            Me.Hide()
        ElseIf (p < 3) Then
            If txtname.Text = "admin" And txtpass.Text <> "welcome" Then
                MsgBox("INVALID PASSWORD")
                p = p + 1
            ElseIf txtname.Text <> "admin" And txtpass.Text = "welcome" Then
                MsgBox("INVALID USERNAME")
                p = p + 1
            ElseIf txtname.Text <> "admin" And txtpass.Text <> "welcome" Then
                MsgBox("USERNAME and PASSWORD INVALID", MsgBoxStyle.OkOnly, "Invalid")
                p = p + 1
            End If
        Else
            MsgBox("Login Disabled")
            Application.Exit()
        End If
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Hide()
        MsgBox("Thanks for using this application", MsgBoxStyle.OkOnly, "STORE MANAGEMENT SYSYEM")
        Application.Exit()
    End Sub
End Class
