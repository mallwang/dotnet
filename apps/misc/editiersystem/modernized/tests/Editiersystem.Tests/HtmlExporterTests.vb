Imports Xunit

Public Class HtmlExporterTests
    Private Shared Function Plain() As CharFormat
        Return New CharFormat With {.Color = "#000000", .FontFamily = "Arial", .SizePt = 8}
    End Function

    Private Shared Function Repeat(f As CharFormat, n As Integer) As List(Of CharFormat)
        Return Enumerable.Repeat(f, n).ToList()
    End Function

    <Theory>
    <InlineData("", 0)>
    <InlineData("abcd", 4)>
    <InlineData("ab cd ef", 5)>
    <InlineData("ab cd", 2)>
    Public Sub Middle_is_next_space_after_half(text As String, expected As Integer)
        Assert.Equal(expected, TextMiddle(text))
    End Sub

    <Fact>
    Public Sub Merges_equal_formats_and_marks_bold()
        Dim bold = Plain() : bold.Bold = True
        Dim f = Repeat(Plain(), 2) : f.AddRange(Repeat(bold, 2))
        Dim html = Export("abcd", f)
        Assert.Contains(">ab</span>", html)
        Assert.Contains("<b><span", html)
        Assert.Contains(">cd</span></b>", html)
    End Sub

    <Fact>
    Public Sub Splits_into_two_columns_and_escapes()
        Dim html = Export("a<b c", Repeat(Plain(), 5))
        Assert.Equal(2, html.Split("<td ").Length - 1)
        Assert.Contains("a&lt;b", html)
    End Sub

    <Fact>
    Public Sub Rejects_mismatched_format_count()
        Assert.Throws(Of ArgumentException)(Function() Export("abc", Repeat(Plain(), 2)))
    End Sub
End Class
