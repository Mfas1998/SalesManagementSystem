Imports System.Data.SqlClient

Public Class add_unit

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()

    End Sub
    Public Sub ClearControls()
        Me.unit_id.Text = vbNullString
        Me.unit_name.Text = vbNullString
    End Sub

    Private Sub add_unit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        unit_id.Text = Max_ID("Unit_table", "unit_id") + 1
        unit_name.Focus()

    End Sub
    Public Sub Insert_Unit_tbl(ByVal unit_id As Int32, ByVal unit_name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Unit_table ( unit_id,unit_name)values(@unit_id,@unit_name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@unit_id", SqlDbType.Int).Value = unit_id
            .Parameters.AddWithValue("@unit_name", SqlDbType.VarChar).Value = unit_name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()

        Cmd.ExecuteNonQuery()

        Con.Close()
        MsgBox("تم إضافة الوحدة بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        If unit_name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If


        Insert_Unit_tbl(unit_id.Text, unit_name.Text)
        If MessageBox.Show("هل تريد إضافة وحدة جديدة ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then

            Me.Close()
            Dim frm As New frm_unit
            frm.TopLevel = False
            home.home_panel.Controls.Add(frm)
            frm.BringToFront()
            frm.Show()
        Else
            ClearControls()
            unit_id.Text = Max_ID("Unit_table", "unit_id") + 1
            unit_name.Focus()


        End If
    End Sub
End Class