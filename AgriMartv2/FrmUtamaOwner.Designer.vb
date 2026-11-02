<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtamaOwner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtamaOwner))
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnRingkasan = New System.Windows.Forms.Button()
        Me.lblVersi = New System.Windows.Forms.Label()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pnlKonten = New System.Windows.Forms.Panel()
        Me.tlpBody = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlJudul = New System.Windows.Forms.Panel()
        Me.lblPeriode = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.tlpKartu = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlKartu1 = New System.Windows.Forms.Panel()
        Me.lblOmzet = New System.Windows.Forms.Label()
        Me.lblJudulOmzet = New System.Windows.Forms.Label()
        Me.pnlKartu2 = New System.Windows.Forms.Panel()
        Me.lblModal = New System.Windows.Forms.Label()
        Me.lblJudulModal = New System.Windows.Forms.Label()
        Me.pnlKartu3 = New System.Windows.Forms.Panel()
        Me.lblLaba = New System.Windows.Forms.Label()
        Me.lblJudulLaba = New System.Windows.Forms.Label()
        Me.pnlKartu4 = New System.Windows.Forms.Panel()
        Me.lblTransaksi = New System.Windows.Forms.Label()
        Me.lblJudulTransaksi = New System.Windows.Forms.Label()
        Me.tlpTabel = New System.Windows.Forms.TableLayoutPanel()
        Me.gbRekap = New System.Windows.Forms.GroupBox()
        Me.dgvRecapHarian = New System.Windows.Forms.DataGridView()
        Me.gbStok = New System.Windows.Forms.GroupBox()
        Me.dgvStokMenipis = New System.Windows.Forms.DataGridView()
        Me.pnlTombol = New System.Windows.Forms.Panel()
        Me.btnLaporanLengkap = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlKonten.SuspendLayout()
        Me.tlpBody.SuspendLayout()
        Me.pnlJudul.SuspendLayout()
        Me.tlpKartu.SuspendLayout()
        Me.pnlKartu1.SuspendLayout()
        Me.pnlKartu2.SuspendLayout()
        Me.pnlKartu3.SuspendLayout()
        Me.pnlKartu4.SuspendLayout()
        Me.tlpTabel.SuspendLayout()
        Me.gbRekap.SuspendLayout()
        CType(Me.dgvRecapHarian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStok.SuspendLayout()
        CType(Me.dgvStokMenipis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTombol.SuspendLayout()
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
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 997)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(0, 951)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 46)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnLaporan
        '
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
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnRingkasan
        '
        Me.btnRingkasan.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(79, Byte), Integer))
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
        'pnlKonten
        '
        Me.pnlKonten.Controls.Add(Me.tlpBody)
        Me.pnlKonten.Controls.Add(Me.pnlHeader)
        Me.pnlKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKonten.Location = New System.Drawing.Point(200, 0)
        Me.pnlKonten.Name = "pnlKonten"
        Me.pnlKonten.Size = New System.Drawing.Size(1443, 997)
        Me.pnlKonten.TabIndex = 1
        '
        'tlpBody
        '
        Me.tlpBody.ColumnCount = 1
        Me.tlpBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpBody.Controls.Add(Me.pnlJudul, 0, 0)
        Me.tlpBody.Controls.Add(Me.tlpKartu, 0, 1)
        Me.tlpBody.Controls.Add(Me.tlpTabel, 0, 2)
        Me.tlpBody.Controls.Add(Me.pnlTombol, 0, 3)
        Me.tlpBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBody.Location = New System.Drawing.Point(0, 40)
        Me.tlpBody.Name = "tlpBody"
        Me.tlpBody.Padding = New System.Windows.Forms.Padding(20, 10, 20, 16)
        Me.tlpBody.RowCount = 4
        Me.tlpBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpBody.Size = New System.Drawing.Size(1443, 957)
        Me.tlpBody.TabIndex = 1
        '
        'pnlJudul
        '
        Me.pnlJudul.Controls.Add(Me.lblPeriode)
        Me.pnlJudul.Controls.Add(Me.lblJudul)
        Me.pnlJudul.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlJudul.Location = New System.Drawing.Point(20, 10)
        Me.pnlJudul.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlJudul.Name = "pnlJudul"
        Me.pnlJudul.Size = New System.Drawing.Size(1403, 44)
        Me.pnlJudul.TabIndex = 0
        '
        'lblPeriode
        '
        Me.lblPeriode.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPeriode.ForeColor = System.Drawing.Color.DimGray
        Me.lblPeriode.Location = New System.Drawing.Point(983, 0)
        Me.lblPeriode.Name = "lblPeriode"
        Me.lblPeriode.Size = New System.Drawing.Size(420, 44)
        Me.lblPeriode.TabIndex = 1
        Me.lblPeriode.Text = "Periode: 01 Nov 2026 - 02 Nov 2026"
        Me.lblPeriode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(0, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(149, 37)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Ringkasan"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpKartu
        '
        Me.tlpKartu.ColumnCount = 4
        Me.tlpKartu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpKartu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpKartu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpKartu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpKartu.Controls.Add(Me.pnlKartu1, 0, 0)
        Me.tlpKartu.Controls.Add(Me.pnlKartu2, 1, 0)
        Me.tlpKartu.Controls.Add(Me.pnlKartu3, 2, 0)
        Me.tlpKartu.Controls.Add(Me.pnlKartu4, 3, 0)
        Me.tlpKartu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpKartu.Location = New System.Drawing.Point(20, 54)
        Me.tlpKartu.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpKartu.Name = "tlpKartu"
        Me.tlpKartu.RowCount = 1
        Me.tlpKartu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpKartu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpKartu.Size = New System.Drawing.Size(1403, 100)
        Me.tlpKartu.TabIndex = 1
        '
        'pnlKartu1
        '
        Me.pnlKartu1.BackColor = System.Drawing.Color.White
        Me.pnlKartu1.Controls.Add(Me.lblOmzet)
        Me.pnlKartu1.Controls.Add(Me.lblJudulOmzet)
        Me.pnlKartu1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKartu1.Location = New System.Drawing.Point(0, 0)
        Me.pnlKartu1.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.pnlKartu1.Name = "pnlKartu1"
        Me.pnlKartu1.Padding = New System.Windows.Forms.Padding(14, 10, 14, 10)
        Me.pnlKartu1.Size = New System.Drawing.Size(338, 100)
        Me.pnlKartu1.TabIndex = 0
        '
        'lblOmzet
        '
        Me.lblOmzet.AutoSize = True
        Me.lblOmzet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOmzet.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOmzet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblOmzet.Location = New System.Drawing.Point(14, 33)
        Me.lblOmzet.Name = "lblOmzet"
        Me.lblOmzet.Size = New System.Drawing.Size(175, 41)
        Me.lblOmzet.TabIndex = 0
        Me.lblOmzet.Text = "Rp 380.000"
        Me.lblOmzet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJudulOmzet
        '
        Me.lblJudulOmzet.AutoSize = True
        Me.lblJudulOmzet.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblJudulOmzet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblJudulOmzet.Location = New System.Drawing.Point(14, 10)
        Me.lblJudulOmzet.Name = "lblJudulOmzet"
        Me.lblJudulOmzet.Size = New System.Drawing.Size(61, 23)
        Me.lblJudulOmzet.TabIndex = 1
        Me.lblJudulOmzet.Text = "Omzet"
        '
        'pnlKartu2
        '
        Me.pnlKartu2.BackColor = System.Drawing.Color.White
        Me.pnlKartu2.Controls.Add(Me.lblModal)
        Me.pnlKartu2.Controls.Add(Me.lblJudulModal)
        Me.pnlKartu2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKartu2.Location = New System.Drawing.Point(350, 0)
        Me.pnlKartu2.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.pnlKartu2.Name = "pnlKartu2"
        Me.pnlKartu2.Padding = New System.Windows.Forms.Padding(14, 10, 14, 10)
        Me.pnlKartu2.Size = New System.Drawing.Size(338, 100)
        Me.pnlKartu2.TabIndex = 1
        '
        'lblModal
        '
        Me.lblModal.AutoSize = True
        Me.lblModal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblModal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblModal.Location = New System.Drawing.Point(14, 33)
        Me.lblModal.Name = "lblModal"
        Me.lblModal.Size = New System.Drawing.Size(175, 41)
        Me.lblModal.TabIndex = 0
        Me.lblModal.Text = "Rp 338.000"
        Me.lblModal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJudulModal
        '
        Me.lblJudulModal.AutoSize = True
        Me.lblJudulModal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblJudulModal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblJudulModal.Location = New System.Drawing.Point(14, 10)
        Me.lblJudulModal.Name = "lblJudulModal"
        Me.lblJudulModal.Size = New System.Drawing.Size(211, 23)
        Me.lblJudulModal.TabIndex = 1
        Me.lblJudulModal.Text = "Total modal barang terjual"
        '
        'pnlKartu3
        '
        Me.pnlKartu3.BackColor = System.Drawing.Color.White
        Me.pnlKartu3.Controls.Add(Me.lblLaba)
        Me.pnlKartu3.Controls.Add(Me.lblJudulLaba)
        Me.pnlKartu3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKartu3.Location = New System.Drawing.Point(700, 0)
        Me.pnlKartu3.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.pnlKartu3.Name = "pnlKartu3"
        Me.pnlKartu3.Padding = New System.Windows.Forms.Padding(14, 10, 14, 10)
        Me.pnlKartu3.Size = New System.Drawing.Size(338, 100)
        Me.pnlKartu3.TabIndex = 2
        '
        'lblLaba
        '
        Me.lblLaba.AutoSize = True
        Me.lblLaba.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLaba.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLaba.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblLaba.Location = New System.Drawing.Point(14, 33)
        Me.lblLaba.Name = "lblLaba"
        Me.lblLaba.Size = New System.Drawing.Size(158, 41)
        Me.lblLaba.TabIndex = 1
        Me.lblLaba.Text = "Rp 42.000"
        Me.lblLaba.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJudulLaba
        '
        Me.lblJudulLaba.AutoSize = True
        Me.lblJudulLaba.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblJudulLaba.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblJudulLaba.Location = New System.Drawing.Point(14, 10)
        Me.lblJudulLaba.Name = "lblJudulLaba"
        Me.lblJudulLaba.Size = New System.Drawing.Size(93, 23)
        Me.lblJudulLaba.TabIndex = 0
        Me.lblJudulLaba.Text = "Laba Kotor"
        '
        'pnlKartu4
        '
        Me.pnlKartu4.BackColor = System.Drawing.Color.White
        Me.pnlKartu4.Controls.Add(Me.lblTransaksi)
        Me.pnlKartu4.Controls.Add(Me.lblJudulTransaksi)
        Me.pnlKartu4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKartu4.Location = New System.Drawing.Point(1050, 0)
        Me.pnlKartu4.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.pnlKartu4.Name = "pnlKartu4"
        Me.pnlKartu4.Padding = New System.Windows.Forms.Padding(14, 10, 14, 10)
        Me.pnlKartu4.Size = New System.Drawing.Size(341, 100)
        Me.pnlKartu4.TabIndex = 3
        '
        'lblTransaksi
        '
        Me.lblTransaksi.AutoSize = True
        Me.lblTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTransaksi.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblTransaksi.Location = New System.Drawing.Point(14, 33)
        Me.lblTransaksi.Name = "lblTransaksi"
        Me.lblTransaksi.Size = New System.Drawing.Size(35, 41)
        Me.lblTransaksi.TabIndex = 1
        Me.lblTransaksi.Text = "2"
        Me.lblTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJudulTransaksi
        '
        Me.lblJudulTransaksi.AutoSize = True
        Me.lblJudulTransaksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblJudulTransaksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblJudulTransaksi.Location = New System.Drawing.Point(14, 10)
        Me.lblJudulTransaksi.Name = "lblJudulTransaksi"
        Me.lblJudulTransaksi.Size = New System.Drawing.Size(137, 23)
        Me.lblJudulTransaksi.TabIndex = 0
        Me.lblJudulTransaksi.Text = "Jumlah Transaksi"
        '
        'tlpTabel
        '
        Me.tlpTabel.ColumnCount = 2
        Me.tlpTabel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpTabel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpTabel.Controls.Add(Me.gbRekap, 0, 0)
        Me.tlpTabel.Controls.Add(Me.gbStok, 1, 0)
        Me.tlpTabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTabel.Location = New System.Drawing.Point(20, 162)
        Me.tlpTabel.Margin = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.tlpTabel.Name = "tlpTabel"
        Me.tlpTabel.RowCount = 1
        Me.tlpTabel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTabel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 721.0!))
        Me.tlpTabel.Size = New System.Drawing.Size(1403, 721)
        Me.tlpTabel.TabIndex = 2
        '
        'gbRekap
        '
        Me.gbRekap.BackColor = System.Drawing.Color.White
        Me.gbRekap.Controls.Add(Me.dgvRecapHarian)
        Me.gbRekap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbRekap.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRekap.Location = New System.Drawing.Point(0, 0)
        Me.gbRekap.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.gbRekap.Name = "gbRekap"
        Me.gbRekap.Padding = New System.Windows.Forms.Padding(8, 6, 8, 8)
        Me.gbRekap.Size = New System.Drawing.Size(829, 721)
        Me.gbRekap.TabIndex = 0
        Me.gbRekap.TabStop = False
        Me.gbRekap.Text = "Recap penjualan harian"
        '
        'dgvRecapHarian
        '
        Me.dgvRecapHarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecapHarian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecapHarian.Location = New System.Drawing.Point(8, 31)
        Me.dgvRecapHarian.Name = "dgvRecapHarian"
        Me.dgvRecapHarian.RowHeadersWidth = 62
        Me.dgvRecapHarian.RowTemplate.Height = 28
        Me.dgvRecapHarian.Size = New System.Drawing.Size(813, 682)
        Me.dgvRecapHarian.TabIndex = 0
        '
        'gbStok
        '
        Me.gbStok.BackColor = System.Drawing.Color.White
        Me.gbStok.Controls.Add(Me.dgvStokMenipis)
        Me.gbStok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbStok.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStok.Location = New System.Drawing.Point(841, 0)
        Me.gbStok.Margin = New System.Windows.Forms.Padding(0)
        Me.gbStok.Name = "gbStok"
        Me.gbStok.Padding = New System.Windows.Forms.Padding(8, 6, 8, 8)
        Me.gbStok.Size = New System.Drawing.Size(562, 721)
        Me.gbStok.TabIndex = 1
        Me.gbStok.TabStop = False
        Me.gbStok.Text = "Stok Menipis (<= 10)"
        '
        'dgvStokMenipis
        '
        Me.dgvStokMenipis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStokMenipis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStokMenipis.Location = New System.Drawing.Point(8, 31)
        Me.dgvStokMenipis.Name = "dgvStokMenipis"
        Me.dgvStokMenipis.RowHeadersWidth = 62
        Me.dgvStokMenipis.RowTemplate.Height = 28
        Me.dgvStokMenipis.Size = New System.Drawing.Size(546, 682)
        Me.dgvStokMenipis.TabIndex = 0
        '
        'pnlTombol
        '
        Me.pnlTombol.Controls.Add(Me.btnLaporanLengkap)
        Me.pnlTombol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTombol.Location = New System.Drawing.Point(20, 891)
        Me.pnlTombol.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTombol.Name = "pnlTombol"
        Me.pnlTombol.Size = New System.Drawing.Size(1403, 50)
        Me.pnlTombol.TabIndex = 3
        '
        'btnLaporanLengkap
        '
        Me.btnLaporanLengkap.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLaporanLengkap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaporanLengkap.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLaporanLengkap.FlatAppearance.BorderSize = 0
        Me.btnLaporanLengkap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporanLengkap.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporanLengkap.ForeColor = System.Drawing.Color.White
        Me.btnLaporanLengkap.Location = New System.Drawing.Point(1183, 0)
        Me.btnLaporanLengkap.Name = "btnLaporanLengkap"
        Me.btnLaporanLengkap.Size = New System.Drawing.Size(220, 50)
        Me.btnLaporanLengkap.TabIndex = 0
        Me.btnLaporanLengkap.Text = "Lihat Laporan Lengkap"
        Me.btnLaporanLengkap.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblUser)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1443, 40)
        Me.pnlHeader.TabIndex = 0
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblUser.Location = New System.Drawing.Point(1123, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Padding = New System.Windows.Forms.Padding(0, 0, 18, 0)
        Me.lblUser.Size = New System.Drawing.Size(320, 40)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Owner | Owner"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmUtamaOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1643, 997)
        Me.Controls.Add(Me.pnlKonten)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1247, 930)
        Me.Name = "FrmUtamaOwner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toko Pertanian - Ringkasan Owner"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlKonten.ResumeLayout(False)
        Me.tlpBody.ResumeLayout(False)
        Me.pnlJudul.ResumeLayout(False)
        Me.pnlJudul.PerformLayout()
        Me.tlpKartu.ResumeLayout(False)
        Me.pnlKartu1.ResumeLayout(False)
        Me.pnlKartu1.PerformLayout()
        Me.pnlKartu2.ResumeLayout(False)
        Me.pnlKartu2.PerformLayout()
        Me.pnlKartu3.ResumeLayout(False)
        Me.pnlKartu3.PerformLayout()
        Me.pnlKartu4.ResumeLayout(False)
        Me.pnlKartu4.PerformLayout()
        Me.tlpTabel.ResumeLayout(False)
        Me.gbRekap.ResumeLayout(False)
        CType(Me.dgvRecapHarian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStok.ResumeLayout(False)
        CType(Me.dgvStokMenipis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTombol.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblLogo As Label
    Friend WithEvents lblVersi As Label
    Friend WithEvents btnRingkasan As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents tlpBody As TableLayoutPanel
    Friend WithEvents pnlJudul As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblPeriode As Label
    Friend WithEvents tlpKartu As TableLayoutPanel
    Friend WithEvents pnlKartu1 As Panel
    Friend WithEvents pnlKartu2 As Panel
    Friend WithEvents pnlKartu3 As Panel
    Friend WithEvents pnlKartu4 As Panel
    Friend WithEvents lblOmzet As Label
    Friend WithEvents lblJudulOmzet As Label
    Friend WithEvents lblModal As Label
    Friend WithEvents lblJudulModal As Label
    Friend WithEvents lblJudulLaba As Label
    Friend WithEvents lblLaba As Label
    Friend WithEvents lblJudulTransaksi As Label
    Friend WithEvents lblTransaksi As Label
    Friend WithEvents tlpTabel As TableLayoutPanel
    Friend WithEvents gbRekap As GroupBox
    Friend WithEvents gbStok As GroupBox
    Friend WithEvents dgvRecapHarian As DataGridView
    Friend WithEvents dgvStokMenipis As DataGridView
    Friend WithEvents pnlTombol As Panel
    Friend WithEvents btnLaporanLengkap As Button
End Class