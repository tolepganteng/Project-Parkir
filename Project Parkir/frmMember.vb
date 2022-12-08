Imports MySql.Data.MySqlClient

Public Class frmMember
    Dim conn As MySqlConnection = New MySqlConnection(connString)
    Dim connString As String = "Server=localhost;Database=parkir;Uid=root;"
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim sqlComm As MySqlCommand

    Dim ds As DataSet
    Dim dt As DataTable


    Private Function Koneksi(ByVal reqState As Boolean) As Boolean
        Dim ret As Boolean = True

        Try
            If reqState = True Then
                If conn.State = ConnectionState.Closed Then conn.Open()
            Else
                If conn.State = ConnectionState.Open Then conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , "error")
            ret = False
        End Try

        Return ret
    End Function

    Private Sub ResetUI()
        txtNamaMember.Clear()
        txtNomor.Clear()
        txtAlamat.Clear()
        txtNoKtp.Clear()
        txtTanggalJoin.Clear()
        txtTipe.Clear()
        txtDeposit.Clear()

    End Sub

    Private Function fillDGV() As Boolean
        Dim ret As Boolean = True

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_MemberSelect"
                    .CommandType = CommandType.StoredProcedure

                End With
                dt = New DataTable
                da = New MySqlDataAdapter

                da.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
                ret = False
            End Try
        Else
            ret = False
        End If

        Return ret
    End Function
    Private Sub SetupDGV()
        With dgv
            .Columns(0).HeaderText = "Nomor"
            .Columns(1).HeaderText = "Nama Member"
            .Columns(2).HeaderText = "No. KTP"

            .Columns(0).Width = 60
            .Columns(1).Width = 200
            .Columns(2).Width = 100
        End With
    End Sub
    Private Sub SetupDGV_Ext()
        SetupDGV()
        With dgv
            .Columns(0).HeaderText = "Alamat"
            .Columns(1).HeaderText = "Deposit"
            .Columns(2).HeaderText = "Tipe"
            .Columns(3).HeaderText = "Tanggal Deposit"

            .Columns(0).Width = 100
            .Columns(1).Width = 80
            .Columns(2).Width = 30
            .Columns(3).Width = 150
        End With
    End Sub

    Private Sub frmMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillDGV()
        ResetUI()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ResetUI()
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim Pilih As DataGridViewRow
        Pilih = dgv.Rows(e.RowIndex)

        Dim lKode As String

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_MemberCariID"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("_MemberID", lKode)
                End With

                dt = New DataTable
                da = New MySqlDataAdapter(sqlComm)
                da.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MsgBox("Tidak Ditemukan", , "error")
                Else
                    For Each drow As DataRow In dt.Rows
                        txtNomor.Text = drow.Item("Member ID").ToString()
                        txtNamaMember.Text = drow.Item("NamaMember").ToString()
                        txtAlamat.Text = drow.Item("Alamat").ToString()
                        txtNoKtp.Text = drow.Item("NoKTP").ToString()
                        txtDeposit.Text = drow.Item("Deposit").ToString()
                        txtTanggalJoin.Text = drow.Item("Tanggal Join").ToString()
                        txtTipe.Text = drow.Item("Tipe").ToString()
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim lKode As String
        Dim lNamaMember As String, lAlamat As String, lNoKTP As String
        Dim lDeposit As String, lTipe As String, lTglJoin As String

        If Koneksi(True) Then
            lKode = txtNomor.Text.ToString()
            lNamaMember = txtNamaMember.Text.ToString()
            lAlamat = txtAlamat.Text.ToString()
            lNoKTP = txtNoKtp.Text.ToString()
            lDeposit = txtDeposit.Text.ToString()
            lTipe = txtTipe.Text.ToString()
            dtpCariTglJoin.Format = DateTimePickerFormat.Custom
            dtpCariTglJoin.CustomFormat = "yy-MM-dd"
            lTglJoin = dtpCariTglJoin.Text
            dtpCariTglJoin.Format = DateTimePickerFormat.Long

            sqlComm = New MySqlCommand

            With sqlComm
                .Connection = conn
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("_MemberID", lKode)
                .Parameters.AddWithValue("_NamaMember", lNamaMember)
                .Parameters.AddWithValue("_Alamat", lAlamat)
                .Parameters.AddWithValue("_NoKTP", lNoKTP)
                .Parameters.AddWithValue("_Deposit", lDeposit)
                .Parameters.AddWithValue("_Tipe", lTipe)
                .Parameters.AddWithValue("_TglJoin", lTglJoin)

                If lKode = "" Then
                    .CommandText = "SP_MemberInsert"
                Else
                    .CommandText = "SP_MemberUpdate"
                End If

                If .ExecuteNonQuery() = 1 Then
                    MsgBox("Berhasil", , "info")
                Else
                    MsgBox("Gagal", , "info")
                End If
            End With
            fillDGV()
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub

    Private Sub Cari_viaSP()
        dt = New DataTable
        da = New MySqlDataAdapter
        da.Fill(dt)

        If dt.Rows.Count Then
            'Belum Kelar!!!!
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim lKode As String

        If MsgBox("Hapus ?", vbOKCancel + vbQuestion, "confirm") = vbCancel Then
            Exit Sub
        End If

        lKode = txtNomor.Text.ToString()
        If lKode = "" Then Exit Sub

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_MemberDelete"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("MemberID", lKode)
                    If .ExecuteNonQuery() > 0 Then
                        MsgBox("Berhasil dihapus", , "info")
                        fillDGV()
                    Else
                        MsgBox("Gagal dihapus", , "info")
                    End If
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , "erorr")
            End Try
        End If

    End Sub

    Private Sub btnCariNamaMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariNamaMember.Click
        Dim lCari As String

        lCari = txtCariNamaMember.Text.ToString()
        If lCari = "" Then Exit Sub

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_MemberCariNama"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("_NamaMember", lCari)
                End With

                Cari_viaSP()
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub

    Private Sub btnCariTglJoin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariTglJoin.Click
        Dim lCari As String

        lCari = Date.Parse(dtpCariTglJoin.Text).ToString("yyy-MM-dd")
        If lCari = "" Then Exit Sub

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_MemberCariTglJoin"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("_TglJoin", lCari)
                End With

                Cari_viaSP()
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub

    Private Sub btnCariAngka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariAngka.Click
        Dim lCari As String

        lCari = txtCariAngka.Text.ToString()
        If lCari = "" Then Exit Sub

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_MemberCariNama"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("_NamaMember", lCari)
                End With

                Cari_viaSP()
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub

    Private Sub btnCariTglJoin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariTglJoin.Click
        Dim lCari As String

        lCari = Date.Parse(dtpCariTglJoin.Text).ToString("yyy-MM-dd")
        If lCari = "" Then Exit Sub

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_CariAngka"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("_Angka", lCari)
                End With

                Cari_viaSP()
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub
End Class
