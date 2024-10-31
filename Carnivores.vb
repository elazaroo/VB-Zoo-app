Public Class Carnivores
    Private Sub btLion_Click(sender As Object, e As EventArgs) Handles btLion.Click
        Zoo.Lion.Alimentar()
    End Sub

    Private Sub btTiger_Click(sender As Object, e As EventArgs) Handles btTiger.Click
        Zoo.Tiger.Alimentar()
    End Sub
End Class