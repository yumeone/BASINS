Option Strict Off
Option Explicit On

Imports atcData
Imports atcUtility
Imports atcUCI
Imports MapWinUtility
Imports System.Xml

''' <summary>
''' 
''' </summary>
''' <remarks>
'''Copyright 2005-2008 AQUA TERRA Consultants - Royalty-free use permitted under open source license
''' </remarks>
Public Class atcTimeseriesFileHspfBinOut
    Inherits atcData.atcDataSource

    Private pFilter As String = "HSPF Binary Output Files (*.hbn)|*.hbn"
    Private pName As String = "Timeseries::HSPF Binary Output"
    Private pNvals As Integer

    Private pBinFile As clsHspfBinary

    Private pUnitsTable As atcTable
    Private pUnitsTableModified As Boolean = False
    Private Shared pUnitsTableTemplate As atcTable
    Private Shared pHspfMsg As atcUCI.HspfMsg
    Private pCountUnitsFound As Integer
    Private pCountUnitsMissing As Integer
    Private pCountUnitsHardCode As Integer
    Private pUnitsMissing As atcCollection

    Public ReadOnly Property AvailableAttributes() As Collection
        Get
            'needed to edit attributes? that can't be done for this type!
            Return New Collection 'empty!
        End Get
    End Property

    Public Overrides ReadOnly Property Category() As String
        Get
            Return "File"
        End Get
    End Property

    Public Overrides ReadOnly Property Description() As String
        Get
            Return "HSPF Binary Output"
        End Get
    End Property

    Public WriteOnly Property HelpFilename() As String
        Set(ByVal newValue As String)
            'TODO:how do we handle helpfiles?
            'App.HelpFile = newvalue
        End Set
    End Property

    Public ReadOnly Property Label() As String
        Get
            Return "HSPFBinary"
        End Get
    End Property

    Private Sub BuildTSers()
        pCountUnitsFound = 0
        pCountUnitsMissing = 0
        pCountUnitsHardCode = 0
        pUnitsMissing = New atcCollection

        pBinFile = New clsHspfBinary
        pBinFile.Filename = Specification

        Try
            Dim lHeaderIndex As Integer = 0
            Dim lSJDate As Double, lEJDate As Double, lOutLev As Integer
            For Each lBinHeader As clsHspfBinHeader In pBinFile.Headers
                With lBinHeader
                    Dim lData As clsHspfBinData = .Data.ItemByIndex(0)
                    lSJDate = Date2J(lData.DateArray)
                    lOutLev = lData.OutLev
                    Dim lDataIndex As Integer
                    If .Data.Count = 1 Then
                        lDataIndex = 1 'force daily
                    Else
                        lDataIndex = 1
                        While lOutLev <> .Data.ItemByIndex(lDataIndex).OutLev And lHeaderIndex < .Data.Count 'looking for same outlev
                            lDataIndex += 1
                        End While
                    End If
                    If lDataIndex < .Data.Count Then
                        lData = .Data.ItemByIndex(lDataIndex)
                        lEJDate = Date2J(lData.DateArray)
                    Else 'only one value dont know what interval is, assume day
                        lEJDate = lSJDate + 1
                    End If

                    'attributes related to dates common to all in ts in a header 
                    Dim lTu As Integer, lTs As Integer, lIntvl As Integer
                    Dim lBaseAttributes As atcDataAttributes = New atcDataAttributes
                    With lBaseAttributes
                        .SetValue("CIntvl", True)
                        .SetValue("History 1", "Read from " & pBinFile.Filename)
                        Dim lFileDetails As System.IO.FileInfo = New System.IO.FileInfo(pBinFile.Filename)
                        .SetValue("Date Created", lFileDetails.CreationTime)
                        .SetValue("Date Modified", lFileDetails.LastWriteTime)
                        If lEJDate - lSJDate >= 1 Then 'daily or longer interval
                            lTs = 1
                            lTu = lBinHeader.Data.ItemByIndex(0).OutLev + 1
                            lIntvl = 1
                            'If lTu = ATCTimeUnit.TUDay Then
                            'Else 'undefined for monthly or annual
                            'End If
                        Else 'use minute
                            lTu = atcTimeUnit.TUMinute
                            lTs = timdifJ(lSJDate, lEJDate, atcTimeUnit.TUMinute, 1)
                            lIntvl = lTs / 1440
                        End If
                        If lTs < 1 Then
                            Logger.Dbg("TimestepProblem:" & lSJDate & ":" & lEJDate & ":" & lTu & ":" & lTs & ":" & _
                                       lBinHeader.id.OperationName & ":" & _
                                       lBinHeader.id.OperationNumber & ":" & _
                                       lBinHeader.id.SectionName)
                            lTs = 1
                        End If
                        .SetValue("Ts", lTs)
                        .SetValue("Tu", lTu)
                        .SetValue("Intvl", lIntvl)
                        Dim lTDate() As Integer = lBinHeader.Data.ItemByIndex(0).DateArray
                        lSJDate = TimAddJ(Date2J(lTDate), lTu, lTs, -lIntvl)
                        .SetValue("SJDay", lSJDate)
                        lTDate = lBinHeader.Data.ItemByIndex(lBinHeader.Data.Count - 1).DateArray
                        lEJDate = Date2J(lTDate)
                        .SetValue("EJDay", lEJDate)
                        pNvals = timdifJ(lSJDate, lEJDate, lTu, lTs)
                    End With

                    For lDataIndex = 0 To .VarNames.Count - 1
                        Dim lTSer As atcTimeseries = New atcTimeseries(Me)
                        For Each lAttributeName As DictionaryEntry In lBaseAttributes.ValuesSortedByName
                            With lBaseAttributes
                                lTSer.Attributes.SetValue(atcDataAttributes.GetDefinition(lAttributeName.Key), lAttributeName.Value)
                            End With
                        Next
                        With lTSer
                            .Attributes.SetValue("Operation", lBinHeader.id.OperationName)
                            .Attributes.SetValue("Section", lBinHeader.id.SectionName)
                            .Attributes.SetValue("IDSCEN", FilenameOnly(Specification))
                            .Attributes.SetValue("IDLOCN", Left(lBinHeader.id.OperationName, 1) & ":" & (lBinHeader.id.OperationNumber))
                            Dim lConstituent As String = lBinHeader.VarNames.ItemByIndex(lDataIndex)
                            .Attributes.SetValue("IDCONS", lConstituent)
                            Dim lUnitSystem As atcUnitSystem = CType(CType(lBinHeader.Data(0), clsHspfBinData).UnitFlag, atcUnitSystem)
                            .Attributes.SetValue("UNITS", GetUnits(lConstituent, lUnitSystem))
                            .Attributes.SetValue("ID", Me.DataSets.Count)
                            If lBinHeader.VarNames.ItemByIndex(lDataIndex) = "LZS" Then 'TODO: need better check here
                                .Attributes.SetValue("Point", True)
                            End If
                            .ValuesNeedToBeRead = True
                            .Dates = New atcTimeseries(Me)
                            AddDataSet(lTSer)
                        End With
                    Next lDataIndex
                End With
                lHeaderIndex += 1
                'Logger.Dbg("Loop " & i)
                Logger.Progress(pBinFile.Headers.Count + lHeaderIndex, pBinFile.Headers.Count * 2)
            Next
        Catch ex As ApplicationException
            Logger.Dbg(ex.Message)
        End Try

        If pUnitsTableModified Then
            With pUnitsTable
                Logger.Dbg("SaveLocalUnitsTable:" & .FileName)
                .WriteFile(.FileName)
            End With
        End If
        Logger.Dbg("UnitsAssigned " & pCountUnitsFound & " " & pCountUnitsHardCode)
        Logger.Dbg("MissingUnique " & pUnitsMissing.Count & " Total " & pCountUnitsMissing)
        For lIndex As Integer = 0 To pUnitsMissing.Count - 1
            Logger.Dbg("Missing " & pUnitsMissing.Keys(lIndex) & " " & pUnitsMissing.Item(lIndex))
        Next
    End Sub

    Private Function GetUnits(ByVal aConstituent As String, Optional ByVal aUnitSystem As atcUnitSystem = atcUnitSystem.atcEnglish) As String
        Dim lUnits As String = ""
        Dim lUnknown As String = "<unknown>"
        Dim lUnknownFlag As Boolean = False

        If pUnitsTable.FindFirst(1, aConstituent) Then 'cons in field 1
            lUnits = pUnitsTable.Value(2) 'units in field 2
            If lUnits = lUnknown Then
                lUnknownFlag = True
                lUnits = "" 'forces another look at generic tables
            Else 'found a good one
                pCountUnitsHardCode += 1
            End If
        End If

        If lUnits.Length = 0 Then 'try generic unit table stored with dll - file may be customized for a specific installation
            If pUnitsTableTemplate Is Nothing Then 'open the generic table
                pUnitsTableTemplate = New atcTableDBF
                Dim lUnitsTemplateFileName As String = IO.Path.ChangeExtension(Reflection.Assembly.GetExecutingAssembly.Location, "units.dbf")
                If FileExists(lUnitsTemplateFileName) Then
                    pUnitsTableTemplate.OpenFile(lUnitsTemplateFileName)
                    Logger.Dbg("UsingGenericUnitsTemplateFile:" & lUnitsTemplateFileName)
                Else
                    Logger.Dbg("GenericUnitsTemplateFile:" & lUnitsTemplateFileName & ":NotAvailable!")
                End If
            End If
            If pUnitsTableTemplate.FindFirst(1, aConstituent) Then 'cons in field 1
                lUnits = pUnitsTableTemplate.Value(2) 'units in field 2
                pCountUnitsFound += 1
            Else  'try HspfMsg
                If pHspfMsg Is Nothing Then 'might need the message file for units
                    pHspfMsg = New HspfMsg
                    pHspfMsg.Open("hspfmsg.mdb")
                End If
                For lTsGroupIndex As Integer = 0 To pHspfMsg.TSGroupDefs.Count - 1
                    Dim lTsGroup As atcUCI.HspfTSGroupDef = pHspfMsg.TSGroupDefs(lTsGroupIndex)
                    For lTsMemberIndex As Integer = 0 To lTsGroup.MemberDefs.Count - 1
                        Dim lTsMember As atcUCI.HspfTSMemberDef = lTsGroup.MemberDefs(lTsMemberIndex)
                        If lTsMember.Name.ToLower = aConstituent.ToLower Then
                            'todo: check english/metric flag, english assumed for now
                            pCountUnitsFound += 1
                            lUnits = lTsMember.EUnits
                            'Logger.Dbg("FoundMsg " & aConstituent & " (" & lUnits & ")")
                            Exit For
                        End If
                    Next
                Next
                If lUnits.Length = 0 Then
                    pCountUnitsMissing += 1
                    'Logger.Dbg("Missing " & aConstituent)
                    Dim lIndex As Integer = pUnitsMissing.IndexFromKey(aConstituent)
                    If lIndex >= 0 Then
                        pUnitsMissing.Item(lIndex) += 1
                    Else
                        pUnitsMissing.Add(aConstituent, 1)
                    End If
                    lUnits = lUnknown
                End If
            End If
            If Not lUnknownFlag Then 'save a local copy
                With pUnitsTable
                    .NumRecords += 1
                    .MoveLast()
                    .Value(1) = aConstituent
                    .Value(2) = lUnits
                    pUnitsTableModified = True
                End With
            End If
        End If
        Return lUnits
    End Function

    Public Overrides Sub readData(ByVal aDataSet As atcDataSet)
        Dim v() As Double
        Dim d() As Double
        ReDim v(0)
        ReDim d(0)

        Dim lTimeseries As atcTimeseries = aDataSet
        Dim lKey As String = lTimeseries.Attributes.GetValue("Operation") & ":" & _
                             Mid(lTimeseries.Attributes.GetValue("IDLOCN"), 3) & ":" & _
                             lTimeseries.Attributes.GetValue("Section")

        Try
            Dim lBinHeader As clsHspfBinHeader = pBinFile.Headers.ItemByKey(lKey)
            With lBinHeader
                Dim lVind As Integer = .VarNames.IndexFromKey(lTimeseries.Attributes.GetValue("IDCONS"))
                If lVind >= 0 Then
                    ReDim v(pNvals)
                    ReDim d(pNvals)
                    Dim lSJday As Integer = lTimeseries.Attributes.GetValue("SJDay")
                    Dim lEJday As Integer = lTimeseries.Attributes.GetValue("EJDay")
                    Dim lOutLev As Integer = .Data.ItemByIndex(0).OutLev
                    d(0) = lSJday
                    Dim j As Integer = 1
                    For i As Integer = 0 To .Data.Count - 1
                        Dim lBinData As clsHspfBinData = .Data.ItemByIndex(i)
                        Dim lCurJday As Double = Date2J(lBinData.DateArray)
                        If lCurJday >= lSJday Then
                            If lCurJday > lEJday Then Exit For
                            If .Data.ItemByIndex(i).OutLev = lOutLev Then
                                v(j) = .Data.ItemByIndex(i).value(lVind)
                                d(j) = lCurJday
                                j += 1
                            End If
                        End If
                    Next i
                    If (lTimeseries.Attributes.GetValue("Point", False)) Then
                        v(0) = Double.NaN
                    Else
                        v(0) = v(1)
                    End If
                Else
                    Logger.Dbg("Could not retrieve HSPF Binary data values for variable: " & lTimeseries.Attributes.GetValue("IDCONS"))
                End If
            End With
        Catch ex As Exception
            Logger.Dbg("Could not retrieve data values for HSPF Binary TSER" & "Key = " & lKey & vbCrLf & _
                       "Message:" & ex.Message)
            ReDim v(0)
        End Try
        't.flags = f
        lTimeseries.Dates.Values = d
        lTimeseries.Values = v
        't.calcSummary()
        ' next might be automatic
        ReDim v(0)
        lTimeseries.ValuesNeedToBeRead = False
    End Sub

    Public Sub Refresh()
        pBinFile.ReadNewRecords()
    End Sub

    Public Function RemoveTimSer(ByVal aTimeseries As atcTimeseries) As Boolean
        Logger.Dbg("Unable to Remove Time Series " & aTimeseries.ToString & vbCrLf & _
                   "From:" & Specification)
        Return False
    End Function

    Public Function RewriteTimSer(ByVal aTimeseries As atcTimeseries) As Boolean
        Logger.Dbg("Unable to Rewrite Time Series " & aTimeseries.ToString & vbCrLf & _
                   "From:" & Specification)
        Return False
    End Function

    Public Function SaveAs(ByVal aFilename As String) As Boolean
        Logger.Dbg("Unable to SaveAs " & aFilename & vbCrLf & _
                   "From:" & Specification)
        Return False
    End Function

    Public Overrides ReadOnly Property Name() As String
        Get
            Return pName
        End Get
    End Property

    Public Overrides ReadOnly Property CanOpen() As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides ReadOnly Property CanSave() As Boolean
        Get
            Return False 'TODO: change this when we can
        End Get
    End Property

    Public Overrides Function Open(ByVal aFileName As String, Optional ByVal aAttributes As atcDataAttributes = Nothing) As Boolean
        If MyBase.Open(aFileName, aAttributes) Then
            pUnitsTable = New atcTableDBF
            Dim lFileName As String = IO.Path.ChangeExtension(Me.Specification, "units.dbf")
            If FileExists(lFileName) Then
                pUnitsTable.OpenFile(lFileName)
            Else 'create from template
                With pUnitsTable
                    .NumFields = 2
                    .FieldName(1) = "CONS"
                    .FieldType(1) = "C"
                    .FieldLength(1) = 32
                    .FieldName(2) = "UNITS"
                    .FieldType(2) = "C"
                    .FieldLength(2) = 16
                    .FileName = lFileName
                    .WriteFile(.FileName)
                End With
            End If
            BuildTSers()
            Return True
        End If
        Return False
    End Function

    Public Sub New()
        Filter = pFilter
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class