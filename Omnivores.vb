Public Class Omnivores
    Private Sub btBear_Click(sender As Object, e As EventArgs) Handles btBear.Click
        Zoo.Bear.Alimentar()
    End Sub

    Private Sub btMonkey_Click(sender As Object, e As EventArgs) Handles btMonkey.Click
        Zoo.Monkey.Alimentar()
    End Sub
End Class