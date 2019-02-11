' Author: Abdulaziz -SK01-
' Date: 15/06/2018
' 
' This application is used to create a fake VAC ban on any steam profile (private/VACed profiles excluded) then take screenshot of the profile
' 
' It works by loading the steam profile page, then replacing a html code with fake one, then taking a screenshot.
' The application use geckoWebBrowser instead of the defualt webBrowser becuase IE sucks and the loaded page doesn't look good.

Imports System.Text.RegularExpressions
Public Class Form1

    Dim multiVacs As String
    Dim multiGameBans As String
    Public finalHtmlString As String
    Dim docCompleted As Boolean
    Dim regex As Regex = New Regex("(?i:^https?:\/\/(?:www\.)?steamcommunity\.com\/(id\/([^/\s]*)|profiles\/([^/\s]*))+/?$)")
    Dim match As Match

    Private Sub txtBoxes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGameBansDays.KeyPress, txtOnlineDays.KeyPress, txtVacDays.KeyPress
        'Restricting the textbox from accepting anything but numbers and the backspace char by using ascii.
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtBoxes_Validate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVacDays.TextChanged, txtOnlineDays.TextChanged, txtGameBansDays.TextChanged
        'Making sure that the user has provided an input, only if true the "btnStart" button will be enabled.
        If radVac.Checked = True Then
            If valueFound(txtVacDays.Text) AndAlso valueFound(txtOnlineDays.Text) Then
                btnStart.Enabled = True
            Else
                btnStart.Enabled = False
            End If
        ElseIf radGameBan.Checked = True Then
            If valueFound(txtGameBansDays.Text) AndAlso valueFound(txtOnlineDays.Text) Then
                btnStart.Enabled = True
            Else
                btnStart.Enabled = False
            End If
        ElseIf radGameVac.Checked = True Then
            If valueFound(txtOnlineDays.Text) AndAlso valueFound(txtGameBansDays.Text) Then
                btnStart.Enabled = True
            Else
                btnStart.Enabled = False
            End If
        Else
            btnStart.Enabled = False
        End If
    End Sub

    Private Sub RadVAC_CheckedChanged(sender As Object, e As EventArgs) Handles radVac.CheckedChanged
        'Checking if "radVac" is checked to enable the buttons needed.
        If radVac.Checked = True Then
            EnableForVac(True)
        Else
            EnableForVac(False)
        End If
    End Sub

    Private Sub RadGameBan_CheckedChanged(sender As Object, e As EventArgs) Handles radGameBan.CheckedChanged
        'Checking if "radGameBan" is checked to enable the buttons needed.
        If radGameBan.Checked = True Then
            EnableForGameBan(True)
        Else
            EnableForGameBan(False)
        End If
    End Sub

    Private Sub RadGameVac_CheckedChanged(sender As Object, e As EventArgs) Handles radGameVac.CheckedChanged
        'Checking If "radGameVac" is checked to enable the buttons needed.
        If radGameVac.Checked = True Then
            EnableForVac(True)
            enableForGameBan(True)
            txtVacDays.Enabled = False
        Else
            EnableForVac(False)
            EnableForGameBan(False)
        End If
    End Sub

    Private Sub TxtUrl_TextChanged(sender As Object, e As EventArgs) Handles txtUrl.TextChanged
        'Making sure that the textbox does have a value to able to hide the "invalid url" label if its empty.
        If ValueFound(txtUrl.Text) Then

            '<================================== Check the url ==========================================
            'Using regex to check if the content of "txtUrl" is a steam profile url.
            'Check the declared variables at top for the regex pattern.
            match = regex.Match(txtUrl.Text)

            If match.Success = True Then
                radBtnState(True)
                Label1.Visible = False
            Else
                radBtnState(False)
                btnStart.Enabled = False
                Label1.Visible = True
                ResetRadTxt()
            End If
            '===========================================================================================>

        Else

            radBtnState(False)
            Label1.Visible = False

        End If
    End Sub

    Private Sub TxtUrl_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUrl.MouseClick
        'Auto filling the "txtUrl" if the clipboard content is a steam profile link.
        match = regex.Match(My.Computer.Clipboard.GetText)
        If match.Success = True Then
            txtUrl.Text = My.Computer.Clipboard.GetText
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            '<================================== Check for multiple Vac/Gamebans ========================

            If chkVacs.Checked = True Then
                multiVacs = "Multiple VAC bans on record"
            Else
                multiVacs = "1 VAC ban on record"
            End If

            If chkGameBans.Checked = True Then
                multiGameBans = "Multiple game bans on record"
            Else
                multiGameBans = "1 game ban on record"
            End If
            '===========================================================================================>

            'Checking which radio button has the user checked.
            If radVac.Checked = True Then
                VACban(MultiVacs, txtVacDays.Text, txtOnlineDays.Text)
            ElseIf radGameBan.Checked = True Then
                GameBan(MultiGameBans, txtGameBansDays.Text, txtOnlineDays.Text)
            ElseIf radGameVac.Checked = True Then
                VACbanGameban(MultiVacs, txtGameBansDays.Text, MultiGameBans, txtOnlineDays.Text)
            End If

            'Double checking that the "txtUrl" is not empty
            If Label1.Visible = False AndAlso ValueFound(txtUrl.Text) Then
                FormBrowser.GeckoWebBrowser1.Navigate(txtUrl.Text)
            End If

            Timer1.Enabled = True
            picLoading.Visible = True

        Catch ex As Exception
            MsgBox("Ops, " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ResetRadTxt()
        txtUrl.Clear()
        chkGameBans.Checked = False
        chkVacs.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'This var is set to true when the browser on "FormBrowser" finish loading the webpage
        docCompleted = FormBrowser.docCompleted 'getting the state with every tick

        If docCompleted = True Then
            picLoading.Visible = False
            FormBrowser.Show()
            Timer1.Enabled = False
        End If
    End Sub

    '<================================== Reset form1 controls ===========================================
    Private Sub resetRadTxt()
        'Unchecking all the radio buttons so the text boxes get disabled.
        For Each Ctrl As Control In GroupBox1.Controls
            If TypeOf Ctrl Is RadioButton Then
                DirectCast(Ctrl, RadioButton).Checked = False
            End If
        Next

        'Clearing all the textboxes
        For Each Ctrl As Control In GroupBox3.Controls
            If TypeOf Ctrl Is TextBox Then
                DirectCast(Ctrl, TextBox).Clear()
            End If
        Next
    End Sub
    '===================================================================================================>

    '<================================== Enable/Disable radio buttons ===================================
    Private Sub radBtnState(state As Boolean)
        If state = True Then
            radVac.Enabled = True
            radGameBan.Enabled = True
            radGameVac.Enabled = True
        Else
            radVac.Enabled = False
            radGameBan.Enabled = False
            radGameVac.Enabled = False
        End If
    End Sub
    '===================================================================================================>

    '<================================== Enable/Disable VAC textboxes ===================================
    Private Sub enableForVac(State As Boolean)
        If State = True Then
            txtVacDays.Enabled = True
            txtOnlineDays.Enabled = True
            chkVacs.Enabled = True
        Else
            txtVacDays.Enabled = False
            txtOnlineDays.Enabled = False
            chkVacs.Enabled = False
        End If
    End Sub
    '===================================================================================================>

    '<================================== Enable/Disable Gameban textboxes ===============================
    Private Sub enableForGameBan(State As Boolean)
        If State = True Then
            txtGameBansDays.Enabled = True
            txtOnlineDays.Enabled = True
            chkGameBans.Enabled = True
            If radGameVac.Checked = True Then
                Label4.Text = "Days since last ban?"
            Else
                Label4.Text = "Days since last Gameban?"
            End If
        Else
            txtGameBansDays.Enabled = False
            txtOnlineDays.Enabled = False
            chkGameBans.Enabled = False
        End If
    End Sub
    '===================================================================================================>

    '<================================== Validate an input ==============================================
    'InputControl is textbox most of the times
    'Output is true/false depending on the textbox content

    Private Function valueFound(inputControl As String)
        If Not String.IsNullOrEmpty(inputControl) Then
            Return True
        Else
            Return False
        End If
    End Function
    '===================================================================================================>

    '<================================== VAC ban html string ============================================
    Private Sub VACban(vacs As String, daysSince As Integer, lastOnline As Integer)
        'Inputs :
        '       * vacs = multiVacs
        '       * daysSince = txtVacDays.text
        '       * lastOnline = txtOnlineDays.text
        '
        'Output : finalHtmlString

        Dim vacBanString As String = "<div class="""">
						<div class=""profile_in_game persona offline"">
					<div class=""profile_in_game_header"">Currently Offline</div>
							<div class=""profile_in_game_name"">Last Online " & lastOnline & " days ago</div>
			               </div>
						<div class=""profile_ban_status"">
											<div class=""profile_ban"">
					" & vacs & "					<span class=""profile_ban_info"">| <a class=""whiteLink"" href=""https://support.steampowered.com/kb_article.php?ref=7849-Radz-6869&amp;l=english"" target=""_blank"" rel=""noreferrer"">Info</a></span>
				</div>
									" & daysSince & " day(s) since last ban								</div>
				</div>"

        finalHtmlString = vacBanString
    End Sub
    '===================================================================================================>

    '<================================== Gameban html string ============================================
    Private Sub GameBan(gameBans As String, daysSinceGameBan As Integer, lastOnline As Integer)
        'Inputs :
        '       * gameBans = multiGameBans
        '       * daysSince = txtVacDays.text
        '       * lastOnline = txtOnlineDays.text
        '
        'Output : finalHtmlString

        Dim gameBanString As String = "<div class="""">
						<div class=""profile_in_game persona offline"">
					<div class=""profile_in_game_header"">Currently Offline</div>
							<div class=""profile_in_game_name"">Last Online " & lastOnline & " days ago</div>
			               </div>
						<div class=""profile_ban_status"">
											<div class=""profile_ban"">
					" & gameBans & "					<span class=""profile_ban_info"">| <a class=""whiteLink"" href=""https://support.steampowered.com/kb_article.php?ref=7849-Radz-6869&amp;l=english"" target=""_blank"" rel=""noreferrer"">Info</a></span>
				</div>
									" & daysSinceGameBan & " day(s) since last ban								</div>
				</div>"

        finalHtmlString = gameBanString
    End Sub
    '===================================================================================================>

    '<================================== VAC & Gameban html string ======================================
    Private Sub VACbanGameban(Vacs As String, daysSince As Integer, gameBans As String, lastOnline As Integer)
        'Input :
        '       * vacs = multiVacs
        '       * gameBans = multiGameBans
        '       * daysSince = txtVacDays.text
        '       * lastOnline = txtOnlineDays.text
        '
        'Output : finalHtmlString

        Dim vacGameBanString As String = "<div class="""">
						<div class=""profile_in_game persona offline"">
					<div class=""profile_in_game_header"">Currently Offline</div>
							<div class=""profile_in_game_name"">Last Online " & lastOnline & " days ago</div>
			               </div>
						<div class=""profile_ban_status"">
											<div class=""profile_ban"">
					" & Vacs & "					<span class=""profile_ban_info"">| <a class=""whiteLink"" href=""https://support.steampowered.com/kb_article.php?ref=7849-Radz-6869&amp;l=english"" target=""_blank"" rel=""noreferrer"">Info</a></span>
				</div>
                    						<div class=""profile_ban"">
				    " & gameBans & " 					<span class=""profile_ban_info"">| <a class=""whiteLink"" href=""https//support.steampowered.com/kb_article.php?ref=6899-IOSK-9514&amp;l=english"" target=""_blank"" rel=""noreferrer"">Info</a></span>
				</div>
									" & daysSince & " day(s) since last ban								</div>
				</div>"
        finalHtmlString = vacGameBanString
    End Sub
    '===================================================================================================>

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        FormHelp.Show()
    End Sub

End Class
