using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAF
{
    public class Coordinate
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }


        public override string ToString()
        {
            return $"{Latitude}, {Longitude}";
        }
    }
}
