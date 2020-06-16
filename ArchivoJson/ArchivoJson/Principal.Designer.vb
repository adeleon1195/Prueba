<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.SELECCIONAR = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CARGAR = New System.Windows.Forms.Button()
        Me.VER = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SELECCIONAR
        '
        Me.SELECCIONAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SELECCIONAR.Location = New System.Drawing.Point(49, 80)
        Me.SELECCIONAR.Margin = New System.Windows.Forms.Padding(4)
        Me.SELECCIONAR.Name = "SELECCIONAR"
        Me.SELECCIONAR.Size = New System.Drawing.Size(130, 52)
        Me.SELECCIONAR.TabIndex = 0
        Me.SELECCIONAR.Text = "Seleccionar"
        Me.SELECCIONAR.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(222, 94)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 24)
        Me.TextBox1.TabIndex = 1
        '
        'CARGAR
        '
        Me.CARGAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CARGAR.Location = New System.Drawing.Point(49, 157)
        Me.CARGAR.Margin = New System.Windows.Forms.Padding(4)
        Me.CARGAR.Name = "CARGAR"
        Me.CARGAR.Size = New System.Drawing.Size(130, 52)
        Me.CARGAR.TabIndex = 2
        Me.CARGAR.Text = "Cargar"
        Me.CARGAR.UseVisualStyleBackColor = False
        '
        'VER
        '
        Me.VER.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.VER.Location = New System.Drawing.Point(49, 242)
        Me.VER.Margin = New System.Windows.Forms.Padding(4)
        Me.VER.Name = "VER"
        Me.VER.Size = New System.Drawing.Size(130, 52)
        Me.VER.TabIndex = 3
        Me.VER.Text = "Ver Datos"
        Me.VER.UseVisualStyleBackColor = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(605, 370)
        Me.Controls.Add(Me.VER)
        Me.Controls.Add(Me.CARGAR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SELECCIONAR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Archivo Json"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SELECCIONAR As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CARGAR As System.Windows.Forms.Button
    Friend WithEvents VER As System.Windows.Forms.Button

End Class
