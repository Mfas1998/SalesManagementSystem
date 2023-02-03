Imports System.Data.SqlClient

Public Class frm_product

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub frm_product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_prd()
    End Sub
    Public Sub load_prd()
        Try
            DGV_prd.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand("Select * from View_all_prd", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read

                DGV_prd.Rows.Add(dr("pro_id").ToString, dr("pro_code").ToString, dr("pro_name").ToString, dr("Cat_name").ToString, dr("unit_name").ToString)
            End While
            dr.Close()
            Con.Close()

        Catch ex As Exception
            Con.Close()

        End Try
    End Sub

    Private Sub add_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_btn.Click
        add_product.ShowDialog()

    End Sub

    Private Sub excel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excel_btn.Click
        dgv_ExportDataToExcelFile(DGV_prd)


    End Sub

    Private Sub word_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles word_btn.Click
        ExportToWord(DGV_prd, "قائمة المنتجات")
    End Sub

    Private Sub edit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_btn.Click


        Get_data_to_edit()
        Me.Close()
    End Sub
    Public Sub Get_data_to_edit()
        fillcmb_Cat_tbl(edit_product.cmb_Cat_id)
        fillcmb_Unit_table(edit_product.cmb_unit_id)
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from View_all_prd  where  pro_id=@pro_id", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@pro_id", SqlDbType.Int).Value = DGV_prd.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                edit_product.pro_id.Text = dr("pro_id").ToString
                edit_product.pro_code.Text = dr("pro_code").ToString
                edit_product.pro_name.Text = dr("pro_name").ToString
                edit_product.cmb_Cat_id.Text = dr("Cat_name").ToString
                edit_product.cmb_unit_id.Text = dr("unit_name").ToString

            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

        edit_product.Show()
    End Sub

    Private Sub del_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del_btn.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_pro_tbl(DGV_prd)
        End If
        load_prd()

    End Sub
    Public Sub Delete_pro_tbl(ByVal DGV_prd As DataGridView)
        Dim Position As Integer = DGV_prd.CurrentRow.Index
        Dim ID_Position As Integer = DGV_prd.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From pro_tbl Where pro_id = @pro_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@pro_id", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف المنتج بنجاح.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub


End Class