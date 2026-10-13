Public Class Kaffeetest

    Dim strGröße As String = ""
    Dim zusatz As String = ""
    Dim fSchalter As Boolean
    Dim Hugo As New Class1


    ' OK
    Private Sub cmdOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

        Dim Name As String = txtName.Text
        Dim strGetränk As String = ""

        ' Prüfen, ob Name befüllt wurde
        If (txtName.Text.Length) < 2 Then
            MessageBox.Show(text:="Bitte Namen eingeben!", _
                            caption:="Fehler", _
                            buttons:=MessageBoxButtons.OK, _
                            icon:=MessageBoxIcon.Error)
            txtName.Select()


            ' Prüfen, ob Betrag befüllt wurde
        ElseIf txtBetrag.Text = "" Then
            MessageBox.Show(text:="Bitte Betrag einwerfen!", _
                                        caption:="Fehler", _
                                        buttons:=MessageBoxButtons.OK, _
                                        icon:=MessageBoxIcon.Error)
            txtBetrag.Select()


            ' Bei richtigen Eingaben
        Else
            If optKaffee.Checked = True Then
                strGetränk = "Kaffee"
            ElseIf optTee.Checked = True Then
                strGetränk = "Tee"
            ElseIf optWasser.Checked = True Then
                strGetränk = "Wasser"
            ElseIf optCola.Checked = True Then
                strGetränk = "Cola"
            Else
                strGetränk = "Suppe"
            End If

            If chkMilch.Checked = True Then
                zusatz = " mit Milch"
            Else
                zusatz = ""
            End If

            If chkZucker.Checked = True Then
                zusatz = zusatz & " mit Zucker"
            End If

            MessageBox.Show("Hallo " & Name & Environment.NewLine & "Du bekommst " & strGröße & _
                            strGetränk & zusatz, "Getränk", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    ' ABBRECHEN
    Private Sub cmdAbbrechen_Click(sender As System.Object, e As System.EventArgs) Handles btnAbbrechen.Click

        Me.Close() ' Programm schließt sich

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtBetrag.Text = "1"
        txtName.Select()
    End Sub


    Private Sub optJumbo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optJumbo.CheckedChanged
        strGröße = "1,0 Liter "
    End Sub

    Private Sub optGroß_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optGroß.CheckedChanged
        strGröße = "0,5 Liter "
    End Sub

    Private Sub optMittel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optMittel.CheckedChanged
        strGröße = "0,33 Liter "
    End Sub

    Private Sub optKlein_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optKlein.CheckedChanged
        strGröße = "0,2 Liter "
    End Sub

    Private Sub optCola_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optCola.CheckedChanged
        fSchalter = False
        'Call Hugo.EinAus(fSchalter)
        Call EinAus(fSchalter)
    End Sub

    Private Sub optWasser_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optWasser.CheckedChanged
        fSchalter = False
        'Call Hugo.EinAus(fSchalter)
        Call EinAus(fSchalter)
    End Sub

    Private Sub optSuppe_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optSuppe.CheckedChanged
        fSchalter = False
        'Call Hugo.EinAus(fSchalter)
        Call EinAus(fSchalter)
    End Sub

    Private Sub optKaffee_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optKaffee.CheckedChanged
        fSchalter = True
        'Call Hugo.EinAus(fSchalter)
        Call EinAus(fSchalter)
    End Sub

    Private Sub optTee_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optTee.CheckedChanged
        fSchalter = True
        'Call Hugo.EinAus(fSchalter)
        Call EinAus(fSchalter)
    End Sub

    Private Sub EinAus(ByVal fSchalter As Boolean)
        If fSchalter = True Then
            chkMilch.Enabled = True
            chkZucker.Enabled = True
        Else
            chkMilch.Enabled = False
            chkMilch.Checked = False
            chkZucker.Enabled = False
            chkZucker.Checked = False
        End If
    End Sub

End Class
