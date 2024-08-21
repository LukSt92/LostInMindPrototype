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
        public int Hp = 100;
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
    }
}
