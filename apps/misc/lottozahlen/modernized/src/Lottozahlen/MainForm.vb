Public Class MainForm
    Private Sub cmdBerechnen_Click(sender As Object, e As EventArgs) Handles cmdBerechnen.Click
        Dim draw = LottoDraw.Create()
        Dim d = draw.DrawDate
        txtEinführung.Text = $"Die Lottozahlen für den {d.Day}.{d.Month}.{d.Year} lauten:"

        Dim labels = {lbl1, lbl2, lbl3, lbl4, lbl5, lbl6}
        For i = 0 To labels.Length - 1
            labels(i).Text = draw.Numbers(i).ToString()
        Next
    End Sub

    Private Sub cmdEnde_Click(sender As Object, e As EventArgs) Handles cmdEnde.Click
        Close()
    End Sub
End Class
