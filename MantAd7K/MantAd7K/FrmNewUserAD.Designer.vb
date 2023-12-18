<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewUserAD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtsamAccountName = New System.Windows.Forms.TextBox()
        Me.TxtGivenName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSetPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSurname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtOU = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TxtDisplayName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDepartment = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCompany = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtL = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtwWWHomePage = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(592, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'TxtsamAccountName
        '
        Me.TxtsamAccountName.BackColor = System.Drawing.SystemColors.Window
        Me.TxtsamAccountName.Location = New System.Drawing.Point(592, 50)
        Me.TxtsamAccountName.Name = "TxtsamAccountName"
        Me.TxtsamAccountName.Size = New System.Drawing.Size(180, 20)
        Me.TxtsamAccountName.TabIndex = 11
        '
        'TxtGivenName
        '
        Me.TxtGivenName.Location = New System.Drawing.Point(215, 50)
        Me.TxtGivenName.Name = "TxtGivenName"
        Me.TxtGivenName.Size = New System.Drawing.Size(180, 20)
        Me.TxtGivenName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombres"
        '
        'TxtSetPassword
        '
        Me.TxtSetPassword.Location = New System.Drawing.Point(592, 89)
        Me.TxtSetPassword.Name = "TxtSetPassword"
        Me.TxtSetPassword.Size = New System.Drawing.Size(90, 20)
        Me.TxtSetPassword.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(592, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contraseña"
        '
        'TxtCN
        '
        Me.TxtCN.Location = New System.Drawing.Point(215, 89)
        Me.TxtCN.Name = "TxtCN"
        Me.TxtCN.ReadOnly = True
        Me.TxtCN.Size = New System.Drawing.Size(366, 20)
        Me.TxtCN.TabIndex = 9
        Me.TxtCN.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(215, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nombre Completo"
        '
        'TxtSurname
        '
        Me.TxtSurname.Location = New System.Drawing.Point(401, 50)
        Me.TxtSurname.Name = "TxtSurname"
        Me.TxtSurname.Size = New System.Drawing.Size(180, 20)
        Me.TxtSurname.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Apellidos"
        '
        'BtnCreate
        '
        Me.BtnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreate.Location = New System.Drawing.Point(697, 351)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCreate.TabIndex = 13
        Me.BtnCreate.Text = "&Crear"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Location = New System.Drawing.Point(697, 380)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 14
        Me.BtnClear.Text = "&Limpiar"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Location = New System.Drawing.Point(697, 409)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 15
        Me.BtnExit.Text = "&Salir"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TxtOU
        '
        Me.TxtOU.Location = New System.Drawing.Point(41, 9)
        Me.TxtOU.Name = "TxtOU"
        Me.TxtOU.ReadOnly = True
        Me.TxtOU.Size = New System.Drawing.Size(540, 20)
        Me.TxtOU.TabIndex = 17
        Me.TxtOU.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "OU"
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.SystemColors.Window
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TreeView1.Location = New System.Drawing.Point(12, 34)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(197, 402)
        Me.TreeView1.TabIndex = 18
        Me.TreeView1.TabStop = False
        '
        'TxtDisplayName
        '
        Me.TxtDisplayName.Location = New System.Drawing.Point(215, 128)
        Me.TxtDisplayName.Name = "TxtDisplayName"
        Me.TxtDisplayName.Size = New System.Drawing.Size(366, 20)
        Me.TxtDisplayName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre a Mostrar"
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(215, 167)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(366, 20)
        Me.TxtTitle.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(215, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Cargo"
        '
        'TxtTelephoneNumber
        '
        Me.TxtTelephoneNumber.Location = New System.Drawing.Point(215, 206)
        Me.TxtTelephoneNumber.Name = "TxtTelephoneNumber"
        Me.TxtTelephoneNumber.Size = New System.Drawing.Size(90, 20)
        Me.TxtTelephoneNumber.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(215, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Telefono"
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(311, 206)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(270, 20)
        Me.TxtMail.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(311, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Correo"
        '
        'TxtDepartment
        '
        Me.TxtDepartment.Location = New System.Drawing.Point(215, 284)
        Me.TxtDepartment.Name = "TxtDepartment"
        Me.TxtDepartment.Size = New System.Drawing.Size(180, 20)
        Me.TxtDepartment.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(215, 268)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Area de Trabajo"
        '
        'TxtCompany
        '
        Me.TxtCompany.Location = New System.Drawing.Point(215, 245)
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Size = New System.Drawing.Size(366, 20)
        Me.TxtCompany.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(215, 229)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Compañia"
        '
        'TxtL
        '
        Me.TxtL.Location = New System.Drawing.Point(401, 284)
        Me.TxtL.Name = "TxtL"
        Me.TxtL.Size = New System.Drawing.Size(180, 20)
        Me.TxtL.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(401, 268)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Sede"
        '
        'TxtwWWHomePage
        '
        Me.TxtwWWHomePage.Location = New System.Drawing.Point(215, 323)
        Me.TxtwWWHomePage.Name = "TxtwWWHomePage"
        Me.TxtwWWHomePage.Size = New System.Drawing.Size(366, 20)
        Me.TxtwWWHomePage.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(215, 307)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "WEB"
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(215, 362)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescription.Size = New System.Drawing.Size(366, 70)
        Me.TxtDescription.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(215, 346)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Descripcion"
        '
        'FrmNewUserAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtwWWHomePage)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtL)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtCompany)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtDepartment)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTelephoneNumber)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtDisplayName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.TxtOU)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.TxtSetPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSurname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtGivenName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtsamAccountName)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmNewUserAD"
        Me.Text = "FrmNewUserAD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtsamAccountName As Windows.Forms.TextBox
    Friend WithEvents TxtGivenName As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtSetPassword As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents TxtCN As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TxtSurname As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents BtnCreate As Windows.Forms.Button
    Friend WithEvents BtnClear As Windows.Forms.Button
    Friend WithEvents BtnExit As Windows.Forms.Button
    Friend WithEvents TxtOU As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TreeView1 As Windows.Forms.TreeView
    Friend WithEvents TxtDisplayName As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtTitle As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents TxtTelephoneNumber As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxtMail As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents TxtDepartment As Windows.Forms.TextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents TxtCompany As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents TxtL As Windows.Forms.TextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents TxtwWWHomePage As Windows.Forms.TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents TxtDescription As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
End Class
