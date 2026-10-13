Public Class MainForm
    Private ReadOnly _game As New GuessGame()

    Private Sub cmdBerechnen_Click(sender As Object, e As EventArgs) Handles cmdBerechnen.Click
        Select Case _game.Guess(txtZahl.Text)
            Case GuessResult.Invalid
                MessageBox.Show("Bitte geben Sie eine Zahl ein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case GuessResult.TooLow
                MessageBox.Show("Zahl zu gering", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case GuessResult.TooHigh
                MessageBox.Show("Zahl zu groß", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case GuessResult.Correct
                MessageBox.Show("Herzlichen Glückwunsch!", "Richtig", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
        txtZahl.SelectAll()
    End Sub

    Private Sub cmdEnde_Click(sender As Object, e As EventArgs) Handles cmdEnde.Click
        Close()
    End Sub
End Class
