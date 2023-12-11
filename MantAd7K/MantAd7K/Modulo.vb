Imports System.IO
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
End Module
