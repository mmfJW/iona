Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page1
    Inherits Wisej.Web.Page

    'Overrides dispose to clean up the component list.
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
    'It can be modified using the Wisej Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page1))
        Me.panel1 = New Wisej.Web.Panel()
        Me.pictureBox1 = New Wisej.Web.PictureBox()
        Me.label2 = New Wisej.Web.Label()
        Me.button1 = New Wisej.Web.Button()
        Me.flowLayoutPanel1 = New Wisej.Web.FlowLayoutPanel()
        Me.label1 = New Wisej.Web.Label()
        Me.button2 = New Wisej.Web.Button()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Orange
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Dock = Wisej.Web.DockStyle.Top
        Me.panel1.ForeColor = System.Drawing.Color.White
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1367, 50)
        Me.panel1.TabIndex = 2
        Me.panel1.TabStop = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.pictureBox1.CssStyle = "border-radius:40px"
        Me.pictureBox1.ImageSource = "https://www.gravatar.com/avatar/?d=identicon"
        Me.pictureBox1.Location = New System.Drawing.Point(1314, 5)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(67, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(89, 15)
        Me.label2.TabIndex = 1
        Me.label2.Text = "PWA Test App"
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Transparent
        Me.button1.BorderStyle = Wisej.Web.BorderStyle.None
        Me.button1.Display = Wisej.Web.Display.Icon
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.ImageSource = "menu-overflow"
        Me.button1.Location = New System.Drawing.Point(3, 3)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(39, 44)
        Me.button1.TabIndex = 0
        Me.button1.Text = "button1"
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Controls.Add(Me.label1)
        Me.flowLayoutPanel1.Controls.Add(Me.button2)
        Me.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 50)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Padding = New Wisej.Web.Padding(40)
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(1367, 812)
        Me.flowLayoutPanel1.TabIndex = 5
        Me.flowLayoutPanel1.TabStop = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.CssStyle = "line-height:24px"
        Me.label1.Font = New System.Drawing.Font("default", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.label1.Location = New System.Drawing.Point(43, 43)
        Me.label1.Name = "label1"
        Me.label1.Padding = New Wisej.Web.Padding(0, 0, 0, 30)
        Me.label1.Size = New System.Drawing.Size(1253, 133)
        Me.label1.TabIndex = 2
        Me.label1.Text = resources.GetString("label1.Text")
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(232, 236, 239)
        Me.button2.BorderStyle = Wisej.Web.BorderStyle.None
        Me.button2.CssStyle = "border-radius:5px"
        Me.button2.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.button2.ForeColor = System.Drawing.Color.FromArgb(22, 117, 242)
        Me.button2.ImageSource = "icon-right"
        Me.button2.Location = New System.Drawing.Point(43, 209)
        Me.button2.Margin = New Wisej.Web.Padding(3, 30, 3, 3)
        Me.button2.Name = "button2"
        Me.button2.Padding = New Wisej.Web.Padding(0, 0, 10, 0)
        Me.button2.Size = New System.Drawing.Size(182, 36)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Read about PWA apps"
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Page1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.flowLayoutPanel1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Page1"
        Me.Size = New System.Drawing.Size(1367, 862)
        Me.Text = "Page1"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents button1 As Button
    Private WithEvents flowLayoutPanel1 As FlowLayoutPanel
    Private WithEvents label1 As Label
    Private WithEvents button2 As Button
End Class
