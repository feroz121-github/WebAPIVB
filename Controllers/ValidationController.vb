Imports System.Net
Imports System.Web.Http

Public Class ValidationController
    Inherits ApiController

    Public Function GetValue(<FromUri()> ByVal tags As TagClass, ByVal source As String) As List(Of TagClass)
        Dim a = 10
        Dim errors = New Errors()
        errors.VField = "Name"
        errors.VError = "Name cannot be more then 20 characters long"

        Dim lstErrors As List(Of Errors) = New List(Of Errors)
        lstErrors.Add(errors)

        Return Nothing
    End Function

    Public Function PostValue(<FromBody()> ByVal tags As List(Of TagClass)) As List(Of TagClass)

        For Each tag In tags
            Validate(tag.ValidationFunction, tag.Tag, tag.Value)
        Next

        Return Nothing
    End Function

    Public Function Validate(ByVal ValidationFunction As String, ByVal Tag As String, ByVal Value As Object) As String

        Select Case ValidationFunction
            Case "Tag20"
                Return Validate_Tag20(Tag, Value)
            Case "Tag36"
                Return Validate_Tag36(Tag, Value)
        End Select

        Return Nothing
    End Function

    Public Function Validate_Tag20(ByVal Tag As String, ByVal Value As Object) As String
        If Value.Length <> 16 Then
            Return "Undertaking number should be 16 characters"
        End If
        Return ""
    End Function

    Public Function Validate_Tag36(ByVal Tag As String, ByVal Value As Object) As String
        If (Not Convert.ToString(Value).Contains(".")) Then
            Return "Exchange rate should contain a decimal place"
        End If
        Return ""
    End Function

End Class
