Imports Xunit

Public Class OrderTests
    <Theory>
    <InlineData(Drink.Kaffee, True)>
    <InlineData(Drink.Tee, True)>
    <InlineData(Drink.Wasser, False)>
    <InlineData(Drink.Cola, False)>
    <InlineData(Drink.Suppe, False)>
    Public Sub Additions_only_for_coffee_and_tea(d As Drink, expected As Boolean)
        Assert.Equal(expected, Order.AllowsAdditions(d))
    End Sub

    <Fact>
    Public Sub Describes_order_with_additions()
        Dim t = Order.Describe("Anna", Drink.Kaffee, CupSize.Mittel, True, True)
        Assert.Equal("Hallo Anna" & Environment.NewLine & "Du bekommst 0,33 Liter Kaffee mit Milch mit Zucker", t)
    End Sub

    <Fact>
    Public Sub Additions_are_ignored_for_cola()
        Dim t = Order.Describe("Bo", Drink.Cola, CupSize.Jumbo, True, True)
        Assert.EndsWith("1,0 Liter Cola", t)
    End Sub

    <Theory>
    <InlineData("")>
    <InlineData("A")>
    <InlineData(Nothing)>
    Public Sub Short_name_is_rejected(name As String)
        Assert.Null(Order.Describe(name, Drink.Tee, CupSize.Klein, False, False))
    End Sub
End Class
