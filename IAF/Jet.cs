using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public abstract class Jet : AerialVehicle, IAttack
    {
        public Jet()
        {
            MaxOperationTime = TimeSpan.FromHours(Constants.JET_OPERATION_TIME_HOURS);
        }
        public int MissileCount { get; set; }
        public MissileTypes MissileType { get; set; }

        public string Attack()
        {
            return $"{PilotName}: {GetType().Name} Attacking {((AttackMission)Mission).Target} with: {MissileType}";
        }
    }
}