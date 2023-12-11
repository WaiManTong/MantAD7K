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

Public Class FrmMantenimientoUsuarios

#Region "Variables del Formulario"
    Dim datosCSV As New DataTable()
    Dim ValorPortable As String = Nothing
    Dim RutaData As String = Nothing
    Dim RutaDataBackup As String = Nothing
    Dim RutaDataVCF As String = Nothing
    Dim RutaDataQR As String = Nothing
#End Region



#Region "SubRutinas"
    Sub UploadImagesToFTP(ByVal ftpServer As String, ByVal ftpUsername As String, ByVal ftpPassword As String, ByVal localFolderPath As String, ByVal remoteFolderPath As String)
        Try
            ' Crear objeto de solicitud FTP para el directorio remoto
            Dim createDirectoryRequest As FtpWebRequest = DirectCast(WebRequest.Create(ftpServer & remoteFolderPath), FtpWebRequest)
            createDirectoryRequest.Credentials = New NetworkCredential(ftpUsername, ftpPassword)
            createDirectoryRequest.Method = WebRequestMethods.Ftp.MakeDirectory

            ' Crear el directorio remoto si no existe
            Try
                Dim response As FtpWebResponse = DirectCast(createDirectoryRequest.GetResponse(), FtpWebResponse)
                response.Close()
            Catch ex As WebException
                ' Ignorar la excepción si el directorio ya existe
                If Not DirectCast(ex.Response, FtpWebResponse).StatusCode = FtpStatusCode.ActionNotTakenFileUnavailable Then
                    Throw
                End If
            End Try

            ' Obtener la lista de archivos en la carpeta local
            Dim localFiles As String() = Directory.GetFiles(localFolderPath)

            ' Configurar la barra de progreso
            TSPB.Maximum = localFiles.Length
            TSPB.Value = 0

            ' Subir cada archivo al servidor FTP
            For Each localFile As VariantType In localFiles
                ' Crear objeto de solicitud FTP para el archivo
                Dim ftpRequest As FtpWebRequest = DirectCast(WebRequest.Create(ftpServer & remoteFolderPath & "/" & Path.GetFileName(localFile)), FtpWebRequest)
                ftpRequest.Credentials = New NetworkCredential(ftpUsername, ftpPassword)
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile

                ' Leer el archivo local
                Dim fileContents As Byte() = File.ReadAllBytes(localFile)

                ' Escribir el archivo en el servidor FTP
                Using requestStream As Stream = ftpRequest.GetRequestStream()
                    requestStream.Write(fileContents, 0, fileContents.Length)
                End Using

                ' Incrementar el valor de la barra de progreso
                TSPB.Value += 1

                ' Imprimir mensaje de éxito
                TSSL.Text = $"Archivo {Path.GetFileName(localFile)} subido correctamente."
            Next

            ' Imprimir mensaje de éxito
            TSSL.Text = "Todos los archivos han sido subidos correctamente."
        Catch ex As Exception

            MsgBox($"Error: {ex.Message}", "UploadImagesToFTP ", vbOK + vbCritical)
        End Try
    End Sub
    Sub CrearDirData()
        Try
            ' Verificar si el directorio ya existe
            If Not Directory.Exists(RutaData) Then
                ' Crear el directorio si no existe
                Directory.CreateDirectory(RutaData)
            End If
            If Not Directory.Exists(RutaDataBackup) Then
                ' Crear el directorio si no existe
                Directory.CreateDirectory(RutaDataBackup)
            End If
            If Not Directory.Exists(RutaDataQR) Then
                ' Crear el directorio si no existe
                Directory.CreateDirectory(RutaDataQR)
            End If

        Catch ex As Exception
            MsgBox("Error al crear el directorio: " & ex.Message, "CrearDirData ", vbOK + vbCritical)
        End Try
    End Sub
    Private Sub ConfigurarDataGridView()
        ' Configuración de columnas en el DataGridView
        DataGridView1.AutoGenerateColumns = True
    End Sub
    Private Sub EjecutarCSVDE()
        Try
            Cursor.Current = Windows.Forms.Cursors.WaitCursor
            ' Ruta al ejecutable CSVDE y parámetros del comando
            Dim rutaCSVDE As String = "csvde"
            Dim parametros As String = "-f " & RutaData & "UsuariosAD.csv -r ""(&(objectClass=user)(objectCategory=person))"" -l DN,sAMAccountName,cn,description,displayName,name,givenName,sn,mail,l,title,telephoneNumber,department,wWWHomePage,company"

            ' Configurar el proceso de inicio
            Dim proceso As New Process()
            ' Configurar para mostrar la ventana de consola
            Dim inicio As New ProcessStartInfo(rutaCSVDE, parametros) With {
                .WindowStyle = ProcessWindowStyle.Hidden,
                .CreateNoWindow = False,
                .UseShellExecute = True
            }

            ' Iniciar el proceso
            proceso.StartInfo = inicio
            proceso.Start()

            ' Esperar a que el proceso termine si es necesario
            proceso.WaitForExit()

            ' Crea Backup del momento
            ' Copy the file to a new folder and rename it.
            File.Copy(RutaData & "UsuariosAD.csv", RutaDataBackup & Format(Now(), "yyyyMMddhhmmss") & ".csv", vbYes)

            ' Verificar si el proceso terminó con errores
            If proceso.ExitCode <> 0 Then
                Throw New Exception($"El proceso CSVDE terminó con el código de salida:  {proceso.ExitCode}")
            End If
        Catch ex As Exception
            Cursor.Current = Windows.Forms.Cursors.Default
            MsgBox(ex.Message)
        End Try
        Cursor.Current = Windows.Forms.Cursors.Default
    End Sub
    Private Sub CargarArchivoCSV()
        Cursor.Current = Cursors.WaitCursor
        Try


            ' Verificar si el archivo existe
            If File.Exists(RutaData & "UsuariosAD.csv") Then
                ' Crear un DataTable y leer el archivo CSV con CsvHelper

                Using reader As New StreamReader(RutaData & "UsuariosAD.csv")
                    Using csv As New CsvReader(reader, New CsvConfiguration(CultureInfo.InvariantCulture))
                        csv.Read()
                        csv.ReadHeader()

                        If datosCSV.Columns.Count < 1 Then
                            ' Agregar las columnas al DataTable
                            For Each header As String In csv.HeaderRecord
                                datosCSV.Columns.Add(header)
                            Next
                        End If
                        datosCSV.Clear()
                        ' Agregar las filas al DataTable
                        While csv.Read()
                            Dim row As DataRow = datosCSV.NewRow()

                            ' Copiar los datos al DataRow directamente
                            For i As Integer = 0 To csv.HeaderRecord.Length - 1
                                row(i) = csv.GetField(i)
                            Next

                            datosCSV.Rows.Add(row)

                        End While
                    End Using
                End Using

                ' Asignar el DataTable al DataGridView
                DataGridView1.DataSource = datosCSV

                For Each columna As DataGridViewColumn In DataGridView1.Columns
                    If columna.Name = "DN" Or
                       columna.Name = "sAMAccountName" Or
                       columna.Name = "cn" Or
                       columna.Name = "name" Then

                        columna.ReadOnly = True

                    End If
                Next

                TSSL.Text = "Se cargaron " & DataGridView1.Rows.Count & " registros."
            Else
                TSSL.Text = "CargarArchivoCSV " & "El archivo CSV no se ha generado correctamente."
            End If
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message, vbCritical)
        End Try
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub ImportarCambios()
        Try
            Dim Candado = vbNo
            Candado = MsgBox("Estas seguro de grabar los cambios?" & vbNewLine & "No hay vuelta atras.", vbYesNo + vbQuestion)

            If Candado = vbYes Then
                ' Ruta al ejecutable CSVDE y parámetros del comando
                Dim rutalLDIF As String = "ldifde"
                Dim parametros As String = "-i -k -f " & Path.Combine(RutaData, "Actualizar.ldf -v -j .\" & RutaData)

                ' Configurar el proceso de inicio
                Dim proceso As New Process()
                ' Configurar para mostrar la ventana de consola
                Dim inicio As New ProcessStartInfo(rutalLDIF, parametros) With {
                    .WindowStyle = ProcessWindowStyle.Hidden,
                    .CreateNoWindow = False,
                    .UseShellExecute = True
                }

                ' Iniciar el proceso
                proceso.StartInfo = inicio
                proceso.Start()

                ' Esperar a que el proceso termine si es necesario
                proceso.WaitForExit()

                ' Verificar si el proceso terminó con errores
                If proceso.ExitCode <> 0 Then
                    Throw New Exception($"El proceso 1 LDIFDE terminó con el código de salida: {proceso.ExitCode}")
                End If

            End If
        Catch ex As Exception
            ' Definir el nombre del archivo que se abrirá
            Dim nombreArchivo As String = RutaData & "ldif.log" ' Reemplaza con la ruta y nombre del archivo deseado

            ' Crear una instancia del formulario Form2 y pasarle el nombre del archivo
            Dim Log As New FrmLog(nombreArchivo)

            ' Mostrar el formulario
            Log.ShowDialog()
        End Try

    End Sub
    Sub CrearArchivoLDF()
        Try
            If File.Exists(Path.Combine(RutaData, "Actualizar.ldf")) Then
                FileSystem.DeleteFile(Path.Combine(RutaData, "Actualizar.ldf"), UIOption.AllDialogs, RecycleOption.SendToRecycleBin)
            End If
            If File.Exists(Path.Combine(RutaData, "Eliminar.ldf")) Then
                FileSystem.DeleteFile(Path.Combine(RutaData, "Actualizar.ldf"), UIOption.AllDialogs, RecycleOption.SendToRecycleBin)
            End If


            ' Crear un escritor de texto para el archivo LDF
            Using escritor As New StreamWriter(Path.Combine(RutaData, "Actualizar.ldf"))

                ' Iterar a través de las filas del DataGridView
                For Each fila As DataGridViewRow In DataGridView1.Rows
                    ' Construir la entrada LDIF para cada fila
                    Dim entradaLDIF As String = "dn:" & fila.Cells("DN").Value & vbCrLf
                    entradaLDIF &= "changetype: modify" & vbCrLf

                    For Each Columna As DataGridViewColumn In DataGridView1.Columns

                        If Columna.Name <> "DN" And Columna.Name <> "sAMAccountName" And Columna.Name <> "cn" And Columna.Name <> "name" Then
                            Debug.Print(Columna.Name & " : " & fila.Cells(Columna.Name).Value.ToString)
                            If fila.Cells(Columna.Name).Value.ToString <> "" Then
                                entradaLDIF &= "replace:" & Columna.Name & vbCrLf
                                entradaLDIF &= Columna.Name & ":" & LimpiarTexto(fila.Cells(Columna.Name).Value) & vbCrLf
                            Else
                                entradaLDIF &= "replace:" & Columna.Name & vbCrLf
                                entradaLDIF &= Columna.Name & ": -" & vbCrLf
                            End If
                            entradaLDIF &= "-" & vbCrLf
                        End If
                    Next

                    ' Separador de entrada LDIF
                    entradaLDIF &= vbCrLf

                    ' Escribir la entrada LDIF en el archivo
                    escritor.Write(entradaLDIF)
                Next
            End Using

        Catch ex As Exception
            MsgBox("Error al crear el archivo LDF: " & ex.Message, "CrearArchivoLDF", vbOK + vbCritical)
        End Try
    End Sub
    Sub GenerarQR()
        Try
            Dim nQR As Integer = 0
            TSPB.Maximum = DataGridView1.RowCount
            TSPB.Visible = True
            TSSLB.Visible = True
            TSSLB.Text = " "
            ' Iterar a través de las filas del DataGridView
            For Each fila As DataGridViewRow In DataGridView1.Rows
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
                        Dim LogoStr As String = RutaData & "logo.jpg"

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

                        Dim rutaImagenQR As String = RutaDataQR & QR & ".jpg"
                        imageQRredim.Save(rutaImagenQR, ImageFormat.Jpeg)
                        nQR = nQR + 1
                        TSPB.Value = nQR
                        TSSLB.Text = nQR.ToString & " de " & DataGridView1.RowCount.ToString
                    End If
                End If
            Next
            TSSL.Text = $"Se generaron {nQR} codigos QR con exito."
            TSPB.Visible = False
            TSSLB.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, "GenerarQR ", vbOK + vbCritical)
        End Try
    End Sub
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

#End Region

#Region "Funciones"
    Private Function ObtenerDatosOriginales() As DataTable
        ' Aquí debes devolver el DataTable original
        ' Puedes cargarlo desde la fuente de datos original o desde un archivo, dependiendo de tu implementación.
        ' Ejemplo:
        ' Dim originalData As New DataTable()
        ' (Lógica para cargar los datos originales en originalData)
        ' Return originalData
        Return datosCSV
    End Function
    Private Function ConstruirFiltro(textoFiltro As String) As String
        ' Aquí puedes personalizar la lógica de construcción del filtro según tus necesidades.
        ' Por ahora, simplemente construyo un filtro básico que verifica si alguna columna contiene el texto especificado.
        ' Puedes adaptar esto según tus requerimientos específicos.

        Dim filtroBuilder As New StringBuilder()

        For Each columna As DataGridViewColumn In DataGridView1.Columns
            ' Verificar si la columna es de tipo cadena antes de agregarla al filtro
            If columna.ValueType Is GetType(String) Then
                If filtroBuilder.Length > 0 Then
                    filtroBuilder.Append(" OR ")
                End If

                filtroBuilder.Append($"[{columna.HeaderText}] LIKE '%{textoFiltro}%'")
            End If
        Next

        Return filtroBuilder.ToString()
    End Function
    Function LimpiarTexto(texto As String) As String
        ' Reemplazar "ñ" y "Ñ" por "n" y "N" respectivamente
        texto = texto.Replace("ñ", "n").Replace("Ñ", "N")

        ' Reemplazar vocales acentuadas y diéresis
        texto = texto.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u")
        texto = texto.Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U")
        texto = texto.Replace("ä", "a").Replace("ë", "e").Replace("ï", "i").Replace("ö", "o").Replace("ü", "u")
        texto = texto.Replace("Ä", "A").Replace("Ë", "E").Replace("Ï", "I").Replace("Ö", "O").Replace("Ü", "U")

        ' Reemplazar "Ç" por "C" y "ç" por "c"
        texto = texto.Replace("Ç", "C").Replace("ç", "c")

        Return texto
    End Function
    Function GetDomainFromUsername(username As String) As String
        Dim parts() As String = username.Split("\"c)
        If parts.Length = 2 Then
            Return parts(0)
        Else
            Return String.Empty
        End If
    End Function
    Private Sub ExportarDataGridViewACSV(dataGridView As DataGridView, filePath As String)
        Try
            ' Crear un escritor de texto para el archivo CSV
            Using writer As New StreamWriter(filePath)
                ' Crear un escritor CSV con el escritor de texto
                Using csv As New CsvWriter(writer, CultureInfo.InvariantCulture)
                    ' Configurar CsvWriter según tus necesidades (opciones, mapeo de columnas, etc.)
                    'csv.Configuration.QuoteAllFields = True
                    ' Escribir encabezados de columnas
                    For Each column As DataGridViewColumn In dataGridView.Columns
                        csv.WriteField(column.HeaderText)
                    Next
                    csv.NextRecord()

                    ' Escribir datos de las filas
                    For Each row As DataGridViewRow In dataGridView.Rows
                        For Each cell As DataGridViewCell In row.Cells
                            csv.WriteField(cell.Value)
                        Next
                        csv.NextRecord()
                    Next
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al exportar a CSV: " & ex.Message, "ExportarDataGridViewACSV", vbOK + vbCritical)
        End Try
    End Sub


#End Region
#Region "Controles"
    Private Sub FrmMantenimientoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ' Obtener información del usuario actual
            Dim currentUser As WindowsIdentity = WindowsIdentity.GetCurrent()
            Dim username As String = currentUser.Name

            ' Obtener el contexto del dominio actual
            Dim currentDomain As Domain = Domain.GetCurrentDomain()
            Dim domainPath As String = "LDAP://" & currentDomain.Name
            Console.WriteLine("Conexión exitosa al Active Directory.")
            LblCnx.Text = currentDomain.Name

            ' Obtener el contexto de dominio actual
            Dim nombreDominio As String = Domain.GetCurrentDomain().ToString

            ' Obtener el nombre del dominio
            RutaData = ".\data\" & nombreDominio & "\"
            RutaDataBackup = RutaData & "backups\"
            RutaDataQR = RutaData & "QR\"
            CrearDirData()


            TSSL.Text = "Conexion Exitosa al Active Directory."

            btnLoadAD.PerformClick()

        Catch ex As Exception
            ' Obtener el directorio de la aplicación
            Dim currentDirectory As String = Path.GetDirectoryName(Application.ExecutablePath)

            ' Crear un objeto FolderBrowserDialog
            ' Configurar propiedades del diálogo
            Dim folderBrowserDialog As New FolderBrowserDialog With {
                .Description = "Selecciona directorio de trabajo",
                .ShowNewFolderButton = True,
                .SelectedPath = currentDirectory ' Establecer el directorio inicial
                }

            ' Mostrar el diálogo y comprobar si el usuario hizo clic en OK
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                ' Obtener el directorio seleccionado por el usuario
                Dim selectedDirectory As String = folderBrowserDialog.SelectedPath

                ' Mostrar el directorio seleccionado
                TSSL.Text = "Directorio seleccionado: " & selectedDirectory
                LblCnx.Text = "Sin Conexion"
                RutaData = ".\data\SinConexion"
            Else
                MsgBox("El usuario canceló la selección." & vbNewLine & "El programa se cerrara.", vbCritical)
                End
            End If
        End Try


        ' Paso 1: Crear el ContextMenuStrip
        ContextMenuStrip1 = New ContextMenuStrip()

        ' Paso 2: Agregar elementos al menú contextual
        Dim item1 As New ToolStripMenuItem("Copiar Valor")
        AddHandler item1.Click, AddressOf Item1_Click
        ContextMenuStrip1.Items.Add(item1)

        Dim item2 As New ToolStripMenuItem("Pegar")
        AddHandler item2.Click, AddressOf Item2_Click
        ContextMenuStrip1.Items.Add(item2)

        ' Paso 3: Asociar el ContextMenuStrip con el DataGridView
        DataGridView1.ContextMenuStrip = ContextMenuStrip1

        ' Configurar la estructura del DataGridView
        ConfigurarDataGridView()

    End Sub
    Private Sub Item1_Click(sender As Object, e As EventArgs)
        ' Copiar el contenido de la celda al portapapeles
        ValorPortable = DataGridView1.CurrentCell.Value
    End Sub
    Private Sub Item2_Click(sender As Object, e As EventArgs)
        Dim selectedCells As DataGridViewSelectedCellCollection = DataGridView1.SelectedCells

        For Each cell As DataGridViewCell In selectedCells
            ' Acceder al valor de la celda
            cell.Value = ValorPortable
        Next

    End Sub
    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer = DataGridView1.HitTest(e.X, e.Y).RowIndex
            Dim currentMouseOverCol As Integer = DataGridView1.HitTest(e.X, e.Y).ColumnIndex

            If currentMouseOverRow >= 0 And currentMouseOverCol >= 0 Then
                ' Mostrar el menú contextual en la posición del cursor
                ContextMenuStrip1.Show(DataGridView1, New System.Drawing.Point(e.X, e.Y))
            End If
        End If
    End Sub
    Private Sub BtnImportAD_Click(sender As Object, e As EventArgs) Handles btnLoadAD.Click

        ' Llamar a la función para ejecutar el comando CSVDE
        EjecutarCSVDE()

        ' Luego cargar el archivo CSV en el DataGridView
        CargarArchivoCSV()

    End Sub
    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        DataGridView1.Columns.Clear()

        Try

            Dim rutaArchivo As New OpenFileDialog
            Dim ruta As String = Nothing
            rutaArchivo.Title = "Selecciona Archivo"
            rutaArchivo.Filter = "Archivos de texto (*.csv)|*.csv|Todos los archivos (*.*)|*.*"
            rutaArchivo.FilterIndex = 1
            rutaArchivo.InitialDirectory = RutaData
            If rutaArchivo.ShowDialog() = DialogResult.OK Then
                ' El usuario ha seleccionado un archivo
                ruta = rutaArchivo.FileName
                RutaData = ruta.Substring(0, ruta.IndexOf("\UsuariosAD.csv"))
            Else
                Exit Sub
            End If

            ' Luego cargar el archivo CSV en el DataGridView
            CargarArchivoCSV()
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}", "BtnReload_Clic ", vbOK + vbCritical)
        End Try
    End Sub
    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        ' Obtener el texto del TextBox para el filtro
        Dim filtro As String = TxtFilter.Text
        DataGridView1.DataSource = datosCSV
        ' Verificar si el filtro no está vacío
        If Not String.IsNullOrEmpty(filtro) Then
            ' Crear un DataView y aplicar el filtro
            Dim vista As New DataView(DirectCast(DataGridView1.DataSource, DataTable)) With {
                .RowFilter = ConstruirFiltro(filtro)
            }
            ' Asignar la vista filtrada al DataGridView
            DataGridView1.DataSource = vista
        Else
            ' Si el filtro está vacío, restaurar los datos originales
            DataGridView1.DataSource = ObtenerDatosOriginales()
        End If
        TSSL.Text = "BtnFilter_Click " & "Se cargaron " & DataGridView1.Rows.Count & " registros."
    End Sub
    Private Sub TxtFilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFilter.KeyPress
        ' Verificar si la tecla presionada es Enter
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Activar el botón BtnFilter
            If Trim(TxtFilter.Text) <> "" Then
                BtnFilter.PerformClick()
            Else
                BtnReload.PerformClick()
            End If

            ' Evitar que el Enter sea procesado más de una vez
            e.Handled = True
        End If
    End Sub
    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click

        ' Crear el listado LDF para actualizar el AD
        CrearArchivoLDF()
        ' Llamar a la función para importar los cambios al Active Directory
        ImportarCambios()

        If TxtFilter.Text <> Nothing Then
            Dim filtro As String = TxtFilter.Text
            btnLoadAD.PerformClick()
            BtnFilter.PerformClick()
        End If
        TSSL.Text = "Cambios Actualizados en el Directorio Activo"

    End Sub
    Private Sub TSSL_TextChanged(sender As Object, e As EventArgs) Handles TSSL.TextChanged
        Beep()
    End Sub
    Private Sub BtnQRCoder_Click(sender As Object, e As EventArgs) Handles BtnQRCoder.Click
        GenerarQR()
    End Sub
    Private Sub BtnClearFilter_Click(sender As Object, e As EventArgs) Handles BtnClearFilter.Click
        TxtFilter.Text = Nothing
        BtnFilter.PerformClick()
    End Sub
    Private Sub TxtFilter_GotFocus(sender As Object, e As EventArgs) Handles TxtFilter.GotFocus
        AcceptButton = BtnFilter
        CancelButton = BtnClearFilter
    End Sub
    Private Sub TxtFilter_LostFocus(sender As Object, e As EventArgs) Handles TxtFilter.LostFocus
        AcceptButton = Nothing
        CancelButton = Nothing
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Mostrar el diálogo para seleccionar la ubicación del archivo CSV
        Dim saveFileDialog As New SaveFileDialog With {
            .Filter = "Archivos CSV (*.csv)|*.csv",
            .Title = "Guardar archivo CSV"
        }

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtener la ubicación del archivo seleccionada por el usuario
            Dim filePath As String = saveFileDialog.FileName

            ' Llamar a la función para exportar los datos del DataGridView al archivo CSV
            ExportarDataGridViewACSV(DataGridView1, filePath)

            MessageBox.Show("Datos exportados exitosamente a CSV.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim response = MsgBox("Realmente desea Salir?", vbYesNo + vbQuestion, "Salir?")
        If response = vbYes Then End
    End Sub
    Private Sub CargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem1.Click
        btnLoadAD.PerformClick()
    End Sub
    Private Sub GrabarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrabarToolStripMenuItem.Click
        BtnImport.PerformClick()
    End Sub
    Private Sub CargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem2.Click
        BtnReload.PerformClick()
    End Sub
    Private Sub GrabarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GrabarToolStripMenuItem1.Click
        BtnSave.PerformClick()
    End Sub
    Private Sub GenerarQRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarQRToolStripMenuItem.Click
        BtnQRCoder.PerformClick()
    End Sub

    Private Sub FrmMantenimientoUsuarios_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        TSSL.Width = Me.Width - 200
    End Sub

    Private Sub BtnConfigFTP_Click(sender As Object, e As EventArgs) Handles BtnConfigFTP.Click
        Dim ftp As New FrmConfigFTP(RutaData)
        ftp.ShowDialog()

    End Sub

    Private Sub BtnUploadFTP_Click(sender As Object, e As EventArgs) Handles BtnUploadFTP.Click
        Dim _ftp As New FTPConfig
        Dim FileFTPConfig As String = RutaData & "FTPConfig.csv"
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

    Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles TxtFilter.TextChanged

    End Sub

#End Region
End Class
