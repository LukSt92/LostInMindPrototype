using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Area area = new Area();
            PointOfInterest currentPoint = new PointOfInterest();
            Console.WriteLine(@"You woke up... Your head hurts... All you remember is that you were falling...
and falling...
and falling...
and falling...
You touch your head and feel sticky blood under your fingers, you have to do something about it...
You search through what you're wearing but these simple clothes don't even have pockets...
'Where I am' - this is your first conscious thought...
Feeling dizzy you get up and look around, there is chest near you and some bright point far ahead of you. The rest of this place is covered in darkness...");
            while (true)
            {
                Console.WriteLine("Where do you want to go?\n");
                area.ShowPoints();
                char key = Console.ReadKey().KeyChar;
                area.GoTo(area.Find(key));
                currentPoint = area.Find(key);
                while (true)
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine($"Press L to look around again, Press T to take {currentPoint.Item.Name} or Q to go back.");
                    key = Console.ReadKey().KeyChar;
                    switch (key)
                    {
                        case 'l':
                        case 'L':
                            currentPoint.ShowDescription();
                            break;
                        case 't':
                        case 'T':
                            currentPoint.TakeItem();
                            player.TakeItem(currentPoint.Item);
                            if (currentPoint.Item.Name == "Torch")
                            { 
                                Console.WriteLine("The moment you grabbed the torch, everything lit up...\nit was as if the flames from the torch had spread across the entire ceiling in that area");
                                // TODO Add new point of interest!
                            }
                            break;
                        default:
                            break;
                    }
                    if (key == 'Q' || key == 'q') break;
                }
            }
        }
    }
}
