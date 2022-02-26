Public Class FrmMainOffice

    Sub awal()
        sembunyi()
        FrmOfficeDashboard.TopLevel = False
        Panel3.Controls.Add(FrmOfficeDashboard)
        FrmOfficeDashboard.Show()
        Label3.Text = Format(DateTime.Now, "dddd, dd MMMM yyyy")
    End Sub
    Private Sub FrmMainOffice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        End
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        sembunyi()
        tampil(FrmOfficeDashboardRoom)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        awal()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        sembunyi()
        tampil(FrmTestChart)
    End Sub
End Class