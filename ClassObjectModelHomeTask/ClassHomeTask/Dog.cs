using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomeTask
{
    internal class Dog : Animal
    {
        public bool hasTail;
        
        public static string Bark()
        {
            string bark = "Dogs are barking.";
            return bark;
        }
        
    }   
}
