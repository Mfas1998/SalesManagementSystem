<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_unit
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
        Me.unit_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.unit_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'unit_name
        '
        Me.unit_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.unit_name.Location = New System.Drawing.Point(69, 127)
        Me.unit_name.MaxLength = 30
        Me.unit_name.Name = "unit_name"
        Me.unit_name.Size = New System.Drawing.Size(292, 31)
        Me.unit_name.TabIndex = 11
        Me.unit_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(367, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "إسم الوحدة:"
        '
        'unit_id
        '
        Me.unit_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.unit_id.Location = New System.Drawing.Point(69, 86)
        Me.unit_id.Name = "unit_id"
        Me.unit_id.ReadOnly = True
        Me.unit_id.Size = New System.Drawing.Size(292, 31)
        Me.unit_id.TabIndex = 10
        Me.unit_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(166, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "إضافة وحدة جديدة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(367, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "رقم الوحدة:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 44)
        Me.Panel1.TabIndex = 7
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.close_btn.FlatAppearance.BorderSize = 3
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.exit_2_321
        Me.close_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.close_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.close_btn.Location = New System.Drawing.Point(68, 184)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(145, 48)
        Me.close_btn.TabIndex = 13
        Me.close_btn.Text = "إغلاق الشاشة"
        Me.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.save_btn.FlatAppearance.BorderSize = 3
        Me.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.save_32
        Me.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.save_btn.Location = New System.Drawing.Point(276, 184)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(145, 48)
        Me.save_btn.TabIndex = 12
        Me.save_btn.Text = "حفظ البيانات"
        Me.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SalesManagementSystem.My.Resources.Resources.x_mark_3_32
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(441, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'add_unit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 242)
        Me.ControlBox = False
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.unit_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.unit_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "add_unit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents unit_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents unit_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
