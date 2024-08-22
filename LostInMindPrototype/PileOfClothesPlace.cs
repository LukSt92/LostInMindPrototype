using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class PileOfClothesPlace : PointOfInterest
    {
        public PileOfClothesPlace()
        {
            Item = new Item() { Name = "Key", Description = "Regular key.", IsKey = true };
            Name = "Pile of clothes";
            Description = "\nAs you got closer you realized that the big white mountain was nothing more than a big pile of white fabrics with something shiny inside";
            DescriptionWithItemTaken = "\nIt used to be a mountain of fabrics... now everything is scattered around.";
            Index = 'V';
        }
    }
}
