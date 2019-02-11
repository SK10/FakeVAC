Imports System.Net
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

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

    Private Sub FormHelp_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Label1.Text = "Version: " & Application.ProductVersion()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Process.Start("https://github.com/SK10/FakeVAC")
    End Sub

    '<================================== Checking For Updates ===========================================

    Dim latesetVer As String
    Dim currentVer As String
    Dim downLoadUrl As String
    Dim match As Match

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        CheckForupdates()
        Cursor = Cursors.WaitCursor
    End Sub

    Private Sub checkForupdates()
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Using wc As New WebClient
            wc.Headers.Add("Content-Type", "application/json")
            wc.Headers.Add("User-Agent", "FakeVAC")
            wc.DownloadStringAsync(New Uri("https://api.github.com/repos/SK10/FakeVAC/releases/latest"))
            AddHandler wc.DownloadStringCompleted, AddressOf Wc_downloadCompleted
        End Using
    End Sub

    Private Sub wc_downloadCompleted(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        Try
            Dim resObject = JsonConvert.DeserializeObject(e.Result)
            Dim regex = New Regex("""tag_name"": ""v(.*)""")

            match = regex.Match(resObject.ToString)

            If match.Success Then
                latesetVer = match.Groups(1).Value
                currentVer = Application.ProductVersion
                regex = New Regex("""browser_download_url"": ""(.*)""")
                match = regex.Match(resObject.ToString)
                If match.Success Then
                    downLoadUrl = match.Groups(1).Value
                End If

                compareVersion()
            Else
                MsgBox("Failed to check for updates")

            End If
        Catch ex As Exception
            MsgBox("Failed to check for updates! check your network connection.")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub compareVersion()

        If latesetVer > currentVer Then
            If MsgBox("Newer version (" & latesetVer & ") is available!" & vbNewLine & "Do you want to download it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Process.Start(downLoadUrl)
            End If
        Else
            MsgBox("You are using the lateset version: " & currentVer)
        End If
    End Sub

    '===================================================================================================>
End Class