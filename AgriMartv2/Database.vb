Imports MySql.Data.MySqlClient

Module Database
    ' Menyimpan string koneksi sesuai user MySQL yang sedang login
    Public ConnString As String = ""

    ' Menyimpan sesi pengguna yang berhasil login (diambil dari tabel PENGGUNA)
    Public SesiIdPengguna As Integer = 0
    Public SesiNamaPengguna As String = ""
    Public SesiPeran As String = ""

    ' Fungsi untuk memanggil koneksi baru di setiap transaksi form
    Public Function AmbilKoneksi() As MySqlConnection
        Return New MySqlConnection(ConnString)
    End Function

    ' Fungsi Login: Menguji koneksi MySQL sekaligus mengecek tabel PENGGUNA
    Public Function LoginDatabase(username As String, password As String, ByRef pesanError As String) As Boolean
        ' Susun Connection String menggunakan username & password dari form login
        ' (Sesuaikan Port=3306 jika port MySQL/XAMPP/Laragon kamu berbeda)
        Dim tempConnStr As String = $"Server=localhost;Port=3306;Database=db_toko_pertanian;Uid={username};Pwd={password};"

        Using conn As New MySqlConnection(tempConnStr)
            Try
                ' 1. Coba buka koneksi dengan akun MySQL tersebut
                conn.Open()

                ' 2. Jika tembus, ambil id_pengguna, peran, dan status_aktif dari tabel PENGGUNA
                ' (Catatan: Kolom kata_sandi tidak di-SELECT karena dibatasi oleh GRANT MySQL)
                Dim query As String = "SELECT id_pengguna, nama_pengguna, peran, status_aktif " &
                                      "FROM PENGGUNA WHERE nama_pengguna = @nama LIMIT 1"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", username)

                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        If rd.Read() Then
                            Dim aktif As Boolean = Convert.ToBoolean(rd("status_aktif"))
                            If Not aktif Then
                                pesanError = "Akun pengguna ini sedang dinonaktifkan!"
                                Return False
                            End If

                            ' Simpan informasi ke variabel global
                            ConnString = tempConnStr
                            SesiIdPengguna = Convert.ToInt32(rd("id_pengguna"))
                            SesiNamaPengguna = rd("nama_pengguna").ToString()
                            SesiPeran = rd("peran").ToString()
                            Return True
                        Else
                            pesanError = "User MySQL valid, tetapi tidak terdaftar di tabel PENGGUNA."
                            Return False
                        End If
                    End Using
                End Using

            Catch ex As MySqlException
                ' Error 1045 = Username / Password MySQL salah
                If ex.Number = 1045 Then
                    pesanError = "Username atau Password salah!"
                Else
                    pesanError = "Gagal terhubung ke MySQL: " & ex.Message
                End If
                Return False
            Catch ex As Exception
                pesanError = "Terjadi kesalahan: " & ex.Message
                Return False
            End Try
        End Using
    End Function
End Module