<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_product
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pro_id = New System.Windows.Forms.TextBox()
        Me.pro_code = New System.Windows.Forms.TextBox()
        Me.pro_name = New System.Windows.Forms.TextBox()
        Me.cmb_Cat_id = New System.Windows.Forms.ComboBox()
        Me.cmb_unit_id = New System.Windows.Forms.ComboBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 0
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
        Me.Label1.Size = New System.Drawing.Size(159, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "إضافة منتج جديد"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(600, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "رقم المنتج:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "باركود المنتج:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(600, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "اسم المنتج:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(599, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "صنف المنتج:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(600, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "وحدة المنتج:"
        '
        'pro_id
        '
        Me.pro_id.Location = New System.Drawing.Point(317, 77)
        Me.pro_id.Name = "pro_id"
        Me.pro_id.ReadOnly = True
        Me.pro_id.Size = New System.Drawing.Size(261, 31)
        Me.pro_id.TabIndex = 6
        Me.pro_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pro_code
        '
        Me.pro_code.Location = New System.Drawing.Point(317, 127)
        Me.pro_code.Name = "pro_code"
        Me.pro_code.Size = New System.Drawing.Size(261, 31)
        Me.pro_code.TabIndex = 7
        Me.pro_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pro_name
        '
        Me.pro_name.Location = New System.Drawing.Point(317, 178)
        Me.pro_name.Name = "pro_name"
        Me.pro_name.Size = New System.Drawing.Size(261, 31)
        Me.pro_name.TabIndex = 8
        Me.pro_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_Cat_id
        '
        Me.cmb_Cat_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cat_id.FormattingEnabled = True
        Me.cmb_Cat_id.Location = New System.Drawing.Point(317, 230)
        Me.cmb_Cat_id.Name = "cmb_Cat_id"
        Me.cmb_Cat_id.Size = New System.Drawing.Size(261, 31)
        Me.cmb_Cat_id.TabIndex = 9
        '
        'cmb_unit_id
        '
        Me.cmb_unit_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unit_id.FormattingEnabled = True
        Me.cmb_unit_id.Location = New System.Drawing.Point(317, 281)
        Me.cmb_unit_id.Name = "cmb_unit_id"
        Me.cmb_unit_id.Size = New System.Drawing.Size(261, 31)
        Me.cmb_unit_id.TabIndex = 10
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
        Me.close_btn.Location = New System.Drawing.Point(228, 341)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(145, 48)
        Me.close_btn.TabIndex = 14
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
        Me.save_btn.Location = New System.Drawing.Point(436, 341)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(145, 48)
        Me.save_btn.TabIndex = 13
        Me.save_btn.Text = "حفظ البيانات"
        Me.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.cmb_unit_id)
        Me.Controls.Add(Me.cmb_Cat_id)
        Me.Controls.Add(Me.pro_name)
        Me.Controls.Add(Me.pro_code)
        Me.Controls.Add(Me.pro_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "add_product"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pro_id As System.Windows.Forms.TextBox
    Friend WithEvents pro_code As System.Windows.Forms.TextBox
    Friend WithEvents pro_name As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Cat_id As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_unit_id As System.Windows.Forms.ComboBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents save_btn As System.Windows.Forms.Button
End Class
