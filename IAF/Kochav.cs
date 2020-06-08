using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public class Kochav : Hermes, IAttack
    {
        public Kochav()
        {
            
        }

        public int MissileCount { get; set; }
        public MissileTypes MissileType { get; set; }

        public string Attack()
        {
            return $"{PilotName}: {GetType().Name} Attacking {((AttackMission)Mission).Target} with: {MissileType}";
        }
    }
}