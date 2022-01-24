using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Person
    {
        private string name;
        public Building building { get; set; }

        public Person(string name)
        {
            this.name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"I'm a human, my name is {name}");
            Console.WriteLine("Building info:");
            building.ShowInfo();
            building.GetDoor().ShowInfo();
            building.GetRoof().ShowInfo();
            building.GetWindows().ShowInfo();


        }
    }

}
