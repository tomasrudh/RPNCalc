Imports System.Drawing

Module Declarations
    Public X, Y, Z, T As Double               'The stack
    Public LastX As Double                    'LastX
    Public S As Double                        'Storage
    Public NumDec As Integer
    Public EntString As String = ""           'Data entered so far
    Public bmDisp As Bitmap                   'Display data
    Public ResizeDone As Boolean = False      'Window is being moved
    Public ColorBack As Color = Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))  'Background color
    Public PenBack As New Pen(ColorBack)      'Background pen
    Public ShowWindow As Boolean = True       'True = window is visible
    Public OldLeft, OldTop As Integer         'Last window position
    Public AlwaysOnTop As Boolean             'Always display RPNCalc on top of other windows
    Public isBig As Boolean = False
    Public Structure strucDebug
        Public Mode As Boolean                  'True = debug mode
        Public LastWinHeight As Integer         'The windows height when normal
        Public LastWinWidth As Integer          'The windows width when normal
    End Structure
    Public DebugMode As strucDebug
    Enum DispTypes
        Segment
        Dots
    End Enum
    Public DispType As Integer = DispTypes.Segment
    Enum KeyTypes
        Null
        Enter
        Clear
        Num
        Add
        Subt
        Mul
        Div
        PI
        Percent
        Negate
        XSwapY
        LastX
        Exponent
        YX
        Back
        Dec
        Calc
        RollDown
        RollUp
        Store
        Recall
        Copy
        Paste
        Drop
    End Enum
    Public LastKeyType As Integer = KeyTypes.Enter  'Keytype pressed last time, "ENTER", "CALC" or "NUM"
    Enum Disp
        Fix
        Sci
        Eng
    End Enum
    Public DispMode As Integer
    Enum Angle
        Deg
        Rad
    End Enum
    Public AngleMode As Integer
End Module