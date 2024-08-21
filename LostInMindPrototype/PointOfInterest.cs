using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class PointOfInterest
    {
        public bool IsKeyRequired;
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOpen { get; private set; }
        public bool IsItemTaken { get; private set; }

        public void TakeItem()
        {
            IsItemTaken = true;
        }
        public void UseKey()
        {
            IsOpen = true;
        }
    }
}
