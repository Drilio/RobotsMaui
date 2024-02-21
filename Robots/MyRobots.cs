using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class MyRobots
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; } 

        public MyRobots(string name, string type, int size)
        {
            Name = name;
            Type = type;
            Size = size;
        }
    }
}