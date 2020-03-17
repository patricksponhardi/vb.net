Imports System

Module Program
    Sub Main(args As String())
        Dim S As New Serie

        Console.WriteLine("TCM-SP")
        Console.WriteLine("SomaNTermos1({0}): " & S.somaNtermos1(978), 978)
        Console.WriteLine("SomaNTermos2(978): " & S.somaNtermos2(978) + ControlChars.NewLine + "Nova Linha (ControlChars.NewLine)")
    End Sub

    Public Class Serie

        Dim count As Integer = 1
        Dim varSoma As Double = 1
        Dim varIteradorAux As Double = 0
        Dim varIterador As Double = 4

        Function somaNtermos1(ByVal n As Integer) As String
            Me.count += 1
            If Me.count > n Then
                Return CStr(Me.varSoma)
            End If

            Me.varSoma += 1 / Me.varIterador

            Me.varIteradorAux += 1
            Me.varIterador += Me.count + Me.varIteradorAux + 2

            Return somaNtermos1(n)
        End Function

        Function somaNtermos2(ByVal n As Integer) As String

            Dim varSoma As Double = 1
            Dim varIteradorAux As Double = 0
            Dim varIterador As Double = 4

            For index = 2 To n
                varSoma += 1 / varIterador

                varIteradorAux += 1
                varIterador += index + varIteradorAux + 2
            Next

            Return CStr(varSoma)
        End Function
    End Class
End Module


