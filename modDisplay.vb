Imports System.Drawing
Imports System.Math
Module modDisplay
    Private BrushBack As New SolidBrush(Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte)))

    Public Function ShowX() As Integer
        'Draws X on the display using DrawDigit
        Dim TempStr, XStringInt, XStringFrc, XStringExp As String
        Dim I, Pos As Integer
        Dim DispNumDec As Integer   'How many decimals to show for this particular view

        If ShowWindow = True Then
            frmRPNCalc.DefInstance.Text = "RPNCalc"
        Else
            frmRPNCalc.DefInstance.Text = X
        End If
        ShowStack()
        ClearDisp()
        XStringExp = "0"
        TempStr = Abs(X).ToString
        If InStr(TempStr, ".") > 0 Then
            XStringInt = TempStr.Substring(0, InStr(TempStr, ".") - 1)
            XStringFrc = (CInt((Abs(X) - Int(Abs(X))) * 10 ^ NumDec) / 10 ^ NumDec).ToString
            XStringFrc = XStringFrc.Substring(InStr(XStringFrc, "."))
        Else
            XStringInt = TempStr
            XStringFrc = ""
        End If
        Select Case DispMode
            Case Disp.Fix
                If X <> 0 AndAlso (-Log10(X) > NumDec Or Log10(X) > 8) Then
                    XStringExp = Int(Log10(X))
                    XStringInt = Int(X / 10 ^ Val(XStringExp)).ToString
                    XStringFrc = CInt((X / 10 ^ Val(XStringExp) - Val(XStringInt)) * 10 ^ NumDec).ToString
                End If
                DispNumDec = NumDec
            Case Disp.Sci
                XStringExp = Int(Log10(X))
                XStringInt = Abs(Int(X / 10 ^ Val(XStringExp))).ToString
                XStringFrc = Abs(CInt((X / 10 ^ Val(XStringExp) - Val(XStringInt)) * 10 ^ NumDec)).ToString
                DispNumDec = NumDec
            Case Disp.Eng
                If X <> 0 Then XStringExp = Int(Log10(X))
                XStringInt = Abs(Int(X / 10 ^ Val(XStringExp))).ToString
                XStringFrc = Abs(CInt((X / 10 ^ Val(XStringExp) - Val(XStringInt)) * 10 ^ NumDec)).ToString
                XStringFrc = XStringFrc & "000"
                Select Case Val(XStringExp) Mod 3
                    Case -1
                        XStringInt = XStringInt & XStringFrc.Substring(0, 2)
                        XStringFrc = XStringFrc.Substring(2)
                        XStringExp = (Val(XStringExp) - 2).ToString
                    Case -2
                        XStringInt = XStringInt & XStringFrc.Substring(0, 1)
                        XStringFrc = XStringFrc.Substring(1)
                        XStringExp = (Val(XStringExp) - 1).ToString
                    Case 1
                        XStringInt = XStringInt & XStringFrc.Substring(0, 1)
                        XStringFrc = XStringFrc.Substring(1)
                        XStringExp = (Val(XStringExp) - 1).ToString
                    Case 2
                        XStringInt = XStringInt & XStringFrc.Substring(0, 2)
                        XStringFrc = XStringFrc.Substring(2)
                        XStringExp = (Val(XStringExp) - 2).ToString
                End Select
                DispNumDec = NumDec - XStringInt.Length + 1
        End Select
        'Draw exponent part
        If Val(XStringExp) <> 0 Or DispMode <> Disp.Fix Then
            If XStringExp.Substring(0, 1) = "-" Then
                DrawDigit("-", 12)
                XStringExp = XStringExp.Substring(1)
            End If
            If XStringExp.Length = 1 Then
                DrawDigit(XStringExp.Substring(0, 1), 14)
            Else
                DrawDigit(XStringExp.Substring(0, 1), 13)
                DrawDigit(XStringExp.Substring(1, 1), 14)
            End If
        End If
        If X < 0 Then DrawDigit("-", 0)
        'Draw integer part
        Pos = 1
        For I = 0 To XStringInt.Length - 1
            DrawDigit(XStringInt.Substring(I, 1), Pos)
            Pos += 1
        Next I
        If NumDec > 0 Then DrawDigit(".", Pos - 1)
        'Draw fractional part
        For I = 0 To DispNumDec - 1
            If I > XStringFrc.Length - 1 Then
                DrawDigit("0", Pos)
            Else
                DrawDigit(XStringFrc.Substring(I, 1), Pos)
            End If
            Pos += 1
        Next I
    End Function

    Public Function ClearDisp() As Integer
        'Dim Disp As Graphics = frmRPNCalc.DefInstance.picDisplay.CreateGraphics
        Dim Disp As Graphics
        Disp = Graphics.FromImage(bmDisp)
        Disp.Clear(ColorBack)
        'Disp.FillRectangle(BrushBack, 0, 0, frmRPNCalc.DefInstance.picDisplay.Width, frmRPNCalc.DefInstance.picDisplay.Height)
        frmRPNCalc.DefInstance.picDisplay.CreateGraphics.DrawImage(bmDisp, 0, 0)
        Disp.Dispose()
    End Function

    Public Sub DrawDigit(ByVal InDigit As String, ByVal Pos As Integer)
        Select Case DispType
            Case DispTypes.Segment
                DrawDigitSegment(InDigit, Pos)
            Case DispTypes.Dots
                DrawDigitDot(InDigit, Pos)
        End Select
    End Sub

    Public Function DrawDigitSegment(ByVal InDigit As String, ByVal Pos As Integer) As Integer
        'Draws one digit on the display
        With frmRPNCalc.DefInstance
            '0 = 111 0111  '1 = 001 0001  '2 = 011 1110  '3 = 011 1011  '4 = 101 1001
            '5 = 110 1011  '6 = 110 1111  '7 = 011 0001  '8 = 111 1111  '9 = 111 1011
            Dim DigitSegs() As Integer = New Integer() {&H77, &H11, &H3E, &H3B, &H59, &H6B, &H6F, &H31, &H7F, &H7B}
            Dim Disp As Graphics = Graphics.FromImage(bmDisp)
            Dim Pen As New Pen(Color.Black)
            Dim DispHeight As Integer = .picDisplay.Height
            Dim W As Byte = 13
            Dim Digit As Integer

            If InDigit = "." Then
                Disp.DrawRectangle(Pen, W * Pos + 12, 17, 1, 1)
                Exit Function
            End If
            Disp.FillRectangle(BrushBack, W * Pos + 2, 0, W - 4, .picDisplay.Height)
            If InDigit = "-" Then
                Disp.DrawLine(Pen, W * Pos + 4, 8, W * Pos + 8, 8)
                Disp.DrawLine(Pen, W * Pos + 3, 9, W * Pos + 9, 9)
                Exit Function
            End If
            If InDigit = "_" Then
                Disp.DrawLine(Pen, W * Pos + 2, 18, W * Pos + 10, 18)
                Exit Function
            End If
            Digit = Val(InDigit)
            '111 1111
            If DigitSegs(Digit) And &H40 Then      'Segment 1
                Disp.DrawLine(Pen, W * Pos + 2, 2, W * Pos + 2, 8)
                Disp.DrawLine(Pen, W * Pos + 3, 3, W * Pos + 3, 7)
            End If
            If DigitSegs(Digit) And &H20 Then      'Segment 2
                Disp.DrawLine(Pen, W * Pos + 3, 1, W * Pos + 9, 1)
                Disp.DrawLine(Pen, W * Pos + 4, 2, W * Pos + 8, 2)
            End If
            If DigitSegs(Digit) And &H10 Then      'Segment 3
                Disp.DrawLine(Pen, W * Pos + 10, 2, W * Pos + 10, 8)
                Disp.DrawLine(Pen, W * Pos + 9, 3, W * Pos + 9, 7)
            End If
            If DigitSegs(Digit) And &H8 Then      'Segment 4
                Disp.DrawLine(Pen, W * Pos + 4, 8, W * Pos + 8, 8)
                Disp.DrawLine(Pen, W * Pos + 3, 9, W * Pos + 9, 9)
            End If
            If DigitSegs(Digit) And &H4 Then      'Segment 5
                Disp.DrawLine(Pen, W * Pos + 2, 10, W * Pos + 2, 16)
                Disp.DrawLine(Pen, W * Pos + 3, 11, W * Pos + 3, 15)
            End If
            If DigitSegs(Digit) And &H2 Then      'Segment 6
                Disp.DrawLine(Pen, W * Pos + 4, 16, W * Pos + 8, 16)
                Disp.DrawLine(Pen, W * Pos + 3, 17, W * Pos + 9, 17)
            End If
            If DigitSegs(Digit) And &H1 Then      'Segment 7
                Disp.DrawLine(Pen, W * Pos + 9, 11, W * Pos + 9, 15)
                Disp.DrawLine(Pen, W * Pos + 10, 10, W * Pos + 10, 16)
            End If
            .picDisplay.CreateGraphics.DrawImage(bmDisp, 0, 0)
            Disp.Dispose()
        End With
    End Function

    Public Function DrawDigitDot(ByVal InDigit As String, ByVal Pos As Integer) As Integer
        'Draws one digit on the display
        With frmRPNCalc.DefInstance
            '0 = 111 0111  '1 = 001 0001  '2 = 011 1110  '3 = 011 1011  '4 = 101 1001
            '5 = 110 1011  '6 = 110 1111  '7 = 011 0001  '8 = 111 1111  '9 = 111 1011
            Dim DigitSegs() As Integer = New Integer() {&H77, &H11, &H3E, &H3B, &H59, &H6B, &H6F, &H31, &H7F, &H7B}
            Dim Disp As Graphics = Graphics.FromImage(bmDisp)
            Dim Pen As New Pen(Color.Black)
            Dim Brush As New SolidBrush(Color.Black)
            Dim DispHeight As Integer = .picDisplay.Height
            Dim W As Byte = 13
            If InDigit = "." Then
                Disp.DrawRectangle(Pen, W * Pos + 12, 17, 1, 1)
                Exit Function
            End If
            Disp.FillRectangle(Brush, W * Pos + 2, 2, 2, 2)
            Disp.FillRectangle(Brush, W * Pos + 4, 4, 2, 2)
            Disp.FillRectangle(Brush, W * Pos + 6, 6, 2, 2)
            Disp.FillRectangle(Brush, W * Pos + 8, 8, 2, 2)
            Disp.FillRectangle(Brush, W * Pos + 10, 10, 2, 2)
            Disp.FillRectangle(Brush, W * Pos + 12, 12, 2, 2)
            Disp.FillRectangle(Brush, W * Pos + 2, 14, 2, 2)
            'Disp.DrawLine(Pen, W * Pos + 4, 8, W * Pos + 8, 8)
            'Disp.DrawLine(Pen, W * Pos + 3, 9, W * Pos + 9, 9)
            .picDisplay.CreateGraphics.DrawImage(bmDisp, 0, 0)
            Disp.Dispose()
        End With
    End Function

    Public Sub ShowStack()
        frmRPNCalc.DefInstance.lblX.Text = X
        frmRPNCalc.DefInstance.lblY.Text = Y
        frmRPNCalc.DefInstance.lblZ.Text = Z
        frmRPNCalc.DefInstance.lblT.Text = T
        frmRPNCalc.DefInstance.Label2.Text = "Last Key Type= " & LastKeyType
    End Sub
End Module
