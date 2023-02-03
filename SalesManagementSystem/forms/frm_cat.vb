Imports System.Data.SqlClient

Public Class frm_cat

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub add_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_btn.Click
        Me.Close()
        add_cat.ShowDialog()

    End Sub
    Public Sub load_cat()
        Try
            DGV_cat.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand("Select * from Cat_tbl", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read

                DGV_cat.Rows.Add(dr("Cat_id").ToString, dr("Cat_name").ToString)
            End While
            dr.Close()
            Con.Close()

        Catch ex As Exception
            Con.Close()

        End Try
    End Sub


    Private Sub frm_cat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_cat()
    End Sub
  

    Public Sub get_data_to_edit()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand("select * from Cat_tbl where Cat_id=@Cat_id", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Cat_id", SqlDbType.Int).Value = DGV_cat.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                edit_cat.Cat_id.Text = dr("Cat_id").ToString
                edit_cat.Cat_name.Text = dr("Cat_name").ToString

            End While

            dr.Close()
            Con.Close()

        Catch ex As Exception
            Con.Close()

        End Try
        Me.Close()
        edit_cat.ShowDialog()

    End Sub

    Private Sub edit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_btn.Click
        get_data_to_edit()

    End Sub
    Public Sub Delete_Cat_tbl(ByVal DGV_cat As DataGridView)
        Dim Position As Integer = DGV_cat.CurrentRow.Index
        Dim ID_Position As Integer = DGV_cat.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Cat_tbl Where Cat_id = @Cat_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Cat_id", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف الصنف بنجاح.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

    Private Sub del_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del_btn.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Cat_tbl(DGV_cat)
        End If
        load_cat()

    End Sub

    Private Sub excel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excel_btn.Click

        dgv_ExportDataToExcelFile(DGV_cat)


    End Sub
    Private Sub word_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles word_btn.Click
        ExportToWord(DGV_cat, "قائمة الاصناف")
    End Sub
   

  
End Class