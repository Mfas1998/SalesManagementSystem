Imports System.Data.SqlClient

Public Class edit_cust

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub
  
    Public Sub Update_cust_tbl(ByVal cust_name As String, ByVal cust_phone As String, ByVal cust_address As String, ByVal to_him As Double, ByVal on_him As Double, ByVal cust_idW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update cust_tbl Set cust_name = @cust_name,cust_phone = @cust_phone,cust_address = @cust_address,to_him = @to_him,on_him = @on_him Where cust_id = @cust_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@cust_name", SqlDbType.varchar).Value = cust_name
            .Parameters.AddWithValue("@cust_phone", SqlDbType.varchar).Value = cust_phone
            .Parameters.AddWithValue("@cust_address", SqlDbType.varchar).Value = cust_address
            .Parameters.AddWithValue("@to_him", SqlDbType.Decimal).Value = to_him
            .Parameters.AddWithValue("@on_him", SqlDbType.Decimal).Value = on_him
            .Parameters.AddWithValue("@cust_id", SqlDbType.Int).Value = cust_idW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل بيانات العميل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub



    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click

        If cust_id.Text = vbNullString Or cust_name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بإدخال إسم العميل", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Update_cust_tbl(cust_name.Text, cust_phone.Text, cust_address.Text, to_him.Text, on_him.Text, cust_id.Text)

        Me.Close()
        Dim frm As New frm_customers
        frm.TopLevel = False
        home.home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub



   
End Class