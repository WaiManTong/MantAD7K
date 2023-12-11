<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimientoUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoUsuarios))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLoadAD = New System.Windows.Forms.Button()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnFilter = New System.Windows.Forms.Button()
        Me.TxtFilter = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSSL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSPB = New System.Windows.Forms.ToolStripProgressBar()
        Me.TSSLB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnImport = New System.Windows.Forms.Button()
        Me.BtnQRCoder = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnClearFilter = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LblCnx = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrabarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilidaddesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarQRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarFTPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnConfigFTP = New System.Windows.Forms.Button()
        Me.BtnUploadFTP = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 88)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1140, 648)
        Me.DataGridView1.TabIndex = 0
        '
        'btnLoadAD
        '
        Me.btnLoadAD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoadAD.Location = New System.Drawing.Point(18, 745)
        Me.btnLoadAD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLoadAD.Name = "btnLoadAD"
        Me.btnLoadAD.Size = New System.Drawing.Size(154, 35)
        Me.btnLoadAD.TabIndex = 5
        Me.btnLoadAD.Text = "&Cargar del AD"
        Me.btnLoadAD.UseVisualStyleBackColor = True
        '
        'BtnReload
        '
        Me.BtnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnReload.Location = New System.Drawing.Point(182, 745)
        Me.BtnReload.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(154, 35)
        Me.BtnReload.TabIndex = 6
        Me.BtnReload.Text = "&Cargar de CSV"
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'BtnFilter
        '
        Me.BtnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFilter.Location = New System.Drawing.Point(638, 42)
        Me.BtnFilter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(112, 35)
        Me.BtnFilter.TabIndex = 7
        Me.BtnFilter.Text = "&Filtrar"
        Me.BtnFilter.UseVisualStyleBackColor = True
        '
        'TxtFilter
        '
        Me.TxtFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFilter.Location = New System.Drawing.Point(759, 46)
        Me.TxtFilter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtFilter.Name = "TxtFilter"
        Me.TxtFilter.Size = New System.Drawing.Size(368, 26)
        Me.TxtFilter.TabIndex = 8
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL, Me.TSPB, Me.TSSLB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 832)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1176, 31)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSL
        '
        Me.TSSL.AutoSize = False
        Me.TSSL.Name = "TSSL"
        Me.TSSL.Size = New System.Drawing.Size(600, 26)
        Me.TSSL.Text = "Bienvenido"
        Me.TSSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TSPB
        '
        Me.TSPB.Name = "TSPB"
        Me.TSPB.Size = New System.Drawing.Size(150, 25)
        Me.TSPB.Visible = False
        '
        'TSSLB
        '
        Me.TSSLB.Name = "TSSLB"
        Me.TSSLB.Size = New System.Drawing.Size(82, 26)
        Me.TSSLB.Text = "0 de 100"
        Me.TSSLB.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'BtnImport
        '
        Me.BtnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnImport.Location = New System.Drawing.Point(18, 789)
        Me.BtnImport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(154, 35)
        Me.BtnImport.TabIndex = 10
        Me.BtnImport.Text = "&Grabar en el AD"
        Me.BtnImport.UseVisualStyleBackColor = True
        '
        'BtnQRCoder
        '
        Me.BtnQRCoder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnQRCoder.Location = New System.Drawing.Point(345, 745)
        Me.BtnQRCoder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnQRCoder.Name = "BtnQRCoder"
        Me.BtnQRCoder.Size = New System.Drawing.Size(154, 35)
        Me.BtnQRCoder.TabIndex = 11
        Me.BtnQRCoder.Text = "Generar &QR"
        Me.BtnQRCoder.UseVisualStyleBackColor = True
        '
        'BtnClearFilter
        '
        Me.BtnClearFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClearFilter.Location = New System.Drawing.Point(1126, 46)
        Me.BtnClearFilter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClearFilter.Name = "BtnClearFilter"
        Me.BtnClearFilter.Size = New System.Drawing.Size(32, 32)
        Me.BtnClearFilter.TabIndex = 12
        Me.BtnClearFilter.Text = "X"
        Me.BtnClearFilter.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(183, 789)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(153, 35)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.Text = "Grabar en CSV"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'LblCnx
        '
        Me.LblCnx.AutoSize = True
        Me.LblCnx.Location = New System.Drawing.Point(18, 52)
        Me.LblCnx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCnx.Name = "LblCnx"
        Me.LblCnx.Size = New System.Drawing.Size(79, 20)
        Me.LblCnx.TabIndex = 14
        Me.LblCnx.Text = "Dominio : "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem, Me.CSVToolStripMenuItem, Me.UtilidaddesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1176, 35)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem1, Me.GrabarToolStripMenuItem})
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(149, 29)
        Me.CargarToolStripMenuItem.Text = "&Active Directory"
        '
        'CargarToolStripMenuItem1
        '
        Me.CargarToolStripMenuItem1.Name = "CargarToolStripMenuItem1"
        Me.CargarToolStripMenuItem1.Size = New System.Drawing.Size(149, 30)
        Me.CargarToolStripMenuItem1.Text = "&Cargar"
        '
        'GrabarToolStripMenuItem
        '
        Me.GrabarToolStripMenuItem.Name = "GrabarToolStripMenuItem"
        Me.GrabarToolStripMenuItem.Size = New System.Drawing.Size(149, 30)
        Me.GrabarToolStripMenuItem.Text = "&Grabar"
        '
        'CSVToolStripMenuItem
        '
        Me.CSVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem2, Me.GrabarToolStripMenuItem1})
        Me.CSVToolStripMenuItem.Name = "CSVToolStripMenuItem"
        Me.CSVToolStripMenuItem.Size = New System.Drawing.Size(56, 29)
        Me.CSVToolStripMenuItem.Text = "&CSV"
        '
        'CargarToolStripMenuItem2
        '
        Me.CargarToolStripMenuItem2.Name = "CargarToolStripMenuItem2"
        Me.CargarToolStripMenuItem2.Size = New System.Drawing.Size(149, 30)
        Me.CargarToolStripMenuItem2.Text = "&Cargar"
        '
        'GrabarToolStripMenuItem1
        '
        Me.GrabarToolStripMenuItem1.Name = "GrabarToolStripMenuItem1"
        Me.GrabarToolStripMenuItem1.Size = New System.Drawing.Size(149, 30)
        Me.GrabarToolStripMenuItem1.Text = "&Grabar"
        '
        'UtilidaddesToolStripMenuItem
        '
        Me.UtilidaddesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarQRToolStripMenuItem, Me.ConfigurarFTPToolStripMenuItem})
        Me.UtilidaddesToolStripMenuItem.Name = "UtilidaddesToolStripMenuItem"
        Me.UtilidaddesToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.UtilidaddesToolStripMenuItem.Text = "&Utilidades"
        '
        'GenerarQRToolStripMenuItem
        '
        Me.GenerarQRToolStripMenuItem.Name = "GenerarQRToolStripMenuItem"
        Me.GenerarQRToolStripMenuItem.Size = New System.Drawing.Size(213, 30)
        Me.GenerarQRToolStripMenuItem.Text = "&Generar QR"
        '
        'ConfigurarFTPToolStripMenuItem
        '
        Me.ConfigurarFTPToolStripMenuItem.Name = "ConfigurarFTPToolStripMenuItem"
        Me.ConfigurarFTPToolStripMenuItem.Size = New System.Drawing.Size(213, 30)
        Me.ConfigurarFTPToolStripMenuItem.Text = "&Configurar FTP"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(57, 29)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'BtnConfigFTP
        '
        Me.BtnConfigFTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnConfigFTP.Location = New System.Drawing.Point(507, 789)
        Me.BtnConfigFTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnConfigFTP.Name = "BtnConfigFTP"
        Me.BtnConfigFTP.Size = New System.Drawing.Size(154, 35)
        Me.BtnConfigFTP.TabIndex = 16
        Me.BtnConfigFTP.Text = "Configurar FTP"
        Me.BtnConfigFTP.UseVisualStyleBackColor = True
        '
        'BtnUploadFTP
        '
        Me.BtnUploadFTP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUploadFTP.Location = New System.Drawing.Point(345, 789)
        Me.BtnUploadFTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUploadFTP.Name = "BtnUploadFTP"
        Me.BtnUploadFTP.Size = New System.Drawing.Size(154, 35)
        Me.BtnUploadFTP.TabIndex = 17
        Me.BtnUploadFTP.Text = "Cargar QR FTP"
        Me.BtnUploadFTP.UseVisualStyleBackColor = True
        '
        'FrmMantenimientoUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 863)
        Me.Controls.Add(Me.BtnUploadFTP)
        Me.Controls.Add(Me.BtnConfigFTP)
        Me.Controls.Add(Me.LblCnx)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnClearFilter)
        Me.Controls.Add(Me.BtnQRCoder)
        Me.Controls.Add(Me.BtnImport)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TxtFilter)
        Me.Controls.Add(Me.BtnFilter)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.btnLoadAD)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1189, 893)
        Me.Name = "FrmMantenimientoUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Usuarios en el Active Directory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents btnLoadAD As Windows.Forms.Button
    Friend WithEvents BtnReload As Windows.Forms.Button
    Friend WithEvents BtnFilter As Windows.Forms.Button
    Friend WithEvents TxtFilter As Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents TSSL As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnImport As Windows.Forms.Button
    Friend WithEvents BtnQRCoder As Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
    Friend WithEvents BtnClearFilter As Windows.Forms.Button
    Friend WithEvents BtnSave As Windows.Forms.Button
    Friend WithEvents LblCnx As Windows.Forms.Label
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents CargarToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CSVToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilidaddesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem2 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrabarToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarQRToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSPB As Windows.Forms.ToolStripProgressBar
    Friend WithEvents TSSLB As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ConfigurarFTPToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnConfigFTP As Windows.Forms.Button
    Friend WithEvents BtnUploadFTP As Windows.Forms.Button
End Class
