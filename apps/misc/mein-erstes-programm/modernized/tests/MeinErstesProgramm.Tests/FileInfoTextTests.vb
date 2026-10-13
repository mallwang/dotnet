Imports System.IO
Imports Xunit

Public Class FileInfoTextTests
    <Fact>
    Public Sub Lists_files_of_existing_directory_only()
        Dim dir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString())
        Directory.CreateDirectory(dir)
        Try
            File.WriteAllText(Path.Combine(dir, "a.txt"), "x")
            Assert.Equal({Path.Combine(dir, "a.txt")}, ListFiles(dir))
            Assert.Null(ListFiles(Path.Combine(dir, "missing")))
        Finally
            Directory.Delete(dir, True)
        End Try
    End Sub

    <Fact>
    Public Sub Describe_has_path_and_three_timestamps()
        Dim p = Path.GetTempFileName()
        Try
            Dim lines = Describe(p).Split(Environment.NewLine)
            Assert.Equal(4, lines.Length)
            Assert.Equal(p, lines(0))
            Assert.StartsWith("Erzeugt: ", lines(1))
            Assert.StartsWith("Letzter Schreibzugriff: ", lines(3))
        Finally
            File.Delete(p)
        End Try
    End Sub
End Class
