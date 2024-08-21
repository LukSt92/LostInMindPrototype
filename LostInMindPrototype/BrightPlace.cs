using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class BrightPlace : PointOfInterest
    {
        public BrightPlace() 
        {
            Name = "Bright place";
            Description = "As you aproach closer to the light, you realized that this is just a wall with a few torches embedded in it.\n";
            DescriptionWithItemTaken = "You already took a torch, there is nothing more for you to here.";
        }
    }
}
