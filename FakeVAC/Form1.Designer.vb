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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.TxtVacDays = New System.Windows.Forms.TextBox()
        Me.TxtOnlineDays = New System.Windows.Forms.TextBox()
        Me.TxtGameBansDays = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PicCopied = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChkGameBans = New System.Windows.Forms.CheckBox()
        Me.ChkVacs = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtUrl = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicCopied, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(21, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(94, 25)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "VAC ban"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(21, 53)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(106, 25)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Game ban"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RadioButton3.Location = New System.Drawing.Point(21, 83)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(158, 25)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "VAC && Game ban"
        Me.RadioButton3.UseVisualStyleBackColor = True
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
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(54, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Copy"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 124)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PicCopied)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
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
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.AutoSize = True
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(117, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 31)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChkGameBans)
        Me.GroupBox3.Controls.Add(Me.ChkVacs)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
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
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RadioButton5.Location = New System.Drawing.Point(281, 132)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(52, 25)
        Me.RadioButton5.TabIndex = 17
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "EN"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RadioButton4.Location = New System.Drawing.Point(205, 132)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(53, 25)
        Me.RadioButton4.TabIndex = 16
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "AR"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
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
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents TxtVacDays As TextBox
    Friend WithEvents TxtOnlineDays As TextBox
    Friend WithEvents TxtGameBansDays As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtUrl As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ChkGameBans As CheckBox
    Friend WithEvents ChkVacs As CheckBox
    Friend WithEvents PicCopied As PictureBox
End Class
