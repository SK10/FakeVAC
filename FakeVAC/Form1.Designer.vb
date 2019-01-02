<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.radVac = New System.Windows.Forms.RadioButton()
        Me.radGameBan = New System.Windows.Forms.RadioButton()
        Me.radGameVac = New System.Windows.Forms.RadioButton()
        Me.txtVacDays = New System.Windows.Forms.TextBox()
        Me.txtOnlineDays = New System.Windows.Forms.TextBox()
        Me.txtGameBansDays = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picLoading = New System.Windows.Forms.PictureBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.chkGameBans = New System.Windows.Forms.CheckBox()
        Me.chkVacs = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'radVac
        '
        Me.radVac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radVac.AutoSize = True
        Me.radVac.Enabled = False
        Me.radVac.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.radVac.Location = New System.Drawing.Point(21, 23)
        Me.radVac.Name = "radVac"
        Me.radVac.Size = New System.Drawing.Size(94, 25)
        Me.radVac.TabIndex = 0
        Me.radVac.TabStop = True
        Me.radVac.Text = "VAC ban"
        Me.radVac.UseVisualStyleBackColor = True
        '
        'radGameBan
        '
        Me.radGameBan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radGameBan.AutoSize = True
        Me.radGameBan.Enabled = False
        Me.radGameBan.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.radGameBan.Location = New System.Drawing.Point(21, 53)
        Me.radGameBan.Name = "radGameBan"
        Me.radGameBan.Size = New System.Drawing.Size(106, 25)
        Me.radGameBan.TabIndex = 1
        Me.radGameBan.TabStop = True
        Me.radGameBan.Text = "Game ban"
        Me.radGameBan.UseVisualStyleBackColor = True
        '
        'radGameVac
        '
        Me.radGameVac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radGameVac.AutoSize = True
        Me.radGameVac.Enabled = False
        Me.radGameVac.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.radGameVac.Location = New System.Drawing.Point(21, 83)
        Me.radGameVac.Name = "radGameVac"
        Me.radGameVac.Size = New System.Drawing.Size(158, 25)
        Me.radGameVac.TabIndex = 2
        Me.radGameVac.TabStop = True
        Me.radGameVac.Text = "VAC && Game ban"
        Me.radGameVac.UseVisualStyleBackColor = True
        '
        'txtVacDays
        '
        Me.txtVacDays.Enabled = False
        Me.txtVacDays.Location = New System.Drawing.Point(14, 82)
        Me.txtVacDays.Name = "txtVacDays"
        Me.txtVacDays.Size = New System.Drawing.Size(49, 24)
        Me.txtVacDays.TabIndex = 4
        '
        'txtOnlineDays
        '
        Me.txtOnlineDays.Enabled = False
        Me.txtOnlineDays.Location = New System.Drawing.Point(14, 138)
        Me.txtOnlineDays.Name = "txtOnlineDays"
        Me.txtOnlineDays.Size = New System.Drawing.Size(49, 24)
        Me.txtOnlineDays.TabIndex = 5
        '
        'txtGameBansDays
        '
        Me.txtGameBansDays.Enabled = False
        Me.txtGameBansDays.Location = New System.Drawing.Point(205, 81)
        Me.txtGameBansDays.Name = "txtGameBansDays"
        Me.txtGameBansDays.Size = New System.Drawing.Size(49, 24)
        Me.txtGameBansDays.TabIndex = 6
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStart.AutoSize = True
        Me.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnStart.Enabled = False
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnStart.Location = New System.Drawing.Point(21, 13)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(56, 31)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Days since last VAC?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(201, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Days since last Gameban?"
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
        Me.GroupBox1.Controls.Add(Me.radGameBan)
        Me.GroupBox1.Controls.Add(Me.radVac)
        Me.GroupBox1.Controls.Add(Me.radGameVac)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 124)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picLoading)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Controls.Add(Me.btnStart)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 50)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'picLoading
        '
        Me.picLoading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLoading.Image = CType(resources.GetObject("picLoading.Image"), System.Drawing.Image)
        Me.picLoading.Location = New System.Drawing.Point(181, 13)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(32, 31)
        Me.picLoading.TabIndex = 10
        Me.picLoading.TabStop = False
        Me.picLoading.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNew.AutoSize = True
        Me.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnNew.Location = New System.Drawing.Point(100, 13)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(53, 31)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnHelp)
        Me.GroupBox3.Controls.Add(Me.chkGameBans)
        Me.GroupBox3.Controls.Add(Me.chkVacs)
        Me.GroupBox3.Controls.Add(Me.txtGameBansDays)
        Me.GroupBox3.Controls.Add(Me.txtOnlineDays)
        Me.GroupBox3.Controls.Add(Me.txtVacDays)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(242, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(410, 173)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.Black
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(372, 132)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnHelp.Size = New System.Drawing.Size(37, 36)
        Me.btnHelp.TabIndex = 21
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'chkGameBans
        '
        Me.chkGameBans.AutoSize = True
        Me.chkGameBans.Enabled = False
        Me.chkGameBans.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.chkGameBans.Location = New System.Drawing.Point(205, 22)
        Me.chkGameBans.Name = "chkGameBans"
        Me.chkGameBans.Size = New System.Drawing.Size(173, 25)
        Me.chkGameBans.TabIndex = 20
        Me.chkGameBans.Text = "Multiple Gamebans"
        Me.chkGameBans.UseVisualStyleBackColor = True
        '
        'chkVacs
        '
        Me.chkVacs.AutoSize = True
        Me.chkVacs.Enabled = False
        Me.chkVacs.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.chkVacs.Location = New System.Drawing.Point(14, 23)
        Me.chkVacs.Name = "chkVacs"
        Me.chkVacs.Size = New System.Drawing.Size(166, 25)
        Me.chkVacs.TabIndex = 19
        Me.chkVacs.Text = "Multiple VAC bans"
        Me.chkVacs.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtUrl)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(635, 43)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
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
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(116, 13)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(513, 24)
        Me.txtUrl.TabIndex = 0
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 231)
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
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents radVac As RadioButton
    Friend WithEvents radGameBan As RadioButton
    Friend WithEvents radGameVac As RadioButton
    Friend WithEvents txtVacDays As TextBox
    Friend WithEvents txtOnlineDays As TextBox
    Friend WithEvents txtGameBansDays As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents chkGameBans As CheckBox
    Friend WithEvents chkVacs As CheckBox
    Friend WithEvents picLoading As PictureBox
    Friend WithEvents btnHelp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
