Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Cors

<EnableCors("*", "*", "*")>
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

        Dim objValidate As Validate = New Validate()
        Try
            For Each tag In tags
                CallByName(objValidate, tag.ValidationFunction, CallType.Method, tag)
            Next
            Return Nothing
        Catch ex As Exception
            Dim TagError As TagClass = New TagClass()
            Dim TagErrorList As List(Of TagClass) = New List(Of TagClass)
            TagError.VError = ex.Message
            TagErrorList.Add(TagError)
            Return TagErrorList
        End Try
    End Function




End Class
