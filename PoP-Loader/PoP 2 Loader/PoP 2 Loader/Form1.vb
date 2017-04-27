Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("B:\dosProgs\DOSBox-0.74\DOSBox.exe")

        Threading.Thread.Sleep(5000)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim webAddress As String = "http://popuw.com/files/pop2manual.pdf"
        Process.Start(webAddress)
    End Sub

    Private Sub Button2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseUp
        If e.Button <> MouseButtons.Right Then Return
        Dim cms = New ContextMenuStrip
        Dim item1 = cms.Items.Add("Copy Link")
        item1.Tag = 1
        AddHandler item1.Click, AddressOf menuChoice
        cms.Show(Button2, e.Location)

    End Sub

    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)
        If selection = 1 Then
            My.Computer.Clipboard.SetText("http://popuw.com/files/pop2manual.pdf")
            MessageBox.Show("Link Copied to Clipboard.")
        End If
    End Sub
End Class
