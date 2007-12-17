Imports atcUtility
Imports atcData
Imports atcWDM
Imports HspfSupport
Imports MapWindow.Interfaces
Imports ZedGraph

Module Graph
    Private Const pTestPath As String = "C:\test\EXP_CAL\hyd_man.net"
    Private Const pBaseName As String = "hyd_man"

    Public Sub ScriptMain(ByRef aMapWin As IMapWin)
        ChDriveDir(pTestPath)
        'open uci file
        Dim lMsg As New atcUCI.HspfMsg
        lMsg.Open("hspfmsg.mdb")
        Dim lHspfUci As New atcUCI.HspfUci
        lHspfUci.FastReadUciForStarter(lMsg, pBaseName & ".uci")
        'open WDM file
        Dim lWdmFileName As String = pTestPath & "\" & pBaseName & ".wdm"
        Dim lWdmDataSource As New atcDataSourceWDM
        lWdmDataSource.Open(lWdmFileName)
        'open expert system
        Dim lExpertSystem As HspfSupport.ExpertSystem
        lExpertSystem = New HspfSupport.ExpertSystem(lHspfUci, lWdmDataSource)
        Dim lCons As String = "Flow"
        Dim lGraphForm As atcGraph.atcGraphForm
        ChDriveDir(CurDir() & "\outfiles")
        Dim lOutFileName As String

        For lSiteIndex As Integer = 1 To lExpertSystem.Sites.Count
            Dim lSite As String = lExpertSystem.Sites(lSiteIndex).Name
            Dim lArea As Double = lExpertSystem.Sites(lSiteIndex).Area
            Dim lDataGroup As New atcDataGroup
            Dim lSimTser As atcTimeseries = lWdmDataSource.DataSets.ItemByKey(lExpertSystem.Sites(lSiteIndex).Dsn(0))
            lSimTser = InchesToCfs(lSimTser, lArea)
            lSimTser.Attributes.SetValue("YAxis", "Left")
            lDataGroup.Add(SubsetByDate(lSimTser, _
                                        lExpertSystem.SDateJ, _
                                        lExpertSystem.EDateJ, Nothing))

            Dim lObsTser As atcTimeseries = lWdmDataSource.DataSets.ItemByKey(lExpertSystem.Sites(lSiteIndex).Dsn(1))
            lObsTser.Attributes.SetValue("YAxis", "Left")
            lDataGroup.Add(SubsetByDate(lObsTser, _
                                        lExpertSystem.SDateJ, _
                                        lExpertSystem.EDateJ, Nothing))
            Dim lYMax As Double = 2500 'todo: compute this

            Dim lACoef As Double
            Dim lBCoef As Double
            Dim lRSquare As Double
            lGraphForm = New atcGraph.atcGraphForm(lDataGroup, AxisType.Linear)
            With lGraphForm.Pane
                With .XAxis
                    'TODO: figures out how to make whole title go below XAxis title
                    .Title.Text = "Observed" & vbCrLf & vbCrLf & _
                                  "Scatter Plot" & vbCrLf & _
                                  "Flow at Upper Marlboro (cfs)"
                    .Scale.Min = 0
                    .Scale.Max = lYMax
                    .Scale.IsUseTenPower = False
                    .Scale.MaxAuto = False
                    .MajorGrid.IsVisible = True
                    .MinorGrid.IsVisible = True
                End With
                .YAxis.Scale.Max = .XAxis.Scale.Max
                .YAxis.Scale.Min = .XAxis.Scale.Min
                With .YAxis
                    .Title.Text = "Simulated"
                    .Scale.IsUseTenPower = False
                    .Scale.MaxAuto = False
                    .MajorGrid.IsVisible = True
                    .MinorGrid.IsVisible = True
                End With

                '45 degree line
                AddLine(lGraphForm.Pane, 1, 0, Drawing.Drawing2D.DashStyle.Dot)
                'regression line 
                FitLine(lDataGroup.ItemByIndex(0), lDataGroup.ItemByIndex(1), lACoef, lBCoef, lRSquare)
                AddLine(lGraphForm.Pane, lACoef, lBCoef)

                Dim lText As New TextObj
                Dim lFmt As String = "###,##0.###"
                lText.Text = "Y = " & DoubleToString(lACoef, , lFmt) & " X + " & DoubleToString(lBCoef, , lFmt) & vbLf & _
                             "R Squared = " & DoubleToString(lRSquare, , lFmt)
                'TODO: turn off border
                lText.Location = New Location(0.05, 0.05, CoordType.ChartFraction, AlignH.Left, AlignV.Top)
                .GraphObjList.Add(lText)
                .CurveList(0).Label.IsVisible = False
            End With
            lOutFileName = lCons & "_" & lSite & "_scat"
            lGraphForm.SaveBitmapToFile(lOutFileName & ".png")
            lGraphForm.ZedGraphCtrl.SaveIn(lOutFileName & ".emf")

            With lGraphForm.Pane
                .YAxis.Type = ZedGraph.AxisType.Log
                .YAxis.Scale.Min = 1
                .XAxis.Type = ZedGraph.AxisType.Log
                .XAxis.Scale.Min = 1
                .CurveList.RemoveAt(2)
                .CurveList.RemoveAt(1)
                AddLine(lGraphForm.Pane, 1, 0, Drawing.Drawing2D.DashStyle.Dot)
                AddLine(lGraphForm.Pane, lACoef, lBCoef)
            End With
            lOutFileName = lCons & "_" & lSite & "_scat_log"
            lGraphForm.SaveBitmapToFile(lOutFileName & ".png")
            lGraphForm.ZedGraphCtrl.SaveIn(lOutFileName & ".emf")

            lGraphForm.Dispose()

            lGraphForm = New atcGraph.atcGraphForm(lDataGroup, AxisType.Probability)
            SetGraphSpecs(lGraphForm)
            With lGraphForm.Pane
                .YAxis.Title.Text = lCons & " (cfs)"
                .YAxis.Type = ZedGraph.AxisType.Log
                .YAxis.Scale.Min = 1
                .YAxis.Scale.Max = lYMax
                .YAxis.Scale.MaxAuto = False
                .YAxis.Scale.IsUseTenPower = False
                .XAxis.Title.Text = "Percent of Time " & lCons & " exceeded at " & lSite
            End With
            lOutFileName = lCons & "_" & lSite & "_dur"
            lGraphForm.SaveBitmapToFile(lOutFileName & ".png")
            lGraphForm.ZedGraphCtrl.SaveIn(lOutFileName & ".emf")
            lGraphForm.Dispose()

            'add precip to aux axis
            Dim lPrecTser As atcTimeseries = lWdmDataSource.DataSets.ItemByKey(lExpertSystem.Sites(lSiteIndex).Dsn(5))
            lPrecTser.Attributes.SetValue("YAxis", "Aux")
            lDataGroup.Add(SubsetByDate(lPrecTser, _
                                        lExpertSystem.SDateJ, _
                                        lExpertSystem.EDateJ, Nothing))
            lGraphForm = New atcGraph.atcGraphForm(lDataGroup)
            With lGraphForm.Pane
                .YAxis.Scale.Min = 1
                .YAxis.Scale.Max = lYMax
                .YAxis.Title.Text = lCons & " (cfs)"
                .XAxis.Title.Text = "Daily Mean Flow at " & lSite
                .XAxis.MajorTic.IsOutside = True
            End With
            With lGraphForm.PaneAux
                .CurveList.Item(0).Color = Drawing.Color.Blue
                .CurveList.Item(0).Label.Text = "Upper Marlboro"
                .YAxis.Title.Text = "Precip (in)"
            End With
            SetGraphSpecs(lGraphForm)
            lOutFileName = lCons & "_" & lSite
            lGraphForm.SaveBitmapToFile(lOutFileName & ".png")
            lGraphForm.ZedGraphCtrl.SaveIn(lOutFileName & ".emf")

            With lGraphForm.Pane
                .YAxis.Type = ZedGraph.AxisType.Log
                .YAxis.Scale.Min = 1
                .YAxis.Scale.Max = lYMax
                .YAxis.Scale.MaxAuto = False
                .YAxis.Scale.IsUseTenPower = False
            End With
            lOutFileName = lCons & "_" & lSite & "_log "
            lGraphForm.SaveBitmapToFile(lOutFileName & ".png")
            lGraphForm.ZedGraphCtrl.SaveIn(lOutFileName & ".emf")
            lGraphForm.Dispose()

            OpenFile(lOutFileName & ".png")
        Next lSiteIndex
    End Sub

    Private Sub AddLine(ByVal aPane As ZedGraph.GraphPane, _
                        ByVal aACoef As Double, ByVal aBCoef As Double, _
                        Optional ByVal aLineStyle As Drawing.Drawing2D.DashStyle = Drawing.Drawing2D.DashStyle.Solid)
        With aPane
            Dim lXValues(1) As Double
            lXValues(0) = .XAxis.Scale.Min
            lXValues(1) = .XAxis.Scale.Max
            Dim lYValues(1) As Double
            lYValues(0) = (aACoef * lXValues(0)) + aBCoef
            lYValues(1) = (aACoef * lXValues(1)) + aBCoef
            Dim lCurve As LineItem = Nothing
            lCurve = .AddCurve("", lXValues, lYValues, Drawing.Color.Blue, SymbolType.None)
            lCurve.Line.Style = aLineStyle
            .CurveList.Add(lCurve)
        End With
    End Sub

    Private Sub SetGraphSpecs(ByRef aGraphForm As atcGraph.atcGraphForm)
        aGraphForm.WindowState = Windows.Forms.FormWindowState.Maximized
        With aGraphForm.Pane
            .YAxis.MajorGrid.IsVisible = True
            .YAxis.MinorGrid.IsVisible = True
            With .CurveList(0)
                .Label.Text = "Simulated"
                .Color = System.Drawing.Color.Red
            End With
            With .CurveList(1)
                .Label.Text = "Observed"
                .Color = System.Drawing.Color.Blue
            End With
        End With
        Windows.Forms.Application.DoEvents()
    End Sub
End Module
