using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile()
        {

        }

        //color(s) of scales
        public string Scales { get; set; }
        
        //internal or external fertilization
        public string Egg_Fertilization { get; set; }
        
        //number of lungs
        public int Lungs { get; set; }
        
        //length of body + tail
        public string Length { get; set; }

    }
}
