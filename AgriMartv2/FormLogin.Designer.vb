<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.pnlRole = New System.Windows.Forms.Panel()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbKasir = New System.Windows.Forms.RadioButton()
        Me.rbOwner = New System.Windows.Forms.RadioButton()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.chkTampilkanPassword = New System.Windows.Forms.CheckBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblJudulLogin = New System.Windows.Forms.Label()
        Me.txtNamaPengguna = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblDeskripsi = New System.Windows.Forms.Label()
        Me.txtKataSandi = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlRole.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 640)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.AgriMartv2.My.Resources.Resources.logo_agrimart
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 640)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(450, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(630, 640)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnMasuk)
        Me.Panel3.Controls.Add(Me.pnlRole)
        Me.Panel3.Controls.Add(Me.lblRole)
        Me.Panel3.Controls.Add(Me.chkTampilkanPassword)
        Me.Panel3.Controls.Add(Me.lblUsername)
        Me.Panel3.Controls.Add(Me.lblJudulLogin)
        Me.Panel3.Controls.Add(Me.txtNamaPengguna)
        Me.Panel3.Controls.Add(Me.lblPassword)
        Me.Panel3.Controls.Add(Me.lblDeskripsi)
        Me.Panel3.Controls.Add(Me.txtKataSandi)
        Me.Panel3.Location = New System.Drawing.Point(57, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(515, 575)
        Me.Panel3.TabIndex = 0
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnMasuk.FlatAppearance.BorderSize = 0
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasuk.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(40, 449)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(437, 46)
        Me.btnMasuk.TabIndex = 11
        Me.btnMasuk.Text = "MASUK "
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'pnlRole
        '
        Me.pnlRole.Controls.Add(Me.rbAdmin)
        Me.pnlRole.Controls.Add(Me.rbKasir)
        Me.pnlRole.Controls.Add(Me.rbOwner)
        Me.pnlRole.Location = New System.Drawing.Point(40, 174)
        Me.pnlRole.Name = "pnlRole"
        Me.pnlRole.Size = New System.Drawing.Size(437, 48)
        Me.pnlRole.TabIndex = 14
        '
        'rbAdmin
        '
        Me.rbAdmin.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.rbAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.rbAdmin.Location = New System.Drawing.Point(0, 0)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(137, 45)
        Me.rbAdmin.TabIndex = 0
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbAdmin.UseVisualStyleBackColor = False
        '
        'rbKasir
        '
        Me.rbKasir.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbKasir.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.rbKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbKasir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.rbKasir.Location = New System.Drawing.Point(150, 0)
        Me.rbKasir.Name = "rbKasir"
        Me.rbKasir.Size = New System.Drawing.Size(137, 45)
        Me.rbKasir.TabIndex = 1
        Me.rbKasir.Text = "Kasir"
        Me.rbKasir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbKasir.UseVisualStyleBackColor = False
        '
        'rbOwner
        '
        Me.rbOwner.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.rbOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbOwner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.rbOwner.Location = New System.Drawing.Point(300, 0)
        Me.rbOwner.Name = "rbOwner"
        Me.rbOwner.Size = New System.Drawing.Size(137, 45)
        Me.rbOwner.TabIndex = 2
        Me.rbOwner.Text = "Owner"
        Me.rbOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbOwner.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(37, 146)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(180, 25)
        Me.lblRole.TabIndex = 3
        Me.lblRole.Text = "Login Sebagai"
        '
        'chkTampilkanPassword
        '
        Me.chkTampilkanPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.chkTampilkanPassword.Location = New System.Drawing.Point(42, 401)
        Me.chkTampilkanPassword.Name = "chkTampilkanPassword"
        Me.chkTampilkanPassword.Size = New System.Drawing.Size(235, 27)
        Me.chkTampilkanPassword.TabIndex = 13
        Me.chkTampilkanPassword.Text = "Tampilkan password"
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(41, 247)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(200, 25)
        Me.lblUsername.TabIndex = 8
        Me.lblUsername.Text = "Username"
        '
        'lblJudulLogin
        '
        Me.lblJudulLogin.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudulLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblJudulLogin.Location = New System.Drawing.Point(35, 32)
        Me.lblJudulLogin.Name = "lblJudulLogin"
        Me.lblJudulLogin.Size = New System.Drawing.Size(445, 60)
        Me.lblJudulLogin.TabIndex = 2
        Me.lblJudulLogin.Text = "Welcome back!"
        '
        'txtNamaPengguna
        '
        Me.txtNamaPengguna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaPengguna.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNamaPengguna.Location = New System.Drawing.Point(41, 279)
        Me.txtNamaPengguna.Name = "txtNamaPengguna"
        Me.txtNamaPengguna.Size = New System.Drawing.Size(437, 39)
        Me.txtNamaPengguna.TabIndex = 9
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(41, 324)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(200, 25)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password"
        '
        'lblDeskripsi
        '
        Me.lblDeskripsi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblDeskripsi.Location = New System.Drawing.Point(39, 95)
        Me.lblDeskripsi.Name = "lblDeskripsi"
        Me.lblDeskripsi.Size = New System.Drawing.Size(438, 27)
        Me.lblDeskripsi.TabIndex = 3
        Me.lblDeskripsi.Text = "Masuk untuk mengelola aktivitas toko pertanian."
        '
        'txtKataSandi
        '
        Me.txtKataSandi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKataSandi.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtKataSandi.Location = New System.Drawing.Point(41, 356)
        Me.txtKataSandi.Name = "txtKataSandi"
        Me.txtKataSandi.Size = New System.Drawing.Size(437, 39)
        Me.txtKataSandi.TabIndex = 11
        Me.txtKataSandi.UseSystemPasswordChar = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 640)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgriMart - Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlRole.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents chkTampilkanPassword As CheckBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblJudulLogin As Label
    Friend WithEvents txtNamaPengguna As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents txtKataSandi As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents btnMasuk As Button
    Friend WithEvents pnlRole As Panel
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKasir As RadioButton
    Friend WithEvents rbOwner As RadioButton
End Class
