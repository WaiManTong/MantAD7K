Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports CsvHelper
Imports CsvHelper.Configuration

Public Class FrmSignDesign

    Private Sub BuscarCadenasEntreCorchetes()
        ' Obtén el contenido del RichTextBox
        Dim contenido As String = RtxtDesign.Text
        ' Crea un HashSet para almacenar cadenas únicas
        Dim cadenasUnicas As New HashSet(Of String)

        ' Encuentra todas las cadenas encerradas entre {} dentro del contenido del <body>
        Dim regex As New Regex("<body[^>]*>([\s\S]*?)<\/body>", RegexOptions.IgnoreCase)
        Dim coincidencias As MatchCollection = regex.Matches(contenido)

        ' Muestra las cadenas encontradas
        For Each coincidencia As Match In coincidencias
            Dim contenidoBody As String = coincidencia.Groups(1).Value
            Dim regexCadenas As New Regex("\{([^{}]+)\}")
            Dim coincidenciasCadenas As MatchCollection = regexCadenas.Matches(contenidoBody)

            ' Muestra las cadenas encontradas dentro del <body>
            For Each cadena As Match In coincidenciasCadenas
                cadenasUnicas.Add(cadena.Groups(1).Value)
            Next
        Next
        LbxFields.Items.Clear()
        LbxFields.Items.AddRange(cadenasUnicas.ToArray())

    End Sub

    Private Sub FrmSignDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If File.Exists(My.Settings.RutaData & "\Plantilla.htm") Then
            RtxtDesign.Text = File.ReadAllText(My.Settings.RutaData & "\Plantilla.htm")
            BuscarCadenasEntreCorchetes()
        Else
            ' Asigna el código HTML de ejemplo al RichTextBox
            RtxtDesign.Text = "<html><body><h1>Hola, mundo!</h1></body></html>"
        End If
        '--------------------------
        ' Lee la primera línea del archivo CSV para obtener las cabeceras
        Dim primeraLinea As String = File.ReadLines("C:\Users\cgrimaldi\source\repos\MantAD7K\MantAd7K\MantAd7K\bin\Debug\data\pe.doerun.local\UsuariosAD.csv").FirstOrDefault()

        ' Verifica si hay una primera línea
        If Not String.IsNullOrEmpty(primeraLinea) Then
            ' Dividir la línea en campos utilizando coma como delimitador
            Dim cabeceras As String() = primeraLinea.Split(","c)

            ' Limpia el ListBox y agrega las cabeceras
            LbxADFields.Items.Clear()
            LbxADFields.Items.AddRange(cabeceras)
        Else
            MessageBox.Show("El archivo CSV no contiene datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        '------------------------------
        If File.Exists(My.Settings.RutaData & "\FieldsSign.csv") Then

            ' Lee todas las líneas del archivo CSV
            Dim lines As String() = File.ReadAllLines(My.Settings.RutaData & "\FieldsSign.csv")

            ' Agrega cada línea al ListBox
            For Each line As String In lines
                LbxCSVTemplate.Items.Add(line)
            Next

        End If

    End Sub

    Private Sub RtxtDesign_TextChanged(sender As Object, e As EventArgs) Handles RtxtDesign.TextChanged
        ActualizarVistaPrevia()

    End Sub

    Private Sub ActualizarVistaPrevia()
        ' Obtiene el código HTML del RichTextBox
        Dim codigoHTML As String = RtxtDesign.Text

        ' Crea un archivo HTML temporal con el código HTML
        Dim rutaArchivoHTML As String = System.IO.Path.GetTempPath() & "temp.html"
        System.IO.File.WriteAllText(rutaArchivoHTML, codigoHTML)

        ' Muestra el archivo HTML en el WebBrowser
        WbSign.Navigate(rutaArchivoHTML)
    End Sub

    Private Sub BtnTemplate_Click(sender As Object, e As EventArgs) Handles BtnTemplate.Click
        ' Abre un cuadro de diálogo para seleccionar el archivo HTML
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = My.Settings.RutaData
        openFileDialog1.Filter = "Archivos HTML|*.html;*.htm"
        openFileDialog1.Title = "Seleccionar archivo HTML"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Lee el contenido del archivo HTML
            Dim archivoHTML As String = File.ReadAllText(openFileDialog1.FileName)

            ' Asigna el contenido al RichTextBox
            RtxtDesign.Text = archivoHTML
        End If
        BuscarCadenasEntreCorchetes()
    End Sub

    Private Sub LbxFields_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbxFields.SelectedIndexChanged
        If LbxFields.SelectedIndex >= 0 Then
            TxtFields.Text = LbxFields.Text
        End If
    End Sub

    Private Sub LbxADFields_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbxADFields.SelectedIndexChanged
        If LbxADFields.SelectedIndex >= 0 Then
            TxtADFields.Text = LbxADFields.Text
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtFields.Text <> Nothing And TxtADFields.Text <> Nothing Then
            LbxCSVTemplate.Items.Add(TxtFields.Text & "," & TxtADFields.Text)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If LbxCSVTemplate.SelectedItems.Count > 0 Then
            ' Recorrer los elementos seleccionados en el ListBox en orden inverso
            For i As Integer = LbxCSVTemplate.SelectedItems.Count - 1 To 0 Step -1
                ' Eliminar el elemento actual
                LbxCSVTemplate.Items.Remove(LbxCSVTemplate.SelectedItems(i))
            Next
        Else
            MessageBox.Show("No hay elementos seleccionados para borrar.")
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Especifica la ruta completa del archivo CSV
        Dim filePath As String = My.Settings.RutaData & "\FieldsSign.csv"

        ' Verifica si el ListBox contiene elementos
        If LbxCSVTemplate.Items.Count > 0 Then
            ' Crea o sobrescribe el archivo CSV
            Using writer As New StreamWriter(filePath, False) ' El segundo parámetro "False" indica que se sobrescribirá el archivo si ya existe
                ' Escribe cada línea del ListBox en el archivo CSV
                For Each item As Object In LbxCSVTemplate.Items
                    writer.WriteLine(item.ToString())
                Next
            End Using

            MessageBox.Show("Archivo CSV guardado exitosamente.", "Éxito")
        Else
            MessageBox.Show("El ListBox no contiene elementos para guardar.", "Aviso")
        End If

        filePath = My.Settings.RutaData & "\Plantilla.htm"
        ' Verifica si el RichTextBox tiene contenido
        If RtxtDesign.Text.Trim() <> "" Then
            ' Guarda el contenido en el archivo HTML
            File.WriteAllText(filePath, RtxtDesign.Text)

            MessageBox.Show("Plantilla guardada exitosamente.", "Éxito")
        Else
            MessageBox.Show("No hay Plantilla para guardar.", "Aviso")
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class