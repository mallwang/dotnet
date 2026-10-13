''' <summary>One lottery draw: 6 distinct numbers out of 49 (sorted) and a random draw date.</summary>
Public Class LottoDraw
    Public Const Count As Integer = 6
    Public Const MaxNumber As Integer = 49

    Public ReadOnly Property Numbers As IReadOnlyList(Of Integer)
    Public ReadOnly Property DrawDate As DateOnly

    Private Sub New(numbers As IReadOnlyList(Of Integer), drawDate As DateOnly)
        Me.Numbers = numbers
        Me.DrawDate = drawDate
    End Sub

    Public Shared Function Create(Optional random As Random = Nothing) As LottoDraw
        Dim rnd = If(random, Random.Shared)
        Dim pool = Enumerable.Range(1, MaxNumber).ToArray()
        rnd.Shuffle(pool)
        Dim numbers = pool.Take(Count).OrderBy(Function(n) n).ToArray()

        Dim first = New DateOnly(2013, 1, 1)
        Dim last = New DateOnly(2998, 12, 31)
        Dim drawDate = first.AddDays(rnd.Next(last.DayNumber - first.DayNumber + 1))
        Return New LottoDraw(numbers, drawDate)
    End Function
End Class
