
'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Celsius to Fahrenheit Converter
'Date: 09/15/2025
'Author: Michael Catrone
'Operation: This program will take a number value from a user, which represents
'           celsius, and will then convert that value to Fahrenheit.
'
'
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date                      Programmer               Change
'-----------------------------------------------------------------------------
'09/15/2025                Mike Catrone             Initial Build


Module Module1

    Sub Main()

        'Declare variables for celsius and fahrenheit
        Dim celsius As Integer
        Dim fahrenheit As Integer


        'Output title and program description to the user
        Console.WriteLine("-------------------------------------")
        Console.WriteLine("-  Celsius to Fahrenheit Converter  -")
        Console.WriteLine("-------------------------------------")

        Console.WriteLine("This program will take a celsius value and convert to fahrenheit.")


        'Ask user to enter a number for celsius and save to variable
        Console.Write("Please enter a value for celsius and press enter ")
        celsius = Console.ReadLine()


        'Convert celsius value to Fahrenheit using the formula below
        fahrenheit = (celsius * 1.8) + 32


        'Output the result for the user
        Console.WriteLine($"{celsius}c is {fahrenheit}f.")


        'Ask user to press any key to terminate program
        Console.Write("Press any key to exit program ")


        'Waiting on keypress from user
        Console.ReadKey()


    End Sub

End Module
