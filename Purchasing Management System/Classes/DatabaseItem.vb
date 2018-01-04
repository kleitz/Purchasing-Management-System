Public Class DatabaseItem
    Implements IDisposable
    Public Data As DataTable
    Private Index As Dictionary(Of String, DataRow)

#Region "Index Functions"
    Public Sub BuildIndex(DataAddress As Integer)
        Index = New Dictionary(Of String, DataRow)
        For Each row As DataRow In Data.Rows
            Index(CType(row(DataAddress), String)) = row
        Next
    End Sub

    Public Function SearchIndex(value As String) As DataRow
        Dim rw As DataRow = Nothing
        Try
            If Index.TryGetValue(value, rw) Then
                Return rw
            Else
                Return Nothing
            End If
        Catch
            MsgBox("Index not initialized!")
            Return Nothing
        End Try
    End Function

#End Region

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                Data.Dispose()
                Index.Clear()
            End If
        End If
        disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub
#End Region

End Class
