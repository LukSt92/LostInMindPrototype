using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class StrangePlace : PointOfInterest
    {
        public StrangePlace()
        {
            Name = "Strange Place";
            Description = "This place is weird, floor and wall are covered with strange symbols, but you can't read them because of the headache.";
            DescriptionWithItemTaken = "Well... this place is still weird, but you managed to decipher some numbers: 657431.";
            Index = 'N';
        }
    }
}
