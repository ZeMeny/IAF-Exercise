using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public class F16 : Jet, IBda
    {
        public F16()
        {
            
        }

        public CameraTypes CameraType { get; set; }

        public string PreformBda()
        {
            return $"{PilotName}: {GetType().Name} taking pictures of {((BdaMission)Mission).Objective} with: {CameraType}";
        }
    }
}