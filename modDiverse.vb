'Imports System.Math
'Imports System.IO
'Imports System.Globalization
Imports System.Environment
'Imports System.Net
'Imports System.Net.Sockets
'Imports System.Text
Public Class Diverse
    Public Left As Integer
    Public Top As Integer
    Public Sub HelpText()
        Dim MsgText As String

        MsgText = "RPNCalc by Tomas Rudh"
        MsgText &= vbNewLine & "tomas@rudhs.se"
        MsgText &= vbNewLine & ""
        MsgText &= vbNewLine & "Options:    F2"
        MsgText &= vbNewLine & vbNewLine & "Functions:"
        MsgText &= vbNewLine & "+ - * / %"
        MsgText &= vbNewLine & "9 decimals"
        MsgText &= vbNewLine & "Non-volatile memory"
        MsgText &= vbNewLine & vbNewLine & "Useful keys:"
        MsgText &= vbNewLine & "PI:" & vbTab & vbTab & "P"
        MsgText &= vbNewLine & "Back:" & vbTab & vbTab & "Backspace"
        MsgText &= vbNewLine & "Clear:" & vbTab & vbTab & "C, Delete, Backspace"
        MsgText &= vbNewLine & "Clear stack:" & vbTab & "Shift Delete"
        MsgText &= vbNewLine & "Help:" & vbTab & vbTab & "F1"
        MsgText &= vbNewLine & "Negate:" & vbTab & vbTab & "N"
        MsgText &= vbNewLine & "Roll down stack:" & vbTab & "Down arrow"
        MsgText &= vbNewLine & "X <> Y:" & vbTab & vbTab & "X"
        MsgText &= vbNewLine & "Last X:" & vbTab & vbTab & "L"
        MsgText &= vbNewLine & "Y^X:" & vbTab & vbTab & "Y"
        MsgText &= vbNewLine & "Store / Recall" & vbTab & "S / R"
        MsgText &= vbNewLine & "Copy X:" & vbTab & vbTab & "Ctrl C"
        MsgText &= vbNewLine & "Paste X:" & vbTab & vbTab & "Ctrl V"
        MsgText &= vbNewLine & "Drag'n'Drop support"
        MsgText &= vbNewLine & "Exit:" & vbTab & vbTab & "Escape"
        MsgText &= vbNewLine & "Right click the display gives more functions" & vbTab & vbTab
        MsgText &= vbNewLine & vbNewLine & "      Version "
        With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location)
            MsgText = MsgText & .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart
        End With
        MsgText = MsgText & vbNewLine & "   All rights reserved"
        MsgBox(MsgText, vbInformation, "RPNCalc")
    End Sub

    Public Sub New()

    End Sub

    Public Sub GetSettings()
        ShowWindow = GetSetting("RPNCalc", "Startup", "ShowHide", True)
        X = GetSetting("RPNCalc", "Startup", "X", 0)
        Y = GetSetting("RPNCalc", "Startup", "Y", 0)
        Z = GetSetting("RPNCalc", "Startup", "Z", 0)
        T = GetSetting("RPNCalc", "Startup", "T", 0)
        LastX = GetSetting("RPNCalc", "Startup", "LastX", 0)
        NumDec = GetSetting("RPNCalc", "Startup", "NumDec", 2)
        AngleMode = GetSetting("RPNCalc", "Startup", "AngleMode", Angle.Deg)
        DispMode = GetSetting("RPNCalc", "Startup", "dispmode", Disp.Fix)
        AlwaysOnTop = GetSetting("RPNCalc", "Startup", "AlwaysOnTop", False)
    End Sub

    Public Function GetVersion() As String
        With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location)
            GetVersion = .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart
            'GetVersion = .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart & "." & .FilePrivatePart
        End With
    End Function

    Public Function GetOSVersion() As String
        Dim osInfo As OperatingSystem

        GetOSVersion = "<Unknown>"
        osInfo = OSVersion
        Select Case osInfo.Platform
            Case PlatformID.Win32Windows
                Select Case (osInfo.Version.Minor)
                    Case 0
                        GetOSVersion = "Windows 95"
                    Case 10
                        If osInfo.Version.Revision.ToString() = "2222A" Then
                            GetOSVersion = "Windows 98SE"
                        Else
                            GetOSVersion = "Windows 98"
                        End If
                    Case 90
                        GetOSVersion = "Windows Me"
                End Select
            Case PlatformID.Win32NT
                Select Case (osInfo.Version.Major)
                    Case 3
                        GetOSVersion = "Windows NT 3.51"
                    Case 4
                        GetOSVersion = "Windows NT 4.0"
                    Case 5
                        Select Case (osInfo.Version.Minor)
                            Case 0
                                GetOSVersion = "Windows 2000"
                            Case 1
                                GetOSVersion = "Windows XP"
                            Case 2
                                GetOSVersion = "Windows Server 2003"
                        End Select
                    Case 6
                        Select Case (osInfo.Version.Minor)
                            Case 2
                                GetOSVersion = "Windows 11"
                        End Select
                    Case Else
                        GetOSVersion = osInfo.VersionString
                End Select
        End Select
    End Function
End Class