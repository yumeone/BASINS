'Copyright 2006 AQUA TERRA Consultants - Royalty-free use permitted under open source license
Option Strict Off
Option Explicit On

Imports System.Text

Public Class HspfConnection
    Private pMFact As Double
    Private pMFactAsRead As String
    Private pTyp As Integer '1-ExtSource,2-Network,3-Schematic,4-ExtTarget
    Private pTran As String
    Private pSgapstrg As String
    Private pAmdstrg As String
    Private pSsystem As String
    Private pSource As HspfSrcTar
    Private pTarget As HspfSrcTar
    Private pMassLink As Integer
    Private pUci As HspfUci
    Private pDesiredType As String
    Private pComment As String = ""

    Public Property MFact() As Double
        Get
            Return pMFact
        End Get
        Set(ByVal Value As Double)
            pMFact = Value
        End Set
    End Property

    Public Property MFactAsRead() As String
        Get
            Return pMFactAsRead
        End Get
        Set(ByVal Value As String)
            pMFactAsRead = Value
        End Set
    End Property

    Public Property Uci() As HspfUci
        Get
            Return pUci
        End Get
        Set(ByVal Value As HspfUci)
            pUci = Value
        End Set
    End Property

    Public Property Source() As HspfSrcTar
        Get
            Return pSource
        End Get
        Set(ByVal Value As HspfSrcTar)
            pSource = Value
        End Set
    End Property

    Public Property Target() As HspfSrcTar
        Get
            Return pTarget
        End Get
        Set(ByVal Value As HspfSrcTar)
            pTarget = Value
        End Set
    End Property

    Public Property Tran() As String
        Get
            Return pTran
        End Get
        Set(ByVal Value As String)
            pTran = Value
        End Set
    End Property


    Public Property Comment() As String
        Get
            Return pComment
        End Get
        Set(ByVal Value As String)
            pComment = Value
        End Set
    End Property

    Public Property Ssystem() As String
        Get
            Return pSsystem
        End Get
        Set(ByVal Value As String)
            pSsystem = Value
        End Set
    End Property

    Public Property Sgapstrg() As String
        Get
            Return pSgapstrg
        End Get
        Set(ByVal Value As String)
            pSgapstrg = Value
        End Set
    End Property

    Public Property Amdstrg() As String
        Get
            Return pAmdstrg
        End Get
        Set(ByVal Value As String)
            pAmdstrg = Value
        End Set
    End Property
    Public Property Typ() As Integer
        Get
            Return pTyp
        End Get
        Set(ByVal Value As Integer)
            pTyp = Value
        End Set
    End Property

    Public Property MassLink() As Integer
        Get
            Return pMassLink
        End Get
        Set(ByVal Value As Integer)
            pMassLink = Value
        End Set
    End Property
    Public ReadOnly Property EditControlName() As String
        Get
            Return "ATCoHspf.ctlConnectionEdit"
        End Get
    End Property
    Public ReadOnly Property DesiredRecordType() As String
        Get
            Return pDesiredType
        End Get
    End Property
    Public ReadOnly Property Caption() As String
        Get
            Return pDesiredType & " Block"
        End Get
    End Property

    Public Sub readTimSer(ByRef aUci As HspfUci)
        Dim lConnection As HspfConnection
        Dim lRecTyp As Integer
        Dim lRetCod As Integer
        Dim lBuff As String = Nothing
        Dim s As String

        pUci = aUci

        Dim lOmCode As Integer = HspfOmCode("EXT SOURCES")
        Dim lInit As Integer = 1
        Dim lComment As String = ""
        Dim lPastHeader As Boolean = False
        Dim lRetKey As Integer = -1
        Do
            If aUci.FastFlag Then
                GetNextRecordFromBlock("EXT SOURCES", lRetKey, lBuff, lRecTyp, lRetCod)
            Else
                lRetKey = -1
                REM_XBLOCKEX(aUci, lOmCode, lInit, lRetKey, lBuff, lRecTyp, lRetCod)
            End If
            If lRetCod <> 2 Then Exit Do
            lInit = 0
            If lRecTyp = 0 Then
                lConnection = New HspfConnection
                lConnection.Uci = aUci
                lConnection.Typ = 1
                lConnection.Source.VolName = Trim(Left(lBuff, 6))
                lConnection.Source.VolId = CInt(Mid(lBuff, 7, 4))
                lConnection.Source.Member = Trim(Mid(lBuff, 12, 6))
                s = Trim(Mid(lBuff, 18, 2))
                If s.Length > 0 Then
                    lConnection.Source.MemSub1 = CInt(s)
                End If
                lConnection.Ssystem = Mid(lBuff, 21, 4)
                lConnection.Sgapstrg = Mid(lBuff, 25, 4)
                s = Trim(Mid(lBuff, 29, 10))
                lConnection.MFactAsRead = Mid(lBuff, 29, 10)
                If s.Length > 0 Then
                    lConnection.MFact = CDbl(s)
                End If
                s = Mid(lBuff, 39, 4)
                If s.Length > 0 Then
                    lConnection.Tran = s
                End If
                lConnection.Target.VolName = Trim(Mid(lBuff, 44, 6))
                lConnection.Target.VolId = CInt(Mid(lBuff, 51, 3))
                s = Trim(Mid(lBuff, 55, 3))
                If s.Length > 0 Then lConnection.Target.VolIdL = CInt(s)
                lConnection.Target.Group = Trim(Mid(lBuff, 59, 6))
                lConnection.Target.Member = Trim(Mid(lBuff, 66, 6))
                s = Trim(Mid(lBuff, 72, 2))
                If s.Length > 0 And IsNumeric(s) Then
                    lConnection.Target.MemSub1 = CInt(s)
                Else
                    If s.Length > 0 Then lConnection.Target.MemSub1 = aUci.CatAsInt(s)
                End If
                s = Trim(Mid(lBuff, 74, 2))
                If s.Length > 0 And IsNumeric(s) Then
                    lConnection.Target.MemSub2 = CInt(s)
                Else
                    If s.Length > 0 Then lConnection.Target.MemSub2 = aUci.CatAsInt(s)
                End If
                lConnection.Comment = lComment
                aUci.Connections.Add(lConnection)
                lComment = ""
            ElseIf lRecTyp = -1 And lRetCod <> 1 Then
                'save comment
                If lBuff.StartsWith("<Name>") Then 'a cheap rule to identify the last header line
                    lPastHeader = True
                ElseIf lPastHeader Then
                    If lComment.Length = 0 Then
                        lComment = lBuff
                    Else
                        lComment &= vbCrLf & lBuff
                    End If
                End If
            End If
        Loop

        lOmCode = HspfOmCode("NETWORK")
        lInit = 1
        lComment = ""
        lPastHeader = False
        lRetKey = -1
        Do
            If aUci.FastFlag Then
                GetNextRecordFromBlock("NETWORK", lRetKey, lBuff, lRecTyp, lRetCod)
            Else
                lRetKey = -1
                Call REM_XBLOCKEX(aUci, lOmCode, lInit, lRetKey, lBuff, lRecTyp, lRetCod)
            End If
            If lRetCod <> 2 Then Exit Do
            lInit = 0
            If lRecTyp = 0 Then
                lConnection = New HspfConnection
                lConnection.Uci = aUci
                lConnection.Typ = 2
                lConnection.Source.VolName = Trim(Left(lBuff, 6))
                lConnection.Source.VolId = CInt(Mid(lBuff, 7, 4))
                lConnection.Source.Group = Trim(Mid(lBuff, 12, 6))
                lConnection.Source.Member = Trim(Mid(lBuff, 19, 6))
                s = Trim(Mid(lBuff, 25, 2))
                If s.Length > 0 And IsNumeric(s) Then
                    lConnection.Source.MemSub1 = CInt(s)
                Else
                    If s.Length > 0 Then lConnection.Source.MemSub1 = aUci.CatAsInt(s)
                End If
                s = Trim(Mid(lBuff, 27, 2))
                If s.Length > 0 And IsNumeric(s) Then
                    lConnection.Source.MemSub2 = CInt(s)
                Else
                    If s.Length > 0 Then lConnection.Source.MemSub2 = aUci.CatAsInt(s)
                End If
                s = Trim(Mid(lBuff, 29, 10))
                lConnection.MFactAsRead = Mid(lBuff, 29, 10)
                If s.Length > 0 Then lConnection.MFact = CDbl(s)
                lConnection.Tran = Trim(Mid(lBuff, 39, 4))
                lConnection.Target.VolName = Trim(Mid(lBuff, 44, 6))
                lConnection.Target.VolId = CInt(Mid(lBuff, 51, 3))
                s = Trim(Mid(lBuff, 55, 3))
                If s.Length > 0 Then lConnection.Target.VolIdL = CInt(s)
                lConnection.Target.Group = Trim(Mid(lBuff, 59, 6))
                lConnection.Target.Member = Trim(Mid(lBuff, 66, 6))
                s = Trim(Mid(lBuff, 72, 2))
                If s.Length > 0 And IsNumeric(s) Then
                    lConnection.Target.MemSub1 = CInt(s)
                Else
                    If s.Length > 0 Then lConnection.Target.MemSub1 = aUci.CatAsInt(s)
                End If
                s = Trim(Mid(lBuff, 74, 2))
                If s.Length > 0 And IsNumeric(s) Then
                    lConnection.Target.MemSub2 = CInt(s)
                Else
                    If s.Length > 0 Then lConnection.Target.MemSub2 = aUci.CatAsInt(s)
                End If
                lConnection.Comment = lComment
                aUci.Connections.Add(lConnection)
                lComment = ""
            ElseIf lRecTyp = -1 And lRetCod <> 1 Then
                'save comment
                If lBuff.StartsWith("<Name>") Then 'a cheap rule to identify the last header line
                    lPastHeader = True
                ElseIf lPastHeader Then
                    If lComment.Length = 0 Then
                        lComment = lBuff
                    Else
                        lComment &= vbCrLf & lBuff
                    End If
                End If
            End If
        Loop

        lOmCode = HspfOmCode("SCHEMATIC")
        lInit = 1
        lComment = ""
        lPastHeader = False
        lRetKey = -1
        Do
            If aUci.FastFlag Then
                GetNextRecordFromBlock("SCHEMATIC", lRetKey, lBuff, lRecTyp, lRetCod)
            Else
                lRetKey = -1
                Call REM_XBLOCKEX(aUci, lOmCode, lInit, lRetKey, lBuff, lRecTyp, lRetCod)
            End If
            If lRetCod <> 2 Then Exit Do
            lInit = 0
            If lRecTyp = 0 Then
                lConnection = New HspfConnection
                lConnection.Uci = aUci
                lConnection.Typ = 3
                lConnection.Source.VolName = Trim(Left(lBuff, 6))
                lConnection.Source.VolId = CInt(Mid(lBuff, 7, 4))
                s = Trim(Mid(lBuff, 29, 10))
                lConnection.MFactAsRead = Mid(lBuff, 29, 10)
                If s.Length > 0 Then lConnection.MFact = CDbl(s)
                lConnection.Target.VolName = Trim(Mid(lBuff, 44, 6))
                lConnection.Target.VolId = CInt(Mid(lBuff, 50, 4))
                lConnection.MassLink = CInt(Mid(lBuff, 57, 4))
                s = Trim(Mid(lBuff, 72, 2))
                If s.Length > 0 And IsNumeric(s) Then
                    lConnection.Target.MemSub1 = CInt(s)
                Else
                    If s.Length > 0 Then lConnection.Target.MemSub1 = aUci.CatAsInt(s)
                End If
                s = Trim(Mid(lBuff, 74, 2))
                If s.Length > 0 And IsNumeric(s) Then
                    lConnection.Target.MemSub2 = CInt(s)
                Else
                    If s.Length > 0 Then lConnection.Target.MemSub2 = aUci.CatAsInt(s)
                End If
                lConnection.Comment = lComment
                aUci.Connections.Add(lConnection)
                lComment = ""
            ElseIf lRecTyp = -1 And lRetCod <> 1 Then
                'save comment
                If lBuff.StartsWith("<Name>") Then 'a cheap rule to identify the last header line
                    lPastHeader = True
                ElseIf lPastHeader Then
                    If lComment.Length = 0 Then
                        lComment = lBuff
                    Else
                        lComment &= vbCrLf & lBuff
                    End If
                End If
            End If
        Loop

        lOmCode = HspfOmCode("EXT TARGETS")
        lInit = 1
        lComment = ""
        lPastHeader = False
        lRetKey = -1
        Do
            If aUci.FastFlag Then
                GetNextRecordFromBlock("EXT TARGETS", lRetKey, lBuff, lRecTyp, lRetCod)
            Else
                lRetKey = -1
                Call REM_XBLOCKEX(aUci, lOmCode, lInit, lRetKey, lBuff, lRecTyp, lRetCod)
            End If
            If lRetCod <> 2 Then Exit Do
            lInit = 0
            If lRecTyp = 0 Then
                lConnection = New HspfConnection
                lConnection.Uci = aUci
                lConnection.Typ = 4
                lConnection.Source.VolName = Trim(Left(lBuff, 6))
                lConnection.Source.VolId = CInt(Mid(lBuff, 7, 4))
                lConnection.Source.Group = Trim(Mid(lBuff, 12, 6))
                lConnection.Source.Member = Trim(Mid(lBuff, 19, 6))
                s = Trim(Mid(lBuff, 25, 2))
                If s.Length > 0 And IsNumeric(s) Then
                    lConnection.Source.MemSub1 = CInt(s)
                Else
                    If s.Length > 0 Then
                        lConnection.Source.MemSub1 = aUci.CatAsInt(s)
                    End If
                End If
                s = Trim(Mid(lBuff, 27, 2))
                If s.Length > 0 And IsNumeric(s) Then
                    lConnection.Source.MemSub2 = CInt(s)
                Else
                    If s.Length > 0 Then
                        lConnection.Source.MemSub1 = aUci.CatAsInt(s)
                    End If
                End If
                s = Trim(Mid(lBuff, 29, 10))
                lConnection.MFactAsRead = Mid(lBuff, 29, 10)
                If s.Length > 0 Then lConnection.MFact = CDbl(s)
                s = Trim(Mid(lBuff, 39, 4))
                If s.Length > 0 Then lConnection.Tran = s
                lConnection.Target.VolName = Trim(Mid(lBuff, 44, 6))
                lConnection.Target.VolId = CInt(Mid(lBuff, 50, 4))
                lConnection.Target.Member = Trim(Mid(lBuff, 55, 6))
                s = Trim(Mid(lBuff, 61, 2))
                If s.Length > 0 Then lConnection.Target.MemSub1 = CInt(s)
                lConnection.Ssystem = Trim(Mid(lBuff, 64, 4))
                lConnection.Sgapstrg = Trim(Mid(lBuff, 69, 4))
                lConnection.Amdstrg = Trim(Mid(lBuff, 74, 4))
                lConnection.Comment = lComment
                aUci.Connections.Add(lConnection)
                lComment = ""
            ElseIf lRecTyp = -1 And lRetCod <> 1 Then
                'save comment
                If lBuff.StartsWith("<Name>") Then 'a cheap rule to identify the last header line
                    lPastHeader = True
                ElseIf lPastHeader Then
                    If lComment.Length = 0 Then
                        lComment = lBuff
                    Else
                        lComment &= vbCrLf & lBuff
                    End If
                End If
            End If
        Loop
    End Sub

    Public Sub New()
        MyBase.New()
        pSource = New HspfSrcTar
        pTarget = New HspfSrcTar
        pTyp = 0
        pMFact = 1.0#
    End Sub
    Public Sub EditExtSrc()
        pDesiredType = "EXT SOURCES"
        editInit(Me, Me.Uci.icon, True) 'add remove ok
    End Sub
    Public Sub EditExtTar()
        pDesiredType = "EXT TARGETS"
        editInit(Me, Me.Uci.icon, True) 'add remove ok
    End Sub
    Public Sub EditNetwork()
        pDesiredType = "NETWORK"
        editInit(Me, Me.Uci.icon, True) 'add remove ok
    End Sub
    Public Sub EditSchematic()
        pDesiredType = "SCHEMATIC"
        editInit(Me, Me.Uci.icon, True) 'add remove ok
    End Sub

    Public Overrides Function ToString() As String
        Dim lSB As New StringBuilder

        'ext sources, network, schematic, ext targets
        Static lTypeExists() As Boolean = {False, False, False, False}

        If pUci.MetSegs.Count > 0 Then
            lTypeExists(0) = True
        End If
        If pUci.PointSources.Count > 0 Then
            lTypeExists(0) = True
        End If

        Dim lOpnSeqBlock As HspfOpnSeqBlk = pUci.OpnSeqBlock
        For Each lOperation As HspfOperation In lOpnSeqBlock.Opns
            For Each lConnection As HspfConnection In lOperation.Targets
                lTypeExists(lConnection.Typ - 1) = True
            Next lConnection
            For Each lConnection As HspfConnection In lOperation.Sources
                lTypeExists(lConnection.Typ - 1) = True
            Next lConnection
        Next lOperation

        For lTypeIndex As Integer = 1 To 4
            If lTypeExists(lTypeIndex - 1) Then
                Dim lBlockName As String = ""
                Select Case lTypeIndex
                    Case 1 : lBlockName = "EXT SOURCES"
                    Case 2 : lBlockName = "NETWORK"
                    Case 3 : lBlockName = "SCHEMATIC"
                    Case 4 : lBlockName = "EXT TARGETS"
                End Select
                Dim lBlockDef As HspfBlockDef = pUci.Msg.BlockDefs.Item(lBlockName)
                Dim lTableDef As HspfTableDef = lBlockDef.TableDefs.Item(0)
                'get lengths and starting positions
                Dim lParmDefIndex As Integer = 0
                Dim iCol(15) As Integer
                Dim iLen(15) As Integer
                For Each lParmDef As HSPFParmDef In lTableDef.ParmDefs
                    iCol(lParmDefIndex) = lParmDef.StartCol
                    iLen(lParmDefIndex) = lParmDef.Length
                    lParmDefIndex += 1
                Next lParmDef
                If lTypeIndex > 1 Then
                    'don't need another blank line before ext sources
                    lSB.AppendLine(" ")
                End If
                lSB.AppendLine(lBlockName)
                'now start building the records
                Select Case lTypeIndex
                    Case 1 'ext srcs
                        lSB.AppendLine("<-Volume-> <Member> SsysSgap<--Mult-->Tran <-Target vols> <-Grp> <-Member-> ***")
                        lSB.AppendLine("<Name>   x <Name> x tem strg<-factor->strg <Name>   x   x        <Name> x x ***")
                        'do met segs - operations with assoc met segs
                        Static lOpTypes() As String = {"PERLND", "IMPLND", "RCHRES"}
                        For Each OpTyp As String In lOpTypes
                            For Each lMetSeg As HspfMetSeg In pUci.MetSegs
                                lSB.AppendLine(lMetSeg.ToStringFromSpecs(OpTyp, iCol, iLen))
                            Next
                        Next
                        'If pUci.PointSources.Count > 0 And pUci.MetSegs.Count > 0 Then
                        '    lSB.AppendLine("") 'write a blank line between met segs and pt srcs
                        'End If
                        'do point sources
                        For Each lPtSrc As HspfPointSource In pUci.PointSources
                            lSB.AppendLine(lPtSrc.ToStringFromSpecs(iCol, iLen))
                        Next
                        'now do everything else
                        For Each lOperation As HspfOperation In lOpnSeqBlock.Opns
                            For Each lConnection As HspfConnection In lOperation.Sources
                                If lConnection.Typ = lTypeIndex Then
                                    If lConnection.Comment.Length > 0 Then
                                        lSB.Append(lConnection.Comment)
                                    End If
                                    Dim lStr As New StringBuilder
                                    lStr.Append(lConnection.Source.VolName.Trim)
                                    lStr.Append(Space(iCol(1) - lStr.Length - 1)) 'pad prev field
                                    Dim t As String = Space(iLen(1)) 'right justify numbers
                                    t = RSet(CStr(lConnection.Source.VolId), Len(t))
                                    lStr.Append(t)
                                    lStr.Append(Space(iCol(2) - lStr.Length - 1))
                                    lStr.Append(lConnection.Source.Member)
                                    lStr.Append(Space(iCol(3) - lStr.Length - 1))
                                    If lConnection.Source.MemSub1 <> 0 Then
                                        t = Space(iLen(3))
                                        t = RSet(CStr(lConnection.Source.MemSub1), Len(t))
                                        If lConnection.Source.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Source.Member, 1, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lStr.Append(Space(iCol(4) - lStr.Length - 1))
                                    lStr.Append(lConnection.Ssystem)
                                    lStr.Append(Space(iCol(5) - lStr.Length - 1))
                                    lStr.Append(lConnection.Sgapstrg)
                                    lStr.Append(Space(iCol(6) - lStr.Length - 1))
                                    If NumericallyTheSame((lConnection.MFactAsRead), (lConnection.MFact)) Then
                                        lStr.Append(lConnection.MFactAsRead)
                                    ElseIf lConnection.MFact <> 1 Then
                                        lStr.Append(CStr(lConnection.MFact).PadLeft(iLen(6)))
                                    End If
                                    lStr.Append(Space(iCol(7) - lStr.Length - 1))
                                    lStr.Append(lConnection.Tran)
                                    lStr.Append(Space(iCol(8) - lStr.Length - 1))
                                    lStr.Append(lOperation.Name)
                                    lStr.Append(Space(iCol(9) - lStr.Length - 1))
                                    lStr.Append(CStr(lOperation.Id).PadLeft(iLen(9)))
                                    lStr.Append(Space(iCol(11) - lStr.Length - 1))
                                    lStr.Append(lConnection.Target.Group)
                                    lStr.Append(Space(iCol(12) - lStr.Length - 1))
                                    lStr.Append(lConnection.Target.Member)
                                    lStr.Append(Space(iCol(13) - lStr.Length - 1))
                                    If lConnection.Target.MemSub1 <> 0 Then
                                        t = CStr(lConnection.Target.MemSub1).PadLeft(iLen(13))
                                        If lConnection.Target.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Target.Member, 1, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lStr.Append(Space(iCol(14) - lStr.Length - 1))
                                    If lConnection.Target.MemSub2 <> 0 Then
                                        t = CStr(lConnection.Target.MemSub2).PadLeft(iLen(14))
                                        If lConnection.Target.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Target.Member, 2, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lSB.AppendLine(lStr.ToString)
                                End If
                            Next lConnection
                        Next lOperation
                    Case 2 'network
                        lSB.AppendLine("<-Volume-> <-Grp> <-Member-><--Mult-->Tran <-Target vols> <-Grp> <-Member->  ***")
                        lSB.AppendLine("<Name>   x        <Name> x x<-factor->strg <Name>   x   x        <Name> x x  ***")
                        For Each lOperation As HspfOperation In lOpnSeqBlock.Opns
                            For Each lConnection As HspfConnection In lOperation.Sources 'used to go thru targets, misses range
                                If lConnection.Typ = lTypeIndex Then
                                    If lConnection.Comment.Length > 0 Then
                                        lSB.AppendLine(lConnection.Comment)
                                    End If
                                    Dim lStr As New StringBuilder
                                    lStr.Append(lConnection.Source.VolName.Trim)
                                    lStr.Append(Space(iCol(1) - lStr.Length - 1)) 'pad prev field
                                    lStr.Append(CStr(lConnection.Source.VolId).PadLeft(iLen(1)))
                                    lStr.Append(Space(iCol(2) - lStr.Length - 1))
                                    lStr.Append(lConnection.Source.Group)
                                    lStr.Append(Space(iCol(3) - lStr.Length - 1))
                                    lStr.Append(lConnection.Source.Member)
                                    lStr.Append(Space(iCol(4) - lStr.Length - 1))
                                    If lConnection.Source.MemSub1 <> 0 Then
                                        Dim t As String = CStr(lConnection.Source.MemSub1).PadLeft(iLen(4))
                                        If lConnection.Source.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Source.Member, 1, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lStr.Append(Space(iCol(5) - lStr.Length - 1))
                                    If lConnection.Source.MemSub2 <> 0 Then
                                        Dim t As String = CStr(lConnection.Source.MemSub2).PadLeft(iLen(5))
                                        If lConnection.Source.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Source.Member, 2, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lStr.Append(Space(iCol(6) - lStr.Length - 1))
                                    If NumericallyTheSame((lConnection.MFactAsRead), _
                                                          (lConnection.MFact)) Then
                                        lStr.Append(lConnection.MFactAsRead)
                                    ElseIf lConnection.MFact <> 1 Then
                                        lStr.Append(CStr(lConnection.MFact).PadLeft(iLen(6)))
                                    End If
                                    lStr.Append(Space(iCol(7) - lStr.Length - 1))
                                    lStr.Append(lConnection.Tran)
                                    lStr.Append(Space(iCol(8) - lStr.Length - 1))
                                    lStr.Append(lOperation.Name)
                                    lStr.Append(Space(iCol(9) - lStr.Length - 1))
                                    lStr.Append(CStr(lOperation.Id).PadLeft(iLen(9)))
                                    lStr.Append(Space(iCol(11) - lStr.Length - 1))
                                    lStr.Append(lConnection.Target.Group)
                                    lStr.Append(Space(iCol(12) - lStr.Length - 1))
                                    lStr.Append(lConnection.Target.Member)
                                    lStr.Append(Space(iCol(13) - lStr.Length - 1))
                                    If lConnection.Target.MemSub1 <> 0 Then
                                        Dim t As String = CStr(lConnection.Target.MemSub1).PadLeft(iLen(13))
                                        If lConnection.Target.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Target.Member, 1, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lStr.Append(Space(iCol(14) - lStr.Length - 1))
                                    If lConnection.Target.MemSub2 <> 0 Then
                                        Dim t As String = CStr(lConnection.Target.MemSub2).PadLeft(iLen(14))
                                        If lConnection.Target.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Target.Member, 2, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lSB.AppendLine(lStr.ToString)
                                End If
                            Next lConnection
                        Next lOperation
                    Case 3 'schematic
                        lSB.AppendLine("<-Volume->                  <--Area-->     <-Volume->  <ML#> ***       <sb>")
                        lSB.AppendLine("<Name>   x                  <-factor->     <Name>   x        ***        x x")
                        For Each lOperation As HspfOperation In lOpnSeqBlock.Opns
                            For Each lConnection As HspfConnection In lOperation.Sources
                                If lConnection.Typ = lTypeIndex Then
                                    If lConnection.Comment.Length > 0 Then
                                        lSB.AppendLine(lConnection.Comment)
                                    End If
                                    Dim lStr As New StringBuilder
                                    lStr.Append(lConnection.Source.VolName.Trim)
                                    lStr.Append(Space(iCol(1) - lStr.Length - 1)) 'pad prev field
                                    lStr.Append(CStr(lConnection.Source.VolId).PadLeft(iLen(1)))
                                    lStr.Append(Space(iCol(2) - lStr.Length - 1))
                                    If NumericallyTheSame((lConnection.MFactAsRead), (lConnection.MFact)) Then
                                        lStr.Append(lConnection.MFactAsRead)
                                    ElseIf lConnection.MFact <> 1 Then
                                        lConnection.MFact = System.Math.Round(lConnection.MFact, 2)
                                        lStr.Append(CStr(lConnection.MFact).PadLeft(iLen(2)))
                                    End If
                                    lStr.Append(Space(iCol(3) - lStr.Length - 1))
                                    lStr.Append(lConnection.Target.VolName)
                                    lStr.Append(Space(iCol(4) - lStr.Length - 1))
                                    lStr.Append(CStr(lConnection.Target.VolId).PadLeft(iLen(5)))
                                    lStr.Append(Space(iCol(5) - lStr.Length - 1))
                                    lStr.Append(CStr(lConnection.MassLink).PadLeft(iLen(5)))
                                    If lConnection.Target.MemSub1 > 0 Then
                                        lStr.Append(Space(iCol(6) - lStr.Length - 1))
                                        Dim t As String = CStr(lConnection.Target.MemSub1).PadLeft(iLen(6))
                                        If lConnection.Target.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Target.Member, 1, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    If lConnection.Target.MemSub2 > 0 Then
                                        lStr.Append(Space(iCol(7) - lStr.Length - 1))
                                        Dim t As String = CStr(lConnection.Target.MemSub2).PadLeft(iLen(7))
                                        If lConnection.Target.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Target.Member, 2, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lSB.AppendLine(lStr.ToString)
                                End If
                            Next lConnection
                        Next lOperation
                    Case 4 'ext targ
                        lSB.AppendLine("<-Volume-> <-Grp> <-Member-><--Mult-->Tran <-Volume-> <Member> Tsys Aggr Amd ***")
                        lSB.AppendLine("<Name>   x        <Name> x x<-factor->strg <Name>   x <Name>qf  tem strg strg***")
                        For Each lOperation As HspfOperation In lOpnSeqBlock.Opns
                            For Each lConnection As HspfConnection In lOperation.Targets
                                If lConnection.Typ = lTypeIndex Then
                                    If lConnection.Comment.Length > 0 Then
                                        lSB.AppendLine(lConnection.Comment)
                                    End If
                                    Dim lStr As New StringBuilder
                                    lStr.Append(lConnection.Source.VolName.Trim)
                                    lStr.Append(Space(iCol(1) - lStr.Length - 1)) 'pad prev field
                                    lStr.Append(CStr(lConnection.Source.VolId).PadLeft(iLen(1)))
                                    lStr.Append(Space(iCol(2) - lStr.Length - 1))
                                    lStr.Append(lConnection.Source.Group)
                                    lStr.Append(Space(iCol(3) - lStr.Length - 1))
                                    lStr.Append(lConnection.Source.Member)
                                    lStr.Append(Space(iCol(4) - lStr.Length - 1))
                                    If lConnection.Source.MemSub1 <> 0 Then
                                        Dim t As String = CStr(lConnection.Source.MemSub1).PadLeft(iLen(4))
                                        If lConnection.Source.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Source.Member, 1, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lStr.Append(Space(iCol(5) - lStr.Length - 1))
                                    If lConnection.Source.MemSub2 <> 0 Then
                                        Dim t As String = CStr(lConnection.Source.MemSub2).PadLeft(iLen(5))
                                        If lConnection.Source.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Source.Member, 2, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lStr.Append(Space(iCol(6) - lStr.Length - 1))
                                    If NumericallyTheSame((lConnection.MFactAsRead), (lConnection.MFact)) Then
                                        lStr.Append(lConnection.MFactAsRead)
                                    ElseIf lConnection.MFact <> 1 Then
                                        'lConn.MFact = Format(lConn.MFact, "0.#######")
                                        'RSet t = CStr(lConn.MFact)
                                        Dim t As String = RSet(HspfTable.NumFmtRE(lConnection.MFact, iLen(6) - 1), iLen(6) - 1)
                                        lConnection.MFact = CDbl(t)
                                        lStr.Append(" " & t)
                                    End If
                                    lStr.Append(Space(iCol(7) - lStr.Length - 1))
                                    lStr.Append(lConnection.Tran)
                                    lStr.Append(Space(iCol(8) - lStr.Length - 1))
                                    lStr.Append(lConnection.Target.VolName)
                                    lStr.Append(Space(iCol(9) - lStr.Length - 1))
                                    lStr.Append(CStr(lConnection.Target.VolId).PadLeft(iLen(9)))
                                    lStr.Append(Space(iCol(10) - lStr.Length - 1))
                                    If Len(lConnection.Target.Member) > iLen(10) Then 'dont write more chars than there is room for
                                        lConnection.Target.Member = Mid(lConnection.Target.Member, 1, iLen(10))
                                    End If
                                    lStr.Append(lConnection.Target.Member.TrimEnd)
                                    If (iCol(11) - lStr.Length - 1 > 0) Then 'check to make sure not spacing zero or fewer characters
                                        lStr.Append(Space(iCol(11) - lStr.Length - 1))
                                    End If
                                    If lConnection.Target.MemSub1 <> 0 Then
                                        Dim t As String = CStr(lConnection.Target.MemSub1).PadLeft(iLen(11))
                                        If lConnection.Target.VolName = "RCHRES" Then
                                            t = pUci.IntAsCat(lConnection.Target.Member, 1, t)
                                        End If
                                        lStr.Append(t)
                                    End If
                                    lStr.Append(Space(iCol(12) - lStr.Length - 1))
                                    lStr.Append(lConnection.Ssystem)
                                    lStr.Append(Space(iCol(13) - lStr.Length - 1))
                                    lStr.Append(lConnection.Sgapstrg)
                                    lStr.Append(Space(iCol(14) - lStr.Length - 1))
                                    lStr.Append(lConnection.Amdstrg)
                                    lSB.AppendLine(lStr.ToString)
                                End If
                            Next lConnection
                        Next lOperation
                End Select
                lSB.AppendLine("END " & lBlockName)
            End If
        Next lTypeIndex
        Return lSB.ToString
    End Function

    Private Function NumericallyTheSame(ByRef ValueAsRead As String, ByRef ValueStored As Single) As Boolean
        'see if the current mfact value is the same as the value as read from the uci
        '4. is the same as 4.0
        Dim rtemp1 As Single

        NumericallyTheSame = False
        If IsNumeric(ValueStored) Then
            If IsNumeric(ValueAsRead) Then
                'simple case
                rtemp1 = CSng(ValueAsRead)
                If rtemp1 = ValueStored Then
                    NumericallyTheSame = True
                End If
            End If
        End If
    End Function
End Class