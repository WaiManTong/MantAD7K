Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports CsvHelper

Module Modulo

    Public Function LeerFTPConfig(_rutaCsv As String) As FTPConfig
        _rutaCsv = _rutaCsv & "FTPConfig.csv"

        Using lector As New StreamReader(_rutaCsv)
            Using csv As New CsvReader(lector)
                ' Lee solo el primer registro y lo mapea a la clase Empleado
                If csv.Read() Then
                    Return csv.GetRecord(Of FTPConfig)()
                End If
            End Using
        End Using

        ' Si no se encontró ningún registro, retorna Nothing
        Return Nothing
    End Function

    Sub ColorearFRM(ActiveFRM As Form)

        Dim FondoOscuro As Color = SystemColors.Desktop
        Dim FondoControl As Color = SystemColors.Window
        Dim FondoResaltado As Color = SystemColors.ControlLight
        Dim TextoFondoOscuro As Color = SystemColors.Info
        Dim TextoFondoControl As Color = SystemColors.WindowText

        ActiveFRM.BackColor = FondoOscuro
        For Each _control As Control In ActiveFRM.Controls

            Select Case True
                Case TypeOf _control Is TextBox
                    _control.BackColor = FondoControl
                    _control.ForeColor = TextoFondoControl
                Case TypeOf _control Is CheckBox
                    _control.ForeColor = TextoFondoOscuro
                Case TypeOf _control Is Label
                    _control.ForeColor = TextoFondoOscuro
                Case TypeOf _control Is DataGridView
                    ' Formato para DataGridView
                    Dim _datagrid As DataGridView = DirectCast(_control, DataGridView)
                    _datagrid.BackColor = FondoControl
                    _datagrid.ForeColor = TextoFondoControl
                    _datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                    _datagrid.ColumnHeadersDefaultCellStyle.BackColor = FondoOscuro
                    _datagrid.ColumnHeadersDefaultCellStyle.ForeColor = TextoFondoOscuro
                    _datagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                    _datagrid.RowHeadersDefaultCellStyle.BackColor = FondoOscuro
                    _datagrid.RowHeadersDefaultCellStyle.ForeColor = TextoFondoOscuro
                    _datagrid.DefaultCellStyle.BackColor = FondoControl
                    _datagrid.DefaultCellStyle.ForeColor = TextoFondoControl
                    _datagrid.DefaultCellStyle.SelectionBackColor = FondoResaltado

                Case TypeOf _control Is RichTextBox
                    ' Formato para RichTextBox
                    Dim Rtextbox As RichTextBox = DirectCast(_control, RichTextBox)
                    Rtextbox.BackColor = FondoControl
                    Rtextbox.ForeColor = TextoFondoControl
                Case TypeOf _control Is Button
                    ' Formato para Button
                    Dim button As Button = DirectCast(_control, Button)
                    ' Establecer el estilo Flat
                    button.FlatStyle = FlatStyle.Flat
                    button.FlatAppearance.BorderSize = 1
                    button.FlatAppearance.MouseOverBackColor = FondoResaltado
                    button.ForeColor = TextoFondoOscuro

                Case TypeOf _control Is TreeView
                    _control.BackColor = FondoControl
                    _control.ForeColor = TextoFondoControl



            End Select
        Next
    End Sub
End Module
