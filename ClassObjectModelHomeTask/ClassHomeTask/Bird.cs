using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomeTask
{
    internal class Bird:Animal
    {
        public bool canSwim;

        public static string CanFly()
        {
            string fly = "Birds can fly.";
            return fly;
        }
    }
}
