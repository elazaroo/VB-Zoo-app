﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carnivores
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
        btLion = New Button()
        btTiger = New Button()
        SuspendLayout()
        ' 
        ' btLion
        ' 
        btLion.Location = New Point(99, 77)
        btLion.Name = "btLion"
        btLion.Size = New Size(171, 82)
        btLion.TabIndex = 0
        btLion.Text = "Lion"
        btLion.UseVisualStyleBackColor = True
        ' 
        ' btTiger
        ' 
        btTiger.Location = New Point(99, 266)
        btTiger.Name = "btTiger"
        btTiger.Size = New Size(171, 82)
        btTiger.TabIndex = 1
        btTiger.Text = "Tiger"
        btTiger.UseVisualStyleBackColor = True
        ' 
        ' Carnivores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btTiger)
        Controls.Add(btLion)
        Name = "Carnivores"
        Text = "Carnivores"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btLion As Button
    Friend WithEvents btTiger As Button
End Class
