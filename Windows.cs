using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Windows
    {
        public int WindowAmound { get; set; }

        public Windows(int windowamound = 5)
        {
            WindowAmound = windowamound;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"I'm window, my house has {WindowAmound} windows.");
        }
    }
}
