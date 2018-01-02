Public Class References
    Implements IDisposable

    Public tDept As DataTable
    Public tItems As DataTable
    Private DeptIndex As Dictionary(Of String, DataRow)
    Private ItemsIndex As Dictionary(Of String, DataRow)

    Public Sub BuildItemIndex(ByRef item As InventoryItem)
        tItems = New DataTable
        ItemsIndex = New Dictionary(Of String, DataRow)
        tItems = item.ReturnAgilisysItems(InventoryItem.SearchMethod.AllItems)
        For Each row As DataRow In tItems.Rows
            ItemsIndex(CType(row(3), String)) = row
        Next
    End Sub

    Public Sub BuildDepartmentIndex()
        DeptIndex = New Dictionary(Of String, DataRow)
        ReturnDepartments()
        For Each row As DataRow In tDept.Rows
            DeptIndex(CType(row(0), String)) = row
        Next
    End Sub

    Public Sub SearchDept(deptName As String, ByRef dept As Deparmtnets)
        Dim rw As DataRow = Nothing
        If DeptIndex.TryGetValue(deptName, rw) Then
            With dept
                .DepartmentName = CType(rw.Item(0), String)
                .DivisionID = CType(rw.Item(1), Integer)
                .DepartmentID = CType(rw.Item(2), Integer)
            End With
        End If
    End Sub

    Public Function SearchItemIndex(myKey As String, ByRef item As InventoryItem) As Boolean
        Try
            Dim rw As DataRow = Nothing
            If ItemsIndex.TryGetValue(myKey, rw) Then
                With item
                    .VendorItemNumber = CType(rw.Item(2), String)
                    .AgilisysItemNumber = CDbl(rw.Item(3))
                    .Description = CType(rw.Item(4), String)
                    .Price = CType(rw.Item(8), String)
                    .VendorName = CType(rw.Item(1), String)
                    .Packaging = CType(rw.Item(5), String)
                    .UnitMeasure = CType(rw.Item(6), String)
                    .Quantity = CType(rw.Item(7), Integer)
                End With
                item.Exists = True
            Else
                item.Exists = False
            End If
        Catch
            MsgBox("Index not initialized")
        End Try
        Return item.Exists
    End Function

    Private Sub ReturnDepartments()
        Dim com As New DatabaseAccess
        tDept = New DataTable
        With com
            .InitiateADOProcedure("qryDepartments")
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            tDept = .ReturnResults
        End With
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                tDept.Dispose()
                tItems.Dispose()
            End If
            ItemsIndex = Nothing
            DeptIndex = Nothing
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
