<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTestChart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTestChart))
        Me.BunifuBarChart1 = New Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(Me.components)
        Me.BunifuChartCanvas1 = New Bunifu.Charts.WinForms.BunifuChartCanvas()
        Me.BunifuDoughnutChart1 = New Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart(Me.components)
        Me.SuspendLayout()
        '
        'BunifuBarChart1
        '
        Me.BunifuBarChart1.BackgroundColor = CType(resources.GetObject("BunifuBarChart1.BackgroundColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuBarChart1.BorderColor = CType(resources.GetObject("BunifuBarChart1.BorderColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuBarChart1.BorderSkipped = Nothing
        Me.BunifuBarChart1.BorderWidth = 0
        Me.BunifuBarChart1.Data = CType(resources.GetObject("BunifuBarChart1.Data"), System.Collections.Generic.List(Of Double))
        Me.BunifuBarChart1.HoverBackgroundColor = System.Drawing.Color.Empty
        Me.BunifuBarChart1.HoverBorderColor = System.Drawing.Color.Empty
        Me.BunifuBarChart1.HoverBorderWidth = 0
        Me.BunifuBarChart1.Label = "Label here"
        Me.BunifuBarChart1.TargetCanvas = Nothing
        '
        'BunifuChartCanvas1
        '
        Me.BunifuChartCanvas1.AnimationDuration = 1000
        Me.BunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutCubic
        Me.BunifuChartCanvas1.BackColor = System.Drawing.Color.White
        Me.BunifuChartCanvas1.CanvasPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuChartCanvas1.Labels = New String() {"Data1", "Data2", "Data3"}
        Me.BunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center
        Me.BunifuChartCanvas1.LegendDisplay = True
        Me.BunifuChartCanvas1.LegendFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuChartCanvas1.LegendForeColor = System.Drawing.Color.DarkGray
        Me.BunifuChartCanvas1.LegendFullWidth = True
        Me.BunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom
        Me.BunifuChartCanvas1.LegendRevese = False
        Me.BunifuChartCanvas1.LegendRTL = False
        Me.BunifuChartCanvas1.Location = New System.Drawing.Point(31, 35)
        Me.BunifuChartCanvas1.Name = "BunifuChartCanvas1"
        Me.BunifuChartCanvas1.ShowXAxis = False
        Me.BunifuChartCanvas1.ShowYAxis = False
        Me.BunifuChartCanvas1.Size = New System.Drawing.Size(432, 253)
        Me.BunifuChartCanvas1.TabIndex = 0
        Me.BunifuChartCanvas1.Title = ""
        Me.BunifuChartCanvas1.TitleLineHeight = 1.2R
        Me.BunifuChartCanvas1.TitlePadding = 10
        Me.BunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top
        Me.BunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest
        Me.BunifuChartCanvas1.TooltipsEnabled = True
        Me.BunifuChartCanvas1.XAxesBeginAtZero = True
        Me.BunifuChartCanvas1.XAxesDrawTicks = False
        Me.BunifuChartCanvas1.XAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.XAxesGridLines = True
        Me.BunifuChartCanvas1.XAxesLabel = ""
        Me.BunifuChartCanvas1.XAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.XAxesLineWidth = 1
        Me.BunifuChartCanvas1.XAxesStacked = False
        Me.BunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.XAxesZeroLineWidth = 1
        Me.BunifuChartCanvas1.YAxesBeginAtZero = True
        Me.BunifuChartCanvas1.YAxesDrawTicks = True
        Me.BunifuChartCanvas1.YAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.YAxesGridLines = False
        Me.BunifuChartCanvas1.YAxesLabel = ""
        Me.BunifuChartCanvas1.YAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText
        Me.BunifuChartCanvas1.YAxesLineWidth = 1
        Me.BunifuChartCanvas1.YAxesStacked = False
        Me.BunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.YAxesZeroLineWidth = 1
        '
        'BunifuDoughnutChart1
        '
        Me.BunifuDoughnutChart1.BackgroundColor = CType(resources.GetObject("BunifuDoughnutChart1.BackgroundColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuDoughnutChart1.BorderColor = CType(resources.GetObject("BunifuDoughnutChart1.BorderColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuDoughnutChart1.BorderWidth = 0
        Me.BunifuDoughnutChart1.Data = CType(resources.GetObject("BunifuDoughnutChart1.Data"), System.Collections.Generic.List(Of Double))
        Me.BunifuDoughnutChart1.HoverBackgroundColor = System.Drawing.Color.Empty
        Me.BunifuDoughnutChart1.HoverBorderColor = System.Drawing.Color.Empty
        Me.BunifuDoughnutChart1.HoverBorderWidth = 0
        Me.BunifuDoughnutChart1.Label = "label here"
        Me.BunifuDoughnutChart1.TargetCanvas = Me.BunifuChartCanvas1
        '
        'FrmTestChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BunifuChartCanvas1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTestChart"
        Me.Text = "FrmTestChart"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuBarChart1 As Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart
    Friend WithEvents BunifuChartCanvas1 As Bunifu.Charts.WinForms.BunifuChartCanvas
    Friend WithEvents BunifuDoughnutChart1 As Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart
End Class
