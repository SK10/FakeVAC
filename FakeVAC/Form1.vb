Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
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

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
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

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
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

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ChkVacs.Text = "عدة (VAC bans)"
            ChkGameBans.Text = "عدة (Game bans)"
            Label2.Text = "كم يوم منذ اخر (VAC ban)?"
            Label4.Text = "كم يوم منذ اخر (Game ban)?"
            Label5.Text = "كم يوم منذ اخر ظهور؟"
            Label6.Text = "اللغة"
            Button1.Text = "نسخ"
            Button2.Text = "جديد"
            GroupBox2.RightToLeft = RightToLeft.Yes
            GroupBox3.RightToLeft = RightToLeft.Yes

        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            ChkVacs.Text = "Multiple VAC bans"
            ChkGameBans.Text = "Multiple Game bans"
            Label2.Text = "Days Since last VAC?"
            Label4.Text = "Days since last gameban?"
            Label5.Text = "Days since last online?"
            Label6.Text = "Language"
            Button1.Text = "Copy"
            Button2.Text = "New"
            GroupBox2.RightToLeft = RightToLeft.No
            GroupBox3.RightToLeft = RightToLeft.No
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RadioButton5.Checked = True
    End Sub
    Private Sub Txtboxes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGameBansDays.KeyPress, TxtOnlineDays.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TextBox_Validate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVacDays.TextChanged, TxtOnlineDays.TextChanged, TxtGameBansDays.TextChanged
        If RadioButton1.Checked = True Then
            If Not String.IsNullOrWhiteSpace(TxtVacDays.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtOnlineDays.Text) Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        ElseIf RadioButton2.Checked = True Then
            If Not String.IsNullOrWhiteSpace(TxtGameBansDays.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtOnlineDays.Text) Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        ElseIf RadioButton3.Checked = True Then
            If Not String.IsNullOrWhiteSpace(TxtOnlineDays.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtGameBansDays.Text) Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        End If


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PicCopied.Visible = False
        ChkGameBans.Checked = False
        TxtGameBansDays.Clear()
        TxtOnlineDays.Clear()
        TxtUrl.Clear()
        TxtVacDays.Clear()
        ChkVacs.Checked = False
    End Sub
    Private Sub VACban(Vacs As String, DaysSince As Integer, LastOnline As Integer)
        Dim VACbanString As String = "						<div class=""profile_in_game persona offline""> 
					<div class=""profile_in_game_header"">Currently Offline</div>
							<div class=""profile_in_game_name"">Last Online " & LastOnline & " days ago</div>
			</div>
						<div class=""profile_ban_status"">
											<div class=""profile_ban""> 
					" & Vacs & "  					<span class=""profile_ban_info"">| <a class=""whiteLink"" href=""https://support.steampowered.com/kb_article.php?ref=7849-Radz-6869&amp;l=english"" target=""_blank"" rel=""noreferrer"">Info</a></span>
				</div>
									 " & DaysSince & " day(s) since last ban								</div>"
        Clipboard.SetText(VACbanString)
    End Sub
    Private Sub GameBan(GameBans As String, DaysSinceGameBan As Integer, LastOnline As Integer)
        Dim GamebanString As String = "						<div class=""profile_in_game persona offline"">
					<div class=""profile_in_game_header"">Currently Offline</div>
							<div class=""profile_in_game_name"">Last Online " & LastOnline & " days ago</div>
			</div>
						<div class=""profile_ban_status"">
														<div class=""profile_ban"">
					 " & GameBans & " 					<span class=""profile_ban_info"">| <a class=""whiteLink"" href=""https//support.steampowered.com/kb_article.php?ref=6899-IOSK-9514&amp;l=english"" target=""_blank"" rel=""noreferrer"">Info</a></span>
				</div>
						 " & DaysSinceGameBan & " day(s) since last ban								</div>"
        Clipboard.SetText(GamebanString)
    End Sub
    Private Sub VACbanGameban(Vacs As String, DaysSince As Integer, GameBans As String, LastOnline As Integer)
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
        Clipboard.SetText(VacGamebanString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
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
            If RadioButton1.Checked = True Then
                VACban(MultiVacs, TxtVacDays.Text, TxtOnlineDays.Text)
            ElseIf RadioButton2.Checked = True Then
                GameBan(MultiGameBans, TxtGameBansDays.Text, TxtOnlineDays.Text)
            ElseIf RadioButton3.Checked = True Then
                VACbanGameban(MultiVacs, TxtGameBansDays.Text, MultiGameBans, TxtOnlineDays.Text)
            End If
            PicCopied.Visible = True
        Catch ex As Exception

        End Try

    End Sub
End Class
