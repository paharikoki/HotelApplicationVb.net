Imports System.Data.SqlClient
Public Class FrmLogin
    Sub awal()
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
        Guna2TextBox3.Text = ""
        captcha()
    End Sub
    Sub captcha()
        Dim nilai As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789"
        Dim hasil As String = ""

        Dim count = 0
        Dim rand As New Random
        Dim strpost = ""
        While count < 5
            strpost = rand.Next(0, nilai.Length)
            hasil = hasil & nilai(strpost)
            count = count + 1
        End While

        Label5.Text = hasil

    End Sub
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        End
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim leveluser As String
        If Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Or Guna2TextBox3.Text = "" Then
            MessageBox.Show("Harap isi semua field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Not Guna2TextBox3.Text = Label5.Text Then
                MessageBox.Show("Captcha Tidak Sesuai", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Guna2TextBox3.Text = ""
                captcha()
                Guna2TextBox3.Select()
            Else
                Dim Login As String = "select * from Employee inner join Job on Job.ID = Employee.JobID where username='" & Guna2TextBox1.Text & "' AND password='" & Guna2TextBox2.Text & "'"
                Koneksi()
                Cmd = New SqlCommand(Login, Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    PrivMeth.Iduser = Rd(0)
                    leveluser = Rd(8)

                    If leveluser = 1 Then
                        MessageBox.Show("Selamat Datang " + Rd(3), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
                        )
                        awal()
                    ElseIf leveluser = 2 Then
                        MessageBox.Show("Selamat Datang " + Rd(3), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
                        )
                        FrmMainOffice.Show()
                        Me.Hide()
                        awal()
                    ElseIf leveluser = 3 Then
                        MessageBox.Show("Selamat Datang " + Rd(3), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
                        )
                        awal()
                    ElseIf leveluser = 4 Then
                        MessageBox.Show("Selamat Datang " + Rd(3), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information
                        )
                        awal()
                    End If
                End If

            End If
        End If
    End Sub
End Class