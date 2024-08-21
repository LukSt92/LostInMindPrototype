using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    abstract class PointOfInterest
    {
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
                Console.WriteLine(Description);
            else
                Console.WriteLine(DescriptionWithItemTaken);
        }
    }
}
