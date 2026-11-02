<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBarangMasuk
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarangMasuk))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblNamaPengguna = New System.Windows.Forms.Label()
        Me.lblNamaAplikasi = New System.Windows.Forms.Label()
        Me.splitUtama = New System.Windows.Forms.SplitContainer()
        Me.pnlInputUtama = New System.Windows.Forms.Panel()
        Me.dgvDetailMasuk = New System.Windows.Forms.DataGridView()
        Me.DetailKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailHargaBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.lblNominalTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.pnlTombol = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.grpTambahBarang = New System.Windows.Forms.GroupBox()
        Me.btnTambahBarang = New System.Windows.Forms.Button()
        Me.txtHargaBeli = New System.Windows.Forms.TextBox()
        Me.lblHargaBeli = New System.Windows.Forms.Label()
        Me.nudJumlah = New System.Windows.Forms.NumericUpDown()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.cmbBarang = New System.Windows.Forms.ComboBox()
        Me.lblPilihBarang = New System.Windows.Forms.Label()
        Me.grpInformasi = New System.Windows.Forms.GroupBox()
        Me.dtpTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.lblTanggalMasuk = New System.Windows.Forms.Label()
        Me.txtNomorMasuk = New System.Windows.Forms.TextBox()
        Me.lblNomorMasuk = New System.Windows.Forms.Label()
        Me.pnlHeaderInput = New System.Windows.Forms.Panel()
        Me.lblHeaderInput = New System.Windows.Forms.Label()
        Me.pnlRiwayat = New System.Windows.Forms.Panel()
        Me.dgvRiwayat = New System.Windows.Forms.DataGridView()
        Me.RiwayatNomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RiwayatTanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RiwayatPetugas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCariRiwayat = New System.Windows.Forms.TextBox()
        Me.lblCariRiwayat = New System.Windows.Forms.Label()
        Me.pnlHeaderRiwayat = New System.Windows.Forms.Panel()
        Me.lblHeaderRiwayat = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.splitUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitUtama.Panel1.SuspendLayout()
        Me.splitUtama.Panel2.SuspendLayout()
        Me.splitUtama.SuspendLayout()
        Me.pnlInputUtama.SuspendLayout()
        CType(Me.dgvDetailMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotal.SuspendLayout()
        Me.pnlTombol.SuspendLayout()
        Me.grpTambahBarang.SuspendLayout()
        CType(Me.nudJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformasi.SuspendLayout()
        Me.pnlHeaderInput.SuspendLayout()
        Me.pnlRiwayat.SuspendLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeaderRiwayat.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.lblNamaPengguna)
        Me.pnlHeader.Controls.Add(Me.lblNamaAplikasi)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1371, 67)
        Me.pnlHeader.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnLogout.Location = New System.Drawing.Point(1234, 16)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(113, 39)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblNamaPengguna
        '
        Me.lblNamaPengguna.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNamaPengguna.AutoSize = True
        Me.lblNamaPengguna.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaPengguna.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNamaPengguna.ForeColor = System.Drawing.Color.White
        Me.lblNamaPengguna.Location = New System.Drawing.Point(1074, 27)
        Me.lblNamaPengguna.Name = "lblNamaPengguna"
        Me.lblNamaPengguna.Size = New System.Drawing.Size(144, 23)
        Me.lblNamaPengguna.TabIndex = 1
        Me.lblNamaPengguna.Text = "Pengguna: Ilham"
        '
        'lblNamaAplikasi
        '
        Me.lblNamaAplikasi.AutoSize = True
        Me.lblNamaAplikasi.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaAplikasi.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblNamaAplikasi.ForeColor = System.Drawing.Color.White
        Me.lblNamaAplikasi.Location = New System.Drawing.Point(14, 13)
        Me.lblNamaAplikasi.Name = "lblNamaAplikasi"
        Me.lblNamaAplikasi.Size = New System.Drawing.Size(247, 37)
        Me.lblNamaAplikasi.TabIndex = 0
        Me.lblNamaAplikasi.Text = "TOKO PERTANIAN"
        '
        'splitUtama
        '
        Me.splitUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitUtama.Location = New System.Drawing.Point(0, 67)
        Me.splitUtama.Name = "splitUtama"
        '
        'splitUtama.Panel1
        '
        Me.splitUtama.Panel1.Controls.Add(Me.pnlInputUtama)
        '
        'splitUtama.Panel2
        '
        Me.splitUtama.Panel2.Controls.Add(Me.pnlRiwayat)
        Me.splitUtama.Size = New System.Drawing.Size(1371, 681)
        Me.splitUtama.SplitterDistance = 856
        Me.splitUtama.SplitterWidth = 6
        Me.splitUtama.TabIndex = 1
        '
        'pnlInputUtama
        '
        Me.pnlInputUtama.Controls.Add(Me.dgvDetailMasuk)
        Me.pnlInputUtama.Controls.Add(Me.pnlTotal)
        Me.pnlInputUtama.Controls.Add(Me.pnlTombol)
        Me.pnlInputUtama.Controls.Add(Me.grpTambahBarang)
        Me.pnlInputUtama.Controls.Add(Me.grpInformasi)
        Me.pnlInputUtama.Controls.Add(Me.pnlHeaderInput)
        Me.pnlInputUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInputUtama.Location = New System.Drawing.Point(0, 0)
        Me.pnlInputUtama.Name = "pnlInputUtama"
        Me.pnlInputUtama.Size = New System.Drawing.Size(856, 681)
        Me.pnlInputUtama.TabIndex = 0
        '
        'dgvDetailMasuk
        '
        Me.dgvDetailMasuk.AllowUserToAddRows = False
        Me.dgvDetailMasuk.AllowUserToDeleteRows = False
        Me.dgvDetailMasuk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetailMasuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetailMasuk.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetailMasuk.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetailMasuk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetailMasuk.ColumnHeadersHeight = 35
        Me.dgvDetailMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDetailMasuk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetailKodeBarang, Me.DetailNamaBarang, Me.DetailJumlah, Me.DetailHargaBeli, Me.DetailSubtotal, Me.DetailHapus})
        Me.dgvDetailMasuk.EnableHeadersVisualStyles = False
        Me.dgvDetailMasuk.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvDetailMasuk.Location = New System.Drawing.Point(17, 352)
        Me.dgvDetailMasuk.MultiSelect = False
        Me.dgvDetailMasuk.Name = "dgvDetailMasuk"
        Me.dgvDetailMasuk.ReadOnly = True
        Me.dgvDetailMasuk.RowHeadersVisible = False
        Me.dgvDetailMasuk.RowHeadersWidth = 51
        Me.dgvDetailMasuk.RowTemplate.Height = 33
        Me.dgvDetailMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetailMasuk.Size = New System.Drawing.Size(822, 172)
        Me.dgvDetailMasuk.TabIndex = 3
        '
        'DetailKodeBarang
        '
        Me.DetailKodeBarang.HeaderText = "Kode Barang"
        Me.DetailKodeBarang.MinimumWidth = 6
        Me.DetailKodeBarang.Name = "DetailKodeBarang"
        Me.DetailKodeBarang.ReadOnly = True
        '
        'DetailNamaBarang
        '
        Me.DetailNamaBarang.HeaderText = "Nama Barang"
        Me.DetailNamaBarang.MinimumWidth = 6
        Me.DetailNamaBarang.Name = "DetailNamaBarang"
        Me.DetailNamaBarang.ReadOnly = True
        '
        'DetailJumlah
        '
        Me.DetailJumlah.HeaderText = "Jumlah"
        Me.DetailJumlah.MinimumWidth = 6
        Me.DetailJumlah.Name = "DetailJumlah"
        Me.DetailJumlah.ReadOnly = True
        '
        'DetailHargaBeli
        '
        Me.DetailHargaBeli.HeaderText = "Harga Beli"
        Me.DetailHargaBeli.MinimumWidth = 6
        Me.DetailHargaBeli.Name = "DetailHargaBeli"
        Me.DetailHargaBeli.ReadOnly = True
        '
        'DetailSubtotal
        '
        Me.DetailSubtotal.HeaderText = "Subtotal"
        Me.DetailSubtotal.MinimumWidth = 6
        Me.DetailSubtotal.Name = "DetailSubtotal"
        Me.DetailSubtotal.ReadOnly = True
        '
        'DetailHapus
        '
        Me.DetailHapus.HeaderText = "Aksi"
        Me.DetailHapus.MinimumWidth = 6
        Me.DetailHapus.Name = "DetailHapus"
        Me.DetailHapus.ReadOnly = True
        Me.DetailHapus.Text = "Hapus"
        Me.DetailHapus.UseColumnTextForButtonValue = True
        '
        'pnlTotal
        '
        Me.pnlTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTotal.BackColor = System.Drawing.Color.White
        Me.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotal.Controls.Add(Me.lblNominalTotal)
        Me.pnlTotal.Controls.Add(Me.lblTotal)
        Me.pnlTotal.Location = New System.Drawing.Point(17, 532)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(822, 51)
        Me.pnlTotal.TabIndex = 4
        '
        'lblNominalTotal
        '
        Me.lblNominalTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNominalTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNominalTotal.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblNominalTotal.Location = New System.Drawing.Point(536, 11)
        Me.lblNominalTotal.Name = "lblNominalTotal"
        Me.lblNominalTotal.Size = New System.Drawing.Size(269, 27)
        Me.lblNominalTotal.TabIndex = 1
        Me.lblNominalTotal.Text = "Rp0"
        Me.lblNominalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(14, 14)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(147, 23)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total Penerimaan"
        '
        'pnlTombol
        '
        Me.pnlTombol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTombol.Controls.Add(Me.btnBatal)
        Me.pnlTombol.Controls.Add(Me.btnSimpan)
        Me.pnlTombol.Location = New System.Drawing.Point(17, 593)
        Me.pnlTombol.Name = "pnlTombol"
        Me.pnlTombol.Size = New System.Drawing.Size(822, 69)
        Me.pnlTombol.TabIndex = 5
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatal.BackColor = System.Drawing.Color.Gray
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(462, 11)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(120, 41)
        Me.btnBatal.TabIndex = 1
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(599, 11)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(189, 41)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Simpan Penerimaan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'grpTambahBarang
        '
        Me.grpTambahBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTambahBarang.Controls.Add(Me.btnTambahBarang)
        Me.grpTambahBarang.Controls.Add(Me.txtHargaBeli)
        Me.grpTambahBarang.Controls.Add(Me.lblHargaBeli)
        Me.grpTambahBarang.Controls.Add(Me.nudJumlah)
        Me.grpTambahBarang.Controls.Add(Me.lblJumlah)
        Me.grpTambahBarang.Controls.Add(Me.cmbBarang)
        Me.grpTambahBarang.Controls.Add(Me.lblPilihBarang)
        Me.grpTambahBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpTambahBarang.Location = New System.Drawing.Point(17, 187)
        Me.grpTambahBarang.Name = "grpTambahBarang"
        Me.grpTambahBarang.Size = New System.Drawing.Size(822, 155)
        Me.grpTambahBarang.TabIndex = 2
        Me.grpTambahBarang.TabStop = False
        Me.grpTambahBarang.Text = "Tambah Barang"
        '
        'btnTambahBarang
        '
        Me.btnTambahBarang.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambahBarang.BackColor = System.Drawing.Color.SeaGreen
        Me.btnTambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTambahBarang.ForeColor = System.Drawing.Color.White
        Me.btnTambahBarang.Location = New System.Drawing.Point(599, 108)
        Me.btnTambahBarang.Name = "btnTambahBarang"
        Me.btnTambahBarang.Size = New System.Drawing.Size(189, 32)
        Me.btnTambahBarang.TabIndex = 6
        Me.btnTambahBarang.Text = "+ Tambah Barang"
        Me.btnTambahBarang.UseVisualStyleBackColor = False
        '
        'txtHargaBeli
        '
        Me.txtHargaBeli.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtHargaBeli.Location = New System.Drawing.Point(211, 111)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Size = New System.Drawing.Size(228, 30)
        Me.txtHargaBeli.TabIndex = 5
        '
        'lblHargaBeli
        '
        Me.lblHargaBeli.AutoSize = True
        Me.lblHargaBeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHargaBeli.Location = New System.Drawing.Point(211, 87)
        Me.lblHargaBeli.Name = "lblHargaBeli"
        Me.lblHargaBeli.Size = New System.Drawing.Size(79, 20)
        Me.lblHargaBeli.TabIndex = 4
        Me.lblHargaBeli.Text = "Harga Beli"
        '
        'nudJumlah
        '
        Me.nudJumlah.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.nudJumlah.Location = New System.Drawing.Point(17, 111)
        Me.nudJumlah.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudJumlah.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudJumlah.Name = "nudJumlah"
        Me.nudJumlah.Size = New System.Drawing.Size(171, 30)
        Me.nudJumlah.TabIndex = 3
        Me.nudJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblJumlah.Location = New System.Drawing.Point(17, 87)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(55, 20)
        Me.lblJumlah.TabIndex = 2
        Me.lblJumlah.Text = "Jumlah"
        '
        'cmbBarang
        '
        Me.cmbBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbBarang.FormattingEnabled = True
        Me.cmbBarang.Location = New System.Drawing.Point(17, 50)
        Me.cmbBarang.Name = "cmbBarang"
        Me.cmbBarang.Size = New System.Drawing.Size(770, 31)
        Me.cmbBarang.TabIndex = 1
        '
        'lblPilihBarang
        '
        Me.lblPilihBarang.AutoSize = True
        Me.lblPilihBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPilihBarang.Location = New System.Drawing.Point(17, 27)
        Me.lblPilihBarang.Name = "lblPilihBarang"
        Me.lblPilihBarang.Size = New System.Drawing.Size(88, 20)
        Me.lblPilihBarang.TabIndex = 0
        Me.lblPilihBarang.Text = "Pilih Barang"
        '
        'grpInformasi
        '
        Me.grpInformasi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformasi.Controls.Add(Me.dtpTanggalMasuk)
        Me.grpInformasi.Controls.Add(Me.lblTanggalMasuk)
        Me.grpInformasi.Controls.Add(Me.txtNomorMasuk)
        Me.grpInformasi.Controls.Add(Me.lblNomorMasuk)
        Me.grpInformasi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grpInformasi.Location = New System.Drawing.Point(17, 69)
        Me.grpInformasi.Name = "grpInformasi"
        Me.grpInformasi.Size = New System.Drawing.Size(822, 107)
        Me.grpInformasi.TabIndex = 1
        Me.grpInformasi.TabStop = False
        Me.grpInformasi.Text = "Informasi Penerimaan"
        '
        'dtpTanggalMasuk
        '
        Me.dtpTanggalMasuk.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpTanggalMasuk.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggalMasuk.Location = New System.Drawing.Point(400, 53)
        Me.dtpTanggalMasuk.Name = "dtpTanggalMasuk"
        Me.dtpTanggalMasuk.Size = New System.Drawing.Size(342, 30)
        Me.dtpTanggalMasuk.TabIndex = 3
        '
        'lblTanggalMasuk
        '
        Me.lblTanggalMasuk.AutoSize = True
        Me.lblTanggalMasuk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTanggalMasuk.Location = New System.Drawing.Point(400, 30)
        Me.lblTanggalMasuk.Name = "lblTanggalMasuk"
        Me.lblTanggalMasuk.Size = New System.Drawing.Size(142, 20)
        Me.lblTanggalMasuk.TabIndex = 2
        Me.lblTanggalMasuk.Text = "Tanggal Penerimaan"
        '
        'txtNomorMasuk
        '
        Me.txtNomorMasuk.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNomorMasuk.Location = New System.Drawing.Point(17, 53)
        Me.txtNomorMasuk.Name = "txtNomorMasuk"
        Me.txtNomorMasuk.ReadOnly = True
        Me.txtNomorMasuk.Size = New System.Drawing.Size(342, 30)
        Me.txtNomorMasuk.TabIndex = 1
        '
        'lblNomorMasuk
        '
        Me.lblNomorMasuk.AutoSize = True
        Me.lblNomorMasuk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNomorMasuk.Location = New System.Drawing.Point(17, 30)
        Me.lblNomorMasuk.Name = "lblNomorMasuk"
        Me.lblNomorMasuk.Size = New System.Drawing.Size(137, 20)
        Me.lblNomorMasuk.TabIndex = 0
        Me.lblNomorMasuk.Text = "Nomor Penerimaan"
        '
        'pnlHeaderInput
        '
        Me.pnlHeaderInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlHeaderInput.Controls.Add(Me.lblHeaderInput)
        Me.pnlHeaderInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderInput.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderInput.Name = "pnlHeaderInput"
        Me.pnlHeaderInput.Size = New System.Drawing.Size(856, 59)
        Me.pnlHeaderInput.TabIndex = 0
        '
        'lblHeaderInput
        '
        Me.lblHeaderInput.AutoSize = True
        Me.lblHeaderInput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderInput.ForeColor = System.Drawing.Color.White
        Me.lblHeaderInput.Location = New System.Drawing.Point(17, 18)
        Me.lblHeaderInput.Name = "lblHeaderInput"
        Me.lblHeaderInput.Size = New System.Drawing.Size(239, 28)
        Me.lblHeaderInput.TabIndex = 0
        Me.lblHeaderInput.Text = "INPUT BARANG MASUK"
        '
        'pnlRiwayat
        '
        Me.pnlRiwayat.Controls.Add(Me.dgvRiwayat)
        Me.pnlRiwayat.Controls.Add(Me.txtCariRiwayat)
        Me.pnlRiwayat.Controls.Add(Me.lblCariRiwayat)
        Me.pnlRiwayat.Controls.Add(Me.pnlHeaderRiwayat)
        Me.pnlRiwayat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRiwayat.Location = New System.Drawing.Point(0, 0)
        Me.pnlRiwayat.Name = "pnlRiwayat"
        Me.pnlRiwayat.Size = New System.Drawing.Size(509, 681)
        Me.pnlRiwayat.TabIndex = 0
        '
        'dgvRiwayat
        '
        Me.dgvRiwayat.AllowUserToAddRows = False
        Me.dgvRiwayat.AllowUserToDeleteRows = False
        Me.dgvRiwayat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRiwayat.BackgroundColor = System.Drawing.Color.White
        Me.dgvRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRiwayat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRiwayat.ColumnHeadersHeight = 35
        Me.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRiwayat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RiwayatNomor, Me.RiwayatTanggal, Me.RiwayatPetugas})
        Me.dgvRiwayat.EnableHeadersVisualStyles = False
        Me.dgvRiwayat.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvRiwayat.Location = New System.Drawing.Point(17, 144)
        Me.dgvRiwayat.MultiSelect = False
        Me.dgvRiwayat.Name = "dgvRiwayat"
        Me.dgvRiwayat.ReadOnly = True
        Me.dgvRiwayat.RowHeadersVisible = False
        Me.dgvRiwayat.RowHeadersWidth = 51
        Me.dgvRiwayat.RowTemplate.Height = 33
        Me.dgvRiwayat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRiwayat.Size = New System.Drawing.Size(474, 518)
        Me.dgvRiwayat.TabIndex = 3
        '
        'RiwayatNomor
        '
        Me.RiwayatNomor.HeaderText = "No. Penerimaan"
        Me.RiwayatNomor.MinimumWidth = 6
        Me.RiwayatNomor.Name = "RiwayatNomor"
        Me.RiwayatNomor.ReadOnly = True
        '
        'RiwayatTanggal
        '
        Me.RiwayatTanggal.HeaderText = "Tanggal"
        Me.RiwayatTanggal.MinimumWidth = 6
        Me.RiwayatTanggal.Name = "RiwayatTanggal"
        Me.RiwayatTanggal.ReadOnly = True
        '
        'RiwayatPetugas
        '
        Me.RiwayatPetugas.HeaderText = "Petugas"
        Me.RiwayatPetugas.MinimumWidth = 6
        Me.RiwayatPetugas.Name = "RiwayatPetugas"
        Me.RiwayatPetugas.ReadOnly = True
        '
        'txtCariRiwayat
        '
        Me.txtCariRiwayat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCariRiwayat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCariRiwayat.Location = New System.Drawing.Point(17, 100)
        Me.txtCariRiwayat.Name = "txtCariRiwayat"
        Me.txtCariRiwayat.Size = New System.Drawing.Size(474, 30)
        Me.txtCariRiwayat.TabIndex = 2
        '
        'lblCariRiwayat
        '
        Me.lblCariRiwayat.AutoSize = True
        Me.lblCariRiwayat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCariRiwayat.Location = New System.Drawing.Point(17, 77)
        Me.lblCariRiwayat.Name = "lblCariRiwayat"
        Me.lblCariRiwayat.Size = New System.Drawing.Size(123, 20)
        Me.lblCariRiwayat.TabIndex = 1
        Me.lblCariRiwayat.Text = "Cari Penerimaan"
        '
        'pnlHeaderRiwayat
        '
        Me.pnlHeaderRiwayat.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlHeaderRiwayat.Controls.Add(Me.lblHeaderRiwayat)
        Me.pnlHeaderRiwayat.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderRiwayat.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderRiwayat.Name = "pnlHeaderRiwayat"
        Me.pnlHeaderRiwayat.Size = New System.Drawing.Size(509, 59)
        Me.pnlHeaderRiwayat.TabIndex = 0
        '
        'lblHeaderRiwayat
        '
        Me.lblHeaderRiwayat.AutoSize = True
        Me.lblHeaderRiwayat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderRiwayat.ForeColor = System.Drawing.Color.White
        Me.lblHeaderRiwayat.Location = New System.Drawing.Point(17, 18)
        Me.lblHeaderRiwayat.Name = "lblHeaderRiwayat"
        Me.lblHeaderRiwayat.Size = New System.Drawing.Size(264, 28)
        Me.lblHeaderRiwayat.TabIndex = 0
        Me.lblHeaderRiwayat.Text = "RIWAYAT BARANG MASUK"
        '
        'FrmBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 748)
        Me.Controls.Add(Me.splitUtama)
        Me.Controls.Add(Me.pnlHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1140, 690)
        Me.Name = "FrmBarangMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toko Pertanian - Barang Masuk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.splitUtama.Panel1.ResumeLayout(False)
        Me.splitUtama.Panel2.ResumeLayout(False)
        CType(Me.splitUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitUtama.ResumeLayout(False)
        Me.pnlInputUtama.ResumeLayout(False)
        CType(Me.dgvDetailMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlTotal.PerformLayout()
        Me.pnlTombol.ResumeLayout(False)
        Me.grpTambahBarang.ResumeLayout(False)
        Me.grpTambahBarang.PerformLayout()
        CType(Me.nudJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformasi.ResumeLayout(False)
        Me.grpInformasi.PerformLayout()
        Me.pnlHeaderInput.ResumeLayout(False)
        Me.pnlHeaderInput.PerformLayout()
        Me.pnlRiwayat.ResumeLayout(False)
        Me.pnlRiwayat.PerformLayout()
        CType(Me.dgvRiwayat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeaderRiwayat.ResumeLayout(False)
        Me.pnlHeaderRiwayat.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblNamaPengguna As Label
    Friend WithEvents lblNamaAplikasi As Label

    Friend WithEvents splitUtama As SplitContainer

    Friend WithEvents pnlInputUtama As Panel
    Friend WithEvents pnlHeaderInput As Panel
    Friend WithEvents lblHeaderInput As Label

    Friend WithEvents grpInformasi As GroupBox
    Friend WithEvents lblNomorMasuk As Label
    Friend WithEvents txtNomorMasuk As TextBox
    Friend WithEvents lblTanggalMasuk As Label
    Friend WithEvents dtpTanggalMasuk As DateTimePicker

    Friend WithEvents grpTambahBarang As GroupBox
    Friend WithEvents lblPilihBarang As Label
    Friend WithEvents cmbBarang As ComboBox
    Friend WithEvents lblJumlah As Label
    Friend WithEvents nudJumlah As NumericUpDown
    Friend WithEvents lblHargaBeli As Label
    Friend WithEvents txtHargaBeli As TextBox
    Friend WithEvents btnTambahBarang As Button

    Friend WithEvents dgvDetailMasuk As DataGridView
    Friend WithEvents DetailKodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents DetailNamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents DetailJumlah As DataGridViewTextBoxColumn
    Friend WithEvents DetailHargaBeli As DataGridViewTextBoxColumn
    Friend WithEvents DetailSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents DetailHapus As DataGridViewButtonColumn

    Friend WithEvents pnlTotal As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblNominalTotal As Label

    Friend WithEvents pnlTombol As Panel
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button

    Friend WithEvents pnlRiwayat As Panel
    Friend WithEvents pnlHeaderRiwayat As Panel
    Friend WithEvents lblHeaderRiwayat As Label
    Friend WithEvents lblCariRiwayat As Label
    Friend WithEvents txtCariRiwayat As TextBox

    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents RiwayatNomor As DataGridViewTextBoxColumn
    Friend WithEvents RiwayatTanggal As DataGridViewTextBoxColumn
    Friend WithEvents RiwayatPetugas As DataGridViewTextBoxColumn

End Class