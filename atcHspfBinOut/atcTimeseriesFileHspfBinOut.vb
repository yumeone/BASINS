Option Strict Off
Option Explicit On 

Imports atcData
Imports atcUtility

Public Class atcTimeseriesFileHspfBinOut
  Inherits atcDataSource
  '##MODULE_REMARKS Copyright 2005 AQUA TERRA Consultants - Royalty-free use permitted under open source license

  Private pFileFilter As String = "HSPF Binary Output Files (*.hbn)|*.hbn"
  Private pName As String = "HSPF Binary Output"
  Private pErrorDescription As String
  Private pMonitor As Object
  Private pMonitorSet As Boolean = False
  Private pDates As ArrayList 'of atcTimeseries

  Private pBinFile As clsHspfBinary
  Private pHSPFNetwork As clsNetworkHSPFOutput
  Private pFileExt As String

  'todo: where should this really be?
  Private Enum ATCTimeUnit
    TUSecond = 1
    TUMinute = 2
    TUHour = 3
    TUDay = 4
    TUMonth = 5
    TUYear = 6
    TUCentury = 7
  End Enum

  Public Sub New()
    MyBase.New()
  End Sub

  Public ReadOnly Property AvailableAttributes() As Collection
    Get
      Dim retval As Collection
      'Dim vAttribute As Variant
      'Dim lCurTSerAttr As ATCclsAttributeDefinition

      'needed to edit attributes? that can't be done for this type!
      'for now - just return nothing

      retval = New Collection
      'Set lCurTSerAttr = New ATCclsAttributeDefinition

      'If pHSPFOutput.DataCollection.Count > 0 Then
      '  For Each vAttribute In pHSPFOutput.DataCollection(1).Attribs
      '    lCurTSerAttr.Name = vAttribute.Name
      '    retval.Add lCurTSerAttr
      '  Next
      'End If
      Return retval
    End Get
  End Property

  Public Overrides ReadOnly Property Description() As String
    Get
      Return "HSPF Binary Time Series Data Type"
    End Get
  End Property

  Public ReadOnly Property ErrorDescription() As String
    Get
      ErrorDescription = pErrorDescription
      pErrorDescription = ""
    End Get
  End Property

  Public ReadOnly Property FileUnit() As Integer
    Get
      Return 0 'unknown here, known thru clsHspfBinary:clsFtnUnfFile
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

  Public WriteOnly Property Monitor() As Object
    Set(ByVal Value As Object)
      pMonitor = Value
      pMonitorSet = True
    End Set
  End Property

  Private Sub BuildTSers()
    Dim lTSer As atcTimeseries
    Dim lBaseAttributes As atcDataAttributes 'attributes related to dates common to all in ts in a header
    Dim lBaseTSer As atcTimeseries
    Dim lBinHeader As clsHspfBinHeader
    Dim lData As clsHspfBinData
    Dim lTu As Integer, lTs As Integer, lNvals As Integer
    Dim lSDate(5) As Integer, lEDate(5) As Integer, lTDate(5) As Integer
    Dim lSJDate As Double, lEJDate As Double, lOutLev As Integer
    Dim i As Integer, j As Integer, s As String

    If pMonitorSet Then
      pMonitor.SendMonitorMessage("(OPEN HSPF Binary Output File)")
      pMonitor.SendMonitorMessage("(BUTTOFF CANCEL)")
      pMonitor.SendMonitorMessage("(BUTTOFF PAUSE)")
      pMonitor.SendMonitorMessage("(MSG1 " & FileName & ")")
    End If

    pBinFile = New clsHspfBinary
    pBinFile.Monitor = pMonitor
    pBinFile.Filename = FileName

    i = 0
    For Each lBinHeader In pBinFile.Headers '.Values
      With lBinHeader
        lData = .Data.ItemByIndex(0)
        lSJDate = Date2J(lData.DateArray)
        lOutLev = lData.OutLev
        If .Data.Count = 1 Then
          j = 1 'force daily
        Else
          j = 1
          While lOutLev <> .Data.ItemByIndex(j).OutLev And i < .Data.Count 'looking for same outlev
            j = j + 1
          End While
        End If
        If j < .Data.Count Then
          lData = .Data.ItemByIndex(j)
          lEJDate = Date2J(lData.DateArray)
        Else 'only one value dont know what interval is, assume day
          lEJDate = lSJDate + 1
        End If
        'lDates = New ATCclsTserDate
        lBaseTSer = New atcTimeseries(Me)
        lBaseAttributes = New atcDataAttributes(lBaseTSer)
        With lBaseAttributes
          .SetValue("CIntvl", True)
          If lEJDate - lSJDate >= 1 Then 'daily or longer interval
            lTs = 1
            .SetValue("Ts", lTs)
            lTu = lBinHeader.Data.ItemByIndex(0).OutLev + 1
            .SetValue("Tu", lTu)

            If lTu = ATCTimeUnit.TUDay Then
              .SetValue("Intvl", 1)
            Else 'undefined for monthly or annual
            End If
          Else 'use minute
            .SetValue("Tu", ATCTimeUnit.TUMinute)
            lTs = timdifJ(lSJDate, lEJDate, ATCTimeUnit.TUMinute, 1)
            .SetValue("Ts", lTs)
            .SetValue("Intvl", lTs / 1440)
          End If
          's = CStr(lBinHeader.Data(1).datekey) 'need the value of the first key here
          'J2Date(Right(s, Len(s) - 2), lTDate)
          For j = 0 To 5
            lSDate(j) = lBinHeader.Data.ItemByIndex(0).DateArray(j)
          Next j
          ' !!!!!! maybe a better way to get the proper start date
          If lBinHeader.Data.ItemByIndex(0).OutLev > 2 Then
            lSDate(3) = lTDate(3)
            If lBinHeader.Data.ItemByIndex(0).OutLev > 3 Then
              lSDate(2) = lTDate(2)
              If lBinHeader.Data.ItemByIndex(0).OutLev > 4 Then
                lSDate(1) = lTDate(1)
                lSDate(0) = lTDate(0) - 1
              End If
            End If
          End If
          .SetValue("SJDay", Date2J(lSDate))
          For j = 0 To 4
            lEDate(j) = lBinHeader.Data.ItemByIndex(lBinHeader.Data.Count - 1).DateArray(j)
          Next j
          .SetValue("EJDay", Date2J(lEDate))
          timdif(lSDate, lEDate, lTu, lTs, lNvals)
          .SetValue("Nvals", lNvals)
        End With
        'lDates.Summary = lDateSumm
        For j = 0 To .VarNames.Count - 1
          lTSer = New atcTimeseries(Me)
          For Each lAttributeName As DictionaryEntry In lBaseAttributes.GetAll
            With lBaseAttributes
              lTSer.Attributes.SetValue(.GetDefinition(lAttributeName.Key), lAttributeName.Value)
            End With
          Next
          With lTSer
            .Attributes.SetValue("Operation", lBinHeader.id.OperationName)
            .Attributes.SetValue("Section", lBinHeader.id.SectionName)
            .Attributes.SetValue("IDSCEN", FilenameOnly(FileName))
            .Attributes.SetValue("IDLOCN", Left(lBinHeader.id.OperationName, 1) & ":" & (lBinHeader.id.OperationNumber))
            .Attributes.SetValue("IDCONS", lBinHeader.VarNames.ItemByIndex(j))
            .ValuesNeedToBeRead = True
            .Dates = New atcTimeseries(Me)
            AddTimeseries(lTSer)
          End With
        Next j
      End With
      If pMonitorSet Then
        s = "(PROGRESS " & CStr(50 + ((100 * i) / (pBinFile.Headers.Count * 2))) & ")"
        pMonitor.SendMonitorMessage(s)
      End If
      i = i + 1
    Next

    If pMonitorSet Then
      pMonitor.SendMonitorMessage("(CLOSE)")
      pMonitor.SendMonitorMessage("(BUTTON CANCEL)")
      pMonitor.SendMonitorMessage("(BUTTON PAUSE)")
    End If

  End Sub

  Public Overrides Sub readData(ByVal t As atcTimeseries)
    Dim lVind As Integer, lOutLev As Integer
    Dim lBinHeader As clsHspfBinHeader
    Dim lBd As clsHspfBinData
    Dim lKey As String
    Dim lCurJday As Double
    Dim lNvals As Integer
    Dim lSJday As Integer
    Dim lEJday As Integer
    Dim v() As Double, i As Integer, j As Integer, f() As Integer
    Dim d() As Double

    lKey = t.Attributes.GetValue("Operation") & ":" & _
           Mid(t.Attributes.GetValue("IDLOCN"), 3) & ":" & _
           t.Attributes.GetValue("Section")

    Try
      lBinHeader = pBinFile.Headers.ItemByKey(lKey)
      With lBinHeader
        'lVind = -1
        'i = 0
        'While lVind = -1 And i < .VarNames.Count
        'If .VarNames.ItemByIndex(i) = t.Attributes.GetValue("IDCONS") Then
        lVind = .VarNames.IndexFromKey(t.Attributes.GetValue("IDCONS"))
        'End I
        'i = i + 1
        'End While
        If lVind >= 0 Then
          lNvals = t.Attributes.GetValue("Nvals") + 1
          ReDim v(lNvals - 1)
          ReDim f(lNvals - 1)
          ReDim d(lNvals - 1)
          lSJday = t.Attributes.GetValue("SJDay")
          lEJday = t.Attributes.GetValue("EJDay")
          lOutLev = .Data.ItemByIndex(0).OutLev
          j = 0
          For i = 0 To .Data.Count - 1
            lBd = .Data.ItemByIndex(i)
            lCurJday = Date2J(lBd.DateArray)
            If lCurJday >= lSJday Then
              If lCurJday > lEJday Then Exit For
              If .Data.ItemByIndex(i).OutLev = lOutLev Then
                v(j) = .Data.ItemByIndex(i).value(lVind)
                d(j) = lCurJday
                j = j + 1
              End If
            End If
          Next i
        Else
          pErrorDescription = "Could not retrieve HSPF Binary data values for variable: " & t.Attributes.GetValue("IDCONS")
        End If
      End With
    Catch
      'Else
      pErrorDescription = "Could not retrieve data values for HSPF Binary TSER" & "Key = " & lKey
      ReDim v(0)
      ReDim f(0)
      'End If
    End Try
    't.flags = f
    t.Dates.Values = d
    t.Values = v
    't.calcSummary()
    ' next 2 might be automatic
    ReDim v(0)
    ReDim f(0)
    t.ValuesNeedToBeRead = False
  End Sub

  Public Sub Refresh()
    pBinFile.ReadNewRecords()
  End Sub

  Public Function RemoveTimSer(ByVal t As atcTimeseries) As Boolean
    pErrorDescription = "Unable to Remove a Time Series for " & Description
    Return False
  End Function

  Public Function RewriteTimSer(ByVal t As atcTimeseries) As Boolean
    pErrorDescription = "Unable to Rewrite a Time Series for " & Description
    Return False
  End Function

  Public Function SaveAs(ByVal Filename As String) As Boolean
    pErrorDescription = "Unable to SaveAS for " & Description
    Return False
  End Function

  Public Sub ShowFilterEdit(ByVal icon As Object) 'should this be a ATCclsTserFile property or function?
    '  pHSPFOutput.Filter.ShowFilterEdit icon
  End Sub

  Public Overrides ReadOnly Property FileFilter() As String
    Get
      Return pFileFilter
    End Get
  End Property

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

  Public Overrides Function Open(ByVal newFileName As String) As Boolean
    newFileName = AbsolutePath(newFileName, CurDir())
    FileName = newFileName
    BuildTSers()
    Return True
  End Function

End Class