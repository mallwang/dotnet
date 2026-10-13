<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdDateiliste = New System.Windows.Forms.Button()
        Me.cmdEnde = New System.Windows.Forms.Button()
        Me.lstDateiliste = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdInfo = New System.Windows.Forms.Button()
        Me.lblAnzeige = New System.Windows.Forms.Label()
        Me.cmdVerzeichnisWaehlen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdDateiliste
        '
        Me.cmdDateiliste.Location = New System.Drawing.Point(12, 12)
        Me.cmdDateiliste.Name = "cmdDateiliste"
        Me.cmdDateiliste.Size = New System.Drawing.Size(75, 23)
        Me.cmdDateiliste.TabIndex = 0
        Me.cmdDateiliste.Text = "Dateiliste"
        Me.cmdDateiliste.UseVisualStyleBackColor = True
        '
        'cmdEnde
        '
        Me.cmdEnde.Location = New System.Drawing.Point(708, 12)
        Me.cmdEnde.Name = "cmdEnde"
        Me.cmdEnde.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnde.TabIndex = 1
        Me.cmdEnde.Text = "Ende"
        Me.cmdEnde.UseVisualStyleBackColor = True
        '
        'lstDateiliste
        '
        Me.lstDateiliste.FormattingEnabled = True
        Me.lstDateiliste.Location = New System.Drawing.Point(12, 41)
        Me.lstDateiliste.Name = "lstDateiliste"
        Me.lstDateiliste.Size = New System.Drawing.Size(771, 95)
        Me.lstDateiliste.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(207, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(495, 20)
        Me.TextBox1.TabIndex = 4
        '
        'cmdInfo
        '
        Me.cmdInfo.Location = New System.Drawing.Point(12, 142)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(75, 23)
        Me.cmdInfo.TabIndex = 5
        Me.cmdInfo.Text = "Info"
        Me.cmdInfo.UseVisualStyleBackColor = True
        '
        'lblAnzeige
        '
        Me.lblAnzeige.AutoSize = True
        Me.lblAnzeige.Location = New System.Drawing.Point(105, 152)
        Me.lblAnzeige.Name = "lblAnzeige"
        Me.lblAnzeige.Size = New System.Drawing.Size(0, 13)
        Me.lblAnzeige.TabIndex = 6
        '
        'cmdVerzeichnisWaehlen
        '
        Me.cmdVerzeichnisWaehlen.Location = New System.Drawing.Point(93, 12)
        Me.cmdVerzeichnisWaehlen.Name = "cmdVerzeichnisWaehlen"
        Me.cmdVerzeichnisWaehlen.Size = New System.Drawing.Size(108, 23)
        Me.cmdVerzeichnisWaehlen.TabIndex = 7
        Me.cmdVerzeichnisWaehlen.Text = "Verzeichnis wählen"
        Me.cmdVerzeichnisWaehlen.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 229)
        Me.Controls.Add(Me.cmdVerzeichnisWaehlen)
        Me.Controls.Add(Me.lblAnzeige)
        Me.Controls.Add(Me.cmdInfo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lstDateiliste)
        Me.Controls.Add(Me.cmdEnde)
        Me.Controls.Add(Me.cmdDateiliste)
        Me.Name = "MainForm"
        Me.Text = "Mein erstes Programm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdDateiliste As System.Windows.Forms.Button
    Friend WithEvents cmdEnde As System.Windows.Forms.Button
    Friend WithEvents lstDateiliste As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdInfo As System.Windows.Forms.Button
    Friend WithEvents lblAnzeige As System.Windows.Forms.Label
    Friend WithEvents cmdVerzeichnisWaehlen As System.Windows.Forms.Button

End Class
