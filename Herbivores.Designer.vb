<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Herbivores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btElephant = New Button()
        btGiraffe = New Button()
        SuspendLayout()
        ' 
        ' btElephant
        ' 
        btElephant.Location = New Point(67, 264)
        btElephant.Name = "btElephant"
        btElephant.Size = New Size(171, 82)
        btElephant.TabIndex = 3
        btElephant.Text = "Elephant"
        btElephant.UseVisualStyleBackColor = True
        ' 
        ' btGiraffe
        ' 
        btGiraffe.Location = New Point(67, 75)
        btGiraffe.Name = "btGiraffe"
        btGiraffe.Size = New Size(171, 82)
        btGiraffe.TabIndex = 2
        btGiraffe.Text = "Giraffe"
        btGiraffe.UseVisualStyleBackColor = True
        ' 
        ' Herbivores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btElephant)
        Controls.Add(btGiraffe)
        Name = "Herbivores"
        Text = "Herbivores"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btElephant As Button
    Friend WithEvents btGiraffe As Button
End Class
