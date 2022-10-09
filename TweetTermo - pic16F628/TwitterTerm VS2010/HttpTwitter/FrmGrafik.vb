Imports System.Windows.Forms.DataVisualization.Charting
Public Class FrmGrafik

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart.Click

    End Sub



    Private Sub FrmGrafik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TT_baseDataSet.TblTemperatura' table. You can move, or remove it, as needed.


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Chart.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        Chart.Series.Clear()
        Chart.Series(0).Points.Add(MainForm.TblTemperaturaBindingSource1.Count)
        Chart.Series(0).Name = "Senzor 1"

        'Chart.DataSource = TblTemperaturaBindingSource.DataSource
        ' Chart.Palette = DataVisualization.Charting.ChartColorPalette.Pastel
        '
        'Dim Series1 As DataVisualization.Charting.Series = Chart.Series("Series1")

        'Chart.Series(Series1.Name).XValueMember = "Datum"
        'Chart.Series(Series1.Name).YValueMembers = "Temperatura"

        'Chart.Size = New System.Drawing.Size(780, 350)



        Chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
    End Sub
End Class