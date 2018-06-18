<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RadVAC = New System.Windows.Forms.RadioButton()
        Me.RadGameBan = New System.Windows.Forms.RadioButton()
        Me.RadGameVac = New System.Windows.Forms.RadioButton()
        Me.TxtVacDays = New System.Windows.Forms.TextBox()
        Me.TxtOnlineDays = New System.Windows.Forms.TextBox()
        Me.TxtGameBansDays = New System.Windows.Forms.TextBox()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PicCopied = New System.Windows.Forms.PictureBox()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnHelp = New System.Windows.Forms.Button()
        Me.ChkGameBans = New System.Windows.Forms.CheckBox()
        Me.ChkVacs = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadEn = New System.Windows.Forms.RadioButton()
        Me.RadAr = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtUrl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicCopied, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadVAC
        '
        Me.RadVAC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadVAC.AutoSize = True
        Me.RadVAC.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RadVAC.Location = New System.Drawing.Point(21, 23)
        Me.RadVAC.Name = "RadVAC"
        Me.RadVAC.Size = New System.Drawing.Size(94, 25)
        Me.RadVAC.TabIndex = 0
        Me.RadVAC.TabStop = True
        Me.RadVAC.Text = "VAC ban"
        Me.RadVAC.UseVisualStyleBackColor = True
        '
        'RadGameBan
        '
        Me.RadGameBan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadGameBan.AutoSize = True
        Me.RadGameBan.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RadGameBan.Location = New System.Drawing.Point(21, 53)
        Me.RadGameBan.Name = "RadGameBan"
        Me.RadGameBan.Size = New System.Drawing.Size(106, 25)
        Me.RadGameBan.TabIndex = 1
        Me.RadGameBan.TabStop = True
        Me.RadGameBan.Text = "Game ban"
        Me.RadGameBan.UseVisualStyleBackColor = True
        '
        'RadGameVac
        '
        Me.RadGameVac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadGameVac.AutoSize = True
        Me.RadGameVac.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RadGameVac.Location = New System.Drawing.Point(21, 83)
        Me.RadGameVac.Name = "RadGameVac"
        Me.RadGameVac.Size = New System.Drawing.Size(158, 25)
        Me.RadGameVac.TabIndex = 2
        Me.RadGameVac.TabStop = True
        Me.RadGameVac.Text = "VAC && Game ban"
        Me.RadGameVac.UseVisualStyleBackColor = True
        '
        'TxtVacDays
        '
        Me.TxtVacDays.Enabled = False
        Me.TxtVacDays.Location = New System.Drawing.Point(14, 82)
        Me.TxtVacDays.Name = "TxtVacDays"
        Me.TxtVacDays.Size = New System.Drawing.Size(49, 24)
        Me.TxtVacDays.TabIndex = 4
        '
        'TxtOnlineDays
        '
        Me.TxtOnlineDays.Enabled = False
        Me.TxtOnlineDays.Location = New System.Drawing.Point(14, 138)
        Me.TxtOnlineDays.Name = "TxtOnlineDays"
        Me.TxtOnlineDays.Size = New System.Drawing.Size(49, 24)
        Me.TxtOnlineDays.TabIndex = 5
        '
        'TxtGameBansDays
        '
        Me.TxtGameBansDays.Enabled = False
        Me.TxtGameBansDays.Location = New System.Drawing.Point(205, 81)
        Me.TxtGameBansDays.Name = "TxtGameBansDays"
        Me.TxtGameBansDays.Size = New System.Drawing.Size(49, 24)
        Me.TxtGameBansDays.TabIndex = 6
        '
        'BtnCopy
        '
        Me.BtnCopy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCopy.AutoSize = True
        Me.BtnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnCopy.Enabled = False
        Me.BtnCopy.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnCopy.Location = New System.Drawing.Point(54, 9)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(56, 31)
        Me.BtnCopy.TabIndex = 8
        Me.BtnCopy.Text = "Copy"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Days Since last VAC?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(201, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Days since last gameban?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(10, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Days since last online?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadGameBan)
        Me.GroupBox1.Controls.Add(Me.RadVAC)
        Me.GroupBox1.Controls.Add(Me.RadGameVac)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 124)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PicCopied)
        Me.GroupBox2.Controls.Add(Me.BtnNew)
        Me.GroupBox2.Controls.Add(Me.BtnCopy)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 43)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'PicCopied
        '
        Me.PicCopied.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCopied.Image = CType(resources.GetObject("PicCopied.Image"), System.Drawing.Image)
        Me.PicCopied.Location = New System.Drawing.Point(12, 9)
        Me.PicCopied.Name = "PicCopied"
        Me.PicCopied.Size = New System.Drawing.Size(32, 31)
        Me.PicCopied.TabIndex = 10
        Me.PicCopied.TabStop = False
        Me.PicCopied.Visible = False
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNew.AutoSize = True
        Me.BtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnNew.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.BtnNew.Location = New System.Drawing.Point(117, 9)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(53, 31)
        Me.BtnNew.TabIndex = 9
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnHelp)
        Me.GroupBox3.Controls.Add(Me.ChkGameBans)
        Me.GroupBox3.Controls.Add(Me.ChkVacs)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.RadEn)
        Me.GroupBox3.Controls.Add(Me.RadAr)
        Me.GroupBox3.Controls.Add(Me.TxtGameBansDays)
        Me.GroupBox3.Controls.Add(Me.TxtOnlineDays)
        Me.GroupBox3.Controls.Add(Me.TxtVacDays)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(242, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(410, 170)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'BtnHelp
        '
        Me.BtnHelp.BackColor = System.Drawing.Color.Transparent
        Me.BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHelp.FlatAppearance.BorderSize = 0
        Me.BtnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHelp.ForeColor = System.Drawing.Color.Black
        Me.BtnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHelp.Location = New System.Drawing.Point(372, 132)
        Me.BtnHelp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnHelp.Size = New System.Drawing.Size(37, 36)
        Me.BtnHelp.TabIndex = 21
        Me.BtnHelp.Text = "?"
        Me.BtnHelp.UseVisualStyleBackColor = False
        '
        'ChkGameBans
        '
        Me.ChkGameBans.AutoSize = True
        Me.ChkGameBans.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ChkGameBans.Location = New System.Drawing.Point(205, 22)
        Me.ChkGameBans.Name = "ChkGameBans"
        Me.ChkGameBans.Size = New System.Drawing.Size(178, 25)
        Me.ChkGameBans.TabIndex = 20
        Me.ChkGameBans.Text = "Multiple Game bans"
        Me.ChkGameBans.UseVisualStyleBackColor = True
        '
        'ChkVacs
        '
        Me.ChkVacs.AutoSize = True
        Me.ChkVacs.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ChkVacs.Location = New System.Drawing.Point(14, 23)
        Me.ChkVacs.Name = "ChkVacs"
        Me.ChkVacs.Size = New System.Drawing.Size(166, 25)
        Me.ChkVacs.TabIndex = 19
        Me.ChkVacs.Text = "Multiple VAC bans"
        Me.ChkVacs.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(201, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Language"
        '
        'RadEn
        '
        Me.RadEn.AutoSize = True
        Me.RadEn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RadEn.Location = New System.Drawing.Point(281, 132)
        Me.RadEn.Name = "RadEn"
        Me.RadEn.Size = New System.Drawing.Size(52, 25)
        Me.RadEn.TabIndex = 17
        Me.RadEn.TabStop = True
        Me.RadEn.Text = "EN"
        Me.RadEn.UseVisualStyleBackColor = True
        '
        'RadAr
        '
        Me.RadAr.AutoSize = True
        Me.RadAr.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RadAr.Location = New System.Drawing.Point(205, 132)
        Me.RadAr.Name = "RadAr"
        Me.RadAr.Size = New System.Drawing.Size(53, 25)
        Me.RadAr.TabIndex = 16
        Me.RadAr.TabStop = True
        Me.RadAr.Text = "AR"
        Me.RadAr.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TxtUrl)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(635, 43)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(8, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Profile URL :"
        '
        'TxtUrl
        '
        Me.TxtUrl.Location = New System.Drawing.Point(116, 13)
        Me.TxtUrl.Name = "TxtUrl"
        Me.TxtUrl.Size = New System.Drawing.Size(513, 24)
        Me.TxtUrl.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(534, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Invalid URL"
        Me.Label1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 226)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Fake VAC creator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PicCopied, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadVAC As RadioButton
    Friend WithEvents RadGameBan As RadioButton
    Friend WithEvents RadGameVac As RadioButton
    Friend WithEvents TxtVacDays As TextBox
    Friend WithEvents TxtOnlineDays As TextBox
    Friend WithEvents TxtGameBansDays As TextBox
    Friend WithEvents BtnCopy As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadEn As RadioButton
    Friend WithEvents RadAr As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtUrl As TextBox
    Friend WithEvents BtnNew As Button
    Friend WithEvents ChkGameBans As CheckBox
    Friend WithEvents ChkVacs As CheckBox
    Friend WithEvents PicCopied As PictureBox
    Friend WithEvents BtnHelp As Button
    Friend WithEvents Label1 As Label
End Class
