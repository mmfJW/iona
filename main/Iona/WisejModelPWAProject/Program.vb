Imports System
Imports Wisej.Web

Module Program

    ' **
    ' * PWA Template
    ' * 
    ' * This template includes a ready-made InstallAppPanel that you can use
    ' * to show a custom PWA installation prompt (works only in Chrome) And a
    ' * set of 8 flavors of the Offline pages.
    ' * 
    ' * Rename the "Offline-#" style that you want to use to just "Offline" And
    ' * delete the others. Wisej will only use the file in "/Offline".
    ' * 
    ' * If you set "offlineUrl" to "" Or delete it from Default.json, Wisej will
    ' * show a simple "Offline" toast instead of the full offline page.
    ' * 
    ' * Don't forget to update the version AssemblyInfo/AssemblyFileVersion when
    ' * you want to update the offline cache.
    ' *

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Main()

        Application.MainPage = New Page1()

        ' NOTE this event fires only in Chrome at this time. Other browsers, including
        ' Edge/Chrome don't seem to support it yet.
        AddHandler Application.BeforeInstallPrompt, AddressOf Application_BeforeInstallPrompt

    End Sub

    Private Sub Application_BeforeInstallPrompt(sender As Object, e As EventArgs)

        RemoveHandler Application.BeforeInstallPrompt, AddressOf Application_BeforeInstallPrompt

        Dim panel As New InstallAppPanel With
        {
            .Parent = Application.MainPage
        }

    End Sub

    ' ''' <summary>
    ' ''' You can use the entry method below
    ' ''' to receive the parameters from the URL in the args collection.
    ' ''' </summary>
    ' ''' <param name="args"></param>
    ' ''' <remarks></remarks>
    'Public Sub Main(args As NameValueCollection)

    'End Sub

End Module