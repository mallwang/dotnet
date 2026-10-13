Imports Xunit

Public Class GuessGameTests
    ' Random with a fixed seed; the secret is whatever the first Next(1,101) yields.
    Private Shared Function Secret(seed As Integer) As Integer
        Return New Random(seed).Next(1, 101)
    End Function

    Private Shared Function NewGame(seed As Integer) As GuessGame
        Return New GuessGame(New Random(seed))
    End Function

    <Theory>
    <InlineData("")>
    <InlineData("abc")>
    <InlineData("1.5")>
    Public Sub Invalid_input_is_rejected(input As String)
        Assert.Equal(GuessResult.Invalid, NewGame(1).Guess(input))
    End Sub

    <Fact>
    Public Sub Low_high_and_correct_guesses()
        Dim s = Secret(42)
        Dim game = NewGame(42)
        Assert.Equal(GuessResult.TooLow, game.Guess((s - 1).ToString()))
        Assert.Equal(GuessResult.TooHigh, game.Guess((s + 1).ToString()))
        Assert.Equal(GuessResult.Correct, game.Guess(s.ToString()))
    End Sub

    <Fact>
    Public Sub Correct_guess_starts_new_round()
        Dim r = New Random(7)
        Dim first = New Random(7).Next(1, 101)
        Dim game = New GuessGame(r)
        Assert.Equal(GuessResult.Correct, game.Guess(first.ToString()))
        Dim second = New Random(7)
        second.Next(1, 101)
        Assert.Equal(GuessResult.Correct, game.Guess(second.Next(1, 101).ToString()))
    End Sub
End Class
