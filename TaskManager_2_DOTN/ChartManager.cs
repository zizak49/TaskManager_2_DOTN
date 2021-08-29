using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace TaskManager_2_DOTN
{
    public class ChartManager
    {
        private Chart cpuChart, ramChart;
        private PerformanceCounter cpuUsage;

        private int gridlinesOffset = 0;

        public ChartManager(Chart cpuChart, Chart ramChart)
        {
            this.cpuChart = cpuChart;
            this.ramChart = ramChart;
            cpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");         
        }

        public void UpdateCharts(long totalUsedMemory)
        {
            cpuChart.Series[0].Points.AddY(cpuUsage.NextValue());
            ramChart.Series[0].Points.AddY(Form1.ConvertToMB(totalUsedMemory));

            cpuChart.Series["Series1"].Points.RemoveAt(0);
            ramChart.Series["Series1"].Points.RemoveAt(0);

            // Make gridlines move.
            cpuChart.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = -gridlinesOffset;
            ramChart.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = -gridlinesOffset;

            // Calculate next offset.
            gridlinesOffset++;
            gridlinesOffset %= (int)cpuChart.ChartAreas[0].AxisX.MajorGrid.Interval;
        }

        public void SetUpCharts(ulong totalRamInstaled)
        {
            cpuChart.Series[0].ChartType = SeriesChartType.Line;
            cpuChart.Series[0].IsValueShownAsLabel = false;
            cpuChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            cpuChart.ChartAreas["ChartArea1"].AxisX.Title = "Time(1s)";
            cpuChart.ChartAreas["ChartArea1"].AxisY.Title = "% Utilization";
            cpuChart.ChartAreas[0].AxisX.MajorGrid.Interval = 10;
            cpuChart.ChartAreas[0].AxisY.MajorGrid.Interval = 10;
            cpuChart.ChartAreas[0].AxisX.Minimum = 0;
            cpuChart.ChartAreas[0].AxisX.Maximum = 60;
            cpuChart.ChartAreas[0].AxisY.Minimum = 0;
            cpuChart.ChartAreas[0].AxisY.Maximum = 100;

            for (int i = 0; i < 60; i++)
            {
                cpuChart.Series[0].Points.AddY(0);
                ramChart.Series[0].Points.AddY(0);
            }

            ramChart.Series[0].ChartType = SeriesChartType.Line;
            ramChart.Series[0].IsValueShownAsLabel = false;
            ramChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            ramChart.ChartAreas["ChartArea1"].AxisX.Title = "Memory usage (MB)";
            ramChart.ChartAreas[0].AxisY.Minimum = 0;
            ramChart.ChartAreas[0].AxisY.Maximum = Form1.ConvertToMB((long)totalRamInstaled);
        }
    }
}
