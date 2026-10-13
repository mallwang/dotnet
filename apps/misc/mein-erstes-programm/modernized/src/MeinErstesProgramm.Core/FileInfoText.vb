Imports System.IO

Public Module FileInfoText
    ''' <summary>Full paths of the files directly inside the directory, or Nothing if it does not exist.</summary>
    Public Function ListFiles(directory As String) As String()
        If Not IO.Directory.Exists(directory) Then Return Nothing
        Return IO.Directory.GetFiles(directory)
    End Function

    ''' <summary>Path plus creation, last access and last write time, one per line.</summary>
    Public Function Describe(path As String) As String
        Return path & Environment.NewLine &
               "Erzeugt: " & File.GetCreationTime(path).ToString() & Environment.NewLine &
               "Letzter Zugriff: " & File.GetLastAccessTime(path).ToString() & Environment.NewLine &
               "Letzter Schreibzugriff: " & File.GetLastWriteTime(path).ToString()
    End Function
End Module
