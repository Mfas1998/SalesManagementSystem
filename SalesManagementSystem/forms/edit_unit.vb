Imports System.Data.SqlClient

Public Class edit_unit

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        If unit_name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Unit_table(unit_name.Text, unit_id.Text)
        Me.Close()
        Dim frm As New frm_unit
        frm.TopLevel = False
        home.home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub
    Public Sub Update_Unit_table(ByVal unit_name As String, ByVal unit_idW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Unit_table Set unit_name = @unit_name Where unit_id = @unit_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@unit_name", SqlDbType.VarChar).Value = unit_name
            .Parameters.AddWithValue("@unit_id", SqlDbType.Int).Value = unit_idW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل الوحدة بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
End Class