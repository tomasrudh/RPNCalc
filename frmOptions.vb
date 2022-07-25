Imports System.Windows.Forms

Public Class frmOptions
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents chkOnTop As System.Windows.Forms.CheckBox
    Friend WithEvents butCancel As System.Windows.Forms.Button
    Friend WithEvents butOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radDegrees As System.Windows.Forms.RadioButton
    Friend WithEvents radRadians As System.Windows.Forms.RadioButton
    Friend WithEvents comNumDec As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radFix As System.Windows.Forms.RadioButton
    Friend WithEvents radSci As System.Windows.Forms.RadioButton
    Friend WithEvents radEng As System.Windows.Forms.RadioButton
    Friend WithEvents txtExample As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.chkOnTop = New System.Windows.Forms.CheckBox
        Me.butCancel = New System.Windows.Forms.Button
        Me.butOK = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtExample = New System.Windows.Forms.TextBox
        Me.radEng = New System.Windows.Forms.RadioButton
        Me.radSci = New System.Windows.Forms.RadioButton
        Me.radFix = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.comNumDec = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.radRadians = New System.Windows.Forms.RadioButton
        Me.radDegrees = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkOnTop
        '
        Me.chkOnTop.Location = New System.Drawing.Point(8, 112)
        Me.chkOnTop.Name = "chkOnTop"
        Me.chkOnTop.Size = New System.Drawing.Size(96, 24)
        Me.chkOnTop.TabIndex = 0
        Me.chkOnTop.Text = "Always on top"
        '
        'butCancel
        '
        Me.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancel.Location = New System.Drawing.Point(184, 112)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(75, 23)
        Me.butCancel.TabIndex = 2
        Me.butCancel.Text = "Cancel"
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(104, 112)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(75, 23)
        Me.butOK.TabIndex = 3
        Me.butOK.Text = "OK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtExample)
        Me.GroupBox1.Controls.Add(Me.radEng)
        Me.GroupBox1.Controls.Add(Me.radSci)
        Me.GroupBox1.Controls.Add(Me.radFix)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.comNumDec)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 96)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'txtExample
        '
        Me.txtExample.BackColor = System.Drawing.Color.PaleGreen
        Me.txtExample.Location = New System.Drawing.Point(104, 56)
        Me.txtExample.Name = "txtExample"
        Me.txtExample.ReadOnly = True
        Me.txtExample.Size = New System.Drawing.Size(100, 20)
        Me.txtExample.TabIndex = 11
        Me.txtExample.Text = "txtExample"
        '
        'radEng
        '
        Me.radEng.Location = New System.Drawing.Point(8, 72)
        Me.radEng.Name = "radEng"
        Me.radEng.Size = New System.Drawing.Size(88, 16)
        Me.radEng.TabIndex = 10
        Me.radEng.Text = "Engineering"
        '
        'radSci
        '
        Me.radSci.Location = New System.Drawing.Point(8, 56)
        Me.radSci.Name = "radSci"
        Me.radSci.Size = New System.Drawing.Size(88, 16)
        Me.radSci.TabIndex = 9
        Me.radSci.Text = "Scientific"
        '
        'radFix
        '
        Me.radFix.Location = New System.Drawing.Point(8, 40)
        Me.radFix.Name = "radFix"
        Me.radFix.Size = New System.Drawing.Size(88, 16)
        Me.radFix.TabIndex = 8
        Me.radFix.Text = "Fixed"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of Decimals"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'comNumDec
        '
        Me.comNumDec.FormattingEnabled = True
        Me.comNumDec.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.comNumDec.Location = New System.Drawing.Point(120, 16)
        Me.comNumDec.Name = "comNumDec"
        Me.comNumDec.Size = New System.Drawing.Size(64, 21)
        Me.comNumDec.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radRadians)
        Me.GroupBox2.Controls.Add(Me.radDegrees)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 56)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Angles"
        '
        'radRadians
        '
        Me.radRadians.Location = New System.Drawing.Point(8, 32)
        Me.radRadians.Name = "radRadians"
        Me.radRadians.Size = New System.Drawing.Size(72, 16)
        Me.radRadians.TabIndex = 1
        Me.radRadians.Text = "Radians"
        '
        'radDegrees
        '
        Me.radDegrees.Location = New System.Drawing.Point(8, 16)
        Me.radDegrees.Name = "radDegrees"
        Me.radDegrees.Size = New System.Drawing.Size(72, 16)
        Me.radDegrees.TabIndex = 0
        Me.radDegrees.Text = "Degrees"
        '
        'frmOptions
        '
        Me.CancelButton = Me.butCancel
        Me.ClientSize = New System.Drawing.Size(272, 142)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.chkOnTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOptions"
        Me.Text = "RPNCalc Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub butCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancel.Click
        Me.Close()
    End Sub

    Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
        NumDec = comNumDec.SelectedIndex
        If radFix.Checked = True Then DispMode = Disp.Fix
        If radSci.Checked = True Then DispMode = Disp.Sci
        If radEng.Checked = True Then DispMode = Disp.Eng
        If radDegrees.Checked = True Then AngleMode = Angle.Deg
        If radRadians.Checked = True Then AngleMode = Angle.Rad
        AlwaysOnTop = chkOnTop.CheckState
        If chkOnTop.CheckState = CheckState.Checked Then
            AlwaysOnTop = True
        Else
            AlwaysOnTop = False
        End If
        ShowX()
        Me.Close()
    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        comNumDec.SelectedIndex = NumDec
        Select Case DispMode
            Case Disp.Fix
                radFix.Checked = True
            Case Disp.Sci
                radSci.Checked = True
            Case Disp.Eng
                radEng.Checked = True
        End Select
        Select Case AngleMode
            Case Angle.Deg
                radDegrees.Checked = True
            Case Angle.Rad
                radRadians.Checked = True
        End Select
        If AlwaysOnTop = True Then chkOnTop.CheckState = CheckState.Checked
    End Sub

    Private Sub rad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radFix.CheckedChanged, radEng.CheckedChanged, radSci.CheckedChanged, comNumDec.SelectedValueChanged
        Dim I As Integer

        If radFix.Checked = True Then
            txtExample.Text = "10000."
            For I = 1 To comNumDec.SelectedIndex
                txtExample.Text = txtExample.Text & "0"
            Next I
        ElseIf radSci.Checked = True Then
            txtExample.Text = "1."
            For I = 1 To comNumDec.SelectedIndex
                txtExample.Text = txtExample.Text & "0"
            Next I
            txtExample.Text = txtExample.Text & "  E4"
        ElseIf radEng.Checked = True Then
            txtExample.Text = "10."
            For I = 1 To comNumDec.SelectedIndex - 1
                txtExample.Text = txtExample.Text & "0"
            Next I
            txtExample.Text = txtExample.Text & "  E3"
        End If
    End Sub
End Class