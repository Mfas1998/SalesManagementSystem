Imports System.Data.SqlClient

Public Class edit_cat

    Private Sub edit_cat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Public Sub Update_Cat_tbl(ByVal Cat_name As String, ByVal Cat_idW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Cat_tbl Set Cat_name = @Cat_name Where Cat_id = @Cat_id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Cat_name", SqlDbType.varchar).Value = Cat_name
            .Parameters.AddWithValue("@Cat_id", SqlDbType.Int).Value = Cat_idW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل الصنف بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub




    Private Sub add_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_btn.Click
        If Cat_name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Cat_tbl(Cat_name.Text, Cat_id.Text)
        Me.Close()
        Dim frm As New frm_cat
        frm.TopLevel = False
        home.home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub
End Class