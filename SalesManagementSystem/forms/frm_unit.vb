Imports System.Data.SqlClient

Public Class frm_unit

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub
    Public Sub load_unit()
        Try
            DGV_unit.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand("Select * from unit_table", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read

                DGV_unit.Rows.Add(dr("unit_id").ToString, dr("unit_name").ToString)
            End While
            dr.Close()
            Con.Close()

        Catch ex As Exception
            Con.Close()

        End Try
    End Sub

    Private Sub frm_unit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_unit()
    End Sub

    Private Sub add_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_btn.Click
        Me.Close()
        add_unit.ShowDialog()

    End Sub

    Private Sub edit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_btn.Click
        get_data_to_edit()
    End Sub
    Public Sub get_data_to_edit()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand("select * from Unit_table where unit_id=@unit_id", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("unit_id", SqlDbType.Int).Value = DGV_unit.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                edit_unit.unit_id.Text = dr("unit_id").ToString
                edit_unit.unit_name.Text = dr("unit_name").ToString

            End While

            dr.Close()
            Con.Close()

        Catch ex As Exception
            Con.Close()

        End Try
        Me.Close()
        edit_unit.ShowDialog()

    End Sub
    Public Sub Delete_Unit_table(ByVal dgv_Unit_table As DataGridView)
        Dim Position As Integer = DGV_unit.CurrentRow.Index
        Dim ID_Position As Integer = DGV_unit.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Unit_table Where unit_id = @unit_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@unit_id", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم الوحدة بنجاح.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

    Private Sub del_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del_btn.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Unit_table(DGV_unit)
        End If
        load_unit()

    End Sub

    Private Sub excel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excel_btn.Click
        dgv_ExportDataToExcelFile(DGV_unit)

    End Sub

    Private Sub word_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles word_btn.Click
        ExportToWord(DGV_unit, "قائمة الوحدات")
    End Sub
End Class