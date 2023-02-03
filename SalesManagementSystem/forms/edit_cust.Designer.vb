<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_cust
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.on_him = New System.Windows.Forms.TextBox()
        Me.to_him = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cust_address = New System.Windows.Forms.TextBox()
        Me.cust_phone = New System.Windows.Forms.TextBox()
        Me.cust_name = New System.Windows.Forms.TextBox()
        Me.cust_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'on_him
        '
        Me.on_him.Location = New System.Drawing.Point(317, 294)
        Me.on_him.Name = "on_him"
        Me.on_him.ReadOnly = True
        Me.on_him.Size = New System.Drawing.Size(71, 31)
        Me.on_him.TabIndex = 49
        Me.on_him.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'to_him
        '
        Me.to_him.Location = New System.Drawing.Point(510, 295)
        Me.to_him.Name = "to_him"
        Me.to_him.ReadOnly = True
        Me.to_him.Size = New System.Drawing.Size(71, 31)
        Me.to_him.TabIndex = 48
        Me.to_him.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 23)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "مدين:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(600, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 23)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "دائن:"
        '
        'cust_address
        '
        Me.cust_address.Location = New System.Drawing.Point(317, 235)
        Me.cust_address.Multiline = True
        Me.cust_address.Name = "cust_address"
        Me.cust_address.Size = New System.Drawing.Size(261, 31)
        Me.cust_address.TabIndex = 45
        Me.cust_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cust_phone
        '
        Me.cust_phone.Location = New System.Drawing.Point(317, 191)
        Me.cust_phone.Name = "cust_phone"
        Me.cust_phone.Size = New System.Drawing.Size(261, 31)
        Me.cust_phone.TabIndex = 44
        Me.cust_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cust_name
        '
        Me.cust_name.Location = New System.Drawing.Point(317, 140)
        Me.cust_name.Name = "cust_name"
        Me.cust_name.Size = New System.Drawing.Size(261, 31)
        Me.cust_name.TabIndex = 43
        Me.cust_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cust_id
        '
        Me.cust_id.Location = New System.Drawing.Point(317, 90)
        Me.cust_id.Name = "cust_id"
        Me.cust_id.ReadOnly = True
        Me.cust_id.Size = New System.Drawing.Size(261, 31)
        Me.cust_id.TabIndex = 40
        Me.cust_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(599, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 23)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "العنوان:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(282, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "تعديل بيانات العميل"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(600, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 23)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "رقم الهاتف:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "إسم العميل:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(600, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 23)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "رقم العميل:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(717, 47)
        Me.Panel1.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SalesManagementSystem.My.Resources.Resources.x_mark_3_32
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(677, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.close_btn.FlatAppearance.BorderSize = 3
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.exit_2_321
        Me.close_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.close_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.close_btn.Location = New System.Drawing.Point(228, 354)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(145, 48)
        Me.close_btn.TabIndex = 42
        Me.close_btn.Text = "إغلاق الشاشة"
        Me.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.save_btn.FlatAppearance.BorderSize = 3
        Me.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.save_32
        Me.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.save_btn.Location = New System.Drawing.Point(436, 354)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(145, 48)
        Me.save_btn.TabIndex = 41
        Me.save_btn.Text = "حفظ البيانات"
        Me.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'edit_cust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.on_him)
        Me.Controls.Add(Me.to_him)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cust_address)
        Me.Controls.Add(Me.cust_phone)
        Me.Controls.Add(Me.cust_name)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.cust_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "edit_cust"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents on_him As System.Windows.Forms.TextBox
    Friend WithEvents to_him As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cust_address As System.Windows.Forms.TextBox
    Friend WithEvents cust_phone As System.Windows.Forms.TextBox
    Friend WithEvents cust_name As System.Windows.Forms.TextBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents cust_id As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
