Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilai As Integer

        If Not Integer.TryParse(txtNilai.Text, nilai) Then
            MessageBox.Show("Masukkan dalam bentuk angka")
            Return
        End If

        If nilai < 0 OrElse nilai > 100 Then
            MessageBox.Show("Masukkan nilai 0 - 100")
            txtNilai.Focus()
            Return
        End If

        If nilai <= 50 Then
            PicImage.Image = Image.FromFile("Aset\LogoUSU.jpeg")
        ElseIf nilai = 75 Then
            PicImage.Image = Image.FromFile("Aset\logo.jpg")
        Else
            PicImage.Image = Image.FromFile("Aset\Lambang_Kabupaten_Deli_Serdang.jpg")
        End If

    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNilai_TextChanged(sender As Object, e As EventArgs) Handles txtNilai.TextChanged

    End Sub

    Private Sub PicImage_Click(sender As Object, e As EventArgs) Handles PicImage.Click

    End Sub
End Class
