Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub rbAdmin_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtNamaPengguna_TextChanged(sender As Object, e As EventArgs) Handles txtNamaPengguna.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click

        Dim user As String = txtNamaPengguna.Text.Trim()
        Dim pass As String = txtKataSandi.Text.Trim()

        If user = "" OrElse pass = "" Then
            MessageBox.Show("Nama pengguna dan kata sandi harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim pesanError As String = ""

        ' Memanggil fungsi LoginDatabase dari ModuleKoneksi
        If LoginDatabase(user, pass, pesanError) Then
            txtKataSandi.Clear()
            Me.Hide()

            ' Arahkan ke form sesuai peran di database
            Select Case SesiPeran
                Case "Admin"
                    Dashboard.Show()
                Case "Kasir"
                    FrmUtamaKasir.Show()
                Case "Owner"
                    FrmUtamaOwner.Show()
                Case Else
                    MessageBox.Show("Peran pengguna tidak dikenali!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Show()
            End Select
        Else
            MessageBox.Show(pesanError, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class