<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile_ = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCreatedDateTime = New System.Windows.Forms.Label()
        Me.lblCreated = New System.Windows.Forms.Label()
        Me.dtpCreated = New System.Windows.Forms.DateTimePicker()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lblModifiedDateTime = New System.Windows.Forms.Label()
        Me.lblModified = New System.Windows.Forms.Label()
        Me.dtpModified = New System.Windows.Forms.DateTimePicker()
        Me.lblLastAccessedDateTime = New System.Windows.Forms.Label()
        Me.lblLastAccessed = New System.Windows.Forms.Label()
        Me.dtpLastAccessed = New System.Windows.Forms.DateTimePicker()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblSizeF = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(304, 24)
        Me.MenuStrip.TabIndex = 3
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.mnuFile_, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileOpen.Text = "&Open..."
        '
        'mnuFile_
        '
        Me.mnuFile_.Name = "mnuFile_"
        Me.mnuFile_.Size = New System.Drawing.Size(177, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'lblCreatedDateTime
        '
        Me.lblCreatedDateTime.AutoSize = True
        Me.lblCreatedDateTime.Location = New System.Drawing.Point(130, 61)
        Me.lblCreatedDateTime.Name = "lblCreatedDateTime"
        Me.lblCreatedDateTime.Size = New System.Drawing.Size(109, 12)
        Me.lblCreatedDateTime.TabIndex = 7
        Me.lblCreatedDateTime.Text = "----/--/-- --:--:--"
        '
        'lblCreated
        '
        Me.lblCreated.AutoSize = True
        Me.lblCreated.Location = New System.Drawing.Point(12, 61)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(74, 12)
        Me.lblCreated.TabIndex = 6
        Me.lblCreated.Text = "Created Time"
        '
        'dtpCreated
        '
        Me.dtpCreated.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        Me.dtpCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCreated.Location = New System.Drawing.Point(130, 76)
        Me.dtpCreated.Name = "dtpCreated"
        Me.dtpCreated.ShowUpDown = True
        Me.dtpCreated.Size = New System.Drawing.Size(128, 19)
        Me.dtpCreated.TabIndex = 5
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Location = New System.Drawing.Point(12, 27)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(238, 19)
        Me.txtPath.TabIndex = 8
        '
        'lblModifiedDateTime
        '
        Me.lblModifiedDateTime.AutoSize = True
        Me.lblModifiedDateTime.Location = New System.Drawing.Point(130, 109)
        Me.lblModifiedDateTime.Name = "lblModifiedDateTime"
        Me.lblModifiedDateTime.Size = New System.Drawing.Size(109, 12)
        Me.lblModifiedDateTime.TabIndex = 11
        Me.lblModifiedDateTime.Text = "----/--/-- --:--:--"
        '
        'lblModified
        '
        Me.lblModified.AutoSize = True
        Me.lblModified.Location = New System.Drawing.Point(12, 109)
        Me.lblModified.Name = "lblModified"
        Me.lblModified.Size = New System.Drawing.Size(77, 12)
        Me.lblModified.TabIndex = 10
        Me.lblModified.Text = "Modified Time"
        '
        'dtpModified
        '
        Me.dtpModified.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        Me.dtpModified.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpModified.Location = New System.Drawing.Point(130, 124)
        Me.dtpModified.Name = "dtpModified"
        Me.dtpModified.ShowUpDown = True
        Me.dtpModified.Size = New System.Drawing.Size(128, 19)
        Me.dtpModified.TabIndex = 9
        '
        'lblLastAccessedDateTime
        '
        Me.lblLastAccessedDateTime.AutoSize = True
        Me.lblLastAccessedDateTime.Location = New System.Drawing.Point(130, 157)
        Me.lblLastAccessedDateTime.Name = "lblLastAccessedDateTime"
        Me.lblLastAccessedDateTime.Size = New System.Drawing.Size(109, 12)
        Me.lblLastAccessedDateTime.TabIndex = 14
        Me.lblLastAccessedDateTime.Text = "----/--/-- --:--:--"
        '
        'lblLastAccessed
        '
        Me.lblLastAccessed.AutoSize = True
        Me.lblLastAccessed.Location = New System.Drawing.Point(12, 157)
        Me.lblLastAccessed.Name = "lblLastAccessed"
        Me.lblLastAccessed.Size = New System.Drawing.Size(110, 12)
        Me.lblLastAccessed.TabIndex = 13
        Me.lblLastAccessed.Text = "Last Accessed Time"
        '
        'dtpLastAccessed
        '
        Me.dtpLastAccessed.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        Me.dtpLastAccessed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLastAccessed.Location = New System.Drawing.Point(130, 172)
        Me.dtpLastAccessed.Name = "dtpLastAccessed"
        Me.dtpLastAccessed.ShowUpDown = True
        Me.dtpLastAccessed.Size = New System.Drawing.Size(128, 19)
        Me.dtpLastAccessed.TabIndex = 12
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.Location = New System.Drawing.Point(256, 27)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(36, 21)
        Me.btnGo.TabIndex = 15
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(228, 329)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(64, 20)
        Me.btnApply.TabIndex = 16
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(12, 205)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(26, 12)
        Me.lblSize.TabIndex = 17
        Me.lblSize.Text = "Size"
        '
        'lblSizeF
        '
        Me.lblSizeF.AutoSize = True
        Me.lblSizeF.Location = New System.Drawing.Point(130, 205)
        Me.lblSizeF.Name = "lblSizeF"
        Me.lblSizeF.Size = New System.Drawing.Size(117, 12)
        Me.lblSizeF.TabIndex = 18
        Me.lblSizeF.Text = "N/A Bytes (N/A KiB)"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 361)
        Me.Controls.Add(Me.lblSizeF)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblLastAccessedDateTime)
        Me.Controls.Add(Me.lblLastAccessed)
        Me.Controls.Add(Me.dtpLastAccessed)
        Me.Controls.Add(Me.lblModifiedDateTime)
        Me.Controls.Add(Me.lblModified)
        Me.Controls.Add(Me.dtpModified)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblCreatedDateTime)
        Me.Controls.Add(Me.lblCreated)
        Me.Controls.Add(Me.dtpCreated)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Form1"
        Me.Text = "WinFileTimeStampEditor"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFile_ As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents lblCreatedDateTime As Label
    Friend WithEvents lblCreated As Label
    Friend WithEvents dtpCreated As DateTimePicker
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblModifiedDateTime As Label
    Friend WithEvents lblModified As Label
    Friend WithEvents dtpModified As DateTimePicker
    Friend WithEvents lblLastAccessedDateTime As Label
    Friend WithEvents lblLastAccessed As Label
    Friend WithEvents dtpLastAccessed As DateTimePicker
    Friend WithEvents btnGo As Button
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents btnApply As Button
    Friend WithEvents lblSize As Label
    Friend WithEvents lblSizeF As Label
End Class
