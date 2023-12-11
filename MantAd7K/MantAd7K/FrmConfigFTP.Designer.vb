<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigFTP
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFTPServer = New System.Windows.Forms.TextBox()
        Me.txtFTPUsername = New System.Windows.Forms.TextBox()
        Me.txtFTPPassword = New System.Windows.Forms.TextBox()
        Me.txtLocalFolderPath = New System.Windows.Forms.TextBox()
        Me.txtRemoteFolderPath = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FTPServer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(5, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FTPUsername"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(5, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FTPPassword"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Info
        Me.Label4.Location = New System.Drawing.Point(5, 147)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LocalFolderPath"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(5, 187)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "RemoteFolderPath"
        '
        'txtFTPServer
        '
        Me.txtFTPServer.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtFTPServer.Location = New System.Drawing.Point(161, 22)
        Me.txtFTPServer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFTPServer.Name = "txtFTPServer"
        Me.txtFTPServer.Size = New System.Drawing.Size(289, 26)
        Me.txtFTPServer.TabIndex = 5
        '
        'txtFTPUsername
        '
        Me.txtFTPUsername.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtFTPUsername.Location = New System.Drawing.Point(161, 62)
        Me.txtFTPUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFTPUsername.Name = "txtFTPUsername"
        Me.txtFTPUsername.Size = New System.Drawing.Size(289, 26)
        Me.txtFTPUsername.TabIndex = 6
        '
        'txtFTPPassword
        '
        Me.txtFTPPassword.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtFTPPassword.Location = New System.Drawing.Point(161, 102)
        Me.txtFTPPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFTPPassword.Name = "txtFTPPassword"
        Me.txtFTPPassword.Size = New System.Drawing.Size(289, 26)
        Me.txtFTPPassword.TabIndex = 7
        '
        'txtLocalFolderPath
        '
        Me.txtLocalFolderPath.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtLocalFolderPath.Location = New System.Drawing.Point(161, 142)
        Me.txtLocalFolderPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLocalFolderPath.Name = "txtLocalFolderPath"
        Me.txtLocalFolderPath.Size = New System.Drawing.Size(289, 26)
        Me.txtLocalFolderPath.TabIndex = 8
        '
        'txtRemoteFolderPath
        '
        Me.txtRemoteFolderPath.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtRemoteFolderPath.Location = New System.Drawing.Point(161, 182)
        Me.txtRemoteFolderPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRemoteFolderPath.Name = "txtRemoteFolderPath"
        Me.txtRemoteFolderPath.Size = New System.Drawing.Size(289, 26)
        Me.txtRemoteFolderPath.TabIndex = 9
        '
        'BtnGuardar
        '
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnGuardar.Location = New System.Drawing.Point(113, 222)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(112, 35)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.Info
        Me.BtnExit.Location = New System.Drawing.Point(235, 222)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(112, 35)
        Me.BtnExit.TabIndex = 11
        Me.BtnExit.Text = "&Cerrar"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnExit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRemoteFolderPath)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtLocalFolderPath)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFTPPassword)
        Me.GroupBox1.Controls.Add(Me.txtFTPServer)
        Me.GroupBox1.Controls.Add(Me.txtFTPUsername)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 275)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'FrmConfigFTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(842, 531)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmConfigFTP"
        Me.Text = "Configuracion de Acceso FTP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtFTPServer As Windows.Forms.TextBox
    Friend WithEvents txtFTPUsername As Windows.Forms.TextBox
    Friend WithEvents txtFTPPassword As Windows.Forms.TextBox
    Friend WithEvents txtLocalFolderPath As Windows.Forms.TextBox
    Friend WithEvents txtRemoteFolderPath As Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents BtnExit As Windows.Forms.Button
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
End Class
