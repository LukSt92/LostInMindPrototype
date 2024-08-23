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
            Item = new Item() { Name = "Piece of junk", Description = "nothing exciting" };
            Name = "Strange Place";
            Description = "\nThis place is weird, floor and wall are covered with strange symbols, but you can't read them because of the headache.";
            DescriptionWithItemTaken = "\nThis place is weird, floor and wall are covered with strange symbols, but you can't read them because of the headache.";
            Index = 'N';
        }
        public string DescWithoutHeadache = "\nWell... this place is still weird, but you managed to decipher some numbers: 657431.";
    }
}
