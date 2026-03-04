using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_pokemon
{
    public class Hero
    {
      

        public int Helth {  get; set; }
        public int MaximumHelth { get; set; }
        public int Demage { get; set; }

        public Hero(int helth, int maximumHelth, int demage)
        {
            Helth = helth;
            MaximumHelth = maximumHelth;
            Demage = demage;
        }
    }
}
