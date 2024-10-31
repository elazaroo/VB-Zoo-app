Imports System.IO

Public Class Zoo

    ' Carnivores
    Public Lion As New Animal("Lion")
    Public Tiger As New Animal("Tiger")

    ' Herbivores
    Public Giraffe As New Animal("Giraffe")
    Public Elephant As New Animal("Elephant")

    ' Omnivores
    Public Bear As New Animal("Bear")
    Public Monkey As New Animal("Monkey")


    Private Sub btCarnivores_Click(sender As Object, e As EventArgs) Handles btCarnivores.Click
        Carnivores.Show()
    End Sub

    Private Sub btHerbivores_Click(sender As Object, e As EventArgs) Handles btHerbivores.Click
        Herbivores.Show()
    End Sub

    Private Sub btOmnivores_Click(sender As Object, e As EventArgs) Handles btOmnivores.Click
        Omnivores.Show()
    End Sub

    Public Sub exportData(animalList As ArrayList)
        Dim todayDate As String = Now.ToString("yyyy-MM-dd HH-mm-ss")
        Dim fileName As String = "feededAnimals" + todayDate + ".txt"
        Dim Route As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + fileName

        Using Writer As New StreamWriter(Route)
            Try
                For Each Animal As Animal In animalList
                    Writer.WriteLine(Animal.ToString)
                Next
                MessageBox.Show("File exported in Documents")
            Catch ex As Exception
                MessageBox.Show("Error when saing file: " + ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btExport_Click(sender As Object, e As EventArgs) Handles btExport.Click
        Dim animalList As New ArrayList()
        animalList.Add(Lion)
        animalList.Add(Tiger)
        animalList.Add(Giraffe)
        animalList.Add(Elephant)
        animalList.Add(Bear)
        animalList.Add(Monkey)

        exportData(animalList)
    End Sub
End Class
