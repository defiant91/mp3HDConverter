<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Encoder = New System.Windows.Forms.TabPage
        Me.renameCheck = New System.Windows.Forms.CheckBox
        Me.inputMessageLabel = New System.Windows.Forms.Label
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.UltraQButton = New System.Windows.Forms.Button
        Me.HighQButton = New System.Windows.Forms.Button
        Me.MediumQButton = New System.Windows.Forms.Button
        Me.LowQButton = New System.Windows.Forms.Button
        Me.RemoveAllButton = New System.Windows.Forms.Button
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.InputListBox = New System.Windows.Forms.ListBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.outputButton = New System.Windows.Forms.Button
        Me.outputBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.bitRateDropBox = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ClearButton = New System.Windows.Forms.Button
        Me.StartButton = New System.Windows.Forms.Button
        Me.modeDropBox = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.inputButton = New System.Windows.Forms.Button
        Me.Decoder = New System.Windows.Forms.TabPage
        Me.inputMessageLabelWav = New System.Windows.Forms.Label
        Me.RemoveAllButtonWav = New System.Windows.Forms.Button
        Me.RemoveButtonWav = New System.Windows.Forms.Button
        Me.InputListBoxWav = New System.Windows.Forms.ListBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.OutputButtonWav = New System.Windows.Forms.Button
        Me.OutputBoxWav = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ClearButtonWav = New System.Windows.Forms.Button
        Me.StartButtonWav = New System.Windows.Forms.Button
        Me.InputButtonWav = New System.Windows.Forms.Button
        Me.Miscellaneous = New System.Windows.Forms.TabPage
        Me.clearErrorLogButton = New System.Windows.Forms.Button
        Me.changeRichText = New System.Windows.Forms.RichTextBox
        Me.changeRadio = New System.Windows.Forms.RadioButton
        Me.licenseRadio = New System.Windows.Forms.RadioButton
        Me.winampButton = New System.Windows.Forms.Button
        Me.contactTab = New System.Windows.Forms.TabPage
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.contactNameBox = New System.Windows.Forms.TextBox
        Me.contactEmailBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.contactMessageBox = New System.Windows.Forms.RichTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.contactSubjectBox = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.contactButton = New System.Windows.Forms.Button
        Me.aboutTab = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.TabControl1.SuspendLayout()
        Me.Encoder.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Decoder.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Miscellaneous.SuspendLayout()
        Me.contactTab.SuspendLayout()
        Me.aboutTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 0
        Me.ToolTip1.InitialDelay = 0
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Encoder)
        Me.TabControl1.Controls.Add(Me.Decoder)
        Me.TabControl1.Controls.Add(Me.Miscellaneous)
        Me.TabControl1.Controls.Add(Me.contactTab)
        Me.TabControl1.Controls.Add(Me.aboutTab)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Location = New System.Drawing.Point(-6, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(633, 371)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'Encoder
        '
        Me.Encoder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Encoder.Controls.Add(Me.renameCheck)
        Me.Encoder.Controls.Add(Me.inputMessageLabel)
        Me.Encoder.Controls.Add(Me.CheckBox3)
        Me.Encoder.Controls.Add(Me.GroupBox1)
        Me.Encoder.Controls.Add(Me.RemoveAllButton)
        Me.Encoder.Controls.Add(Me.RemoveButton)
        Me.Encoder.Controls.Add(Me.InputListBox)
        Me.Encoder.Controls.Add(Me.CheckBox1)
        Me.Encoder.Controls.Add(Me.outputButton)
        Me.Encoder.Controls.Add(Me.outputBox)
        Me.Encoder.Controls.Add(Me.Label6)
        Me.Encoder.Controls.Add(Me.PictureBox1)
        Me.Encoder.Controls.Add(Me.bitRateDropBox)
        Me.Encoder.Controls.Add(Me.Label3)
        Me.Encoder.Controls.Add(Me.ClearButton)
        Me.Encoder.Controls.Add(Me.StartButton)
        Me.Encoder.Controls.Add(Me.modeDropBox)
        Me.Encoder.Controls.Add(Me.Label2)
        Me.Encoder.Controls.Add(Me.Label1)
        Me.Encoder.Controls.Add(Me.inputButton)
        Me.Encoder.Location = New System.Drawing.Point(4, 22)
        Me.Encoder.Name = "Encoder"
        Me.Encoder.Padding = New System.Windows.Forms.Padding(3)
        Me.Encoder.Size = New System.Drawing.Size(625, 345)
        Me.Encoder.TabIndex = 0
        Me.Encoder.Text = "Encoder"
        '
        'renameCheck
        '
        Me.renameCheck.AutoSize = True
        Me.renameCheck.Location = New System.Drawing.Point(163, 279)
        Me.renameCheck.Name = "renameCheck"
        Me.renameCheck.Size = New System.Drawing.Size(167, 17)
        Me.renameCheck.TabIndex = 40
        Me.renameCheck.Text = "Rename Files to ""Artist - Title"""
        Me.renameCheck.UseVisualStyleBackColor = True
        Me.renameCheck.Visible = False
        '
        'inputMessageLabel
        '
        Me.inputMessageLabel.AutoSize = True
        Me.inputMessageLabel.BackColor = System.Drawing.Color.White
        Me.inputMessageLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputMessageLabel.Location = New System.Drawing.Point(139, 61)
        Me.inputMessageLabel.Name = "inputMessageLabel"
        Me.inputMessageLabel.Size = New System.Drawing.Size(245, 46)
        Me.inputMessageLabel.TabIndex = 39
        Me.inputMessageLabel.Text = "Drag and Drop a Wave file here" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or use the browse button"
        Me.inputMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(163, 256)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(75, 17)
        Me.CheckBox3.TabIndex = 8
        Me.CheckBox3.Text = "Tag File(s)"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UltraQButton)
        Me.GroupBox1.Controls.Add(Me.HighQButton)
        Me.GroupBox1.Controls.Add(Me.MediumQButton)
        Me.GroupBox1.Controls.Add(Me.LowQButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(378, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 105)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preset Quality (backward compatible mp3 file)"
        '
        'UltraQButton
        '
        Me.UltraQButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraQButton.Location = New System.Drawing.Point(127, 62)
        Me.UltraQButton.Name = "UltraQButton"
        Me.UltraQButton.Size = New System.Drawing.Size(94, 34)
        Me.UltraQButton.TabIndex = 32
        Me.UltraQButton.TabStop = False
        Me.UltraQButton.Text = "Highest"
        Me.UltraQButton.UseVisualStyleBackColor = True
        '
        'HighQButton
        '
        Me.HighQButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighQButton.Location = New System.Drawing.Point(17, 62)
        Me.HighQButton.Name = "HighQButton"
        Me.HighQButton.Size = New System.Drawing.Size(94, 34)
        Me.HighQButton.TabIndex = 30
        Me.HighQButton.TabStop = False
        Me.HighQButton.Text = "Higher"
        Me.HighQButton.UseVisualStyleBackColor = True
        '
        'MediumQButton
        '
        Me.MediumQButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MediumQButton.Location = New System.Drawing.Point(127, 20)
        Me.MediumQButton.Name = "MediumQButton"
        Me.MediumQButton.Size = New System.Drawing.Size(94, 34)
        Me.MediumQButton.TabIndex = 29
        Me.MediumQButton.TabStop = False
        Me.MediumQButton.Text = "High"
        Me.MediumQButton.UseVisualStyleBackColor = True
        '
        'LowQButton
        '
        Me.LowQButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LowQButton.Location = New System.Drawing.Point(17, 20)
        Me.LowQButton.Name = "LowQButton"
        Me.LowQButton.Size = New System.Drawing.Size(94, 34)
        Me.LowQButton.TabIndex = 27
        Me.LowQButton.TabStop = False
        Me.LowQButton.Text = "Default"
        Me.LowQButton.UseVisualStyleBackColor = True
        '
        'RemoveAllButton
        '
        Me.RemoveAllButton.Location = New System.Drawing.Point(516, 168)
        Me.RemoveAllButton.Name = "RemoveAllButton"
        Me.RemoveAllButton.Size = New System.Drawing.Size(80, 21)
        Me.RemoveAllButton.TabIndex = 3
        Me.RemoveAllButton.Text = "Remove All"
        Me.RemoveAllButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(516, 141)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(80, 21)
        Me.RemoveButton.TabIndex = 2
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'InputListBox
        '
        Me.InputListBox.AllowDrop = True
        Me.InputListBox.FormattingEnabled = True
        Me.InputListBox.HorizontalScrollbar = True
        Me.InputListBox.Location = New System.Drawing.Point(56, 3)
        Me.InputListBox.Name = "InputListBox"
        Me.InputListBox.ScrollAlwaysVisible = True
        Me.InputListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.InputListBox.Size = New System.Drawing.Size(454, 186)
        Me.InputListBox.TabIndex = 0
        Me.InputListBox.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(244, 256)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Delete Original File(s)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'outputButton
        '
        Me.outputButton.Location = New System.Drawing.Point(516, 200)
        Me.outputButton.Name = "outputButton"
        Me.outputButton.Size = New System.Drawing.Size(80, 20)
        Me.outputButton.TabIndex = 4
        Me.outputButton.Text = "Browse"
        Me.outputButton.UseVisualStyleBackColor = True
        '
        'outputBox
        '
        Me.outputBox.AllowDrop = True
        Me.outputBox.Location = New System.Drawing.Point(56, 200)
        Me.outputBox.Name = "outputBox"
        Me.outputBox.ReadOnly = True
        Me.outputBox.Size = New System.Drawing.Size(454, 20)
        Me.outputBox.TabIndex = 0
        Me.outputBox.TabStop = False
        Me.outputBox.Text = "Leave This Message For Same Directory"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Output:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.MP3HD_Converter.My.Resources.Resource1.MP3HD
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(14, 259)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 80)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'bitRateDropBox
        '
        Me.bitRateDropBox.FormattingEnabled = True
        Me.bitRateDropBox.Items.AddRange(New Object() {"96", "128", "160", "192", "256", "320"})
        Me.bitRateDropBox.Location = New System.Drawing.Point(59, 227)
        Me.bitRateDropBox.MaxLength = 3
        Me.bitRateDropBox.Name = "bitRateDropBox"
        Me.bitRateDropBox.Size = New System.Drawing.Size(127, 21)
        Me.bitRateDropBox.TabIndex = 5
        Me.bitRateDropBox.Text = "320"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Input:"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(278, 299)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(94, 35)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Enabled = False
        Me.StartButton.Location = New System.Drawing.Point(163, 299)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(94, 35)
        Me.StartButton.TabIndex = 9
        Me.StartButton.Text = "&Encode!"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'modeDropBox
        '
        Me.modeDropBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.modeDropBox.FormattingEnabled = True
        Me.modeDropBox.Items.AddRange(New Object() {"0 - CBR", "1 - VBR HQ", "2 - VBR MHQ", "3 - VBR MQ", "4 - VBR MLQ", "5 - VBR LQ"})
        Me.modeDropBox.Location = New System.Drawing.Point(248, 229)
        Me.modeDropBox.Name = "modeDropBox"
        Me.modeDropBox.Size = New System.Drawing.Size(127, 21)
        Me.modeDropBox.TabIndex = 6
        Me.modeDropBox.Text = "0 - CBR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mode:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bit Rate:"
        '
        'inputButton
        '
        Me.inputButton.Location = New System.Drawing.Point(516, 3)
        Me.inputButton.Name = "inputButton"
        Me.inputButton.Size = New System.Drawing.Size(80, 20)
        Me.inputButton.TabIndex = 0
        Me.inputButton.Text = "Browse"
        Me.inputButton.UseVisualStyleBackColor = True
        '
        'Decoder
        '
        Me.Decoder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Decoder.Controls.Add(Me.inputMessageLabelWav)
        Me.Decoder.Controls.Add(Me.RemoveAllButtonWav)
        Me.Decoder.Controls.Add(Me.RemoveButtonWav)
        Me.Decoder.Controls.Add(Me.InputListBoxWav)
        Me.Decoder.Controls.Add(Me.CheckBox2)
        Me.Decoder.Controls.Add(Me.OutputButtonWav)
        Me.Decoder.Controls.Add(Me.OutputBoxWav)
        Me.Decoder.Controls.Add(Me.Label4)
        Me.Decoder.Controls.Add(Me.PictureBox2)
        Me.Decoder.Controls.Add(Me.Label8)
        Me.Decoder.Controls.Add(Me.ClearButtonWav)
        Me.Decoder.Controls.Add(Me.StartButtonWav)
        Me.Decoder.Controls.Add(Me.InputButtonWav)
        Me.Decoder.Location = New System.Drawing.Point(4, 22)
        Me.Decoder.Name = "Decoder"
        Me.Decoder.Padding = New System.Windows.Forms.Padding(3)
        Me.Decoder.Size = New System.Drawing.Size(625, 345)
        Me.Decoder.TabIndex = 1
        Me.Decoder.Text = "Decoder"
        '
        'inputMessageLabelWav
        '
        Me.inputMessageLabelWav.AutoSize = True
        Me.inputMessageLabelWav.BackColor = System.Drawing.Color.White
        Me.inputMessageLabelWav.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputMessageLabelWav.Location = New System.Drawing.Point(139, 61)
        Me.inputMessageLabelWav.Name = "inputMessageLabelWav"
        Me.inputMessageLabelWav.Size = New System.Drawing.Size(269, 46)
        Me.inputMessageLabelWav.TabIndex = 57
        Me.inputMessageLabelWav.Text = "Drag and Drop an MP3HD file here" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or use the browse button"
        Me.inputMessageLabelWav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RemoveAllButtonWav
        '
        Me.RemoveAllButtonWav.Location = New System.Drawing.Point(516, 168)
        Me.RemoveAllButtonWav.Name = "RemoveAllButtonWav"
        Me.RemoveAllButtonWav.Size = New System.Drawing.Size(80, 21)
        Me.RemoveAllButtonWav.TabIndex = 3
        Me.RemoveAllButtonWav.Text = "Remove All"
        Me.RemoveAllButtonWav.UseVisualStyleBackColor = True
        '
        'RemoveButtonWav
        '
        Me.RemoveButtonWav.Location = New System.Drawing.Point(516, 141)
        Me.RemoveButtonWav.Name = "RemoveButtonWav"
        Me.RemoveButtonWav.Size = New System.Drawing.Size(80, 21)
        Me.RemoveButtonWav.TabIndex = 2
        Me.RemoveButtonWav.Text = "Remove"
        Me.RemoveButtonWav.UseVisualStyleBackColor = True
        '
        'InputListBoxWav
        '
        Me.InputListBoxWav.AllowDrop = True
        Me.InputListBoxWav.FormattingEnabled = True
        Me.InputListBoxWav.HorizontalScrollbar = True
        Me.InputListBoxWav.Location = New System.Drawing.Point(56, 3)
        Me.InputListBoxWav.Name = "InputListBoxWav"
        Me.InputListBoxWav.ScrollAlwaysVisible = True
        Me.InputListBoxWav.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.InputListBoxWav.Size = New System.Drawing.Size(454, 186)
        Me.InputListBoxWav.TabIndex = 56
        Me.InputListBoxWav.TabStop = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(244, 256)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Delete Original File(s)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'OutputButtonWav
        '
        Me.OutputButtonWav.Location = New System.Drawing.Point(516, 200)
        Me.OutputButtonWav.Name = "OutputButtonWav"
        Me.OutputButtonWav.Size = New System.Drawing.Size(80, 20)
        Me.OutputButtonWav.TabIndex = 4
        Me.OutputButtonWav.Text = "Browse"
        Me.OutputButtonWav.UseVisualStyleBackColor = True
        '
        'OutputBoxWav
        '
        Me.OutputBoxWav.AllowDrop = True
        Me.OutputBoxWav.Location = New System.Drawing.Point(56, 200)
        Me.OutputBoxWav.Name = "OutputBoxWav"
        Me.OutputBoxWav.ReadOnly = True
        Me.OutputBoxWav.Size = New System.Drawing.Size(454, 20)
        Me.OutputBoxWav.TabIndex = 55
        Me.OutputBoxWav.TabStop = False
        Me.OutputBoxWav.Text = "Leave This Message For Same Directory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Output:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.MP3HD_Converter.My.Resources.Resource1.MP3HD
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(14, 259)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 80)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Input:"
        '
        'ClearButtonWav
        '
        Me.ClearButtonWav.Location = New System.Drawing.Point(278, 299)
        Me.ClearButtonWav.Name = "ClearButtonWav"
        Me.ClearButtonWav.Size = New System.Drawing.Size(94, 35)
        Me.ClearButtonWav.TabIndex = 7
        Me.ClearButtonWav.Text = "&Clear"
        Me.ClearButtonWav.UseVisualStyleBackColor = True
        '
        'StartButtonWav
        '
        Me.StartButtonWav.Location = New System.Drawing.Point(163, 299)
        Me.StartButtonWav.Name = "StartButtonWav"
        Me.StartButtonWav.Size = New System.Drawing.Size(94, 35)
        Me.StartButtonWav.TabIndex = 6
        Me.StartButtonWav.Text = "&Decode!"
        Me.StartButtonWav.UseVisualStyleBackColor = True
        '
        'InputButtonWav
        '
        Me.InputButtonWav.Location = New System.Drawing.Point(516, 3)
        Me.InputButtonWav.Name = "InputButtonWav"
        Me.InputButtonWav.Size = New System.Drawing.Size(80, 20)
        Me.InputButtonWav.TabIndex = 1
        Me.InputButtonWav.Text = "Browse"
        Me.InputButtonWav.UseVisualStyleBackColor = True
        '
        'Miscellaneous
        '
        Me.Miscellaneous.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Miscellaneous.Controls.Add(Me.clearErrorLogButton)
        Me.Miscellaneous.Controls.Add(Me.changeRichText)
        Me.Miscellaneous.Controls.Add(Me.changeRadio)
        Me.Miscellaneous.Controls.Add(Me.licenseRadio)
        Me.Miscellaneous.Controls.Add(Me.winampButton)
        Me.Miscellaneous.Location = New System.Drawing.Point(4, 22)
        Me.Miscellaneous.Name = "Miscellaneous"
        Me.Miscellaneous.Padding = New System.Windows.Forms.Padding(3)
        Me.Miscellaneous.Size = New System.Drawing.Size(625, 345)
        Me.Miscellaneous.TabIndex = 2
        Me.Miscellaneous.Text = "Tools"
        '
        'clearErrorLogButton
        '
        Me.clearErrorLogButton.Location = New System.Drawing.Point(317, 3)
        Me.clearErrorLogButton.Name = "clearErrorLogButton"
        Me.clearErrorLogButton.Size = New System.Drawing.Size(96, 26)
        Me.clearErrorLogButton.TabIndex = 3
        Me.clearErrorLogButton.Text = "Clear Error Log"
        Me.clearErrorLogButton.UseVisualStyleBackColor = True
        '
        'changeRichText
        '
        Me.changeRichText.HideSelection = False
        Me.changeRichText.Location = New System.Drawing.Point(14, 35)
        Me.changeRichText.Name = "changeRichText"
        Me.changeRichText.ReadOnly = True
        Me.changeRichText.Size = New System.Drawing.Size(594, 299)
        Me.changeRichText.TabIndex = 0
        Me.changeRichText.TabStop = False
        Me.changeRichText.Text = ""
        '
        'changeRadio
        '
        Me.changeRadio.AutoSize = True
        Me.changeRadio.Location = New System.Drawing.Point(120, 8)
        Me.changeRadio.Name = "changeRadio"
        Me.changeRadio.Size = New System.Drawing.Size(102, 17)
        Me.changeRadio.TabIndex = 2
        Me.changeRadio.Text = "View Changelog"
        Me.changeRadio.UseVisualStyleBackColor = True
        '
        'licenseRadio
        '
        Me.licenseRadio.AutoSize = True
        Me.licenseRadio.Checked = True
        Me.licenseRadio.Location = New System.Drawing.Point(14, 8)
        Me.licenseRadio.Name = "licenseRadio"
        Me.licenseRadio.Size = New System.Drawing.Size(88, 17)
        Me.licenseRadio.TabIndex = 1
        Me.licenseRadio.TabStop = True
        Me.licenseRadio.Text = "View License"
        Me.licenseRadio.UseVisualStyleBackColor = True
        '
        'winampButton
        '
        Me.winampButton.Location = New System.Drawing.Point(419, 3)
        Me.winampButton.Name = "winampButton"
        Me.winampButton.Size = New System.Drawing.Size(189, 26)
        Me.winampButton.TabIndex = 4
        Me.winampButton.Text = "Insert Playback Plug-in into Winamp"
        Me.winampButton.UseVisualStyleBackColor = True
        '
        'contactTab
        '
        Me.contactTab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.contactTab.Controls.Add(Me.Label12)
        Me.contactTab.Controls.Add(Me.Label11)
        Me.contactTab.Controls.Add(Me.Label10)
        Me.contactTab.Controls.Add(Me.Label9)
        Me.contactTab.Controls.Add(Me.contactNameBox)
        Me.contactTab.Controls.Add(Me.contactEmailBox)
        Me.contactTab.Controls.Add(Me.Button1)
        Me.contactTab.Controls.Add(Me.contactMessageBox)
        Me.contactTab.Controls.Add(Me.Label7)
        Me.contactTab.Controls.Add(Me.contactSubjectBox)
        Me.contactTab.Controls.Add(Me.Label5)
        Me.contactTab.Controls.Add(Me.contactButton)
        Me.contactTab.Location = New System.Drawing.Point(4, 22)
        Me.contactTab.Name = "contactTab"
        Me.contactTab.Padding = New System.Windows.Forms.Padding(3)
        Me.contactTab.Size = New System.Drawing.Size(625, 345)
        Me.contactTab.TabIndex = 4
        Me.contactTab.Text = "Contact"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(169, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(267, 39)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "No personal information is collected when " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sending the message.  This is here to" & _
            " improve" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the program and to help fix bugs."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(270, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(288, 26)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Note: If you are reporting a bug/crash, please include what " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you were doing at t" & _
            "he time of the problem in the message."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Email (Optional):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Name (Optional):"
        '
        'contactNameBox
        '
        Me.contactNameBox.Location = New System.Drawing.Point(95, 12)
        Me.contactNameBox.Name = "contactNameBox"
        Me.contactNameBox.Size = New System.Drawing.Size(169, 20)
        Me.contactNameBox.TabIndex = 1
        '
        'contactEmailBox
        '
        Me.contactEmailBox.Location = New System.Drawing.Point(95, 38)
        Me.contactEmailBox.Name = "contactEmailBox"
        Me.contactEmailBox.Size = New System.Drawing.Size(169, 20)
        Me.contactEmailBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(512, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'contactMessageBox
        '
        Me.contactMessageBox.Location = New System.Drawing.Point(95, 89)
        Me.contactMessageBox.Name = "contactMessageBox"
        Me.contactMessageBox.Size = New System.Drawing.Size(412, 207)
        Me.contactMessageBox.TabIndex = 4
        Me.contactMessageBox.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Message:"
        '
        'contactSubjectBox
        '
        Me.contactSubjectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.contactSubjectBox.FormattingEnabled = True
        Me.contactSubjectBox.Items.AddRange(New Object() {"Bug Report", "Feature Request", "Question", "Thanks", "Other"})
        Me.contactSubjectBox.Location = New System.Drawing.Point(95, 64)
        Me.contactSubjectBox.Name = "contactSubjectBox"
        Me.contactSubjectBox.Size = New System.Drawing.Size(169, 21)
        Me.contactSubjectBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Subject:"
        '
        'contactButton
        '
        Me.contactButton.Location = New System.Drawing.Point(512, 258)
        Me.contactButton.Name = "contactButton"
        Me.contactButton.Size = New System.Drawing.Size(107, 37)
        Me.contactButton.TabIndex = 5
        Me.contactButton.Text = "Send Message"
        Me.contactButton.UseVisualStyleBackColor = True
        '
        'aboutTab
        '
        Me.aboutTab.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.aboutTab.Controls.Add(Me.RichTextBox1)
        Me.aboutTab.Location = New System.Drawing.Point(4, 22)
        Me.aboutTab.Name = "aboutTab"
        Me.aboutTab.Padding = New System.Windows.Forms.Padding(3)
        Me.aboutTab.Size = New System.Drawing.Size(625, 345)
        Me.aboutTab.TabIndex = 3
        Me.aboutTab.Text = "About"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(14, 6)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(594, 328)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(618, 368)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MP3HD Converter"
        Me.TabControl1.ResumeLayout(False)
        Me.Encoder.ResumeLayout(False)
        Me.Encoder.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Decoder.ResumeLayout(False)
        Me.Decoder.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Miscellaneous.ResumeLayout(False)
        Me.Miscellaneous.PerformLayout()
        Me.contactTab.ResumeLayout(False)
        Me.contactTab.PerformLayout()
        Me.aboutTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Encoder As System.Windows.Forms.TabPage
    Friend WithEvents RemoveAllButton As System.Windows.Forms.Button
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents InputListBox As System.Windows.Forms.ListBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents outputButton As System.Windows.Forms.Button
    Friend WithEvents outputBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UltraQButton As System.Windows.Forms.Button
    Friend WithEvents HighQButton As System.Windows.Forms.Button
    Friend WithEvents MediumQButton As System.Windows.Forms.Button
    Friend WithEvents LowQButton As System.Windows.Forms.Button
    Friend WithEvents bitRateDropBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents modeDropBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents inputButton As System.Windows.Forms.Button
    Friend WithEvents Decoder As System.Windows.Forms.TabPage
    Friend WithEvents RemoveAllButtonWav As System.Windows.Forms.Button
    Friend WithEvents RemoveButtonWav As System.Windows.Forms.Button
    Friend WithEvents InputListBoxWav As System.Windows.Forms.ListBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents OutputButtonWav As System.Windows.Forms.Button
    Friend WithEvents OutputBoxWav As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ClearButtonWav As System.Windows.Forms.Button
    Friend WithEvents StartButtonWav As System.Windows.Forms.Button
    Friend WithEvents InputButtonWav As System.Windows.Forms.Button
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents Miscellaneous As System.Windows.Forms.TabPage
    Friend WithEvents aboutTab As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents winampButton As System.Windows.Forms.Button
    Friend WithEvents changeRichText As System.Windows.Forms.RichTextBox
    Friend WithEvents changeRadio As System.Windows.Forms.RadioButton
    Friend WithEvents licenseRadio As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents contactTab As System.Windows.Forms.TabPage
    Friend WithEvents contactButton As System.Windows.Forms.Button
    Friend WithEvents contactSubjectBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents contactEmailBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents contactMessageBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents contactNameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents clearErrorLogButton As System.Windows.Forms.Button
    Friend WithEvents inputMessageLabel As System.Windows.Forms.Label
    Friend WithEvents inputMessageLabelWav As System.Windows.Forms.Label
    Friend WithEvents renameCheck As System.Windows.Forms.CheckBox

End Class
