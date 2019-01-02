Imports Gecko
Imports Gecko.Events
Public Class FormBrowser

    Dim screenshotName As String
    Dim finalHtmlString As String
    Dim geckoElementCollection As GeckoElementCollection
    Public docCompleted As Boolean = False
    Dim picPath As String = "C:\Users\" & Environment.UserName & "\Pictures\"

    '<<================================== Replacing the html code ========================================
    Private Sub doTheMagic()
        Try
            'Getting the html code from "Form1"
            finalHtmlString = Form1.finalHtmlString

            geckoElementCollection = GeckoWebBrowser1.Document.GetElementsByTagName("div")

            'Looking for each "div" tag in the web page
            For Each curElemnt As GeckoHtmlElement In geckoElementCollection

                'If there is a "div" tag with an attribute "class" that equale "responsive_status_info"
                'Then we change the value of that tag to the html code we got from Form1
                If curElemnt.GetAttribute("class") = "responsive_status_info" Then
                    curElemnt.InnerHtml = finalHtmlString
                    'Removing part of the webpage which is (install steam - login - langauge) because the page will look cleaner
                ElseIf curElemnt.GetAttribute("id") = "global_action_menu" Then
                    curElemnt.InnerHtml = ""
                End If
            Next
        Catch ex As Exception

            MsgBox("Ops, Something went wrong, the profile might be already vac banned or maybe it doesn't exist.")
            Hide()
        End Try
    End Sub
    '===================================================================================================>>

    '<<================================== Taking the screenshot ==========================================
    Private Function TakeScreenShot() As Bitmap
        'Output : 
        '       * tmpImg which is the screenshot 

        Dim tmpImg As New Bitmap(GeckoWebBrowser1.Width, GeckoWebBrowser1.Height) 'Using "geckoWebBrowser1 size for the screenshot.
        Using g As Graphics = Graphics.FromImage(tmpImg)
            'I substracted 21 from the width to hide the scrollbar from the screenshot.
            g.CopyFromScreen(GeckoWebBrowser1.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(GeckoWebBrowser1.Width - 21, GeckoWebBrowser1.Height))
        End Using
        Return tmpImg
    End Function
    '===================================================================================================>>

    Private Sub GeckoWebBrowser1_DocumentCompleted(sender As Object, e As GeckoDocumentCompletedEventArgs) Handles GeckoWebBrowser1.DocumentCompleted

        docCompleted = True 'Setting this var to true so i can tell that the webpage is loaded in the form1

        doTheMagic()

        'Removing this part from the url so only the id is left to use it as screenshot name.
        screenshotName = Form1.txtUrl.Text.Replace("https://steamcommunity.com/", "")

        checkIfExists()
    End Sub

    '<<================================== Check for existing screenshot ==================================
    Private Sub checkIfExists()

        If System.IO.File.Exists(picPath & screenshotName.Replace("/", "-") & ".png") Then
            Form1.Hide()

            If MsgBox("Screenshot under the same name was found, do you want to overwrite it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Timer1.Enabled = True 'this timer is to delay taking the screenshot by half a second after loading the webpage.
            Else
                Close()
                Form1.Show()
            End If

        Else

            Timer1.Enabled = True
        End If
    End Sub
    '===================================================================================================>>

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Taking the screenshot and saving it to the pictures library.
        TakeScreenShot().Save(picPath & screenshotName.Replace("/", "-") & ".png", Imaging.ImageFormat.Png)

        Form1.btnNew.PerformClick()

        'Opening the pictures folder and selecting the screenshot
        Process.Start("explorer.exe", "/select," & picPath & screenshotName.Replace("/", "-") & ".png")

        Timer1.Enabled = False
        Hide()
        Form1.Show()
    End Sub
End Class