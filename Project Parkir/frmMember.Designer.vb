<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMember
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
        Me.lblMember = New System.Windows.Forms.Label()
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.txtNamaMember = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNoKtp = New System.Windows.Forms.TextBox()
        Me.txtTanggalJoin = New System.Windows.Forms.TextBox()
        Me.txtTipe = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCariTglJoin = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpCariTglJoin = New System.Windows.Forms.DateTimePicker()
        Me.btnCariAngka = New System.Windows.Forms.Button()
        Me.txtCariAngka = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCariNamaMember = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lAngka = New System.Windows.Forms.Label()
        Me.lblString = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtCariNamaMember = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMember
        '
        Me.lblMember.AutoSize = True
        Me.lblMember.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMember.Location = New System.Drawing.Point(0, 0)
        Me.lblMember.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblMember.Name = "lblMember"
        Me.lblMember.Size = New System.Drawing.Size(50, 13)
        Me.lblMember.TabIndex = 0
        Me.lblMember.Text = "Members"
        '
        'txtNomor
        '
        Me.txtNomor.Location = New System.Drawing.Point(555, 22)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(216, 20)
        Me.txtNomor.TabIndex = 1
        '
        'txtNamaMember
        '
        Me.txtNamaMember.Location = New System.Drawing.Point(555, 48)
        Me.txtNamaMember.Name = "txtNamaMember"
        Me.txtNamaMember.Size = New System.Drawing.Size(216, 20)
        Me.txtNamaMember.TabIndex = 2
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(555, 74)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(216, 20)
        Me.txtAlamat.TabIndex = 3
        '
        'txtNoKtp
        '
        Me.txtNoKtp.Location = New System.Drawing.Point(555, 100)
        Me.txtNoKtp.Name = "txtNoKtp"
        Me.txtNoKtp.Size = New System.Drawing.Size(216, 20)
        Me.txtNoKtp.TabIndex = 4
        '
        'txtTanggalJoin
        '
        Me.txtTanggalJoin.Location = New System.Drawing.Point(555, 126)
        Me.txtTanggalJoin.Name = "txtTanggalJoin"
        Me.txtTanggalJoin.Size = New System.Drawing.Size(216, 20)
        Me.txtTanggalJoin.TabIndex = 5
        '
        'txtTipe
        '
        Me.txtTipe.Location = New System.Drawing.Point(555, 152)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.Size = New System.Drawing.Size(216, 20)
        Me.txtTipe.TabIndex = 6
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(555, 178)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(216, 20)
        Me.txtDeposit.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nomor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(434, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama Member"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(434, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "No. KTP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(434, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tanggal Join"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(434, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tipe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(434, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Deposit"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(435, 228)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 15
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(565, 228)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 16
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(696, 228)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCariTglJoin)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.dtpCariTglJoin)
        Me.Panel1.Controls.Add(Me.btnCariAngka)
        Me.Panel1.Controls.Add(Me.txtCariAngka)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnCariNamaMember)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.lAngka)
        Me.Panel1.Controls.Add(Me.lblString)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.txtCariNamaMember)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(12, 274)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 111)
        Me.Panel1.TabIndex = 18
        '
        'btnCariTglJoin
        '
        Me.btnCariTglJoin.Location = New System.Drawing.Point(305, 72)
        Me.btnCariTglJoin.Name = "btnCariTglJoin"
        Me.btnCariTglJoin.Size = New System.Drawing.Size(47, 22)
        Me.btnCariTglJoin.TabIndex = 34
        Me.btnCariTglJoin.Text = "Go"
        Me.btnCariTglJoin.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Tanggal Daftar"
        '
        'dtpCariTglJoin
        '
        Me.dtpCariTglJoin.Location = New System.Drawing.Point(83, 72)
        Me.dtpCariTglJoin.Name = "dtpCariTglJoin"
        Me.dtpCariTglJoin.Size = New System.Drawing.Size(216, 20)
        Me.dtpCariTglJoin.TabIndex = 32
        '
        'btnCariAngka
        '
        Me.btnCariAngka.Location = New System.Drawing.Point(698, 50)
        Me.btnCariAngka.Name = "btnCariAngka"
        Me.btnCariAngka.Size = New System.Drawing.Size(36, 20)
        Me.btnCariAngka.TabIndex = 20
        Me.btnCariAngka.Text = "GO"
        Me.btnCariAngka.UseVisualStyleBackColor = True
        '
        'txtCariAngka
        '
        Me.txtCariAngka.Location = New System.Drawing.Point(476, 47)
        Me.txtCariAngka.Name = "txtCariAngka"
        Me.txtCariAngka.Size = New System.Drawing.Size(216, 20)
        Me.txtCariAngka.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(420, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Text"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(698, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 20)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "GO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(305, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 20)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "GO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCariNamaMember
        '
        Me.btnCariNamaMember.Location = New System.Drawing.Point(305, 8)
        Me.btnCariNamaMember.Name = "btnCariNamaMember"
        Me.btnCariNamaMember.Size = New System.Drawing.Size(36, 20)
        Me.btnCariNamaMember.TabIndex = 15
        Me.btnCariNamaMember.Text = "GO"
        Me.btnCariNamaMember.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(476, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(216, 20)
        Me.TextBox3.TabIndex = 14
        '
        'lAngka
        '
        Me.lAngka.AutoSize = True
        Me.lAngka.Location = New System.Drawing.Point(420, 50)
        Me.lAngka.Name = "lAngka"
        Me.lAngka.Size = New System.Drawing.Size(38, 13)
        Me.lAngka.TabIndex = 13
        Me.lAngka.Text = "Angka"
        '
        'lblString
        '
        Me.lblString.AutoSize = True
        Me.lblString.Location = New System.Drawing.Point(7, 50)
        Me.lblString.Name = "lblString"
        Me.lblString.Size = New System.Drawing.Size(34, 13)
        Me.lblString.TabIndex = 12
        Me.lblString.Text = "String"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(83, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 20)
        Me.TextBox2.TabIndex = 11
        '
        'txtCariNamaMember
        '
        Me.txtCariNamaMember.Location = New System.Drawing.Point(83, 8)
        Me.txtCariNamaMember.Name = "txtCariNamaMember"
        Me.txtCariNamaMember.Size = New System.Drawing.Size(216, 20)
        Me.txtCariNamaMember.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nomor Member"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 22)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(404, 229)
        Me.dgv.TabIndex = 19
        '
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 397)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.txtTipe)
        Me.Controls.Add(Me.txtTanggalJoin)
        Me.Controls.Add(Me.txtNoKtp)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNamaMember)
        Me.Controls.Add(Me.txtNomor)
        Me.Controls.Add(Me.lblMember)
        Me.Name = "frmMember"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMember As System.Windows.Forms.Label
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaMember As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNoKtp As System.Windows.Forms.TextBox
    Friend WithEvents txtTanggalJoin As System.Windows.Forms.TextBox
    Friend WithEvents txtTipe As System.Windows.Forms.TextBox
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCariNamaMember As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lAngka As System.Windows.Forms.Label
    Friend WithEvents lblString As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCariAngka As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnCariNamaMember As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btnCariAngka As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnCariTglJoin As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpCariTglJoin As System.Windows.Forms.DateTimePicker

End Class
