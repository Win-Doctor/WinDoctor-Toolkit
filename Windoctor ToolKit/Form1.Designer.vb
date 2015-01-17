<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabFunzioni = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Ripristina_Hosts = New System.Windows.Forms.Button()
        Me.Ripristina_Update = New System.Windows.Forms.Button()
        Me.Ripristina_Firewall = New System.Windows.Forms.Button()
        Me.Ripristina_Rete = New System.Windows.Forms.Button()
        Me.Ripristina_TaskManager = New System.Windows.Forms.Button()
        Me.Script = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEsegui = New System.Windows.Forms.Button()
        Me.TxtPastebin = New System.Windows.Forms.TextBox()
        Me.BtnEseguiManualmente = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnAggiornaProcessi = New System.Windows.Forms.Button()
        Me.BtnTermina = New System.Windows.Forms.Button()
        Me.ListaProcessi = New System.Windows.Forms.ListBox()
        Me.ListaFile = New System.Windows.Forms.ListBox()
        Me.ListaTermina = New System.Windows.Forms.ListBox()
        Me.ListaFolder = New System.Windows.Forms.ListBox()
        Me.ListaScript = New System.Windows.Forms.ListBox()
        Me.TabFunzioni.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Script.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabFunzioni
        '
        Me.TabFunzioni.Controls.Add(Me.TabPage2)
        Me.TabFunzioni.Controls.Add(Me.TabPage1)
        Me.TabFunzioni.Controls.Add(Me.Script)
        Me.TabFunzioni.Controls.Add(Me.TabPage3)
        Me.TabFunzioni.Location = New System.Drawing.Point(12, 12)
        Me.TabFunzioni.Name = "TabFunzioni"
        Me.TabFunzioni.SelectedIndex = 0
        Me.TabFunzioni.Size = New System.Drawing.Size(477, 415)
        Me.TabFunzioni.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(469, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tools"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Ripristina_Hosts)
        Me.TabPage1.Controls.Add(Me.Ripristina_Update)
        Me.TabPage1.Controls.Add(Me.Ripristina_Firewall)
        Me.TabPage1.Controls.Add(Me.Ripristina_Rete)
        Me.TabPage1.Controls.Add(Me.Ripristina_TaskManager)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(469, 389)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Fix"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Ripristina_Hosts
        '
        Me.Ripristina_Hosts.Location = New System.Drawing.Point(6, 122)
        Me.Ripristina_Hosts.Name = "Ripristina_Hosts"
        Me.Ripristina_Hosts.Size = New System.Drawing.Size(143, 23)
        Me.Ripristina_Hosts.TabIndex = 6
        Me.Ripristina_Hosts.Text = "Ripristina File Hosts"
        Me.Ripristina_Hosts.UseVisualStyleBackColor = True
        '
        'Ripristina_Update
        '
        Me.Ripristina_Update.Location = New System.Drawing.Point(6, 93)
        Me.Ripristina_Update.Name = "Ripristina_Update"
        Me.Ripristina_Update.Size = New System.Drawing.Size(143, 23)
        Me.Ripristina_Update.TabIndex = 5
        Me.Ripristina_Update.Text = "Ripristina Windows Update"
        Me.Ripristina_Update.UseVisualStyleBackColor = True
        '
        'Ripristina_Firewall
        '
        Me.Ripristina_Firewall.Location = New System.Drawing.Point(6, 64)
        Me.Ripristina_Firewall.Name = "Ripristina_Firewall"
        Me.Ripristina_Firewall.Size = New System.Drawing.Size(143, 23)
        Me.Ripristina_Firewall.TabIndex = 4
        Me.Ripristina_Firewall.Text = "Ripristina Windows Firewall"
        Me.Ripristina_Firewall.UseVisualStyleBackColor = True
        '
        'Ripristina_Rete
        '
        Me.Ripristina_Rete.Location = New System.Drawing.Point(6, 35)
        Me.Ripristina_Rete.Name = "Ripristina_Rete"
        Me.Ripristina_Rete.Size = New System.Drawing.Size(143, 23)
        Me.Ripristina_Rete.TabIndex = 3
        Me.Ripristina_Rete.Text = "Ripristina Rete"
        Me.Ripristina_Rete.UseVisualStyleBackColor = True
        '
        'Ripristina_TaskManager
        '
        Me.Ripristina_TaskManager.Enabled = False
        Me.Ripristina_TaskManager.Location = New System.Drawing.Point(6, 6)
        Me.Ripristina_TaskManager.Name = "Ripristina_TaskManager"
        Me.Ripristina_TaskManager.Size = New System.Drawing.Size(143, 23)
        Me.Ripristina_TaskManager.TabIndex = 2
        Me.Ripristina_TaskManager.Text = "Ripristina Gestione Attività"
        Me.Ripristina_TaskManager.UseVisualStyleBackColor = True
        '
        'Script
        '
        Me.Script.Controls.Add(Me.Label1)
        Me.Script.Controls.Add(Me.BtnEsegui)
        Me.Script.Controls.Add(Me.TxtPastebin)
        Me.Script.Controls.Add(Me.BtnEseguiManualmente)
        Me.Script.Controls.Add(Me.TextBox1)
        Me.Script.Location = New System.Drawing.Point(4, 22)
        Me.Script.Name = "Script"
        Me.Script.Padding = New System.Windows.Forms.Padding(3)
        Me.Script.Size = New System.Drawing.Size(469, 389)
        Me.Script.TabIndex = 3
        Me.Script.Text = "Script"
        Me.Script.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Inserire codice Script:"
        '
        'BtnEsegui
        '
        Me.BtnEsegui.Location = New System.Drawing.Point(125, 349)
        Me.BtnEsegui.Name = "BtnEsegui"
        Me.BtnEsegui.Size = New System.Drawing.Size(62, 34)
        Me.BtnEsegui.TabIndex = 3
        Me.BtnEsegui.Text = "Esegui"
        Me.BtnEsegui.UseVisualStyleBackColor = True
        '
        'TxtPastebin
        '
        Me.TxtPastebin.Location = New System.Drawing.Point(7, 363)
        Me.TxtPastebin.Name = "TxtPastebin"
        Me.TxtPastebin.Size = New System.Drawing.Size(112, 20)
        Me.TxtPastebin.TabIndex = 2
        '
        'BtnEseguiManualmente
        '
        Me.BtnEseguiManualmente.Location = New System.Drawing.Point(309, 349)
        Me.BtnEseguiManualmente.Name = "BtnEseguiManualmente"
        Me.BtnEseguiManualmente.Size = New System.Drawing.Size(154, 34)
        Me.BtnEseguiManualmente.TabIndex = 1
        Me.BtnEseguiManualmente.Text = "Esegui Script Manualmente "
        Me.BtnEseguiManualmente.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(456, 337)
        Me.TextBox1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BtnAggiornaProcessi)
        Me.TabPage3.Controls.Add(Me.BtnTermina)
        Me.TabPage3.Controls.Add(Me.ListaProcessi)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(469, 389)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Lista Processi"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BtnAggiornaProcessi
        '
        Me.BtnAggiornaProcessi.Location = New System.Drawing.Point(142, 6)
        Me.BtnAggiornaProcessi.Name = "BtnAggiornaProcessi"
        Me.BtnAggiornaProcessi.Size = New System.Drawing.Size(75, 23)
        Me.BtnAggiornaProcessi.TabIndex = 2
        Me.BtnAggiornaProcessi.Text = "Aggiorna"
        Me.BtnAggiornaProcessi.UseVisualStyleBackColor = True
        '
        'BtnTermina
        '
        Me.BtnTermina.Location = New System.Drawing.Point(142, 35)
        Me.BtnTermina.Name = "BtnTermina"
        Me.BtnTermina.Size = New System.Drawing.Size(75, 23)
        Me.BtnTermina.TabIndex = 1
        Me.BtnTermina.Text = "Termina"
        Me.BtnTermina.UseVisualStyleBackColor = True
        '
        'ListaProcessi
        '
        Me.ListaProcessi.FormattingEnabled = True
        Me.ListaProcessi.Location = New System.Drawing.Point(6, 6)
        Me.ListaProcessi.Name = "ListaProcessi"
        Me.ListaProcessi.Size = New System.Drawing.Size(129, 381)
        Me.ListaProcessi.TabIndex = 0
        '
        'ListaFile
        '
        Me.ListaFile.FormattingEnabled = True
        Me.ListaFile.Location = New System.Drawing.Point(621, 34)
        Me.ListaFile.Name = "ListaFile"
        Me.ListaFile.Size = New System.Drawing.Size(120, 108)
        Me.ListaFile.TabIndex = 1
        '
        'ListaTermina
        '
        Me.ListaTermina.FormattingEnabled = True
        Me.ListaTermina.Location = New System.Drawing.Point(621, 148)
        Me.ListaTermina.Name = "ListaTermina"
        Me.ListaTermina.Size = New System.Drawing.Size(120, 108)
        Me.ListaTermina.TabIndex = 2
        '
        'ListaFolder
        '
        Me.ListaFolder.FormattingEnabled = True
        Me.ListaFolder.Location = New System.Drawing.Point(747, 34)
        Me.ListaFolder.Name = "ListaFolder"
        Me.ListaFolder.Size = New System.Drawing.Size(120, 108)
        Me.ListaFolder.TabIndex = 3
        '
        'ListaScript
        '
        Me.ListaScript.FormattingEnabled = True
        Me.ListaScript.Location = New System.Drawing.Point(495, 34)
        Me.ListaScript.Name = "ListaScript"
        Me.ListaScript.Size = New System.Drawing.Size(120, 394)
        Me.ListaScript.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 435)
        Me.Controls.Add(Me.ListaScript)
        Me.Controls.Add(Me.ListaFolder)
        Me.Controls.Add(Me.ListaTermina)
        Me.Controls.Add(Me.ListaFile)
        Me.Controls.Add(Me.TabFunzioni)
        Me.Name = "Form1"
        Me.Text = "Windoctor ToolKit"
        Me.TabFunzioni.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Script.ResumeLayout(False)
        Me.Script.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabFunzioni As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Ripristina_TaskManager As System.Windows.Forms.Button
    Friend WithEvents Script As System.Windows.Forms.TabPage
    Friend WithEvents BtnEseguiManualmente As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnEsegui As System.Windows.Forms.Button
    Friend WithEvents TxtPastebin As System.Windows.Forms.TextBox
    Friend WithEvents Ripristina_Rete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ripristina_Firewall As System.Windows.Forms.Button
    Friend WithEvents Ripristina_Update As System.Windows.Forms.Button
    Friend WithEvents Ripristina_Hosts As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents BtnTermina As System.Windows.Forms.Button
    Friend WithEvents ListaProcessi As System.Windows.Forms.ListBox
    Friend WithEvents BtnAggiornaProcessi As System.Windows.Forms.Button
    Friend WithEvents ListaFile As System.Windows.Forms.ListBox
    Friend WithEvents ListaTermina As System.Windows.Forms.ListBox
    Friend WithEvents ListaFolder As System.Windows.Forms.ListBox
    Friend WithEvents ListaScript As System.Windows.Forms.ListBox

End Class
