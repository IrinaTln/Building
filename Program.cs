using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyHome house = new FamilyHome();
            Person man = new Person("James.");
            house.door = new Door("white.");
            house.roof = new Roof("red.");
            house.windos = new Windows();
            man.building = house;
            man.ShowInfo();


            Flats house2 = new Flats();
            house2.ShowInfo();

            Console.ReadKey();
        }

    }
}
