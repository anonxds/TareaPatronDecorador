using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    class CndPeperoni : DecoradorPizza
    {
        private Pizza _pizza;

        public CndPeperoni(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Descripcion()
        {
            return "Peperoni";
        }

        public override double precio()
        {
            return 20 + _pizza.precio();
        }
    }
}
