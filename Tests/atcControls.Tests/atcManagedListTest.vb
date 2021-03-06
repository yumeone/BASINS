﻿Imports System.Windows.Forms
Imports System
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports atcControls

'''<summary>
'''This is a test class for atcManagedListTest and is intended
'''to contain all atcManagedListTest Unit Tests
'''</summary>
<TestClass()> _
Public Class atcManagedListTest
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

    '''<summary>Test atcManagedList Constructor</summary>
    <TestMethod()> Public Sub atcManagedListConstructorTest()
        Dim target As atcManagedList = New atcManagedList()
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

    '''<summary>Test Dispose</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub DisposeTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        Dim disposing As Boolean = False ' TODO: Initialize to an appropriate value
        target.Dispose(disposing)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test InitializeComponent</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub InitializeComponentTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        target.InitializeComponent()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test LoadListSettingsOrDefaults</summary>
    <TestMethod()> Public Sub LoadListSettingsOrDefaultsTest()
        Dim target As atcManagedList = New atcManagedList() ' TODO: Initialize to an appropriate value
        target.LoadListSettingsOrDefaults()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test RegistrySection</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub RegistrySectionTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.RegistrySection
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test SaveList</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub SaveListTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        target.SaveList()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test atcManagedList_Disposed</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub atcManagedList_DisposedTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.atcManagedList_Disposed(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test atcManagedList_Load</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub atcManagedList_LoadTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.atcManagedList_Load(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test btnAdd_Click</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub btnAdd_ClickTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.btnAdd_Click(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test btnAll_Click</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub btnAll_ClickTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.btnAll_Click(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test btnDefault_Click</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub btnDefault_ClickTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.btnDefault_Click(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test btnNone_Click</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub btnNone_ClickTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.btnNone_Click(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test btnRemove_Click</summary>
    <TestMethod(), DeploymentItem("atcControls.dll")> _
    Public Sub btnRemove_ClickTest()
        Dim target As atcManagedList_Accessor = New atcManagedList_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.btnRemove_Click(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>Test CurrentValues</summary>
    <TestMethod()> Public Sub CurrentValuesTest()
        Dim target As atcManagedList = New atcManagedList() ' TODO: Initialize to an appropriate value
        Dim expected() As Double = Nothing ' TODO: Initialize to an appropriate value
        Dim actual() As Double
        target.CurrentValues = expected
        actual = target.CurrentValues
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test btnAdd</summary>
    <TestMethod()> Public Sub btnAddTest()
        Dim target As atcManagedList = New atcManagedList() ' TODO: Initialize to an appropriate value
        Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Button
        target.btnAdd = expected
        actual = target.btnAdd
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test btnAll</summary>
    <TestMethod()> Public Sub btnAllTest()
        Dim target As atcManagedList = New atcManagedList() ' TODO: Initialize to an appropriate value
        Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Button
        target.btnAll = expected
        actual = target.btnAll
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test btnDefault</summary>
    <TestMethod()> Public Sub btnDefaultTest()
        Dim target As atcManagedList = New atcManagedList() ' TODO: Initialize to an appropriate value
        Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Button
        target.btnDefault = expected
        actual = target.btnDefault
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test btnNone</summary>
    <TestMethod()> Public Sub btnNoneTest()
        Dim target As atcManagedList = New atcManagedList() ' TODO: Initialize to an appropriate value
        Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Button
        target.btnNone = expected
        actual = target.btnNone
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test btnRemove</summary>
    <TestMethod()> Public Sub btnRemoveTest()
        Dim target As atcManagedList = New atcManagedList() ' TODO: Initialize to an appropriate value
        Dim expected As Button = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Button
        target.btnRemove = expected
        actual = target.btnRemove
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test lstValues</summary>
    <TestMethod()> Public Sub lstValuesTest()
        Dim target As atcManagedList = New atcManagedList() ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.lstValues = expected
        actual = target.lstValues
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test txtAdd</summary>
    <TestMethod()> Public Sub txtAddTest()
        Dim target As atcManagedList = New atcManagedList() ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtAdd = expected
        actual = target.txtAdd
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
