using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Planets.Models
{
    public class SpaceObjects
    {
        public ObservableCollection<SpaceObject> AllObjects { get; set; }
        public SpaceObjects() 
        {
            AllObjects = new ObservableCollection<SpaceObject>();
            AllObjects.Add(new SpaceObject { CurrentName = "Mercury", Material = "Stone", Size = 2439.7 });
            AllObjects.Add(new SpaceObject { CurrentName = "Venus", Material = "Stone", Size = 5728.1 });
            AllObjects.Add(new SpaceObject { CurrentName = "Earth", Material = "Stone", Size = 6378.1 });
            AllObjects.Add(new SpaceObject { CurrentName = "Mars", Material = "Stone", Size = 6792.4 });
            AllObjects.Add(new SpaceObject { CurrentName = "Jupiter", Material = "Gas", Size = 142984 });
            AllObjects.Add(new SpaceObject { CurrentName = "Saturn", Material = "Gas", Size = 120536 });
            AllObjects.Add(new SpaceObject { CurrentName = "Uranus", Material = "Icy liquid", Size = 51118 });
            AllObjects.Add(new SpaceObject { CurrentName = "Neptune", Material = "Icy liquid", Size = 49528 });
        }
    }
}
