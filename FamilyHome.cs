using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class FamilyHome:Building
    {
        int size;
        string status;

        public FamilyHome (int space = 60) : base(space)
        {
            
        }
        public int Size
        {
            set
            {
                size = value;
                if (size >= 50) status = "small house";
                else if (size < 100 && size >150) status = "middle house";
                else if (size < 150) status = "big house";

            }
            get { return (size); }
        }

        public string Status
        {
            get { return status; } 
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"James house space is {Space} m2");
            Console.WriteLine($"It's {status}.");
        }
    }

}
