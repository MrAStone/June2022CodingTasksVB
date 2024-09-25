Imports System.Diagnostics.Eventing
Imports System.Net.NetworkInformation
Imports Microsoft.VisualBasic.ApplicationServices

Module Module1

    Sub Main()

    End Sub
    Sub q3()
        Dim charge As Integer
        Console.WriteLine("Enter your car registration: ")
        Dim carReg As String = Console.ReadLine
        While carReg.Length() > 8
            '3.1
            Dim displayMessage As String = " is not valid"

            Console.WriteLine(displayMessage)
            carReg = Console.ReadLine
        End While
        Console.Write("Enter your stay in hours: ")
        Dim hours As Integer = Console.ReadLine
        If hours < 2 Then
            charge = 0
        Else
            '3.2
            charge = hours * 2
        End If
        Console.WriteLine(charge)

    End Sub
    Sub q5()
        Dim numbers = New Integer() {11, 14, 56, 4, 12, 6, 42, 2}
        Dim count As Integer = 0
        Dim r As Random = New Random()
        While count < 10
            count = count + 1
            Dim number As Integer = r.Next(0, 8) ' fixed syntax error
            Console.WriteLine(numbers(count))
        End While
        ' 5.2
    End Sub
    Sub q7()
        'Write a VB.Net program to check if an email address 
        'has been entered correctly by a User.
        '        Your program must: 
        '• get the user to input an email address
        '• get the user to input the email address a second time
        '• output the message Match And output the email address if the email
        'addresses entered are the same
        '• output the message Do Not match if the email addresses entered are
        'Not the same.
        'You should use meaningful variable name(s) And VB.Net syntax in your answer.


    End Sub
    Sub q8()
        'Write a VB.Net program that calculates the value of a bonus payment for an
        'employee based on how many items they have sold And the number of years they
        'have been employed.
        'The program should: 
        '• get the user to input the number of items sold
        '• get the user to input the number of years employed
        '• output the value of the bonus payment
        'o If the years of employment Is less than Or equal to 2 And the number of items
        'sold Is greater than 100, then the bonus will be the number of items sold
        'multiplied by 2
        'o If the years of employment Is greater than 2, then the bonus will be the number of
        'items sold multiplied by 10
        'o otherwise, the bonus Is 0
        'You should use meaningful variable name(s) And VB.Net syntax in your answer.


    End Sub
    Sub q13P1()
        'A program Is being developed in VB.Net to simulate a card game.
        'Throughout the game each player always has 100 cards. Each card displays a
        'Number.
        'Players take it in turns to swap one of their cards with another random card from a set
        'of cards until a player has a run of five numbers in sequence within their 100 cards.
        '1 3 . 1 Figure 14 shows part of the program that will get a player to enter the position
        'of a card to swap.
        'Figure 14
        Console.Write("Enter card position: ")
        Dim position As Integer = Console.ReadLine()
        '        Extend the program in Figure 14. Your answer must be written in VB.Net.
        'The program should keep getting the user to enter the card position until they
        'enter a card position that Is between 1 And 100 inclusive.
        'You should use meaningful variable name(s) And VB.Net syntax in your
        'answer.
        '13.1
    End Sub
    Sub q13p2()
        ' https://filestore.aqa.org.uk/sample-papers-And-mark-schemes/2022/june/AQA-85251C-QP-JUN22.PDF

    End Sub
    Sub q14P1()
        Dim ticket As String(,) = New String(,) {{"", "", ""}, {"", "", ""}, {"", "", ""}}
        Dim i As Integer = 0
        While (i < 3)
            Dim j As Integer '= ____
            While (j < 3)
                ' ticket(____, ____) = generateKeyTerm()
                '______________
            End While
            '______________
        End While
    End Sub
    Function generateKeyTerm() ' used for q14.1
        Dim rnd As New Random
        Dim terms As Integer() = {"CPU", "ALU", "LAN", "Register", "Cache"}
        Dim num As Integer = rnd.Next(0, terms.Length)
        Return terms(num)

    End Function
    'q14.2

End Module
