Imports System.Data.SqlClient
Public Class FrmMasterRoom
    Sub awal()
        Dim FillData As String = "select r.ID, rt.Name 'RoomClass',r.RoomNumber,r.RoomFloor,r.RoomStatus,r.Description, rt.RoomPrice from Room R inner join RoomType Rt on Rt.ID = R.RoomTypeID;"
        Koneksi()
        Da = New SqlDataAdapter(FillData, Conn)
        Ds = New DataSet
        Da.Fill(Ds, "room")

        Guna2DataGridView1.DataSource = Ds.Tables("room")
        Guna2DataGridView1.ReadOnly = True
        Guna2DataGridView1.AllowUserToDeleteRows = False
        Guna2DataGridView1.AllowUserToAddRows = False

        Guna2DataGridView1.ColumnHeadersHeight = 32
        Guna2DataGridView1.DefaultCellStyle.Font = New Font("Segoe UI", 12)
        Guna2DataGridView1.Columns(0).Visible = False
    End Sub
    Private Sub FrmMasterRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        sembunyi()
        tampil(FrmEditorRoom)
    End Sub
End Class