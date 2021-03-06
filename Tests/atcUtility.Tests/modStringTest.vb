﻿Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports atcUtility

'''<summary>
'''This is a test class for modStringTest and is intended
'''to contain all modStringTest Unit Tests
'''</summary>
<TestClass()> _
Public Class modStringTest
    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region

    '''<summary>Test Assign</summary>
    <TestMethod()> Public Sub AssignTest()
        Dim aResult As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aResultExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aExpression As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.Assign(aResult, aExpression)
        Assert.AreEqual(aResultExpected, aResult)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test Assign</summary>
    <TestMethod()> Public Sub AssignTest1()
        Dim aResult As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim aResultExpected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim aExpression As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        actual = modString.Assign(aResult, aExpression)
        Assert.AreEqual(aResultExpected, aResult)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test Assign</summary>
    <TestMethod()> Public Sub AssignTest2()
        Dim aResult As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim aResultExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim aExpression As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = modString.Assign(aResult, aExpression)
        Assert.AreEqual(aResultExpected, aResult)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test Byte2String</summary>
    <TestMethod()> Public Sub Byte2StringTest()
        Dim Byt() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim BytExpected() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim StartAt As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim StartAtExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Length As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim LengthExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.Byte2String(Byt, StartAt, Length)
        Assert.AreEqual(BytExpected, Byt)
        Assert.AreEqual(StartAtExpected, StartAt)
        Assert.AreEqual(LengthExpected, Length)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test ByteIsPrintable</summary>
    <TestMethod()> Public Sub ByteIsPrintableTest()
        Dim aByte As Byte = 0 ' TODO: Initialize to an appropriate value
        Dim aByteExpected As Byte = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = modString.ByteIsPrintable(aByte)
        Assert.AreEqual(aByteExpected, aByte)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test CapitalizeFirstLetter</summary>
    <TestMethod()> Public Sub CapitalizeFirstLetterTest()
        Dim aStr As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.CapitalizeFirstLetter(aStr)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test Center</summary>
    <TestMethod()> Public Sub CenterTest()
        Dim aStr As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aWidth As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.Center(aStr, aWidth)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test CountString</summary>
    <TestMethod()> Public Sub CountStringTest()
        Dim Source As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim SourceExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Find As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim FindExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = modString.CountString(Source, Find)
        Assert.AreEqual(SourceExpected, Source)
        Assert.AreEqual(FindExpected, Find)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test DecimalAlign</summary>
    <TestMethod()> Public Sub DecimalAlignTest()
        Dim aValue As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim aFieldWidth As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim aDecimalPlaces As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim aSignificantDigits As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.DecimalAlign(aValue, aFieldWidth, aDecimalPlaces, aSignificantDigits)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test DecimalAlign</summary>
    <TestMethod()> Public Sub DecimalAlignTest1()
        Dim aValue As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aFieldWidth As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim aWidthAfterDecimal As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.DecimalAlign(aValue, aFieldWidth, aWidthAfterDecimal)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test DecimalAlign</summary>
    <TestMethod()> Public Sub DecimalAlignTest2()
        Dim aNumericStrings() As String = Nothing ' TODO: Initialize to an appropriate value
        Dim aNumericStringsExpected() As String = Nothing ' TODO: Initialize to an appropriate value
        Dim PadLeft As Boolean = False ' TODO: Initialize to an appropriate value
        Dim PadLeftExpected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim PadRight As Boolean = False ' TODO: Initialize to an appropriate value
        Dim PadRightExpected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim MinWidth As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim MinWidthExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        modString.DecimalAlign(aNumericStrings, PadLeft, PadRight, MinWidth)
        Assert.AreEqual(aNumericStringsExpected, aNumericStrings)
        Assert.AreEqual(PadLeftExpected, PadLeft)
        Assert.AreEqual(PadRightExpected, PadRight)
        Assert.AreEqual(MinWidthExpected, MinWidth)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test DoubleToString</summary>
    <TestMethod()> Public Sub DoubleToStringTest()
        Dim aValue As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim aMaxWidth As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim aFormat As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aExpFormat As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aCantFit As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aSignificantDigits As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.DoubleToString(aValue, aMaxWidth, aFormat, aExpFormat, aCantFit, aSignificantDigits)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test FirstStringPos</summary>
    <TestMethod()> Public Sub FirstStringPosTest()
        Dim start As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Source As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim SearchFor() As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = modString.FirstStringPos(start, Source, SearchFor)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test IsAlpha</summary>
    <TestMethod()> Public Sub IsAlphaTest()
        Dim aStr As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aStrExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = modString.IsAlpha(aStr)
        Assert.AreEqual(aStrExpected, aStr)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test IsAlphaNumeric</summary>
    <TestMethod()> Public Sub IsAlphaNumericTest()
        Dim aStr As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aStrExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = modString.IsAlphaNumeric(aStr)
        Assert.AreEqual(aStrExpected, aStr)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test IsInteger</summary>
    <TestMethod()> Public Sub IsIntegerTest()
        Dim aStr As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aStrExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = modString.IsInteger(aStr)
        Assert.AreEqual(aStrExpected, aStr)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test Long2Single</summary>
    <TestMethod()> Public Sub Long2SingleTest()
        Dim Value As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim ValueExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Single = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Single
        actual = modString.Long2Single(Value)
        Assert.AreEqual(ValueExpected, Value)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test Long2String</summary>
    <TestMethod()> Public Sub Long2StringTest()
        Dim Value As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim ValueExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.Long2String(Value)
        Assert.AreEqual(ValueExpected, Value)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test ReadableFromXML</summary>
    <TestMethod()> Public Sub ReadableFromXMLTest()
        Dim aXML As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.ReadableFromXML(aXML)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test ReplaceString</summary>
    <TestMethod()> Public Sub ReplaceStringTest()
        Dim Source As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim SourceExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Find As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim FindExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ReplaceWith As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ReplaceWithExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.ReplaceString(Source, Find, ReplaceWith)
        Assert.AreEqual(SourceExpected, Source)
        Assert.AreEqual(FindExpected, Find)
        Assert.AreEqual(ReplaceWithExpected, ReplaceWith)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test ReplaceStringNoCase</summary>
    <TestMethod()> Public Sub ReplaceStringNoCaseTest()
        Dim Source As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim SourceExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim Find As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim FindExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ReplaceWith As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ReplaceWithExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.ReplaceStringNoCase(Source, Find, ReplaceWith)
        Assert.AreEqual(SourceExpected, Source)
        Assert.AreEqual(FindExpected, Find)
        Assert.AreEqual(ReplaceWithExpected, ReplaceWith)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test RightJustify</summary>
    <TestMethod()> Public Sub RightJustifyTest()
        Dim aValue As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim aWidth As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.RightJustify(aValue, aWidth)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test Rndlow</summary>
    <TestMethod()> Public Sub RndlowTest()
        Dim aX As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim aXExpected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        actual = modString.Rndlow(aX)
        Assert.AreEqual(aXExpected, aX)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test SafeSubstring</summary>
    <TestMethod()> Public Sub SafeSubstringTest()
        Dim aSourceString As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aStartIndex As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim aLength As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.SafeSubstring(aSourceString, aStartIndex, aLength)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test SafeSubstring</summary>
    <TestMethod()> Public Sub SafeSubstringTest1()
        Dim aSourceString As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aStartIndex As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.SafeSubstring(aSourceString, aStartIndex)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test SignificantDigits</summary>
    <TestMethod()> Public Sub SignificantDigitsTest()
        Dim aValue As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim aDigits As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        actual = modString.SignificantDigits(aValue, aDigits)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test StrFindBlock</summary>
    <TestMethod()> Public Sub StrFindBlockTest()
        Dim aSource As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aStartsWith As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aEndsWith As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aStartIndex As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.StrFindBlock(aSource, aStartsWith, aEndsWith, aStartIndex)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test StrFirstInt</summary>
    <TestMethod()> Public Sub StrFirstIntTest()
        Dim Source As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim SourceExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = modString.StrFirstInt(Source)
        Assert.AreEqual(SourceExpected, Source)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test StrNoNull</summary>
    <TestMethod()> Public Sub StrNoNullTest()
        Dim S As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.StrNoNull(S)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test StrPad</summary>
    <TestMethod()> Public Sub StrPadTest()
        Dim S As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim NewLength As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim PadWith As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim PadLeft As Boolean = False ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.StrPad(S, NewLength, PadWith, PadLeft)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test StrPrintable</summary>
    <TestMethod()> Public Sub StrPrintableTest()
        Dim S As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim SExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ReplaceWith As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim ReplaceWithExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.StrPrintable(S, ReplaceWith)
        Assert.AreEqual(SExpected, S)
        Assert.AreEqual(ReplaceWithExpected, ReplaceWith)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test StrReplaceBlock</summary>
    <TestMethod()> Public Sub StrReplaceBlockTest()
        Dim aSource As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aStartsWith As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aEndsWith As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aReplaceWith As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aStartIndex As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.StrReplaceBlock(aSource, aStartsWith, aEndsWith, aReplaceWith, aStartIndex)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test StrRetRem</summary>
    <TestMethod()> Public Sub StrRetRemTest()
        Dim S As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim SExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.StrRetRem(S)
        Assert.AreEqual(SExpected, S)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test StringQuotedAsNeeded</summary>
    <TestMethod()> Public Sub StringQuotedAsNeededTest()
        Dim aInputString As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aDelimiter As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim aQuote As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = modString.StringQuotedAsNeeded(aInputString, aDelimiter, aQuote)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
