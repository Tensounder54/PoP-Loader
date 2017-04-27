<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.LaunchButton = New System.Windows.Forms.Button()
        Me.KBOptions = New System.Windows.Forms.Button()
        Me.LaunchOptions = New System.Windows.Forms.Button()
        Me.popuw_Link = New System.Windows.Forms.Button()
        Me.SDLPop_GH_Link = New System.Windows.Forms.Button()
        Me.Laucher_GH_Link = New System.Windows.Forms.Button()
        Me.LauncherHelp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LaunchButton
        '
        Me.LaunchButton.Location = New System.Drawing.Point(12, 162)
        Me.LaunchButton.Name = "LaunchButton"
        Me.LaunchButton.Size = New System.Drawing.Size(237, 23)
        Me.LaunchButton.TabIndex = 0
        Me.LaunchButton.Text = "Launch"
        Me.LaunchButton.UseVisualStyleBackColor = True
        '
        'KBOptions
        '
        Me.KBOptions.Enabled = False
        Me.KBOptions.Location = New System.Drawing.Point(12, 191)
        Me.KBOptions.Name = "KBOptions"
        Me.KBOptions.Size = New System.Drawing.Size(237, 23)
        Me.KBOptions.TabIndex = 1
        Me.KBOptions.Text = "Key Binding Options"
        Me.KBOptions.UseVisualStyleBackColor = True
        '
        'LaunchOptions
        '
        Me.LaunchOptions.Location = New System.Drawing.Point(12, 220)
        Me.LaunchOptions.Name = "LaunchOptions"
        Me.LaunchOptions.Size = New System.Drawing.Size(237, 23)
        Me.LaunchOptions.TabIndex = 2
        Me.LaunchOptions.Text = "Launch Options"
        Me.LaunchOptions.UseVisualStyleBackColor = True
        '
        'popuw_Link
        '
        Me.popuw_Link.CausesValidation = False
        Me.popuw_Link.Location = New System.Drawing.Point(11, 249)
        Me.popuw_Link.Name = "popuw_Link"
        Me.popuw_Link.Size = New System.Drawing.Size(237, 23)
        Me.popuw_Link.TabIndex = 3
        Me.popuw_Link.Text = "Game Help"
        Me.popuw_Link.UseVisualStyleBackColor = True
        '
        'SDLPop_GH_Link
        '
        Me.SDLPop_GH_Link.Location = New System.Drawing.Point(12, 307)
        Me.SDLPop_GH_Link.Name = "SDLPop_GH_Link"
        Me.SDLPop_GH_Link.Size = New System.Drawing.Size(237, 23)
        Me.SDLPop_GH_Link.TabIndex = 4
        Me.SDLPop_GH_Link.Text = "SDLPop GitHub Souce Code"
        Me.SDLPop_GH_Link.UseVisualStyleBackColor = True
        '
        'Laucher_GH_Link
        '
        Me.Laucher_GH_Link.Location = New System.Drawing.Point(12, 336)
        Me.Laucher_GH_Link.Name = "Laucher_GH_Link"
        Me.Laucher_GH_Link.Size = New System.Drawing.Size(237, 23)
        Me.Laucher_GH_Link.TabIndex = 5
        Me.Laucher_GH_Link.Text = "Launcher GitHub Souce Code"
        Me.Laucher_GH_Link.UseVisualStyleBackColor = True
        '
        'LauncherHelp
        '
        Me.LauncherHelp.Location = New System.Drawing.Point(12, 278)
        Me.LauncherHelp.Name = "LauncherHelp"
        Me.LauncherHelp.Size = New System.Drawing.Size(237, 23)
        Me.LauncherHelp.TabIndex = 6
        Me.LauncherHelp.Text = "Launcher Help"
        Me.LauncherHelp.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PoP_2_Loader.My.Resources.Resources.logo_pop1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 369)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LauncherHelp)
        Me.Controls.Add(Me.Laucher_GH_Link)
        Me.Controls.Add(Me.SDLPop_GH_Link)
        Me.Controls.Add(Me.popuw_Link)
        Me.Controls.Add(Me.LaunchOptions)
        Me.Controls.Add(Me.KBOptions)
        Me.Controls.Add(Me.LaunchButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "SDLPop - Launcher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LaunchButton As Button
    Friend WithEvents KBOptions As Button
    Friend WithEvents LaunchOptions As Button
    Friend WithEvents popuw_Link As Button
    Friend WithEvents SDLPop_GH_Link As Button
    Friend WithEvents Laucher_GH_Link As Button
    Friend WithEvents LauncherHelp As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
