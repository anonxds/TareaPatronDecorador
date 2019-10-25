using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    class CndPina : DecoradorPizza
    {
        private Pizza _pizza;

        public CndPina(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Descripcion()
        {
            return "Piña";
        }

        public override double precio()
        {
            return 15 + _pizza.precio();
        }
    }
}
