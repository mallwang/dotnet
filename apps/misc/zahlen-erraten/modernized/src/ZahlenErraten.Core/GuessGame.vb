Public Enum GuessResult
    Invalid
    TooLow
    TooHigh
    Correct
End Enum

''' <summary>Pure game logic: a secret number between 1 and 100 (inclusive).</summary>
Public Class GuessGame
    Public Const MinValue As Integer = 1
    Public Const MaxValue As Integer = 100

    Private ReadOnly _random As Random
    Private _secret As Integer

    Public Sub New(Optional random As Random = Nothing)
        _random = If(random, Random.Shared)
        NewRound()
    End Sub

    Public Sub NewRound()
        _secret = _random.Next(MinValue, MaxValue + 1)
    End Sub

    ''' <summary>Checks the input; starts a new round on a correct guess.</summary>
    Public Function Guess(input As String) As GuessResult
        Dim value As Integer
        If Not Integer.TryParse(input, value) Then Return GuessResult.Invalid
        If value < _secret Then Return GuessResult.TooLow
        If value > _secret Then Return GuessResult.TooHigh
        NewRound()
        Return GuessResult.Correct
    End Function
End Class
