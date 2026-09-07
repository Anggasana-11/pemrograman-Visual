# Pertemuan 3: Operator dan Struktur Pengendalian

Catatan praktikum Visual Basic Windows Forms tentang operator, variabel, tipe data, dan struktur pengendalian `If...ElseIf...Else`.

## 1. Operator

Operator adalah simbol yang digunakan untuk melakukan operasi terhadap nilai atau variabel.

### Operator aritmatika

| Operator | Fungsi | Contoh | Hasil |
| --- | --- | --- | --- |
| `+` | Penjumlahan | `10 + 5` | `15` |
| `-` | Pengurangan | `10 - 5` | `5` |
| `*` | Perkalian | `10 * 5` | `50` |
| `/` | Pembagian desimal | `10 / 4` | `2.5` |
| `\` | Pembagian bilangan bulat | `10 \ 4` | `2` |
| `Mod` | Sisa pembagian | `10 Mod 4` | `2` |
| `^` | Perpangkatan | `2 ^ 3` | `8` |

### Operator perbandingan

Operator perbandingan menghasilkan nilai Boolean, yaitu `True` atau `False`.

| Operator | Arti |
| --- | --- |
| `=` | Sama dengan |
| `<>` | Tidak sama dengan |
| `<` | Lebih kecil dari |
| `>` | Lebih besar dari |
| `<=` | Lebih kecil atau sama dengan |
| `>=` | Lebih besar atau sama dengan |

Contoh: `nilai <= 50` bernilai `True` jika nilai yang diperiksa kurang dari atau sama dengan 50.

### Operator logika

| Operator | Fungsi |
| --- | --- |
| `AndAlso` | `True` jika kedua kondisi benar. Pemeriksaan berhenti lebih awal jika kondisi pertama salah. |
| `OrElse` | `True` jika salah satu kondisi benar. Pemeriksaan berhenti lebih awal jika kondisi pertama benar. |
| `Not` | Membalik nilai logika, `True` menjadi `False` dan sebaliknya. |

Contoh: `nilai < 0 OrElse nilai > 100` memeriksa apakah nilai berada di luar rentang 0 sampai 100.

## 2. Variabel

Variabel adalah tempat untuk menyimpan data sementara selama program berjalan. Variabel memiliki nama dan tipe data.

```vb
Dim nilai As Integer
nilai = 80
```

`Dim` digunakan untuk membuat variabel, `nilai` adalah nama variabel, sedangkan `Integer` adalah tipe datanya. Nama variabel sebaiknya jelas dan menggambarkan isi data.

## 3. Tipe Data

| Tipe data | Kegunaan | Contoh |
| --- | --- | --- |
| `Integer` | Bilangan bulat | `80`, `-2` |
| `Double` | Bilangan desimal | `2.5` |
| `Decimal` | Bilangan desimal dengan ketelitian tinggi, misalnya nilai uang | `15000.75D` |
| `String` | Teks | `"Halo"` |
| `Char` | Satu karakter | `"A"c` |
| `Boolean` | Nilai benar atau salah | `True`, `False` |
| `Date` | Tanggal dan waktu | `#09/02/2026#` |

Pemilihan tipe data yang tepat membantu program menggunakan data secara benar. Pada praktikum ini, input nilai diubah menjadi `Integer` karena nilai yang diterima adalah bilangan bulat 0 sampai 100.

## 4. Praktik Membuat Form

Buat sebuah Windows Form sederhana dengan susunan kontrol berikut:

```text
[ PictureBox ]
[   TextBox  ]
[   Input    ]
```

### Langkah-langkah

1. Buka proyek `Pertemuan3-Operator Struktur Pengendalian` di Visual Studio.
2. Dari Toolbox, tarik `PictureBox` ke Form. Atur `Name` menjadi `PicImage` dan `SizeMode` menjadi `Zoom`.
3. Tarik `TextBox` di bawah PictureBox. Pada Properties, ubah `Name` menjadi `txtNilai`.
4. Tarik `Button` di bawah TextBox. Ubah `Name` menjadi `btnInput` dan `Text` menjadi `Input`.
5. Buat folder `Aset` di dalam folder proyek.
6. Masukkan gambar berikut ke folder `Aset`:
   - `LogoUSU.jpeg`
   - `logo.jpg`
   - `Lambang_Kabupaten_Deli_Serdang.jpg`
7. Pastikan setiap gambar memiliki properti **Copy to Output Directory** bernilai **Copy if newer** atau **PreserveNewest**. Dengan begitu, gambar tersedia di folder output ketika program dijalankan.
8. Klik dua kali tombol `Input` untuk membuat event `btnInput_Click`, lalu masukkan kode pada bagian berikut.

## 5. Kode Program

```vb
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
```

## 6. Penjelasan Kode

### Event tombol Input

`Private Sub btnInput_Click(...) Handles btnInput.Click` adalah prosedur yang berjalan ketika tombol `btnInput` diklik. `sender` adalah objek yang memicu event, sedangkan `e` berisi informasi event. Kata `Handles` menghubungkan prosedur dengan event tombol.

`Dim nilai As Integer` membuat variabel `nilai` untuk menyimpan input sebagai bilangan bulat.

`Integer.TryParse(txtNilai.Text, nilai)` mencoba mengubah teks dari `txtNilai` menjadi `Integer`. Hasil konversi disimpan ke variabel `nilai`. Fungsi ini lebih aman daripada konversi langsung karena tidak menyebabkan error ketika teks tidak dapat diubah menjadi angka.

`Not` membalik hasil pemeriksaan. Jadi, blok pertama dijalankan jika input bukan angka. `MessageBox.Show` menampilkan pesan, sedangkan `Return` menghentikan prosedur agar kode berikutnya tidak dijalankan.

### Validasi rentang nilai

```vb
If nilai < 0 OrElse nilai > 100 Then
```

Kondisi tersebut menolak nilai di bawah 0 atau di atas 100. `OrElse` digunakan karena cukup salah satu kondisi yang benar agar input ditolak. `txtNilai.Focus()` mengembalikan kursor ke TextBox sehingga pengguna dapat segera memperbaiki input.

### Menentukan gambar dengan If

```vb
If nilai <= 50 Then
	' LogoUSU.jpeg
ElseIf nilai = 75 Then
	' logo.jpg
Else
	' Lambang_Kabupaten_Deli_Serdang.jpg
End If
```

Program memeriksa kondisi dari atas ke bawah dan hanya menjalankan satu cabang:

| Nilai | Gambar yang ditampilkan |
| --- | --- |
| `0` sampai `50` | `Aset\LogoUSU.jpeg` |
| Tepat `75` | `Aset\logo.jpg` |
| `51` sampai `74` atau `76` sampai `100` | `Aset\Lambang_Kabupaten_Deli_Serdang.jpg` |

`Image.FromFile` membaca gambar dari folder `Aset`, kemudian hasilnya diberikan ke properti `Image` milik `PicImage`.

### Membatasi input keyboard

Pada event `txtNilai_KeyPress`, `Char.IsControl` mengizinkan tombol kontrol seperti Backspace, sedangkan `Char.IsDigit` mengizinkan angka. Jika karakter bukan kontrol dan bukan angka, `e.Handled = True` membatalkan karakter tersebut sehingga huruf dan simbol tidak dapat diketik.

### Event yang masih kosong

`txtNilai_TextChanged` berjalan setiap kali isi TextBox berubah. `PicImage_Click` berjalan ketika PictureBox diklik. Keduanya boleh dibiarkan kosong jika belum ada tindakan yang diperlukan.

## 7. Alur Program

1. Pengguna mengetik nilai pada `txtNilai`.
2. Program mengabaikan karakter selain angka saat mengetik.
3. Saat `Input` diklik, teks dicoba dikonversi menjadi `Integer`.
4. Jika bukan angka, program menampilkan pesan kesalahan.
5. Jika di luar rentang 0 sampai 100, program menampilkan pesan dan mengembalikan fokus ke TextBox.
6. Jika valid, program memilih gambar sesuai kondisi `If...ElseIf...Else`.
7. Gambar yang dipilih ditampilkan pada `PicImage`.

## 8. Catatan Penting

- Nama kontrol harus sama persis dengan kode: `PicImage`, `txtNilai`, dan `btnInput`.
- Nama file gambar juga harus sama persis, termasuk huruf besar-kecil dan ekstensi.
- Jalur `Aset\...` bersifat relatif terhadap folder program yang sedang dijalankan.
- `TryParse` dan validasi rentang mencegah input yang tidak sesuai diproses oleh program.
