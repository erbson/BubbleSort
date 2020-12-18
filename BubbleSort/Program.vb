Imports System

Module Program

    Dim vetor = New Integer() {9, 7, 2, 8, 1, 5, 1, 6}

    Sub Main(args As String())
        Dim i As Integer
        Ordenar(vetor)
        For i = 1 To UBound(vetor)
            Console.WriteLine(vetor(i))
        Next
    End Sub

    Private Sub Ordenar(vetor() As Integer)
        Dim j As Integer
        Dim Auxilar As Integer
        For i = 1 To UBound(vetor)
            For j = 0 To UBound(vetor) - 1
                If vetor(j) > vetor(j + 1) Then
                    Auxilar = vetor(j)
                    vetor(j) = vetor(j + 1)
                    vetor(j + 1) = Auxilar
                End If
            Next

        Next


    End Sub
End Module
