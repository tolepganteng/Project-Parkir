Imports MySql.Data.MySqlClient

Public Class frmMobil
    Dim conn As MySqlConnection = New MySqlConnection(connString)
    Dim connString As String = "Server=localhost;Database=mobil;Uid=root;"
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
        txtMemberID.Clear()
        txtNoPolisi.Clear()
        txtCatatan.Clear()
    End Sub
    Private Function fillDGV() As Boolean
        Dim ret As Boolean = True

        If Koneksi(True) Then
            Try
                sqlComm = New MySqlCommand
                With sqlComm
                    .Connection = conn
                    .CommandText = "SP_MobilSelect"
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
            .Columns(0).HeaderText = "MemberID"
            .Columns(1).HeaderText = "No Polisi"
            .Columns(2).HeaderText = "Catatan"

            .Columns(0).Width = 60
            .Columns(1).Width = 200
            .Columns(2).Width = 100
        End With
    End Sub
    Private Sub frmMobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                    .CommandText = "SP_MobilCariID"
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
                        txtMemberID.Text = drow.Item("MemberID").ToString()
                        txtNoPolisi.Text = drow.Item("No Polisi").ToString()
                        txtCatatan.Text = drow.Item("Catatan").ToString()
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message, , "error")
            End Try
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim lMemberID As String
        Dim lNoPolisi As String
        Dim lCatatan As String

        If Koneksi(True) Then

            lMemberID = txtMemberID.Text.ToString()
            lNoPolisi = txtNoPolisi.Text.ToString()
            lCatatan = txtCatatan.Text.ToString()


            sqlComm = New MySqlCommand

            With sqlComm
                .Connection = conn
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("_MemberID", lKode)
                .Parameters.AddWithValue("_NamaMember", lNamaMember)
                .Parameters.AddWithValue("_Alamat", lAlamat)

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
End Class