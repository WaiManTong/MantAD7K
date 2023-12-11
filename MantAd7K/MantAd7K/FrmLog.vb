Imports System.IO
Imports System.Windows

Public Class FrmLog
    ' Variable para almacenar el nombre del archivo
    Private archivo As String

    ' Constructor que toma el nombre del archivo como parámetro
    Public Sub New(ByVal nombreArchivo As String)
        InitializeComponent()

        ' Asignar el nombre del archivo a la variable
        archivo = nombreArchivo

        ' Leer el contenido del archivo y mostrarlo en el TextBox
        TxtLog.Text = File.ReadAllText(archivo)
    End Sub

    ' Manejador de eventos para el botón "Grabar"
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Grabar el contenido del TextBox en el archivo
        File.WriteAllText(archivo, TxtLog.Text)
        MessageBox.Show("Contenido grabado en el archivo.", "Éxito", vbOK, vbInformation)
    End Sub

    ' Manejador de eventos para el botón "Cerrar"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        ' Cerrar el formulario
        Me.Close()
    End Sub

    Private Sub FrmLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class