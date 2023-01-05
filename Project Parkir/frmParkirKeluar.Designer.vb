<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParkirKeluar
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
        Me.components = New System.ComponentModel.Container()
        Me.txtTglMasuk = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtStrukID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFeePerJam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRateParkir = New System.Windows.Forms.TextBox()
        Me.txtNoPolisi = New System.Windows.Forms.TextBox()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.txtBiayaParkir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTanpaStruk = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtKembalian = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkTanpaStruk = New System.Windows.Forms.CheckedListBox()
        Me.txtTotalBiayaParkir = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtTanggalKeluar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTglMasuk
        '
        Me.txtTglMasuk.Enabled = False
        Me.txtTglMasuk.Location = New System.Drawing.Point(120, 104)
        Me.txtTglMasuk.Name = "txtTglMasuk"
        Me.txtTglMasuk.Size = New System.Drawing.Size(190, 20)
        Me.txtTglMasuk.TabIndex = 98
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(377, 267)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(299, 48)
        Me.btnSimpan.TabIndex = 83
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Tanggal Masuk"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(75, 282)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(145, 25)
        Me.btnReset.TabIndex = 85
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtStrukID
        '
        Me.txtStrukID.Enabled = False
        Me.txtStrukID.Location = New System.Drawing.Point(132, 12)
        Me.txtStrukID.Name = "txtStrukID"
        Me.txtStrukID.Size = New System.Drawing.Size(190, 20)
        Me.txtStrukID.TabIndex = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Fee PerJam"
        '
        'txtFeePerJam
        '
        Me.txtFeePerJam.Enabled = False
        Me.txtFeePerJam.Location = New System.Drawing.Point(120, 202)
        Me.txtFeePerJam.Name = "txtFeePerJam"
        Me.txtFeePerJam.Size = New System.Drawing.Size(190, 20)
        Me.txtFeePerJam.TabIndex = 92
        Me.txtFeePerJam.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-3, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "No Polisi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Rate Parkir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Nomor Member"
        '
        'txtRateParkir
        '
        Me.txtRateParkir.Enabled = False
        Me.txtRateParkir.Location = New System.Drawing.Point(120, 179)
        Me.txtRateParkir.Name = "txtRateParkir"
        Me.txtRateParkir.Size = New System.Drawing.Size(190, 20)
        Me.txtRateParkir.TabIndex = 88
        Me.txtRateParkir.Text = "0"
        '
        'txtNoPolisi
        '
        Me.txtNoPolisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPolisi.Location = New System.Drawing.Point(120, 67)
        Me.txtNoPolisi.Name = "txtNoPolisi"
        Me.txtNoPolisi.Size = New System.Drawing.Size(190, 31)
        Me.txtNoPolisi.TabIndex = 87
        '
        'txtMemberID
        '
        Me.txtMemberID.Enabled = False
        Me.txtMemberID.Location = New System.Drawing.Point(120, 153)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(190, 20)
        Me.txtMemberID.TabIndex = 86
        '
        'txtBiayaParkir
        '
        Me.txtBiayaParkir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiayaParkir.Location = New System.Drawing.Point(473, 44)
        Me.txtBiayaParkir.Name = "txtBiayaParkir"
        Me.txtBiayaParkir.Size = New System.Drawing.Size(190, 31)
        Me.txtBiayaParkir.TabIndex = 100
        Me.txtBiayaParkir.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Biaya Parkir"
        '
        'txtTanpaStruk
        '
        Me.txtTanpaStruk.Enabled = False
        Me.txtTanpaStruk.Location = New System.Drawing.Point(473, 81)
        Me.txtTanpaStruk.Name = "txtTanpaStruk"
        Me.txtTanpaStruk.Size = New System.Drawing.Size(190, 20)
        Me.txtTanpaStruk.TabIndex = 102
        Me.txtTanpaStruk.Text = "0"
        '
        'txtCash
        '
        Me.txtCash.Enabled = False
        Me.txtCash.Location = New System.Drawing.Point(473, 193)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(190, 20)
        Me.txtCash.TabIndex = 103
        Me.txtCash.Text = "0"
        '
        'txtKembalian
        '
        Me.txtKembalian.Enabled = False
        Me.txtKembalian.Location = New System.Drawing.Point(473, 219)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.Size = New System.Drawing.Size(190, 20)
        Me.txtKembalian.TabIndex = 104
        Me.txtKembalian.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(367, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Cash"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(367, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Kembalian"
        '
        'chkTanpaStruk
        '
        Me.chkTanpaStruk.FormattingEnabled = True
        Me.chkTanpaStruk.Location = New System.Drawing.Point(370, 84)
        Me.chkTanpaStruk.Name = "chkTanpaStruk"
        Me.chkTanpaStruk.Size = New System.Drawing.Size(17, 19)
        Me.chkTanpaStruk.TabIndex = 110
        '
        'txtTotalBiayaParkir
        '
        Me.txtTotalBiayaParkir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBiayaParkir.Location = New System.Drawing.Point(473, 137)
        Me.txtTotalBiayaParkir.Name = "txtTotalBiayaParkir"
        Me.txtTotalBiayaParkir.Size = New System.Drawing.Size(190, 31)
        Me.txtTotalBiayaParkir.TabIndex = 111
        Me.txtTotalBiayaParkir.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(367, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Total Biaya Parkir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-3, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 25)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Nomor Struk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(393, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Tanpa Struk"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(120, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 20)
        Me.TextBox1.TabIndex = 114
        '
        'txtTanggalKeluar
        '
        Me.txtTanggalKeluar.AutoSize = True
        Me.txtTanggalKeluar.Location = New System.Drawing.Point(1, 137)
        Me.txtTanggalKeluar.Name = "txtTanggalKeluar"
        Me.txtTanggalKeluar.Size = New System.Drawing.Size(79, 13)
        Me.txtTanggalKeluar.TabIndex = 115
        Me.txtTanggalKeluar.Text = "Tanggal Keluar"
        '
        'frmParkirKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 328)
        Me.Controls.Add(Me.txtTanggalKeluar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotalBiayaParkir)
        Me.Controls.Add(Me.chkTanpaStruk)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKembalian)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtTanpaStruk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBiayaParkir)
        Me.Controls.Add(Me.txtTglMasuk)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtStrukID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFeePerJam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRateParkir)
        Me.Controls.Add(Me.txtNoPolisi)
        Me.Controls.Add(Me.txtMemberID)
        Me.Name = "frmParkirKeluar"
        Me.Text = "frmParkirKeluar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTglMasuk As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtStrukID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFeePerJam As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRateParkir As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPolisi As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberID As System.Windows.Forms.TextBox
    Friend WithEvents txtBiayaParkir As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTanpaStruk As System.Windows.Forms.TextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtKembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkTanpaStruk As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtTotalBiayaParkir As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTanggalKeluar As System.Windows.Forms.Label
End Class
