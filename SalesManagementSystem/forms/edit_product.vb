Imports System.Data.SqlClient

Public Class edit_product

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()

    End Sub
    Public Sub Update_pro_tbl(ByVal pro_id As Int32, ByVal pro_code As String, ByVal pro_name As String, ByVal Cat_id As Int32, ByVal unit_id As Int32, ByVal pro_idW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update pro_tbl Set pro_id = @pro_id,pro_code = @pro_code,pro_name = @pro_name,Cat_id = @Cat_id,unit_id = @unit_id Where pro_id = @pro_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@pro_id", SqlDbType.Int).Value = pro_id
            .Parameters.AddWithValue("@pro_code", SqlDbType.VarChar).Value = pro_code
            .Parameters.AddWithValue("@pro_name", SqlDbType.VarChar).Value = pro_name
            .Parameters.AddWithValue("@Cat_id", SqlDbType.Int).Value = Cat_id
            .Parameters.AddWithValue("@unit_id", SqlDbType.Int).Value = unit_id

        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()

        Con.Close()
        MsgBox("تم تعديل بيانات المنتج بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        If pro_id.Text = vbNullString Or pro_code.Text = vbNullString Or pro_name.Text = vbNullString Or cmb_Cat_id.Text = vbNullString Or cmb_unit_id.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_pro_tbl(pro_id.Text, pro_code.Text, pro_name.Text, cmb_Cat_id.SelectedValue, cmb_unit_id.SelectedValue, pro_id.Text)
        Me.Close()
        Dim frm As New frm_product
        frm.TopLevel = False
        home.home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    
End Class