using System;
using System.Collections.Generic;
using System.Linq;

namespace Kebab
{
    public class Kebab
    {
        public enum Meat
        {
            Kebab, Chicken, Fish, Shrimp, Steak
        }
        public enum Sauce
        {
            Algerian, Samourai, Blanche, BBQ, Ketchup, Mayo
        }
        private bool salad { get; set; }
        private bool tomato { get; set; }
        private bool onion { get; set; }
        private List<Meat> meat { get; set; }
        private List<Sauce> sauce { get; set; }
        

        public Kebab(bool salad, bool tomato, bool onion, List<Meat> meat, List<Sauce> sauce)
        {
            this.salad = salad;
            this.tomato = tomato;
            this.onion = onion;
            this.meat = meat;
            this.sauce = sauce;
        }
        
        public bool isVegetarian()
        {
            return !meat.Any();
        }

        public bool isPescetarian()
        {
            return !meat.Contains(Meat.Chicken) && !meat.Contains(Meat.Steak) && !meat.Contains(Meat.Kebab);
        }
    }
}