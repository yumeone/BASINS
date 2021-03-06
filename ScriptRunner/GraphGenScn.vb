﻿Imports atcUtility
Imports atcData
Imports atcTimeseriesFEQ
Imports atcWDM
Imports atcGraph
Imports MapWindow.Interfaces
Imports ZedGraph
Imports MapWinUtility
Imports System

Module GraphGenScn
    Private pbasename As String
    Private Const pWorkingDirectory As String = "G:\"
    Private Const pTimeseries1Axis As String = "Aux"
    Private Const pTimeseries1IsPoint As Boolean = False
    Private Const pTimeseries2Axis As String = "Aux"
    Private Const pTimeseries2IsPoint As Boolean = False
    Private Const pTimeseries3Axis As String = "Left"
    Private Const pTimeseries3IsPoint As Boolean = False
    Private Const pTimeseries4Axis As String = "Left"
    Private Const pTimeseries4IsPoint As Boolean = True
    Private Const pTimeseries5Axis As String = "Left"
    Private Const pTimeseries5IsPoint As Boolean = True
    Private Const pTimeseries6Axis As String = "Left"
    Private Const pTimeseries6IsPoint As Boolean = True
    Private Const pTimeseries7Axis As String = "Right"
    Private Const pTimeseries7IsPoint As Boolean = False

    Private pTimeseriesConstituent, pLeftYAxisLabel, pLeftAuxAxisLabel, foldername As String
    'New things
    Private pWDMFileName As String = ""
    Private pSTAFileName As String = ""
    Private pFEODataFileNames As List(Of String) = Nothing
    Private pFEODataFiles As Dictionary(Of String, atcTimeseriesFEQ.atcTimeseriesFEQ) = Nothing
    Private pTSGroup As atcTimeseriesGroup = Nothing
    Private pGraphSpec As clsGenScnGraphSpec = Nothing
    Private pTSBlockFileName As String = "" 'this is assumed to be the original GenScn .tsb files (csv)
    Private pTSBlockTab As atcTableDelimited = Nothing
    Private pSJDay As Double = 0.0
    Private pEJDay As Double = 0.0
    Private pSJDayCommon As Double = 0.0
    Private pEJDayCommon As Double = 0.0
    Private pGraphTitle As String = ""
    Private pApplyGraphSpec As Boolean
    Private pGraphWidth As Integer
    Private pGraphHeight As Integer

    Private Sub Initialize()
        'Set control file
        pSTAFileName = "G:\Admin\USGS_DO15_FEQ\AUTOPLOT\forecast\forecast.sta"
        Dim lStartPath As String = IO.Path.GetDirectoryName(pSTAFileName)
        Dim lSTAFileH As New IO.StreamReader(pSTAFileName)
        Dim lOneLine As String = ""
        Dim lKey As String = ""
        Dim lValue As String = ""
        While Not lSTAFileH.EndOfStream
            lOneLine = lSTAFileH.ReadLine()
            If lOneLine.StartsWith("#") Then Continue While
            lKey = StrRetRem(lOneLine)
            If lKey = "WDM" Then
                lKey = StrRetRem(lOneLine)
            End If
            lValue = lOneLine.Trim()
            Select Case lKey
                Case "WDM1"
                    pWDMFileName = AbsolutePath(lValue, lStartPath)
                    If pTSGroup Is Nothing Then
                        pTSGroup = New atcTimeseriesGroup()
                    End If
                    'could check if these files exists and quit preemptively here
                Case "FEO"
                    If pFEODataFileNames Is Nothing Then
                        pFEODataFileNames = New Generic.List(Of String)
                    End If
                    If pFEODataFiles Is Nothing Then
                        pFEODataFiles = New Dictionary(Of String, atcTimeseriesFEQ.atcTimeseriesFEQ)
                    End If
                    Dim lFEOFileName As String = AbsolutePath(lValue, lStartPath)
                    pFEODataFileNames.Add(lFEOFileName)
                    'could check if these files exists and quit preemptively here
                    If pTSGroup Is Nothing Then
                        pTSGroup = New atcTimeseriesGroup()
                    End If
                Case "TSB"
                    If lValue.Trim() <> "" Then
                        pTSBlockFileName = AbsolutePath(lValue, lStartPath)
                    End If
                Case "GRF"
                    If lValue.Trim() <> "" Then
                        lValue = StrRetRem(lOneLine)
                        If pGraphSpec Is Nothing Then
                            pGraphSpec = New clsGenScnGraphSpec()
                            pGraphSpec.Specification = AbsolutePath(lValue, lStartPath)
                            pGraphSpec.RetrieveSpecs()
                        End If
                        If lOneLine.Trim = "0" Then
                            pApplyGraphSpec = False
                        ElseIf lOneLine.Trim = "1" Then
                            pApplyGraphSpec = True
                        Else
                            pApplyGraphSpec = True 'default is to apply specs
                        End If
                    End If
                Case "GRAPHWIDTH"
                    If Not Integer.TryParse(lValue.Trim, pGraphWidth) Then
                        pGraphWidth = 0
                    End If
                Case "GRAPHHEIGHT"
                    If Not Integer.TryParse(lValue.Trim, pGraphHeight) Then
                        pGraphHeight = 0
                    End If
                Case "SDATETIME", "EDATETIME"
                    Dim lDate(5) As Integer
                    Dim lStrDate As String = StrRetRem(lOneLine).Trim
                    Dim lStrTime As String = lOneLine.Trim
                    Dim lValueInt As Integer
                    Try
                        Dim lArray() As String = lStrDate.Split("/")
                        For I As Integer = 0 To 2
                            lValueInt = Integer.Parse(lArray(I))
                            lDate(I) = lValueInt
                        Next
                        ReDim lArray(0)
                        lArray = lStrTime.Split(":")
                        For I As Integer = 0 To 2
                            lValueInt = Integer.Parse(lArray(I))
                            lDate(I + 3) = lValueInt
                        Next
                        If lKey = "SDATETIME" Then
                            pSJDay = Date2J(lDate)
                        Else
                            pEJDay = Date2J(lDate)
                        End If
                    Catch ex As Exception
                        If lKey = "SDATETIME" Then
                            pSJDay = 0.0
                        Else
                            pEJDay = 0.0
                        End If
                    End Try
            End Select
        End While

        If pGraphSpec Is Nothing Then
            pGraphSpec = New clsGenScnGraphSpec()
            pGraphSpec.Specification = ""
        End If

        'pWDMFileName = "G:\Admin\USGS_DO15_FEQ\WBforecast\wbdr.wdm"
        ''pTSGroup = New atcTimeseriesGroup()
        'pTSBlockFileName = "G:\Admin\USGS_DO15_FEQ\WBforecast\feo\gagefeo\tsb\U77.tsb"
        'pGraphSpec = New clsGenScnGraphSpec()
        ''pGraphSpec.pSpecification = "G:\Admin\USGS_DO15_FEQ\WBforecast\feo\gagefeo\specs\U77_obs_sim_prec.grf"
        'pGraphSpec.pSpecification = ""
        'pGraphSpec.RetrieveSpecs()
        'pSJDay = 0.0
        'pEJDay = 0.0
    End Sub

    Public Sub ScriptMain(ByRef aMapWin As IMapWin)
        Initialize()

        If pTSGroup Is Nothing Then
            Logger.Msg("No source data. Stop graphing.")
            Clear()
            Exit Sub
        End If

        If Not pTSBlockFileName = "" Then
            If IO.File.Exists(pTSBlockFileName) Then
                pTSBlockTab = New atcTableDelimited()
                With pTSBlockTab
                    .Delimiter = ","
                    .NumFields = 3
                    .FieldName(1) = "Scenario"
                    .FieldName(2) = "Location"
                    .FieldName(3) = "Constituent"
                End With
                If pTSBlockTab.OpenString("Scenario,Location,Constituent" & vbCrLf & IO.File.ReadAllText(pTSBlockFileName)) Then
                    pTSBlockTab.MoveFirst()
                Else
                    pTSBlockTab = Nothing
                End If
            End If
        Else 'If there is no TS specified, then...
            Logger.Msg("No datasets are specified. Stop graphing.")
            Clear()
            Exit Sub
        End If

        'Get Datasets
        'Open WDM first (assuming there is only one WDM)
        Dim lWDM As New atcWDM.atcDataSourceWDM()
        If Not lWDM.Open(pWDMFileName) Then
            Logger.Msg("Open WDM file, " & pWDMFileName, " failed. Stop graphing.")
            Clear()
            Exit Sub
        End If
        With pTSBlockTab
            Dim lScenario As String = ""
            Dim lLocation As String = ""
            Dim lConstituent As String = ""
            Dim lDataFound As Boolean
            While Not .EOF
                lDataFound = False
                'Search for FEOs first
                For Each lFEOFileName As String In pFEODataFileNames
                    If Not lDataFound Then
                        Dim lNewFEODataSource As atcTimeseriesFEQ.atcTimeseriesFEQ
                        If Not pFEODataFiles.ContainsKey(lFEOFileName) Then
                            lNewFEODataSource = New atcTimeseriesFEQ.atcTimeseriesFEQ
                            If lNewFEODataSource.Open(lFEOFileName) Then
                                Logger.Dbg("Found " & lNewFEODataSource.DataSets.Count & " datasets.")
                                pFEODataFiles.Add(lFEOFileName, lNewFEODataSource)
                            End If
                        Else
                            lNewFEODataSource = pFEODataFiles.Item(lFEOFileName)
                        End If
                        For Each lTs As atcTimeseries In lNewFEODataSource.DataSets
                            lScenario = lTs.Attributes.GetValue("Scenario").ToString.ToLower
                            lLocation = lTs.Attributes.GetValue("Location").ToString.ToLower
                            lConstituent = lTs.Attributes.GetValue("Constituent").ToString.ToLower
                            If .Value(1).Trim("""").ToLower = lScenario And .Value(2).Trim("""").ToLower = lLocation And .Value(3).Trim("""").ToLower = lConstituent Then
                                pTSGroup.Add(lTs)
                                lDataFound = True
                                Exit For
                            End If
                        Next
                    Else
                        Exit For
                    End If
                Next 'FEO file

                'Search WDM next
                If Not lDataFound Then
                    For Each lTS As atcTimeseries In lWDM.DataSets
                        lScenario = lTS.Attributes.GetValue("Scenario").ToString.ToLower
                        lLocation = lTS.Attributes.GetValue("Location").ToString.ToLower
                        lConstituent = lTS.Attributes.GetValue("Constituent").ToString.ToLower
                        If .Value(1).Trim("""").ToLower = lScenario And .Value(2).Trim("""").ToLower = lLocation And .Value(3).Trim("""").ToLower = lConstituent Then
                            pTSGroup.Add(lTS)
                            lDataFound = True
                            Exit For
                        End If
                    Next
                End If

                If Not lDataFound Then
                    Logger.Msg("No data found for " & lScenario & "-" & lLocation & "-" & lConstituent & ", Stop graphing.")
                    lWDM.Clear()
                    lWDM = Nothing
                    Clear()
                    Exit Sub
                End If

                .MoveNext()
            End While
        End With

        If pTSGroup Is Nothing OrElse pTSGroup.Count = 0 Then
            Logger.Msg("No data found. Stop graphing.")
            Clear()
            Exit Sub
        Else 'Get the desired duration
            Dim lStart As Double
            Dim lEnd As Double
            If pSJDay = 0 OrElse pEJDay = 0 Then
                CommonDates(pTSGroup, pSJDay, pEJDay, pSJDayCommon, pEJDayCommon)
                lStart = pSJDayCommon
                lEnd = pEJDayCommon
            Else
                lStart = pSJDay
                lEnd = pEJDay
            End If
            Dim lTSGroup As New atcTimeseriesGroup
            For Each lTS As atcTimeseries In pTSGroup
                lTSGroup.Add(SubsetByDate(lTS, lStart, lEnd, Nothing))
            Next
            pTSGroup.Clear()
            pTSGroup = lTSGroup
        End If

        Dim lCrvIndex As Integer
        For I As Integer = 0 To pTSGroup.Count - 1
            Dim lCons As String = pTSGroup(I).Attributes.GetValue("Constituent")
            lCrvIndex = pGraphSpec.CurveIndex(lCons, I)
            Dim lTimeseriesAxis As String = pTimeseries3Axis
            '1-leftY,2-rightY,3-Aux,4-X
            Select Case pGraphSpec.Crv(lCrvIndex).CType_Renamed
                Case 1
                    lTimeseriesAxis = pTimeseries3Axis
                Case 2
                    lTimeseriesAxis = pTimeseries7Axis
                Case 3
                    lTimeseriesAxis = pTimeseries1Axis
                Case 4
                    lTimeseriesAxis = "X"
            End Select

            With pTSGroup(I)
                If lCons = "PREC" Then
                    .Attributes.SetValue("YAxis", pTimeseries1Axis)
                    .Attributes.SetValue("Point", pTimeseries1IsPoint)
                    'pLeftAuxAxisLabel = "PREC (in)"
                    pLeftAuxAxisLabel = "PREC"
                    'ElseIf lCons = "WSELEV" Then
                    '    .Attributes.SetValue("YAxis", pTimeseries3Axis)
                    '    .Attributes.SetValue("Point", pTimeseries3IsPoint)
                    '    pLeftYAxisLabel &= "WSELEV (ft)" & " "
                    'ElseIf lCons = "ELEV" Then
                    '    .Attributes.SetValue("YAxis", pTimeseries3Axis)
                    '    .Attributes.SetValue("Point", pTimeseries3IsPoint)
                    '    pLeftYAxisLabel &= "ELEV (ft)" & " "
                Else
                    .Attributes.SetValue("YAxis", lTimeseriesAxis)
                    .Attributes.SetValue("Point", pTimeseries3IsPoint)
                End If
            End With
        Next
        'Dim lAxisIndexWithYLab As Integer = 1
        'For I As Integer = 1 To 4
        '    If pGraphSpec.Axis(I).label IsNot Nothing Then
        '        Select Case I
        '            Case 1
        '                lAxisIndexWithYLab = 1
        '            Case 2
        '                lAxisIndexWithYLab = 2
        '            Case 3
        '                lAxisIndexWithYLab = 3
        '            Case 4
        '        End Select
        '    End If
        'Next
        'pLeftYAxisLabel = pGraphSpec.Axis(lAxisIndexWithYLab).label

        If pGraphSpec.IsReady And pApplyGraphSpec Then
            pLeftAuxAxisLabel = pGraphSpec.Axis(3).label
            pLeftYAxisLabel = pGraphSpec.Axis(1).label
        End If
        If pLeftYAxisLabel = "" Then
            pLeftYAxisLabel = pTSGroup(0).Attributes.GetValue("Constituent").ToString
        End If
        pGraphTitle = "Analysis Plot for Values"
        GraphTimeseriesBatch(pTSGroup)

        lWDM.Clear()
        lWDM = Nothing
        Clear()
    End Sub

    Private Sub Clear()
        pSJDay = 0 : pEJDay = 0 : pSJDayCommon = 0 : pEJDayCommon = 0
        pTimeseriesConstituent = "" : pLeftYAxisLabel = "" : pLeftAuxAxisLabel = "" : foldername = ""
        pGraphTitle = "" : pTSBlockFileName = ""
        If pTSGroup IsNot Nothing Then
            pTSGroup.Clear()
            pTSGroup = Nothing
        End If
        If pGraphSpec IsNot Nothing Then
            pGraphSpec.Clear()
            pGraphSpec = Nothing
        End If
        If pFEODataFileNames IsNot Nothing Then pFEODataFileNames.Clear()
        If pTSBlockTab IsNot Nothing Then
            pTSBlockTab.Clear()
            pTSBlockTab = Nothing
        End If
        If pFEODataFiles IsNot Nothing Then
            For Each lKey As String In pFEODataFiles.Keys
                If pFEODataFiles.Item(lKey) IsNot Nothing Then
                    pFEODataFiles.Item(lKey).Clear()
                End If
            Next
            pFEODataFiles.Clear()
            pFEODataFiles = Nothing
        End If
    End Sub

    Sub GraphTimeseriesBatch(ByVal aDataGroup As atcTimeseriesGroup)

        'TODO: Special case, remove later
        'Reverse order to match graph spec
        'Dim lDG As New atcTimeseriesGroup
        'For I As Integer = aDataGroup.Count - 1 To 0
        '    lDG.Add(aDataGroup(I))
        'Next
        'aDataGroup = lDG

        foldername = IO.Path.GetDirectoryName(pSTAFileName)
        pbasename = IO.Path.GetFileNameWithoutExtension(pSTAFileName)
        Dim lOutFileName As String = foldername & "\" & pbasename
        'Dim lZgc As ZedGraphControl = CreateZgc(, 1024, 768)
        Dim lZgc As ZedGraphControl = Nothing
        If pGraphHeight = 0 OrElse pGraphWidth = 0 Then
            lZgc = CreateZgc(, 640, 480)
        Else
            lZgc = CreateZgc(, pGraphWidth, pGraphHeight)
        End If

        Dim lGrapher As New clsGraphTime(aDataGroup, lZgc)
        Dim lPaneAux As GraphPane = Nothing
        Dim lPaneMain As GraphPane = Nothing
        If lZgc.MasterPane.PaneList.Count < 2 Then
            lPaneMain = lZgc.MasterPane.PaneList(0)
        Else
            lPaneAux = lZgc.MasterPane.PaneList(0)
            lPaneMain = lZgc.MasterPane.PaneList(1)
        End If

        Dim lCurve As ZedGraph.LineItem = Nothing
        Dim lCrvIndex As Integer = 0
        If lPaneAux IsNot Nothing Then
            'Assuming only PREC is on the top Auxiliary pane
            lCurve = lPaneAux.CurveList.Item(0)
            With lCurve
                .Line.StepType = StepType.NonStep
                If pGraphSpec.IsReady And pApplyGraphSpec Then
                    lCrvIndex = pGraphSpec.CurveIndex("PREC", aDataGroup.Count - 1)
                    .Color = ToNewColor(pGraphSpec.Crv(lCrvIndex).Color)
                    .Line.Width = pGraphSpec.Crv(lCrvIndex).LThck
                    .Label.Text = pGraphSpec.Crv(lCrvIndex).LegLbl
                Else
                    .Line.Width = 2
                    .Color = Drawing.Color.Red
                End If
            End With
        End If

        'If Not lCurve.Label.Text.Contains(" at ") Then
        '    lCurve.Label.Text &= " at " & aDataGroup(0).Attributes.GetValue("Location")
        'End If
        'If lPaneAux.CurveList.Count > 1 Then
        '    lCurve = lPaneAux.CurveList.Item(1)
        '    lCurve.Line.StepType = StepType.NonStep
        '    lCurve.Line.Width = 2
        '    lCurve.Color = Drawing.Color.Red
        '    lPaneAux.CurveList.Item(0).Color = Drawing.Color.Blue
        '    If Not lCurve.Label.Text.Contains(" at ") Then
        '        lCurve.Label.Text &= " at " & aDataGroup(0).Attributes.GetValue("Location")
        '    End If
        'End If

        Dim lCurveOnMainPane As ZedGraph.LineItem = Nothing
        Dim lLastIndexOfCurvesOnMain As Integer
        If lPaneAux Is Nothing Then
            lLastIndexOfCurvesOnMain = lPaneMain.CurveList.Count - 1
        Else
            lLastIndexOfCurvesOnMain = lPaneMain.CurveList.Count - 2
        End If
        For i As Integer = 0 To lLastIndexOfCurvesOnMain
            lCurveOnMainPane = lPaneMain.CurveList.Item(i)
            If pGraphSpec.IsReady And pApplyGraphSpec Then
                lCrvIndex = pGraphSpec.CurveIndex("BluhBluh", i)
                lCurveOnMainPane.Label.Text = pGraphSpec.Crv(lCrvIndex).LegLbl
                'If pGraphSpec.Crv(i).LType >= 0 Then
                '    lObserved.Symbol.Type = pGraphSpec.Crv(i).LType Mod 5
                'Else
                '    lObserved.Symbol.Type = SymbolType.Circle
                'End If
                lCurveOnMainPane.Color = ToNewColor(pGraphSpec.Crv(lCrvIndex).Color)
                lCurveOnMainPane.Line.StepType = StepType.NonStep
                lCurveOnMainPane.Line.Width = pGraphSpec.Crv(lCrvIndex).LThck
                'lPaneMain.Y2Axis.Title.Text = pGraphSpec.Axis(2).label
            Else 'No graph specs loaded
                If Not lCurveOnMainPane.Label.Text.Contains(" at ") Then
                    lCurveOnMainPane.Label.Text &= " at " & aDataGroup(i).Attributes.GetValue("Location")
                End If
                Dim constituent As String = aDataGroup(i).Attributes.GetValue("Constituent")
                lCurveOnMainPane.Line.StepType = StepType.NonStep
                lCurveOnMainPane.Line.Width = 2
                Dim lRand As New Random
                lCurveOnMainPane.Color = Drawing.Color.FromArgb(255, lRand.Next(0, 255), lRand.Next(0, 255), lRand.Next(0, 255))
            End If
        Next

        'lCurve = lPaneMain.CurveList.Item(lPaneMain.CurveList.Count - 2)
        'lCurve.Line.StepType = StepType.NonStep
        'lCurve.Line.Width = 2
        'lCurve.Color = Drawing.Color.Green
        'If Not lCurve.Label.Text.Contains(" at ") Then
        '    lCurve.Label.Text &= " at " & aDataGroup(0).Attributes.GetValue("Location")
        'End If

        'lCurve = lPaneMain.CurveList.Item(lPaneMain.CurveList.Count - 1)
        'lCurve.Line.StepType = StepType.NonStep
        'If pGraphSpec.IsReady And pApplyGraphSpec Then
        '    lCurve.Line.Width = pGraphSpec.Crv(lPaneMain.CurveList.Count - 1).LThck
        '    lCurve.Color = ToNewColor(pGraphSpec.Crv(lPaneMain.CurveList.Count - 1).Color)
        '    lCurve.Label.Text = pGraphSpec.Crv(lPaneMain.CurveList.Count - 1).LegLbl
        'Else
        '    lCurve.Line.Width = 2
        '    lCurve.Color = Drawing.Color.Blue
        '    If Not lCurve.Label.Text.Contains(" at ") Then
        '        lCurve.Label.Text &= " at " & aDataGroup(0).Attributes.GetValue("Location")
        '    End If
        'End If

        'FormatPanes(lZgc)
        'Apply labels etc
        If lPaneAux IsNot Nothing Then lPaneAux.YAxis.Title.Text = pLeftAuxAxisLabel
        lPaneMain.YAxis.Title.Text = pLeftYAxisLabel
        lPaneMain.XAxis.Title.Text &= vbCrLf & "Analysis Plot for Values"

        If pGraphSpec.IsReady And pApplyGraphSpec Then
            lPaneMain.XAxis.Title.Text = pGraphSpec.Title.Replace("&", vbCrLf)
            lPaneMain.XAxis.Title.FontSpec.Size = 12.0
            If Not pGraphSpec.XtraText.Trim() = "" Then
                Dim lExtraTextStr As String = pGraphSpec.XtraText.Replace("&", vbCrLf)
                Dim lExtraText As ZedGraph.TextObj = Nothing
                'lExtraText = New ZedGraph.TextObj(lExtraTextStr, pGraphSpec.XTxtLoc, 0.95, CoordType.ChartFraction, AlignH.Left, AlignV.Bottom)
                lExtraText = New ZedGraph.TextObj(lExtraTextStr, pGraphSpec.XTxtLoc, pGraphSpec.YTxtLoc, CoordType.ChartFraction, AlignH.Left, AlignV.Bottom)
                With lExtraText
                    .ZOrder = ZOrder.A_InFront
                    .FontSpec.StringAlignment = Drawing.StringAlignment.Near
                    .FontSpec.Size = 12.0
                    .FontSpec.Border.IsVisible = False
                    .FontSpec.Fill = New ZedGraph.Fill(Drawing.Color.FromArgb(0, 255, 255, 255))
                    .IsVisible = True
                End With
                lPaneMain.GraphObjList.Add(lExtraText)
            End If
        End If

        'Adjust legend position
        If pGraphSpec.IsReady And pApplyGraphSpec Then
            Dim lLocLeg As Location = New Location(pGraphSpec.XLegLoc, pGraphSpec.YLegLoc - 0.95, CoordType.ChartFraction)
            lPaneMain.Legend.Location = lLocLeg
        End If

        'Adjust scale
        Dim lYAxisCross As Double = 0.0
        Dim lShowGrid As Boolean = False
        If pGraphSpec.IsReady And pApplyGraphSpec Then
            '1-leftY,2-rightY,3-Aux,4-X
            If pGraphSpec.Axis(1).label IsNot Nothing Then
                With lPaneMain.YAxis.Scale
                    .MinAuto = False
                    .MaxAuto = False
                    .Min = pGraphSpec.Axis(1).minv
                    .Max = pGraphSpec.Axis(1).maxv
                    .MajorStep = (.Max - .Min) / pGraphSpec.Axis(1).NTic
                    lYAxisCross = .Min
                End With

                If pGraphSpec.Gridy = 1 Then
                    lShowGrid = True
                End If
                lPaneMain.YAxis.MajorGrid.IsVisible = lShowGrid
                lPaneMain.YAxis.MinorGrid.IsVisible = lShowGrid
                lPaneMain.YAxis.MinorTic.IsAllTics = lShowGrid
            End If
            lPaneMain.XAxis.CrossAuto = False
            lPaneMain.XAxis.Cross = lYAxisCross
            lPaneMain.YAxis.Scale.BaseTic = lYAxisCross
            lZgc.AxisChange()

            'If pGraphSpec.Axis(2).label IsNot Nothing Then
            '    With lPaneMain.Y2Axis.Scale
            '        .Min = pGraphSpec.Axis(2).minv
            '        .Max = pGraphSpec.Axis(2).maxv
            '        .MajorStep = (.Max - .Min) / pGraphSpec.Axis(2).NTic
            '    End With
            'End If
            If pGraphSpec.Axis(3).label IsNot Nothing Then
                With lPaneAux.YAxis.Scale
                    .MinAuto = False
                    .MaxAuto = False
                    .Min = pGraphSpec.Axis(3).minv
                    .Max = pGraphSpec.Axis(3).maxv
                    .MajorStep = (.Max - .Min) / pGraphSpec.Axis(3).NTic
                End With
            End If
            'If pGraphSpec.Axis(4).label IsNot Nothing Then
            '    With lPaneMain.XAxis.Scale
            '        .Min = pGraphSpec.Axis(4).minv
            '        .Max = pGraphSpec.Axis(4).maxv
            '        .MajorStep = (.Max - .Min) / pGraphSpec.Axis(4).NTic
            '    End With
            'End If

            lShowGrid = False
            If pGraphSpec.Gridx = 1 Then
                lShowGrid = True
            End If
            lPaneMain.XAxis.MajorGrid.IsVisible = lShowGrid
            lPaneMain.XAxis.MinorGrid.IsVisible = lShowGrid
        End If

        'Make sure both graphs line up horizontally
        Dim lMaxX As Single = 0
        Dim lMinRight As Single = 0
        If lPaneAux IsNot Nothing Then
            lPaneAux.AxisChange()
            lMaxX = Math.Max(lPaneAux.Chart.Rect.X, lPaneMain.Chart.Rect.X)
            lMinRight = Math.Min(lPaneAux.Chart.Rect.Right, lPaneMain.Chart.Rect.Right)
            lPaneAux.Chart.Rect = New Drawing.RectangleF(lMaxX, lPaneAux.Chart.Rect.Y, lMinRight - lMaxX, lPaneAux.Chart.Rect.Height)
        Else
            lMaxX = lPaneMain.Chart.Rect.X
            lMinRight = lPaneMain.Chart.Rect.Right
        End If
        If lPaneMain IsNot Nothing Then lPaneMain.AxisChange()
        lPaneMain.Chart.Rect = New Drawing.RectangleF(lMaxX, lPaneMain.Chart.Rect.Y, lMinRight - lMaxX, lPaneMain.Chart.Rect.Height)

        lZgc.AxisChange()
        lZgc.Invalidate()
        lZgc.Refresh()

        System.IO.Directory.CreateDirectory(foldername)
        lZgc.SaveIn(lOutFileName & ".png")
        lZgc.SaveIn(lOutFileName & ".emf")
        'With lPaneAux
        '    .YAxis.Type = ZedGraph.AxisType.Log
        '    ScaleAxis(aDataGroup, .YAxis)
        '    .YAxis.Scale.MaxAuto = False
        '    .YAxis.Scale.IsUseTenPower = False
        'End With
        'lOutFileName = lOutFileName & "_log "
        'lZgc.SaveIn(lOutFileName & ".png")
        'lZgc.SaveIn(lOutFileName & ".emf")
        lZgc.Dispose()
    End Sub

    Private Function ToNewColor(ByVal aOldColor As Integer) As Drawing.Color
        Return Drawing.Color.FromArgb(aOldColor And &HFF, (aOldColor And &HFF00) >> 8, (aOldColor And &HFF0000) >> 16)
    End Function
End Module
