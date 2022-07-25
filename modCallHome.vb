Imports System.Windows.Forms
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.IO
Public Class CallHome
    Public CHT As Thread

    Public Sub StartCallHome()
        CHT = New Thread(New ThreadStart(AddressOf CallHomeThread))
        CHT.IsBackground = True
        CHT.Name = "CallHomeThread"
        CHT.Priority = ThreadPriority.Lowest
        CHT.Start()
    End Sub

    Public Sub CallHomeThread()
        Dim Bytes(100) As Byte
        Dim I, NumStarts As Integer
        Dim TempChar As String
        Dim Diverse As New Diverse


        Console.Write("CallHomeThread started" & vbNewLine)
        Try
            'Dim ipHostInfo As IPHostEntry = Dns.Resolve("rudh.mine.nu")
            Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry("rudhs.se")
            Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
            Dim remoteEP As New IPEndPoint(ipAddress, 1004)
            Dim sender As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            NumStarts = GetSetting("RPNCalc", "Startup", "NumStarts", 0) + 1
            SaveSetting("RPNCalc", "Startup", "NumStarts", NumStarts)
            sender.Connect(remoteEP)
            TempChar = Diverse.GetVersion() & "|" & Mid(Diverse.GetOSVersion(), 9)  'Cutting off "Windows "
            TempChar &= "|" & System.Globalization.CultureInfo.CurrentCulture.LCID & "|RPNCalc|" & NumStarts & " "
            Dim Tempmsg As Byte() = Encoding.ASCII.GetBytes(TempChar)
            ' Replace NLCR with "|"
            Dim Sockmsg(Tempmsg.Length) As Byte
            For I = 0 To Tempmsg.Length - 2
                If Tempmsg(I) = 13 And Tempmsg(I + 1) = 10 Then
                    Sockmsg(I) = 124    '"|"
                    I += 1
                Else
                    Sockmsg(I) = Tempmsg(I)
                End If
            Next I
            Dim bytesSent As Integer = sender.Send(Sockmsg, 0, Sockmsg.Length, SocketFlags.None)
            'sender.Receive(Bytes, sender.Available)
            sender.Receive(Bytes)
            sender.Shutdown(SocketShutdown.Both)
            sender.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class