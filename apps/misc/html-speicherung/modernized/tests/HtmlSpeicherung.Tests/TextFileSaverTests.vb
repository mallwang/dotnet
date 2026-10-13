Imports System.IO
Imports Xunit

Public Class TextFileSaverTests
    <Fact>
    Public Sub Writes_utf8_without_bom()
        Dim p = Path.GetTempFileName()
        Try
            TextFileSaver.Save(p, "<b>Grüße</b>")
            Assert.Equal("<b>Grüße</b>", File.ReadAllText(p))
            Assert.NotEqual(&HEF, File.ReadAllBytes(p)(0))
        Finally
            File.Delete(p)
        End Try
    End Sub
End Class
