Public Class home

    

    Private Sub إدارةالاصنافToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إدارةالاصنافToolStripMenuItem.Click
        Dim frm As New frm_cat
        frm.TopLevel = False
        home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()



    End Sub

    Private Sub إدارةالوحداتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إدارةالوحداتToolStripMenuItem.Click
        Dim frm As New frm_unit
        frm.TopLevel = False
        home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub إضافةمنتججديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_product.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub إدارةالمنتجاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إدارةالمنتجاتToolStripMenuItem.Click
        Dim frm As New frm_product
        frm.TopLevel = False
        home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub إدارةالعملاءToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frm_customers
        frm.TopLevel = False
        home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub إدارةالعملاءToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إدارةالعملاءToolStripMenuItem.Click
        Dim frm As New frm_customers
        frm.TopLevel = False
        home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub home_panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles home_panel.Paint

    End Sub

   

    Private Sub إدارةالموردينToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إدارةالموردينToolStripMenuItem.Click
        Dim frm As New frm_importer
        frm.TopLevel = False
        home_panel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub
End Class
