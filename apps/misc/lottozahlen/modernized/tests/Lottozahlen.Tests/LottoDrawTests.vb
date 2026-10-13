Imports Xunit

Public Class LottoDrawTests
    <Theory>
    <InlineData(1)>
    <InlineData(2)>
    <InlineData(3)>
    Public Sub Numbers_are_six_distinct_sorted_values_in_range(seed As Integer)
        Dim n = LottoDraw.Create(New Random(seed)).Numbers
        Assert.Equal(6, n.Count)
        Assert.Equal(6, n.Distinct().Count())
        Assert.All(n, Sub(x) Assert.InRange(x, 1, 49))
        Assert.Equal(n.OrderBy(Function(x) x), n)
    End Sub

    <Fact>
    Public Sub Draw_date_is_within_legacy_year_range()
        For seed = 0 To 200
            Dim d = LottoDraw.Create(New Random(seed)).DrawDate
            Assert.InRange(d.Year, 2013, 2998)
        Next
    End Sub
End Class
