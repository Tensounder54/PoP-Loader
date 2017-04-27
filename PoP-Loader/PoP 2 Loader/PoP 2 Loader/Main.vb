Public Class Main

    Private Sub popuw_Link_Click(sender As Object, e As EventArgs)
        Dim webAddress As String = "http://popuw.com/index1.html"
        Process.Start(webAddress)
    End Sub

    'Button 4 - Link to popuw

    Private Sub popuw_Link_Click_1(sender As Object, e As EventArgs) Handles popuw_Link.Click
        Process.Start("http://popuw.com/index1.html")
    End Sub

    Private Sub popuw_Link_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button <> MouseButtons.Right Then Return
        Dim cms = New ContextMenuStrip
        Dim item1 = cms.Items.Add("Copy Link")
        item1.Tag = 1
        AddHandler item1.Click, AddressOf menuChoice_popuw_Link
        cms.Show(popuw_Link, e.Location)
    End Sub

    Private Sub menuChoice_popuw_Link(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        If selection = 1 Then
            My.Computer.Clipboard.SetText("http://popuw.com/index1.html")
            MessageBox.Show("Link Copied to Clipboard.")
        End If
    End Sub

    'Button 5 - Link to Tensounder54/Pop_Launcher/README.md

    Private Sub LauncherHelp_Click(sender As Object, e As EventArgs) Handles LauncherHelp.Click
        Process.Start("https://github.com/Tensounder54/PoP-Loader/blob/master/README.md")
    End Sub

    Private Sub LauncherHelp_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button <> MouseButtons.Right Then Return
        Dim cms = New ContextMenuStrip
        Dim item1 = cms.Items.Add("Copy Link")
        item1.Tag = 1
        AddHandler item1.Click, AddressOf menuChoice_LauncherHelp
        cms.Show(LauncherHelp, e.Location)
    End Sub

    Private Sub menuChoice_LauncherHelp(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        If selection = 1 Then
            My.Computer.Clipboard.SetText("https://github.com/Tensounder54/PoP-Loader/blob/master/README.md")
            MessageBox.Show("Link Copied to Clipboard.")
        End If
    End Sub

    'Button 6 - Link to SDLPop Github

    Private Sub SDLPop_GH_Link_Click(sender As Object, e As EventArgs) Handles SDLPop_GH_Link.Click
        Process.Start("https://github.com/NagyD/SDLPoP")
    End Sub

    Private Sub SDLPop_GH_Link_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button <> MouseButtons.Right Then Return
        Dim cms = New ContextMenuStrip
        Dim item1 = cms.Items.Add("Copy Link")
        item1.Tag = 1
        AddHandler item1.Click, AddressOf menuChoice_SDLPop_GH_Link
        cms.Show(SDLPop_GH_Link, e.Location)
    End Sub

    Private Sub menuChoice_SDLPop_GH_Link(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        If selection = 1 Then
            My.Computer.Clipboard.SetText("https://github.com/NagyD/SDLPoP")
            MessageBox.Show("Link Copied to Clipboard.")
        End If
    End Sub

    'Button 7 - Link to Launcher Github

    Private Sub Laucher_GH_Link_Click(sender As Object, e As EventArgs) Handles Laucher_GH_Link.Click
        Process.Start("https://github.com/Tensounder54/PoP-Loader")
    End Sub

    Private Sub Laucher_GH_Link_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button <> MouseButtons.Right Then Return
        Dim cms = New ContextMenuStrip
        Dim item1 = cms.Items.Add("Copy Link")
        item1.Tag = 1
        AddHandler item1.Click, AddressOf menuChoice_Laucher_GH_Link
        cms.Show(Laucher_GH_Link, e.Location)
    End Sub

    Private Sub menuChoice_Laucher_GH_Link(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        If selection = 1 Then
            My.Computer.Clipboard.SetText("https://github.com/Tensounder54/PoP-Loader")
            MessageBox.Show("Link Copied to Clipboard.")
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KBOptions_Click(sender As Object, e As EventArgs) Handles KBOptions.Click
        Key_Bindings.Show()
        Hide()
    End Sub

    Private Sub LaunchButton_Click(sender As Object, e As EventArgs) Handles LaunchButton.Click
        'Launch the game with desired launch options'

        'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '    Dim OpenCMD
        '    OpenCMD = CreateObject("wscript.shell")
        '    OpenCMD.run("b:", "cd Program files\SDLPoP\SDLPoP_v1.16", "prince.exe megahit")
        '    OpenCMD.run("cd Program files\SDLPoP\SDLPoP_v1.16")
        '    OpenCMD.run("prince.exe megahit")

        '    Process.Start("cmd.exe")

        '    Threading.Thread.Sleep(5000)

        '    Process.Start("CMD", "/k b:", "/k cd Program files\SDLPoP\SDLPoP_v1.16", "/k prince.exe megahit")
        'End Sub

    End Sub

    Private Sub LaunchOptions_Click(sender As Object, e As EventArgs) Handles LaunchOptions.Click
        Launcher_Options.Show()
        Me.Hide()
    End Sub


End Class