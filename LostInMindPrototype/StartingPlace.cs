using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class StartingPlace : PointOfInterest
    {
        public StartingPlace()
        {
            Name = "Starting place";
            Description = "You see only ground and a chest.\n";
            DescriptionWithItemTaken = "You see an open chest, there is nothing more to do here.\n";
        }
        public bool IsChestOpen { get; private set; }

    }
}
