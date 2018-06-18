Imports System.Text.RegularExpressions
Public Class Form1

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Selecting English as primary langauge
        RadEn.Checked = True
    End Sub

    Private Sub RadVAC_CheckedChanged(sender As Object, e As EventArgs) Handles RadVAC.CheckedChanged
        If RadVAC.Checked = True Then
            ChkVacs.Enabled = True
            TxtVacDays.Enabled = True
            TxtOnlineDays.Enabled = True
            ChkGameBans.Enabled = False
            TxtGameBansDays.Enabled = False
        Else
            ChkVacs.Checked = False
            TxtVacDays.Clear()
        End If
    End Sub

    Private Sub RadGameBan_CheckedChanged(sender As Object, e As EventArgs) Handles RadGameBan.CheckedChanged
        If RadGameBan.Checked = True Then
            ChkVacs.Enabled = False
            TxtVacDays.Enabled = False
            TxtOnlineDays.Enabled = True
            ChkGameBans.Enabled = True
            TxtGameBansDays.Enabled = True
        Else
            ChkGameBans.Checked = False
            TxtGameBansDays.Clear()
        End If
    End Sub

    Private Sub RadGameVac_CheckedChanged(sender As Object, e As EventArgs) Handles RadGameVac.CheckedChanged
        If RadGameVac.Checked = True Then
            ChkVacs.Enabled = True
            TxtOnlineDays.Enabled = True
            ChkGameBans.Enabled = True
            TxtGameBansDays.Enabled = True
            Label4.Text = "Days since last ban?"
        Else
            ChkVacs.Checked = False
            ChkGameBans.Checked = False
            TxtGameBansDays.Clear()
            Label4.Text = "Days since gameban?"
        End If
    End Sub

    Private Sub RadAr_CheckedChanged(sender As Object, e As EventArgs) Handles RadAr.CheckedChanged
        'Change the langauge to Arabic
        If RadAr.Checked = True Then
            ChkVacs.Text = "عدة (VAC bans)"
            ChkGameBans.Text = "عدة (Game bans)"
            Label2.Text = "كم يوم منذ اخر (VAC ban)?"
            Label4.Text = "كم يوم منذ اخر (Game ban)?"
            Label5.Text = "كم يوم منذ اخر ظهور؟"
            Label6.Text = "اللغة"
            BtnCopy.Text = "نسخ"
            BtnNew.Text = "جديد"
            GroupBox2.RightToLeft = RightToLeft.Yes
            GroupBox3.RightToLeft = RightToLeft.Yes
        End If
    End Sub

    Private Sub RadEn_CheckedChanged(sender As Object, e As EventArgs) Handles RadEn.CheckedChanged
        'Change the langauge to English
        If RadEn.Checked = True Then
            ChkVacs.Text = "Multiple VAC bans"
            ChkGameBans.Text = "Multiple Game bans"
            Label2.Text = "Days Since last VAC?"
            Label4.Text = "Days since last gameban?"
            Label5.Text = "Days since last online?"
            Label6.Text = "Language"
            BtnCopy.Text = "Copy"
            BtnNew.Text = "New"
            GroupBox2.RightToLeft = RightToLeft.No
            GroupBox3.RightToLeft = RightToLeft.No
        End If
    End Sub

    Private Sub Txtboxes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGameBansDays.KeyPress, TxtOnlineDays.KeyPress
        'make the textboxes accept numbers only
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txtboxes_Validate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVacDays.TextChanged, TxtOnlineDays.TextChanged, TxtGameBansDays.TextChanged
        'Making sure that the user has provided an input
        If RadVAC.Checked = True Then
            If Not String.IsNullOrWhiteSpace(TxtVacDays.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtOnlineDays.Text) Then
                BtnCopy.Enabled = True
            Else
                BtnCopy.Enabled = False
            End If
        ElseIf RadGameBan.Checked = True Then
            If Not String.IsNullOrWhiteSpace(TxtGameBansDays.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtOnlineDays.Text) Then
                BtnCopy.Enabled = True
            Else
                BtnCopy.Enabled = False
            End If
        ElseIf RadGameVac.Checked = True Then
            If Not String.IsNullOrWhiteSpace(TxtOnlineDays.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtGameBansDays.Text) Then
                BtnCopy.Enabled = True
            Else
                BtnCopy.Enabled = False
            End If
        End If
    End Sub

    Private Sub TxtUrl_TextChanged(sender As Object, e As EventArgs) Handles TxtUrl.TextChanged
        'making sure that the url is correct
        Dim regex As Regex = New Regex("(?:https?:\/\/)?steamcommunity\.com\/(?:profiles|id)\/[a-zA-Z0-9]+")
        Dim match As Match = regex.Match(TxtUrl.Text)
        If Not String.IsNullOrWhiteSpace(TxtUrl.Text) Then
            If match.Success = False Then
                Label1.Visible = True
            Else
                Label1.Visible = False
            End If
        Else
            Label1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        'making sure that everything is working
        Try
            'checking if the checkboxes is checked
            Dim MultiVacs As String
            Dim MultiGameBans As String

            If ChkVacs.Checked = True Then
                MultiVacs = "Multiple VAC bans on record"
            Else
                MultiVacs = "1 VAC ban on record"
            End If
            If ChkGameBans.Checked = True Then
                MultiGameBans = "Multiple game bans on record"
            Else
                MultiGameBans = "1 game ban on record"
            End If
            'checking which radio button is checked
            If RadVAC.Checked = True Then
                VACban(MultiVacs, TxtVacDays.Text, TxtOnlineDays.Text)
            ElseIf RadGameBan.Checked = True Then
                GameBan(MultiGameBans, TxtGameBansDays.Text, TxtOnlineDays.Text)
            ElseIf RadGameVac.Checked = True Then
                VACbanGameban(MultiVacs, TxtGameBansDays.Text, MultiGameBans, TxtOnlineDays.Text)
            End If
            PicCopied.Visible = True
            'opening the link in browser
            If Label1.Visible = False AndAlso Not String.IsNullOrWhiteSpace(TxtUrl.Text) Then
                Process.Start(TxtUrl.Text)
            End If
        Catch ex As Exception
            MsgBox("Ops " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        'Reseting everything
        PicCopied.Visible = False
        ChkGameBans.Checked = False
        TxtGameBansDays.Clear()
        TxtOnlineDays.Clear()
        TxtUrl.Clear()
        TxtVacDays.Clear()
        ChkVacs.Checked = False
    End Sub

    Private Sub VACban(Vacs As String, DaysSince As Integer, LastOnline As Integer)
        'VAC ban only text
        Dim VACbanString As String = "						<div class=""profile_in_game persona offline""> 
					<div class=""profile_in_game_header"">Currently Offline</div>
							<div class=""profile_in_game_name"">Last Online " & LastOnline & " days ago</div>
			</div>
						<div class=""profile_ban_status"">
											<div class=""profile_ban""> 
					" & Vacs & "  					<span class=""profile_ban_info"">| <a class=""whiteLink"" href=""https://support.steampowered.com/kb_article.php?ref=7849-Radz-6869&amp;l=english"" target=""_blank"" rel=""noreferrer"">Info</a></span>
				</div>
									 " & DaysSince & " day(s) since last ban								</div>"
        'copies the text to clipboard
        Clipboard.SetText(VACbanString)
    End Sub
    Private Sub GameBan(GameBans As String, DaysSinceGameBan As Integer, LastOnline As Integer)
        'Game ban only text
        Dim GamebanString As String = "						<div class=""profile_in_game persona offline"">
					<div class=""profile_in_game_header"">Currently Offline</div>
							<div class=""profile_in_game_name"">Last Online " & LastOnline & " days ago</div>
			</div>
						<div class=""profile_ban_status"">
														<div class=""profile_ban"">
					 " & GameBans & " 					<span class=""profile_ban_info"">| <a class=""whiteLink"" href=""https//support.steampowered.com/kb_article.php?ref=6899-IOSK-9514&amp;l=english"" target=""_blank"" rel=""noreferrer"">Info</a></span>
				</div>
						 " & DaysSinceGameBan & " day(s) since last ban								</div>"
        'copies the text to clipboard
        Clipboard.SetText(GamebanString)
    End Sub
    Private Sub VACbanGameban(Vacs As String, DaysSince As Integer, GameBans As String, LastOnline As Integer)
        'Vac & game ban text
        Dim VacGamebanString As String = "						<div class=""profile_in_game persona offline"">
					<div class=""profile_in_game_header"">Currently Offline</div>
							<div class=""profile_in_game_name"">Last Online " & LastOnline & " days ago</div>
			</div>
						<div class=""profile_ban_status"">
											<div class=""profile_ban"">
				 " & Vacs & " 					<span class=""profile_ban_info"">| <a class=""whiteLink"" href=""https//support.steampowered.com/kb_article.php?ref=7849-Radz-6869&amp;l=english"" target=""_blank"" rel=""noreferrer"">Info</a></span>
				</div>
										<div class=""profile_ban"">
				 " & GameBans & " 					<span class=""profile_ban_info"">| <a class=""whiteLink"" href=""https//support.steampowered.com/kb_article.php?ref=6899-IOSK-9514&amp;l=english"" target=""_blank"" rel=""noreferrer"">Info</a></span>
				</div>
						 " & DaysSince & " day(s) since last ban								</div>"
        'copies the text to clipboard
        Clipboard.SetText(VacGamebanString)
    End Sub

End Class
