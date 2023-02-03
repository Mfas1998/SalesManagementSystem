Imports System.Data.SqlClient

Public Class add_cat



    Private Sub add_cat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        Cat_id.Text = Max_ID("Cat_tbl", "Cat_id") + 1
        Cat_name.Focus()


    End Sub

    Public Sub ClearControls()
        Me.Cat_id.Text = vbNullString
        Me.Cat_name.Text = vbNullString
    End Sub

    Public Sub Insert_Cat_tbl(ByVal Cat_id As Int32, ByVal Cat_name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Cat_tbl ( Cat_id,Cat_name)values(@Cat_id,@Cat_name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Cat_id", SqlDbType.Int).Value = Cat_id
            .Parameters.AddWithValue("@Cat_name", SqlDbType.varchar).Value = Cat_name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة الصنف بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub




    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        If Cat_name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If


        Insert_Cat_tbl(Cat_id.Text, Cat_name.Text)
        If MessageBox.Show("هل تريد إضافة صنف جديد اخر", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then

            Me.Close()
            Dim frm As New frm_cat
            frm.TopLevel = False
            home.home_panel.Controls.Add(frm)
            frm.BringToFront()
            frm.Show()
        Else
            ClearControls()
            Cat_id.Text = Max_ID("Cat_tbl", "Cat_id") + 1
            Cat_name.Focus()


        End If




    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()

    End Sub
End Class