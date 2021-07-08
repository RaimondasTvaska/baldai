﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baldai
{
    class Leg
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public double Length { get; set; }//cm
        public double Width { get; set; }//mm
        public double Height { get; set; }//mm
        public string Color { get; set; }//sq, circle
        public string BendThoughness { get; set; }//measure kPa

        public List<Miscellaneous> misc = new List<Miscellaneous>();

        public override string ToString()
        {
            return "Pavadinimas - " + Name + " medžiaga -" + Material + "; ";
        }

    }
}
