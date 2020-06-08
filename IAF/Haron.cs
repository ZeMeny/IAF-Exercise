using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public abstract class Haron : AerialVehicle, IIntelligence, IAttack
    {
        public Haron()
        {
            MaxOperationTime = TimeSpan.FromHours(Constants.HARON_OPERATION_TIME_HOURS);
        }

        public SensorTypes SensorType { get; set; }
        public int MissileCount { get; set; }
        public MissileTypes MissileType { get; set; }

        public string Attack()
        {
            return $"{PilotName}: {GetType().Name} Attacking {((AttackMission)Mission).Target} with: {MissileType}";
        }

        public string CollectIntelligence()
        {
            return $"{PilotName}: {GetType().Name} Collecting Data in {((IntellignceMission)Mission).Region} with sensor type: elint";
        }
    }
}