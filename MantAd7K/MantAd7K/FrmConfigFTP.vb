Imports System.Globalization
Imports System.IO
Imports System.Windows
Imports CsvHelper

Public Class FrmConfigFTP
    Private _RutaCSV As String

    ' Método para leer el archivo CSV y asignar valores al formulario
    Public Sub LeerArchivoCSV(rutaArchivo As String)
        Dim FileFTPConfig As String = rutaArchivo & "FTPConfig.csv"
        ' Utilizamos un StreamReader para leer el archivo CSV
        Using reader As New StreamReader(FileFTPConfig)
            ' Configuramos el lector CSVHelper
            Using csv As New CsvReader(reader, CultureInfo.InvariantCulture)
                ' Leemos el archivo CSV y mapeamos las columnas a las propiedades del formulario
                csv.Read()
                csv.ReadHeader()
                While csv.Read()
                    txtFTPServer.Text = csv.GetField(Of String)("FTPServer")
                    txtFTPUsername.Text = csv.GetField(Of String)("FTPUsername")
                    txtFTPPassword.Text = csv.GetField(Of String)("FTPPassword")
                    txtLocalFolderPath.Text = csv.GetField(Of String)("LocalFolderPath")
                    txtRemoteFolderPath.Text = csv.GetField(Of String)("RemoteFolderPath")
                End While
            End Using
        End Using
    End Sub


    ' Constructor que toma el nombre del archivo como parámetro
    Public Sub New(ByVal Ruta As String)
        InitializeComponent()
        ' Asignar el nombre del archivo a la variable
        _RutaCSV = Ruta
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        ' Obtener la información de los TextBox
        Dim ftpServer As String = txtFTPServer.Text
        Dim ftpUsername As String = txtFTPUsername.Text
        Dim ftpPassword As String = txtFTPPassword.Text
        Dim localFolderPath As String = txtLocalFolderPath.Text
        Dim remoteFolderPath As String = txtRemoteFolderPath.Text

        ' Validar si todos los campos están llenos
        If String.IsNullOrWhiteSpace(ftpServer) OrElse
           String.IsNullOrWhiteSpace(ftpUsername) OrElse
           String.IsNullOrWhiteSpace(ftpPassword) OrElse
           String.IsNullOrWhiteSpace(localFolderPath) OrElse
           String.IsNullOrWhiteSpace(remoteFolderPath) Then
            MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos Vacíos", vbOK + vbCritical)
            Return
        End If

        ' Crear objeto de configuración FTP
        Dim ftpConfig As New FTPConfig(ftpServer, ftpUsername, ftpPassword, localFolderPath, remoteFolderPath)

        ' Guardar la configuración en un archivo CSV
        GuardarConfiguracionCSV(ftpConfig)

        BtnExit.PerformClick()
    End Sub

    Private Sub GuardarConfiguracionCSV(ftpConfig As FTPConfig)

        ' Combinar la ruta del escritorio con el nombre del archivo CSV
        Dim rutaArchivoCSV As String = Path.Combine(_RutaCSV, "FTPConfig.csv")
        If File.Exists(rutaArchivoCSV) Then
            File.Delete(rutaArchivoCSV)
        End If


        ' Escribir la configuración en el archivo CSV
        Using writer As New StreamWriter(rutaArchivoCSV)
            Using csv As New CsvWriter(writer, Globalization.CultureInfo.InvariantCulture)
                csv.WriteHeader(Of FTPConfig)()
                csv.NextRecord()
                csv.WriteRecord(ftpConfig)
            End Using
        End Using
    End Sub


    Private Sub FrmConfigFTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeerArchivoCSV(_RutaCSV)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class


'Public Class FTPConfigParameters
'    Public ftpServer As String
'    Public ftpUsername As String
'    Public ftpPassword As String
'    Public localFolderPath As String
'    Public remoteFolderPath As String

'    Public Sub New()
'        MyBase.New
'    End Sub

'End Class