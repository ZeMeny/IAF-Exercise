using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public interface IAttack
    {
        int MissileCount { get; set; }

        MissileTypes MissileType { get; set; }

        string Attack();
    }
}