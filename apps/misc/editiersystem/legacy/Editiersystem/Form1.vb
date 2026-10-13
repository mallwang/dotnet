Imports System.IO

Public Class Form1

    Dim Inhalt As String = ""

    ' PROGRAMMSTART
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Größen hinzufügen
        cboGroesse.Items.Add("8")
        cboGroesse.Items.Add("9")
        cboGroesse.Items.Add("10")
        cboGroesse.Items.Add("11")
        cboGroesse.Items.Add("12")
        cboGroesse.Items.Add("14")
        cboGroesse.Items.Add("16")
        cboGroesse.SelectedIndex = 0

        'Farben hinzufügen
        cboFarbe.Items.Add("Schwarz")
        cboFarbe.Items.Add("Rot")
        cboFarbe.Items.Add("Blau")
        cboFarbe.Items.Add("Gelb")
        cboFarbe.Items.Add("Grün")
        cboFarbe.SelectedIndex = 0

        'Schriftarten hinzufügen
        cboSchriftart.Items.Add("Arial")
        cboSchriftart.Items.Add("Courier New")
        cboSchriftart.Items.Add("Tahoma")
        cboSchriftart.Items.Add("Times New Roman")
        'cboSchriftart.Items.Add("Frutiger 45 Light")
        cboSchriftart.SelectedIndex = 0

    End Sub

#Region "Buttons"

    ' Button Laden
    Private Sub cmdLaden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLaden.Click

        Try
            Dim Text As String = ""
            Dim ofd As New OpenFileDialog


            ofd.InitialDirectory = "Desktop"
            ofd.Filter = "html-Datei (*.html)|*.html|" & "Textdatei (*.txt)|*.txt|" & " Alle Dateien (*.*)|*.*"
            ofd.Title = "Datei zum Öffnen auswählen"

            If ofd.ShowDialog() = DialogResult.OK Then

                'Text = File.ReadAllText(ofd.FileName)
                'If Text.Contains("<b>") Then
                '    Text = Text.Split("<b>")(1).Split("</b>")(0)
                '    rtxt.Text = Text
                'Else
                '    MsgBox("kein inhalt")
                'End If

                Text = File.ReadAllText(ofd.FileName)

                'Text = Text.Replace("<b>", "")
                'Text = Text.Replace("</b>", "")
                'Text = Text.Replace("<u>", "")
                'Text = Text.Replace("</u>", "")

                Richtextbox.Text = Text

            End If
        Catch ex As Exception
            MessageBox.Show("storeQueryString: " + ex.Message + " StackTrace: " + ex.StackTrace)
        End Try

    End Sub

    ' Button Zeichen zaehlen
    Private Sub cmdZeichenzaehlen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZeichenzaehlen.Click
        MsgBox("Die Zeichenanzahl beträgt: " & zeichenZaehlen(Richtextbox))
    End Sub

    ' Button Fett
    Private Sub cmdFett_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFett.Click
        If Not formatieren(Richtextbox.SelectedText, FontStyle.Bold, 0) Then
        End If
    End Sub

    ' Button Unterstrichen
    Private Sub cmdUnterstrichen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnterstrichen.Click
        If Not formatieren(Richtextbox.SelectedText, FontStyle.Underline, 0) Then
        End If
    End Sub

    ' Button Hochstellen
    Private Sub cmdHochstellen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHochstellen.Click
        If Not formatieren(Richtextbox.SelectedText, Nothing, 3) Then
        End If
    End Sub

    ' Combobox Groesse
    Private Sub cboGroesse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGroesse.SelectedIndexChanged
        If Not formatieren(Richtextbox.SelectedText, Nothing, 1) Then
        End If
    End Sub

    ' Combobox Farbe
    Private Sub cboFarbe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFarbe.SelectedIndexChanged
        If Not textFarbig(Richtextbox.SelectedText) Then
        End If
    End Sub

    ' Combobox Schriftart
    Private Sub cboSchriftart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSchriftart.SelectedIndexChanged
        If Not formatieren(Richtextbox.SelectedText, Nothing, 2) Then
        End If
    End Sub

    ' Button Speichern
    Private Sub cmdSpeiern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSpeiern.Click


        System.IO.File.Delete("C:\temp\Druckvorschau.html")

        Try
            ' Speichern-Dialog öffnet sich
            Dim sfd As New SaveFileDialog
            sfd.InitialDirectory = "Desktop"
            sfd.Filter = " Textdatei (*.txt)|*.txt| " _
                & "HTML-Datei (*.html)|*.html| " _
                & "Alle Dateien (*.*)|*.*"
            sfd.FilterIndex = 2
            sfd.Title = "Wählen Sie eine Datei zum Speichern aus"
            If sfd.ShowDialog() = DialogResult.OK Then
                System.IO.File.WriteAllText(sfd.FileName, speichern(Richtextbox), System.Text.Encoding.UTF8)
                MsgBox("Gespeichert!")
            End If
        Catch ex As Exception
            MessageBox.Show("storeQueryString: " + ex.Message + " StackTrace: " + ex.StackTrace)
        End Try

    End Sub

    ' Button druckvorschau
    Private Sub cmdDruckvorschau_Click(sender As System.Object, e As System.EventArgs) Handles cmdDruckvorschau.Click
        druckvorschau()
    End Sub

    ' Button ende
    Private Sub cmdEnde_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnde.Click
        programmende()
    End Sub

#End Region


#Region "Functions"

    ' textmitte ermitteln
    ''' <summary>
    ''' Die Richtextbox wird zu einem String geparst. Ab dessen Hälfte wird der Index des
    ''' nächsten Leerzeichens gesucht. Dieser Wert stellt die Textmitte in abhängigkeit
    ''' der eingegebenen Wörter dar.
    ''' </summary>
    ''' <param name="Richtextbox">sichtbare RichTextBox der Oberfläche</param>
    ''' <returns>Index der wörterabhängigen Textmitte</returns>
    ''' <remarks></remarks>
    Private Function textmitte(ByVal Richtextbox As RichTextBox) As Integer
        Dim inhalt As String = Richtextbox.Text
        Dim healfte As Integer = inhalt.Length / 2
        Dim teiler As Integer = 0
        'Dim erhoehen As Integer = 0

        For h As Integer = healfte To inhalt.Length - 1
            If inhalt(h) = " "c Then
                teiler = h
                'teiler += erhoehen
                Return teiler
            End If
        Next
        Return inhalt.Length


    End Function

    ' arrayvergleich
    ''' <summary>
    ''' Beide Übergebene Arrays werden auf die Übereinstimmung ihres Inhalts hin geprüft.
    ''' </summary>
    ''' <param name="format">Array des Hauptzeichens</param>
    ''' <param name="format2">Array des Folgezeichens</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function arrayvergleich(ByVal format() As String, ByVal format2() As String)
        For i As Integer = 0 To format.LongCount - 1
            If format(i) = format2(i) Then
            Else
                Return False
            End If
        Next
        Return True
    End Function

    ' umwandlungHtml
    ''' <summary>
    ''' Hier werden anhand der Parameter das Arrays die HTML-Steuerzeichen eingefügt.
    ''' </summary>
    ''' <param name="Text">Identisch zu formatierende Zeichenkette</param>
    ''' <param name="format">Array mit stilistischen Parameter</param>
    ''' <remarks></remarks>
    Private Sub umwandlungHtml(ByVal Text As String, ByVal format() As String)

        Dim praefix As String = "" 'vorangestellter html-Code
        Dim suffix As String = "" 'nachgestellter html-Code
        Dim farbe As String = ""
        Dim schriftart As String = ""

        'Hier findet das formatieren statt
        ' fett?
        If format(3) = "True" Then
            praefix &= "<b>"
            suffix &= "</b>"
        End If
        ' unterstrichen?
        If format(4) = "True" Then
            praefix &= "<u>"
            suffix &= "</u>"
        End If
        ' hochgestellt
        If format(5) = "5" Then
            praefix &= "<sup>"
            suffix &= "</sup>"
        End If

        ' Schriftfarbe
        If format(0) = "Color [Black]" Then
            farbe = "black"
        ElseIf format(0) = "Color [Red]" Then
            farbe = "red"
        ElseIf format(0) = "Color [Blue]" Then
            farbe = "blue"
        ElseIf format(0) = "Color [Yellow]" Then
            farbe = "yellow"
        ElseIf format(0) = "Color [Green]" Then
            farbe = "green"
        End If

        ' Schriftart
        If format(2) = "[FontFamily: Name=Microsoft Sans Serif]" Then
            schriftart = "Microsoft Sans Serif"
        ElseIf format(2) = "[FontFamily: Name=Courier New]" Then
            schriftart = "Courier New"
        ElseIf format(2) = "[FontFamily: Name=Arial]" Then
            schriftart = "Arial"
        ElseIf format(2) = "[FontFamily: Name=Tahoma]" Then
            schriftart = "Tahoma"
        ElseIf format(2) = "[FontFamily: Name=Times New Roman]" Then
            schriftart = "Times New Roman"
        End If

        praefix &= "<span style=""white-space: wrap; font-size:" & format(1) & "pt; color:" & farbe & "; font-family:" & schriftart & """>"
        suffix = "</span>" & suffix
        txt.AppendText(praefix + Text + suffix)

    End Sub

    ' zeichenZaehlen
    ''' <summary>
    ''' Der Inhalt der 
    ''' </summary>
    ''' <param name="Richtextbox"></param>
    ''' <returns>Anzahl an eingegebenen Zeichen des kompletten Textes</returns>
    ''' <remarks></remarks>
    Private Function zeichenZaehlen(ByVal Richtextbox As RichTextBox) As Integer
        Dim gesamttext As String = Richtextbox.Text
        Dim anzahl As Integer
        anzahl = gesamttext.Count
        Return anzahl
    End Function

    ' textFarbig
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="markText"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function textFarbig(markText As String) As Boolean
        If markText = "" Then
            Return False
        Else
            If cboFarbe.SelectedItem.ToString = "Schwarz" Then
                Richtextbox.SelectionColor = Color.Black
            ElseIf cboFarbe.SelectedItem.ToString = "Rot" Then
                Richtextbox.SelectionColor = Color.Red
            ElseIf cboFarbe.SelectedItem.ToString = "Blau" Then
                Richtextbox.SelectionColor = Color.Blue
            ElseIf cboFarbe.SelectedItem.ToString = "Gelb" Then
                Richtextbox.SelectionColor = Color.Yellow
            ElseIf cboFarbe.SelectedItem.ToString = "Grün" Then
                Richtextbox.SelectionColor = Color.Green
            End If
        End If
        Return True
    End Function

    ' formatieren
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="markText">Markierte Zeichenkette</param>
    ''' <param name="fontStyle"></param>
    ''' <param name="art">Änderungsart (0=font 1=groesse 2=schriftart 3=hochgestellt)</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function formatieren(ByVal markText As String, _
                                 ByVal fontStyle As FontStyle, _
                                 ByVal art As Integer) As Boolean
        If markText = "" Then
            Return False
        Else
            Dim selectionStart = Richtextbox.SelectionStart
            Dim selectionLength = Richtextbox.SelectionLength
            Dim selectionEnd = selectionStart + selectionLength - 1

            ' Schleife formatiert jedes markierte Zeichen
            '0=font 1=groesse 2=schriftart 3=hochgestellt
            For pos As Integer = selectionStart To selectionEnd
                Richtextbox.Select(pos, 1)
                If art = 0 Then '0=font
                    Richtextbox.SelectionFont = New Font(Richtextbox.SelectionFont, _
                                                  Richtextbox.SelectionFont.Style Xor fontStyle)
                ElseIf art = 1 Then '1=groesse
                    Dim currentFont As System.Drawing.Font = Richtextbox.SelectionFont
                    Richtextbox.SelectionFont = New Font(currentFont.FontFamily, _
                                                  CSng(cboGroesse.Text), _
                                                  Richtextbox.SelectionFont.Style)
                ElseIf art = 2 Then '2=schriftart
                    Richtextbox.SelectionFont = New Font(cboSchriftart.Text, _
                                                  Richtextbox.SelectionFont.Size, _
                                                  Richtextbox.SelectionFont.Style)
                ElseIf art = 3 Then '3=hochgestellt
                    Dim currentFont As System.Drawing.Font = Richtextbox.SelectionFont
                    If Richtextbox.SelectionCharOffset = 5 Then
                        Richtextbox.SelectionFont = New Font(currentFont.FontFamily, _
                                                      Richtextbox.SelectionFont.Size, _
                                                      Richtextbox.SelectionFont.Style)
                        Richtextbox.SelectionCharOffset = 0
                    Else
                        Richtextbox.SelectionFont = New Font(currentFont.FontFamily, _
                                                      (Richtextbox.SelectionFont.Size - 2), _
                                                      Richtextbox.SelectionFont.Style)
                        Richtextbox.SelectionCharOffset = 5
                    End If
                End If
            Next
        End If
        Return True
    End Function


    ' speichern
    ''' <summary>
    ''' Zunächst wird die nicht sichtbare Textbox mit HTML-Steuerzeichen gefüllt.
    ''' Anschließend erfolgt die Feststellung der Formatierung.
    ''' Hilfmittel hierfür sind 2 Arrays, die die Werte für die Schriftauszeichnung enthalten.
    ''' Letztlich erfolgt die Auszeichnung der Textelemente durch Verwendung der 
    ''' Funktion "umwandlungHtml".
    ''' Die Textbox erhält somit den eingegebenen Text und die HTML-Steuerzeichen.
    ''' </summary>
    ''' <param name="Richtextbox">Die sichtbare RichTextBox der Oberfläche</param>
    ''' <returns>
    ''' Nach erfolgreichem Durchlauf erfolgt die Rückgabe eines Strings
    ''' Dieser enthält den Inhalt der nicht sichtbaren Textbox.
    ''' </returns>
    ''' <remarks></remarks>
    Private Function speichern(ByVal Richtextbox As RichTextBox) As String

        ' in die nicht sichtbare Richtextbox "txt" kommt sämtlicher text mit den html-Steuerzeichen
        ' zuerst leeren
        txt.Text = ""
        ' html-Steuerzeichen einfügen sowie Tabelle und linke Spalte erstellen
        txt.AppendText("<html><head></head><body>")
        txt.AppendText("<table border=""0"" cellspacing=""15"">")
        txt.AppendText("<td width=""50%"" valign=""top"">")
        txt.AppendText("<p style=""line-height:1.4em; align=""justify"""">")

        ' Suche texthälfte
        Dim Teiler As Integer = 0
        Teiler = textmitte(Richtextbox)

        ' für jedes Zeichen der Richtextbox
        Dim i As Integer = 0
        Richtextbox.SelectionStart = i
        Richtextbox.SelectionLength = 1
        Dim ft As Font = Richtextbox.SelectionFont ' Schriftauszeichnung (f, u)
        Dim cl As Color = Richtextbox.SelectionColor ' Farbe
        Dim sz As Integer = Richtextbox.SelectionFont.Size ' Größe
        Dim sa As FontFamily = Richtextbox.SelectionFont.FontFamily ' Schriftart
        Dim hg As Integer = Richtextbox.SelectionCharOffset ' Hochgestellt
        Dim Text As String = ""
        Dim format(5), format2(5) As String ' Arrays mit stilistischen Parametern

        format(0) = cl.ToString
        format(1) = sz
        format(2) = sa.ToString
        format(3) = ft.Bold
        format(4) = ft.Underline
        format(5) = hg

        format2(0) = cl.ToString
        format2(1) = sz
        format2(2) = sa.ToString
        format2(3) = ft.Bold
        format2(4) = ft.Underline
        format2(5) = hg

        ' Schleifendurchlauf und Test der 
        Do Until i = Richtextbox.Text.Length

            Richtextbox.SelectionStart = i
            Richtextbox.SelectionLength = 1
            Dim ft2 As Font = Richtextbox.SelectionFont
            Dim cl2 As Color = Richtextbox.SelectionColor
            Dim sz2 As Integer = Richtextbox.SelectionFont.Size
            Dim sa2 As FontFamily = Richtextbox.SelectionFont.FontFamily
            Dim hg2 As Integer = Richtextbox.SelectionCharOffset

            format2(0) = cl2.ToString
            format2(1) = sz2
            format2(2) = sa2.ToString
            format2(3) = ft2.Bold
            format2(4) = ft2.Underline
            format2(5) = hg2

            If arrayvergleich(format, format2) = True Then
                Text = Text & Richtextbox.SelectedText
                i += 1

            Else
                umwandlungHtml(Text, format)
                Text = ""
                format(0) = format2(0)
                format(1) = format2(1)
                format(2) = format2(2)
                format(3) = format2(3)
                format(4) = format2(4)
                format(5) = format2(5)
            End If

            If i = Teiler Then
                ' text hinzufügen
                umwandlungHtml(Text, format)
                Text = ""
                ' linke Spalte schließen
                txt.AppendText("</p>" & "</td>")

                ' rechte Spalte öffnen
                txt.AppendText("<td width=""50%"" valign=""top"">")
                txt.AppendText("<p style=""line-height:1.4em; align=""justify"""">")
            End If
        Loop
        umwandlungHtml(Text, format)
        Text = ""
        ' rechte Spalte sowie Tabelle schließen und html beenden
        txt.AppendText("</p>" & "</td>" & "</table>" & "</body>" & "</html>")

        Return txt.Text
    End Function

    'druckvorschau
    ''' <summary>
    ''' Hier wird zunächst eine HTML-Datei in dem temporären Ordner auf C: erstellt.
    ''' Diese verwendet die Funktion "speichern".
    ''' Letztlich wird diese Datei mithilfe einer Shell geöffnet.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub druckvorschau()
        System.IO.File.WriteAllText("C:\temp\Druckvorschau.html", speichern(Richtextbox), System.Text.Encoding.UTF8)
        Dim Shell As Shell32.Shell = New Shell32.Shell
        Shell.Open("C:\temp\Druckvorschau.html")
    End Sub

    ' programmende
    Private Sub programmende()
        System.IO.File.Delete("C:\temp\Druckvorschau.html")
        Me.Close()
    End Sub

#End Region

End Class
