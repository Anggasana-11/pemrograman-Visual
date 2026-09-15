<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArray
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
        btnTampilkan = New Button()
        txtpanjang = New TextBox()
        txtlebar = New TextBox()
        Panjang = New Label()
        Label1 = New Label()
        lstnilai = New ListBox()
        SuspendLayout()
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(168, 230)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 0
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' txtpanjang
        ' 
        txtpanjang.Location = New Point(150, 81)
        txtpanjang.Name = "txtpanjang"
        txtpanjang.Size = New Size(150, 31)
        txtpanjang.TabIndex = 1
        ' 
        ' txtlebar
        ' 
        txtlebar.Location = New Point(150, 173)
        txtlebar.Name = "txtlebar"
        txtlebar.Size = New Size(150, 31)
        txtlebar.TabIndex = 2
        ' 
        ' Panjang
        ' 
        Panjang.AutoSize = True
        Panjang.Location = New Point(152, 42)
        Panjang.Name = "Panjang"
        Panjang.Size = New Size(76, 25)
        Panjang.TabIndex = 3
        Panjang.Text = "panjang"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(150, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 25)
        Label1.TabIndex = 4
        Label1.Text = "Lebar"
        ' 
        ' lstnilai
        ' 
        lstnilai.FormattingEnabled = True
        lstnilai.Location = New Point(152, 300)
        lstnilai.Name = "lstnilai"
        lstnilai.Size = New Size(142, 79)
        lstnilai.TabIndex = 5
        ' 
        ' FrmArray
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(434, 450)
        Controls.Add(lstnilai)
        Controls.Add(Label1)
        Controls.Add(Panjang)
        Controls.Add(txtlebar)
        Controls.Add(txtpanjang)
        Controls.Add(btnTampilkan)
        Name = "FrmArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampilkan As Button
    Friend WithEvents txtpanjang As TextBox
    Friend WithEvents txtlebar As TextBox
    Friend WithEvents Panjang As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstnilai As ListBox

End Class
