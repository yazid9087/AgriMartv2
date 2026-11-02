<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvRiwayatMasuk = New System.Windows.Forms.DataGridView()
        Me.lblRiwayat = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalBarang = New System.Windows.Forms.Label()
        Me.pnlKartu = New System.Windows.Forms.Panel()
        Me.pnlRingkasanBarang = New System.Windows.Forms.Panel()
        Me.lblJudulTotalBarang = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlRingkasanStok = New System.Windows.Forms.Panel()
        Me.lblJudulTotalStok = New System.Windows.Forms.Label()
        Me.lblTotalStok = New System.Windows.Forms.Label()
        Me.pnlRingkasanMenipis = New System.Windows.Forms.Panel()
        Me.lblJudulStokMenipis = New System.Windows.Forms.Label()
        Me.lblStokMenipis = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRiwayatMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlKartu.SuspendLayout()
        Me.pnlRingkasanBarang.SuspendLayout()
        Me.pnlRingkasanStok.SuspendLayout()
        Me.pnlRingkasanMenipis.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlKartu)
        Me.Panel1.Controls.Add(Me.dgvRiwayatMasuk)
        Me.Panel1.Controls.Add(Me.lblRiwayat)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 653)
        Me.Panel1.TabIndex = 0
        '
        'dgvRiwayatMasuk
        '
        Me.dgvRiwayatMasuk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRiwayatMasuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRiwayatMasuk.BackgroundColor = System.Drawing.Color.White
        Me.dgvRiwayatMasuk.ColumnHeadersHeight = 29
        Me.dgvRiwayatMasuk.Location = New System.Drawing.Point(0, 311)
        Me.dgvRiwayatMasuk.Name = "dgvRiwayatMasuk"
        Me.dgvRiwayatMasuk.RowHeadersWidth = 51
        Me.dgvRiwayatMasuk.RowTemplate.Height = 24
        Me.dgvRiwayatMasuk.Size = New System.Drawing.Size(1102, 342)
        Me.dgvRiwayatMasuk.TabIndex = 3
        '
        'lblRiwayat
        '
        Me.lblRiwayat.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRiwayat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblRiwayat.Location = New System.Drawing.Point(32, 255)
        Me.lblRiwayat.Name = "lblRiwayat"
        Me.lblRiwayat.Size = New System.Drawing.Size(390, 47)
        Me.lblRiwayat.TabIndex = 2
        Me.lblRiwayat.Text = "Riwayat Barang Masuk Terbaru"
        Me.lblRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTotalBarang)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1102, 67)
        Me.Panel2.TabIndex = 0
        '
        'lblTotalBarang
        '
        Me.lblTotalBarang.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTotalBarang.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblTotalBarang.Location = New System.Drawing.Point(0, 0)
        Me.lblTotalBarang.Name = "lblTotalBarang"
        Me.lblTotalBarang.Size = New System.Drawing.Size(394, 67)
        Me.lblTotalBarang.TabIndex = 1
        Me.lblTotalBarang.Text = "Dashboard Admin"
        Me.lblTotalBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlKartu
        '
        Me.pnlKartu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlKartu.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.pnlKartu.Controls.Add(Me.pnlRingkasanBarang)
        Me.pnlKartu.Controls.Add(Me.pnlRingkasanStok)
        Me.pnlKartu.Controls.Add(Me.pnlRingkasanMenipis)
        Me.pnlKartu.Location = New System.Drawing.Point(0, 67)
        Me.pnlKartu.Name = "pnlKartu"
        Me.pnlKartu.Size = New System.Drawing.Size(1102, 178)
        Me.pnlKartu.TabIndex = 4
        '
        'pnlRingkasanBarang
        '
        Me.pnlRingkasanBarang.BackColor = System.Drawing.Color.White
        Me.pnlRingkasanBarang.Controls.Add(Me.lblJudulTotalBarang)
        Me.pnlRingkasanBarang.Controls.Add(Me.Label1)
        Me.pnlRingkasanBarang.Location = New System.Drawing.Point(81, 16)
        Me.pnlRingkasanBarang.Name = "pnlRingkasanBarang"
        Me.pnlRingkasanBarang.Size = New System.Drawing.Size(265, 143)
        Me.pnlRingkasanBarang.TabIndex = 0
        '
        'lblJudulTotalBarang
        '
        Me.lblJudulTotalBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulTotalBarang.Location = New System.Drawing.Point(17, 15)
        Me.lblJudulTotalBarang.Name = "lblJudulTotalBarang"
        Me.lblJudulTotalBarang.Size = New System.Drawing.Size(220, 27)
        Me.lblJudulTotalBarang.TabIndex = 0
        Me.lblJudulTotalBarang.Text = "Total Barang Aktif"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 106)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "0"
        '
        'pnlRingkasanStok
        '
        Me.pnlRingkasanStok.BackColor = System.Drawing.Color.White
        Me.pnlRingkasanStok.Controls.Add(Me.lblJudulTotalStok)
        Me.pnlRingkasanStok.Controls.Add(Me.lblTotalStok)
        Me.pnlRingkasanStok.Location = New System.Drawing.Point(376, 16)
        Me.pnlRingkasanStok.Name = "pnlRingkasanStok"
        Me.pnlRingkasanStok.Size = New System.Drawing.Size(265, 143)
        Me.pnlRingkasanStok.TabIndex = 1
        '
        'lblJudulTotalStok
        '
        Me.lblJudulTotalStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulTotalStok.Location = New System.Drawing.Point(17, 15)
        Me.lblJudulTotalStok.Name = "lblJudulTotalStok"
        Me.lblJudulTotalStok.Size = New System.Drawing.Size(220, 27)
        Me.lblJudulTotalStok.TabIndex = 0
        Me.lblJudulTotalStok.Text = "Total Stok"
        '
        'lblTotalStok
        '
        Me.lblTotalStok.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblTotalStok.Location = New System.Drawing.Point(17, 35)
        Me.lblTotalStok.Name = "lblTotalStok"
        Me.lblTotalStok.Size = New System.Drawing.Size(220, 106)
        Me.lblTotalStok.TabIndex = 1
        Me.lblTotalStok.Text = "0"
        '
        'pnlRingkasanMenipis
        '
        Me.pnlRingkasanMenipis.BackColor = System.Drawing.Color.White
        Me.pnlRingkasanMenipis.Controls.Add(Me.lblJudulStokMenipis)
        Me.pnlRingkasanMenipis.Controls.Add(Me.lblStokMenipis)
        Me.pnlRingkasanMenipis.Location = New System.Drawing.Point(680, 16)
        Me.pnlRingkasanMenipis.Name = "pnlRingkasanMenipis"
        Me.pnlRingkasanMenipis.Size = New System.Drawing.Size(265, 143)
        Me.pnlRingkasanMenipis.TabIndex = 2
        '
        'lblJudulStokMenipis
        '
        Me.lblJudulStokMenipis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulStokMenipis.Location = New System.Drawing.Point(17, 15)
        Me.lblJudulStokMenipis.Name = "lblJudulStokMenipis"
        Me.lblJudulStokMenipis.Size = New System.Drawing.Size(235, 27)
        Me.lblJudulStokMenipis.TabIndex = 0
        Me.lblJudulStokMenipis.Text = "Barang Stok Menipis (<= 10)"
        '
        'lblStokMenipis
        '
        Me.lblStokMenipis.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokMenipis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStokMenipis.Location = New System.Drawing.Point(17, 35)
        Me.lblStokMenipis.Name = "lblStokMenipis"
        Me.lblStokMenipis.Size = New System.Drawing.Size(220, 106)
        Me.lblStokMenipis.TabIndex = 1
        Me.lblStokMenipis.Text = "0"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 653)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard Admin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvRiwayatMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnlKartu.ResumeLayout(False)
        Me.pnlRingkasanBarang.ResumeLayout(False)
        Me.pnlRingkasanStok.ResumeLayout(False)
        Me.pnlRingkasanMenipis.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotalBarang As Label
    Friend WithEvents dgvRiwayatMasuk As DataGridView
    Friend WithEvents lblRiwayat As Label
    Friend WithEvents pnlKartu As Panel
    Friend WithEvents pnlRingkasanBarang As Panel
    Friend WithEvents lblJudulTotalBarang As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlRingkasanStok As Panel
    Friend WithEvents lblJudulTotalStok As Label
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents pnlRingkasanMenipis As Panel
    Friend WithEvents lblJudulStokMenipis As Label
    Friend WithEvents lblStokMenipis As Label
End Class
