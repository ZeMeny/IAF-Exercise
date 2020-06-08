using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public abstract class Hermes : AerialVehicle, IIntelligence, IBda
    {
        public Hermes()
        {
            MaxOperationTime = TimeSpan.FromHours(Constants.HERMES_OPERATION_TIME_HOURS);
        }

        public SensorTypes SensorType { get; set; }
        public CameraTypes CameraType { get; set; }

        public string CollectIntelligence()
        {
            return $"{PilotName}: {GetType().Name} Collecting Data in {((IntellignceMission)Mission).Region} with sensor type: elint";
        }

        public string PreformBda()
        {
            return $"{PilotName}: {GetType().Name} taking pictures of {((BdaMission)Mission).Objective} with: {SensorType}";
        }
    }
}