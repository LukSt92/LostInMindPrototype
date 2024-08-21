using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class Player
    {
        Inventory inventory = new Inventory();
        public bool IsHeadOkay;
        public bool IsBagTaken { get; private set; }
        public bool IsTorchTaken { get; private set; }

        public void TakeBag()
        {
            IsBagTaken = true;
        }
        public void TakeTorch()
        {
            IsTorchTaken = true;
        }
        public void TakeItem(Item item)
        {
            inventory.GetItem(item);
        }
    }
}
