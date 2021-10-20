<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfoQS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfoQS))
        Me.LblTituloQS = New System.Windows.Forms.Label()
        Me.BtnVolverQS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTituloQS
        '
        Me.LblTituloQS.AutoSize = True
        Me.LblTituloQS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTituloQS.Location = New System.Drawing.Point(12, 22)
        Me.LblTituloQS.Name = "LblTituloQS"
        Me.LblTituloQS.Size = New System.Drawing.Size(420, 21)
        Me.LblTituloQS.TabIndex = 0
        Me.LblTituloQS.Text = "¿Qué son los algoritmos de planificación de procesos?"
        '
        'BtnVolverQS
        '
        Me.BtnVolverQS.Location = New System.Drawing.Point(538, 415)
        Me.BtnVolverQS.Name = "BtnVolverQS"
        Me.BtnVolverQS.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolverQS.TabIndex = 1
        Me.BtnVolverQS.Text = "VOLVER"
        Me.BtnVolverQS.UseVisualStyleBackColor = True
        '
        'FrmInfoQS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 450)
        Me.Controls.Add(Me.BtnVolverQS)
        Me.Controls.Add(Me.LblTituloQS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInfoQS"
        Me.Text = "INFORMACIÓN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTituloQS As Label
    Friend WithEvents BtnVolverQS As Button
End Class
