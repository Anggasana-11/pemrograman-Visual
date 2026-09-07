<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnInput = New Button()
        txtNilai = New TextBox()
        PicImage = New PictureBox()
        CType(PicImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(358, 235)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(75, 23)
        btnInput.TabIndex = 0
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' txtNilai
        ' 
        txtNilai.Location = New Point(330, 206)
        txtNilai.Name = "txtNilai"
        txtNilai.Size = New Size(131, 23)
        txtNilai.TabIndex = 1
        ' 
        ' PicImage
        ' 
        PicImage.Location = New Point(347, 70)
        PicImage.Name = "PicImage"
        PicImage.Size = New Size(100, 100)
        PicImage.SizeMode = PictureBoxSizeMode.Zoom
        PicImage.TabIndex = 2
        PicImage.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PicImage)
        Controls.Add(txtNilai)
        Controls.Add(btnInput)
        Name = "Form1"
        Text = "Form1"
        CType(PicImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents txtNilai As TextBox
    Friend WithEvents PicImage As PictureBox

End Class
