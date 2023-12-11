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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnPreview = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnTemplate = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RtxtDesign
        '
        Me.RtxtDesign.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RtxtDesign.BackColor = System.Drawing.SystemColors.Desktop
        Me.RtxtDesign.ForeColor = System.Drawing.Color.LimeGreen
        Me.RtxtDesign.Location = New System.Drawing.Point(12, 318)
        Me.RtxtDesign.Name = "RtxtDesign"
        Me.RtxtDesign.ReadOnly = True
        Me.RtxtDesign.Size = New System.Drawing.Size(732, 326)
        Me.RtxtDesign.TabIndex = 0
        Me.RtxtDesign.Text = ""
        '
        'WbSign
        '
        Me.WbSign.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WbSign.Location = New System.Drawing.Point(12, 12)
        Me.WbSign.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WbSign.Name = "WbSign"
        Me.WbSign.Size = New System.Drawing.Size(1062, 300)
        Me.WbSign.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(750, 344)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 19)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(916, 344)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(158, 19)
        Me.TextBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(750, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Campo"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(916, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Valor"
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnAdd.Location = New System.Drawing.Point(982, 384)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(92, 33)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "&Agregar"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(750, 384)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(223, 260)
        Me.ListBox1.TabIndex = 7
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnClear.Location = New System.Drawing.Point(982, 423)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(92, 33)
        Me.BtnClear.TabIndex = 8
        Me.BtnClear.Text = "&Limpiar"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnPreview
        '
        Me.BtnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPreview.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnPreview.Location = New System.Drawing.Point(982, 462)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(92, 33)
        Me.BtnPreview.TabIndex = 9
        Me.BtnPreview.Text = "&Visualizar"
        Me.BtnPreview.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnSave.Location = New System.Drawing.Point(982, 501)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(92, 33)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "&Guardar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnTemplate
        '
        Me.BtnTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTemplate.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnTemplate.Location = New System.Drawing.Point(982, 540)
        Me.BtnTemplate.Name = "BtnTemplate"
        Me.BtnTemplate.Size = New System.Drawing.Size(92, 33)
        Me.BtnTemplate.TabIndex = 11
        Me.BtnTemplate.Text = "&Plantilla"
        Me.BtnTemplate.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnClose.Location = New System.Drawing.Point(982, 579)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(92, 33)
        Me.BtnClose.TabIndex = 12
        Me.BtnClose.Text = "&Cerrar"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmSignDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1086, 656)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnTemplate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnPreview)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.WbSign)
        Me.Controls.Add(Me.RtxtDesign)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSignDesign"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RtxtDesign As Windows.Forms.RichTextBox
    Friend WithEvents WbSign As Windows.Forms.WebBrowser
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents BtnAdd As Windows.Forms.Button
    Friend WithEvents ListBox1 As Windows.Forms.ListBox
    Friend WithEvents BtnClear As Windows.Forms.Button
    Friend WithEvents BtnPreview As Windows.Forms.Button
    Friend WithEvents BtnSave As Windows.Forms.Button
    Friend WithEvents BtnTemplate As Windows.Forms.Button
    Friend WithEvents BtnClose As Windows.Forms.Button
End Class
