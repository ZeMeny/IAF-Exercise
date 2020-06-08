using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public interface IIntelligence
    {
        SensorTypes SensorType { get; set; }

        string CollectIntelligence();
    }
}