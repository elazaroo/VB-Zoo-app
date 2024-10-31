<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Zoo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btCarnivores = New Button()
        btHerbivores = New Button()
        btOmnivores = New Button()
        btExport = New Button()
        SuspendLayout()
        ' 
        ' btCarnivores
        ' 
        btCarnivores.Location = New Point(50, 40)
        btCarnivores.Name = "btCarnivores"
        btCarnivores.Size = New Size(152, 91)
        btCarnivores.TabIndex = 0
        btCarnivores.Text = "Carnivores"
        btCarnivores.UseVisualStyleBackColor = True
        ' 
        ' btHerbivores
        ' 
        btHerbivores.Location = New Point(50, 180)
        btHerbivores.Name = "btHerbivores"
        btHerbivores.Size = New Size(152, 91)
        btHerbivores.TabIndex = 1
        btHerbivores.Text = "Hervibores"
        btHerbivores.UseVisualStyleBackColor = True
        ' 
        ' btOmnivores
        ' 
        btOmnivores.Location = New Point(50, 315)
        btOmnivores.Name = "btOmnivores"
        btOmnivores.Size = New Size(152, 91)
        btOmnivores.TabIndex = 2
        btOmnivores.Text = "Omnivores"
        btOmnivores.UseVisualStyleBackColor = True
        ' 
        ' btExport
        ' 
        btExport.Location = New Point(446, 199)
        btExport.Name = "btExport"
        btExport.Size = New Size(181, 52)
        btExport.TabIndex = 3
        btExport.Text = "Export Data"
        btExport.UseVisualStyleBackColor = True
        ' 
        ' Zoo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btExport)
        Controls.Add(btOmnivores)
        Controls.Add(btHerbivores)
        Controls.Add(btCarnivores)
        Name = "Zoo"
        Text = "Zoo"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btCarnivores As Button
    Friend WithEvents btHerbivores As Button
    Friend WithEvents btOmnivores As Button
    Friend WithEvents btExport As Button

End Class
