Public Class MainForm
    Private ReadOnly _drinks As Dictionary(Of RadioButton, Drink)
    Private ReadOnly _sizes As Dictionary(Of RadioButton, CupSize)

    Public Sub New()
        InitializeComponent()
        _drinks = New Dictionary(Of RadioButton, Drink) From {
            {optKaffee, Drink.Kaffee}, {optTee, Drink.Tee}, {optWasser, Drink.Wasser},
            {optCola, Drink.Cola}, {optSuppe, Drink.Suppe}}
        _sizes = New Dictionary(Of RadioButton, CupSize) From {
            {optKlein, CupSize.Klein}, {optMittel, CupSize.Mittel},
            {optGroß, CupSize.Gross}, {optJumbo, CupSize.Jumbo}}
        txtBetrag.Text = "1"
        UpdateAdditions()
    End Sub

    Private Function SelectedDrink() As Drink
        Return _drinks.First(Function(p) p.Key.Checked).Value
    End Function

    Private Sub UpdateAdditions()
        Dim allowed = Order.AllowsAdditions(SelectedDrink())
        chkMilch.Enabled = allowed
        chkZucker.Enabled = allowed
        If Not allowed Then
            chkMilch.Checked = False
            chkZucker.Checked = False
        End If
    End Sub

    Private Sub DrinkChanged(sender As Object, e As EventArgs) Handles optKaffee.CheckedChanged, optTee.CheckedChanged,
        optWasser.CheckedChanged, optCola.CheckedChanged, optSuppe.CheckedChanged
        UpdateAdditions()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim size = _sizes.First(Function(p) p.Key.Checked).Value
        Dim text = Order.Describe(txtName.Text, SelectedDrink(), size, chkMilch.Checked, chkZucker.Checked)
        If text Is Nothing Then
            MessageBox.Show("Bitte Namen eingeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Select()
        ElseIf txtBetrag.Text = "" Then
            MessageBox.Show("Bitte Betrag einwerfen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBetrag.Select()
        Else
            MessageBox.Show(text, "Getränk", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Close()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtName.Select()
    End Sub
End Class
