Imports System.IO
Imports System.Text

Public Module TextFileSaver
    ''' <summary>Writes the text as UTF-8 (the legacy version used the default encoding and never disposed the writer on errors).</summary>
    Public Sub Save(path As String, text As String)
        File.WriteAllText(path, text, New UTF8Encoding(False))
    End Sub
End Module
