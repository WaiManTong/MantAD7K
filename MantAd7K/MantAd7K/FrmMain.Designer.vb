﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.PnWindows = New System.Windows.Forms.Panel()
        Me.SS = New System.Windows.Forms.StatusStrip()
        Me.TSSL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSPB = New System.Windows.Forms.ToolStripProgressBar()
        Me.TSSLB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PnMenu = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnConfigTemSign = New System.Windows.Forms.Button()
        Me.BtnGenSignOutlook = New System.Windows.Forms.Button()
        Me.BtnConfigFTP = New System.Windows.Forms.Button()
        Me.BtnUploadFTP = New System.Windows.Forms.Button()
        Me.BtnGenQR = New System.Windows.Forms.Button()
        Me.BtnTools = New System.Windows.Forms.Button()
        Me.BtnNewAD = New System.Windows.Forms.Button()
        Me.BtnLoadAD = New System.Windows.Forms.Button()
        Me.BtnAD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SS.SuspendLayout()
        Me.PnMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnWindows
        '
        Me.PnWindows.BackColor = System.Drawing.Color.Black
        Me.PnWindows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnWindows.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnWindows.Location = New System.Drawing.Point(250, 0)
        Me.PnWindows.Name = "PnWindows"
        Me.PnWindows.Size = New System.Drawing.Size(528, 834)
        Me.PnWindows.TabIndex = 2
        '
        'SS
        '
        Me.SS.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.SS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL, Me.TSPB, Me.TSSLB})
        Me.SS.Location = New System.Drawing.Point(0, 834)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(778, 22)
        Me.SS.TabIndex = 1
        '
        'TSSL
        '
        Me.TSSL.AutoSize = False
        Me.TSSL.Name = "TSSL"
        Me.TSSL.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always
        Me.TSSL.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TSSL.Size = New System.Drawing.Size(500, 17)
        Me.TSSL.Text = "Bienvenido."
        Me.TSSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TSPB
        '
        Me.TSPB.Name = "TSPB"
        Me.TSPB.Size = New System.Drawing.Size(100, 24)
        Me.TSPB.Visible = False
        '
        'TSSLB
        '
        Me.TSSLB.Name = "TSSLB"
        Me.TSSLB.Size = New System.Drawing.Size(112, 25)
        Me.TSSLB.Text = "001 de 1000"
        Me.TSSLB.Visible = False
        '
        'PnMenu
        '
        Me.PnMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnMenu.Controls.Add(Me.BtnExit)
        Me.PnMenu.Controls.Add(Me.BtnConfigTemSign)
        Me.PnMenu.Controls.Add(Me.BtnGenSignOutlook)
        Me.PnMenu.Controls.Add(Me.BtnConfigFTP)
        Me.PnMenu.Controls.Add(Me.BtnUploadFTP)
        Me.PnMenu.Controls.Add(Me.BtnGenQR)
        Me.PnMenu.Controls.Add(Me.BtnTools)
        Me.PnMenu.Controls.Add(Me.BtnNewAD)
        Me.PnMenu.Controls.Add(Me.BtnLoadAD)
        Me.PnMenu.Controls.Add(Me.BtnAD)
        Me.PnMenu.Controls.Add(Me.PictureBox1)
        Me.PnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnMenu.Name = "PnMenu"
        Me.PnMenu.Size = New System.Drawing.Size(250, 834)
        Me.PnMenu.TabIndex = 3
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnExit.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnExit.Location = New System.Drawing.Point(0, 580)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnExit.Size = New System.Drawing.Size(248, 50)
        Me.BtnExit.TabIndex = 15
        Me.BtnExit.Text = "Salir"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnConfigTemSign
        '
        Me.BtnConfigTemSign.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnConfigTemSign.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConfigTemSign.FlatAppearance.BorderSize = 0
        Me.BtnConfigTemSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfigTemSign.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnConfigTemSign.Location = New System.Drawing.Point(0, 540)
        Me.BtnConfigTemSign.Name = "BtnConfigTemSign"
        Me.BtnConfigTemSign.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnConfigTemSign.Size = New System.Drawing.Size(248, 40)
        Me.BtnConfigTemSign.TabIndex = 14
        Me.BtnConfigTemSign.Text = "Configurar Plantilla Firma"
        Me.BtnConfigTemSign.UseVisualStyleBackColor = False
        Me.BtnConfigTemSign.Visible = False
        '
        'BtnGenSignOutlook
        '
        Me.BtnGenSignOutlook.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnGenSignOutlook.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGenSignOutlook.FlatAppearance.BorderSize = 0
        Me.BtnGenSignOutlook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGenSignOutlook.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnGenSignOutlook.Location = New System.Drawing.Point(0, 500)
        Me.BtnGenSignOutlook.Name = "BtnGenSignOutlook"
        Me.BtnGenSignOutlook.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnGenSignOutlook.Size = New System.Drawing.Size(248, 40)
        Me.BtnGenSignOutlook.TabIndex = 13
        Me.BtnGenSignOutlook.Text = "Generar Firma Outlook"
        Me.BtnGenSignOutlook.UseVisualStyleBackColor = False
        Me.BtnGenSignOutlook.Visible = False
        '
        'BtnConfigFTP
        '
        Me.BtnConfigFTP.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnConfigFTP.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConfigFTP.FlatAppearance.BorderSize = 0
        Me.BtnConfigFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfigFTP.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnConfigFTP.Location = New System.Drawing.Point(0, 460)
        Me.BtnConfigFTP.Name = "BtnConfigFTP"
        Me.BtnConfigFTP.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnConfigFTP.Size = New System.Drawing.Size(248, 40)
        Me.BtnConfigFTP.TabIndex = 12
        Me.BtnConfigFTP.Text = "Configurar FTP"
        Me.BtnConfigFTP.UseVisualStyleBackColor = False
        Me.BtnConfigFTP.Visible = False
        '
        'BtnUploadFTP
        '
        Me.BtnUploadFTP.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnUploadFTP.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUploadFTP.FlatAppearance.BorderSize = 0
        Me.BtnUploadFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUploadFTP.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnUploadFTP.Location = New System.Drawing.Point(0, 420)
        Me.BtnUploadFTP.Name = "BtnUploadFTP"
        Me.BtnUploadFTP.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnUploadFTP.Size = New System.Drawing.Size(248, 40)
        Me.BtnUploadFTP.TabIndex = 11
        Me.BtnUploadFTP.Text = "Subir QR FTP"
        Me.BtnUploadFTP.UseVisualStyleBackColor = False
        Me.BtnUploadFTP.Visible = False
        '
        'BtnGenQR
        '
        Me.BtnGenQR.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnGenQR.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGenQR.FlatAppearance.BorderSize = 0
        Me.BtnGenQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGenQR.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnGenQR.Location = New System.Drawing.Point(0, 380)
        Me.BtnGenQR.Name = "BtnGenQR"
        Me.BtnGenQR.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnGenQR.Size = New System.Drawing.Size(248, 40)
        Me.BtnGenQR.TabIndex = 10
        Me.BtnGenQR.Text = "Generar QR"
        Me.BtnGenQR.UseVisualStyleBackColor = False
        Me.BtnGenQR.Visible = False
        '
        'BtnTools
        '
        Me.BtnTools.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTools.FlatAppearance.BorderSize = 0
        Me.BtnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTools.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnTools.Location = New System.Drawing.Point(0, 330)
        Me.BtnTools.Name = "BtnTools"
        Me.BtnTools.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnTools.Size = New System.Drawing.Size(248, 50)
        Me.BtnTools.TabIndex = 9
        Me.BtnTools.Text = "Herramientas"
        Me.BtnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTools.UseVisualStyleBackColor = False
        '
        'BtnNewAD
        '
        Me.BtnNewAD.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnNewAD.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnNewAD.FlatAppearance.BorderSize = 0
        Me.BtnNewAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAD.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnNewAD.Location = New System.Drawing.Point(0, 290)
        Me.BtnNewAD.Name = "BtnNewAD"
        Me.BtnNewAD.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnNewAD.Size = New System.Drawing.Size(248, 40)
        Me.BtnNewAD.TabIndex = 7
        Me.BtnNewAD.Text = "Crear Usuario"
        Me.BtnNewAD.UseVisualStyleBackColor = False
        '
        'BtnLoadAD
        '
        Me.BtnLoadAD.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnLoadAD.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLoadAD.FlatAppearance.BorderSize = 0
        Me.BtnLoadAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoadAD.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnLoadAD.Location = New System.Drawing.Point(0, 250)
        Me.BtnLoadAD.Name = "BtnLoadAD"
        Me.BtnLoadAD.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnLoadAD.Size = New System.Drawing.Size(248, 40)
        Me.BtnLoadAD.TabIndex = 5
        Me.BtnLoadAD.Text = "Leer AD"
        Me.BtnLoadAD.UseVisualStyleBackColor = False
        '
        'BtnAD
        '
        Me.BtnAD.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnAD.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAD.Enabled = False
        Me.BtnAD.FlatAppearance.BorderSize = 0
        Me.BtnAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAD.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnAD.Location = New System.Drawing.Point(0, 200)
        Me.BtnAD.Name = "BtnAD"
        Me.BtnAD.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnAD.Size = New System.Drawing.Size(248, 50)
        Me.BtnAD.TabIndex = 4
        Me.BtnAD.Text = "Directorio Activo"
        Me.BtnAD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAD.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 200)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(778, 856)
        Me.Controls.Add(Me.PnWindows)
        Me.Controls.Add(Me.PnMenu)
        Me.Controls.Add(Me.SS)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MantAD7K"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SS.ResumeLayout(False)
        Me.SS.PerformLayout()
        Me.PnMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SS As Windows.Forms.StatusStrip
    Friend WithEvents PnWindows As Windows.Forms.Panel
    Friend WithEvents PnMenu As Windows.Forms.Panel
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents BtnAD As Windows.Forms.Button
    Friend WithEvents BtnLoadAD As Windows.Forms.Button
    Friend WithEvents BtnExit As Windows.Forms.Button
    Friend WithEvents BtnConfigTemSign As Windows.Forms.Button
    Friend WithEvents BtnGenSignOutlook As Windows.Forms.Button
    Friend WithEvents BtnConfigFTP As Windows.Forms.Button
    Friend WithEvents BtnUploadFTP As Windows.Forms.Button
    Friend WithEvents BtnGenQR As Windows.Forms.Button
    Friend WithEvents BtnTools As Windows.Forms.Button
    Friend WithEvents BtnNewAD As Windows.Forms.Button
    Friend WithEvents TSSL As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSPB As Windows.Forms.ToolStripProgressBar
    Friend WithEvents TSSLB As Windows.Forms.ToolStripStatusLabel
End Class
