<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Me.CrEmbarque = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrEmbarque
        '
        Me.CrEmbarque.ActiveViewIndex = -1
        Me.CrEmbarque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrEmbarque.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrEmbarque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrEmbarque.Location = New System.Drawing.Point(0, 0)
        Me.CrEmbarque.Name = "CrEmbarque"
        Me.CrEmbarque.Size = New System.Drawing.Size(977, 731)
        Me.CrEmbarque.TabIndex = 0
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 731)
        Me.Controls.Add(Me.CrEmbarque)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrEmbarque As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
