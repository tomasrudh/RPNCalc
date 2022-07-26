Imports System.Windows.Forms

Public Class FrmOptions
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
    Private ReadOnly components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ChkOnTop As System.Windows.Forms.CheckBox
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents ButOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadDegrees As System.Windows.Forms.RadioButton
    Friend WithEvents RadRadians As System.Windows.Forms.RadioButton
    Friend WithEvents ComNumDec As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadFix As System.Windows.Forms.RadioButton
    Friend WithEvents RadSci As System.Windows.Forms.RadioButton
    Friend WithEvents RadEng As System.Windows.Forms.RadioButton
    Friend WithEvents TxtExample As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources = New System.ComponentModel.ComponentResourceManager(GetType(FrmOptions))
        Me.ChkOnTop = New System.Windows.Forms.CheckBox
        Me.ButCancel = New System.Windows.Forms.Button
        Me.ButOK = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtExample = New System.Windows.Forms.TextBox
        Me.RadEng = New System.Windows.Forms.RadioButton
        Me.RadSci = New System.Windows.Forms.RadioButton
        Me.RadFix = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComNumDec = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadRadians = New System.Windows.Forms.RadioButton
        Me.RadDegrees = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkOnTop
        '
        Me.ChkOnTop.Location = New System.Drawing.Point(8, 112)
        Me.ChkOnTop.Name = "ChkOnTop"
        Me.ChkOnTop.Size = New System.Drawing.Size(96, 24)
        Me.ChkOnTop.TabIndex = 0
        Me.ChkOnTop.Text = "Always on top"
        '
        'ButCancel
        '
        Me.ButCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButCancel.Location = New System.Drawing.Point(184, 112)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButCancel.TabIndex = 2
        Me.ButCancel.Text = "Cancel"
        '
        'ButOK
        '
        Me.ButOK.Location = New System.Drawing.Point(104, 112)
        Me.ButOK.Name = "ButOK"
        Me.ButOK.Size = New System.Drawing.Size(75, 23)
        Me.ButOK.TabIndex = 3
        Me.ButOK.Text = "OK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtExample)
        Me.GroupBox1.Controls.Add(Me.RadEng)
        Me.GroupBox1.Controls.Add(Me.RadSci)
        Me.GroupBox1.Controls.Add(Me.RadFix)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComNumDec)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 96)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'TxtExample
        '
        Me.TxtExample.BackColor = System.Drawing.Color.PaleGreen
        Me.TxtExample.Location = New System.Drawing.Point(104, 56)
        Me.TxtExample.Name = "TxtExample"
        Me.TxtExample.ReadOnly = True
        Me.TxtExample.Size = New System.Drawing.Size(100, 20)
        Me.TxtExample.TabIndex = 11
        Me.TxtExample.Text = "TxtExample"
        '
        'RadEng
        '
        Me.RadEng.Location = New System.Drawing.Point(8, 72)
        Me.RadEng.Name = "RadEng"
        Me.RadEng.Size = New System.Drawing.Size(88, 16)
        Me.RadEng.TabIndex = 10
        Me.RadEng.Text = "Engineering"
        '
        'RadSci
        '
        Me.RadSci.Location = New System.Drawing.Point(8, 56)
        Me.RadSci.Name = "RadSci"
        Me.RadSci.Size = New System.Drawing.Size(88, 16)
        Me.RadSci.TabIndex = 9
        Me.RadSci.Text = "Scientific"
        '
        'RadFix
        '
        Me.RadFix.Location = New System.Drawing.Point(8, 40)
        Me.RadFix.Name = "RadFix"
        Me.RadFix.Size = New System.Drawing.Size(88, 16)
        Me.RadFix.TabIndex = 8
        Me.RadFix.Text = "Fixed"
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
        'ComNumDec
        '
        Me.ComNumDec.FormattingEnabled = True
        Me.ComNumDec.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComNumDec.Location = New System.Drawing.Point(120, 16)
        Me.ComNumDec.Name = "ComNumDec"
        Me.ComNumDec.Size = New System.Drawing.Size(64, 21)
        Me.ComNumDec.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadRadians)
        Me.GroupBox2.Controls.Add(Me.RadDegrees)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 56)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Angles"
        '
        'RadRadians
        '
        Me.RadRadians.Location = New System.Drawing.Point(8, 32)
        Me.RadRadians.Name = "RadRadians"
        Me.RadRadians.Size = New System.Drawing.Size(72, 16)
        Me.RadRadians.TabIndex = 1
        Me.RadRadians.Text = "Radians"
        '
        'RadDegrees
        '
        Me.RadDegrees.Location = New System.Drawing.Point(8, 16)
        Me.RadDegrees.Name = "RadDegrees"
        Me.RadDegrees.Size = New System.Drawing.Size(72, 16)
        Me.RadDegrees.TabIndex = 0
        Me.RadDegrees.Text = "Degrees"
        '
        'FrmOptions
        '
        Me.CancelButton = Me.ButCancel
        Me.ClientSize = New System.Drawing.Size(272, 142)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButOK)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ChkOnTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOptions"
        Me.Text = "RPNCalc Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub ButOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButOK.Click
        NumDec = ComNumDec.SelectedIndex
        If RadFix.Checked = True Then DispMode = Disp.Fix
        If RadSci.Checked = True Then DispMode = Disp.Sci
        If RadEng.Checked = True Then DispMode = Disp.Eng
        If RadDegrees.Checked = True Then AngleMode = Angle.Deg
        If RadRadians.Checked = True Then AngleMode = Angle.Rad
        AlwaysOnTop = ChkOnTop.CheckState
        If ChkOnTop.CheckState = CheckState.Checked Then
            AlwaysOnTop = True
        Else
            AlwaysOnTop = False
        End If
        ShowX()
        Me.Close()
    End Sub

    Private Sub FrmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        ComNumDec.SelectedIndex = NumDec
        Select Case DispMode
            Case Disp.Fix
                RadFix.Checked = True
            Case Disp.Sci
                RadSci.Checked = True
            Case Disp.Eng
                RadEng.Checked = True
        End Select
        Select Case AngleMode
            Case Angle.Deg
                RadDegrees.Checked = True
            Case Angle.Rad
                RadRadians.Checked = True
        End Select
        If AlwaysOnTop = True Then ChkOnTop.CheckState = CheckState.Checked
    End Sub

    Private Sub Rad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles RadFix.CheckedChanged, RadEng.CheckedChanged, RadSci.CheckedChanged, ComNumDec.SelectedValueChanged
        Dim I As Integer

        If RadFix.Checked = True Then
            TxtExample.Text = "10000."
            For I = 1 To ComNumDec.SelectedIndex
                TxtExample.Text = TxtExample.Text & "0"
            Next I
        ElseIf RadSci.Checked = True Then
            TxtExample.Text = "1."
            For I = 1 To ComNumDec.SelectedIndex
                TxtExample.Text = TxtExample.Text & "0"
            Next I
            TxtExample.Text = TxtExample.Text & "  E4"
        ElseIf RadEng.Checked = True Then
            TxtExample.Text = "10."
            For I = 1 To ComNumDec.SelectedIndex - 1
                TxtExample.Text = TxtExample.Text & "0"
            Next I
            TxtExample.Text = TxtExample.Text & "  E3"
        End If
    End Sub
End Class