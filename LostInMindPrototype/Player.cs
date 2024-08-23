using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class Player
    {
        List<Item> items = new List<Item>();
        public bool IsHeadOkay { get; private set; }
        public bool IsKeyTaken;
        public void PillsUsed()
        {
            IsHeadOkay = true;
            Console.WriteLine("The headache is gone, a wound from a fall to... Weird");
        }
        private int lastId = 1;
        public void ShowInventory()
        {
            while (true)
            {
                if (items.Count == 0)
                {
                    Console.WriteLine("\n\nYou don't have any items.");
                    break;
                }
                Console.WriteLine("\n\nTo use item press his Id number or press Q to return:");
                foreach (Item item in items)
                {
                    Console.WriteLine($"\nId:{item.Id} - {item.Name} - {item.Description}\n");
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
        public void TakeItem(Item item)
        {
            item.Id = lastId;
            lastId++;
            items.Add(item);
        }
        public void UseItem(Item item)
        {
            if (item.IsUseable == true)
            {
                if (item.Name == "Pills")
                {
                    IsHeadOkay = true;
                    Console.WriteLine("\nThe headache is gone, a wound from a fall too... Weird");
                }
                Console.WriteLine($"\nYou used {item.Name}.\n");
                items.Remove(item);
            }
            else
                Console.WriteLine($"\nYou can't use {item.Name} like that. You have to find a place where it will be useful.\n");
        }
    }
}
