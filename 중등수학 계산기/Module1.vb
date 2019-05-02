Module Module1
    Public Function LCM(ByVal num1 As Integer, ByVal num2 As Integer) As Double
        Dim result As Double = num1
        Try
            Do Until result Mod num2 = 0
                result += num1
            Loop
        Catch ex As Exception
            Return -1
        End Try
        Return result
    End Function
End Module
