﻿namespace ErpNet.FP.Core.Configuration
{
    using System.Collections.Generic;

    public class PrinterConfig
    {
        public string Uri { get; set; } = string.Empty;
    }

    public class PrinterConfigWithId : PrinterConfig
    {
        public string Id { get; set; } = string.Empty;
    }

    public class ServiceOptions
    {
        public bool AutoDetect { get; set; } = true;
        public string ServerId { get; set; } = string.Empty;
        public Dictionary<string, PrinterConfig> Printers { get; set; } = new Dictionary<string, PrinterConfig>();
        public int UdpBeaconPort { get; set; } = 8001;
    }
}