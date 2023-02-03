<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_cat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_cat))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cat_id = New System.Windows.Forms.TextBox()
        Me.Cat_name = New System.Windows.Forms.TextBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(93, Byte), Integer))
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
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SalesManagementSystem.My.Resources.Resources.x_mark_3_32
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Cat_id
        '
        resources.ApplyResources(Me.Cat_id, "Cat_id")
        Me.Cat_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cat_id.Name = "Cat_id"
        Me.Cat_id.ReadOnly = True
        '
        'Cat_name
        '
        resources.ApplyResources(Me.Cat_name, "Cat_name")
        Me.Cat_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cat_name.Name = "Cat_name"
        '
        'close_btn
        '
        resources.ApplyResources(Me.close_btn, "close_btn")
        Me.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.close_btn.FlatAppearance.BorderSize = 3
        Me.close_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.exit_2_321
        Me.close_btn.Name = "close_btn"
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        resources.ApplyResources(Me.save_btn, "save_btn")
        Me.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.save_btn.FlatAppearance.BorderSize = 3
        Me.save_btn.Image = Global.SalesManagementSystem.My.Resources.Resources.save_32
        Me.save_btn.Name = "save_btn"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'add_cat
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.Cat_name)
        Me.Controls.Add(Me.Cat_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "add_cat"
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
    Friend WithEvents Cat_id As System.Windows.Forms.TextBox
    Friend WithEvents Cat_name As System.Windows.Forms.TextBox
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents close_btn As System.Windows.Forms.Button
End Class
