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
        Me.txtEinführung = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdBerechnen = New System.Windows.Forms.Button()
        Me.cmdEnde = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEinführung
        '
        Me.txtEinführung.AutoSize = True
        Me.txtEinführung.Location = New System.Drawing.Point(12, 50)
        Me.txtEinführung.Name = "txtEinführung"
        Me.txtEinführung.Size = New System.Drawing.Size(0, 13)
        Me.txtEinführung.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(13, 72)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 13)
        Me.lbl1.TabIndex = 1
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(39, 72)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 13)
        Me.lbl2.TabIndex = 1
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(65, 72)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(0, 13)
        Me.lbl3.TabIndex = 1
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(91, 72)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(0, 13)
        Me.lbl4.TabIndex = 1
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(117, 72)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(0, 13)
        Me.lbl5.TabIndex = 1
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(143, 72)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(0, 13)
        Me.lbl6.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "LOTTO 6 aus 49"
        '
        'cmdBerechnen
        '
        Me.cmdBerechnen.Location = New System.Drawing.Point(12, 112)
        Me.cmdBerechnen.Name = "cmdBerechnen"
        Me.cmdBerechnen.Size = New System.Drawing.Size(75, 23)
        Me.cmdBerechnen.TabIndex = 3
        Me.cmdBerechnen.Text = "Berechnen"
        Me.cmdBerechnen.UseVisualStyleBackColor = True
        '
        'cmdEnde
        '
        Me.cmdEnde.Location = New System.Drawing.Point(237, 111)
        Me.cmdEnde.Name = "cmdEnde"
        Me.cmdEnde.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnde.TabIndex = 4
        Me.cmdEnde.Text = "Ende"
        Me.cmdEnde.UseVisualStyleBackColor = True
        '
        'Lottozahlen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 147)
        Me.Controls.Add(Me.cmdEnde)
        Me.Controls.Add(Me.cmdBerechnen)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtEinführung)
        Me.Name = "MainForm"
        Me.Text = "Lottozahlen 1.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEinführung As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdBerechnen As System.Windows.Forms.Button
    Friend WithEvents cmdEnde As System.Windows.Forms.Button

End Class
