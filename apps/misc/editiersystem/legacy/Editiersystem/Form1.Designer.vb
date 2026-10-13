<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Richtextbox = New System.Windows.Forms.RichTextBox()
        Me.txt = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdLaden = New System.Windows.Forms.ToolStripButton()
        Me.cmdZeichenzaehlen = New System.Windows.Forms.ToolStripButton()
        Me.cmdFett = New System.Windows.Forms.ToolStripButton()
        Me.cmdUnterstrichen = New System.Windows.Forms.ToolStripButton()
        Me.cmdHochstellen = New System.Windows.Forms.ToolStripButton()
        Me.cboGroesse = New System.Windows.Forms.ToolStripComboBox()
        Me.cboFarbe = New System.Windows.Forms.ToolStripComboBox()
        Me.cboSchriftart = New System.Windows.Forms.ToolStripComboBox()
        Me.cmdSpeiern = New System.Windows.Forms.ToolStripButton()
        Me.cmdDruckvorschau = New System.Windows.Forms.Button()
        Me.cmdEnde = New System.Windows.Forms.Button()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Richtextbox
        '
        Me.Richtextbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Richtextbox.Location = New System.Drawing.Point(12, 33)
        Me.Richtextbox.MaxLength = 215654654
        Me.Richtextbox.MinimumSize = New System.Drawing.Size(533, 285)
        Me.Richtextbox.Name = "Richtextbox"
        Me.Richtextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Richtextbox.Size = New System.Drawing.Size(557, 295)
        Me.Richtextbox.TabIndex = 2
        Me.Richtextbox.Text = ""
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(571, 33)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(10, 295)
        Me.txt.TabIndex = 7
        Me.txt.Text = ""
        Me.txt.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdLaden, Me.cmdZeichenzaehlen, Me.cmdFett, Me.cmdUnterstrichen, Me.cmdHochstellen, Me.cboGroesse, Me.cboFarbe, Me.cboSchriftart, Me.cmdSpeiern})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(581, 25)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdLaden
        '
        Me.cmdLaden.Image = CType(resources.GetObject("cmdLaden.Image"), System.Drawing.Image)
        Me.cmdLaden.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLaden.Name = "cmdLaden"
        Me.cmdLaden.Size = New System.Drawing.Size(56, 22)
        Me.cmdLaden.Text = "Laden"
        Me.cmdLaden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdZeichenzaehlen
        '
        Me.cmdZeichenzaehlen.Image = CType(resources.GetObject("cmdZeichenzaehlen.Image"), System.Drawing.Image)
        Me.cmdZeichenzaehlen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdZeichenzaehlen.Name = "cmdZeichenzaehlen"
        Me.cmdZeichenzaehlen.Size = New System.Drawing.Size(98, 22)
        Me.cmdZeichenzaehlen.Text = "Zeichen zählen"
        '
        'cmdFett
        '
        Me.cmdFett.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdFett.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFett.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFett.Name = "cmdFett"
        Me.cmdFett.Size = New System.Drawing.Size(23, 22)
        Me.cmdFett.Text = "F"
        Me.cmdFett.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdFett.ToolTipText = "Fett"
        '
        'cmdUnterstrichen
        '
        Me.cmdUnterstrichen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdUnterstrichen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUnterstrichen.Image = CType(resources.GetObject("cmdUnterstrichen.Image"), System.Drawing.Image)
        Me.cmdUnterstrichen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUnterstrichen.Name = "cmdUnterstrichen"
        Me.cmdUnterstrichen.Size = New System.Drawing.Size(23, 22)
        Me.cmdUnterstrichen.Text = "U"
        Me.cmdUnterstrichen.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.cmdUnterstrichen.ToolTipText = "Unterstrichen"
        '
        'cmdHochstellen
        '
        Me.cmdHochstellen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdHochstellen.Font = New System.Drawing.Font("Tahoma", 5.25!)
        Me.cmdHochstellen.Image = CType(resources.GetObject("cmdHochstellen.Image"), System.Drawing.Image)
        Me.cmdHochstellen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdHochstellen.Name = "cmdHochstellen"
        Me.cmdHochstellen.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.cmdHochstellen.Size = New System.Drawing.Size(23, 22)
        Me.cmdHochstellen.Text = "H"
        Me.cmdHochstellen.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdHochstellen.ToolTipText = "Hochgestellt"
        '
        'cboGroesse
        '
        Me.cboGroesse.AutoSize = False
        Me.cboGroesse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGroesse.Name = "cboGroesse"
        Me.cboGroesse.Size = New System.Drawing.Size(50, 21)
        Me.cboGroesse.ToolTipText = "Größe ändern"
        '
        'cboFarbe
        '
        Me.cboFarbe.AutoSize = False
        Me.cboFarbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFarbe.Name = "cboFarbe"
        Me.cboFarbe.Size = New System.Drawing.Size(80, 21)
        Me.cboFarbe.ToolTipText = "Farbe ändern"
        '
        'cboSchriftart
        '
        Me.cboSchriftart.AutoSize = False
        Me.cboSchriftart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSchriftart.Name = "cboSchriftart"
        Me.cboSchriftart.Size = New System.Drawing.Size(117, 21)
        Me.cboSchriftart.ToolTipText = "Schriftart ändern"
        '
        'cmdSpeiern
        '
        Me.cmdSpeiern.Image = CType(resources.GetObject("cmdSpeiern.Image"), System.Drawing.Image)
        Me.cmdSpeiern.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSpeiern.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSpeiern.Name = "cmdSpeiern"
        Me.cmdSpeiern.Size = New System.Drawing.Size(74, 22)
        Me.cmdSpeiern.Text = "Speichern"
        Me.cmdSpeiern.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdDruckvorschau
        '
        Me.cmdDruckvorschau.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDruckvorschau.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDruckvorschau.Location = New System.Drawing.Point(12, 337)
        Me.cmdDruckvorschau.Name = "cmdDruckvorschau"
        Me.cmdDruckvorschau.Size = New System.Drawing.Size(119, 23)
        Me.cmdDruckvorschau.TabIndex = 27
        Me.cmdDruckvorschau.Text = "Druckvorschau"
        Me.cmdDruckvorschau.UseVisualStyleBackColor = True
        '
        'cmdEnde
        '
        Me.cmdEnde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEnde.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEnde.Location = New System.Drawing.Point(502, 337)
        Me.cmdEnde.Name = "cmdEnde"
        Me.cmdEnde.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnde.TabIndex = 28
        Me.cmdEnde.Text = "Ende"
        Me.cmdEnde.UseVisualStyleBackColor = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 368)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmdEnde)
        Me.Controls.Add(Me.cmdDruckvorschau)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Richtextbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(589, 396)
        Me.Name = "Form1"
        Me.Text = "MarkTED"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Richtextbox As System.Windows.Forms.RichTextBox
    Friend WithEvents txt As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdLaden As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdZeichenzaehlen As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboGroesse As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmdFett As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdUnterstrichen As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboFarbe As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cboSchriftart As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmdSpeiern As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdHochstellen As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDruckvorschau As System.Windows.Forms.Button
    Friend WithEvents cmdEnde As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton

End Class
