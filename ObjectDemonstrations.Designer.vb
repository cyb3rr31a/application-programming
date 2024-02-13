<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectDemonstrations
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
        txt = New TextBox()
        GroupBox1 = New GroupBox()
        RadBtnGaramond = New RadioButton()
        RadBtnMagneto = New RadioButton()
        RadBtnTahoma = New RadioButton()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        CheckBoxItalic = New CheckBox()
        CheckBoxBold = New CheckBox()
        CheckBoxBoth = New CheckBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        RadBtnRed = New RadioButton()
        RadBtnBlue = New RadioButton()
        RadBtnGreen = New RadioButton()
        BtnLoadPicture = New Button()
        BtnExit = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' txt
        ' 
        txt.Location = New Point(6, 41)
        txt.Name = "txt"
        txt.Size = New Size(114, 31)
        txt.TabIndex = 0
        txt.Text = "Sample Test"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txt)
        GroupBox1.Location = New Point(33, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(173, 92)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Test"
        ' 
        ' RadBtnGaramond
        ' 
        RadBtnGaramond.AutoSize = True
        RadBtnGaramond.Location = New Point(6, 44)
        RadBtnGaramond.Name = "RadBtnGaramond"
        RadBtnGaramond.Size = New Size(121, 29)
        RadBtnGaramond.TabIndex = 2
        RadBtnGaramond.TabStop = True
        RadBtnGaramond.Text = "Garamond"
        RadBtnGaramond.UseVisualStyleBackColor = True
        ' 
        ' RadBtnMagneto
        ' 
        RadBtnMagneto.AutoSize = True
        RadBtnMagneto.Location = New Point(144, 44)
        RadBtnMagneto.Name = "RadBtnMagneto"
        RadBtnMagneto.Size = New Size(109, 29)
        RadBtnMagneto.TabIndex = 3
        RadBtnMagneto.TabStop = True
        RadBtnMagneto.Text = "Magneto"
        RadBtnMagneto.UseVisualStyleBackColor = True
        ' 
        ' RadBtnTahoma
        ' 
        RadBtnTahoma.AutoSize = True
        RadBtnTahoma.Location = New Point(271, 43)
        RadBtnTahoma.Name = "RadBtnTahoma"
        RadBtnTahoma.Size = New Size(99, 29)
        RadBtnTahoma.TabIndex = 4
        RadBtnTahoma.TabStop = True
        RadBtnTahoma.Text = "Tahoma"
        RadBtnTahoma.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadBtnGaramond)
        GroupBox2.Controls.Add(RadBtnTahoma)
        GroupBox2.Controls.Add(RadBtnMagneto)
        GroupBox2.Location = New Point(238, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(449, 104)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(33, 155)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(226, 228)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' CheckBoxItalic
        ' 
        CheckBoxItalic.AutoSize = True
        CheckBoxItalic.Location = New Point(6, 55)
        CheckBoxItalic.Name = "CheckBoxItalic"
        CheckBoxItalic.Size = New Size(74, 29)
        CheckBoxItalic.TabIndex = 7
        CheckBoxItalic.Text = "Italic"
        CheckBoxItalic.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxBold
        ' 
        CheckBoxBold.AutoSize = True
        CheckBoxBold.Location = New Point(6, 109)
        CheckBoxBold.Name = "CheckBoxBold"
        CheckBoxBold.Size = New Size(74, 29)
        CheckBoxBold.TabIndex = 8
        CheckBoxBold.Text = "Bold"
        CheckBoxBold.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxBoth
        ' 
        CheckBoxBoth.AutoSize = True
        CheckBoxBoth.Location = New Point(6, 161)
        CheckBoxBoth.Name = "CheckBoxBoth"
        CheckBoxBoth.Size = New Size(115, 29)
        CheckBoxBoth.TabIndex = 9
        CheckBoxBoth.Text = "Bold Italic"
        CheckBoxBoth.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CheckBoxItalic)
        GroupBox3.Controls.Add(CheckBoxBoth)
        GroupBox3.Controls.Add(CheckBoxBold)
        GroupBox3.Location = New Point(293, 155)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(175, 228)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Style"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(RadBtnRed)
        GroupBox4.Controls.Add(RadBtnBlue)
        GroupBox4.Controls.Add(RadBtnGreen)
        GroupBox4.Location = New Point(509, 155)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(178, 228)
        GroupBox4.TabIndex = 11
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font Color"
        ' 
        ' RadBtnRed
        ' 
        RadBtnRed.AutoSize = True
        RadBtnRed.Location = New Point(23, 181)
        RadBtnRed.Name = "RadBtnRed"
        RadBtnRed.Size = New Size(67, 29)
        RadBtnRed.TabIndex = 2
        RadBtnRed.TabStop = True
        RadBtnRed.Text = "Red"
        RadBtnRed.UseVisualStyleBackColor = True
        ' 
        ' RadBtnBlue
        ' 
        RadBtnBlue.AutoSize = True
        RadBtnBlue.Location = New Point(23, 108)
        RadBtnBlue.Name = "RadBtnBlue"
        RadBtnBlue.Size = New Size(70, 29)
        RadBtnBlue.TabIndex = 1
        RadBtnBlue.TabStop = True
        RadBtnBlue.Text = "Blue"
        RadBtnBlue.UseVisualStyleBackColor = True
        ' 
        ' RadBtnGreen
        ' 
        RadBtnGreen.AutoSize = True
        RadBtnGreen.Location = New Point(23, 42)
        RadBtnGreen.Name = "RadBtnGreen"
        RadBtnGreen.Size = New Size(83, 29)
        RadBtnGreen.TabIndex = 0
        RadBtnGreen.TabStop = True
        RadBtnGreen.Text = "Green"
        RadBtnGreen.UseVisualStyleBackColor = True
        ' 
        ' BtnLoadPicture
        ' 
        BtnLoadPicture.Location = New Point(69, 410)
        BtnLoadPicture.Name = "BtnLoadPicture"
        BtnLoadPicture.Size = New Size(152, 39)
        BtnLoadPicture.TabIndex = 12
        BtnLoadPicture.Text = "Load Picture"
        BtnLoadPicture.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(566, 410)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(82, 39)
        BtnExit.TabIndex = 13
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' ObjectDemonstrations
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 500)
        Controls.Add(BtnExit)
        Controls.Add(BtnLoadPicture)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "ObjectDemonstrations"
        Text = "Object Demonstrations"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadBtnGaramond As RadioButton
    Friend WithEvents RadBtnMagneto As RadioButton
    Friend WithEvents RadBtnTahoma As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBoxItalic As CheckBox
    Friend WithEvents CheckBoxBold As CheckBox
    Friend WithEvents CheckBoxBoth As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadBtnRed As RadioButton
    Friend WithEvents RadBtnBlue As RadioButton
    Friend WithEvents RadBtnGreen As RadioButton
    Friend WithEvents BtnLoadPicture As Button
    Friend WithEvents BtnExit As Button
End Class
