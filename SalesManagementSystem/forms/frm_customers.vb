Imports System.Data.SqlClient

Public Class frm_customers

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub add_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_btn.Click
        Me.Close()

        add_customers.ShowDialog()

    End Sub

    Private Sub frm_customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_cust()
    End Sub
    Public Sub load_cust()
        Try
            DGV_cust.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand("Select * from cust_tbl", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read

                DGV_cust.Rows.Add(dr("cust_id").ToString, dr("cust_name").ToString, dr("cust_phone").ToString, dr("cust_address").ToString, dr("to_him").ToString, dr("on_him").ToString)
            End While
            dr.Close()
            Con.Close()

        Catch ex As Exception
            Con.Close()

        End Try
    End Sub

    Private Sub excel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excel_btn.Click
        dgv_ExportDataToExcelFile(DGV_cust)

    End Sub

    Private Sub word_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles word_btn.Click
        ExportToWord(DGV_cust, "قائمة العملاء")

    End Sub

    Private Sub del_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del_btn.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_cust_tbl(DGV_cust)

        End If
        load_cust()

    End Sub
    Public Sub Delete_cust_tbl(ByVal dgv_cust_tbl As DataGridView)
        Dim Position As Integer = dgv_cust_tbl.CurrentRow.Index
        Dim ID_Position As Integer = DGV_cust.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From cust_tbl Where cust_id = @cust_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@cust_id", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف بيانات العميل بنجاح.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Public Sub get_data_to_edit()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand("select * from cust_tbl where cust_id=@cust_id", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("cust_id", SqlDbType.Int).Value = DGV_cust.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                edit_cust.cust_id.Text = dr("cust_id").ToString
                edit_cust.cust_name.Text = dr("cust_name").ToString
                edit_cust.cust_phone.Text = dr("cust_phone").ToString
                edit_cust.cust_address.Text = dr("cust_address").ToString
                edit_cust.to_him.Text = dr("to_him").ToString
                edit_cust.on_him.Text = dr("on_him").ToString


            End While

            dr.Close()
            Con.Close()

        Catch ex As Exception
            Con.Close()

        End Try
        Me.Close()
        edit_cust.ShowDialog()

    End Sub

    Private Sub edit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_btn.Click
        get_data_to_edit()

    End Sub

    Public Sub Search_By_name()
        Try
            DGV_cust.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from cust_tbl  where cust_name LIKE '" & tx_search.Text & "%'", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_cust.Rows.Add(dr("cust_id").ToString, dr("cust_name").ToString, dr("cust_phone").ToString, dr("cust_address").ToString, dr("to_him").ToString, dr("on_him").ToString)
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
End Class