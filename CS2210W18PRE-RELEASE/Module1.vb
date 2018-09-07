Module Module1

    Sub Main()
        Dim _min_age As Integer = 4
        Dim _max_age As Integer = 14

        Dim contestants_name(19) As String
        Dim contestants_age(19) As Integer
        Dim contestants_checkdigit(19) As String
        Dim contestants_run(19) As Integer
        Dim contestants_personalbesttime(19) As Double

        For index = 0 To 29 'Accept 20 contestants registration
            Console.WriteLine("Please enter the name for Contestant " & index + 1)
            contestants_name(index) = Console.ReadLine 'Read user input
Age:
            Console.WriteLine("Enter the age for Contestant " & contestants_name(index))
            Dim age = Convert.ToInt32(Console.ReadLine) 'read and convert user input to integer
            If age < _min_age Or age > _max_age Then 'check if age is within accepted range
                Console.WriteLine("Age is out of range, should be between 4 to 15 years old!")
                GoTo Age 'go back to age input
            Else
                contestants_age(index) = age
            End If

            'initialise to zero
            contestants_run(index) = 0
            contestants_personalbesttime(index) = 0

            'calculate checkdigit
            Dim digit3, digit2, digit1, checkdigit As Integer
            Dim remainder As Integer
            digit3 = index / 2
            digit2 = age / 2
            digit1 = index Mod age

            remainder = ((digit3 * 4) + (digit2 * 3) + (digit1 * 2)) Mod 10
            checkdigit = 10 - remainder

            contestants_checkdigit(index) = digit3 & digit2 & digit1 & checkdigit

            'display check digit and accept next registration
            Console.WriteLine("Contestant " & index & " was registered with UID: " & contestants_checkdigit(index))

            index = index + 1
        Next index
    End Sub

End Module
