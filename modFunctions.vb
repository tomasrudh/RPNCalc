Imports System.Drawing
Imports System.Windows.Forms

Module Functions
    Public Sub FunctionHandling(ByVal KeyType As Integer, ByVal Value As Integer)
        Dim I As Integer
        Dim Temp As Double
        Dim Pos As Integer = 1
        Dim Disp As Graphics = Graphics.FromImage(bmDisp)

        Select Case KeyType
            Case KeyTypes.Num, KeyTypes.Dec, KeyTypes.Negate, KeyTypes.Exponent, KeyTypes.Back
                If LastKeyType = KeyTypes.Calc And KeyType <> KeyTypes.Back Then
                    RollUp()
                    EntString = ""
                End If
                LastKeyType = KeyTypes.Num
                Select Case KeyType
                    Case KeyTypes.Num
                        If InStr(EntString, "E") = 0 OrElse EntString.Length - InStr(EntString, "E") < 3 Then
                            EntString = EntString & Value.ToString
                        End If
                    Case KeyTypes.Dec
                        If InStr(EntString, ".") = 0 And InStr(EntString, ",") = 0 Then
                            If EntString.Length = 0 Then
                                EntString = EntString & "0."
                            Else
                                If EntString.EndsWith(".") = False Then EntString = EntString & "."
                            End If
                            If EntString = "-" Then
                                EntString = "-0."
                            End If
                        End If
                    Case KeyTypes.Negate
                        If LastKeyType = KeyTypes.Num Then
                            If InStr(EntString, "E") = 0 Then
                                If EntString.StartsWith("-") Then
                                    EntString = EntString.Substring(1)
                                Else
                                    EntString = "-" & EntString
                                End If
                            Else
                                If EntString.Substring(InStr(EntString, "E")).StartsWith("+") Then
                                    EntString = EntString.Substring(0, InStr(EntString, "E")) & "-" & EntString.Substring(InStr(EntString, "E") + 1)
                                Else
                                    EntString = EntString.Substring(0, InStr(EntString, "E")) & "+" & EntString.Substring(InStr(EntString, "E") + 1)
                                End If
                            End If
                        Else
                            X = -X
                            ShowX()
                            LastKeyType = KeyTypes.Enter
                        End If
                    Case KeyTypes.Exponent
                        If EntString.Length = 0 Then EntString = "1E+"
                        If InStr(EntString, "E") = 0 Then EntString = EntString & "E+"
                    Case KeyTypes.Back
                        If LastKeyType = KeyTypes.Num Then
                            If EntString.Length > 0 Then EntString = EntString.Substring(0, EntString.Length - 1)
                            If EntString.EndsWith("E") Then EntString = EntString.Substring(0, EntString.Length - 1)
                            If EntString.Length = 0 Then
                                X = 0
                                LastKeyType = KeyTypes.Enter
                                ShowX()
                            End If
                        Else
                            X = 0
                            EntString = ""
                            LastKeyType = KeyTypes.Enter
                            ShowX()
                        End If
                End Select
                'Draws display during entry
                ClearDisp()
                If EntString.StartsWith("-") Then
                    DrawDigit("-", 0)
                    I = 1
                End If
                Pos = 1   'Current print position
                For I = I To EntString.Length - 1
                    If EntString.Substring(I, 1) = "E" Then
                        Pos = 12
                    Else
                        If Pos < 11 Or Pos > 11 Then
                            If EntString.Substring(I, 1) = "." Then
                                Pos -= 1
                            End If
                            If EntString.Substring(I, 1) <> "+" Then DrawDigit(EntString.Substring(I, 1), Pos)
                            Pos += 1
                        End If
                    End If
                Next I
                DrawDigit("_", Pos)
                X = Val(EntString)
                If EntString.Length = 0 Then ShowX()
            Case KeyTypes.Enter
                'If LastKeyType = KeyTypes.Num Then
                RollUp()
                    X = Y
                    EntString = ""
                'End If
                ShowX()
                LastKeyType = KeyTypes.Enter
            Case KeyTypes.LastX
                If LastKeyType = KeyTypes.Num Then X = Val(EntString)
                RollUp()
                X = LastX
                ShowX()
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.XSwapY
                If LastKeyType = KeyTypes.Num Then X = Val(EntString)
                Temp = X : X = Y : Y = Temp
                ShowX()
                EntString = ""
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.Add
                If LastKeyType = KeyTypes.Num Then X = Val(EntString)
                LastX = X
                X = Y + X
                Y = Z : Z = T
                ShowX()
                EntString = ""
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.Subt
                If LastKeyType = KeyTypes.Num Then X = Val(EntString)
                LastX = X
                X = Y - X
                Y = Z : Z = T
                ShowX()
                EntString = ""
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.Mul
                If LastKeyType = KeyTypes.Num Then X = Val(EntString)
                LastX = X
                X = Y * X
                Y = Z : Z = T
                ShowX()
                EntString = ""
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.Div
                If (LastKeyType = KeyTypes.Num And Val(EntString) = 0) Or X = 0 Then
                    MsgBox("Division with 0!", MsgBoxStyle.Critical)
                Else
                    If LastKeyType = KeyTypes.Num Then X = Val(EntString)
                    LastX = X
                    X = Y / X
                    Y = Z : Z = T
                    ShowX()
                    EntString = ""
                    LastKeyType = KeyTypes.Calc
                End If
            Case KeyTypes.Copy
                If LastKeyType = KeyTypes.Num Then
                    Clipboard.SetDataObject(EntString, True)
                Else
                    Clipboard.SetDataObject(X.ToString, True)
                End If
            Case KeyTypes.Paste
                Dim data As IDataObject = Clipboard.GetDataObject()
                If (data.GetDataPresent(DataFormats.Text)) AndAlso IsNumeric(data.GetData(DataFormats.Text)) = True Then
                    If LastKeyType = KeyTypes.Num Then X = Val(EntString)
                    T = Z : Z = Y : Y = X
                    X = Val(data.GetData(DataFormats.Text))
                    ShowX()
                    EntString = ""
                    LastKeyType = KeyTypes.Calc
                End If
            Case KeyTypes.PI
                If LastKeyType = KeyTypes.Num Then X = Val(EntString)
                T = Z : Z = Y : Y = X
                X = Math.PI
                ShowX()
                EntString = ""
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.Store
                If LastKeyType = KeyTypes.Num Then
                    S = Val(EntString)
                Else
                    S = X
                End If
            Case KeyTypes.Recall
                If LastKeyType = KeyTypes.Num Then X = Val(EntString)
                T = Z : Z = Y : Y = X
                X = S
                ShowX()
                EntString = ""
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.Percent
                LastX = X
                X = (X / 100) * CDbl(Y)
                Y = Z : Z = T
                ShowX()
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.YX
                LastX = X
                X = Y ^ X
                Y = Z : Z = T
                ShowX()
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.Clear
                X = 0
                ShowX()
                EntString = ""
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.RollDown
                RollDown()
                ShowX()
                EntString = ""
                LastKeyType = KeyTypes.Calc
            Case KeyTypes.RollUp
                RollUp()
                ShowX()
                EntString = ""
                LastKeyType = KeyTypes.Calc
        End Select
        frmRPNCalc.DefInstance.Label2.Text = EntString
        If ShowWindow = True Then
            frmRPNCalc.DefInstance.Text = "RPNCalc"
        Else
            If LastKeyType = KeyTypes.Num Then
                frmRPNCalc.DefInstance.Text = EntString & "_"
                '  Else
                '    frmRPNCalc.DefInstance.Text = X
            End If
        End If
        ShowStack()
        frmRPNCalc.DefInstance.picDisplay.CreateGraphics.DrawImage(bmDisp, 0, 0)
        Disp.Dispose()
    End Sub

    Public Sub RollDown()
        'Rolls down the stack, X moves to T
        Dim Temp As Double = X
        X = Y : Y = Z : Z = T : T = Temp
    End Sub

    Public Function RollUp() As Integer
        'Rolls up the stack one step, T moves to X
        Dim Temp As Double = T
        T = Z : Z = Y : Y = X
        X = Temp
    End Function
End Module