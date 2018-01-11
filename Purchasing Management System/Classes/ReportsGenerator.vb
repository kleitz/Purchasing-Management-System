Imports Microsoft.Office.Interop
Public Class ReportsGenerator
    Public source As DatabaseItem
    Private xlapp As Excel.Application
    Private xlwb As Excel.Workbook
    Private xlws As Excel.Worksheet

    Public Sub New()
        xlapp = New Excel.Application
        xlwb = xlapp.Workbooks.Add
        xlws = CType(xlwb.Worksheets.Add, Excel.Worksheet)
        source = New DatabaseItem
    End Sub

    Public Sub GenerateReport(Optional modifier As Integer = 3, Optional title As String = "")
        Try
            Dim i As Integer
            i = modifier
            With xlws
                For x As Integer = 1 To source.Data.Rows.Count - 1
                    For y As Integer = 0 To source.Data.Columns.Count - 1
                        .Cells(i, y + 1) = CStr(source.Data.Rows(x).Item(y))
                    Next
                    i += 1
                Next
            End With
            xlapp.Visible = True
            xlws.Range("A1:Z3000").EntireColumn.AutoFit()
            xlws.Cells(1, 1) = title
        Catch ex As Exception
            Dim handler As New ErrorHandler
            With handler
                .ErrorNumber = Err.Number
                .ErrorDescription = Err.Description
                .ExceptionMessage = ex.ToString
                .LogError()
            End With
        End Try
    End Sub
End Class
