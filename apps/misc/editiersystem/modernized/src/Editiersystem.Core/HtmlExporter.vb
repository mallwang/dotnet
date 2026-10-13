Imports System.Globalization
Imports System.Net
Imports System.Text

''' <summary>Formatting of one character of the editor text.</summary>
Public Structure CharFormat
    Public Bold As Boolean
    Public Underline As Boolean
    Public Superscript As Boolean
    ''' <summary>CSS color, e.g. "#FF0000".</summary>
    Public Color As String
    Public FontFamily As String
    Public SizePt As Single

    Public Overrides Function Equals(obj As Object) As Boolean
        If Not (TypeOf obj Is CharFormat) Then Return False
        Dim o = DirectCast(obj, CharFormat)
        Return Bold = o.Bold AndAlso Underline = o.Underline AndAlso Superscript = o.Superscript AndAlso
               Color = o.Color AndAlso FontFamily = o.FontFamily AndAlso SizePt = o.SizePt
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return HashCode.Combine(Bold, Underline, Superscript, Color, FontFamily, SizePt)
    End Function
End Structure

''' <summary>Converts formatted text into a two-column HTML page.</summary>
Public Module HtmlExporter
    ''' <summary>Index of the first space at or after the middle of the text, or the text length if there is none.</summary>
    Public Function TextMiddle(text As String) As Integer
        Dim i = text.IndexOf(" "c, text.Length \ 2)
        Return If(i < 0, text.Length, i)
    End Function

    ''' <param name="text">The plain text.</param>
    ''' <param name="formats">One format per character of <paramref name="text"/>.</param>
    Public Function Export(text As String, formats As IReadOnlyList(Of CharFormat)) As String
        If formats.Count <> text.Length Then Throw New ArgumentException("One format per character required.", NameOf(formats))
        Const ColumnStart As String = "<td width=""50%"" valign=""top""><p style=""line-height:1.4em; text-align:justify"">"
        Dim split = TextMiddle(text)
        Dim sb As New StringBuilder("<html><head><meta charset=""utf-8""></head><body><table border=""0"" cellspacing=""15""><tr>" & ColumnStart)
        Dim start = 0
        For i = 0 To text.Length
            If i = text.Length OrElse i = split OrElse Not formats(i).Equals(formats(start)) Then
                If i > start Then AppendRun(sb, text.Substring(start, i - start), formats(start))
                start = i
            End If
            If i = split Then sb.Append("</p></td>").Append(ColumnStart)
        Next
        Return sb.Append("</p></td></tr></table></body></html>").ToString()
    End Function

    Private Sub AppendRun(sb As StringBuilder, text As String, f As CharFormat)
        Dim pre = If(f.Bold, "<b>", "") & If(f.Underline, "<u>", "") & If(f.Superscript, "<sup>", "")
        Dim post = If(f.Superscript, "</sup>", "") & If(f.Underline, "</u>", "") & If(f.Bold, "</b>", "")
        sb.Append(pre).Append("<span style=""white-space:pre-wrap; font-size:").Append(f.SizePt.ToString("0.##", CultureInfo.InvariantCulture)).
           Append("pt; color:").Append(f.Color).Append("; font-family:").Append(f.FontFamily).Append(""">").
           Append(WebUtility.HtmlEncode(text)).Append("</span>").Append(post)
    End Sub
End Module
