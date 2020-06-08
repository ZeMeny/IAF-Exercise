using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public class F15 : Jet, IIntelligence
    {
        public F15()
        {

        }
        public SensorTypes SensorType { get; set; }

        public string CollectIntelligence()
        {
            return $"{PilotName}: {GetType().Name} Collecting Data in {((IntellignceMission)Mission).Region} with sensor type: elint";
        }
    }
}