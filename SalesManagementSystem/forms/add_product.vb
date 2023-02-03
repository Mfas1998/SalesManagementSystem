Imports System.Data.SqlClient
Imports System.IO

Public Class add_product


    Private Sub cmb_Cat_id_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cat_id.DropDown
        fillcmb_Cat_tbl(cmb_Cat_id)
    End Sub

    Private Sub cmb_unit_id_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_unit_id.DropDown
        fillcmb_Unit_table(cmb_unit_id)
    End Sub

   

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()

    End Sub

    Private Sub add_product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        pro_id.Text = Max_ID("pro_tbl", "pro_id") + 1
        pro_code.Focus()
    End Sub
    Public Sub ClearControls()
        Me.pro_id.Text = vbNullString
        Me.pro_code.Text = vbNullString
        Me.pro_name.Text = vbNullString
        Me.cmb_Cat_id.Text = vbNullString
        Me.cmb_unit_id.Text = vbNullString

    End Sub

   Public Sub Insert_pro_tbl(ByVal pro_id AS Int32,ByVal pro_code AS String,ByVal pro_name AS String,ByVal Cat_id AS Int32,ByVal unit_id AS Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into pro_tbl ( pro_id,pro_code,pro_name,Cat_id,unit_id)values(@pro_id,@pro_code,@pro_name,@Cat_id,@unit_id)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@pro_id", SqlDbType.Int).Value = pro_id
            .Parameters.AddWithValue("@pro_code", SqlDbType.varchar).Value = pro_code
            .Parameters.AddWithValue("@pro_name", SqlDbType.varchar).Value = pro_name
            .Parameters.AddWithValue("@Cat_id", SqlDbType.Int).Value = Cat_id
            .Parameters.AddWithValue("@unit_id", SqlDbType.Int).Value = unit_id
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة بيانات المنتج بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub



    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        If pro_id.Text = vbNullString Or pro_code.Text = vbNullString Or pro_name.Text = vbNullString Or cmb_Cat_id.Text = vbNullString Or cmb_unit_id.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If




        Insert_pro_tbl(pro_id.Text, pro_code.Text, pro_name.Text, cmb_Cat_id.SelectedValue, cmb_unit_id.SelectedValue)


        If MessageBox.Show("هل تريد إضافة منتج جديد اخر", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then

            Me.Close()
            Dim frm As New frm_product
            frm.TopLevel = False
            home.home_panel.Controls.Add(frm)
            frm.BringToFront()
            frm.Show()
        Else
            ClearControls()
            pro_id.Text = Max_ID("pro_tbl", "pro_id") + 1
            pro_code.Focus()


        End If
    End Sub
End Class