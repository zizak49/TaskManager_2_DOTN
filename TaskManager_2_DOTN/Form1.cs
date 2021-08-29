using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace TaskManager_2_DOTN
{
    public partial class Form1 : Form
    {
        private List<Process> processes;
        private Process selectedProcess;

        private DisplayDataControler displayDataControler;
        private ProcessMonitor processMonitor;
        private PerformanceCounter cpuUsage;
        private ServicesManager servicesManager;

        private long totalUsedMemory = 0;

        private Timer dataRefresh;

        private int gridlinesOffset = 0;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            LoadAllProcesses();

            //Load and display static information
            displayDataControler = new DisplayDataControler(this);
            processMonitor = new ProcessMonitor();

            cpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            displayDataControler.LoadSystemInformation();
            displayDataControler.UpdateOSData();
            displayDataControler.UpdateCPUData();

            SetUpCharts();

            //Timer for updating data
            InitTimer();
        }

        private void LoadAllProcesses()
        {
            processes = Process.GetProcesses().ToList();

            foreach (Process process in processes)
            {
                processesListBox.Items.Add(process);
            }

            processesListBox.ValueMember = "ProcessName";
        }

        private void end_process_Click(object sender, EventArgs e)
        {
            selectedProcess = processes[processesListBox.SelectedIndex];

            selectedProcess.Kill();
            selectedProcess.WaitForExit();

            processes.Remove(selectedProcess);
            processesListBox.Items.RemoveAt(processesListBox.SelectedIndex);

            processesListBox.Refresh();
        }

        private void processesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayProcessInfo(processes[processesListBox.SelectedIndex]);
            }
            catch (Exception)
            {
                processesListBox.SelectedIndex = 1;
            }
        }

        private void DisplayProcessInfo(Process selectedProcess)
        {
            processMonitor.UpdateSelectedProcess(selectedProcess, this);
        }

        public static long ConvertToMB(long number)
        {
            number = (number / 1024) / 1024;
            return number;
        }

        public void InitTimer()
        {
            dataRefresh = new Timer();
            dataRefresh.Tick += new EventHandler(Timer_Tick);
            dataRefresh.Interval = 1000; // in miliseconds
            dataRefresh.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            if (selectedProcess != null)
            {
                processMonitor.UpdateSelectedProcess(selectedProcess, this);
            }

            totalUsedMemory = 0;

            foreach (Process process in processes)
            {
                totalUsedMemory += process.WorkingSet64;
            }
            totalUsedMemoryVal.Text = ConvertToMB(totalUsedMemory).ToString() + " MB";

            UpdateCharts();
        }

        private void UpdateCharts()
        {
            cpuChart.Series[0].Points.AddY(cpuUsage.NextValue());
            ramChart.Series[0].Points.AddY(ConvertToMB(totalUsedMemory));

            cpuChart.Series["Series1"].Points.RemoveAt(0);
            ramChart.Series["Series1"].Points.RemoveAt(0);

            // Make gridlines move.
            cpuChart.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = -gridlinesOffset;
            ramChart.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = -gridlinesOffset;

            // Calculate next offset.
            gridlinesOffset++;
            gridlinesOffset %= (int)cpuChart.ChartAreas[0].AxisX.MajorGrid.Interval;
        }

        private void SetUpCharts()
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
            ramChart.ChartAreas[0].AxisY.Maximum = ConvertToMB((long)displayDataControler.totalRamInstaled);
        }
    }
}
