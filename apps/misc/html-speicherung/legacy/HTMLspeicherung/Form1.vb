Public Class Form1

    Private Sub cmdFett_Click(sender As System.Object, e As System.EventArgs) Handles cmdFett.Click
        Try
            'rtxt.SuspendLayout()

            ' markierter Text wird zwischengespeichert
            Dim selectionStart = rtxt1.SelectionStart
            Dim selectionLength = rtxt1.SelectionLength
            Dim selectionEnd = selectionStart + selectionLength - 1

            ' Schleife formatiert jedes markierte Zeichen in fett
            For pos = selectionStart To selectionEnd
                rtxt1.Select(pos, 1)
                rtxt1.SelectionFont = New Font(rtxt1.SelectionFont, FontStyle.Bold)
            Next

            'RichTextBox.Select(selectionStart, selectionLength)
            'rtxt.ResumeLayout()
        Catch ex As Exception
            MessageBox.Show("storeQueryString: " + ex.Message + " StackTrace: " + ex.StackTrace)
        End Try

    End Sub

    Private Sub cmdSpeichern_Click(sender As System.Object, e As System.EventArgs) Handles cmdSpeichern.Click

        Dim sfd As New SaveFileDialog
        sfd.InitialDirectory = "Desktop"
        sfd.Filter = " Textdatei (*.txt)|*.txt| " _
            & "HTML-Datei (*.html)|*.html| " _
            & "Alle Dateien (*.*)|*.*"
        sfd.FilterIndex = 2
        sfd.Title = "Wählen Sie eine Datei zum Speichern aus"
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim sra1 As New IO.StreamWriter(sfd.FileName)
            sra1.Write(rtxt1.Text)
            sra1.Close()
            'System.IO.File.AppendAllText(sfd.FileName, rtxt1.Text, System.Text.Encoding.UTF8)
            MsgBox("Gespeichert")
        End If

    End Sub
End Class
