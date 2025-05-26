Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallAppPanel
    Inherits Wisej.Web.UserControl

    'InstallAppPanel overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej.NET Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej.NET Designer
    'It can be modified using the Wisej.NET Designer.
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ClientEvent2 As Wisej.Web.JavaScript.ClientEvent = New Wisej.Web.JavaScript.ClientEvent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstallAppPanel))
        Me.buttonClose = New Wisej.Web.Button()
        Me.buttonInstall = New Wisej.Web.Button()
        Me.label1 = New Wisej.Web.Label()
        Me.pictureBox1 = New Wisej.Web.PictureBox()
        Me.animation1 = New Wisej.Web.Animation(Me.components)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonClose
        '
        Me.buttonClose.BackColor = System.Drawing.Color.Transparent
        Me.buttonClose.BorderStyle = Wisej.Web.BorderStyle.None
        Me.buttonClose.Display = Wisej.Web.Display.Icon
        Me.buttonClose.ForeColor = System.Drawing.Color.White
        Me.buttonClose.ImageSource = "window-close"
        Me.buttonClose.Location = New System.Drawing.Point(292, 16)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(24, 24)
        Me.buttonClose.TabIndex = 7
        Me.buttonClose.Text = "Close"
        '
        'buttonInstall
        '
        Me.buttonInstall.BackColor = System.Drawing.Color.FromArgb(70, 70, 70)
        ClientEvent2.Event = "execute"
        ClientEvent2.JavaScript = "Wisej.showPWAPrompt()"
        Me.buttonInstall.ClientEvents.Add(ClientEvent2)
        Me.buttonInstall.CssStyle = "border-radius:5px"
        Me.buttonInstall.Font = New System.Drawing.Font("@defaultBold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.buttonInstall.ForeColor = System.Drawing.Color.White
        Me.buttonInstall.Location = New System.Drawing.Point(198, 11)
        Me.buttonInstall.Name = "buttonInstall"
        Me.buttonInstall.Size = New System.Drawing.Size(75, 35)
        Me.buttonInstall.TabIndex = 6
        Me.buttonInstall.Text = "Install"
        '
        'label1
        '
        Me.label1.AutoEllipsis = True
        Me.label1.Font = New System.Drawing.Font("@defaultBold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.label1.Location = New System.Drawing.Point(59, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(133, 15)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Test PWA App"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(22, 117, 242)
        Me.pictureBox1.CssStyle = "border-radius:5px"
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(13, 8)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom
        '
        'InstallAppPanel
        '
        Me.Anchor = Wisej.Web.AnchorStyles.Bottom
        Me.animation1.GetAnimation(Me).Event = "appear"
        Me.animation1.GetAnimation(Me).Name = "slideUpIn"
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.buttonInstall)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.CssStyle = "border-radius:10px"
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "InstallAppPanel"
        Me.Size = New System.Drawing.Size(332, 56)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents buttonClose As Button
    Private WithEvents buttonInstall As Button
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents animation1 As Animation
End Class
