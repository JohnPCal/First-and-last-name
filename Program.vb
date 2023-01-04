Imports System

Module Name_Combine
    Sub Main()
        Dim firstname, lastname, fullname, initials As String

        Console.Write("Enter first name ")
        firstname = Console.ReadLine()
        Console.Write("Enter last name ")
        lastname = Console.ReadLine()

        fullname = Capitalise(firstname, lastname)
        initials = CapInitials(firstname, lastname)
        Console.WriteLine(fullname)
        Console.WriteLine(initials)
        Console.WriteLine("Name length: " & fullname.Length)
        Console.WriteLine("All caps: " & fullname.ToUpper)
        Console.WriteLine("Initial first name with full surname: " & InitialSurname(firstname, lastname))
        Console.WriteLine("Surname, Firstname: " & lastname.ToLower & " " & firstname.ToLower)

        Console.WriteLine(UCase(ComplexInitials(firstname, lastname)))

        'John Calverley
    End Sub

    Function Capitalise(ByVal firstname As String, ByVal lastname As String) As String
        Dim output As String = ""
        output = output + UCase(firstname(0)) 'First letter in uppercase
        output = output + LCase(Mid(firstname, 2)) 'Rest of firstname in lower
        output = output + " "                       'Space
        output = output + UCase(lastname(0)) ' First letter in upper
        output = output + LCase(Mid(lastname, 2)) 'Rest of lastname in lower
        Return output
    End Function

    Function CapInitials(ByVal firstname As String, ByVal lastname As String) As String
        Dim output1 As String = ""
        output1 = output1 + UCase(firstname(0))
        output1 = output1 + "."
        output1 = output1 + UCase(lastname(0))
        output1 = output1 + "."
        Return output1
    End Function

    Function InitialSurname(ByVal firstname As String, ByVal lastname As String) As String
        Dim output2 As String = ""
        output2 = output2 + UCase(firstname(0))
        output2 = output2 + ". "
        output2 = output2 + UCase(lastname(0))
        output2 = output2 + LCase(Mid(lastname, 2))
        Return output2
    End Function

    'ComplexInitials was created with help from a friend
    Function ComplexInitials(ByVal firstname As String, ByVal lastname As String) As String
        Dim FullName As String = firstname + " " + lastname
        Dim space As Boolean = True
        Dim charArray() As Char = FullName.ToCharArray 'creates array for chars
        Dim ret As String = ""

        For Each c In charArray
            If (space = True) Then
                ret = ret + c + "."
                space = False
            ElseIf (c = " ") Then
                space = True
            End If
        Next

        Return ret
    End Function

End Module
