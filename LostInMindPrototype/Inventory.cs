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
        private int lastId = 1;
        public void ShowInventory()
        {
            while (true)
            {
                if (items.Count == 0)
                {
                    Console.WriteLine("\nYou don't have any items.");
                    break;
                }
                Console.WriteLine("\nTo use item press his Id number or press Q to return:");
                foreach (Item item in items)
                {
                    Console.WriteLine($"Id:{item.Id} - {item.Name} - {item.Description}\n");
                }
                char key = Console.ReadKey().KeyChar;
                key = char.ToUpper(key);
                if (key == 'Q')
                    break;
                if (int.TryParse(key.ToString(), out int itemId))
                {
                    UseItem(items.Find(x => x.Id == itemId));
                }
            }
        }
        public void GetItem(Item item)
        {
            item.Id = lastId;
            lastId++;
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
