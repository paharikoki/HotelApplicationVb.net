Imports System.Data.SqlClient
Public Class FrmEditorRoomType
    Dim id As String
    Sub awal()
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
        Guna2TextBox3.Text = ""
        Guna2NumericUpDown1.Minimum = 1
        Guna2NumericUpDown1.Maximum = 10
        Guna2TextBox3.MaxLength = 3
        Label6.Text = ""
        Label6.Text = PrivMeth.id

        If Label6.Text = "" Then
            Guna2Button1.Text = "Tambah"
        Else
            Dim getData As String = "select * from RoomType where id='" & Label6.Text & "'"
            Koneksi()
            Cmd = New SqlCommand(getData, Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            Guna2TextBox1.Text = Rd("Name")
            Guna2TextBox2.Text = Rd("RoomPrice")
            Guna2TextBox3.Text = Rd("RoomCode")
            Guna2NumericUpDown1.Value = Rd("Capacity")

            Guna2Button1.Text = "Simpan"
        End If
    End Sub

    Private Sub FrmEditorRoomType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        sembunyi()
        tampil(FrmMasterRoomType)
    End Sub

    Private Sub Guna2TextBox2_KeyPress(sender As Object, e As EventArgs) Handles Guna2TextBox2.KeyPress
        onlynumber(e)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Guna2Button1.Text = "Tambah" Then
            Dim InsertData As String = "insert into RoomType (Name,Capacity,RoomPrice,RoomCode) values('" & Guna2TextBox1.Text & "','" & Guna2NumericUpDown1.Value & "','" & Guna2TextBox2.Text & "','" & Guna2TextBox3.Text & "')"
            Koneksi()
            Cmd = New SqlCommand(InsertData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Menambahkan Data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            awal()
        ElseIf Guna2Button1.Text = "Simpan" Then
            Dim InsertData As String = "update RoomType set Name='" & Guna2TextBox1.Text & "',Capacity='" & Guna2NumericUpDown1.Value & "',RoomPrice='" & Guna2TextBox2.Text & "',RoomCode='" & Guna2TextBox3.Text & "' where id='" & Label6.Text & "'"
            Koneksi()
            Cmd = New SqlCommand(InsertData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil Mengedit Data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            awal()
        End If
    End Sub
End Class