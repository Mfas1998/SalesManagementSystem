Imports System.Data.SqlClient

Public Class add_customers

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()

    End Sub

    Private Sub add_customers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        cust_id.Text = Max_ID("cust_tbl", "cust_id") + 1
        to_him.Text = 0.0
        on_him.Text = 0.0
        cust_name.Focus()

    End Sub
    Public Sub ClearControls()
        Me.cust_id.Text = vbNullString
        Me.cust_name.Text = vbNullString
        Me.cust_phone.Text = vbNullString
        Me.cust_address.Text = vbNullString
        Me.to_him.Text = vbNullString
        Me.on_him.Text = vbNullString

    End Sub

    Public Sub Insert_cust_tbl(ByVal cust_id As Int32, ByVal cust_name As String, ByVal cust_phone As String, ByVal cust_address As String, ByVal to_him As Double, ByVal on_him As Double)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into cust_tbl ( cust_id,cust_name,cust_phone,cust_address,to_him,on_him)values(@cust_id,@cust_name,@cust_phone,@cust_address,@to_him,@on_him)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@cust_id", SqlDbType.Int).Value = cust_id
            .Parameters.AddWithValue("@cust_name", SqlDbType.VarChar).Value = cust_name
            .Parameters.AddWithValue("@cust_phone", SqlDbType.VarChar).Value = cust_phone
            .Parameters.AddWithValue("@cust_address", SqlDbType.VarChar).Value = cust_address
            .Parameters.AddWithValue("@to_him", SqlDbType.Decimal).Value = to_him
            .Parameters.AddWithValue("@on_him", SqlDbType.Decimal).Value = on_him
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة بيانات العميل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        If cust_id.Text = vbNullString Or cust_name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بإدخال إسم العميل", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If


        Insert_cust_tbl(cust_id.Text, cust_name.Text, cust_phone.Text, cust_address.Text, to_him.Text, on_him.Text)
        If MessageBox.Show("هل تريد إضافةعميل جديد اخر", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then

            Me.Close()
            Dim frm As New frm_customers
            frm.TopLevel = False
            home.home_panel.Controls.Add(frm)
            frm.BringToFront()
            frm.Show()
        Else
            ClearControls()
            cust_id.Text = Max_ID("cust_tbl", "cust_id") + 1
            cust_name.Focus()


        End If
    End Sub
End Class