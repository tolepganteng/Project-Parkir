Imports MySql.Data.MySqlClient

Public Class frmParkirMasuk
    Dim conn As MySqlConnection = New MySqlConnection(connString)
    Dim connString As String = "Server=127.0.0.1,Database=db_parkir;Uid=root;"
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

    Private Sub frmParkirMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSimpan.Text = DateTime.Now()
    End Sub

    Private Sub ResetUI()
        txtNoPolisi.Text = ""
        txtStrukID.Text = ""
        txtMemberID.Text = ""
        txtTglMasuk.Text = ""
        txtRateParkir.Text = RateParkir
        txtFeePerJam.Text = FeePerJam
        btnSimpan.Enabled = True
    End Sub

    Private Sub SetupDGV()
        With dgv
            .Columns(0).HeaderText = "No. Struk"
            .Columns(1).HeaderText = "Tanggal Masuk"

            .Columns(0).Width = 100
            .Columns(1).Width = 200
        End With
    End Sub

    Private Function fillDGV() As Boolean
        Dim ret As Boolean = True

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_StrukList"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("_Status", "M")
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

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ResetUI()
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim Pilih As DataGridViewRow
        Pilih = dgv.Rows(e.RowIndex)

        Dim lkode As String


        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_ParkirCariStrukMasukStatus"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("_Status", "M")
                End With

                dt = New DataTable
                da = New MySqlDataAdapter(sqlComm)
                da.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MsgBox("Tidak Ditemukan", , "error")
                Else
                    For Each drow As DataRow In dt.Rows
                        txtNoPolisi.Text = drow.Item("NoPolisi").ToString()
                        txtStrukID.Text = drow.Item("StrukID").ToString()
                        txtTglMasuk.Text = drow.Item("TglMasuk").ToString()
                        txtMemberID.Text = drow.Item("MemberID").ToString()
                        txtRateParkir.Text = drow.Item("RateParkir").ToString()
                        txtFeePerJam.Text = drow.Item("FeePerJam").ToString()
                    Next
                    btnSimpan.Enabled = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub

    Private Function SedangParkir(ByVal lNoPolisi As String) As Boolean
        Dim ret As Boolean = False
        Dim lCari As String

        lCari = lNoPolisi

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_ParkirCariNoPolisiStatus"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("_NoPolisi", lCari)
                    .Parameters.AddWithValue("_Status", "M")
                End With

                dt = New DataTable
                da = New MySqlDataAdapter
                da.Fill(dt)

                If dt.Rows.Count = 0 Then
                    ret = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message, , "error")

            End Try
        End If

        Return ret
    End Function

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim lNoPolisi As String,
        lTglmasuk As String, lMemberID As String, lRateParkir As String, lFeePerJam As String

        If Koneksi(True) Then
            Try
                lNoPolisi = txtNoPolisi.Text.ToString()

                If SedangParkir(lNoPolisi) Then
                    MsgBox("Mobil tersebut sedang parkirdi area parkir", , "info")
                End If

                lTglmasuk = Date.Parse(btnSimpan.Text).ToString("yyy-MM-dd hh;mm:ss")
                lMemberID = txtMemberID.Text.ToString()
                lRateParkir = txtRateParkir.Text.ToString()
                lFeePerJam = txtFeePerJam.Text.ToString()

                sqlComm = New MySqlCommand

                With sqlComm
                    .Connection = conn
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("_TglMasuk", lTglmasuk)
                    .Parameters.AddWithValue("_NoPolisi", lNoPolisi)
                    .Parameters.AddWithValue("_MemberID", lMemberID)
                    .Parameters.AddWithValue("_RateParkir", lRateParkir)
                    .Parameters.AddWithValue("_FeePerJam", lFeePerJam)
                    .Parameters.AddWithValue("_Status", "M")

                    .CommandText = "SP_ParkiMasuk"

                    If .ExecuteNonQuery() = 1 Then
                        MsgBox("Berhasil", , "info")
                    Else
                        MsgBox("Gagal", , "info")
                    End If
                End With
                fillDGV()
                ResetUI()
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim lKode As String

        If MsgBox("Hapus ?", vbOKCancel + vbQuestion, "confirm") = vbCancel Then
            Exit Sub
        End If

        lKode = txtStrukID.Text.ToString()
        If lKode = "" Then Exit Sub

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_ParkirDelete"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("StrukturID", lKode)
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



    Private Sub txtNoPolisi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoPolisi.Leave
        Dim lCari As String

        lCari = txtNoPolisi.Text.ToString()

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_ParkirCariMemberID"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("_NoPolisi", lCari)
                End With

                dt = New DataTable
                da = New MySqlDataAdapter
                da.Fill(dt)

                If dt.Rows.Count = 0 Then
                    txtMemberID.Text = ""
                    txtRateParkir.Text = 3
                    txtFeePerJam.Text = 3000
                Else
                    txtMemberID.Text = dt.Rows(0)("MemberID").ToString()
                    txtRateParkir.Text = RateParkir
                    txtFeePerJam.Text = FeePerJam
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub
End Class