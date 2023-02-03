Imports System.Data.SqlClient



Module Main_Module
    Public Function Max_ID(ByVal TableName As String, ByVal ColumnName As String)
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("select max(" & ColumnName & ") From " & TableName & "", Con)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar

            Con.Close()
        Catch ex As Exception
            Number = 0
            Con.Close()
        End Try
        Return Number
    End Function


    Public Sub fillcmb_Cat_tbl(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Cat_tbl ", con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "Cat_name"
            cmb.ValueMember = "Cat_id"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub


    Public Sub fillcmb_Unit_table(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Unit_table ", con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "unit_name"
            cmb.ValueMember = "unit_id"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub ChoosePicture(ByVal Pbox As PictureBox)
        Dim a As New OpenFileDialog
        With a
            .AddExtension = True
            .CheckPathExists = True
            .CheckFileExists = True
            .Title = "Choose Image"
            .Filter = "Choose Image (*.PNG; *.JPG; *.GIF; *.JPEG)| *.PNG; *.JPG; *.GIF; *.JPEG | All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                PBox.Image = Image.FromFile(.FileName)
            End If
        End With
    End Sub

End Module
