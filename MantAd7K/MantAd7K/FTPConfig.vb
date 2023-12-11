Public Class FTPConfig
    Public Property FTPServer As String
    Public Property FTPUsername As String
    Public Property FTPPassword As String
    Public Property LocalFolderPath As String
    Public Property RemoteFolderPath As String

    ' Constructor para inicializar las propiedades
    Public Sub New(Optional server As String = Nothing, Optional username As String = Nothing, Optional password As String = Nothing, Optional localFolder As String = Nothing, Optional remoteFolder As String = Nothing)
        FTPServer = server
        FTPUsername = username
        FTPPassword = password
        LocalFolderPath = localFolder
        RemoteFolderPath = remoteFolder
    End Sub
End Class
