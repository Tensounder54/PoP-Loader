Public Class Launcher_Options

    Public CMD_Option1 As Boolean = False
    Public CMD_Option2 As Boolean = False
    Public CMD_Option3 As Boolean = False
    Public CMD_Option4 As Boolean = False
    Public CMD_Option5 As Boolean = False
    Public CMD_Option6 As Boolean = False
    Public CMD_Option7 As Boolean = False
    Public CMD_Option8 As Boolean = False
    Public CMD_Option9 As Boolean = False
    Public CMD_Option10 As Boolean = False
    Public CMD_Option11 As Boolean = False
    Public CMD_Option12 As Boolean = False

    Private Sub Launcher_Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("5")
        ComboBox1.Items.Add("6")
        ComboBox1.Items.Add("7")
        ComboBox1.Items.Add("8")
        ComboBox1.Items.Add("9")
        ComboBox1.Items.Add("10")
        ComboBox1.Items.Add("11")
        ComboBox1.Items.Add("12")
        ComboBox1.Items.Add("13")
        ComboBox1.Items.Add("14")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Skips the offscreen buffer.")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CMD_Option1 = True
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CMD_Option2 = True
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        CMD_Option3 = True
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        CMD_Option4 = True
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        'CMD_Option5 = True
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        'CMD_Option6 = True
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        'CMD_Option7 = True
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        CMD_Option8 = True
    End Sub
End Class