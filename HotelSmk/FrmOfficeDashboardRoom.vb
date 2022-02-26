Imports System.Data.SqlClient
Public Class FrmOfficeDashboardRoom
    Sub awal()
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
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim FillDataRoom As String = "select * from Room"
        Koneksi()
        Da = New SqlDataAdapter(FillDataRoom, Conn)
        Ds = New DataSet
        Da.Fill(Ds, "Room")

        Guna2DataGridView2.DataSource = Ds.Tables("Room")
        Guna2DataGridView2.ReadOnly = True
        Guna2DataGridView2.AllowUserToAddRows = False
        Guna2DataGridView2.AllowUserToDeleteRows = False
        Guna2DataGridView2.ColumnHeadersHeight = 32
        Guna2DataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Guna2DataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        Guna2DataGridView2.Columns(0).Visible = False
    End Sub
    Private Sub FrmOfficeDashboardRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        sembunyi()
        tampil(FrmMasterRoom)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        sembunyi
        tampil(FrmMasterRoomType)
    End Sub
End Class