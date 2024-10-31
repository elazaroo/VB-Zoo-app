Public Class Animal
    Dim name As String
    Dim feeded As Boolean


    Public Sub New(ByVal _name As String)
        name = _name
        feeded = False
    End Sub

    Public Sub Alimentar()
        If (feeded = False) Then
            feeded = True
            MessageBox.Show("Animal feeded")
        Else
            MessageBox.Show("The animal has been feeded previously")
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return name & " | " + If(feeded = True, "Feeded", "No feeded")
    End Function

End Class
