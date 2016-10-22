Module Module1

    Sub Main()
        Console.WriteLine("Enter your favorite language")
        Dim language As String
        language = Console.ReadLine()
        language = language.ToUpper
        If language = "VISUAL BASIC" Or _
                language = "VB" Or _
                language = "VB.NET" Then
            Console.WriteLine("We have a winner!")
        Else
            Console.WriteLine(language & " is not a bad language.")
        End If
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("PRESS ENTER TO EXIT")
        Console.ReadLine()
    End Sub

End Module
