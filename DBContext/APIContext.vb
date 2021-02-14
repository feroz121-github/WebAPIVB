Imports System
Imports Microsoft.EntityFrameworkCore

Partial Public Class APIContext
    Inherits DbContext

    Public Property TagData As DbSet(Of TagClass)


    Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseOracle("User Id=Scott;Password=tiger;Data Source=Ora;")
    End Sub
End Class
