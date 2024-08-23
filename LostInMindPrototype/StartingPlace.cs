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
            Item = new Item() { Name = "Pills", Description = "For Headache.", IsUseable = true };
            Name = "Starting place";
            Description = "\nYou see only ground and a chest.";
            DescriptionWithItemTaken = "\nYou see an open chest, there is nothing more to do here.";
            Index = 'C';
        }
        public bool IsChestOpen { get; private set; }

    }
}
