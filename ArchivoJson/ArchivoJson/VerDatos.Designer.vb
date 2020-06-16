<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerDatos))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.COLABORADORES = New System.Windows.Forms.Button()
        Me.SUCURSALES = New System.Windows.Forms.Button()
        Me.EMPRESA = New System.Windows.Forms.Button()
        Me.LIMPIAR = New System.Windows.Forms.Button()
        Me.PRINCIPAL = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(515, 255)
        Me.DataGridView1.TabIndex = 0
        '
        'COLABORADORES
        '
        Me.COLABORADORES.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.COLABORADORES.Location = New System.Drawing.Point(439, 31)
        Me.COLABORADORES.Margin = New System.Windows.Forms.Padding(4)
        Me.COLABORADORES.Name = "COLABORADORES"
        Me.COLABORADORES.Size = New System.Drawing.Size(130, 52)
        Me.COLABORADORES.TabIndex = 1
        Me.COLABORADORES.Text = "Colaboradores"
        Me.COLABORADORES.UseVisualStyleBackColor = False
        '
        'SUCURSALES
        '
        Me.SUCURSALES.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SUCURSALES.Location = New System.Drawing.Point(232, 31)
        Me.SUCURSALES.Margin = New System.Windows.Forms.Padding(4)
        Me.SUCURSALES.Name = "SUCURSALES"
        Me.SUCURSALES.Size = New System.Drawing.Size(130, 52)
        Me.SUCURSALES.TabIndex = 2
        Me.SUCURSALES.Text = "Sucursales"
        Me.SUCURSALES.UseVisualStyleBackColor = False
        '
        'EMPRESA
        '
        Me.EMPRESA.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EMPRESA.Location = New System.Drawing.Point(23, 31)
        Me.EMPRESA.Margin = New System.Windows.Forms.Padding(4)
        Me.EMPRESA.Name = "EMPRESA"
        Me.EMPRESA.Size = New System.Drawing.Size(130, 52)
        Me.EMPRESA.TabIndex = 3
        Me.EMPRESA.Text = "Empresas"
        Me.EMPRESA.UseVisualStyleBackColor = False
        '
        'LIMPIAR
        '
        Me.LIMPIAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LIMPIAR.Location = New System.Drawing.Point(439, 378)
        Me.LIMPIAR.Margin = New System.Windows.Forms.Padding(4)
        Me.LIMPIAR.Name = "LIMPIAR"
        Me.LIMPIAR.Size = New System.Drawing.Size(121, 40)
        Me.LIMPIAR.TabIndex = 4
        Me.LIMPIAR.Text = "Limpiar"
        Me.LIMPIAR.UseVisualStyleBackColor = False
        '
        'PRINCIPAL
        '
        Me.PRINCIPAL.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PRINCIPAL.Location = New System.Drawing.Point(45, 378)
        Me.PRINCIPAL.Margin = New System.Windows.Forms.Padding(4)
        Me.PRINCIPAL.Name = "PRINCIPAL"
        Me.PRINCIPAL.Size = New System.Drawing.Size(121, 40)
        Me.PRINCIPAL.TabIndex = 5
        Me.PRINCIPAL.Text = "Menu Principal"
        Me.PRINCIPAL.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(163, 225)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'VerDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 443)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PRINCIPAL)
        Me.Controls.Add(Me.LIMPIAR)
        Me.Controls.Add(Me.EMPRESA)
        Me.Controls.Add(Me.SUCURSALES)
        Me.Controls.Add(Me.COLABORADORES)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VerDatos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents COLABORADORES As System.Windows.Forms.Button
    Friend WithEvents SUCURSALES As System.Windows.Forms.Button
    Friend WithEvents EMPRESA As System.Windows.Forms.Button
    Friend WithEvents LIMPIAR As System.Windows.Forms.Button
    Friend WithEvents PRINCIPAL As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
