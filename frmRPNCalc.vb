Imports System.Drawing
Imports System.Windows.Forms

Public Class frmRPNCalc
    Public Shared DefInstance As New frmRPNCalc
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    Public Shared Sub Main()
        DefInstance.Show()
        Application.Run()
    End Sub

    Private Sub RPNCalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Diverse As New Diverse
        Dim C As New CallHome

        Diverse.GetSettings()
        Left = GetSetting("RPNCalc", "Startup", "Left", 10)
        If Left < 0 Then
            Left = GetSetting("RPNCalc", "Startup", "OldLeft", 10)
        End If
        'frmRPNCalc.DefInstance.Left = Left
        Top = GetSetting("RPNCalc", "Startup", "Top", 10)
        If Top < 0 Then
            Top = GetSetting("RPNCalc", "Startup", "OldTop", 10)
        End If
        If Left < 0 Or Left > Screen.PrimaryScreen.WorkingArea.Width Then Left = 10
        If Top < 0 Or Top > Screen.PrimaryScreen.WorkingArea.Height Then Top = 10
        'frmRPNCalc.DefInstance.Top = Top
        Me.Location = New Point(Left, Top)
        If ShowWindow = True Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        End If
        SetupSystemMenu()
        If DispMode = Disp.Fix Then mnuFixed.Checked = True
        If DispMode = Disp.Eng Then mnuEngineering.Checked = True
        If DispMode = Disp.Sci Then mnuScientific.Checked = True
        Me.TopMost = AlwaysOnTop
        mnuAlwaysOnTop.Checked = AlwaysOnTop
        bmDisp = New Bitmap(picDisplay.Width, picDisplay.Height, CreateGraphics())
        DebugMode.Mode = False
        DebugMode.LastWinHeight = MyBase.Height
        DebugMode.LastWinWidth = MyBase.Width
        ShowX()
        'Me.Height = 60
        ResizeDone = True
        lblVersion.Text = Diverse.GetVersion()
        lblStarted.Text = "Started " & GetSetting("RPNCalc", "Startup", "NumStarts", 0) + 1 & " times"
        C.StartCallHome()
    End Sub

    Private Sub RPNCalc_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        'Dim D As New Diverse
        SaveSettings()
    End Sub

    Private Sub Pic_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picDisplay.Paint
        If ResizeDone = False Then Exit Sub
        ResizeDone = False
        e.Graphics.DrawImage(bmDisp, 0, 0)
        ResizeDone = True
    End Sub

    Private Sub KeyPressed(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Dim InputNum As Integer
        Dim KeyType As Integer
        Dim Diverse As New Diverse

        TextBox2.Text = e.KeyData
        Select Case e.KeyData
            Case 48 To 57 : InputNum = e.KeyValue - 48 : KeyType = KeyTypes.Num 'Digits 1 - 0
            Case 96 To 105 : InputNum = e.KeyValue - 96 : KeyType = KeyTypes.Num 'Numeric keyboard 1 - 0
            Case Keys.N : KeyType = KeyTypes.Negate 'N
            Case Keys.Return : KeyType = KeyTypes.Enter 'Enter
            Case Keys.Oemplus, Keys.Add : KeyType = KeyTypes.Add '+
            Case Keys.OemMinus, Keys.Subtract : KeyType = KeyTypes.Subt '-
            Case Keys.Multiply, 65727 : KeyType = KeyTypes.Mul '*
            Case Keys.Divide, 111, 65591 : KeyType = KeyTypes.Div '/
            Case 65589 : KeyType = KeyTypes.Percent '%, Shift 5
            Case Keys.Back, 8 : KeyType = KeyTypes.Back 'Backspace
            Case Keys.Delete, 46, Keys.C : KeyType = KeyTypes.Clear 'Delete
            Case 65582 : KeyType = KeyTypes.Clear 'Shift - Delete, Clear stack
                Y = 0 : Z = 0 : T = 0
            Case Keys.Decimal, 188, 190 : KeyType = KeyTypes.Dec '. or ,
            Case Keys.E : KeyType = KeyTypes.Exponent 'E
            Case Keys.Y : KeyType = KeyTypes.YX 'Y^X
            Case Keys.X : KeyType = KeyTypes.XSwapY 'X
            Case Keys.L : KeyType = KeyTypes.LastX 'L
            Case Keys.S : KeyType = KeyTypes.Store 'S
            Case Keys.R : KeyType = KeyTypes.Recall 'R
            Case Keys.P : KeyType = KeyTypes.PI 'PI
            Case Keys.Down : KeyType = KeyTypes.RollDown 'Pil ner
            Case Keys.Up : KeyType = KeyTypes.RollUp 'Pil upp
            Case 27, 262259  'Cancel, Alt-F4
                SaveSettings()
                Application.Exit()
            Case Keys.F1 : Diverse.HelpText() 'F1, Help
            Case Keys.F2  'F2, Options
                Dim frmOptions As New frmOptions
                frmOptions.ShowDialog()
                Me.TopMost = AlwaysOnTop
                mnuAlwaysOnTop.Checked = AlwaysOnTop
            Case 131139 : KeyType = KeyTypes.Copy 'Ctrl-C
            Case 131158 : KeyType = KeyTypes.Paste 'Ctrl-V
            Case 131140   'Ctrl-D, Toggle debug mode
                If DebugMode.Mode = False Then
                    DebugMode.Mode = True
                    MyBase.Height = 250
                    MyBase.Width = 448
                Else
                    DebugMode.Mode = False
                    MyBase.Height = DebugMode.LastWinHeight
                    MyBase.Width = DebugMode.LastWinWidth
                End If
            Case 393297 'Alt-gr q
                Select Case isBig
                    Case True
                        isBig = False
                        MyBase.Height = DebugMode.LastWinHeight
                        MyBase.Width = DebugMode.LastWinWidth
                    Case False
                        isBig = True
                        Me.Height = 250
                End Select
            Case Else : KeyType = KeyTypes.Null
        End Select
        e.Handled = True
        FunctionHandling(KeyType, InputNum)
    End Sub

    Private Sub RPNCalc_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub RPNCalc_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub RPNCalc_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPaste.Click
        KeyPressed("", New KeyEventArgs(131158))
    End Sub

    Private Sub Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopy.Click
        KeyPressed("", New KeyEventArgs(131139))
    End Sub

    Private Sub picDisplay_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picDisplay.MouseDown
        ' Drag out of RPNCalc
        If e.Button = Windows.Forms.MouseButtons.Left Then
            picDisplay.DoDragDrop(X.ToString, DragDropEffects.Copy)
        End If
    End Sub

    Private Sub RPNCalc_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter
        ' Drag into RPNCalc
        If IsNumeric(e.Data.GetData(DataFormats.Text).ToString) = True Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub RPNCalc_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        FunctionHandling(KeyTypes.Drop, e.Data.GetData(DataFormats.Text).ToString)
    End Sub

    Private Sub Options_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptions.Click
        Dim frmOptions As New frmOptions
        frmOptions.ShowDialog()
        Me.TopMost = AlwaysOnTop
        mnuAlwaysOnTop.Checked = AlwaysOnTop
    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click
        Dim Diverse As New Diverse
        Diverse.HelpText()
    End Sub

    Private Sub ShowHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowHide.Click
        ShowHide()
    End Sub

    Private Sub DispModes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
            Handles mnuFixed.Click, mnuScientific.Click, mnuEngineering.Click
        Dim Temp As Integer

        Do
            Temp = InputBox("Please enter number of decimals", , NumDec)
            If Temp.ToString = "" Then Exit Sub
        Loop While IsNumeric(Temp) = False
        mnuFixed.Checked = False
        mnuScientific.Checked = False
        mnuEngineering.Checked = False
        sender.checked = True
        Select Case sender.text
            Case "Fixed..."
                DispMode = Disp.Fix
            Case "Scientific..."
                DispMode = Disp.Sci
            Case "Engineering..."
                DispMode = Disp.Eng
        End Select
        NumDec = Int(Val(Temp))
        ShowX()
    End Sub

    Public Sub SaveSettings()
        'Console.Write("SaveSettings" & vbNewLine)
        'Console.Write(Me.Location.X & vbNewLine)
        SaveSetting("RPNCalc", "Startup", "Left", Me.Location.X)
        SaveSetting("RPNCalc", "Startup", "Top", Me.Location.Y)
        SaveSetting("RPNCalc", "Startup", "OldLeft", OldLeft)
        SaveSetting("RPNCalc", "Startup", "OldTop", OldTop)
        'SaveSetting("RPNCalc", "Startup", "ShowHide", ShowWindow)
        SaveSetting("RPNCalc", "Startup", "X", X)
        SaveSetting("RPNCalc", "Startup", "Y", Y)
        SaveSetting("RPNCalc", "Startup", "Z", Z)
        SaveSetting("RPNCalc", "Startup", "T", T)
        SaveSetting("RPNCalc", "Startup", "LastX", LastX)
        SaveSetting("RPNCalc", "Startup", "NumDec", NumDec)
        SaveSetting("RPNCalc", "Startup", "DispMode", DispMode)
        SaveSetting("RPNCalc", "Startup", "AngleMode", AngleMode)
        SaveSetting("RPNCalc", "Startup", "AlwaysOnTop", AlwaysOnTop)
    End Sub

End Class