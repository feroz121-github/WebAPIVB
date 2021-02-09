Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Cors
Imports WebAPIVB.Person

<EnableCors("*", "*", "*")>
Public Class ValuesController
    Inherits ApiController

    ' GET api/values

    Public Function GetValue(ByVal id As Integer) As String
        Return id.ToString()
    End Function

    Public Function GetValue(<FromUri()> ByVal mt760 As MSG_MT760) As List(Of Errors)
        Dim a = 10
        Dim errors = New Errors()
        errors.VField = "Name"
        errors.VError = "Name cannot be more then 20 characters long"

        Dim lstErrors As List(Of Errors) = New List(Of Errors)
        lstErrors.Add(errors)

        Return lstErrors
    End Function

    Public Function GetValues(<FromUri> ByVal person As Person, ByVal msgType As String) As List(Of Errors)

        Dim name = person.Name
        Dim age = person.Age
        Dim errors = New Errors()
        Dim lstErrors As List(Of Errors) = New List(Of Errors)

        If name IsNot Nothing Then
            If name.Length > 20 Then
                errors.VField = "Name"
                errors.VError = "Name cannot be more then 20 characters long"
                lstErrors.Add(errors)
            End If
        End If


        If age > 35 Then
            errors = New Errors()
            errors.VField = "Age"
            errors.VError = "Age cannot be more than 35"
            lstErrors.Add(errors)
        End If

        Return lstErrors
    End Function

    Public Function GetStreetData(ByVal City As String) As IEnumerable(Of Object)
        Dim ObjtString = New String() {"1", "2", "3"}
        Dim objDictnory As New Dictionary(Of String, String)
        Dim dictionary As New Dictionary(Of Integer, Boolean)

        Dim ObjStreetList As List(Of Street) = New List(Of Street)
        Dim ObjStreet As New Street()

        ObjStreet.Street = 32
        ObjStreet.Area = "Tampines"
        ObjStreet.City = "Singapore"

        ObjStreetList.Add(ObjStreet)
        ObjStreet = New Street()

        ObjStreet.Street = 22
        ObjStreet.Area = "Tampines"
        ObjStreet.City = "Singapore"


        ObjStreetList.Add(ObjStreet)
        ObjStreet = New Street()

        ObjStreet.Street = 11
        ObjStreet.Area = "Dalal Street"
        ObjStreet.City = "Mumbai"

        ObjStreetList.Add(ObjStreet)

        If City IsNot Nothing Then
            ObjStreetList = ObjStreetList.Where(Function(x) x.City = City).ToList()
        End If

        Return ObjStreetList
    End Function

    ' GET api/values/Feroz/Kumar

    Public Function GetValue(ByVal firstName As String, ByVal lastName As String) As String
        Return firstName + lastName
    End Function


    ' POST api/values
    'Public Function PostValue(<FromBody()> ByVal mt760 As MSG_MT760) As List(Of Errors)
    '    Dim a = 10
    '    Dim errors = New Errors()
    '    errors.VField = "Name"
    '    errors.VError = "Name cannot be more then 20 characters long"

    '    Dim lstErrors As List(Of Errors) = New List(Of Errors)
    '    lstErrors.Add(errors)

    '    Return lstErrors
    'End Function

    Public Function GetValue(<FromUri()> ByVal tags As TagClass, ByVal source As String) As List(Of TagClass)
        Dim a = 10
        Dim errors = New Errors()
        errors.VField = "Name"
        errors.VError = "Name cannot be more then 20 characters long"

        Dim lstErrors As List(Of Errors) = New List(Of Errors)
        lstErrors.Add(errors)

        Return Nothing
    End Function


    'Public Function PostValue(<FromBody()> ByVal tags As List(Of TagClass)) As List(Of TagClass)
    '    Dim a = 10
    '    Dim errors = New Errors()
    '    errors.VField = "Name"
    '    errors.VError = "Name cannot be more then 20 characters long"

    '    Dim lstErrors As List(Of Errors) = New List(Of Errors)
    '    lstErrors.Add(errors)

    '    Return Nothing
    'End Function

    'Not more than 16 characters
    Public Function Validate_Tag20() As String

        Return Nothing
    End Function

    'user provided a value that is not a number with decimal places. 
    'The decimal delimiter can either be a '.' or ','.
    Public Function Validate_Tag36() As String

        Return Nothing
    End Function

    ' PUT api/values/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub

End Class



