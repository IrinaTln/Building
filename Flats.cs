using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Flats:Building
    {
        public Flats(int FlatsHouse = 15) : base(FlatsHouse)
        {
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"I'm flat-building, I have {FlatsHouse} flats.");
        }
    }

}
