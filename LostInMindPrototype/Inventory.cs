using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class Inventory
    {
        List<Item> items = new List<Item>();
        public void ShowInventory()
        {
            foreach (Item item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Description}\n");
            }
        }
        public void GetItem(Item item)
        {
            items.Add(item);
        }
        public void UseItem(Item item)
        {
            if (item.isUseable == true)
            {
                Console.WriteLine($"You used {item.Name}.\n");
                items.Remove(item);
            }
            else
                Console.WriteLine($"You can't use {item.Name} like that. You have to find a place where it will be useful.\n");
        }
    }
}
