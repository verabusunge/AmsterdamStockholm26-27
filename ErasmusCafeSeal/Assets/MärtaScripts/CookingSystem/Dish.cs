using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Dish
    {
        public bool isCooked;
        public bool isMixed;
        public List<int> ingridients;

        public virtual void Recepie(bool isCooked, bool isMixed, List<int> ingridients)
        {
           this.isCooked = isCooked;
           this.isMixed = isMixed;
           this.ingridients = ingridients;
        }

        public virtual void Mixing()
        {   
            //Should be called upon as "whisk" collide w bowl
            //isMixed set true 

            //call for DishCheck --> is recepie right? (isRecepie==true) -->
            //Sprite change, play Sound efx
        }
        
        public virtual void Cook()
        {
            //similar to mix, should be called after/as oven-timer is set/done
            //isCooked set true
            //sprite change, soound efx
        }

        public void SLOP()
        {
            //should be called for if isRecepie == false && Mixing() --> set sprite as Goo? (safety net for failure)
        }

    }
