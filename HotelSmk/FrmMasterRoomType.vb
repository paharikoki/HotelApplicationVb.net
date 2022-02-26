Imports System.Data.SqlClient
Public Class FrmMasterRoomType
    Sub awal()
        PrivMeth.id = ""
        Dim FilldataRoomType As String = "select * from RoomType"
        Koneksi()
        Da = New SqlDataAdapter(FilldataRoomType, Conn)
        Ds = New DataSet
        Da.Fill(Ds, "RoomType")

        Guna2DataGridView1.DataSource = Ds.Tables("RoomType")
        Guna2DataGridView1.ReadOnly = True
        Guna2DataGridView1.AllowUserToAddRows = False
        Guna2DataGridView1.AllowUserToDeleteRows = False

        Guna2DataGridView1.Columns(0).Visible = False
        Guna2DataGridView1.ColumnHeadersHeight = 32
        Guna2DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Guna2DataGridView1.DefaultCellStyle.Font = New Font("Segoe UI", 12)
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
    Private Sub FrmMasterRoomType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        sembunyi()
        tampil(FrmEditorRoomType)
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        Dim i As Integer
        i = Guna2DataGridView1.CurrentRow.Index

        PrivMeth.id = Guna2DataGridView1.Item(0, i).Value
        FrmEditorRoomType.Guna2TextBox1.Text = Guna2DataGridView1.Item(1, i).Value
        FrmEditorRoomType.Guna2NumericUpDown1.Value = Guna2DataGridView1.Item(2, i).Value
        FrmEditorRoomType.Guna2TextBox2.Text = Guna2DataGridView1.Item(3, i).Value
        FrmEditorRoomType.Guna2TextBox3.Text = Guna2DataGridView1.Item(4, i).Value
        FrmEditorRoomType.Label6.Text = PrivMeth.id
        Guna2DataGridView1.ContextMenuStrip = Guna2ContextMenuStrip1
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        sembunyi()
        tampil(FrmEditorRoomType)
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        If PrivMeth.id = "" Then
            MessageBox.Show("Silakan Pilih Data Terlebih Dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim DeleteData As String = "delete from RoomType where id='" & PrivMeth.id & "'"
            Koneksi()
            Cmd = New SqlCommand(DeleteData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Menghapus Data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            awal()
        End If
    End Sub
End Class
