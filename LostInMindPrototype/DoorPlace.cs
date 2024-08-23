using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class DoorPlace : PointOfInterest
    {
        public DoorPlace()
        {
            Name = "Place with huge doors";
            Description = "\nYou see doors, so large that even from a distance it is impossible not to see them.\nWhen you come closer you see a small device next to them.\n Of course, you need a password to open these doors. 6 digits, no more, no less. ";
            Index = 'X';
        }
    }
}
