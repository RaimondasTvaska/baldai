using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baldai
{
    class Miscellaneous
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public double Length { get; set; }//cm
        public double Width { get; set; }//cm
        public double Height { get; set; }//mm
        public string Shape { get; set; }//measure kPa
        public bool Transparent { get; set; }
        public string PositionX { get; set; }
        public string PositionY { get; set; }

        public List<Miscellaneous> misc = new List<Miscellaneous>();
    }
}
