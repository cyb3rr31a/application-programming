<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        BtnLoadObjectDemo = New Button()
        BtnExit = New Button()
        LoadObjectDemo = New ToolTip(components)
        ExitForm = New ToolTip(components)
        SuspendLayout()
        ' 
        ' BtnLoadObjectDemo
        ' 
        BtnLoadObjectDemo.Location = New Point(101, 165)
        BtnLoadObjectDemo.Name = "BtnLoadObjectDemo"
        BtnLoadObjectDemo.Size = New Size(214, 62)
        BtnLoadObjectDemo.TabIndex = 0
        BtnLoadObjectDemo.Text = "Load Object Demo"
        BtnLoadObjectDemo.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(491, 165)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(112, 62)
        BtnExit.TabIndex = 1
        BtnExit.Text = "EXIT"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' WelcomeForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnExit)
        Controls.Add(BtnLoadObjectDemo)
        Name = "WelcomeForm"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnLoadObjectDemo As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LoadObjectDemo As ToolTip
    Friend WithEvents ExitForm As ToolTip

End Class
