<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPNCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPNCalc))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuShowHide = New System.Windows.Forms.MenuItem()
        Me.mnuOptions = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.mnuCopy = New System.Windows.Forms.MenuItem()
        Me.mnuPaste = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.mnuFixed = New System.Windows.Forms.MenuItem()
        Me.mnuScientific = New System.Windows.Forms.MenuItem()
        Me.mnuEngineering = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.mnuAlwaysOnTop = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblStarted = New System.Windows.Forms.Label()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(8, 128)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(184, 20)
        Me.TextBox2.TabIndex = 28
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "TextBox2"
        '
        'TextBox1
        '
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.Location = New System.Drawing.Point(8, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 26
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "TextBox1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "X"
        '
        'lblY
        '
        Me.lblY.Location = New System.Drawing.Point(32, 40)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(176, 16)
        Me.lblY.TabIndex = 23
        Me.lblY.Text = " lblY"
        '
        'lblZ
        '
        Me.lblZ.Location = New System.Drawing.Point(32, 24)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(176, 16)
        Me.lblZ.TabIndex = 21
        Me.lblZ.Text = " lblZ"
        '
        'lblT
        '
        Me.lblT.Location = New System.Drawing.Point(32, 8)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(176, 16)
        Me.lblT.TabIndex = 19
        Me.lblT.Text = " lblT"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Y"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Z"
        '
        'lblX
        '
        Me.lblX.Location = New System.Drawing.Point(32, 56)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(176, 16)
        Me.lblX.TabIndex = 17
        Me.lblX.Text = " lblX"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "T"
        '
        'picDisplay
        '
        Me.picDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDisplay.ContextMenu = Me.ContextMenu1
        Me.picDisplay.Location = New System.Drawing.Point(7, 8)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(200, 24)
        Me.picDisplay.TabIndex = 30
        Me.picDisplay.TabStop = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelp, Me.mnuShowHide, Me.mnuOptions, Me.MenuItem5, Me.mnuCopy, Me.mnuPaste, Me.MenuItem6, Me.mnuFixed, Me.mnuScientific, Me.mnuEngineering, Me.MenuItem2, Me.mnuAlwaysOnTop, Me.MenuItem1, Me.mnuExit})
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 0
        Me.mnuHelp.Text = "Help"
        '
        'mnuShowHide
        '
        Me.mnuShowHide.Index = 1
        Me.mnuShowHide.Text = "Show / Hide"
        '
        'mnuOptions
        '
        Me.mnuOptions.Index = 2
        Me.mnuOptions.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.mnuOptions.Text = "Options"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "-"
        '
        'mnuCopy
        '
        Me.mnuCopy.Index = 4
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Index = 5
        Me.mnuPaste.Text = "Paste"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Text = "-"
        '
        'mnuFixed
        '
        Me.mnuFixed.Index = 7
        Me.mnuFixed.Text = "Fixed..."
        '
        'mnuScientific
        '
        Me.mnuScientific.Index = 8
        Me.mnuScientific.Text = "Scientific..."
        '
        'mnuEngineering
        '
        Me.mnuEngineering.Index = 9
        Me.mnuEngineering.Text = "Engineering..."
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 10
        Me.MenuItem2.Text = "-"
        '
        'mnuAlwaysOnTop
        '
        Me.mnuAlwaysOnTop.Index = 11
        Me.mnuAlwaysOnTop.Text = "Always on top"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 12
        Me.MenuItem1.Text = "-"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 13
        Me.mnuExit.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblY)
        Me.Panel1.Controls.Add(Me.lblZ)
        Me.Panel1.Controls.Add(Me.lblT)
        Me.Panel1.Controls.Add(Me.lblX)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblVersion)
        Me.Panel1.Controls.Add(Me.lblStarted)
        Me.Panel1.Location = New System.Drawing.Point(1, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 216)
        Me.Panel1.TabIndex = 31
        '
        'lblVersion
        '
        Me.lblVersion.Location = New System.Drawing.Point(136, 184)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(72, 23)
        Me.lblVersion.TabIndex = 18
        Me.lblVersion.Text = "lblVersion"
        '
        'lblStarted
        '
        Me.lblStarted.Location = New System.Drawing.Point(8, 153)
        Me.lblStarted.Name = "lblStarted"
        Me.lblStarted.Size = New System.Drawing.Size(146, 23)
        Me.lblStarted.TabIndex = 18
        Me.lblStarted.Text = "Started 0 times"
        '
        'frmRPNCalc
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(213, 41)
        Me.Controls.Add(Me.picDisplay)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRPNCalc"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "frmRPNCalc"
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lblY As Windows.Forms.Label
    Friend WithEvents lblZ As Windows.Forms.Label
    Friend WithEvents lblT As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents lblX As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents picDisplay As Windows.Forms.PictureBox
    Friend WithEvents ContextMenu1 As Windows.Forms.ContextMenu
    Friend WithEvents mnuHelp As Windows.Forms.MenuItem
    Friend WithEvents mnuShowHide As Windows.Forms.MenuItem
    Friend WithEvents mnuOptions As Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As Windows.Forms.MenuItem
    Friend WithEvents mnuCopy As Windows.Forms.MenuItem
    Friend WithEvents mnuPaste As Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As Windows.Forms.MenuItem
    Friend WithEvents mnuFixed As Windows.Forms.MenuItem
    Friend WithEvents mnuScientific As Windows.Forms.MenuItem
    Friend WithEvents mnuEngineering As Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As Windows.Forms.MenuItem
    Friend WithEvents mnuAlwaysOnTop As Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As Windows.Forms.MenuItem
    Friend WithEvents mnuExit As Windows.Forms.MenuItem
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents lblVersion As Windows.Forms.Label
    Friend WithEvents lblStarted As Windows.Forms.Label
End Class
