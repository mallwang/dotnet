Imports System.Drawing

Public Class MainForm
    Private Sub cmdFett_Click(sender As Object, e As EventArgs) Handles cmdFett.Click
        Dim start = rtxt1.SelectionStart
        Dim length = rtxt1.SelectionLength
        ' format char by char so other styles (e.g. italic) in the selection are kept
        For pos = start To start + length - 1
            rtxt1.Select(pos, 1)
            rtxt1.SelectionFont = New Font(rtxt1.SelectionFont, FontStyle.Bold)
        Next
        rtxt1.Select(start, length)
    End Sub

    Private Sub cmdSpeichern_Click(sender As Object, e As EventArgs) Handles cmdSpeichern.Click
        Using sfd As New SaveFileDialog With {
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
            .Filter = "Textdatei (*.txt)|*.txt|HTML-Datei (*.html)|*.html|Alle Dateien (*.*)|*.*",
            .FilterIndex = 2,
            .Title = "Wählen Sie eine Datei zum Speichern aus"}
            If sfd.ShowDialog() <> DialogResult.OK Then Return
            Try
                TextFileSaver.Save(sfd.FileName, rtxt1.Text)
                MessageBox.Show("Gespeichert")
            Catch ex As IO.IOException
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As UnauthorizedAccessException
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
