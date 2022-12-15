<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParkirMasuk
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtStrukID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFeePerJam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRateParkir = New System.Windows.Forms.TextBox()
        Me.txtNoPolisi = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTglMasuk
        '
        Me.txtTglMasuk.Enabled = False
        Me.txtTglMasuk.Location = New System.Drawing.Point(452, 75)
        Me.txtTglMasuk.Name = "txtTglMasuk"
        Me.txtTglMasuk.Size = New System.Drawing.Size(190, 20)
        Me.txtTglMasuk.TabIndex = 81
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(301, 213)
        Me.dgv.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Tanggal Masuk"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.btnReload)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(12, 231)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(301, 34)
        Me.FlowLayoutPanel3.TabIndex = 80
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(3, 3)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(98, 25)
        Me.btnReload.TabIndex = 18
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(337, 190)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(305, 48)
        Me.btnSimpan.TabIndex = 66
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(334, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Nomor Struk"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(339, 244)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(145, 25)
        Me.btnHapus.TabIndex = 67
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(497, 244)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(145, 25)
        Me.btnReset.TabIndex = 68
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtStrukID
        '
        Me.txtStrukID.Enabled = False
        Me.txtStrukID.Location = New System.Drawing.Point(452, 49)
        Me.txtStrukID.Name = "txtStrukID"
        Me.txtStrukID.Size = New System.Drawing.Size(190, 20)
        Me.txtStrukID.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(334, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Fee PerJam"
        '
        'txtFeePerJam
        '
        Me.txtFeePerJam.Enabled = False
        Me.txtFeePerJam.Location = New System.Drawing.Point(452, 153)
        Me.txtFeePerJam.Name = "txtFeePerJam"
        Me.txtFeePerJam.Size = New System.Drawing.Size(190, 20)
        Me.txtFeePerJam.TabIndex = 75
        Me.txtFeePerJam.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Rate Parkir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(334, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "No Polisi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Nomor Member"
        '
        'txtRateParkir
        '
        Me.txtRateParkir.Enabled = False
        Me.txtRateParkir.Location = New System.Drawing.Point(452, 127)
        Me.txtRateParkir.Name = "txtRateParkir"
        Me.txtRateParkir.Size = New System.Drawing.Size(190, 20)
        Me.txtRateParkir.TabIndex = 71
        Me.txtRateParkir.Text = "0"
        '
        'txtNoPolisi
        '
        Me.txtNoPolisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPolisi.Location = New System.Drawing.Point(452, 12)
        Me.txtNoPolisi.Name = "txtNoPolisi"
        Me.txtNoPolisi.Size = New System.Drawing.Size(190, 31)
        Me.txtNoPolisi.TabIndex = 70
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'txtMemberID
        '
        Me.txtMemberID.Enabled = False
        Me.txtMemberID.Location = New System.Drawing.Point(452, 101)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(190, 20)
        Me.txtMemberID.TabIndex = 69
        '
        'frmParkirMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 293)
        Me.Controls.Add(Me.txtTglMasuk)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtStrukID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFeePerJam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRateParkir)
        Me.Controls.Add(Me.txtNoPolisi)
        Me.Controls.Add(Me.txtMemberID)
        Me.Name = "frmParkirMasuk"
        Me.Text = "frmParkirMasuk"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTglMasuk As System.Windows.Forms.TextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtStrukID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFeePerJam As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRateParkir As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPolisi As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtMemberID As System.Windows.Forms.TextBox
End Class
