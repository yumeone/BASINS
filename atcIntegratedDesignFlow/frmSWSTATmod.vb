Imports atcData
Imports atcUtility
Imports DFLOWAnalysis
Imports MapWinUtility
Imports atcBatchProcessing
Imports System.Windows.Forms

Public Class frmSWSTATmod
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        InitializeComponent() 'required by Windows Form Designer
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuAnalysis As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSelectData As System.Windows.Forms.MenuItem
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabSelectDates As System.Windows.Forms.TabPage
    Friend WithEvents tabNDay As System.Windows.Forms.TabPage
    Friend WithEvents grpDates As System.Windows.Forms.GroupBox
    Friend WithEvents cboStartMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblYearStart As System.Windows.Forms.Label
    Friend WithEvents txtEndDay As System.Windows.Forms.TextBox
    Friend WithEvents txtStartDay As System.Windows.Forms.TextBox
    Friend WithEvents cboEndMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblYearEnd As System.Windows.Forms.Label
    Friend WithEvents grpYears As System.Windows.Forms.GroupBox
    Friend WithEvents lblDataStart As System.Windows.Forms.Label
    Friend WithEvents lblDataEnd As System.Windows.Forms.Label
    Friend WithEvents lblOmitBefore As System.Windows.Forms.Label
    Friend WithEvents lblOmitAfter As System.Windows.Forms.Label
    Friend WithEvents txtOmitAfterYear As System.Windows.Forms.TextBox
    Friend WithEvents txtOmitBeforeYear As System.Windows.Forms.TextBox
    Friend WithEvents btnNDay As System.Windows.Forms.Button
    Friend WithEvents btnDisplayTrend As System.Windows.Forms.Button
    Friend WithEvents btnDisplayBasic As System.Windows.Forms.Button
    Friend WithEvents btnDoFrequencyGrid As System.Windows.Forms.Button
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents grpRecurrence As System.Windows.Forms.GroupBox
    Friend WithEvents btnRecurrenceDefault As System.Windows.Forms.Button
    Friend WithEvents btnRecurrenceRemove As System.Windows.Forms.Button
    Friend WithEvents lstRecurrence As System.Windows.Forms.ListBox
    Friend WithEvents btnRecurrenceAdd As System.Windows.Forms.Button
    Friend WithEvents txtRecurrenceAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnRecurrenceNone As System.Windows.Forms.Button
    Friend WithEvents btnRecurrenceAll As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents grpNday As System.Windows.Forms.GroupBox
    Friend WithEvents btnNdayDefault As System.Windows.Forms.Button
    Friend WithEvents btnNdayRemove As System.Windows.Forms.Button
    Friend WithEvents btnNdayAdd As System.Windows.Forms.Button
    Friend WithEvents txtNdayAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnNdayNone As System.Windows.Forms.Button
    Friend WithEvents btnNdayAll As System.Windows.Forms.Button
    Friend WithEvents lstNday As System.Windows.Forms.ListBox
    Friend WithEvents chkLog As System.Windows.Forms.CheckBox
    Friend WithEvents grpHighLow As System.Windows.Forms.GroupBox
    Friend WithEvents radioHigh As System.Windows.Forms.RadioButton
    Friend WithEvents radioLow As System.Windows.Forms.RadioButton
    Friend WithEvents btnDoFrequencyGraph As System.Windows.Forms.Button
    Friend WithEvents chkMultipleStationPlots As System.Windows.Forms.CheckBox
    Friend WithEvents chkMultipleNDayPlots As System.Windows.Forms.CheckBox
    Friend WithEvents gbTextOutput As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutputDir As System.Windows.Forms.TextBox
    Friend WithEvents lblOutputDir As System.Windows.Forms.Label
    Friend WithEvents txtOutputRootName As System.Windows.Forms.TextBox
    Friend WithEvents lblBaseFilename As System.Windows.Forms.Label
    Friend WithEvents tabDFLOW As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbNonBio3 As System.Windows.Forms.TextBox
    Friend WithEvents tbNonBio4 As System.Windows.Forms.TextBox
    Friend WithEvents tbNonBio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbNonBio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbNonBio3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbNonBio2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbNonBio1 As System.Windows.Forms.RadioButton
    Friend WithEvents gbBio As System.Windows.Forms.GroupBox
    Friend WithEvents tbBio3 As System.Windows.Forms.TextBox
    Friend WithEvents tbBio4 As System.Windows.Forms.TextBox
    Friend WithEvents tbBio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbBio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbBio3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbBio2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbBio1 As System.Windows.Forms.RadioButton
    Friend WithEvents ckbBio As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnScreeningTests As System.Windows.Forms.Button
    Friend WithEvents btnFrequencyReport As System.Windows.Forms.Button
    Friend WithEvents groupGraph As System.Windows.Forms.GroupBox
    Friend WithEvents chkHarmonicMean As System.Windows.Forms.CheckBox
    Friend WithEvents radioYearsAll As RadioButton
    Friend WithEvents radioYearsCustom As RadioButton
    Friend WithEvents radioYearsCommon As RadioButton
    Friend WithEvents chkBio3Amm As System.Windows.Forms.CheckBox
    Friend WithEvents chkBio2Chronic As System.Windows.Forms.CheckBox
    Friend WithEvents chkBio1Acute As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonBioCustom2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtNonBioCustomNday2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNonBioCustomReturn2 As System.Windows.Forms.TextBox
    Friend WithEvents chkNonBioCustom1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonBioChronic As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonBioAcute As System.Windows.Forms.CheckBox
    Friend WithEvents lblNonBioReturn As System.Windows.Forms.Label
    Friend WithEvents txtNonBioCustomNday1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNonBioCustomReturn1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNonBioNday As System.Windows.Forms.Label
    Friend WithEvents chkNonBio3FlowPct As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonBio2ExpFlow As System.Windows.Forms.CheckBox
    Friend WithEvents tabOutlier As TabPage
    Friend WithEvents grdStations As DataGridView
    Friend WithEvents btnOutliers As Button
    Friend WithEvents btnOTall As Button
    Friend WithEvents btnOTnone As Button
    Friend WithEvents btnOTCalculateStats As Button
    Friend WithEvents colOutliers As DataGridViewTextBoxColumn
    Friend WithEvents col7Q10 As DataGridViewTextBoxColumn
    Friend WithEvents colTo As DataGridViewTextBoxColumn
    Friend WithEvents colFrom As DataGridViewTextBoxColumn
    Friend WithEvents colLong As DataGridViewTextBoxColumn
    Friend WithEvents colLat As DataGridViewTextBoxColumn
    Friend WithEvents colStationID As DataGridViewTextBoxColumn
    Friend WithEvents colSelected As DataGridViewCheckBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSWSTATmod))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileSelectData = New System.Windows.Forms.MenuItem()
        Me.mnuAnalysis = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabSelectDates = New System.Windows.Forms.TabPage()
        Me.gbTextOutput = New System.Windows.Forms.GroupBox()
        Me.txtOutputDir = New System.Windows.Forms.TextBox()
        Me.lblOutputDir = New System.Windows.Forms.Label()
        Me.txtOutputRootName = New System.Windows.Forms.TextBox()
        Me.lblBaseFilename = New System.Windows.Forms.Label()
        Me.grpHighLow = New System.Windows.Forms.GroupBox()
        Me.radioHigh = New System.Windows.Forms.RadioButton()
        Me.radioLow = New System.Windows.Forms.RadioButton()
        Me.btnDisplayBasic = New System.Windows.Forms.Button()
        Me.grpDates = New System.Windows.Forms.GroupBox()
        Me.cboStartMonth = New System.Windows.Forms.ComboBox()
        Me.lblYearStart = New System.Windows.Forms.Label()
        Me.txtEndDay = New System.Windows.Forms.TextBox()
        Me.txtStartDay = New System.Windows.Forms.TextBox()
        Me.cboEndMonth = New System.Windows.Forms.ComboBox()
        Me.lblYearEnd = New System.Windows.Forms.Label()
        Me.grpYears = New System.Windows.Forms.GroupBox()
        Me.radioYearsCustom = New System.Windows.Forms.RadioButton()
        Me.radioYearsCommon = New System.Windows.Forms.RadioButton()
        Me.radioYearsAll = New System.Windows.Forms.RadioButton()
        Me.lblDataStart = New System.Windows.Forms.Label()
        Me.lblDataEnd = New System.Windows.Forms.Label()
        Me.lblOmitBefore = New System.Windows.Forms.Label()
        Me.lblOmitAfter = New System.Windows.Forms.Label()
        Me.txtOmitAfterYear = New System.Windows.Forms.TextBox()
        Me.txtOmitBeforeYear = New System.Windows.Forms.TextBox()
        Me.tabNDay = New System.Windows.Forms.TabPage()
        Me.btnDoFrequencyGrid = New System.Windows.Forms.Button()
        Me.groupGraph = New System.Windows.Forms.GroupBox()
        Me.btnDoFrequencyGraph = New System.Windows.Forms.Button()
        Me.chkMultipleNDayPlots = New System.Windows.Forms.CheckBox()
        Me.chkMultipleStationPlots = New System.Windows.Forms.CheckBox()
        Me.btnFrequencyReport = New System.Windows.Forms.Button()
        Me.btnScreeningTests = New System.Windows.Forms.Button()
        Me.chkLog = New System.Windows.Forms.CheckBox()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.grpRecurrence = New System.Windows.Forms.GroupBox()
        Me.btnRecurrenceDefault = New System.Windows.Forms.Button()
        Me.btnRecurrenceRemove = New System.Windows.Forms.Button()
        Me.lstRecurrence = New System.Windows.Forms.ListBox()
        Me.btnRecurrenceAdd = New System.Windows.Forms.Button()
        Me.txtRecurrenceAdd = New System.Windows.Forms.TextBox()
        Me.btnRecurrenceNone = New System.Windows.Forms.Button()
        Me.btnRecurrenceAll = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.grpNday = New System.Windows.Forms.GroupBox()
        Me.btnNdayDefault = New System.Windows.Forms.Button()
        Me.btnNdayRemove = New System.Windows.Forms.Button()
        Me.btnNdayAdd = New System.Windows.Forms.Button()
        Me.txtNdayAdd = New System.Windows.Forms.TextBox()
        Me.btnNdayNone = New System.Windows.Forms.Button()
        Me.btnNdayAll = New System.Windows.Forms.Button()
        Me.lstNday = New System.Windows.Forms.ListBox()
        Me.btnDisplayTrend = New System.Windows.Forms.Button()
        Me.btnNDay = New System.Windows.Forms.Button()
        Me.tabDFLOW = New System.Windows.Forms.TabPage()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkNonBio3FlowPct = New System.Windows.Forms.CheckBox()
        Me.chkNonBio2ExpFlow = New System.Windows.Forms.CheckBox()
        Me.chkNonBioCustom2 = New System.Windows.Forms.CheckBox()
        Me.txtNonBioCustomNday2 = New System.Windows.Forms.TextBox()
        Me.txtNonBioCustomReturn2 = New System.Windows.Forms.TextBox()
        Me.chkNonBioCustom1 = New System.Windows.Forms.CheckBox()
        Me.chkNonBioChronic = New System.Windows.Forms.CheckBox()
        Me.chkNonBioAcute = New System.Windows.Forms.CheckBox()
        Me.lblNonBioReturn = New System.Windows.Forms.Label()
        Me.txtNonBioCustomNday1 = New System.Windows.Forms.TextBox()
        Me.txtNonBioCustomReturn1 = New System.Windows.Forms.TextBox()
        Me.lblNonBioNday = New System.Windows.Forms.Label()
        Me.chkHarmonicMean = New System.Windows.Forms.CheckBox()
        Me.tbNonBio3 = New System.Windows.Forms.TextBox()
        Me.tbNonBio4 = New System.Windows.Forms.TextBox()
        Me.tbNonBio2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbNonBio1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbNonBio3 = New System.Windows.Forms.RadioButton()
        Me.rbNonBio2 = New System.Windows.Forms.RadioButton()
        Me.rbNonBio1 = New System.Windows.Forms.RadioButton()
        Me.gbBio = New System.Windows.Forms.GroupBox()
        Me.chkBio3Amm = New System.Windows.Forms.CheckBox()
        Me.chkBio2Chronic = New System.Windows.Forms.CheckBox()
        Me.chkBio1Acute = New System.Windows.Forms.CheckBox()
        Me.rbBio3 = New System.Windows.Forms.RadioButton()
        Me.rbBio2 = New System.Windows.Forms.RadioButton()
        Me.rbBio1 = New System.Windows.Forms.RadioButton()
        Me.tbBio3 = New System.Windows.Forms.TextBox()
        Me.tbBio4 = New System.Windows.Forms.TextBox()
        Me.tbBio2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBio1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckbBio = New System.Windows.Forms.CheckBox()
        Me.tabOutlier = New System.Windows.Forms.TabPage()
        Me.btnOutliers = New System.Windows.Forms.Button()
        Me.btnOTall = New System.Windows.Forms.Button()
        Me.btnOTnone = New System.Windows.Forms.Button()
        Me.btnOTCalculateStats = New System.Windows.Forms.Button()
        Me.grdStations = New System.Windows.Forms.DataGridView()
        Me.colSelected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colStationID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col7Q10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOutliers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tabMain.SuspendLayout()
        Me.tabSelectDates.SuspendLayout()
        Me.gbTextOutput.SuspendLayout()
        Me.grpHighLow.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.grpYears.SuspendLayout()
        Me.tabNDay.SuspendLayout()
        Me.groupGraph.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.grpRecurrence.SuspendLayout()
        Me.grpNday.SuspendLayout()
        Me.tabDFLOW.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbBio.SuspendLayout()
        Me.tabOutlier.SuspendLayout()
        CType(Me.grdStations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuAnalysis, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileSelectData})
        Me.mnuFile.Text = "File"
        '
        'mnuFileSelectData
        '
        Me.mnuFileSelectData.Index = 0
        Me.mnuFileSelectData.Text = "Select &Data"
        '
        'mnuAnalysis
        '
        Me.mnuAnalysis.Index = 1
        Me.mnuAnalysis.Text = "Analysis"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.mnuHelp.Text = "Help"
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.tabSelectDates)
        Me.tabMain.Controls.Add(Me.tabNDay)
        Me.tabMain.Controls.Add(Me.tabDFLOW)
        Me.tabMain.Controls.Add(Me.tabOutlier)
        Me.tabMain.Location = New System.Drawing.Point(0, 2)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(472, 545)
        Me.tabMain.TabIndex = 1
        '
        'tabSelectDates
        '
        Me.tabSelectDates.BackColor = System.Drawing.Color.Transparent
        Me.tabSelectDates.Controls.Add(Me.gbTextOutput)
        Me.tabSelectDates.Controls.Add(Me.grpHighLow)
        Me.tabSelectDates.Controls.Add(Me.btnDisplayBasic)
        Me.tabSelectDates.Controls.Add(Me.grpDates)
        Me.tabSelectDates.Controls.Add(Me.grpYears)
        Me.tabSelectDates.Location = New System.Drawing.Point(4, 22)
        Me.tabSelectDates.Name = "tabSelectDates"
        Me.tabSelectDates.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSelectDates.Size = New System.Drawing.Size(464, 519)
        Me.tabSelectDates.TabIndex = 0
        Me.tabSelectDates.Text = "Select Dates"
        Me.tabSelectDates.UseVisualStyleBackColor = True
        '
        'gbTextOutput
        '
        Me.gbTextOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTextOutput.Controls.Add(Me.txtOutputDir)
        Me.gbTextOutput.Controls.Add(Me.lblOutputDir)
        Me.gbTextOutput.Controls.Add(Me.txtOutputRootName)
        Me.gbTextOutput.Controls.Add(Me.lblBaseFilename)
        Me.gbTextOutput.Location = New System.Drawing.Point(214, 6)
        Me.gbTextOutput.Name = "gbTextOutput"
        Me.gbTextOutput.Size = New System.Drawing.Size(241, 144)
        Me.gbTextOutput.TabIndex = 73
        Me.gbTextOutput.TabStop = False
        Me.gbTextOutput.Text = "Output"
        Me.gbTextOutput.Visible = False
        '
        'txtOutputDir
        '
        Me.txtOutputDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputDir.Location = New System.Drawing.Point(6, 45)
        Me.txtOutputDir.Name = "txtOutputDir"
        Me.txtOutputDir.Size = New System.Drawing.Size(229, 20)
        Me.txtOutputDir.TabIndex = 12
        '
        'lblOutputDir
        '
        Me.lblOutputDir.AutoSize = True
        Me.lblOutputDir.Location = New System.Drawing.Point(6, 29)
        Me.lblOutputDir.Name = "lblOutputDir"
        Me.lblOutputDir.Size = New System.Drawing.Size(29, 13)
        Me.lblOutputDir.TabIndex = 31
        Me.lblOutputDir.Text = "Path"
        '
        'txtOutputRootName
        '
        Me.txtOutputRootName.Location = New System.Drawing.Point(6, 102)
        Me.txtOutputRootName.Name = "txtOutputRootName"
        Me.txtOutputRootName.Size = New System.Drawing.Size(201, 20)
        Me.txtOutputRootName.TabIndex = 13
        '
        'lblBaseFilename
        '
        Me.lblBaseFilename.AutoSize = True
        Me.lblBaseFilename.Location = New System.Drawing.Point(6, 86)
        Me.lblBaseFilename.Name = "lblBaseFilename"
        Me.lblBaseFilename.Size = New System.Drawing.Size(52, 13)
        Me.lblBaseFilename.TabIndex = 30
        Me.lblBaseFilename.Text = "File Prefix"
        '
        'grpHighLow
        '
        Me.grpHighLow.Controls.Add(Me.radioHigh)
        Me.grpHighLow.Controls.Add(Me.radioLow)
        Me.grpHighLow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpHighLow.Location = New System.Drawing.Point(8, 6)
        Me.grpHighLow.Name = "grpHighLow"
        Me.grpHighLow.Size = New System.Drawing.Size(200, 65)
        Me.grpHighLow.TabIndex = 72
        Me.grpHighLow.TabStop = False
        Me.grpHighLow.Text = "Flow Condition"
        '
        'radioHigh
        '
        Me.radioHigh.AutoSize = True
        Me.radioHigh.Checked = True
        Me.radioHigh.Location = New System.Drawing.Point(6, 19)
        Me.radioHigh.Name = "radioHigh"
        Me.radioHigh.Size = New System.Drawing.Size(47, 17)
        Me.radioHigh.TabIndex = 1
        Me.radioHigh.TabStop = True
        Me.radioHigh.Text = "High"
        Me.radioHigh.UseVisualStyleBackColor = True
        '
        'radioLow
        '
        Me.radioLow.AutoSize = True
        Me.radioLow.Location = New System.Drawing.Point(6, 42)
        Me.radioLow.Name = "radioLow"
        Me.radioLow.Size = New System.Drawing.Size(45, 17)
        Me.radioLow.TabIndex = 2
        Me.radioLow.Text = "Low"
        Me.radioLow.UseVisualStyleBackColor = True
        '
        'btnDisplayBasic
        '
        Me.btnDisplayBasic.Location = New System.Drawing.Point(8, 307)
        Me.btnDisplayBasic.Name = "btnDisplayBasic"
        Me.btnDisplayBasic.Size = New System.Drawing.Size(157, 23)
        Me.btnDisplayBasic.TabIndex = 10
        Me.btnDisplayBasic.Text = "Display Basic Statistics"
        Me.btnDisplayBasic.UseVisualStyleBackColor = True
        '
        'grpDates
        '
        Me.grpDates.BackColor = System.Drawing.Color.Transparent
        Me.grpDates.Controls.Add(Me.cboStartMonth)
        Me.grpDates.Controls.Add(Me.lblYearStart)
        Me.grpDates.Controls.Add(Me.txtEndDay)
        Me.grpDates.Controls.Add(Me.txtStartDay)
        Me.grpDates.Controls.Add(Me.cboEndMonth)
        Me.grpDates.Controls.Add(Me.lblYearEnd)
        Me.grpDates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpDates.Location = New System.Drawing.Point(8, 77)
        Me.grpDates.Name = "grpDates"
        Me.grpDates.Size = New System.Drawing.Size(200, 73)
        Me.grpDates.TabIndex = 67
        Me.grpDates.TabStop = False
        Me.grpDates.Text = "Year / Season Boundaries"
        '
        'cboStartMonth
        '
        Me.cboStartMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboStartMonth.Location = New System.Drawing.Point(41, 19)
        Me.cboStartMonth.MaxDropDownItems = 12
        Me.cboStartMonth.Name = "cboStartMonth"
        Me.cboStartMonth.Size = New System.Drawing.Size(88, 21)
        Me.cboStartMonth.TabIndex = 3
        Me.cboStartMonth.Text = "January"
        '
        'lblYearStart
        '
        Me.lblYearStart.AutoSize = True
        Me.lblYearStart.Location = New System.Drawing.Point(6, 22)
        Me.lblYearStart.Name = "lblYearStart"
        Me.lblYearStart.Size = New System.Drawing.Size(29, 13)
        Me.lblYearStart.TabIndex = 23
        Me.lblYearStart.Text = "Start"
        '
        'txtEndDay
        '
        Me.txtEndDay.Location = New System.Drawing.Point(135, 46)
        Me.txtEndDay.Name = "txtEndDay"
        Me.txtEndDay.Size = New System.Drawing.Size(24, 20)
        Me.txtEndDay.TabIndex = 6
        Me.txtEndDay.Text = "31"
        Me.txtEndDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartDay
        '
        Me.txtStartDay.Location = New System.Drawing.Point(135, 19)
        Me.txtStartDay.Name = "txtStartDay"
        Me.txtStartDay.Size = New System.Drawing.Size(24, 20)
        Me.txtStartDay.TabIndex = 4
        Me.txtStartDay.Text = "1"
        Me.txtStartDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboEndMonth
        '
        Me.cboEndMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboEndMonth.Location = New System.Drawing.Point(41, 46)
        Me.cboEndMonth.MaxDropDownItems = 12
        Me.cboEndMonth.Name = "cboEndMonth"
        Me.cboEndMonth.Size = New System.Drawing.Size(88, 21)
        Me.cboEndMonth.TabIndex = 5
        Me.cboEndMonth.Text = "December"
        '
        'lblYearEnd
        '
        Me.lblYearEnd.AutoSize = True
        Me.lblYearEnd.Location = New System.Drawing.Point(6, 49)
        Me.lblYearEnd.Name = "lblYearEnd"
        Me.lblYearEnd.Size = New System.Drawing.Size(26, 13)
        Me.lblYearEnd.TabIndex = 61
        Me.lblYearEnd.Text = "End"
        '
        'grpYears
        '
        Me.grpYears.BackColor = System.Drawing.Color.Transparent
        Me.grpYears.Controls.Add(Me.radioYearsCustom)
        Me.grpYears.Controls.Add(Me.radioYearsCommon)
        Me.grpYears.Controls.Add(Me.radioYearsAll)
        Me.grpYears.Controls.Add(Me.lblDataStart)
        Me.grpYears.Controls.Add(Me.lblDataEnd)
        Me.grpYears.Controls.Add(Me.lblOmitBefore)
        Me.grpYears.Controls.Add(Me.lblOmitAfter)
        Me.grpYears.Controls.Add(Me.txtOmitAfterYear)
        Me.grpYears.Controls.Add(Me.txtOmitBeforeYear)
        Me.grpYears.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpYears.Location = New System.Drawing.Point(8, 156)
        Me.grpYears.Name = "grpYears"
        Me.grpYears.Size = New System.Drawing.Size(250, 145)
        Me.grpYears.TabIndex = 66
        Me.grpYears.TabStop = False
        Me.grpYears.Text = "Years to Include in Analysis"
        '
        'radioYearsCustom
        '
        Me.radioYearsCustom.AutoSize = True
        Me.radioYearsCustom.Location = New System.Drawing.Point(6, 65)
        Me.radioYearsCustom.Name = "radioYearsCustom"
        Me.radioYearsCustom.Size = New System.Drawing.Size(63, 17)
        Me.radioYearsCustom.TabIndex = 48
        Me.radioYearsCustom.TabStop = True
        Me.radioYearsCustom.Text = "Custom:"
        Me.radioYearsCustom.UseVisualStyleBackColor = True
        '
        'radioYearsCommon
        '
        Me.radioYearsCommon.AutoSize = True
        Me.radioYearsCommon.Location = New System.Drawing.Point(6, 42)
        Me.radioYearsCommon.Name = "radioYearsCommon"
        Me.radioYearsCommon.Size = New System.Drawing.Size(66, 17)
        Me.radioYearsCommon.TabIndex = 47
        Me.radioYearsCommon.TabStop = True
        Me.radioYearsCommon.Text = "Common"
        Me.radioYearsCommon.UseVisualStyleBackColor = True
        '
        'radioYearsAll
        '
        Me.radioYearsAll.AutoSize = True
        Me.radioYearsAll.Location = New System.Drawing.Point(6, 19)
        Me.radioYearsAll.Name = "radioYearsAll"
        Me.radioYearsAll.Size = New System.Drawing.Size(36, 17)
        Me.radioYearsAll.TabIndex = 46
        Me.radioYearsAll.TabStop = True
        Me.radioYearsAll.Text = "All"
        Me.radioYearsAll.UseVisualStyleBackColor = True
        '
        'lblDataStart
        '
        Me.lblDataStart.AutoSize = True
        Me.lblDataStart.Enabled = False
        Me.lblDataStart.Location = New System.Drawing.Point(122, 91)
        Me.lblDataStart.Name = "lblDataStart"
        Me.lblDataStart.Size = New System.Drawing.Size(119, 13)
        Me.lblDataStart.TabIndex = 45
        Me.lblDataStart.Tag = "Data Starts"
        Me.lblDataStart.Text = "Start Date: 11/22/1934"
        '
        'lblDataEnd
        '
        Me.lblDataEnd.AutoSize = True
        Me.lblDataEnd.Enabled = False
        Me.lblDataEnd.Location = New System.Drawing.Point(122, 117)
        Me.lblDataEnd.Name = "lblDataEnd"
        Me.lblDataEnd.Size = New System.Drawing.Size(116, 13)
        Me.lblDataEnd.TabIndex = 1
        Me.lblDataEnd.Tag = "Data Ends"
        Me.lblDataEnd.Text = "End Date: 11/22/1934"
        '
        'lblOmitBefore
        '
        Me.lblOmitBefore.AutoSize = True
        Me.lblOmitBefore.Enabled = False
        Me.lblOmitBefore.Location = New System.Drawing.Point(5, 91)
        Me.lblOmitBefore.Name = "lblOmitBefore"
        Me.lblOmitBefore.Size = New System.Drawing.Size(54, 13)
        Me.lblOmitBefore.TabIndex = 40
        Me.lblOmitBefore.Text = "Start Year"
        '
        'lblOmitAfter
        '
        Me.lblOmitAfter.AutoSize = True
        Me.lblOmitAfter.Enabled = False
        Me.lblOmitAfter.Location = New System.Drawing.Point(5, 117)
        Me.lblOmitAfter.Name = "lblOmitAfter"
        Me.lblOmitAfter.Size = New System.Drawing.Size(51, 13)
        Me.lblOmitAfter.TabIndex = 43
        Me.lblOmitAfter.Text = "End Year"
        '
        'txtOmitAfterYear
        '
        Me.txtOmitAfterYear.Enabled = False
        Me.txtOmitAfterYear.Location = New System.Drawing.Point(65, 114)
        Me.txtOmitAfterYear.Name = "txtOmitAfterYear"
        Me.txtOmitAfterYear.Size = New System.Drawing.Size(37, 20)
        Me.txtOmitAfterYear.TabIndex = 9
        Me.txtOmitAfterYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOmitBeforeYear
        '
        Me.txtOmitBeforeYear.Enabled = False
        Me.txtOmitBeforeYear.Location = New System.Drawing.Point(65, 88)
        Me.txtOmitBeforeYear.Name = "txtOmitBeforeYear"
        Me.txtOmitBeforeYear.Size = New System.Drawing.Size(37, 20)
        Me.txtOmitBeforeYear.TabIndex = 8
        Me.txtOmitBeforeYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabNDay
        '
        Me.tabNDay.BackColor = System.Drawing.Color.Transparent
        Me.tabNDay.Controls.Add(Me.btnDoFrequencyGrid)
        Me.tabNDay.Controls.Add(Me.groupGraph)
        Me.tabNDay.Controls.Add(Me.btnFrequencyReport)
        Me.tabNDay.Controls.Add(Me.btnScreeningTests)
        Me.tabNDay.Controls.Add(Me.chkLog)
        Me.tabNDay.Controls.Add(Me.panelTop)
        Me.tabNDay.Controls.Add(Me.btnDisplayTrend)
        Me.tabNDay.Controls.Add(Me.btnNDay)
        Me.tabNDay.Location = New System.Drawing.Point(4, 22)
        Me.tabNDay.Name = "tabNDay"
        Me.tabNDay.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNDay.Size = New System.Drawing.Size(464, 519)
        Me.tabNDay.TabIndex = 2
        Me.tabNDay.Text = "N-Day, Trend, Frequency"
        Me.tabNDay.UseVisualStyleBackColor = True
        '
        'btnDoFrequencyGrid
        '
        Me.btnDoFrequencyGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDoFrequencyGrid.Location = New System.Drawing.Point(177, 402)
        Me.btnDoFrequencyGrid.Name = "btnDoFrequencyGrid"
        Me.btnDoFrequencyGrid.Size = New System.Drawing.Size(124, 23)
        Me.btnDoFrequencyGrid.TabIndex = 37
        Me.btnDoFrequencyGrid.Text = "Frequency Grid"
        Me.btnDoFrequencyGrid.UseVisualStyleBackColor = True
        '
        'groupGraph
        '
        Me.groupGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupGraph.Controls.Add(Me.btnDoFrequencyGraph)
        Me.groupGraph.Controls.Add(Me.chkMultipleNDayPlots)
        Me.groupGraph.Controls.Add(Me.chkMultipleStationPlots)
        Me.groupGraph.Location = New System.Drawing.Point(138, 454)
        Me.groupGraph.Name = "groupGraph"
        Me.groupGraph.Size = New System.Drawing.Size(289, 57)
        Me.groupGraph.TabIndex = 43
        Me.groupGraph.TabStop = False
        '
        'btnDoFrequencyGraph
        '
        Me.btnDoFrequencyGraph.Location = New System.Drawing.Point(10, 18)
        Me.btnDoFrequencyGraph.Name = "btnDoFrequencyGraph"
        Me.btnDoFrequencyGraph.Size = New System.Drawing.Size(124, 23)
        Me.btnDoFrequencyGraph.TabIndex = 38
        Me.btnDoFrequencyGraph.Text = "Frequency Graph"
        Me.btnDoFrequencyGraph.UseVisualStyleBackColor = True
        '
        'chkMultipleNDayPlots
        '
        Me.chkMultipleNDayPlots.AutoSize = True
        Me.chkMultipleNDayPlots.Location = New System.Drawing.Point(152, 10)
        Me.chkMultipleNDayPlots.Name = "chkMultipleNDayPlots"
        Me.chkMultipleNDayPlots.Size = New System.Drawing.Size(128, 17)
        Me.chkMultipleNDayPlots.TabIndex = 39
        Me.chkMultipleNDayPlots.Text = "Separate N-Day Plots"
        Me.chkMultipleNDayPlots.UseVisualStyleBackColor = True
        '
        'chkMultipleStationPlots
        '
        Me.chkMultipleStationPlots.AutoSize = True
        Me.chkMultipleStationPlots.Location = New System.Drawing.Point(152, 33)
        Me.chkMultipleStationPlots.Name = "chkMultipleStationPlots"
        Me.chkMultipleStationPlots.Size = New System.Drawing.Size(131, 17)
        Me.chkMultipleStationPlots.TabIndex = 40
        Me.chkMultipleStationPlots.Text = "Separate Station Plots"
        Me.chkMultipleStationPlots.UseVisualStyleBackColor = True
        '
        'btnFrequencyReport
        '
        Me.btnFrequencyReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFrequencyReport.Location = New System.Drawing.Point(177, 431)
        Me.btnFrequencyReport.Name = "btnFrequencyReport"
        Me.btnFrequencyReport.Size = New System.Drawing.Size(124, 23)
        Me.btnFrequencyReport.TabIndex = 42
        Me.btnFrequencyReport.Text = "Frequency Report"
        Me.btnFrequencyReport.UseVisualStyleBackColor = True
        '
        'btnScreeningTests
        '
        Me.btnScreeningTests.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnScreeningTests.Location = New System.Drawing.Point(8, 460)
        Me.btnScreeningTests.Name = "btnScreeningTests"
        Me.btnScreeningTests.Size = New System.Drawing.Size(124, 23)
        Me.btnScreeningTests.TabIndex = 41
        Me.btnScreeningTests.Text = "Screening Tests (R)"
        Me.btnScreeningTests.UseVisualStyleBackColor = True
        '
        'chkLog
        '
        Me.chkLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkLog.AutoSize = True
        Me.chkLog.Checked = True
        Me.chkLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLog.Location = New System.Drawing.Point(37, 381)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.Size = New System.Drawing.Size(80, 17)
        Me.chkLog.TabIndex = 36
        Me.chkLog.Text = "Logarithmic"
        Me.chkLog.UseVisualStyleBackColor = True
        '
        'panelTop
        '
        Me.panelTop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTop.Controls.Add(Me.grpRecurrence)
        Me.panelTop.Controls.Add(Me.Splitter1)
        Me.panelTop.Controls.Add(Me.grpNday)
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(464, 378)
        Me.panelTop.TabIndex = 34
        '
        'grpRecurrence
        '
        Me.grpRecurrence.BackColor = System.Drawing.Color.Transparent
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceDefault)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceRemove)
        Me.grpRecurrence.Controls.Add(Me.lstRecurrence)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceAdd)
        Me.grpRecurrence.Controls.Add(Me.txtRecurrenceAdd)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceNone)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceAll)
        Me.grpRecurrence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpRecurrence.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpRecurrence.Location = New System.Drawing.Point(210, 0)
        Me.grpRecurrence.Name = "grpRecurrence"
        Me.grpRecurrence.Size = New System.Drawing.Size(254, 378)
        Me.grpRecurrence.TabIndex = 7
        Me.grpRecurrence.TabStop = False
        Me.grpRecurrence.Text = "Recurrence Interval"
        '
        'btnRecurrenceDefault
        '
        Me.btnRecurrenceDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceDefault.Location = New System.Drawing.Point(192, 319)
        Me.btnRecurrenceDefault.Name = "btnRecurrenceDefault"
        Me.btnRecurrenceDefault.Size = New System.Drawing.Size(56, 20)
        Me.btnRecurrenceDefault.TabIndex = 31
        Me.btnRecurrenceDefault.Text = "Default"
        '
        'btnRecurrenceRemove
        '
        Me.btnRecurrenceRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceRemove.Location = New System.Drawing.Point(158, 319)
        Me.btnRecurrenceRemove.Name = "btnRecurrenceRemove"
        Me.btnRecurrenceRemove.Size = New System.Drawing.Size(28, 20)
        Me.btnRecurrenceRemove.TabIndex = 30
        Me.btnRecurrenceRemove.Text = "-"
        '
        'lstRecurrence
        '
        Me.lstRecurrence.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstRecurrence.IntegralHeight = False
        Me.lstRecurrence.Location = New System.Drawing.Point(6, 19)
        Me.lstRecurrence.Name = "lstRecurrence"
        Me.lstRecurrence.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstRecurrence.Size = New System.Drawing.Size(240, 294)
        Me.lstRecurrence.TabIndex = 27
        Me.lstRecurrence.Tag = "Return Period"
        '
        'btnRecurrenceAdd
        '
        Me.btnRecurrenceAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceAdd.Location = New System.Drawing.Point(126, 319)
        Me.btnRecurrenceAdd.Name = "btnRecurrenceAdd"
        Me.btnRecurrenceAdd.Size = New System.Drawing.Size(27, 20)
        Me.btnRecurrenceAdd.TabIndex = 29
        Me.btnRecurrenceAdd.Text = "+"
        '
        'txtRecurrenceAdd
        '
        Me.txtRecurrenceAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecurrenceAdd.Location = New System.Drawing.Point(6, 319)
        Me.txtRecurrenceAdd.Name = "txtRecurrenceAdd"
        Me.txtRecurrenceAdd.Size = New System.Drawing.Size(114, 20)
        Me.txtRecurrenceAdd.TabIndex = 28
        '
        'btnRecurrenceNone
        '
        Me.btnRecurrenceNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceNone.Location = New System.Drawing.Point(183, 348)
        Me.btnRecurrenceNone.Name = "btnRecurrenceNone"
        Me.btnRecurrenceNone.Size = New System.Drawing.Size(65, 24)
        Me.btnRecurrenceNone.TabIndex = 33
        Me.btnRecurrenceNone.Text = "None"
        '
        'btnRecurrenceAll
        '
        Me.btnRecurrenceAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceAll.Location = New System.Drawing.Point(6, 348)
        Me.btnRecurrenceAll.Name = "btnRecurrenceAll"
        Me.btnRecurrenceAll.Size = New System.Drawing.Size(64, 24)
        Me.btnRecurrenceAll.TabIndex = 32
        Me.btnRecurrenceAll.Text = "All"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Control
        Me.Splitter1.Location = New System.Drawing.Point(200, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 378)
        Me.Splitter1.TabIndex = 13
        Me.Splitter1.TabStop = False
        '
        'grpNday
        '
        Me.grpNday.BackColor = System.Drawing.Color.Transparent
        Me.grpNday.Controls.Add(Me.btnNdayDefault)
        Me.grpNday.Controls.Add(Me.btnNdayRemove)
        Me.grpNday.Controls.Add(Me.btnNdayAdd)
        Me.grpNday.Controls.Add(Me.txtNdayAdd)
        Me.grpNday.Controls.Add(Me.btnNdayNone)
        Me.grpNday.Controls.Add(Me.btnNdayAll)
        Me.grpNday.Controls.Add(Me.lstNday)
        Me.grpNday.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpNday.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpNday.Location = New System.Drawing.Point(0, 0)
        Me.grpNday.Name = "grpNday"
        Me.grpNday.Size = New System.Drawing.Size(200, 378)
        Me.grpNday.TabIndex = 1
        Me.grpNday.TabStop = False
        Me.grpNday.Text = "Number of Days"
        '
        'btnNdayDefault
        '
        Me.btnNdayDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayDefault.Location = New System.Drawing.Point(138, 319)
        Me.btnNdayDefault.Name = "btnNdayDefault"
        Me.btnNdayDefault.Size = New System.Drawing.Size(56, 20)
        Me.btnNdayDefault.TabIndex = 24
        Me.btnNdayDefault.Text = "Default"
        '
        'btnNdayRemove
        '
        Me.btnNdayRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayRemove.Location = New System.Drawing.Point(105, 319)
        Me.btnNdayRemove.Name = "btnNdayRemove"
        Me.btnNdayRemove.Size = New System.Drawing.Size(27, 20)
        Me.btnNdayRemove.TabIndex = 23
        Me.btnNdayRemove.Text = "-"
        '
        'btnNdayAdd
        '
        Me.btnNdayAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayAdd.Location = New System.Drawing.Point(72, 319)
        Me.btnNdayAdd.Name = "btnNdayAdd"
        Me.btnNdayAdd.Size = New System.Drawing.Size(27, 20)
        Me.btnNdayAdd.TabIndex = 22
        Me.btnNdayAdd.Text = "+"
        '
        'txtNdayAdd
        '
        Me.txtNdayAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNdayAdd.Location = New System.Drawing.Point(6, 319)
        Me.txtNdayAdd.Name = "txtNdayAdd"
        Me.txtNdayAdd.Size = New System.Drawing.Size(54, 20)
        Me.txtNdayAdd.TabIndex = 21
        '
        'btnNdayNone
        '
        Me.btnNdayNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayNone.Location = New System.Drawing.Point(130, 348)
        Me.btnNdayNone.Name = "btnNdayNone"
        Me.btnNdayNone.Size = New System.Drawing.Size(64, 23)
        Me.btnNdayNone.TabIndex = 26
        Me.btnNdayNone.Text = "None"
        '
        'btnNdayAll
        '
        Me.btnNdayAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNdayAll.Location = New System.Drawing.Point(6, 348)
        Me.btnNdayAll.Name = "btnNdayAll"
        Me.btnNdayAll.Size = New System.Drawing.Size(64, 24)
        Me.btnNdayAll.TabIndex = 25
        Me.btnNdayAll.Text = "All"
        '
        'lstNday
        '
        Me.lstNday.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstNday.IntegralHeight = False
        Me.lstNday.Location = New System.Drawing.Point(6, 19)
        Me.lstNday.Name = "lstNday"
        Me.lstNday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstNday.Size = New System.Drawing.Size(188, 294)
        Me.lstNday.TabIndex = 20
        Me.lstNday.Tag = "NDay"
        '
        'btnDisplayTrend
        '
        Me.btnDisplayTrend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDisplayTrend.Location = New System.Drawing.Point(8, 431)
        Me.btnDisplayTrend.Name = "btnDisplayTrend"
        Me.btnDisplayTrend.Size = New System.Drawing.Size(124, 23)
        Me.btnDisplayTrend.TabIndex = 35
        Me.btnDisplayTrend.Text = "Trend List"
        Me.btnDisplayTrend.UseVisualStyleBackColor = True
        '
        'btnNDay
        '
        Me.btnNDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNDay.Location = New System.Drawing.Point(8, 402)
        Me.btnNDay.Name = "btnNDay"
        Me.btnNDay.Size = New System.Drawing.Size(124, 23)
        Me.btnNDay.TabIndex = 34
        Me.btnNDay.Text = "N-Day Timeseries List"
        Me.btnNDay.UseVisualStyleBackColor = True
        '
        'tabDFLOW
        '
        Me.tabDFLOW.Controls.Add(Me.btnCalculate)
        Me.tabDFLOW.Controls.Add(Me.GroupBox2)
        Me.tabDFLOW.Controls.Add(Me.gbBio)
        Me.tabDFLOW.Location = New System.Drawing.Point(4, 22)
        Me.tabDFLOW.Name = "tabDFLOW"
        Me.tabDFLOW.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDFLOW.Size = New System.Drawing.Size(464, 519)
        Me.tabDFLOW.TabIndex = 3
        Me.tabDFLOW.Text = "Design Flow"
        Me.tabDFLOW.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(6, 478)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 21
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkNonBio3FlowPct)
        Me.GroupBox2.Controls.Add(Me.chkNonBio2ExpFlow)
        Me.GroupBox2.Controls.Add(Me.chkNonBioCustom2)
        Me.GroupBox2.Controls.Add(Me.txtNonBioCustomNday2)
        Me.GroupBox2.Controls.Add(Me.txtNonBioCustomReturn2)
        Me.GroupBox2.Controls.Add(Me.chkNonBioCustom1)
        Me.GroupBox2.Controls.Add(Me.chkNonBioChronic)
        Me.GroupBox2.Controls.Add(Me.chkNonBioAcute)
        Me.GroupBox2.Controls.Add(Me.lblNonBioReturn)
        Me.GroupBox2.Controls.Add(Me.txtNonBioCustomNday1)
        Me.GroupBox2.Controls.Add(Me.txtNonBioCustomReturn1)
        Me.GroupBox2.Controls.Add(Me.lblNonBioNday)
        Me.GroupBox2.Controls.Add(Me.chkHarmonicMean)
        Me.GroupBox2.Controls.Add(Me.tbNonBio3)
        Me.GroupBox2.Controls.Add(Me.tbNonBio4)
        Me.GroupBox2.Controls.Add(Me.tbNonBio2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbNonBio1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.rbNonBio3)
        Me.GroupBox2.Controls.Add(Me.rbNonBio2)
        Me.GroupBox2.Controls.Add(Me.rbNonBio1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(419, 230)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Non-Biological Design Flow Parameters"
        '
        'chkNonBio3FlowPct
        '
        Me.chkNonBio3FlowPct.AutoSize = True
        Me.chkNonBio3FlowPct.Location = New System.Drawing.Point(6, 169)
        Me.chkNonBio3FlowPct.Name = "chkNonBio3FlowPct"
        Me.chkNonBio3FlowPct.Size = New System.Drawing.Size(100, 17)
        Me.chkNonBio3FlowPct.TabIndex = 18
        Me.chkNonBio3FlowPct.Text = "Flow percentile:"
        Me.chkNonBio3FlowPct.UseVisualStyleBackColor = True
        '
        'chkNonBio2ExpFlow
        '
        Me.chkNonBio2ExpFlow.AutoSize = True
        Me.chkNonBio2ExpFlow.Location = New System.Drawing.Point(6, 146)
        Me.chkNonBio2ExpFlow.Name = "chkNonBio2ExpFlow"
        Me.chkNonBio2ExpFlow.Size = New System.Drawing.Size(113, 17)
        Me.chkNonBio2ExpFlow.TabIndex = 16
        Me.chkNonBio2ExpFlow.Text = "Explicit flow value:"
        Me.chkNonBio2ExpFlow.UseVisualStyleBackColor = True
        '
        'chkNonBioCustom2
        '
        Me.chkNonBioCustom2.AutoSize = True
        Me.chkNonBioCustom2.Location = New System.Drawing.Point(6, 112)
        Me.chkNonBioCustom2.Name = "chkNonBioCustom2"
        Me.chkNonBioCustom2.Size = New System.Drawing.Size(61, 17)
        Me.chkNonBioCustom2.TabIndex = 13
        Me.chkNonBioCustom2.Text = "Custom"
        Me.chkNonBioCustom2.UseVisualStyleBackColor = True
        '
        'txtNonBioCustomNday2
        '
        Me.txtNonBioCustomNday2.Enabled = False
        Me.txtNonBioCustomNday2.Location = New System.Drawing.Point(120, 110)
        Me.txtNonBioCustomNday2.Name = "txtNonBioCustomNday2"
        Me.txtNonBioCustomNday2.Size = New System.Drawing.Size(49, 20)
        Me.txtNonBioCustomNday2.TabIndex = 14
        Me.txtNonBioCustomNday2.Text = "30"
        Me.txtNonBioCustomNday2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNonBioCustomReturn2
        '
        Me.txtNonBioCustomReturn2.Enabled = False
        Me.txtNonBioCustomReturn2.Location = New System.Drawing.Point(175, 110)
        Me.txtNonBioCustomReturn2.Name = "txtNonBioCustomReturn2"
        Me.txtNonBioCustomReturn2.Size = New System.Drawing.Size(49, 20)
        Me.txtNonBioCustomReturn2.TabIndex = 15
        Me.txtNonBioCustomReturn2.Text = "5"
        Me.txtNonBioCustomReturn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkNonBioCustom1
        '
        Me.chkNonBioCustom1.AutoSize = True
        Me.chkNonBioCustom1.Location = New System.Drawing.Point(6, 86)
        Me.chkNonBioCustom1.Name = "chkNonBioCustom1"
        Me.chkNonBioCustom1.Size = New System.Drawing.Size(61, 17)
        Me.chkNonBioCustom1.TabIndex = 10
        Me.chkNonBioCustom1.Text = "Custom"
        Me.chkNonBioCustom1.UseVisualStyleBackColor = True
        '
        'chkNonBioChronic
        '
        Me.chkNonBioChronic.AutoSize = True
        Me.chkNonBioChronic.Location = New System.Drawing.Point(6, 42)
        Me.chkNonBioChronic.Name = "chkNonBioChronic"
        Me.chkNonBioChronic.Size = New System.Drawing.Size(263, 17)
        Me.chkNonBioChronic.TabIndex = 9
        Me.chkNonBioChronic.Text = "Criterion continuous concentration (chronic, 7Q10)"
        Me.chkNonBioChronic.UseVisualStyleBackColor = True
        '
        'chkNonBioAcute
        '
        Me.chkNonBioAcute.AutoSize = True
        Me.chkNonBioAcute.Location = New System.Drawing.Point(6, 19)
        Me.chkNonBioAcute.Name = "chkNonBioAcute"
        Me.chkNonBioAcute.Size = New System.Drawing.Size(246, 17)
        Me.chkNonBioAcute.TabIndex = 8
        Me.chkNonBioAcute.Text = "Criterion maximum concentration (acute, 1Q10)"
        Me.chkNonBioAcute.UseVisualStyleBackColor = True
        '
        'lblNonBioReturn
        '
        Me.lblNonBioReturn.AccessibleDescription = "Return period on years with excursions (years)"
        Me.lblNonBioReturn.AutoSize = True
        Me.lblNonBioReturn.Location = New System.Drawing.Point(172, 67)
        Me.lblNonBioReturn.Name = "lblNonBioReturn"
        Me.lblNonBioReturn.Size = New System.Drawing.Size(39, 13)
        Me.lblNonBioReturn.TabIndex = 30
        Me.lblNonBioReturn.Text = "Return"
        '
        'txtNonBioCustomNday1
        '
        Me.txtNonBioCustomNday1.Enabled = False
        Me.txtNonBioCustomNday1.Location = New System.Drawing.Point(120, 84)
        Me.txtNonBioCustomNday1.Name = "txtNonBioCustomNday1"
        Me.txtNonBioCustomNday1.Size = New System.Drawing.Size(49, 20)
        Me.txtNonBioCustomNday1.TabIndex = 11
        Me.txtNonBioCustomNday1.Text = "30"
        Me.txtNonBioCustomNday1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNonBioCustomReturn1
        '
        Me.txtNonBioCustomReturn1.Enabled = False
        Me.txtNonBioCustomReturn1.Location = New System.Drawing.Point(175, 84)
        Me.txtNonBioCustomReturn1.Name = "txtNonBioCustomReturn1"
        Me.txtNonBioCustomReturn1.Size = New System.Drawing.Size(49, 20)
        Me.txtNonBioCustomReturn1.TabIndex = 12
        Me.txtNonBioCustomReturn1.Text = "5"
        Me.txtNonBioCustomReturn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNonBioNday
        '
        Me.lblNonBioNday.AutoSize = True
        Me.lblNonBioNday.Location = New System.Drawing.Point(117, 67)
        Me.lblNonBioNday.Name = "lblNonBioNday"
        Me.lblNonBioNday.Size = New System.Drawing.Size(37, 13)
        Me.lblNonBioNday.TabIndex = 29
        Me.lblNonBioNday.Text = "N-Day"
        '
        'chkHarmonicMean
        '
        Me.chkHarmonicMean.AutoSize = True
        Me.chkHarmonicMean.Checked = True
        Me.chkHarmonicMean.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHarmonicMean.Location = New System.Drawing.Point(4, 207)
        Me.chkHarmonicMean.Name = "chkHarmonicMean"
        Me.chkHarmonicMean.Size = New System.Drawing.Size(101, 17)
        Me.chkHarmonicMean.TabIndex = 20
        Me.chkHarmonicMean.Text = "Harmonic Mean"
        Me.chkHarmonicMean.UseVisualStyleBackColor = True
        '
        'tbNonBio3
        '
        Me.tbNonBio3.Enabled = False
        Me.tbNonBio3.Location = New System.Drawing.Point(120, 144)
        Me.tbNonBio3.Name = "tbNonBio3"
        Me.tbNonBio3.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio3.TabIndex = 17
        Me.tbNonBio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNonBio4
        '
        Me.tbNonBio4.Enabled = False
        Me.tbNonBio4.Location = New System.Drawing.Point(120, 170)
        Me.tbNonBio4.Name = "tbNonBio4"
        Me.tbNonBio4.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio4.TabIndex = 19
        Me.tbNonBio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNonBio2
        '
        Me.tbNonBio2.Enabled = False
        Me.tbNonBio2.Location = New System.Drawing.Point(327, 60)
        Me.tbNonBio2.Name = "tbNonBio2"
        Me.tbNonBio2.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio2.TabIndex = 9
        Me.tbNonBio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbNonBio2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(172, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "cfs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(172, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(268, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(226, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Return period on years with excursions (years):"
        Me.Label7.Visible = False
        '
        'tbNonBio1
        '
        Me.tbNonBio1.Enabled = False
        Me.tbNonBio1.Location = New System.Drawing.Point(275, 60)
        Me.tbNonBio1.Name = "tbNonBio1"
        Me.tbNonBio1.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio1.TabIndex = 5
        Me.tbNonBio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbNonBio1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(268, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Flow averaging period (days):"
        Me.Label8.Visible = False
        '
        'rbNonBio3
        '
        Me.rbNonBio3.AutoSize = True
        Me.rbNonBio3.Location = New System.Drawing.Point(271, 136)
        Me.rbNonBio3.Name = "rbNonBio3"
        Me.rbNonBio3.Size = New System.Drawing.Size(99, 17)
        Me.rbNonBio3.TabIndex = 3
        Me.rbNonBio3.Text = "Flow percentile:"
        Me.rbNonBio3.UseVisualStyleBackColor = True
        Me.rbNonBio3.Visible = False
        '
        'rbNonBio2
        '
        Me.rbNonBio2.AutoSize = True
        Me.rbNonBio2.Location = New System.Drawing.Point(271, 159)
        Me.rbNonBio2.Name = "rbNonBio2"
        Me.rbNonBio2.Size = New System.Drawing.Size(112, 17)
        Me.rbNonBio2.TabIndex = 2
        Me.rbNonBio2.Text = "Explicit flow value:"
        Me.rbNonBio2.UseVisualStyleBackColor = True
        Me.rbNonBio2.Visible = False
        '
        'rbNonBio1
        '
        Me.rbNonBio1.AutoSize = True
        Me.rbNonBio1.Checked = True
        Me.rbNonBio1.Location = New System.Drawing.Point(271, 113)
        Me.rbNonBio1.Name = "rbNonBio1"
        Me.rbNonBio1.Size = New System.Drawing.Size(83, 17)
        Me.rbNonBio1.TabIndex = 1
        Me.rbNonBio1.TabStop = True
        Me.rbNonBio1.Text = "Hydrological"
        Me.rbNonBio1.UseVisualStyleBackColor = True
        Me.rbNonBio1.Visible = False
        '
        'gbBio
        '
        Me.gbBio.Controls.Add(Me.chkBio3Amm)
        Me.gbBio.Controls.Add(Me.chkBio2Chronic)
        Me.gbBio.Controls.Add(Me.chkBio1Acute)
        Me.gbBio.Controls.Add(Me.rbBio3)
        Me.gbBio.Controls.Add(Me.rbBio2)
        Me.gbBio.Controls.Add(Me.rbBio1)
        Me.gbBio.Controls.Add(Me.tbBio3)
        Me.gbBio.Controls.Add(Me.tbBio4)
        Me.gbBio.Controls.Add(Me.tbBio2)
        Me.gbBio.Controls.Add(Me.Label4)
        Me.gbBio.Controls.Add(Me.Label3)
        Me.gbBio.Controls.Add(Me.Label2)
        Me.gbBio.Controls.Add(Me.tbBio1)
        Me.gbBio.Controls.Add(Me.Label1)
        Me.gbBio.Controls.Add(Me.ckbBio)
        Me.gbBio.Location = New System.Drawing.Point(8, 6)
        Me.gbBio.Name = "gbBio"
        Me.gbBio.Size = New System.Drawing.Size(419, 229)
        Me.gbBio.TabIndex = 5
        Me.gbBio.TabStop = False
        Me.gbBio.Text = "Biological Design Flow Parameters"
        '
        'chkBio3Amm
        '
        Me.chkBio3Amm.AutoSize = True
        Me.chkBio3Amm.Checked = True
        Me.chkBio3Amm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBio3Amm.Location = New System.Drawing.Point(6, 66)
        Me.chkBio3Amm.Name = "chkBio3Amm"
        Me.chkBio3Amm.Size = New System.Drawing.Size(103, 17)
        Me.chkBio3Amm.TabIndex = 2
        Me.chkBio3Amm.Text = "Ammonia (30B3)"
        Me.chkBio3Amm.UseVisualStyleBackColor = True
        '
        'chkBio2Chronic
        '
        Me.chkBio2Chronic.AutoSize = True
        Me.chkBio2Chronic.Checked = True
        Me.chkBio2Chronic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBio2Chronic.Location = New System.Drawing.Point(6, 43)
        Me.chkBio2Chronic.Name = "chkBio2Chronic"
        Me.chkBio2Chronic.Size = New System.Drawing.Size(256, 17)
        Me.chkBio2Chronic.TabIndex = 1
        Me.chkBio2Chronic.Text = "Criterion continuous concentration (chronic, 4B3)"
        Me.chkBio2Chronic.UseVisualStyleBackColor = True
        '
        'chkBio1Acute
        '
        Me.chkBio1Acute.AutoSize = True
        Me.chkBio1Acute.Checked = True
        Me.chkBio1Acute.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBio1Acute.Location = New System.Drawing.Point(6, 20)
        Me.chkBio1Acute.Name = "chkBio1Acute"
        Me.chkBio1Acute.Size = New System.Drawing.Size(239, 17)
        Me.chkBio1Acute.TabIndex = 0
        Me.chkBio1Acute.Text = "Criterion maximum concentration (acute, 1B3)"
        Me.chkBio1Acute.UseVisualStyleBackColor = True
        '
        'rbBio3
        '
        Me.rbBio3.AutoSize = True
        Me.rbBio3.Location = New System.Drawing.Point(290, 65)
        Me.rbBio3.Name = "rbBio3"
        Me.rbBio3.Size = New System.Drawing.Size(102, 17)
        Me.rbBio3.TabIndex = 3
        Me.rbBio3.Text = "Ammonia (30B3)"
        Me.rbBio3.UseVisualStyleBackColor = True
        Me.rbBio3.Visible = False
        '
        'rbBio2
        '
        Me.rbBio2.AutoSize = True
        Me.rbBio2.Location = New System.Drawing.Point(290, 42)
        Me.rbBio2.Name = "rbBio2"
        Me.rbBio2.Size = New System.Drawing.Size(255, 17)
        Me.rbBio2.TabIndex = 2
        Me.rbBio2.Text = "Criterion continuous concentration (chronic, 4B3)"
        Me.rbBio2.UseVisualStyleBackColor = True
        Me.rbBio2.Visible = False
        '
        'rbBio1
        '
        Me.rbBio1.AutoSize = True
        Me.rbBio1.Checked = True
        Me.rbBio1.Location = New System.Drawing.Point(290, 20)
        Me.rbBio1.Name = "rbBio1"
        Me.rbBio1.Size = New System.Drawing.Size(238, 17)
        Me.rbBio1.TabIndex = 1
        Me.rbBio1.TabStop = True
        Me.rbBio1.Text = "Criterion maximum concentration (acute, 1B3)"
        Me.rbBio1.UseVisualStyleBackColor = True
        Me.rbBio1.Visible = False
        '
        'tbBio3
        '
        Me.tbBio3.Location = New System.Drawing.Point(290, 163)
        Me.tbBio3.Name = "tbBio3"
        Me.tbBio3.Size = New System.Drawing.Size(46, 20)
        Me.tbBio3.TabIndex = 6
        Me.tbBio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio4
        '
        Me.tbBio4.Location = New System.Drawing.Point(290, 188)
        Me.tbBio4.Name = "tbBio4"
        Me.tbBio4.Size = New System.Drawing.Size(46, 20)
        Me.tbBio4.TabIndex = 7
        Me.tbBio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio2
        '
        Me.tbBio2.Location = New System.Drawing.Point(290, 138)
        Me.tbBio2.Name = "tbBio2"
        Me.tbBio2.Size = New System.Drawing.Size(46, 20)
        Me.tbBio2.TabIndex = 5
        Me.tbBio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Average number of excursions counted per cluster:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Length of excursion clustering period (days):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Average number of years between excursions:"
        '
        'tbBio1
        '
        Me.tbBio1.Location = New System.Drawing.Point(290, 113)
        Me.tbBio1.Name = "tbBio1"
        Me.tbBio1.Size = New System.Drawing.Size(46, 20)
        Me.tbBio1.TabIndex = 4
        Me.tbBio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Flow averaging period (days):"
        '
        'ckbBio
        '
        Me.ckbBio.AutoSize = True
        Me.ckbBio.Checked = True
        Me.ckbBio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbBio.Location = New System.Drawing.Point(6, 89)
        Me.ckbBio.Name = "ckbBio"
        Me.ckbBio.Size = New System.Drawing.Size(61, 17)
        Me.ckbBio.TabIndex = 3
        Me.ckbBio.Text = "Custom"
        Me.ckbBio.UseVisualStyleBackColor = True
        '
        'tabOutlier
        '
        Me.tabOutlier.Controls.Add(Me.btnOutliers)
        Me.tabOutlier.Controls.Add(Me.btnOTall)
        Me.tabOutlier.Controls.Add(Me.btnOTnone)
        Me.tabOutlier.Controls.Add(Me.btnOTCalculateStats)
        Me.tabOutlier.Controls.Add(Me.grdStations)
        Me.tabOutlier.Location = New System.Drawing.Point(4, 22)
        Me.tabOutlier.Name = "tabOutlier"
        Me.tabOutlier.Size = New System.Drawing.Size(464, 519)
        Me.tabOutlier.TabIndex = 4
        Me.tabOutlier.Text = "Group Outlier Test"
        Me.tabOutlier.UseVisualStyleBackColor = True
        '
        'btnOutliers
        '
        Me.btnOutliers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOutliers.Location = New System.Drawing.Point(354, 488)
        Me.btnOutliers.Name = "btnOutliers"
        Me.btnOutliers.Size = New System.Drawing.Size(102, 23)
        Me.btnOutliers.TabIndex = 36
        Me.btnOutliers.Text = "Detect Outliers"
        Me.btnOutliers.UseVisualStyleBackColor = True
        '
        'btnOTall
        '
        Me.btnOTall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOTall.Location = New System.Drawing.Point(60, 488)
        Me.btnOTall.Name = "btnOTall"
        Me.btnOTall.Size = New System.Drawing.Size(43, 23)
        Me.btnOTall.TabIndex = 35
        Me.btnOTall.Text = "All"
        Me.btnOTall.UseVisualStyleBackColor = True
        '
        'btnOTnone
        '
        Me.btnOTnone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOTnone.Location = New System.Drawing.Point(8, 488)
        Me.btnOTnone.Name = "btnOTnone"
        Me.btnOTnone.Size = New System.Drawing.Size(46, 23)
        Me.btnOTnone.TabIndex = 34
        Me.btnOTnone.Text = "None"
        Me.btnOTnone.UseVisualStyleBackColor = True
        '
        'btnOTCalculateStats
        '
        Me.btnOTCalculateStats.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOTCalculateStats.Location = New System.Drawing.Point(109, 488)
        Me.btnOTCalculateStats.Name = "btnOTCalculateStats"
        Me.btnOTCalculateStats.Size = New System.Drawing.Size(106, 23)
        Me.btnOTCalculateStats.TabIndex = 33
        Me.btnOTCalculateStats.Text = "Calculate Statistics"
        Me.btnOTCalculateStats.UseVisualStyleBackColor = True
        '
        'grdStations
        '
        Me.grdStations.AllowUserToAddRows = False
        Me.grdStations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelected, Me.colStationID, Me.colLat, Me.colLong, Me.colFrom, Me.colTo, Me.col7Q10, Me.colOutliers})
        Me.grdStations.Location = New System.Drawing.Point(0, 0)
        Me.grdStations.Name = "grdStations"
        Me.grdStations.RowHeadersVisible = False
        Me.grdStations.Size = New System.Drawing.Size(464, 482)
        Me.grdStations.TabIndex = 32
        '
        'colSelected
        '
        Me.colSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colSelected.HeaderText = ""
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Width = 5
        '
        'colStationID
        '
        Me.colStationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.colStationID.HeaderText = "Station ID"
        Me.colStationID.MaxInputLength = 16
        Me.colStationID.MinimumWidth = 8
        Me.colStationID.Name = "colStationID"
        Me.colStationID.ReadOnly = True
        Me.colStationID.Width = 8
        '
        'colLat
        '
        Me.colLat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.colLat.HeaderText = "Lat"
        Me.colLat.MaxInputLength = 16
        Me.colLat.Name = "colLat"
        Me.colLat.Width = 5
        '
        'colLong
        '
        Me.colLong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.colLong.HeaderText = "Long"
        Me.colLong.Name = "colLong"
        Me.colLong.Width = 5
        '
        'colFrom
        '
        Me.colFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colFrom.HeaderText = "From"
        Me.colFrom.Name = "colFrom"
        Me.colFrom.Width = 55
        '
        'colTo
        '
        Me.colTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colTo.HeaderText = "To"
        Me.colTo.Name = "colTo"
        Me.colTo.Width = 45
        '
        'col7Q10
        '
        Me.col7Q10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.col7Q10.HeaderText = "7Q10"
        Me.col7Q10.Name = "col7Q10"
        Me.col7Q10.Width = 58
        '
        'colOutliers
        '
        Me.colOutliers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colOutliers.HeaderText = "Is Outlier"
        Me.colOutliers.Name = "colOutliers"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'frmSWSTATmod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 547)
        Me.Controls.Add(Me.tabMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmSWSTATmod"
        Me.Text = "Integrated Design Flow"
        Me.tabMain.ResumeLayout(False)
        Me.tabSelectDates.ResumeLayout(False)
        Me.gbTextOutput.ResumeLayout(False)
        Me.gbTextOutput.PerformLayout()
        Me.grpHighLow.ResumeLayout(False)
        Me.grpHighLow.PerformLayout()
        Me.grpDates.ResumeLayout(False)
        Me.grpDates.PerformLayout()
        Me.grpYears.ResumeLayout(False)
        Me.grpYears.PerformLayout()
        Me.tabNDay.ResumeLayout(False)
        Me.tabNDay.PerformLayout()
        Me.groupGraph.ResumeLayout(False)
        Me.groupGraph.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.grpRecurrence.ResumeLayout(False)
        Me.grpRecurrence.PerformLayout()
        Me.grpNday.ResumeLayout(False)
        Me.grpNday.PerformLayout()
        Me.tabDFLOW.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbBio.ResumeLayout(False)
        Me.gbBio.PerformLayout()
        Me.tabOutlier.ResumeLayout(False)
        CType(Me.grdStations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'The group of atcTimeseries displayed
    Private WithEvents pDataGroup As atcTimeseriesGroup
    Private WithEvents pNDayGroup As atcTimeseriesGroup

    Private pDateFormat As New atcDateFormat

    'Value formatting options, can be overridden by timeseries attributes
    Private pMaxWidth As Integer = 10
    Private pFormat As String = "#,##0.########"
    Private pExpFormat As String = "#.#e#"
    Private pCantFit As String = "#"
    Private pSignificantDigits As Integer = 5

    'Private pDataAttributes As ArrayList
    Private pBasicAttributes As Generic.List(Of String)
    Private pNDayAttributes As Generic.List(Of String)
    Private pTrendAttributes As Generic.List(Of String)

    Private pYearStartMonth As Integer = 0
    Private pYearStartDay As Integer = 0
    Private pYearEndMonth As Integer = 0
    Private pYearEndDay As Integer = 0
    Private pFirstYear As Integer = 0
    Private pLastYear As Integer = 0

    Private pCommonStart As Double = GetMinValue()
    Private pCommonEnd As Double = GetMaxValue()

    Private Const pNoDatesInCommon As String = ": No dates in common"

    Public Event ParametersSet(ByVal aArgs As atcDataAttributes)
    Private pAttributes As atcDataAttributes
    Private pSetGlobal As Boolean = False
    Private pBatch As Boolean = False

    Private Shared pLastDayOfMonth() As Integer = {99, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

    Private pDFLOWScenarios As atcCollection 'a collection of InteractiveDFLOW class objects

    Private pSW As New Stopwatch()

    Private Sub mnuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click
        If Application.ProductName = "USGSHydroToolbox" Then
            ShowHelp("SW Tools/USGS Integrated Design Flow (IDF)/Interactive.html")
        Else
            ShowHelp("BASINS Details\Analysis\USGS Surface Water Statistics.html")
        End If
    End Sub

    Private Sub PopulateForm()
        pDateFormat = New atcDateFormat
        With pDateFormat
            .IncludeHours = False
            .IncludeMinutes = False
            .IncludeSeconds = False
        End With

        Dim lhighlowsetting As String = GetSetting("atcFrequencyGrid", "Defaults", "HighOrLow", "none")
        If lhighlowsetting = "High" Then
            radioHigh.Checked = True
        Else
            radioLow.Checked = True
        End If

        chkLog.Checked = (GetSetting("atcFrequencyGrid", "Defaults", "Logarithmic", "True") = "True")

        LoadListSettingsOrDefaults(lstNday)
        LoadListSettingsOrDefaults(lstRecurrence)
        RepopulateForm()
    End Sub

    Private Sub PopulateForm(ByVal attribs As atcDataAttributes)
        pDateFormat = New atcDateFormat
        With pDateFormat
            .IncludeHours = False
            .IncludeMinutes = False
            .IncludeSeconds = False
        End With

        Dim lHighLow As String = attribs.GetValue(InputNames.HighLow, "")
        If lHighLow.ToLower = "high" Then
            radioHigh.Checked = True
        Else
            radioLow.Checked = True
        End If

        chkLog.Checked = attribs.GetValue(InputNames.Logarithmic, True)
        chkMultipleNDayPlots.Checked = attribs.GetValue(InputNames.MultiNDayPlot, False)
        chkMultipleStationPlots.Checked = attribs.GetValue(InputNames.MultiStationPlot, False)
        Dim lOutDir As String = attribs.GetValue(InputNames.OutputDir, "")
        If IO.Directory.Exists(lOutDir) Then
            txtOutputDir.Text = lOutDir
        End If
        Dim lPrefix As String = attribs.GetValue(InputNames.OutputPrefix, "")
        txtOutputRootName.Text = lPrefix

        LoadListSettingsOrDefaults(lstNday, attribs)
        LoadListSettingsOrDefaults(lstRecurrence, attribs)
        RepopulateForm()
    End Sub

    Private Sub RepopulateForm()
        SeasonsYearsToForm()

        Dim lFirstDate As Double = GetMaxValue()
        Dim lLastDate As Double = GetMinValue()

        pCommonStart = GetMinValue()
        pCommonEnd = GetMaxValue()

        Dim lHaveAnnual As Boolean = False
        Dim lAnnualIsHigh As Boolean = False
        Dim lAnnualIsLow As Boolean = False
        Dim lAnnualNday As Integer = 0

        Dim lAttr_loc As String
        Dim lAttr_Lat As Double
        Dim lAttr_Long As Double
        Dim lAttr_From As String
        Dim lAttr_To As String
        Dim lAttr_Stat As Double
        Dim lAttr_Lat_str As String
        Dim lAttr_Long_str As String
        Dim lDate(5) As Integer
        For Each lDataset As atcData.atcTimeseries In pDataGroup
            If lDataset.Dates.numValues > 0 Then
                Dim lThisDate As Double = lDataset.Dates.Value(1)
                If lThisDate < lFirstDate Then lFirstDate = lThisDate
                If lThisDate > pCommonStart Then pCommonStart = lThisDate
                lThisDate = lDataset.Dates.Value(lDataset.Dates.numValues)
                If lThisDate > lLastDate Then lLastDate = lThisDate
                If lThisDate < pCommonEnd Then pCommonEnd = lThisDate

                If lDataset.Attributes.GetValue("Tu", atcTimeUnit.TUDay) = atcTimeUnit.TUYear Then
                    lHaveAnnual = True
                    Dim lConstituent As String = lDataset.Attributes.GetValue("Constituent", "")
                    If lConstituent.Length < 4 Then
                        Logger.Msg("Dataset #" & lDataset.Attributes.GetValue("ID", "") & " " & lDataset.ToString,
                                   "Annual Dataset Missing Constituent")
                    Else
                        Select Case lConstituent.Substring(0, 1).ToUpper
                            Case "L" : lAnnualIsLow = True
                            Case "H" : lAnnualIsHigh = True
                            Case Else
                                Logger.Msg("Dataset #" & lDataset.Attributes.GetValue("ID", "") & " " & lDataset.ToString,
                                           "Annual Dataset Constituent does not start with L or H")
                        End Select
                        Dim lNday As Integer
                        If Integer.TryParse(lConstituent.Substring(1), lNday) Then
                            If lAnnualNday = 0 Then
                                lAnnualNday = lNday
                            ElseIf lAnnualNday <> lNday Then
                                Logger.Msg("Annual datasets with different N-Day cannot be analyzed at the same time." & vbCrLf _
                                           & "N-Day values of both " & lAnnualNday & " and " & lNday & " were found.",
                                           "Incompatible Annual Data Selected")
                            End If
                        End If
                    End If
                End If

                'populate the outlier test tab station listing
                With lDataset.Attributes
                    lAttr_loc = .GetValue("Location", "")
                    lAttr_Lat = .GetValue("Latitude", 0)
                    lAttr_Lat_str = DoubleToString(lAttr_Lat, 15, "0.##########", aSignificantDigits:=8)
                    lAttr_Long = .GetValue("Longitude", 0)
                    lAttr_Long_str = DoubleToString(lAttr_Long, 15, "0.##########", aSignificantDigits:=8)
                    lAttr_From = pDateFormat.JDateToString(lDataset.Dates.Value(0))
                    lAttr_To = pDateFormat.JDateToString(lDataset.Dates.Value(lDataset.Dates.numValues))
                End With
                grdStations.Rows.Add(False, lAttr_loc, lAttr_Lat_str, lAttr_Long_str, lAttr_From, lAttr_To, "")
            End If
        Next

        grpHighLow.Enabled = True
        grpNday.Enabled = True
        If lHaveAnnual Then
            If lAnnualIsLow <> lAnnualIsHigh Then
                radioHigh.Checked = lAnnualIsHigh
                radioLow.Checked = Not lAnnualIsHigh
                grpHighLow.Enabled = False
            Else
                If lAnnualIsLow Then
                    Logger.Msg("Low and high annual datasets cannot be analyzed at the same time",
                               "Incompatible Annual Data Selected")
                End If
            End If

            If lAnnualNday > 0 Then
                lstNday.ClearSelected()
                SelectNday(lAnnualNday)
                grpNday.Enabled = False
            End If
        End If

        If lFirstDate < GetMaxValue() AndAlso lLastDate > GetMinValue() Then
            lblDataStart.Text = lblDataStart.Tag & " " & pDateFormat.JDateToString(lFirstDate)
            lblDataEnd.Text = lblDataEnd.Tag & " " & pDateFormat.JDateToString(lLastDate)
            radioYearsAll.Text = "All: " & pDateFormat.JDateToString(lFirstDate) & " to " & pDateFormat.JDateToString(lLastDate)
            radioYearsAll.Enabled = True
        Else
            If radioYearsAll.Checked Then
                radioYearsAll.Checked = False
                radioYearsCustom.Checked = True
            End If
            radioYearsAll.Enabled = False
        End If

        If pCommonStart > GetMinValue() AndAlso pCommonEnd < GetMaxValue() AndAlso pCommonStart < pCommonEnd Then
            radioYearsCommon.Text = "Common: " & pDateFormat.JDateToString(pCommonStart) & " to " & pDateFormat.JDateToString(pCommonEnd)
            radioYearsCommon.Enabled = True
        Else
            radioYearsCommon.Text = "Common" & pNoDatesInCommon
            If radioYearsCommon.Checked Then
                radioYearsCommon.Checked = False
                radioYearsCustom.Checked = True
            End If
            radioYearsCommon.Enabled = False
        End If

        If radioYearsAll.Checked Then
            radioYearsAll_CheckedChanged(Nothing, Nothing)
        ElseIf radioYearsCustom.Checked Then
            'No need to change it
        ElseIf radioYearsCommon.Checked Then
            radioYearsCommon_CheckedChanged(Nothing, Nothing)
        Else
            radioYearsCommon.Checked = True
        End If
    End Sub

    Private Sub LoadListSettingsOrDefaults(ByVal lst As System.Windows.Forms.ListBox)
        Dim lArgName As String = lst.Tag
        Dim lAvailableArray As String(,) = GetAllSettings("atcFrequencyGrid", "List." & lArgName)
        Dim lSelected As New ArrayList
        lst.Items.Clear()

        If Not lAvailableArray Is Nothing AndAlso lAvailableArray.Length > 0 Then
            Try
                For lIndex As Integer = 0 To lAvailableArray.GetUpperBound(0)
                    lst.Items.Add(lAvailableArray(lIndex, 0))
                    If lAvailableArray(lIndex, 1) = "True" Then
                        lst.SetSelected(lst.Items.Count - 1, True)
                    End If
                Next
            Catch e As Exception
                Logger.Dbg("Error retrieving saved settings: " & e.Message)
            End Try
        Else
            LoadListDefaults(lst)
        End If
    End Sub

    Private Sub LoadListSettingsOrDefaults(ByVal lst As System.Windows.Forms.ListBox, ByVal attribs As atcDataAttributes)
        Dim lArgName As String = lst.Tag & "s"
        Dim listing As atcCollection = attribs.GetValue(lArgName, Nothing)
        If listing Is Nothing Then
            Exit Sub
        End If

        Dim lSelected As New ArrayList
        lst.Items.Clear()

        If listing.Count > 0 Then
            Try
                For lIndex As Integer = 0 To listing.Count - 1
                    lst.Items.Add(listing.Keys(lIndex))
                    If listing.ItemByIndex(lIndex) Then
                        lst.SetSelected(lst.Items.Count - 1, True)
                    End If
                Next
            Catch e As Exception
                Logger.Dbg("Error retrieving " & lArgName & " settings: " & e.Message)
            End Try
        Else
            LoadListDefaults(lst)
        End If
    End Sub

    Private Sub frmSWSTAT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = System.Windows.Forms.Keys.F1 Then
            If Application.ProductName = "USGSHydroToolbox" Then
                ShowHelp("SW Tools/USGS Integrated Design Flow (IDF)/Interactive.html")
            Else
                ShowHelp("BASINS Details\Analysis\USGS Surface Water Statistics.html")
            End If
        End If
    End Sub

    Public Sub Initialize(Optional ByVal aTimeseriesGroup As atcData.atcTimeseriesGroup = Nothing,
                          Optional ByVal aBasicAttributes As Generic.List(Of String) = Nothing,
                          Optional ByVal aNDayAttributes As Generic.List(Of String) = Nothing,
                          Optional ByVal aTrendAttributes As Generic.List(Of String) = Nothing,
                          Optional ByVal aShowForm As Boolean = True)

        If aTimeseriesGroup Is Nothing Then
            pDataGroup = New atcTimeseriesGroup
        Else
            pDataGroup = aTimeseriesGroup
        End If

        If aBasicAttributes Is Nothing OrElse aBasicAttributes.Count < 1 Then
            pBasicAttributes = atcDataManager.DisplayAttributes
        Else
            pBasicAttributes = aBasicAttributes
        End If

        If aNDayAttributes Is Nothing Then
            pNDayAttributes = atcDataManager.DisplayAttributes
        Else
            pNDayAttributes = aNDayAttributes
        End If

        If aTrendAttributes Is Nothing Then
            pTrendAttributes = atcDataManager.DisplayAttributes
        Else
            pTrendAttributes = aTrendAttributes
        End If

        If pDFLOWScenarios Is Nothing Then
            pDFLOWScenarios = New atcCollection()
        End If

        If aShowForm Then
            Dim DisplayPlugins As ICollection = atcDataManager.GetPlugins(GetType(atcDataDisplay))
            For Each lDisp As atcDataDisplay In DisplayPlugins
                Dim lMenuText As String = lDisp.Name
                If lMenuText <> "Analysis::USGS Surface Water Statistics (SWSTAT)::Integrated Frequency Analysis" Then
                    If lMenuText.StartsWith("Analysis::") Then lMenuText = lMenuText.Substring(10)
                    mnuAnalysis.MenuItems.Add(lMenuText, New EventHandler(AddressOf mnuAnalysis_Click))
                End If
            Next
        End If

        If pDataGroup.Count = 0 Then 'ask user to specify some timeseries
            pDataGroup = atcDataManager.UserSelectData("Select Data for Integrated Frequency Analysis",
                                                       pDataGroup, Nothing, True, True, Me.Icon)
        End If
        'Ensure STAID is set in all timeseries
        For Each lTs As atcTimeseries In pDataGroup
            Logger.Dbg("IDF: station " & STAID(lTs))
        Next
        DFLOWCalcs_Initialize()
        If pDataGroup.Count > 0 Then
            PopulateForm()
            PopulateDFLOW(pDataGroup)
            If aShowForm Then Me.Show()
        Else 'user declined to specify timeseries
            Me.Close()
        End If

    End Sub

    Public Sub Initialize(ByVal aTimeseriesGroup As atcData.atcTimeseriesGroup,
                          ByVal attributes As atcDataAttributes)

        'Optional ByVal aBasicAttributes As Generic.List(Of String) = Nothing, _
        'Optional ByVal aNDayAttributes As Generic.List(Of String) = Nothing, _
        'Optional ByVal aTrendAttributes As Generic.List(Of String) = Nothing, _
        'Optional ByVal aShowForm As Boolean = True
        DFLOWCalcs_Initialize(attributes)
        If aTimeseriesGroup Is Nothing Then
            pDataGroup = New atcTimeseriesGroup
        Else
            pDataGroup = aTimeseriesGroup
        End If

        pAttributes = attributes

        If pDFLOWScenarios Is Nothing Then
            pDFLOWScenarios = New atcCollection()
        End If
        pBatch = True
        Dim loperation As String = attributes.GetValue("Operation", "")
        If loperation.ToLower = "globalsetparm" Then
            pSetGlobal = True
            btnDoFrequencyGrid.Text = "Set Global Parameters"
            Me.Text &= " -Batch Run Global Default Parameter Setup"

        Else
            pSetGlobal = False
            btnDoFrequencyGrid.Text = "Set Group Parameters"
            Dim lGroupname As String = attributes.GetValue("group", "")
            Me.Text &= " -Batch Run Group (" & lGroupname & ") Parameter Setup"
        End If
        btnNDay.Visible = False
        btnDisplayTrend.Visible = False
        btnDisplayBasic.Visible = False
        btnDoFrequencyGraph.Visible = False
        gbTextOutput.Visible = True

        PopulateForm(attributes)
        PopulateDFLOW(pDataGroup)
        Me.Show()
    End Sub

    Public Property DateFormat() As atcDateFormat
        Get
            Return pDateFormat
        End Get
        Set(ByVal newValue As atcDateFormat)
            pDateFormat = newValue
        End Set
    End Property

    Private Sub mnuAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnalysis.Click
        atcDataManager.ShowDisplay(sender.Text, pDataGroup, Me.Icon)
    End Sub

    Private Sub pDataGroup_Added(ByVal aAdded As atcCollection) Handles pDataGroup.Added
        If Me.Visible Then RepopulateForm()
        'TODO: could efficiently insert newly added item(s)
    End Sub

    Private Sub pDataGroup_Removed(ByVal aRemoved As atcCollection) Handles pDataGroup.Removed
        If Me.Visible Then RepopulateForm()
        'TODO: could efficiently remove by serial number
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        pDataGroup = Nothing
    End Sub

    Private Sub mnuFileSelectData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSelectData.Click
        atcDataManager.UserSelectData("Select Data for Integrated Frequency Analysis",
                                      pDataGroup, Nothing, False, True, Me.Icon)
    End Sub

    Private Sub SeasonsYearsToForm()
        If cboStartMonth.Items.Count > 0 Then
            cboStartMonth.SelectedIndex = pYearStartMonth - 1
            cboEndMonth.SelectedIndex = pYearEndMonth - 1
            If pYearStartDay > 0 Then txtStartDay.Text = pYearStartDay Else txtStartDay.Text = ""
            If pYearEndDay > 0 Then txtEndDay.Text = pYearEndDay Else txtEndDay.Text = ""
            If pFirstYear > 0 Then txtOmitBeforeYear.Text = pFirstYear Else txtOmitBeforeYear.Text = ""
            If pLastYear > 0 Then txtOmitAfterYear.Text = pLastYear Else txtOmitAfterYear.Text = ""
            If pFirstYear > 0 OrElse pLastYear > 0 Then
                ShowCustomYears(True)
            End If
        End If
    End Sub

    Private Function SeasonsYearsFromFormBatch() As String
        pYearStartMonth = cboStartMonth.SelectedIndex + 1
        pYearEndMonth = cboEndMonth.SelectedIndex + 1
        If IsNumeric(txtStartDay.Text) Then
            pYearStartDay = Math.Min(CInt(txtStartDay.Text), DayMon(1901, pYearStartMonth))
            txtStartDay.Text = pYearStartDay
        Else
            pYearStartDay = 0
        End If
        If IsNumeric(txtEndDay.Text) Then
            pYearEndDay = Math.Min(CInt(txtEndDay.Text), DayMon(1901, pYearEndMonth))
            txtEndDay.Text = pYearEndDay
        Else
            pYearEndDay = 0
        End If
        If IsNumeric(txtOmitBeforeYear.Text) Then
            pFirstYear = CInt(txtOmitBeforeYear.Text)
        Else
            pFirstYear = 0
        End If
        If IsNumeric(txtOmitAfterYear.Text) Then
            pLastYear = CInt(txtOmitAfterYear.Text)
        Else
            pLastYear = 0
        End If
        Dim lMsg As String = SaveSettingsBatch()
        Return lMsg
    End Function

    Private Function IsSeasonal() As String
        Dim lName As String = GetSetting("atcFrequencyGrid", "Defaults", "HighOrLow", "")
        If String.IsNullOrEmpty(lName) Then
            Return "high low not defined"
        End If
        Dim lYearStartMonth As Integer = GetSetting("atcFrequencyGrid", "StartMonth", lName, -1)
        Dim lYearStartDay As Integer = GetSetting("atcFrequencyGrid", "StartDay", lName, -1)
        Dim lYearEndMonth As Integer = GetSetting("atcFrequencyGrid", "EndMonth", lName, -1)
        Dim lYearEndDay As Integer = GetSetting("atcFrequencyGrid", "EndDay", lName, -1)
        If lYearStartMonth < 0 OrElse lYearStartDay < 0 OrElse lYearEndMonth < 0 OrElse lYearEndDay < 0 Then
            Return "month or day not defined"
        End If
        If lYearStartMonth - 1 = lYearEndMonth OrElse (lYearStartMonth = 1 And lYearEndMonth = 12) Then
            If lYearEndDay = DayMon(1901, lYearEndMonth) OrElse lYearEndDay = DayMon(2000, lYearEndMonth) Then
                If lYearStartDay = 1 Then
                    Return "not seasonal"
                End If
            End If
        End If
        Return "seasonal"
    End Function

    Private Sub SeasonsYearsFromForm()
        pYearStartMonth = cboStartMonth.SelectedIndex + 1
        pYearEndMonth = cboEndMonth.SelectedIndex + 1
        If IsNumeric(txtStartDay.Text) Then
            pYearStartDay = Math.Min(CInt(txtStartDay.Text), DayMon(1901, pYearStartMonth))
            txtStartDay.Text = pYearStartDay
        Else
            pYearStartDay = 0
        End If
        If IsNumeric(txtEndDay.Text) Then
            pYearEndDay = Math.Min(CInt(txtEndDay.Text), DayMon(1901, pYearEndMonth))
            txtEndDay.Text = pYearEndDay
        Else
            pYearEndDay = 0
        End If
        If IsNumeric(txtOmitBeforeYear.Text) Then
            pFirstYear = CInt(txtOmitBeforeYear.Text)
        Else
            pFirstYear = 0
        End If
        If IsNumeric(txtOmitAfterYear.Text) Then
            pLastYear = CInt(txtOmitAfterYear.Text)
        Else
            pLastYear = 0
        End If
        SaveSettings()
    End Sub

    Private Sub ShowCustomYears(ByVal aShowCustom As Boolean)
        'cboYears.Visible = Not aShowCustom
        txtOmitBeforeYear.Enabled = aShowCustom
        txtOmitAfterYear.Enabled = aShowCustom
        lblDataStart.Enabled = aShowCustom
        lblDataEnd.Enabled = aShowCustom
        lblOmitBefore.Enabled = aShowCustom
        lblOmitAfter.Enabled = aShowCustom
    End Sub

    'Return all selected items, or if none are selected then all items
    Private Function ListToArray(ByVal aList As System.Windows.Forms.ListBox) As Double()
        Dim lArray() As Double
        Dim lCollection As New ArrayList
        If aList.SelectedItems.Count > 0 Then
            For lIndex As Integer = 0 To aList.SelectedItems.Count - 1
                If IsNumeric(aList.SelectedItems(lIndex)) Then
                    lCollection.Add(CDbl(aList.SelectedItems(lIndex)))
                End If
            Next
        Else
            For lIndex As Integer = 0 To aList.Items.Count - 1
                If IsNumeric(aList.Items(lIndex)) Then
                    lCollection.Add(CDbl(aList.Items(lIndex)))
                End If
            Next
        End If
        ReDim lArray(lCollection.Count - 1)
        For lIndex As Integer = 0 To lCollection.Count - 1
            lArray(lIndex) = lCollection.Item(lIndex)
        Next
        Return lArray
    End Function

    Private Function SelectedData() As atcTimeseriesGroup
        Dim lDataGroupB As New atcTimeseriesGroup
        Dim lTsB As atcTimeseries
        SeasonsYearsFromForm()

        For Each lTs As atcTimeseries In pDataGroup
            If lTs.Attributes.GetValue("Time Unit") = atcTimeUnit.TUYear Then
                lTsB = lTs
            Else
                If pFirstYear > 0 AndAlso pLastYear > 0 Then
                    lTsB = SubsetByDateBoundary(lTs, pYearStartMonth, pYearStartDay, Nothing, pFirstYear, pLastYear, pYearEndMonth, pYearEndDay)
                Else
                    lTsB = lTs
                End If

                Dim lSeasons As New atcSeasonsYearSubset(pYearStartMonth, pYearStartDay, pYearEndMonth, pYearEndDay)
                lSeasons.SeasonSelected(0) = True
                lTsB = lSeasons.SplitBySelected(lTsB, Nothing).ItemByIndex(1)
                lTsB.Attributes.SetValue("ID", lTs.OriginalParentID)
                If lTs.Attributes.ContainsAttribute("SeasonName") Then
                    lTsB.Attributes.SetValue("SeasonName", lTs.Attributes.GetValue("SeasonName"))
                Else
                    lTsB.Attributes.RemoveByKey("SeasonName")
                End If
            End If
            lDataGroupB.Add(lTsB)
        Next

        Return lDataGroupB
    End Function

    Private Sub btnDisplayBasic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayBasic.Click
        Dim lList As New atcList.atcListForm

        With lList
            .Text = "Basic Statistics"
            Dim lSelectedData As atcTimeseriesGroup = SelectedData()
            AddSeasonNameIfNeeded(pBasicAttributes, lSelectedData)
            .Initialize(lSelectedData, pBasicAttributes, False, , )
            .Width = 600
            .SwapRowsColumns = True
            .Icon = Me.Icon
        End With

        'Code section is to print out Text format of Basic Statistics, leave to remind how formatting is working to get 
        '     at the precise formatting in a SWSTAT format table
        '
        'Dim lselectedData As atcDataGroup = SelectedData()
        'Dim lfrmReport As New frmTextReport
        'lfrmReport.Title = "Basic Flow Statistics"

        'lfrmReport.ReportBody = "  DATA-                                                     NUMBER      NON-ZERO" & vbCrLf
        'lfrmReport.ReportBody &= "   SET                                        STANDARD   OF DATA VALUES RETURNS" & vbCrLf
        'lfrmReport.ReportBody &= " NUMBER    MINIMUM     MAXIMUM        MEAN   DEVIATION     USED  UNUSED CODE  NO." & vbCrLf
        'lfrmReport.ReportBody &= " ------ ---------- ----------- ----------- -----------  ------- ------- ---- ---" & vbCrLf

        'Dim lTemp As Double = 0.0
        'Dim lTSstats As New ArrayList()
        'If lselectedData.Count > 0 Then
        '    For Each aTS As atcTimeseries In lselectedData

        '        lTSstats = TSStats(aTS)

        '        lfrmReport.ReportBody &= CStr(aTS.Attributes.GetValue("ID")).PadLeft(6)
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(0), , 3, 6, False).PadLeft(13) 'min
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(1), , 3, 6, False).PadLeft(12) 'max
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(2), , 3, 6, False).PadLeft(12) 'mean
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(3), , 3, 6, False).PadLeft(12) 'lstdev
        '        lfrmReport.ReportBody &= CStr(lTSstats(4)).PadLeft(8) 'used
        '        lfrmReport.ReportBody &= CStr(lTSstats(5)).PadLeft(8) 'unused
        '        lfrmReport.ReportBody &= vbCrLf

        '    Next
        'Else
        'Logger.Msg("Select at least one time series")
        'End If

        'lfrmReport.displayReport()

    End Sub

    'Private Function TSStats(ByVal aTS As atcTimeseries) As ArrayList

    '    Dim lmean As Double
    '    Dim lmin As Double
    '    Dim lmax As Double
    '    Dim lstdev As Double
    '    Dim lUsed As Integer
    '    Dim lTotalCount As Integer
    '    Dim lSum As Double
    '    Dim lUnused As Integer
    '    Dim lSS As Double

    '    Dim lusedVals As New ArrayList()
    '    Dim lStats As New ArrayList()

    '    lmin = Double.MaxValue
    '    lmax = Double.MinValue
    '    For Each lVal As Double In aTS.Values
    '        lTotalCount += 1
    '        If lVal > 0 Then
    '            lUsed += 1
    '            lSum += lVal
    '            lusedVals.Add(lVal)
    '            If lVal > lmax Then
    '                lmax = lVal
    '            End If
    '            If lVal < lmin Then
    '                lmin = lVal
    '            End If
    '        End If
    '    Next

    '    lmean = lSum / lUsed
    '    lUnused = lTotalCount - lUsed

    '    For Each lVal As Double In lusedVals
    '        lSS += (lVal - lmean) ^ 2
    '    Next

    '    lstdev = Math.Sqrt(lSS / lUsed)

    '    lStats.Add(lmin)
    '    lStats.Add(lmax)
    '    lStats.Add(lmean)
    '    lStats.Add(lstdev)
    '    lStats.Add(lUsed)
    '    lStats.Add(lUnused)

    '    Return lStats

    'End Function

    Private Sub btnNDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNDay.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim lSelectedData As atcTimeseriesGroup = SelectedData()
        If lSelectedData.Count > 0 Then
            If lstNday.SelectedIndices.Count > 0 Then
                Dim lRankedAnnual As atcTimeseriesGroup =
                   clsIDFPlugin.ComputeRankedAnnualTimeseries(aTimeseriesGroup:=lSelectedData,
                                                                 aNDay:=ListToArray(lstNday), aHighFlag:=radioHigh.Checked,
                                                                 aFirstYear:=pFirstYear, aLastYear:=pLastYear,
                                                                 aBoundaryMonth:=pYearStartMonth, aBoundaryDay:=pYearStartDay,
                                                                 aEndMonth:=pYearEndMonth, aEndDay:=pYearEndDay)
                If lRankedAnnual.Count > 0 Then
                    Dim lHeaders As New Generic.List(Of String)()
                    lHeaders.Add("Year")
                    For Each lTS As atcTimeseries In lRankedAnnual
                        lTS.Attributes.SetValue("Units", "Common")
                        lHeaders.Add(lTS.Attributes.GetValue("Constituent", "Value"))
                    Next

                    Dim lList As New atcList.atcListForm
                    With lList
                        With .DateFormat
                            .IncludeDays = False
                            .IncludeHours = False
                            .IncludeMinutes = False
                            .IncludeMonths = False
                        End With
                        .Text = "N-Day " & HighOrLowString() & " Annual Time Series and Ranking"
                        AddSeasonNameIfNeeded(pNDayAttributes, lRankedAnnual)
                        .Initialize(lRankedAnnual.Clone, pNDayAttributes, True,,, lHeaders)
                        .DisplayValueAttributes = True
                        .Icon = Me.Icon
                    End With
                End If
            Else
                Logger.Msg("Select at least one number of days")
            End If
        Else
            Logger.Msg("Select at least one time series")
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnNdayAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayAdd.Click
        AddNday(txtNdayAdd.Text)
    End Sub

    Private Sub AddNday(ByVal aNday As String)
        If IsNumeric(aNday) Then
            Try
                Dim lIndex As Integer = 0
                Dim lNewValue As Double = CDbl(aNday)
                While lIndex < lstNday.Items.Count AndAlso CDbl(lstNday.Items(lIndex)) < lNewValue
                    lIndex += 1
                End While
                lstNday.Items.Insert(lIndex, aNday)
                lstNday.SetSelected(lIndex, True)
            Catch ex As Exception
                Logger.Dbg("Exception adding N-day '" & aNday & "': " & ex.Message)
            End Try
        Else
            Logger.Msg("Non-numeric value '" & aNday & "' could not be added to N-Day list")
        End If
    End Sub

    Private Sub SelectNday(ByVal aNday As String)
        If Not lstNday.Items.Contains(aNday) Then
            AddNday(aNday)
        End If
        For lNdayIndex As Integer = 0 To lstNday.Items.Count - 1
            If CInt(lstNday.Items(lNdayIndex)) = aNday Then
                lstNday.SelectedIndex = lNdayIndex
                Exit For
            End If
        Next
    End Sub

    Private Sub btnNdayRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayRemove.Click
        Dim lRemoveThese As New ArrayList
        Dim lIndex As Integer
        If lstNday.SelectedIndices.Count > 0 Then
            For lIndex = lstNday.SelectedIndices.Count - 1 To 0 Step -1
                lRemoveThese.Add(lstNday.SelectedIndices.Item(lIndex))
            Next
        Else
            For lIndex = lstNday.Items.Count - 1 To 0 Step -1
                If lstNday.Items(lIndex) = txtNdayAdd.Text Then
                    lRemoveThese.Add(lIndex)
                End If
            Next
        End If

        For Each lIndex In lRemoveThese
            lstNday.Items.RemoveAt(lIndex)
        Next
    End Sub

    Private Sub btnNdayDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayDefault.Click
        LoadListDefaults(lstNday)
    End Sub

    Private Sub LoadListDefaults(ByVal aList As System.Windows.Forms.ListBox)
        Dim lDefault() As Double = clsIDFPlugin.ListDefaultArray(aList.Tag)
        If Not lDefault Is Nothing Then
            aList.Items.Clear()
            For Each lNumber As Double In lDefault
                Dim lLabel As String = Format(lNumber, "0.####")
                aList.Items.Add(lLabel)
            Next
        End If
    End Sub

    ''' <summary>Calculate aOperationName: "n-day "  HighOrLowString()  " value"
    ''' aReturnPeriods() = ListToArray(lstRecurrence)
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalculateBatch()
        If Not pSetGlobal AndAlso pDataGroup IsNot Nothing Then ClearAttributes()
        Dim lMsg As String = SeasonsYearsFromFormBatch()
        If Not String.IsNullOrEmpty(lMsg) Then
            Logger.Msg("Please address the following issues before proceeding:" & vbCrLf & vbCrLf & lMsg, MsgBoxStyle.Information, "Input Needs Correction")
            Exit Sub
        Else
            If pSetGlobal Then
                Logger.MsgCustomOwned("Parameters are set for Global Defaults.", "USGS Batch Processing", Me, New String() {"OK"})
                Me.Close()
            Else
                Dim lGroup As String = pAttributes.GetValue("Group", "")
                Logger.MsgCustomOwned("Group Parameters are set for " & lGroup, "USGS Batch Processing", Me, New String() {"OK"})
                Me.Close()
            End If
        End If
        RaiseEvent ParametersSet(pAttributes)
    End Sub

    Private Sub Calculate(ByVal aOperationName As String, ByVal aReturnPeriods() As Double, Optional ByVal aNDays() As Double = Nothing, Optional aDataGroup As atcTimeseriesGroup = Nothing)
        ClearAttributes()
        SeasonsYearsFromForm() 'setup all inputs from form
        Dim lArgs As atcDataAttributes = SetOperationConditions(aOperationName, aReturnPeriods, aNDays, aDataGroup)
        Dim lCalculator As New atcTimeseriesNdayHighLow.atcTimeseriesNdayHighLow
        lCalculator.Open(aOperationName, lArgs)
        lCalculator.DataSets.Clear()
    End Sub

    ''' <summary>
    ''' This routine isolates the construction of operation conditions based on user form selections
    ''' hence, it is to be used AFTER ClearAttributes(), SeasonsYearsFromForm() tandem calls
    ''' </summary>
    ''' <param name="aOperationName"></param>
    ''' <param name="aReturnPeriods"></param>
    ''' <param name="aNDays"></param>
    ''' <param name="aDataGroup"></param>
    ''' <returns></returns>
    Private Function SetOperationConditions(ByVal aOperationName As String, ByVal aReturnPeriods() As Double, Optional ByVal aNDays() As Double = Nothing, Optional aDataGroup As atcTimeseriesGroup = Nothing) As atcDataAttributes
        For Each lTs As atcTimeseries In pDataGroup
            lTs.Attributes.SetValueIfMissing("CalcEMA", True)
        Next
        Dim lArgs As New atcDataAttributes
        If aDataGroup Is Nothing Then
            lArgs.SetValue("Timeseries", pDataGroup)
        Else
            lArgs.SetValue("Timeseries", aDataGroup)
        End If
        If aNDays Is Nothing Then
            lArgs.SetValue("NDay", ListToArray(lstNday))
        Else
            lArgs.SetValue("NDay", aNDays)
        End If
        lArgs.SetValue("Return Period", aReturnPeriods)
        lArgs.SetValue("LogFlg", chkLog.Checked)
        If pYearStartMonth > 0 Then lArgs.SetValue("BoundaryMonth", pYearStartMonth)
        If pYearStartDay > 0 Then lArgs.SetValue("BoundaryDay", pYearStartDay)
        If pYearEndMonth > 0 Then lArgs.SetValue("EndMonth", pYearEndMonth)
        If pYearEndDay > 0 Then lArgs.SetValue("EndDay", pYearEndDay)
        If pFirstYear > 0 Then lArgs.SetValue("FirstYear", pFirstYear)
        If pLastYear > 0 Then lArgs.SetValue("LastYear", pLastYear)
        Return lArgs
    End Function

    Private Function SaveSettingsBatch() As String
        Dim lMsg As String = ""
        Dim lName As String = HighOrLowString()
        If pYearStartMonth = 0 OrElse pYearStartDay = 0 OrElse pYearEndMonth = 0 OrElse pYearEndDay = 0 Then
            lMsg &= "- Problem with start and/or end dates." & vbCrLf
        Else
            If pAttributes Is Nothing Then
                pAttributes = New atcDataAttributes()
            End If
            With pAttributes
                .SetValue(InputNames.StartMonth, pYearStartMonth)
                .SetValue(InputNames.StartDay, pYearStartDay)
                .SetValue(InputNames.EndMonth, pYearEndMonth)
                .SetValue(InputNames.EndDay, pYearEndDay)
                'For All years, txtOmitBeforeYear and txtOmitAfterYear are empty
                If radioYearsAll.Checked Then
                    .SetValue(InputNames.IncludeYears, radioYearsAll.Text)
                ElseIf radioYearsCommon.Checked Then
                    .SetValue(InputNames.IncludeYears, radioYearsCommon.Text)
                Else
                    .SetValue(InputNames.IncludeYears, radioYearsCustom.Text.TrimEnd(":"c))
                End If
                .SetValue(InputNames.StartYear, txtOmitBeforeYear.Text)
                .SetValue(InputNames.EndYear, txtOmitAfterYear.Text)
                .SetValue(InputNames.HighLow, lName)
                .SetValue(InputNames.Logarithmic, chkLog.Checked)
                .SetValue(InputNames.MultiNDayPlot, chkMultipleNDayPlots.Checked)
                .SetValue(InputNames.MultiStationPlot, chkMultipleStationPlots.Checked)
                If IO.Directory.Exists(txtOutputDir.Text) Then
                    .SetValue(InputNames.OutputDir, txtOutputDir.Text)
                Else
                    lMsg &= "- Need to specify a default output directory."
                End If
                If Not String.IsNullOrEmpty(txtOutputRootName.Text.Trim()) Then
                    .SetValue(InputNames.OutputPrefix, txtOutputRootName.Text.Trim())
                End If
            End With
        End If

        If Not pSetGlobal Then
            Dim lStationsInfo As atcCollection = clsBatchUtil.BuildStationsInfo(pDataGroup)
            pAttributes.SetValue(InputNames.StationsInfo, lStationsInfo)
        End If

        lMsg &= SaveListBatch(lstNday)
        lMsg &= SaveListBatch(lstRecurrence)

        Return lMsg
    End Function

    Private Sub SaveSettings()
        Dim lName As String = HighOrLowString()
        SaveSetting("atcFrequencyGrid", "StartMonth", lName, pYearStartMonth)
        SaveSetting("atcFrequencyGrid", "StartDay", lName, pYearStartDay)
        SaveSetting("atcFrequencyGrid", "EndMonth", lName, pYearEndMonth)
        SaveSetting("atcFrequencyGrid", "EndDay", lName, pYearEndDay)
        SaveSetting("atcFrequencyGrid", "Defaults", "HighOrLow", lName)
        SaveSetting("atcFrequencyGrid", "Defaults", "Logarithmic", chkLog.Checked.ToString)
        SaveList(lstNday)
        SaveList(lstRecurrence)
    End Sub

    Private Sub SaveList(ByVal lst As System.Windows.Forms.ListBox)
        SaveSetting("atcFrequencyGrid", "List." & lst.Tag, "dummy", "")
        DeleteSetting("atcFrequencyGrid", "List." & lst.Tag)
        For lIndex As Integer = 0 To lst.Items.Count - 1
            SaveSetting("atcFrequencyGrid", "List." & lst.Tag, lst.Items(lIndex), lst.SelectedIndices.Contains(lIndex))
        Next
    End Sub

    Private Function SaveListBatch(ByVal lst As System.Windows.Forms.ListBox) As String
        Dim lMsg As String = ""

        'Dim listing0() As Double = pAttributes.GetValue(lst.Tag, Nothing)
        'If listing0 IsNot Nothing Then
        '    ReDim listing0(0)
        '    listing0 = Nothing
        'End If
        Dim lCollection0 As atcCollection = pAttributes.GetValue(lst.Tag & "s", Nothing)
        If lCollection0 IsNot Nothing Then
            lCollection0.Clear()
            lCollection0 = Nothing
        End If
        pAttributes.RemoveByKey(lst.Tag)
        pAttributes.RemoveByKey(lst.Tag & "s")
        If lst.SelectedIndices.Count = 0 Then
            lMsg &= "- Need to select at least one " & lst.Tag & vbCrLf
            Return lMsg
        Else
            Dim listing(lst.Items.Count - 1) As Double
            Dim lCollection As New atcCollection()

            Dim lItemValue As Double
            For lIndex As Integer = 0 To lst.Items.Count - 1
                lItemValue = lst.Items(lIndex)
                listing(lIndex) = lItemValue
                lCollection.Add(lItemValue, lst.SelectedIndices.Contains(lIndex))
            Next
            pAttributes.SetValue(lst.Tag, listing)
            pAttributes.SetValue(lst.Tag & "s", lCollection)
        End If

        Return lMsg
    End Function

    Private Sub ClearAttributes()
        Dim lRemoveThese As New atcCollection
        For Each lData As atcDataSet In pDataGroup
            For Each lAttribute As atcDefinedValue In lData.Attributes
                If Not lAttribute.Arguments Is Nothing Then
                    If lAttribute.Arguments.ContainsAttribute("Nday") OrElse
                       lAttribute.Arguments.ContainsAttribute("Return Period") Then
                        lRemoveThese.Add(lAttribute)
                    End If
                End If
            Next
            For Each lAttribute As atcDefinedValue In lRemoveThese
                lData.Attributes.Remove(lAttribute)
            Next
        Next
    End Sub

    Private Sub btnNdayAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayAll.Click
        For index As Integer = 0 To lstNday.Items.Count - 1
            lstNday.SetSelected(index, True)
        Next
    End Sub

    Private Sub btnNdayNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayNone.Click
        For index As Integer = 0 To lstNday.Items.Count - 1
            lstNday.SetSelected(index, False)
        Next
    End Sub

    Private Sub radioHigh_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioHigh.CheckedChanged
        GetDefaultYearStartEnd()
    End Sub

    Private Sub radioLow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioLow.CheckedChanged
        GetDefaultYearStartEnd()
    End Sub

    Private Sub GetDefaultYearStartEnd()
        If radioHigh.Checked Then
            pYearStartMonth = 10
            pYearStartDay = 1
            pYearEndMonth = 9
            pYearEndDay = 30
        Else
            pYearStartMonth = 4
            pYearStartDay = 1
            pYearEndMonth = 3
            pYearEndDay = 31
        End If

        Dim lName As String = HighOrLowString()
        pYearStartMonth = GetSetting("atcFrequencyGrid", "StartMonth", lName, pYearStartMonth)
        pYearStartDay = GetSetting("atcFrequencyGrid", "StartDay", lName, pYearStartDay)
        pYearEndMonth = GetSetting("atcFrequencyGrid", "EndMonth", lName, pYearEndMonth)
        pYearEndDay = GetSetting("atcFrequencyGrid", "EndDay", lName, pYearEndDay)
        SeasonsYearsToForm()
    End Sub

    Private Function HighOrLowString() As String
        If radioHigh.Checked Then
            Return "High"
        Else
            Return "Low"
        End If
    End Function

    Private Function MultipleNDayPlots() As Boolean
        If chkMultipleNDayPlots.Checked Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function MultipleStationPlots() As Boolean
        If chkMultipleStationPlots.Checked Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function GetRunRExe() As String
        Dim lRunR As String
        Dim lPrompt As Boolean = False
        Do
            lRunR = FindFile("Locate RunR executable", RunRProg, aUserVerifyFileName:=lPrompt)
            If lRunR.Length = 0 Then Return "RunR.exe not found"
            lPrompt = True
        Loop While Not lRunR.ToLower.EndsWith("runr.exe") OrElse Not IO.File.Exists(lRunR)
        Return lRunR
    End Function

    Private Function GetRScript() As String
        Dim lRcodeFilename As String
        Dim lPrompt As Boolean = False
        Do
            'lRcodeFilename = FindFile("Locate R script for computing Spearman Rho Test", "fnGetTrend.R", aUserVerifyFileName:=lPrompt)
            lRcodeFilename = FindFile("Locate R script for computing Spearman Rho Test", RScriptFilename, aUserVerifyFileName:=lPrompt)
            If lRcodeFilename.Length = 0 Then Return "R script not found"
            lPrompt = True
        Loop While Not lRcodeFilename.ToUpper.EndsWith(".R") OrElse Not IO.File.Exists(lRcodeFilename)
        Return lRcodeFilename
    End Function

    '{
    ''' <summary>
    ''' This function calculates Spearman's Rho, p at which rho = 0, and 
    ''' confidence limits for given Percent Confidence Interval (dPercentConfidenceInterval). 
    '''JEK: 
    '''Outputs � If it returns TRUE, then mark it in the table as �FLAG�.  If it returns FALSE, then mark it in the table as �FALSE�.  Do Not show True/False in the SWToolbox table just FLAG Or PASS.
    '''TRUE -> FLAG
    '''FALSE -> PASS
    ''' </summary>
    ''' <param name="aAnnualTS"></param>
    ''' <returns></returns>
    Private Function RunSpearmanTest(ByVal aAnnualTS As atcTimeseries) As String
        Dim lRunR As String = GetRunRExe()
        'Dim lPrompt As Boolean = False
        'Do
        '    lRunR = FindFile("Locate RunR executable", "RunR.exe", aUserVerifyFileName:=lPrompt)
        '    If lRunR.Length = 0 Then Return "RunR.exe not found"
        '    lPrompt = True
        'Loop While Not lRunR.ToLower.EndsWith("runr.exe") OrElse Not IO.File.Exists(lRunR)

        'lPrompt = False
        Dim lRcodeFilename As String = GetRScript()
        'Do
        '    'lRcodeFilename = FindFile("Locate R script for computing Spearman Rho Test", "fnGetTrend.R", aUserVerifyFileName:=lPrompt)
        '    lRcodeFilename = FindFile("Locate R script for computing Spearman Rho Test", RScriptFilename, aUserVerifyFileName:=lPrompt)
        '    If lRcodeFilename.Length = 0 Then Return "R script not found"
        '    lPrompt = True
        'Loop While Not lRcodeFilename.ToUpper.EndsWith(".R") OrElse Not IO.File.Exists(lRcodeFilename)

        If IO.File.Exists(lRcodeFilename) AndAlso aAnnualTS.numValues > 0 Then
            Dim lYearsString As String = ""
            Dim lValuesString As String = ""
            Dim lDateArray(6) As Integer
            For lValueIndex As Integer = 1 To aAnnualTS.numValues
                If Not Double.IsNaN(aAnnualTS.Value(lValueIndex)) Then
                    J2Date(aAnnualTS.Dates.Value(lValueIndex), lDateArray)
                    lYearsString &= lDateArray(0) & ", "
                    lValuesString &= DoubleToString(aAnnualTS.Value(lValueIndex), 15, "0.##########", aSignificantDigits:=8) & ", "
                End If
            Next
            'Trim extra comma and space
            lYearsString = lYearsString.Substring(0, lYearsString.Length - 2)
            lValuesString = lValuesString.Substring(0, lValuesString.Length - 2)

            Dim lArgsFilename As String = GetTemporaryFileName("RunR_Spearman", ".R")
            Logger.Dbg("Writing trend R function/arguments to " & lArgsFilename)
            TryCopy(lRcodeFilename, lArgsFilename)
            Dim lArgWriter As New System.IO.StreamWriter(lArgsFilename, True)
            lArgWriter.WriteLine()
            lArgWriter.WriteLine("# Arguments for this run")
            'lArgWriter.WriteLine("InputYears <- c(" & lYearsString & ")")
            'lArgWriter.WriteLine("InputValues <- c(" & lValuesString & ")")
            'lArgWriter.WriteLine("fnGetTrend(InputYears, InputValues, dPercentConfidenceInterval = 95, intWhat = 0)")
            lArgWriter.WriteLine("dInputarray1 <- c(" & lYearsString & ")")
            lArgWriter.WriteLine("dInputArray2 <- c(" & lValuesString & ")")
            lArgWriter.WriteLine("fnGetTrend(dInputarray1, dInputArray2, intReturn = 0, dPercentConfidenceInterval = 95)")
            lArgWriter.Close()

            Dim lResultsFilename As String = GetTemporaryFileName("Rresults_Spearman", ".txt")
            Logger.Dbg("Writing trend R results to " & lResultsFilename)
            Try
                LaunchProgram(lRunR, IO.Path.GetDirectoryName(lRcodeFilename), lResultsFilename & " " & lArgsFilename)
                Return IO.File.ReadAllText(lResultsFilename).TrimEnd(vbLf).TrimEnd(vbCr)
            Catch ex As Exception
                Return "R execution error: " & ex.InnerException.Message
            End Try
        End If
        Return "R code not found"
    End Function '}

    '{
    ''' <summary>
    ''' This function calculates the Pearson Type III K ratio to test if a site statistic is in the sample array. 
    ''' The Pearson Type III K ratio is used because there may be one or more zeroes among site statistics. 
    ''' It takes the site statistic and an array of statistics from nearby sites and uses the lat & Long of the site of interest 
    ''' to rank stations by proximity and compares it to the N nearby stations. 
    ''' If the statistic for the station of interest "fits" the Kratio then returns one or less otherwise the station is an outlier.
    '''JEK:
    '''In order to do this, we would need to allow the user to select sites to include.  
    '''For those sites, we'd pass the lat/lon, the 7Q10.  
    '''So this would be done outside the integrated design frequency workflow.  
    '''There�d have to be a separate menu item under analysis called �Compare station stats� or something like that.   
    ''' </summary>
    ''' <param name="aDataGroup">The selected group of time series that has the chosen flow stat calculated</param>
    ''' <param name="aStatName">7Low10</param>
    ''' <param name="aStationID">The target station ID</param>
    ''' <returns>R scripting console output that is written to a text file</returns>
    Private Function RunKRatioStationsTest(ByVal aDataGroup As atcTimeseriesGroup, ByVal aStatName As String, ByVal aStationID As String) As String
        If aDataGroup Is Nothing OrElse aDataGroup.Count = 0 Then Return "No Data"

        Dim lRunR As String = GetRunRExe()
        Dim lRcodeFilename As String = GetRScript()
        If Not IO.File.Exists(lRcodeFilename) Then
            Return "R code not found"
        End If
        Dim fnLbl As String = RTests.KRatioStations.ToString()
        Dim dMyLat As Double
        Dim dMyLong As Double
        Dim dMyStat As Double
        Dim lDA As Double = Double.NaN
        Dim lTs As atcTimeseries = pDataGroup.FindData("Location", aStationID)(0)
        With lTs.Attributes
            dMyLat = .GetValue("Latitude", Double.NaN)
            dMyLong = .GetValue("Longitude", Double.NaN)
            dMyStat = .GetValue(aStatName, Double.NaN)
            lDA = .GetValue("Drainage Area", Double.NaN)
            If Not Double.IsNaN(dMyStat) AndAlso Not Double.IsNaN(lDA) AndAlso Not Math.Abs(lDA - 0) < 0.00001 Then
                dMyStat /= lDA
            Else
                dMyStat = Double.NaN
            End If
        End With
        If Double.IsNaN(dMyLat) OrElse Double.IsNaN(dMyLong) OrElse Double.IsNaN(dMyStat) Then
            Return "No Data"
        End If
        Dim lngStationCount As Long = aDataGroup.Count
        Dim dArrayLat(lngStationCount - 2) As Double
        Dim dArrayLong(lngStationCount - 2) As Double
        Dim dArrayStat(lngStationCount - 2) As Double

        Dim lDateArray(6) As Integer
        Dim J As Integer = 0
        Dim lStatValue As Double = Double.NaN
        For I As Integer = 0 To aDataGroup.Count - 1
            lTs = aDataGroup(I)
            With lTs.Attributes
                If .GetValue("Location") <> aStationID Then
                    dArrayLat(J) = .GetValue("Latitude", Double.NaN)
                    dArrayLong(J) = .GetValue("Longitude", Double.NaN)
                    lStatValue = .GetValue(aStatName, Double.NaN)
                    lDA = .GetValue("Drainage Area", Double.NaN)
                    If Not Double.IsNaN(lStatValue) AndAlso Not Double.IsNaN(lDA) AndAlso Not Math.Abs(lDA - 0) < 0.00001 Then
                        dArrayStat(J) = lStatValue / lDA
                    Else
                        dArrayStat(J) = Double.NaN
                    End If
                    If Double.IsNaN(dArrayLat(J)) OrElse Double.IsNaN(dArrayLong(J)) OrElse Double.IsNaN(dArrayStat(J)) Then
                        ReDim dArrayLat(0)
                        ReDim dArrayLong(0)
                        ReDim dArrayStat(0)
                        dArrayLat = Nothing
                        dArrayLong = Nothing
                        dArrayStat = Nothing
                        Return "No Data"
                    End If
                    J += 1
                End If
            End With
        Next

        Dim lLatsString As String = ""
        Dim lLongString As String = ""
        Dim lStatString As String = ""
        For lIndex As Integer = 0 To dArrayLat.Length - 1
            lLatsString &= DoubleToString(dArrayLat(lIndex), 15, "0.##########", aSignificantDigits:=8) & ", "
            lLongString &= DoubleToString(dArrayLong(lIndex), 15, "0.##########", aSignificantDigits:=8) & ", "
            lStatString &= DoubleToString(dArrayStat(lIndex), 15, "0.##########", aSignificantDigits:=8) & ", "
        Next
        'Trim extra comma and space
        lLatsString = lLatsString.Substring(0, lLatsString.Length - 2)
        lLongString = lLongString.Substring(0, lLongString.Length - 2)
        lStatString = lStatString.Substring(0, lStatString.Length - 2)

        Dim lArgsFilename As String = GetTemporaryFileName("RunR_" & fnLbl, ".R")
        Logger.Dbg("Writing Stn Outlier Test R function/arguments to " & lArgsFilename)
        TryCopy(lRcodeFilename, lArgsFilename)
        Dim lArgWriter As New System.IO.StreamWriter(lArgsFilename, True)
        lArgWriter.WriteLine()
        lArgWriter.WriteLine("# Arguments for this run")
        'fnKRatioStations <- function(dMyLat, dMyLong, dMyStat, lngStationCount, dArrayLat, dArrayLong, dArrayStat, intReturn = 0, intppFormula = 5)
        lArgWriter.WriteLine("dMyLat <- c(" & dMyLat & ")")
        lArgWriter.WriteLine("dMyLong <- c(" & dMyLong & ")")
        lArgWriter.WriteLine("dMyStat <- c(" & dMyStat & ")")
        lArgWriter.WriteLine("lngStationCount <- c(" & lngStationCount & ")")
        lArgWriter.WriteLine("dArrayLat <- c(" & lLatsString & ")")
        lArgWriter.WriteLine("dArrayLong <- c(" & lLongString & ")")
        lArgWriter.WriteLine("dArrayStat <- c(" & lStatString & ")")
        lArgWriter.WriteLine("fnKRatioStations(dMyLat, dMyLong, dMyStat, lngStationCount, dArrayLat, dArrayLong, dArrayStat, intReturn = 0, intppFormula = 5)")
        lArgWriter.Close()

        ReDim dArrayLat(0)
        ReDim dArrayLong(0)
        ReDim dArrayStat(0)
        dArrayLat = Nothing
        dArrayLong = Nothing
        dArrayStat = Nothing

        Dim lResultsFilename As String = GetTemporaryFileName("Rresults_" & fnLbl, ".txt")
        Logger.Dbg("Writing " & fnLbl & " R results to " & lResultsFilename)
        Try
            LaunchProgram(lRunR, IO.Path.GetDirectoryName(lRcodeFilename), lResultsFilename & " " & lArgsFilename)
            Return IO.File.ReadAllText(lResultsFilename).TrimEnd(vbLf).TrimEnd(vbCr)
        Catch ex As Exception
            Return "R execution error: " & ex.InnerException.Message
        End Try
        Return ""
    End Function '}

    '{
    ''' <summary>
    ''' This Function calculates() the Kolmogorov-Smirnov test fit probability Of the specified distribution. 
    ''' It does the test based On the 95-percent confidence interval 
    ''' JEK:
    ''' ***** Spearman Section ****
    ''' fnGetTrend
    ''' calculates Spearman's Rho, p at which rho = 0, and confidence limits for given Percent Confidence Interval (dPercentConfidenceInterval). 
    ''' Outputs � 
    ''' TRUE -> FLAG
    ''' FALSE -> PASS
    ''' ***** Spearman Section End ****
    '''
    ''' ***** PPCC Section ****
    ''' fnPPCCTest
    ''' This function calculates the probability plot correlation coefficient test value. 
    ''' It does the test based on the 95-percent confidence interval  
    '''JEK:
    '''Inputs:
    '''dlnArray = n-day minimum time series (in cfs)
    '''intDistribution = 3, if �logarithmic� Is checked, 2 otherwise.
    '''Note #1: I am assuming that SWToolbox fits a Pearson Type III distribution no matter what � that no other distributional choices are available To it, And the only difference Is whether it uses a log-transformed dataset Or Not.
    '''Note #2: No need To pass it the last two vars, where defaults are provided � the defaults are what we want To use.
    '''Outputs:
    '''TRUE -> PASS
    '''FALSE-> FLAG
    ''' ***** PPCC Section End ****
    '''
    ''' ***** ProbableKSFit Section ****
    '''fnProbableKSFit(dInArray, intDistribution, intReturn = 0, bCensorZero = TRUE)
    '''calculates the Kolmogorov-Smirnov test fit probability Of the specified distribution. 
    '''It does the test based On the 95-percent confidence interval 
    ''' Inputs:
    ''' dlnArray = n - Day minimum time series (In cfs)
    ''' intDistribution = 3, If �logarithmic� Is checked, 2 otherwise.
    ''' Outputs:
    ''' TRUE -> PASS
    ''' FALSE -> FLAG
    ''' ***** ProbableKSFit Section End ****
    ''' </summary>
    ''' <param name="aAnnualTS"></param>
    ''' <returns></returns>
    Private Function RunRScreeningTests(ByVal aAnnualTS As atcTimeseries, ByVal aRTest As RTests) As String
        Dim fnLbl As String = aRTest.ToString()
        Dim lRunR As String = GetRunRExe()
        Dim lRcodeFilename As String = GetRScript()

        If IO.File.Exists(lRcodeFilename) AndAlso aAnnualTS.numValues > 0 Then
            Dim lYearsString As String = ""
            Dim lValuesString As String = ""
            Dim lYearsArray As New ArrayList()
            Dim lValuesArray As New ArrayList()
            Dim lDateArray(6) As Integer
            For lValueIndex As Integer = 1 To aAnnualTS.numValues
                If Not Double.IsNaN(aAnnualTS.Value(lValueIndex)) Then
                    J2Date(aAnnualTS.Dates.Value(lValueIndex), lDateArray)
                    lYearsString &= lDateArray(0) & ", "
                    lValuesString &= DoubleToString(aAnnualTS.Value(lValueIndex), 15, "0.##########", aSignificantDigits:=8) & ", "

                    lYearsArray.Add(lDateArray(0))
                    lValuesArray.Add(aAnnualTS.Value(lValueIndex))
                End If
            Next
            'Test suitability for R Testing
            Select Case aRTest
                Case RTests.Spearman
                    If lYearsArray.Count < 4 Then
                        Return "<4yr"
                    End If
                Case Else
                    If lYearsArray.Count < 3 Then
                        Return "<3yr"
                    End If
            End Select
            'Trim extra comma and space
            lYearsString = lYearsString.Substring(0, lYearsString.Length - 2)
            lValuesString = lValuesString.Substring(0, lValuesString.Length - 2)

            Dim lArgsFilename As String = GetTemporaryFileName("RunR_" & fnLbl, ".R")
            Logger.Dbg("Writing " & fnLbl & " R function/arguments to " & lArgsFilename)
            TryCopy(lRcodeFilename, lArgsFilename)
            Dim lArgWriter As New System.IO.StreamWriter(lArgsFilename, True)
            lArgWriter.WriteLine()
            lArgWriter.WriteLine("# Arguments for this run")
            Select Case aRTest
                Case RTests.Spearman
                    lArgWriter.WriteLine("dInputarray1 <- c(" & lYearsString & ")")
                    lArgWriter.WriteLine("dInputArray2 <- c(" & lValuesString & ")")
                    lArgWriter.WriteLine("fnGetTrend(dInputarray1, dInputArray2, intReturn = 0, dPercentConfidenceInterval = 95)")
                Case RTests.PPCC
                    lArgWriter.WriteLine("dInArray <- c(" & lValuesString & ")")
                    If chkLog.Checked Then
                        lArgWriter.WriteLine("intDistribution <- c(" & 3 & ")")
                    Else
                        lArgWriter.WriteLine("intDistribution <- c(" & 2 & ")")
                    End If
                    lArgWriter.WriteLine("fnPPCCTest(dInArray, intDistribution, intReturn = 0, bCensorZero = TRUE)")
                Case RTests.KSFit
                    lArgWriter.WriteLine("dInArray <- c(" & lValuesString & ")")
                    If chkLog.Checked Then
                        lArgWriter.WriteLine("intDistribution <- c(" & 3 & ")")
                    Else
                        lArgWriter.WriteLine("intDistribution <- c(" & 2 & ")")
                    End If
                    lArgWriter.WriteLine("fnProbableKSFit(dInArray, intDistribution, intReturn = 0, bCensorZero = TRUE)")
                Case RTests.BestFitDistribution
                Case RTests.KRatioOutliers
                    lArgWriter.WriteLine("dInArray <- c(" & lValuesString & ")")
                    If chkLog.Checked Then
                        lArgWriter.WriteLine("intDistribution <- c(" & 3 & ")")
                    Else
                        lArgWriter.WriteLine("intDistribution <- c(" & 2 & ")")
                    End If
                    lArgWriter.WriteLine("fnKRatioOutlierFits(dInArray, intDistribution, bCensorZero = TRUE, intppFormula = 5)")
                Case RTests.KRatioStations
            End Select
            lArgWriter.Close()

            Dim lResultsFilename As String = GetTemporaryFileName("Rresults_" & fnLbl, ".txt")
            Logger.Dbg("Writing " & fnLbl & " R results to " & lResultsFilename)
            Try
                LaunchProgram(lRunR, IO.Path.GetDirectoryName(lRcodeFilename), lResultsFilename & " " & lArgsFilename)
                If aRTest = RTests.KRatioOutliers Then
                    Dim lSR As System.IO.StreamReader = Nothing
                    Dim lKRatio_FLows As New atcCollection()
                    Dim lFlowVal As Double
                    Dim lKratio As Double
                    Try
                        lSR = New System.IO.StreamReader(lResultsFilename)
                        Dim lAllText As String = lSR.ReadToEnd()
                        Dim lFlowLine As String = lAllText.Substring(lAllText.IndexOf("(") + 1, lAllText.IndexOf(")") - 2)
                        Dim lKratioLine As String = lAllText.Substring(lAllText.LastIndexOf("(") + 1, lAllText.LastIndexOf(")") - lAllText.LastIndexOf("(") - 1)
                        Dim lStop As String = ""
                        'lFlowLine = lFlowLine.Replace("c", "").Replace("(", "").Replace(")", "")
                        'lKratioLine = lKratioLine.Replace("c", "").Replace("(", "").Replace(")", "")
                        lFlowLine = lFlowLine.Replace(vbLf, "").Replace("&", "").Replace(" ", "")
                        lKratioLine = lKratioLine.Replace(vbLf, "").Replace("&", "").Replace(" ", "")
                        Dim lArrFlow() As String = Nothing
                        Dim lArrKratio() As String = Nothing
                        lArrFlow = System.Text.RegularExpressions.Regex.Split(lFlowLine, ",")
                        lArrKratio = System.Text.RegularExpressions.Regex.Split(lKratioLine, ",")
                        If lArrFlow.Length = lArrKratio.Length Then
                            For I As Integer = 0 To lArrFlow.Length - 1
                                If Double.TryParse(lArrFlow(I), lFlowVal) AndAlso Double.TryParse(lArrKratio(I), lKratio) Then
                                    If Not lKRatio_FLows.Keys.Contains(lFlowVal) Then
                                        lKRatio_FLows.Add(lFlowVal, lKratio)
                                    End If
                                End If
                            Next
                        Else
                            Return ""
                        End If
                    Catch ex As Exception
                        Return ""
                    Finally
                        If lSR IsNot Nothing Then
                            lSR.Close() : lSR = Nothing
                        End If
                    End Try

                    Dim lOutlierYears As String = ""
                    For Each lFlow As Double In lKRatio_FLows.Keys
                        lKratio = lKRatio_FLows.ItemByKey(lFlow)
                        If lKratio > 1 Then
                            For I As Integer = 0 To lValuesArray.Count - 1
                                Dim lFlowInOrder As Double = lValuesArray(I)
                                If Math.Abs(lFlowInOrder - lFlow) < 0.00001 Then
                                    lOutlierYears &= lYearsArray(I) & ","
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                    lValuesArray.Clear() : lValuesArray = Nothing
                    lYearsArray.Clear() : lYearsArray = Nothing
                    lKRatio_FLows.Clear() : lKRatio_FLows = Nothing
                    Return lOutlierYears.TrimEnd(",")
                Else
                    lValuesArray.Clear() : lValuesArray = Nothing
                    lYearsArray.Clear() : lYearsArray = Nothing
                    Return IO.File.ReadAllText(lResultsFilename).TrimEnd(vbLf).TrimEnd(vbCr)
                End If
            Catch ex As Exception
                Return "R execution error: " & ex.InnerException.Message
            End Try
        End If
        Return "R code not found"
    End Function '}

    Private Sub btnDisplayTrend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayTrend.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim lSelectedData As atcTimeseriesGroup = SelectedData()
        If lSelectedData.Count > 0 Then
            If lstNday.SelectedIndices.Count > 0 Then
                Dim lRankedAnnual As atcTimeseriesGroup =
                   clsIDFPlugin.ComputeRankedAnnualTimeseries(aTimeseriesGroup:=lSelectedData,
                                                                 aNDay:=ListToArray(lstNday),
                                                                 aHighFlag:=radioHigh.Checked,
                                                                 aFirstYear:=pFirstYear,
                                                                 aLastYear:=pLastYear,
                                                                 aBoundaryMonth:=pYearStartMonth,
                                                                 aBoundaryDay:=pYearStartDay,
                                                                 aEndMonth:=pYearEndMonth,
                                                                 aEndDay:=pYearEndDay)
                If lRankedAnnual.Count > 0 Then
                    For Each lTS As atcTimeseries In lRankedAnnual
                        With lTS.Attributes
                            .SetValue("Original ID", lTS.OriginalParentID)
                            .SetValue("From", pDateFormat.JDateToString(lTS.Dates.Value(1)))
                            .SetValue("To", pDateFormat.JDateToString(lTS.Dates.Value(lTS.numValues)))
                            .SetValue("Not Used", .GetValue("Count Missing"))
                            '.SetValueIfMissing("SpearmanTest", RunSpearmanTest(lTS))
                        End With
                    Next

                    Dim lList As New atcList.atcListForm
                    With lList
                        With .DateFormat
                            .IncludeDays = False
                            .IncludeHours = False
                            .IncludeMinutes = False
                            .IncludeMonths = False
                        End With

                        .Text = "Trend of " & HighOrLowString() & " Annual Time Series and Statistics"
                        AddSeasonNameIfNeeded(pTrendAttributes, lRankedAnnual)
                        .HAlignment = atcControls.atcAlignment.HAlignLeft
                        .Initialize(lRankedAnnual, pTrendAttributes, False)
                        .SwapRowsColumns = True
                        .Icon = Me.Icon
                    End With
                End If
            Else
                Logger.Msg("Select at least one number of days")
            End If
        Else
            Logger.Msg("Select at least one time series")
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' This is currently a close copy of btnDisplayTrend_Click but may become its own new thing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnScreeningTests_Click(sender As Object, e As EventArgs) Handles btnScreeningTests.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim lSelectedData As atcTimeseriesGroup = SelectedData()
        If lSelectedData.Count > 0 Then
            If lstNday.SelectedIndices.Count > 0 Then
                Dim lRankedAnnual As atcTimeseriesGroup =
                   clsIDFPlugin.ComputeRankedAnnualTimeseries(aTimeseriesGroup:=lSelectedData,
                                                                 aNDay:=ListToArray(lstNday),
                                                                 aHighFlag:=radioHigh.Checked,
                                                                 aFirstYear:=pFirstYear,
                                                                 aLastYear:=pLastYear,
                                                                 aBoundaryMonth:=pYearStartMonth,
                                                                 aBoundaryDay:=pYearStartDay,
                                                                 aEndMonth:=pYearEndMonth,
                                                                 aEndDay:=pYearEndDay)
                If lRankedAnnual.Count > 0 Then
                    Dim lTestResult As String = ""
                    Dim lTestName As String = ""
                    Logger.Status("Running R Screening Tests...")
                    Dim lTserIndex As Integer = 1
                    For Each lTS As atcTimeseries In lRankedAnnual
                        With lTS.Attributes
                            .SetValue("Original ID", lTS.OriginalParentID)
                            .SetValue("From", pDateFormat.JDateToString(lTS.Dates.Value(1)))
                            .SetValue("To", pDateFormat.JDateToString(lTS.Dates.Value(lTS.numValues)))
                            .SetValue("Not Used", .GetValue("Count Missing"))
                            Try
                                'lTxtSpearman = RunSpearmanTest(lTS)
                                lTestResult = RunRScreeningTests(lTS, RTests.Spearman)
                                lTestName = RTests.Spearman.ToString() '"Spearman"
                                If Not String.IsNullOrEmpty(lTestResult) Then
                                    lTestResult = lTestResult.ToUpper()
                                    If lTestResult = "TRUE" Then
                                        .SetValueIfMissing(lTestName, "FLAG")
                                    ElseIf lTestResult = "FALSE" Then
                                        .SetValueIfMissing(lTestName, "PASS")
                                    ElseIf Not String.IsNullOrEmpty(lTestResult) AndAlso lTestResult.StartsWith("No R") Then
                                        Logger.Msg(lTestResult, MsgBoxStyle.Information, "R Screening Test Cancelled")
                                        Me.Cursor = System.Windows.Forms.Cursors.Default
                                        Exit Sub
                                    Else
                                        .SetValueIfMissing(lTestName, lTestResult)
                                    End If
                                Else
                                    .SetValueIfMissing(lTestName, "N/A")
                                End If
                            Catch ex As Exception
                                .SetValueIfMissing(lTestName, "Test Failed")
                            End Try

                            Try
                                lTestResult = RunRScreeningTests(lTS, RTests.PPCC)
                                lTestName = RTests.PPCC.ToString() '"PPCC"
                                If Not String.IsNullOrEmpty(lTestResult) Then
                                    lTestResult = lTestResult.ToUpper()
                                    If lTestResult = "TRUE" Then
                                        .SetValueIfMissing(lTestName, "PASS")
                                    ElseIf lTestResult = "FALSE" Then
                                        .SetValueIfMissing(lTestName, "FLAG")
                                    Else
                                        .SetValueIfMissing(lTestName, lTestResult)
                                    End If
                                Else
                                    .SetValueIfMissing(lTestName, "N/A")
                                End If
                            Catch ex As Exception
                                .SetValueIfMissing(lTestName, "Test Failed")
                            End Try

                            Try
                                lTestResult = RunRScreeningTests(lTS, RTests.KSFit)
                                lTestName = RTests.KSFit.ToString() '"KSFit"
                                If Not String.IsNullOrEmpty(lTestResult) Then
                                    lTestResult = lTestResult.ToUpper()
                                    If lTestResult = "TRUE" Then
                                        .SetValueIfMissing(lTestName, "PASS")
                                    ElseIf lTestResult = "FALSE" Then
                                        .SetValueIfMissing(lTestName, "FLAG")
                                    Else
                                        .SetValueIfMissing(lTestName, lTestResult)
                                    End If
                                Else
                                    .SetValueIfMissing(lTestName, "N/A")
                                End If
                            Catch ex As Exception
                                .SetValueIfMissing(lTestName, "Test Failed")
                            End Try

                            Try
                                lTestResult = RunRScreeningTests(lTS, RTests.KRatioOutliers)
                                lTestName = RTests.KRatioOutliers.ToString()
                                If Not String.IsNullOrEmpty(lTestResult) Then
                                    .SetValueIfMissing(lTestName, lTestResult)
                                Else
                                    .SetValueIfMissing(lTestName, "")
                                End If
                            Catch ex As Exception
                                .SetValueIfMissing(lTestName, "Test Failed")
                            End Try

                        End With
                        Logger.Progress("R Screening Test for " & lTS.Attributes.GetValue("Location"), lTserIndex, lRankedAnnual.Count)
                        lTserIndex += 1
                    Next
                    Dim lList As New atcList.atcListForm
                    With lList
                        With .DateFormat
                            .IncludeDays = False
                            .IncludeHours = False
                            .IncludeMinutes = False
                            .IncludeMonths = False
                        End With
                        .Text = "Screening Tests of " & HighOrLowString() & " Annual Time Series and Statistics"
                        Dim lAttributes As New List(Of String)
                        With lAttributes
                            .Add("STAID")
                            .Add("STANAM")
                            .Add("Count")
                            .Add("Not Used")
                            .Add("Min")
                            .Add("Max")
                            .Add("NDay")
                            '.Add("Spearman")
                            '.Add("PPCC")
                            '.Add("KSFit")
                            '.Add("KRatioOutliers")
                            .Add(RTests.Spearman.ToString())
                            .Add(RTests.PPCC.ToString())
                            .Add(RTests.KSFit.ToString())
                            .Add(RTests.KRatioOutliers.ToString())
                        End With
                        AddSeasonNameIfNeeded(lAttributes, lRankedAnnual)
                        .Initialize(lRankedAnnual, lAttributes, False)
                        .SwapRowsColumns = True
                        .Icon = Me.Icon
                    End With
                End If
            Else
                Logger.Msg("Select at least one number of days")
            End If
        Else
            Logger.Msg("Select at least one time series")
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnDoFrequencyGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoFrequencyGrid.Click
        If pBatch Then
            CalculateBatch() 'setting params for batch run
        Else
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            ClearAttributes()
            SeasonsYearsFromForm() 'setup all inputs from form
            ' It is important that the Return Periods that go into N-day calculation (i.e. PearsonType3/LGPSTX) via "lAttrs"
            ' HAVE TO BE the full range of default return periods (28 entries), NOT the user selected return periods on the form.
            ' In fact, the atcTimeseriesNdayHighLow calculator should simply use its internally-defined default set of return periods
            ' instead of potentially confusing with users selected return periods on the form!
            Dim lAttrs As atcDataAttributes = SetOperationConditions("n-day " & HighOrLowString() & " value", clsIDFPlugin.ListDefaultArray("Return Period"))
            Dim lFreqForm As New frmDisplayFrequencyGrid(aDataGroup:=pDataGroup,
                                                         aHigh:=radioHigh.Checked,
                                                         aNday:=ListToArray(lstNday),
                                                         aReturns:=ListToArray(lstRecurrence),
                                                         aShowForm:=True,
                                                         aConditions:=lAttrs)


            lFreqForm.SWSTATformmod = Me

            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub btnFrequencyReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFrequencyReport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim lFreqForm As New frmDisplayFrequencyGrid(aDataGroup:=pDataGroup,
                                                             aHigh:=radioHigh.Checked,
                                                             aNday:=ListToArray(lstNday),
                                                             aReturns:=ListToArray(lstRecurrence))

        Calculate("n-day " & HighOrLowString() & " value", clsIDFPlugin.ListDefaultArray("Return Period"))

        lFreqForm.Visible = False

        Dim lSaveDialog As New System.Windows.Forms.SaveFileDialog
        With lSaveDialog
            .Title = "Save Frequency Report As"
            .DefaultExt = ".txt"
            .FileName = GetNewFileName(SafeFilename(ReplaceString(lFreqForm.Text, " ", "_") & "_report"), ".txt")
            If FileExists(IO.Path.GetDirectoryName(.FileName), True, False) Then
                .InitialDirectory = IO.Path.GetDirectoryName(.FileName)
            End If
            If .ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                'Calculate("n-day " & HighOrLowString() & " value", ListToArray(lstRecurrence))

                SaveFileString(.FileName, lFreqForm.CreateReport)
                OpenFile(.FileName)
            End If
        End With
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnDoFrequencyGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoFrequencyGraph.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        DoFrequencyGraph()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Public Sub DoFrequencyGraph(Optional ByVal aDataGroup As atcData.atcTimeseriesGroup = Nothing)
        Calculate("n-day " & HighOrLowString() & " value", clsIDFPlugin.ListDefaultArray("Return Period"))
        Dim lGraphPlugin As New atcGraph.atcGraphPlugin
        Dim lGraphForm As atcGraph.atcGraphForm
        'Dim lSeparateGraphs As Boolean = False
        'Select Case pDataGroup.Count
        '    Case 0 : Return
        '    Case 1 : lSeparateGraphs = False
        '    Case Else
        '        lSeparateGraphs = (Logger.MsgCustomCheckbox("Create separate graphs or all on one graph?", _
        '                                                    pDataGroup.Count & " datasets selected", _
        '                                                    "Do not ask again", "BASINS", "SWSTAT", "SeparateFreqGraphs", _
        '                                                    "Separate", "One Graph") = "Separate")
        'End Select

        'Get station list
        Dim lStnList As New Generic.List(Of String)
        For Each lDataSet As atcTimeseries In pDataGroup
            If Not lStnList.Contains(STAID(lDataSet)) Then
                lStnList.Add(STAID(lDataSet))
            End If
        Next
        'Get Nday list
        Dim lNDayList As New Generic.List(Of String)
        For Each lDataSet As atcTimeseries In pDataGroup
            For Each lAtt As atcData.atcDefinedValue In lDataSet.Attributes
                If lAtt.Definition.Name.ToLower.Contains("daytimeseries") Then
                    If Not lNDayList.Contains(lAtt.Definition.Name) Then
                        lNDayList.Add(lAtt.Definition.Name)
                    End If
                End If
            Next
        Next
        If MultipleNDayPlots() And MultipleStationPlots() Then
            For Each lStaId As String In lStnList
                For Each lNDayTimeseriesName As String In lNDayList
                    Dim lDataGroup As New atcData.atcTimeseriesGroup
                    For Each lDataset As atcTimeseries In pDataGroup
                        If STAID(lDataset) = lStaId Then
                            Dim lTs As atcTimeseries = lDataset.Attributes.GetValue(lNDayTimeseriesName)
                            If lTs IsNot Nothing Then
                                lDataGroup.Add(lTs)
                            End If
                        End If
                    Next
                    If lDataGroup.Count > 0 Then
                        lGraphForm = lGraphPlugin.Show(lDataGroup, "Frequency")
                        lGraphForm.Icon = Me.Icon
                    End If
                    lDataGroup.Clear()
                    lDataGroup = Nothing
                Next
            Next

            'For Each lDataSet As atcTimeseries In pDataGroup
            '    lGraphForm = lGraphPlugin.Show(New atcTimeseriesGroup(lDataSet), "Frequency")
            '    lGraphForm.Icon = Me.Icon
            'Next
        ElseIf MultipleNDayPlots() Then
            For Each lNDayTimeseriesName As String In lNDayList
                Dim lDataGroup As New atcData.atcTimeseriesGroup
                For Each lDataset As atcTimeseries In pDataGroup
                    Dim lTs As atcTimeseries = lDataset.Attributes.GetValue(lNDayTimeseriesName)
                    If lTs IsNot Nothing Then
                        lDataGroup.Add(lTs)
                    End If
                Next
                If lDataGroup IsNot Nothing AndAlso lDataGroup.Count > 0 Then
                    lGraphForm = lGraphPlugin.Show(lDataGroup, "Frequency")
                    lGraphForm.Icon = Me.Icon
                End If
                lDataGroup.Clear()
                lDataGroup = Nothing
            Next
        ElseIf MultipleStationPlots() Then
            Dim lDataGroup As atcData.atcTimeseriesGroup = Nothing
            For Each lStaId As String In lStnList
                lDataGroup = pDataGroup.FindData("STAID", lStaId)
                If lDataGroup IsNot Nothing AndAlso lDataGroup.Count > 0 Then
                    lGraphForm = lGraphPlugin.Show(lDataGroup, "Frequency")
                    lGraphForm.Icon = Me.Icon
                End If
                lDataGroup.Clear()
                lDataGroup = Nothing
            Next
        Else
            lGraphForm = lGraphPlugin.Show(pDataGroup, "Frequency")
            lGraphForm.Icon = Me.Icon
        End If

        lNDayList.Clear()
        lNDayList = Nothing
        lStnList.Clear()
        lStnList = Nothing
    End Sub


    Private Sub radioYearsAll_CheckedChanged(sender As Object, e As EventArgs) Handles radioYearsAll.CheckedChanged
        If radioYearsAll.Checked Then
            ShowCustomYears(False)
            txtOmitBeforeYear.Text = ""
            txtOmitAfterYear.Text = ""
        End If
    End Sub

    Private Sub radioYearsCommon_CheckedChanged(sender As Object, e As EventArgs) Handles radioYearsCommon.CheckedChanged
        If radioYearsCommon.Checked Then
            ShowCustomYears(False)
            If radioYearsCommon.Text.EndsWith(pNoDatesInCommon) Then
                radioYearsAll.Checked = True
            Else
                Try
                    Dim lCurDate(5) As Integer
                    J2Date(pCommonStart, lCurDate)
                    txtOmitBeforeYear.Text = Format(lCurDate(0), "0000")
                    J2Date(pCommonEnd, lCurDate)
                    txtOmitAfterYear.Text = Format(lCurDate(0), "0000")
                Catch
                End Try
            End If
        End If
    End Sub

    Private Sub radioYearsCustom_CheckedChanged(sender As Object, e As EventArgs) Handles radioYearsCustom.CheckedChanged
        If radioYearsCustom.Checked Then
            ShowCustomYears(True)
        End If
    End Sub

    Private Sub btnRecurrenceAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceAdd.Click
        If IsNumeric(txtRecurrenceAdd.Text) Then
            Try
                Dim lIndex As Integer = 0
                Dim lNewValue As Double = CDbl(txtRecurrenceAdd.Text)
                While lIndex < lstRecurrence.Items.Count AndAlso CDbl(lstRecurrence.Items(lIndex)) < lNewValue
                    lIndex += 1
                End While
                lstRecurrence.Items.Insert(lIndex, txtRecurrenceAdd.Text)
                lstRecurrence.SetSelected(lIndex, True)
            Catch ex As Exception
                Logger.Dbg("Exception adding Recurrence '" & txtRecurrenceAdd.Text & "': " & ex.Message)
            End Try
        Else
            Logger.Msg("Type a return period to add in the blank, then press the add button again")
        End If
    End Sub

    Private Sub btnRecurrenceRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceRemove.Click
        Dim lRemoveThese As New ArrayList
        Dim lIndex As Integer
        If lstRecurrence.SelectedIndices.Count > 0 Then
            For lIndex = lstRecurrence.SelectedIndices.Count - 1 To 0 Step -1
                lRemoveThese.Add(lstRecurrence.SelectedIndices.Item(lIndex))
            Next
        Else
            For lIndex = lstRecurrence.Items.Count - 1 To 0 Step -1
                If lstRecurrence.Items(lIndex) = txtRecurrenceAdd.Text Then
                    lRemoveThese.Add(lIndex)
                End If
            Next
        End If

        For Each lIndex In lRemoveThese
            lstRecurrence.Items.RemoveAt(lIndex)
        Next

    End Sub

    Private Sub btnRecurrenceDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceDefault.Click
        LoadListDefaults(lstRecurrence)
    End Sub

    Private Sub btnRecurrenceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceAll.Click
        For index As Integer = 0 To lstRecurrence.Items.Count - 1
            lstRecurrence.SetSelected(index, True)
        Next
    End Sub

    Private Sub btnRecurrenceNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceNone.Click
        For index As Integer = 0 To lstRecurrence.Items.Count - 1
            lstRecurrence.SetSelected(index, False)
        Next
    End Sub

#Region "DFLOW"

    Private Sub ckbBio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbBio.CheckedChanged

        DFLOWCalcs.fBioDefault = Not ckbBio.Checked

        tbBio1.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio2.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio3.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio4.Enabled = Not DFLOWCalcs.fBioDefault

        For i As Integer = 0 To 3
            If DFLOWCalcs.fBioFPArray(3, i) < 0 Then
                DFLOWCalcs.fBioFPArray(3, i) = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, i)
            End If
        Next
        tbBio1.Text = DFLOWCalcs.fBioFPArray(3, 0)
        tbBio2.Text = DFLOWCalcs.fBioFPArray(3, 1)
        tbBio3.Text = DFLOWCalcs.fBioFPArray(3, 2)
        tbBio4.Text = DFLOWCalcs.fBioFPArray(3, 3)
    End Sub

    Private Sub rbBio1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBio1.CheckedChanged, rbBio3.CheckedChanged, rbBio2.CheckedChanged
        If rbBio1.Checked Then
            DFLOWCalcs.fBioType = 0
        ElseIf rbBio2.Checked Then
            DFLOWCalcs.fBioType = 1
        Else
            DFLOWCalcs.fBioType = 2
        End If
        If pBatch AndAlso pAttributes IsNot Nothing Then
            Dim lParams() As Integer = Nothing
            If rbBio1.Checked Then
                lParams = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration.ToString())
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration)
            ElseIf rbBio2.Checked Then
                lParams = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString())
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration)
            ElseIf rbBio3.Checked Then
                lParams = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString())
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia)
            End If
            If lParams IsNot Nothing Then
                tbBio1.Text = lParams(0).ToString()
                tbBio2.Text = lParams(1).ToString()
                tbBio3.Text = lParams(2).ToString()
                tbBio4.Text = lParams(3).ToString()
            End If
        Else
            tbBio1.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 0)
            tbBio2.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 1)
            tbBio3.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 2)
            tbBio4.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 3)
        End If
    End Sub
    ' Boolean flag used to determine when a character other than a number is entered.
    Private nonNumberEntered As Boolean = False

    ' Handle the KeyDown event to determine the type of character entered into the control.
    Private Sub textBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
         Handles tbBio1.KeyDown, tbBio2.KeyDown, tbBio3.KeyDown, tbBio4.KeyDown, tbNonBio1.KeyDown, tbNonBio2.KeyDown, tbNonBio4.KeyDown
        ' Initialize the flag to false.
        nonNumberEntered = False

        ' Determine whether the keystroke is a number from the top of the keyboard.
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            ' Determine whether the keystroke is a number from the keypad.
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' Determine whether the keystroke is a backspace.
                If e.KeyCode <> Keys.Back Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If
    End Sub 'textBox1_KeyDown
    Private Sub textBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbNonBio3.KeyDown
        ' Initialize the flag to false.
        nonNumberEntered = False

        ' Determine whether the keystroke is a number from the top of the keyboard.
        If e.KeyCode = Keys.OemPeriod And InStr(sender.text, ".") = 1 Then
            If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                ' Determine whether the keystroke is a number from the keypad.
                If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                    ' Determine whether the keystroke is a backspace.
                    If e.KeyCode <> Keys.Back Then
                        ' A non-numerical keystroke was pressed. 
                        ' Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = True
                    End If
                End If
            End If
        End If
    End Sub

    ' This event occurs after the KeyDown event and can be used 
    ' to prevent characters from entering the control.
    Private Sub textBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles tbBio1.KeyPress, tbBio2.KeyPress, tbBio3.KeyPress, tbBio4.KeyPress, tbNonBio1.KeyPress, tbNonBio2.KeyPress, tbNonBio4.KeyPress, tbNonBio3.KeyPress

        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub 'textBox1_KeyPress

    Private Sub rbNonBio1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNonBio1.CheckedChanged, rbNonBio3.CheckedChanged, rbNonBio2.CheckedChanged

        If rbNonBio1.Checked Then
            DFLOWCalcs.fNonBioType = 0
        ElseIf rbNonBio2.Checked Then
            DFLOWCalcs.fNonBioType = 1
        Else
            DFLOWCalcs.fNonBioType = 2
        End If
        Label7.Enabled = rbNonBio1.Checked
        Label8.Enabled = rbNonBio1.Checked
        tbNonBio1.Enabled = rbNonBio1.Checked
        tbNonBio2.Enabled = rbNonBio1.Checked

        Label5.Enabled = rbNonBio2.Checked
        tbNonBio3.Enabled = rbNonBio2.Checked

        Label6.Enabled = rbNonBio3.Checked
        tbNonBio4.Enabled = rbNonBio3.Checked

        If pBatch AndAlso pAttributes IsNot Nothing Then
            If rbNonBio1.Checked Then
                pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Hydrological)
                'Dim lParams() As Integer = pAttributes.GetValue(InputNames.EDFlowType.Hydrological.ToString(), Nothing)
                'If lParams IsNot Nothing AndAlso lParams.Length = 2 Then
                '    tbNonBio1.Text = lParams(0).ToString()
                '    tbNonBio2.Text = lParams(1).ToString()
                'End If
            ElseIf rbNonBio2.Checked Then
                pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value)
                'Dim lflowval As Double = pAttributes.GetValue(InputNames.EDFlowType.Explicit_Flow_Value.ToString(), 1.0)
                'tbNonBio3.Text = lflowval.ToString()
            ElseIf rbNonBio3.Checked Then
                pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile)
                'Dim lflowPct As Double = pAttributes.GetValue(InputNames.EDFlowType.Flow_Percentile.ToString(), 0.1)
                'tbNonBio4.Text = lflowPct.ToString()
            End If
        Else
            If rbNonBio1.Checked Then
                If pAttributes IsNot Nothing Then pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Hydrological)
                Dim lAvgPeriod As Integer
                Dim lReturnPeriod As Integer
                If pAttributes IsNot Nothing AndAlso pAttributes.ContainsAttribute(DFLOWAnalysis.InputNames.EDFlowType.Hydrological.ToString()) Then
                    Dim lParams() As Integer = pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Hydrological.ToString(), Nothing)
                    If lParams IsNot Nothing AndAlso lParams.Length = 2 Then
                        lAvgPeriod = lParams(0)
                        lReturnPeriod = lParams(1)
                    Else
                        lAvgPeriod = DFLOWAnalysis.DFLOWCalcs.fAveragingPeriod
                        lReturnPeriod = DFLOWAnalysis.DFLOWCalcs.fReturnPeriod
                    End If
                Else
                    lAvgPeriod = DFLOWAnalysis.DFLOWCalcs.fAveragingPeriod
                    lReturnPeriod = DFLOWAnalysis.DFLOWCalcs.fReturnPeriod
                End If
                tbNonBio1.Text = lAvgPeriod.ToString()
                tbNonBio2.Text = lReturnPeriod.ToString()
            ElseIf rbNonBio2.Checked Then
                If pAttributes IsNot Nothing Then pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value)
                Dim lflowval As Double
                If pAttributes IsNot Nothing AndAlso pAttributes.ContainsAttribute(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString()) Then
                    lflowval = pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString())
                Else
                    lflowval = DFLOWAnalysis.DFLOWCalcs.fExplicitFlow
                End If
                tbNonBio3.Text = lflowval.ToString()
            ElseIf rbNonBio3.Checked Then
                If pAttributes IsNot Nothing Then pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile)
                Dim lflowPct As Double
                If pAttributes IsNot Nothing AndAlso pAttributes.ContainsAttribute(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString()) Then
                    lflowPct = pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString())
                Else
                    lflowPct = DFLOWAnalysis.DFLOWCalcs.fPercentile
                End If
                tbNonBio4.Text = lflowPct.ToString()
            End If
        End If
    End Sub

    Private Sub tbNonBio1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNonBio1.TextChanged
        If IsNumeric(tbNonBio1.Text) AndAlso Integer.TryParse(tbNonBio1.Text, DFLOWCalcs.fAveragingPeriod) Then
            Dim lParams() As Integer = GetSavedParams(False)
            If lParams IsNot Nothing AndAlso lParams.Length = 2 Then
                lParams(0) = DFLOWCalcs.fAveragingPeriod
            End If
        End If
    End Sub
    Private Sub tbNonBio2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNonBio2.TextChanged
        If IsNumeric(tbNonBio2.Text) AndAlso Integer.TryParse(tbNonBio2.Text, DFLOWCalcs.fReturnPeriod) Then
            Dim lParams() As Integer = GetSavedParams(False)
            If lParams IsNot Nothing AndAlso lParams.Length = 2 Then
                lParams(1) = DFLOWCalcs.fReturnPeriod
            End If
        End If
    End Sub
    Private Sub tbNonBio3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNonBio3.TextChanged
        If IsNumeric(tbNonBio3.Text) AndAlso Double.TryParse(tbNonBio3.Text, DFLOWCalcs.fExplicitFlow) AndAlso DFLOWCalcs.fExplicitFlow > 0 Then
            Dim lNewValue As Double = GetSavedParams(False, DFLOWCalcs.fExplicitFlow)
        End If
    End Sub
    Private Sub tbNonBio4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNonBio4.TextChanged
        If IsNumeric(tbNonBio4.Text) AndAlso Double.TryParse(tbNonBio4.Text, DFLOWCalcs.fPercentile) AndAlso DFLOWCalcs.fPercentile > 0 Then
            Dim lNewValue As Double = GetSavedParams(False, DFLOWCalcs.fPercentile)
        End If
    End Sub

    Private Sub tbBio1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBio1.TextChanged
        If IsNumeric(tbBio1.Text) AndAlso Integer.TryParse(tbBio1.Text, DFLOWCalcs.fBioFPArray(3, 0)) Then
            'fBioFPArray(3, 0) = tbBio1.Text
            Dim lParams() As Integer = GetSavedParams()
            If lParams IsNot Nothing AndAlso lParams.Length = 4 Then
                lParams(DFLOWAnalysis.InputNames.EBioDFlowParamIndex.P0FlowAveragingPeriodDays) = Integer.Parse(tbBio1.Text)
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioUseDefault, False)
            End If
        End If
    End Sub
    Private Sub tbBio2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBio2.TextChanged
        If IsNumeric(tbBio2.Text) AndAlso Integer.TryParse(tbBio2.Text, DFLOWCalcs.fBioFPArray(3, 1)) Then
            'fBioFPArray(3, 1) = tbBio2.Text
            Dim lParams() As Integer = GetSavedParams()
            If lParams IsNot Nothing AndAlso lParams.Length = 4 Then
                lParams(DFLOWAnalysis.InputNames.EBioDFlowParamIndex.P1AverageYearsBetweenExcursions) = Integer.Parse(tbBio2.Text)
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioUseDefault, False)
            End If
        End If
    End Sub
    Private Sub tbBio3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBio3.TextChanged
        If IsNumeric(tbBio3.Text) AndAlso Integer.TryParse(tbBio3.Text, DFLOWCalcs.fBioFPArray(3, 2)) Then
            'fBioFPArray(3, 2) = tbBio3.Text
            Dim lParams() As Integer = GetSavedParams()
            If lParams IsNot Nothing AndAlso lParams.Length = 4 Then
                lParams(DFLOWAnalysis.InputNames.EBioDFlowParamIndex.P2ExcursionClusterPeriodDays) = Integer.Parse(tbBio3.Text)
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioUseDefault, False)
            End If
        End If
    End Sub
    Private Sub tbBio4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBio4.TextChanged
        If IsNumeric(tbBio4.Text) AndAlso Integer.TryParse(tbBio4.Text, DFLOWCalcs.fBioFPArray(3, 3)) Then
            'fBioFPArray(3, 3) = tbBio4.Text
            Dim lParams() As Integer = GetSavedParams()
            If lParams IsNot Nothing AndAlso lParams.Length = 4 Then
                lParams(DFLOWAnalysis.InputNames.EBioDFlowParamIndex.P3AverageExcursionsPerCluster) = Integer.Parse(tbBio4.Text)
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioUseDefault, False)
            End If
        End If
    End Sub

    Private Function GetSavedParams(Optional ByVal aBio As Boolean = True, Optional ByVal aValue As Double = -99) As Object
        If pAttributes IsNot Nothing Then
            If aBio Then
                If rbBio1.Checked Then
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration.ToString(), Nothing)
                ElseIf rbBio2.Checked Then
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString(), Nothing)
                ElseIf rbBio3.Checked Then
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString(), Nothing)
                End If
            Else
                If rbNonBio1.Checked Then
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Hydrological.ToString(), Nothing)
                ElseIf rbNonBio2.Checked Then
                    If aValue > 0 Then
                        pAttributes.SetValue(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString(), aValue)
                    End If
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString(), Nothing)
                ElseIf rbNonBio3.Checked Then
                    If aValue > 0 Then
                        pAttributes.SetValue(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString(), aValue)
                    End If
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString(), Nothing)
                End If
            End If
        Else
            Return Nothing
        End If
        Return Nothing
    End Function

    Friend Sub DFLOWCalcs_Initialize(Optional ByVal aChoice As atcDataAttributes = Nothing)
        If aChoice Is Nothing Then
            ' This sets the initial values for DFLOW calculations - CMC, 7Q10
            DFLOWCalcs.fBioDefault = True
            DFLOWCalcs.fBioType = 0
            DFLOWCalcs.fBioPeriod = 1
            DFLOWCalcs.fBioYears = 3
            DFLOWCalcs.fBioCluster = 120
            DFLOWCalcs.fBioExcursions = 5

            DFLOWCalcs.fNonBioType = 0
            DFLOWCalcs.fAveragingPeriod = 7
            DFLOWCalcs.fReturnPeriod = 10
            DFLOWCalcs.fExplicitFlow = 1.0
            DFLOWCalcs.fPercentile = 0.1

            aChoice = New atcDataAttributes()
            With aChoice
                .SetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration))
                .SetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration))
                .SetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia))
                .SetValue(DFLOWAnalysis.InputNames.EDFlowType.Hydrological.ToString(), New Integer() {7, 10})
                .SetValue(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString(), 1.0)
                .SetValue(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString(), 0.1)
            End With
        Else
            With aChoice
                DFLOWCalcs.fBioDefault = .GetValue(DFLOWAnalysis.InputNames.BioUseDefault, True)
                DFLOWCalcs.fBioType = .GetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration)
                Dim lBio4Params() As Integer '= DFLOWCalcs.GetBioDefaultParams(DFLOWCalcs.fBioType)
                If DFLOWCalcs.fBioDefault Then
                    lBio4Params = DFLOWCalcs.GetBioDefaultParams(DFLOWCalcs.fBioType)
                Else
                    Select Case DFLOWCalcs.fBioType
                        Case DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration
                            lBio4Params = .GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWCalcs.fBioType))
                        Case DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration
                            lBio4Params = .GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWCalcs.fBioType))
                        Case DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia
                            lBio4Params = .GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWCalcs.fBioType))
                    End Select
                End If
                DFLOWCalcs.fBioPeriod = lBio4Params(0)
                DFLOWCalcs.fBioYears = lBio4Params(1)
                DFLOWCalcs.fBioCluster = lBio4Params(2)
                DFLOWCalcs.fBioExcursions = lBio4Params(3)

                DFLOWCalcs.fNonBioType = .GetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Hydrological)
                Dim lHydro2Params() As Integer = .GetValue(DFLOWAnalysis.InputNames.EDFlowType.Hydrological.ToString(), New Integer() {7, 10})
                DFLOWCalcs.fAveragingPeriod = lHydro2Params(0)
                DFLOWCalcs.fReturnPeriod = lHydro2Params(1)

                DFLOWCalcs.fExplicitFlow = .GetValue(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString(), 1.0)
                DFLOWCalcs.fPercentile = .GetValue(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString(), 0.1)
            End With
        End If
    End Sub

    Private Sub PopulateDFLOW(ByVal aTimeseriesGroup As atcTimeseriesGroup)
        ' This populates the DFLOW input form according to the DFLOW calculation values
        ckbBio.Checked = Not DFLOWCalcs.fBioDefault
        'rbBio1.Enabled = DFLOWCalcs.fBioDefault
        'rbBio2.Enabled = DFLOWCalcs.fBioDefault
        'rbBio3.Enabled = DFLOWCalcs.fBioDefault

        tbBio1.Enabled = ckbBio.Checked
        tbBio2.Enabled = ckbBio.Checked
        tbBio3.Enabled = ckbBio.Checked
        tbBio4.Enabled = ckbBio.Checked

        'Select Case DFLOWCalcs.fBioType
        '    Case 0
        '        rbBio1.Checked = True
        '    Case 1
        '        rbBio2.Checked = True
        '    Case 2
        '        rbBio3.Checked = True
        'End Select
        'tbBio1.Enabled = Not DFLOWCalcs.fBioDefault
        'tbBio2.Enabled = Not DFLOWCalcs.fBioDefault
        'tbBio3.Enabled = Not DFLOWCalcs.fBioDefault

        Dim lBioIdx As Integer
        'If DFLOWCalcs.fBioDefault Then
        '    lBioIdx = DFLOWCalcs.fBioType
        'Else
        lBioIdx = 3
        'End If

        RemoveHandler tbBio1.TextChanged, AddressOf tbBio1_TextChanged
        RemoveHandler tbBio2.TextChanged, AddressOf tbBio2_TextChanged
        RemoveHandler tbBio3.TextChanged, AddressOf tbBio3_TextChanged
        RemoveHandler tbBio4.TextChanged, AddressOf tbBio4_TextChanged

        'RemoveHandler tbNonBio1.TextChanged, AddressOf tbNonBio1_TextChanged
        'RemoveHandler tbNonBio2.TextChanged, AddressOf tbNonBio2_TextChanged
        RemoveHandler tbNonBio3.TextChanged, AddressOf tbNonBio3_TextChanged
        RemoveHandler tbNonBio4.TextChanged, AddressOf tbNonBio4_TextChanged


        If DFLOWCalcs.fBioFPArray(lBioIdx, 0) < 0 Then
            If pBatch Then
                tbBio1.Text = DFLOWCalcs.fBioPeriod.ToString()
            Else
                tbBio1.Text = ""
            End If
        Else
            If pBatch Then
                tbBio1.Text = DFLOWCalcs.fBioPeriod.ToString()
            Else
                tbBio1.Text = DFLOWCalcs.fBioFPArray(lBioIdx, 0)
            End If
        End If

        If DFLOWCalcs.fBioFPArray(lBioIdx, 1) < 0 Then
            If pBatch Then
                tbBio2.Text = DFLOWCalcs.fBioYears.ToString()
            Else
                tbBio2.Text = ""
            End If
        Else
            If pBatch Then
                tbBio2.Text = DFLOWCalcs.fBioYears.ToString()
            Else
                tbBio2.Text = DFLOWCalcs.fBioFPArray(lBioIdx, 1)
            End If
        End If

        If DFLOWCalcs.fBioFPArray(lBioIdx, 2) < 0 Then
            If pBatch Then
                tbBio3.Text = DFLOWCalcs.fBioExcursions.ToString()
            Else
                tbBio3.Text = ""
            End If
        Else
            If pBatch Then
                tbBio3.Text = DFLOWCalcs.fBioExcursions.ToString()
            Else
                tbBio3.Text = DFLOWCalcs.fBioFPArray(lBioIdx, 2)
            End If
        End If

        If DFLOWCalcs.fBioFPArray(lBioIdx, 3) < 0 Then
            If pBatch Then
                tbBio4.Text = DFLOWCalcs.fBioCluster.ToString()
            Else
                tbBio4.Text = ""
            End If
        Else
            If pBatch Then
                tbBio4.Text = DFLOWCalcs.fBioCluster.ToString()
            Else
                tbBio4.Text = DFLOWCalcs.fBioFPArray(lBioIdx, 3)
            End If
        End If

        'Select Case DFLOWCalcs.fNonBioType
        '    Case 0
        '        rbNonBio1.Checked = True
        '    Case 1
        '        rbNonBio2.Checked = True
        '    Case 2
        '        rbNonBio3.Checked = True
        'End Select

        'tbNonBio1.Text = DFLOWCalcs.fAveragingPeriod
        'tbNonBio2.Text = DFLOWCalcs.fReturnPeriod
        tbNonBio3.Text = DFLOWCalcs.fExplicitFlow
        tbNonBio4.Text = DFLOWCalcs.fPercentile

        AddHandler tbBio1.TextChanged, AddressOf tbBio1_TextChanged
        AddHandler tbBio2.TextChanged, AddressOf tbBio2_TextChanged
        AddHandler tbBio3.TextChanged, AddressOf tbBio3_TextChanged
        AddHandler tbBio4.TextChanged, AddressOf tbBio4_TextChanged

        AddHandler tbNonBio1.TextChanged, AddressOf tbNonBio1_TextChanged
        AddHandler tbNonBio2.TextChanged, AddressOf tbNonBio2_TextChanged
        AddHandler tbNonBio3.TextChanged, AddressOf tbNonBio3_TextChanged
        AddHandler tbNonBio4.TextChanged, AddressOf tbNonBio4_TextChanged

        'clbDataSets.Items.Clear()

        Dim lDateFormat As atcDateFormat
        lDateFormat = New atcDateFormat
        With lDateFormat
            .IncludeHours = False
            .IncludeMinutes = False
            .IncludeSeconds = False
        End With

        If aTimeseriesGroup IsNot Nothing AndAlso aTimeseriesGroup.Count > 0 Then
            'Dim lDataSet As atcDataSet
            'For Each lDataSet In aTimeseriesGroup
            '    Dim lString As String
            '    lString = lDataSet.Attributes.GetFormattedValue("Location") & " (" & _
            '              lDateFormat.JDateToString(lDataSet.Attributes.GetValue("start date")) & " - " & _
            '              lDateFormat.JDateToString(lDataSet.Attributes.GetValue("end date")) & ")"

            '    clbDataSets.Items.Add(lString, True)
            'Next
        End If
        chkNonBioChronic.Checked = True
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'DFLOWCalcs.fBioPeriod = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 0)
        'DFLOWCalcs.fBioYears = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 1)
        'DFLOWCalcs.fBioCluster = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 2)
        'DFLOWCalcs.fBioExcursions = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 3)
        'Dim lfrmResult As New DFLOWAnalysis.frmDFLOWResults(pDataGroup, , True)

        'This call ensure the season boundaries are applied to the data group before analysis begin
        SeasonsYearsFromForm()

        'build all scenarios
        If pDFLOWScenarios IsNot Nothing Then
            pDFLOWScenarios.Clear()
        Else
            pDFLOWScenarios = New atcCollection()
        End If
        Dim lAllScenariosBio As New atcCollection()
        Dim lAllScenariosNBio As New atcCollection()
        If chkBio1Acute.Checked Then
            lAllScenariosBio.Add(clsInteractiveDFLOW.EDFLOWPARAM.BIOAcute, clsInteractiveDFLOW.EDFLOWPARAM.BIOAcute)
        End If
        If chkBio2Chronic.Checked Then
            lAllScenariosBio.Add(clsInteractiveDFLOW.EDFLOWPARAM.BIOChronic, clsInteractiveDFLOW.EDFLOWPARAM.BIOChronic)
        End If
        If chkBio3Amm.Checked Then
            lAllScenariosBio.Add(clsInteractiveDFLOW.EDFLOWPARAM.BIOAmmonia, clsInteractiveDFLOW.EDFLOWPARAM.BIOAmmonia)
        End If
        If ckbBio.Checked Then
            lAllScenariosBio.Add(clsInteractiveDFLOW.EDFLOWPARAM.BIOCustom, clsInteractiveDFLOW.EDFLOWPARAM.BIOCustom)
        End If

        If chkNonBioAcute.Checked Then
            lAllScenariosNBio.Add(clsInteractiveDFLOW.EDFLOWPARAM.NBIOAcute, clsInteractiveDFLOW.EDFLOWPARAM.NBIOAcute)
        End If
        If chkNonBioChronic.Checked Then
            lAllScenariosNBio.Add(clsInteractiveDFLOW.EDFLOWPARAM.NBIOChronic, clsInteractiveDFLOW.EDFLOWPARAM.NBIOChronic)
        End If
        If chkNonBioCustom1.Checked Then
            lAllScenariosNBio.Add(clsInteractiveDFLOW.EDFLOWPARAM.NBIOCustom1, clsInteractiveDFLOW.EDFLOWPARAM.NBIOCustom1)
        End If
        If chkNonBioCustom2.Checked Then
            lAllScenariosNBio.Add(clsInteractiveDFLOW.EDFLOWPARAM.NBIOCustom2, clsInteractiveDFLOW.EDFLOWPARAM.NBIOCustom2)
        End If
        If chkNonBio2ExpFlow.Checked Then
            lAllScenariosNBio.Add(clsInteractiveDFLOW.EDFLOWPARAM.NBIOExplicitFlow, clsInteractiveDFLOW.EDFLOWPARAM.NBIOExplicitFlow)
        End If
        If chkNonBio3FlowPct.Checked Then
            lAllScenariosNBio.Add(clsInteractiveDFLOW.EDFLOWPARAM.NBIOFlowPCT, clsInteractiveDFLOW.EDFLOWPARAM.NBIOFlowPCT)
        End If
        If lAllScenariosBio.Count = 0 Then
            Logger.Msg("Need to specify at least one set of biological flow parameters.", MsgBoxStyle.Information, "DFLOW Analysis")
            Exit Sub
        End If
        If lAllScenariosNBio.Count = 0 Then
            Logger.Msg("Need to specify at least one set of non-biological flow parameters.", MsgBoxStyle.Information, "DFLOW Analysis")
            Exit Sub
        End If
        Dim lScenID As Integer = 1
        For Each lEScenBio As clsInteractiveDFLOW.EDFLOWPARAM In lAllScenariosBio
            For Each lEScenNBio As clsInteractiveDFLOW.EDFLOWPARAM In lAllScenariosNBio
                Dim lScen As New clsInteractiveDFLOW()
                Dim lBioIsValid As Boolean = True
                Dim lNBioIsValid As Boolean = True
                With lScen
                    .TypeBio = lEScenBio
                    Dim lBioMethodIndex As Integer = 0
                    Select Case lEScenBio
                        Case clsInteractiveDFLOW.EDFLOWPARAM.BIOAcute : lBioMethodIndex = 0
                        Case clsInteractiveDFLOW.EDFLOWPARAM.BIOChronic : lBioMethodIndex = 1
                        Case clsInteractiveDFLOW.EDFLOWPARAM.BIOAmmonia : lBioMethodIndex = 2
                        Case clsInteractiveDFLOW.EDFLOWPARAM.BIOCustom
                            lBioMethodIndex = 3
                            For I As Integer = 0 To 3
                                If DFLOWCalcs.fBioFPArray(lBioMethodIndex, I) > 0 Then
                                Else
                                    lBioIsValid = False
                                    Exit For
                                End If
                            Next
                    End Select
                    .ParamBio1FlowAvgDays = DFLOWCalcs.fBioFPArray(lBioMethodIndex, 0)
                    .ParamBio2YearsBetweenExcursion = DFLOWCalcs.fBioFPArray(lBioMethodIndex, 1)
                    .ParamBio3ExcursionClusterDays = DFLOWCalcs.fBioFPArray(lBioMethodIndex, 2)
                    .ParamBio4ExcursionPerCluster = DFLOWCalcs.fBioFPArray(lBioMethodIndex, 3)

                    .TypeNBio = lEScenNBio
                    Select Case lEScenNBio
                        Case clsInteractiveDFLOW.EDFLOWPARAM.NBIOAcute
                            .ParamNBioNDay = 1 : .ParamNBioReturn = 10
                        Case clsInteractiveDFLOW.EDFLOWPARAM.NBIOChronic
                            .ParamNBioNDay = 7 : .ParamNBioReturn = 10
                        Case clsInteractiveDFLOW.EDFLOWPARAM.NBIOCustom1
                            If Not Double.TryParse(txtNonBioCustomNday1.Text, .ParamNBioNDay) Then
                                .ParamNBioNDay = -99
                                lNBioIsValid = False
                            End If
                            If Not Double.TryParse(txtNonBioCustomReturn1.Text, .ParamNBioReturn) Then
                                .ParamNBioReturn = -99
                                lNBioIsValid = False
                            End If
                        Case clsInteractiveDFLOW.EDFLOWPARAM.NBIOCustom2
                            If Not Double.TryParse(txtNonBioCustomNday2.Text, .ParamNBioNDay) Then
                                .ParamNBioNDay = -99
                                lNBioIsValid = False
                            End If
                            If Not Double.TryParse(txtNonBioCustomReturn2.Text, .ParamNBioReturn) Then
                                .ParamNBioReturn = -99
                                lNBioIsValid = False
                            End If
                        Case clsInteractiveDFLOW.EDFLOWPARAM.NBIOExplicitFlow
                            If Not Double.TryParse(tbNonBio3.Text, .ParamNBioExpFlow) Then
                                .ParamNBioExpFlow = -99
                                lNBioIsValid = False
                            End If
                        Case clsInteractiveDFLOW.EDFLOWPARAM.NBIOFlowPCT
                            If Not Double.TryParse(tbNonBio4.Text, .ParamNBioFlowPct) Then
                                .ParamNBioFlowPct = -99
                                lNBioIsValid = False
                            End If
                    End Select
                    If Not chkHarmonicMean.Checked Then
                        .CalculateHM = False
                    End If
                End With
                If lBioIsValid AndAlso lNBioIsValid Then
                    pDFLOWScenarios.Add(lScenID, lScen)
                    lScenID += 1
                End If
            Next 'lEScenNBio 
        Next 'lEScenBio
        If pDFLOWScenarios.Count > 0 Then
            Dim lIsSeasonal As String = IsSeasonal()
            If pDataGroup IsNot Nothing AndAlso pDataGroup.Count > 0 Then
                Dim lInputArgs As atcDataAttributes = Me.DateArgsFromForm()
                With lInputArgs
                    .SetValue(DFLOWReportUtil.Info.i_Version, "4.x")
                    .SetValue(DFLOWReportUtil.Info.i_BuildDate, "6/30/2016")
                    Dim lRunDateTime As DateTime = Now()
                    With lRunDateTime
                        Dim lRunDateTimeRecord As String = .Month & "/" & .Day & "/" & .Year & " " & .Hour & ":" & .Minute
                        lInputArgs.SetValue(DFLOWReportUtil.Info.i_RunDateTime, lRunDateTimeRecord)
                    End With
                    .SetValue(DFLOWReportUtil.Info.i_Username, Environment.UserName)
                    .SetValue(DFLOWReportUtil.Info.i_SeasonStartDate, .GetValue(InputNamesDFLOW.StartDay) & "-" & DateAndTime.MonthName(.GetValue(InputNamesDFLOW.StartMonth), True))
                    .SetValue(DFLOWReportUtil.Info.i_SeasonEndDate, .GetValue(InputNamesDFLOW.EndDay) & "-" & DateAndTime.MonthName(.GetValue(InputNamesDFLOW.EndMonth), True))
                    Dim lStartYear As Integer = .GetValue(InputNamesDFLOW.StartYear)
                    Dim lEndYear As Integer = .GetValue(InputNamesDFLOW.EndYear)
                    .SetValue(DFLOWReportUtil.Info.i_YearsIncluded, lEndYear - lStartYear + 1)
                    .SetValue(DFLOWReportUtil.Info.i_SeasonStartYear, lStartYear)
                    .SetValue(DFLOWReportUtil.Info.i_SeasonEndYear, lEndYear)
                    If lIsSeasonal.StartsWith("seasonal") Then
                        .SetValue(DFLOWReportUtil.Info.i_Seasonal, True)
                    Else
                        .SetValue(DFLOWReportUtil.Info.i_Seasonal, False)
                    End If
                End With
                For Each lScen As clsInteractiveDFLOW In pDFLOWScenarios
                    Dim lBioParam As New atcCollection()
                    With lBioParam
                        .Add(InputNamesDFLOW.BioAvgPeriod, lScen.ParamBio1FlowAvgDays)
                        .Add(InputNamesDFLOW.BioReturnYears, lScen.ParamBio2YearsBetweenExcursion)
                        .Add(InputNamesDFLOW.BioClusterDays, lScen.ParamBio3ExcursionClusterDays)
                        .Add(InputNamesDFLOW.BioNumExcrsnPerCluster, lScen.ParamBio4ExcursionPerCluster)
                        Select Case lScen.TypeBio
                            Case clsInteractiveDFLOW.EDFLOWPARAM.BIOAcute : .Add("type_" & InputNamesDFLOW.EBioDFlowType.Acute_maximum_concentration.ToString())
                            Case clsInteractiveDFLOW.EDFLOWPARAM.BIOChronic : .Add("type_" & InputNamesDFLOW.EBioDFlowType.Chronic_continuous_concentration.ToString())
                            Case clsInteractiveDFLOW.EDFLOWPARAM.BIOAmmonia : .Add("type_" & InputNamesDFLOW.EBioDFlowType.Ammonia.ToString())
                            Case clsInteractiveDFLOW.EDFLOWPARAM.BIOCustom : .Add("type_" & InputNamesDFLOW.EBioDFlowType.Custom.ToString())
                        End Select
                    End With

                    Dim lNBioParam As New atcCollection()
                    With lNBioParam
                        Select Case lScen.TypeNBio
                            Case clsInteractiveDFLOW.EDFLOWPARAM.NBIOAcute, clsInteractiveDFLOW.EDFLOWPARAM.NBIOChronic, clsInteractiveDFLOW.EDFLOWPARAM.NBIOCustom1, clsInteractiveDFLOW.EDFLOWPARAM.NBIOCustom2
                                .Add("type_" & InputNamesDFLOW.EDFlowType.Hydrological.ToString())
                                .Add(InputNamesDFLOW.NBioAveragingPeriod, lScen.ParamNBioNDay)
                                .Add(InputNamesDFLOW.NBioReturnPeriod, lScen.ParamNBioReturn)
                            Case clsInteractiveDFLOW.EDFLOWPARAM.NBIOExplicitFlow
                                .Add("type_" & InputNamesDFLOW.EDFlowType.Explicit_Flow_Value.ToString())
                                .Add(InputNamesDFLOW.NBioExplicitFlow, lScen.ParamNBioExpFlow)
                            Case clsInteractiveDFLOW.EDFLOWPARAM.NBIOFlowPCT
                                .Add("type_" & InputNamesDFLOW.EDFlowType.Flow_Percentile.ToString())
                                .Add(InputNamesDFLOW.NBioFlowPercentile, lScen.ParamNBioFlowPct)
                                'Case clsInteractiveDFLOW.EDFLOWPARAM.NBIOCustom1, clsInteractiveDFLOW.EDFLOWPARAM.NBIOCustom2
                                '    .Add("type_" & InputNamesDFLOW.EDFlowType.Custom.ToString())
                                '    .Add(InputNamesDFLOW.NBioAveragingPeriod, lScen.ParamNBioNDay)
                                '    .Add(InputNamesDFLOW.NBioReturnPeriod, lScen.ParamNBioReturn)
                        End Select
                    End With
                    With lInputArgs
                        .SetValue("ExcursionCountArray", lScen.ExcursionCountArray)
                        .SetValue("ExcursionsArray", lScen.ExcursionsArray)
                        .SetValue("ClustersArray", lScen.ClustersArray)
                    End With
                    lScen.DataGroup = pDataGroup
                    lScen.ReportSrc = DFLOWCalcs.DFLOWToGrid(pDataGroup, lBioParam, lNBioParam, lInputArgs, True)
                    lNBioParam.Clear() : lNBioParam = Nothing
                    lBioParam.Clear() : lBioParam = Nothing
                Next 'lScen

                'Dim lReportSrc As New atcControls.atcGridSource()
                'Dim lTableTemplate As atcControls.atcGridSource = pDFLOWScenarios(0).ReportSrc
                'With lReportSrc
                '    .FixedRows = 1
                '    .Rows = 1
                '    .Columns = lTableTemplate.Columns + 4 + 4 + 1
                '    Dim I As Integer
                '    For I = 0 To .Columns - 1
                '        .CellValue(0, I) = lTableTemplate.CellValue(0, I)
                '    Next
                '    I = lTableTemplate.Columns
                '    .CellValue(0, I) = "B_NDay"
                '    .CellValue(0, I + 1) = "B_Return"
                '    .CellValue(0, I + 2) = "B_ClusterDays"
                '    .CellValue(0, I + 3) = "B_ExcPerCluster"
                '    .CellValue(0, I + 4) = "NB_NDay"
                '    .CellValue(0, I + 5) = "NB_Return"
                '    .CellValue(0, I + 6) = "NB_FlowValue"
                '    .CellValue(0, I + 7) = "NB_Flow%"
                '    '.CellValue(0, I + 8) = "HM"
                '    .CellValue(0, I + 8) = "ScenID"

                '    .Rows = 2
                '    Dim lSuperRowIndex As Integer = .Rows - 1
                '    Dim lScen As clsInteractiveDFLOW = Nothing
                '    For Each lScenarioID As Integer In pDFLOWScenarios.Keys
                '        lScen = pDFLOWScenarios.ItemByKey(lScenarioID)
                '        For lRow As Integer = 1 To lScen.ReportSrc.Rows - 1
                '            Dim lCol As Integer = 0
                '            For lCol = 0 To lTableTemplate.Columns - 1
                '                .CellValue(.Rows - 1, lCol) = lScen.ReportSrc.CellValue(lRow, lCol)
                '            Next
                '            lCol = lTableTemplate.Columns
                '            .CellValue(lSuperRowIndex, lCol) = lScen.ParamBio1FlowAvgDays
                '            .CellValue(lSuperRowIndex, lCol + 1) = lScen.ParamBio2YearsBetweenExcursion
                '            .CellValue(lSuperRowIndex, lCol + 2) = lScen.ParamBio3ExcursionClusterDays
                '            .CellValue(lSuperRowIndex, lCol + 3) = lScen.ParamBio4ExcursionPerCluster
                '            If lScen.ParamNBioNDay > 0 Then
                '                .CellValue(lSuperRowIndex, lCol + 4) = lScen.ParamNBioNDay
                '                .CellValue(lSuperRowIndex, lCol + 5) = lScen.ParamNBioReturn
                '            Else
                '                .CellValue(lSuperRowIndex, lCol + 4) = "-"
                '                .CellValue(lSuperRowIndex, lCol + 5) = "-"
                '            End If
                '            If lScen.ParamNBioExpFlow > 0 Then
                '                .CellValue(lSuperRowIndex, lCol + 6) = lScen.ParamNBioExpFlow
                '            Else
                '                .CellValue(lSuperRowIndex, lCol + 6) = "-"
                '            End If
                '            If lScen.ParamNBioFlowPct > 0 Then
                '                .CellValue(lSuperRowIndex, lCol + 7) = lScen.ParamNBioFlowPct
                '            Else
                '                .CellValue(lSuperRowIndex, lCol + 7) = "-"
                '            End If
                '            '.CellValue(lSuperRowIndex, lCol + 8) = GetTserHM(.CellValue(lSuperRowIndex, 0), .CellValue(lSuperRowIndex, 1))
                '            .CellValue(lSuperRowIndex, lCol + 8) = lScenarioID
                '            .Rows = .Rows + 1
                '            lSuperRowIndex = .Rows - 1
                '        Next
                '    Next
                'End With

                Dim lReportSrc As atcControls.atcGridSource = Nothing
                Dim lReportGrid As New frmDFLOWResults(pDataGroup, ,, True)
                lReportGrid.UserSpecifyDFLOWResults(lReportSrc, pDFLOWScenarios, lInputArgs) 'pDFLOWScenarios(0).ReportSrc)
            End If 'has dataset(s)
        End If 'has scenario(s)
    End Sub

    Private Function DateArgsFromForm() As atcDataAttributes
        Dim lFirstYear As Integer
        Dim lStartMonth As Integer
        Dim lStartDay As Integer
        Dim lLastYear As Integer
        Dim lEndMonth As Integer
        Dim lEndDay As Integer
        lStartDay = 1
        If radioHigh.Checked Then
            lStartMonth = 10
            lEndMonth = 9
            lEndDay = 30
        ElseIf radioLow.Checked Then
            lStartMonth = 4
            lEndMonth = 3
            lEndDay = 31
        End If
        Dim lInputArgs As New atcDataAttributes()
        With lInputArgs
            If Integer.TryParse(txtOmitBeforeYear.Text, lFirstYear) Then
                If lFirstYear > 1900 Then .SetValue(InputNamesDFLOW.StartYear, lFirstYear)
            Else
                .SetValue(InputNamesDFLOW.StartYear, 0)
            End If
            If Integer.TryParse(txtOmitAfterYear.Text, lLastYear) Then
                If lLastYear > 1900 AndAlso lLastYear > lFirstYear Then .SetValue(InputNamesDFLOW.EndYear, lLastYear)
            Else
                .SetValue(InputNamesDFLOW.EndYear, 0)
            End If
            If cboStartMonth.SelectedIndex >= 0 Then
                lStartMonth = cboStartMonth.SelectedIndex + 1
            End If
            .SetValue(InputNamesDFLOW.StartMonth, lStartMonth)
            If cboEndMonth.SelectedIndex >= 0 Then
                lEndMonth = cboEndMonth.SelectedIndex + 1
            End If
            .SetValue(InputNamesDFLOW.EndMonth, lEndMonth)

            Integer.TryParse(txtStartDay.Text, lStartDay)
            If lStartDay <= 0 OrElse lStartDay > DayMon(2000, lStartMonth) Then
                lStartDay = 1
            End If
            .SetValue(InputNamesDFLOW.StartDay, lStartDay)
            Integer.TryParse(txtEndDay.Text, lEndDay)
            If lEndDay < 0 OrElse lEndDay > DayMon(2000, lEndMonth) Then
                lEndDay = DayMon(2000, lEndMonth)
            End If
            .SetValue(InputNamesDFLOW.EndDay, lEndDay)
        End With
        Return lInputArgs
    End Function

    Private Function GetTserHM(ByVal aStationInfo As String, ByVal aDuration As String) As Double
        Dim lStationID As String = aStationInfo.Substring(0, aStationInfo.IndexOf(" "))
        Dim lTsers As atcTimeseriesGroup = pDataGroup.FindData("Location", lStationID)
        If lTsers IsNot Nothing AndAlso lTsers.Count > 0 Then
            Dim lBeginTime As String = aDuration.Substring(0, aDuration.IndexOf(" "))
            Dim lEndTime As String = aDuration.Substring(aDuration.LastIndexOf(" ") + 1)
            Dim lDate0 As DateTime
            Dim lDate1 As DateTime
            If DateTime.TryParse(lBeginTime, lDate0) AndAlso DateTime.TryParse(lEndTime, lDate1) Then
                Dim lITsOK As String = "OK"
                Dim latcDate0 As Double = Date2J(lDate0.Year, lDate0.Month, lDate0.Day)
                Dim latcDate1 As Double = Date2J(lDate1.Year, lDate1.Month, lDate1.Day, 24, 0, 0)
                Dim lTs As atcTimeseries = SubsetByDate(lTsers(0), latcDate0, latcDate1, Nothing)
                Dim lHM As Double = lTs.Attributes.GetValue("Harmonic Mean", GetNaN())
                lTs.Clear() : lTs = Nothing
                Return lHM
            Else
                Return lTsers(0).Attributes.GetValue("Harmonic Mean", GetNaN())
            End If
        Else
            Return GetNaN()
        End If
    End Function
    Private Sub chkNonBioCustom1_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonBioCustom1.CheckedChanged
        If chkNonBioCustom1.Checked Then
            txtNonBioCustomNday1.Enabled = True
            txtNonBioCustomReturn1.Enabled = True
        Else
            txtNonBioCustomNday1.Enabled = False
            txtNonBioCustomReturn1.Enabled = False
        End If
    End Sub

    Private Sub chkNonBioCustom2_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonBioCustom2.CheckedChanged
        If chkNonBioCustom2.Checked Then
            txtNonBioCustomNday2.Enabled = True
            txtNonBioCustomReturn2.Enabled = True
        Else
            txtNonBioCustomNday2.Enabled = False
            txtNonBioCustomReturn2.Enabled = False
        End If
    End Sub

    Private Sub chkNonBio2ExpFlow_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonBio2ExpFlow.CheckedChanged
        tbNonBio3.Enabled = chkNonBio2ExpFlow.Checked
    End Sub

    Private Sub chkNonBio3FlowPct_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonBio3FlowPct.CheckedChanged
        tbNonBio4.Enabled = chkNonBio3FlowPct.Checked
    End Sub

#End Region '"DFLOW"

    Private Sub btnOTnone_Click(sender As Object, e As EventArgs) Handles btnOTnone.Click
        With grdStations
            For I As Integer = 0 To .Rows().Count - 1
                .Item(0, I).Value = False
            Next
        End With
    End Sub

    Private Sub btnOTall_Click(sender As Object, e As EventArgs) Handles btnOTall.Click
        With grdStations
            Dim lStatVal As Double
            For I As Integer = 0 To .Rows().Count - 1
                If Not String.IsNullOrEmpty(.Item(6, I).Value) AndAlso Not Double.TryParse(.Item(6, I).Value, lStatVal) Then
                    .Item(0, I).Value = False
                    Continue For
                Else
                    .Item(0, I).Value = True
                End If
            Next
        End With
    End Sub

    Private Sub btnOutliers_Click(sender As Object, e As EventArgs) Handles btnOutliers.Click
        'Logger.Msg("Outlier Test is under development.", MsgBoxStyle.Exclamation, "Group Outlier Test")
        'Exit Sub
        If pDataGroup.Count < 5 Then
            Logger.Msg("Need to have at least 5 stations to perform the outlier test.", MsgBoxStyle.Exclamation, "Group Outlier Test")
            Exit Sub
        End If
        Dim lOTStatName As String = "7Low10"
        'Get selection station ids
        Dim lNewGroup As New atcTimeseriesGroup()
        Dim lTs As atcTimeseries = Nothing
        Dim lStatVal As Double
        Dim lLat As Double
        Dim lLong As Double
        Dim lDA As Double
        Dim lRowIndices As New atcCollection()
        Dim lTestInputsMissingInSelected As Boolean = False
        With grdStations
            For I As Integer = 0 To .Rows().Count - 1
                If .Item(0, I).Value Then
                    lTs = pDataGroup.FindData("Location", .Item(1, I).Value)(0)
                    lStatVal = lTs.Attributes.GetValue(lOTStatName, Double.NaN)
                    lLat = lTs.Attributes.GetValue("Latitude", Double.NaN)
                    lLong = lTs.Attributes.GetValue("Longitude", Double.NaN)
                    lDA = lTs.Attributes.GetValue("Drainage Area", Double.NaN)

                    'Allow users to type in the lat, long, and 7Q10 statistic into the grid and use them
                    If Double.IsNaN(lStatVal) Then
                        If Not Double.TryParse(.Item(6, I).Value, lStatVal) Then
                            lStatVal = Double.NaN
                        End If
                    End If
                    If Double.IsNaN(lLat) Then
                        If Not Double.TryParse(.Item(2, I).Value, lLat) Then
                            lLat = Double.NaN
                        End If
                    End If
                    If Double.IsNaN(lLong) Then
                        If Not Double.TryParse(.Item(3, I).Value, lLong) Then
                            lLong = Double.NaN
                        End If
                    End If
                    If Not Double.IsNaN(lStatVal) AndAlso Not Double.IsNaN(lLat) AndAlso Not Double.IsNaN(lLong) AndAlso Not Double.IsNaN(lDA) Then
                        lNewGroup.Add(lTs)
                        lRowIndices.Add(.Item(1, I).Value, I)
                    Else
                        'lNewGroup.Clear()
                        'lNewGroup = Nothing
                        'Logger.Msg("Need to calculate the required flow statistics first for the following station:" & vbCrLf & .Item(1, I).Value,
                        '           MsgBoxStyle.Exclamation, "Outliers Test")
                        'Exit Sub

                        'If row is selected, but missing required data, the unselect it.
                        .Item(0, I).Value = False
                        lTestInputsMissingInSelected = True
                    End If
                Else
                    .Item(7, I).Value = ""
                End If
            Next
        End With
        If lTestInputsMissingInSelected Then
            Logger.Msg("Some selected stations are excluded due to missing latitude, longitude, drainage area, or 7Q10 statistics.",
                       MsgBoxStyle.Information, "Group Outlier Test")
        End If
        If lNewGroup.Count < 5 Then
            Logger.Msg("Need to select at least 5 stations to perform the outlier test.", MsgBoxStyle.Information, "Group Outlier Test")
            Exit Sub
        End If
        'Do the outliers test
        'Dim lRresults As String = OutlierTest(lNewGroup)
        'rtBoxOT.AppendText(lRresults)
        Dim lRowToUpdate As Integer = 0
        Dim lRTable As atcTableDelimited = OutlierTest(lNewGroup)
        If lRTable IsNot Nothing Then
            With lRTable
                .MoveFirst()
                While Not .EOF()
                    If Not String.IsNullOrEmpty(.Value(1)) Then
                        lRowToUpdate = lRowIndices.ItemByKey(.Value(1))
                        grdStations.Item(7, lRowToUpdate).Value = .Value(7)
                        If String.IsNullOrEmpty(grdStations.Item(6, lRowToUpdate).Value) Then
                            grdStations.Item(6, lRowToUpdate).Value = .Value(6)
                        End If
                    End If
                    .MoveNext()
                End While
            End With
            lRTable.Clear()
            lRTable = Nothing
        End If
        lNewGroup.Clear()
        lNewGroup = Nothing
    End Sub

    ''' <summary>
    ''' Do outliers test by calling R script
    ''' </summary>
    ''' <param name="aDataGroup">A group of flow time series that already have the required flow stat calculated</param>
    ''' <returns></returns>
    Private Function OutlierTest(ByVal aDataGroup As atcTimeseriesGroup) As atcTableDelimited 'String
        If aDataGroup Is Nothing OrElse aDataGroup.Count = 0 Then Return Nothing
        Dim lOTStatName As String = "7Low10"

        Dim lRTable As New atcTableDelimited()
        With lRTable
            .Delimiter = ","
            .NumFields = 7
            .FieldName(1) = "StationID"
            .FieldName(2) = "Lat"
            .FieldName(3) = "Long"
            .FieldName(4) = "From"
            .FieldName(5) = "To"
            .FieldName(6) = "7Q10"
            .FieldName(7) = "IsOutlier"
            .CurrentRecord = 1
        End With

        Dim lRresult As String
        Dim lStatNDayTser As atcTimeseries = Nothing
        Dim lStationID As String
        Dim latString As String
        Dim longString As String
        Dim lFrom As String
        Dim lTo As String
        Dim lStatVal As Double
        Dim lOTLbl As String
        Dim lDateFormat = New atcDateFormat()
        With lDateFormat
            .IncludeMonths = False
            .IncludeDays = False
            .IncludeHours = False
            .IncludeMinutes = False
            .IncludeSeconds = False
        End With

        Logger.Status("Running R K Ratio Station Outlier Testing...")
        Dim lProgIndex As Integer = 1
        For Each lTs As atcTimeseries In aDataGroup
            With lTs.Attributes
                lStationID = .GetValue("Location")
                lRresult = RunKRatioStationsTest(aDataGroup, lOTStatName, lStationID)
                lStatNDayTser = .GetDefinedValue("7Q10").Arguments.GetValue("NDayTimeseries")
                lFrom = lDateFormat.JDateToString(lStatNDayTser.Dates.Value(0))
                lTo = lDateFormat.JDateToString(lStatNDayTser.Dates.Value(lStatNDayTser.numValues))
                lStatVal = lTs.Attributes.GetValue(lOTStatName)
                lRTable.Value(1) = lStationID
                lRTable.Value(2) = .GetValue("Latitude")
                lRTable.Value(3) = .GetValue("Longitude")
                lRTable.Value(4) = lFrom
                lRTable.Value(5) = lTo
                lRTable.Value(6) = DoubleToString(lStatVal, 15, "0.##########", aSignificantDigits:=8)
                If lRresult = "TRUE" Then
                    lRTable.Value(7) = "No"
                ElseIf lRresult = "FALSE" Then
                    lRTable.Value(7) = "Yes"
                Else
                    lRTable.Value(7) = lRresult
                End If
                lRTable.CurrentRecord += 1
            End With
            Logger.Progress("Outlier Testing: " & lStationID, lProgIndex, aDataGroup.Count)
            lProgIndex += 1
        Next
        'Dim lRTableFW As New atcTableFixed()
        'With lRTableFW
        '    .NumFields = 7
        '    .FieldName(1) = "StationID"
        '    .FieldName(2) = "Lat"
        '    .FieldName(3) = "Long"
        '    .FieldName(4) = "From"
        '    .FieldName(5) = "To"
        '    .FieldName(6) = "7Q10"
        '    .FieldName(7) = "IsOutlier"
        '    .FieldLength(1) = 10
        '    .FieldLength(2) = 10
        '    .FieldLength(3) = 10
        '    .FieldLength(4) = 5
        '    .FieldLength(5) = 5
        '    .FieldLength(6) = 10
        '    .FieldLength(7) = 10
        'End With

        'Format the result table
        'Dim lResultBuilder As New System.Text.StringBuilder()
        'lResultBuilder.Append("StationID".PadLeft(10, " "))
        'lResultBuilder.Append("Lat".PadLeft(10, " "))
        'lResultBuilder.Append("Long".PadLeft(10, " "))
        'lResultBuilder.Append("From".PadLeft(6, " "))
        'lResultBuilder.Append("To".PadLeft(6, " "))
        'lResultBuilder.Append("7Q10".PadLeft(10, " "))
        'lResultBuilder.AppendLine("IsOutlier".PadLeft(10, " "))
        'With lRTable
        '    .MoveFirst()
        '    While Not .EOF
        '        lResultBuilder.Append(.Value(1).PadLeft(10, " "))
        '        lResultBuilder.Append(.Value(2).PadLeft(10, " "))
        '        lResultBuilder.Append(.Value(3).PadLeft(10, " "))
        '        lResultBuilder.Append(.Value(4).PadLeft(6, " "))
        '        lResultBuilder.Append(.Value(5).PadLeft(6, " "))
        '        lResultBuilder.Append(.Value(6).PadLeft(10, " "))
        '        lResultBuilder.AppendLine(.Value(7).PadLeft(10, " "))
        '        .MoveNext()
        '    End While
        'End With

        'Return lRTable.ToString()
        'Return lResultBuilder.ToString()
        'lRTable.Clear()
        Return lRTable
    End Function

    Private Sub btnOTCalculateStats_Click(sender As Object, e As EventArgs) Handles btnOTCalculateStats.Click
        Dim lOTStatName As String = "7Low10"
        Dim lNeedToRecalculate As Boolean = False
        With grdStations
            Dim lStationID As String
            Dim lStatVal As Double
            For I As Integer = 0 To .Rows().Count - 1
                lStationID = .Item(1, I).Value
                Dim lTs As atcTimeseries = pDataGroup.FindData("Location", lStationID)(0)
                lStatVal = lTs.Attributes.GetValue(lOTStatName, Double.NaN)
                If Double.IsNaN(lStatVal) Then
                    lNeedToRecalculate = True
                    Exit For
                End If
            Next
        End With
        If lNeedToRecalculate Then
            Dim lWaitTime As Double = 10000
            Dim lNDays(0) As Double : lNDays(0) = 7
            Dim lReturns(0) As Double : lReturns(0) = 10
            'recalculate for all time series in the data group
            'using the current settings including season starts etc
            Dim lNewGroup As New atcTimeseriesGroup()
            Logger.Status("Calculating NDay Statistics...")
            For J As Integer = 0 To pDataGroup.Count - 1
                lNewGroup.Add(pDataGroup(J))
                Try
                    Calculate("n-day low value", lReturns, lNDays, lNewGroup)
                    'Dim lInputs As New atcDataAttributes()
                    'With lInputs
                    '    .SetValue("NDayOpn", "n-day low value")
                    '    .SetValue("Returns", lReturns)
                    '    .SetValue("NDays", lNDays)
                    '    .SetValue("DataGroup", lNewGroup)
                    'End With
                    'pSW.Reset()
                    'pSW.Start()
                    'BackgroundWorker1.RunWorkerAsync(lInputs)
                    'While BackgroundWorker1.IsBusy
                    '    If pSW.ElapsedMilliseconds > 10000 Then
                    '        BackgroundWorker1.Dispose()
                    '    End If
                    'End While
                Catch ex As Exception
                    pDataGroup(J).Attributes.RemoveByKey(lOTStatName)
                End Try
                lNewGroup.Clear()
                Logger.Progress("Calculated 7Q10 for " & pDataGroup(J).Attributes.GetValue("Location"), J + 1, pDataGroup.Count)
            Next
            lNewGroup.Clear()
            lNewGroup = Nothing
        End If
        RepopulateOTGrid()
    End Sub

    'Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '    Dim lInputs As atcDataAttributes = e.Argument
    '    Dim lOpn As String = lInputs.GetValue("NDayOpn")
    '    Dim lReturns() As Double = lInputs.GetValue("Returns")
    '    Dim lNDays() As Double = lInputs.GetValue("NDays")
    '    Dim lDataGroup As atcTimeseriesGroup = lInputs.GetValue("DataGroup")
    '    Calculate(lOpn, lReturns, lNDays, lDataGroup)
    'End Sub

    Private Sub RepopulateOTGrid()
        Dim lOTStatName As String = "7Low10"
        Dim lStationID As String
        Dim lStatVal As Double
        Dim lFrom As String = ""
        Dim lTo As String = ""

        Dim lDateFormat = New atcDateFormat()
        With lDateFormat
            .IncludeMonths = False
            .IncludeDays = False
            .IncludeHours = False
            .IncludeMinutes = False
            .IncludeSeconds = False
        End With

        With grdStations
            Dim lDefinedVal As atcDefinedValue = Nothing
            Dim lTs As atcTimeseries = Nothing
            Dim lStatNDayTser As atcTimeseries = Nothing
            For I As Integer = 0 To .Rows().Count - 1
                lStationID = .Item(1, I).Value
                lTs = pDataGroup.FindData("Location", lStationID)(0)
                lDefinedVal = lTs.Attributes.GetDefinedValue("7Q10")
                If lDefinedVal IsNot Nothing Then
                    lStatNDayTser = lDefinedVal.Arguments.GetValue("NDayTimeseries")
                    lFrom = lDateFormat.JDateToString(lStatNDayTser.Dates.Value(0))
                    lTo = lDateFormat.JDateToString(lStatNDayTser.Dates.Value(lStatNDayTser.numValues))
                Else
                    lFrom = "N/A"
                    lTo = "N/A"
                End If
                .Item(4, I).Value = lFrom
                .Item(5, I).Value = lTo
                With lTs.Attributes
                    If .ContainsAttribute(lOTStatName & "Adj") Then
                        lStatVal = .GetValue(lOTStatName & "Adj", Double.NaN)
                    Else
                        lStatVal = .GetValue(lOTStatName, Double.NaN)
                    End If
                End With
                If Not Double.IsNaN(lStatVal) Then
                    .Item(6, I).Value = DoubleToString(lStatVal, 15, "0.##########", aSignificantDigits:=8)
                Else
                    .Item(6, I).Value = "NA, <3yr"
                End If
            Next
        End With
    End Sub
End Class

