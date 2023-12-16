Imports CsvHelper
Imports CsvHelper.Configuration
Imports System.Data
Imports System.Diagnostics
Imports System.DirectoryServices.ActiveDirectory
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.FileIO
Imports System.Drawing.Imaging
Imports QRCoder
Imports System.Security.Principal
Imports System.Net
Imports System.Collections.Generic

Public Class FrmMain
    Function RedimensionarImagen(imagenOriginal As Bitmap) As Bitmap
        Dim ImageSize As Integer = 129
        ' Crear una nueva imagen con el tamaño deseado
        Dim imagenRedimensionada As New Bitmap(ImageSize, ImageSize)

        ' Crear un objeto Graphics para dibujar la imagen redimensionada
        Dim g As Graphics = Graphics.FromImage(imagenRedimensionada)

        ' Configurar la calidad de dibujo
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        ' Dibujar la imagen original en la nueva imagen con el nuevo tamaño
        g.DrawImage(imagenOriginal, 0, 0, ImageSize, ImageSize)

        ' Liberar recursos
        g.Dispose()

        Return imagenRedimensionada
    End Function

    Sub SuperponerLogoEnQR(ByRef imagenQR As Bitmap, logoPath As String)
        ' Cargar el logo desde el archivo

        Dim logo As New Bitmap(logoPath)

        ' Calcular la posición del logo en el centro del código QR
        Dim posicionX As Integer = (imagenQR.Width - logo.Width) \ 2
        Dim posicionY As Integer = (imagenQR.Height - logo.Height) \ 2

        ' Superponer el logo en el código QR
        Using graficos As Graphics = Graphics.FromImage(imagenQR)
            graficos.DrawImage(logo, posicionX, posicionY, logo.Width, logo.Height)
        End Using

    End Sub

    ' Lista para almacenar referencias a los formularios cargados
    Private formulariosCargados As List(Of Form) = New List(Of Form)

    ' Método para cerrar todos los formularios cargados
    Private Sub CerrarFormulariosCargados()
        ' Cierra y libera los recursos de todos los formularios cargados
        For Each formulario As Form In formulariosCargados
            formulario.Close()
            formulario.Dispose()
        Next

        ' Limpia la lista de formularios cargados
        formulariosCargados.Clear()
    End Sub

    Private Function ObtenerFormularioVisible() As Form
        ' Busca el formulario que tiene la propiedad Visible establecida como True
        For Each formulario As Form In formulariosCargados
            If formulario.Visible Then
                Return formulario
            End If
        Next

        ' Si no se encuentra ningún formulario visible, devuelve Nothing
        Return Nothing
    End Function
    Sub GenerarQR()
        Cursor.Current = Cursors.WaitCursor
        Try
            Dim nQR As Integer = 0
            ' Verifica si hay un formulario cargado antes de intentar manipular el DataGridView
            If ObtenerFormularioVisible() IsNot Nothing AndAlso TypeOf ObtenerFormularioVisible() Is FrmVisorAD Then
                ' Accede al DataGridView en el formulario cargado
                Dim dataGridViewEnFormulario As DataGridView = DirectCast(ObtenerFormularioVisible.Controls("dataGridView1"), DataGridView)




                TSPB.Maximum = dataGridViewEnFormulario.RowCount
                TSPB.Visible = True
                TSSLB.Visible = True
                TSSLB.Text = " "
                ' Iterar a través de las filas del DataGridView
                For Each fila As DataGridViewRow In dataGridViewEnFormulario.Rows
                    If (fila.Cells("mail").Value.ToString <> Nothing And fila.Cells("mail").Value.ToString <> "-") Then

                        If (fila.Cells("title").Value.ToString <> Nothing And fila.Cells("title").Value.ToString <> "-") Or
                               (fila.Cells("telephoneNumber").Value.ToString <> Nothing And fila.Cells("telephoneNumber").Value.ToString <> "-") Then

                            ' Supongamos que las columnas contienen información del contacto
                            Dim nombreCompleto As String = Convert.ToString(fila.Cells("name").Value)
                            Dim nombre As String = Convert.ToString(fila.Cells("givenName").Value)
                            Dim apellido As String = Convert.ToString(fila.Cells("sn").Value)
                            Dim telefono As String = Convert.ToString(fila.Cells("telephoneNumber").Value)
                            Dim empresa As String = Convert.ToString(fila.Cells("company").Value)
                            Dim cargo As String = Convert.ToString(fila.Cells("title").Value)
                            Dim email As String = Convert.ToString(fila.Cells("mail").Value)
                            Dim QR As String = Convert.ToString(fila.Cells("sAMAccountName").Value)


                            ' Crear una cadena de texto con formato VCard
                            Dim vCardData As String = "BEGIN:VCARD" & vbNewLine &
                                                    "VERSION:4.0" & vbNewLine &
                                                    "N:" & apellido & ";" & nombre & ";;;" & vbNewLine &
                                                    "FN:" & nombreCompleto & vbNewLine &
                                                    "ORG:" & empresa & vbNewLine &
                                                    "TITLE:" & cargo & vbNewLine &
                                                    "TEL;WORK:" & telefono & vbNewLine &
                                                    "EMAIL:" & email & vbNewLine &
                                                    "END:VCARD" & vbNewLine

                            ' Crear un generador de códigos QR
                            Dim LogoStr As String = My.Settings.RutaData & "logo.jpg"

                            Dim generadorQR As New QRCodeGenerator()
                            Dim datosQRCode As QRCodeData = generadorQR.CreateQrCode(vCardData, QRCodeGenerator.ECCLevel.Q)
                            Dim codigoQR As New QRCode(datosQRCode)

                            ' Crear una representación gráfica del código QR
                            Dim imagenQR As Bitmap = codigoQR.GetGraphic(6) ' El valor 20 es el tamaño de píxeles por módulo
                            ' Guardar o mostrar la imagen del código QR según tus necesidades

                            If File.Exists(LogoStr) Then
                                ' Superponer el logo en el centro del código QR
                                SuperponerLogoEnQR(imagenQR, LogoStr)
                            End If

                            Dim imageQRredim As Bitmap = RedimensionarImagen(imagenQR)

                            Dim rutaImagenQR As String = My.Settings.RutaDataQR & QR & ".jpg"
                            imageQRredim.Save(rutaImagenQR, ImageFormat.Jpeg)
                            nQR = nQR + 1
                            TSPB.Value = nQR
                            TSSLB.Text = nQR.ToString & " de " & dataGridViewEnFormulario.RowCount.ToString
                        End If
                    End If

                Next
            Else
                MsgBox("El Visor no esta disponible.")
            End If
            TSSL.Text = "Se generaron " & nQR & " codigos QR con exito."
            TSPB.Visible = False
            TSSLB.Visible = False
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Sub GenerateSign()
        Cursor.Current = Cursors.WaitCursor
        Try
            Dim nSign As Integer = 0
            ' Verifica si hay un formulario cargado antes de intentar manipular el DataGridView
            If ObtenerFormularioVisible() IsNot Nothing AndAlso TypeOf ObtenerFormularioVisible() Is FrmVisorAD Then
                ' Accede al DataGridView en el formulario cargado
                Dim dataGridViewEnFormulario As DataGridView = DirectCast(ObtenerFormularioVisible.Controls("dataGridView1"), DataGridView)

                TSPB.Maximum = dataGridViewEnFormulario.RowCount
                TSPB.Visible = True
                TSSLB.Visible = True
                TSSLB.Text = " "
                Dim _plantilla As String = File.ReadAllText(My.Settings.RutaData & "\Plantilla.htm")
                Dim _Esquema As String() = File.ReadAllLines(My.Settings.RutaData & "\FieldsSign.csv")


                ' Iterar a través de las filas del DataGridView
                For Each fila As DataGridViewRow In dataGridViewEnFormulario.Rows
                    If (fila.Cells("mail").Value.ToString <> Nothing And fila.Cells("mail").Value.ToString <> "-") Then

                        If (fila.Cells("title").Value.ToString <> Nothing And fila.Cells("title").Value.ToString <> "-") Or
                               (fila.Cells("telephoneNumber").Value.ToString <> Nothing And fila.Cells("telephoneNumber").Value.ToString <> "-") Then

                            Dim _firma As String = _plantilla

                            ' Recorrer la matriz y realizar el reemplazo
                            For Each linea As String In _Esquema
                                ' Dividir la línea en las dos cadenas
                                Dim partes As String() = linea.Split(","c)

                                ' Verificar que la línea tiene dos partes
                                If partes.Length = 2 Then
                                    ' Obtener los valores de la línea
                                    Dim cadena1 As String = partes(0)
                                    Dim cadena2 As String = partes(1)

                                    ' Realizar el reemplazo en la variable de texto
                                    _firma = _firma.Replace("{" & cadena1 & "}", Convert.ToString(fila.Cells(cadena2).Value))
                                End If
                            Next

                            ' Especifica la ruta completa del archivo de texto
                            Dim filePath As String = My.Settings.RutaDataSign & fila.Cells("mail").Value.ToString & ".htm"
                            ' Si el archivo ya existe, así que se sobrescribe con el nuevo contenido
                            File.WriteAllText(filePath, _firma)
                        End If
                    End If
                    nSign = nSign + 1
                Next
            Else
                MsgBox("El Visor no esta disponible.")
            End If
            TSSL.Text = "Se generaron " & nSign & " Firmas con exito."
            TSPB.Visible = False
            TSSLB.Visible = False
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message)
        End Try
        Cursor.Current = Cursors.Default

    End Sub
    Private Sub CerrarFormularioCargado()
        ' Recorre los controles del Panel y cierra cualquier formulario encontrado.
        For Each control As Control In PnWindows.Controls
            If TypeOf control Is Form Then
                Dim formulario As Form = DirectCast(control, Form)
                formulario.Close()
                formulario.Dispose()
            End If
        Next
    End Sub
    Private Sub CargarFormularioEnPanel(formularioHijo As Form)
        ' Asegúrate de que el formulario hijo no tenga un padre antes de agregarlo al Panel.
        If formularioHijo IsNot Nothing AndAlso formularioHijo.Parent Is Nothing Then
            ' Configura el formulario hijo
            formularioHijo.TopLevel = False
            formularioHijo.FormBorderStyle = FormBorderStyle.None
            formularioHijo.Dock = DockStyle.Fill

            ' Agrega el formulario hijo al Panel
            PnWindows.Controls.Add(formularioHijo)

            ' Muestra el formulario hijo
            formularioHijo.Show()
            formularioHijo.BringToFront()
        End If
    End Sub

    Sub BtnsAD(_visible As Boolean)
        BtnNewAD.Visible = _visible
        BtnLoadAD.Visible = _visible
    End Sub

    Sub BtnsTools(_visible As Boolean)
        BtnConfigTemSign.Visible = _visible
        BtnGenSignOutlook.Visible = _visible
        BtnConfigFTP.Visible = _visible
        BtnUploadFTP.Visible = _visible
        BtnGenQR.Visible = _visible
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub BtnLoadAD_Click(sender As Object, e As EventArgs) Handles BtnLoadAD.Click
        Dim _visor As New FrmVisorAD
        CargarFormularioEnPanel(_visor)
        formulariosCargados.Add(_visor)

    End Sub

    Private Sub BtnConfigFTP_Click(sender As Object, e As EventArgs) Handles BtnConfigFTP.Click
        CerrarFormularioCargado()
        Dim _configftp As New FrmConfigFTP(My.Settings.RutaData)
        CargarFormularioEnPanel(_configftp)
        formulariosCargados.Add(_configftp)
        'Dim ftp As New FrmConfigFTP(RutaData)
        'ftp.ShowDialog()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        BtnLoadAD.PerformClick()

    End Sub

    Private Sub BtnGenQR_Click(sender As Object, e As EventArgs) Handles BtnGenQR.Click
        GenerarQR()
    End Sub

    Private Sub BtnUploadFTP_Click(sender As Object, e As EventArgs) Handles BtnUploadFTP.Click
        Try


            Dim _ftp As New FTPConfig
            Dim FileFTPConfig As String = My.Settings.RutaData & "FTPConfig.csv"
            ' Utilizamos un StreamReader para leer el archivo CSV
            Using reader As New StreamReader(FileFTPConfig)
                ' Configuramos el lector CSVHelper
                Using csv As New CsvReader(reader, CultureInfo.InvariantCulture)
                    ' Leemos el archivo CSV y mapeamos las columnas a las propiedades del formulario
                    csv.Read()
                    csv.ReadHeader()
                    csv.Read()

                    _ftp.FTPServer = csv.GetField(Of String)("FTPServer")
                    _ftp.FTPUsername = csv.GetField(Of String)("FTPUsername")
                    _ftp.FTPPassword = csv.GetField(Of String)("FTPPassword")
                    _ftp.LocalFolderPath = csv.GetField(Of String)("LocalFolderPath")
                    _ftp.RemoteFolderPath = csv.GetField(Of String)("RemoteFolderPath")
                End Using
            End Using
            UploadFileToFtp(_ftp.FTPServer, _ftp.FTPUsername, _ftp.FTPPassword, _ftp.LocalFolderPath, _ftp.RemoteFolderPath)
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Sub UploadFileToFtp(ByVal ftpServer As String, ByVal ftpUsername As String, ByVal ftpPassword As String, ByVal localFilePath As String, ByVal remoteFilePath As String)

        Try
            Dim C As Integer = 0
            ' Recorre la lista de archivos
            For Each archivo As String In FileSystem.GetFiles(localFilePath)
                Dim nombreArchivo = archivo.Split("\")

                ' Crea la solicitud FTP
                Dim ftpRequest As FtpWebRequest = DirectCast(WebRequest.Create(ftpServer & remoteFilePath & "/" & nombreArchivo(nombreArchivo.length - 1)), FtpWebRequest)
                ftpRequest.Credentials = New NetworkCredential(ftpUsername, ftpPassword)
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile

                ' Lee el archivo local y escribe en la solicitud FTP
                Using fileStream As FileStream = File.OpenRead(archivo)
                    Using requestStream As Stream = ftpRequest.GetRequestStream()
                        fileStream.CopyTo(requestStream)
                    End Using
                End Using

                ' Obtiene la respuesta del servidor FTP
                Dim ftpResponse As FtpWebResponse = DirectCast(ftpRequest.GetResponse(), FtpWebResponse)


                C = C + 1
                ' Cierra la respuesta del servidor
                ftpResponse.Close()
            Next
            ' Muestra la respuesta del servidor
            TSSL.Text = "Se ha subido exitosamente " & C & " Imagenes."
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        TSSL.Width = Me.Width - 200
    End Sub

    Private Sub TSSL_TextChanged(sender As Object, e As EventArgs) Handles TSSL.TextChanged
        Beep()

    End Sub

    Private Sub BtnConfigTemSign_Click(sender As Object, e As EventArgs) Handles BtnConfigTemSign.Click
        Dim _configsigndesign As New FrmSignDesign
        CargarFormularioEnPanel(_configsigndesign)
        formulariosCargados.Add(_configsigndesign)
    End Sub

    Private Sub BtnGenSignOutlook_Click(sender As Object, e As EventArgs) Handles BtnGenSignOutlook.Click
        GenerateSign()

    End Sub
End Class