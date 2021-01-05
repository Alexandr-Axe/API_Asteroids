using System;
using System.Collections.Generic;
using System.Text;

namespace Planets.Models
{
    public class SpaceObject
    {
        public string CurrentName { get; set; }
        public string Material { get; set; }
        public double Size { get; set; }
        public SpaceObject(/*string name, string material, double size*/) 
        {
            /*CurrentName = name;
            Material = material;
            Size = size;*/
        }
    }
}
