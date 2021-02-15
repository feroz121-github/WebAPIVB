Imports System.ComponentModel.DataAnnotations

Public Class MSG_MT760
    Public Property SenderInfo As String
    Public Property MessageType As String
    Public Property IssueDate As String
    Public Property SenderReciever As String
    Public Property MoneyPaid As String
End Class

Public Class TagClass
    <Key>
    Public Property ID As Integer
    Public Property Tag As String
    Public Property Value As String

    Public Property ValidationFunction As String
    Public Property VError As String
End Class