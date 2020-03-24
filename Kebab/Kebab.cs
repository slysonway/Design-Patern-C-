using System;
using System.Collections.Generic;
using System.Linq;

namespace Kebab
{
    public class Kebab
    {
        private bool salad { get; set; }
        private bool tomato { get; set; }
        private bool onion { get; set; }
        private List<Meat> meat { get; set; }
        private List<Sauce> sauce { get; set; }
        private int cheese { get; set; }


        public Kebab(bool salad, bool tomato, bool onion, List<Meat> meat, List<Sauce> sauce, int cheese)
        {
            this.salad = salad;
            this.tomato = tomato;
            this.onion = onion;
            this.meat = meat;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        
        public bool isVegetarian()
        {
            return !meat.Any();
        }

        public bool isPescetarian()
        {
            return !meat.Contains(Meat.Chicken) && !meat.Contains(Meat.Steak) && !meat.Contains(Meat.Kebab);
        }

        public Kebab withOutOnion()
        {
            this.onion = false;
            return this;
        }

        public Kebab addCheese()
        {
            if (cheese == 0)
            {
                cheese++;
            }
            else
            {
                cheese *= 2;
            }
            
            return this;
        }

        public override string ToString()
        {
            return $"{nameof(salad)}: {salad}, {nameof(tomato)}: {tomato}, {nameof(onion)}: {onion}, {nameof(meat)}: {string.Join(",", meat)}, {nameof(sauce)}: {string.Join(",", sauce)}, {nameof(cheese)}: {cheese}";
        }
    }
}