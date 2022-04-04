using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        //color(s) of eggs
        public string Egg_Colors {get;set;}

        //beak color(s)
        public string Beak_Color {get;set;}

        //feather color(s)
        public string Feather_Colors {get;set;}

        //measurement from one wingtip to the other
        public string Wingspan {get;set;}


    }
}
