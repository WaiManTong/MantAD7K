Imports System.DirectoryServices
Imports System.DirectoryServices.AccountManagement
Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms

Public Class FrmNewUserAD

    Private Sub RecorrerSubOUs(parentEntry As DirectoryEntry, parentNode As TreeNodeCollection)
        ' Obtener las OUs secundarias
        Dim childEntries As DirectoryEntries = parentEntry.Children
        For Each childEntry As DirectoryEntry In childEntries
            If childEntry.SchemaClassName = "organizationalUnit" Then
                ' Eliminar "OU=" del nombre de la OU
                Dim ouName As String = childEntry.Name.Replace("OU=", "")

                ' Agregar la OU como nodo hijo
                Dim ouNode As New TreeNode(ouName)
                ouNode.Tag = childEntry.Path   ' Almacenar el DN en el Tag del nodo
                parentNode.Add(ouNode)

                ' Recorrer las sub-OUs de forma recursiva
                RecorrerSubOUs(childEntry, ouNode.Nodes)
            End If
        Next
    End Sub

    Sub DisplayName()
        TxtCN.Text = Trim(TxtGivenName.Text & " " & TxtSurname.Text)
        TxtDisplayName.Text = Trim(TxtGivenName.Text & " " & TxtSurname.Text)
    End Sub
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click

        For Each _control As Control In Controls
            If TypeOf _control Is TextBox And _control.Text.Trim = Nothing Then
                If _control.Name = "TxtGivenName" Or _control.Name = "TxtSN" Or
                   _control.Name = "TxtOU" Or _control.Name = "TxtSamAccountName" Or
                   _control.Name = "TxtPassword" Then

                    _control.Focus()
                    MessageBox.Show("Este campo no puede estar vacio.")
                    Exit Sub

                End If
            End If
        Next


        Try
            ' Detecta el dominio automáticamente
            Dim domainContext As New DirectoryContext(DirectoryContextType.Domain)
            Dim domain As Domain = Domain.GetDomain(domainContext)

            ' Especifica la OU donde deseas crear el usuario
            'Dim ouPath As String = "OU=Usuarios,DC=dominio,DC=com"
            Dim ouPath As String = TxtOU.Text

            ' Conéctate al directorio activo con autenticación anónima
            'Dim ldapPath As String = $"LDAP://{domain.Name}/{ouPath}"
            Dim ldapPath As String = ouPath
            Dim Ldap As New DirectoryEntry(ldapPath)

            ' Crea el usuario Test User e inicializa sus propiedades
            'Dim user As DirectoryEntry = Ldap.Children.Add($"cn=Test User", "user")
            Dim user As DirectoryEntry = Ldap.Children.Add($"cn={Trim(TxtGivenName.Text & " " & TxtSurname.Text)}", "user")

            user.Properties("sn").Add(TxtSurname.Text)
            user.Properties("givenName").Add(TxtGivenName.Text)
            user.Properties("CN").Add(TxtCN.Text)
            user.Properties("displayName").Add(TxtDisplayName.Text)
            user.Properties("title").Add(TxtTitle.Text)
            user.Properties("telephoneNumber").Add(TxtTelephoneNumber.Text)
            user.Properties("mail").Add(TxtMail.Text)
            user.Properties("company").Add(TxtCompany.Text)
            user.Properties("department").Add(TxtDepartment.Text)
            user.Properties("l").Add(TxtL.Text)
            user.Properties("wWWHomePage").Add(TxtwWWHomePage.Text)
            user.Properties("description").Add("Cuenta de prueba creada por código")
            user.Properties("SAMAccountName").Add(TxtsamAccountName.Text)
            user.Properties("userPrincipalName").Add(TxtsamAccountName.Text & "@" & TreeView1.TopNode.Text)


            ' Enviamos las modificaciones al servidor
            user.CommitChanges()

            ' Ahora vamos a definir su contraseña. El usuario debe haber sido creado
            ' y guardado antes de poder realizar este paso
            user.Invoke("SetPassword", New Object() {TxtSetPassword.Text})

            ' Activamos la cuenta: ADS_UF_NORMAL_ACCOUNT
            user.Properties("userAccountControl").Value = &H200

            ' Enviamos las modificaciones al servidor
            user.CommitChanges()
        Catch ex As Exception
            MessageBox.Show($"Error al crear el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtGivenName_LostFocus(sender As Object, e As EventArgs) Handles TxtGivenName.LostFocus
        DisplayName()
    End Sub

    Private Sub TxtSurname_LostFocus(sender As Object, e As EventArgs) Handles TxtSurname.LostFocus
        DisplayName()
    End Sub

    Private Sub FrmNewUserAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorearFRM(Me)
        ' Obtener el DN del dominio
        Dim domainEntry As New DirectoryEntry("LDAP://RootDSE")
        Dim domainDN As String = domainEntry.Properties("defaultNamingContext").Value.ToString()

        ' Crear un nodo raíz para el TreeView
        Dim rootNode As New TreeNode(domainDN.Replace("DC=", ""))
        TreeView1.Nodes.Add(rootNode)

        ' Llenar el TreeView con las OUs
        Dim entry As New DirectoryEntry($"LDAP://{domainDN}")
        RecorrerSubOUs(entry, rootNode.Nodes)
        'TreeView1.ExpandAll()
        TreeView1.TopNode.Expand()
        TreeView1.SelectedNode = TreeView1.Nodes(0)

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        ' Muestra el contenido del Tag en el TextBox al seleccionar un nodo
        TxtOU.Text = CStr(e.Node.Tag)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TreeView1.SelectedNode = TreeView1.TopNode
        For Each _control As Control In Controls
            If TypeOf _control Is TextBox Then
                _control.Text = Nothing
            End If
        Next
        TxtGivenName.Focus()

    End Sub

    Private Sub TxtGivenName_TextChanged(sender As Object, e As EventArgs) Handles TxtGivenName.TextChanged

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class