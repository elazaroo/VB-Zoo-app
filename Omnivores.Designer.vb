<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Omnivores
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
        btMonkey = New Button()
        btBear = New Button()
        SuspendLayout()
        ' 
        ' btMonkey
        ' 
        btMonkey.Location = New Point(75, 256)
        btMonkey.Name = "btMonkey"
        btMonkey.Size = New Size(171, 82)
        btMonkey.TabIndex = 5
        btMonkey.Text = "Monkey"
        btMonkey.UseVisualStyleBackColor = True
        ' 
        ' btBear
        ' 
        btBear.Location = New Point(75, 67)
        btBear.Name = "btBear"
        btBear.Size = New Size(171, 82)
        btBear.TabIndex = 4
        btBear.Text = "Bear"
        btBear.UseVisualStyleBackColor = True
        ' 
        ' Omnivores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btMonkey)
        Controls.Add(btBear)
        Name = "Omnivores"
        Text = "Omnivores"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btMonkey As Button
    Friend WithEvents btBear As Button
End Class
