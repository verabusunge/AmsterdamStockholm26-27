using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.MärtaScripts
{
    public class Kladdkaka : Dish
    {
        public Kladdkaka()
        {
            //Each number represents an ingredient, ex butter = 1, flour = 2, etc
            ingridients = new List<int> {1, 2, 3, 4, 5 };
            isMixed = false;
            isCooked = false;
        }

        public override void Mixing()
        {
            //overrides SC, check if isRecepie = true,, --> set sprite as kladdkaka etc 
        }

        public override void Cook()
        {
            //overrides SC, sets sprite as kladdkaka etc 
        }
    }
}
