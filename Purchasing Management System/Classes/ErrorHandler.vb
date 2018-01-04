Imports System.IO
Public Class ErrorHandler
    Private dt As Date
    Private num As Integer
    Private des As String
    Private msg As String
    Private filloc As String

    Public Sub New()
        filloc = Application.StartupPath & "\Resources\Error" & DateTime.Now.ToString("MMddyyyy_hhmmttss") & ".txt"
        Dim fs As FileStream = Nothing
        fs = File.Create(filloc)
        fs.Close()
    End Sub

    Public Property Timestamp As Date
        Get
            Return dt
        End Get
        Set(value As Date)
            dt = value
        End Set
    End Property

    Public Property ErrorNumber As Integer
        Get
            Return num
        End Get
        Set(value As Integer)
            num = value
        End Set
    End Property

    Public Property ErrorDescription As String
        Get
            Return des
        End Get
        Set(value As String)
            des = value
        End Set
    End Property

    Public Property ExceptionMessage As String
        Get
            Return msg
        End Get
        Set(value As String)
            msg = value
        End Set
    End Property

    Public Sub LogError()
        Using objWriter As New System.IO.StreamWriter(filloc)
            With objWriter
                .WriteLine()
                .WriteLine("Date & Time: " & Timestamp)
                .WriteLine()
                .WriteLine("Error Number: " & ErrorNumber)
                .WriteLine()
                .WriteLine()
                .WriteLine("Error Message: " & ErrorDescription)
                .WriteLine()
                .WriteLine()
                .WriteLine("Exeption Details: " & ExceptionMessage)
            End With
        End Using
    End Sub
End Class
