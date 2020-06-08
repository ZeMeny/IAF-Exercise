using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public class Shoval : Haron, IBda
    {
        public Shoval()
        {
            
        }
        public CameraTypes CameraType { get; set; }

        public string PreformBda()
        {
            return $"{PilotName}: {GetType().Name} taking pictures of {((BdaMission)Mission).Objective} with: {SensorType}";
        }
    }
}