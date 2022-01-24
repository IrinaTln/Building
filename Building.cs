using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public abstract class Building
    {
        public int Space { get; set; }
        public int FlatsHouse { get; set; }
        public Door door;
        public Roof roof;
        public Windows windos;
        
        public Materials Matirials { get; set; }

        public Building (int space = 120, int flatshouse = 15)
        {
            Space = space;
            FlatsHouse = flatshouse;
        }
        public abstract void ShowInfo();


        public Door GetDoor()
        {
            return door;
        }

        public Roof GetRoof()
        {
            return roof;
        }

        public Windows GetWindows()
        {
            return windos;
        }
    }
}
