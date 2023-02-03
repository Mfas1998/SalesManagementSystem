<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cat))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGV_cat = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.word_btn = New System.Windows.Forms.Button()
        Me.excel_btn = New System.Windows.Forms.Button()
        Me.print_btn = New System.Windows.Forms.Button()
        Me.del_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_cat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Name = "Panel1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.word_btn)
        Me.Panel2.Controls.Add(Me.excel_btn)
        Me.Panel2.Controls.Add(Me.print_btn)
        Me.Panel2.Controls.Add(Me.del_btn)
        Me.Panel2.Controls.Add(Me.edit_btn)
        Me.Panel2.Controls.Add(Me.add_btn)
        Me.Panel2.Name = "Panel2"
        '
        'Panel3
        '
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DGV_cat)
        Me.Panel3.Name = "Panel3"
        '
        'DGV_cat
        '
        resources.ApplyResources(Me.DGV_cat, "DGV_cat")
        Me.DGV_cat.AllowUserToAddRows = False
        Me.DGV_cat.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_cat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_cat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_cat.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_cat.EnableHeadersVisualStyles = False
        Me.DGV_cat.Name = "DGV_cat"
        Me.DGV_cat.ReadOnly = True
        Me.DGV_cat.RowHeadersVisible = False
        Me.DGV_cat.RowTemplate.Height = 32
        Me.DGV_cat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'word_btn
        '
        resources.ApplyResources(Me.word_btn, "word_btn")
        Me.word_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.word_btn.FlatAppearance.BorderSize = 3
        Me.word_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.microsoft_word_32
        Me.word_btn.Name = "word_btn"
        Me.word_btn.UseVisualStyleBackColor = True
        '
        'excel_btn
        '
        resources.ApplyResources(Me.excel_btn, "excel_btn")
        Me.excel_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.excel_btn.FlatAppearance.BorderSize = 3
        Me.excel_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.excel_3_32
        Me.excel_btn.Name = "excel_btn"
        Me.excel_btn.UseVisualStyleBackColor = True
        '
        'print_btn
        '
        resources.ApplyResources(Me.print_btn, "print_btn")
        Me.print_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.print_btn.FlatAppearance.BorderSize = 3
        Me.print_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.printer_32
        Me.print_btn.Name = "print_btn"
        Me.print_btn.UseVisualStyleBackColor = True
        '
        'del_btn
        '
        resources.ApplyResources(Me.del_btn, "del_btn")
        Me.del_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.del_btn.FlatAppearance.BorderSize = 3
        Me.del_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.delete_property_32
        Me.del_btn.Name = "del_btn"
        Me.del_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        resources.ApplyResources(Me.edit_btn, "edit_btn")
        Me.edit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.edit_btn.FlatAppearance.BorderSize = 3
        Me.edit_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.edit_11_32
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'add_btn
        '
        resources.ApplyResources(Me.add_btn, "add_btn")
        Me.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.add_btn.FlatAppearance.BorderSize = 3
        Me.add_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.plus_4_32
        Me.add_btn.Name = "add_btn"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SalesManagementSystem.My.Resources.Resources.x_mark_3_32
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'frm_cat
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_cat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV_cat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents add_btn As System.Windows.Forms.Button
    Friend WithEvents word_btn As System.Windows.Forms.Button
    Friend WithEvents excel_btn As System.Windows.Forms.Button
    Friend WithEvents print_btn As System.Windows.Forms.Button
    Friend WithEvents del_btn As System.Windows.Forms.Button
    Friend WithEvents edit_btn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DGV_cat As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
