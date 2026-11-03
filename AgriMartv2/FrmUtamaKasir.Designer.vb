<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtamaKasir
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtamaKasir))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblNamaKasir = New System.Windows.Forms.Label()
        Me.lblNamaAplikasi = New System.Windows.Forms.Label()
        Me.splitUtama = New System.Windows.Forms.SplitContainer()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaJual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFilterBarang = New System.Windows.Forms.Panel()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.txtCariBarang = New System.Windows.Forms.TextBox()
        Me.lblCariBarang = New System.Windows.Forms.Label()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.KeranjangKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeranjangNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeranjangJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeranjangHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeranjangSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeranjangHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlPembayaran = New System.Windows.Forms.Panel()
        Me.cmbMetodePembayaran = New System.Windows.Forms.ComboBox()
        Me.lblMetodePembayaran = New System.Windows.Forms.Label()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.lblNominalKembalian = New System.Windows.Forms.Label()
        Me.txtUangBayar = New System.Windows.Forms.TextBox()
        Me.lblNominalTotalBelanja = New System.Windows.Forms.Label()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.lblUangBayar = New System.Windows.Forms.Label()
        Me.lblTotalBelanja = New System.Windows.Forms.Label()
        Me.pnlHeaderKeranjang = New System.Windows.Forms.Panel()
        Me.lblHeaderKeranjang = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        CType(Me.splitUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitUtama.Panel1.SuspendLayout()
        Me.splitUtama.Panel2.SuspendLayout()
        Me.splitUtama.SuspendLayout()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilterBarang.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPembayaran.SuspendLayout()
        Me.pnlHeaderKeranjang.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.lblNamaKasir)
        Me.pnlHeader.Controls.Add(Me.lblNamaAplikasi)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1169, 67)
        Me.pnlHeader.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnLogout.Location = New System.Drawing.Point(1035, 22)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(113, 39)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblNamaKasir
        '
        Me.lblNamaKasir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNamaKasir.AutoSize = True
        Me.lblNamaKasir.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaKasir.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaKasir.ForeColor = System.Drawing.Color.White
        Me.lblNamaKasir.Location = New System.Drawing.Point(907, 31)
        Me.lblNamaKasir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNamaKasir.Name = "lblNamaKasir"
        Me.lblNamaKasir.Size = New System.Drawing.Size(97, 23)
        Me.lblNamaKasir.TabIndex = 1
        Me.lblNamaKasir.Text = "Kasir: acad"
        '
        'lblNamaAplikasi
        '
        Me.lblNamaAplikasi.AutoSize = True
        Me.lblNamaAplikasi.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaAplikasi.Font = New System.Drawing.Font("Segoe UI", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaAplikasi.ForeColor = System.Drawing.Color.White
        Me.lblNamaAplikasi.Location = New System.Drawing.Point(13, 13)
        Me.lblNamaAplikasi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNamaAplikasi.Name = "lblNamaAplikasi"
        Me.lblNamaAplikasi.Size = New System.Drawing.Size(247, 37)
        Me.lblNamaAplikasi.TabIndex = 0
        Me.lblNamaAplikasi.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "TOKO PERTANIAN"
        Me.lblNamaAplikasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'splitUtama
        '
        Me.splitUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitUtama.Location = New System.Drawing.Point(0, 67)
        Me.splitUtama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.splitUtama.Name = "splitUtama"
        '
        'splitUtama.Panel1
        '
        Me.splitUtama.Panel1.Controls.Add(Me.dgvBarang)
        Me.splitUtama.Panel1.Controls.Add(Me.pnlFilterBarang)
        '
        'splitUtama.Panel2
        '
        Me.splitUtama.Panel2.Controls.Add(Me.dgvKeranjang)
        Me.splitUtama.Panel2.Controls.Add(Me.pnlPembayaran)
        Me.splitUtama.Panel2.Controls.Add(Me.pnlHeaderKeranjang)
        Me.splitUtama.Size = New System.Drawing.Size(1169, 440)
        Me.splitUtama.SplitterDistance = 433
        Me.splitUtama.SplitterWidth = 3
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBarang.ColumnHeadersHeight = 35
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarang, Me.NamaBarang, Me.Kategori, Me.Satuan, Me.HargaJual, Me.Stok})
        Me.dgvBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBarang.EnableHeadersVisualStyles = False
        Me.dgvBarang.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvBarang.Location = New System.Drawing.Point(0, 77)
        Me.dgvBarang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvBarang.MultiSelect = False
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.RowHeadersVisible = False
        Me.dgvBarang.RowHeadersWidth = 82
        Me.dgvBarang.RowTemplate.Height = 33
        Me.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarang.Size = New System.Drawing.Size(433, 363)
        Me.dgvBarang.TabIndex = 0
        '
        'KodeBarang
        '
        Me.KodeBarang.DataPropertyName = "kode_barang"
        Me.KodeBarang.HeaderText = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Kode Barang"
        Me.KodeBarang.MinimumWidth = 10
        Me.KodeBarang.Name = "KodeBarang"
        Me.KodeBarang.ReadOnly = True
        '
        'NamaBarang
        '
        Me.NamaBarang.DataPropertyName = "nama_barang"
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.MinimumWidth = 10
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.ReadOnly = True
        '
        'Kategori
        '
        Me.Kategori.DataPropertyName = "kategori"
        Me.Kategori.HeaderText = "Kategori"
        Me.Kategori.MinimumWidth = 10
        Me.Kategori.Name = "Kategori"
        Me.Kategori.ReadOnly = True
        '
        'Satuan
        '
        Me.Satuan.DataPropertyName = "satuan"
        Me.Satuan.HeaderText = "Satuan"
        Me.Satuan.MinimumWidth = 10
        Me.Satuan.Name = "Satuan"
        Me.Satuan.ReadOnly = True
        '
        'HargaJual
        '
        Me.HargaJual.DataPropertyName = "" & Global.Microsoft.VisualBasic.ChrW(9) & "harga_jual"
        Me.HargaJual.HeaderText = "Harga Jual"
        Me.HargaJual.MinimumWidth = 10
        Me.HargaJual.Name = "HargaJual"
        Me.HargaJual.ReadOnly = True
        '
        'Stok
        '
        Me.Stok.DataPropertyName = "" & Global.Microsoft.VisualBasic.ChrW(9) & "stok"
        Me.Stok.HeaderText = "Stok"
        Me.Stok.MinimumWidth = 10
        Me.Stok.Name = "Stok"
        Me.Stok.ReadOnly = True
        '
        'pnlFilterBarang
        '
        Me.pnlFilterBarang.Controls.Add(Me.cmbKategori)
        Me.pnlFilterBarang.Controls.Add(Me.lblKategori)
        Me.pnlFilterBarang.Controls.Add(Me.txtCariBarang)
        Me.pnlFilterBarang.Controls.Add(Me.lblCariBarang)
        Me.pnlFilterBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterBarang.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilterBarang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlFilterBarang.Name = "pnlFilterBarang"
        Me.pnlFilterBarang.Size = New System.Drawing.Size(433, 77)
        Me.pnlFilterBarang.TabIndex = 1
        '
        'cmbKategori
        '
        Me.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKategori.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(124, 39)
        Me.cmbKategori.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(309, 31)
        Me.cmbKategori.TabIndex = 3
        '
        'lblKategori
        '
        Me.lblKategori.AutoSize = True
        Me.lblKategori.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKategori.Location = New System.Drawing.Point(36, 44)
        Me.lblKategori.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(66, 20)
        Me.lblKategori.TabIndex = 2
        Me.lblKategori.Text = "Kategori"
        '
        'txtCariBarang
        '
        Me.txtCariBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCariBarang.Location = New System.Drawing.Point(124, 6)
        Me.txtCariBarang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Size = New System.Drawing.Size(309, 30)
        Me.txtCariBarang.TabIndex = 1
        '
        'lblCariBarang
        '
        Me.lblCariBarang.AutoSize = True
        Me.lblCariBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCariBarang.Location = New System.Drawing.Point(16, 10)
        Me.lblCariBarang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCariBarang.Name = "lblCariBarang"
        Me.lblCariBarang.Size = New System.Drawing.Size(90, 20)
        Me.lblCariBarang.TabIndex = 0
        Me.lblCariBarang.Text = "Cari Barang"
        '
        'dgvKeranjang
        '
        Me.dgvKeranjang.AllowUserToAddRows = False
        Me.dgvKeranjang.AllowUserToDeleteRows = False
        Me.dgvKeranjang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKeranjang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvKeranjang.BackgroundColor = System.Drawing.Color.White
        Me.dgvKeranjang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeranjangKodeBarang, Me.KeranjangNamaBarang, Me.KeranjangJumlah, Me.KeranjangHarga, Me.KeranjangSubtotal, Me.KeranjangHapus})
        Me.dgvKeranjang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvKeranjang.Location = New System.Drawing.Point(0, 77)
        Me.dgvKeranjang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvKeranjang.MultiSelect = False
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.ReadOnly = True
        Me.dgvKeranjang.RowHeadersVisible = False
        Me.dgvKeranjang.RowHeadersWidth = 82
        Me.dgvKeranjang.RowTemplate.Height = 33
        Me.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKeranjang.Size = New System.Drawing.Size(733, 194)
        Me.dgvKeranjang.TabIndex = 1
        '
        'KeranjangKodeBarang
        '
        Me.KeranjangKodeBarang.HeaderText = "Kode Barang"
        Me.KeranjangKodeBarang.MinimumWidth = 10
        Me.KeranjangKodeBarang.Name = "KeranjangKodeBarang"
        Me.KeranjangKodeBarang.ReadOnly = True
        '
        'KeranjangNamaBarang
        '
        Me.KeranjangNamaBarang.HeaderText = "Nama Barang"
        Me.KeranjangNamaBarang.MinimumWidth = 10
        Me.KeranjangNamaBarang.Name = "KeranjangNamaBarang"
        Me.KeranjangNamaBarang.ReadOnly = True
        '
        'KeranjangJumlah
        '
        Me.KeranjangJumlah.HeaderText = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Jumlah"
        Me.KeranjangJumlah.MinimumWidth = 10
        Me.KeranjangJumlah.Name = "KeranjangJumlah"
        Me.KeranjangJumlah.ReadOnly = True
        '
        'KeranjangHarga
        '
        Me.KeranjangHarga.HeaderText = "Harga"
        Me.KeranjangHarga.MinimumWidth = 10
        Me.KeranjangHarga.Name = "KeranjangHarga"
        Me.KeranjangHarga.ReadOnly = True
        '
        'KeranjangSubtotal
        '
        Me.KeranjangSubtotal.HeaderText = "Subtotal"
        Me.KeranjangSubtotal.MinimumWidth = 10
        Me.KeranjangSubtotal.Name = "KeranjangSubtotal"
        Me.KeranjangSubtotal.ReadOnly = True
        '
        'KeranjangHapus
        '
        Me.KeranjangHapus.HeaderText = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Aksi"
        Me.KeranjangHapus.MinimumWidth = 10
        Me.KeranjangHapus.Name = "KeranjangHapus"
        Me.KeranjangHapus.ReadOnly = True
        Me.KeranjangHapus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KeranjangHapus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.KeranjangHapus.Text = "Hapus"
        Me.KeranjangHapus.UseColumnTextForButtonValue = True
        '
        'pnlPembayaran
        '
        Me.pnlPembayaran.BackColor = System.Drawing.Color.White
        Me.pnlPembayaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPembayaran.Controls.Add(Me.cmbMetodePembayaran)
        Me.pnlPembayaran.Controls.Add(Me.lblMetodePembayaran)
        Me.pnlPembayaran.Controls.Add(Me.btnBayar)
        Me.pnlPembayaran.Controls.Add(Me.lblNominalKembalian)
        Me.pnlPembayaran.Controls.Add(Me.txtUangBayar)
        Me.pnlPembayaran.Controls.Add(Me.lblNominalTotalBelanja)
        Me.pnlPembayaran.Controls.Add(Me.lblKembalian)
        Me.pnlPembayaran.Controls.Add(Me.lblUangBayar)
        Me.pnlPembayaran.Controls.Add(Me.lblTotalBelanja)
        Me.pnlPembayaran.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPembayaran.Location = New System.Drawing.Point(0, 271)
        Me.pnlPembayaran.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlPembayaran.Name = "pnlPembayaran"
        Me.pnlPembayaran.Size = New System.Drawing.Size(733, 169)
        Me.pnlPembayaran.TabIndex = 2
        '
        'cmbMetodePembayaran
        '
        Me.cmbMetodePembayaran.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMetodePembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMetodePembayaran.FormattingEnabled = True
        Me.cmbMetodePembayaran.Items.AddRange(New Object() {"Tunai", "Qris"})
        Me.cmbMetodePembayaran.Location = New System.Drawing.Point(591, 31)
        Me.cmbMetodePembayaran.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbMetodePembayaran.Name = "cmbMetodePembayaran"
        Me.cmbMetodePembayaran.Size = New System.Drawing.Size(121, 24)
        Me.cmbMetodePembayaran.TabIndex = 8
        '
        'lblMetodePembayaran
        '
        Me.lblMetodePembayaran.AutoSize = True
        Me.lblMetodePembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMetodePembayaran.Location = New System.Drawing.Point(14, 32)
        Me.lblMetodePembayaran.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMetodePembayaran.Name = "lblMetodePembayaran"
        Me.lblMetodePembayaran.Size = New System.Drawing.Size(179, 20)
        Me.lblMetodePembayaran.TabIndex = 7
        Me.lblMetodePembayaran.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Metode Pembayaran"
        '
        'btnBayar
        '
        Me.btnBayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBayar.BackColor = System.Drawing.Color.Green
        Me.btnBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.Color.White
        Me.btnBayar.Location = New System.Drawing.Point(591, 124)
        Me.btnBayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(120, 36)
        Me.btnBayar.TabIndex = 6
        Me.btnBayar.Text = "BAYAR"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'lblNominalKembalian
        '
        Me.lblNominalKembalian.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNominalKembalian.AutoSize = True
        Me.lblNominalKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNominalKembalian.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblNominalKembalian.Location = New System.Drawing.Point(587, 99)
        Me.lblNominalKembalian.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNominalKembalian.Name = "lblNominalKembalian"
        Me.lblNominalKembalian.Size = New System.Drawing.Size(42, 20)
        Me.lblNominalKembalian.TabIndex = 5
        Me.lblNominalKembalian.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Rp0"
        '
        'txtUangBayar
        '
        Me.txtUangBayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUangBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUangBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUangBayar.Location = New System.Drawing.Point(591, 65)
        Me.txtUangBayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUangBayar.Name = "txtUangBayar"
        Me.txtUangBayar.Size = New System.Drawing.Size(121, 27)
        Me.txtUangBayar.TabIndex = 4
        Me.txtUangBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNominalTotalBelanja
        '
        Me.lblNominalTotalBelanja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNominalTotalBelanja.AutoSize = True
        Me.lblNominalTotalBelanja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNominalTotalBelanja.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblNominalTotalBelanja.Location = New System.Drawing.Point(587, 1)
        Me.lblNominalTotalBelanja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNominalTotalBelanja.Name = "lblNominalTotalBelanja"
        Me.lblNominalTotalBelanja.Size = New System.Drawing.Size(42, 20)
        Me.lblNominalTotalBelanja.TabIndex = 3
        Me.lblNominalTotalBelanja.Tag = "" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.lblNominalTotalBelanja.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "Rp0"
        '
        'lblKembalian
        '
        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembalian.ForeColor = System.Drawing.Color.Black
        Me.lblKembalian.Location = New System.Drawing.Point(14, 99)
        Me.lblKembalian.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(96, 20)
        Me.lblKembalian.TabIndex = 2
        Me.lblKembalian.Text = "Kembalian"
        '
        'lblUangBayar
        '
        Me.lblUangBayar.AutoSize = True
        Me.lblUangBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUangBayar.ForeColor = System.Drawing.Color.Black
        Me.lblUangBayar.Location = New System.Drawing.Point(14, 70)
        Me.lblUangBayar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUangBayar.Name = "lblUangBayar"
        Me.lblUangBayar.Size = New System.Drawing.Size(107, 20)
        Me.lblUangBayar.TabIndex = 1
        Me.lblUangBayar.Text = "Uang Bayar"
        '
        'lblTotalBelanja
        '
        Me.lblTotalBelanja.AutoSize = True
        Me.lblTotalBelanja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBelanja.ForeColor = System.Drawing.Color.Black
        Me.lblTotalBelanja.Location = New System.Drawing.Point(14, 1)
        Me.lblTotalBelanja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalBelanja.Name = "lblTotalBelanja"
        Me.lblTotalBelanja.Size = New System.Drawing.Size(120, 20)
        Me.lblTotalBelanja.TabIndex = 0
        Me.lblTotalBelanja.Text = "Total Belanja"
        '
        'pnlHeaderKeranjang
        '
        Me.pnlHeaderKeranjang.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlHeaderKeranjang.Controls.Add(Me.lblHeaderKeranjang)
        Me.pnlHeaderKeranjang.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderKeranjang.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderKeranjang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlHeaderKeranjang.Name = "pnlHeaderKeranjang"
        Me.pnlHeaderKeranjang.Size = New System.Drawing.Size(733, 77)
        Me.pnlHeaderKeranjang.TabIndex = 0
        '
        'lblHeaderKeranjang
        '
        Me.lblHeaderKeranjang.AutoSize = True
        Me.lblHeaderKeranjang.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderKeranjang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderKeranjang.ForeColor = System.Drawing.Color.White
        Me.lblHeaderKeranjang.Location = New System.Drawing.Point(13, 14)
        Me.lblHeaderKeranjang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeaderKeranjang.Name = "lblHeaderKeranjang"
        Me.lblHeaderKeranjang.Size = New System.Drawing.Size(223, 28)
        Me.lblHeaderKeranjang.TabIndex = 1
        Me.lblHeaderKeranjang.Text = "KERANJANG BELANJA"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(708, 81)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'FrmUtamaKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 507)
        Me.Controls.Add(Me.splitUtama)
        Me.Controls.Add(Me.pnlHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(673, 433)
        Me.Name = "FrmUtamaKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toko Pertanian - Kasir"
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
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPembayaran.ResumeLayout(False)
        Me.pnlPembayaran.PerformLayout()
        Me.pnlHeaderKeranjang.ResumeLayout(False)
        Me.pnlHeaderKeranjang.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblNamaAplikasi As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblNamaKasir As Label
    Friend WithEvents splitUtama As SplitContainer
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents pnlFilterBarang As Panel
    Friend WithEvents txtCariBarang As TextBox
    Friend WithEvents lblCariBarang As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents KodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents Kategori As DataGridViewTextBoxColumn
    Friend WithEvents Satuan As DataGridViewTextBoxColumn
    Friend WithEvents HargaJual As DataGridViewTextBoxColumn
    Friend WithEvents Stok As DataGridViewTextBoxColumn
    Friend WithEvents pnlHeaderKeranjang As Panel
    Friend WithEvents lblHeaderKeranjang As Label
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents KeranjangKodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents KeranjangNamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents KeranjangJumlah As DataGridViewTextBoxColumn
    Friend WithEvents KeranjangHarga As DataGridViewTextBoxColumn
    Friend WithEvents KeranjangSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents KeranjangHapus As DataGridViewButtonColumn
    Friend WithEvents pnlPembayaran As Panel
    Friend WithEvents lblTotalBelanja As Label
    Friend WithEvents lblUangBayar As Label
    Friend WithEvents lblKembalian As Label
    Friend WithEvents lblNominalTotalBelanja As Label
    Friend WithEvents txtUangBayar As TextBox
    Friend WithEvents lblNominalKembalian As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnBayar As Button
    Friend WithEvents lblMetodePembayaran As Label
    Friend WithEvents cmbMetodePembayaran As ComboBox
End Class