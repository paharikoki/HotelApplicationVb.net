Imports System.Data.SqlClient
Public Class FrmEditorRoom
    Dim kode As String
    Sub awal()
        Guna2ComboBox1.Text = ""
        Guna2ComboBox1.Items.Clear()
        Guna2ComboBox2.Text = ""
        Guna2ComboBox2.Items.Clear()
        Guna2ComboBox2.Items.Add("Ready")
        Guna2ComboBox2.Items.Add("On Rent")
        Guna2ComboBox2.Items.Add("On Cleaning")
        Guna2ComboBox2.Items.Add("Broken")

        Dim FillRoomType As String = "select * from RoomType"
        Koneksi()
        Cmd = New SqlCommand(FillRoomType, Conn)
        Rd = Cmd.ExecuteReader
        While Rd.Read
            Guna2ComboBox1.Items.Add(Rd("Name"))
        End While
        Guna2NumericUpDown1.Minimum = 1
        Guna2NumericUpDown1.Maximum = 7
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        sembunyi()
        tampil(FrmMasterRoom)
    End Sub

    Private Sub FrmEditorRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        Dim getId As String = "select * from RoomType where name='" & Guna2ComboBox1.Text & "'"
        Koneksi()
        Cmd = New SqlCommand(getId, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        Label7.Text = Rd(0)
        kode = Rd(4)

    End Sub
End Class