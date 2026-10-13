Option Strict On
Option Explicit On
Imports System.IO

Public Class Form2

    Public Sub New(ByVal strTextBox As String)
        InitializeComponent()
        Label7.Text = strTextBox
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Dim frm As Form1 = Form1
        frm.recieveCancel(True)
        Me.Close()
    End Sub

    Private Sub trackBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles trackBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub yearBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles yearBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub continueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles continueButton.Click
        File.AppendAllText("mp3hdconverter.jsf", " -Title """ & titleBox.Text & """" & _
                           " -Artist """ & artistBox.Text & """" & " -Album """ & albumBox.Text & """" & _
                           " -Track """ & trackBox.Text & """" & " -Year """ & yearBox.Text _
                           & """" & " -Genre """ & genreBox.Text & """" & " -Encoder ""MP3HD Converter - Jeff Fenster - Thomson" & ControlChars.NewLine)
        Me.Close()
    End Sub
End Class