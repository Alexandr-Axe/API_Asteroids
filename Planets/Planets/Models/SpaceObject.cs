using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Planets.Models
{
    public class SpaceObject
    {
        public string CurrentName { get; set; }
        public double Size { get; set; }
        public double Velocity { get; set; }
        public SpaceObject(/*string name, string material, double size*/) 
        {
            /*CurrentName = name;
            Material = material;
            Size = size;*/
        }
    }
}
