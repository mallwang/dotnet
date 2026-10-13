<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rtxt1 = New System.Windows.Forms.RichTextBox()
        Me.cmdFett = New System.Windows.Forms.Button()
        Me.cmdSpeichern = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtxt1
        '
        Me.rtxt1.Location = New System.Drawing.Point(13, 49)
        Me.rtxt1.Name = "rtxt1"
        Me.rtxt1.Size = New System.Drawing.Size(267, 96)
        Me.rtxt1.TabIndex = 0
        Me.rtxt1.Text = ""
        '
        'cmdFett
        '
        Me.cmdFett.Location = New System.Drawing.Point(13, 13)
        Me.cmdFett.Name = "cmdFett"
        Me.cmdFett.Size = New System.Drawing.Size(75, 23)
        Me.cmdFett.TabIndex = 1
        Me.cmdFett.Text = "Fett"
        Me.cmdFett.UseVisualStyleBackColor = True
        '
        'cmdSpeichern
        '
        Me.cmdSpeichern.Location = New System.Drawing.Point(205, 13)
        Me.cmdSpeichern.Name = "cmdSpeichern"
        Me.cmdSpeichern.Size = New System.Drawing.Size(75, 23)
        Me.cmdSpeichern.TabIndex = 2
        Me.cmdSpeichern.Text = "Speichern"
        Me.cmdSpeichern.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 272)
        Me.Controls.Add(Me.cmdSpeichern)
        Me.Controls.Add(Me.cmdFett)
        Me.Controls.Add(Me.rtxt1)
        Me.Name = "MainForm"
        Me.Text = "HTML-Speicherung"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtxt1 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdFett As System.Windows.Forms.Button
    Friend WithEvents cmdSpeichern As System.Windows.Forms.Button

End Class
