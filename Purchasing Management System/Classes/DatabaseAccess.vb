Imports System.Data.OleDb
Imports System.IO
Public Class DatabaseAccess
    Private Conn As OleDb.OleDbConnection
    Private Table As DataTable
    Private cmd As OleDbCommand
    Private value As VariantType

    Enum ReturnType
        ExecuteNonQuery
        ExecuteReader
    End Enum

    Public Sub InitiateADOProcedure(strCmd As String)
        cmd = New OleDbCommand
        With cmd
            .CommandType() = CommandType.StoredProcedure
            .CommandText = strCmd
        End With
    End Sub

    Public Sub InitiateADOCommand(strCmd As String)
        cmd = New OleDbCommand
        With cmd
            .CommandType = CommandType.Text
            .CommandText = strCmd
        End With
    End Sub

    Public Sub AddParameter(pSQLVariable As String, pValue As String)
        cmd.Parameters.AddWithValue(pSQLVariable, pValue)
    End Sub

    Public Function CheckIfExists() As Boolean
        If Table IsNot Nothing AndAlso Table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
        Table.Dispose()
    End Function

    Public Function ReturnResults() As DataTable
        Return Table
        Table.Dispose()
    End Function

    Public Function ReturnValue() As VariantType
        value = CType(Table.Rows(CInt(Int(Table.Rows.Count * Rnd()))).Item(0), Object).ToString
        Table.Dispose()
        Return value
    End Function

    Public Sub Execute(returnType As ReturnType)
        Submit(cmd, returnType)
    End Sub

    Private Sub Submit(command As OleDbCommand, returnType As ReturnType)
        Try
            Using conn As New OleDbConnection(connectionString:="Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & My.Settings.DatabaseLocation & "; Persist Security Info = false;")
                conn.Open()
                With command
                    .Connection = conn
                    If returnType = ReturnType.ExecuteNonQuery Then
                        .ExecuteNonQuery()
                    ElseIf returnType = ReturnType.ExecuteReader Then
                        Dim reader As OleDb.OleDbDataReader = .ExecuteReader
                        Table = New DataTable
                        Table.Load(reader)
                    End If
                    .Dispose()
                End With
                conn.Close()
                conn.Dispose()
            End Using
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
