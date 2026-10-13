Option Strict On
Option Explicit On
Imports System.IO
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class Form1
    Dim strargs() As String = System.Environment.GetCommandLineArgs
    Dim progPath As String = IO.Path.GetDirectoryName(Diagnostics.Process.GetCurrentProcess().MainModule.FileName)
    Dim cancelAnswer As Boolean

    Public Sub recieveCancel(ByVal value As Boolean)
        cancelAnswer = value
    End Sub

    Private Sub inputbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputButton.Click
        Try
            Dim fdlg As OpenFileDialog = New OpenFileDialog()
            fdlg.Title = "Pick A Wave File"
            If Not My.Settings.LastInputDirectory = "" Then
                fdlg.InitialDirectory = My.Settings.LastInputDirectory
            Else
                fdlg.InitialDirectory = "::{450D8FBA-AD25-11D0-98A8-0800361B1103}\My Music"
            End If
            fdlg.Filter = "Wav Files (*.wav)|*.wav"
            fdlg.FilterIndex = 1
            fdlg.RestoreDirectory = True
            fdlg.Multiselect = True
            If fdlg.ShowDialog() = DialogResult.OK Then
                Dim Path As String
                Dim Pos As Integer
                Path = IO.Path.GetFullPath(fdlg.FileName)
                Pos = Path.LastIndexOf("\")
                Path = Path.Substring(0, Pos + 1)
                My.Settings.LastInputDirectory = Path

                InputListBox.Items.AddRange(fdlg.FileNames)
            End If

2:
            For Each itm As String In InputListBox.Items
                If itm.EndsWith(".wav") Then

                Else
                    InputListBox.Items.Remove(itm)
                    GoTo 2
                End If
            Next

            Dim counter As Integer
1:
            For Each itm As String In InputListBox.Items
                counter = 0
                For Each item As String In InputListBox.Items
                    If item = itm Then
                        counter = counter + 1
                        If counter >= 2 Then
                            InputListBox.Items.Remove(itm)
                            GoTo 1
                        End If
                    End If
                Next
            Next

            If InputListBox.Items.Count = 0 Then
                inputMessageLabel.Visible = True
                StartButton.Enabled = False
            Else
                inputMessageLabel.Visible = False
                StartButton.Enabled = True
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub startbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        Try
            If File.Exists("mp3hdconverter.jsf") Then
                File.Delete("mp3hdconverter.jsf")
            End If
            File.AppendAllText("mp3hdconverter.jsf", "")
            If CheckBox1.Checked = True Then
                Dim confirm As DialogResult
                confirm = MessageBox.Show("Are you sure you want to delete the original file(s)?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.No Then
                    CheckBox1.Checked = False
                    Exit Sub
                End If
            End If

            If CheckBox3.Checked = True Then
                For Each fileItem In InputListBox.Items
                    cancelAnswer = False
                    Dim frm As Form2 = New Form2(fileItem.ToString)
                    frm.ShowDialog()
                    If cancelAnswer = True Then
                        File.Delete("mp3hdconverter.jsf")
                        Exit Sub
                    End If
                Next
            Else
                For Each itm In InputListBox.Items
                    File.AppendAllText("mp3hdconverter.jsf", "" & ControlChars.NewLine)
                Next
            End If

            Dim tagging As String
            Dim testing() As String = File.ReadAllLines("mp3hdconverter.jsf")

            For x = 0 To InputListBox.Items.Count() - 1
                tagging = testing(x)

                If InputListBox.Items.Count() = 0 Or bitRateDropBox.Text = "" Then
                    MessageBox.Show("Please Enter All Fields Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim Input As String = CStr(InputListBox.Items.Item(x))
                Dim process As New ProcessStartInfo
                Dim outputBR, pathroot, mode, setMode, isCorrect As String
                Dim outputBRnum As Integer
                Dim outputlocation As String

                isCorrect = IO.Path.GetExtension(Input)
                pathroot = IO.Path.GetFullPath(Input)
                pathroot = IO.Path.ChangeExtension(pathroot, "")

                If outputBox.Text = "" Or outputBox.Text = "Leave This Message For Same Directory" Then
                    outputlocation = pathroot
                Else
                    outputlocation = outputBox.Text
                    If renameCheck.Checked = False Then
                        outputlocation = outputlocation & "\" & IO.Path.GetFileName(Input)
                        outputlocation = IO.Path.ChangeExtension(outputlocation, "")
                    End If
                End If

                ''''''''''''''''Renaming'''''''''''''''''''''
                'If CheckBox3.Checked = True Then
                If renameCheck.Checked = True Then
                    Dim art, title As String
                    Dim r As Integer
                    r = tagging.IndexOf("-Artist")
                    art = tagging.Remove(0, r + 9)
                    r = art.IndexOf("-Album")
                    art = art.Remove(r - 2, art.Length - r + 2)
                    r = tagging.IndexOf("-Title")
                    title = tagging.Remove(0, r + 8)
                    r = title.IndexOf("-Artist")
                    title = title.Remove(r - 2, title.Length - r + 2)

                    If outputBox.Text = "" Or outputBox.Text = "Leave This Message For Same Directory" Then
                        outputlocation = IO.Path.GetDirectoryName(Input) & "\" & art & " - " & title & "."
                    Else
                        outputlocation = outputlocation & "\"
                    End If
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''

                outputBRnum = Integer.Parse(bitRateDropBox.Text)
                outputBR = Convert.ToString(outputBRnum * 1000)

                mode = modeDropBox.Text
                If mode = "0 - CBR" Or mode = "1 - VBR HQ" Or mode = "2 - VBR MHQ" Or _
                        mode = "3 - VBR MQ" Or mode = "4 - VBR MLQ" Or mode = "5 - VBR LQ" Then

                    If mode = "0 - CBR" Then
                        setMode = "0"
                    ElseIf mode = "1 - VBR HQ" Then
                        setMode = "1"
                    ElseIf mode = "2 - VBR MHQ" Then
                        setMode = "2"
                    ElseIf mode = "3 - VBR MQ" Then
                        setMode = "3"
                    ElseIf mode = "4 - VBR MLQ" Then
                        setMode = "4"
                    ElseIf mode = "5 - VBR LQ" Then
                        setMode = "5"
                    Else
                        setMode = "0"
                    End If
                Else
                    MessageBox.Show("Please Select A Proper Mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If IO.File.Exists(outputlocation & "mp3") Then
                    Dim confirm As DialogResult
                    confirm = MessageBox.Show("The output file already exists, do you want to overwrite it?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                    If confirm = DialogResult.Yes Then
                        Dim myprocess As Process = System.Diagnostics.Process.Start(progPath & "\mp3hdencoder.exe", "-br " & outputBR & " -mode " & setMode & " -if """ & Input & """ -of """ & outputlocation & "mp3""")
                        myprocess.WaitForExit()
                    ElseIf confirm = DialogResult.No Then
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                Else
                    Dim myprocess As Process = System.Diagnostics.Process.Start(progPath & "\mp3hdencoder.exe", "-br " & outputBR & " -mode " & setMode & " -if """ & Input & """ -of """ & outputlocation & "mp3""" & tagging)
                    myprocess.WaitForExit()
                End If

                If CheckBox1.Checked = True Then
                    My.Computer.FileSystem.DeleteFile(Input, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                End If
            Next
            File.Delete("mp3hdconverter.jsf")
            InputListBox.Items.Clear()
            inputMessageLabel.Visible = True
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub clearbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Try
            bitRateDropBox.Text = "320"
            InputListBox.Items.Clear()
            modeDropBox.Text = "0 - CBR"
            outputBox.Text = "Leave This Message For Same Directory"
            My.Settings.LastBitrate = ""
            My.Settings.LastInputDirectory = ""
            My.Settings.LastMode = ""
            My.Settings.LastOutputDirectory = ""
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            inputMessageLabel.Visible = True
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub modeDropBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles modeDropBox.Leave
        Dim mode As String = modeDropBox.Text
        If mode = "0 - CBR" Or mode = "1 - VBR HQ" Or mode = "2 - VBR MHQ" Or mode = "3 - VBR MQ" _
            Or mode = "4 - VBR MLQ" Or mode = "5 - VBR LQ" Then
            Exit Sub
        Else
            modeDropBox.Text = "0 - CBR"
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.MainFormLocation = Me.Location
        My.Settings.LastOutputDirectory = outputBox.Text
        My.Settings.LastBitrate = bitRateDropBox.Text
        My.Settings.LastMode = modeDropBox.Text
        My.Settings.LastOutputDirectoryWav = OutputBoxWav.Text
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            Dim pro As System.Diagnostics.Process
            pro = System.Diagnostics.Process.Start(test & "Change Log.txt")
            pro.Kill()
        Catch ex As System.ComponentModel.Win32Exception
            MessageBox.Show("This program requires having administrative rights.  Please restart program as an administrator.", "Failed Admin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try

        Try
            ToolTip1.SetToolTip(bitRateDropBox, "Enter a bitrate between 96 and 320")
            If My.Settings.MainFormLocation.X <= 10 Or My.Settings.MainFormLocation.Y <= 10 Then
                Me.StartPosition = FormStartPosition.CenterScreen
            Else
                Me.Location = My.Settings.MainFormLocation
            End If

            If Not My.Settings.LastOutputDirectory = "" Then
                outputBox.Text = My.Settings.LastOutputDirectory
            End If

            If Not My.Settings.LastOutputDirectoryWav = "" Then
                OutputBoxWav.Text = My.Settings.LastOutputDirectoryWav
            End If

            If Not My.Settings.LastBitrate = "" Then
                bitRateDropBox.Text = My.Settings.LastBitrate
            End If

            If Not My.Settings.LastMode = "" Then
                modeDropBox.Text = My.Settings.LastMode
            End If

            Dim inWrite As IO.StreamWriter
            Dim myprocess1 As IO.FileStream

            myprocess1 = New IO.FileStream(progPath & "\mp3hdencoder.exe", IO.FileMode.Open, IO.FileAccess.Write)
            inWrite = New IO.StreamWriter(myprocess1)
            inWrite.Write("a")
            inWrite.Write("a")
            inWrite.Write("a")
            inWrite.Write("a")
            inWrite.Write("y")
            myprocess1.Close()

1:
            If strargs.Length > 1 Then
                strargs(0) = strargs(UBound(strargs))
                ReDim Preserve strargs(UBound(strargs) - 1)
                For Each s In strargs
                    If IO.Path.GetFileName(s).ToLower = "mp3hd converter.exe" Then
                        InputListBox.Items.Clear()
                    ElseIf IO.Path.GetExtension(s) = ".wav" Then
                        InputListBox.Items.Add(s)
                    ElseIf IO.Path.GetExtension(s) = ".mp3" Then
                        InputListBoxWav.Items.Add(s)
                    Else
                        InputListBox.Items.Remove(s)
                        GoTo 1
                    End If
                Next
            Else
                Exit Sub
            End If

            Dim counter As Integer
2:
            For Each itm As String In InputListBox.Items
                counter = 0
                For Each item As String In InputListBox.Items
                    If item = itm Then
                        counter = counter + 1
                        If counter >= 2 Then
                            InputListBox.Items.Remove(itm)
                            GoTo 2
                        End If
                    End If
                Next
            Next

            Dim counter2 As Integer
3:
            For Each itm As String In InputListBoxWav.Items
                counter2 = 0
                For Each item As String In InputListBoxWav.Items
                    If item = itm Then
                        counter2 = counter2 + 1
                        If counter >= 2 Then
                            InputListBoxWav.Items.Remove(itm)
                            GoTo 3
                        End If
                    End If
                Next
            Next

            If InputListBox.Items.Count = 0 Then
                inputMessageLabel.Visible = True
            Else
                inputMessageLabel.Visible = False
            End If

            If InputListBoxWav.Items.Count = 0 Then
                inputMessageLabelWav.Visible = True
            Else
                inputMessageLabelWav.Visible = False
            End If

            If InputListBox.Items.Count < 1 Then
                StartButton.Enabled = False
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub bitRateDropBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bitRateDropBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub bitRateDropBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles bitRateDropBox.Leave
        Try
            If bitRateDropBox.Text = "" Then
                bitRateDropBox.Text = "320"
            Else
                Dim bitrate As Integer = Integer.Parse(bitRateDropBox.Text)
                If bitrate < 96 Then
                    bitRateDropBox.Text = "96"
                ElseIf bitrate > 320 Then
                    bitRateDropBox.Text = "320"
                End If
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub lowqbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowQButton.Click
        bitRateDropBox.Text = "128"
        modeDropBox.Text = "0 - CBR"
    End Sub

    Private Sub MediumQButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumQButton.Click
        bitRateDropBox.Text = "192"
        modeDropBox.Text = "0 - CBR"
    End Sub

    Private Sub HighQButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighQButton.Click
        bitRateDropBox.Text = "256"
        modeDropBox.Text = "0 - CBR"
    End Sub

    Private Sub UltraQButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraQButton.Click
        bitRateDropBox.Text = "320"
        modeDropBox.Text = "0 - CBR"
    End Sub

    Private Sub inputlistbox_dragdrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputListBox.DragDrop
        Try
            Dim file_names As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
            For Each file_name As String In file_names
                InputListBox.Items.Add(file_name)
            Next file_name

            'Makes sure that the files are MP3's or WAV's
1:
            For Each itm As String In InputListBox.Items
                If itm.EndsWith(".wav") Then
                    'Do Nothing For Now
                Else
                    InputListBox.Items.Remove(itm)
                    GoTo 1
                End If
            Next

            'Makes sure there are no duplicate files
            Dim counter As Integer
2:
            For Each itm As String In InputListBox.Items
                counter = 0
                For Each item As String In InputListBox.Items
                    If item = itm Then
                        counter = counter + 1
                        If counter >= 2 Then
                            InputListBox.Items.Remove(itm)
                            GoTo 2
                        End If
                    End If
                Next
            Next

            If InputListBox.Items.Count = 0 Then
                inputMessageLabel.Visible = True
                StartButton.Enabled = False
            Else
                inputMessageLabel.Visible = False
                StartButton.Enabled = True
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub inputlistbox_dragenter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputListBox.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
            inputMessageLabel.Visible = False
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub outputButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles outputButton.Click
        Try
            Dim FolderBrowserDialog1 As New FolderBrowserDialog
            Dim location As String = "::{450D8FBA-AD25-11D0-98A8-0800361B1103}\My Music"

            With FolderBrowserDialog1
                .RootFolder = Environment.SpecialFolder.Desktop
                .SelectedPath = location
                .Description = "Select where you want to output the file."
                If .ShowDialog = DialogResult.OK Then
                    outputBox.Text = .SelectedPath
                End If
            End With
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub RemoveButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Try
1:
            For Each x As String In InputListBox.SelectedItems
                InputListBox.Items.Remove(x)
                GoTo 1
            Next
            If InputListBox.Items.Count = 0 Then
                inputMessageLabel.Visible = True
                StartButton.Enabled = False
            Else
                inputMessageLabel.Visible = False
                StartButton.Enabled = True
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub RemoveAllButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveAllButton.Click
        InputListBox.Items.Clear()
        If InputListBox.Items.Count = 0 Then
            inputMessageLabel.Visible = True
            StartButton.Enabled = False
        Else
            inputMessageLabel.Visible = False
            StartButton.Enabled = True
        End If
    End Sub

    Private Sub InputListBox_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles InputListBox.DragLeave
        If InputListBox.Items.Count = 0 Then
            inputMessageLabel.Visible = True
        End If
    End Sub

    Private Sub InputListBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InputListBox.KeyUp
        If (e.KeyCode = Keys.Delete) Then
1:
            For Each x As String In InputListBox.SelectedItems
                InputListBox.Items.Remove(x)
                GoTo 1
            Next
        End If
        If InputListBox.Items.Count = 0 Then
            inputMessageLabel.Visible = True
            StartButton.Enabled = False
        Else
            inputMessageLabel.Visible = False
            StartButton.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("http://www.all4mp3.com/Default.aspx")
    End Sub

    Private Sub InputButtonWav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButtonWav.Click
        Try
            Dim fdlg As OpenFileDialog = New OpenFileDialog()
            fdlg.Title = "Pick A Wave or MP3 File"
            If Not My.Settings.LastInputDirectory = "" Then
                fdlg.InitialDirectory = My.Settings.LastInputDirectoryWav
            Else
                fdlg.InitialDirectory = "::{450D8FBA-AD25-11D0-98A8-0800361B1103}\My Music"
            End If
            fdlg.Filter = "MP3 Files (*.mp3)|*.mp3"
            fdlg.FilterIndex = 3
            fdlg.RestoreDirectory = True
            fdlg.Multiselect = True
            If fdlg.ShowDialog() = DialogResult.OK Then
                Dim Path As String
                Dim Pos As Integer
                Path = IO.Path.GetFullPath(fdlg.FileName)
                Pos = Path.LastIndexOf("\")
                Path = Path.Substring(0, Pos + 1)
                My.Settings.LastInputDirectoryWav = Path

                InputListBoxWav.Items.AddRange(fdlg.FileNames)
            End If

2:
            For Each itm As String In InputListBoxWav.Items
                If itm.EndsWith(".mp3") Then

                Else
                    InputListBoxWav.Items.Remove(itm)
                    GoTo 2
                End If
            Next

            Dim counter As Integer
1:
            For Each itm As String In InputListBoxWav.Items
                counter = 0
                For Each item As String In InputListBoxWav.Items
                    If item = itm Then
                        counter = counter + 1
                        If counter >= 2 Then
                            InputListBoxWav.Items.Remove(itm)
                            GoTo 1
                        End If
                    End If
                Next
            Next

            If InputListBoxWav.Items.Count = 0 Then
                inputMessageLabelWav.Visible = True
            Else
                inputMessageLabelWav.Visible = False
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub InputListBoxWav_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputListBoxWav.DragDrop
        Try
            Dim file_names As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
            For Each file_name As String In file_names
                InputListBoxWav.Items.Add(file_name)
            Next file_name

            'Makes sure that the files are MP3's or WAV's
1:
            For Each itm As String In InputListBoxWav.Items
                If itm.EndsWith(".mp3") Then
                    'Do Nothing For Now
                Else
                    InputListBoxWav.Items.Remove(itm)
                    GoTo 1
                End If
            Next

            'Makes sure there are no duplicate files
            Dim counter As Integer
2:
            For Each itm As String In InputListBoxWav.Items
                counter = 0
                For Each item As String In InputListBoxWav.Items
                    If item = itm Then
                        counter = counter + 1
                        If counter >= 2 Then
                            InputListBoxWav.Items.Remove(itm)
                            GoTo 2
                        End If
                    End If
                Next
            Next

            If InputListBoxWav.Items.Count = 0 Then
                inputMessageLabelWav.Visible = True
            Else
                inputMessageLabelWav.Visible = False
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub InputListBoxWav_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputListBoxWav.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
            inputMessageLabelWav.Visible = False
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub InputListBoxWav_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles InputListBoxWav.DragLeave
        If InputListBoxWav.Items.Count = 0 Then
            inputMessageLabelWav.Visible = True
        Else
            inputMessageLabelWav.Visible = False
        End If
    End Sub

    Private Sub InputListBoxWav_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InputListBoxWav.KeyUp
        If (e.KeyCode = Keys.Delete) Then
1:
            For Each x As String In InputListBoxWav.SelectedItems
                InputListBoxWav.Items.Remove(x)
                GoTo 1
            Next
        End If
        If InputListBoxWav.Items.Count = 0 Then
            inputMessageLabelWav.Visible = True
        Else
            inputMessageLabelWav.Visible = False
        End If
    End Sub

    Private Sub RemoveAllButtonWav_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RemoveAllButtonWav.Click
        InputListBoxWav.Items.Clear()
        If InputListBoxWav.Items.Count = 0 Then
            inputMessageLabelWav.Visible = True
        Else
            inputMessageLabelWav.Visible = False
        End If
    End Sub

    Private Sub RemoveButtonWav_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RemoveButtonWav.Click
        Try
1:
            For Each x As String In InputListBoxWav.SelectedItems
                InputListBoxWav.Items.Remove(x)
                GoTo 1
            Next
            If InputListBoxWav.Items.Count = 0 Then
                inputMessageLabelWav.Visible = True
            Else
                inputMessageLabelWav.Visible = False
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub OutputButtonWav_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OutputButtonWav.Click
        Try
            Dim FolderBrowserDialog1 As New FolderBrowserDialog
            Dim location As String = "::{450D8FBA-AD25-11D0-98A8-0800361B1103}\My Music"

            With FolderBrowserDialog1
                .RootFolder = Environment.SpecialFolder.Desktop
                .SelectedPath = location
                .Description = "Select where you want to output the file."
                If .ShowDialog = DialogResult.OK Then
                    OutputBoxWav.Text = .SelectedPath
                End If
            End With
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub StartButtonWav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButtonWav.Click
        Try
            If CheckBox2.Checked = True Then
                Dim confirm As DialogResult
                confirm = MessageBox.Show("Are you sure you want to delete the original file?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.No Then
                    CheckBox2.Checked = False
                    Exit Sub
                End If
            End If

            For x = 0 To InputListBoxWav.Items.Count() - 1

                If InputListBoxWav.Items.Count() = 0 Then
                    MessageBox.Show("You must select at least one file to decode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim Input As String = CStr(InputListBoxWav.Items.Item(x))
                Dim process As New ProcessStartInfo
                Dim pathroot, isCorrect As String
                Dim outputlocation As String

                isCorrect = IO.Path.GetExtension(Input)
                pathroot = IO.Path.GetFullPath(Input)
                pathroot = IO.Path.ChangeExtension(pathroot, "")

                If OutputBoxWav.Text = "" Or OutputBoxWav.Text = "Leave This Message For Same Directory" Then
                    outputlocation = pathroot
                Else
                    outputlocation = OutputBoxWav.Text
                    outputlocation = outputlocation & "\" & IO.Path.GetFileName(Input)
                    outputlocation = IO.Path.ChangeExtension(outputlocation, "")
                End If


                If IO.File.Exists(outputlocation & "wav") Then
                    Dim confirm As DialogResult
                    confirm = MessageBox.Show("The output file already exists, do you want to overwrite it?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                    If confirm = DialogResult.Yes Then
                        Dim myprocess As Process = System.Diagnostics.Process.Start(progPath & "\mp3hddecoder.exe", "-if """ & Input & """ -of """ & outputlocation & "wav""")
                        myprocess.WaitForExit()
                    ElseIf confirm = DialogResult.No Then
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                Else
                    Dim myprocess As Process = System.Diagnostics.Process.Start(progPath & "\mp3hddecoder.exe", "-if """ & Input & """ -of """ & outputlocation & "wav""")
                    Do Until myprocess.HasExited = True
                        Me.WindowState = FormWindowState.Minimized
                    Loop

                    'myprocess.WaitForExit()
                End If

                If CheckBox2.Checked = True Then
                    My.Computer.FileSystem.DeleteFile(Input, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                End If
            Next

            InputListBoxWav.Items.Clear()

            inputMessageLabelWav.Visible = True
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub ClearButtonWav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButtonWav.Click
        InputListBoxWav.Items.Clear()
        OutputBoxWav.Text = "Leave This Message For Same Directory"
        CheckBox2.Checked = False
        inputMessageLabelWav.Visible = True
    End Sub

    Private Sub winampButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles winampButton.Click
        Try
            Dim FolderBrowserDialog1 As New FolderBrowserDialog
            With FolderBrowserDialog1
                .RootFolder = Environment.SpecialFolder.Desktop
                .SelectedPath = "C:\Program Files\Winamp"
                .Description = "Choose your Winamp Folder (Usually in C:\Program Files\)"
                If .ShowDialog = DialogResult.OK Then
                    If IO.File.Exists(.SelectedPath & "\plugins\in_mp3hd.dll") Then
                        MessageBox.Show("The File Has Been Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        IO.File.Copy("in_mp3hd.dll", .SelectedPath & "\plugins\in_mp3hd.dll")
                        MessageBox.Show("The File Has Been Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End With
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub licenseRadio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles licenseRadio.CheckedChanged
        Try
            If licenseRadio.Checked = True Then
                Dim test As String
                Dim pos As Integer
                test = Application.ExecutablePath
                pos = test.LastIndexOf("\")
                test = test.Remove(pos + 1, test.Length - pos - 1)
                Dim objReader As StreamReader = New StreamReader(test & "license.txt")
                Dim strContents As String = objReader.ReadToEnd()
                objReader.Close()

                changeRichText.Text = strContents
            ElseIf changeRadio.Checked = True Then
                Dim test As String
                Dim pos As Integer
                test = Application.ExecutablePath
                pos = test.LastIndexOf("\")
                test = test.Remove(pos + 1, test.Length - pos - 1)
                Dim objReader As StreamReader = New StreamReader(test & "Change Log.txt")
                Dim strContents As String = objReader.ReadToEnd()
                objReader.Close()

                changeRichText.Text = strContents

            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub contactButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contactButton.Click
        Try
            Dim name, email, subject, message As String

            name = contactNameBox.Text
            email = contactEmailBox.Text
            subject = contactSubjectBox.Text
            message = contactMessageBox.Text

            If File.Exists("error.log") = True Then
                Dim errorReport() As String = File.ReadAllLines("error.log")
                For Each x In errorReport
                    message = message.Insert(message.Length, ControlChars.NewLine _
                                             & ControlChars.NewLine & x)
                Next
                File.Delete("error.log")
            End If

            If name = "" Then
                name = "Anonymous"
            End If

            If email = "" Then
                email = "Anonymous@anonymous.com"
            End If

            message = message.Insert(0, "Subject: " & subject & ControlChars.NewLine & ControlChars.NewLine)
            message = message.Insert(0, "Email: " & email & ControlChars.NewLine)
            message = message.Insert(0, "Name: " & name & ControlChars.NewLine)

            Dim emailAddress() As String = {"", ""}

            For Each x In emailAddress
                Dim SmtpServer As New SmtpClient()
                Dim mail As New MailMessage()

                SmtpServer.Credentials = New Net.NetworkCredential("", "")
                SmtpServer.Port = 587
                SmtpServer.Host = "smtp.gmail.com"
                SmtpServer.EnableSsl = True

                mail = New MailMessage()
                mail.From = New MailAddress(email)
                mail.To.Add(x)
                mail.Subject = subject
                mail.Body = message
                SmtpServer.Send(mail)
            Next

            MessageBox.Show("Your message has been sent, Thank you.", _
                            "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        contactNameBox.Text = ""
        contactEmailBox.Text = ""
        contactSubjectBox.SelectedIndex = -1
        contactMessageBox.Text = ""
        contactNameBox.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearErrorLogButton.Click
        Try
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            If File.Exists(test & "error.log") = True Then
                File.Delete(test & "error.log")
            End If
            MessageBox.Show("Error Log Cleared", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim test As String
            Dim pos As Integer
            test = Application.ExecutablePath
            pos = test.LastIndexOf("\")
            test = test.Remove(pos + 1, test.Length - pos - 1)
            File.AppendAllText(test & "error.log", x.Message & ControlChars.NewLine)
            TabControl1.SelectedTab = contactTab
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.fen-soft.com/")
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            renameCheck.Visible = True
        Else
            renameCheck.Visible = False
            renameCheck.Checked = False
        End If
    End Sub
End Class