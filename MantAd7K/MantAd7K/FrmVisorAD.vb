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

Public Class FrmVisorAD

    Dim datosCSV As New DataTable()

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

    Private Sub ImportarCambios()
        Try
            Dim Candado = vbNo
            Candado = MsgBox("Estas seguro de grabar los cambios?" & vbNewLine & "No hay vuelta atras.", vbYesNo + vbQuestion)

            If Candado = vbYes Then
                ' Ruta al ejecutable CSVDE y parámetros del comando
                Dim rutalLDIF As String = "ldifde"
                Dim parametros As String = "-i -k -f " & Path.Combine(My.Settings.RutaData, "Actualizar.ldf -v -j .\" & My.Settings.RutaData)

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
            Dim nombreArchivo As String = My.Settings.RutaData & "ldif.log" ' Reemplaza con la ruta y nombre del archivo deseado

            ' Crear una instancia del formulario Form2 y pasarle el nombre del archivo
            Dim Log As New FrmLog(nombreArchivo)

            ' Mostrar el formulario
            Log.ShowDialog()
        End Try

    End Sub

    Sub CrearArchivoLDF()
        Try
            If File.Exists(Path.Combine(My.Settings.RutaData, "Actualizar.ldf")) Then
                FileSystem.DeleteFile(Path.Combine(My.Settings.RutaData, "Actualizar.ldf"), UIOption.AllDialogs, RecycleOption.SendToRecycleBin)
            End If
            If File.Exists(Path.Combine(My.Settings.RutaData, "Eliminar.ldf")) Then
                FileSystem.DeleteFile(Path.Combine(My.Settings.RutaData, "Actualizar.ldf"), UIOption.AllDialogs, RecycleOption.SendToRecycleBin)
            End If


            ' Crear un escritor de texto para el archivo LDF
            Using escritor As New StreamWriter(Path.Combine(My.Settings.RutaData, "Actualizar.ldf"))

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

    Sub CrearDirData()
        Try
            ' Verificar si el directorio ya existe
            If Not Directory.Exists(My.Settings.RutaData) Then
                ' Crear el directorio si no existe
                Directory.CreateDirectory(My.Settings.RutaData)
            End If
            If Not Directory.Exists(My.Settings.RutaDataBackup) Then
                ' Crear el directorio si no existe
                Directory.CreateDirectory(My.Settings.RutaDataBackup)
            End If
            If Not Directory.Exists(My.Settings.RutaDataQR) Then
                ' Crear el directorio si no existe
                Directory.CreateDirectory(My.Settings.RutaDataQR)
            End If
            If Not Directory.Exists(My.Settings.RutaDataSign) Then
                ' Crear el directorio si no existe
                Directory.CreateDirectory(My.Settings.RutaDataSign)
            End If

        Catch ex As Exception
            MsgBox("Error al crear el directorio: " & ex.Message)
        End Try
    End Sub
    Private Sub EjecutarCSVDE()
        Try
            Cursor.Current = Windows.Forms.Cursors.WaitCursor
            ' Ruta al ejecutable CSVDE y parámetros del comando
            Dim rutaCSVDE As String = "csvde"
            Dim parametros As String = "-f " & My.Settings.RutaData & "UsuariosAD.csv -r ""(&(objectClass=user)(objectCategory=person))"" -l DN,sAMAccountName,cn,description,displayName,name,givenName,sn,mail,l,title,telephoneNumber,department,wWWHomePage,company"

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
            File.Copy(My.Settings.RutaData & "UsuariosAD.csv", My.Settings.RutaDataBackup & Format(Now(), "yyyyMMddhhmmss") & ".csv", vbYes)

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
            If File.Exists(My.Settings.RutaData & "UsuariosAD.csv") Then
                ' Crear un DataTable y leer el archivo CSV con CsvHelper

                Using reader As New StreamReader(My.Settings.RutaData & "UsuariosAD.csv")
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

            End If
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MsgBox(ex.Message, vbCritical)
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub FrmVisorAD_Load(sender As Object, e As EventArgs) Handles Me.Load
        ColorearFRM(Me)
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
            My.Settings.RutaData = ".\data\" & nombreDominio & "\"
            My.Settings.RutaDataBackup = My.Settings.RutaData & "backups\"
            My.Settings.RutaDataQR = My.Settings.RutaData & "QR\"
            My.Settings.RutaDataSign = My.Settings.RutaData & "Sign\"
            CrearDirData()

            ' Llamar a la función para ejecutar el comando CSVDE
            EjecutarCSVDE()

            ' Luego cargar el archivo CSV en el DataGridView
            CargarArchivoCSV()

        Catch ex As Exception
            MsgBox("No se pudo contactar al AD, intente Conexion Manual")
            Exit Sub
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
    Private Sub TxtFilter_GotFocus(sender As Object, e As EventArgs) Handles TxtFilter.GotFocus
        AcceptButton = BtnFilter
        CancelButton = BtnClearFilter
    End Sub
    Private Sub TxtFilter_LostFocus(sender As Object, e As EventArgs) Handles TxtFilter.LostFocus
        AcceptButton = Nothing
        CancelButton = Nothing
    End Sub

    Private Sub BtnSaveAD_Click(sender As Object, e As EventArgs) Handles BtnSaveAD.Click

        ' Crear el listado LDF para actualizar el AD
        CrearArchivoLDF()
        ' Llamar a la función para importar los cambios al Active Directory
        ImportarCambios()

        If TxtFilter.Text <> Nothing Then
            Dim filtro As String = TxtFilter.Text
            BtnReload.PerformClick()
            BtnFilter.PerformClick()
        End If
    End Sub
    Private Sub BtnClearFilter_Click(sender As Object, e As EventArgs) Handles BtnClearFilter.Click
        TxtFilter.Text = Nothing
        BtnFilter.PerformClick()
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        ' Llamar a la función para ejecutar el comando CSVDE
        EjecutarCSVDE()

        ' Luego cargar el archivo CSV en el DataGridView
        CargarArchivoCSV()

    End Sub
End Class