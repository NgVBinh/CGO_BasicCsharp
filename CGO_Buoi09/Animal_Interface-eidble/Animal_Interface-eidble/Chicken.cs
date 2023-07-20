using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Interface_eidble
{
    public class Chicken : Animal, Edible
    {       
        public override string HowToEat()
        {
            return "Could be fried";
        }
        public override string MakeSound()
        {
            return "cuc cu";
        }
    }
}
