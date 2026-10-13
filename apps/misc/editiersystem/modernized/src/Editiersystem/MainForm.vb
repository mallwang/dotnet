Imports System.Drawing
Imports System.IO

Public Class MainForm
    Private Const SuperscriptOffset As Integer = 5

    Private ReadOnly _previewFile As String = Path.Combine(Path.GetTempPath(), "Druckvorschau.html")

    Private Shared ReadOnly Colors As New Dictionary(Of String, Color) From {
        {"Schwarz", Color.Black}, {"Rot", Color.Red}, {"Blau", Color.Blue}, {"Gelb", Color.Yellow}, {"Grün", Color.Green}}

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboGroesse.Items.AddRange({"8", "9", "10", "11", "12", "14", "16"})
        cboFarbe.Items.AddRange(Colors.Keys.ToArray())
        cboSchriftart.Items.AddRange({"Arial", "Courier New", "Tahoma", "Times New Roman"})
        cboGroesse.SelectedIndex = 0
        cboFarbe.SelectedIndex = 0
        cboSchriftart.SelectedIndex = 0
    End Sub

#Region "Buttons"

    Private Sub cmdLaden_Click(sender As Object, e As EventArgs) Handles cmdLaden.Click
        Using ofd As New OpenFileDialog With {
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
            .Filter = "html-Datei (*.html)|*.html|Textdatei (*.txt)|*.txt|Alle Dateien (*.*)|*.*",
            .Title = "Datei zum Öffnen auswählen"}
            If ofd.ShowDialog() <> DialogResult.OK Then Return
            Try
                Richtextbox.Text = File.ReadAllText(ofd.FileName)
            Catch ex As Exception When TypeOf ex Is IOException OrElse TypeOf ex Is UnauthorizedAccessException
                ShowError(ex)
            End Try
        End Using
    End Sub

    Private Sub cmdZeichenzaehlen_Click(sender As Object, e As EventArgs) Handles cmdZeichenzaehlen.Click
        MessageBox.Show("Die Zeichenanzahl beträgt: " & Richtextbox.Text.Length)
    End Sub

    Private Sub cmdFett_Click(sender As Object, e As EventArgs) Handles cmdFett.Click
        ForEachSelectedChar(Sub() Richtextbox.SelectionFont = New Font(Richtextbox.SelectionFont, Richtextbox.SelectionFont.Style Xor FontStyle.Bold))
    End Sub

    Private Sub cmdUnterstrichen_Click(sender As Object, e As EventArgs) Handles cmdUnterstrichen.Click
        ForEachSelectedChar(Sub() Richtextbox.SelectionFont = New Font(Richtextbox.SelectionFont, Richtextbox.SelectionFont.Style Xor FontStyle.Underline))
    End Sub

    Private Sub cmdHochstellen_Click(sender As Object, e As EventArgs) Handles cmdHochstellen.Click
        ForEachSelectedChar(
            Sub()
                Dim f = Richtextbox.SelectionFont
                If Richtextbox.SelectionCharOffset = SuperscriptOffset Then
                    Richtextbox.SelectionFont = New Font(f.FontFamily, f.Size + 2, f.Style)
                    Richtextbox.SelectionCharOffset = 0
                Else
                    Richtextbox.SelectionFont = New Font(f.FontFamily, f.Size - 2, f.Style)
                    Richtextbox.SelectionCharOffset = SuperscriptOffset
                End If
            End Sub)
    End Sub

    Private Sub cboGroesse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGroesse.SelectedIndexChanged
        Dim size = Single.Parse(cboGroesse.Text, Globalization.CultureInfo.InvariantCulture)
        ForEachSelectedChar(Sub() Richtextbox.SelectionFont = New Font(Richtextbox.SelectionFont.FontFamily, size, Richtextbox.SelectionFont.Style))
    End Sub

    Private Sub cboFarbe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFarbe.SelectedIndexChanged
        If Richtextbox.SelectionLength > 0 AndAlso cboFarbe.SelectedItem IsNot Nothing Then
            Richtextbox.SelectionColor = Colors(cboFarbe.SelectedItem.ToString())
        End If
    End Sub

    Private Sub cboSchriftart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSchriftart.SelectedIndexChanged
        ForEachSelectedChar(Sub() Richtextbox.SelectionFont = New Font(cboSchriftart.Text, Richtextbox.SelectionFont.Size, Richtextbox.SelectionFont.Style))
    End Sub

    Private Sub cmdSpeiern_Click(sender As Object, e As EventArgs) Handles cmdSpeiern.Click
        Using sfd As New SaveFileDialog With {
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
            .Filter = "Textdatei (*.txt)|*.txt|HTML-Datei (*.html)|*.html|Alle Dateien (*.*)|*.*",
            .FilterIndex = 2,
            .Title = "Wählen Sie eine Datei zum Speichern aus"}
            If sfd.ShowDialog() <> DialogResult.OK Then Return
            Try
                File.WriteAllText(sfd.FileName, ToHtml(), New System.Text.UTF8Encoding(False))
                MessageBox.Show("Gespeichert!")
            Catch ex As Exception When TypeOf ex Is IOException OrElse TypeOf ex Is UnauthorizedAccessException
                ShowError(ex)
            End Try
        End Using
    End Sub

    Private Sub cmdDruckvorschau_Click(sender As Object, e As EventArgs) Handles cmdDruckvorschau.Click
        Try
            File.WriteAllText(_previewFile, ToHtml(), New System.Text.UTF8Encoding(False))
            Process.Start(New ProcessStartInfo(_previewFile) With {.UseShellExecute = True})
        Catch ex As Exception When TypeOf ex Is IOException OrElse TypeOf ex Is UnauthorizedAccessException OrElse TypeOf ex Is ComponentModel.Win32Exception
            ShowError(ex)
        End Try
    End Sub

    Private Sub cmdEnde_Click(sender As Object, e As EventArgs) Handles cmdEnde.Click
        Close()
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            File.Delete(_previewFile)
        Catch ex As IOException
            ' preview still open in the browser; leave it in the temp folder
        End Try
    End Sub

#End Region

    Private Shared Sub ShowError(ex As Exception)
        MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ''' <summary>Runs the action for each selected character one by one, then restores the selection.</summary>
    Private Sub ForEachSelectedChar(action As Action)
        Dim start = Richtextbox.SelectionStart
        Dim length = Richtextbox.SelectionLength
        If length = 0 Then Return
        For pos = start To start + length - 1
            Richtextbox.Select(pos, 1)
            action()
        Next
        Richtextbox.Select(start, length)
    End Sub

    Private Function ToHtml() As String
        Dim start = Richtextbox.SelectionStart
        Dim length = Richtextbox.SelectionLength
        Dim text = Richtextbox.Text
        Dim formats As New List(Of CharFormat)(text.Length)
        For i = 0 To text.Length - 1
            Richtextbox.Select(i, 1)
            Dim f = Richtextbox.SelectionFont
            formats.Add(New CharFormat With {
                .Bold = f.Bold,
                .Underline = f.Underline,
                .Superscript = Richtextbox.SelectionCharOffset = SuperscriptOffset,
                .Color = ColorTranslator.ToHtml(Color.FromArgb(Richtextbox.SelectionColor.ToArgb())),
                .FontFamily = f.FontFamily.Name,
                .SizePt = f.Size})
        Next
        Richtextbox.Select(start, length)
        Return HtmlExporter.Export(text, formats)
    End Function
End Class
