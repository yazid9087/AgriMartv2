<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLaporanOwner
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLaporanOwner))
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnRingkasan = New System.Windows.Forms.Button()
        Me.lblVersi = New System.Windows.Forms.Label()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.tabLaporan = New System.Windows.Forms.TabControl()
        Me.tpPenjualan = New System.Windows.Forms.TabPage()
        Me.dgvPenjualan = New System.Windows.Forms.DataGridView()
        Me.clmNoNota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKasir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMetode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpLaba = New System.Windows.Forms.TabPage()
        Me.dgvLaba = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmOmzet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotalModal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmLabaKotor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpPerBarang = New System.Windows.Forms.TabPage()
        Me.dgvPerBarang = New System.Windows.Forms.DataGridView()
        Me.clmKode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmJumlahTerjual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmOmzet2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmLabaKotor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpMetode = New System.Windows.Forms.TabPage()
        Me.dvgMetode = New System.Windows.Forms.DataGridView()
        Me.clmMetodePembayaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmJumlahTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotalPenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpPersediaan = New System.Windows.Forms.TabPage()
        Me.dgvPersediaan = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmHargaBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmHargaJual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRingkasan = New System.Windows.Forms.Label()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.lblSampai = New System.Windows.Forms.Label()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.lblDari = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.tabLaporan.SuspendLayout()
        Me.tpPenjualan.SuspendLayout()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpLaba.SuspendLayout()
        CType(Me.dgvLaba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPerBarang.SuspendLayout()
        CType(Me.dgvPerBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpMetode.SuspendLayout()
        CType(Me.dvgMetode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPersediaan.SuspendLayout()
        CType(Me.dgvPersediaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnLaporan)
        Me.pnlSidebar.Controls.Add(Me.btnRingkasan)
        Me.pnlSidebar.Controls.Add(Me.lblVersi)
        Me.pnlSidebar.Controls.Add(Me.lblLogo)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 712)
        Me.pnlSidebar.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(0, 666)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 46)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.ForeColor = System.Drawing.Color.White
        Me.btnLaporan.Location = New System.Drawing.Point(0, 146)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnLaporan.Size = New System.Drawing.Size(200, 46)
        Me.btnLaporan.TabIndex = 3
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'btnRingkasan
        '
        Me.btnRingkasan.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnRingkasan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRingkasan.FlatAppearance.BorderSize = 0
        Me.btnRingkasan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRingkasan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRingkasan.ForeColor = System.Drawing.Color.White
        Me.btnRingkasan.Location = New System.Drawing.Point(0, 100)
        Me.btnRingkasan.Name = "btnRingkasan"
        Me.btnRingkasan.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnRingkasan.Size = New System.Drawing.Size(200, 46)
        Me.btnRingkasan.TabIndex = 2
        Me.btnRingkasan.Text = "Ringkasan"
        Me.btnRingkasan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRingkasan.UseVisualStyleBackColor = False
        '
        'lblVersi
        '
        Me.lblVersi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersi.ForeColor = System.Drawing.Color.White
        Me.lblVersi.Location = New System.Drawing.Point(0, 56)
        Me.lblVersi.Name = "lblVersi"
        Me.lblVersi.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.lblVersi.Size = New System.Drawing.Size(200, 24)
        Me.lblVersi.TabIndex = 1
        Me.lblVersi.Text = "OWNER VERSION"
        Me.lblVersi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLogo
        '
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(0, 16)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.lblLogo.Size = New System.Drawing.Size(200, 40)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "AgriMart"
        Me.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlBody)
        Me.Panel1.Controls.Add(Me.pnlHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1144, 712)
        Me.Panel1.TabIndex = 2
        '
        'pnlBody
        '
        Me.pnlBody.Controls.Add(Me.tabLaporan)
        Me.pnlBody.Controls.Add(Me.lblRingkasan)
        Me.pnlBody.Controls.Add(Me.pnlFilter)
        Me.pnlBody.Controls.Add(Me.lblJudul)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 40)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Padding = New System.Windows.Forms.Padding(20, 10, 20, 16)
        Me.pnlBody.Size = New System.Drawing.Size(1144, 672)
        Me.pnlBody.TabIndex = 2
        '
        'tabLaporan
        '
        Me.tabLaporan.Controls.Add(Me.tpPenjualan)
        Me.tabLaporan.Controls.Add(Me.tpLaba)
        Me.tabLaporan.Controls.Add(Me.tpPerBarang)
        Me.tabLaporan.Controls.Add(Me.tpMetode)
        Me.tabLaporan.Controls.Add(Me.tpPersediaan)
        Me.tabLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabLaporan.Location = New System.Drawing.Point(20, 99)
        Me.tabLaporan.Name = "tabLaporan"
        Me.tabLaporan.SelectedIndex = 0
        Me.tabLaporan.Size = New System.Drawing.Size(1104, 532)
        Me.tabLaporan.TabIndex = 3
        '
        'tpPenjualan
        '
        Me.tpPenjualan.Controls.Add(Me.dgvPenjualan)
        Me.tpPenjualan.Location = New System.Drawing.Point(4, 32)
        Me.tpPenjualan.Name = "tpPenjualan"
        Me.tpPenjualan.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPenjualan.Size = New System.Drawing.Size(1096, 496)
        Me.tpPenjualan.TabIndex = 0
        Me.tpPenjualan.Text = "Penjualan"
        Me.tpPenjualan.UseVisualStyleBackColor = True
        '
        'dgvPenjualan
        '
        Me.dgvPenjualan.AllowUserToAddRows = False
        Me.dgvPenjualan.AllowUserToDeleteRows = False
        Me.dgvPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPenjualan.BackgroundColor = System.Drawing.Color.White
        Me.dgvPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPenjualan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNoNota, Me.clmTanggal, Me.clmKasir, Me.clmMetode, Me.clmTotal})
        Me.dgvPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPenjualan.EnableHeadersVisualStyles = False
        Me.dgvPenjualan.Location = New System.Drawing.Point(3, 3)
        Me.dgvPenjualan.Name = "dgvPenjualan"
        Me.dgvPenjualan.ReadOnly = True
        Me.dgvPenjualan.RowHeadersVisible = False
        Me.dgvPenjualan.RowHeadersWidth = 62
        Me.dgvPenjualan.RowTemplate.Height = 28
        Me.dgvPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPenjualan.Size = New System.Drawing.Size(1090, 490)
        Me.dgvPenjualan.TabIndex = 0
        '
        'clmNoNota
        '
        Me.clmNoNota.HeaderText = "No Nota"
        Me.clmNoNota.MinimumWidth = 8
        Me.clmNoNota.Name = "clmNoNota"
        Me.clmNoNota.ReadOnly = True
        '
        'clmTanggal
        '
        Me.clmTanggal.HeaderText = "Tanggal"
        Me.clmTanggal.MinimumWidth = 8
        Me.clmTanggal.Name = "clmTanggal"
        Me.clmTanggal.ReadOnly = True
        '
        'clmKasir
        '
        Me.clmKasir.HeaderText = "Kasir"
        Me.clmKasir.MinimumWidth = 8
        Me.clmKasir.Name = "clmKasir"
        Me.clmKasir.ReadOnly = True
        '
        'clmMetode
        '
        Me.clmMetode.HeaderText = "Metode"
        Me.clmMetode.MinimumWidth = 8
        Me.clmMetode.Name = "clmMetode"
        Me.clmMetode.ReadOnly = True
        '
        'clmTotal
        '
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.MinimumWidth = 8
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'tpLaba
        '
        Me.tpLaba.Controls.Add(Me.dgvLaba)
        Me.tpLaba.Location = New System.Drawing.Point(4, 32)
        Me.tpLaba.Name = "tpLaba"
        Me.tpLaba.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLaba.Size = New System.Drawing.Size(1096, 496)
        Me.tpLaba.TabIndex = 1
        Me.tpLaba.Text = "Laba Kotor"
        Me.tpLaba.UseVisualStyleBackColor = True
        '
        'dgvLaba
        '
        Me.dgvLaba.AllowUserToAddRows = False
        Me.dgvLaba.AllowUserToDeleteRows = False
        Me.dgvLaba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLaba.BackgroundColor = System.Drawing.Color.White
        Me.dgvLaba.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLaba.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvLaba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaba.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.clmOmzet, Me.clmTotalModal, Me.clmLabaKotor})
        Me.dgvLaba.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLaba.EnableHeadersVisualStyles = False
        Me.dgvLaba.Location = New System.Drawing.Point(3, 3)
        Me.dgvLaba.Name = "dgvLaba"
        Me.dgvLaba.ReadOnly = True
        Me.dgvLaba.RowHeadersVisible = False
        Me.dgvLaba.RowHeadersWidth = 62
        Me.dgvLaba.RowTemplate.Height = 28
        Me.dgvLaba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLaba.Size = New System.Drawing.Size(1090, 490)
        Me.dgvLaba.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No Nota"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tanggal"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'clmOmzet
        '
        Me.clmOmzet.HeaderText = "Omzet"
        Me.clmOmzet.MinimumWidth = 8
        Me.clmOmzet.Name = "clmOmzet"
        Me.clmOmzet.ReadOnly = True
        '
        'clmTotalModal
        '
        Me.clmTotalModal.HeaderText = "Total Modal"
        Me.clmTotalModal.MinimumWidth = 8
        Me.clmTotalModal.Name = "clmTotalModal"
        Me.clmTotalModal.ReadOnly = True
        '
        'clmLabaKotor
        '
        Me.clmLabaKotor.HeaderText = "Laba Kotor"
        Me.clmLabaKotor.MinimumWidth = 8
        Me.clmLabaKotor.Name = "clmLabaKotor"
        Me.clmLabaKotor.ReadOnly = True
        '
        'tpPerBarang
        '
        Me.tpPerBarang.Controls.Add(Me.dgvPerBarang)
        Me.tpPerBarang.Location = New System.Drawing.Point(4, 32)
        Me.tpPerBarang.Name = "tpPerBarang"
        Me.tpPerBarang.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPerBarang.Size = New System.Drawing.Size(1096, 496)
        Me.tpPerBarang.TabIndex = 2
        Me.tpPerBarang.Text = "Penjualan per Barang"
        Me.tpPerBarang.UseVisualStyleBackColor = True
        '
        'dgvPerBarang
        '
        Me.dgvPerBarang.AllowUserToAddRows = False
        Me.dgvPerBarang.AllowUserToDeleteRows = False
        Me.dgvPerBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPerBarang.BackgroundColor = System.Drawing.Color.White
        Me.dgvPerBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPerBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvPerBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmKode, Me.clmNamaBarang, Me.clmJumlahTerjual, Me.clmOmzet2, Me.clmLabaKotor2})
        Me.dgvPerBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPerBarang.EnableHeadersVisualStyles = False
        Me.dgvPerBarang.Location = New System.Drawing.Point(3, 3)
        Me.dgvPerBarang.Name = "dgvPerBarang"
        Me.dgvPerBarang.ReadOnly = True
        Me.dgvPerBarang.RowHeadersVisible = False
        Me.dgvPerBarang.RowHeadersWidth = 62
        Me.dgvPerBarang.RowTemplate.Height = 28
        Me.dgvPerBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPerBarang.Size = New System.Drawing.Size(1090, 490)
        Me.dgvPerBarang.TabIndex = 2
        '
        'clmKode
        '
        Me.clmKode.HeaderText = "Kode"
        Me.clmKode.MinimumWidth = 8
        Me.clmKode.Name = "clmKode"
        Me.clmKode.ReadOnly = True
        '
        'clmNamaBarang
        '
        Me.clmNamaBarang.HeaderText = "Nama Barang"
        Me.clmNamaBarang.MinimumWidth = 8
        Me.clmNamaBarang.Name = "clmNamaBarang"
        Me.clmNamaBarang.ReadOnly = True
        '
        'clmJumlahTerjual
        '
        Me.clmJumlahTerjual.HeaderText = "Jumlah Terjual"
        Me.clmJumlahTerjual.MinimumWidth = 8
        Me.clmJumlahTerjual.Name = "clmJumlahTerjual"
        Me.clmJumlahTerjual.ReadOnly = True
        '
        'clmOmzet2
        '
        Me.clmOmzet2.HeaderText = "Omzet"
        Me.clmOmzet2.MinimumWidth = 8
        Me.clmOmzet2.Name = "clmOmzet2"
        Me.clmOmzet2.ReadOnly = True
        '
        'clmLabaKotor2
        '
        Me.clmLabaKotor2.HeaderText = "Laba Kotor"
        Me.clmLabaKotor2.MinimumWidth = 8
        Me.clmLabaKotor2.Name = "clmLabaKotor2"
        Me.clmLabaKotor2.ReadOnly = True
        '
        'tpMetode
        '
        Me.tpMetode.Controls.Add(Me.dvgMetode)
        Me.tpMetode.Location = New System.Drawing.Point(4, 32)
        Me.tpMetode.Name = "tpMetode"
        Me.tpMetode.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMetode.Size = New System.Drawing.Size(1096, 496)
        Me.tpMetode.TabIndex = 3
        Me.tpMetode.Text = "Rekap Metode Pembayaran"
        Me.tpMetode.UseVisualStyleBackColor = True
        '
        'dvgMetode
        '
        Me.dvgMetode.AllowUserToAddRows = False
        Me.dvgMetode.AllowUserToDeleteRows = False
        Me.dvgMetode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgMetode.BackgroundColor = System.Drawing.Color.White
        Me.dvgMetode.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgMetode.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dvgMetode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMetode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmMetodePembayaran, Me.clmJumlahTransaksi, Me.clmTotalPenjualan})
        Me.dvgMetode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgMetode.EnableHeadersVisualStyles = False
        Me.dvgMetode.Location = New System.Drawing.Point(3, 3)
        Me.dvgMetode.Name = "dvgMetode"
        Me.dvgMetode.ReadOnly = True
        Me.dvgMetode.RowHeadersVisible = False
        Me.dvgMetode.RowHeadersWidth = 62
        Me.dvgMetode.RowTemplate.Height = 28
        Me.dvgMetode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgMetode.Size = New System.Drawing.Size(1090, 490)
        Me.dvgMetode.TabIndex = 3
        '
        'clmMetodePembayaran
        '
        Me.clmMetodePembayaran.HeaderText = "Metode Pembayaran"
        Me.clmMetodePembayaran.MinimumWidth = 8
        Me.clmMetodePembayaran.Name = "clmMetodePembayaran"
        Me.clmMetodePembayaran.ReadOnly = True
        '
        'clmJumlahTransaksi
        '
        Me.clmJumlahTransaksi.HeaderText = "Jumlah Transaksi"
        Me.clmJumlahTransaksi.MinimumWidth = 8
        Me.clmJumlahTransaksi.Name = "clmJumlahTransaksi"
        Me.clmJumlahTransaksi.ReadOnly = True
        '
        'clmTotalPenjualan
        '
        Me.clmTotalPenjualan.HeaderText = "Total Penjualan"
        Me.clmTotalPenjualan.MinimumWidth = 8
        Me.clmTotalPenjualan.Name = "clmTotalPenjualan"
        Me.clmTotalPenjualan.ReadOnly = True
        '
        'tpPersediaan
        '
        Me.tpPersediaan.Controls.Add(Me.dgvPersediaan)
        Me.tpPersediaan.Location = New System.Drawing.Point(4, 32)
        Me.tpPersediaan.Name = "tpPersediaan"
        Me.tpPersediaan.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPersediaan.Size = New System.Drawing.Size(1096, 496)
        Me.tpPersediaan.TabIndex = 4
        Me.tpPersediaan.Text = "Persediaan"
        Me.tpPersediaan.UseVisualStyleBackColor = True
        '
        'dgvPersediaan
        '
        Me.dgvPersediaan.AllowUserToAddRows = False
        Me.dgvPersediaan.AllowUserToDeleteRows = False
        Me.dgvPersediaan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPersediaan.BackgroundColor = System.Drawing.Color.White
        Me.dgvPersediaan.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPersediaan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvPersediaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersediaan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.clmKategori, Me.clmSatuan, Me.clmHargaBeli, Me.clmHargaJual, Me.clmStok})
        Me.dgvPersediaan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPersediaan.EnableHeadersVisualStyles = False
        Me.dgvPersediaan.Location = New System.Drawing.Point(3, 3)
        Me.dgvPersediaan.Name = "dgvPersediaan"
        Me.dgvPersediaan.ReadOnly = True
        Me.dgvPersediaan.RowHeadersVisible = False
        Me.dgvPersediaan.RowHeadersWidth = 62
        Me.dgvPersediaan.RowTemplate.Height = 28
        Me.dgvPersediaan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPersediaan.Size = New System.Drawing.Size(1090, 490)
        Me.dgvPersediaan.TabIndex = 3
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kode"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'clmKategori
        '
        Me.clmKategori.HeaderText = "Kategori"
        Me.clmKategori.MinimumWidth = 8
        Me.clmKategori.Name = "clmKategori"
        Me.clmKategori.ReadOnly = True
        '
        'clmSatuan
        '
        Me.clmSatuan.HeaderText = "Satuan"
        Me.clmSatuan.MinimumWidth = 8
        Me.clmSatuan.Name = "clmSatuan"
        Me.clmSatuan.ReadOnly = True
        '
        'clmHargaBeli
        '
        Me.clmHargaBeli.HeaderText = "Harga Beli"
        Me.clmHargaBeli.MinimumWidth = 8
        Me.clmHargaBeli.Name = "clmHargaBeli"
        Me.clmHargaBeli.ReadOnly = True
        '
        'clmHargaJual
        '
        Me.clmHargaJual.HeaderText = "Harga Jual"
        Me.clmHargaJual.MinimumWidth = 8
        Me.clmHargaJual.Name = "clmHargaJual"
        Me.clmHargaJual.ReadOnly = True
        '
        'clmStok
        '
        Me.clmStok.HeaderText = "Stok"
        Me.clmStok.MinimumWidth = 8
        Me.clmStok.Name = "clmStok"
        Me.clmStok.ReadOnly = True
        '
        'lblRingkasan
        '
        Me.lblRingkasan.AutoSize = True
        Me.lblRingkasan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblRingkasan.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRingkasan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblRingkasan.Location = New System.Drawing.Point(20, 631)
        Me.lblRingkasan.Name = "lblRingkasan"
        Me.lblRingkasan.Size = New System.Drawing.Size(370, 25)
        Me.lblRingkasan.TabIndex = 2
        Me.lblRingkasan.Text = "Jumlah Nota: 2 | Total Penjulan: Rp 340.000"
        Me.lblRingkasan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlFilter
        '
        Me.pnlFilter.Controls.Add(Me.btnRefresh)
        Me.pnlFilter.Controls.Add(Me.btnTampilkan)
        Me.pnlFilter.Controls.Add(Me.dtpAkhir)
        Me.pnlFilter.Controls.Add(Me.lblSampai)
        Me.pnlFilter.Controls.Add(Me.dtpAwal)
        Me.pnlFilter.Controls.Add(Me.lblDari)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(20, 47)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1104, 52)
        Me.pnlFilter.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Green
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(520, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 34)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnTampilkan
        '
        Me.btnTampilkan.BackColor = System.Drawing.Color.Green
        Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.Location = New System.Drawing.Point(400, 6)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(110, 34)
        Me.btnTampilkan.TabIndex = 4
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = False
        '
        'dtpAkhir
        '
        Me.dtpAkhir.CustomFormat = "dd/MM/yyyy"
        Me.dtpAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAkhir.Location = New System.Drawing.Point(260, 10)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(120, 30)
        Me.dtpAkhir.TabIndex = 3
        '
        'lblSampai
        '
        Me.lblSampai.AutoSize = True
        Me.lblSampai.Location = New System.Drawing.Point(190, 14)
        Me.lblSampai.Name = "lblSampai"
        Me.lblSampai.Size = New System.Drawing.Size(66, 23)
        Me.lblSampai.TabIndex = 2
        Me.lblSampai.Text = "Sampai"
        '
        'dtpAwal
        '
        Me.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwal.Location = New System.Drawing.Point(50, 10)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(120, 30)
        Me.dtpAwal.TabIndex = 1
        '
        'lblDari
        '
        Me.lblDari.AutoSize = True
        Me.lblDari.Location = New System.Drawing.Point(0, 14)
        Me.lblDari.Name = "lblDari"
        Me.lblDari.Size = New System.Drawing.Size(41, 23)
        Me.lblDari.TabIndex = 0
        Me.lblDari.Text = "Dari"
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(20, 10)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(377, 37)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Laporan Penjualan dan Laba"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblUser)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1144, 40)
        Me.pnlHeader.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblUser.Location = New System.Drawing.Point(824, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Padding = New System.Windows.Forms.Padding(0, 0, 18, 0)
        Me.lblUser.Size = New System.Drawing.Size(320, 40)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Owner | Owner"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmLaporanOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1344, 712)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1024, 680)
        Me.Name = "FrmLaporanOwner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toko Pertanian - Laporan Owner"
        Me.pnlSidebar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.tabLaporan.ResumeLayout(False)
        Me.tpPenjualan.ResumeLayout(False)
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpLaba.ResumeLayout(False)
        CType(Me.dgvLaba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPerBarang.ResumeLayout(False)
        CType(Me.dgvPerBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpMetode.ResumeLayout(False)
        CType(Me.dvgMetode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPersediaan.ResumeLayout(False)
        CType(Me.dgvPersediaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnRingkasan As Button
    Friend WithEvents lblVersi As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents pnlBody As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents lblRingkasan As Label
    Friend WithEvents tabLaporan As TabControl
    Friend WithEvents tpPenjualan As TabPage
    Friend WithEvents tpLaba As TabPage
    Friend WithEvents lblDari As Label
    Friend WithEvents dtpAwal As DateTimePicker
    Friend WithEvents lblSampai As Label
    Friend WithEvents dtpAkhir As DateTimePicker
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents tpPerBarang As TabPage
    Friend WithEvents tpMetode As TabPage
    Friend WithEvents tpPersediaan As TabPage
    Friend WithEvents dgvPenjualan As DataGridView
    Friend WithEvents clmNoNota As DataGridViewTextBoxColumn
    Friend WithEvents clmTanggal As DataGridViewTextBoxColumn
    Friend WithEvents clmKasir As DataGridViewTextBoxColumn
    Friend WithEvents clmMetode As DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As DataGridViewTextBoxColumn
    Friend WithEvents dgvLaba As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents clmOmzet As DataGridViewTextBoxColumn
    Friend WithEvents clmTotalModal As DataGridViewTextBoxColumn
    Friend WithEvents clmLabaKotor As DataGridViewTextBoxColumn
    Friend WithEvents dgvPerBarang As DataGridView
    Friend WithEvents clmKode As DataGridViewTextBoxColumn
    Friend WithEvents clmNamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents clmJumlahTerjual As DataGridViewTextBoxColumn
    Friend WithEvents clmOmzet2 As DataGridViewTextBoxColumn
    Friend WithEvents clmLabaKotor2 As DataGridViewTextBoxColumn
    Friend WithEvents dvgMetode As DataGridView
    Friend WithEvents clmMetodePembayaran As DataGridViewTextBoxColumn
    Friend WithEvents clmJumlahTransaksi As DataGridViewTextBoxColumn
    Friend WithEvents clmTotalPenjualan As DataGridViewTextBoxColumn
    Friend WithEvents dgvPersediaan As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents clmKategori As DataGridViewTextBoxColumn
    Friend WithEvents clmSatuan As DataGridViewTextBoxColumn
    Friend WithEvents clmHargaBeli As DataGridViewTextBoxColumn
    Friend WithEvents clmHargaJual As DataGridViewTextBoxColumn
    Friend WithEvents clmStok As DataGridViewTextBoxColumn
End Class