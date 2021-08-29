namespace TaskManagerDOTN
{
    public struct CPU_Info
    {
        public string iD;
        public string socket;
        public string name;
        public string description;
        public ushort addressWidth;
        public ushort dataWidth;
        public ushort architecture;
        public uint speedMHz;
        public uint busSpeedMHz;
        public uint l2Cache;
        public uint l3Cache;
        public uint cores;
        public uint threads; 
    }
}
