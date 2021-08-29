using System.Diagnostics;

namespace TaskManagerDOTN
{
    class ProcessMonitor
    {
        // Define variables to track the peak
        // memory usage of the process.
        private long peakPagedMem = 0;
        private long peakWorkingSet = 0;
        private long peakVirtualMem = 0;

        public void UpdateSelectedProcess(Process selectedProcess, Form1 mainForm)
        {
            selectedProcess.Refresh();

            // Display current process statistics.
            mainForm.processMemoryUsage.Text = "Memory usage: " + Form1.ConvertToMB(selectedProcess.WorkingSet64).ToString() + " MB";
            mainForm.basePriority.Text = "Base priority: " + selectedProcess.BasePriority;
            mainForm.priorityClass.Text = "Priority class: " + selectedProcess.PriorityClass;
            mainForm.userProcessorTime.Text = "User processor time:" + selectedProcess.UserProcessorTime.ToString(@"hh\:mm\:ss");
            mainForm.privilegedProcessorTime.Text = "Privileged processor time: " + selectedProcess.PrivilegedProcessorTime.ToString(@"hh\:mm\:ss");
            mainForm.totalProcessorTime.Text = "Total processor time: " + selectedProcess.TotalProcessorTime.ToString(@"hh\:mm\:ss");
            mainForm.pagedSystemMemorySize.Text = "Paged system memory size: " + Form1.ConvertToMB(selectedProcess.PagedSystemMemorySize64).ToString() + " MB";
            mainForm.pagedMemorySize.Text = "Paged memory size:" + Form1.ConvertToMB(selectedProcess.PagedMemorySize64).ToString()+ " MB";

            // Update the values for the overall peak memory statistics.
            peakPagedMem = selectedProcess.PeakPagedMemorySize64;
            peakVirtualMem = selectedProcess.PeakVirtualMemorySize64;
            peakWorkingSet = selectedProcess.PeakWorkingSet64;
        }
    }
}
