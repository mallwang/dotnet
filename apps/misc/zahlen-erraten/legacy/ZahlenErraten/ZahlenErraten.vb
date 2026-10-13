Public Class Gleitzeit

    Dim Zahl As New System.Random
    Dim Zufallszahl As Integer
    Dim Vergleich As Boolean
    Dim EingZahl As Integer

    ' PROGRAMMSTART
    Private Sub Gleitzeit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()
        Zufallszahl = Zahl.Next(1, 100)
        Vergleich = False

    End Sub

    ' BERECHNEN
    Private Sub cmdBerechnen_Click(sender As System.Object, e As System.EventArgs) Handles cmdBerechnen.Click

        EingZahl = txtZahl.Text

        ' Wenn keine Zahl eingegeben worden ist
        If txtZahl.Text = "" Then
            MsgBox("Bitte geben Sie eine Zahl ein!", MsgBoxStyle.Critical)

            ' Ansonsten
        Else
            If EingZahl Like Zufallszahl = True Then
                Vergleich = True
            ElseIf EingZahl < Zufallszahl Then
                MessageBox.Show("Zahl zu gering", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf EingZahl > Zufallszahl Then
                MessageBox.Show("Zahl zu groß", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        ' Bei richtigem Ergebnis
        If Vergleich = True Then
            MessageBox.Show("Herzlichen Glückwunsch!", "Richtig", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Zufallszahl = Zahl.Next(1, 100)
            Vergleich = False
        End If

        txtZahl.SelectAll()

    End Sub

    ' ENDE
    Private Sub cmdEnde_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnde.Click
        Me.Close()
    End Sub
End Class
