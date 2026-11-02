<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDataBarang
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDataBarang))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblNamaPengguna = New System.Windows.Forms.Label()
        Me.lblNamaAplikasi = New System.Windows.Forms.Label()
        Me.splitUtama = New System.Windows.Forms.SplitContainer()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaJual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFilterBarang = New System.Windows.Forms.Panel()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.txtCariBarang = New System.Windows.Forms.TextBox()
        Me.lblCariBarang = New System.Windows.Forms.Label()
        Me.pnlIsiForm = New System.Windows.Forms.Panel()
        Me.lblPetunjuk = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.lblHargaJual = New System.Windows.Forms.Label()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.lblSatuan = New System.Windows.Forms.Label()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.lblKategoriInput = New System.Windows.Forms.Label()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.lblNamaBarang = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.lblKodeBarang = New System.Windows.Forms.Label()
        Me.pnlTombol = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.pnlHeaderForm = New System.Windows.Forms.Panel()
        Me.lblHeaderForm = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.splitUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitUtama.Panel1.SuspendLayout()
        Me.splitUtama.Panel2.SuspendLayout()
        Me.splitUtama.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilterBarang.SuspendLayout()
        Me.pnlIsiForm.SuspendLayout()
        Me.pnlTombol.SuspendLayout()
        Me.pnlHeaderForm.SuspendLayout()
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
        Me.pnlHeader.Size = New System.Drawing.Size(1257, 67)
        Me.pnlHeader.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnLogout.Location = New System.Drawing.Point(1120, 16)
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
        Me.lblNamaPengguna.Location = New System.Drawing.Point(960, 27)
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
        Me.lblNamaAplikasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'splitUtama
        '
        Me.splitUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitUtama.Location = New System.Drawing.Point(0, 67)
        Me.splitUtama.Name = "splitUtama"
        '
        'splitUtama.Panel1
        '
        Me.splitUtama.Panel1.Controls.Add(Me.dgvBarang)
        Me.splitUtama.Panel1.Controls.Add(Me.pnlFilterBarang)
        '
        'splitUtama.Panel2
        '
        Me.splitUtama.Panel2.Controls.Add(Me.pnlIsiForm)
        Me.splitUtama.Panel2.Controls.Add(Me.pnlTombol)
        Me.splitUtama.Panel2.Controls.Add(Me.pnlHeaderForm)
        Me.splitUtama.Size = New System.Drawing.Size(1257, 626)
        Me.splitUtama.SplitterDistance = 697
        Me.splitUtama.SplitterWidth = 6
        Me.splitUtama.TabIndex = 1
        '
        'dgvBarang
        '
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.AllowUserToDeleteRows = False
        Me.dgvBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBarang.BackgroundColor = System.Drawing.Color.White
        Me.dgvBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBarang.ColumnHeadersHeight = 38
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarang, Me.NamaBarang, Me.Kategori, Me.Satuan, Me.HargaJual, Me.Stok, Me.StatusBarang})
        Me.dgvBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBarang.EnableHeadersVisualStyles = False
        Me.dgvBarang.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvBarang.Location = New System.Drawing.Point(0, 77)
        Me.dgvBarang.MultiSelect = False
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.RowHeadersVisible = False
        Me.dgvBarang.RowHeadersWidth = 51
        Me.dgvBarang.RowTemplate.Height = 33
        Me.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarang.Size = New System.Drawing.Size(697, 549)
        Me.dgvBarang.TabIndex = 0
        '
        'KodeBarang
        '
        Me.KodeBarang.DataPropertyName = "kode_barang"
        Me.KodeBarang.HeaderText = "Kode Barang"
        Me.KodeBarang.MinimumWidth = 6
        Me.KodeBarang.Name = "KodeBarang"
        Me.KodeBarang.ReadOnly = True
        '
        'NamaBarang
        '
        Me.NamaBarang.DataPropertyName = "nama_barang"
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.MinimumWidth = 6
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.ReadOnly = True
        '
        'Kategori
        '
        Me.Kategori.DataPropertyName = "kategori"
        Me.Kategori.HeaderText = "Kategori"
        Me.Kategori.MinimumWidth = 6
        Me.Kategori.Name = "Kategori"
        Me.Kategori.ReadOnly = True
        '
        'Satuan
        '
        Me.Satuan.DataPropertyName = "satuan"
        Me.Satuan.HeaderText = "Satuan"
        Me.Satuan.MinimumWidth = 6
        Me.Satuan.Name = "Satuan"
        Me.Satuan.ReadOnly = True
        '
        'HargaJual
        '
        Me.HargaJual.DataPropertyName = "harga_jual"
        Me.HargaJual.HeaderText = "Harga Jual"
        Me.HargaJual.MinimumWidth = 6
        Me.HargaJual.Name = "HargaJual"
        Me.HargaJual.ReadOnly = True
        '
        'Stok
        '
        Me.Stok.DataPropertyName = "stok"
        Me.Stok.HeaderText = "Stok"
        Me.Stok.MinimumWidth = 6
        Me.Stok.Name = "Stok"
        Me.Stok.ReadOnly = True
        '
        'StatusBarang
        '
        Me.StatusBarang.DataPropertyName = "status_aktif"
        Me.StatusBarang.HeaderText = "Status"
        Me.StatusBarang.MinimumWidth = 6
        Me.StatusBarang.Name = "StatusBarang"
        Me.StatusBarang.ReadOnly = True
        '
        'pnlFilterBarang
        '
        Me.pnlFilterBarang.Controls.Add(Me.cmbKategori)
        Me.pnlFilterBarang.Controls.Add(Me.lblKategori)
        Me.pnlFilterBarang.Controls.Add(Me.txtCariBarang)
        Me.pnlFilterBarang.Controls.Add(Me.lblCariBarang)
        Me.pnlFilterBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterBarang.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilterBarang.Name = "pnlFilterBarang"
        Me.pnlFilterBarang.Size = New System.Drawing.Size(697, 77)
        Me.pnlFilterBarang.TabIndex = 1
        '
        'cmbKategori
        '
        Me.cmbKategori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKategori.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(446, 39)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(234, 31)
        Me.cmbKategori.TabIndex = 3
        '
        'lblKategori
        '
        Me.lblKategori.AutoSize = True
        Me.lblKategori.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKategori.Location = New System.Drawing.Point(17, 44)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(66, 20)
        Me.lblKategori.TabIndex = 2
        Me.lblKategori.Text = "Kategori"
        '
        'txtCariBarang
        '
        Me.txtCariBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCariBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCariBarang.Location = New System.Drawing.Point(114, 5)
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Size = New System.Drawing.Size(565, 30)
        Me.txtCariBarang.TabIndex = 1
        '
        'lblCariBarang
        '
        Me.lblCariBarang.AutoSize = True
        Me.lblCariBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCariBarang.Location = New System.Drawing.Point(17, 11)
        Me.lblCariBarang.Name = "lblCariBarang"
        Me.lblCariBarang.Size = New System.Drawing.Size(90, 20)
        Me.lblCariBarang.TabIndex = 0
        Me.lblCariBarang.Text = "Cari Barang"
        '
        'pnlIsiForm
        '
        Me.pnlIsiForm.AutoScroll = True
        Me.pnlIsiForm.Controls.Add(Me.lblPetunjuk)
        Me.pnlIsiForm.Controls.Add(Me.cmbStatus)
        Me.pnlIsiForm.Controls.Add(Me.lblStatus)
        Me.pnlIsiForm.Controls.Add(Me.txtHargaJual)
        Me.pnlIsiForm.Controls.Add(Me.lblHargaJual)
        Me.pnlIsiForm.Controls.Add(Me.txtSatuan)
        Me.pnlIsiForm.Controls.Add(Me.lblSatuan)
        Me.pnlIsiForm.Controls.Add(Me.txtKategori)
        Me.pnlIsiForm.Controls.Add(Me.lblKategoriInput)
        Me.pnlIsiForm.Controls.Add(Me.txtNamaBarang)
        Me.pnlIsiForm.Controls.Add(Me.lblNamaBarang)
        Me.pnlIsiForm.Controls.Add(Me.txtKodeBarang)
        Me.pnlIsiForm.Controls.Add(Me.lblKodeBarang)
        Me.pnlIsiForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlIsiForm.Location = New System.Drawing.Point(0, 77)
        Me.pnlIsiForm.Name = "pnlIsiForm"
        Me.pnlIsiForm.Padding = New System.Windows.Forms.Padding(17, 16, 17, 16)
        Me.pnlIsiForm.Size = New System.Drawing.Size(554, 462)
        Me.pnlIsiForm.TabIndex = 1
        '
        'lblPetunjuk
        '
        Me.lblPetunjuk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPetunjuk.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lblPetunjuk.ForeColor = System.Drawing.Color.DimGray
        Me.lblPetunjuk.Location = New System.Drawing.Point(21, 373)
        Me.lblPetunjuk.Name = "lblPetunjuk"
        Me.lblPetunjuk.Size = New System.Drawing.Size(823, 45)
        Me.lblPetunjuk.TabIndex = 12
        Me.lblPetunjuk.Text = "Catatan: stok dan harga beli dikelola melalui menu Barang Masuk."
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Aktif", "Nonaktif"})
        Me.cmbStatus.Location = New System.Drawing.Point(21, 331)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(822, 31)
        Me.cmbStatus.TabIndex = 11
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.Location = New System.Drawing.Point(21, 309)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(53, 20)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "Status"
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHargaJual.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtHargaJual.Location = New System.Drawing.Point(21, 272)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(822, 30)
        Me.txtHargaJual.TabIndex = 9
        '
        'lblHargaJual
        '
        Me.lblHargaJual.AutoSize = True
        Me.lblHargaJual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHargaJual.Location = New System.Drawing.Point(21, 251)
        Me.lblHargaJual.Name = "lblHargaJual"
        Me.lblHargaJual.Size = New System.Drawing.Size(83, 20)
        Me.lblHargaJual.TabIndex = 8
        Me.lblHargaJual.Text = "Harga Jual"
        '
        'txtSatuan
        '
        Me.txtSatuan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSatuan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSatuan.Location = New System.Drawing.Point(21, 213)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(822, 30)
        Me.txtSatuan.TabIndex = 7
        '
        'lblSatuan
        '
        Me.lblSatuan.AutoSize = True
        Me.lblSatuan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSatuan.Location = New System.Drawing.Point(21, 192)
        Me.lblSatuan.Name = "lblSatuan"
        Me.lblSatuan.Size = New System.Drawing.Size(57, 20)
        Me.lblSatuan.TabIndex = 6
        Me.lblSatuan.Text = "Satuan"
        '
        'txtKategori
        '
        Me.txtKategori.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKategori.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtKategori.Location = New System.Drawing.Point(21, 155)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(822, 30)
        Me.txtKategori.TabIndex = 5
        '
        'lblKategoriInput
        '
        Me.lblKategoriInput.AutoSize = True
        Me.lblKategoriInput.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblKategoriInput.Location = New System.Drawing.Point(21, 133)
        Me.lblKategoriInput.Name = "lblKategoriInput"
        Me.lblKategoriInput.Size = New System.Drawing.Size(69, 20)
        Me.lblKategoriInput.TabIndex = 4
        Me.lblKategoriInput.Text = "Kategori"
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNamaBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNamaBarang.Location = New System.Drawing.Point(21, 96)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(822, 30)
        Me.txtNamaBarang.TabIndex = 3
        '
        'lblNamaBarang
        '
        Me.lblNamaBarang.AutoSize = True
        Me.lblNamaBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNamaBarang.Location = New System.Drawing.Point(21, 75)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(105, 20)
        Me.lblNamaBarang.TabIndex = 2
        Me.lblNamaBarang.Text = "Nama Barang"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKodeBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtKodeBarang.Location = New System.Drawing.Point(21, 37)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(822, 30)
        Me.txtKodeBarang.TabIndex = 1
        '
        'lblKodeBarang
        '
        Me.lblKodeBarang.AutoSize = True
        Me.lblKodeBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblKodeBarang.Location = New System.Drawing.Point(21, 16)
        Me.lblKodeBarang.Name = "lblKodeBarang"
        Me.lblKodeBarang.Size = New System.Drawing.Size(99, 20)
        Me.lblKodeBarang.TabIndex = 0
        Me.lblKodeBarang.Text = "Kode Barang"
        '
        'pnlTombol
        '
        Me.pnlTombol.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTombol.Controls.Add(Me.btnBatal)
        Me.pnlTombol.Controls.Add(Me.btnUbah)
        Me.pnlTombol.Controls.Add(Me.btnSimpan)
        Me.pnlTombol.Controls.Add(Me.btnTambah)
        Me.pnlTombol.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTombol.Location = New System.Drawing.Point(0, 539)
        Me.pnlTombol.Name = "pnlTombol"
        Me.pnlTombol.Size = New System.Drawing.Size(554, 87)
        Me.pnlTombol.TabIndex = 2
        '
        'btnBatal
        '
        Me.btnBatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatal.BackColor = System.Drawing.Color.Gray
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(433, 43)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(97, 32)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUbah.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(21, 45)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(97, 30)
        Me.btnUbah.TabIndex = 2
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(152, 45)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(97, 30)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.BackColor = System.Drawing.Color.SeaGreen
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(298, 45)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(97, 30)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'pnlHeaderForm
        '
        Me.pnlHeaderForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlHeaderForm.Controls.Add(Me.lblHeaderForm)
        Me.pnlHeaderForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderForm.Name = "pnlHeaderForm"
        Me.pnlHeaderForm.Size = New System.Drawing.Size(554, 77)
        Me.pnlHeaderForm.TabIndex = 0
        '
        'lblHeaderForm
        '
        Me.lblHeaderForm.AutoSize = True
        Me.lblHeaderForm.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderForm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderForm.ForeColor = System.Drawing.Color.White
        Me.lblHeaderForm.Location = New System.Drawing.Point(17, 23)
        Me.lblHeaderForm.Name = "lblHeaderForm"
        Me.lblHeaderForm.Size = New System.Drawing.Size(218, 28)
        Me.lblHeaderForm.TabIndex = 0
        Me.lblHeaderForm.Text = "FORM DATA BARANG"
        '
        'FrmDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 693)
        Me.Controls.Add(Me.splitUtama)
        Me.Controls.Add(Me.pnlHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1026, 584)
        Me.Name = "FrmDataBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toko Pertanian - Data Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.splitUtama.Panel1.ResumeLayout(False)
        Me.splitUtama.Panel2.ResumeLayout(False)
        CType(Me.splitUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitUtama.ResumeLayout(False)
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilterBarang.ResumeLayout(False)
        Me.pnlFilterBarang.PerformLayout()
        Me.pnlIsiForm.ResumeLayout(False)
        Me.pnlIsiForm.PerformLayout()
        Me.pnlTombol.ResumeLayout(False)
        Me.pnlHeaderForm.ResumeLayout(False)
        Me.pnlHeaderForm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblNamaPengguna As Label
    Friend WithEvents lblNamaAplikasi As Label

    Friend WithEvents splitUtama As SplitContainer

    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents KodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents Kategori As DataGridViewTextBoxColumn
    Friend WithEvents Satuan As DataGridViewTextBoxColumn
    Friend WithEvents HargaJual As DataGridViewTextBoxColumn
    Friend WithEvents Stok As DataGridViewTextBoxColumn
    Friend WithEvents StatusBarang As DataGridViewTextBoxColumn

    Friend WithEvents pnlFilterBarang As Panel
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents lblKategori As Label
    Friend WithEvents txtCariBarang As TextBox
    Friend WithEvents lblCariBarang As Label

    Friend WithEvents pnlHeaderForm As Panel
    Friend WithEvents lblHeaderForm As Label

    Friend WithEvents pnlIsiForm As Panel
    Friend WithEvents lblKodeBarang As Label
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents lblNamaBarang As Label
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents lblKategoriInput As Label
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents lblSatuan As Label
    Friend WithEvents txtSatuan As TextBox
    Friend WithEvents lblHargaJual As Label
    Friend WithEvents txtHargaJual As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblPetunjuk As Label

    Friend WithEvents pnlTombol As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnBatal As Button

End Class