using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Door
    {
        public string Color { get; set; }

        public Door (string color = "blue")
        {
            Color = color;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"I'm a door, my color is {Color}");
        }
    }
}
