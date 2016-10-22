Public Class StringTools


    Const strNum1 As String = "One"
    Const strNum2 As String = "Two"
    Const strNum3 As String = "Three"
    Const strNum4 As String = "Four"
    Const strNum5 As String = "Five"
    Const strNum6 As String = "Six"
    Const strNum7 As String = "Seven"
    Const strNum8 As String = "Eight"
    Const strNum9 As String = "Nine"
    Const strNum10 As String = "Ten"
    Const strNum11 As String = "Eleven"
    Const strNum12 As String = "Twelve"
    Const strNum13 As String = "Thirteen"
    Const strNum14 As String = "Fourteen"
    Const strNum15 As String = "Fifteen"
    Const strNumteen As String = "teen"
    Const strNum20 As String = "Twenty"
    Const strNum30 As String = "Thirty"
    Const strNum40 As String = "Fourty"
    Const strNum50 As String = "Fifty"
    Const strNum60 As String = "Sixty"
    Const strNum70 As String = "Seventy"
    Const strNum80 As String = "Eighty"
    Const strNum90 As String = "Ninety"

    Enum PaddingEnum
        PaddingCommas
        PaddingSpaces
        PaddingDashes
    End Enum

    Enum DelimitEnum
        DelimiterNone
        Delimiter1Asterisk
        Delimiter3Asterisks
    End Enum

    Enum CaseEnum
        CaseCaps
        CaseLower
        CaseUpper
    End Enum

    'local variable(s) to hold property value(s)
    Private varUseCase As CaseEnum 'local copy
    Private varUseDelimiter As DelimitEnum 'local copy
    Private varUsePadding As PaddingEnum 'local copy

    Public Function Num2String(ByVal number As Decimal) As String
        Dim biln As Decimal, miln As Decimal, thou As Decimal, hund As Decimal
        Dim strNumber As String = ""

        If number > 999999999999.99 Then
            Num2String = "***"
            Exit Function
        End If

        biln = Math.Floor(number / 1000000000)
        If biln > 0 Then strNumber = FormatNum(biln) & " Billion" & Pad()
        miln = Math.Floor((number - biln * 1000000000) / 1000000)
        If miln > 0 Then strNumber = strNumber & FormatNum(miln) & " Million" & Pad()
        thou = Math.Floor((number - biln * 1000000000 - miln * 1000000) / 1000)
        If thou > 0 Then strNumber = strNumber & FormatNum(thou) & " Thousand" & Pad()
        hund = Math.Floor(number - biln * 1000000000 - miln * 1000000 - thou * 1000)
        If hund > 0 Then strNumber = strNumber & FormatNum(hund)
        If Right(strNumber, 1) = "," Then strNumber = Left(strNumber, Len(strNumber) - 1)
        If Left(strNumber, 1) = "," Then strNumber = Right(strNumber, Len(strNumber) - 1)
        If number <> Math.Floor(number) Then
            strNumber = strNumber & FormatDecimal((number - Math.Floor(number)) * 100)
        Else
            ' the following loop is necessary for the proper conversion
            ' of amount like 32,100,000 or 1,000,000,000.
            While strNumber.EndsWith(", ")
                strNumber = Left(strNumber, strNumber.Length - 2) & " "
            End While
            strNumber = strNumber & " DOLLARS"
        End If
        Num2String = Delimit(SetCase(strNumber))
    End Function

    Public Property Padding() As PaddingEnum
        Get
            Return (varUsePadding)
        End Get
        Set(ByVal Value As PaddingEnum)
            varUsePadding = Value
        End Set

    End Property


    Public Property Delimiter() As DelimitEnum
        Get
            Return (varUseDelimiter)
        End Get
        Set(ByVal Value As DelimitEnum)
            varUseDelimiter = Value
        End Set
    End Property



    Public Property [Case]() As CaseEnum
        Get
            Return (varUseCase)
        End Get
        Set(ByVal Value As CaseEnum)
            varUseCase = Value
        End Set
    End Property


    Private Function FormatNum(ByVal num As Decimal) As String
        Dim digit100 As Decimal, digit10 As Decimal
        Dim strNum As String = ""

        digit100 = Math.Floor(num / 100)
        If digit100 > 0 Then strNum = Format100(digit100)
        digit10 = Fix((num - digit100 * 100))
        If digit10 > 0 Then
            If strNum <> "" Then
                strNum = strNum & " And " & Format10(digit10)
            Else
                strNum = Format10(digit10)
            End If
        End If
        Return strNum
    End Function

    Private Function Format100(ByVal num As Decimal) As String
        Dim str100 As String
        str100 = Format1(num) & " Hundred"
        Return str100
    End Function

    Private Function Format10(ByVal num As Decimal) As String
        Dim strNum As String = ""
        If num < 10 Then
            Format10 = Format1(num)
            Exit Function
        End If
        If num < 20 Then
            Select Case num
                Case 10
                    Format10 = strNum10
                    Exit Function
                Case 11
                    Format10 = strNum11
                    Exit Function
                Case 12
                    Format10 = strNum12
                    Exit Function
                Case 13
                    Format10 = strNum13
                    Exit Function
                Case 14
                    Format10 = strNum14
                    Exit Function
                Case 15
                    Format10 = strNum15
                    Exit Function
                Case Else
                    Format10 = Format1(num Mod 10) & strNumteen
            End Select
            Exit Function
        Else
            Select Case Math.Floor(num / 10) * 10
                Case 20 : strNum = strNum20
                Case 30 : strNum = strNum30
                Case 40 : strNum = strNum40
                Case 50 : strNum = strNum50
                Case 60 : strNum = strNum60
                Case 70 : strNum = strNum70
                Case 80 : strNum = strNum80
                Case 90 : strNum = strNum90
            End Select
            Return (strNum & " " & Format1(num Mod 10))
        End If
    End Function

    Private Function Format1(ByVal num As Decimal) As String
        Select Case num
            Case 1 : Return strNum1
            Case 2 : Return strNum2
            Case 3 : Return strNum3
            Case 4 : Return strNum4
            Case 5 : Return strNum5
            Case 6 : Return strNum6
            Case 7 : Return strNum7
            Case 8 : Return strNum8
            Case 9 : Return strNum9
            Case Else : Return Nothing
        End Select
    End Function

    Private Function FormatDecimal(ByVal num As Decimal) As String
        Return " DOLLARS and " & Format10(num) & " CENTS"
    End Function

    Private Function SetCase(ByVal nString As String) As String
        Select Case varUseCase
            Case CaseEnum.CaseUpper : Return nString.ToLower
            Case CaseEnum.CaseLower : Return nString.ToUpper
            Case CaseEnum.CaseCaps : Return nString
            Case Else : Return Nothing
        End Select
    End Function

    Private Function Pad() As String
        Select Case varUsePadding
            Case PaddingEnum.PaddingSpaces : Return " "
            Case PaddingEnum.PaddingDashes : Return "-"
            Case PaddingEnum.PaddingCommas : Return ", "
            Case Else : Return Nothing
        End Select
    End Function

    Private Function Delimit(ByVal nString As String) As String
        Select Case varUseDelimiter
            Case DelimitEnum.DelimiterNone : Return nString
            Case DelimitEnum.Delimiter1Asterisk : Return "*" & nString & "*"
            Case DelimitEnum.Delimiter3Asterisks : Return "***" & nString & "***"
            Case Else : Return Nothing
        End Select
    End Function

    Public Function ExtractFileName(ByVal PathFileName As String) As String
        Dim delimiterPosition As Integer
        delimiterPosition = PathFileName.LastIndexOf("\")
        If delimiterPosition > 0 Then
            Return PathFileName.Substring(delimiterPosition + 1)
        Else
            Return PathFileName
        End If
    End Function

    Public Function ExtractPathName(ByVal PathFileName As String) As String
        Dim delimiterPosition As Integer
        delimiterPosition = PathFileName.LastIndexOf("\")
        If delimiterPosition > 0 Then
            Return PathFileName.Substring(0, delimiterPosition)
        Else
            Return ""
        End If
    End Function
End Class