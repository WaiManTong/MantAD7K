<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisorAD
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblCnx = New System.Windows.Forms.Label()
        Me.BtnFilter = New System.Windows.Forms.Button()
        Me.TxtFilter = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnClearFilter = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnSaveAD = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCnx
        '
        Me.LblCnx.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCnx.AutoSize = True
        Me.LblCnx.ForeColor = System.Drawing.SystemColors.Info
        Me.LblCnx.Location = New System.Drawing.Point(8, 6)
        Me.LblCnx.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCnx.Name = "LblCnx"
        Me.LblCnx.Size = New System.Drawing.Size(51, 13)
        Me.LblCnx.TabIndex = 0
        Me.LblCnx.Text = "Dominio :"
        '
        'BtnFilter
        '
        Me.BtnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFilter.FlatAppearance.BorderSize = 0
        Me.BtnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilter.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnFilter.Location = New System.Drawing.Point(11, 21)
        Me.BtnFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(43, 23)
        Me.BtnFilter.TabIndex = 1
        Me.BtnFilter.Text = "Filtrar"
        Me.BtnFilter.UseVisualStyleBackColor = True
        '
        'TxtFilter
        '
        Me.TxtFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFilter.BackColor = System.Drawing.SystemColors.Desktop
        Me.TxtFilter.ForeColor = System.Drawing.SystemColors.Info
        Me.TxtFilter.Location = New System.Drawing.Point(58, 23)
        Me.TxtFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtFilter.Name = "TxtFilter"
        Me.TxtFilter.Size = New System.Drawing.Size(231, 20)
        Me.TxtFilter.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(8, 52)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(303, 202)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnClearFilter
        '
        Me.BtnClearFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClearFilter.FlatAppearance.BorderSize = 0
        Me.BtnClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearFilter.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnClearFilter.Location = New System.Drawing.Point(289, 21)
        Me.BtnClearFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClearFilter.Name = "BtnClearFilter"
        Me.BtnClearFilter.Size = New System.Drawing.Size(19, 23)
        Me.BtnClearFilter.TabIndex = 4
        Me.BtnClearFilter.Text = "X"
        Me.BtnClearFilter.UseVisualStyleBackColor = True
        '
        'BtnReload
        '
        Me.BtnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnReload.FlatAppearance.BorderSize = 0
        Me.BtnReload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReload.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnReload.Location = New System.Drawing.Point(8, 258)
        Me.BtnReload.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(74, 23)
        Me.BtnReload.TabIndex = 5
        Me.BtnReload.Text = "Refrescar"
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'BtnSaveAD
        '
        Me.BtnSaveAD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveAD.FlatAppearance.BorderSize = 0
        Me.BtnSaveAD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnSaveAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveAD.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnSaveAD.Location = New System.Drawing.Point(86, 258)
        Me.BtnSaveAD.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSaveAD.Name = "BtnSaveAD"
        Me.BtnSaveAD.Size = New System.Drawing.Size(74, 23)
        Me.BtnSaveAD.TabIndex = 6
        Me.BtnSaveAD.Text = "Grabar"
        Me.BtnSaveAD.UseVisualStyleBackColor = True
        '
        'FrmVisorAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(319, 289)
        Me.Controls.Add(Me.BtnSaveAD)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.BtnClearFilter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtFilter)
        Me.Controls.Add(Me.BtnFilter)
        Me.Controls.Add(Me.LblCnx)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmVisorAD"
        Me.Text = "FrmVisorAD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCnx As Windows.Forms.Label
    Friend WithEvents BtnFilter As Windows.Forms.Button
    Friend WithEvents TxtFilter As Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents BtnClearFilter As Windows.Forms.Button
    Friend WithEvents BtnReload As Windows.Forms.Button
    Friend WithEvents BtnSaveAD As Windows.Forms.Button
End Class
