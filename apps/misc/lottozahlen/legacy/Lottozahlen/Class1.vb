Public Class Class1

    Public Function ZufallsTag()
        Dim Tag As Integer
        Dim gZahl As New System.Random
        Randomize()
        Tag = gZahl.Next(1, 31)
        Return Tag
    End Function

    Public Function ZufallsMonat()
        Dim Monat As Integer
        Dim gZahl As New System.Random
        Randomize()
        Monat = gZahl.Next(1, 13)
        Return Monat
    End Function

    Public Function ZufallsJahr()
        Dim Jahr As Integer
        Dim gZahl As New System.Random
        Randomize()
        Jahr = gZahl.Next(2013, 2999)
        Return Jahr

    End Function

End Class
