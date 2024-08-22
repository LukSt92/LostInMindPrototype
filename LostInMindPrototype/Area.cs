using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class Area
    {
        List<PointOfInterest> points = new List<PointOfInterest>()
        {
            new StartingPlace(),
            new BrightPlace(),
        };

        public void ShowPoints()
        {
            foreach (var point in points)
            {
                Console.WriteLine($"{point.Name} - press {point.Index} to go there.");
            }
        }
        public PointOfInterest Find(char key)
        {
             return points.Find(x => x.Index == key);
        }
        public void GoTo(PointOfInterest point)
        {
            point.ShowDescription();
        }
        public void ShowOptions(PointOfInterest point)
        {
            Console.WriteLine($"Press L to look around again, Press T to take {point.Item.Name} or Q to go back.");
        }
        public void AddNewAreas()
        {
            points.Add(new StrangePlace());
            points.Add(new PileOfClothesPlace());
            points.Add(new DoorPlace());
        }
    }
}
