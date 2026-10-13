Public Enum Drink
    Kaffee
    Tee
    Wasser
    Cola
    Suppe
End Enum

Public Enum CupSize
    Klein
    Mittel
    Gross
    Jumbo
End Enum

''' <summary>A drink order. Milk and sugar are only possible for coffee and tea.</summary>
Public Class Order
    Public Shared Function AllowsAdditions(drink As Drink) As Boolean
        Return drink = Drink.Kaffee OrElse drink = Drink.Tee
    End Function

    Public Shared Function Liters(size As CupSize) As String
        Select Case size
            Case CupSize.Klein : Return "0,2"
            Case CupSize.Mittel : Return "0,33"
            Case CupSize.Gross : Return "0,5"
            Case Else : Return "1,0"
        End Select
    End Function

    ''' <summary>Returns "Hallo {name}\nDu bekommst ..." or Nothing if the name is shorter than 2 characters.</summary>
    Public Shared Function Describe(name As String, drink As Drink, size As CupSize,
                                    milk As Boolean, sugar As Boolean) As String
        If name Is Nothing OrElse name.Length < 2 Then Return Nothing
        Dim withAdditions = AllowsAdditions(drink)
        Dim extras = If(withAdditions AndAlso milk, " mit Milch", "") &
                     If(withAdditions AndAlso sugar, " mit Zucker", "")
        Return $"Hallo {name}{Environment.NewLine}Du bekommst {Liters(size)} Liter {drink}{extras}"
    End Function
End Class
