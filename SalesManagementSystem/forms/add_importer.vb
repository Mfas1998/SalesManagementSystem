Imports System.Data.SqlClient

Public Class add_importer

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()

    End Sub

    Public Sub ClearControls()
        Me.imp_id.Text = vbNullString
        Me.imp_name.Text = vbNullString
        Me.imp_phone.Text = vbNullString
        Me.imp_address.Text = vbNullString
        Me.to_him.Text = vbNullString
        Me.on_him.Text = vbNullString

    End Sub

    Private Sub add_importer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        imp_id.Text = Max_ID("imp_tbl", "imp_id") + 1
        to_him.Text = 0.0
        on_him.Text = 0.0
        imp_name.Focus()
    End Sub


    Public Sub Insert_imp_tbl(ByVal imp_id As Int32, ByVal imp_name As String, ByVal imp_phone As String, ByVal imp_address As String, ByVal to_him As Double, ByVal on_him As Double)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into imp_tbl ( imp_id,imp_name,imp_phone,imp_address,to_him,on_him)values(@imp_id,@imp_name,@imp_phone,@imp_address,@to_him,@on_him)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@imp_id", SqlDbType.Int).Value = imp_id
            .Parameters.AddWithValue("@imp_name", SqlDbType.VarChar).Value = imp_name
            .Parameters.AddWithValue("@imp_phone", SqlDbType.VarChar).Value = imp_phone
            .Parameters.AddWithValue("@imp_address", SqlDbType.VarChar).Value = imp_address
            .Parameters.AddWithValue("@to_him", SqlDbType.Decimal).Value = to_him
            .Parameters.AddWithValue("@on_him", SqlDbType.Decimal).Value = on_him
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة بيانات المورد بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click


        If imp_id.Text = vbNullString Or imp_name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بإدخال إسم المورد", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If


        Insert_imp_tbl(imp_id.Text, imp_name.Text, imp_phone.Text, imp_address.Text, to_him.Text, on_him.Text)
        If MessageBox.Show("هل تريد إضافةمورد جديد اخر", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then

            Me.Close()
            Dim frm As New frm_importer
            frm.TopLevel = False
            home.home_panel.Controls.Add(frm)
            frm.BringToFront()
            frm.Show()
        Else
            ClearControls()
            imp_id.Text = Max_ID("imp_tbl", "imp_id") + 1
            imp_name.Focus()


        End If
    End Sub

End Class