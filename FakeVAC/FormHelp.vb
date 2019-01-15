Public Class FormHelp
    Dim gifPath As String = Application.StartupPath & "\Tutorial.gif"

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        'Checking if the tutorial.gif exist, if not the following code will download it.
        If System.IO.File.Exists(gifPath) Then
            Process.Start(gifPath)
        Else
            Cursor = Cursors.WaitCursor

            Using client As New Net.WebClient
                client.DownloadFile("https://raw.githubusercontent.com/SK10/FakeVAC/master/Tutorial.gif", gifPath)
            End Using

            Cursor = Cursors.Default
            Process.Start(gifPath)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/SK10/FakeVAC")
    End Sub

    Private Sub FormHelp_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Label2.Text = Application.ProductVersion()
    End Sub
End Class