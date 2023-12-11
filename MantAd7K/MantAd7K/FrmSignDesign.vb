Imports System.IO
Imports System.Windows.Forms

Public Class FrmSignDesign
    Private Sub FrmSignDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Asigna el código HTML de ejemplo al RichTextBox
        RtxtDesign.Text = "<html><body><h1>Hola, mundo!</h1></body></html>"
        ActualizarVistaPrevia()

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
    End Sub
End Class