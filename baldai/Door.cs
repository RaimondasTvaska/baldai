using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baldai
{
    class Door
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public double Length { get; set; }//cm
        public double Width { get; set; }//cm
        public double Height { get; set; }//mm
        public int  Hinges { get; set; }//measure kPa
        public string Side { get; set; }

        public List<Miscellaneous> misc = new List<Miscellaneous>();

        public override string ToString()
        {
            return "Pavadinimas - " + Name + " medžiaga -" + Material + "; ";
        }
    }
}
