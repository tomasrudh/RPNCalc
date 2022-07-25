Imports System.Windows.Forms

Module modWindowHandling
    Public Const WM_SYSCOMMAND As Int32 = &H112
    Public Const MF_SEPARATOR As Int32 = &H800
    Public Const MF_STRING As Int32 = &H0
    Public Const IDM_ABOUT As Int32 = 1000
    Public Const IDM_HELP As Int32 = 1001
    Public Const IDM_SHOW As Int32 = 1002

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Function AppendMenu(ByVal hMenu As IntPtr, ByVal wFlags As Int32, ByVal wIDNewItem As Int32, ByVal lpNewItem As String) As Boolean
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Function GetSystemMenu(ByVal hWnd As IntPtr, ByVal bRevert As Boolean) As IntPtr
    End Function

    Public Sub SetupSystemMenu()
        'Dim sysMenuHandle As IntPtr = GetSystemMenu(Me.Handle, False)
        Dim sysMenuHandle As IntPtr = GetSystemMenu(frmRPNCalc.DefInstance.Handle, False)
        AppendMenu(sysMenuHandle, MF_SEPARATOR, 0, String.Empty)
        AppendMenu(sysMenuHandle, MF_STRING, IDM_SHOW, "Show / Hide")
        AppendMenu(sysMenuHandle, MF_STRING, IDM_HELP, "Help")
        AppendMenu(sysMenuHandle, MF_STRING, IDM_ABOUT, "About...")
    End Sub

    Public Sub ShowHide()
        If ShowWindow = True Then
            'Hide window
            frmRPNCalc.DefInstance.FormBorderStyle = FormBorderStyle.Fixed3D
            ShowWindow = False
            OldLeft = frmRPNCalc.DefInstance.Left
            OldTop = frmRPNCalc.DefInstance.Top
            frmRPNCalc.DefInstance.Left = -100
            frmRPNCalc.DefInstance.Top = -100
            frmRPNCalc.DefInstance.Text = X
        Else
            'Show window
            ShowWindow = True
            frmRPNCalc.DefInstance.FormBorderStyle = FormBorderStyle.None
            If OldLeft < 0 Or OldLeft > Screen.PrimaryScreen.WorkingArea.Width Then OldLeft = 10
            If OldTop < 0 Or OldTop > Screen.PrimaryScreen.WorkingArea.Height Then OldTop = 10
            frmRPNCalc.DefInstance.Left = OldLeft
            frmRPNCalc.DefInstance.Top = OldTop
            frmRPNCalc.DefInstance.Text = "RPNCalc"
        End If
    End Sub
End Module