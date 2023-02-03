<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.إدارةالاصنافToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.إدارةالوحداتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.إدارةالمنتجاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.إدارةالعملاءToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.home_panel = New System.Windows.Forms.Panel()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.إدارةالموردينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.إدارةالمشترياتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.فاتورةمشترياتجديدةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.main_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 42)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(556, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نظام إدارة المبيعات"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 100)
        Me.Panel2.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 100)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ملفToolStripMenuItem
        '
        Me.ملفToolStripMenuItem.AutoSize = False
        Me.ملفToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ملفToolStripMenuItem.Image = Global.SalesManagementSystem.My.Resources.Resources.folder_48
        Me.ملفToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ملفToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        Me.ملفToolStripMenuItem.Size = New System.Drawing.Size(94, 80)
        Me.ملفToolStripMenuItem.Text = "ملف"
        Me.ملفToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ملفToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.إدارةالاصنافToolStripMenuItem, Me.إدارةالوحداتToolStripMenuItem, Me.إدارةالمنتجاتToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.SalesManagementSystem.My.Resources.Resources.product_icon
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(94, 80)
        Me.ToolStripMenuItem1.Text = "المنتجات"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'إدارةالاصنافToolStripMenuItem
        '
        Me.إدارةالاصنافToolStripMenuItem.Name = "إدارةالاصنافToolStripMenuItem"
        Me.إدارةالاصنافToolStripMenuItem.Size = New System.Drawing.Size(192, 30)
        Me.إدارةالاصنافToolStripMenuItem.Text = "إدارة الاصناف"
        '
        'إدارةالوحداتToolStripMenuItem
        '
        Me.إدارةالوحداتToolStripMenuItem.Name = "إدارةالوحداتToolStripMenuItem"
        Me.إدارةالوحداتToolStripMenuItem.Size = New System.Drawing.Size(192, 30)
        Me.إدارةالوحداتToolStripMenuItem.Text = "إدارة الوحدات"
        '
        'إدارةالمنتجاتToolStripMenuItem
        '
        Me.إدارةالمنتجاتToolStripMenuItem.Name = "إدارةالمنتجاتToolStripMenuItem"
        Me.إدارةالمنتجاتToolStripMenuItem.Size = New System.Drawing.Size(192, 30)
        Me.إدارةالمنتجاتToolStripMenuItem.Text = "إدارة المنتجات"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.AutoSize = False
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.إدارةالعملاءToolStripMenuItem})
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(94, 80)
        Me.ToolStripMenuItem2.Text = "العملاء"
        Me.ToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'إدارةالعملاءToolStripMenuItem
        '
        Me.إدارةالعملاءToolStripMenuItem.Name = "إدارةالعملاءToolStripMenuItem"
        Me.إدارةالعملاءToolStripMenuItem.Size = New System.Drawing.Size(177, 30)
        Me.إدارةالعملاءToolStripMenuItem.Text = "إدارة العملاء"
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.main_panel.Controls.Add(Me.home_panel)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Location = New System.Drawing.Point(0, 142)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(1284, 519)
        Me.main_panel.TabIndex = 3
        '
        'home_panel
        '
        Me.home_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.home_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.home_panel.Location = New System.Drawing.Point(0, 0)
        Me.home_panel.Name = "home_panel"
        Me.home_panel.Size = New System.Drawing.Size(1284, 519)
        Me.home_panel.TabIndex = 0
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.AutoSize = False
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.إدارةالموردينToolStripMenuItem})
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(94, 80)
        Me.ToolStripMenuItem3.Text = "الموردين"
        Me.ToolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'إدارةالموردينToolStripMenuItem
        '
        Me.إدارةالموردينToolStripMenuItem.Name = "إدارةالموردينToolStripMenuItem"
        Me.إدارةالموردينToolStripMenuItem.Size = New System.Drawing.Size(192, 30)
        Me.إدارةالموردينToolStripMenuItem.Text = "إدارة الموردين"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.AutoSize = False
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.إدارةالمشترياتToolStripMenuItem, Me.فاتورةمشترياتجديدةToolStripMenuItem})
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(94, 80)
        Me.ToolStripMenuItem4.Text = "المشتريات"
        Me.ToolStripMenuItem4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'إدارةالمشترياتToolStripMenuItem
        '
        Me.إدارةالمشترياتToolStripMenuItem.Name = "إدارةالمشترياتToolStripMenuItem"
        Me.إدارةالمشترياتToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.إدارةالمشترياتToolStripMenuItem.Text = "إدارة المشتريات"
        '
        'فاتورةمشترياتجديدةToolStripMenuItem
        '
        Me.فاتورةمشترياتجديدةToolStripMenuItem.Name = "فاتورةمشترياتجديدةToolStripMenuItem"
        Me.فاتورةمشترياتجديدةToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.فاتورةمشترياتجديدةToolStripMenuItem.Text = "فاتورة مشتريات جديدة"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.AutoSize = False
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(94, 80)
        Me.ToolStripMenuItem5.Text = "المبيعات"
        Me.ToolStripMenuItem5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.main_panel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "home"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.main_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ملفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents إدارةالاصنافToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents home_panel As System.Windows.Forms.Panel
    Friend WithEvents إدارةالوحداتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents إدارةالمنتجاتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents إدارةالعملاءToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents إدارةالموردينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents إدارةالمشترياتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents فاتورةمشترياتجديدةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem

End Class
