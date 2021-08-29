using System.Linq;
using System.Management;

namespace TaskManagerDOTN
{
    class DisplayDataControler
    {
        private Form1 mainForm;

        private OperatingSystemInfo operatingSystemInfo;
        private CPU_Info cpuInfo;

        public DisplayDataControler(Form1 mainForm)
        {
            this.mainForm = mainForm;
        }

        public void UpdateOSData() 
        {
            mainForm.osVersion.Text = "OS Version: " + operatingSystemInfo.name + " " + operatingSystemInfo.architecture;
            mainForm.build.Text = "Build: "+ operatingSystemInfo.build;
            mainForm.serialNumber.Text = "Serial number: "+ operatingSystemInfo.serialNumber;
            mainForm.version.Text = "Version: "+ operatingSystemInfo.version;
        }

        public void UpdateCPUData()
        {
            mainForm.prrocesorrName.Text = "CPU: " + cpuInfo.name;
            mainForm.label7.Text = "Number of cores " + cpuInfo.cores + " at " + cpuInfo.speedMHz + " MHz with " + cpuInfo.threads + " threads";
            mainForm.socketType.Text = "Socket: " + cpuInfo.socket;
            mainForm.cache.Text = "Processor cache: " + "L2 Cache: " + (cpuInfo.l2Cache / 1000).ToString() + " MB" + ", L3 Cache: " + (cpuInfo.l3Cache / 1000).ToString() + " MB";
        }
        public void LoadSystemInformation()
        {
            var wmi = new ManagementObjectSearcher("select * from Win32_OperatingSystem").Get().Cast<ManagementObject>().First();

            operatingSystemInfo.name = ((string)wmi["Caption"]).Trim();
            operatingSystemInfo.version = (string)wmi["Version"];
            operatingSystemInfo.maxProcessCount = (uint)wmi["MaxNumberOfProcesses"];
            operatingSystemInfo.maxProcessRAM = (ulong)wmi["MaxProcessMemorySize"];
            operatingSystemInfo.architecture = (string)wmi["OSArchitecture"];
            operatingSystemInfo.serialNumber = (string)wmi["SerialNumber"];
            operatingSystemInfo.build = (string)wmi["BuildNumber"];

            var cpu = new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>().First();

            cpuInfo.iD = (string)cpu["ProcessorId"];
            cpuInfo.socket = (string)cpu["SocketDesignation"];
            cpuInfo.name = (string)cpu["Name"];
            cpuInfo.description = (string)cpu["Caption"];
            cpuInfo.addressWidth = (ushort)cpu["AddressWidth"];
            cpuInfo.dataWidth = (ushort)cpu["DataWidth"];
            cpuInfo.architecture = (ushort)cpu["Architecture"];
            cpuInfo.speedMHz = (uint)cpu["MaxClockSpeed"];
            cpuInfo.busSpeedMHz = (uint)cpu["ExtClock"];
            cpuInfo.l2Cache = (uint)cpu["L2CacheSize"];
            cpuInfo.l3Cache = (uint)cpu["L3CacheSize"];
            cpuInfo.cores = (uint)cpu["NumberOfCores"];
            cpuInfo.threads = (uint)cpu["NumberOfLogicalProcessors"];
        }
    }
}
