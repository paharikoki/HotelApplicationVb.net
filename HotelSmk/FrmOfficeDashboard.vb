Imports LiveCharts.WinForms
Imports LiveCharts
Imports LiveCharts.Wpf
Public Class FrmOfficeDashboard
    Private Sub FrmOfficeDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuChartCanvas1_Load(sender As Object, e As EventArgs) Handles BunifuChartCanvas1.Load
        BunifuDoughnutChart1.Data.Add(24)
        BunifuDoughnutChart1.Data.Add(54)
        BunifuDoughnutChart1.Data.Add(65)
        BunifuDoughnutChart1.BackgroundColor.Add(Color.FromArgb(23, 124, 32))
        BunifuDoughnutChart1.BackgroundColor.Add(Color.FromArgb(244, 46, 32))
        BunifuDoughnutChart1.BackgroundColor.Add(Color.FromArgb(23, 64, 75))
        BunifuChartCanvas1.Labels = New String() {"Data 1", "Data 2", "Data 3"}
    End Sub
End Class