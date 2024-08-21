using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class PointOfInterest
    {
        public Item Item;
        public char Index;
        public string Name;
        public string Description;
        public string DescriptionWithItemTaken;
        public bool IsHereItem;
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
        public virtual void ShowMenu()
        {
            if (IsItemTaken == false)
                Console.WriteLine($"Press L to look around again, Press T to take {Item.Name} or Q to go back.");
            else
                Console.WriteLine($"Press L to look around again or Q to go back.");
        }
    }
}
