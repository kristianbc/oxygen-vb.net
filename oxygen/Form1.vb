Imports SystemIO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.Hide()
        My.Computer.FileSystem.CreateDirectory("C:\gotownedlmao")
        If My.Computer.FileSystem.DirectoryExists("C:\gotownedlmao") Then

            My.Computer.FileSystem.CreateDirectory("C:\thisexistmysupermanguynewfag")

            Process.Start("cmd.exe")
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ")

            Dim jonas As New Random

            jonas.Next()

            MsgBox(":)")

        Else

            MsgBox("scamaz")








        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MsgBox("wannacry")

        Dim StartInfo As New System.Diagnostics.ProcessStartInfo
        StartInfo.FileName = "cmd"
        StartInfo.RedirectStandardInput = True
        StartInfo.RedirectStandardOutput = True
        StartInfo.UseShellExecute = False

        Dim CMDprocess As New Process
        CMDprocess.StartInfo = StartInfo
        CMDprocess.Start()
        Dim sw As System.IO.StreamWriter = CMDprocess.StandardInput
        sw.WriteLine("echo you")

        'Me.WindowState = FormWindowState.Maximized 'just addon if u want

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        OpenFileDialog1.ShowDialog()
    End Sub
End Class
