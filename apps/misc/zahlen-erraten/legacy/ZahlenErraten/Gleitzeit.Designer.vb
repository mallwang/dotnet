<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gleitzeit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtZahl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdEnde = New System.Windows.Forms.Button()
        Me.cmdBerechnen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Willkommen!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ich denke an eine Zahl zwischen 1 und 100." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kannst du sie erraten?"
        '
        'txtZahl
        '
        Me.txtZahl.Location = New System.Drawing.Point(53, 69)
        Me.txtZahl.Name = "txtZahl"
        Me.txtZahl.Size = New System.Drawing.Size(36, 20)
        Me.txtZahl.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Zahl:"
        '
        'cmdEnde
        '
        Me.cmdEnde.Location = New System.Drawing.Point(176, 67)
        Me.cmdEnde.Name = "cmdEnde"
        Me.cmdEnde.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnde.TabIndex = 3
        Me.cmdEnde.Text = "Ende"
        Me.cmdEnde.UseVisualStyleBackColor = True
        '
        'cmdBerechnen
        '
        Me.cmdBerechnen.Location = New System.Drawing.Point(95, 67)
        Me.cmdBerechnen.Name = "cmdBerechnen"
        Me.cmdBerechnen.Size = New System.Drawing.Size(75, 23)
        Me.cmdBerechnen.TabIndex = 4
        Me.cmdBerechnen.Text = "Berechnen"
        Me.cmdBerechnen.UseVisualStyleBackColor = True
        '
        'Gleitzeit
        '
        Me.AcceptButton = Me.cmdBerechnen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 108)
        Me.Controls.Add(Me.cmdBerechnen)
        Me.Controls.Add(Me.cmdEnde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtZahl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gleitzeit"
        Me.Text = "Zahlen raten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtZahl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdEnde As System.Windows.Forms.Button
    Friend WithEvents cmdBerechnen As System.Windows.Forms.Button

End Class
