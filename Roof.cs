using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Roof
    {
        public string RoofColor { get; set; }

        public Roof(string roofcolor = "red")
        {
            RoofColor = roofcolor;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"The color of James house roof is {RoofColor}");
        }
    }
}
