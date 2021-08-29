﻿
namespace TaskManagerDOTN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SystemInformation = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cache = new System.Windows.Forms.Label();
            this.socketType = new System.Windows.Forms.Label();
            this.prrocesorrName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.serialNumber = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.Label();
            this.osVersion = new System.Windows.Forms.Label();
            this.Processes = new System.Windows.Forms.TabPage();
            this.pagedMemorySize = new System.Windows.Forms.Label();
            this.pagedSystemMemorySize = new System.Windows.Forms.Label();
            this.totalProcessorTime = new System.Windows.Forms.Label();
            this.privilegedProcessorTime = new System.Windows.Forms.Label();
            this.userProcessorTime = new System.Windows.Forms.Label();
            this.priorityClass = new System.Windows.Forms.Label();
            this.basePriority = new System.Windows.Forms.Label();
            this.endProcess = new System.Windows.Forms.Button();
            this.totalUsedMemoryVal = new System.Windows.Forms.Label();
            this.totalUsedMemoryText = new System.Windows.Forms.Label();
            this.processesListBox = new System.Windows.Forms.ListBox();
            this.processMemoryUsage = new System.Windows.Forms.Label();
            this.processName = new System.Windows.Forms.Label();
            this.Preformance = new System.Windows.Forms.TabPage();
            this.Services = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SystemInformation.SuspendLayout();
            this.Processes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SystemInformation);
            this.tabControl1.Controls.Add(this.Processes);
            this.tabControl1.Controls.Add(this.Preformance);
            this.tabControl1.Controls.Add(this.Services);
            this.tabControl1.Location = new System.Drawing.Point(11, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // SystemInformation
            // 
            this.SystemInformation.Controls.Add(this.label7);
            this.SystemInformation.Controls.Add(this.cache);
            this.SystemInformation.Controls.Add(this.socketType);
            this.SystemInformation.Controls.Add(this.prrocesorrName);
            this.SystemInformation.Controls.Add(this.label2);
            this.SystemInformation.Controls.Add(this.label1);
            this.SystemInformation.Controls.Add(this.version);
            this.SystemInformation.Controls.Add(this.serialNumber);
            this.SystemInformation.Controls.Add(this.build);
            this.SystemInformation.Controls.Add(this.osVersion);
            this.SystemInformation.Location = new System.Drawing.Point(4, 22);
            this.SystemInformation.Name = "SystemInformation";
            this.SystemInformation.Size = new System.Drawing.Size(656, 257);
            this.SystemInformation.TabIndex = 3;
            this.SystemInformation.Text = "System Information";
            this.SystemInformation.UseVisualStyleBackColor = true;
            this.SystemInformation.Click += new System.EventHandler(this.SystemInformation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // cache
            // 
            this.cache.AutoSize = true;
            this.cache.Location = new System.Drawing.Point(51, 238);
            this.cache.Name = "cache";
            this.cache.Size = new System.Drawing.Size(90, 13);
            this.cache.TabIndex = 9;
            this.cache.Text = "Processor cache:";
            // 
            // socketType
            // 
            this.socketType.AutoSize = true;
            this.socketType.Location = new System.Drawing.Point(51, 217);
            this.socketType.Name = "socketType";
            this.socketType.Size = new System.Drawing.Size(44, 13);
            this.socketType.TabIndex = 8;
            this.socketType.Text = "Socket:";
            // 
            // prrocesorrName
            // 
            this.prrocesorrName.AutoSize = true;
            this.prrocesorrName.Location = new System.Drawing.Point(51, 173);
            this.prrocesorrName.Name = "prrocesorrName";
            this.prrocesorrName.Size = new System.Drawing.Size(57, 13);
            this.prrocesorrName.TabIndex = 7;
            this.prrocesorrName.Text = "Processor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device specification:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Operating system infromation:";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(51, 108);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(48, 13);
            this.version.TabIndex = 5;
            this.version.Text = "Version: ";
            // 
            // serialNumber
            // 
            this.serialNumber.AutoSize = true;
            this.serialNumber.Location = new System.Drawing.Point(51, 65);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(77, 13);
            this.serialNumber.TabIndex = 3;
            this.serialNumber.Text = "Serial number: ";
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.Location = new System.Drawing.Point(51, 87);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(36, 13);
            this.build.TabIndex = 2;
            this.build.Text = "Build: ";
            // 
            // osVersion
            // 
            this.osVersion.AutoSize = true;
            this.osVersion.Location = new System.Drawing.Point(51, 43);
            this.osVersion.Name = "osVersion";
            this.osVersion.Size = new System.Drawing.Size(63, 13);
            this.osVersion.TabIndex = 0;
            this.osVersion.Text = "OS Version:";
            // 
            // Processes
            // 
            this.Processes.Controls.Add(this.pagedMemorySize);
            this.Processes.Controls.Add(this.pagedSystemMemorySize);
            this.Processes.Controls.Add(this.totalProcessorTime);
            this.Processes.Controls.Add(this.privilegedProcessorTime);
            this.Processes.Controls.Add(this.userProcessorTime);
            this.Processes.Controls.Add(this.priorityClass);
            this.Processes.Controls.Add(this.basePriority);
            this.Processes.Controls.Add(this.endProcess);
            this.Processes.Controls.Add(this.totalUsedMemoryVal);
            this.Processes.Controls.Add(this.totalUsedMemoryText);
            this.Processes.Controls.Add(this.processesListBox);
            this.Processes.Controls.Add(this.processMemoryUsage);
            this.Processes.Controls.Add(this.processName);
            this.Processes.Location = new System.Drawing.Point(4, 22);
            this.Processes.Name = "Processes";
            this.Processes.Padding = new System.Windows.Forms.Padding(3);
            this.Processes.Size = new System.Drawing.Size(656, 257);
            this.Processes.TabIndex = 0;
            this.Processes.Text = "Processes";
            this.Processes.UseVisualStyleBackColor = true;
            // 
            // pagedMemorySize
            // 
            this.pagedMemorySize.AutoSize = true;
            this.pagedMemorySize.Location = new System.Drawing.Point(257, 208);
            this.pagedMemorySize.Name = "pagedMemorySize";
            this.pagedMemorySize.Size = new System.Drawing.Size(101, 13);
            this.pagedMemorySize.TabIndex = 14;
            this.pagedMemorySize.Text = "Paged memory size:";
            // 
            // pagedSystemMemorySize
            // 
            this.pagedSystemMemorySize.AutoSize = true;
            this.pagedSystemMemorySize.Location = new System.Drawing.Point(257, 186);
            this.pagedSystemMemorySize.Name = "pagedSystemMemorySize";
            this.pagedSystemMemorySize.Size = new System.Drawing.Size(136, 13);
            this.pagedSystemMemorySize.TabIndex = 13;
            this.pagedSystemMemorySize.Text = "Paged system memory size:";
            // 
            // totalProcessorTime
            // 
            this.totalProcessorTime.AutoSize = true;
            this.totalProcessorTime.Location = new System.Drawing.Point(257, 165);
            this.totalProcessorTime.Name = "totalProcessorTime";
            this.totalProcessorTime.Size = new System.Drawing.Size(105, 13);
            this.totalProcessorTime.TabIndex = 12;
            this.totalProcessorTime.Text = "Total processor time:";
            // 
            // privilegedProcessorTime
            // 
            this.privilegedProcessorTime.AutoSize = true;
            this.privilegedProcessorTime.Location = new System.Drawing.Point(257, 143);
            this.privilegedProcessorTime.Name = "privilegedProcessorTime";
            this.privilegedProcessorTime.Size = new System.Drawing.Size(127, 13);
            this.privilegedProcessorTime.TabIndex = 11;
            this.privilegedProcessorTime.Text = "Privileged processor time:";
            // 
            // userProcessorTime
            // 
            this.userProcessorTime.AutoSize = true;
            this.userProcessorTime.Location = new System.Drawing.Point(257, 121);
            this.userProcessorTime.Name = "userProcessorTime";
            this.userProcessorTime.Size = new System.Drawing.Size(103, 13);
            this.userProcessorTime.TabIndex = 10;
            this.userProcessorTime.Text = "User processor time:";
            // 
            // priorityClass
            // 
            this.priorityClass.AutoSize = true;
            this.priorityClass.Location = new System.Drawing.Point(257, 100);
            this.priorityClass.Name = "priorityClass";
            this.priorityClass.Size = new System.Drawing.Size(68, 13);
            this.priorityClass.TabIndex = 9;
            this.priorityClass.Text = "Priority class:";
            // 
            // basePriority
            // 
            this.basePriority.AutoSize = true;
            this.basePriority.Location = new System.Drawing.Point(257, 78);
            this.basePriority.Name = "basePriority";
            this.basePriority.Size = new System.Drawing.Size(67, 13);
            this.basePriority.TabIndex = 8;
            this.basePriority.Text = "Base priority:";
            // 
            // endProcess
            // 
            this.endProcess.Location = new System.Drawing.Point(587, 237);
            this.endProcess.Name = "endProcess";
            this.endProcess.Size = new System.Drawing.Size(68, 20);
            this.endProcess.TabIndex = 7;
            this.endProcess.Text = "End process";
            this.endProcess.UseVisualStyleBackColor = true;
            this.endProcess.Click += new System.EventHandler(this.end_process_Click);
            // 
            // totalUsedMemoryVal
            // 
            this.totalUsedMemoryVal.AutoSize = true;
            this.totalUsedMemoryVal.Location = new System.Drawing.Point(176, 39);
            this.totalUsedMemoryVal.Name = "totalUsedMemoryVal";
            this.totalUsedMemoryVal.Size = new System.Drawing.Size(14, 13);
            this.totalUsedMemoryVal.TabIndex = 6;
            this.totalUsedMemoryVal.Text = "#";
            // 
            // totalUsedMemoryText
            // 
            this.totalUsedMemoryText.AutoSize = true;
            this.totalUsedMemoryText.Location = new System.Drawing.Point(75, 39);
            this.totalUsedMemoryText.Name = "totalUsedMemoryText";
            this.totalUsedMemoryText.Size = new System.Drawing.Size(99, 13);
            this.totalUsedMemoryText.TabIndex = 5;
            this.totalUsedMemoryText.Text = "Total used memory:";
            // 
            // processesListBox
            // 
            this.processesListBox.FormattingEnabled = true;
            this.processesListBox.Location = new System.Drawing.Point(3, 55);
            this.processesListBox.Name = "processesListBox";
            this.processesListBox.Size = new System.Drawing.Size(244, 290);
            this.processesListBox.TabIndex = 2;
            this.processesListBox.SelectedIndexChanged += new System.EventHandler(this.processesListBox_SelectedIndexChanged);
            // 
            // processMemoryUsage
            // 
            this.processMemoryUsage.AutoSize = true;
            this.processMemoryUsage.Location = new System.Drawing.Point(257, 56);
            this.processMemoryUsage.Name = "processMemoryUsage";
            this.processMemoryUsage.Size = new System.Drawing.Size(79, 13);
            this.processMemoryUsage.TabIndex = 1;
            this.processMemoryUsage.Text = "Memory usage:";
            // 
            // processName
            // 
            this.processName.AutoSize = true;
            this.processName.Location = new System.Drawing.Point(3, 39);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(35, 13);
            this.processName.TabIndex = 1;
            this.processName.Text = "Name";
            // 
            // Preformance
            // 
            this.Preformance.Location = new System.Drawing.Point(4, 22);
            this.Preformance.Name = "Preformance";
            this.Preformance.Padding = new System.Windows.Forms.Padding(3);
            this.Preformance.Size = new System.Drawing.Size(656, 257);
            this.Preformance.TabIndex = 1;
            this.Preformance.Text = "Preformance";
            this.Preformance.UseVisualStyleBackColor = true;
            // 
            // Services
            // 
            this.Services.Location = new System.Drawing.Point(4, 22);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(656, 257);
            this.Services.TabIndex = 2;
            this.Services.Text = "Services";
            this.Services.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 295);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.SystemInformation.ResumeLayout(false);
            this.SystemInformation.PerformLayout();
            this.Processes.ResumeLayout(false);
            this.Processes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Processes;
        private System.Windows.Forms.TabPage Preformance;
        private System.Windows.Forms.TabPage Services;
        private System.Windows.Forms.Label processName;
        public System.Windows.Forms.Label processMemoryUsage;
        private System.Windows.Forms.ListBox processesListBox;
        private System.Windows.Forms.Label totalUsedMemoryVal;
        private System.Windows.Forms.Label totalUsedMemoryText;
        private System.Windows.Forms.TabPage SystemInformation;

        public System.Windows.Forms.Label osVersion;
        public System.Windows.Forms.Label osType;
        public System.Windows.Forms.Label build;
        public System.Windows.Forms.Label version;
        public System.Windows.Forms.Label serialNumber;

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label cache;
        public System.Windows.Forms.Label socketType;
        public System.Windows.Forms.Label prrocesorrName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button endProcess;

        public System.Windows.Forms.Label privilegedProcessorTime;
        public System.Windows.Forms.Label userProcessorTime;
        public System.Windows.Forms.Label priorityClass;
        public System.Windows.Forms.Label basePriority;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label totalProcessorTime;
        public System.Windows.Forms.Label pagedSystemMemorySize;
        public System.Windows.Forms.Label pagedMemorySize;
    }
}

