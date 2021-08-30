using System;
using System.ServiceProcess;
using System.Windows.Forms;

namespace TaskManager_2_DOTN
{
    public class ServicesManager
    {
        private ServiceController[] services;
        private DataGridViewRow selectedRow;

        private DataGridView dataGridView;

        private Button start, stop;

        public ServiceController[] Services { get => services; }

        public ServicesManager(DataGridView dataGridView,Button start,Button stop)
        {
            this.dataGridView = dataGridView;

            this.start = start;
            this.stop = stop;

            this.start.Click += new EventHandler(StartServiceClick);
            this.stop.Click += new EventHandler(StopService_Click);

            this.dataGridView.SelectionChanged += new EventHandler(ServicesGridView_SelectionChanged);

            LoadAllServices();
        }

        private void LoadAllServices() 
        {
            services = ServiceController.GetServices();
            dataGridView.DataSource = services;
        }

        private void ServicesGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectedRow = dataGridView.CurrentRow;
        }

        private void StopService_Click(object sender, EventArgs e)
        {
            if (services[selectedRow.Index].Status == ServiceControllerStatus.Running)
            {
                services[selectedRow.Index].Stop();
                LoadAllServices();
            }
        }

        private void StartServiceClick(object sender, EventArgs e)
        {
            if (services[selectedRow.Index].Status == ServiceControllerStatus.Stopped)
            {
                services[selectedRow.Index].Start();
                LoadAllServices();
            } 
        }
    }
}
