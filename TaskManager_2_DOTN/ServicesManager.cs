using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;

namespace TaskManager_2_DOTN
{
    public class ServicesManager
    {
        private ServiceController[] services;

        public ServiceController[] Services { get => services; }

        public void LoadAllServices() 
        {
            services = ServiceController.GetServices();
        }
    }
}
