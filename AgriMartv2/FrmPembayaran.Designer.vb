Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPembayaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPembayaran))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpInformasi = New System.Windows.Forms.GroupBox()
        Me.tlpInformasi = New System.Windows.Forms.TableLayoutPanel()
        Me.flpNoNota = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblNoNotaCaption = New System.Windows.Forms.Label()
        Me.lblNoNotaValue = New System.Windows.Forms.Label()
        Me.flpTanggal = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTanggalCaption = New System.Windows.Forms.Label()
        Me.lblTanggalValue = New System.Windows.Forms.Label()
        Me.flpKasir = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblKasirCaption = New System.Windows.Forms.Label()
        Me.lblKasirValue = New System.Windows.Forms.Label()
        Me.tlpKonten = New System.Windows.Forms.TableLayoutPanel()
        Me.grpDetail = New System.Windows.Forms.GroupBox()
        Me.dgvDetailBarang = New System.Windows.Forms.DataGridView()
        Me.grpPembayaran = New System.Windows.Forms.GroupBox()
        Me.tlpPembayaran = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalCaption = New System.Windows.Forms.Label()
        Me.lblTotalValue = New System.Windows.Forms.Label()
        Me.lblMetodeCaption = New System.Windows.Forms.Label()
        Me.cmbMetodePembayaran = New System.Windows.Forms.ComboBox()
        Me.lblUangBayarCaption = New System.Windows.Forms.Label()
        Me.txtUangBayar = New System.Windows.Forms.TextBox()
        Me.lblKembalianCaption = New System.Windows.Forms.Label()
        Me.lblKembalianValue = New System.Windows.Forms.Label()
        Me.lblPetunjuk = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.tlpFooter = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnKonfirmasi = New System.Windows.Forms.Button()
        Me.tlpRoot = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        Me.grpInformasi.SuspendLayout()
        Me.tlpInformasi.SuspendLayout()
        Me.flpNoNota.SuspendLayout()
        Me.flpTanggal.SuspendLayout()
        Me.flpKasir.SuspendLayout()
        Me.tlpKonten.SuspendLayout()
        Me.grpDetail.SuspendLayout()
        CType(Me.dgvDetailBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPembayaran.SuspendLayout()
        Me.tlpPembayaran.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.tlpFooter.SuspendLayout()
        Me.tlpRoot.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1746, 92)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(24, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 57)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "PEMBAYARAN"
        '
        'grpInformasi
        '
        Me.grpInformasi.BackColor = System.Drawing.Color.White
        Me.grpInformasi.Controls.Add(Me.tlpInformasi)
        Me.grpInformasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpInformasi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpInformasi.Location = New System.Drawing.Point(3, 101)
        Me.grpInformasi.Name = "grpInformasi"
        Me.grpInformasi.Padding = New System.Windows.Forms.Padding(10, 8, 10, 8)
        Me.grpInformasi.Size = New System.Drawing.Size(1746, 117)
        Me.grpInformasi.TabIndex = 1
        Me.grpInformasi.TabStop = False
        Me.grpInformasi.Text = "Informasi Transaksi"
        '
        'tlpInformasi
        '
        Me.tlpInformasi.ColumnCount = 3
        Me.tlpInformasi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpInformasi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.tlpInformasi.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.tlpInformasi.Controls.Add(Me.flpNoNota, 0, 0)
        Me.tlpInformasi.Controls.Add(Me.flpTanggal, 1, 0)
        Me.tlpInformasi.Controls.Add(Me.flpKasir, 2, 0)
        Me.tlpInformasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpInformasi.Location = New System.Drawing.Point(10, 34)
        Me.tlpInformasi.Name = "tlpInformasi"
        Me.tlpInformasi.RowCount = 1
        Me.tlpInformasi.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInformasi.Size = New System.Drawing.Size(1726, 75)
        Me.tlpInformasi.TabIndex = 0
        '
        'flpNoNota
        '
        Me.flpNoNota.Controls.Add(Me.lblNoNotaCaption)
        Me.flpNoNota.Controls.Add(Me.lblNoNotaValue)
        Me.flpNoNota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpNoNota.Location = New System.Drawing.Point(3, 3)
        Me.flpNoNota.Name = "flpNoNota"
        Me.flpNoNota.Padding = New System.Windows.Forms.Padding(8, 8, 4, 4)
        Me.flpNoNota.Size = New System.Drawing.Size(569, 69)
        Me.flpNoNota.TabIndex = 0
        Me.flpNoNota.WrapContents = False
        '
        'lblNoNotaCaption
        '
        Me.lblNoNotaCaption.AutoSize = True
        Me.lblNoNotaCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNoNotaCaption.Location = New System.Drawing.Point(8, 13)
        Me.lblNoNotaCaption.Margin = New System.Windows.Forms.Padding(0, 5, 7, 0)
        Me.lblNoNotaCaption.Name = "lblNoNotaCaption"
        Me.lblNoNotaCaption.Size = New System.Drawing.Size(98, 28)
        Me.lblNoNotaCaption.TabIndex = 0
        Me.lblNoNotaCaption.Text = "No. Nota"
        '
        'lblNoNotaValue
        '
        Me.lblNoNotaValue.AutoSize = True
        Me.lblNoNotaValue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNoNotaValue.Location = New System.Drawing.Point(113, 13)
        Me.lblNoNotaValue.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblNoNotaValue.Name = "lblNoNotaValue"
        Me.lblNoNotaValue.Size = New System.Drawing.Size(20, 28)
        Me.lblNoNotaValue.TabIndex = 1
        Me.lblNoNotaValue.Text = "-"
        '
        'flpTanggal
        '
        Me.flpTanggal.Controls.Add(Me.lblTanggalCaption)
        Me.flpTanggal.Controls.Add(Me.lblTanggalValue)
        Me.flpTanggal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpTanggal.Location = New System.Drawing.Point(578, 3)
        Me.flpTanggal.Name = "flpTanggal"
        Me.flpTanggal.Padding = New System.Windows.Forms.Padding(8, 8, 4, 4)
        Me.flpTanggal.Size = New System.Drawing.Size(569, 69)
        Me.flpTanggal.TabIndex = 1
        Me.flpTanggal.WrapContents = False
        '
        'lblTanggalCaption
        '
        Me.lblTanggalCaption.AutoSize = True
        Me.lblTanggalCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTanggalCaption.Location = New System.Drawing.Point(8, 13)
        Me.lblTanggalCaption.Margin = New System.Windows.Forms.Padding(0, 5, 7, 0)
        Me.lblTanggalCaption.Name = "lblTanggalCaption"
        Me.lblTanggalCaption.Size = New System.Drawing.Size(86, 28)
        Me.lblTanggalCaption.TabIndex = 0
        Me.lblTanggalCaption.Text = "Tanggal"
        '
        'lblTanggalValue
        '
        Me.lblTanggalValue.AutoSize = True
        Me.lblTanggalValue.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTanggalValue.Location = New System.Drawing.Point(101, 13)
        Me.lblTanggalValue.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblTanggalValue.Name = "lblTanggalValue"
        Me.lblTanggalValue.Size = New System.Drawing.Size(20, 28)
        Me.lblTanggalValue.TabIndex = 1
        Me.lblTanggalValue.Text = "-"
        '
        'flpKasir
        '
        Me.flpKasir.Controls.Add(Me.lblKasirCaption)
        Me.flpKasir.Controls.Add(Me.lblKasirValue)
        Me.flpKasir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpKasir.Location = New System.Drawing.Point(1153, 3)
        Me.flpKasir.Name = "flpKasir"
        Me.flpKasir.Padding = New System.Windows.Forms.Padding(8, 8, 4, 4)
        Me.flpKasir.Size = New System.Drawing.Size(570, 69)
        Me.flpKasir.TabIndex = 2
        Me.flpKasir.WrapContents = False
        '
        'lblKasirCaption
        '
        Me.lblKasirCaption.AutoSize = True
        Me.lblKasirCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblKasirCaption.Location = New System.Drawing.Point(8, 13)
        Me.lblKasirCaption.Margin = New System.Windows.Forms.Padding(0, 5, 7, 0)
        Me.lblKasirCaption.Name = "lblKasirCaption"
        Me.lblKasirCaption.Size = New System.Drawing.Size(59, 28)
        Me.lblKasirCaption.TabIndex = 0
        Me.lblKasirCaption.Text = "Kasir"
        '
        'lblKasirValue
        '
        Me.lblKasirValue.AutoSize = True
        Me.lblKasirValue.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblKasirValue.Location = New System.Drawing.Point(74, 13)
        Me.lblKasirValue.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblKasirValue.Name = "lblKasirValue"
        Me.lblKasirValue.Size = New System.Drawing.Size(20, 28)
        Me.lblKasirValue.TabIndex = 1
        Me.lblKasirValue.Text = "-"
        '
        'tlpKonten
        '
        Me.tlpKonten.ColumnCount = 2
        Me.tlpKonten.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.tlpKonten.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tlpKonten.Controls.Add(Me.grpDetail, 0, 0)
        Me.tlpKonten.Controls.Add(Me.grpPembayaran, 1, 0)
        Me.tlpKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpKonten.Location = New System.Drawing.Point(3, 224)
        Me.tlpKonten.Name = "tlpKonten"
        Me.tlpKonten.RowCount = 1
        Me.tlpKonten.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpKonten.Size = New System.Drawing.Size(1746, 741)
        Me.tlpKonten.TabIndex = 2
        '
        'grpDetail
        '
        Me.grpDetail.BackColor = System.Drawing.Color.White
        Me.grpDetail.Controls.Add(Me.dgvDetailBarang)
        Me.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDetail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpDetail.Location = New System.Drawing.Point(3, 3)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Padding = New System.Windows.Forms.Padding(10, 8, 10, 10)
        Me.grpDetail.Size = New System.Drawing.Size(1128, 735)
        Me.grpDetail.TabIndex = 0
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Ringkasan Barang"
        '
        'dgvDetailBarang
        '
        Me.dgvDetailBarang.AllowUserToAddRows = False
        Me.dgvDetailBarang.AllowUserToDeleteRows = False
        Me.dgvDetailBarang.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.dgvDetailBarang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetailBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetailBarang.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetailBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetailBarang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetailBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetailBarang.ColumnHeadersHeight = 38
        Me.dgvDetailBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetailBarang.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDetailBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetailBarang.EnableHeadersVisualStyles = False
        Me.dgvDetailBarang.GridColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dgvDetailBarang.Location = New System.Drawing.Point(10, 34)
        Me.dgvDetailBarang.MultiSelect = False
        Me.dgvDetailBarang.Name = "dgvDetailBarang"
        Me.dgvDetailBarang.ReadOnly = True
        Me.dgvDetailBarang.RowHeadersVisible = False
        Me.dgvDetailBarang.RowHeadersWidth = 82
        Me.dgvDetailBarang.RowTemplate.Height = 32
        Me.dgvDetailBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetailBarang.Size = New System.Drawing.Size(1108, 691)
        Me.dgvDetailBarang.TabIndex = 0
        '
        'grpPembayaran
        '
        Me.grpPembayaran.BackColor = System.Drawing.Color.White
        Me.grpPembayaran.Controls.Add(Me.tlpPembayaran)
        Me.grpPembayaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpPembayaran.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpPembayaran.Location = New System.Drawing.Point(1137, 3)
        Me.grpPembayaran.Name = "grpPembayaran"
        Me.grpPembayaran.Padding = New System.Windows.Forms.Padding(12, 8, 12, 10)
        Me.grpPembayaran.Size = New System.Drawing.Size(606, 735)
        Me.grpPembayaran.TabIndex = 1
        Me.grpPembayaran.TabStop = False
        Me.grpPembayaran.Text = "Rincian Pembayaran"
        '
        'tlpPembayaran
        '
        Me.tlpPembayaran.ColumnCount = 1
        Me.tlpPembayaran.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPembayaran.Controls.Add(Me.lblTotalCaption, 0, 0)
        Me.tlpPembayaran.Controls.Add(Me.lblTotalValue, 0, 1)
        Me.tlpPembayaran.Controls.Add(Me.lblMetodeCaption, 0, 2)
        Me.tlpPembayaran.Controls.Add(Me.cmbMetodePembayaran, 0, 3)
        Me.tlpPembayaran.Controls.Add(Me.lblUangBayarCaption, 0, 4)
        Me.tlpPembayaran.Controls.Add(Me.txtUangBayar, 0, 5)
        Me.tlpPembayaran.Controls.Add(Me.lblKembalianCaption, 0, 6)
        Me.tlpPembayaran.Controls.Add(Me.lblKembalianValue, 0, 7)
        Me.tlpPembayaran.Controls.Add(Me.lblPetunjuk, 0, 8)
        Me.tlpPembayaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPembayaran.Location = New System.Drawing.Point(12, 34)
        Me.tlpPembayaran.Name = "tlpPembayaran"
        Me.tlpPembayaran.RowCount = 9
        Me.tlpPembayaran.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.tlpPembayaran.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.tlpPembayaran.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.tlpPembayaran.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.tlpPembayaran.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.tlpPembayaran.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.tlpPembayaran.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.tlpPembayaran.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.tlpPembayaran.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.tlpPembayaran.Size = New System.Drawing.Size(582, 691)
        Me.tlpPembayaran.TabIndex = 0
        '
        'lblTotalCaption
        '
        Me.lblTotalCaption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCaption.Location = New System.Drawing.Point(3, 0)
        Me.lblTotalCaption.Name = "lblTotalCaption"
        Me.lblTotalCaption.Size = New System.Drawing.Size(576, 62)
        Me.lblTotalCaption.TabIndex = 0
        Me.lblTotalCaption.Text = "Total Belanja"
        Me.lblTotalCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalValue
        '
        Me.lblTotalValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalValue.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalValue.Location = New System.Drawing.Point(3, 62)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(576, 110)
        Me.lblTotalValue.TabIndex = 1
        Me.lblTotalValue.Text = "Rp 0"
        Me.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMetodeCaption
        '
        Me.lblMetodeCaption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMetodeCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMetodeCaption.Location = New System.Drawing.Point(3, 172)
        Me.lblMetodeCaption.Name = "lblMetodeCaption"
        Me.lblMetodeCaption.Size = New System.Drawing.Size(576, 62)
        Me.lblMetodeCaption.TabIndex = 2
        Me.lblMetodeCaption.Text = "Metode Pembayaran"
        Me.lblMetodeCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbMetodePembayaran
        '
        Me.cmbMetodePembayaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMetodePembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMetodePembayaran.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMetodePembayaran.FormattingEnabled = True
        Me.cmbMetodePembayaran.Location = New System.Drawing.Point(0, 238)
        Me.cmbMetodePembayaran.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.cmbMetodePembayaran.Name = "cmbMetodePembayaran"
        Me.cmbMetodePembayaran.Size = New System.Drawing.Size(582, 36)
        Me.cmbMetodePembayaran.TabIndex = 3
        '
        'lblUangBayarCaption
        '
        Me.lblUangBayarCaption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUangBayarCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUangBayarCaption.Location = New System.Drawing.Point(3, 316)
        Me.lblUangBayarCaption.Name = "lblUangBayarCaption"
        Me.lblUangBayarCaption.Size = New System.Drawing.Size(576, 62)
        Me.lblUangBayarCaption.TabIndex = 4
        Me.lblUangBayarCaption.Text = "Uang Bayar"
        Me.lblUangBayarCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUangBayar
        '
        Me.txtUangBayar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUangBayar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUangBayar.Location = New System.Drawing.Point(0, 382)
        Me.txtUangBayar.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.txtUangBayar.Name = "txtUangBayar"
        Me.txtUangBayar.Size = New System.Drawing.Size(582, 39)
        Me.txtUangBayar.TabIndex = 5
        Me.txtUangBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblKembalianCaption
        '
        Me.lblKembalianCaption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKembalianCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblKembalianCaption.Location = New System.Drawing.Point(3, 460)
        Me.lblKembalianCaption.Name = "lblKembalianCaption"
        Me.lblKembalianCaption.Size = New System.Drawing.Size(576, 62)
        Me.lblKembalianCaption.TabIndex = 6
        Me.lblKembalianCaption.Text = "Kembalian"
        Me.lblKembalianCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKembalianValue
        '
        Me.lblKembalianValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKembalianValue.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblKembalianValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblKembalianValue.Location = New System.Drawing.Point(3, 522)
        Me.lblKembalianValue.Name = "lblKembalianValue"
        Me.lblKembalianValue.Size = New System.Drawing.Size(576, 82)
        Me.lblKembalianValue.TabIndex = 7
        Me.lblKembalianValue.Text = "Rp 0"
        Me.lblKembalianValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPetunjuk
        '
        Me.lblPetunjuk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPetunjuk.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblPetunjuk.ForeColor = System.Drawing.Color.DimGray
        Me.lblPetunjuk.Location = New System.Drawing.Point(3, 604)
        Me.lblPetunjuk.Name = "lblPetunjuk"
        Me.lblPetunjuk.Size = New System.Drawing.Size(576, 87)
        Me.lblPetunjuk.TabIndex = 8
        Me.lblPetunjuk.Text = "Masukkan nominal uang yang diterima dari pelanggan."
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.White
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.tlpFooter)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFooter.Location = New System.Drawing.Point(3, 971)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1746, 76)
        Me.pnlFooter.TabIndex = 3
        '
        'tlpFooter
        '
        Me.tlpFooter.ColumnCount = 3
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.0!))
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0!))
        Me.tlpFooter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0!))
        Me.tlpFooter.Controls.Add(Me.lblStatus, 0, 0)
        Me.tlpFooter.Controls.Add(Me.btnBatal, 1, 0)
        Me.tlpFooter.Controls.Add(Me.btnKonfirmasi, 2, 0)
        Me.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFooter.Location = New System.Drawing.Point(0, 0)
        Me.tlpFooter.Name = "tlpFooter"
        Me.tlpFooter.Padding = New System.Windows.Forms.Padding(8)
        Me.tlpFooter.RowCount = 1
        Me.tlpFooter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFooter.Size = New System.Drawing.Size(1744, 74)
        Me.tlpFooter.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.DimGray
        Me.lblStatus.Location = New System.Drawing.Point(11, 8)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(996, 58)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Siap menerima pembayaran."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBatal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(1016, 14)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(316, 46)
        Me.btnBatal.TabIndex = 1
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnKonfirmasi
        '
        Me.btnKonfirmasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnKonfirmasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKonfirmasi.FlatAppearance.BorderSize = 0
        Me.btnKonfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKonfirmasi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKonfirmasi.ForeColor = System.Drawing.Color.White
        Me.btnKonfirmasi.Location = New System.Drawing.Point(1344, 14)
        Me.btnKonfirmasi.Margin = New System.Windows.Forms.Padding(6)
        Me.btnKonfirmasi.Name = "btnKonfirmasi"
        Me.btnKonfirmasi.Size = New System.Drawing.Size(386, 46)
        Me.btnKonfirmasi.TabIndex = 2
        Me.btnKonfirmasi.Text = "KONFIRMASI BAYAR"
        Me.btnKonfirmasi.UseVisualStyleBackColor = False
        '
        'tlpRoot
        '
        Me.tlpRoot.ColumnCount = 1
        Me.tlpRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRoot.Controls.Add(Me.pnlHeader, 0, 0)
        Me.tlpRoot.Controls.Add(Me.grpInformasi, 0, 1)
        Me.tlpRoot.Controls.Add(Me.tlpKonten, 0, 2)
        Me.tlpRoot.Controls.Add(Me.pnlFooter, 0, 3)
        Me.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRoot.Location = New System.Drawing.Point(0, 0)
        Me.tlpRoot.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpRoot.Name = "tlpRoot"
        Me.tlpRoot.RowCount = 4
        Me.tlpRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tlpRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123.0!))
        Me.tlpRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.tlpRoot.Size = New System.Drawing.Size(1752, 1050)
        Me.tlpRoot.TabIndex = 0
        '
        'FrmPembayaran
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1752, 1050)
        Me.Controls.Add(Me.tlpRoot)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "FrmPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toko Pertanian - Pembayaran"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpInformasi.ResumeLayout(False)
        Me.tlpInformasi.ResumeLayout(False)
        Me.flpNoNota.ResumeLayout(False)
        Me.flpNoNota.PerformLayout()
        Me.flpTanggal.ResumeLayout(False)
        Me.flpTanggal.PerformLayout()
        Me.flpKasir.ResumeLayout(False)
        Me.flpKasir.PerformLayout()
        Me.tlpKonten.ResumeLayout(False)
        Me.grpDetail.ResumeLayout(False)
        CType(Me.dgvDetailBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPembayaran.ResumeLayout(False)
        Me.tlpPembayaran.ResumeLayout(False)
        Me.tlpPembayaran.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.tlpFooter.ResumeLayout(False)
        Me.tlpRoot.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpInformasi As GroupBox
    Friend WithEvents lblNoNotaCaption As Label
    Friend WithEvents lblNoNotaValue As Label
    Friend WithEvents lblTanggalCaption As Label
    Friend WithEvents lblTanggalValue As Label
    Friend WithEvents lblKasirCaption As Label
    Friend WithEvents lblKasirValue As Label
    Friend WithEvents grpDetail As GroupBox
    Friend WithEvents dgvDetailBarang As DataGridView
    Friend WithEvents colKodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents colNamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents colJumlah As DataGridViewTextBoxColumn
    Friend WithEvents colHargaJual As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents grpPembayaran As GroupBox
    Friend WithEvents lblTotalCaption As Label
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents lblMetodeCaption As Label
    Friend WithEvents cmbMetodePembayaran As ComboBox
    Friend WithEvents lblUangBayarCaption As Label
    Friend WithEvents txtUangBayar As TextBox
    Friend WithEvents lblKembalianCaption As Label
    Friend WithEvents lblKembalianValue As Label
    Friend WithEvents lblPetunjuk As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKonfirmasi As Button
    Friend WithEvents tlpRoot As TableLayoutPanel
    Friend WithEvents tlpInformasi As TableLayoutPanel
    Friend WithEvents flpNoNota As FlowLayoutPanel
    Friend WithEvents flpTanggal As FlowLayoutPanel
    Friend WithEvents flpKasir As FlowLayoutPanel
    Friend WithEvents tlpKonten As TableLayoutPanel
    Friend WithEvents tlpPembayaran As TableLayoutPanel
    Friend WithEvents tlpFooter As TableLayoutPanel

End Class