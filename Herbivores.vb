Public Class Herbivores
    Private Sub btGiraffe_Click(sender As Object, e As EventArgs) Handles btGiraffe.Click
        Zoo.Giraffe.Alimentar()
    End Sub

    Private Sub btElephant_Click(sender As Object, e As EventArgs) Handles btElephant.Click
        Zoo.Elephant.Alimentar()
    End Sub
End Class