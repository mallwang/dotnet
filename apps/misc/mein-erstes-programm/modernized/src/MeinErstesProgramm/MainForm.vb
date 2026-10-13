Public Class MainForm
    Private Sub cmdDateiliste_Click(sender As Object, e As EventArgs) Handles cmdDateiliste.Click
        lstDateiliste.Items.Clear()
        Dim files As String()
        Try
            files = ListFiles(TextBox1.Text)
        Catch ex As Exception When TypeOf ex Is IO.IOException OrElse TypeOf ex Is UnauthorizedAccessException OrElse TypeOf ex Is ArgumentException
            MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        If files Is Nothing Then
            MessageBox.Show("Das Verzeichnis " & TextBox1.Text & " existiert nicht")
        Else
            lstDateiliste.Items.AddRange(files)
        End If
    End Sub

    Private Sub cmdInfo_Click(sender As Object, e As EventArgs) Handles cmdInfo.Click
        If lstDateiliste.SelectedIndex = -1 Then
            MessageBox.Show("Es wurde kein Eintrag ausgewählt")
        Else
            lblAnzeige.Text = Describe(lstDateiliste.Text)
        End If
    End Sub

    Private Sub cmdVerzeichnisWaehlen_Click(sender As Object, e As EventArgs) Handles cmdVerzeichnisWaehlen.Click
        Using fbd As New FolderBrowserDialog With {
            .RootFolder = Environment.SpecialFolder.Desktop,
            .ShowNewFolderButton = False,
            .Description = "Verzeichnis auswählen"}
            If fbd.ShowDialog() = DialogResult.OK Then
                TextBox1.Text = fbd.SelectedPath
            Else
                TextBox1.Clear()
                lstDateiliste.Items.Clear()
                lblAnzeige.Text = ""
            End If
        End Using
    End Sub

    Private Sub cmdEnde_Click(sender As Object, e As EventArgs) Handles cmdEnde.Click
        Close()
    End Sub
End Class
