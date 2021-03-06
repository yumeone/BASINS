Imports atcUtility
Imports atcData
Imports atcTimeseriesMath
Imports atcDurationCompare

Public Module AnnualCompareStats
    Public Function Report(ByVal aUci As atcUCI.HspfUci,
                           ByVal aCons As String,
                           ByVal aSite As String,
                           ByVal aUnits As String,
                           ByVal aPrecTSer As atcTimeseries,
                           ByVal aSimTSer As atcTimeseries,
                           ByVal aObsTSer As atcTimeseries,
                           ByVal aRunMade As String,
                           Optional ByVal aSDateJ As Double = 0,
                           Optional ByVal aEDateJ As Double = 0,
                           Optional ByVal aPercentMissingData As Double = 0.0) As String

        Dim lStr As String
        lStr = "Annual Simulated and Observed " & aCons & " Statistics for '" & IO.Path.GetFileNameWithoutExtension(aUci.Name) & "' scenario." & vbCrLf
        lStr &= "   Run Made " & aRunMade & vbCrLf
        lStr &= "   " & aUci.GlobalBlock.RunInf.Value & vbCrLf

        Dim lSDateJ As Double = aSDateJ
        If Math.Abs(lSDateJ) < 0.00001 Then lSDateJ = aUci.GlobalBlock.SDateJ
        Dim lEDateJ As Double = aEDateJ
        If Math.Abs(lEDateJ) < 0.00001 Then lEDateJ = aUci.GlobalBlock.EdateJ

        lStr &= "   " & TimeSpanAsString(aSDateJ, aEDateJ, "Analysis Period: ")
        lStr &= "   (Units:" & aUnits & ")" & vbCrLf & vbCrLf

        If aPercentMissingData > 0 Then
            lStr &= "The observed data is not continuous in this analysis period. The analysis utilizes " & vbCrLf &
                  "simulated and observed data only on the days (time periods) when observed data are " & vbCrLf &
                 "available. Use the results with caution." & vbCrLf
            lStr &= FormatNumber(aPercentMissingData, 1) & "% of observed data is missing." & vbCrLf & vbCrLf
        End If

        CheckDateJ(aObsTSer, "Observed", lSDateJ, lEDateJ, lStr)
        CheckDateJ(aSimTSer, "Simulated", lSDateJ, lEDateJ, lStr)

        Dim lNewSimTSer As atcTimeseries = SubsetByDate(aSimTSer, lSDateJ, lEDateJ, Nothing)
        Dim lNewObsTSer As atcTimeseries = SubsetByDate(aObsTSer, lSDateJ, lEDateJ, Nothing)
        Dim lNewPrecTSer As atcTimeseries = SubsetByDate(aPrecTSer, lSDateJ, lEDateJ, Nothing)

        If lNewSimTSer.numValues <> lNewObsTSer.numValues Then
            lStr &= "   SimCount " & lNewSimTSer.numValues & " ObsCount " & lNewObsTSer.numValues & vbCrLf & vbCrLf
        End If

        lStr &= IntervalReport(aSite, atcTimeUnit.TUYear, lNewSimTSer, lNewObsTSer, True, lNewPrecTSer)

        Return lStr
    End Function
End Module
