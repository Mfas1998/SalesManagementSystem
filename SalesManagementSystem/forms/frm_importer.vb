Imports System.Data.SqlClient

Public Class frm_importer

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub add_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_btn.Click
        Me.Close()

        add_importer.ShowDialog()
    End Sub

    Public Sub load_imp()
        Try
            DGV_importer.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand("Select * from imp_tbl", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read

                DGV_importer.Rows.Add(dr("imp_id").ToString, dr("imp_name").ToString, dr("imp_phone").ToString, dr("imp_address").ToString, dr("to_him").ToString, dr("on_him").ToString)
            End While
            dr.Close()
            Con.Close()

        Catch ex As Exception
            Con.Close()

        End Try
    End Sub

    Private Sub frm_importer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_imp()
    End Sub

    Public Sub Delete_imp_tbl(ByVal dgv_imp_tbl As DataGridView)
        Dim Position As Integer = dgv_imp_tbl.CurrentRow.Index
        Dim ID_Position As Integer = DGV_importer.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From imp_tbl Where imp_id = @imp_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@imp_id", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف بيانات العميل بنجاح.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub



    Private Sub del_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del_btn.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_imp_tbl(DGV_importer)
        End If
        load_imp()

    End Sub

    Private Sub excel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excel_btn.Click
        dgv_ExportDataToExcelFile(DGV_importer)

    End Sub

    Private Sub word_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles word_btn.Click
        ExportToWord(DGV_importer, "قائمة الموردين")

    End Sub

    Public Sub Search_By_name()
        Try
            DGV_importer.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from imp_tbl  where imp_name LIKE '" & tx_search.Text & "%'", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_importer.Rows.Add(dr("imp_id").ToString, dr("imp_name").ToString, dr("imp_phone").ToString, dr("imp_address").ToString, dr("to_him").ToString, dr("on_him").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Private Sub tx_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx_search.TextChanged
        Search_By_name()
    End Sub

    Public Sub get_data_to_edit()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand("select * from imp_tbl where imp_id=@imp_id", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("imp_id", SqlDbType.Int).Value = DGV_importer.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                edit_importer.imp_id.Text = dr("imp_id").ToString
                edit_importer.imp_name.Text = dr("imp_name").ToString
                edit_importer.imp_phone.Text = dr("imp_phone").ToString
                edit_importer.imp_address.Text = dr("imp_address").ToString
                edit_importer.to_him.Text = dr("to_him").ToString
                edit_importer.on_him.Text = dr("on_him").ToString


            End While

            dr.Close()
            Con.Close()

        Catch ex As Exception
            Con.Close()

        End Try
        Me.Close()
        edit_importer.ShowDialog()

    End Sub

    Private Sub edit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_btn.Click
        get_data_to_edit()
    End Sub



End Class