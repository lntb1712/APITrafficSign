using System;
using System.Collections.Generic;

namespace APITrafficSign.Models
{
    public partial class TrafficSign
    {
        public string TrafficSignReco { get; set; } = null!;
        public string? TrafficSignCode { get; set; }
        public string? TrafficSignName { get; set; }
    }
}
