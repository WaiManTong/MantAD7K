Public Class ClsUserAD
    Public Property DN As String
    Public Property SAMACCOUNTNAME As String
    Public Property CN As String
    Public Property DESCRIPTION As String
    Public Property DISPLAYNAME As String
    Public Property NAME As String
    Public Property GIVENNAME As String
    Public Property SN As String
    Public Property MAIL As String
    Public Property L As String
    Public Property TITLE As String
    Public Property TELEPHONENUMBER As String
    Public Property DEPARTMENT As String
    Public Property WWWHOMEPAGE As String
    Public Property COMPANY As String

    Public Sub New(ByVal _DN As String, ByVal _sAMAccountName As String, ByVal _cn As String, ByVal _description As String,
                   ByVal _displayName As String, ByVal _name As String, ByVal _givenName As String, ByVal _sn As String,
                   ByVal _mail As String, ByVal _l As String, ByVal _title As String, ByVal _telephoneNumber As String,
                   ByVal _department As String, ByVal _wWWHomePage As String, ByVal _company As String)

        DN = _DN
        SAMACCOUNTNAME = _sAMAccountName
        CN = _cn
        DESCRIPTION = _description
        DISPLAYNAME = _displayName
        NAME = _name
        GIVENNAME = _givenName
        SN = _sn
        MAIL = _mail
        L = _l
        TITLE = _title
        TELEPHONENUMBER = _telephoneNumber
        DEPARTMENT = _department
        WWWHOMEPAGE = _wWWHomePage
        COMPANY = _company
    End Sub
End Class
