﻿Public Class Package
    Inherits DatabaseItem
    Private pDate As Date
    Private cour As String
    Private pType As String
    Private recType As String
    Private ship As String
    Private recieve As String
    Private trknum As String
    Private pID As Integer

#Region "Database Functions"

    Public Sub SubmitTrackingEntry()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spInsertTracking")
            .AddParameter("varDate", PackageDate)
            .AddParameter("varCarrier", Courier)
            .AddParameter("varPType", PackageType)
            .AddParameter("varRType", RecipientType)
            .AddParameter("varRecipient", Recipient)
            .AddParameter("varShipper", Shipper)
            .AddParameter("varTrackingNumber", TrackingNumber)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Public Sub UpateTrackingEntry()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spUpdateTracking")
            .AddParameter("varDate", PackageDate)
            .AddParameter("varCarrier", Courier)
            .AddParameter("varPType", PackageType)
            .AddParameter("varRType", RecipientType)
            .AddParameter("varRecipient", Recipient)
            .AddParameter("varShipper", Shipper)
            .AddParameter("varTrackingNumber", TrackingNumber)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Public Sub DeleteTrackingEntry()
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("spDeleteTracking")
            .AddParameter("varTrackingNumber", TrackingNumber)
            .Execute(DatabaseAccess.ReturnType.ExecuteNonQuery)
        End With
    End Sub

    Public Sub GetPackageData()
        Dim com As New DatabaseAccess
        Dim str As String
        With com
            .InitiateADOProcedure("qryPackageLog")
            .AddParameter("varDate", PackageDate)
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Data = .ReturnResults()
        End With

        For Each row As DataRow In Data.Rows
            str = row.Item(5).ToString
            row.Item(5) = "'" & str & "'"
        Next

    End Sub

    Public Sub GenerateDailyPackageReport()
        Dim str As String
        Dim com As New DatabaseAccess
        With com
            .InitiateADOProcedure("qryPackageLogReportByDate")
            .AddParameter("varDate", PackageDate)
            .AddParameter("varCat", RecipientType)
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Data = .ReturnResults
            For Each row As DataRow In Data.Rows
                str = row.Item(3).ToString
                row.Item(3) = "'" & str & "'"
            Next
        End With
    End Sub

    Public Sub GenerateMonthlyPackageReport(pMonth As Integer, pYear As Integer)
        Dim report As New ReportsGenerator
        Dim com As New DatabaseAccess
        Dim str As String
        With com
            .InitiateADOProcedure("qryPackageReportByMonth")
            .AddParameter("vMonth", pMonth)
            .AddParameter("vYear", pYear)
            .Execute(DatabaseAccess.ReturnType.ExecuteReader)
            Data = .ReturnResults
        End With

        For Each row As DataRow In Data.Rows
            str = row.Item(6).ToString
            row.Item(6) = "'" & str & "'"
        Next

        With report
            .source = Me
            .GenerateReport(3, "Package Log Month: " & pMonth & ", Year: " & pYear)
        End With
    End Sub

#End Region

#Region "Getters/Setters"
    Public Property PackageDate As Date
        Get
            Return pDate
        End Get
        Set(value As Date)
            pDate = value
        End Set
    End Property

    Public Property Courier As String
        Get
            Return cour
        End Get
        Set(value As String)
            cour = value
        End Set
    End Property

    Public Property PackageType As String
        Get
            Return pType
        End Get
        Set(value As String)
            pType = value
        End Set
    End Property

    Public Property RecipientType As String
        Get
            Return recType
        End Get
        Set(value As String)
            recType = value
        End Set
    End Property

    Public Property Shipper As String
        Get
            Return ship
        End Get
        Set(value As String)
            ship = value
        End Set
    End Property

    Public Property Recipient As String
        Get
            Return recieve
        End Get
        Set(value As String)
            recieve = value
        End Set
    End Property

    Public Property TrackingNumber As String
        Get
            Return trknum
        End Get
        Set(value As String)
            trknum = value
        End Set
    End Property

    Public Property PackageID As Integer
        Get
            Return pID
        End Get
        Set(value As Integer)
            pID = value
        End Set
    End Property
#End Region
End Class
