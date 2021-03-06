Imports System.Drawing
Imports atcUtility
Imports atcMwGisUtility
Imports MapWinUtility
Imports atcControls
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports HTMLBuilder

Friend Class frmMercury
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnSimulate As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents tabResults As System.Windows.Forms.TabPage
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents tabMercury As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tabHydrology As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGridSize As System.Windows.Forms.Label
    Friend WithEvents cboSubbasinLayer As System.Windows.Forms.ComboBox
    Friend WithEvents lblSubbasinsLayer As System.Windows.Forms.Label
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Public WithEvents SSTab1 As System.Windows.Forms.TabControl
    Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents framehydro As System.Windows.Forms.GroupBox
    Public WithEvents txtInitialSoilMoistureConstant As System.Windows.Forms.TextBox
    Public WithEvents cboInitialSoilMoisture As System.Windows.Forms.ComboBox
    Public WithEvents txtbCNNonGrow As System.Windows.Forms.TextBox
    Public WithEvents txtaCNNonGrow As System.Windows.Forms.TextBox
    Public WithEvents txtaCNGrow As System.Windows.Forms.TextBox
    Public WithEvents txtbCNGrow As System.Windows.Forms.TextBox
    Public WithEvents optFieldCapacity As System.Windows.Forms.RadioButton
    Public WithEvents optConstSoilMoisture As System.Windows.Forms.RadioButton
    Public WithEvents txtInitialAccuSnowConstant As System.Windows.Forms.TextBox
    Public WithEvents txtHydroP2Rainfall As System.Windows.Forms.TextBox
    Public WithEvents btnP2Map As System.Windows.Forms.Button
    Public WithEvents optInputSoilMoisture As System.Windows.Forms.RadioButton
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label63 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label62 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents Label65 As System.Windows.Forms.Label
    Public WithEvents Label101 As System.Windows.Forms.Label
    Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtHgLandUnsaturatedSoilDepth As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandBedrockDepth As System.Windows.Forms.TextBox
    Public WithEvents Label111 As System.Windows.Forms.Label
    Public WithEvents Label64 As System.Windows.Forms.Label
    Public WithEvents fraGroundWater As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents txtInitialShallowGWConstant As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents txtHydroGWSeepageCoeff As System.Windows.Forms.TextBox
    Public WithEvents txtHydroGWRecessionCoeff As System.Windows.Forms.TextBox
    Public WithEvents Label107 As System.Windows.Forms.Label
    Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents FrameStreamParam As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents txtHydroManningCoeff As System.Windows.Forms.TextBox
    Public WithEvents cboRegions As System.Windows.Forms.ComboBox
    Public WithEvents txtAlphaDepth As System.Windows.Forms.TextBox
    Public WithEvents txtBetaDepth As System.Windows.Forms.TextBox
    Public WithEvents txtAlphaWidth As System.Windows.Forms.TextBox
    Public WithEvents txtBetaWidth As System.Windows.Forms.TextBox
    Public WithEvents txtCrossSectionSlope1 As System.Windows.Forms.TextBox
    Public WithEvents txtCrossSectionSlope2 As System.Windows.Forms.TextBox
    Public WithEvents PictureChannel As System.Windows.Forms.PictureBox
    Public WithEvents Label102 As System.Windows.Forms.Label
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents Label66 As System.Windows.Forms.Label
    Public WithEvents Label67 As System.Windows.Forms.Label
    Public WithEvents _SSTab1_TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents LakeAttributes As System.Windows.Forms.GroupBox
    Public WithEvents txtHydroOrificeDepth As System.Windows.Forms.TextBox
    Public WithEvents txtLakeInfiltration As System.Windows.Forms.TextBox
    Public WithEvents txtBankFullDepth As System.Windows.Forms.TextBox
    Public WithEvents txtInitWaterDepth As System.Windows.Forms.TextBox
    Public WithEvents txtLakesThreshold As System.Windows.Forms.TextBox
    Public WithEvents txtHydroOrificeDia As System.Windows.Forms.TextBox
    Public WithEvents txtHydroOrificeDischargeCoeff As System.Windows.Forms.TextBox
    Public WithEvents txtHydroWeirCrestLength As System.Windows.Forms.TextBox
    Public WithEvents txtHydroWeirDischargeCoeff As System.Windows.Forms.TextBox
    Public WithEvents txtHydroEvapoCoeff As System.Windows.Forms.TextBox
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents Label38 As System.Windows.Forms.Label
    Public WithEvents Label39 As System.Windows.Forms.Label
    Public WithEvents Label40 As System.Windows.Forms.Label
    Public WithEvents Label41 As System.Windows.Forms.Label
    Public WithEvents Label42 As System.Windows.Forms.Label
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents Label44 As System.Windows.Forms.Label
    Public WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents tabSediment As System.Windows.Forms.TabPage
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Public WithEvents subtabSediment As System.Windows.Forms.TabControl
    Public WithEvents TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtLakeInitialSediment As System.Windows.Forms.TextBox
    Public WithEvents txtSedEquilibriumConc As System.Windows.Forms.TextBox
    Public WithEvents txtSedDecayConstant As System.Windows.Forms.TextBox
    Public WithEvents txtSedPercentClay As System.Windows.Forms.TextBox
    Public WithEvents txtSedPercentSilt As System.Windows.Forms.TextBox
    Public WithEvents txtSedPercentSand As System.Windows.Forms.TextBox
    Public WithEvents Label53 As System.Windows.Forms.Label
    Public WithEvents Label54 As System.Windows.Forms.Label
    Public WithEvents Label55 As System.Windows.Forms.Label
    Public WithEvents Label56 As System.Windows.Forms.Label
    Public WithEvents Label57 As System.Windows.Forms.Label
    Public WithEvents Label58 As System.Windows.Forms.Label
    Public WithEvents TabControl2 As System.Windows.Forms.TabControl
    Public WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents txtInitialSoilHgMultiplier As System.Windows.Forms.TextBox
    Public WithEvents txtInitialConstantHg As System.Windows.Forms.TextBox
    Public WithEvents optionInitialHgConstant As System.Windows.Forms.RadioButton
    Public WithEvents optionSoilHgGrid As System.Windows.Forms.RadioButton
    Public WithEvents cboInitialSoilHg As System.Windows.Forms.ComboBox
    Public WithEvents lblInitialSoilHgMultiplier As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cboHgWetDepTS As System.Windows.Forms.ComboBox
    Public WithEvents cboHgDryDepTS As System.Windows.Forms.ComboBox
    Public WithEvents cboHgStationsLayer As System.Windows.Forms.ComboBox
    Public WithEvents cboHgWetDepTable As System.Windows.Forms.ComboBox
    Public WithEvents cboHgDryDepTable As System.Windows.Forms.ComboBox
    Public WithEvents chkHgTimeSeries As System.Windows.Forms.CheckBox
    Public WithEvents chkHgGrid As System.Windows.Forms.CheckBox
    Public WithEvents chkHgConstant As System.Windows.Forms.CheckBox
    Public WithEvents txtHgWetPrcpConc As System.Windows.Forms.TextBox
    Public WithEvents optionHgWetPrcpConc As System.Windows.Forms.RadioButton
    Public WithEvents txtHgWetMultiplier As System.Windows.Forms.TextBox
    Public WithEvents txtHgWetConstant As System.Windows.Forms.TextBox
    Public WithEvents optionHgWetConst As System.Windows.Forms.RadioButton
    Public WithEvents cboHgWetDepositionFlux As System.Windows.Forms.ComboBox
    Public WithEvents txtHgDryMultiplier As System.Windows.Forms.TextBox
    Public WithEvents txtHgDryConstant As System.Windows.Forms.TextBox
    Public WithEvents cboHgDryDepositionFlux As System.Windows.Forms.ComboBox
    Public WithEvents lblHgWet As System.Windows.Forms.Label
    Public WithEvents lblHgDry As System.Windows.Forms.Label
    Public WithEvents lblHgWetDepTS As System.Windows.Forms.Label
    Public WithEvents lblDryHgDepTS As System.Windows.Forms.Label
    Public WithEvents lblHgStation As System.Windows.Forms.Label
    Public WithEvents lblDryDeposition As System.Windows.Forms.Label
    Public WithEvents lblHgWetMul As System.Windows.Forms.Label
    Public WithEvents lblHgDryMul As System.Windows.Forms.Label
    Public WithEvents TabPage4 As System.Windows.Forms.TabPage
    Public WithEvents MercuryLand As System.Windows.Forms.GroupBox
    Public WithEvents txtInitialHgSaturatedSoilConstant As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandSoilParticleDensity As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandBedrockDensity As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandBedrockHgConc As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandPollutantEnrichmentFactor As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandSoilReductionDepth As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandSoilBaseReductionRate As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandChemicalWeatheringRate As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandSoilWaterPartitionCoeff As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandSoilMixingDepth As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandAirPlantBioConc As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandAirHgConc As System.Windows.Forms.TextBox
    Public WithEvents Label85 As System.Windows.Forms.Label
    Public WithEvents Label109 As System.Windows.Forms.Label
    Public WithEvents Label60 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label61 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents TabPage5 As System.Windows.Forms.TabPage
    Public WithEvents Frame10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents txtHgLandAnnualEvapo As System.Windows.Forms.TextBox
    Public WithEvents txtHgInitialLeafLitterConstant As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandLeafAdhereFraction As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandLeafInterFraction As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandKDcomp1 As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandKDcomp2 As System.Windows.Forms.TextBox
    Public WithEvents txtHgLandKDcomp3 As System.Windows.Forms.TextBox
    Public WithEvents Label68 As System.Windows.Forms.Label
    Public WithEvents Label69 As System.Windows.Forms.Label
    Public WithEvents Label70 As System.Windows.Forms.Label
    Public WithEvents Label113 As System.Windows.Forms.Label
    Public WithEvents Label114 As System.Windows.Forms.Label
    Public WithEvents Label115 As System.Windows.Forms.Label
    Public WithEvents TabPage6 As System.Windows.Forms.TabPage
    Public WithEvents MercuryWater As System.Windows.Forms.GroupBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Public WithEvents txtHgBenthicPorewaterDiffusionCoeff As System.Windows.Forms.TextBox
    Public WithEvents txtLakeHgWaterColumn As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Public WithEvents txtHgWaterAlphaW As System.Windows.Forms.TextBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Public WithEvents txtHgWaterKWR As System.Windows.Forms.TextBox
    Public WithEvents txtHgWaterBetaW As System.Windows.Forms.TextBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Public WithEvents txtHgWaterKWM As System.Windows.Forms.TextBox
    Public WithEvents txtHgWaterVSB As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Public WithEvents txtHgWaterVRS As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Public WithEvents txtHgWaterKDsw As System.Windows.Forms.TextBox
    Public WithEvents Label80 As System.Windows.Forms.Label
    Public WithEvents txtHgWaterKbio As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Public WithEvents txtHgWaterCbio As System.Windows.Forms.TextBox
    Public WithEvents Label82 As System.Windows.Forms.Label
    Public WithEvents txtHgWaterHgDecayInChannel As System.Windows.Forms.TextBox
    Public WithEvents txtHgMethylHgFraction As System.Windows.Forms.TextBox
    Public WithEvents Label83 As System.Windows.Forms.Label
    Public WithEvents Label120 As System.Windows.Forms.Label
    Public WithEvents Label121 As System.Windows.Forms.Label
    Public WithEvents _SSTab1_TabPage4 As System.Windows.Forms.TabPage
    Public WithEvents Frame11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Public WithEvents txtHgWaterTheta_bs As System.Windows.Forms.TextBox
    Public WithEvents txtHgBenthicCbs As System.Windows.Forms.TextBox
    Public WithEvents txtHgBenthicKDbs As System.Windows.Forms.TextBox
    Public WithEvents txtHgBenthicSedimentDepth As System.Windows.Forms.TextBox
    Public WithEvents txtHgBenthicVbur As System.Windows.Forms.TextBox
    Public WithEvents txtHgBenthicKBM As System.Windows.Forms.TextBox
    Public WithEvents txtHgBenthicBetaB As System.Windows.Forms.TextBox
    Public WithEvents txtHgBenthicKBR As System.Windows.Forms.TextBox
    Public WithEvents txtHgBenthicAlphaB As System.Windows.Forms.TextBox
    Public WithEvents txtLakeHgBenthic As System.Windows.Forms.TextBox
    Public WithEvents Label127 As System.Windows.Forms.Label
    Public WithEvents Label126 As System.Windows.Forms.Label
    Public WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents tabSimulate As System.Windows.Forms.TabPage
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents chkWASP As System.Windows.Forms.CheckBox
    Public WithEvents chkWhAEM As System.Windows.Forms.CheckBox
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents chkMercury As System.Windows.Forms.CheckBox
    Public WithEvents chkSediment As System.Windows.Forms.CheckBox
    Public WithEvents chkHydro As System.Windows.Forms.CheckBox
    Friend WithEvents lblDEMLayer As System.Windows.Forms.Label
    Friend WithEvents cboDEMLayer As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboDEMUnits As System.Windows.Forms.ComboBox
    Friend WithEvents txtGridSize As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents cboPointSourceTable As System.Windows.Forms.ComboBox
    Friend WithEvents cboPointSourceLayer As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboClimateStaLayer As System.Windows.Forms.ComboBox
    Friend WithEvents cboClimateDataTable As System.Windows.Forms.ComboBox
    Public WithEvents fraSimulationTimeFrame As System.Windows.Forms.GroupBox
    Friend WithEvents dtEndSim As System.Windows.Forms.DateTimePicker
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtStartSim As System.Windows.Forms.DateTimePicker
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents cboStartMonth As System.Windows.Forms.ComboBox
    Public WithEvents cboEndMonth As System.Windows.Forms.ComboBox
    Public WithEvents Label97 As System.Windows.Forms.Label
    Public WithEvents Label98 As System.Windows.Forms.Label
    Public WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtEndClimate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtStartClimate As System.Windows.Forms.DateTimePicker
    Public WithEvents Label99 As System.Windows.Forms.Label
    Public WithEvents Label100 As System.Windows.Forms.Label
    Public WithEvents lblDateRange As System.Windows.Forms.Label
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Public WithEvents fraDryHg As System.Windows.Forms.GroupBox
    Friend WithEvents dtEndDry As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtStartDry As System.Windows.Forms.DateTimePicker
    Public WithEvents lblDateRange2 As System.Windows.Forms.Label
    Public WithEvents Label104 As System.Windows.Forms.Label
    Public WithEvents Label105 As System.Windows.Forms.Label
    Public WithEvents fraWetHg As System.Windows.Forms.GroupBox
    Friend WithEvents dtEndWet As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtStartWet As System.Windows.Forms.DateTimePicker
    Public WithEvents lblDateRange3 As System.Windows.Forms.Label
    Public WithEvents Label106 As System.Windows.Forms.Label
    Public WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents cboStreamLayer As System.Windows.Forms.ComboBox
    Friend WithEvents cboFlowRelationTable As System.Windows.Forms.ComboBox
    Friend WithEvents cboLakeLayer As System.Windows.Forms.ComboBox
    Friend WithEvents cboSubbasinField As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboClimateStaField As System.Windows.Forms.ComboBox
    Friend WithEvents cboPointSourceField As System.Windows.Forms.ComboBox
    Friend WithEvents lnkClimateDataTable As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkPointSourceTable As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkFlowRelationTable As System.Windows.Forms.LinkLabel
    Friend WithEvents cboLakeField As System.Windows.Forms.ComboBox
    Friend WithEvents lnkLakeLayer As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkStreamLayer As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkPointSourceLayer As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkClimateStaLayer As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkSubbasinLayer As System.Windows.Forms.LinkLabel
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabPage13 As System.Windows.Forms.TabPage
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents lnkSoilLayer As System.Windows.Forms.LinkLabel
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents cboSoilLayer As System.Windows.Forms.ComboBox
    Friend WithEvents cboSoilField As System.Windows.Forms.ComboBox
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents cboLanduseType As System.Windows.Forms.ComboBox
    Friend WithEvents lblLandUseLayer As System.Windows.Forms.Label
    Friend WithEvents cboLandUseLayer As System.Windows.Forms.ComboBox
    Friend WithEvents cboLandUseField As System.Windows.Forms.ComboBox
    Friend WithEvents lnkLanduseLayer As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents Label133 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents Label135 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtOutputName As System.Windows.Forms.TextBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnOutputName As System.Windows.Forms.Button
    Friend WithEvents txtInputName As System.Windows.Forms.TextBox
    Friend WithEvents btnInputName As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboSoilTable As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboLanduseTable As System.Windows.Forms.ComboBox
    Friend WithEvents cboLanduseCNTable As System.Windows.Forms.ComboBox
    Friend WithEvents lnkSoilTable As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkLanduseTable As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkLanduseCNTable As System.Windows.Forms.LinkLabel
    Public WithEvents fraWhAEM As System.Windows.Forms.GroupBox
    Public WithEvents txtWhAEMDuration As System.Windows.Forms.TextBox
    Public WithEvents whaemLabel As System.Windows.Forms.Label
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents txtTimeStep As System.Windows.Forms.TextBox
    Public WithEvents Label93 As System.Windows.Forms.Label
    Public WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents tabSlopeLength As System.Windows.Forms.TabPage
    Public WithEvents fraSlopeLength As System.Windows.Forms.GroupBox
    Public WithEvents txtMaxSlope As System.Windows.Forms.TextBox
    Public WithEvents chkMaxSlope As System.Windows.Forms.CheckBox
    Public WithEvents optionExisting As System.Windows.Forms.RadioButton
    Public WithEvents optionDefaultLSFactor As System.Windows.Forms.RadioButton
    Public WithEvents txtCSL As System.Windows.Forms.TextBox
    Public WithEvents optionDefineSlopeLength As System.Windows.Forms.RadioButton
    Public WithEvents frameOverland As System.Windows.Forms.GroupBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Public WithEvents txtSedAlphaTc As System.Windows.Forms.TextBox
    Public WithEvents txtInitialSedimentImperviousLandConstant As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Public WithEvents txtInitialSedimentPerviousLandConstant As System.Windows.Forms.TextBox
    Public WithEvents txtSedAccumulationRate As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents txtSedRoutingCoeffBeta As System.Windows.Forms.TextBox
    Public WithEvents txtSedCalibCoeffAlpha As System.Windows.Forms.TextBox
    Public WithEvents txtSedDepletionRate As System.Windows.Forms.TextBox
    Public WithEvents txtSedYieldCapacity As System.Windows.Forms.TextBox
    Public WithEvents Label77 As System.Windows.Forms.Label
    Public WithEvents Label73 As System.Windows.Forms.Label
    Public WithEvents Label50 As System.Windows.Forms.Label
    Public WithEvents Label51 As System.Windows.Forms.Label
    Public WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents lnkMergeCatchments As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDEMLayerSize As System.Windows.Forms.Label
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents Label136 As System.Windows.Forms.Label
    Friend WithEvents cboFlowDirLayer As System.Windows.Forms.ComboBox
    Friend WithEvents cboFlowAccLayer As System.Windows.Forms.ComboBox
    Friend WithEvents lblFlowDirLayerSize As System.Windows.Forms.Label
    Friend WithEvents lblFlowAccLayerSize As System.Windows.Forms.Label
    Friend WithEvents lnkClipAll As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents chkForceRebuild As System.Windows.Forms.CheckBox
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents txtThreshold As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents cboHgStationsField As System.Windows.Forms.ComboBox
    Friend WithEvents btnViewFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAddLayers As System.Windows.Forms.CheckBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblSimulate As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label137 As System.Windows.Forms.Label
    Friend WithEvents cboResultsSubbasin As System.Windows.Forms.ComboBox
    Friend WithEvents Label138 As System.Windows.Forms.Label
    Friend WithEvents tabResult As System.Windows.Forms.TabControl
    Friend WithEvents TabPage14 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage15 As System.Windows.Forms.TabPage
    Friend WithEvents Zed As ZedGraph.ZedGraphControl
    Friend WithEvents splitResults As System.Windows.Forms.SplitContainer
    Friend WithEvents lstVariables As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnVariables As System.Windows.Forms.Button
    Friend WithEvents cboResultsOutput As System.Windows.Forms.ComboBox
    Friend WithEvents wbResults As System.Windows.Forms.WebBrowser
    Friend WithEvents mnuVariables As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectNoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents HelpProvider As System.Windows.Forms.HelpProvider

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMercury))
        Me.btnSimulate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnHelp = New System.Windows.Forms.Button
        Me.btnAbout = New System.Windows.Forms.Button
        Me.btnOpen = New System.Windows.Forms.Button
        Me.HelpProvider = New System.Windows.Forms.HelpProvider
        Me.cboDEMLayer = New System.Windows.Forms.ComboBox
        Me.cboDEMUnits = New System.Windows.Forms.ComboBox
        Me.btnSaveAs = New System.Windows.Forms.Button
        Me.txtOutputName = New System.Windows.Forms.TextBox
        Me.cboSubbasinLayer = New System.Windows.Forms.ComboBox
        Me.txtGridSize = New System.Windows.Forms.TextBox
        Me.cboSubbasinField = New System.Windows.Forms.ComboBox
        Me.lnkSubbasinLayer = New System.Windows.Forms.LinkLabel
        Me.lnkMergeCatchments = New System.Windows.Forms.LinkLabel
        Me.txtThreshold = New System.Windows.Forms.TextBox
        Me.lnkSoilLayer = New System.Windows.Forms.LinkLabel
        Me.cboSoilLayer = New System.Windows.Forms.ComboBox
        Me.cboSoilField = New System.Windows.Forms.ComboBox
        Me.cboLanduseType = New System.Windows.Forms.ComboBox
        Me.cboLandUseLayer = New System.Windows.Forms.ComboBox
        Me.cboLandUseField = New System.Windows.Forms.ComboBox
        Me.lnkLanduseLayer = New System.Windows.Forms.LinkLabel
        Me.cboSoilTable = New System.Windows.Forms.ComboBox
        Me.cboLanduseTable = New System.Windows.Forms.ComboBox
        Me.cboLanduseCNTable = New System.Windows.Forms.ComboBox
        Me.lnkSoilTable = New System.Windows.Forms.LinkLabel
        Me.lnkLanduseTable = New System.Windows.Forms.LinkLabel
        Me.lnkLanduseCNTable = New System.Windows.Forms.LinkLabel
        Me.lnkClimateStaLayer = New System.Windows.Forms.LinkLabel
        Me.lnkPointSourceTable = New System.Windows.Forms.LinkLabel
        Me.lnkClimateDataTable = New System.Windows.Forms.LinkLabel
        Me.lnkLakeLayer = New System.Windows.Forms.LinkLabel
        Me.lnkFlowRelationTable = New System.Windows.Forms.LinkLabel
        Me.lnkStreamLayer = New System.Windows.Forms.LinkLabel
        Me.btnOutputName = New System.Windows.Forms.Button
        Me.txtInputName = New System.Windows.Forms.TextBox
        Me.btnInputName = New System.Windows.Forms.Button
        Me.btnP2Map = New System.Windows.Forms.Button
        Me.cboPointSourceTable = New System.Windows.Forms.ComboBox
        Me.cboClimateStaLayer = New System.Windows.Forms.ComboBox
        Me.cboClimateStaField = New System.Windows.Forms.ComboBox
        Me.cboClimateDataTable = New System.Windows.Forms.ComboBox
        Me.chkForceRebuild = New System.Windows.Forms.CheckBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.cboHgStationsField = New System.Windows.Forms.ComboBox
        Me.btnViewFile = New System.Windows.Forms.Button
        Me.chkAddLayers = New System.Windows.Forms.CheckBox
        Me.Zed = New ZedGraph.ZedGraphControl
        Me.cboResultsSubbasin = New System.Windows.Forms.ComboBox
        Me.btnVariables = New System.Windows.Forms.Button
        Me.cboResultsOutput = New System.Windows.Forms.ComboBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnCopy = New System.Windows.Forms.Button
        Me.tabResults = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Label137 = New System.Windows.Forms.Label
        Me.splitResults = New System.Windows.Forms.SplitContainer
        Me.tabResult = New System.Windows.Forms.TabControl
        Me.TabPage14 = New System.Windows.Forms.TabPage
        Me.TabPage15 = New System.Windows.Forms.TabPage
        Me.wbResults = New System.Windows.Forms.WebBrowser
        Me.lstVariables = New System.Windows.Forms.CheckedListBox
        Me.mnuVariables = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectNoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label138 = New System.Windows.Forms.Label
        Me.tabMercury = New System.Windows.Forms.TabPage
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtInitialSoilHgMultiplier = New System.Windows.Forms.TextBox
        Me.txtInitialConstantHg = New System.Windows.Forms.TextBox
        Me.optionInitialHgConstant = New System.Windows.Forms.RadioButton
        Me.optionSoilHgGrid = New System.Windows.Forms.RadioButton
        Me.cboInitialSoilHg = New System.Windows.Forms.ComboBox
        Me.lblInitialSoilHgMultiplier = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.cboHgWetDepTS = New System.Windows.Forms.ComboBox
        Me.cboHgDryDepTS = New System.Windows.Forms.ComboBox
        Me.cboHgStationsLayer = New System.Windows.Forms.ComboBox
        Me.cboHgWetDepTable = New System.Windows.Forms.ComboBox
        Me.cboHgDryDepTable = New System.Windows.Forms.ComboBox
        Me.chkHgTimeSeries = New System.Windows.Forms.CheckBox
        Me.chkHgGrid = New System.Windows.Forms.CheckBox
        Me.chkHgConstant = New System.Windows.Forms.CheckBox
        Me.txtHgWetPrcpConc = New System.Windows.Forms.TextBox
        Me.optionHgWetPrcpConc = New System.Windows.Forms.RadioButton
        Me.txtHgWetMultiplier = New System.Windows.Forms.TextBox
        Me.txtHgWetConstant = New System.Windows.Forms.TextBox
        Me.optionHgWetConst = New System.Windows.Forms.RadioButton
        Me.cboHgWetDepositionFlux = New System.Windows.Forms.ComboBox
        Me.txtHgDryMultiplier = New System.Windows.Forms.TextBox
        Me.txtHgDryConstant = New System.Windows.Forms.TextBox
        Me.cboHgDryDepositionFlux = New System.Windows.Forms.ComboBox
        Me.lblHgWet = New System.Windows.Forms.Label
        Me.lblHgDry = New System.Windows.Forms.Label
        Me.lblHgWetDepTS = New System.Windows.Forms.Label
        Me.lblDryHgDepTS = New System.Windows.Forms.Label
        Me.lblHgStation = New System.Windows.Forms.Label
        Me.lblDryDeposition = New System.Windows.Forms.Label
        Me.lblHgWetMul = New System.Windows.Forms.Label
        Me.lblHgDryMul = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.MercuryLand = New System.Windows.Forms.GroupBox
        Me.txtInitialHgSaturatedSoilConstant = New System.Windows.Forms.TextBox
        Me.txtHgLandSoilParticleDensity = New System.Windows.Forms.TextBox
        Me.txtHgLandBedrockDensity = New System.Windows.Forms.TextBox
        Me.txtHgLandBedrockHgConc = New System.Windows.Forms.TextBox
        Me.txtHgLandPollutantEnrichmentFactor = New System.Windows.Forms.TextBox
        Me.txtHgLandSoilReductionDepth = New System.Windows.Forms.TextBox
        Me.txtHgLandSoilBaseReductionRate = New System.Windows.Forms.TextBox
        Me.txtHgLandChemicalWeatheringRate = New System.Windows.Forms.TextBox
        Me.txtHgLandSoilWaterPartitionCoeff = New System.Windows.Forms.TextBox
        Me.txtHgLandSoilMixingDepth = New System.Windows.Forms.TextBox
        Me.txtHgLandAirPlantBioConc = New System.Windows.Forms.TextBox
        Me.txtHgLandAirHgConc = New System.Windows.Forms.TextBox
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label109 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Frame10 = New System.Windows.Forms.GroupBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtHgLandAnnualEvapo = New System.Windows.Forms.TextBox
        Me.txtHgInitialLeafLitterConstant = New System.Windows.Forms.TextBox
        Me.txtHgLandLeafAdhereFraction = New System.Windows.Forms.TextBox
        Me.txtHgLandLeafInterFraction = New System.Windows.Forms.TextBox
        Me.txtHgLandKDcomp1 = New System.Windows.Forms.TextBox
        Me.txtHgLandKDcomp2 = New System.Windows.Forms.TextBox
        Me.txtHgLandKDcomp3 = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label113 = New System.Windows.Forms.Label
        Me.Label114 = New System.Windows.Forms.Label
        Me.Label115 = New System.Windows.Forms.Label
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.MercuryWater = New System.Windows.Forms.GroupBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.txtHgBenthicPorewaterDiffusionCoeff = New System.Windows.Forms.TextBox
        Me.txtLakeHgWaterColumn = New System.Windows.Forms.TextBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.txtHgWaterAlphaW = New System.Windows.Forms.TextBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.txtHgWaterKWR = New System.Windows.Forms.TextBox
        Me.txtHgWaterBetaW = New System.Windows.Forms.TextBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.txtHgWaterKWM = New System.Windows.Forms.TextBox
        Me.txtHgWaterVSB = New System.Windows.Forms.TextBox
        Me.Label76 = New System.Windows.Forms.Label
        Me.txtHgWaterVRS = New System.Windows.Forms.TextBox
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.txtHgWaterKDsw = New System.Windows.Forms.TextBox
        Me.Label80 = New System.Windows.Forms.Label
        Me.txtHgWaterKbio = New System.Windows.Forms.TextBox
        Me.Label81 = New System.Windows.Forms.Label
        Me.txtHgWaterCbio = New System.Windows.Forms.TextBox
        Me.Label82 = New System.Windows.Forms.Label
        Me.txtHgWaterHgDecayInChannel = New System.Windows.Forms.TextBox
        Me.txtHgMethylHgFraction = New System.Windows.Forms.TextBox
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label120 = New System.Windows.Forms.Label
        Me.Label121 = New System.Windows.Forms.Label
        Me._SSTab1_TabPage4 = New System.Windows.Forms.TabPage
        Me.Frame11 = New System.Windows.Forms.GroupBox
        Me.Label84 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.Label90 = New System.Windows.Forms.Label
        Me.Label91 = New System.Windows.Forms.Label
        Me.txtHgWaterTheta_bs = New System.Windows.Forms.TextBox
        Me.txtHgBenthicCbs = New System.Windows.Forms.TextBox
        Me.txtHgBenthicKDbs = New System.Windows.Forms.TextBox
        Me.txtHgBenthicSedimentDepth = New System.Windows.Forms.TextBox
        Me.txtHgBenthicVbur = New System.Windows.Forms.TextBox
        Me.txtHgBenthicKBM = New System.Windows.Forms.TextBox
        Me.txtHgBenthicBetaB = New System.Windows.Forms.TextBox
        Me.txtHgBenthicKBR = New System.Windows.Forms.TextBox
        Me.txtHgBenthicAlphaB = New System.Windows.Forms.TextBox
        Me.txtLakeHgBenthic = New System.Windows.Forms.TextBox
        Me.Label127 = New System.Windows.Forms.Label
        Me.Label126 = New System.Windows.Forms.Label
        Me.Label92 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tabHydrology = New System.Windows.Forms.TabPage
        Me.SSTab1 = New System.Windows.Forms.TabControl
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage
        Me.framehydro = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.optConstSoilMoisture = New System.Windows.Forms.RadioButton
        Me.optInputSoilMoisture = New System.Windows.Forms.RadioButton
        Me.optFieldCapacity = New System.Windows.Forms.RadioButton
        Me.txtInitialSoilMoistureConstant = New System.Windows.Forms.TextBox
        Me.cboInitialSoilMoisture = New System.Windows.Forms.ComboBox
        Me.txtbCNNonGrow = New System.Windows.Forms.TextBox
        Me.txtaCNNonGrow = New System.Windows.Forms.TextBox
        Me.txtaCNGrow = New System.Windows.Forms.TextBox
        Me.txtbCNGrow = New System.Windows.Forms.TextBox
        Me.txtInitialAccuSnowConstant = New System.Windows.Forms.TextBox
        Me.txtHydroP2Rainfall = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label101 = New System.Windows.Forms.Label
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.txtHgLandUnsaturatedSoilDepth = New System.Windows.Forms.TextBox
        Me.txtHgLandBedrockDepth = New System.Windows.Forms.TextBox
        Me.Label111 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.fraGroundWater = New System.Windows.Forms.GroupBox
        Me.txtInitialShallowGWConstant = New System.Windows.Forms.TextBox
        Me.txtHydroGWSeepageCoeff = New System.Windows.Forms.TextBox
        Me.txtHydroGWRecessionCoeff = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label107 = New System.Windows.Forms.Label
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage
        Me.FrameStreamParam = New System.Windows.Forms.GroupBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtHydroManningCoeff = New System.Windows.Forms.TextBox
        Me.cboRegions = New System.Windows.Forms.ComboBox
        Me.txtAlphaDepth = New System.Windows.Forms.TextBox
        Me.txtBetaDepth = New System.Windows.Forms.TextBox
        Me.txtAlphaWidth = New System.Windows.Forms.TextBox
        Me.txtBetaWidth = New System.Windows.Forms.TextBox
        Me.txtCrossSectionSlope1 = New System.Windows.Forms.TextBox
        Me.txtCrossSectionSlope2 = New System.Windows.Forms.TextBox
        Me.PictureChannel = New System.Windows.Forms.PictureBox
        Me.Label102 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me._SSTab1_TabPage3 = New System.Windows.Forms.TabPage
        Me.LakeAttributes = New System.Windows.Forms.GroupBox
        Me.txtHydroOrificeDepth = New System.Windows.Forms.TextBox
        Me.txtLakeInfiltration = New System.Windows.Forms.TextBox
        Me.txtBankFullDepth = New System.Windows.Forms.TextBox
        Me.txtInitWaterDepth = New System.Windows.Forms.TextBox
        Me.txtLakesThreshold = New System.Windows.Forms.TextBox
        Me.txtHydroOrificeDia = New System.Windows.Forms.TextBox
        Me.txtHydroOrificeDischargeCoeff = New System.Windows.Forms.TextBox
        Me.txtHydroWeirCrestLength = New System.Windows.Forms.TextBox
        Me.txtHydroWeirDischargeCoeff = New System.Windows.Forms.TextBox
        Me.txtHydroEvapoCoeff = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tabGeneral = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TabControl4 = New System.Windows.Forms.TabControl
        Me.TabPage10 = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.Label117 = New System.Windows.Forms.Label
        Me.lblSubbasinsLayer = New System.Windows.Forms.Label
        Me.lblGridSize = New System.Windows.Forms.Label
        Me.Label119 = New System.Windows.Forms.Label
        Me.Label122 = New System.Windows.Forms.Label
        Me.Label123 = New System.Windows.Forms.Label
        Me.lblDEMLayer = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblDEMLayerSize = New System.Windows.Forms.Label
        Me.TabPage11 = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel
        Me.Label128 = New System.Windows.Forms.Label
        Me.Label129 = New System.Windows.Forms.Label
        Me.Label130 = New System.Windows.Forms.Label
        Me.Label124 = New System.Windows.Forms.Label
        Me.Label131 = New System.Windows.Forms.Label
        Me.lblLandUseLayer = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabPage12 = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label132 = New System.Windows.Forms.Label
        Me.Label133 = New System.Windows.Forms.Label
        Me.Label96 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboPointSourceLayer = New System.Windows.Forms.ComboBox
        Me.Label95 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboPointSourceField = New System.Windows.Forms.ComboBox
        Me.lnkPointSourceLayer = New System.Windows.Forms.LinkLabel
        Me.TabPage13 = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel
        Me.Label125 = New System.Windows.Forms.Label
        Me.Label134 = New System.Windows.Forms.Label
        Me.cboLakeLayer = New System.Windows.Forms.ComboBox
        Me.Label116 = New System.Windows.Forms.Label
        Me.cboLakeField = New System.Windows.Forms.ComboBox
        Me.Label112 = New System.Windows.Forms.Label
        Me.cboFlowRelationTable = New System.Windows.Forms.ComboBox
        Me.Label110 = New System.Windows.Forms.Label
        Me.Label135 = New System.Windows.Forms.Label
        Me.cboStreamLayer = New System.Windows.Forms.ComboBox
        Me.Label118 = New System.Windows.Forms.Label
        Me.Label136 = New System.Windows.Forms.Label
        Me.cboFlowDirLayer = New System.Windows.Forms.ComboBox
        Me.cboFlowAccLayer = New System.Windows.Forms.ComboBox
        Me.lblFlowDirLayerSize = New System.Windows.Forms.Label
        Me.lblFlowAccLayerSize = New System.Windows.Forms.Label
        Me.lblOutput = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lnkClipAll = New System.Windows.Forms.LinkLabel
        Me.tabMain = New System.Windows.Forms.TabControl
        Me.tabSediment = New System.Windows.Forms.TabPage
        Me.subtabSediment = New System.Windows.Forms.TabControl
        Me.tabSlopeLength = New System.Windows.Forms.TabPage
        Me.fraSlopeLength = New System.Windows.Forms.GroupBox
        Me.txtMaxSlope = New System.Windows.Forms.TextBox
        Me.chkMaxSlope = New System.Windows.Forms.CheckBox
        Me.optionExisting = New System.Windows.Forms.RadioButton
        Me.optionDefaultLSFactor = New System.Windows.Forms.RadioButton
        Me.txtCSL = New System.Windows.Forms.TextBox
        Me.optionDefineSlopeLength = New System.Windows.Forms.RadioButton
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.frameOverland = New System.Windows.Forms.GroupBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtSedAlphaTc = New System.Windows.Forms.TextBox
        Me.txtInitialSedimentImperviousLandConstant = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.txtInitialSedimentPerviousLandConstant = New System.Windows.Forms.TextBox
        Me.txtSedAccumulationRate = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.txtSedRoutingCoeffBeta = New System.Windows.Forms.TextBox
        Me.txtSedCalibCoeffAlpha = New System.Windows.Forms.TextBox
        Me.txtSedDepletionRate = New System.Windows.Forms.TextBox
        Me.txtSedYieldCapacity = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtLakeInitialSediment = New System.Windows.Forms.TextBox
        Me.txtSedEquilibriumConc = New System.Windows.Forms.TextBox
        Me.txtSedDecayConstant = New System.Windows.Forms.TextBox
        Me.txtSedPercentClay = New System.Windows.Forms.TextBox
        Me.txtSedPercentSilt = New System.Windows.Forms.TextBox
        Me.txtSedPercentSand = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.tabSimulate = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.Label103 = New System.Windows.Forms.Label
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.fraWhAEM = New System.Windows.Forms.GroupBox
        Me.txtWhAEMDuration = New System.Windows.Forms.TextBox
        Me.whaemLabel = New System.Windows.Forms.Label
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.chkMercury = New System.Windows.Forms.CheckBox
        Me.chkSediment = New System.Windows.Forms.CheckBox
        Me.chkHydro = New System.Windows.Forms.CheckBox
        Me.Frame6 = New System.Windows.Forms.GroupBox
        Me.chkWASP = New System.Windows.Forms.CheckBox
        Me.chkWhAEM = New System.Windows.Forms.CheckBox
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtTimeStep = New System.Windows.Forms.TextBox
        Me.Label93 = New System.Windows.Forms.Label
        Me.Label94 = New System.Windows.Forms.Label
        Me.fraSimulationTimeFrame = New System.Windows.Forms.GroupBox
        Me.dtEndSim = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtStartSim = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.dtEndClimate = New System.Windows.Forms.DateTimePicker
        Me.dtStartClimate = New System.Windows.Forms.DateTimePicker
        Me.Label99 = New System.Windows.Forms.Label
        Me.Label100 = New System.Windows.Forms.Label
        Me.lblDateRange = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cboStartMonth = New System.Windows.Forms.ComboBox
        Me.cboEndMonth = New System.Windows.Forms.ComboBox
        Me.Label97 = New System.Windows.Forms.Label
        Me.Label98 = New System.Windows.Forms.Label
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.fraDryHg = New System.Windows.Forms.GroupBox
        Me.dtEndDry = New System.Windows.Forms.DateTimePicker
        Me.dtStartDry = New System.Windows.Forms.DateTimePicker
        Me.lblDateRange2 = New System.Windows.Forms.Label
        Me.Label104 = New System.Windows.Forms.Label
        Me.Label105 = New System.Windows.Forms.Label
        Me.fraWetHg = New System.Windows.Forms.GroupBox
        Me.dtEndWet = New System.Windows.Forms.DateTimePicker
        Me.dtStartWet = New System.Windows.Forms.DateTimePicker
        Me.lblDateRange3 = New System.Windows.Forms.Label
        Me.Label106 = New System.Windows.Forms.Label
        Me.Label108 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lblSimulate = New System.Windows.Forms.Label
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabResults.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.splitResults.Panel1.SuspendLayout()
        Me.splitResults.Panel2.SuspendLayout()
        Me.splitResults.SuspendLayout()
        Me.tabResult.SuspendLayout()
        Me.TabPage14.SuspendLayout()
        Me.TabPage15.SuspendLayout()
        Me.mnuVariables.SuspendLayout()
        Me.tabMercury.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.MercuryLand.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Frame10.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.MercuryWater.SuspendLayout()
        Me._SSTab1_TabPage4.SuspendLayout()
        Me.Frame11.SuspendLayout()
        Me.tabHydrology.SuspendLayout()
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me.framehydro.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me._SSTab1_TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.fraGroundWater.SuspendLayout()
        Me._SSTab1_TabPage2.SuspendLayout()
        Me.FrameStreamParam.SuspendLayout()
        CType(Me.PictureChannel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._SSTab1_TabPage3.SuspendLayout()
        Me.LakeAttributes.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabSediment.SuspendLayout()
        Me.subtabSediment.SuspendLayout()
        Me.tabSlopeLength.SuspendLayout()
        Me.fraSlopeLength.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.frameOverland.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabSimulate.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.fraWhAEM.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.fraSimulationTimeFrame.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.fraDryHg.SuspendLayout()
        Me.fraWetHg.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimulate
        '
        Me.btnSimulate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimulate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.btnSimulate, "This will cause all grids to be processed, the GBMM input files to be rewritten, " & _
                "and the GBMM C++ computational program to run.")
        Me.btnSimulate.Location = New System.Drawing.Point(383, 1)
        Me.btnSimulate.Name = "btnSimulate"
        Me.HelpProvider.SetShowHelp(Me.btnSimulate, True)
        Me.btnSimulate.Size = New System.Drawing.Size(159, 26)
        Me.btnSimulate.TabIndex = 1
        Me.btnSimulate.Text = "&Run Simulation..."
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(506, 521)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 26)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Close"
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.btnHelp, "Display the GBMM User Guide.")
        Me.btnHelp.Location = New System.Drawing.Point(219, 520)
        Me.btnHelp.Name = "btnHelp"
        Me.HelpProvider.SetShowHelp(Me.btnHelp, True)
        Me.btnHelp.Size = New System.Drawing.Size(75, 26)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "&Help"
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAbout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.btnAbout, "Display the About GBMM dialog box.")
        Me.btnAbout.Location = New System.Drawing.Point(300, 520)
        Me.btnAbout.Name = "btnAbout"
        Me.HelpProvider.SetShowHelp(Me.btnAbout, True)
        Me.btnAbout.Size = New System.Drawing.Size(75, 26)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "&About"
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider.SetHelpString(Me.btnOpen, "Open an existing mercury scenario file which contains all settings specified on t" & _
                "hese tabs. If you do not explicitly open a data file, the default file will auto" & _
                "matically be opened and used.")
        Me.btnOpen.Location = New System.Drawing.Point(12, 520)
        Me.btnOpen.Name = "btnOpen"
        Me.HelpProvider.SetShowHelp(Me.btnOpen, True)
        Me.btnOpen.Size = New System.Drawing.Size(75, 26)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "&Open..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'cboDEMLayer
        '
        Me.cboDEMLayer.AllowDrop = True
        Me.cboDEMLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDEMLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboDEMLayer, "Select the digital elevation model (DEM) grid layer containing the elevations in " & _
                "your area of interest. It will automatically be clipped to only include the exte" & _
                "nts of the subbasins layer.")
        Me.cboDEMLayer.Location = New System.Drawing.Point(183, 100)
        Me.cboDEMLayer.Name = "cboDEMLayer"
        Me.HelpProvider.SetShowHelp(Me.cboDEMLayer, True)
        Me.cboDEMLayer.Size = New System.Drawing.Size(183, 21)
        Me.cboDEMLayer.Sorted = True
        Me.cboDEMLayer.TabIndex = 9
        '
        'cboDEMUnits
        '
        Me.cboDEMUnits.AllowDrop = True
        Me.cboDEMUnits.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cboDEMUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboDEMUnits, "Select the units associated with the values stored in the DEM grid.")
        Me.cboDEMUnits.Items.AddRange(New Object() {"Meters", "Centimeters", "Feet"})
        Me.cboDEMUnits.Location = New System.Drawing.Point(183, 127)
        Me.cboDEMUnits.Name = "cboDEMUnits"
        Me.HelpProvider.SetShowHelp(Me.cboDEMUnits, True)
        Me.cboDEMUnits.Size = New System.Drawing.Size(120, 21)
        Me.cboDEMUnits.TabIndex = 12
        '
        'btnSaveAs
        '
        Me.btnSaveAs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider.SetHelpString(Me.btnSaveAs, "Save the current GBMM data files. Note that the location should match the Input F" & _
                "older name specified on the General tab.")
        Me.btnSaveAs.Location = New System.Drawing.Point(93, 520)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.HelpProvider.SetShowHelp(Me.btnSaveAs, True)
        Me.btnSaveAs.Size = New System.Drawing.Size(75, 26)
        Me.btnSaveAs.TabIndex = 2
        Me.btnSaveAs.Text = "&Save As..."
        Me.btnSaveAs.UseVisualStyleBackColor = True
        '
        'txtOutputName
        '
        Me.txtOutputName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider.SetHelpString(Me.txtOutputName, "Specify where output from the GBMM C++ computational program will be saved.")
        Me.txtOutputName.Location = New System.Drawing.Point(114, 153)
        Me.txtOutputName.Name = "txtOutputName"
        Me.HelpProvider.SetShowHelp(Me.txtOutputName, True)
        Me.txtOutputName.Size = New System.Drawing.Size(364, 20)
        Me.txtOutputName.TabIndex = 5
        '
        'cboSubbasinLayer
        '
        Me.cboSubbasinLayer.AllowDrop = True
        Me.cboSubbasinLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSubbasinLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboSubbasinLayer, "This is the polygon shapefile describing the subbasins for which GBMM modeling is" & _
                " desired.")
        Me.cboSubbasinLayer.Location = New System.Drawing.Point(183, 43)
        Me.cboSubbasinLayer.Name = "cboSubbasinLayer"
        Me.HelpProvider.SetShowHelp(Me.cboSubbasinLayer, True)
        Me.cboSubbasinLayer.Size = New System.Drawing.Size(183, 21)
        Me.cboSubbasinLayer.Sorted = True
        Me.cboSubbasinLayer.TabIndex = 4
        '
        'txtGridSize
        '
        Me.HelpProvider.SetHelpString(Me.txtGridSize, "If you want to perform calculations on a larger grid spacing, enter a grid size w" & _
                "hich is an even multiple of the DEM grid size.")
        Me.txtGridSize.Location = New System.Drawing.Point(183, 154)
        Me.txtGridSize.Name = "txtGridSize"
        Me.HelpProvider.SetShowHelp(Me.txtGridSize, True)
        Me.txtGridSize.Size = New System.Drawing.Size(120, 20)
        Me.txtGridSize.TabIndex = 14
        '
        'cboSubbasinField
        '
        Me.cboSubbasinField.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSubbasinField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubbasinField.FormattingEnabled = True
        Me.HelpProvider.SetHelpString(Me.cboSubbasinField, "The field in the shape file containing a unique subbasin ID.")
        Me.cboSubbasinField.Location = New System.Drawing.Point(372, 43)
        Me.cboSubbasinField.Name = "cboSubbasinField"
        Me.HelpProvider.SetShowHelp(Me.cboSubbasinField, True)
        Me.cboSubbasinField.Size = New System.Drawing.Size(91, 21)
        Me.cboSubbasinField.TabIndex = 5
        Me.cboSubbasinField.Visible = False
        '
        'lnkSubbasinLayer
        '
        Me.lnkSubbasinLayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkSubbasinLayer.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkSubbasinLayer, "Click here to open a table browser which displays the data table associated with " & _
                "the shape file.")
        Me.lnkSubbasinLayer.LinkColor = System.Drawing.Color.Blue
        Me.lnkSubbasinLayer.Location = New System.Drawing.Point(469, 47)
        Me.lnkSubbasinLayer.Name = "lnkSubbasinLayer"
        Me.HelpProvider.SetShowHelp(Me.lnkSubbasinLayer, True)
        Me.lnkSubbasinLayer.Size = New System.Drawing.Size(60, 13)
        Me.lnkSubbasinLayer.TabIndex = 6
        Me.lnkSubbasinLayer.TabStop = True
        Me.lnkSubbasinLayer.Text = "View Table"
        Me.lnkSubbasinLayer.Visible = False
        Me.lnkSubbasinLayer.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkMergeCatchments
        '
        Me.lnkMergeCatchments.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkMergeCatchments.AutoSize = True
        Me.TableLayoutPanel5.SetColumnSpan(Me.lnkMergeCatchments, 4)
        Me.HelpProvider.SetHelpString(Me.lnkMergeCatchments, resources.GetString("lnkMergeCatchments.HelpString"))
        Me.lnkMergeCatchments.Location = New System.Drawing.Point(148, 70)
        Me.lnkMergeCatchments.Name = "lnkMergeCatchments"
        Me.HelpProvider.SetShowHelp(Me.lnkMergeCatchments, True)
        Me.lnkMergeCatchments.Size = New System.Drawing.Size(236, 13)
        Me.lnkMergeCatchments.TabIndex = 7
        Me.lnkMergeCatchments.TabStop = True
        Me.lnkMergeCatchments.Text = "Create subbasins by merging NHD catchments..."
        '
        'txtThreshold
        '
        Me.HelpProvider.SetHelpString(Me.txtThreshold, resources.GetString("txtThreshold.HelpString"))
        Me.txtThreshold.Location = New System.Drawing.Point(183, 180)
        Me.txtThreshold.Name = "txtThreshold"
        Me.HelpProvider.SetShowHelp(Me.txtThreshold, True)
        Me.txtThreshold.Size = New System.Drawing.Size(120, 20)
        Me.txtThreshold.TabIndex = 16
        '
        'lnkSoilLayer
        '
        Me.lnkSoilLayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkSoilLayer.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkSoilLayer, "Click here to open a table browser which displays the data table associated with " & _
                "the shape file.")
        Me.lnkSoilLayer.LinkColor = System.Drawing.Color.Blue
        Me.lnkSoilLayer.Location = New System.Drawing.Point(469, 47)
        Me.lnkSoilLayer.Name = "lnkSoilLayer"
        Me.HelpProvider.SetShowHelp(Me.lnkSoilLayer, True)
        Me.lnkSoilLayer.Size = New System.Drawing.Size(60, 13)
        Me.lnkSoilLayer.TabIndex = 6
        Me.lnkSoilLayer.TabStop = True
        Me.lnkSoilLayer.Text = "View Table"
        Me.lnkSoilLayer.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'cboSoilLayer
        '
        Me.cboSoilLayer.AllowDrop = True
        Me.cboSoilLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSoilLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboSoilLayer, "Specify a polygon shape file describing the soil types in your study area. A soil" & _
                " grid will automatically be created to the grid size you specify and clipped to " & _
                "the subbasins grid extents.")
        Me.cboSoilLayer.Location = New System.Drawing.Point(183, 43)
        Me.cboSoilLayer.Name = "cboSoilLayer"
        Me.HelpProvider.SetShowHelp(Me.cboSoilLayer, True)
        Me.cboSoilLayer.Size = New System.Drawing.Size(183, 21)
        Me.cboSoilLayer.Sorted = True
        Me.cboSoilLayer.TabIndex = 4
        '
        'cboSoilField
        '
        Me.cboSoilField.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSoilField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSoilField.FormattingEnabled = True
        Me.HelpProvider.SetHelpString(Me.cboSoilField, "This is the shape file field containing soil type ID. It must match a same-named " & _
                "field in the Soil Property Table.")
        Me.cboSoilField.Location = New System.Drawing.Point(372, 43)
        Me.cboSoilField.Name = "cboSoilField"
        Me.HelpProvider.SetShowHelp(Me.cboSoilField, True)
        Me.cboSoilField.Size = New System.Drawing.Size(91, 21)
        Me.cboSoilField.TabIndex = 5
        '
        'cboLanduseType
        '
        Me.cboLanduseType.AllowDrop = True
        Me.cboLanduseType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLanduseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboLanduseType, "Select the type of land use layer to use.")
        Me.cboLanduseType.Location = New System.Drawing.Point(183, 107)
        Me.cboLanduseType.Name = "cboLanduseType"
        Me.HelpProvider.SetShowHelp(Me.cboLanduseType, True)
        Me.cboLanduseType.Size = New System.Drawing.Size(183, 21)
        Me.cboLanduseType.TabIndex = 11
        '
        'cboLandUseLayer
        '
        Me.cboLandUseLayer.AllowDrop = True
        Me.cboLandUseLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLandUseLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboLandUseLayer, "If a user-specified shapefile or grid type is selected above, select that layer h" & _
                "ere.")
        Me.cboLandUseLayer.Location = New System.Drawing.Point(183, 134)
        Me.cboLandUseLayer.Name = "cboLandUseLayer"
        Me.HelpProvider.SetShowHelp(Me.cboLandUseLayer, True)
        Me.cboLandUseLayer.Size = New System.Drawing.Size(183, 21)
        Me.cboLandUseLayer.Sorted = True
        Me.cboLandUseLayer.TabIndex = 13
        '
        'cboLandUseField
        '
        Me.cboLandUseField.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLandUseField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLandUseField.FormattingEnabled = True
        Me.HelpProvider.SetHelpString(Me.cboLandUseField, "Specify the field name containing the land use code in the specified shapefile.")
        Me.cboLandUseField.Location = New System.Drawing.Point(372, 134)
        Me.cboLandUseField.Name = "cboLandUseField"
        Me.HelpProvider.SetShowHelp(Me.cboLandUseField, True)
        Me.cboLandUseField.Size = New System.Drawing.Size(91, 21)
        Me.cboLandUseField.TabIndex = 14
        '
        'lnkLanduseLayer
        '
        Me.lnkLanduseLayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkLanduseLayer.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkLanduseLayer, "Click here to open a table browser which displays the data table associated with " & _
                "the shape file.")
        Me.lnkLanduseLayer.LinkColor = System.Drawing.Color.Blue
        Me.lnkLanduseLayer.Location = New System.Drawing.Point(469, 138)
        Me.lnkLanduseLayer.Name = "lnkLanduseLayer"
        Me.HelpProvider.SetShowHelp(Me.lnkLanduseLayer, True)
        Me.lnkLanduseLayer.Size = New System.Drawing.Size(60, 13)
        Me.lnkLanduseLayer.TabIndex = 15
        Me.lnkLanduseLayer.TabStop = True
        Me.lnkLanduseLayer.Text = "View Table"
        Me.lnkLanduseLayer.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'cboSoilTable
        '
        Me.cboSoilTable.AllowDrop = True
        Me.cboSoilTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSoilTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboSoilTable, resources.GetString("cboSoilTable.HelpString"))
        Me.cboSoilTable.Location = New System.Drawing.Point(183, 70)
        Me.cboSoilTable.Name = "cboSoilTable"
        Me.HelpProvider.SetShowHelp(Me.cboSoilTable, True)
        Me.cboSoilTable.Size = New System.Drawing.Size(183, 21)
        Me.cboSoilTable.Sorted = True
        Me.cboSoilTable.TabIndex = 8
        '
        'cboLanduseTable
        '
        Me.cboLanduseTable.AllowDrop = True
        Me.cboLanduseTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLanduseTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboLanduseTable, resources.GetString("cboLanduseTable.HelpString"))
        Me.cboLanduseTable.Location = New System.Drawing.Point(183, 161)
        Me.cboLanduseTable.Name = "cboLanduseTable"
        Me.HelpProvider.SetShowHelp(Me.cboLanduseTable, True)
        Me.cboLanduseTable.Size = New System.Drawing.Size(183, 21)
        Me.cboLanduseTable.Sorted = True
        Me.cboLanduseTable.TabIndex = 17
        '
        'cboLanduseCNTable
        '
        Me.cboLanduseCNTable.AllowDrop = True
        Me.cboLanduseCNTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLanduseCNTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboLanduseCNTable, "This table must contain the following fields: LU_CNCODE, CN. All data tables must" & _
                " reside in the BASINS data folder for the current BASINS project, under GBMM\Dat" & _
                "a.")
        Me.cboLanduseCNTable.Location = New System.Drawing.Point(183, 188)
        Me.cboLanduseCNTable.Name = "cboLanduseCNTable"
        Me.HelpProvider.SetShowHelp(Me.cboLanduseCNTable, True)
        Me.cboLanduseCNTable.Size = New System.Drawing.Size(183, 21)
        Me.cboLanduseCNTable.Sorted = True
        Me.cboLanduseCNTable.TabIndex = 20
        '
        'lnkSoilTable
        '
        Me.lnkSoilTable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkSoilTable.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkSoilTable, "Click here to open a table browser which displays the data table contents.")
        Me.lnkSoilTable.LinkColor = System.Drawing.Color.Blue
        Me.lnkSoilTable.Location = New System.Drawing.Point(469, 74)
        Me.lnkSoilTable.Name = "lnkSoilTable"
        Me.HelpProvider.SetShowHelp(Me.lnkSoilTable, True)
        Me.lnkSoilTable.Size = New System.Drawing.Size(60, 13)
        Me.lnkSoilTable.TabIndex = 9
        Me.lnkSoilTable.TabStop = True
        Me.lnkSoilTable.Text = "View Table"
        Me.lnkSoilTable.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkLanduseTable
        '
        Me.lnkLanduseTable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkLanduseTable.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkLanduseTable, "Click here to open a table browser which displays the data table contents.")
        Me.lnkLanduseTable.LinkColor = System.Drawing.Color.Blue
        Me.lnkLanduseTable.Location = New System.Drawing.Point(469, 165)
        Me.lnkLanduseTable.Name = "lnkLanduseTable"
        Me.HelpProvider.SetShowHelp(Me.lnkLanduseTable, True)
        Me.lnkLanduseTable.Size = New System.Drawing.Size(60, 13)
        Me.lnkLanduseTable.TabIndex = 18
        Me.lnkLanduseTable.TabStop = True
        Me.lnkLanduseTable.Text = "View Table"
        Me.lnkLanduseTable.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkLanduseCNTable
        '
        Me.lnkLanduseCNTable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkLanduseCNTable.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkLanduseCNTable, "Click here to open a table browser which displays the data table contents.")
        Me.lnkLanduseCNTable.LinkColor = System.Drawing.Color.Blue
        Me.lnkLanduseCNTable.Location = New System.Drawing.Point(469, 192)
        Me.lnkLanduseCNTable.Name = "lnkLanduseCNTable"
        Me.HelpProvider.SetShowHelp(Me.lnkLanduseCNTable, True)
        Me.lnkLanduseCNTable.Size = New System.Drawing.Size(60, 13)
        Me.lnkLanduseCNTable.TabIndex = 21
        Me.lnkLanduseCNTable.TabStop = True
        Me.lnkLanduseCNTable.Text = "View Table"
        Me.lnkLanduseCNTable.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkClimateStaLayer
        '
        Me.lnkClimateStaLayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkClimateStaLayer.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkClimateStaLayer, "Click here to open a table browser which displays the data table associated with " & _
                "the shape file.")
        Me.lnkClimateStaLayer.LinkColor = System.Drawing.Color.Blue
        Me.lnkClimateStaLayer.Location = New System.Drawing.Point(469, 47)
        Me.lnkClimateStaLayer.Name = "lnkClimateStaLayer"
        Me.HelpProvider.SetShowHelp(Me.lnkClimateStaLayer, True)
        Me.lnkClimateStaLayer.Size = New System.Drawing.Size(60, 13)
        Me.lnkClimateStaLayer.TabIndex = 6
        Me.lnkClimateStaLayer.TabStop = True
        Me.lnkClimateStaLayer.Text = "View Table"
        Me.lnkClimateStaLayer.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkPointSourceTable
        '
        Me.lnkPointSourceTable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkPointSourceTable.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkPointSourceTable, "Click here to open a table browser which displays the data table contents.")
        Me.lnkPointSourceTable.LinkColor = System.Drawing.Color.Blue
        Me.lnkPointSourceTable.Location = New System.Drawing.Point(469, 138)
        Me.lnkPointSourceTable.Name = "lnkPointSourceTable"
        Me.HelpProvider.SetShowHelp(Me.lnkPointSourceTable, True)
        Me.lnkPointSourceTable.Size = New System.Drawing.Size(60, 13)
        Me.lnkPointSourceTable.TabIndex = 16
        Me.lnkPointSourceTable.TabStop = True
        Me.lnkPointSourceTable.Text = "View Table"
        Me.lnkPointSourceTable.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkClimateDataTable
        '
        Me.lnkClimateDataTable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkClimateDataTable.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkClimateDataTable, "Click here to open a table browser which displays the data table contents.")
        Me.lnkClimateDataTable.LinkColor = System.Drawing.Color.Blue
        Me.lnkClimateDataTable.Location = New System.Drawing.Point(469, 74)
        Me.lnkClimateDataTable.Name = "lnkClimateDataTable"
        Me.HelpProvider.SetShowHelp(Me.lnkClimateDataTable, True)
        Me.lnkClimateDataTable.Size = New System.Drawing.Size(60, 13)
        Me.lnkClimateDataTable.TabIndex = 9
        Me.lnkClimateDataTable.TabStop = True
        Me.lnkClimateDataTable.Text = "View Table"
        Me.lnkClimateDataTable.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkLakeLayer
        '
        Me.lnkLakeLayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkLakeLayer.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkLakeLayer, "Click here to open a table browser which displays the data table associated with " & _
                "the shape file.")
        Me.lnkLakeLayer.LinkColor = System.Drawing.Color.Blue
        Me.lnkLakeLayer.Location = New System.Drawing.Point(469, 101)
        Me.lnkLakeLayer.Name = "lnkLakeLayer"
        Me.HelpProvider.SetShowHelp(Me.lnkLakeLayer, True)
        Me.lnkLakeLayer.Size = New System.Drawing.Size(60, 13)
        Me.lnkLakeLayer.TabIndex = 12
        Me.lnkLakeLayer.TabStop = True
        Me.lnkLakeLayer.Text = "View Table"
        Me.lnkLakeLayer.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkFlowRelationTable
        '
        Me.lnkFlowRelationTable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkFlowRelationTable.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkFlowRelationTable, "Click here to open a table browser which displays the data table contents.")
        Me.lnkFlowRelationTable.LinkColor = System.Drawing.Color.Blue
        Me.lnkFlowRelationTable.Location = New System.Drawing.Point(469, 74)
        Me.lnkFlowRelationTable.Name = "lnkFlowRelationTable"
        Me.HelpProvider.SetShowHelp(Me.lnkFlowRelationTable, True)
        Me.lnkFlowRelationTable.Size = New System.Drawing.Size(60, 13)
        Me.lnkFlowRelationTable.TabIndex = 8
        Me.lnkFlowRelationTable.TabStop = True
        Me.lnkFlowRelationTable.Text = "View Table"
        Me.lnkFlowRelationTable.Visible = False
        Me.lnkFlowRelationTable.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkStreamLayer
        '
        Me.lnkStreamLayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkStreamLayer.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.lnkStreamLayer, "Click here to open a table browser which displays the data table associated with " & _
                "the shape file.")
        Me.lnkStreamLayer.LinkColor = System.Drawing.Color.Blue
        Me.lnkStreamLayer.Location = New System.Drawing.Point(469, 47)
        Me.lnkStreamLayer.Name = "lnkStreamLayer"
        Me.HelpProvider.SetShowHelp(Me.lnkStreamLayer, True)
        Me.lnkStreamLayer.Size = New System.Drawing.Size(60, 13)
        Me.lnkStreamLayer.TabIndex = 5
        Me.lnkStreamLayer.TabStop = True
        Me.lnkStreamLayer.Text = "View Table"
        Me.lnkStreamLayer.Visible = False
        Me.lnkStreamLayer.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'btnOutputName
        '
        Me.btnOutputName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HelpProvider.SetHelpString(Me.btnOutputName, "Click this button to browse to the input/output folder.")
        Me.btnOutputName.Location = New System.Drawing.Point(484, 152)
        Me.btnOutputName.Name = "btnOutputName"
        Me.HelpProvider.SetShowHelp(Me.btnOutputName, True)
        Me.btnOutputName.Size = New System.Drawing.Size(65, 23)
        Me.btnOutputName.TabIndex = 6
        Me.btnOutputName.Text = "Browse..."
        Me.btnOutputName.UseVisualStyleBackColor = True
        '
        'txtInputName
        '
        Me.txtInputName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider.SetHelpString(Me.txtInputName, resources.GetString("txtInputName.HelpString"))
        Me.txtInputName.Location = New System.Drawing.Point(114, 124)
        Me.txtInputName.Name = "txtInputName"
        Me.HelpProvider.SetShowHelp(Me.txtInputName, True)
        Me.txtInputName.Size = New System.Drawing.Size(364, 20)
        Me.txtInputName.TabIndex = 2
        '
        'btnInputName
        '
        Me.btnInputName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HelpProvider.SetHelpString(Me.btnInputName, "Click this button to browse to the input/output folder.")
        Me.btnInputName.Location = New System.Drawing.Point(484, 123)
        Me.btnInputName.Name = "btnInputName"
        Me.HelpProvider.SetShowHelp(Me.btnInputName, True)
        Me.btnInputName.Size = New System.Drawing.Size(65, 23)
        Me.btnInputName.TabIndex = 3
        Me.btnInputName.Text = "Browse..."
        Me.btnInputName.UseVisualStyleBackColor = True
        '
        'btnP2Map
        '
        Me.btnP2Map.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnP2Map.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnP2Map.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP2Map.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HelpProvider.SetHelpString(Me.btnP2Map, "Display the 2-year, 24-hour precipitation map.")
        Me.btnP2Map.Location = New System.Drawing.Point(298, 294)
        Me.btnP2Map.Name = "btnP2Map"
        Me.btnP2Map.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HelpProvider.SetShowHelp(Me.btnP2Map, True)
        Me.btnP2Map.Size = New System.Drawing.Size(65, 25)
        Me.btnP2Map.TabIndex = 19
        Me.btnP2Map.Text = "P2 Map ..."
        Me.btnP2Map.UseVisualStyleBackColor = True
        '
        'cboPointSourceTable
        '
        Me.cboPointSourceTable.AllowDrop = True
        Me.cboPointSourceTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPointSourceTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboPointSourceTable, resources.GetString("cboPointSourceTable.HelpString"))
        Me.cboPointSourceTable.Location = New System.Drawing.Point(183, 134)
        Me.cboPointSourceTable.Name = "cboPointSourceTable"
        Me.HelpProvider.SetShowHelp(Me.cboPointSourceTable, True)
        Me.cboPointSourceTable.Size = New System.Drawing.Size(183, 21)
        Me.cboPointSourceTable.Sorted = True
        Me.cboPointSourceTable.TabIndex = 15
        '
        'cboClimateStaLayer
        '
        Me.cboClimateStaLayer.AllowDrop = True
        Me.cboClimateStaLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClimateStaLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboClimateStaLayer, "Specify a point shape file containing the location of climate stations.")
        Me.cboClimateStaLayer.Location = New System.Drawing.Point(183, 43)
        Me.cboClimateStaLayer.Name = "cboClimateStaLayer"
        Me.HelpProvider.SetShowHelp(Me.cboClimateStaLayer, True)
        Me.cboClimateStaLayer.Size = New System.Drawing.Size(183, 21)
        Me.cboClimateStaLayer.Sorted = True
        Me.cboClimateStaLayer.TabIndex = 4
        '
        'cboClimateStaField
        '
        Me.cboClimateStaField.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClimateStaField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClimateStaField.FormattingEnabled = True
        Me.HelpProvider.SetHelpString(Me.cboClimateStaField, "Select which shape file field contains the station ID.")
        Me.cboClimateStaField.Location = New System.Drawing.Point(372, 43)
        Me.cboClimateStaField.Name = "cboClimateStaField"
        Me.HelpProvider.SetShowHelp(Me.cboClimateStaField, True)
        Me.cboClimateStaField.Size = New System.Drawing.Size(91, 21)
        Me.cboClimateStaField.TabIndex = 5
        '
        'cboClimateDataTable
        '
        Me.cboClimateDataTable.AllowDrop = True
        Me.cboClimateDataTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClimateDataTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HelpProvider.SetHelpString(Me.cboClimateDataTable, "This climate time series table must contain these fields: STA_ID, IDATE, TAVG_C, " & _
                "PRCP_CM. All data tables must reside in the BASINS data folder for the current B" & _
                "ASINS project, under GBMM\Data.")
        Me.cboClimateDataTable.Location = New System.Drawing.Point(183, 70)
        Me.cboClimateDataTable.Name = "cboClimateDataTable"
        Me.HelpProvider.SetShowHelp(Me.cboClimateDataTable, True)
        Me.cboClimateDataTable.Size = New System.Drawing.Size(183, 21)
        Me.cboClimateDataTable.Sorted = True
        Me.cboClimateDataTable.TabIndex = 8
        '
        'chkForceRebuild
        '
        Me.chkForceRebuild.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.chkForceRebuild, resources.GetString("chkForceRebuild.HelpString"))
        Me.chkForceRebuild.Location = New System.Drawing.Point(18, 20)
        Me.chkForceRebuild.Name = "chkForceRebuild"
        Me.HelpProvider.SetShowHelp(Me.chkForceRebuild, True)
        Me.chkForceRebuild.Size = New System.Drawing.Size(176, 17)
        Me.chkForceRebuild.TabIndex = 0
        Me.chkForceRebuild.Text = "&Force all input files to be rebuilt"
        Me.chkForceRebuild.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider.SetHelpString(Me.btnReset, "Reset all inputs to their default values")
        Me.btnReset.Location = New System.Drawing.Point(425, 521)
        Me.btnReset.Name = "btnReset"
        Me.HelpProvider.SetShowHelp(Me.btnReset, True)
        Me.btnReset.Size = New System.Drawing.Size(75, 26)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset..."
        '
        'cboHgStationsField
        '
        Me.cboHgStationsField.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboHgStationsField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHgStationsField.FormattingEnabled = True
        Me.HelpProvider.SetHelpString(Me.cboHgStationsField, "The field in the shape file containing a unique subbasin ID.")
        Me.cboHgStationsField.Location = New System.Drawing.Point(408, 202)
        Me.cboHgStationsField.Name = "cboHgStationsField"
        Me.HelpProvider.SetShowHelp(Me.cboHgStationsField, True)
        Me.cboHgStationsField.Size = New System.Drawing.Size(93, 22)
        Me.cboHgStationsField.TabIndex = 19
        Me.cboHgStationsField.Visible = False
        '
        'btnViewFile
        '
        Me.btnViewFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider.SetHelpString(Me.btnViewFile, "Open the GBMM input file using Notepad (for debugging purposes only).")
        Me.btnViewFile.Location = New System.Drawing.Point(423, 305)
        Me.btnViewFile.Name = "btnViewFile"
        Me.HelpProvider.SetShowHelp(Me.btnViewFile, True)
        Me.btnViewFile.Size = New System.Drawing.Size(109, 23)
        Me.btnViewFile.TabIndex = 1
        Me.btnViewFile.Text = "View Input File..."
        Me.btnViewFile.UseVisualStyleBackColor = True
        '
        'chkAddLayers
        '
        Me.chkAddLayers.AutoSize = True
        Me.HelpProvider.SetHelpString(Me.chkAddLayers, resources.GetString("chkAddLayers.HelpString"))
        Me.chkAddLayers.Location = New System.Drawing.Point(18, 44)
        Me.chkAddLayers.Name = "chkAddLayers"
        Me.HelpProvider.SetShowHelp(Me.chkAddLayers, True)
        Me.chkAddLayers.Size = New System.Drawing.Size(179, 17)
        Me.chkAddLayers.TabIndex = 1
        Me.chkAddLayers.Text = "Add all &temporary layers to map"
        Me.chkAddLayers.UseVisualStyleBackColor = True
        '
        'Zed
        '
        Me.Zed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpProvider.SetHelpString(Me.Zed, "This ZedGraph tool displays the selected data for the period of record; use the m" & _
                "ouse scroll wheel to zoom and pan; rt-click for additional options.")
        Me.Zed.Location = New System.Drawing.Point(3, 3)
        Me.Zed.Name = "Zed"
        Me.Zed.ScrollGrace = 0
        Me.Zed.ScrollMaxX = 0
        Me.Zed.ScrollMaxY = 0
        Me.Zed.ScrollMaxY2 = 0
        Me.Zed.ScrollMinX = 0
        Me.Zed.ScrollMinY = 0
        Me.Zed.ScrollMinY2 = 0
        Me.HelpProvider.SetShowHelp(Me.Zed, True)
        Me.Zed.Size = New System.Drawing.Size(339, 360)
        Me.Zed.TabIndex = 0
        '
        'cboResultsSubbasin
        '
        Me.cboResultsSubbasin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboResultsSubbasin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResultsSubbasin.FormattingEnabled = True
        Me.HelpProvider.SetHelpString(Me.cboResultsSubbasin, "This is the subbasin number (assigned sequentially) that you want to display the " & _
                "results for.")
        Me.cboResultsSubbasin.Location = New System.Drawing.Point(374, 4)
        Me.cboResultsSubbasin.Name = "cboResultsSubbasin"
        Me.HelpProvider.SetShowHelp(Me.cboResultsSubbasin, True)
        Me.cboResultsSubbasin.Size = New System.Drawing.Size(75, 21)
        Me.cboResultsSubbasin.Sorted = True
        Me.cboResultsSubbasin.TabIndex = 3
        '
        'btnVariables
        '
        Me.HelpProvider.SetHelpString(Me.btnVariables, "Display the list of variables assocated with the selected output type below; thes" & _
                "e are checked to selected which are displayed in the graph and table.")
        Me.btnVariables.Location = New System.Drawing.Point(455, 3)
        Me.btnVariables.Name = "btnVariables"
        Me.HelpProvider.SetShowHelp(Me.btnVariables, True)
        Me.btnVariables.Size = New System.Drawing.Size(94, 23)
        Me.btnVariables.TabIndex = 4
        Me.btnVariables.Text = "Show Variables"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'cboResultsOutput
        '
        Me.cboResultsOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboResultsOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResultsOutput.FormattingEnabled = True
        Me.HelpProvider.SetHelpString(Me.cboResultsOutput, "This is the type of computed output to display. Each type as its own unique set o" & _
                "f parameters.")
        Me.cboResultsOutput.Location = New System.Drawing.Point(84, 4)
        Me.cboResultsOutput.Name = "cboResultsOutput"
        Me.HelpProvider.SetShowHelp(Me.cboResultsOutput, True)
        Me.cboResultsOutput.Size = New System.Drawing.Size(224, 21)
        Me.cboResultsOutput.Sorted = True
        Me.cboResultsOutput.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HelpProvider.SetHelpString(Me.btnPrint, "Send the currently displayed graph or report to the printer.")
        Me.btnPrint.Location = New System.Drawing.Point(464, 430)
        Me.btnPrint.Name = "btnPrint"
        Me.HelpProvider.SetShowHelp(Me.btnPrint, True)
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "&Print..."
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider.SetHelpString(Me.btnPreview, "Display the print preview form.")
        Me.btnPreview.Location = New System.Drawing.Point(374, 430)
        Me.btnPreview.Name = "btnPreview"
        Me.HelpProvider.SetShowHelp(Me.btnPreview, True)
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 7
        Me.btnPreview.Text = "Pre&view..."
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.HelpProvider.SetHelpString(Me.btnCopy, "Copy the graph or report to the clipboard.")
        Me.btnCopy.Location = New System.Drawing.Point(3, 430)
        Me.btnCopy.Name = "btnCopy"
        Me.HelpProvider.SetShowHelp(Me.btnCopy, True)
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 6
        Me.btnCopy.Text = "&Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'tabResults
        '
        Me.tabResults.Controls.Add(Me.TableLayoutPanel2)
        Me.tabResults.Location = New System.Drawing.Point(4, 25)
        Me.tabResults.Name = "tabResults"
        Me.tabResults.Padding = New System.Windows.Forms.Padding(3)
        Me.tabResults.Size = New System.Drawing.Size(558, 462)
        Me.tabResults.TabIndex = 5
        Me.tabResults.Text = "Results"
        Me.tabResults.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.Controls.Add(Me.Label137, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.splitResults, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label138, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cboResultsSubbasin, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnVariables, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cboResultsOutput, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPrint, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPreview, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCopy, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(552, 456)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label137
        '
        Me.Label137.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label137.AutoSize = True
        Me.Label137.Location = New System.Drawing.Point(6, 8)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(72, 13)
        Me.Label137.TabIndex = 0
        Me.Label137.Text = "Output Type:"
        '
        'splitResults
        '
        Me.splitResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.splitResults, 5)
        Me.splitResults.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitResults.Location = New System.Drawing.Point(3, 32)
        Me.splitResults.Name = "splitResults"
        '
        'splitResults.Panel1
        '
        Me.splitResults.Panel1.Controls.Add(Me.tabResult)
        '
        'splitResults.Panel2
        '
        Me.splitResults.Panel2.Controls.Add(Me.lstVariables)
        Me.splitResults.Size = New System.Drawing.Size(546, 392)
        Me.splitResults.SplitterDistance = 353
        Me.splitResults.TabIndex = 5
        '
        'tabResult
        '
        Me.tabResult.Controls.Add(Me.TabPage14)
        Me.tabResult.Controls.Add(Me.TabPage15)
        Me.tabResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabResult.Location = New System.Drawing.Point(0, 0)
        Me.tabResult.Name = "tabResult"
        Me.tabResult.SelectedIndex = 0
        Me.tabResult.Size = New System.Drawing.Size(353, 392)
        Me.tabResult.TabIndex = 0
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.Zed)
        Me.TabPage14.Location = New System.Drawing.Point(4, 22)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(345, 366)
        Me.TabPage14.TabIndex = 0
        Me.TabPage14.Text = "Graph"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'TabPage15
        '
        Me.TabPage15.Controls.Add(Me.wbResults)
        Me.TabPage15.Location = New System.Drawing.Point(4, 22)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage15.Size = New System.Drawing.Size(345, 366)
        Me.TabPage15.TabIndex = 1
        Me.TabPage15.Text = "Tabular"
        Me.TabPage15.UseVisualStyleBackColor = True
        '
        'wbResults
        '
        Me.wbResults.AllowWebBrowserDrop = False
        Me.wbResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbResults.Location = New System.Drawing.Point(3, 3)
        Me.wbResults.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbResults.Name = "wbResults"
        Me.wbResults.Size = New System.Drawing.Size(339, 360)
        Me.wbResults.TabIndex = 0
        '
        'lstVariables
        '
        Me.lstVariables.CheckOnClick = True
        Me.lstVariables.ContextMenuStrip = Me.mnuVariables
        Me.lstVariables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstVariables.FormattingEnabled = True
        Me.lstVariables.IntegralHeight = False
        Me.lstVariables.Location = New System.Drawing.Point(0, 0)
        Me.lstVariables.Name = "lstVariables"
        Me.lstVariables.Size = New System.Drawing.Size(189, 392)
        Me.lstVariables.TabIndex = 0
        '
        'mnuVariables
        '
        Me.mnuVariables.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAllToolStripMenuItem, Me.SelectNoneToolStripMenuItem})
        Me.mnuVariables.Name = "mnuVariables"
        Me.mnuVariables.Size = New System.Drawing.Size(143, 48)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'SelectNoneToolStripMenuItem
        '
        Me.SelectNoneToolStripMenuItem.Name = "SelectNoneToolStripMenuItem"
        Me.SelectNoneToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SelectNoneToolStripMenuItem.Text = "Select None"
        '
        'Label138
        '
        Me.Label138.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label138.AutoSize = True
        Me.Label138.Location = New System.Drawing.Point(314, 8)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(54, 13)
        Me.Label138.TabIndex = 2
        Me.Label138.Text = "SubBasin:"
        '
        'tabMercury
        '
        Me.tabMercury.Controls.Add(Me.TabControl2)
        Me.tabMercury.Controls.Add(Me.Label7)
        Me.tabMercury.Location = New System.Drawing.Point(4, 25)
        Me.tabMercury.Name = "tabMercury"
        Me.tabMercury.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMercury.Size = New System.Drawing.Size(558, 462)
        Me.tabMercury.TabIndex = 3
        Me.tabMercury.Text = "Mercury"
        Me.tabMercury.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me._SSTab1_TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.ItemSize = New System.Drawing.Size(42, 19)
        Me.TabControl2.Location = New System.Drawing.Point(3, 58)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(552, 401)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.Frame2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(544, 374)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Mercury Data"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtInitialSoilHgMultiplier)
        Me.GroupBox2.Controls.Add(Me.txtInitialConstantHg)
        Me.GroupBox2.Controls.Add(Me.optionInitialHgConstant)
        Me.GroupBox2.Controls.Add(Me.optionSoilHgGrid)
        Me.GroupBox2.Controls.Add(Me.cboInitialSoilHg)
        Me.GroupBox2.Controls.Add(Me.lblInitialSoilHgMultiplier)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(19, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(507, 73)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Initial Hg Concentration in Watershed Soil (ng/g)"
        '
        'txtInitialSoilHgMultiplier
        '
        Me.txtInitialSoilHgMultiplier.AcceptsReturn = True
        Me.txtInitialSoilHgMultiplier.BackColor = System.Drawing.SystemColors.Window
        Me.txtInitialSoilHgMultiplier.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInitialSoilHgMultiplier.Enabled = False
        Me.txtInitialSoilHgMultiplier.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitialSoilHgMultiplier.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInitialSoilHgMultiplier.Location = New System.Drawing.Point(461, 47)
        Me.txtInitialSoilHgMultiplier.MaxLength = 0
        Me.txtInitialSoilHgMultiplier.Name = "txtInitialSoilHgMultiplier"
        Me.txtInitialSoilHgMultiplier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInitialSoilHgMultiplier.Size = New System.Drawing.Size(30, 20)
        Me.txtInitialSoilHgMultiplier.TabIndex = 5
        Me.txtInitialSoilHgMultiplier.Text = "1"
        '
        'txtInitialConstantHg
        '
        Me.txtInitialConstantHg.AcceptsReturn = True
        Me.txtInitialConstantHg.BackColor = System.Drawing.SystemColors.Window
        Me.txtInitialConstantHg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInitialConstantHg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitialConstantHg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInitialConstantHg.Location = New System.Drawing.Point(215, 21)
        Me.txtInitialConstantHg.MaxLength = 0
        Me.txtInitialConstantHg.Name = "txtInitialConstantHg"
        Me.txtInitialConstantHg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInitialConstantHg.Size = New System.Drawing.Size(50, 20)
        Me.txtInitialConstantHg.TabIndex = 1
        Me.txtInitialConstantHg.Text = "50"
        '
        'optionInitialHgConstant
        '
        Me.optionInitialHgConstant.AutoSize = True
        Me.optionInitialHgConstant.BackColor = System.Drawing.Color.Transparent
        Me.optionInitialHgConstant.Checked = True
        Me.optionInitialHgConstant.Cursor = System.Windows.Forms.Cursors.Default
        Me.optionInitialHgConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionInitialHgConstant.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optionInitialHgConstant.Location = New System.Drawing.Point(24, 22)
        Me.optionInitialHgConstant.Name = "optionInitialHgConstant"
        Me.optionInitialHgConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optionInitialHgConstant.Size = New System.Drawing.Size(102, 18)
        Me.optionInitialHgConstant.TabIndex = 0
        Me.optionInitialHgConstant.TabStop = True
        Me.optionInitialHgConstant.Text = "Constant Value:"
        Me.optionInitialHgConstant.UseVisualStyleBackColor = False
        '
        'optionSoilHgGrid
        '
        Me.optionSoilHgGrid.AutoSize = True
        Me.optionSoilHgGrid.BackColor = System.Drawing.Color.Transparent
        Me.optionSoilHgGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.optionSoilHgGrid.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionSoilHgGrid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optionSoilHgGrid.Location = New System.Drawing.Point(24, 48)
        Me.optionSoilHgGrid.Name = "optionSoilHgGrid"
        Me.optionSoilHgGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optionSoilHgGrid.Size = New System.Drawing.Size(175, 18)
        Me.optionSoilHgGrid.TabIndex = 2
        Me.optionSoilHgGrid.TabStop = True
        Me.optionSoilHgGrid.Text = "Initial Concentration Grid Layer:"
        Me.optionSoilHgGrid.UseVisualStyleBackColor = False
        '
        'cboInitialSoilHg
        '
        Me.cboInitialSoilHg.BackColor = System.Drawing.SystemColors.Window
        Me.cboInitialSoilHg.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboInitialSoilHg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInitialSoilHg.Enabled = False
        Me.cboInitialSoilHg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInitialSoilHg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboInitialSoilHg.Location = New System.Drawing.Point(215, 45)
        Me.cboInitialSoilHg.Name = "cboInitialSoilHg"
        Me.cboInitialSoilHg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboInitialSoilHg.Size = New System.Drawing.Size(184, 22)
        Me.cboInitialSoilHg.TabIndex = 3
        Me.cboInitialSoilHg.Tag = "Raster"
        '
        'lblInitialSoilHgMultiplier
        '
        Me.lblInitialSoilHgMultiplier.AutoSize = True
        Me.lblInitialSoilHgMultiplier.BackColor = System.Drawing.Color.Transparent
        Me.lblInitialSoilHgMultiplier.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInitialSoilHgMultiplier.Enabled = False
        Me.lblInitialSoilHgMultiplier.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitialSoilHgMultiplier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInitialSoilHgMultiplier.Location = New System.Drawing.Point(405, 50)
        Me.lblInitialSoilHgMultiplier.Name = "lblInitialSoilHgMultiplier"
        Me.lblInitialSoilHgMultiplier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInitialSoilHgMultiplier.Size = New System.Drawing.Size(51, 14)
        Me.lblInitialSoilHgMultiplier.TabIndex = 4
        Me.lblInitialSoilHgMultiplier.Text = "Multiplier:"
        '
        'Frame2
        '
        Me.Frame2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Frame2.BackColor = System.Drawing.Color.Transparent
        Me.Frame2.Controls.Add(Me.cboHgStationsField)
        Me.Frame2.Controls.Add(Me.cboHgWetDepTS)
        Me.Frame2.Controls.Add(Me.cboHgDryDepTS)
        Me.Frame2.Controls.Add(Me.cboHgStationsLayer)
        Me.Frame2.Controls.Add(Me.cboHgWetDepTable)
        Me.Frame2.Controls.Add(Me.cboHgDryDepTable)
        Me.Frame2.Controls.Add(Me.chkHgTimeSeries)
        Me.Frame2.Controls.Add(Me.chkHgGrid)
        Me.Frame2.Controls.Add(Me.chkHgConstant)
        Me.Frame2.Controls.Add(Me.txtHgWetPrcpConc)
        Me.Frame2.Controls.Add(Me.optionHgWetPrcpConc)
        Me.Frame2.Controls.Add(Me.txtHgWetMultiplier)
        Me.Frame2.Controls.Add(Me.txtHgWetConstant)
        Me.Frame2.Controls.Add(Me.optionHgWetConst)
        Me.Frame2.Controls.Add(Me.cboHgWetDepositionFlux)
        Me.Frame2.Controls.Add(Me.txtHgDryMultiplier)
        Me.Frame2.Controls.Add(Me.txtHgDryConstant)
        Me.Frame2.Controls.Add(Me.cboHgDryDepositionFlux)
        Me.Frame2.Controls.Add(Me.lblHgWet)
        Me.Frame2.Controls.Add(Me.lblHgDry)
        Me.Frame2.Controls.Add(Me.lblHgWetDepTS)
        Me.Frame2.Controls.Add(Me.lblDryHgDepTS)
        Me.Frame2.Controls.Add(Me.lblHgStation)
        Me.Frame2.Controls.Add(Me.lblDryDeposition)
        Me.Frame2.Controls.Add(Me.lblHgWetMul)
        Me.Frame2.Controls.Add(Me.lblHgDryMul)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(19, 86)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(507, 281)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Daily Mercury Deposition Flux (ug/m²)"
        '
        'cboHgWetDepTS
        '
        Me.cboHgWetDepTS.BackColor = System.Drawing.SystemColors.Window
        Me.cboHgWetDepTS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHgWetDepTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHgWetDepTS.Enabled = False
        Me.cboHgWetDepTS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHgWetDepTS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHgWetDepTS.Location = New System.Drawing.Point(408, 250)
        Me.cboHgWetDepTS.Name = "cboHgWetDepTS"
        Me.cboHgWetDepTS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHgWetDepTS.Size = New System.Drawing.Size(93, 22)
        Me.cboHgWetDepTS.TabIndex = 25
        '
        'cboHgDryDepTS
        '
        Me.cboHgDryDepTS.BackColor = System.Drawing.SystemColors.Window
        Me.cboHgDryDepTS.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHgDryDepTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHgDryDepTS.Enabled = False
        Me.cboHgDryDepTS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHgDryDepTS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHgDryDepTS.Location = New System.Drawing.Point(408, 226)
        Me.cboHgDryDepTS.Name = "cboHgDryDepTS"
        Me.cboHgDryDepTS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHgDryDepTS.Size = New System.Drawing.Size(93, 22)
        Me.cboHgDryDepTS.TabIndex = 22
        '
        'cboHgStationsLayer
        '
        Me.cboHgStationsLayer.BackColor = System.Drawing.SystemColors.Window
        Me.cboHgStationsLayer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHgStationsLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHgStationsLayer.Enabled = False
        Me.cboHgStationsLayer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHgStationsLayer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHgStationsLayer.Location = New System.Drawing.Point(218, 202)
        Me.cboHgStationsLayer.Name = "cboHgStationsLayer"
        Me.cboHgStationsLayer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHgStationsLayer.Size = New System.Drawing.Size(181, 22)
        Me.cboHgStationsLayer.TabIndex = 18
        Me.cboHgStationsLayer.Tag = "Feature"
        '
        'cboHgWetDepTable
        '
        Me.cboHgWetDepTable.BackColor = System.Drawing.SystemColors.Window
        Me.cboHgWetDepTable.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHgWetDepTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHgWetDepTable.Enabled = False
        Me.cboHgWetDepTable.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHgWetDepTable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHgWetDepTable.Location = New System.Drawing.Point(218, 250)
        Me.cboHgWetDepTable.Name = "cboHgWetDepTable"
        Me.cboHgWetDepTable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHgWetDepTable.Size = New System.Drawing.Size(181, 22)
        Me.cboHgWetDepTable.TabIndex = 24
        Me.cboHgWetDepTable.Tag = "Table"
        '
        'cboHgDryDepTable
        '
        Me.cboHgDryDepTable.BackColor = System.Drawing.SystemColors.Window
        Me.cboHgDryDepTable.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHgDryDepTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHgDryDepTable.Enabled = False
        Me.cboHgDryDepTable.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHgDryDepTable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHgDryDepTable.Location = New System.Drawing.Point(218, 226)
        Me.cboHgDryDepTable.Name = "cboHgDryDepTable"
        Me.cboHgDryDepTable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHgDryDepTable.Size = New System.Drawing.Size(181, 22)
        Me.cboHgDryDepTable.TabIndex = 21
        Me.cboHgDryDepTable.Tag = "Table"
        '
        'chkHgTimeSeries
        '
        Me.chkHgTimeSeries.AutoSize = True
        Me.chkHgTimeSeries.BackColor = System.Drawing.Color.Transparent
        Me.chkHgTimeSeries.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkHgTimeSeries.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHgTimeSeries.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkHgTimeSeries.Location = New System.Drawing.Point(8, 183)
        Me.chkHgTimeSeries.Name = "chkHgTimeSeries"
        Me.chkHgTimeSeries.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHgTimeSeries.Size = New System.Drawing.Size(186, 18)
        Me.chkHgTimeSeries.TabIndex = 16
        Me.chkHgTimeSeries.Text = "Time-variable Mercury Deposition"
        Me.chkHgTimeSeries.UseVisualStyleBackColor = False
        '
        'chkHgGrid
        '
        Me.chkHgGrid.AutoSize = True
        Me.chkHgGrid.BackColor = System.Drawing.Color.Transparent
        Me.chkHgGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkHgGrid.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHgGrid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkHgGrid.Location = New System.Drawing.Point(6, 107)
        Me.chkHgGrid.Name = "chkHgGrid"
        Me.chkHgGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHgGrid.Size = New System.Drawing.Size(142, 18)
        Me.chkHgGrid.TabIndex = 7
        Me.chkHgGrid.Text = "Mercury Deposition Grid"
        Me.chkHgGrid.UseVisualStyleBackColor = False
        '
        'chkHgConstant
        '
        Me.chkHgConstant.AutoSize = True
        Me.chkHgConstant.BackColor = System.Drawing.Color.Transparent
        Me.chkHgConstant.Checked = True
        Me.chkHgConstant.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHgConstant.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkHgConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHgConstant.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkHgConstant.Location = New System.Drawing.Point(8, 16)
        Me.chkHgConstant.Name = "chkHgConstant"
        Me.chkHgConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHgConstant.Size = New System.Drawing.Size(165, 18)
        Me.chkHgConstant.TabIndex = 0
        Me.chkHgConstant.Text = "Constant Mercury Deposition"
        Me.chkHgConstant.UseVisualStyleBackColor = False
        '
        'txtHgWetPrcpConc
        '
        Me.txtHgWetPrcpConc.AcceptsReturn = True
        Me.txtHgWetPrcpConc.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWetPrcpConc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWetPrcpConc.Enabled = False
        Me.txtHgWetPrcpConc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWetPrcpConc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWetPrcpConc.Location = New System.Drawing.Point(272, 80)
        Me.txtHgWetPrcpConc.MaxLength = 0
        Me.txtHgWetPrcpConc.Name = "txtHgWetPrcpConc"
        Me.txtHgWetPrcpConc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWetPrcpConc.Size = New System.Drawing.Size(54, 20)
        Me.txtHgWetPrcpConc.TabIndex = 6
        Me.txtHgWetPrcpConc.Text = "15.0"
        '
        'optionHgWetPrcpConc
        '
        Me.optionHgWetPrcpConc.AutoSize = True
        Me.optionHgWetPrcpConc.BackColor = System.Drawing.Color.Transparent
        Me.optionHgWetPrcpConc.Cursor = System.Windows.Forms.Cursors.Default
        Me.optionHgWetPrcpConc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionHgWetPrcpConc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optionHgWetPrcpConc.Location = New System.Drawing.Point(40, 80)
        Me.optionHgWetPrcpConc.Name = "optionHgWetPrcpConc"
        Me.optionHgWetPrcpConc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optionHgWetPrcpConc.Size = New System.Drawing.Size(211, 18)
        Me.optionHgWetPrcpConc.TabIndex = 5
        Me.optionHgWetPrcpConc.TabStop = True
        Me.optionHgWetPrcpConc.Text = "Hg Concentration in Precipitation (ng/l):"
        Me.optionHgWetPrcpConc.UseVisualStyleBackColor = False
        '
        'txtHgWetMultiplier
        '
        Me.txtHgWetMultiplier.AcceptsReturn = True
        Me.txtHgWetMultiplier.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWetMultiplier.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWetMultiplier.Enabled = False
        Me.txtHgWetMultiplier.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWetMultiplier.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWetMultiplier.Location = New System.Drawing.Point(461, 152)
        Me.txtHgWetMultiplier.MaxLength = 0
        Me.txtHgWetMultiplier.Name = "txtHgWetMultiplier"
        Me.txtHgWetMultiplier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWetMultiplier.Size = New System.Drawing.Size(30, 20)
        Me.txtHgWetMultiplier.TabIndex = 15
        Me.txtHgWetMultiplier.Text = "1"
        '
        'txtHgWetConstant
        '
        Me.txtHgWetConstant.AcceptsReturn = True
        Me.txtHgWetConstant.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWetConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWetConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWetConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWetConstant.Location = New System.Drawing.Point(272, 56)
        Me.txtHgWetConstant.MaxLength = 0
        Me.txtHgWetConstant.Name = "txtHgWetConstant"
        Me.txtHgWetConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWetConstant.Size = New System.Drawing.Size(54, 20)
        Me.txtHgWetConstant.TabIndex = 4
        Me.txtHgWetConstant.Text = "0.15"
        '
        'optionHgWetConst
        '
        Me.optionHgWetConst.AutoSize = True
        Me.optionHgWetConst.BackColor = System.Drawing.Color.Transparent
        Me.optionHgWetConst.Checked = True
        Me.optionHgWetConst.Cursor = System.Windows.Forms.Cursors.Default
        Me.optionHgWetConst.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionHgWetConst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optionHgWetConst.Location = New System.Drawing.Point(40, 56)
        Me.optionHgWetConst.Name = "optionHgWetConst"
        Me.optionHgWetConst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optionHgWetConst.Size = New System.Drawing.Size(185, 18)
        Me.optionHgWetConst.TabIndex = 3
        Me.optionHgWetConst.TabStop = True
        Me.optionHgWetConst.Text = "Hg Wet Deposition Flux Constant:"
        Me.optionHgWetConst.UseVisualStyleBackColor = False
        '
        'cboHgWetDepositionFlux
        '
        Me.cboHgWetDepositionFlux.BackColor = System.Drawing.SystemColors.Window
        Me.cboHgWetDepositionFlux.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHgWetDepositionFlux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHgWetDepositionFlux.Enabled = False
        Me.cboHgWetDepositionFlux.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHgWetDepositionFlux.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHgWetDepositionFlux.Location = New System.Drawing.Point(218, 152)
        Me.cboHgWetDepositionFlux.Name = "cboHgWetDepositionFlux"
        Me.cboHgWetDepositionFlux.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHgWetDepositionFlux.Size = New System.Drawing.Size(181, 22)
        Me.cboHgWetDepositionFlux.TabIndex = 13
        Me.cboHgWetDepositionFlux.Tag = "Raster"
        '
        'txtHgDryMultiplier
        '
        Me.txtHgDryMultiplier.AcceptsReturn = True
        Me.txtHgDryMultiplier.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgDryMultiplier.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgDryMultiplier.Enabled = False
        Me.txtHgDryMultiplier.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgDryMultiplier.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgDryMultiplier.Location = New System.Drawing.Point(461, 128)
        Me.txtHgDryMultiplier.MaxLength = 0
        Me.txtHgDryMultiplier.Name = "txtHgDryMultiplier"
        Me.txtHgDryMultiplier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgDryMultiplier.Size = New System.Drawing.Size(30, 20)
        Me.txtHgDryMultiplier.TabIndex = 11
        Me.txtHgDryMultiplier.Text = "1"
        '
        'txtHgDryConstant
        '
        Me.txtHgDryConstant.AcceptsReturn = True
        Me.txtHgDryConstant.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgDryConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgDryConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgDryConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgDryConstant.Location = New System.Drawing.Point(272, 32)
        Me.txtHgDryConstant.MaxLength = 0
        Me.txtHgDryConstant.Name = "txtHgDryConstant"
        Me.txtHgDryConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgDryConstant.Size = New System.Drawing.Size(54, 20)
        Me.txtHgDryConstant.TabIndex = 2
        Me.txtHgDryConstant.Text = "0.03"
        '
        'cboHgDryDepositionFlux
        '
        Me.cboHgDryDepositionFlux.BackColor = System.Drawing.SystemColors.Window
        Me.cboHgDryDepositionFlux.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHgDryDepositionFlux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHgDryDepositionFlux.Enabled = False
        Me.cboHgDryDepositionFlux.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHgDryDepositionFlux.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHgDryDepositionFlux.Location = New System.Drawing.Point(218, 128)
        Me.cboHgDryDepositionFlux.Name = "cboHgDryDepositionFlux"
        Me.cboHgDryDepositionFlux.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHgDryDepositionFlux.Size = New System.Drawing.Size(181, 22)
        Me.cboHgDryDepositionFlux.TabIndex = 9
        Me.cboHgDryDepositionFlux.Tag = "Raster"
        '
        'lblHgWet
        '
        Me.lblHgWet.AutoSize = True
        Me.lblHgWet.BackColor = System.Drawing.Color.Transparent
        Me.lblHgWet.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHgWet.Enabled = False
        Me.lblHgWet.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHgWet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHgWet.Location = New System.Drawing.Point(32, 155)
        Me.lblHgWet.Name = "lblHgWet"
        Me.lblHgWet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHgWet.Size = New System.Drawing.Size(144, 14)
        Me.lblHgWet.TabIndex = 12
        Me.lblHgWet.Text = "Hg Wet Deposition Flux Grid:"
        '
        'lblHgDry
        '
        Me.lblHgDry.AutoSize = True
        Me.lblHgDry.BackColor = System.Drawing.Color.Transparent
        Me.lblHgDry.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHgDry.Enabled = False
        Me.lblHgDry.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHgDry.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHgDry.Location = New System.Drawing.Point(32, 131)
        Me.lblHgDry.Name = "lblHgDry"
        Me.lblHgDry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHgDry.Size = New System.Drawing.Size(142, 14)
        Me.lblHgDry.TabIndex = 8
        Me.lblHgDry.Text = "Hg Dry Deposition Flux Grid:"
        '
        'lblHgWetDepTS
        '
        Me.lblHgWetDepTS.AutoSize = True
        Me.lblHgWetDepTS.BackColor = System.Drawing.Color.Transparent
        Me.lblHgWetDepTS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHgWetDepTS.Enabled = False
        Me.lblHgWetDepTS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHgWetDepTS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHgWetDepTS.Location = New System.Drawing.Point(32, 253)
        Me.lblHgWetDepTS.Name = "lblHgWetDepTS"
        Me.lblHgWetDepTS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHgWetDepTS.Size = New System.Drawing.Size(170, 14)
        Me.lblHgWetDepTS.TabIndex = 23
        Me.lblHgWetDepTS.Text = "Wet Deposition Time Series Table:"
        '
        'lblDryHgDepTS
        '
        Me.lblDryHgDepTS.AutoSize = True
        Me.lblDryHgDepTS.BackColor = System.Drawing.Color.Transparent
        Me.lblDryHgDepTS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDryHgDepTS.Enabled = False
        Me.lblDryHgDepTS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDryHgDepTS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDryHgDepTS.Location = New System.Drawing.Point(32, 229)
        Me.lblDryHgDepTS.Name = "lblDryHgDepTS"
        Me.lblDryHgDepTS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDryHgDepTS.Size = New System.Drawing.Size(168, 14)
        Me.lblDryHgDepTS.TabIndex = 20
        Me.lblDryHgDepTS.Text = "Dry Deposition Time Series Table:"
        '
        'lblHgStation
        '
        Me.lblHgStation.AutoSize = True
        Me.lblHgStation.BackColor = System.Drawing.Color.Transparent
        Me.lblHgStation.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHgStation.Enabled = False
        Me.lblHgStation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHgStation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHgStation.Location = New System.Drawing.Point(32, 205)
        Me.lblHgStation.Name = "lblHgStation"
        Me.lblHgStation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHgStation.Size = New System.Drawing.Size(179, 14)
        Me.lblHgStation.TabIndex = 17
        Me.lblHgStation.Text = "Mercury Observation Station Layer:"
        '
        'lblDryDeposition
        '
        Me.lblDryDeposition.AutoSize = True
        Me.lblDryDeposition.BackColor = System.Drawing.Color.Transparent
        Me.lblDryDeposition.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDryDeposition.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDryDeposition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDryDeposition.Location = New System.Drawing.Point(37, 35)
        Me.lblDryDeposition.Name = "lblDryDeposition"
        Me.lblDryDeposition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDryDeposition.Size = New System.Drawing.Size(165, 14)
        Me.lblDryDeposition.TabIndex = 1
        Me.lblDryDeposition.Text = "Hg Dry Deposition Flux Constant:"
        '
        'lblHgWetMul
        '
        Me.lblHgWetMul.AutoSize = True
        Me.lblHgWetMul.BackColor = System.Drawing.Color.Transparent
        Me.lblHgWetMul.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHgWetMul.Enabled = False
        Me.lblHgWetMul.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHgWetMul.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHgWetMul.Location = New System.Drawing.Point(405, 155)
        Me.lblHgWetMul.Name = "lblHgWetMul"
        Me.lblHgWetMul.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHgWetMul.Size = New System.Drawing.Size(51, 14)
        Me.lblHgWetMul.TabIndex = 14
        Me.lblHgWetMul.Text = "Multiplier:"
        '
        'lblHgDryMul
        '
        Me.lblHgDryMul.AutoSize = True
        Me.lblHgDryMul.BackColor = System.Drawing.Color.Transparent
        Me.lblHgDryMul.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHgDryMul.Enabled = False
        Me.lblHgDryMul.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHgDryMul.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHgDryMul.Location = New System.Drawing.Point(405, 131)
        Me.lblHgDryMul.Name = "lblHgDryMul"
        Me.lblHgDryMul.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHgDryMul.Size = New System.Drawing.Size(51, 14)
        Me.lblHgDryMul.TabIndex = 10
        Me.lblHgDryMul.Text = "Multiplier:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.MercuryLand)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(544, 374)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Land"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'MercuryLand
        '
        Me.MercuryLand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MercuryLand.BackColor = System.Drawing.Color.Transparent
        Me.MercuryLand.Controls.Add(Me.txtInitialHgSaturatedSoilConstant)
        Me.MercuryLand.Controls.Add(Me.txtHgLandSoilParticleDensity)
        Me.MercuryLand.Controls.Add(Me.txtHgLandBedrockDensity)
        Me.MercuryLand.Controls.Add(Me.txtHgLandBedrockHgConc)
        Me.MercuryLand.Controls.Add(Me.txtHgLandPollutantEnrichmentFactor)
        Me.MercuryLand.Controls.Add(Me.txtHgLandSoilReductionDepth)
        Me.MercuryLand.Controls.Add(Me.txtHgLandSoilBaseReductionRate)
        Me.MercuryLand.Controls.Add(Me.txtHgLandChemicalWeatheringRate)
        Me.MercuryLand.Controls.Add(Me.txtHgLandSoilWaterPartitionCoeff)
        Me.MercuryLand.Controls.Add(Me.txtHgLandSoilMixingDepth)
        Me.MercuryLand.Controls.Add(Me.txtHgLandAirPlantBioConc)
        Me.MercuryLand.Controls.Add(Me.txtHgLandAirHgConc)
        Me.MercuryLand.Controls.Add(Me.Label85)
        Me.MercuryLand.Controls.Add(Me.Label109)
        Me.MercuryLand.Controls.Add(Me.Label60)
        Me.MercuryLand.Controls.Add(Me.Label19)
        Me.MercuryLand.Controls.Add(Me.Label61)
        Me.MercuryLand.Controls.Add(Me.Label20)
        Me.MercuryLand.Controls.Add(Me.Label21)
        Me.MercuryLand.Controls.Add(Me.Label22)
        Me.MercuryLand.Controls.Add(Me.Label23)
        Me.MercuryLand.Controls.Add(Me.Label24)
        Me.MercuryLand.Controls.Add(Me.Label25)
        Me.MercuryLand.Controls.Add(Me.Label26)
        Me.MercuryLand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MercuryLand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MercuryLand.Location = New System.Drawing.Point(104, 23)
        Me.MercuryLand.Name = "MercuryLand"
        Me.MercuryLand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MercuryLand.Size = New System.Drawing.Size(336, 328)
        Me.MercuryLand.TabIndex = 0
        Me.MercuryLand.TabStop = False
        Me.MercuryLand.Text = "Define Constants for Mercury (Land)"
        '
        'txtInitialHgSaturatedSoilConstant
        '
        Me.txtInitialHgSaturatedSoilConstant.AcceptsReturn = True
        Me.txtInitialHgSaturatedSoilConstant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInitialHgSaturatedSoilConstant.BackColor = System.Drawing.SystemColors.Window
        Me.txtInitialHgSaturatedSoilConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInitialHgSaturatedSoilConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitialHgSaturatedSoilConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInitialHgSaturatedSoilConstant.Location = New System.Drawing.Point(259, 72)
        Me.txtInitialHgSaturatedSoilConstant.MaxLength = 0
        Me.txtInitialHgSaturatedSoilConstant.Name = "txtInitialHgSaturatedSoilConstant"
        Me.txtInitialHgSaturatedSoilConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInitialHgSaturatedSoilConstant.Size = New System.Drawing.Size(67, 20)
        Me.txtInitialHgSaturatedSoilConstant.TabIndex = 5
        Me.txtInitialHgSaturatedSoilConstant.Text = "0.00001"
        '
        'txtHgLandSoilParticleDensity
        '
        Me.txtHgLandSoilParticleDensity.AcceptsReturn = True
        Me.txtHgLandSoilParticleDensity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandSoilParticleDensity.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandSoilParticleDensity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandSoilParticleDensity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandSoilParticleDensity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandSoilParticleDensity.Location = New System.Drawing.Point(259, 144)
        Me.txtHgLandSoilParticleDensity.MaxLength = 0
        Me.txtHgLandSoilParticleDensity.Name = "txtHgLandSoilParticleDensity"
        Me.txtHgLandSoilParticleDensity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandSoilParticleDensity.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandSoilParticleDensity.TabIndex = 11
        Me.txtHgLandSoilParticleDensity.Text = "2.65"
        '
        'txtHgLandBedrockDensity
        '
        Me.txtHgLandBedrockDensity.AcceptsReturn = True
        Me.txtHgLandBedrockDensity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandBedrockDensity.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandBedrockDensity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandBedrockDensity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandBedrockDensity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandBedrockDensity.Location = New System.Drawing.Point(259, 240)
        Me.txtHgLandBedrockDensity.MaxLength = 0
        Me.txtHgLandBedrockDensity.Name = "txtHgLandBedrockDensity"
        Me.txtHgLandBedrockDensity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandBedrockDensity.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandBedrockDensity.TabIndex = 19
        Me.txtHgLandBedrockDensity.Text = "2.6"
        '
        'txtHgLandBedrockHgConc
        '
        Me.txtHgLandBedrockHgConc.AcceptsReturn = True
        Me.txtHgLandBedrockHgConc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandBedrockHgConc.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandBedrockHgConc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandBedrockHgConc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandBedrockHgConc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandBedrockHgConc.Location = New System.Drawing.Point(259, 288)
        Me.txtHgLandBedrockHgConc.MaxLength = 0
        Me.txtHgLandBedrockHgConc.Name = "txtHgLandBedrockHgConc"
        Me.txtHgLandBedrockHgConc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandBedrockHgConc.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandBedrockHgConc.TabIndex = 23
        Me.txtHgLandBedrockHgConc.Text = "60"
        '
        'txtHgLandPollutantEnrichmentFactor
        '
        Me.txtHgLandPollutantEnrichmentFactor.AcceptsReturn = True
        Me.txtHgLandPollutantEnrichmentFactor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandPollutantEnrichmentFactor.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandPollutantEnrichmentFactor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandPollutantEnrichmentFactor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandPollutantEnrichmentFactor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandPollutantEnrichmentFactor.Location = New System.Drawing.Point(259, 216)
        Me.txtHgLandPollutantEnrichmentFactor.MaxLength = 0
        Me.txtHgLandPollutantEnrichmentFactor.Name = "txtHgLandPollutantEnrichmentFactor"
        Me.txtHgLandPollutantEnrichmentFactor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandPollutantEnrichmentFactor.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandPollutantEnrichmentFactor.TabIndex = 17
        Me.txtHgLandPollutantEnrichmentFactor.Text = "2"
        '
        'txtHgLandSoilReductionDepth
        '
        Me.txtHgLandSoilReductionDepth.AcceptsReturn = True
        Me.txtHgLandSoilReductionDepth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandSoilReductionDepth.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandSoilReductionDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandSoilReductionDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandSoilReductionDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandSoilReductionDepth.Location = New System.Drawing.Point(259, 120)
        Me.txtHgLandSoilReductionDepth.MaxLength = 0
        Me.txtHgLandSoilReductionDepth.Name = "txtHgLandSoilReductionDepth"
        Me.txtHgLandSoilReductionDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandSoilReductionDepth.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandSoilReductionDepth.TabIndex = 9
        Me.txtHgLandSoilReductionDepth.Text = "0.5"
        '
        'txtHgLandSoilBaseReductionRate
        '
        Me.txtHgLandSoilBaseReductionRate.AcceptsReturn = True
        Me.txtHgLandSoilBaseReductionRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandSoilBaseReductionRate.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandSoilBaseReductionRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandSoilBaseReductionRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandSoilBaseReductionRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandSoilBaseReductionRate.Location = New System.Drawing.Point(259, 192)
        Me.txtHgLandSoilBaseReductionRate.MaxLength = 0
        Me.txtHgLandSoilBaseReductionRate.Name = "txtHgLandSoilBaseReductionRate"
        Me.txtHgLandSoilBaseReductionRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandSoilBaseReductionRate.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandSoilBaseReductionRate.TabIndex = 15
        Me.txtHgLandSoilBaseReductionRate.Text = "0.0001"
        '
        'txtHgLandChemicalWeatheringRate
        '
        Me.txtHgLandChemicalWeatheringRate.AcceptsReturn = True
        Me.txtHgLandChemicalWeatheringRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandChemicalWeatheringRate.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandChemicalWeatheringRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandChemicalWeatheringRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandChemicalWeatheringRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandChemicalWeatheringRate.Location = New System.Drawing.Point(259, 264)
        Me.txtHgLandChemicalWeatheringRate.MaxLength = 0
        Me.txtHgLandChemicalWeatheringRate.Name = "txtHgLandChemicalWeatheringRate"
        Me.txtHgLandChemicalWeatheringRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandChemicalWeatheringRate.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandChemicalWeatheringRate.TabIndex = 21
        Me.txtHgLandChemicalWeatheringRate.Text = "0.0004"
        '
        'txtHgLandSoilWaterPartitionCoeff
        '
        Me.txtHgLandSoilWaterPartitionCoeff.AcceptsReturn = True
        Me.txtHgLandSoilWaterPartitionCoeff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandSoilWaterPartitionCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandSoilWaterPartitionCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandSoilWaterPartitionCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandSoilWaterPartitionCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandSoilWaterPartitionCoeff.Location = New System.Drawing.Point(259, 168)
        Me.txtHgLandSoilWaterPartitionCoeff.MaxLength = 0
        Me.txtHgLandSoilWaterPartitionCoeff.Name = "txtHgLandSoilWaterPartitionCoeff"
        Me.txtHgLandSoilWaterPartitionCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandSoilWaterPartitionCoeff.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandSoilWaterPartitionCoeff.TabIndex = 13
        Me.txtHgLandSoilWaterPartitionCoeff.Text = "58000"
        '
        'txtHgLandSoilMixingDepth
        '
        Me.txtHgLandSoilMixingDepth.AcceptsReturn = True
        Me.txtHgLandSoilMixingDepth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandSoilMixingDepth.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandSoilMixingDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandSoilMixingDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandSoilMixingDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandSoilMixingDepth.Location = New System.Drawing.Point(259, 96)
        Me.txtHgLandSoilMixingDepth.MaxLength = 0
        Me.txtHgLandSoilMixingDepth.Name = "txtHgLandSoilMixingDepth"
        Me.txtHgLandSoilMixingDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandSoilMixingDepth.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandSoilMixingDepth.TabIndex = 7
        Me.txtHgLandSoilMixingDepth.Text = "1"
        '
        'txtHgLandAirPlantBioConc
        '
        Me.txtHgLandAirPlantBioConc.AcceptsReturn = True
        Me.txtHgLandAirPlantBioConc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandAirPlantBioConc.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandAirPlantBioConc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandAirPlantBioConc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandAirPlantBioConc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandAirPlantBioConc.Location = New System.Drawing.Point(259, 48)
        Me.txtHgLandAirPlantBioConc.MaxLength = 0
        Me.txtHgLandAirPlantBioConc.Name = "txtHgLandAirPlantBioConc"
        Me.txtHgLandAirPlantBioConc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandAirPlantBioConc.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandAirPlantBioConc.TabIndex = 3
        Me.txtHgLandAirPlantBioConc.Text = "18000"
        '
        'txtHgLandAirHgConc
        '
        Me.txtHgLandAirHgConc.AcceptsReturn = True
        Me.txtHgLandAirHgConc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandAirHgConc.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandAirHgConc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandAirHgConc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandAirHgConc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandAirHgConc.Location = New System.Drawing.Point(259, 24)
        Me.txtHgLandAirHgConc.MaxLength = 0
        Me.txtHgLandAirHgConc.Name = "txtHgLandAirHgConc"
        Me.txtHgLandAirHgConc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandAirHgConc.Size = New System.Drawing.Size(67, 20)
        Me.txtHgLandAirHgConc.TabIndex = 1
        Me.txtHgLandAirHgConc.Text = "0.00155"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label85.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label85.Location = New System.Drawing.Point(6, 75)
        Me.Label85.Name = "Label85"
        Me.Label85.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label85.Size = New System.Drawing.Size(242, 14)
        Me.Label85.TabIndex = 4
        Me.Label85.Text = "Initial Groundwater Mercury Concentration (ng/l):"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.BackColor = System.Drawing.Color.Transparent
        Me.Label109.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label109.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label109.Location = New System.Drawing.Point(6, 147)
        Me.Label109.Name = "Label109"
        Me.Label109.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label109.Size = New System.Drawing.Size(142, 14)
        Me.Label109.TabIndex = 10
        Me.Label109.Text = "Soil Particle Density (g/cm³):"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label60.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(6, 291)
        Me.Label60.Name = "Label60"
        Me.Label60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label60.Size = New System.Drawing.Size(195, 14)
        Me.Label60.TabIndex = 22
        Me.Label60.Text = "Bedrock Mercury Concentration (ng/g):"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(6, 267)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(182, 14)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Chemical Weathering Rate (µm/day):"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label61.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(6, 243)
        Me.Label61.Name = "Label61"
        Me.Label61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label61.Size = New System.Drawing.Size(127, 14)
        Me.Label61.TabIndex = 18
        Me.Label61.Text = "Bedrock Density (g/cm³):"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(6, 219)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(140, 14)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Pollutant Enrichment Factor:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(6, 123)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(134, 14)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Soil Reduction Depth (cm):"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(6, 195)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(179, 14)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Soil Base Reduction Rate (per day):"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(6, 171)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(185, 14)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "Soil Water Partition Coefficient (ml/g):"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(6, 99)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(172, 14)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Watershed Soil Mixing Depth (cm):"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(6, 51)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(205, 14)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Air-Plant Bio-Concentration Factor (BCF):"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(6, 27)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(169, 14)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Air Mercury Concentration (ng/g):"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Frame10)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(544, 374)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Forest"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Frame10
        '
        Me.Frame10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Frame10.BackColor = System.Drawing.Color.Transparent
        Me.Frame10.Controls.Add(Me.Label27)
        Me.Frame10.Controls.Add(Me.txtHgLandAnnualEvapo)
        Me.Frame10.Controls.Add(Me.txtHgInitialLeafLitterConstant)
        Me.Frame10.Controls.Add(Me.txtHgLandLeafAdhereFraction)
        Me.Frame10.Controls.Add(Me.txtHgLandLeafInterFraction)
        Me.Frame10.Controls.Add(Me.txtHgLandKDcomp1)
        Me.Frame10.Controls.Add(Me.txtHgLandKDcomp2)
        Me.Frame10.Controls.Add(Me.txtHgLandKDcomp3)
        Me.Frame10.Controls.Add(Me.Label68)
        Me.Frame10.Controls.Add(Me.Label69)
        Me.Frame10.Controls.Add(Me.Label70)
        Me.Frame10.Controls.Add(Me.Label113)
        Me.Frame10.Controls.Add(Me.Label114)
        Me.Frame10.Controls.Add(Me.Label115)
        Me.Frame10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame10.Location = New System.Drawing.Point(97, 52)
        Me.Frame10.Name = "Frame10"
        Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame10.Size = New System.Drawing.Size(350, 295)
        Me.Frame10.TabIndex = 0
        Me.Frame10.TabStop = False
        Me.Frame10.Text = "Define Parameters for Forest Land:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(6, 113)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(195, 14)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Initial Leaf Litter for Forest Land (g/m²):"
        '
        'txtHgLandAnnualEvapo
        '
        Me.txtHgLandAnnualEvapo.AcceptsReturn = True
        Me.txtHgLandAnnualEvapo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandAnnualEvapo.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandAnnualEvapo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandAnnualEvapo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandAnnualEvapo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandAnnualEvapo.Location = New System.Drawing.Point(257, 21)
        Me.txtHgLandAnnualEvapo.MaxLength = 0
        Me.txtHgLandAnnualEvapo.Name = "txtHgLandAnnualEvapo"
        Me.txtHgLandAnnualEvapo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandAnnualEvapo.Size = New System.Drawing.Size(87, 20)
        Me.txtHgLandAnnualEvapo.TabIndex = 1
        Me.txtHgLandAnnualEvapo.Text = "30"
        '
        'txtHgInitialLeafLitterConstant
        '
        Me.txtHgInitialLeafLitterConstant.AcceptsReturn = True
        Me.txtHgInitialLeafLitterConstant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgInitialLeafLitterConstant.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgInitialLeafLitterConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgInitialLeafLitterConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgInitialLeafLitterConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgInitialLeafLitterConstant.Location = New System.Drawing.Point(257, 110)
        Me.txtHgInitialLeafLitterConstant.MaxLength = 0
        Me.txtHgInitialLeafLitterConstant.Name = "txtHgInitialLeafLitterConstant"
        Me.txtHgInitialLeafLitterConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgInitialLeafLitterConstant.Size = New System.Drawing.Size(87, 20)
        Me.txtHgInitialLeafLitterConstant.TabIndex = 7
        Me.txtHgInitialLeafLitterConstant.Text = "40"
        '
        'txtHgLandLeafAdhereFraction
        '
        Me.txtHgLandLeafAdhereFraction.AcceptsReturn = True
        Me.txtHgLandLeafAdhereFraction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandLeafAdhereFraction.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandLeafAdhereFraction.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandLeafAdhereFraction.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandLeafAdhereFraction.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandLeafAdhereFraction.Location = New System.Drawing.Point(257, 80)
        Me.txtHgLandLeafAdhereFraction.MaxLength = 0
        Me.txtHgLandLeafAdhereFraction.Name = "txtHgLandLeafAdhereFraction"
        Me.txtHgLandLeafAdhereFraction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandLeafAdhereFraction.Size = New System.Drawing.Size(87, 20)
        Me.txtHgLandLeafAdhereFraction.TabIndex = 5
        Me.txtHgLandLeafAdhereFraction.Text = "0.6"
        '
        'txtHgLandLeafInterFraction
        '
        Me.txtHgLandLeafInterFraction.AcceptsReturn = True
        Me.txtHgLandLeafInterFraction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandLeafInterFraction.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandLeafInterFraction.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandLeafInterFraction.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandLeafInterFraction.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandLeafInterFraction.Location = New System.Drawing.Point(257, 50)
        Me.txtHgLandLeafInterFraction.MaxLength = 0
        Me.txtHgLandLeafInterFraction.Name = "txtHgLandLeafInterFraction"
        Me.txtHgLandLeafInterFraction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandLeafInterFraction.Size = New System.Drawing.Size(87, 20)
        Me.txtHgLandLeafInterFraction.TabIndex = 3
        Me.txtHgLandLeafInterFraction.Text = "0.47"
        '
        'txtHgLandKDcomp1
        '
        Me.txtHgLandKDcomp1.AcceptsReturn = True
        Me.txtHgLandKDcomp1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandKDcomp1.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandKDcomp1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandKDcomp1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandKDcomp1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandKDcomp1.Location = New System.Drawing.Point(257, 149)
        Me.txtHgLandKDcomp1.MaxLength = 0
        Me.txtHgLandKDcomp1.Name = "txtHgLandKDcomp1"
        Me.txtHgLandKDcomp1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandKDcomp1.Size = New System.Drawing.Size(87, 20)
        Me.txtHgLandKDcomp1.TabIndex = 9
        Me.txtHgLandKDcomp1.Text = "0.0019"
        '
        'txtHgLandKDcomp2
        '
        Me.txtHgLandKDcomp2.AcceptsReturn = True
        Me.txtHgLandKDcomp2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandKDcomp2.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandKDcomp2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandKDcomp2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandKDcomp2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandKDcomp2.Location = New System.Drawing.Point(257, 189)
        Me.txtHgLandKDcomp2.MaxLength = 0
        Me.txtHgLandKDcomp2.Name = "txtHgLandKDcomp2"
        Me.txtHgLandKDcomp2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandKDcomp2.Size = New System.Drawing.Size(87, 20)
        Me.txtHgLandKDcomp2.TabIndex = 11
        Me.txtHgLandKDcomp2.Text = "0.0005"
        '
        'txtHgLandKDcomp3
        '
        Me.txtHgLandKDcomp3.AcceptsReturn = True
        Me.txtHgLandKDcomp3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandKDcomp3.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandKDcomp3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandKDcomp3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandKDcomp3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandKDcomp3.Location = New System.Drawing.Point(257, 229)
        Me.txtHgLandKDcomp3.MaxLength = 0
        Me.txtHgLandKDcomp3.Name = "txtHgLandKDcomp3"
        Me.txtHgLandKDcomp3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandKDcomp3.Size = New System.Drawing.Size(87, 20)
        Me.txtHgLandKDcomp3.TabIndex = 13
        Me.txtHgLandKDcomp3.Text = "0.0012"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label68.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label68.Location = New System.Drawing.Point(6, 24)
        Me.Label68.Name = "Label68"
        Me.Label68.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label68.Size = New System.Drawing.Size(207, 14)
        Me.Label68.TabIndex = 0
        Me.Label68.Text = "Average Annual Evapotranspiration (cm):"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label69.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label69.Location = New System.Drawing.Point(6, 83)
        Me.Label69.Name = "Label69"
        Me.Label69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label69.Size = New System.Drawing.Size(199, 14)
        Me.Label69.TabIndex = 4
        Me.Label69.Text = "Leaf Adhering Fraction (Air Deposition):"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label70.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label70.Location = New System.Drawing.Point(6, 54)
        Me.Label70.Name = "Label70"
        Me.Label70.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label70.Size = New System.Drawing.Size(211, 14)
        Me.Label70.TabIndex = 2
        Me.Label70.Text = "Leaf Interception Fraction (Air Deposition):"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.BackColor = System.Drawing.Color.Transparent
        Me.Label113.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label113.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label113.Location = New System.Drawing.Point(6, 145)
        Me.Label113.Name = "Label113"
        Me.Label113.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label113.Size = New System.Drawing.Size(242, 28)
        Me.Label113.TabIndex = 8
        Me.Label113.Text = "Litter Decomposition Rate for Deciduous Forest/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deciduous Shrubland (per day) (c" & _
            "odes 41 && 51):"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.BackColor = System.Drawing.Color.Transparent
        Me.Label114.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label114.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label114.Location = New System.Drawing.Point(6, 184)
        Me.Label114.Name = "Label114"
        Me.Label114.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label114.Size = New System.Drawing.Size(241, 28)
        Me.Label114.TabIndex = 10
        Me.Label114.Text = "Litter Decomposition Rate for Evergreen Forest/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Evergreen Shrubland (per day) (c" & _
            "odes 42 && 52):"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.BackColor = System.Drawing.Color.Transparent
        Me.Label115.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label115.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label115.Location = New System.Drawing.Point(6, 220)
        Me.Label115.Name = "Label115"
        Me.Label115.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label115.Size = New System.Drawing.Size(214, 42)
        Me.Label115.TabIndex = 12
        Me.Label115.Text = "Litter Decomposition Rate for Mixed Forest/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mixed Shrubland/Woody Wetland (per d" & _
            "ay)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(codes 43, 53, && 91):"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.MercuryWater)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(544, 374)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Water"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'MercuryWater
        '
        Me.MercuryWater.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MercuryWater.BackColor = System.Drawing.Color.Transparent
        Me.MercuryWater.Controls.Add(Me.Label71)
        Me.MercuryWater.Controls.Add(Me.txtHgBenthicPorewaterDiffusionCoeff)
        Me.MercuryWater.Controls.Add(Me.txtLakeHgWaterColumn)
        Me.MercuryWater.Controls.Add(Me.Label72)
        Me.MercuryWater.Controls.Add(Me.txtHgWaterAlphaW)
        Me.MercuryWater.Controls.Add(Me.Label74)
        Me.MercuryWater.Controls.Add(Me.txtHgWaterKWR)
        Me.MercuryWater.Controls.Add(Me.txtHgWaterBetaW)
        Me.MercuryWater.Controls.Add(Me.Label75)
        Me.MercuryWater.Controls.Add(Me.txtHgWaterKWM)
        Me.MercuryWater.Controls.Add(Me.txtHgWaterVSB)
        Me.MercuryWater.Controls.Add(Me.Label76)
        Me.MercuryWater.Controls.Add(Me.txtHgWaterVRS)
        Me.MercuryWater.Controls.Add(Me.Label78)
        Me.MercuryWater.Controls.Add(Me.Label79)
        Me.MercuryWater.Controls.Add(Me.txtHgWaterKDsw)
        Me.MercuryWater.Controls.Add(Me.Label80)
        Me.MercuryWater.Controls.Add(Me.txtHgWaterKbio)
        Me.MercuryWater.Controls.Add(Me.Label81)
        Me.MercuryWater.Controls.Add(Me.txtHgWaterCbio)
        Me.MercuryWater.Controls.Add(Me.Label82)
        Me.MercuryWater.Controls.Add(Me.txtHgWaterHgDecayInChannel)
        Me.MercuryWater.Controls.Add(Me.txtHgMethylHgFraction)
        Me.MercuryWater.Controls.Add(Me.Label83)
        Me.MercuryWater.Controls.Add(Me.Label120)
        Me.MercuryWater.Controls.Add(Me.Label121)
        Me.MercuryWater.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MercuryWater.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MercuryWater.Location = New System.Drawing.Point(73, 19)
        Me.MercuryWater.Name = "MercuryWater"
        Me.MercuryWater.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MercuryWater.Size = New System.Drawing.Size(398, 336)
        Me.MercuryWater.TabIndex = 0
        Me.MercuryWater.TabStop = False
        Me.MercuryWater.Text = "Define Constants for Mercury (Water)"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Location = New System.Drawing.Point(6, 262)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(259, 14)
        Me.Label71.TabIndex = 20
        Me.Label71.Text = "Biomass Concentration in Water Column, Cbio (mg/l):"
        '
        'txtHgBenthicPorewaterDiffusionCoeff
        '
        Me.txtHgBenthicPorewaterDiffusionCoeff.AcceptsReturn = True
        Me.txtHgBenthicPorewaterDiffusionCoeff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgBenthicPorewaterDiffusionCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgBenthicPorewaterDiffusionCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgBenthicPorewaterDiffusionCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgBenthicPorewaterDiffusionCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgBenthicPorewaterDiffusionCoeff.Location = New System.Drawing.Point(305, 187)
        Me.txtHgBenthicPorewaterDiffusionCoeff.MaxLength = 0
        Me.txtHgBenthicPorewaterDiffusionCoeff.Name = "txtHgBenthicPorewaterDiffusionCoeff"
        Me.txtHgBenthicPorewaterDiffusionCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgBenthicPorewaterDiffusionCoeff.Size = New System.Drawing.Size(87, 20)
        Me.txtHgBenthicPorewaterDiffusionCoeff.TabIndex = 15
        Me.txtHgBenthicPorewaterDiffusionCoeff.Text = "0.000000005"
        '
        'txtLakeHgWaterColumn
        '
        Me.txtLakeHgWaterColumn.AcceptsReturn = True
        Me.txtLakeHgWaterColumn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLakeHgWaterColumn.BackColor = System.Drawing.SystemColors.Window
        Me.txtLakeHgWaterColumn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLakeHgWaterColumn.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLakeHgWaterColumn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLakeHgWaterColumn.Location = New System.Drawing.Point(305, 19)
        Me.txtLakeHgWaterColumn.MaxLength = 0
        Me.txtLakeHgWaterColumn.Name = "txtLakeHgWaterColumn"
        Me.txtLakeHgWaterColumn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLakeHgWaterColumn.Size = New System.Drawing.Size(87, 20)
        Me.txtLakeHgWaterColumn.TabIndex = 1
        Me.txtLakeHgWaterColumn.Text = "1"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Location = New System.Drawing.Point(6, 238)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(207, 14)
        Me.Label72.TabIndex = 18
        Me.Label72.Text = "Biomass-Water Partition Coefficient, Kbio:"
        '
        'txtHgWaterAlphaW
        '
        Me.txtHgWaterAlphaW.AcceptsReturn = True
        Me.txtHgWaterAlphaW.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterAlphaW.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterAlphaW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterAlphaW.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterAlphaW.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterAlphaW.Location = New System.Drawing.Point(305, 43)
        Me.txtHgWaterAlphaW.MaxLength = 0
        Me.txtHgWaterAlphaW.Name = "txtHgWaterAlphaW"
        Me.txtHgWaterAlphaW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterAlphaW.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterAlphaW.TabIndex = 3
        Me.txtHgWaterAlphaW.Text = "1"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Location = New System.Drawing.Point(6, 214)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(220, 14)
        Me.Label74.TabIndex = 16
        Me.Label74.Text = "Sediment Water Partition Coefficient, Kd sw:"
        '
        'txtHgWaterKWR
        '
        Me.txtHgWaterKWR.AcceptsReturn = True
        Me.txtHgWaterKWR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterKWR.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterKWR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterKWR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterKWR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterKWR.Location = New System.Drawing.Point(305, 67)
        Me.txtHgWaterKWR.MaxLength = 0
        Me.txtHgWaterKWR.Name = "txtHgWaterKWR"
        Me.txtHgWaterKWR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterKWR.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterKWR.TabIndex = 5
        Me.txtHgWaterKWR.Text = "0.075"
        '
        'txtHgWaterBetaW
        '
        Me.txtHgWaterBetaW.AcceptsReturn = True
        Me.txtHgWaterBetaW.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterBetaW.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterBetaW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterBetaW.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterBetaW.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterBetaW.Location = New System.Drawing.Point(305, 91)
        Me.txtHgWaterBetaW.MaxLength = 0
        Me.txtHgWaterBetaW.Name = "txtHgWaterBetaW"
        Me.txtHgWaterBetaW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterBetaW.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterBetaW.TabIndex = 7
        Me.txtHgWaterBetaW.Text = "0.4"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.Location = New System.Drawing.Point(6, 190)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(222, 14)
        Me.Label75.TabIndex = 14
        Me.Label75.Text = "Porewater Diffusion Coefficient, Esw (m²/s):"
        '
        'txtHgWaterKWM
        '
        Me.txtHgWaterKWM.AcceptsReturn = True
        Me.txtHgWaterKWM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterKWM.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterKWM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterKWM.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterKWM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterKWM.Location = New System.Drawing.Point(305, 115)
        Me.txtHgWaterKWM.MaxLength = 0
        Me.txtHgWaterKWM.Name = "txtHgWaterKWM"
        Me.txtHgWaterKWM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterKWM.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterKWM.TabIndex = 9
        Me.txtHgWaterKWM.Text = "0.001"
        '
        'txtHgWaterVSB
        '
        Me.txtHgWaterVSB.AcceptsReturn = True
        Me.txtHgWaterVSB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterVSB.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterVSB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterVSB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterVSB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterVSB.Location = New System.Drawing.Point(305, 139)
        Me.txtHgWaterVSB.MaxLength = 0
        Me.txtHgWaterVSB.Name = "txtHgWaterVSB"
        Me.txtHgWaterVSB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterVSB.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterVSB.TabIndex = 11
        Me.txtHgWaterVSB.Text = "0.2"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Location = New System.Drawing.Point(6, 118)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(292, 14)
        Me.Label76.TabIndex = 8
        Me.Label76.Text = "Mercury Methylation Rate in Water Column, Kwm (per day):"
        '
        'txtHgWaterVRS
        '
        Me.txtHgWaterVRS.AcceptsReturn = True
        Me.txtHgWaterVRS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterVRS.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterVRS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterVRS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterVRS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterVRS.Location = New System.Drawing.Point(305, 163)
        Me.txtHgWaterVRS.MaxLength = 0
        Me.txtHgWaterVRS.Name = "txtHgWaterVRS"
        Me.txtHgWaterVRS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterVRS.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterVRS.TabIndex = 13
        Me.txtHgWaterVRS.Text = "0.00001"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.Transparent
        Me.Label78.Location = New System.Drawing.Point(6, 46)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(250, 14)
        Me.Label78.TabIndex = 2
        Me.Label78.Text = "Net Reduction Loss Factor in Water Column, α wc:"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.Transparent
        Me.Label79.Location = New System.Drawing.Point(6, 94)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(256, 14)
        Me.Label79.TabIndex = 6
        Me.Label79.Text = "Net Methylation Loss Factor in Water Column, β wc:"
        '
        'txtHgWaterKDsw
        '
        Me.txtHgWaterKDsw.AcceptsReturn = True
        Me.txtHgWaterKDsw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterKDsw.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterKDsw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterKDsw.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterKDsw.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterKDsw.Location = New System.Drawing.Point(305, 211)
        Me.txtHgWaterKDsw.MaxLength = 0
        Me.txtHgWaterKDsw.Name = "txtHgWaterKDsw"
        Me.txtHgWaterKDsw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterKDsw.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterKDsw.TabIndex = 17
        Me.txtHgWaterKDsw.Text = "100000"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label80.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label80.Location = New System.Drawing.Point(6, 142)
        Me.Label80.Name = "Label80"
        Me.Label80.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label80.Size = New System.Drawing.Size(197, 14)
        Me.Label80.TabIndex = 10
        Me.Label80.Text = "Biomass Settling Velocity, Vsb (m/day):"
        '
        'txtHgWaterKbio
        '
        Me.txtHgWaterKbio.AcceptsReturn = True
        Me.txtHgWaterKbio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterKbio.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterKbio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterKbio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterKbio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterKbio.Location = New System.Drawing.Point(305, 235)
        Me.txtHgWaterKbio.MaxLength = 0
        Me.txtHgWaterKbio.Name = "txtHgWaterKbio"
        Me.txtHgWaterKbio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterKbio.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterKbio.TabIndex = 19
        Me.txtHgWaterKbio.Text = "200000"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Location = New System.Drawing.Point(6, 70)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(282, 14)
        Me.Label81.TabIndex = 4
        Me.Label81.Text = "Mercury Reduction Rate in Water Column, Kwr (per day):"
        '
        'txtHgWaterCbio
        '
        Me.txtHgWaterCbio.AcceptsReturn = True
        Me.txtHgWaterCbio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterCbio.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterCbio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterCbio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterCbio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterCbio.Location = New System.Drawing.Point(305, 259)
        Me.txtHgWaterCbio.MaxLength = 0
        Me.txtHgWaterCbio.Name = "txtHgWaterCbio"
        Me.txtHgWaterCbio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterCbio.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterCbio.TabIndex = 21
        Me.txtHgWaterCbio.Text = "0.7"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.Color.Transparent
        Me.Label82.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label82.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label82.Location = New System.Drawing.Point(6, 166)
        Me.Label82.Name = "Label82"
        Me.Label82.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label82.Size = New System.Drawing.Size(236, 14)
        Me.Label82.TabIndex = 12
        Me.Label82.Text = "Sediment Re-suspension Velocity, Vrs (m/day):"
        '
        'txtHgWaterHgDecayInChannel
        '
        Me.txtHgWaterHgDecayInChannel.AcceptsReturn = True
        Me.txtHgWaterHgDecayInChannel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterHgDecayInChannel.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterHgDecayInChannel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterHgDecayInChannel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterHgDecayInChannel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterHgDecayInChannel.Location = New System.Drawing.Point(305, 283)
        Me.txtHgWaterHgDecayInChannel.MaxLength = 0
        Me.txtHgWaterHgDecayInChannel.Name = "txtHgWaterHgDecayInChannel"
        Me.txtHgWaterHgDecayInChannel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterHgDecayInChannel.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterHgDecayInChannel.TabIndex = 23
        Me.txtHgWaterHgDecayInChannel.Text = "0.04"
        '
        'txtHgMethylHgFraction
        '
        Me.txtHgMethylHgFraction.AcceptsReturn = True
        Me.txtHgMethylHgFraction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgMethylHgFraction.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgMethylHgFraction.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgMethylHgFraction.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgMethylHgFraction.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgMethylHgFraction.Location = New System.Drawing.Point(305, 307)
        Me.txtHgMethylHgFraction.MaxLength = 0
        Me.txtHgMethylHgFraction.Name = "txtHgMethylHgFraction"
        Me.txtHgMethylHgFraction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgMethylHgFraction.Size = New System.Drawing.Size(87, 20)
        Me.txtHgMethylHgFraction.TabIndex = 25
        Me.txtHgMethylHgFraction.Text = "0.06"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label83.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label83.Location = New System.Drawing.Point(6, 22)
        Me.Label83.Name = "Label83"
        Me.Label83.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label83.Size = New System.Drawing.Size(228, 14)
        Me.Label83.TabIndex = 0
        Me.Label83.Text = "Initial Hg Concentration in Water Column (ng/l):"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.BackColor = System.Drawing.Color.Transparent
        Me.Label120.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label120.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label120.Location = New System.Drawing.Point(6, 286)
        Me.Label120.Name = "Label120"
        Me.Label120.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label120.Size = New System.Drawing.Size(260, 14)
        Me.Label120.TabIndex = 22
        Me.Label120.Text = "Mercury Decay Rate in Channel Transport (per day):"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.BackColor = System.Drawing.Color.Transparent
        Me.Label121.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label121.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label121.Location = New System.Drawing.Point(6, 310)
        Me.Label121.Name = "Label121"
        Me.Label121.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label121.Size = New System.Drawing.Size(219, 14)
        Me.Label121.TabIndex = 24
        Me.Label121.Text = "Fraction of Methyl Mercury in Total Mercury:"
        '
        '_SSTab1_TabPage4
        '
        Me._SSTab1_TabPage4.Controls.Add(Me.Frame11)
        Me._SSTab1_TabPage4.Location = New System.Drawing.Point(4, 23)
        Me._SSTab1_TabPage4.Name = "_SSTab1_TabPage4"
        Me._SSTab1_TabPage4.Size = New System.Drawing.Size(544, 374)
        Me._SSTab1_TabPage4.TabIndex = 4
        Me._SSTab1_TabPage4.Text = "Benthic"
        Me._SSTab1_TabPage4.UseVisualStyleBackColor = True
        '
        'Frame11
        '
        Me.Frame11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Frame11.BackColor = System.Drawing.Color.Transparent
        Me.Frame11.Controls.Add(Me.Label84)
        Me.Frame11.Controls.Add(Me.Label86)
        Me.Frame11.Controls.Add(Me.Label87)
        Me.Frame11.Controls.Add(Me.Label88)
        Me.Frame11.Controls.Add(Me.Label89)
        Me.Frame11.Controls.Add(Me.Label90)
        Me.Frame11.Controls.Add(Me.Label91)
        Me.Frame11.Controls.Add(Me.txtHgWaterTheta_bs)
        Me.Frame11.Controls.Add(Me.txtHgBenthicCbs)
        Me.Frame11.Controls.Add(Me.txtHgBenthicKDbs)
        Me.Frame11.Controls.Add(Me.txtHgBenthicSedimentDepth)
        Me.Frame11.Controls.Add(Me.txtHgBenthicVbur)
        Me.Frame11.Controls.Add(Me.txtHgBenthicKBM)
        Me.Frame11.Controls.Add(Me.txtHgBenthicBetaB)
        Me.Frame11.Controls.Add(Me.txtHgBenthicKBR)
        Me.Frame11.Controls.Add(Me.txtHgBenthicAlphaB)
        Me.Frame11.Controls.Add(Me.txtLakeHgBenthic)
        Me.Frame11.Controls.Add(Me.Label127)
        Me.Frame11.Controls.Add(Me.Label126)
        Me.Frame11.Controls.Add(Me.Label92)
        Me.Frame11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame11.Location = New System.Drawing.Point(57, 52)
        Me.Frame11.Name = "Frame11"
        Me.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame11.Size = New System.Drawing.Size(430, 271)
        Me.Frame11.TabIndex = 0
        Me.Frame11.TabStop = False
        Me.Frame11.Text = "Define Constants for Mercury (Benthic)"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.Label84.Location = New System.Drawing.Point(6, 243)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(272, 14)
        Me.Label84.TabIndex = 18
        Me.Label84.Text = "Solids Concentration in Benthic Sediments, C bs (g/m³):"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.BackColor = System.Drawing.Color.Transparent
        Me.Label86.Location = New System.Drawing.Point(6, 219)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(316, 14)
        Me.Label86.TabIndex = 16
        Me.Label86.Text = "Bed Sediment / Sediment Pore Water Partition Coefficient, Kd bs:"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.BackColor = System.Drawing.Color.Transparent
        Me.Label87.Location = New System.Drawing.Point(6, 195)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(184, 14)
        Me.Label87.TabIndex = 14
        Me.Label87.Text = "Benthic Sediment Bed Porosity, θ bs:"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.BackColor = System.Drawing.Color.Transparent
        Me.Label88.Location = New System.Drawing.Point(6, 124)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(293, 14)
        Me.Label88.TabIndex = 8
        Me.Label88.Text = "Benthic Sediment Mercury Methylation Rate, Kbm (per day):"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.BackColor = System.Drawing.Color.Transparent
        Me.Label89.Location = New System.Drawing.Point(6, 100)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(268, 14)
        Me.Label89.TabIndex = 6
        Me.Label89.Text = "Net Methylation Loss Factor in Benthic Sediment, β bs:"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.BackColor = System.Drawing.Color.Transparent
        Me.Label90.Location = New System.Drawing.Point(6, 76)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(283, 14)
        Me.Label90.TabIndex = 4
        Me.Label90.Text = "Benthic Sediment Mercury Reduction Rate, Kbr (per day):"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Location = New System.Drawing.Point(6, 52)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(268, 14)
        Me.Label91.TabIndex = 2
        Me.Label91.Text = "Net Reduction Loss Factor in Benthic Sediments, α bs:"
        '
        'txtHgWaterTheta_bs
        '
        Me.txtHgWaterTheta_bs.AcceptsReturn = True
        Me.txtHgWaterTheta_bs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgWaterTheta_bs.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgWaterTheta_bs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgWaterTheta_bs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgWaterTheta_bs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgWaterTheta_bs.Location = New System.Drawing.Point(337, 192)
        Me.txtHgWaterTheta_bs.MaxLength = 0
        Me.txtHgWaterTheta_bs.Name = "txtHgWaterTheta_bs"
        Me.txtHgWaterTheta_bs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgWaterTheta_bs.Size = New System.Drawing.Size(87, 20)
        Me.txtHgWaterTheta_bs.TabIndex = 15
        Me.txtHgWaterTheta_bs.Text = "0.9"
        '
        'txtHgBenthicCbs
        '
        Me.txtHgBenthicCbs.AcceptsReturn = True
        Me.txtHgBenthicCbs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgBenthicCbs.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgBenthicCbs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgBenthicCbs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgBenthicCbs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgBenthicCbs.Location = New System.Drawing.Point(337, 240)
        Me.txtHgBenthicCbs.MaxLength = 0
        Me.txtHgBenthicCbs.Name = "txtHgBenthicCbs"
        Me.txtHgBenthicCbs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgBenthicCbs.Size = New System.Drawing.Size(87, 20)
        Me.txtHgBenthicCbs.TabIndex = 19
        Me.txtHgBenthicCbs.Text = "75000"
        '
        'txtHgBenthicKDbs
        '
        Me.txtHgBenthicKDbs.AcceptsReturn = True
        Me.txtHgBenthicKDbs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgBenthicKDbs.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgBenthicKDbs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgBenthicKDbs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgBenthicKDbs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgBenthicKDbs.Location = New System.Drawing.Point(337, 216)
        Me.txtHgBenthicKDbs.MaxLength = 0
        Me.txtHgBenthicKDbs.Name = "txtHgBenthicKDbs"
        Me.txtHgBenthicKDbs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgBenthicKDbs.Size = New System.Drawing.Size(87, 20)
        Me.txtHgBenthicKDbs.TabIndex = 17
        Me.txtHgBenthicKDbs.Text = "50000"
        '
        'txtHgBenthicSedimentDepth
        '
        Me.txtHgBenthicSedimentDepth.AcceptsReturn = True
        Me.txtHgBenthicSedimentDepth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgBenthicSedimentDepth.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgBenthicSedimentDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgBenthicSedimentDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgBenthicSedimentDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgBenthicSedimentDepth.Location = New System.Drawing.Point(337, 168)
        Me.txtHgBenthicSedimentDepth.MaxLength = 0
        Me.txtHgBenthicSedimentDepth.Name = "txtHgBenthicSedimentDepth"
        Me.txtHgBenthicSedimentDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgBenthicSedimentDepth.Size = New System.Drawing.Size(87, 20)
        Me.txtHgBenthicSedimentDepth.TabIndex = 13
        Me.txtHgBenthicSedimentDepth.Text = "0.02"
        '
        'txtHgBenthicVbur
        '
        Me.txtHgBenthicVbur.AcceptsReturn = True
        Me.txtHgBenthicVbur.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgBenthicVbur.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgBenthicVbur.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgBenthicVbur.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgBenthicVbur.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgBenthicVbur.Location = New System.Drawing.Point(337, 144)
        Me.txtHgBenthicVbur.MaxLength = 0
        Me.txtHgBenthicVbur.Name = "txtHgBenthicVbur"
        Me.txtHgBenthicVbur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgBenthicVbur.Size = New System.Drawing.Size(87, 20)
        Me.txtHgBenthicVbur.TabIndex = 11
        Me.txtHgBenthicVbur.Text = "0.00000035"
        '
        'txtHgBenthicKBM
        '
        Me.txtHgBenthicKBM.AcceptsReturn = True
        Me.txtHgBenthicKBM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgBenthicKBM.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgBenthicKBM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgBenthicKBM.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgBenthicKBM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgBenthicKBM.Location = New System.Drawing.Point(337, 121)
        Me.txtHgBenthicKBM.MaxLength = 0
        Me.txtHgBenthicKBM.Name = "txtHgBenthicKBM"
        Me.txtHgBenthicKBM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgBenthicKBM.Size = New System.Drawing.Size(87, 20)
        Me.txtHgBenthicKBM.TabIndex = 9
        Me.txtHgBenthicKBM.Text = "0.0001"
        '
        'txtHgBenthicBetaB
        '
        Me.txtHgBenthicBetaB.AcceptsReturn = True
        Me.txtHgBenthicBetaB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgBenthicBetaB.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgBenthicBetaB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgBenthicBetaB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgBenthicBetaB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgBenthicBetaB.Location = New System.Drawing.Point(337, 97)
        Me.txtHgBenthicBetaB.MaxLength = 0
        Me.txtHgBenthicBetaB.Name = "txtHgBenthicBetaB"
        Me.txtHgBenthicBetaB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgBenthicBetaB.Size = New System.Drawing.Size(87, 20)
        Me.txtHgBenthicBetaB.TabIndex = 7
        Me.txtHgBenthicBetaB.Text = "0.4"
        '
        'txtHgBenthicKBR
        '
        Me.txtHgBenthicKBR.AcceptsReturn = True
        Me.txtHgBenthicKBR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgBenthicKBR.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgBenthicKBR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgBenthicKBR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgBenthicKBR.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgBenthicKBR.Location = New System.Drawing.Point(337, 73)
        Me.txtHgBenthicKBR.MaxLength = 0
        Me.txtHgBenthicKBR.Name = "txtHgBenthicKBR"
        Me.txtHgBenthicKBR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgBenthicKBR.Size = New System.Drawing.Size(87, 20)
        Me.txtHgBenthicKBR.TabIndex = 5
        Me.txtHgBenthicKBR.Text = "0.000001"
        '
        'txtHgBenthicAlphaB
        '
        Me.txtHgBenthicAlphaB.AcceptsReturn = True
        Me.txtHgBenthicAlphaB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgBenthicAlphaB.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgBenthicAlphaB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgBenthicAlphaB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgBenthicAlphaB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgBenthicAlphaB.Location = New System.Drawing.Point(337, 49)
        Me.txtHgBenthicAlphaB.MaxLength = 0
        Me.txtHgBenthicAlphaB.Name = "txtHgBenthicAlphaB"
        Me.txtHgBenthicAlphaB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgBenthicAlphaB.Size = New System.Drawing.Size(87, 20)
        Me.txtHgBenthicAlphaB.TabIndex = 3
        Me.txtHgBenthicAlphaB.Text = "1"
        '
        'txtLakeHgBenthic
        '
        Me.txtLakeHgBenthic.AcceptsReturn = True
        Me.txtLakeHgBenthic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLakeHgBenthic.BackColor = System.Drawing.SystemColors.Window
        Me.txtLakeHgBenthic.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLakeHgBenthic.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLakeHgBenthic.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLakeHgBenthic.Location = New System.Drawing.Point(337, 24)
        Me.txtLakeHgBenthic.MaxLength = 0
        Me.txtLakeHgBenthic.Name = "txtLakeHgBenthic"
        Me.txtLakeHgBenthic.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLakeHgBenthic.Size = New System.Drawing.Size(87, 20)
        Me.txtLakeHgBenthic.TabIndex = 1
        Me.txtLakeHgBenthic.Text = "30"
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.BackColor = System.Drawing.Color.Transparent
        Me.Label127.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label127.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label127.Location = New System.Drawing.Point(6, 171)
        Me.Label127.Name = "Label127"
        Me.Label127.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label127.Size = New System.Drawing.Size(178, 14)
        Me.Label127.TabIndex = 12
        Me.Label127.Text = "Depth of Benthic Sediment Bed (m):"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.BackColor = System.Drawing.Color.Transparent
        Me.Label126.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label126.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label126.Location = New System.Drawing.Point(6, 147)
        Me.Label126.Name = "Label126"
        Me.Label126.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label126.Size = New System.Drawing.Size(149, 14)
        Me.Label126.TabIndex = 10
        Me.Label126.Text = "Burial Velocity, Vbur (m/day):"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.BackColor = System.Drawing.Color.Transparent
        Me.Label92.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label92.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label92.Location = New System.Drawing.Point(6, 27)
        Me.Label92.Name = "Label92"
        Me.Label92.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label92.Size = New System.Drawing.Size(248, 14)
        Me.Label92.TabIndex = 0
        Me.Label92.Text = "Initial Hg Concentration in Benthic Sediment (ng/g):"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Info
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(552, 55)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabHydrology
        '
        Me.tabHydrology.Controls.Add(Me.SSTab1)
        Me.tabHydrology.Controls.Add(Me.Label2)
        Me.tabHydrology.Location = New System.Drawing.Point(4, 25)
        Me.tabHydrology.Name = "tabHydrology"
        Me.tabHydrology.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHydrology.Size = New System.Drawing.Size(558, 462)
        Me.tabHydrology.TabIndex = 1
        Me.tabHydrology.Text = "Hydrology"
        Me.tabHydrology.UseVisualStyleBackColor = True
        '
        'SSTab1
        '
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage2)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage3)
        Me.SSTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SSTab1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 19)
        Me.SSTab1.Location = New System.Drawing.Point(3, 54)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Size = New System.Drawing.Size(552, 405)
        Me.SSTab1.TabIndex = 1
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.BackColor = System.Drawing.Color.Transparent
        Me._SSTab1_TabPage0.Controls.Add(Me.framehydro)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 23)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(544, 378)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Overland"
        Me._SSTab1_TabPage0.UseVisualStyleBackColor = True
        '
        'framehydro
        '
        Me.framehydro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.framehydro.BackColor = System.Drawing.Color.Transparent
        Me.framehydro.Controls.Add(Me.PictureBox1)
        Me.framehydro.Controls.Add(Me.Panel2)
        Me.framehydro.Controls.Add(Me.txtInitialSoilMoistureConstant)
        Me.framehydro.Controls.Add(Me.cboInitialSoilMoisture)
        Me.framehydro.Controls.Add(Me.txtbCNNonGrow)
        Me.framehydro.Controls.Add(Me.txtaCNNonGrow)
        Me.framehydro.Controls.Add(Me.txtaCNGrow)
        Me.framehydro.Controls.Add(Me.txtbCNGrow)
        Me.framehydro.Controls.Add(Me.txtInitialAccuSnowConstant)
        Me.framehydro.Controls.Add(Me.txtHydroP2Rainfall)
        Me.framehydro.Controls.Add(Me.btnP2Map)
        Me.framehydro.Controls.Add(Me.Label8)
        Me.framehydro.Controls.Add(Me.Label9)
        Me.framehydro.Controls.Add(Me.Label15)
        Me.framehydro.Controls.Add(Me.Label63)
        Me.framehydro.Controls.Add(Me.Label16)
        Me.framehydro.Controls.Add(Me.Label62)
        Me.framehydro.Controls.Add(Me.Label17)
        Me.framehydro.Controls.Add(Me.Label28)
        Me.framehydro.Controls.Add(Me.Label65)
        Me.framehydro.Controls.Add(Me.Label101)
        Me.framehydro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.framehydro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.framehydro.Location = New System.Drawing.Point(22, 20)
        Me.framehydro.Name = "framehydro"
        Me.framehydro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.framehydro.Size = New System.Drawing.Size(505, 332)
        Me.framehydro.TabIndex = 0
        Me.framehydro.TabStop = False
        Me.framehydro.Text = "Define Constants for Hydrology"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.atcGBMM.My.Resources.Resources.CNGraph
        Me.PictureBox1.Location = New System.Drawing.Point(298, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.optConstSoilMoisture)
        Me.Panel2.Controls.Add(Me.optInputSoilMoisture)
        Me.Panel2.Controls.Add(Me.optFieldCapacity)
        Me.Panel2.Location = New System.Drawing.Point(45, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(173, 76)
        Me.Panel2.TabIndex = 1
        '
        'optConstSoilMoisture
        '
        Me.optConstSoilMoisture.AutoSize = True
        Me.optConstSoilMoisture.BackColor = System.Drawing.Color.Transparent
        Me.optConstSoilMoisture.Checked = True
        Me.optConstSoilMoisture.Cursor = System.Windows.Forms.Cursors.Default
        Me.optConstSoilMoisture.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optConstSoilMoisture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optConstSoilMoisture.Location = New System.Drawing.Point(3, 3)
        Me.optConstSoilMoisture.Name = "optConstSoilMoisture"
        Me.optConstSoilMoisture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optConstSoilMoisture.Size = New System.Drawing.Size(138, 18)
        Me.optConstSoilMoisture.TabIndex = 0
        Me.optConstSoilMoisture.TabStop = True
        Me.optConstSoilMoisture.Text = "Constant Value (cm/m):"
        Me.optConstSoilMoisture.UseVisualStyleBackColor = False
        '
        'optInputSoilMoisture
        '
        Me.optInputSoilMoisture.AutoSize = True
        Me.optInputSoilMoisture.BackColor = System.Drawing.Color.Transparent
        Me.optInputSoilMoisture.Cursor = System.Windows.Forms.Cursors.Default
        Me.optInputSoilMoisture.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optInputSoilMoisture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optInputSoilMoisture.Location = New System.Drawing.Point(3, 27)
        Me.optInputSoilMoisture.Name = "optInputSoilMoisture"
        Me.optInputSoilMoisture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optInputSoilMoisture.Size = New System.Drawing.Size(107, 18)
        Me.optInputSoilMoisture.TabIndex = 1
        Me.optInputSoilMoisture.Text = "Input Grid (cm/m)"
        Me.optInputSoilMoisture.UseVisualStyleBackColor = False
        '
        'optFieldCapacity
        '
        Me.optFieldCapacity.AutoSize = True
        Me.optFieldCapacity.BackColor = System.Drawing.Color.Transparent
        Me.optFieldCapacity.Cursor = System.Windows.Forms.Cursors.Default
        Me.optFieldCapacity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFieldCapacity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optFieldCapacity.Location = New System.Drawing.Point(3, 51)
        Me.optFieldCapacity.Name = "optFieldCapacity"
        Me.optFieldCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optFieldCapacity.Size = New System.Drawing.Size(128, 18)
        Me.optFieldCapacity.TabIndex = 2
        Me.optFieldCapacity.Text = "Field Capacity (cm/m)"
        Me.optFieldCapacity.UseVisualStyleBackColor = False
        '
        'txtInitialSoilMoistureConstant
        '
        Me.txtInitialSoilMoistureConstant.AcceptsReturn = True
        Me.txtInitialSoilMoistureConstant.BackColor = System.Drawing.SystemColors.Window
        Me.txtInitialSoilMoistureConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInitialSoilMoistureConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitialSoilMoistureConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInitialSoilMoistureConstant.Location = New System.Drawing.Point(248, 35)
        Me.txtInitialSoilMoistureConstant.MaxLength = 0
        Me.txtInitialSoilMoistureConstant.Name = "txtInitialSoilMoistureConstant"
        Me.txtInitialSoilMoistureConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInitialSoilMoistureConstant.Size = New System.Drawing.Size(44, 20)
        Me.txtInitialSoilMoistureConstant.TabIndex = 2
        Me.txtInitialSoilMoistureConstant.Text = "30.0"
        '
        'cboInitialSoilMoisture
        '
        Me.cboInitialSoilMoisture.BackColor = System.Drawing.SystemColors.Window
        Me.cboInitialSoilMoisture.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboInitialSoilMoisture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInitialSoilMoisture.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInitialSoilMoisture.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboInitialSoilMoisture.Location = New System.Drawing.Point(248, 59)
        Me.cboInitialSoilMoisture.Name = "cboInitialSoilMoisture"
        Me.cboInitialSoilMoisture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboInitialSoilMoisture.Size = New System.Drawing.Size(246, 22)
        Me.cboInitialSoilMoisture.TabIndex = 3
        Me.cboInitialSoilMoisture.Tag = "Raster"
        '
        'txtbCNNonGrow
        '
        Me.txtbCNNonGrow.AcceptsReturn = True
        Me.txtbCNNonGrow.BackColor = System.Drawing.SystemColors.Window
        Me.txtbCNNonGrow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbCNNonGrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbCNNonGrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbCNNonGrow.Location = New System.Drawing.Point(248, 262)
        Me.txtbCNNonGrow.MaxLength = 0
        Me.txtbCNNonGrow.Name = "txtbCNNonGrow"
        Me.txtbCNNonGrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbCNNonGrow.Size = New System.Drawing.Size(44, 20)
        Me.txtbCNNonGrow.TabIndex = 16
        Me.txtbCNNonGrow.Text = "2.8"
        '
        'txtaCNNonGrow
        '
        Me.txtaCNNonGrow.AcceptsReturn = True
        Me.txtaCNNonGrow.BackColor = System.Drawing.SystemColors.Window
        Me.txtaCNNonGrow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaCNNonGrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaCNNonGrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtaCNNonGrow.Location = New System.Drawing.Point(248, 236)
        Me.txtaCNNonGrow.MaxLength = 0
        Me.txtaCNNonGrow.Name = "txtaCNNonGrow"
        Me.txtaCNNonGrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtaCNNonGrow.Size = New System.Drawing.Size(44, 20)
        Me.txtaCNNonGrow.TabIndex = 14
        Me.txtaCNNonGrow.Text = "1.3"
        '
        'txtaCNGrow
        '
        Me.txtaCNGrow.AcceptsReturn = True
        Me.txtaCNGrow.BackColor = System.Drawing.SystemColors.Window
        Me.txtaCNGrow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaCNGrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaCNGrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtaCNGrow.Location = New System.Drawing.Point(248, 172)
        Me.txtaCNGrow.MaxLength = 0
        Me.txtaCNGrow.Name = "txtaCNGrow"
        Me.txtaCNGrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtaCNGrow.Size = New System.Drawing.Size(44, 20)
        Me.txtaCNGrow.TabIndex = 9
        Me.txtaCNGrow.Text = "3.6"
        '
        'txtbCNGrow
        '
        Me.txtbCNGrow.AcceptsReturn = True
        Me.txtbCNGrow.BackColor = System.Drawing.SystemColors.Window
        Me.txtbCNGrow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbCNGrow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbCNGrow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtbCNGrow.Location = New System.Drawing.Point(248, 198)
        Me.txtbCNGrow.MaxLength = 0
        Me.txtbCNGrow.Name = "txtbCNGrow"
        Me.txtbCNGrow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbCNGrow.Size = New System.Drawing.Size(44, 20)
        Me.txtbCNGrow.TabIndex = 11
        Me.txtbCNGrow.Text = "5.3"
        '
        'txtInitialAccuSnowConstant
        '
        Me.txtInitialAccuSnowConstant.AcceptsReturn = True
        Me.txtInitialAccuSnowConstant.BackColor = System.Drawing.SystemColors.Window
        Me.txtInitialAccuSnowConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInitialAccuSnowConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitialAccuSnowConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInitialAccuSnowConstant.Location = New System.Drawing.Point(248, 111)
        Me.txtInitialAccuSnowConstant.MaxLength = 0
        Me.txtInitialAccuSnowConstant.Name = "txtInitialAccuSnowConstant"
        Me.txtInitialAccuSnowConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInitialAccuSnowConstant.Size = New System.Drawing.Size(39, 20)
        Me.txtInitialAccuSnowConstant.TabIndex = 5
        Me.txtInitialAccuSnowConstant.Text = "0"
        '
        'txtHydroP2Rainfall
        '
        Me.txtHydroP2Rainfall.AcceptsReturn = True
        Me.txtHydroP2Rainfall.BackColor = System.Drawing.SystemColors.Window
        Me.txtHydroP2Rainfall.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHydroP2Rainfall.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHydroP2Rainfall.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHydroP2Rainfall.Location = New System.Drawing.Point(248, 296)
        Me.txtHydroP2Rainfall.MaxLength = 0
        Me.txtHydroP2Rainfall.Name = "txtHydroP2Rainfall"
        Me.txtHydroP2Rainfall.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHydroP2Rainfall.Size = New System.Drawing.Size(44, 20)
        Me.txtHydroP2Rainfall.TabIndex = 18
        Me.txtHydroP2Rainfall.Text = "10"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(180, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(41, 14)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "a (cm):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(180, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(41, 14)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "a (cm):"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(180, 201)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(41, 14)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "b (cm):"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label63.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label63.Location = New System.Drawing.Point(180, 265)
        Me.Label63.Name = "Label63"
        Me.Label63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label63.Size = New System.Drawing.Size(41, 14)
        Me.Label63.TabIndex = 15
        Me.Label63.Text = "b (cm):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(42, 175)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(114, 14)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "For Growing Season: "
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label62.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label62.Location = New System.Drawing.Point(42, 239)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label62.Size = New System.Drawing.Size(134, 14)
        Me.Label62.TabIndex = 12
        Me.Label62.Text = "For Non-Growing Season:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(24, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(195, 14)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Define Break Points for CN Modification"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(24, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(134, 14)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Initial Soil Moisture Content"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label65.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(24, 114)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label65.Size = New System.Drawing.Size(201, 14)
        Me.Label65.TabIndex = 4
        Me.Label65.Text = "Initial Accumulated Snow (cm of water):"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label101.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label101.Location = New System.Drawing.Point(24, 299)
        Me.Label101.Name = "Label101"
        Me.Label101.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label101.Size = New System.Drawing.Size(166, 14)
        Me.Label101.TabIndex = 17
        Me.Label101.Text = "P2, 2 Year-24 Hour Rainfall (cm):"
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.Panel1)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 23)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(544, 378)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Groundwater"
        Me._SSTab1_TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Image1)
        Me.Panel1.Controls.Add(Me.Frame1)
        Me.Panel1.Controls.Add(Me.fraGroundWater)
        Me.Panel1.Location = New System.Drawing.Point(6, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 262)
        Me.Panel1.TabIndex = 0
        '
        'Image1
        '
        Me.Image1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(243, 3)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(287, 252)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 0
        Me.Image1.TabStop = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me.txtHgLandUnsaturatedSoilDepth)
        Me.Frame1.Controls.Add(Me.txtHgLandBedrockDepth)
        Me.Frame1.Controls.Add(Me.Label111)
        Me.Frame1.Controls.Add(Me.Label64)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(3, 134)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(238, 121)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Soil Properties"
        '
        'txtHgLandUnsaturatedSoilDepth
        '
        Me.txtHgLandUnsaturatedSoilDepth.AcceptsReturn = True
        Me.txtHgLandUnsaturatedSoilDepth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandUnsaturatedSoilDepth.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandUnsaturatedSoilDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandUnsaturatedSoilDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandUnsaturatedSoilDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandUnsaturatedSoilDepth.Location = New System.Drawing.Point(198, 32)
        Me.txtHgLandUnsaturatedSoilDepth.MaxLength = 0
        Me.txtHgLandUnsaturatedSoilDepth.Name = "txtHgLandUnsaturatedSoilDepth"
        Me.txtHgLandUnsaturatedSoilDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandUnsaturatedSoilDepth.Size = New System.Drawing.Size(34, 20)
        Me.txtHgLandUnsaturatedSoilDepth.TabIndex = 1
        Me.txtHgLandUnsaturatedSoilDepth.Text = "1"
        '
        'txtHgLandBedrockDepth
        '
        Me.txtHgLandBedrockDepth.AcceptsReturn = True
        Me.txtHgLandBedrockDepth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHgLandBedrockDepth.BackColor = System.Drawing.SystemColors.Window
        Me.txtHgLandBedrockDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHgLandBedrockDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHgLandBedrockDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHgLandBedrockDepth.Location = New System.Drawing.Point(198, 64)
        Me.txtHgLandBedrockDepth.MaxLength = 0
        Me.txtHgLandBedrockDepth.Name = "txtHgLandBedrockDepth"
        Me.txtHgLandBedrockDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHgLandBedrockDepth.Size = New System.Drawing.Size(34, 20)
        Me.txtHgLandBedrockDepth.TabIndex = 3
        Me.txtHgLandBedrockDepth.Text = "1.5"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.BackColor = System.Drawing.Color.Transparent
        Me.Label111.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label111.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label111.Location = New System.Drawing.Point(10, 35)
        Me.Label111.Name = "Label111"
        Me.Label111.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label111.Size = New System.Drawing.Size(139, 14)
        Me.Label111.TabIndex = 0
        Me.Label111.Text = "Unsaturated Soil Depth (m):"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label64.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label64.Location = New System.Drawing.Point(10, 67)
        Me.Label64.Name = "Label64"
        Me.Label64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label64.Size = New System.Drawing.Size(112, 14)
        Me.Label64.TabIndex = 2
        Me.Label64.Text = "Depth to Bedrock (m):"
        '
        'fraGroundWater
        '
        Me.fraGroundWater.BackColor = System.Drawing.Color.Transparent
        Me.fraGroundWater.Controls.Add(Me.txtInitialShallowGWConstant)
        Me.fraGroundWater.Controls.Add(Me.txtHydroGWSeepageCoeff)
        Me.fraGroundWater.Controls.Add(Me.txtHydroGWRecessionCoeff)
        Me.fraGroundWater.Controls.Add(Me.Label29)
        Me.fraGroundWater.Controls.Add(Me.Label30)
        Me.fraGroundWater.Controls.Add(Me.Label107)
        Me.fraGroundWater.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraGroundWater.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraGroundWater.Location = New System.Drawing.Point(3, 3)
        Me.fraGroundWater.Name = "fraGroundWater"
        Me.fraGroundWater.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraGroundWater.Size = New System.Drawing.Size(238, 105)
        Me.fraGroundWater.TabIndex = 0
        Me.fraGroundWater.TabStop = False
        Me.fraGroundWater.Text = "Groundwater Parameters"
        '
        'txtInitialShallowGWConstant
        '
        Me.txtInitialShallowGWConstant.AcceptsReturn = True
        Me.txtInitialShallowGWConstant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInitialShallowGWConstant.BackColor = System.Drawing.SystemColors.Window
        Me.txtInitialShallowGWConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInitialShallowGWConstant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitialShallowGWConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInitialShallowGWConstant.Location = New System.Drawing.Point(198, 24)
        Me.txtInitialShallowGWConstant.MaxLength = 0
        Me.txtInitialShallowGWConstant.Name = "txtInitialShallowGWConstant"
        Me.txtInitialShallowGWConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInitialShallowGWConstant.Size = New System.Drawing.Size(34, 20)
        Me.txtInitialShallowGWConstant.TabIndex = 1
        Me.txtInitialShallowGWConstant.Text = "30"
        '
        'txtHydroGWSeepageCoeff
        '
        Me.txtHydroGWSeepageCoeff.AcceptsReturn = True
        Me.txtHydroGWSeepageCoeff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHydroGWSeepageCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.txtHydroGWSeepageCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHydroGWSeepageCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHydroGWSeepageCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHydroGWSeepageCoeff.Location = New System.Drawing.Point(198, 72)
        Me.txtHydroGWSeepageCoeff.MaxLength = 0
        Me.txtHydroGWSeepageCoeff.Name = "txtHydroGWSeepageCoeff"
        Me.txtHydroGWSeepageCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHydroGWSeepageCoeff.Size = New System.Drawing.Size(34, 20)
        Me.txtHydroGWSeepageCoeff.TabIndex = 5
        Me.txtHydroGWSeepageCoeff.Text = "0"
        '
        'txtHydroGWRecessionCoeff
        '
        Me.txtHydroGWRecessionCoeff.AcceptsReturn = True
        Me.txtHydroGWRecessionCoeff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHydroGWRecessionCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.txtHydroGWRecessionCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHydroGWRecessionCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHydroGWRecessionCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHydroGWRecessionCoeff.Location = New System.Drawing.Point(198, 47)
        Me.txtHydroGWRecessionCoeff.MaxLength = 0
        Me.txtHydroGWRecessionCoeff.Name = "txtHydroGWRecessionCoeff"
        Me.txtHydroGWRecessionCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHydroGWRecessionCoeff.Size = New System.Drawing.Size(34, 20)
        Me.txtHydroGWRecessionCoeff.TabIndex = 3
        Me.txtHydroGWRecessionCoeff.Text = "0.1"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(10, 75)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(157, 14)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Seepage Coefficient, Sr (/day):"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(10, 50)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(166, 14)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Recession Coefficient, Gr (/day):"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.BackColor = System.Drawing.Color.Transparent
        Me.Label107.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label107.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label107.Location = New System.Drawing.Point(10, 27)
        Me.Label107.Name = "Label107"
        Me.Label107.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label107.Size = New System.Drawing.Size(185, 14)
        Me.Label107.TabIndex = 0
        Me.Label107.Text = " Initial Shallow Ground Water (cm/m):"
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.Controls.Add(Me.FrameStreamParam)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 23)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(544, 378)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Streams"
        Me._SSTab1_TabPage2.UseVisualStyleBackColor = True
        '
        'FrameStreamParam
        '
        Me.FrameStreamParam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FrameStreamParam.BackColor = System.Drawing.Color.Transparent
        Me.FrameStreamParam.Controls.Add(Me.Label31)
        Me.FrameStreamParam.Controls.Add(Me.Label32)
        Me.FrameStreamParam.Controls.Add(Me.Label33)
        Me.FrameStreamParam.Controls.Add(Me.Label34)
        Me.FrameStreamParam.Controls.Add(Me.txtHydroManningCoeff)
        Me.FrameStreamParam.Controls.Add(Me.cboRegions)
        Me.FrameStreamParam.Controls.Add(Me.txtAlphaDepth)
        Me.FrameStreamParam.Controls.Add(Me.txtBetaDepth)
        Me.FrameStreamParam.Controls.Add(Me.txtAlphaWidth)
        Me.FrameStreamParam.Controls.Add(Me.txtBetaWidth)
        Me.FrameStreamParam.Controls.Add(Me.txtCrossSectionSlope1)
        Me.FrameStreamParam.Controls.Add(Me.txtCrossSectionSlope2)
        Me.FrameStreamParam.Controls.Add(Me.PictureChannel)
        Me.FrameStreamParam.Controls.Add(Me.Label102)
        Me.FrameStreamParam.Controls.Add(Me.Label35)
        Me.FrameStreamParam.Controls.Add(Me.Label66)
        Me.FrameStreamParam.Controls.Add(Me.Label67)
        Me.FrameStreamParam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameStreamParam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameStreamParam.Location = New System.Drawing.Point(9, 73)
        Me.FrameStreamParam.Name = "FrameStreamParam"
        Me.FrameStreamParam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameStreamParam.Size = New System.Drawing.Size(526, 233)
        Me.FrameStreamParam.TabIndex = 0
        Me.FrameStreamParam.TabStop = False
        Me.FrameStreamParam.Text = "Define Stream Parameters"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(335, 195)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(26, 14)
        Me.Label31.TabIndex = 14
        Me.Label31.Text = "βw:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(335, 163)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(22, 14)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "βd:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(16, 163)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(240, 14)
        Me.Label33.TabIndex = 8
        Me.Label33.Text = "Channel Depth (D = αd * Drainage Area ^ βd) αd:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(16, 195)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(254, 14)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "Channel Width (W = αw * Drainage Area ^ βw) αw:"
        '
        'txtHydroManningCoeff
        '
        Me.txtHydroManningCoeff.AcceptsReturn = True
        Me.txtHydroManningCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.txtHydroManningCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHydroManningCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHydroManningCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHydroManningCoeff.Location = New System.Drawing.Point(274, 24)
        Me.txtHydroManningCoeff.MaxLength = 0
        Me.txtHydroManningCoeff.Name = "txtHydroManningCoeff"
        Me.txtHydroManningCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHydroManningCoeff.Size = New System.Drawing.Size(54, 20)
        Me.txtHydroManningCoeff.TabIndex = 1
        Me.txtHydroManningCoeff.Text = "0.014"
        '
        'cboRegions
        '
        Me.cboRegions.BackColor = System.Drawing.SystemColors.Window
        Me.cboRegions.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegions.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegions.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRegions.Location = New System.Drawing.Point(274, 128)
        Me.cboRegions.Name = "cboRegions"
        Me.cboRegions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboRegions.Size = New System.Drawing.Size(136, 22)
        Me.cboRegions.TabIndex = 7
        '
        'txtAlphaDepth
        '
        Me.txtAlphaDepth.AcceptsReturn = True
        Me.txtAlphaDepth.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlphaDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAlphaDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlphaDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAlphaDepth.Location = New System.Drawing.Point(274, 160)
        Me.txtAlphaDepth.MaxLength = 0
        Me.txtAlphaDepth.Name = "txtAlphaDepth"
        Me.txtAlphaDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAlphaDepth.Size = New System.Drawing.Size(47, 20)
        Me.txtAlphaDepth.TabIndex = 9
        '
        'txtBetaDepth
        '
        Me.txtBetaDepth.AcceptsReturn = True
        Me.txtBetaDepth.BackColor = System.Drawing.SystemColors.Window
        Me.txtBetaDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBetaDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBetaDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBetaDepth.Location = New System.Drawing.Point(363, 160)
        Me.txtBetaDepth.MaxLength = 0
        Me.txtBetaDepth.Name = "txtBetaDepth"
        Me.txtBetaDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBetaDepth.Size = New System.Drawing.Size(47, 20)
        Me.txtBetaDepth.TabIndex = 11
        '
        'txtAlphaWidth
        '
        Me.txtAlphaWidth.AcceptsReturn = True
        Me.txtAlphaWidth.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlphaWidth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAlphaWidth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlphaWidth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAlphaWidth.Location = New System.Drawing.Point(274, 192)
        Me.txtAlphaWidth.MaxLength = 0
        Me.txtAlphaWidth.Name = "txtAlphaWidth"
        Me.txtAlphaWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAlphaWidth.Size = New System.Drawing.Size(47, 20)
        Me.txtAlphaWidth.TabIndex = 13
        '
        'txtBetaWidth
        '
        Me.txtBetaWidth.AcceptsReturn = True
        Me.txtBetaWidth.BackColor = System.Drawing.SystemColors.Window
        Me.txtBetaWidth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBetaWidth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBetaWidth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBetaWidth.Location = New System.Drawing.Point(363, 192)
        Me.txtBetaWidth.MaxLength = 0
        Me.txtBetaWidth.Name = "txtBetaWidth"
        Me.txtBetaWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBetaWidth.Size = New System.Drawing.Size(47, 20)
        Me.txtBetaWidth.TabIndex = 15
        '
        'txtCrossSectionSlope1
        '
        Me.txtCrossSectionSlope1.AcceptsReturn = True
        Me.txtCrossSectionSlope1.BackColor = System.Drawing.SystemColors.Window
        Me.txtCrossSectionSlope1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrossSectionSlope1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrossSectionSlope1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCrossSectionSlope1.Location = New System.Drawing.Point(274, 56)
        Me.txtCrossSectionSlope1.MaxLength = 0
        Me.txtCrossSectionSlope1.Name = "txtCrossSectionSlope1"
        Me.txtCrossSectionSlope1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCrossSectionSlope1.Size = New System.Drawing.Size(54, 20)
        Me.txtCrossSectionSlope1.TabIndex = 3
        Me.txtCrossSectionSlope1.Text = "1.0"
        '
        'txtCrossSectionSlope2
        '
        Me.txtCrossSectionSlope2.AcceptsReturn = True
        Me.txtCrossSectionSlope2.BackColor = System.Drawing.SystemColors.Window
        Me.txtCrossSectionSlope2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrossSectionSlope2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrossSectionSlope2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCrossSectionSlope2.Location = New System.Drawing.Point(274, 88)
        Me.txtCrossSectionSlope2.MaxLength = 0
        Me.txtCrossSectionSlope2.Name = "txtCrossSectionSlope2"
        Me.txtCrossSectionSlope2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCrossSectionSlope2.Size = New System.Drawing.Size(54, 20)
        Me.txtCrossSectionSlope2.TabIndex = 5
        Me.txtCrossSectionSlope2.Text = "1.0"
        '
        'PictureChannel
        '
        Me.PictureChannel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureChannel.BackColor = System.Drawing.SystemColors.Control
        Me.PictureChannel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureChannel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureChannel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PictureChannel.Image = CType(resources.GetObject("PictureChannel.Image"), System.Drawing.Image)
        Me.PictureChannel.Location = New System.Drawing.Point(334, 19)
        Me.PictureChannel.Name = "PictureChannel"
        Me.PictureChannel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PictureChannel.Size = New System.Drawing.Size(186, 92)
        Me.PictureChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureChannel.TabIndex = 9
        Me.PictureChannel.TabStop = False
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.BackColor = System.Drawing.Color.Transparent
        Me.Label102.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label102.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label102.Location = New System.Drawing.Point(16, 27)
        Me.Label102.Name = "Label102"
        Me.Label102.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label102.Size = New System.Drawing.Size(247, 14)
        Me.Label102.TabIndex = 0
        Me.Label102.Text = "Manning's Roughness Coefficient for Channel (n):"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(16, 131)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(236, 14)
        Me.Label35.TabIndex = 6
        Me.Label35.Text = "Select Region to Compute Channel Depth/Width:"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label66.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label66.Location = New System.Drawing.Point(16, 59)
        Me.Label66.Name = "Label66"
        Me.Label66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label66.Size = New System.Drawing.Size(187, 14)
        Me.Label66.TabIndex = 2
        Me.Label66.Text = "Cross-Sectional Left Slope, Z1 (H:V):"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label67.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label67.Location = New System.Drawing.Point(16, 91)
        Me.Label67.Name = "Label67"
        Me.Label67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label67.Size = New System.Drawing.Size(192, 14)
        Me.Label67.TabIndex = 4
        Me.Label67.Text = "Cross-Sectional Right Slope, Z2 (H:V):"
        '
        '_SSTab1_TabPage3
        '
        Me._SSTab1_TabPage3.Controls.Add(Me.LakeAttributes)
        Me._SSTab1_TabPage3.Location = New System.Drawing.Point(4, 23)
        Me._SSTab1_TabPage3.Name = "_SSTab1_TabPage3"
        Me._SSTab1_TabPage3.Size = New System.Drawing.Size(544, 378)
        Me._SSTab1_TabPage3.TabIndex = 3
        Me._SSTab1_TabPage3.Text = "Lakes"
        Me._SSTab1_TabPage3.UseVisualStyleBackColor = True
        '
        'LakeAttributes
        '
        Me.LakeAttributes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LakeAttributes.BackColor = System.Drawing.Color.Transparent
        Me.LakeAttributes.Controls.Add(Me.txtHydroOrificeDepth)
        Me.LakeAttributes.Controls.Add(Me.txtLakeInfiltration)
        Me.LakeAttributes.Controls.Add(Me.txtBankFullDepth)
        Me.LakeAttributes.Controls.Add(Me.txtInitWaterDepth)
        Me.LakeAttributes.Controls.Add(Me.txtLakesThreshold)
        Me.LakeAttributes.Controls.Add(Me.txtHydroOrificeDia)
        Me.LakeAttributes.Controls.Add(Me.txtHydroOrificeDischargeCoeff)
        Me.LakeAttributes.Controls.Add(Me.txtHydroWeirCrestLength)
        Me.LakeAttributes.Controls.Add(Me.txtHydroWeirDischargeCoeff)
        Me.LakeAttributes.Controls.Add(Me.txtHydroEvapoCoeff)
        Me.LakeAttributes.Controls.Add(Me.Label36)
        Me.LakeAttributes.Controls.Add(Me.Label37)
        Me.LakeAttributes.Controls.Add(Me.Label38)
        Me.LakeAttributes.Controls.Add(Me.Label39)
        Me.LakeAttributes.Controls.Add(Me.Label40)
        Me.LakeAttributes.Controls.Add(Me.Label41)
        Me.LakeAttributes.Controls.Add(Me.Label42)
        Me.LakeAttributes.Controls.Add(Me.Label43)
        Me.LakeAttributes.Controls.Add(Me.Label44)
        Me.LakeAttributes.Controls.Add(Me.Label45)
        Me.LakeAttributes.Enabled = False
        Me.LakeAttributes.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LakeAttributes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LakeAttributes.Location = New System.Drawing.Point(134, 49)
        Me.LakeAttributes.Name = "LakeAttributes"
        Me.LakeAttributes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LakeAttributes.Size = New System.Drawing.Size(276, 281)
        Me.LakeAttributes.TabIndex = 0
        Me.LakeAttributes.TabStop = False
        Me.LakeAttributes.Text = "Define Lake/Reservoir Parameters"
        '
        'txtHydroOrificeDepth
        '
        Me.txtHydroOrificeDepth.AcceptsReturn = True
        Me.txtHydroOrificeDepth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHydroOrificeDepth.BackColor = System.Drawing.SystemColors.Window
        Me.txtHydroOrificeDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHydroOrificeDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHydroOrificeDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHydroOrificeDepth.Location = New System.Drawing.Point(210, 121)
        Me.txtHydroOrificeDepth.MaxLength = 0
        Me.txtHydroOrificeDepth.Name = "txtHydroOrificeDepth"
        Me.txtHydroOrificeDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHydroOrificeDepth.Size = New System.Drawing.Size(60, 20)
        Me.txtHydroOrificeDepth.TabIndex = 9
        Me.txtHydroOrificeDepth.Text = "0"
        '
        'txtLakeInfiltration
        '
        Me.txtLakeInfiltration.AcceptsReturn = True
        Me.txtLakeInfiltration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLakeInfiltration.BackColor = System.Drawing.SystemColors.Window
        Me.txtLakeInfiltration.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLakeInfiltration.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLakeInfiltration.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLakeInfiltration.Location = New System.Drawing.Point(210, 241)
        Me.txtLakeInfiltration.MaxLength = 0
        Me.txtLakeInfiltration.Name = "txtLakeInfiltration"
        Me.txtLakeInfiltration.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLakeInfiltration.Size = New System.Drawing.Size(60, 20)
        Me.txtLakeInfiltration.TabIndex = 19
        Me.txtLakeInfiltration.Text = "0.001"
        '
        'txtBankFullDepth
        '
        Me.txtBankFullDepth.AcceptsReturn = True
        Me.txtBankFullDepth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBankFullDepth.BackColor = System.Drawing.SystemColors.Window
        Me.txtBankFullDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBankFullDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankFullDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBankFullDepth.Location = New System.Drawing.Point(210, 73)
        Me.txtBankFullDepth.MaxLength = 0
        Me.txtBankFullDepth.Name = "txtBankFullDepth"
        Me.txtBankFullDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBankFullDepth.Size = New System.Drawing.Size(60, 20)
        Me.txtBankFullDepth.TabIndex = 5
        Me.txtBankFullDepth.Text = "0.5"
        '
        'txtInitWaterDepth
        '
        Me.txtInitWaterDepth.AcceptsReturn = True
        Me.txtInitWaterDepth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInitWaterDepth.BackColor = System.Drawing.SystemColors.Window
        Me.txtInitWaterDepth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInitWaterDepth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitWaterDepth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInitWaterDepth.Location = New System.Drawing.Point(210, 49)
        Me.txtInitWaterDepth.MaxLength = 0
        Me.txtInitWaterDepth.Name = "txtInitWaterDepth"
        Me.txtInitWaterDepth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInitWaterDepth.Size = New System.Drawing.Size(60, 20)
        Me.txtInitWaterDepth.TabIndex = 3
        Me.txtInitWaterDepth.Text = "0.5"
        '
        'txtLakesThreshold
        '
        Me.txtLakesThreshold.AcceptsReturn = True
        Me.txtLakesThreshold.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLakesThreshold.BackColor = System.Drawing.SystemColors.Window
        Me.txtLakesThreshold.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLakesThreshold.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLakesThreshold.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLakesThreshold.Location = New System.Drawing.Point(210, 25)
        Me.txtLakesThreshold.MaxLength = 0
        Me.txtLakesThreshold.Name = "txtLakesThreshold"
        Me.txtLakesThreshold.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLakesThreshold.Size = New System.Drawing.Size(60, 20)
        Me.txtLakesThreshold.TabIndex = 1
        Me.txtLakesThreshold.Text = "1000000"
        '
        'txtHydroOrificeDia
        '
        Me.txtHydroOrificeDia.AcceptsReturn = True
        Me.txtHydroOrificeDia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHydroOrificeDia.BackColor = System.Drawing.SystemColors.Window
        Me.txtHydroOrificeDia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHydroOrificeDia.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHydroOrificeDia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHydroOrificeDia.Location = New System.Drawing.Point(210, 145)
        Me.txtHydroOrificeDia.MaxLength = 0
        Me.txtHydroOrificeDia.Name = "txtHydroOrificeDia"
        Me.txtHydroOrificeDia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHydroOrificeDia.Size = New System.Drawing.Size(60, 20)
        Me.txtHydroOrificeDia.TabIndex = 11
        Me.txtHydroOrificeDia.Text = "0"
        '
        'txtHydroOrificeDischargeCoeff
        '
        Me.txtHydroOrificeDischargeCoeff.AcceptsReturn = True
        Me.txtHydroOrificeDischargeCoeff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHydroOrificeDischargeCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.txtHydroOrificeDischargeCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHydroOrificeDischargeCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHydroOrificeDischargeCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHydroOrificeDischargeCoeff.Location = New System.Drawing.Point(210, 169)
        Me.txtHydroOrificeDischargeCoeff.MaxLength = 0
        Me.txtHydroOrificeDischargeCoeff.Name = "txtHydroOrificeDischargeCoeff"
        Me.txtHydroOrificeDischargeCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHydroOrificeDischargeCoeff.Size = New System.Drawing.Size(60, 20)
        Me.txtHydroOrificeDischargeCoeff.TabIndex = 13
        Me.txtHydroOrificeDischargeCoeff.Text = "0.6"
        '
        'txtHydroWeirCrestLength
        '
        Me.txtHydroWeirCrestLength.AcceptsReturn = True
        Me.txtHydroWeirCrestLength.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHydroWeirCrestLength.BackColor = System.Drawing.SystemColors.Window
        Me.txtHydroWeirCrestLength.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHydroWeirCrestLength.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHydroWeirCrestLength.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHydroWeirCrestLength.Location = New System.Drawing.Point(210, 193)
        Me.txtHydroWeirCrestLength.MaxLength = 0
        Me.txtHydroWeirCrestLength.Name = "txtHydroWeirCrestLength"
        Me.txtHydroWeirCrestLength.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHydroWeirCrestLength.Size = New System.Drawing.Size(60, 20)
        Me.txtHydroWeirCrestLength.TabIndex = 15
        Me.txtHydroWeirCrestLength.Text = "30"
        '
        'txtHydroWeirDischargeCoeff
        '
        Me.txtHydroWeirDischargeCoeff.AcceptsReturn = True
        Me.txtHydroWeirDischargeCoeff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHydroWeirDischargeCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.txtHydroWeirDischargeCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHydroWeirDischargeCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHydroWeirDischargeCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHydroWeirDischargeCoeff.Location = New System.Drawing.Point(210, 217)
        Me.txtHydroWeirDischargeCoeff.MaxLength = 0
        Me.txtHydroWeirDischargeCoeff.Name = "txtHydroWeirDischargeCoeff"
        Me.txtHydroWeirDischargeCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHydroWeirDischargeCoeff.Size = New System.Drawing.Size(60, 20)
        Me.txtHydroWeirDischargeCoeff.TabIndex = 17
        Me.txtHydroWeirDischargeCoeff.Text = "1.84"
        '
        'txtHydroEvapoCoeff
        '
        Me.txtHydroEvapoCoeff.AcceptsReturn = True
        Me.txtHydroEvapoCoeff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHydroEvapoCoeff.BackColor = System.Drawing.SystemColors.Window
        Me.txtHydroEvapoCoeff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHydroEvapoCoeff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHydroEvapoCoeff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHydroEvapoCoeff.Location = New System.Drawing.Point(210, 97)
        Me.txtHydroEvapoCoeff.MaxLength = 0
        Me.txtHydroEvapoCoeff.Name = "txtHydroEvapoCoeff"
        Me.txtHydroEvapoCoeff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHydroEvapoCoeff.Size = New System.Drawing.Size(60, 20)
        Me.txtHydroEvapoCoeff.TabIndex = 7
        Me.txtHydroEvapoCoeff.Text = "0.10"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(6, 123)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(126, 14)
        Me.Label36.TabIndex = 8
        Me.Label36.Text = "Orifice Depth to Bed (m):"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(6, 246)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(142, 14)
        Me.Label37.TabIndex = 18
        Me.Label37.Text = "Lake Infiltration rate (cm/hr):"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(6, 52)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(118, 14)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "Initial Water Depth (m) :"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(6, 75)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(101, 14)
        Me.Label39.TabIndex = 4
        Me.Label39.Text = "Bankfull Depth (m) :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label40.Location = New System.Drawing.Point(6, 28)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label40.Size = New System.Drawing.Size(160, 14)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Threshold Area for Lakes (m²) :"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label41.Location = New System.Drawing.Point(6, 147)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label41.Size = New System.Drawing.Size(106, 14)
        Me.Label41.TabIndex = 10
        Me.Label41.Text = "Orifice Diameter (m):"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(6, 171)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label42.Size = New System.Drawing.Size(149, 14)
        Me.Label42.TabIndex = 12
        Me.Label42.Text = "Orifice Discharge Coefficient:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(6, 195)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(116, 14)
        Me.Label43.TabIndex = 14
        Me.Label43.Text = "Weir Crest Length (m):"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label44.Location = New System.Drawing.Point(6, 222)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(139, 14)
        Me.Label44.TabIndex = 16
        Me.Label44.Text = "Weir Discharge Coefficient:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label45.Location = New System.Drawing.Point(6, 99)
        Me.Label45.Name = "Label45"
        Me.Label45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label45.Size = New System.Drawing.Size(122, 14)
        Me.Label45.TabIndex = 6
        Me.Label45.Text = "Evaporation Coefficient:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(552, 51)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.Transparent
        Me.tabGeneral.Controls.Add(Me.TableLayoutPanel1)
        Me.tabGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(558, 462)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOutputName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOutput, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOutputName, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtInputName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInputName, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lnkClipAll, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(552, 456)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TabControl4
        '
        Me.TabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControl4, 3)
        Me.TabControl4.Controls.Add(Me.TabPage10)
        Me.TabControl4.Controls.Add(Me.TabPage11)
        Me.TabControl4.Controls.Add(Me.TabPage12)
        Me.TabControl4.Controls.Add(Me.TabPage13)
        Me.TabControl4.Location = New System.Drawing.Point(3, 189)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(546, 241)
        Me.TabControl4.TabIndex = 7
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(538, 215)
        Me.TabPage10.TabIndex = 0
        Me.TabPage10.Text = "Subbasins && DEM"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel5.Controls.Add(Me.Label117, 0, 7)
        Me.TableLayoutPanel5.Controls.Add(Me.cboSubbasinLayer, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lblSubbasinsLayer, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.txtGridSize, 1, 6)
        Me.TableLayoutPanel5.Controls.Add(Me.lblGridSize, 0, 6)
        Me.TableLayoutPanel5.Controls.Add(Me.Label119, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label122, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cboDEMLayer, 1, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label123, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblDEMLayer, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.cboSubbasinField, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lnkSubbasinLayer, 3, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label10, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.cboDEMUnits, 1, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.lnkMergeCatchments, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.lblDEMLayerSize, 2, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.txtThreshold, 1, 7)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 9
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(532, 209)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Label117
        '
        Me.Label117.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label117.AutoSize = True
        Me.Label117.Location = New System.Drawing.Point(3, 183)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(155, 13)
        Me.Label117.TabIndex = 15
        Me.Label117.Text = "Stream Area &Threshold (sq km):"
        '
        'lblSubbasinsLayer
        '
        Me.lblSubbasinsLayer.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSubbasinsLayer.AutoSize = True
        Me.lblSubbasinsLayer.Location = New System.Drawing.Point(3, 47)
        Me.lblSubbasinsLayer.Name = "lblSubbasinsLayer"
        Me.lblSubbasinsLayer.Size = New System.Drawing.Size(88, 13)
        Me.lblSubbasinsLayer.TabIndex = 3
        Me.lblSubbasinsLayer.Text = "Subbasins &Layer:"
        '
        'lblGridSize
        '
        Me.lblGridSize.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGridSize.AutoSize = True
        Me.lblGridSize.Location = New System.Drawing.Point(3, 157)
        Me.lblGridSize.Name = "lblGridSize"
        Me.lblGridSize.Size = New System.Drawing.Size(89, 13)
        Me.lblGridSize.TabIndex = 13
        Me.lblGridSize.Text = "Grid &Cell Size (m):"
        '
        'Label119
        '
        Me.Label119.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(72, 13)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(35, 13)
        Me.Label119.TabIndex = 0
        Me.Label119.Text = "Item:"
        '
        'Label122
        '
        Me.Label122.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.Location = New System.Drawing.Point(210, 13)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(129, 13)
        Me.Label122.TabIndex = 1
        Me.Label122.Text = "Layer or Table Name:"
        '
        'Label123
        '
        Me.Label123.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(372, 13)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(91, 13)
        Me.Label123.TabIndex = 2
        Me.Label123.Text = "ID Field Name:"
        Me.Label123.Visible = False
        '
        'lblDEMLayer
        '
        Me.lblDEMLayer.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDEMLayer.AutoSize = True
        Me.lblDEMLayer.Location = New System.Drawing.Point(3, 104)
        Me.lblDEMLayer.Name = "lblDEMLayer"
        Me.lblDEMLayer.Size = New System.Drawing.Size(85, 13)
        Me.lblDEMLayer.TabIndex = 8
        Me.lblDEMLayer.Text = "&DEM Grid Layer:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "DEM Grid Elevation &Units:"
        '
        'lblDEMLayerSize
        '
        Me.lblDEMLayerSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDEMLayerSize.AutoSize = True
        Me.lblDEMLayerSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDEMLayerSize.Location = New System.Drawing.Point(378, 104)
        Me.lblDEMLayerSize.Name = "lblDEMLayerSize"
        Me.lblDEMLayerSize.Size = New System.Drawing.Size(79, 13)
        Me.lblDEMLayerSize.TabIndex = 10
        Me.lblDEMLayerSize.Text = "Cell Size = ??m"
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.TableLayoutPanel6)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(538, 215)
        Me.TabPage11.TabIndex = 1
        Me.TabPage11.Text = "Soils && Landuse"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 4
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel6.Controls.Add(Me.Label128, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label129, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label130, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lnkSoilLayer, 3, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label124, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.cboSoilLayer, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.cboSoilField, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label131, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.cboLanduseType, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.lblLandUseLayer, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.cboLandUseLayer, 1, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.cboLandUseField, 2, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.lnkLanduseLayer, 3, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.cboSoilTable, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label5, 0, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6, 0, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.cboLanduseTable, 1, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.cboLanduseCNTable, 1, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.lnkSoilTable, 3, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.lnkLanduseTable, 3, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.lnkLanduseCNTable, 3, 7)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 9
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(532, 209)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label128
        '
        Me.Label128.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.Location = New System.Drawing.Point(72, 13)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(35, 13)
        Me.Label128.TabIndex = 0
        Me.Label128.Text = "Item:"
        '
        'Label129
        '
        Me.Label129.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.Location = New System.Drawing.Point(210, 13)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(129, 13)
        Me.Label129.TabIndex = 1
        Me.Label129.Text = "Layer or Table Name:"
        '
        'Label130
        '
        Me.Label130.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.Location = New System.Drawing.Point(372, 13)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(91, 13)
        Me.Label130.TabIndex = 2
        Me.Label130.Text = "ID Field Name:"
        '
        'Label124
        '
        Me.Label124.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label124.AutoSize = True
        Me.Label124.Location = New System.Drawing.Point(3, 47)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(83, 13)
        Me.Label124.TabIndex = 3
        Me.Label124.Text = "Soil Type &Layer:"
        '
        'Label131
        '
        Me.Label131.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label131.AutoSize = True
        Me.Label131.Location = New System.Drawing.Point(3, 111)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(112, 13)
        Me.Label131.TabIndex = 10
        Me.Label131.Text = "Land Use Layer &Type:"
        '
        'lblLandUseLayer
        '
        Me.lblLandUseLayer.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLandUseLayer.AutoSize = True
        Me.lblLandUseLayer.Location = New System.Drawing.Point(3, 138)
        Me.lblLandUseLayer.Name = "lblLandUseLayer"
        Me.lblLandUseLayer.Size = New System.Drawing.Size(85, 13)
        Me.lblLandUseLayer.TabIndex = 12
        Me.lblLandUseLayer.Text = "Land &Use Layer:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Soil &Property Table:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "La&nd Use Parameter Table:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Landuse &Curve Number Table:"
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.TableLayoutPanel7)
        Me.TabPage12.Location = New System.Drawing.Point(4, 22)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(538, 215)
        Me.TabPage12.TabIndex = 2
        Me.TabPage12.Text = "Climate && Point Sources"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel7.Controls.Add(Me.Label18, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label132, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label133, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.cboPointSourceTable, 1, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.Label96, 0, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.cboClimateStaLayer, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.cboPointSourceLayer, 1, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.cboClimateStaField, 2, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label95, 0, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.lnkClimateStaLayer, 3, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.cboClimateDataTable, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.lnkPointSourceTable, 3, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.Label12, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.lnkClimateDataTable, 3, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.cboPointSourceField, 2, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.lnkPointSourceLayer, 3, 4)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 7
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(532, 209)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(72, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Item:"
        '
        'Label132
        '
        Me.Label132.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label132.AutoSize = True
        Me.Label132.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.Location = New System.Drawing.Point(210, 13)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(129, 13)
        Me.Label132.TabIndex = 1
        Me.Label132.Text = "Layer or Table Name:"
        '
        'Label133
        '
        Me.Label133.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label133.AutoSize = True
        Me.Label133.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label133.Location = New System.Drawing.Point(372, 13)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(91, 13)
        Me.Label133.TabIndex = 2
        Me.Label133.Text = "ID Field Name:"
        '
        'Label96
        '
        Me.Label96.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(3, 138)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(159, 13)
        Me.Label96.TabIndex = 14
        Me.Label96.Text = "P&oint Source Time Series Table:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "&Climate Stations Layer:"
        '
        'cboPointSourceLayer
        '
        Me.cboPointSourceLayer.AllowDrop = True
        Me.cboPointSourceLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPointSourceLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPointSourceLayer.Location = New System.Drawing.Point(183, 107)
        Me.cboPointSourceLayer.Name = "cboPointSourceLayer"
        Me.cboPointSourceLayer.Size = New System.Drawing.Size(183, 21)
        Me.cboPointSourceLayer.Sorted = True
        Me.cboPointSourceLayer.TabIndex = 11
        '
        'Label95
        '
        Me.Label95.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(3, 111)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(153, 13)
        Me.Label95.TabIndex = 10
        Me.Label95.Text = "&Point Sources Layer (Optional):"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Climate &Time Series Table:"
        '
        'cboPointSourceField
        '
        Me.cboPointSourceField.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPointSourceField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPointSourceField.FormattingEnabled = True
        Me.cboPointSourceField.Location = New System.Drawing.Point(372, 107)
        Me.cboPointSourceField.Name = "cboPointSourceField"
        Me.cboPointSourceField.Size = New System.Drawing.Size(91, 21)
        Me.cboPointSourceField.TabIndex = 12
        '
        'lnkPointSourceLayer
        '
        Me.lnkPointSourceLayer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkPointSourceLayer.AutoSize = True
        Me.lnkPointSourceLayer.LinkColor = System.Drawing.Color.Blue
        Me.lnkPointSourceLayer.Location = New System.Drawing.Point(469, 111)
        Me.lnkPointSourceLayer.Name = "lnkPointSourceLayer"
        Me.lnkPointSourceLayer.Size = New System.Drawing.Size(60, 13)
        Me.lnkPointSourceLayer.TabIndex = 13
        Me.lnkPointSourceLayer.TabStop = True
        Me.lnkPointSourceLayer.Text = "View Table"
        Me.lnkPointSourceLayer.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.TableLayoutPanel8)
        Me.TabPage13.Location = New System.Drawing.Point(4, 22)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(538, 215)
        Me.TabPage13.TabIndex = 3
        Me.TabPage13.Text = "Streams && Lakes"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel8.Controls.Add(Me.Label125, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label134, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.cboLakeLayer, 1, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.Label116, 0, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.lnkLakeLayer, 3, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.cboLakeField, 2, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.Label112, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.cboFlowRelationTable, 1, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.Label110, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label135, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.cboStreamLayer, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.lnkFlowRelationTable, 3, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.lnkStreamLayer, 3, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label118, 0, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.Label136, 0, 6)
        Me.TableLayoutPanel8.Controls.Add(Me.cboFlowDirLayer, 1, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.cboFlowAccLayer, 1, 6)
        Me.TableLayoutPanel8.Controls.Add(Me.lblFlowDirLayerSize, 2, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.lblFlowAccLayerSize, 2, 6)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Enabled = False
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 8
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(532, 209)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'Label125
        '
        Me.Label125.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.Location = New System.Drawing.Point(72, 13)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(35, 13)
        Me.Label125.TabIndex = 0
        Me.Label125.Text = "Item:"
        '
        'Label134
        '
        Me.Label134.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label134.AutoSize = True
        Me.Label134.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label134.Location = New System.Drawing.Point(210, 13)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(129, 13)
        Me.Label134.TabIndex = 1
        Me.Label134.Text = "Layer or Table Name:"
        '
        'cboLakeLayer
        '
        Me.cboLakeLayer.AllowDrop = True
        Me.cboLakeLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLakeLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLakeLayer.Location = New System.Drawing.Point(183, 97)
        Me.cboLakeLayer.Name = "cboLakeLayer"
        Me.cboLakeLayer.Size = New System.Drawing.Size(183, 21)
        Me.cboLakeLayer.Sorted = True
        Me.cboLakeLayer.TabIndex = 10
        '
        'Label116
        '
        Me.Label116.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label116.AutoSize = True
        Me.Label116.Location = New System.Drawing.Point(3, 101)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(111, 13)
        Me.Label116.TabIndex = 9
        Me.Label116.Text = "La&ke Layer (Optional):"
        '
        'cboLakeField
        '
        Me.cboLakeField.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLakeField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLakeField.FormattingEnabled = True
        Me.cboLakeField.Location = New System.Drawing.Point(372, 97)
        Me.cboLakeField.Name = "cboLakeField"
        Me.cboLakeField.Size = New System.Drawing.Size(91, 21)
        Me.cboLakeField.TabIndex = 11
        '
        'Label112
        '
        Me.Label112.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(3, 74)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(131, 13)
        Me.Label112.TabIndex = 6
        Me.Label112.Text = "NHD Flow &Relation Table:"
        Me.Label112.Visible = False
        '
        'cboFlowRelationTable
        '
        Me.cboFlowRelationTable.AllowDrop = True
        Me.cboFlowRelationTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFlowRelationTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFlowRelationTable.Location = New System.Drawing.Point(183, 70)
        Me.cboFlowRelationTable.Name = "cboFlowRelationTable"
        Me.cboFlowRelationTable.Size = New System.Drawing.Size(183, 21)
        Me.cboFlowRelationTable.Sorted = True
        Me.cboFlowRelationTable.TabIndex = 7
        Me.cboFlowRelationTable.Visible = False
        '
        'Label110
        '
        Me.Label110.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label110.AutoSize = True
        Me.Label110.Location = New System.Drawing.Point(3, 47)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(72, 13)
        Me.Label110.TabIndex = 3
        Me.Label110.Text = "Stream &Layer:"
        Me.Label110.Visible = False
        '
        'Label135
        '
        Me.Label135.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label135.AutoSize = True
        Me.Label135.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label135.Location = New System.Drawing.Point(372, 13)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(91, 13)
        Me.Label135.TabIndex = 2
        Me.Label135.Text = "ID Field Name:"
        '
        'cboStreamLayer
        '
        Me.cboStreamLayer.AllowDrop = True
        Me.cboStreamLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStreamLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStreamLayer.Location = New System.Drawing.Point(183, 43)
        Me.cboStreamLayer.Name = "cboStreamLayer"
        Me.cboStreamLayer.Size = New System.Drawing.Size(183, 21)
        Me.cboStreamLayer.Sorted = True
        Me.cboStreamLayer.TabIndex = 4
        Me.cboStreamLayer.Visible = False
        '
        'Label118
        '
        Me.Label118.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label118.AutoSize = True
        Me.Label118.Location = New System.Drawing.Point(3, 128)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(128, 13)
        Me.Label118.TabIndex = 13
        Me.Label118.Text = "Flow Direction Grid Layer:"
        Me.Label118.Visible = False
        '
        'Label136
        '
        Me.Label136.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label136.AutoSize = True
        Me.Label136.Location = New System.Drawing.Point(3, 155)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(150, 13)
        Me.Label136.TabIndex = 16
        Me.Label136.Text = "Flow Accumulation Grid Layer:"
        Me.Label136.Visible = False
        '
        'cboFlowDirLayer
        '
        Me.cboFlowDirLayer.AllowDrop = True
        Me.cboFlowDirLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFlowDirLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFlowDirLayer.Location = New System.Drawing.Point(183, 124)
        Me.cboFlowDirLayer.Name = "cboFlowDirLayer"
        Me.cboFlowDirLayer.Size = New System.Drawing.Size(183, 21)
        Me.cboFlowDirLayer.Sorted = True
        Me.cboFlowDirLayer.TabIndex = 14
        Me.cboFlowDirLayer.Visible = False
        '
        'cboFlowAccLayer
        '
        Me.cboFlowAccLayer.AllowDrop = True
        Me.cboFlowAccLayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFlowAccLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFlowAccLayer.Location = New System.Drawing.Point(183, 151)
        Me.cboFlowAccLayer.Name = "cboFlowAccLayer"
        Me.cboFlowAccLayer.Size = New System.Drawing.Size(183, 21)
        Me.cboFlowAccLayer.Sorted = True
        Me.cboFlowAccLayer.TabIndex = 17
        Me.cboFlowAccLayer.Visible = False
        '
        'lblFlowDirLayerSize
        '
        Me.lblFlowDirLayerSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFlowDirLayerSize.AutoSize = True
        Me.lblFlowDirLayerSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowDirLayerSize.Location = New System.Drawing.Point(378, 128)
        Me.lblFlowDirLayerSize.Name = "lblFlowDirLayerSize"
        Me.lblFlowDirLayerSize.Size = New System.Drawing.Size(79, 13)
        Me.lblFlowDirLayerSize.TabIndex = 15
        Me.lblFlowDirLayerSize.Text = "Cell Size = ??m"
        Me.lblFlowDirLayerSize.Visible = False
        '
        'lblFlowAccLayerSize
        '
        Me.lblFlowAccLayerSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFlowAccLayerSize.AutoSize = True
        Me.lblFlowAccLayerSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowAccLayerSize.Location = New System.Drawing.Point(378, 155)
        Me.lblFlowAccLayerSize.Name = "lblFlowAccLayerSize"
        Me.lblFlowAccLayerSize.Size = New System.Drawing.Size(79, 13)
        Me.lblFlowAccLayerSize.TabIndex = 18
        Me.lblFlowAccLayerSize.Text = "Cell Size = ??m"
        Me.lblFlowAccLayerSize.Visible = False
        '
        'lblOutput
        '
        Me.lblOutput.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(3, 157)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(105, 13)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "&Output Folder Name:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 120)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Input Folder Name:"
        '
        'lnkClipAll
        '
        Me.lnkClipAll.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lnkClipAll.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lnkClipAll, 3)
        Me.lnkClipAll.Location = New System.Drawing.Point(352, 438)
        Me.lnkClipAll.Name = "lnkClipAll"
        Me.lnkClipAll.Size = New System.Drawing.Size(197, 13)
        Me.lnkClipAll.TabIndex = 8
        Me.lnkClipAll.TabStop = True
        Me.lnkClipAll.Text = "Clip all layers to subbasins and replace..."
        Me.ToolTip1.SetToolTip(Me.lnkClipAll, "Clip all layers to the boundaries of the current subbasins layer, add to map, and" & _
                " select them")
        Me.lnkClipAll.Visible = False
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.tabGeneral)
        Me.tabMain.Controls.Add(Me.tabHydrology)
        Me.tabMain.Controls.Add(Me.tabSediment)
        Me.tabMain.Controls.Add(Me.tabMercury)
        Me.tabMain.Controls.Add(Me.tabSimulate)
        Me.tabMain.Controls.Add(Me.tabResults)
        Me.tabMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.ItemSize = New System.Drawing.Size(60, 21)
        Me.tabMain.Location = New System.Drawing.Point(15, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(566, 491)
        Me.tabMain.TabIndex = 0
        '
        'tabSediment
        '
        Me.tabSediment.Controls.Add(Me.subtabSediment)
        Me.tabSediment.Controls.Add(Me.Label59)
        Me.tabSediment.Location = New System.Drawing.Point(4, 25)
        Me.tabSediment.Name = "tabSediment"
        Me.tabSediment.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSediment.Size = New System.Drawing.Size(558, 462)
        Me.tabSediment.TabIndex = 2
        Me.tabSediment.Text = "Sediment"
        Me.tabSediment.UseVisualStyleBackColor = True
        '
        'subtabSediment
        '
        Me.subtabSediment.Controls.Add(Me.tabSlopeLength)
        Me.subtabSediment.Controls.Add(Me.TabPage1)
        Me.subtabSediment.Controls.Add(Me.TabPage2)
        Me.subtabSediment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subtabSediment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtabSediment.ItemSize = New System.Drawing.Size(42, 19)
        Me.subtabSediment.Location = New System.Drawing.Point(3, 54)
        Me.subtabSediment.Name = "subtabSediment"
        Me.subtabSediment.SelectedIndex = 0
        Me.subtabSediment.Size = New System.Drawing.Size(552, 405)
        Me.subtabSediment.TabIndex = 1
        '
        'tabSlopeLength
        '
        Me.tabSlopeLength.Controls.Add(Me.fraSlopeLength)
        Me.tabSlopeLength.Location = New System.Drawing.Point(4, 23)
        Me.tabSlopeLength.Name = "tabSlopeLength"
        Me.tabSlopeLength.Size = New System.Drawing.Size(544, 378)
        Me.tabSlopeLength.TabIndex = 0
        Me.tabSlopeLength.Text = "Slope Length"
        Me.tabSlopeLength.UseVisualStyleBackColor = True
        '
        'fraSlopeLength
        '
        Me.fraSlopeLength.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fraSlopeLength.BackColor = System.Drawing.Color.Transparent
        Me.fraSlopeLength.Controls.Add(Me.txtMaxSlope)
        Me.fraSlopeLength.Controls.Add(Me.chkMaxSlope)
        Me.fraSlopeLength.Controls.Add(Me.optionExisting)
        Me.fraSlopeLength.Controls.Add(Me.optionDefaultLSFactor)
        Me.fraSlopeLength.Controls.Add(Me.txtCSL)
        Me.fraSlopeLength.Controls.Add(Me.optionDefineSlopeLength)
        Me.fraSlopeLength.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSlopeLength.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSlopeLength.Location = New System.Drawing.Point(109, 132)
        Me.fraSlopeLength.Name = "fraSlopeLength"
        Me.fraSlopeLength.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSlopeLength.Size = New System.Drawing.Size(326, 115)
        Me.fraSlopeLength.TabIndex = 0
        Me.fraSlopeLength.TabStop = False
        Me.fraSlopeLength.Text = "Define Slope Length"
        '
        'txtMaxSlope
        '
        Me.txtMaxSlope.AcceptsReturn = True
        Me.txtMaxSlope.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaxSlope.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaxSlope.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaxSlope.Enabled = False
        Me.txtMaxSlope.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxSlope.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMaxSlope.Location = New System.Drawing.Point(279, 41)
        Me.txtMaxSlope.MaxLength = 0
        Me.txtMaxSlope.Name = "txtMaxSlope"
        Me.txtMaxSlope.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaxSlope.Size = New System.Drawing.Size(41, 20)
        Me.txtMaxSlope.TabIndex = 2
        Me.txtMaxSlope.Text = "100"
        '
        'chkMaxSlope
        '
        Me.chkMaxSlope.AutoSize = True
        Me.chkMaxSlope.BackColor = System.Drawing.Color.Transparent
        Me.chkMaxSlope.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMaxSlope.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMaxSlope.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMaxSlope.Location = New System.Drawing.Point(40, 43)
        Me.chkMaxSlope.Name = "chkMaxSlope"
        Me.chkMaxSlope.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMaxSlope.Size = New System.Drawing.Size(155, 18)
        Me.chkMaxSlope.TabIndex = 1
        Me.chkMaxSlope.Text = "Maximum Slope Length (m)"
        Me.chkMaxSlope.UseVisualStyleBackColor = False
        '
        'optionExisting
        '
        Me.optionExisting.AutoSize = True
        Me.optionExisting.BackColor = System.Drawing.Color.Transparent
        Me.optionExisting.Cursor = System.Windows.Forms.Cursors.Default
        Me.optionExisting.Enabled = False
        Me.optionExisting.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionExisting.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optionExisting.Location = New System.Drawing.Point(6, 91)
        Me.optionExisting.Name = "optionExisting"
        Me.optionExisting.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optionExisting.Size = New System.Drawing.Size(218, 18)
        Me.optionExisting.TabIndex = 5
        Me.optionExisting.TabStop = True
        Me.optionExisting.Text = "Use Existing Slope Length and LSFactor"
        Me.optionExisting.UseVisualStyleBackColor = False
        '
        'optionDefaultLSFactor
        '
        Me.optionDefaultLSFactor.AutoSize = True
        Me.optionDefaultLSFactor.BackColor = System.Drawing.Color.Transparent
        Me.optionDefaultLSFactor.Cursor = System.Windows.Forms.Cursors.Default
        Me.optionDefaultLSFactor.Enabled = False
        Me.optionDefaultLSFactor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionDefaultLSFactor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optionDefaultLSFactor.Location = New System.Drawing.Point(6, 19)
        Me.optionDefaultLSFactor.Name = "optionDefaultLSFactor"
        Me.optionDefaultLSFactor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optionDefaultLSFactor.Size = New System.Drawing.Size(167, 18)
        Me.optionDefaultLSFactor.TabIndex = 0
        Me.optionDefaultLSFactor.TabStop = True
        Me.optionDefaultLSFactor.Text = "Use DEM based Slope Length"
        Me.optionDefaultLSFactor.UseVisualStyleBackColor = False
        '
        'txtCSL
        '
        Me.txtCSL.AcceptsReturn = True
        Me.txtCSL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCSL.BackColor = System.Drawing.SystemColors.Window
        Me.txtCSL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCSL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCSL.Location = New System.Drawing.Point(279, 67)
        Me.txtCSL.MaxLength = 0
        Me.txtCSL.Name = "txtCSL"
        Me.txtCSL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCSL.Size = New System.Drawing.Size(41, 20)
        Me.txtCSL.TabIndex = 4
        Me.txtCSL.Text = "30"
        '
        'optionDefineSlopeLength
        '
        Me.optionDefineSlopeLength.AutoSize = True
        Me.optionDefineSlopeLength.BackColor = System.Drawing.Color.Transparent
        Me.optionDefineSlopeLength.Checked = True
        Me.optionDefineSlopeLength.Cursor = System.Windows.Forms.Cursors.Default
        Me.optionDefineSlopeLength.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionDefineSlopeLength.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optionDefineSlopeLength.Location = New System.Drawing.Point(6, 67)
        Me.optionDefineSlopeLength.Name = "optionDefineSlopeLength"
        Me.optionDefineSlopeLength.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optionDefineSlopeLength.Size = New System.Drawing.Size(246, 18)
        Me.optionDefineSlopeLength.TabIndex = 3
        Me.optionDefineSlopeLength.TabStop = True
        Me.optionDefineSlopeLength.Text = "Define a Constant Slope Length (m)  (default):"
        Me.optionDefineSlopeLength.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.frameOverland)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(544, 378)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Overland"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'frameOverland
        '
        Me.frameOverland.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.frameOverland.BackColor = System.Drawing.Color.Transparent
        Me.frameOverland.Controls.Add(Me.Label46)
        Me.frameOverland.Controls.Add(Me.txtSedAlphaTc)
        Me.frameOverland.Controls.Add(Me.txtInitialSedimentImperviousLandConstant)
        Me.frameOverland.Controls.Add(Me.Label47)
        Me.frameOverland.Controls.Add(Me.Label48)
        Me.frameOverland.Controls.Add(Me.txtInitialSedimentPerviousLandConstant)
        Me.frameOverland.Controls.Add(Me.txtSedAccumulationRate)
        Me.frameOverland.Controls.Add(Me.Label49)
        Me.frameOverland.Controls.Add(Me.txtSedRoutingCoeffBeta)
        Me.frameOverland.Controls.Add(Me.txtSedCalibCoeffAlpha)
        Me.frameOverland.Controls.Add(Me.txtSedDepletionRate)
        Me.frameOverland.Controls.Add(Me.txtSedYieldCapacity)
        Me.frameOverland.Controls.Add(Me.Label77)
        Me.frameOverland.Controls.Add(Me.Label73)
        Me.frameOverland.Controls.Add(Me.Label50)
        Me.frameOverland.Controls.Add(Me.Label51)
        Me.frameOverland.Controls.Add(Me.Label52)
        Me.frameOverland.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frameOverland.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frameOverland.Location = New System.Drawing.Point(54, 64)
        Me.frameOverland.Name = "frameOverland"
        Me.frameOverland.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frameOverland.Size = New System.Drawing.Size(436, 251)
        Me.frameOverland.TabIndex = 0
        Me.frameOverland.TabStop = False
        Me.frameOverland.Text = "Define Constants for Sediment"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(37, 227)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(154, 14)
        Me.Label46.TabIndex = 15
        Me.Label46.Text = "Routing Coefficient for SDR, β:"
        '
        'txtSedAlphaTc
        '
        Me.txtSedAlphaTc.AcceptsReturn = True
        Me.txtSedAlphaTc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedAlphaTc.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedAlphaTc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedAlphaTc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedAlphaTc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedAlphaTc.Location = New System.Drawing.Point(390, 149)
        Me.txtSedAlphaTc.MaxLength = 0
        Me.txtSedAlphaTc.Name = "txtSedAlphaTc"
        Me.txtSedAlphaTc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedAlphaTc.Size = New System.Drawing.Size(40, 20)
        Me.txtSedAlphaTc.TabIndex = 11
        Me.txtSedAlphaTc.Text = "0.5"
        '
        'txtInitialSedimentImperviousLandConstant
        '
        Me.txtInitialSedimentImperviousLandConstant.AcceptsReturn = True
        Me.txtInitialSedimentImperviousLandConstant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInitialSedimentImperviousLandConstant.BackColor = System.Drawing.SystemColors.Window
        Me.txtInitialSedimentImperviousLandConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInitialSedimentImperviousLandConstant.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitialSedimentImperviousLandConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInitialSedimentImperviousLandConstant.Location = New System.Drawing.Point(390, 49)
        Me.txtInitialSedimentImperviousLandConstant.MaxLength = 0
        Me.txtInitialSedimentImperviousLandConstant.Name = "txtInitialSedimentImperviousLandConstant"
        Me.txtInitialSedimentImperviousLandConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInitialSedimentImperviousLandConstant.Size = New System.Drawing.Size(40, 20)
        Me.txtInitialSedimentImperviousLandConstant.TabIndex = 3
        Me.txtInitialSedimentImperviousLandConstant.Text = "0"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(37, 203)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(168, 14)
        Me.Label47.TabIndex = 13
        Me.Label47.Text = "Calibration Coefficient for SDR, α:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(6, 177)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(396, 14)
        Me.Label48.TabIndex = 12
        Me.Label48.Text = "Sediment Delivery Ratio, SDR = α * exp(-β * Tc), where Tc = Travel Time to Outlet" & _
            ""
        '
        'txtInitialSedimentPerviousLandConstant
        '
        Me.txtInitialSedimentPerviousLandConstant.AcceptsReturn = True
        Me.txtInitialSedimentPerviousLandConstant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInitialSedimentPerviousLandConstant.BackColor = System.Drawing.SystemColors.Window
        Me.txtInitialSedimentPerviousLandConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInitialSedimentPerviousLandConstant.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitialSedimentPerviousLandConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInitialSedimentPerviousLandConstant.Location = New System.Drawing.Point(390, 24)
        Me.txtInitialSedimentPerviousLandConstant.MaxLength = 0
        Me.txtInitialSedimentPerviousLandConstant.Name = "txtInitialSedimentPerviousLandConstant"
        Me.txtInitialSedimentPerviousLandConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInitialSedimentPerviousLandConstant.Size = New System.Drawing.Size(40, 20)
        Me.txtInitialSedimentPerviousLandConstant.TabIndex = 1
        Me.txtInitialSedimentPerviousLandConstant.Text = "0"
        '
        'txtSedAccumulationRate
        '
        Me.txtSedAccumulationRate.AcceptsReturn = True
        Me.txtSedAccumulationRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedAccumulationRate.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedAccumulationRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedAccumulationRate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedAccumulationRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedAccumulationRate.Location = New System.Drawing.Point(390, 74)
        Me.txtSedAccumulationRate.MaxLength = 0
        Me.txtSedAccumulationRate.Name = "txtSedAccumulationRate"
        Me.txtSedAccumulationRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedAccumulationRate.Size = New System.Drawing.Size(40, 20)
        Me.txtSedAccumulationRate.TabIndex = 5
        Me.txtSedAccumulationRate.Text = "0.05"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(6, 152)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(235, 14)
        Me.Label49.TabIndex = 10
        Me.Label49.Text = "Fraction of Daily Rainfall Occurs During Tc, α tc"
        '
        'txtSedRoutingCoeffBeta
        '
        Me.txtSedRoutingCoeffBeta.AcceptsReturn = True
        Me.txtSedRoutingCoeffBeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedRoutingCoeffBeta.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedRoutingCoeffBeta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedRoutingCoeffBeta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedRoutingCoeffBeta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedRoutingCoeffBeta.Location = New System.Drawing.Point(390, 224)
        Me.txtSedRoutingCoeffBeta.MaxLength = 0
        Me.txtSedRoutingCoeffBeta.Name = "txtSedRoutingCoeffBeta"
        Me.txtSedRoutingCoeffBeta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedRoutingCoeffBeta.Size = New System.Drawing.Size(40, 20)
        Me.txtSedRoutingCoeffBeta.TabIndex = 16
        Me.txtSedRoutingCoeffBeta.Text = "0.01"
        '
        'txtSedCalibCoeffAlpha
        '
        Me.txtSedCalibCoeffAlpha.AcceptsReturn = True
        Me.txtSedCalibCoeffAlpha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedCalibCoeffAlpha.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedCalibCoeffAlpha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedCalibCoeffAlpha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedCalibCoeffAlpha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedCalibCoeffAlpha.Location = New System.Drawing.Point(390, 200)
        Me.txtSedCalibCoeffAlpha.MaxLength = 0
        Me.txtSedCalibCoeffAlpha.Name = "txtSedCalibCoeffAlpha"
        Me.txtSedCalibCoeffAlpha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedCalibCoeffAlpha.Size = New System.Drawing.Size(40, 20)
        Me.txtSedCalibCoeffAlpha.TabIndex = 14
        Me.txtSedCalibCoeffAlpha.Text = "1.0"
        '
        'txtSedDepletionRate
        '
        Me.txtSedDepletionRate.AcceptsReturn = True
        Me.txtSedDepletionRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedDepletionRate.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedDepletionRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedDepletionRate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedDepletionRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedDepletionRate.Location = New System.Drawing.Point(390, 99)
        Me.txtSedDepletionRate.MaxLength = 0
        Me.txtSedDepletionRate.Name = "txtSedDepletionRate"
        Me.txtSedDepletionRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedDepletionRate.Size = New System.Drawing.Size(40, 20)
        Me.txtSedDepletionRate.TabIndex = 7
        Me.txtSedDepletionRate.Text = "0.12"
        '
        'txtSedYieldCapacity
        '
        Me.txtSedYieldCapacity.AcceptsReturn = True
        Me.txtSedYieldCapacity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedYieldCapacity.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedYieldCapacity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedYieldCapacity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedYieldCapacity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedYieldCapacity.Location = New System.Drawing.Point(390, 124)
        Me.txtSedYieldCapacity.MaxLength = 0
        Me.txtSedYieldCapacity.Name = "txtSedYieldCapacity"
        Me.txtSedYieldCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedYieldCapacity.Size = New System.Drawing.Size(40, 20)
        Me.txtSedYieldCapacity.TabIndex = 9
        Me.txtSedYieldCapacity.Text = "30"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label77.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label77.Location = New System.Drawing.Point(6, 52)
        Me.Label77.Name = "Label77"
        Me.Label77.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label77.Size = New System.Drawing.Size(220, 14)
        Me.Label77.TabIndex = 2
        Me.Label77.Text = "Initial Sediments on Impervious Land (kg/ha):"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label73.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label73.Location = New System.Drawing.Point(6, 27)
        Me.Label73.Name = "Label73"
        Me.Label73.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label73.Size = New System.Drawing.Size(213, 14)
        Me.Label73.TabIndex = 0
        Me.Label73.Text = "Initial Sediments on Pervious Land (kg/ha) :"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label50.Location = New System.Drawing.Point(6, 77)
        Me.Label50.Name = "Label50"
        Me.Label50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label50.Size = New System.Drawing.Size(311, 14)
        Me.Label50.TabIndex = 4
        Me.Label50.Text = "Sediments Accumulation Rate on Impervious Land (kg/ha/day) :"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label51.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label51.Location = New System.Drawing.Point(6, 127)
        Me.Label51.Name = "Label51"
        Me.Label51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label51.Size = New System.Drawing.Size(187, 14)
        Me.Label51.TabIndex = 8
        Me.Label51.Text = "Sediment Yield Capacity (kg/ha/day) :"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label52.Location = New System.Drawing.Point(6, 102)
        Me.Label52.Name = "Label52"
        Me.Label52.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label52.Size = New System.Drawing.Size(280, 14)
        Me.Label52.TabIndex = 6
        Me.Label52.Text = "Sediments Depletion Rate on Impervious Land (per day) :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(544, 378)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Lake/Reservoir Routing"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtLakeInitialSediment)
        Me.GroupBox1.Controls.Add(Me.txtSedEquilibriumConc)
        Me.GroupBox1.Controls.Add(Me.txtSedDecayConstant)
        Me.GroupBox1.Controls.Add(Me.txtSedPercentClay)
        Me.GroupBox1.Controls.Add(Me.txtSedPercentSilt)
        Me.GroupBox1.Controls.Add(Me.txtSedPercentSand)
        Me.GroupBox1.Controls.Add(Me.Label53)
        Me.GroupBox1.Controls.Add(Me.Label54)
        Me.GroupBox1.Controls.Add(Me.Label55)
        Me.GroupBox1.Controls.Add(Me.Label56)
        Me.GroupBox1.Controls.Add(Me.Label57)
        Me.GroupBox1.Controls.Add(Me.Label58)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(87, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(370, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Define Constants for Sediment"
        '
        'txtLakeInitialSediment
        '
        Me.txtLakeInitialSediment.AcceptsReturn = True
        Me.txtLakeInitialSediment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLakeInitialSediment.BackColor = System.Drawing.SystemColors.Window
        Me.txtLakeInitialSediment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLakeInitialSediment.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLakeInitialSediment.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLakeInitialSediment.Location = New System.Drawing.Point(324, 27)
        Me.txtLakeInitialSediment.MaxLength = 0
        Me.txtLakeInitialSediment.Name = "txtLakeInitialSediment"
        Me.txtLakeInitialSediment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLakeInitialSediment.Size = New System.Drawing.Size(40, 20)
        Me.txtLakeInitialSediment.TabIndex = 1
        Me.txtLakeInitialSediment.Text = "0.5"
        '
        'txtSedEquilibriumConc
        '
        Me.txtSedEquilibriumConc.AcceptsReturn = True
        Me.txtSedEquilibriumConc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedEquilibriumConc.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedEquilibriumConc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedEquilibriumConc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedEquilibriumConc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedEquilibriumConc.Location = New System.Drawing.Point(324, 59)
        Me.txtSedEquilibriumConc.MaxLength = 0
        Me.txtSedEquilibriumConc.Name = "txtSedEquilibriumConc"
        Me.txtSedEquilibriumConc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedEquilibriumConc.Size = New System.Drawing.Size(40, 20)
        Me.txtSedEquilibriumConc.TabIndex = 3
        Me.txtSedEquilibriumConc.Text = "0.4"
        '
        'txtSedDecayConstant
        '
        Me.txtSedDecayConstant.AcceptsReturn = True
        Me.txtSedDecayConstant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedDecayConstant.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedDecayConstant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedDecayConstant.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedDecayConstant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedDecayConstant.Location = New System.Drawing.Point(324, 91)
        Me.txtSedDecayConstant.MaxLength = 0
        Me.txtSedDecayConstant.Name = "txtSedDecayConstant"
        Me.txtSedDecayConstant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedDecayConstant.Size = New System.Drawing.Size(40, 20)
        Me.txtSedDecayConstant.TabIndex = 5
        Me.txtSedDecayConstant.Text = "0.184"
        '
        'txtSedPercentClay
        '
        Me.txtSedPercentClay.AcceptsReturn = True
        Me.txtSedPercentClay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedPercentClay.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedPercentClay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedPercentClay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedPercentClay.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedPercentClay.Location = New System.Drawing.Point(324, 123)
        Me.txtSedPercentClay.MaxLength = 0
        Me.txtSedPercentClay.Name = "txtSedPercentClay"
        Me.txtSedPercentClay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedPercentClay.Size = New System.Drawing.Size(40, 20)
        Me.txtSedPercentClay.TabIndex = 7
        Me.txtSedPercentClay.Text = "0.5"
        '
        'txtSedPercentSilt
        '
        Me.txtSedPercentSilt.AcceptsReturn = True
        Me.txtSedPercentSilt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedPercentSilt.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedPercentSilt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedPercentSilt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedPercentSilt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedPercentSilt.Location = New System.Drawing.Point(324, 155)
        Me.txtSedPercentSilt.MaxLength = 0
        Me.txtSedPercentSilt.Name = "txtSedPercentSilt"
        Me.txtSedPercentSilt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedPercentSilt.Size = New System.Drawing.Size(40, 20)
        Me.txtSedPercentSilt.TabIndex = 9
        Me.txtSedPercentSilt.Text = "0.4"
        '
        'txtSedPercentSand
        '
        Me.txtSedPercentSand.AcceptsReturn = True
        Me.txtSedPercentSand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSedPercentSand.BackColor = System.Drawing.SystemColors.Window
        Me.txtSedPercentSand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSedPercentSand.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSedPercentSand.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSedPercentSand.Location = New System.Drawing.Point(324, 187)
        Me.txtSedPercentSand.MaxLength = 0
        Me.txtSedPercentSand.Name = "txtSedPercentSand"
        Me.txtSedPercentSand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSedPercentSand.Size = New System.Drawing.Size(40, 20)
        Me.txtSedPercentSand.TabIndex = 11
        Me.txtSedPercentSand.Text = "0.1"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label53.Location = New System.Drawing.Point(6, 30)
        Me.Label53.Name = "Label53"
        Me.Label53.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label53.Size = New System.Drawing.Size(283, 14)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Initial Total Suspended Solids (TSS) Concentration (mg/l) :"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label54.Location = New System.Drawing.Point(6, 62)
        Me.Label54.Name = "Label54"
        Me.Label54.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label54.Size = New System.Drawing.Size(306, 14)
        Me.Label54.TabIndex = 2
        Me.Label54.Text = "Equilibrium Concentration of Suspended Solids in Water (mg/l):"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.Location = New System.Drawing.Point(6, 94)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label55.Size = New System.Drawing.Size(213, 14)
        Me.Label55.TabIndex = 4
        Me.Label55.Text = "Solids Decay Constant in Water (per day) :"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label56.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label56.Location = New System.Drawing.Point(6, 126)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label56.Size = New System.Drawing.Size(186, 14)
        Me.Label56.TabIndex = 6
        Me.Label56.Text = "Fraction of Clay in Inflow Sediments :"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label57.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label57.Location = New System.Drawing.Point(6, 158)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label57.Size = New System.Drawing.Size(179, 14)
        Me.Label57.TabIndex = 8
        Me.Label57.Text = "Fraction of Silt in Inflow Sediments :"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label58.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label58.Location = New System.Drawing.Point(6, 190)
        Me.Label58.Name = "Label58"
        Me.Label58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label58.Size = New System.Drawing.Size(190, 14)
        Me.Label58.TabIndex = 10
        Me.Label58.Text = "Fraction of Sand in Inflow Sediments :"
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.SystemColors.Info
        Me.Label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label59.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label59.Location = New System.Drawing.Point(3, 3)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(552, 51)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = resources.GetString("Label59.Text")
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabSimulate
        '
        Me.tabSimulate.Controls.Add(Me.TableLayoutPanel4)
        Me.tabSimulate.Location = New System.Drawing.Point(4, 25)
        Me.tabSimulate.Name = "tabSimulate"
        Me.tabSimulate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSimulate.Size = New System.Drawing.Size(558, 462)
        Me.tabSimulate.TabIndex = 4
        Me.tabSimulate.Text = "Simulate"
        Me.tabSimulate.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label103, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TabControl3, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel6, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(552, 456)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label103
        '
        Me.Label103.BackColor = System.Drawing.SystemColors.Info
        Me.Label103.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label103.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label103.Location = New System.Drawing.Point(3, 0)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(546, 54)
        Me.Label103.TabIndex = 0
        Me.Label103.Text = "This tab is used to set the final simulation options and run the stand-alone GBMM" & _
            " C++ computational program. Here specify the simulation options and desired time" & _
            " ranges."
        Me.Label103.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage7)
        Me.TabControl3.Controls.Add(Me.TabPage8)
        Me.TabControl3.Controls.Add(Me.TabPage9)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(3, 57)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(546, 360)
        Me.TabControl3.TabIndex = 1
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.btnViewFile)
        Me.TabPage7.Controls.Add(Me.Panel3)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(538, 334)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "General Options"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.AutoSize = True
        Me.Panel3.Controls.Add(Me.GroupBox6)
        Me.Panel3.Controls.Add(Me.fraWhAEM)
        Me.Panel3.Controls.Add(Me.Frame5)
        Me.Panel3.Controls.Add(Me.Frame6)
        Me.Panel3.Location = New System.Drawing.Point(101, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(336, 252)
        Me.Panel3.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkAddLayers)
        Me.GroupBox6.Controls.Add(Me.chkForceRebuild)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(7, 171)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(326, 74)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "File Build Options"
        '
        'fraWhAEM
        '
        Me.fraWhAEM.BackColor = System.Drawing.Color.Transparent
        Me.fraWhAEM.Controls.Add(Me.txtWhAEMDuration)
        Me.fraWhAEM.Controls.Add(Me.whaemLabel)
        Me.fraWhAEM.Enabled = False
        Me.fraWhAEM.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraWhAEM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraWhAEM.Location = New System.Drawing.Point(7, 115)
        Me.fraWhAEM.Name = "fraWhAEM"
        Me.fraWhAEM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraWhAEM.Size = New System.Drawing.Size(326, 49)
        Me.fraWhAEM.TabIndex = 2
        Me.fraWhAEM.TabStop = False
        Me.fraWhAEM.Text = "WhAEM Link"
        '
        'txtWhAEMDuration
        '
        Me.txtWhAEMDuration.AcceptsReturn = True
        Me.txtWhAEMDuration.BackColor = System.Drawing.SystemColors.Window
        Me.txtWhAEMDuration.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWhAEMDuration.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhAEMDuration.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWhAEMDuration.Location = New System.Drawing.Point(267, 19)
        Me.txtWhAEMDuration.MaxLength = 0
        Me.txtWhAEMDuration.Name = "txtWhAEMDuration"
        Me.txtWhAEMDuration.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWhAEMDuration.Size = New System.Drawing.Size(49, 20)
        Me.txtWhAEMDuration.TabIndex = 1
        Me.txtWhAEMDuration.Text = "1"
        '
        'whaemLabel
        '
        Me.whaemLabel.AutoSize = True
        Me.whaemLabel.BackColor = System.Drawing.Color.Transparent
        Me.whaemLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.whaemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.whaemLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.whaemLabel.Location = New System.Drawing.Point(8, 22)
        Me.whaemLabel.Name = "whaemLabel"
        Me.whaemLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.whaemLabel.Size = New System.Drawing.Size(253, 13)
        Me.whaemLabel.TabIndex = 0
        Me.whaemLabel.Text = "Average Duration for Groundwater Recharge (days):"
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.Transparent
        Me.Frame5.Controls.Add(Me.chkMercury)
        Me.Frame5.Controls.Add(Me.chkSediment)
        Me.Frame5.Controls.Add(Me.chkHydro)
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(7, 3)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(326, 48)
        Me.Frame5.TabIndex = 0
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "Simulation"
        '
        'chkMercury
        '
        Me.chkMercury.AutoSize = True
        Me.chkMercury.BackColor = System.Drawing.Color.Transparent
        Me.chkMercury.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMercury.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMercury.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMercury.Location = New System.Drawing.Point(239, 20)
        Me.chkMercury.Name = "chkMercury"
        Me.chkMercury.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMercury.Size = New System.Drawing.Size(66, 18)
        Me.chkMercury.TabIndex = 2
        Me.chkMercury.Text = "Mercury"
        Me.chkMercury.UseVisualStyleBackColor = False
        '
        'chkSediment
        '
        Me.chkSediment.AutoSize = True
        Me.chkSediment.BackColor = System.Drawing.Color.Transparent
        Me.chkSediment.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSediment.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSediment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSediment.Location = New System.Drawing.Point(131, 20)
        Me.chkSediment.Name = "chkSediment"
        Me.chkSediment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSediment.Size = New System.Drawing.Size(70, 18)
        Me.chkSediment.TabIndex = 1
        Me.chkSediment.Text = "Sediment"
        Me.chkSediment.UseVisualStyleBackColor = False
        '
        'chkHydro
        '
        Me.chkHydro.AutoSize = True
        Me.chkHydro.BackColor = System.Drawing.Color.Transparent
        Me.chkHydro.Checked = True
        Me.chkHydro.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHydro.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkHydro.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHydro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkHydro.Location = New System.Drawing.Point(18, 20)
        Me.chkHydro.Name = "chkHydro"
        Me.chkHydro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHydro.Size = New System.Drawing.Size(75, 18)
        Me.chkHydro.TabIndex = 0
        Me.chkHydro.Text = "Hydrology"
        Me.chkHydro.UseVisualStyleBackColor = False
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.Transparent
        Me.Frame6.Controls.Add(Me.chkWASP)
        Me.Frame6.Controls.Add(Me.chkWhAEM)
        Me.Frame6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(7, 59)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(326, 50)
        Me.Frame6.TabIndex = 1
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "Model Linkage Options"
        '
        'chkWASP
        '
        Me.chkWASP.AutoSize = True
        Me.chkWASP.BackColor = System.Drawing.Color.Transparent
        Me.chkWASP.Checked = True
        Me.chkWASP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWASP.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkWASP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWASP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkWASP.Location = New System.Drawing.Point(45, 22)
        Me.chkWASP.Name = "chkWASP"
        Me.chkWASP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkWASP.Size = New System.Drawing.Size(97, 18)
        Me.chkWASP.TabIndex = 0
        Me.chkWASP.Text = "WASP Linkage"
        Me.chkWASP.UseVisualStyleBackColor = False
        '
        'chkWhAEM
        '
        Me.chkWhAEM.AutoSize = True
        Me.chkWhAEM.BackColor = System.Drawing.Color.Transparent
        Me.chkWhAEM.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkWhAEM.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWhAEM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkWhAEM.Location = New System.Drawing.Point(173, 22)
        Me.chkWhAEM.Name = "chkWhAEM"
        Me.chkWhAEM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkWhAEM.Size = New System.Drawing.Size(104, 18)
        Me.chkWhAEM.TabIndex = 1
        Me.chkWhAEM.Text = "WhAEM Linkage"
        Me.chkWhAEM.UseVisualStyleBackColor = False
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.Panel4)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(538, 334)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "Simulation Time"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Controls.Add(Me.fraSimulationTimeFrame)
        Me.Panel4.Controls.Add(Me.GroupBox5)
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Location = New System.Drawing.Point(60, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(419, 253)
        Me.Panel4.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtTimeStep)
        Me.GroupBox3.Controls.Add(Me.Label93)
        Me.GroupBox3.Controls.Add(Me.Label94)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(3, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(413, 50)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Time Step"
        '
        'txtTimeStep
        '
        Me.txtTimeStep.AcceptsReturn = True
        Me.txtTimeStep.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimeStep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTimeStep.Enabled = False
        Me.txtTimeStep.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeStep.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTimeStep.Location = New System.Drawing.Point(230, 19)
        Me.txtTimeStep.MaxLength = 0
        Me.txtTimeStep.Name = "txtTimeStep"
        Me.txtTimeStep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTimeStep.Size = New System.Drawing.Size(33, 20)
        Me.txtTimeStep.TabIndex = 1
        Me.txtTimeStep.Text = "1"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.BackColor = System.Drawing.Color.Transparent
        Me.Label93.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label93.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label93.Location = New System.Drawing.Point(269, 22)
        Me.Label93.Name = "Label93"
        Me.Label93.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label93.Size = New System.Drawing.Size(32, 14)
        Me.Label93.TabIndex = 2
        Me.Label93.Text = "Days"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label94.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label94.Location = New System.Drawing.Point(105, 22)
        Me.Label94.Name = "Label94"
        Me.Label94.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label94.Size = New System.Drawing.Size(108, 14)
        Me.Label94.TabIndex = 0
        Me.Label94.Text = "Simulation Time Step:"
        '
        'fraSimulationTimeFrame
        '
        Me.fraSimulationTimeFrame.BackColor = System.Drawing.Color.Transparent
        Me.fraSimulationTimeFrame.Controls.Add(Me.dtEndSim)
        Me.fraSimulationTimeFrame.Controls.Add(Me.Label13)
        Me.fraSimulationTimeFrame.Controls.Add(Me.dtStartSim)
        Me.fraSimulationTimeFrame.Controls.Add(Me.Label14)
        Me.fraSimulationTimeFrame.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSimulationTimeFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSimulationTimeFrame.Location = New System.Drawing.Point(3, 4)
        Me.fraSimulationTimeFrame.Name = "fraSimulationTimeFrame"
        Me.fraSimulationTimeFrame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSimulationTimeFrame.Size = New System.Drawing.Size(413, 49)
        Me.fraSimulationTimeFrame.TabIndex = 0
        Me.fraSimulationTimeFrame.TabStop = False
        Me.fraSimulationTimeFrame.Text = "Define Simulation Time Period"
        '
        'dtEndSim
        '
        Me.dtEndSim.CustomFormat = "MM/dd/yyyy"
        Me.dtEndSim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEndSim.Location = New System.Drawing.Point(286, 20)
        Me.dtEndSim.Name = "dtEndSim"
        Me.dtEndSim.Size = New System.Drawing.Size(117, 20)
        Me.dtEndSim.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(227, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "End Date: "
        '
        'dtStartSim
        '
        Me.dtStartSim.CustomFormat = "MM/dd/yyyy"
        Me.dtStartSim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStartSim.Location = New System.Drawing.Point(72, 20)
        Me.dtStartSim.Name = "dtStartSim"
        Me.dtStartSim.Size = New System.Drawing.Size(117, 20)
        Me.dtStartSim.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(8, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Start Date:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.dtEndClimate)
        Me.GroupBox5.Controls.Add(Me.dtStartClimate)
        Me.GroupBox5.Controls.Add(Me.Label99)
        Me.GroupBox5.Controls.Add(Me.Label100)
        Me.GroupBox5.Controls.Add(Me.lblDateRange)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(3, 59)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox5.Size = New System.Drawing.Size(413, 80)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select Climate Data Time Period to be used for Simulation"
        '
        'dtEndClimate
        '
        Me.dtEndClimate.CustomFormat = "MM/dd/yyyy"
        Me.dtEndClimate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEndClimate.Location = New System.Drawing.Point(286, 48)
        Me.dtEndClimate.Name = "dtEndClimate"
        Me.dtEndClimate.Size = New System.Drawing.Size(117, 20)
        Me.dtEndClimate.TabIndex = 4
        '
        'dtStartClimate
        '
        Me.dtStartClimate.CustomFormat = "MM/dd/yyyy"
        Me.dtStartClimate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStartClimate.Location = New System.Drawing.Point(72, 48)
        Me.dtStartClimate.Name = "dtStartClimate"
        Me.dtStartClimate.Size = New System.Drawing.Size(117, 20)
        Me.dtStartClimate.TabIndex = 2
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.Color.Transparent
        Me.Label99.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label99.Location = New System.Drawing.Point(227, 51)
        Me.Label99.Name = "Label99"
        Me.Label99.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label99.Size = New System.Drawing.Size(55, 13)
        Me.Label99.TabIndex = 3
        Me.Label99.Text = "End Date:"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.BackColor = System.Drawing.Color.Transparent
        Me.Label100.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label100.Location = New System.Drawing.Point(8, 51)
        Me.Label100.Name = "Label100"
        Me.Label100.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label100.Size = New System.Drawing.Size(58, 13)
        Me.Label100.TabIndex = 1
        Me.Label100.Text = "Start Date:"
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDateRange
        '
        Me.lblDateRange.AutoSize = True
        Me.lblDateRange.BackColor = System.Drawing.Color.Transparent
        Me.lblDateRange.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDateRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDateRange.Location = New System.Drawing.Point(8, 23)
        Me.lblDateRange.Name = "lblDateRange"
        Me.lblDateRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDateRange.Size = New System.Drawing.Size(122, 13)
        Me.lblDateRange.TabIndex = 0
        Me.lblDateRange.Text = "Available Climate Data: ("
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cboStartMonth)
        Me.GroupBox4.Controls.Add(Me.cboEndMonth)
        Me.GroupBox4.Controls.Add(Me.Label97)
        Me.GroupBox4.Controls.Add(Me.Label98)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(3, 145)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(413, 49)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Define Growing Season"
        '
        'cboStartMonth
        '
        Me.cboStartMonth.BackColor = System.Drawing.SystemColors.Window
        Me.cboStartMonth.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboStartMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStartMonth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStartMonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboStartMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboStartMonth.Location = New System.Drawing.Point(94, 19)
        Me.cboStartMonth.Name = "cboStartMonth"
        Me.cboStartMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboStartMonth.Size = New System.Drawing.Size(47, 22)
        Me.cboStartMonth.TabIndex = 1
        '
        'cboEndMonth
        '
        Me.cboEndMonth.BackColor = System.Drawing.SystemColors.Window
        Me.cboEndMonth.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEndMonth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEndMonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEndMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboEndMonth.Location = New System.Drawing.Point(312, 19)
        Me.cboEndMonth.Name = "cboEndMonth"
        Me.cboEndMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboEndMonth.Size = New System.Drawing.Size(47, 22)
        Me.cboEndMonth.TabIndex = 3
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.BackColor = System.Drawing.Color.Transparent
        Me.Label97.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label97.Location = New System.Drawing.Point(227, 23)
        Me.Label97.Name = "Label97"
        Me.Label97.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label97.Size = New System.Drawing.Size(62, 13)
        Me.Label97.TabIndex = 2
        Me.Label97.Text = "End Month:"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.Color.Transparent
        Me.Label98.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label98.Location = New System.Drawing.Point(11, 23)
        Me.Label98.Name = "Label98"
        Me.Label98.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label98.Size = New System.Drawing.Size(65, 13)
        Me.Label98.TabIndex = 0
        Me.Label98.Text = "Start Month:"
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.Panel5)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(538, 334)
        Me.TabPage9.TabIndex = 2
        Me.TabPage9.Text = "Mercury Time Series"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.Controls.Add(Me.fraDryHg)
        Me.Panel5.Controls.Add(Me.fraWetHg)
        Me.Panel5.Location = New System.Drawing.Point(53, 61)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(433, 212)
        Me.Panel5.TabIndex = 0
        '
        'fraDryHg
        '
        Me.fraDryHg.BackColor = System.Drawing.Color.Transparent
        Me.fraDryHg.Controls.Add(Me.dtEndDry)
        Me.fraDryHg.Controls.Add(Me.dtStartDry)
        Me.fraDryHg.Controls.Add(Me.lblDateRange2)
        Me.fraDryHg.Controls.Add(Me.Label104)
        Me.fraDryHg.Controls.Add(Me.Label105)
        Me.fraDryHg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraDryHg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraDryHg.Location = New System.Drawing.Point(3, 3)
        Me.fraDryHg.Name = "fraDryHg"
        Me.fraDryHg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDryHg.Size = New System.Drawing.Size(425, 81)
        Me.fraDryHg.TabIndex = 0
        Me.fraDryHg.TabStop = False
        Me.fraDryHg.Text = "Select Dry Hg Deposition Data Time Period to be used for Simulation"
        '
        'dtEndDry
        '
        Me.dtEndDry.CustomFormat = "MM/dd/yyyy"
        Me.dtEndDry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEndDry.Location = New System.Drawing.Point(294, 52)
        Me.dtEndDry.Name = "dtEndDry"
        Me.dtEndDry.Size = New System.Drawing.Size(117, 20)
        Me.dtEndDry.TabIndex = 4
        '
        'dtStartDry
        '
        Me.dtStartDry.CustomFormat = "MM/dd/yyyy"
        Me.dtStartDry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStartDry.Location = New System.Drawing.Point(80, 52)
        Me.dtStartDry.Name = "dtStartDry"
        Me.dtStartDry.Size = New System.Drawing.Size(117, 20)
        Me.dtStartDry.TabIndex = 2
        '
        'lblDateRange2
        '
        Me.lblDateRange2.AutoSize = True
        Me.lblDateRange2.BackColor = System.Drawing.Color.Transparent
        Me.lblDateRange2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDateRange2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRange2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDateRange2.Location = New System.Drawing.Point(16, 24)
        Me.lblDateRange2.Name = "lblDateRange2"
        Me.lblDateRange2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDateRange2.Size = New System.Drawing.Size(152, 13)
        Me.lblDateRange2.TabIndex = 0
        Me.lblDateRange2.Text = "Available Hg Deposition Data: "
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.BackColor = System.Drawing.Color.Transparent
        Me.Label104.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label104.Location = New System.Drawing.Point(232, 56)
        Me.Label104.Name = "Label104"
        Me.Label104.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label104.Size = New System.Drawing.Size(55, 13)
        Me.Label104.TabIndex = 3
        Me.Label104.Text = "End Date:"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.BackColor = System.Drawing.Color.Transparent
        Me.Label105.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label105.Location = New System.Drawing.Point(16, 56)
        Me.Label105.Name = "Label105"
        Me.Label105.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label105.Size = New System.Drawing.Size(58, 13)
        Me.Label105.TabIndex = 1
        Me.Label105.Text = "Start Date:"
        Me.Label105.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fraWetHg
        '
        Me.fraWetHg.BackColor = System.Drawing.Color.Transparent
        Me.fraWetHg.Controls.Add(Me.dtEndWet)
        Me.fraWetHg.Controls.Add(Me.dtStartWet)
        Me.fraWetHg.Controls.Add(Me.lblDateRange3)
        Me.fraWetHg.Controls.Add(Me.Label106)
        Me.fraWetHg.Controls.Add(Me.Label108)
        Me.fraWetHg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraWetHg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraWetHg.Location = New System.Drawing.Point(3, 123)
        Me.fraWetHg.Name = "fraWetHg"
        Me.fraWetHg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraWetHg.Size = New System.Drawing.Size(425, 81)
        Me.fraWetHg.TabIndex = 1
        Me.fraWetHg.TabStop = False
        Me.fraWetHg.Text = "Select Wet Hg Deposition Data Time Period to be used for Simulation"
        '
        'dtEndWet
        '
        Me.dtEndWet.CustomFormat = "MM/dd/yyyy"
        Me.dtEndWet.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEndWet.Location = New System.Drawing.Point(294, 52)
        Me.dtEndWet.Name = "dtEndWet"
        Me.dtEndWet.Size = New System.Drawing.Size(117, 20)
        Me.dtEndWet.TabIndex = 4
        '
        'dtStartWet
        '
        Me.dtStartWet.CustomFormat = "MM/dd/yyyy"
        Me.dtStartWet.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStartWet.Location = New System.Drawing.Point(80, 52)
        Me.dtStartWet.Name = "dtStartWet"
        Me.dtStartWet.Size = New System.Drawing.Size(117, 20)
        Me.dtStartWet.TabIndex = 2
        '
        'lblDateRange3
        '
        Me.lblDateRange3.AutoSize = True
        Me.lblDateRange3.BackColor = System.Drawing.Color.Transparent
        Me.lblDateRange3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDateRange3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRange3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDateRange3.Location = New System.Drawing.Point(16, 24)
        Me.lblDateRange3.Name = "lblDateRange3"
        Me.lblDateRange3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDateRange3.Size = New System.Drawing.Size(152, 13)
        Me.lblDateRange3.TabIndex = 0
        Me.lblDateRange3.Text = "Available Hg Deposition Data: "
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.BackColor = System.Drawing.Color.Transparent
        Me.Label106.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label106.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label106.Location = New System.Drawing.Point(232, 55)
        Me.Label106.Name = "Label106"
        Me.Label106.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label106.Size = New System.Drawing.Size(55, 13)
        Me.Label106.TabIndex = 3
        Me.Label106.Text = "End Date:"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.BackColor = System.Drawing.Color.Transparent
        Me.Label108.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label108.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label108.Location = New System.Drawing.Point(16, 55)
        Me.Label108.Name = "Label108"
        Me.Label108.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label108.Size = New System.Drawing.Size(58, 13)
        Me.Label108.TabIndex = 1
        Me.Label108.Text = "Start Date:"
        Me.Label108.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.lblSimulate)
        Me.Panel6.Controls.Add(Me.btnSimulate)
        Me.Panel6.Location = New System.Drawing.Point(3, 423)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(546, 30)
        Me.Panel6.TabIndex = 2
        '
        'lblSimulate
        '
        Me.lblSimulate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSimulate.AutoSize = True
        Me.lblSimulate.ForeColor = System.Drawing.Color.Red
        Me.lblSimulate.Location = New System.Drawing.Point(3, 8)
        Me.lblSimulate.Name = "lblSimulate"
        Me.lblSimulate.Size = New System.Drawing.Size(268, 13)
        Me.lblSimulate.TabIndex = 0
        Me.lblSimulate.Text = "When GBMM simulation is complete, click Results tab..."
        Me.lblSimulate.Visible = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmMercury
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(593, 559)
        Me.Controls.Add(Me.btnSaveAs)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(601, 593)
        Me.Name = "frmMercury"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "BASINS Grid-Based Mercury Model (GBMM)"
        Me.tabResults.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.splitResults.Panel1.ResumeLayout(False)
        Me.splitResults.Panel2.ResumeLayout(False)
        Me.splitResults.ResumeLayout(False)
        Me.tabResult.ResumeLayout(False)
        Me.TabPage14.ResumeLayout(False)
        Me.TabPage15.ResumeLayout(False)
        Me.mnuVariables.ResumeLayout(False)
        Me.tabMercury.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.MercuryLand.ResumeLayout(False)
        Me.MercuryLand.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.Frame10.ResumeLayout(False)
        Me.Frame10.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.MercuryWater.ResumeLayout(False)
        Me.MercuryWater.PerformLayout()
        Me._SSTab1_TabPage4.ResumeLayout(False)
        Me.Frame11.ResumeLayout(False)
        Me.Frame11.PerformLayout()
        Me.tabHydrology.ResumeLayout(False)
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me.framehydro.ResumeLayout(False)
        Me.framehydro.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me._SSTab1_TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.fraGroundWater.ResumeLayout(False)
        Me.fraGroundWater.PerformLayout()
        Me._SSTab1_TabPage2.ResumeLayout(False)
        Me.FrameStreamParam.ResumeLayout(False)
        Me.FrameStreamParam.PerformLayout()
        CType(Me.PictureChannel, System.ComponentModel.ISupportInitialize).EndInit()
        Me._SSTab1_TabPage3.ResumeLayout(False)
        Me.LakeAttributes.ResumeLayout(False)
        Me.LakeAttributes.PerformLayout()
        Me.tabGeneral.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TabPage12.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TabPage13.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tabSediment.ResumeLayout(False)
        Me.subtabSediment.ResumeLayout(False)
        Me.tabSlopeLength.ResumeLayout(False)
        Me.fraSlopeLength.ResumeLayout(False)
        Me.fraSlopeLength.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.frameOverland.ResumeLayout(False)
        Me.frameOverland.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabSimulate.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.fraWhAEM.ResumeLayout(False)
        Me.fraWhAEM.PerformLayout()
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.Frame6.ResumeLayout(False)
        Me.Frame6.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.fraSimulationTimeFrame.ResumeLayout(False)
        Me.fraSimulationTimeFrame.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.fraDryHg.ResumeLayout(False)
        Me.fraDryHg.PerformLayout()
        Me.fraWetHg.ResumeLayout(False)
        Me.fraWetHg.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Dim gInitializing As Boolean
    Dim gLanduseType As Integer
    Dim gMethod As Integer

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Logger.Dbg("UserCanceled")
        Me.Close()
    End Sub

    ''' <summary>
    ''' Copy report output in HTML format to clipboard
    ''' </summary>
    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        If tabResult.SelectedIndex = 0 Then
            Zed.Copy(False)
        Else
            Dim Header As String = String.Format("Version:1.0{0}StartHTML:0000000105{0}EndHTML:{1,10:0}{0}StartFragment:0000000105{0}EndFragment:{1,10:0}{0}", vbCrLf, wbResults.DocumentText.Length + 105)
            Clipboard.SetDataObject(New DataObject(DataFormats.Html, Header & wbResults.DocumentText))
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Dim HelpFile As String = Project.Folders.AppFolder & "\GBMM2_UserGuide.pdf"
        If My.Computer.FileSystem.FileExists(HelpFile) Then
            Process.Start(HelpFile)
        Else
            WarningMsg("Unable to find help file: " & HelpFile)
        End If
    End Sub

    Private Sub btnSimulate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSimulate.Click
        Try
            SaveForm()

            If Not ValidateData() Then Exit Sub

            wbResults.DocumentText = ""

            EnableControls(False)

            ProgressForm = New frmProgress

            With ProgressForm
                .Show(Me)

                If Not SetupMercuryModel() Then Exit Sub

                .Close()
                .Dispose()
                ProgressForm = Nothing
            End With

            With Project

                If .FileName = "" Then btnSaveAs.PerformClick()
                If .FileName = "" Then Return
                If Not .Save Then Exit Sub
                With gMapWin.Project
                    .Save(.FileName)
                End With

                Dim exe As String = .Folders.AppFolder & "\GBMM.exe"

                If Not My.Computer.FileSystem.FileExists(exe) Then
                    WarningMsg("Unable to find GBMM executable: " & exe & vbCr & vbCr & "You may need to reinstall the application.")
                    Exit Sub
                End If

                'delete output folder contents so GBMM doesn't prompt you
                If GisUtil.IsLayer("SoilMercury") Then GisUtil.RemoveLayer(GisUtil.LayerIndex("SoilMercury"))
                If GisUtil.IsLayer("SoilWater") Then GisUtil.RemoveLayer(GisUtil.LayerIndex("SoilWater"))
                If My.Computer.FileSystem.DirectoryExists(.Folders.OutputFolder) Then My.Computer.FileSystem.DeleteDirectory(.Folders.OutputFolder, FileIO.DeleteDirectoryOption.DeleteAllContents)

                lblSimulate.Visible = True

                Shell(String.Format("{0} ""{1}""", exe, .FileName), AppWinStyle.NormalFocus, False)

            End With

        Catch ex As Exception
            ErrorMsg(, ex)
        Finally
            If ProgressForm IsNot Nothing Then
                ProgressForm.Close()
                ProgressForm.Dispose()
                ProgressForm = Nothing
            End If
            EnableControls(True)
        End Try
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        With New OpenFileDialog
            .AddExtension = True
            .CheckFileExists = True
            .CheckPathExists = True
            .DefaultExt = ".inp"
            .Filter = "GBMM input files (*.inp)|*.inp"
            .FilterIndex = 0
            .InitialDirectory = Project.Folders.InputFolder
            If Not My.Computer.FileSystem.DirectoryExists(.InitialDirectory) Then My.Computer.FileSystem.CreateDirectory(.InitialDirectory)
            .Title = "Open GBMM File"
            Dim merfiles As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetFiles(Project.Folders.InputFolder, FileIO.SearchOption.SearchTopLevelOnly, "*.inp")
            If merfiles.Count > 0 Then .FileName = merfiles(0)
            If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Project.FileName = .FileName
                If Project.Load() Then
                    LoadForm()
                    wbResults.DocumentText = ""
                End If
            End If
            .Dispose()
        End With
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If tabResult.SelectedIndex = 0 Then
            Zed.DoPrintPreview()
        Else
            wbResults.ShowPrintPreviewDialog()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If tabResult.SelectedIndex = 0 Then
            Zed.DoPrint()
        Else
            wbResults.ShowPrintDialog()
        End If
    End Sub

    Private Sub btnSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAs.Click
        SaveForm()
        With New SaveFileDialog
            .AddExtension = True
            .CheckFileExists = False
            .CheckPathExists = True
            .DefaultExt = ".inp"
            .Filter = "GBMM input files (*.inp)|*.inp"
            .FilterIndex = 0
            .InitialDirectory = Project.Folders.InputFolder
            If Not My.Computer.FileSystem.DirectoryExists(.InitialDirectory) Then My.Computer.FileSystem.CreateDirectory(.InitialDirectory)
            .Title = "Save GBMM File"
            .FileName = Project.FileName
            If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If Not String.Equals(IO.Path.GetDirectoryName(.FileName), Project.Folders.InputFolder, StringComparison.OrdinalIgnoreCase) Then
                    WarningMsg("The GBMM input file must reside in the same directory specified as the Input Data Folder.")
                Else
                    Project.FileName = .FileName
                    Project.Save()
                    Text = "BASINS Grid-Based Mercury Model - " & IO.Path.GetFileName(.FileName)
                End If
            End If
            .Dispose()
        End With
    End Sub

    Private Sub cboBMPIDField_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSubbasinLayer.SelectionChangeCommitted
        Project.Modified = True
        wbResults.DocumentText = ""
    End Sub

    Private Sub cboLanduseType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLanduseType.SelectedIndexChanged
        cboLandUseLayer.Enabled = True
        lblLandUseLayer.Enabled = True
        cboLandUseField.Enabled = False
        lnkLanduseLayer.Enabled = False
        cboLandUseLayer.Items.Clear()
        For lLyr As Integer = 0 To GisUtil.NumLayers() - 1
            Dim lt As MapWindow.Interfaces.eLayerType = GisUtil.LayerType(lLyr)
            If cboLanduseType.Text.StartsWith("USGS GIRAS") Then
                cboLandUseLayer.Enabled = False
                lblLandUseLayer.Enabled = False
            ElseIf cboLanduseType.Text = "User Shapefile" Then
                Project.Layers.Landuse.LayerType = enumLayerType.Polygon
                cboLandUseField.Enabled = True
                lnkLanduseLayer.Enabled = True
            ElseIf cboLanduseType.Text.StartsWith("NLCD") Then
                Project.Layers.Landuse.LayerType = enumLayerType.Grid
                cboLandUseField.Enabled = False
                lnkLanduseLayer.Enabled = False
            Else
                Project.Layers.Landuse.LayerType = enumLayerType.Grid
                cboLandUseField.Enabled = False
                lnkLanduseLayer.Enabled = False
            End If
        Next
        FillCombo(cboLandUseLayer)
        If cboLandUseLayer.Items.Count > 0 Then cboLandUseLayer.SelectedIndex = 0
        Project.LanduseType = cboLanduseType.SelectedIndex
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        With New frmAbout
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub EnableControls(ByVal b As Boolean)
        btnSimulate.Enabled = b
        btnHelp.Enabled = b
        btnCancel.Enabled = b
        btnAbout.Enabled = b
        tabMain.Enabled = b
        btnOpen.Enabled = b
        btnSaveAs.Enabled = b
        btnReset.Enabled = b
    End Sub

    Private Sub frmMercury_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MercuryForm = Nothing
        gMapWin.StatusBar(2).Text = ""
        SaveWindowPos(REGAPP, Me)
        Dispose()
    End Sub

    Private Sub frmMercury_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        With Project
            If .Modified Then
                If .FileName = "" Then
                    btnSaveAs.PerformClick()
                    'e.Cancel = .FileName = ""
                Else
                    Select Case MessageBox.Show(String.Format("Save changes to {0}?", .FileName), "File Has Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                        Case Windows.Forms.DialogResult.Yes : SaveForm() : e.Cancel = Not Project.Save
                        Case Windows.Forms.DialogResult.No : e.Cancel = False
                        Case Windows.Forms.DialogResult.Cancel : e.Cancel = True
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub frmMercury_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetWindowPos(REGAPP, Me)

        Project = New clsProject

        'set up eventhandlers
        For Each cntl As Control In GetControlList(Me)
            If TypeOf cntl Is LinkLabel Then
                Dim lnk As LinkLabel = cntl
                If lnk.Name.EndsWith("Table") Or lnk.Name.EndsWith("Layer") Then
                    AddHandler lnk.LinkClicked, AddressOf lnk_LinkClicked
                End If
            ElseIf TypeOf cntl Is ComboBox Then
                Dim cboAny As ComboBox = cntl
                FillCombo(cboAny)
                AddHandler cboAny.DropDown, AddressOf cbo_DropDown

                AddHandler cboAny.SelectionChangeCommitted, AddressOf cbo_SelectionChangeCommitted

                If cntl.Name.EndsWith("Field") Then
                    Dim cbo As ComboBox = FindControl(Me, cntl.Name.Replace("Field", "Layer"))
                    If cbo IsNot Nothing Then
                        AddHandler cbo.SelectedIndexChanged, AddressOf cboLayer_SelectedIndexChanged
                    Else
                        Debug.Assert(False)
                    End If
                End If
            ElseIf TypeOf cntl Is TextBox Then
                If Not cntl.Name.EndsWith("Name") Then AddHandler cntl.Validating, AddressOf txt_Validating
                AddHandler cntl.KeyPress, AddressOf txt_KeyPress
            ElseIf TypeOf cntl Is CheckBox Then
                AddHandler cntl.Click, AddressOf chk_Click
            End If
        Next

        With cboLanduseType
            .Items.Clear()
            .Items.AddRange(New String() {"USGS GIRAS Shapefiles", "NLCD 1992 Grid", "NLCD 2001 Grid", "User Shapefile", "User Grid"})
            '.SelectedIndex = 0
        End With

        cboRegions.Items.AddRange(Project.StreamParms.RegionArray)

        For i As Integer = 1 To 2
            With CType(Choose(i, cboHgDryDepTS, cboHgWetDepTS), ComboBox)
                .Items.Clear()
                .Items.Add("Daily")
                .Items.Add("Monthly")
            End With
        Next

        LoadForm() 'with defaults

        With Project
            'assign reasonable defaults
            For i As Integer = 1 To 23
                Dim cbo As ComboBox = Choose(i, cboClimateStaLayer, cboDEMLayer, cboLakeLayer, cboLandUseLayer, cboHgStationsLayer, cboPointSourceLayer, cboSoilLayer, cboStreamLayer, cboSubbasinLayer, cboInitialSoilMoisture, cboInitialSoilHg, cboHgDryDepositionFlux, cboHgWetDepositionFlux, cboClimateDataTable, cboFlowRelationTable, cboHgDryDepTable, cboHgWetDepTable, cboLanduseTable, cboLanduseCNTable, cboSoilTable, cboPointSourceTable, cboFlowDirLayer, cboFlowAccLayer)
                Dim search As String = Choose(i, "climate", "elevation", "waterbody", "land", "mercury", "<", "soil", "flowline", "subbasin", "water", "mercury", "dry", "wet", "climate", "relation", "dry", "wet", "lulookup", "cn", "soil", "point", "direction", "accum")
                For Each s As String In cbo.Items
                    If s.ToLower.Contains(search) Then cbo.Text = s : Exit For
                Next
            Next

            Dim merfiles As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetFiles(Project.Folders.InputFolder, FileIO.SearchOption.SearchTopLevelOnly, "*.inp")
            Select Case merfiles.Count
                Case 0
                Case 1
                    Project.FileName = merfiles(0)
                    If Project.Load() Then
                        'LoadData(merfiles(0))
                        LoadForm()
                        wbResults.DocumentText = ""
                    End If
                Case Else
                    btnOpen.PerformClick()
            End Select
        End With
        MercuryForm = Me
    End Sub

    ''' <summary>
    ''' Move data from Project structure into form fields
    ''' </summary>
    Private Sub LoadForm()
        Try
            With Project
                Text = "BASINS Grid-Based Mercury Model (GBMM)"
                If .FileName <> "" Then Text &= " - " & IO.Path.GetFileName(.FileName)
                With .Folders
                    txtInputName.Text = .InputFolder
                    txtOutputName.Text = .OutputFolder
                End With

                cboLanduseType.SelectedIndex = .LanduseType

                With .Layers
                    If .Subbasins.LayerName <> "" Then cboSubbasinLayer.Text = .Subbasins.LayerName
                    If .DEM.LayerName <> "" Then cboDEMLayer.Text = .DEM.LayerName
                    If .ClimateSta.LayerName <> "" Then cboClimateStaLayer.Text = .ClimateSta.LayerName : cboClimateStaField.Text = .ClimateSta.FieldName
                    If .PointSources.LayerName <> "" Then cboPointSourceLayer.Text = .PointSources.LayerName : cboPointSourceField.Text = .PointSources.FieldName
                    If .Soils.LayerName <> "" Then cboSoilLayer.Text = .Soils.LayerName : cboSoilField.Text = .Soils.FieldName
                    If .Landuse.LayerName <> "" Then cboLandUseLayer.Text = .Landuse.LayerName : cboLandUseField.Text = .Landuse.FieldName
                    If .MercurySta.LayerName <> "" Then cboHgStationsLayer.Text = .MercurySta.LayerName : cboHgStationsField.Text = .MercurySta.FieldName
                    cboStreamLayer.Text = .Streams.LayerName
                    cboLakeLayer.Text = .Lakes.LayerName : cboLakeField.Text = .Lakes.FieldName
                    cboFlowDirLayer.Text = .FlowDir.LayerName
                    cboFlowAccLayer.Text = .FlowAcc.LayerName
                End With

                With .Tables
                    If .Climate.TableName <> "" Then cboClimateDataTable.Text = .Climate.TableName
                    If .HgDryDep.TableName <> "" Then cboHgDryDepTable.Text = .HgDryDep.TableName
                    If .HgWetDep.TableName <> "" Then cboHgWetDepTable.Text = .HgWetDep.TableName
                    If .PointSource.TableName <> "" Then cboPointSourceTable.Text = .PointSource.TableName
                    If .LandUse.TableName <> "" Then cboLanduseTable.Text = .LandUse.TableName
                    If .LandUseCN.TableName <> "" Then cboLanduseCNTable.Text = .LandUseCN.TableName
                    If .Soils.TableName <> "" Then cboSoilTable.Text = .Soils.TableName
                End With

                txtGridSize.Text = .GridSize
                cboDEMUnits.SelectedIndex = .DEMUnits
                txtThreshold.Text = .StreamThreshold

                'Hydrology-Overland
                cboInitialSoilMoisture.Text = Project.Grids.SoilWater.LayerName
                With .WatershedParms
                    optConstSoilMoisture.Checked = .SoilWaterFlag = enumSoilWater.Constant
                    optInputSoilMoisture.Checked = .SoilWaterFlag = enumSoilWater.InputGrid
                    optFieldCapacity.Checked = .SoilWaterFlag = enumSoilWater.FieldCapacity
                    txtInitialSoilMoistureConstant.Text = .InitSoilWater
                    txtInitialAccuSnowConstant.Text = .InitSnow
                    txtaCNGrow.Text = .GrowA
                    txtbCNGrow.Text = .GrowB
                    txtaCNNonGrow.Text = .NGrowA
                    txtbCNNonGrow.Text = .NGrowB
                    txtHydroP2Rainfall.Text = .P2Rainfall
                    txtInitialShallowGWConstant.Text = .GWInit
                    txtHydroGWRecessionCoeff.Text = .GWRecess
                    txtHydroGWSeepageCoeff.Text = .GWSeepage
                    txtHgLandUnsaturatedSoilDepth.Text = .USDepth
                    txtHgLandBedrockDepth.Text = .BRDepth
                End With
                'Hydrology-Streams
                With .StreamParms
                    txtHydroManningCoeff.Text = .Manning
                    txtCrossSectionSlope1.Text = .Z1
                    txtCrossSectionSlope2.Text = .Z2
                    cboRegions.SelectedIndex = .Region
                    If .Region = enumRegion.UserDefined Then
                        txtAlphaDepth.Text = .AlphaDepth.ToString("0.0000")
                        txtBetaDepth.Text = .BetaDepth.ToString("0.0000")
                        txtAlphaWidth.Text = .AlphaWidth.ToString("0.0000")
                        txtBetaWidth.Text = .BetaWidth.ToString("0.0000")
                    End If
                End With
                'Hydrology-Lakes
                With .LakeParms
                    txtLakesThreshold.Text = .AreaThreshold
                    txtInitWaterDepth.Text = .Depth
                    txtBankFullDepth.Text = .FullDepth
                    txtHydroEvapoCoeff.Text = .Evap
                    txtHydroOrificeDepth.Text = .OrifH
                    txtHydroOrificeDia.Text = .OrifD
                    txtHydroOrificeDischargeCoeff.Text = .OrifC
                    txtHydroWeirCrestLength.Text = .WeirL
                    txtHydroWeirDischargeCoeff.Text = .WeirC
                    txtLakeInfiltration.Text = .Infilt
                    txtLakeInitialSediment.Text = .SedimentHg 'Sediment-Lake tab
                End With
                'Sediment-Slope Length
                With .LSFactor
                    optionDefaultLSFactor.Checked = (.LSFlag = enumLSFlag.DEM)
                    optionDefineSlopeLength.Checked = (.LSFlag = enumLSFlag.Constant)
                    optionExisting.Checked = (.LSFlag = enumLSFlag.Existing)
                    chkMaxSlope.Checked = .MaxSlopeLengthFlag
                    txtMaxSlope.Text = .MaxSlopeLength
                    txtCSL.Text = .ConstantSlopeLength
                End With
                'Sediment-Overland
                With .WatershedSedParms
                    txtInitialSedimentPerviousLandConstant.Text = .InitPerv
                    txtInitialSedimentImperviousLandConstant.Text = .InitImperv
                    txtSedAccumulationRate.Text = .Accum
                    txtSedDepletionRate.Text = .Deplet
                    txtSedYieldCapacity.Text = .Capacity
                    txtSedAlphaTc.Text = .RainAlpha
                    txtSedCalibCoeffAlpha.Text = .SDRAlpha
                    txtSedRoutingCoeffBeta.Text = .SDRBeta
                End With
                'Sediment-Lake
                With .LakeSedParms
                    txtSedEquilibriumConc.Text = .TssEquil
                    txtSedDecayConstant.Text = .SettleDecay
                    txtSedPercentClay.Text = .Clay
                    txtSedPercentSilt.Text = .Silt
                    txtSedPercentSand.Text = .Sand
                End With
                'Mercury-Data
                With .WatershedMercuryParms
                    optionInitialHgConstant.Checked = (.SoilFlag = enumMercFlag.InitConc)
                    optionSoilHgGrid.Checked = (.SoilFlag = enumMercFlag.GridMult)
                    txtInitialConstantHg.Text = .InitSoil
                    cboInitialSoilHg.Text = Project.Grids.MercuryDryDepo.LayerName
                    txtInitialSoilHgMultiplier.Text = .GridMult
                End With
                With .MercuryDepo
                    chkHgConstant.Checked = (.AirDepoFlag = enumDepoFlag.Constant)
                    chkHgGrid.Checked = (.AirDepoFlag = enumDepoFlag.InputGrid)
                    chkHgTimeSeries.Checked = (.AirDepoFlag = enumDepoFlag.TimeSeries)
                    optionHgWetConst.Checked = (.WetDepoFlag = enumWetDepo.WetDepo)
                    optionHgWetPrcpConc.Checked = (.WetDepoFlag = enumWetDepo.Rainfall)
                    txtHgDryConstant.Text = .DryDepoFlux
                    txtHgWetConstant.Text = .WetDepoFlux
                    txtHgWetPrcpConc.Text = .WetDepoPrecip
                    cboHgDryDepositionFlux.Text = Project.Grids.MercuryDryDepo.LayerName
                    cboHgWetDepositionFlux.Text = Project.Grids.MercuryWetDepo.LayerName
                    txtHgDryMultiplier.Text = .DryDepoMult
                    txtHgWetMultiplier.Text = .WetDepoMult
                    cboHgStationsLayer.Text = Project.Layers.MercurySta.LayerName
                    cboHgDryDepTable.Text = Project.Tables.HgDryDep.TableName
                    cboHgWetDepTable.Text = Project.Tables.HgWetDep.TableName
                    cboHgDryDepTS.SelectedIndex = .DryDepoStep
                    cboHgWetDepTS.SelectedIndex = .WetDepoStep
                End With
                'Mercury-Land
                With .WatershedMercuryParms
                    txtHgLandAirHgConc.Text = Project.ForestMercuryParms.AirConc.ToString("0.000000")
                    txtHgLandAirPlantBioConc.Text = Project.ForestMercuryParms.BioConc
                    txtInitialHgSaturatedSoilConstant.Text = .InitGW.ToString("0.000000")
                    txtHgLandSoilMixingDepth.Text = .SoilMixing
                    txtHgLandSoilReductionDepth.Text = .SoilReductionDepth
                    txtHgLandSoilParticleDensity.Text = Project.LakeMercuryParms.PD
                    txtHgLandSoilWaterPartitionCoeff.Text = .SoilPartition
                    txtHgLandSoilBaseReductionRate.Text = .SoilBaseReductionRate.ToString("0.000000")
                    txtHgLandPollutantEnrichmentFactor.Text = .Enrich
                    txtHgLandBedrockDensity.Text = .BedrockDensity
                    txtHgLandChemicalWeatheringRate.Text = .Weathering.ToString("0.000000")
                    txtHgLandBedrockHgConc.Text = .InitRock
                End With
                'Mercury-Forest
                With .ForestMercuryParms
                    txtHgLandAnnualEvapo.Text = .AET
                    txtHgLandLeafInterFraction.Text = .IntFrac
                    txtHgLandLeafAdhereFraction.Text = .AdhereFrac
                    txtHgInitialLeafLitterConstant.Text = .Litter
                    txtHgLandKDcomp1.Text = .LitterDecomp1
                    txtHgLandKDcomp2.Text = .LitterDecomp2
                    txtHgLandKDcomp3.Text = .LitterDecomp3
                End With
                'Mercury-Water
                With .LakeMercuryParms
                    txtLakeHgWaterColumn.Text = Project.LakeParms.WaterHg
                    txtHgWaterAlphaW.Text = .AlphaW
                    txtHgWaterKWR.Text = .KWR
                    txtHgWaterBetaW.Text = .BetaW
                    txtHgWaterKWM.Text = .KWM
                    txtHgWaterVSB.Text = .VSB
                    txtHgWaterVRS.Text = .VRS.ToString("0.000000")
                    txtHgBenthicPorewaterDiffusionCoeff.Text = Project.BenthicMercuryParms.Esw.ToString("0.000000000")
                    txtHgWaterKDsw.Text = .KDSW
                    txtHgWaterKbio.Text = .KBio
                    txtHgWaterCbio.Text = .CBio
                    txtHgWaterHgDecayInChannel.Text = Project.WatershedMercuryParms.ChannelDecay
                    txtHgMethylHgFraction.Text = Project.WatershedMercuryParms.Fraction
                End With
                'Mercury-Benthic
                With .BenthicMercuryParms
                    txtLakeHgBenthic.Text = Project.LakeParms.BenthicHg
                    txtHgBenthicAlphaB.Text = .AlphaB
                    txtHgBenthicKBR.Text = .KBR.ToString("0.000000")
                    txtHgBenthicBetaB.Text = .BetaB
                    txtHgBenthicKBM.Text = .KBM
                    txtHgBenthicVbur.Text = .VBur.ToString("0.000000000")
                    txtHgBenthicSedimentDepth.Text = .ZB
                    txtHgWaterTheta_bs.Text = .Por_BS
                    txtHgBenthicKDbs.Text = .Kdbs
                    txtHgBenthicCbs.Text = .Cbs
                End With
                'Simulate-General
                With .SimFlags
                    chkHydro.Checked = .Hydro
                    chkSediment.Checked = .Sediment
                    chkMercury.Checked = .Mercury
                    chkWASP.Checked = .Wasp
                    chkWhAEM.Checked = .WHAEM
                    txtWhAEMDuration.Text = .WHAEMDuration
                End With
                chkForceRebuild.Checked = .ForceRebuild
                chkAddLayers.Checked = .AddLayers

                'Simulate-Simulation Time
                With .SimPeriods
                    dtStartSim.Value = .StartDate
                    dtEndSim.Value = .EndDate
                    dtStartClimate.Value = Project.Tables.Climate.StartDate
                    dtEndClimate.Value = Project.Tables.Climate.EndDate
                    cboStartMonth.Text = .StartMonth
                    cboEndMonth.Text = .EndMonth
                    txtTimeStep.Text = .DeltaT
                End With
                'Simulate-Mercury Time
                With .Tables
                    dtStartDry.Value = .HgDryDep.StartDate
                    dtEndDry.Value = .HgDryDep.EndDate
                    dtStartWet.Value = .HgWetDep.StartDate
                    dtEndWet.Value = .HgWetDep.EndDate
                End With
            End With
        Catch ex As Exception
            Logger.Message("Error while trying to load form:" & vbCr & vbCr & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, Windows.Forms.DialogResult.OK)
        End Try
    End Sub

    ''' <summary>
    ''' Move data from form fields into Project structure
    ''' </summary>
    Friend Sub SaveForm()
        Try
            With Project
                With .Folders
                    .InputFolder = txtInputName.Text
                    .OutputFolder = txtOutputName.Text
                End With
                .GridSize = txtGridSize.Text
                .DEMUnits = cboDEMUnits.SelectedIndex
                .StreamThreshold = txtThreshold.Text
                .LanduseType = cboLanduseType.SelectedIndex

                With .Layers
                    .Subbasins.LayerName = cboSubbasinLayer.Text
                    .DEM.LayerName = cboDEMLayer.Text
                    .ClimateSta.LayerName = cboClimateStaLayer.Text
                    .ClimateSta.FieldName = cboClimateStaField.Text
                    .PointSources.LayerName = cboPointSourceLayer.Text
                    .PointSources.FieldName = cboPointSourceField.Text
                    If .PointSources.LayerName.StartsWith("<") Then .PointSources.LayerName = ""
                    .Soils.LayerName = cboSoilLayer.Text
                    .Soils.FieldName = cboSoilField.Text
                    .Landuse.LayerName = cboLandUseLayer.Text
                    .Landuse.FieldName = cboLandUseField.Text
                    .MercurySta.LayerName = cboHgStationsLayer.Text
                    .MercurySta.FieldName = cboHgStationsField.Text
                    If .MercurySta.LayerName.StartsWith("<") Then .MercurySta.LayerName = ""
                    .Streams.LayerName = cboStreamLayer.Text
                    .Lakes.LayerName = cboLakeLayer.Text
                    .Lakes.FieldName = cboLakeField.Text
                    .FlowDir.LayerName = cboFlowDirLayer.Text
                    .FlowAcc.LayerName = cboFlowAccLayer.Text
                End With

                .Tables.Climate.TableName = cboClimateDataTable.Text
                .Tables.HgDryDep.TableName = cboHgDryDepTable.Text
                .Tables.HgWetDep.TableName = cboHgWetDepTable.Text
                .Tables.PointSource.TableName = cboPointSourceTable.Text
                If .Layers.PointSources.LayerName = "" Then .Tables.PointSource.TableName = ""
                .Tables.LandUse.TableName = cboLanduseTable.Text
                .Tables.LandUseCN.TableName = cboLanduseCNTable.Text
                .Tables.Soils.TableName = cboSoilTable.Text

                'Hydrology-Overland
                Project.Grids.SoilWater.LayerName = cboInitialSoilMoisture.Text
                With .WatershedParms
                    If optConstSoilMoisture.Checked Then .SoilWaterFlag = enumSoilWater.Constant
                    If optInputSoilMoisture.Checked Then .SoilWaterFlag = enumSoilWater.InputGrid
                    If optFieldCapacity.Checked Then .SoilWaterFlag = enumSoilWater.FieldCapacity
                    .InitSoilWater = txtInitialSoilMoistureConstant.Text
                    .InitSnow = txtInitialAccuSnowConstant.Text
                    .GrowA = txtaCNGrow.Text
                    .GrowB = txtbCNGrow.Text
                    .NGrowA = txtaCNNonGrow.Text
                    .NGrowB = txtbCNNonGrow.Text
                    .P2Rainfall = txtHydroP2Rainfall.Text
                    .GWInit = txtInitialShallowGWConstant.Text
                    .GWRecess = txtHydroGWRecessionCoeff.Text
                    .GWSeepage = txtHydroGWSeepageCoeff.Text
                    .USDepth = txtHgLandUnsaturatedSoilDepth.Text
                    .BRDepth = txtHgLandBedrockDepth.Text
                End With
                'Hydrology-Streams
                With .StreamParms
                    .Manning = txtHydroManningCoeff.Text
                    .Z1 = txtCrossSectionSlope1.Text
                    .Z2 = txtCrossSectionSlope2.Text
                    .Region = cboRegions.SelectedIndex
                    .AlphaDepth = txtAlphaDepth.Text
                    .BetaDepth = txtBetaDepth.Text
                    .AlphaWidth = txtAlphaWidth.Text
                    .BetaWidth = txtBetaWidth.Text
                End With
                'Hydrology-Lakes
                With .LakeParms
                    .AreaThreshold = txtLakesThreshold.Text
                    .Depth = txtInitWaterDepth.Text
                    .FullDepth = txtBankFullDepth.Text
                    .Evap = txtHydroEvapoCoeff.Text
                    .OrifH = txtHydroOrificeDepth.Text
                    .OrifD = txtHydroOrificeDia.Text
                    .OrifC = txtHydroOrificeDischargeCoeff.Text
                    .WeirL = txtHydroWeirCrestLength.Text
                    .WeirC = txtHydroWeirDischargeCoeff.Text
                    .Infilt = txtLakeInfiltration.Text
                End With
                'Sediment-Slope Length
                With .LSFactor
                    If optionDefaultLSFactor.Checked Then .LSFlag = enumLSFlag.DEM
                    If optionDefineSlopeLength.Checked Then .LSFlag = enumLSFlag.Constant
                    If optionExisting.Checked Then .LSFlag = enumLSFlag.Existing
                    .MaxSlopeLengthFlag = chkMaxSlope.Checked
                    .MaxSlopeLength = txtMaxSlope.Text
                    .ConstantSlopeLength = txtCSL.Text
                End With
                'Sediment-Overland
                With .WatershedSedParms
                    .InitPerv = txtInitialSedimentPerviousLandConstant.Text
                    .InitImperv = txtInitialSedimentImperviousLandConstant.Text
                    .Accum = txtSedAccumulationRate.Text
                    .Deplet = txtSedDepletionRate.Text
                    .Capacity = txtSedYieldCapacity.Text
                    .RainAlpha = txtSedAlphaTc.Text
                    .SDRAlpha = txtSedCalibCoeffAlpha.Text
                    .SDRBeta = txtSedRoutingCoeffBeta.Text
                End With
                'Sediment-Lake
                With .LakeSedParms
                    Project.LakeParms.SedimentHg = txtLakeInitialSediment.Text
                    .TssEquil = txtSedEquilibriumConc.Text
                    .SettleDecay = txtSedDecayConstant.Text
                    .Clay = txtSedPercentClay.Text
                    .Silt = txtSedPercentSilt.Text
                    .Sand = txtSedPercentSand.Text
                End With
                'Mercury-Data
                With .WatershedMercuryParms
                    If optionInitialHgConstant.Checked Then .SoilFlag = enumMercFlag.InitConc
                    If optionSoilHgGrid.Checked Then .SoilFlag = enumMercFlag.GridMult
                    .InitSoil = txtInitialConstantHg.Text
                    Project.Grids.MercurySoil.LayerName = cboInitialSoilHg.Text
                    .GridMult = txtInitialSoilHgMultiplier.Text
                End With
                With .MercuryDepo
                    If chkHgConstant.Checked Then .AirDepoFlag = enumDepoFlag.Constant
                    If chkHgGrid.Checked Then .AirDepoFlag = enumDepoFlag.InputGrid
                    If chkHgTimeSeries.Checked Then .AirDepoFlag = enumDepoFlag.TimeSeries
                    If optionHgWetConst.Checked Then .WetDepoFlag = enumWetDepo.WetDepo
                    If optionHgWetPrcpConc.Checked Then .WetDepoFlag = enumWetDepo.Rainfall
                    .DryDepoFlux = txtHgDryConstant.Text
                    .WetDepoFlux = txtHgWetConstant.Text
                    .WetDepoPrecip = txtHgWetPrcpConc.Text
                    Project.Grids.MercuryDryDepo.LayerName = cboHgDryDepositionFlux.Text
                    Project.Grids.MercuryWetDepo.LayerName = cboHgWetDepositionFlux.Text
                    .DryDepoMult = txtHgDryMultiplier.Text
                    .WetDepoMult = txtHgWetMultiplier.Text
                    Project.Layers.MercurySta.LayerName = cboHgStationsLayer.Text
                    Project.Tables.HgDryDep.TableName = cboHgDryDepTable.Text
                    Project.Tables.HgWetDep.TableName = cboHgWetDepTable.Text
                    .DryDepoStep = cboHgDryDepTS.SelectedIndex
                    .WetDepoStep = cboHgWetDepTS.SelectedIndex
                End With
                'Mercury-Land
                With .WatershedMercuryParms
                    Project.ForestMercuryParms.AirConc = txtHgLandAirHgConc.Text
                    Project.ForestMercuryParms.BioConc = txtHgLandAirPlantBioConc.Text
                    .InitGW = txtInitialHgSaturatedSoilConstant.Text
                    .SoilMixing = txtHgLandSoilMixingDepth.Text
                    .SoilReductionDepth = txtHgLandSoilReductionDepth.Text
                    Project.LakeMercuryParms.PD = txtHgLandSoilParticleDensity.Text
                    .SoilPartition = txtHgLandSoilWaterPartitionCoeff.Text
                    .SoilBaseReductionRate = txtHgLandSoilBaseReductionRate.Text
                    .Enrich = txtHgLandPollutantEnrichmentFactor.Text
                    .BedrockDensity = txtHgLandBedrockDensity.Text
                    .Weathering = txtHgLandChemicalWeatheringRate.Text
                    .InitRock = txtHgLandBedrockHgConc.Text
                End With
                'Mercury-Forest
                With .ForestMercuryParms
                    .AET = txtHgLandAnnualEvapo.Text
                    .IntFrac = txtHgLandLeafInterFraction.Text
                    .AdhereFrac = txtHgLandLeafAdhereFraction.Text
                    .Litter = txtHgInitialLeafLitterConstant.Text
                    .LitterDecomp1 = txtHgLandKDcomp1.Text
                    .LitterDecomp2 = txtHgLandKDcomp2.Text
                    .LitterDecomp3 = txtHgLandKDcomp3.Text
                End With
                'Mercury-Water
                With .LakeMercuryParms
                    Project.LakeParms.WaterHg = txtLakeHgWaterColumn.Text
                    .AlphaW = txtHgWaterAlphaW.Text
                    .KWR = txtHgWaterKWR.Text
                    .BetaW = txtHgWaterBetaW.Text
                    .KWM = txtHgWaterKWM.Text
                    .VSB = txtHgWaterVSB.Text
                    .VRS = txtHgWaterVRS.Text
                    Project.BenthicMercuryParms.Esw = txtHgBenthicPorewaterDiffusionCoeff.Text
                    .KDSW = txtHgWaterKDsw.Text
                    .KBio = txtHgWaterKbio.Text
                    .CBio = txtHgWaterCbio.Text
                    Project.WatershedMercuryParms.ChannelDecay = txtHgWaterHgDecayInChannel.Text
                    Project.WatershedMercuryParms.Fraction = txtHgMethylHgFraction.Text
                End With
                'Mercury-Benthic
                With .BenthicMercuryParms
                    Project.LakeParms.BenthicHg = txtLakeHgBenthic.Text
                    .AlphaB = txtHgBenthicAlphaB.Text
                    .KBR = txtHgBenthicKBR.Text
                    .BetaB = txtHgBenthicBetaB.Text
                    .KBM = txtHgBenthicKBM.Text
                    .KBR = txtHgBenthicVbur.Text
                    .ZB = txtHgBenthicSedimentDepth.Text
                    .Por_BS = txtHgWaterTheta_bs.Text
                    .Kdbs = txtHgBenthicKDbs.Text
                    .Cbs = txtHgBenthicCbs.Text
                End With
                'Simulate-General
                With .SimFlags
                    .Hydro = chkHydro.Checked
                    .Sediment = chkSediment.Checked
                    .Mercury = chkMercury.Checked
                    .Wasp = chkWASP.Checked
                    .WHAEM = chkWhAEM.Checked
                    .WHAEMDuration = txtWhAEMDuration.Text
                End With
                .ForceRebuild = chkForceRebuild.Checked
                .AddLayers = chkAddLayers.Checked

                'Simulate-Simulation Time
                With .SimPeriods
                    .StartDate = dtStartSim.Value
                    .EndDate = dtEndSim.Value
                    Project.Tables.Climate.StartDate = dtStartClimate.Value
                    Project.Tables.Climate.EndDate = dtEndClimate.Value
                    .StartMonth = cboStartMonth.Text
                    .EndMonth = cboEndMonth.Text
                    .DeltaT = txtTimeStep.Text
                End With
                'Simulate-Mercury Time
                With .Tables
                    .HgDryDep.StartDate = dtStartDry.Value
                    .HgDryDep.EndDate = dtEndDry.Value
                    .HgWetDep.StartDate = dtStartWet.Value
                    .HgWetDep.EndDate = dtEndWet.Value
                End With
            End With
        Catch ex As Exception
            Logger.Message("Error while trying to load form:" & vbCr & vbCr & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, Windows.Forms.DialogResult.OK)
        End Try
    End Sub

    Private Sub txtGridSize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOutputName.KeyPress, txtInputName.KeyPress
        Project.Modified = True
        wbResults.DocumentText = ""
    End Sub

    Private Sub txtGridSize_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGridSize.Validated
        Project.Modified = True
        wbResults.DocumentText = ""
    End Sub

    Private Sub P2Map_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP2Map.Click
        With New frmP2Map
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub lstRegions_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRegions.SelectedIndexChanged
        txtAlphaWidth.Text = Project.StreamParms.AlphaWidthArray(cboRegions.SelectedIndex)
        txtBetaWidth.Text = Project.StreamParms.BetaWidthArray(cboRegions.SelectedIndex)
        txtAlphaDepth.Text = Project.StreamParms.AlphaDepthArray(cboRegions.SelectedIndex)
        txtBetaDepth.Text = Project.StreamParms.BetaDepthArray(cboRegions.SelectedIndex)
    End Sub

    Private Sub optConstSoilMoisture_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optConstSoilMoisture.CheckedChanged
        If eventSender.Checked Then
            optConstSoilMoisture.Checked = True
            optFieldCapacity.Checked = False
            optInputSoilMoisture.Checked = False
            txtInitialSoilMoistureConstant.Enabled = True
            cboInitialSoilMoisture.Enabled = False
        End If
    End Sub

    Private Sub optFieldCapacity_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optFieldCapacity.CheckedChanged
        If eventSender.Checked Then
            optFieldCapacity.Checked = True
            optConstSoilMoisture.Checked = False
            optInputSoilMoisture.Checked = False
            txtInitialSoilMoistureConstant.Enabled = False
            cboInitialSoilMoisture.Enabled = False
        End If
    End Sub

    Private Sub optInputSoilMoisture_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optInputSoilMoisture.CheckedChanged
        If eventSender.Checked Then
            optConstSoilMoisture.Checked = False
            optFieldCapacity.Checked = False
            optInputSoilMoisture.Checked = True
            txtInitialSoilMoistureConstant.Enabled = False
            cboInitialSoilMoisture.Enabled = True
        End If
    End Sub

    Private Sub optionHgWetConst_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optionHgWetConst.CheckedChanged
        If eventSender.Checked Then
            txtHgWetConstant.Enabled = True
            txtHgWetPrcpConc.Enabled = False
        End If
    End Sub

    Private Sub optionHgWetPrcpConc_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optionHgWetPrcpConc.CheckedChanged
        If eventSender.Checked Then
            txtHgWetConstant.Enabled = False
            txtHgWetPrcpConc.Enabled = True
        End If
    End Sub

    Private Sub optionInitialHgConstant_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optionInitialHgConstant.CheckedChanged
        If eventSender.Checked Then
            txtInitialConstantHg.Enabled = True
            cboInitialSoilHg.Enabled = False
            lblInitialSoilHgMultiplier.Enabled = False
            txtInitialSoilHgMultiplier.Enabled = False
        End If
    End Sub

    Private Sub optionSoilHgGrid_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optionSoilHgGrid.CheckedChanged
        If eventSender.Checked Then
            txtInitialConstantHg.Enabled = False
            cboInitialSoilHg.Enabled = True
            lblInitialSoilHgMultiplier.Enabled = True
            txtInitialSoilHgMultiplier.Enabled = True
        End If
    End Sub

    Private Sub chkTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHgTimeSeries.CheckedChanged
        If chkHgTimeSeries.Checked Then
            chkHgConstant.Checked = False
            chkHgGrid.Checked = False
            txtHgDryConstant.Enabled = False
            txtHgWetConstant.Enabled = False
            txtHgWetPrcpConc.Enabled = False
            cboHgDryDepositionFlux.Enabled = False
            txtHgDryMultiplier.Enabled = False
            cboHgWetDepositionFlux.Enabled = False
            txtHgWetMultiplier.Enabled = False
            cboHgStationsLayer.Enabled = True
            cboHgDryDepTable.Enabled = True
            cboHgWetDepTable.Enabled = True
            cboHgDryDepTS.Enabled = True
            cboHgWetDepTS.Enabled = True
            lblHgStation.Enabled = True
            lblDryHgDepTS.Enabled = True
            lblHgWetDepTS.Enabled = True

            optionHgWetPrcpConc.Enabled = False
            optionHgWetConst.Enabled = False

            lblHgDry.Enabled = False
            lblHgWet.Enabled = False
            lblHgDryMul.Enabled = False
            lblHgWetMul.Enabled = False
        End If
    End Sub

    Private Sub chkGrid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHgGrid.CheckedChanged
        If chkHgGrid.Checked Then
            chkHgConstant.CheckState = System.Windows.Forms.CheckState.Unchecked
            chkHgTimeSeries.CheckState = System.Windows.Forms.CheckState.Unchecked
            txtHgDryConstant.Enabled = False
            txtHgWetConstant.Enabled = False
            txtHgWetPrcpConc.Enabled = False
            cboHgDryDepositionFlux.Enabled = True
            txtHgDryMultiplier.Enabled = True
            cboHgWetDepositionFlux.Enabled = True
            txtHgWetMultiplier.Enabled = True
            cboHgStationsLayer.Enabled = False
            cboHgDryDepTable.Enabled = False
            cboHgWetDepTable.Enabled = False
            cboHgDryDepTS.Enabled = False
            cboHgWetDepTS.Enabled = False
            lblHgStation.Enabled = False
            lblDryHgDepTS.Enabled = False
            lblHgWetDepTS.Enabled = False
            optionHgWetPrcpConc.Enabled = False
            optionHgWetConst.Enabled = False

            lblHgDry.Enabled = True
            lblHgWet.Enabled = True
            lblHgDryMul.Enabled = True
            lblHgWetMul.Enabled = True
        End If
    End Sub

    Private Sub chkConstant_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHgConstant.CheckedChanged
        If chkHgConstant.Checked Then
            chkHgGrid.Checked = False
            chkHgTimeSeries.Checked = False
            optionHgWetPrcpConc.Enabled = True
            optionHgWetConst.Enabled = True
            txtHgDryConstant.Enabled = True
            cboHgDryDepositionFlux.Enabled = False
            txtHgDryMultiplier.Enabled = False
            cboHgWetDepositionFlux.Enabled = False
            txtHgWetMultiplier.Enabled = False
            cboHgStationsLayer.Enabled = False
            cboHgDryDepTable.Enabled = False
            cboHgWetDepTable.Enabled = False

            cboHgDryDepTS.Enabled = False
            cboHgWetDepTS.Enabled = False

            lblHgStation.Enabled = False
            lblDryHgDepTS.Enabled = False
            lblHgWetDepTS.Enabled = False

            lblHgDry.Enabled = False
            lblHgWet.Enabled = False
            lblHgDryMul.Enabled = False
            lblHgWetMul.Enabled = False

            If optionHgWetConst.Checked = True Then
                txtHgWetConstant.Enabled = True
                txtHgWetPrcpConc.Enabled = False
            ElseIf optionHgWetPrcpConc.Checked = True Then
                txtHgWetConstant.Enabled = False
                txtHgWetPrcpConc.Enabled = True
            End If
        Else
            txtHgDryConstant.Enabled = False
            optionHgWetConst.Enabled = False
            txtHgWetConstant.Enabled = False
            optionHgWetPrcpConc.Enabled = False
            txtHgWetPrcpConc.Enabled = False
        End If
    End Sub

    Private Function ValidateData() As Boolean
        Try
            With Project

                If .SimPeriods.EndDate.Subtract(.SimPeriods.StartDate).TotalDays < 0 Or .Tables.Climate.EndDate.Subtract(.Tables.Climate.StartDate).TotalDays < 0 Or .Tables.HgDryDep.EndDate.Subtract(.Tables.HgDryDep.StartDate).TotalDays < 0 Or .Tables.HgWetDep.EndDate.Subtract(.Tables.HgWetDep.StartDate).TotalDays < 0 Then
                    WarningMsg("All start dates must precede their corresponding end dates; please check your input data.")
                    Return False
                End If

                Dim duration As Double = .SimPeriods.EndDate.Subtract(.SimPeriods.StartDate).TotalDays + 1
                If .SimFlags.WHAEMDuration < 1 Then
                    WarningMsg("Average Duration for Groundwater Recharge cannot be less than 1 day")
                    Return False
                ElseIf .SimFlags.WHAEMDuration > duration Then
                    WarningMsg("Average Duration for Groundwater Recharge cannot be more than than {0:0} days", duration)
                    Return False
                End If

                If .SimFlags.Mercury Then
                    If .MercuryDepo.AirDepoFlag = enumDepoFlag.TimeSeries Then
                        If .SimPeriods.EndDate.Subtract(.SimPeriods.StartDate).TotalDays < 364 Then
                            If Not (.SimPeriods.StartDate = .Tables.HgDryDep.StartDate And .SimPeriods.EndDate = .Tables.HgDryDep.EndDate And _
                                    .SimPeriods.StartDate = .Tables.HgWetDep.StartDate And .SimPeriods.EndDate = .Tables.HgWetDep.EndDate And _
                                    .SimPeriods.StartDate = .Tables.Climate.StartDate And .SimPeriods.EndDate = .Tables.Climate.EndDate) Then
                                WarningMsg("Selected simulation date range is less than a year; the Climate, Dry Hg, and Wet Hg date ranges must all match the simulation date range.")
                                Return False
                            End If
                        End If
                    End If
                End If

                If .Folders.InputFolder = "" Or .Folders.OutputFolder = "" Then
                    WarningMsg("You must enter valid folder paths.")
                    Return False
                End If

                If Not My.Computer.FileSystem.DirectoryExists(.Folders.OutputFolder) Then My.Computer.FileSystem.CreateDirectory(.Folders.OutputFolder)

                'look for missing layers, grids, tables, or fields)

                With .Layers
                    If .Soils.LayerName = "" Or ((Project.LanduseType = enumLandUseType.UserGrid Or Project.LanduseType = enumLandUseType.UserShapefile) And .Landuse.LayerName = "") Or .DEM.LayerName = "" Then
                        WarningMsg("One or more required layers are missing; you must have these layers specified at a minimum: Soils, Landuse, and DEM!")
                        Return False
                    End If
                End With

                Dim gDEM As New MapWinGIS.Grid
                If gDEM.Open(.Layers.DEM.Filename) Then
                    Dim DEMGridSize As Double = Math.Round(gDEM.Header.dX, 1)
                    gDEM.Close()
                    If .GridSize <= 0 OrElse Math.IEEERemainder(.GridSize, DEMGridSize) > 0.1 Then
                        WarningMsg("The computational grid size ({0}) must be an even multiple of the selected DEM grid size ({1})", .GridSize, DEMGridSize)
                        Return False
                    End If
                End If

                With .Tables
                    If .Climate.TableName = "" Or .LandUse.TableName = "" Or .LandUseCN.TableName = "" Or .Soils.TableName = "" Or (Project.Layers.PointSources.LayerName <> "" And .PointSource.TableName = "") Or (Project.Layers.MercurySta.LayerName <> "" And (.HgDryDep.TableName = "" Or .HgWetDep.TableName = "")) Then
                        WarningMsg("One or more required data tables are missing; you must have these tables specified at a minimum: Climate Data, Land Use, Land Use Curve Numbers, Soils Properties (and optionally Point Sources and Mercury Stations).")
                        Return False
                    End If
                    If .PointSource.TableName <> "" And Project.Layers.PointSources.LayerName = "" Then
                        WarningMsg("Both Point Source Layer and Data Table need to be populated, if either one is filled.")
                        Return False
                    End If
                    If Not (CheckTableFields(.LandUse.TableName, "LUCODE", "LUC", "LUP", "GETCOVER", "NGETCOVER", "IMP_DCON", "IMP_TOT", "TYPE", "N") AndAlso _
                            CheckTableFields(.LandUseCN.TableName, "LU_CNCODE", "CN") AndAlso _
                            CheckTableFields(.Soils.TableName, "VALUE", "MUID2", "AWC", "KFACT", "PERM", "BD", "CLAYPERC", "GROUP", "GROUPVALUE") AndAlso _
                            CheckTableFields(.Climate.TableName, "STA_ID", "IDATE", "TAVG_C", "PRCP_CM") AndAlso _
                            (.PointSource.TableName = "" OrElse CheckTableFields(.PointSource.TableName, "STA_ID"))) Then
                        WarningMsg("One or more required data tables is missing one or more required fields.")
                        Return False
                    End If
                End With
                Return True
            End With
        Catch ex As Exception
            ErrorMsg(, ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Make sure specified table has all the required fields
    ''' </summary>
    ''' <param name="TableName">Name of table or layer</param>
    ''' <param name="ReqdFields">List of required layer names</param>
    Friend Function CheckTableFields(ByVal TableName As String, ByVal ParamArray ReqdFields() As String) As Boolean
        Dim dt As DataTable

        dt = LoadTable(TableName, True)
        If dt Is Nothing Then
            WarningMsg(TableName & " file is invalid; unable to check for required fields.")
            Return False
        End If

        With dt
            For Each s As String In ReqdFields
                If Not .Columns.Contains(s) Then
                    WarningMsg(TableName & " table is missing the following required field: " & s)
                    Return False
                End If
            Next
        End With
        Return True
    End Function

    Private Sub cbo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkHydro.CheckedChanged, chkSediment.CheckedChanged, chkMercury.CheckedChanged
        'must be checked from left to right
        If sender Is chkHydro Then
            If chkHydro.Checked Then
            Else
                chkSediment.Checked = False
                chkMercury.Checked = False
            End If
        ElseIf sender Is chkSediment Then
            If chkSediment.Checked Then
                chkHydro.Checked = True
            Else
                chkMercury.Checked = False
            End If
        ElseIf sender Is chkMercury Then
            If chkMercury.Checked Then
                chkHydro.Checked = True
                chkSediment.Checked = True
            End If
        End If
        If Not chkHydro.Checked Then
            chkSediment.Checked = False
            chkMercury.Checked = False
        ElseIf Not chkSediment.Checked Then
            chkMercury.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' Recursive function to find control with specified name
    ''' </summary>
    ''' <param name="ParentControl">Control to search</param>
    ''' <param name="ControlName">Name of control to find</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function FindControl(ByVal ParentControl As Control, ByVal ControlName As String) As Control
        Dim cntl As Control = ParentControl.Controls(ControlName)
        If cntl IsNot Nothing Then
            Return cntl
        Else
            For Each ChildControl As Control In ParentControl.Controls
                cntl = FindControl(ChildControl, ControlName)
                If cntl IsNot Nothing Then Return cntl
            Next
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Recursive routine to return list of all controls in the form
    ''' </summary>
    ''' <param name="ParentControl"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetControlList(ByVal ParentControl As Control) As Generic.List(Of Control)
        Static lstControls As Generic.List(Of Control)
        If TypeOf ParentControl Is Form Then
            lstControls = New Generic.List(Of Control)
        Else
            lstControls.Add(ParentControl)
        End If
        For Each cntl As Control In ParentControl.Controls
            GetControlList(cntl)
        Next
        If TypeOf ParentControl Is Form Then Return lstControls Else Return Nothing
    End Function

    Private Sub btnOutputName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutputName.Click, btnInputName.Click
        Dim btn As Button = sender
        Dim txt As TextBox = FindControl(Me, btn.Name.Replace("btn", "txt"))
        With New FolderBrowserDialog
            .SelectedPath = Project.Folders.OutputFolder
            .Description = String.Format("Select path where {0} the GBMM computational model will be saved:", IIf(txt.Name.Contains("Input"), "input to", "output from"))
            .RootFolder = Environment.SpecialFolder.MyComputer
            If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then txt.Text = .SelectedPath
            .Dispose()
        End With
    End Sub

    Private Sub cbo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs)
        FillCombo(sender)
    End Sub

    Private Sub FillCombo(ByVal cboSender As ComboBox)
        Dim text As String = cboSender.Text

        'fill combobox lists
        With Project
            With .Layers
                For i As Integer = 1 To 11
                    Dim cbo As ComboBox = Choose(i, cboClimateStaLayer, cboDEMLayer, cboLakeLayer, cboLandUseLayer, cboHgStationsLayer, cboPointSourceLayer, cboSoilLayer, cboStreamLayer, cboSubbasinLayer, cboFlowDirLayer, cboFlowAccLayer)
                    If cbo Is cboSender Then
                        cboSender.Items.Clear()
                        With CType(Choose(i, .ClimateSta, .DEM, .Lakes, .Landuse, .MercurySta, .PointSources, .Soils, .Streams, .Subbasins, .FlowDir, .FlowAcc), clsLayer)
                            For j As Integer = 0 To GisUtil.NumLayers - 1
                                Dim ln As String = GisUtil.LayerName(j)
                                Dim lt As MapWindow.Interfaces.eLayerType = GisUtil.LayerType(j)
                                If lt = MapWindow.Interfaces.eLayerType.PolygonShapefile And .LayerType = enumLayerType.Polygon Then
                                    cbo.Items.Add(ln)
                                ElseIf lt = MapWindow.Interfaces.eLayerType.Grid And .LayerType = enumLayerType.Grid Then
                                    cbo.Items.Add(ln)
                                ElseIf lt = MapWindow.Interfaces.eLayerType.LineShapefile And .LayerType = enumLayerType.Polyline Then
                                    cbo.Items.Add(ln)
                                ElseIf lt = MapWindow.Interfaces.eLayerType.PointShapefile And .LayerType = enumLayerType.Point Then
                                    cbo.Items.Add(ln)
                                End If
                            Next
                            'these are optional layers
                            Select Case i
                                Case 3, 6 : cbo.Items.Add("<Not Selected>")
                            End Select
                        End With
                        Exit For
                    End If
                Next
            End With

            With .Grids
                For i As Integer = 1 To 4
                    Dim cbo As ComboBox = Choose(i, cboInitialSoilMoisture, cboInitialSoilHg, cboHgDryDepositionFlux, cboHgWetDepositionFlux)
                    If cbo Is cboSender Then
                        cboSender.Items.Clear()
                        With CType(Choose(i, .SoilWater, .MercurySoil, .MercuryDryDepo, .MercuryWetDepo), clsGrid)
                            For j As Integer = 0 To GisUtil.NumLayers - 1
                                Dim ln As String = GisUtil.LayerName(j)
                                Dim lt As MapWindow.Interfaces.eLayerType = GisUtil.LayerType(j)
                                If lt = MapWindow.Interfaces.eLayerType.Grid Then
                                    cbo.Items.Add(ln)
                                End If
                            Next
                        End With
                        Exit For
                    End If
                Next
            End With

            'note: all tables must reside in the Data folder; can be of type .txt or .dbf
            With .Tables
                For i As Integer = 1 To 8
                    Dim cbo As ComboBox = Choose(i, cboClimateDataTable, cboFlowRelationTable, cboHgDryDepTable, cboHgWetDepTable, cboLanduseTable, cboLanduseCNTable, cboSoilTable, cboPointSourceTable)
                    If cbo Is cboSender Then
                        cbo.Items.Clear()
                        With CType(Choose(i, .Climate, .FlowRelation, .HgDryDep, .HgWetDep, .LandUse, .LandUseCN, .Soils, .PointSource), clsTable)
                            For Each fn As String In My.Computer.FileSystem.GetFiles(Project.Folders.DataFolder, FileIO.SearchOption.SearchTopLevelOnly, "*.dbf", "*.txt")
                                cbo.Items.Add(IO.Path.GetFileName(fn))
                            Next
                            'these are optional tables
                            Select Case i
                                Case 8 : cbo.Items.Add("<Not Selected>")
                            End Select
                        End With
                        Exit For
                    End If
                Next
            End With

            If cboSender.Items.Contains(text) Then cboSender.Text = text
        End With
    End Sub

    Private Sub cboLayer_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim cboLayer As ComboBox = sender
        Dim cboField As ComboBox = FindControl(Me, cboLayer.Name.Replace("Layer", "Field"))
        If Not GisUtil.IsLayer(cboLayer.Text) Then Exit Sub
        Dim lyr As Integer = GisUtil.LayerIndex(cboLayer.Text)
        Dim lt As MapWindow.Interfaces.eLayerType = GisUtil.LayerType(lyr)
        With cboField.Items
            .Clear()
            If lt <> MapWindow.Interfaces.eLayerType.Grid Then
                For i As Integer = 0 To GisUtil.NumFields(lyr) - 1
                    .Add(GisUtil.FieldName(i, lyr))
                Next
            End If
        End With
        For Each s As String In cboField.Items
            If s.EndsWith("ID") Then cboField.Text = s : Exit For
        Next
    End Sub

    Private Sub lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Try
            UseWaitCursor = True
            Cursor.Current = Cursors.WaitCursor
            With New frmTableViewer
                Dim cboTableName As ComboBox = FindControl(Me, CType(sender, LinkLabel).Name.Replace("lnk", "cbo"))
                Dim TableName As String = cboTableName.Text
                If TableName = "" Or TableName.StartsWith("<") Then 'no layer or table specified
                    Exit Sub
                ElseIf IO.Path.GetExtension(TableName) = "" Then 'must be layer name
                    If GisUtil.IsLayer(TableName) Then
                        TableName = IO.Path.ChangeExtension(GisUtil.LayerFileName(GisUtil.LayerIndex(TableName)), ".dbf")
                    Else
                        Exit Sub
                    End If
                Else 'is table filename
                    TableName = Project.Folders.DataFolder & "\" & TableName
                End If
                Dim dt As DataTable = LoadTable(TableName)
                With .dgTable
                    .DefaultCellStyle.NullValue = "<Null>"
                    .DataSource = dt
                    If .DataSource Is Nothing Then Exit Sub
                    For i As Integer = 0 To dt.Columns.Count - 1
                        If dt.Columns(i).DataType Is GetType(Byte()) Then
                            .Columns(i).Visible = False
                            Dim dgcol As New DataGridViewLinkColumn
                            dgcol.HeaderText = .Columns(i).HeaderText
                            dgcol.DefaultCellStyle.NullValue = ""
                            .Columns.Add(dgcol)
                        ElseIf dt.Columns(i).DataType Is GetType(String) Then
                            .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Else
                            .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        End If
                        .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                    Next
                    .AutoSize = True
                End With
                .Text = String.Format("Table Viewer: {0}", cboTableName.Text)
                UseWaitCursor = False
                .ShowDialog(Me)
                .Dispose()
                dt.Dispose()
            End With
        Catch ex As Exception
            ErrorMsg(, ex)
        Finally
            UseWaitCursor = False
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub chkWhAEM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWhAEM.CheckedChanged
        fraWhAEM.Enabled = chkWhAEM.Checked
    End Sub

    Private Sub cboPointSourceLayer_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPointSourceLayer.SelectedIndexChanged
        If cboPointSourceLayer.SelectedIndex = 0 Then
            cboPointSourceField.Enabled = False
            cboPointSourceField.SelectedIndex = -1
            cboPointSourceTable.Enabled = False
            cboPointSourceTable.SelectedIndex = 0
        Else
            cboPointSourceField.Enabled = True
            cboPointSourceTable.Enabled = True
        End If
    End Sub

    Private Sub cboLakeLayer_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLakeLayer.SelectedIndexChanged
        If cboLakeLayer.SelectedIndex = 0 Then
            cboLakeField.Enabled = False
            cboLakeField.SelectedIndex = -1
            lnkLakeLayer.Enabled = False
        Else
            cboLakeField.Enabled = True
            lnkLakeLayer.Enabled = True
        End If
    End Sub

    Private Sub txt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        With CType(sender, TextBox)
            If .Text = "" Or Not IsNumeric(.Text) Then
                ErrorProvider.SetIconAlignment(sender, ErrorIconAlignment.MiddleLeft)
                ErrorProvider.SetError(sender, "You must enter a non-blank, numeric value here!")
                e.Cancel = True
            Else
                ErrorProvider.SetError(sender, "")
            End If
        End With
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            With CType(sender, Control)
                Dim dictCntl As New Generic.SortedDictionary(Of Integer, Control)
                For Each cntl As Control In .Parent.Controls
                    If Not dictCntl.ContainsKey(cntl.TabIndex) Then dictCntl.Add(cntl.TabIndex, cntl)
                Next
                For i As Integer = .TabIndex + 1 To dictCntl.Count - 1
                    Dim cntl As Control = dictCntl(i)
                    If TypeOf cntl Is TextBox And cntl.Enabled Then
                        cntl.Focus()
                        Exit For
                    End If
                Next
            End With
            e.Handled = True
        End If
        Project.Modified = True
    End Sub

    Private Sub option_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optionDefaultLSFactor.CheckedChanged, optionDefineSlopeLength.CheckedChanged, optionExisting.CheckedChanged
        chkMaxSlope.Enabled = optionDefaultLSFactor.Checked
        txtMaxSlope.Enabled = optionDefaultLSFactor.Checked
        txtCSL.Enabled = optionDefineSlopeLength.Checked
    End Sub

    Private Sub chkMaxSlope_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMaxSlope.CheckedChanged
        txtMaxSlope.Enabled = chkMaxSlope.Checked
    End Sub

    Private Sub subtabSediment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles subtabSediment.SelectedIndexChanged
        If subtabSediment.SelectedIndex = 0 Then
            With Project.Grids
                optionExisting.Enabled = My.Computer.FileSystem.FileExists(.LSFactor.FileName) And My.Computer.FileSystem.FileExists(.Slope.FileName)
            End With
        End If
    End Sub

    Private Sub lnkMergeCatchments_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkMergeCatchments.LinkClicked
        With New frmMergeCatchments
            .Show(Me)
        End With
    End Sub

    Private Sub cboDEMLayer_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDEMLayer.SelectedIndexChanged, cboFlowDirLayer.SelectedIndexChanged, cboFlowAccLayer.SelectedIndexChanged
        Dim cbo As ComboBox = sender
        Dim lbl As Label = FindControl(Me, cbo.Name.Replace("cbo", "lbl") & "Size")
        If cbo.SelectedIndex <> -1 AndAlso GisUtil.IsLayer(cbo.Text) Then
            Dim grid As New MapWinGIS.Grid
            If grid.Open(GisUtil.LayerFileName(cbo.Text)) Then
                Dim gridsize As Double = grid.Header.dX / Project.DistFactor
                lbl.Text = String.Format("Cell size = {0}m", Math.Round(gridsize, 1))
                lbl.Visible = True
                grid.Close()
                If sender Is cboDEMLayer Then txtGridSize.Text = Math.Round(gridsize, 1)
            End If
        Else
            lbl.Visible = True
            lbl.Text = "Cell size = ??m"
        End If
    End Sub

    Private Sub lnkClipAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkClipAll.LinkClicked

        Dim lstLayers As New Generic.List(Of String)

        For i As Integer = 1 To 5
            Dim cbo As ComboBox = Choose(i, cboDEMLayer, cboFlowAccLayer, cboFlowDirLayer, cboLakeLayer, cboLandUseLayer)
            If cbo.Text <> "" AndAlso GisUtil.IsLayer(cbo.Text) AndAlso Not cbo.Text.EndsWith("(Clipped)") Then
                Logger.Progress("Clipping " & cbo.Text & "...", i, 6)
                Dim fn As String = GisUtil.LayerFileName(cbo.Text)
                Dim fnClipped As String = String.Format("{0}\{1}{2}", IO.Path.GetDirectoryName(fn), IO.Path.GetFileNameWithoutExtension(fn) & "_Clipped", IO.Path.GetExtension(fn))
                If GisUtil.IsLayerByFileName(fnClipped) Then GisUtil.RemoveLayer(GisUtil.LayerIndex(fnClipped))
                If My.Computer.FileSystem.FileExists(fnClipped) Then My.Computer.FileSystem.DeleteFile(fnClipped)

                If Not ClipGridWithShapefile(GisUtil.LayerFileName(cbo.Text), Project.Layers.Subbasins.Filename, fnClipped) Then Exit Sub

                ''SHAPEMERGE IS NOT IMPLEMENTED, so use method below!

                'Dim sf As New MapWinGIS.Shapefile
                'sf.Open(GisUtil.LayerFileName(cboSubbasinLayer.Text))
                'Dim u As New MapWinGIS.Utils

                'Dim grids(sf.NumShapes - 1) As MapWinGIS.Grid

                'For j As Integer = 0 To sf.NumShapes - 1
                '    Dim tempgrid As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\tempgrid.tif"
                '    If Not MapWinGeoProc.SpatialOperations.ClipGridWithPolygon(GisUtil.LayerFileName(cbo.Text), sf.Shape(j), tempgrid) Then
                '        WarningMsg("Unable to clip grid: " & cbo.Text)
                '        Exit Sub
                '    End If
                '    Dim g As New MapWinGIS.Grid
                '    g.Open(tempgrid)
                '    grids(j) = g
                'Next
                'Dim mergegrid As MapWinGIS.Grid = u.GridMerge(grids, fnClipped)
                'mergegrid.Header.NodataValue = -1

                ''problem with above: all cells outside of polygons are assigned a value of 0, rather than NoDataValue
                'If Not u.GridReplace(mergegrid, 0, -1) Then WarningMsg("Could not replace: " & u.ErrorMsg(u.LastErrorCode))

                'mergegrid.Save(fnClipped)
                'mergegrid.Close()

                'For j As Integer = 0 To sf.NumShapes - 1
                '    grids(j).Close()
                'Next

                'add as layer and reset combo box
                Dim newText As String = cbo.Text & " (Clipped)"
                If GisUtil.IsLayerByFileName(newText) Then GisUtil.RemoveLayer(newText)
                GisUtil.AddGroup(GroupName & " (Clipped)")
                If GisUtil.AddLayerToGroup(fnClipped, newText, GroupName & " (Clipped)") Then
                    FillCombo(cbo)
                    cbo.Text = newText
                End If
                lstLayers.Add(cbo.Text)
            End If
        Next
        Logger.Progress("", 1, 1)
        If lstLayers.Count > 0 AndAlso MessageBox.Show("Do you want to remove the original layers that were clipped?", "Clip Layers", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each s As String In lstLayers
                GisUtil.RemoveLayer(GisUtil.LayerIndex(s))
            Next
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If MessageBox.Show("Are you sure you want to reset all inputs to their default values?", "Reset GBMM", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Project = New clsProject
            LoadForm()
        End If
    End Sub

    Private Sub btnViewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewFile.Click
        If My.Computer.FileSystem.FileExists(Project.FileName) Then
            Shell("Notepad " & Project.FileName, AppWinStyle.NormalFocus)
        End If
    End Sub

    Private Sub LoadResults()
        With Project
            GisUtil.AddGroup(GroupName & " Results")

            'gbmm creates two grids, but assignes .txt as extension; change and load
            For i As Integer = 1 To 2
                Dim fn As String = .Folders.OutputFolder & "\MERCURYOUT\" & Choose(i, "SoilWater.txt", "SoilMercury.txt")
                If My.Computer.FileSystem.FileExists(fn) Then My.Computer.FileSystem.RenameFile(fn, IO.Path.GetFileNameWithoutExtension(fn) & ".asc")
                fn = IO.Path.ChangeExtension(fn, ".asc")
                Dim g As New MapWinGIS.Grid
                g.Open(fn)
                g.AssignNewProjection(GisUtil.ProjectProjection)
                g.Close()
                GisUtil.AddGroup(GroupName & " Results")
                If Not GisUtil.IsLayerByFileName(fn) Then GisUtil.AddLayerToGroup(fn, IO.Path.GetFileNameWithoutExtension(fn), GroupName & " Results")
            Next
            With cboResultsOutput
                .Sorted = False
                .Items.Clear()
                .Items.AddRange(New String() {"Mass Balance", "Source Load", "Output"})
                .SelectedIndex = 0
            End With
        End With
    End Sub

    Private Function GetMinMaxDate(ByVal TableName As String, ByRef MinDate As Date, ByRef MaxDate As Date) As Boolean
        Try
            'open text file and read first column (IDATE) to determine min & max
            MinDate = Date.MaxValue
            MaxDate = Date.MinValue
            Dim sr As New IO.StreamReader(Project.Folders.DataFolder & "\" & TableName)
            Dim line As String = sr.ReadLine
            If line.Split(",")(0) <> "IDATE" Then WarningMsg("Data table first column must be IDATE.") : Return False
            While Not sr.EndOfStream
                line = sr.ReadLine
                Dim ar() As String = line.Split(",")
                If ar.Length = 0 Or Not IsDate(ar(0)) Then WarningMsg("In invalid date was found in the data table; the last line read was: " & line) : Return False
                Dim d As Date = CDate(ar(0))
                If d < MinDate Then MinDate = d
                If d > MaxDate Then MaxDate = d
            End While
            sr.Close()
            sr.Dispose()
            Return True
        Catch ex As Exception
            ErrorMsg("Time series table was improperly formatted; it must be a comma-separated text file with a header line and the first column must contain a properly formatted date value.", ex)
            Return False
        End Try
    End Function

    Private Sub tabMain_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabMain.SelectedIndexChanged
        Try
            If tabMain.SelectedIndex = 4 Then 'Simulate tab
                Dim minDate, maxDate As Date

                If cboClimateDataTable.Text <> "" Then
                    GetMinMaxDate(cboClimateDataTable.Text, minDate, maxDate)
                    lblDateRange.Text = String.Format("Available climate data: {0:MM/dd/yyyy} to {1:MM/dd/yyyy}", minDate, maxDate)
                End If
                If chkHgTimeSeries.Checked Then
                    fraDryHg.Enabled = True
                    fraWetHg.Enabled = True
                    GetMinMaxDate(cboHgDryDepTS.Text, minDate, maxDate)
                    lblDateRange2.Text = String.Format("Available Hg deposition data: {0:MM/dd/yyyy} to {1:MM/dd/yyyy}", minDate, maxDate)
                    GetMinMaxDate(cboHgWetDepTS.Text, minDate, maxDate)
                    lblDateRange3.Text = String.Format("Available Hg deposition data: {0:MM/dd/yyyy} to {1:MM/dd/yyyy}", minDate, maxDate)
                Else
                    fraDryHg.Enabled = False
                    fraWetHg.Enabled = False
                End If
            ElseIf tabMain.SelectedIndex = 5 Then 'Results tab
                LoadResults()
            Else
                lblSimulate.Visible = False
            End If
        Catch ex As Exception
            ErrorMsg("Time series table was improperly formatted; it must be a comma-separated text file with a header line and the first column must contain a properly formatted date value.", ex)
        End Try
    End Sub

    Private Sub cbo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        Project.Modified = True
    End Sub

    Private Sub chk_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Project.Modified = True
    End Sub

    Private Sub dt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtEndClimate.KeyDown, dtEndDry.KeyDown, dtEndSim.KeyDown, dtEndWet.KeyDown, dtStartClimate.KeyDown, dtStartDry.KeyDown, dtStartSim.KeyDown, dtStartWet.KeyDown
        If e.KeyCode = Keys.Return Then SendKeys.Send("{RIGHT}")
        Project.Modified = True
    End Sub

    Dim dictVar As New Generic.Dictionary(Of String, String)

    Private Function ResultFile() As String
        Return String.Format("{0}\MERCURYOUT\Subwatershed{1}_{2}.out", Project.Folders.OutputFolder, Choose(cboResultsOutput.SelectedIndex + 1, "MassBalance", "SourceLoad", "Output"), cboResultsSubbasin.Text)
    End Function

    Private Sub cboResultsOutput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboResultsOutput.SelectedIndexChanged
        Try
            If cboResultsOutput.SelectedIndex = -1 Then Exit Sub
            With Project
                'get list of subbasins 
                cboResultsSubbasin.Items.Clear()
                For Each s As String In My.Computer.FileSystem.GetFiles(.Folders.OutputFolder & "\MERCURYOUT", FileIO.SearchOption.SearchTopLevelOnly, "SubwatershedMassBalance*.out")
                    Dim SubID As Integer = Val(s.Substring(s.LastIndexOf("_") + 1))
                    cboResultsSubbasin.Items.Add(SubID)
                Next
                If cboResultsSubbasin.Items.Count = 0 Then Exit Sub
                cboResultsSubbasin.SelectedIndex = 0

                Dim sr As New IO.StreamReader(ResultFile)

                'variable names start on line 23
                For i As Integer = 1 To 22
                    sr.ReadLine()
                Next

                dictVar.Clear()
                Dim line As String = sr.ReadLine
                Do While line.Trim <> "TT"
                    Dim ar() As String = line.Split(New Char() {" "}, StringSplitOptions.RemoveEmptyEntries)
                    Dim ID As String = ar(1)
                    Dim Name As String = ""
                    For i As Integer = 2 To ar.Length - 1
                        Name &= IIf(i = 2, "", " ") & ar(i)
                    Next
                    dictVar.Add(ID, Name)
                    line = sr.ReadLine
                Loop
                sr.Close()
                sr.Dispose()
                lstVariables.Items.Clear()
                For Each kv As KeyValuePair(Of String, String) In dictVar
                    lstVariables.Items.Add(kv.Value)
                Next

                'all variables have been unselected; show pane
                If btnVariables.Text.StartsWith("Show") Then btnVariables.PerformClick()

                If lstVariables.Items.Count = 0 Then Exit Sub
                cboResultsSubbasin.SelectedIndex = 0
                RefreshResults()
            End With
        Catch ex As Exception
            ErrorMsg(, ex)
        End Try
    End Sub

    Private Sub btnVariables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVariables.Click
        If btnVariables.Text.StartsWith("Show") Then
            splitResults.Panel2Collapsed = False
            btnVariables.Text = "Hide Variables"
        Else
            splitResults.Panel2Collapsed = True
            btnVariables.Text = "Show Variables"
        End If
    End Sub

    Private Sub RefreshResults()
        Try
            If lstVariables.CheckedIndices.Count = 0 Or cboResultsSubbasin.SelectedIndex = -1 Then Zed.Visible = False : wbResults.DocumentText = "" : Exit Sub

            Zed.Visible = True

            With Zed.GraphPane
                .Title.Text = cboResultsOutput.Text
                .XAxis.Title.Text = ""
                .XAxis.Type = ZedGraph.AxisType.DateDual
                .XAxis.Scale.FontSpec.Size = 9
                .YAxis.Title.Text = ""
                .YAxis.Scale.FontSpec.Size = 9
                .YAxis.Type = ZedGraph.AxisType.Linear
                .XAxis.MajorGrid.IsVisible = True
                .XAxis.MinorGrid.IsVisible = True
                .YAxis.MajorGrid.IsVisible = True
                .CurveList.Clear()
                .Legend.IsVisible = True
                .Legend.Position = ZedGraph.LegendPos.Bottom
                .IsFontsScaled = False
                .IsPenWidthScaled = False
            End With
            Dim crv(lstVariables.Items.Count - 1) As ZedGraph.LineItem
            Dim csr As New ZedGraph.ColorSymbolRotator
            For i As Integer = 0 To lstVariables.Items.Count - 1
                If lstVariables.GetItemChecked(i) Then
                    crv(i) = New ZedGraph.LineItem(CStr(lstVariables.Items(i)))
                    crv(i).Symbol.Type = ZedGraph.SymbolType.None
                    crv(i).Line.Color = csr.NextColor
                    Zed.GraphPane.CurveList.Add(crv(i))
                End If
            Next

            Dim hb As New clsHTMLBuilder
            hb.AppendHeading(clsHTMLBuilder.enumHeading.Level2, clsHTMLBuilder.enumAlign.Center, "BASINS Grid-Based Mercury Model (GBMM)")

            With Project
                hb.AppendTable(100, clsHTMLBuilder.enumWidthUnits.Percent, clsHTMLBuilder.enumBorderStyle.none, , clsHTMLBuilder.enumDividerStyle.None)
                hb.AppendTableColumn("", , , 200, clsHTMLBuilder.enumWidthUnits.Pixels)
                hb.AppendTableColumn("")

                hb.AppendTableRow("Filename:", .FileName)
                hb.AppendTableRowEmpty()
                hb.AppendTableRow("Input Folder:", .Folders.InputFolder)
                hb.AppendTableRow("Output Folder:", .Folders.OutputFolder)
                hb.AppendTableRowEmpty()
                hb.AppendTableRow("Subbasins Layer:", .Layers.Subbasins.LayerName)
                hb.AppendTableRow("DEM Layer:", .Layers.DEM.LayerName)
                hb.AppendTableRow("Grid Size (m):", .GridSize)
                hb.AppendTableRow("Stream Area Threshold (sq km):", .StreamThreshold)
                hb.AppendTableRowEmpty()
                hb.AppendTableRow("Soil Type Layer:", .Layers.Soils.LayerName)
                hb.AppendTableRow("Soil Type Field:", .Layers.Soils.FieldName)
                hb.AppendTableRow("Soil Property Table:", .Tables.Soils.TableName)
                hb.AppendTableRowEmpty()
                hb.AppendTableRow("Land Use Layer Type:", .LanduseType.ToString)
                If .LanduseType <> enumLandUseType.GIRAS Then
                    hb.AppendTableRow("Land Use Layer:", .Layers.Landuse.LayerName)
                    If .LanduseType = enumLandUseType.UserShapefile Then
                        hb.AppendTableRow("Land Use Field:", .Layers.Landuse.FieldName)
                    End If
                End If
                hb.AppendTableRow("Land Use Parameter Table:", .Tables.LandUse.TableName)
                hb.AppendTableRow("Land Use Curve Number Table:", .Tables.LandUseCN.TableName)
                hb.AppendTableRowEmpty()
                hb.AppendTableRow("Climate Stations Layer:", .Layers.ClimateSta.LayerName)
                hb.AppendTableRow("Climate Time Series Table:", .Tables.Climate.TableName)
                hb.AppendTableRowEmpty()
                If .Layers.PointSources.LayerName <> "" Then
                    hb.AppendTableRow("Point Sources Layer:", .Layers.PointSources.LayerName)
                    hb.AppendTableRow("Point Sources Field:", .Layers.PointSources.FieldName)
                    hb.AppendTableRow("Point Source Time Series Table:", .Tables.PointSource.TableName)
                    hb.AppendTableRowEmpty()
                End If
                hb.AppendTableRow("Output Type:", cboResultsOutput.Text)
                hb.AppendTableRow("Subbasin No.:", cboResultsSubbasin.Text)
                hb.AppendTableRowEmpty()

            End With

            Dim sr As New IO.StreamReader(ResultFile)
            Dim line As String
            Do
                line = sr.ReadLine
            Loop Until Not line.StartsWith("TT")
            Dim lstExtraInfo As New Generic.List(Of String)
            Do
                lstExtraInfo.Add(line)
                line = sr.ReadLine
            Loop Until line.StartsWith("DATE" & vbTab)

            For Each s As String In lstExtraInfo
                hb.AppendTableRow(s.Split(":")(0) & ":", Val(s.Split(":")(1)).ToString("0,000.00"))
            Next
            hb.AppendTableEnd()
            hb.AppendHeading(clsHTMLBuilder.enumHeading.Level4, clsHTMLBuilder.enumAlign.Left, "Time Series Output:")
            hb.AppendTable()
            hb.AppendTableColumn("Date", , clsHTMLBuilder.enumAlign.Right, 75, clsHTMLBuilder.enumWidthUnits.Pixels)
            For i As Integer = 0 To lstVariables.Items.Count - 1
                If lstVariables.GetItemChecked(i) Then
                    hb.AppendTableColumn(CStr(lstVariables.Items(i)).Replace("Evapotranspiration", "Evapo- transpiration"), , clsHTMLBuilder.enumAlign.Right, 75, clsHTMLBuilder.enumWidthUnits.Pixels)
                End If
            Next
            Do
                hb.AppendTableRow()
                line = sr.ReadLine
                Dim ar() As String = line.Split(vbTab)
                Dim dt As Date = CDate(ar(0))
                hb.AppendTableCell(dt)
                For i As Integer = 0 To lstVariables.Items.Count - 1
                    If lstVariables.GetItemChecked(i) Then
                        Dim result As Double = ar(i + 1)
                        crv(i).AddPoint(dt.ToOADate, result)
                        hb.AppendTableCell(result.ToString("0.00"))
                    End If
                Next
                hb.AppendTableCellEnd()
            Loop Until sr.EndOfStream
            hb.AppendTableRowEnd()
            hb.AppendTableEnd()
            hb.Save(Project.Folders.OutputFolder & "\GBMM.htm")
            wbResults.Navigate(Project.Folders.OutputFolder & "\GBMM.htm")
            sr.Close()
            sr.Dispose()
            Zed.GraphPane.AxisChange()
            Zed.Refresh()
        Catch ex As Exception
            ErrorMsg(, ex)
        End Try
    End Sub

    Private Sub lstVariables_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstVariables.SelectedIndexChanged
        RefreshResults()
    End Sub

    Private Sub cboResultsSubbasin_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboResultsSubbasin.SelectionChangeCommitted
        RefreshResults()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click, SelectNoneToolStripMenuItem.Click
        For i As Integer = 0 To lstVariables.Items.Count - 1
            lstVariables.SetItemChecked(i, sender Is SelectAllToolStripMenuItem)
        Next
        RefreshResults()
    End Sub

    '''' <summary>
    '''' Merge all shapes in one shape file return merged shape
    '''' </summary>
    '''' <param name="aLayerIndexSource">Index of source layer having selected shaped</param>
    '''' <returns></returns>
    '''' <remarks>Programmed by LCW for GBMM project</remarks>
    '<CLSCompliant(False)> _
    'Public Shared Function MergeAllShapes(ByVal aLayerIndexSource As Integer) As MapWinGIS.Shape
    '    Try
    '        'build collection of selected shape indexes
    '        Dim lSelectedShapeIndexes As New atcCollection
    '        For lIndex As Integer = 1 To NumFeatures(aLayerIndexSource)
    '            lSelectedShapeIndexes.Add(lIndex - 1)
    '        Next
    '        lSelectedShapeIndexes.Sort()
    '        If lSelectedShapeIndexes.Count = 0 Then Return Nothing

    '        'copy source file to temp file
    '        Dim tempfile As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\tempfile.shp"

    '        If Not MapWinGeoProc.DataManagement.CopyShapefile(LayerFileName(aLayerIndexSource), tempfile) Then Return Nothing

    '        Dim mergeShp As MapWinGIS.Shape

    '        Dim sfSource As New MapWinGIS.Shapefile

    '        With sfSource
    '            If Not .Open(tempfile) Then Return Nothing
    '            If Not .StartEditingShapes(True) Then Return Nothing

    '            'insert first shape at end
    '            If Not .EditInsertShape(.Shape(lSelectedShapeIndexes(0)), .NumShapes) Then Return Nothing

    '            For i As Integer = 1 To lSelectedShapeIndexes.Count - 1
    '                Dim newShp As New MapWinGIS.Shape
    '                If Not newShp.Create(.ShapefileType) Then Return Nothing
    '                If Not MapWinGeoProc.SpatialOperations.MergeShapes(sfSource, lSelectedShapeIndexes(i), .NumShapes - 1, newShp) Then Return Nothing
    '                'replace last shape with this one
    '                If Not .EditDeleteShape(.NumShapes - 1) Then Return Nothing
    '                If Not .EditInsertShape(newShp, .NumShapes) Then Return Nothing
    '                If pStatusShow Then Logger.Progress("Merging shapes...", i, lSelectedShapeIndexes.Count - 1)
    '                System.Windows.Forms.Application.DoEvents()
    '            Next

    '            'now all selected have been merged into last shape; save it for later
    '            mergeShp = .Shape(.NumShapes - 1)

    '            If Not .StopEditingShapes(False, True) Then Return Nothing
    '            If Not .Close() Then Return Nothing
    '            My.Computer.FileSystem.DeleteFile(tempfile)
    '        End With

    '        Return mergeShp

    '    Catch ex As Exception
    '        Throw ex
    '        Return Nothing
    '    Finally
    '        Logger.Progress("", 100, 100) 'clear the progressbar
    '    End Try
    'End Function

End Class

