Public Class Key_Bindings
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



    'Private Sub Button2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If e.Button <> MouseButtons.Right Then Return
    '    Dim cms = New ContextMenuStrip
    '    Dim item1 = cms.Items.Add("Copy Link")
    '    item1.Tag = 1
    '    AddHandler item1.Click, AddressOf menuChoice
    '    cms.Show(Button2, e.Location)

    'End Sub

    'Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim item = CType(sender, ToolStripMenuItem)
    '    Dim selection = CInt(item.Tag)
    '    If selection = 1 Then
    '        My.Computer.Clipboard.SetText("http://popuw.com/files/pop2manual.pdf")
    '        MessageBox.Show("Link Copied to Clipboard.")
    '    End If
    'End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Till level 4 | Practice Mode - Reduces time to 15 mins.")
    End Sub
End Class
