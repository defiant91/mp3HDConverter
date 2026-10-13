<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.titleBox = New System.Windows.Forms.TextBox
        Me.artistBox = New System.Windows.Forms.TextBox
        Me.albumBox = New System.Windows.Forms.TextBox
        Me.trackBox = New System.Windows.Forms.TextBox
        Me.yearBox = New System.Windows.Forms.TextBox
        Me.continueButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.genreBox = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Artist:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Album:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-3, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Track #:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(119, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Year:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Genre:"
        '
        'titleBox
        '
        Me.titleBox.Location = New System.Drawing.Point(51, 27)
        Me.titleBox.Name = "titleBox"
        Me.titleBox.Size = New System.Drawing.Size(380, 20)
        Me.titleBox.TabIndex = 6
        '
        'artistBox
        '
        Me.artistBox.Location = New System.Drawing.Point(51, 55)
        Me.artistBox.Name = "artistBox"
        Me.artistBox.Size = New System.Drawing.Size(380, 20)
        Me.artistBox.TabIndex = 7
        '
        'albumBox
        '
        Me.albumBox.Location = New System.Drawing.Point(51, 82)
        Me.albumBox.Name = "albumBox"
        Me.albumBox.Size = New System.Drawing.Size(380, 20)
        Me.albumBox.TabIndex = 8
        '
        'trackBox
        '
        Me.trackBox.Location = New System.Drawing.Point(51, 108)
        Me.trackBox.MaxLength = 3
        Me.trackBox.Name = "trackBox"
        Me.trackBox.Size = New System.Drawing.Size(62, 20)
        Me.trackBox.TabIndex = 9
        '
        'yearBox
        '
        Me.yearBox.Location = New System.Drawing.Point(157, 108)
        Me.yearBox.MaxLength = 4
        Me.yearBox.Name = "yearBox"
        Me.yearBox.Size = New System.Drawing.Size(62, 20)
        Me.yearBox.TabIndex = 10
        '
        'continueButton
        '
        Me.continueButton.Location = New System.Drawing.Point(270, 134)
        Me.continueButton.Name = "continueButton"
        Me.continueButton.Size = New System.Drawing.Size(75, 23)
        Me.continueButton.TabIndex = 12
        Me.continueButton.TabStop = False
        Me.continueButton.Text = "Continue"
        Me.continueButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(356, 134)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 14
        Me.exitButton.TabStop = False
        Me.exitButton.Text = "Cancel"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Label7"
        '
        'genreBox
        '
        Me.genreBox.AutoCompleteCustomSource.AddRange(New String() {"Acid Jazz", "Alt-Country", "Alternative", "Ambient", "Ancient Greek Music", "Andean", "Art Song", "Baroque", "Bhangra", "Black Metal", "Bluegrass", "Blues", "Boogie Woogie", "Bossa Nova", "Breakbeat", "Cajun and Zydeco", "Calypso", "Candombe", "Caribbean", "Celtic", "Children's", "Chinese Opera", "Christian", "Christian Country", "Christian Punk", "Christian Rap and Hip Hop", "Christian Rock and Pop", "Christian Ska", "Christian Worship", "Classical", "Classical Modern", "Classical Romantic", "Country", "Dancehall Reggae", "Death Metal", "Disco", "Dixieland", "Doo Wop", "Drum and Bass", "Dub", "Early Music", "Electro", "Electronic", "Enka", "Eurodance", "Filk", "Flamenco", "Folk and Traditional", "Free Jazz", "Freestyle", "Funk", "Garage", "Go-Go", "Gospel", "Gothic", "Gregorian Chant", "Gypsy", "Hardcore", "House", "IDM", "Industrial", "Industrial Noise", "Jazz", "Jewish", "Junkanoo", "Klezmer", "Kompa", "Latin", "Latin Freestyle", "Latin Jazz", "Latin Pop", "Lounge", "March", "Mariachi", "Medieval", "Merengue", "Metal", "Microtonal", "Minimalism", "Musicals", "Musique Concrète", "New Age", "Novelty", "Opera", "Operetta", "Pagan", "Polka", "Progressive Rock", "Punk and Hardcore", "R&B and Soul", "Ragtime", "Rap and Hip-Hop", "Reggae", "Religious and Devotional", "Renaissance", "Rock and Pop", "Rockabilly", "Salsa", "Samba", "Ska", "Skiffle", "Soca", "Southern Gospel", "Spirituals", "Surf Rock", "Synthpop", "Tango", "Techno", "Tejano", "Trance", "Vallenato", "Western", "World Fusion"})
        Me.genreBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.genreBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.genreBox.FormattingEnabled = True
        Me.genreBox.Items.AddRange(New Object() {"Acid Jazz", "Alt-Country", "Alternative", "Ambient", "Baroque", "Bluegrass", "Blues", "Boogie Woogie", "Bossa Nova", "Cajun and Zydeco", "Calypso", "Caribbean", "Celtic", "Children's", "Chinese Opera", "Christian", "Christian Rock", "Christian Punk", "Christian Worship", "Classical", "Classical Modern", "Classical Romantic", "Country", "Dancehall Reggae", "Death Metal", "Disco", "Dixieland", "Doo Wop", "Drum and Bass", "Dub", "Early Music", "Electro", "Electronic", "Eurodance", "Flamenco", "Folk and Traditional", "Free Jazz", "Freestyle", "Funk", "Garage", "Go-Go", "Gospel", "Gothic", "Gregorian Chant", "Grunge", "Gypsy", "Hardcore", "Hip Hop", "Industrial", "Industrial Noise", "Jazz", "Jewish", "Latin", "Latin Freestyle", "Latin Jazz", "Latin Pop", "Lounge", "March", "Mariachi", "Medieval", "Merengue", "Metal", "Minimalism", "Musicals", "New Age", "Novelty", "Opera", "Operetta", "Pagan", "Polka", "Pop", "Post-Grunge", "Progressive Rock", "Punk and Hardcore", "R&B and Soul", "Ragtime", "Rap", "Reggae", "Religious and Devotional", "Renaissance", "Rock", "Rockabilly", "Salsa", "Samba", "Ska", "Southern Gospel", "Southern Rock", "Spirituals", "Surf Rock", "Synthpop", "Tango", "Techno", "Tejano", "Trance", "Western", "World Fusion"})
        Me.genreBox.Location = New System.Drawing.Point(270, 107)
        Me.genreBox.Name = "genreBox"
        Me.genreBox.Size = New System.Drawing.Size(161, 21)
        Me.genreBox.TabIndex = 16
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(443, 160)
        Me.ControlBox = False
        Me.Controls.Add(Me.genreBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.continueButton)
        Me.Controls.Add(Me.yearBox)
        Me.Controls.Add(Me.trackBox)
        Me.Controls.Add(Me.albumBox)
        Me.Controls.Add(Me.artistBox)
        Me.Controls.Add(Me.titleBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tag File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents titleBox As System.Windows.Forms.TextBox
    Friend WithEvents artistBox As System.Windows.Forms.TextBox
    Friend WithEvents albumBox As System.Windows.Forms.TextBox
    Friend WithEvents trackBox As System.Windows.Forms.TextBox
    Friend WithEvents yearBox As System.Windows.Forms.TextBox
    Friend WithEvents continueButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents genreBox As System.Windows.Forms.ComboBox
End Class
