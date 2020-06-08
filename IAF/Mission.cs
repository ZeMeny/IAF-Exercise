using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IAF
{
    public class Mission
    {
        public Coordinate TargetLocation { get; set; }

        public void Begin()
        {
            Console.WriteLine("Beginning Mission!");
        }

        public void Cancel()
        {
            Console.WriteLine("Abort Mission!");
        }

        public void Finish()
        {
            Console.WriteLine("Finish Mission!");
        }
    }
}