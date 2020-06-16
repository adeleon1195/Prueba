<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SELECCIONAR = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CARGAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SELECCIONAR
        '
        Me.SELECCIONAR.Location = New System.Drawing.Point(51, 36)
        Me.SELECCIONAR.Name = "SELECCIONAR"
        Me.SELECCIONAR.Size = New System.Drawing.Size(146, 36)
        Me.SELECCIONAR.TabIndex = 0
        Me.SELECCIONAR.Text = "Seleccionar"
        Me.SELECCIONAR.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(263, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 20)
        Me.TextBox1.TabIndex = 1
        '
        'CARGAR
        '
        Me.CARGAR.Location = New System.Drawing.Point(51, 100)
        Me.CARGAR.Name = "CARGAR"
        Me.CARGAR.Size = New System.Drawing.Size(146, 36)
        Me.CARGAR.TabIndex = 2
        Me.CARGAR.Text = "Cargar"
        Me.CARGAR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 536)
        Me.Controls.Add(Me.CARGAR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SELECCIONAR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SELECCIONAR As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CARGAR As System.Windows.Forms.Button

End Class
