Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRiwayatPenjualan
    Inherits Form

    Private components As System.ComponentModel.IContainer

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

    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRiwayatPenjualan))
        Me.tlpRoot = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.tlpFilter = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.lblDari = New System.Windows.Forms.Label()
        Me.dtpDari = New System.Windows.Forms.DateTimePicker()
        Me.lblSampai = New System.Windows.Forms.Label()
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpDaftar = New System.Windows.Forms.GroupBox()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.colNoNota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKasir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMetode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpDetail = New System.Windows.Forms.GroupBox()
        Me.dgvDetail = New System.Windows.Forms.DataGridView()
        Me.colKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.tlpFooter = New System.Windows.Forms.TableLayoutPanel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblTotalCaption = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tlpRoot.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.tlpFilter.SuspendLayout()
        Me.grpDaftar.SuspendLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetail.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.tlpFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpRoot
        '
        Me.tlpRoot.ColumnCount = 1
        Me.tlpRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRoot.Controls.Add(Me.pnlHeader, 0, 0)
        Me.tlpRoot.Controls.Add(Me.pnlFilter, 0, 1)
        Me.tlpRoot.Controls.Add(Me.grpDaftar, 0, 2)
        Me.tlpRoot.Controls.Add(Me.grpDetail, 0, 3)
        Me.tlpRoot.Controls.Add(Me.pnlFooter, 0, 4)
        Me.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRoot.Location = New System.Drawing.Point(0, 0)
        Me.tlpRoot.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRoot.Name = "tlpRoot"
        Me.tlpRoot.RowCount = 5
        Me.tlpRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.tlpRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.tlpRoot.Size = New System.Drawing.Size(1755, 1055)
        Me.tlpRoot.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1749, 95)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 23.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(25, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(426, 52)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "RIWAYAT PENJUALAN"
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.White
        Me.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilter.Controls.Add(Me.tlpFilter)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFilter.Location = New System.Drawing.Point(3, 104)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.pnlFilter.Size = New System.Drawing.Size(1749, 74)
        Me.pnlFilter.TabIndex = 1
        '
        'tlpFilter
        '
        Me.tlpFilter.ColumnCount = 8
        Me.tlpFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.tlpFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.0!))
        Me.tlpFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.tlpFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.tlpFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.tlpFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.tlpFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.tlpFilter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.tlpFilter.Controls.Add(Me.lblCari, 0, 0)
        Me.tlpFilter.Controls.Add(Me.txtCari, 1, 0)
        Me.tlpFilter.Controls.Add(Me.lblDari, 2, 0)
        Me.tlpFilter.Controls.Add(Me.dtpDari, 3, 0)
        Me.tlpFilter.Controls.Add(Me.lblSampai, 4, 0)
        Me.tlpFilter.Controls.Add(Me.dtpSampai, 5, 0)
        Me.tlpFilter.Controls.Add(Me.btnCari, 6, 0)
        Me.tlpFilter.Controls.Add(Me.btnReset, 7, 0)
        Me.tlpFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFilter.Location = New System.Drawing.Point(12, 10)
        Me.tlpFilter.Name = "tlpFilter"
        Me.tlpFilter.RowCount = 1
        Me.tlpFilter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFilter.Size = New System.Drawing.Size(1723, 52)
        Me.tlpFilter.TabIndex = 0
        '
        'lblCari
        '
        Me.lblCari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCari.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCari.Location = New System.Drawing.Point(3, 0)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(97, 52)
        Me.lblCari.TabIndex = 0
        Me.lblCari.Text = "Cari:"
        Me.lblCari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCari
        '
        Me.txtCari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCari.Location = New System.Drawing.Point(106, 8)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(3, 8, 10, 8)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(400, 30)
        Me.txtCari.TabIndex = 1
        '
        'lblDari
        '
        Me.lblDari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDari.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblDari.Location = New System.Drawing.Point(519, 0)
        Me.lblDari.Name = "lblDari"
        Me.lblDari.Size = New System.Drawing.Size(97, 52)
        Me.lblDari.TabIndex = 2
        Me.lblDari.Text = "Dari:"
        Me.lblDari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDari
        '
        Me.dtpDari.CustomFormat = "dd/MM/yyyy"
        Me.dtpDari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDari.Location = New System.Drawing.Point(622, 8)
        Me.dtpDari.Margin = New System.Windows.Forms.Padding(3, 8, 8, 8)
        Me.dtpDari.Name = "dtpDari"
        Me.dtpDari.Size = New System.Drawing.Size(230, 27)
        Me.dtpDari.TabIndex = 3
        '
        'lblSampai
        '
        Me.lblSampai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSampai.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSampai.Location = New System.Drawing.Point(863, 0)
        Me.lblSampai.Name = "lblSampai"
        Me.lblSampai.Size = New System.Drawing.Size(131, 52)
        Me.lblSampai.TabIndex = 4
        Me.lblSampai.Text = "Sampai:"
        Me.lblSampai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpSampai
        '
        Me.dtpSampai.CustomFormat = "dd/MM/yyyy"
        Me.dtpSampai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpSampai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSampai.Location = New System.Drawing.Point(1000, 8)
        Me.dtpSampai.Margin = New System.Windows.Forms.Padding(3, 8, 8, 8)
        Me.dtpSampai.Name = "dtpSampai"
        Me.dtpSampai.Size = New System.Drawing.Size(230, 27)
        Me.dtpSampai.TabIndex = 5
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(1243, 6)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(231, 40)
        Me.btnCari.TabIndex = 6
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(1484, 6)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(234, 40)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'grpDaftar
        '
        Me.grpDaftar.BackColor = System.Drawing.Color.White
        Me.grpDaftar.Controls.Add(Me.dgvTransaksi)
        Me.grpDaftar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDaftar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpDaftar.Location = New System.Drawing.Point(3, 184)
        Me.grpDaftar.Name = "grpDaftar"
        Me.grpDaftar.Padding = New System.Windows.Forms.Padding(10, 8, 10, 10)
        Me.grpDaftar.Size = New System.Drawing.Size(1749, 393)
        Me.grpDaftar.TabIndex = 2
        Me.grpDaftar.TabStop = False
        Me.grpDaftar.Text = "Daftar Transaksi Penjualan"
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.AllowUserToAddRows = False
        Me.dgvTransaksi.AllowUserToDeleteRows = False
        Me.dgvTransaksi.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.dgvTransaksi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransaksi.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTransaksi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransaksi.ColumnHeadersHeight = 38
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNoNota, Me.colTanggal, Me.colKasir, Me.colMetode, Me.colTotal})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransaksi.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTransaksi.EnableHeadersVisualStyles = False
        Me.dgvTransaksi.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dgvTransaksi.Location = New System.Drawing.Point(10, 31)
        Me.dgvTransaksi.MultiSelect = False
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.ReadOnly = True
        Me.dgvTransaksi.RowHeadersVisible = False
        Me.dgvTransaksi.RowHeadersWidth = 82
        Me.dgvTransaksi.RowTemplate.Height = 30
        Me.dgvTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransaksi.Size = New System.Drawing.Size(1729, 352)
        Me.dgvTransaksi.TabIndex = 0
        '
        'colNoNota
        '
        Me.colNoNota.HeaderText = "No. Nota"
        Me.colNoNota.MinimumWidth = 10
        Me.colNoNota.Name = "colNoNota"
        Me.colNoNota.ReadOnly = True
        '
        'colTanggal
        '
        Me.colTanggal.HeaderText = "Tanggal"
        Me.colTanggal.MinimumWidth = 10
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.ReadOnly = True
        '
        'colKasir
        '
        Me.colKasir.HeaderText = "Nama Kasir"
        Me.colKasir.MinimumWidth = 10
        Me.colKasir.Name = "colKasir"
        Me.colKasir.ReadOnly = True
        '
        'colMetode
        '
        Me.colMetode.HeaderText = "Metode Pembayaran"
        Me.colMetode.MinimumWidth = 10
        Me.colMetode.Name = "colMetode"
        Me.colMetode.ReadOnly = True
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total Penjualan"
        Me.colTotal.MinimumWidth = 10
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'grpDetail
        '
        Me.grpDetail.BackColor = System.Drawing.Color.White
        Me.grpDetail.Controls.Add(Me.dgvDetail)
        Me.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDetail.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpDetail.Location = New System.Drawing.Point(3, 583)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Padding = New System.Windows.Forms.Padding(10, 8, 10, 10)
        Me.grpDetail.Size = New System.Drawing.Size(1749, 393)
        Me.grpDetail.TabIndex = 3
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Detail Barang Transaksi"
        '
        'dgvDetail
        '
        Me.dgvDetail.AllowUserToAddRows = False
        Me.dgvDetail.AllowUserToDeleteRows = False
        Me.dgvDetail.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.dgvDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetail.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDetail.ColumnHeadersHeight = 38
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colKodeBarang, Me.colNamaBarang, Me.colJumlah, Me.colHarga, Me.colSubtotal})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetail.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetail.EnableHeadersVisualStyles = False
        Me.dgvDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dgvDetail.Location = New System.Drawing.Point(10, 31)
        Me.dgvDetail.MultiSelect = False
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.ReadOnly = True
        Me.dgvDetail.RowHeadersVisible = False
        Me.dgvDetail.RowHeadersWidth = 82
        Me.dgvDetail.RowTemplate.Height = 30
        Me.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetail.Size = New System.Drawing.Size(1729, 352)
        Me.dgvDetail.TabIndex = 0
        '
        'colKodeBarang
        '
        Me.colKodeBarang.HeaderText = "Kode Barang"
        Me.colKodeBarang.MinimumWidth = 10
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.ReadOnly = True
        '
        'colNamaBarang
        '
        Me.colNamaBarang.HeaderText = "Nama Barang"
        Me.colNamaBarang.MinimumWidth = 10
        Me.colNamaBarang.Name = "colNamaBarang"
        Me.colNamaBarang.ReadOnly = True
        '
        'colJumlah
        '
        Me.colJumlah.HeaderText = "Jumlah"
        Me.colJumlah.MinimumWidth = 10
        Me.colJumlah.Name = "colJumlah"
        Me.colJumlah.ReadOnly = True
        '
        'colHarga
        '
        Me.colHarga.HeaderText = "Harga Satuan"
        Me.colHarga.MinimumWidth = 10
        Me.colHarga.Name = "colHarga"
        Me.colHarga.ReadOnly = True
        '
        'colSubtotal
        '
        Me.colSubtotal.HeaderText = "Subtotal"
        Me.colSubtotal.MinimumWidth = 10
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.ReadOnly = True
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.White
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.tlpFooter)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFooter.Location = New System.Drawing.Point(3, 982)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1749, 70)
        Me.pnlFooter.TabIndex = 4
        '
        'tlpFooter
        '
        Me.tlpFooter.ColumnCount = 5
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.85153!))
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.98036!))
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.6354708!))
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5199307!))
        Me.tlpFooter.Controls.Add(Me.lblInfo, 0, 0)
        Me.tlpFooter.Controls.Add(Me.lblTotalCaption, 1, 0)
        Me.tlpFooter.Controls.Add(Me.lblTotal, 2, 0)
        Me.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFooter.Location = New System.Drawing.Point(0, 0)
        Me.tlpFooter.Name = "tlpFooter"
        Me.tlpFooter.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.tlpFooter.RowCount = 1
        Me.tlpFooter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFooter.Size = New System.Drawing.Size(1747, 68)
        Me.tlpFooter.TabIndex = 0
        '
        'lblInfo
        '
        Me.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblInfo.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfo.Location = New System.Drawing.Point(11, 7)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(651, 54)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "Pilih transaksi untuk melihat rincian."
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalCaption
        '
        Me.lblTotalCaption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCaption.Location = New System.Drawing.Point(668, 7)
        Me.lblTotalCaption.Name = "lblTotalCaption"
        Me.lblTotalCaption.Size = New System.Drawing.Size(805, 54)
        Me.lblTotalCaption.TabIndex = 1
        Me.lblTotalCaption.Text = "Total Penjualan:"
        Me.lblTotalCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(1479, 7)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(236, 54)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Rp 0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmRiwayatPenjualan
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1755, 1055)
        Me.Controls.Add(Me.tlpRoot)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1100, 780)
        Me.Name = "FrmRiwayatPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toko Pertanian - Riwayat Penjualan"
        Me.tlpRoot.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFilter.ResumeLayout(False)
        Me.tlpFilter.ResumeLayout(False)
        Me.tlpFilter.PerformLayout()
        Me.grpDaftar.ResumeLayout(False)
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetail.ResumeLayout(False)
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.tlpFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpRoot As TableLayoutPanel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents tlpFilter As TableLayoutPanel
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents lblDari As Label
    Friend WithEvents dtpDari As DateTimePicker
    Friend WithEvents lblSampai As Label
    Friend WithEvents dtpSampai As DateTimePicker
    Friend WithEvents btnCari As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents grpDaftar As GroupBox
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents colNoNota As DataGridViewTextBoxColumn
    Friend WithEvents colTanggal As DataGridViewTextBoxColumn
    Friend WithEvents colKasir As DataGridViewTextBoxColumn
    Friend WithEvents colMetode As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents grpDetail As GroupBox
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents colKodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents colNamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents colJumlah As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents tlpFooter As TableLayoutPanel
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblTotalCaption As Label
    Friend WithEvents lblTotal As Label

End Class