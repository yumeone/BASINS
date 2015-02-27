﻿Imports atcUtility
Imports MapWinUtility

Public Class frmModel

    Private pIcon As clsIcon
    Friend Schematic As ctlSchematic

    Public Property ModelIcon() As clsIcon
        Set(ByVal value As clsIcon)
            pIcon = value
            lstUciFiles.Text = pIcon.UciFileName
            txtName.Text = pIcon.WatershedName

            cboDownstream.Items.Clear()
            cboDownstream.Items.Add("None")
            For Each lIcon In Schematic.AllIcons
                cboDownstream.Items.Add(lIcon.WatershedName)
            Next
            If pIcon.DownstreamIcon Is Nothing Then
                cboDownstream.SelectedIndex = 0
            Else
                Dim lIndex As Integer = cboDownstream.Items.IndexOf(pIcon.DownstreamIcon.WatershedName)
                If lIndex = -1 Then
                    lIndex = cboDownstream.Items.Count
                    cboDownstream.Items.Add(pIcon.DownstreamIcon.WatershedName)
                End If
                cboDownstream.SelectedIndex = lIndex
            End If
            btnImage.Text = pIcon.WatershedImageFilename
            btnImage.BackgroundImage = pIcon.WatershedImage
            btnImage.BackgroundImageLayout = ImageLayout.Zoom
        End Set
        Get
            pIcon.UciFileName = lstUciFiles.Text
            pIcon.WatershedName = txtName.Text

            Dim lNewDownstreamIcon As clsIcon
            Select Case cboDownstream.SelectedItem.Text.Trim.ToLowerInvariant
                Case "", "none" 'No downstream model
                    lNewDownstreamIcon = Nothing
                Case Else
                    lNewDownstreamIcon = Schematic.AllIcons.FindOrAddIcon(cboDownstream.SelectedItem.Text.Trim)
            End Select

            If pIcon.DownstreamIcon IsNot Nothing AndAlso pIcon.DownstreamIcon.UpstreamIcons.Contains(pIcon) Then
                'Remove old downstream icon connectivity
                pIcon.DownstreamIcon.UpstreamIcons.Remove(pIcon)
            End If
            pIcon.DownstreamIcon = lNewDownstreamIcon
            pIcon.DownstreamIcon.UpstreamIcons.Add(pIcon)

            pIcon.WatershedImageFilename = btnImage.Text
            pIcon.WatershedImage = btnImage.BackgroundImage

            Return pIcon
        End Get
    End Property

    Private Sub btnImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImage.Click
        Dim lFileName As String = String.Empty
        If frmHspfSimulationManager.BrowseOpen("Open Watershed Image File", "PNG Files|*.png|All Files|*.*", ".png", Me, lFileName) Then
            btnImage.Text = lFileName
            btnImage.BackgroundImage = Drawing.Image.FromFile(lFileName)
            Me.Height = btnImage.Height + 164
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        pIcon = Me.ModelIcon 'Apply changes to icon
        If Not Schematic.AllIcons.Contains(pIcon) Then
            'Make sure this icon is on the schematic
            Schematic.AllIcons.Add(pIcon)
        End If
        Schematic.BuildTree(Schematic.AllIcons)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnWinHSPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWinHSPF.Click
        RunUCI("WinHSPF.exe", lstUciFiles.Text)
    End Sub

    Private Sub btnRunHSPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunHSPF.Click
        RunUCI("WinHSPFlt.exe", lstUciFiles.Text)
    End Sub

    Private Sub RunUCI(ByVal aExeName As String, ByVal aUCIFilename As String)
        Dim lHspfExe As String = atcUtility.FindFile("Please locate " & aExeName, aExeName)
        If Not IO.File.Exists(lHspfExe) OrElse Not lHspfExe.ToLower.EndsWith(aExeName.ToLower) Then
            lHspfExe = atcUtility.FindFile("Please locate " & aExeName, aExeName, , , True)
            If Not IO.File.Exists(lHspfExe) OrElse Not lHspfExe.ToLower.EndsWith(aExeName.ToLower) Then
                Logger.Msg("Unable to locate " & aExeName & ", not running.", aExeName)
                Exit Sub
            End If
        End If

        Logger.Status("Running " & aUCIFilename & " (" & lHspfExe & ")")
        MapWinUtility.LaunchProgram(lHspfExe, IO.Path.GetDirectoryName(aUCIFilename), aUCIFilename)
    End Sub

    Private Sub btnBrowseUCIFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseUCIFile.Click
        Dim lFileName As String = String.Empty
        If frmHspfSimulationManager.BrowseOpen("Open UCI File", "UCI Files|*.uci|All Files|*.*", ".uci", Me, lFileName) Then
            lstUciFiles.Items.Add(lFileName)
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            lstUciFiles.Items.Remove(lstUciFiles.SelectedItem)
        Catch
        End Try
    End Sub
End Class