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
You find a bag under your feet, you grab it and and you immediately look inside it. Empty... 
Feeling dizzy you get up and look around, there is chest near you and some bright point far ahead of you. The rest of this place is covered in darkness...");
            while (true)
            {
                Console.Write("\nWhat do you want to do?\nI - to open inventory or G - to go somewhere else:");
                char key = Console.ReadKey(true).KeyChar;
                key = char.ToUpper(key);
                if (key == 'I')
                {
                    player.ShowInventory();
                }
                if (key == 'G')
                {
                    Console.WriteLine("\nWhere do you want to go?\n");
                    area.ShowPoints();
                    key = Console.ReadKey().KeyChar;
                    key = char.ToUpper(key);
                    area.GoTo(area.Find(key));
                    currentPoint = area.Find(key);
                    while (true)
                    {
                        if (currentPoint.Index == 'C')
                        {
                            Console.WriteLine($"What would you like to do? You are currently in {currentPoint.Name}");
                            if (currentPoint.IsItemTaken)
                                Console.WriteLine($"Press L - to look around again, I - to open inventory or Q - to go back.");
                            else
                                Console.WriteLine($"Press L - to look around again, I - to open inventory, O - to open the chest or Q - to go back.");
                            key = Console.ReadKey().KeyChar;
                            switch (key)
                            {
                                case 'i':
                                case 'I':
                                    player.ShowInventory();
                                    break;
                                case 'l':
                                case 'L':
                                    currentPoint.ShowDescription();
                                    break;
                                case 'o':
                                case 'O':
                                    if (player.IsKeyTaken && currentPoint.IsItemTaken == false)
                                    {
                                        Console.WriteLine("You inserted the key, it fits perfectly, you turn it and now the chest is open.\n Inside you see some pills with a note 'For Headache' Perfect.");
                                        currentPoint.TakeItem();
                                        player.TakeItem(currentPoint.Item);
                                    }
                                    if (!player.IsKeyTaken)
                                        Console.WriteLine("\nThe chest is locked, you need a key to open it.");
                                    else
                                        currentPoint.ShowDescription();
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (currentPoint.Index == 'X')
                        {
                            Console.WriteLine($"What would you like to do? You are currently in {currentPoint.Name}");
                            Console.WriteLine($"Press L - to look around again, I - to open inventory, O - to type password or Q - to go back.");
                            key = Console.ReadKey().KeyChar;
                            switch (key)
                            {
                                case 'i':
                                case 'I':
                                    player.ShowInventory();
                                    break;
                                case 'l':
                                case 'L':
                                    currentPoint.ShowDescription();
                                    break;
                                case 'o':
                                case 'O':
                                    Console.WriteLine("Type password (6 digits only):");
                                    if (int.TryParse(Console.ReadLine(), out int pass))
                                        if (pass == 657431)
                                        {
                                            // ENDING TODO
                                            // Poprawić wszystkie teksty tak żeby się nie mieszały ze sobą oraz żeby można było je łatwo przeczytać!
                                            // Spróbować zrefaktoryzować kod bo w niektórych miejscach aż w oczy kole.
                                        }
                                        else
                                            Console.WriteLine("Sorry, wrong password.");
                                    else
                                        Console.WriteLine("DIGITS ONLY!!");
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (currentPoint.Index != 'C' && currentPoint.Index != 'X')
                        {
                            Console.WriteLine($"What would you like to do? You are currently in {currentPoint.Name}");
                            if (currentPoint.IsItemTaken)
                                Console.WriteLine($"Press L - to look around again, I - to open inventory or Q - to go back.");
                            else
                                Console.WriteLine($"Press L - to look around again, I - to open inventory, T - to take {currentPoint.Item.Name} or Q - to go back.");
                            key = Console.ReadKey().KeyChar;
                            switch (key)
                            {
                                case 'i':
                                case 'I':
                                    player.ShowInventory();
                                    break;
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
                                        Console.WriteLine("\nThe moment you grabbed the torch, everything lit up...\nit was as if the flames from the torch had spread across the entire ceiling in that area");
                                        area.AddNewAreas();
                                    }
                                    if (currentPoint.Item.Name == "Key")
                                        player.IsKeyTaken = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                            if (key == 'Q' || key == 'q') break;
                        }
                    }

                }
            }
        }
    }