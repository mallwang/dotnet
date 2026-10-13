Module basKaffeeZubehör
    Public Sub EinAus(ByVal fSchalter As Boolean)
        If fSchalter = True Then
            Kaffeetest.chkMilch.Enabled = True
            Kaffeetest.chkZucker.Enabled = True
        Else
            Kaffeetest.chkMilch.Enabled = False
            Kaffeetest.chkMilch.Checked = False
            Kaffeetest.chkZucker.Enabled = False
            Kaffeetest.chkZucker.Checked = False
        End If
    End Sub
End Module
