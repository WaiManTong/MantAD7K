<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSignDesign
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
        Me.RtxtDesign = New System.Windows.Forms.RichTextBox()
        Me.WbSign = New System.Windows.Forms.WebBrowser()
        Me.TxtFields = New System.Windows.Forms.TextBox()
        Me.TxtADFields = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LbxFields = New System.Windows.Forms.ListBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnTemplate = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LbxADFields = New System.Windows.Forms.ListBox()
        Me.LbxCSVTemplate = New System.Windows.Forms.ListBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RtxtDesign
        '
        Me.RtxtDesign.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RtxtDesign.BackColor = System.Drawing.SystemColors.Desktop
        Me.RtxtDesign.ForeColor = System.Drawing.Color.LimeGreen
        Me.RtxtDesign.Location = New System.Drawing.Point(8, 219)
        Me.RtxtDesign.Margin = New System.Windows.Forms.Padding(2)
        Me.RtxtDesign.Name = "RtxtDesign"
        Me.RtxtDesign.Size = New System.Drawing.Size(515, 106)
        Me.RtxtDesign.TabIndex = 0
        Me.RtxtDesign.Text = ""
        '
        'WbSign
        '
        Me.WbSign.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WbSign.Location = New System.Drawing.Point(8, 8)
        Me.WbSign.Margin = New System.Windows.Forms.Padding(2)
        Me.WbSign.MinimumSize = New System.Drawing.Size(13, 13)
        Me.WbSign.Name = "WbSign"
        Me.WbSign.Size = New System.Drawing.Size(515, 202)
        Me.WbSign.TabIndex = 1
        '
        'TxtFields
        '
        Me.TxtFields.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtFields.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFields.Location = New System.Drawing.Point(11, 347)
        Me.TxtFields.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtFields.Name = "TxtFields"
        Me.TxtFields.ReadOnly = True
        Me.TxtFields.Size = New System.Drawing.Size(107, 13)
        Me.TxtFields.TabIndex = 2
        '
        'TxtADFields
        '
        Me.TxtADFields.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtADFields.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtADFields.Location = New System.Drawing.Point(122, 347)
        Me.TxtADFields.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtADFields.Name = "TxtADFields"
        Me.TxtADFields.ReadOnly = True
        Me.TxtADFields.Size = New System.Drawing.Size(108, 13)
        Me.TxtADFields.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(11, 332)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Campo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(122, 332)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Valor"
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnDelete.Location = New System.Drawing.Point(462, 368)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(61, 21)
        Me.BtnDelete.TabIndex = 6
        Me.BtnDelete.Text = "&Borrar"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'LbxFields
        '
        Me.LbxFields.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LbxFields.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LbxFields.FormattingEnabled = True
        Me.LbxFields.Location = New System.Drawing.Point(10, 368)
        Me.LbxFields.Margin = New System.Windows.Forms.Padding(2)
        Me.LbxFields.Name = "LbxFields"
        Me.LbxFields.Size = New System.Drawing.Size(108, 104)
        Me.LbxFields.TabIndex = 7
        '
        'BtnClear
        '
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnClear.Location = New System.Drawing.Point(462, 393)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(61, 21)
        Me.BtnClear.TabIndex = 8
        Me.BtnClear.Text = "&Limpiar"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnSave.Location = New System.Drawing.Point(138, 476)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(61, 21)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "&Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnTemplate
        '
        Me.BtnTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTemplate.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnTemplate.Location = New System.Drawing.Point(203, 476)
        Me.BtnTemplate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTemplate.Name = "BtnTemplate"
        Me.BtnTemplate.Size = New System.Drawing.Size(61, 21)
        Me.BtnTemplate.TabIndex = 11
        Me.BtnTemplate.Text = "&Plantilla"
        Me.BtnTemplate.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnClose.Location = New System.Drawing.Point(268, 476)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(61, 21)
        Me.BtnClose.TabIndex = 12
        Me.BtnClose.Text = "&Cerrar"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LbxADFields
        '
        Me.LbxADFields.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LbxADFields.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LbxADFields.FormattingEnabled = True
        Me.LbxADFields.Location = New System.Drawing.Point(122, 368)
        Me.LbxADFields.Margin = New System.Windows.Forms.Padding(2)
        Me.LbxADFields.Name = "LbxADFields"
        Me.LbxADFields.Size = New System.Drawing.Size(108, 104)
        Me.LbxADFields.TabIndex = 13
        '
        'LbxCSVTemplate
        '
        Me.LbxCSVTemplate.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LbxCSVTemplate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LbxCSVTemplate.FormattingEnabled = True
        Me.LbxCSVTemplate.Location = New System.Drawing.Point(234, 368)
        Me.LbxCSVTemplate.Margin = New System.Windows.Forms.Padding(2)
        Me.LbxCSVTemplate.Name = "LbxCSVTemplate"
        Me.LbxCSVTemplate.Size = New System.Drawing.Size(224, 104)
        Me.LbxCSVTemplate.TabIndex = 14
        '
        'BtnAdd
        '
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnAdd.Location = New System.Drawing.Point(234, 339)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(25, 21)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = ">"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'FrmSignDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(531, 537)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.LbxCSVTemplate)
        Me.Controls.Add(Me.LbxADFields)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnTemplate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LbxFields)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.TxtADFields)
        Me.Controls.Add(Me.TxtFields)
        Me.Controls.Add(Me.WbSign)
        Me.Controls.Add(Me.RtxtDesign)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmSignDesign"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RtxtDesign As Windows.Forms.RichTextBox
    Friend WithEvents WbSign As Windows.Forms.WebBrowser
    Friend WithEvents TxtFields As Windows.Forms.TextBox
    Friend WithEvents TxtADFields As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents BtnDelete As Windows.Forms.Button
    Friend WithEvents LbxFields As Windows.Forms.ListBox
    Friend WithEvents BtnClear As Windows.Forms.Button
    Friend WithEvents BtnSave As Windows.Forms.Button
    Friend WithEvents BtnTemplate As Windows.Forms.Button
    Friend WithEvents BtnClose As Windows.Forms.Button
    Friend WithEvents LbxADFields As Windows.Forms.ListBox
    Friend WithEvents LbxCSVTemplate As Windows.Forms.ListBox
    Friend WithEvents BtnAdd As Windows.Forms.Button
End Class
