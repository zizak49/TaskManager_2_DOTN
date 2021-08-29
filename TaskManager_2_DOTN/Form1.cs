﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskManager_2_DOTN
{
    public partial class Form1 : Form
    {
        private List<Process> processes;
        private Process selectedProcess;

        private DisplayDataControler displayDataControler;
        private ProcessMonitor processMonitor;
        private ServicesManager servicesManager;
        private ChartManager chartManager;

        private long totalUsedMemory = 0;

        private Timer dataRefresh;


        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            LoadAllProcesses();

            //Load and display static information
            displayDataControler = new DisplayDataControler(this);

            processMonitor = new ProcessMonitor();
            servicesManager = new ServicesManager(servicesGridView, startService, stopService);

            servicesManager.LoadAllServices();
            servicesGridView.DataSource = servicesManager.Services;
            servicesGridView.Select();

            displayDataControler.LoadSystemInformation();
            displayDataControler.UpdateOSData();
            displayDataControler.UpdateCPUData();

            chartManager = new ChartManager(cpuChart, ramChart);
            chartManager.SetUpCharts(displayDataControler.totalRamInstaled);

            //Timer for updating data
            InitTimer();
        }

        #region Processes tab
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

        #endregion

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

            chartManager.UpdateCharts(totalUsedMemory);
        }
    }
}
