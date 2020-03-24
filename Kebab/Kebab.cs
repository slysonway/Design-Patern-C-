using System;

namespace Kebab
{
    public class Kebab
    {
        private bool salad { get; set; }
        private bool tomato { get; set; }
        private bool onion { get; set; }
        private bool meat { get; set; }
        

        public Kebab(bool salad, bool tomato, bool onion, bool meat)
        {
            this.salad = salad;
            this.tomato = tomato;
            this.onion = onion;
            this.meat = meat;
        }
        
        Boolean isVegetarian()
        {
            return meat;
        }
    }
}