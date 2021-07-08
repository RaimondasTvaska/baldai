using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baldai
{
    class Furniture
    {
        public string Name { get; set; }
        public List<Leg> legs = new List<Leg>();
        public List<Surface> surfaces = new List<Surface>();
        public List<Door> doors = new List<Door>();

        public string printDoors()
        {
            string text = "";
            foreach (var door in doors)
            {
                text += door;
            }
            return text;
        }
        public string printLegs()
        {
            string text = "";
            foreach (var leg in legs)
            {
                text += leg;
            }
            return text;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        /*
         * legs
         * pavirsiai
         * doors
         */
    }
}
