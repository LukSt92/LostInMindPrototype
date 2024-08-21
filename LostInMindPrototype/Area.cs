using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInMindPrototype
{
    class Area
    {
        List<PointOfInterest> points = new List<PointOfInterest>();

        public void ShowPoints()
        {
            foreach (var point in points)
            {
                Console.WriteLine(point.Name);
            }
        }
    }
}
