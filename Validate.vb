Public Class Validate

    Public Sub testMethod()
        Dim a = "Hello"
    End Sub
    Public Sub Validate_Tag40(ByRef Tag As TagClass)
        Dim a = "Hello"
        Tag.VError = "No Error"
    End Sub

    Public Sub Validate_Tag20(ByRef Tag As TagClass)
        If Tag.Value.Length <> 16 Then
            Tag.VError = "Undertaking number should be 16 characters"
        End If
    End Sub


    Public Sub Validate_Tag36(ByRef Tag As TagClass)
        If (Not Convert.ToString(Tag.Value).Contains(".")) Then
            Tag.VError = "Exchange rate should contain a decimal place"
        End If
    End Sub
End Class
