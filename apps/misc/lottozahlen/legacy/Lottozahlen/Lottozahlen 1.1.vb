Public Class Lottozahlen


    Dim gZahl As New System.Random
    Dim Zahl As Integer
    Dim i As Integer
    Dim Liste(6) As Integer
    Dim Blabla As New SortedList
    Dim Zufallsdatum As New Class1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Blabla.Clear()
        Randomize()
    End Sub

    Private Sub cmdEnde_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnde.Click
        Me.Close()
    End Sub


    Private Sub cmdBerechnen_Click(sender As System.Object, e As System.EventArgs) Handles cmdBerechnen.Click

        Blabla.Clear()

        For i = 1 To 6
            Do
                Zahl = gZahl.Next(1, 50)

                If Not Blabla.ContainsValue(Zahl) Then
                    Blabla.Add(Zahl, Zahl)
                    Liste(i) = Zahl
                    Exit Do
                End If
            Loop
        Next i

        Array.Sort(Liste)

        Dim Tag As Integer
        txtEinführung.Text = "Die Lottozahlen für den " & Zufallsdatum.ZufallsTag & "." & _
            Zufallsdatum.ZufallsMonat & "." & Zufallsdatum.ZufallsJahr & " lauten:"


        lbl1.Text = Liste(1)
        lbl2.Text = Liste(2)
        lbl3.Text = Liste(3)
        lbl4.Text = Liste(4)
        lbl5.Text = Liste(5)
        lbl6.Text = Liste(6)

    End Sub


End Class
