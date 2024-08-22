using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class PointOfInterest
    {
        Player player;
        public Item Item;
        public char Index;
        public string Name;
        public string Description;
        public string DescriptionWithItemTaken;
        public bool IsItemTaken { get; private set; }

        public void TakeItem()
        {
            IsItemTaken = true;
        }
        public void ShowDescription()
        {
            if (IsItemTaken == false)
                Console.WriteLine($"\n{Description}");
            else
                Console.WriteLine($"\n{DescriptionWithItemTaken}");
        }
    }
}
