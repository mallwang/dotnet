<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kaffeetest
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
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBetrag = New System.Windows.Forms.TextBox()
        Me.lblBetrag = New System.Windows.Forms.Label()
        Me.grpGetränke = New System.Windows.Forms.GroupBox()
        Me.optSuppe = New System.Windows.Forms.RadioButton()
        Me.optCola = New System.Windows.Forms.RadioButton()
        Me.optWasser = New System.Windows.Forms.RadioButton()
        Me.optTee = New System.Windows.Forms.RadioButton()
        Me.optKaffee = New System.Windows.Forms.RadioButton()
        Me.grpGröße = New System.Windows.Forms.GroupBox()
        Me.optMittel = New System.Windows.Forms.RadioButton()
        Me.optKlein = New System.Windows.Forms.RadioButton()
        Me.optGroß = New System.Windows.Forms.RadioButton()
        Me.optJumbo = New System.Windows.Forms.RadioButton()
        Me.chkMilch = New System.Windows.Forms.CheckBox()
        Me.chkZucker = New System.Windows.Forms.CheckBox()
        Me.grpGetränke.SuspendLayout()
        Me.grpGröße.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(394, 237)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(75, 23)
        Me.btnAbbrechen.TabIndex = 0
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(394, 208)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "Ausgeben"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 32)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(57, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'txtBetrag
        '
        Me.txtBetrag.Location = New System.Drawing.Point(57, 58)
        Me.txtBetrag.Name = "txtBetrag"
        Me.txtBetrag.Size = New System.Drawing.Size(61, 20)
        Me.txtBetrag.TabIndex = 7
        '
        'lblBetrag
        '
        Me.lblBetrag.AutoSize = True
        Me.lblBetrag.Location = New System.Drawing.Point(12, 61)
        Me.lblBetrag.Name = "lblBetrag"
        Me.lblBetrag.Size = New System.Drawing.Size(41, 13)
        Me.lblBetrag.TabIndex = 8
        Me.lblBetrag.Text = "Betrag:"
        '
        'grpGetränke
        '
        Me.grpGetränke.Controls.Add(Me.optSuppe)
        Me.grpGetränke.Controls.Add(Me.optCola)
        Me.grpGetränke.Controls.Add(Me.optWasser)
        Me.grpGetränke.Controls.Add(Me.optTee)
        Me.grpGetränke.Controls.Add(Me.optKaffee)
        Me.grpGetränke.Location = New System.Drawing.Point(15, 84)
        Me.grpGetränke.Name = "grpGetränke"
        Me.grpGetränke.Size = New System.Drawing.Size(142, 168)
        Me.grpGetränke.TabIndex = 9
        Me.grpGetränke.TabStop = False
        Me.grpGetränke.Text = "Getränke"
        '
        'optSuppe
        '
        Me.optSuppe.AutoSize = True
        Me.optSuppe.Location = New System.Drawing.Point(6, 113)
        Me.optSuppe.Name = "optSuppe"
        Me.optSuppe.Size = New System.Drawing.Size(56, 17)
        Me.optSuppe.TabIndex = 4
        Me.optSuppe.TabStop = True
        Me.optSuppe.Text = "Suppe"
        Me.optSuppe.UseVisualStyleBackColor = True
        '
        'optCola
        '
        Me.optCola.AutoSize = True
        Me.optCola.Location = New System.Drawing.Point(6, 67)
        Me.optCola.Name = "optCola"
        Me.optCola.Size = New System.Drawing.Size(46, 17)
        Me.optCola.TabIndex = 3
        Me.optCola.TabStop = True
        Me.optCola.Text = "Cola"
        Me.optCola.UseVisualStyleBackColor = True
        '
        'optWasser
        '
        Me.optWasser.AutoSize = True
        Me.optWasser.Location = New System.Drawing.Point(6, 90)
        Me.optWasser.Name = "optWasser"
        Me.optWasser.Size = New System.Drawing.Size(61, 17)
        Me.optWasser.TabIndex = 2
        Me.optWasser.Text = "Wasser"
        Me.optWasser.UseVisualStyleBackColor = True
        '
        'optTee
        '
        Me.optTee.AutoSize = True
        Me.optTee.Location = New System.Drawing.Point(6, 44)
        Me.optTee.Name = "optTee"
        Me.optTee.Size = New System.Drawing.Size(44, 17)
        Me.optTee.TabIndex = 1
        Me.optTee.Text = "Tee"
        Me.optTee.UseVisualStyleBackColor = True
        '
        'optKaffee
        '
        Me.optKaffee.AutoSize = True
        Me.optKaffee.Checked = True
        Me.optKaffee.Location = New System.Drawing.Point(6, 21)
        Me.optKaffee.Name = "optKaffee"
        Me.optKaffee.Size = New System.Drawing.Size(56, 17)
        Me.optKaffee.TabIndex = 0
        Me.optKaffee.TabStop = True
        Me.optKaffee.Text = "Kaffee"
        Me.optKaffee.UseVisualStyleBackColor = True
        '
        'grpGröße
        '
        Me.grpGröße.Controls.Add(Me.optMittel)
        Me.grpGröße.Controls.Add(Me.optKlein)
        Me.grpGröße.Controls.Add(Me.optGroß)
        Me.grpGröße.Controls.Add(Me.optJumbo)
        Me.grpGröße.Location = New System.Drawing.Point(163, 84)
        Me.grpGröße.Name = "grpGröße"
        Me.grpGröße.Size = New System.Drawing.Size(142, 168)
        Me.grpGröße.TabIndex = 9
        Me.grpGröße.TabStop = False
        Me.grpGröße.Text = "Größe"
        '
        'optMittel
        '
        Me.optMittel.AutoSize = True
        Me.optMittel.Checked = True
        Me.optMittel.Location = New System.Drawing.Point(6, 67)
        Me.optMittel.Name = "optMittel"
        Me.optMittel.Size = New System.Drawing.Size(50, 17)
        Me.optMittel.TabIndex = 3
        Me.optMittel.TabStop = True
        Me.optMittel.Text = "Mittel"
        Me.optMittel.UseVisualStyleBackColor = True
        '
        'optKlein
        '
        Me.optKlein.AutoSize = True
        Me.optKlein.Location = New System.Drawing.Point(6, 90)
        Me.optKlein.Name = "optKlein"
        Me.optKlein.Size = New System.Drawing.Size(48, 17)
        Me.optKlein.TabIndex = 2
        Me.optKlein.Text = "Klein"
        Me.optKlein.UseVisualStyleBackColor = True
        '
        'optGroß
        '
        Me.optGroß.AutoSize = True
        Me.optGroß.Location = New System.Drawing.Point(6, 44)
        Me.optGroß.Name = "optGroß"
        Me.optGroß.Size = New System.Drawing.Size(48, 17)
        Me.optGroß.TabIndex = 1
        Me.optGroß.Text = "Groß"
        Me.optGroß.UseVisualStyleBackColor = True
        '
        'optJumbo
        '
        Me.optJumbo.AutoSize = True
        Me.optJumbo.Location = New System.Drawing.Point(6, 21)
        Me.optJumbo.Name = "optJumbo"
        Me.optJumbo.Size = New System.Drawing.Size(56, 17)
        Me.optJumbo.TabIndex = 0
        Me.optJumbo.Text = "Jumbo"
        Me.optJumbo.UseVisualStyleBackColor = True
        '
        'chkMilch
        '
        Me.chkMilch.AutoSize = True
        Me.chkMilch.Location = New System.Drawing.Point(323, 105)
        Me.chkMilch.Name = "chkMilch"
        Me.chkMilch.Size = New System.Drawing.Size(67, 17)
        Me.chkMilch.TabIndex = 10
        Me.chkMilch.Text = "mit Milch"
        Me.chkMilch.UseVisualStyleBackColor = True
        '
        'chkZucker
        '
        Me.chkZucker.AutoSize = True
        Me.chkZucker.Location = New System.Drawing.Point(323, 129)
        Me.chkZucker.Name = "chkZucker"
        Me.chkZucker.Size = New System.Drawing.Size(76, 17)
        Me.chkZucker.TabIndex = 11
        Me.chkZucker.Text = "mit Zucker"
        Me.chkZucker.UseVisualStyleBackColor = True
        '
        'Kaffeetest
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 272)
        Me.Controls.Add(Me.chkZucker)
        Me.Controls.Add(Me.chkMilch)
        Me.Controls.Add(Me.grpGröße)
        Me.Controls.Add(Me.grpGetränke)
        Me.Controls.Add(Me.lblBetrag)
        Me.Controls.Add(Me.txtBetrag)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Name = "Kaffeetest"
        Me.Text = "Kaffeautomat"
        Me.grpGetränke.ResumeLayout(False)
        Me.grpGetränke.PerformLayout()
        Me.grpGröße.ResumeLayout(False)
        Me.grpGröße.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtBetrag As System.Windows.Forms.TextBox
    Friend WithEvents lblBetrag As System.Windows.Forms.Label
    Friend WithEvents grpGetränke As System.Windows.Forms.GroupBox
    Friend WithEvents optTee As System.Windows.Forms.RadioButton
    Friend WithEvents optKaffee As System.Windows.Forms.RadioButton
    Friend WithEvents optWasser As System.Windows.Forms.RadioButton
    Friend WithEvents optSuppe As System.Windows.Forms.RadioButton
    Friend WithEvents optCola As System.Windows.Forms.RadioButton
    Friend WithEvents grpGröße As System.Windows.Forms.GroupBox
    Friend WithEvents optMittel As System.Windows.Forms.RadioButton
    Friend WithEvents optKlein As System.Windows.Forms.RadioButton
    Friend WithEvents optGroß As System.Windows.Forms.RadioButton
    Friend WithEvents optJumbo As System.Windows.Forms.RadioButton
    Friend WithEvents chkMilch As System.Windows.Forms.CheckBox
    Friend WithEvents chkZucker As System.Windows.Forms.CheckBox

End Class
