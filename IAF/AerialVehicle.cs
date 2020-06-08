using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public abstract class AerialVehicle
    {
        public TimeSpan MaxOperationTime { get; protected set; }

        public string PilotName { get; set; }

        public bool IsReady { get; set; }

        public TimeSpan TimeSinceLastRepair { get; set; }

        public Mission Mission { get; set; }


        public void FlyTo()
        {
            Console.WriteLine($"Flying to: {Mission?.TargetLocation}");
        }

        public void Land()
        {
            Console.WriteLine("Landing");
        }

        public void Check()
        {
            if (TimeSinceLastRepair > MaxOperationTime)
            {
                Repair();
            }
        }

        public void Repair()
        {
            IsReady = true;
            TimeSinceLastRepair = TimeSpan.Zero;
        }
    }
}