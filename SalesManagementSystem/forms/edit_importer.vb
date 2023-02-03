Imports System.Data.SqlClient

Public Class edit_importer

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()

    End Sub


    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        If imp_id.Text = vbNullString Or imp_name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بإدخال إسم المورد", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Update_imp_tbl(imp_name.Text, imp_phone.Text, imp_address.Text, to_him.Text, on_him.Text, imp_id.Text)

        Me.Close()
        Dim frm As New frm_importer
        frm.TopLevel = False
        home.home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub
   
    Public Sub Update_imp_tbl(ByVal imp_name As String, ByVal imp_phone As String, ByVal imp_address As String, ByVal to_him As Double, ByVal on_him As Double, ByVal imp_idW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update imp_tbl Set imp_name = @imp_name,imp_phone = @imp_phone,imp_address = @imp_address,to_him = @to_him,on_him = @on_him Where imp_id = @imp_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@imp_name", SqlDbType.VarChar).Value = imp_name
            .Parameters.AddWithValue("@imp_phone", SqlDbType.VarChar).Value = imp_phone
            .Parameters.AddWithValue("@imp_address", SqlDbType.VarChar).Value = imp_address
            .Parameters.AddWithValue("@to_him", SqlDbType.Decimal).Value = to_him
            .Parameters.AddWithValue("@on_him", SqlDbType.Decimal).Value = on_him
            .Parameters.AddWithValue("@imp_id", SqlDbType.Int).Value = imp_idW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل بيانات المورد بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

End Class