<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGV_cust = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.word_btn = New System.Windows.Forms.Button()
        Me.excel_btn = New System.Windows.Forms.Button()
        Me.print_btn = New System.Windows.Forms.Button()
        Me.del_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_search = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_cust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(953, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "شاشة إدارة العملاء"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DGV_cust)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 106)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1184, 455)
        Me.Panel3.TabIndex = 8
        '
        'DGV_cust
        '
        Me.DGV_cust.AllowUserToAddRows = False
        Me.DGV_cust.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_cust.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_cust.ColumnHeadersHeight = 32
        Me.DGV_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_cust.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column6, Me.Column4, Me.Column5})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_cust.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_cust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_cust.EnableHeadersVisualStyles = False
        Me.DGV_cust.Location = New System.Drawing.Point(0, 0)
        Me.DGV_cust.Name = "DGV_cust"
        Me.DGV_cust.ReadOnly = True
        Me.DGV_cust.RowHeadersVisible = False
        Me.DGV_cust.RowTemplate.Height = 32
        Me.DGV_cust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_cust.Size = New System.Drawing.Size(1184, 455)
        Me.DGV_cust.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "رقم العميل"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "إسم العميل"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 350
        '
        'Column2
        '
        Me.Column2.HeaderText = "رقم الهاتف"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "العنوان"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "دائن"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "مدين"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.word_btn)
        Me.Panel2.Controls.Add(Me.excel_btn)
        Me.Panel2.Controls.Add(Me.print_btn)
        Me.Panel2.Controls.Add(Me.del_btn)
        Me.Panel2.Controls.Add(Me.edit_btn)
        Me.Panel2.Controls.Add(Me.add_btn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1184, 60)
        Me.Panel2.TabIndex = 7
        '
        'word_btn
        '
        Me.word_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.word_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.word_btn.FlatAppearance.BorderSize = 3
        Me.word_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.word_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.microsoft_word_32
        Me.word_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.word_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.word_btn.Location = New System.Drawing.Point(16, 6)
        Me.word_btn.Name = "word_btn"
        Me.word_btn.Size = New System.Drawing.Size(173, 48)
        Me.word_btn.TabIndex = 5
        Me.word_btn.Text = "تصدير الى الورد"
        Me.word_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.word_btn.UseVisualStyleBackColor = True
        '
        'excel_btn
        '
        Me.excel_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.excel_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.excel_btn.FlatAppearance.BorderSize = 3
        Me.excel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.excel_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.excel_3_32
        Me.excel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.excel_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.excel_btn.Location = New System.Drawing.Point(195, 6)
        Me.excel_btn.Name = "excel_btn"
        Me.excel_btn.Size = New System.Drawing.Size(173, 48)
        Me.excel_btn.TabIndex = 4
        Me.excel_btn.Text = "تصدير الى الإكسل"
        Me.excel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.excel_btn.UseVisualStyleBackColor = True
        '
        'print_btn
        '
        Me.print_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.print_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.print_btn.FlatAppearance.BorderSize = 3
        Me.print_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.print_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.printer_32
        Me.print_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.print_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.print_btn.Location = New System.Drawing.Point(374, 6)
        Me.print_btn.Name = "print_btn"
        Me.print_btn.Size = New System.Drawing.Size(209, 48)
        Me.print_btn.TabIndex = 3
        Me.print_btn.Text = "طباعة جميع العملاء"
        Me.print_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.print_btn.UseVisualStyleBackColor = True
        '
        'del_btn
        '
        Me.del_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.del_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.del_btn.FlatAppearance.BorderSize = 3
        Me.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.delete_property_32
        Me.del_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.del_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.del_btn.Location = New System.Drawing.Point(589, 6)
        Me.del_btn.Name = "del_btn"
        Me.del_btn.Size = New System.Drawing.Size(201, 48)
        Me.del_btn.TabIndex = 2
        Me.del_btn.Text = "حذف العميل المحدد"
        Me.del_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.del_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.edit_btn.FlatAppearance.BorderSize = 3
        Me.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.edit_11_32
        Me.edit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.edit_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.edit_btn.Location = New System.Drawing.Point(796, 6)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(198, 48)
        Me.edit_btn.TabIndex = 1
        Me.edit_btn.Text = "تعديل بيانات العميل"
        Me.edit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'add_btn
        '
        Me.add_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.add_btn.FlatAppearance.BorderSize = 3
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.plus_4_32
        Me.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.add_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.add_btn.Location = New System.Drawing.Point(1000, 6)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(184, 48)
        Me.add_btn.TabIndex = 0
        Me.add_btn.Text = "إضافة عميل جديد"
        Me.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tx_search)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 46)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(296, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 29)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "بحث"
        '
        'tx_search
        '
        Me.tx_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tx_search.Location = New System.Drawing.Point(16, 9)
        Me.tx_search.Name = "tx_search"
        Me.tx_search.Size = New System.Drawing.Size(274, 31)
        Me.tx_search.TabIndex = 44
        Me.tx_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SalesManagementSystem.My.Resources.Resources.x_mark_3_32
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(1140, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frm_customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_customers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV_cust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents word_btn As System.Windows.Forms.Button
    Friend WithEvents excel_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DGV_cust As System.Windows.Forms.DataGridView
    Friend WithEvents print_btn As System.Windows.Forms.Button
    Friend WithEvents del_btn As System.Windows.Forms.Button
    Friend WithEvents edit_btn As System.Windows.Forms.Button
    Friend WithEvents add_btn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tx_search As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
