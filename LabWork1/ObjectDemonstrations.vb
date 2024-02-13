Public Class ObjectDemonstrations
    Private Sub FontRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnGaramond.CheckedChanged, RadBtnMagneto.CheckedChanged, RadBtnTahoma.CheckedChanged
        ' Event handler for Font radio buttons

        Dim selectedRadioButton As RadioButton = DirectCast(sender, RadioButton)

        If selectedRadioButton.Checked Then
            ' Change the font of the text in the TextBox based on the selected radio button
            Select Case selectedRadioButton.Name
                Case "RadBtnGaramond"
                    txt.Font = New Font("Garamond", 11)
                Case "RadBtnMagneto"
                    txt.Font = New Font("Magneto", 11)
                Case "RadBtnTahoma"
                    txt.Font = New Font("Tahoma", 11)
            End Select
        End If
    End Sub

    Private Sub FontStyleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBold.CheckedChanged, CheckBoxItalic.CheckedChanged, CheckBoxBoth.CheckedChanged
        ' Event handler for Font Style checkboxes

        ' Initialize FontStyle variable to None
        Dim selectedFontStyle As FontStyle = FontStyle.Regular

        ' Check which checkboxes are checked and update the FontStyle variable
        If CheckBoxBold.Checked Then
            selectedFontStyle = selectedFontStyle Or FontStyle.Bold
        End If

        If CheckBoxItalic.Checked Then
            selectedFontStyle = selectedFontStyle Or FontStyle.Italic
        End If

        If CheckBoxBoth.Checked Then
            selectedFontStyle = selectedFontStyle Or FontStyle.Bold Or FontStyle.Italic
        End If

        ' Apply the selected FontStyle to the text in the TextBox
        txt.Font = New Font(txt.Font, selectedFontStyle)
    End Sub

    Private Sub FontColorRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnRed.CheckedChanged, RadBtnGreen.CheckedChanged, RadBtnBlue.CheckedChanged
        ' Event handler for Font Color radio buttons

        Dim selectedRadioButton As RadioButton = DirectCast(sender, RadioButton)

        If selectedRadioButton.Checked Then
            ' Change the font color of the text in the TextBox based on the selected radio button
            Select Case selectedRadioButton.Name
                Case "RadBtnRed"
                    txt.ForeColor = Color.Red
                Case "RadBtnGreen"
                    txt.ForeColor = Color.Green
                Case "RadBtnBlue"
                    txt.ForeColor = Color.Blue
            End Select
        End If
    End Sub

    Private Sub BtnLoadPicture_Click(sender As Object, e As EventArgs) Handles BtnLoadPicture.Click
        ' Create an OpenFileDialog to allow users to choose an image file
        Using openFileDialog As New OpenFileDialog()
            ' Set the file filter to restrict selection to image files
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"

            ' Check if the user clicked OK in the OpenFileDialog
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    ' Get the selected file path
                    Dim imagePath As String = openFileDialog.FileName

                    ' Display the selected image in the PictureBox with Zoom mode
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    PictureBox1.Image = Image.FromFile(imagePath)
                Catch ex As Exception
                    ' Handle any exceptions that may occur during image loading
                    MessageBox.Show("Error loading the image. Please select a valid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ' Close the current form and show the welcoming form
        Dim welcomeForm As New WelcomeForm()
        welcomeForm.Show()
        Me.Close()
    End Sub

End Class