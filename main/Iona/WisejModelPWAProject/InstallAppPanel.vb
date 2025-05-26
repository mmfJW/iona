Imports System.Drawing

''' <summary>
'''  Displays a custom panel at the bottom Of the parent With an "Install" button that
'''  triggers the PWA install prompt On the browser.
''' </summary>
Public Class InstallAppPanel

    Private Sub InstallAppPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parentSize = Me.Parent.Size
        Me.Location = New Point(
            (parentSize.Width - Me.Width) / 2,
            (parentSize.Height - Me.Height - 5))

        BringToFront()

    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click

        Dispose()

    End Sub

    Private Sub buttonInstall_Click(sender As Object, e As EventArgs) Handles buttonInstall.Click

        Dispose()

    End Sub

End Class
