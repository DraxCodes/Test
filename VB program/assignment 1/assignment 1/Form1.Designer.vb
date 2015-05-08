<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblName = New System.Windows.Forms.Label
        Me.txtbPass = New System.Windows.Forms.TextBox
        Me.lblPass = New System.Windows.Forms.Label
        Me.lblMerit = New System.Windows.Forms.Label
        Me.lblDistinctions = New System.Windows.Forms.Label
        Me.txtbMerit = New System.Windows.Forms.TextBox
        Me.txtbDist = New System.Windows.Forms.TextBox
        Me.lblGradeTxt = New System.Windows.Forms.Label
        Me.lblResult = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.lblRemainingtxt = New System.Windows.Forms.Label
        Me.lblRemaining = New System.Windows.Forms.Label
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(9, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(476, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.QuitToolStripMenuItem.AutoSize = False
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(4, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(487, 29)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "LEVEL 3 BTEC GRADING CALCULATOR"
        '
        'txtbPass
        '
        Me.txtbPass.Location = New System.Drawing.Point(30, 106)
        Me.txtbPass.Name = "txtbPass"
        Me.txtbPass.Size = New System.Drawing.Size(140, 20)
        Me.txtbPass.TabIndex = 2
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(27, 85)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(110, 18)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Nº Of Passes"
        '
        'lblMerit
        '
        Me.lblMerit.AutoSize = True
        Me.lblMerit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerit.Location = New System.Drawing.Point(27, 140)
        Me.lblMerit.Name = "lblMerit"
        Me.lblMerit.Size = New System.Drawing.Size(101, 18)
        Me.lblMerit.TabIndex = 4
        Me.lblMerit.Text = "Nº Of Merits"
        '
        'lblDistinctions
        '
        Me.lblDistinctions.AutoSize = True
        Me.lblDistinctions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistinctions.Location = New System.Drawing.Point(27, 213)
        Me.lblDistinctions.Name = "lblDistinctions"
        Me.lblDistinctions.Size = New System.Drawing.Size(134, 18)
        Me.lblDistinctions.TabIndex = 5
        Me.lblDistinctions.Text = "Nº Of Distinction"
        '
        'txtbMerit
        '
        Me.txtbMerit.Location = New System.Drawing.Point(30, 161)
        Me.txtbMerit.Name = "txtbMerit"
        Me.txtbMerit.Size = New System.Drawing.Size(140, 20)
        Me.txtbMerit.TabIndex = 6
        '
        'txtbDist
        '
        Me.txtbDist.Location = New System.Drawing.Point(30, 234)
        Me.txtbDist.Name = "txtbDist"
        Me.txtbDist.Size = New System.Drawing.Size(140, 20)
        Me.txtbDist.TabIndex = 7
        '
        'lblGradeTxt
        '
        Me.lblGradeTxt.AutoSize = True
        Me.lblGradeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeTxt.Location = New System.Drawing.Point(253, 131)
        Me.lblGradeTxt.Name = "lblGradeTxt"
        Me.lblGradeTxt.Size = New System.Drawing.Size(108, 16)
        Me.lblGradeTxt.TabIndex = 8
        Me.lblGradeTxt.Text = "Current Grade:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(367, 131)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(90, 16)
        Me.lblResult.TabIndex = 9
        Me.lblResult.Text = "Not Entered"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(256, 161)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "neutral.png")
        Me.imgList.Images.SetKeyName(1, "smiley.png")
        Me.imgList.Images.SetKeyName(2, "happy.png")
        Me.imgList.Images.SetKeyName(3, "likeasir.jpg")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(30, 274)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(140, 36)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblRemainingtxt
        '
        Me.lblRemainingtxt.AutoSize = True
        Me.lblRemainingtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingtxt.Location = New System.Drawing.Point(181, 85)
        Me.lblRemainingtxt.Name = "lblRemainingtxt"
        Me.lblRemainingtxt.Size = New System.Drawing.Size(250, 18)
        Me.lblRemainingtxt.TabIndex = 12
        Me.lblRemainingtxt.Text = "Not enough entered. Remaining:"
        Me.lblRemainingtxt.Visible = False
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.Location = New System.Drawing.Point(437, 87)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(16, 16)
        Me.lblRemaining.TabIndex = 13
        Me.lblRemaining.Text = "0"
        Me.lblRemaining.Visible = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 332)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.lblRemainingtxt)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblGradeTxt)
        Me.Controls.Add(Me.txtbDist)
        Me.Controls.Add(Me.txtbMerit)
        Me.Controls.Add(Me.lblDistinctions)
        Me.Controls.Add(Me.lblMerit)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtbPass)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "form1"
        Me.Text = "BTEC Grading Calculator"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtbPass As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblMerit As System.Windows.Forms.Label
    Friend WithEvents lblDistinctions As System.Windows.Forms.Label
    Friend WithEvents txtbMerit As System.Windows.Forms.TextBox
    Friend WithEvents txtbDist As System.Windows.Forms.TextBox
    Friend WithEvents lblGradeTxt As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblRemainingtxt As System.Windows.Forms.Label
    Friend WithEvents lblRemaining As System.Windows.Forms.Label

End Class
