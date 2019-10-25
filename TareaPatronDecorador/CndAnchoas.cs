using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    class CndAnchoas : DecoradorPizza
    {
        private Pizza _pizza;

        public CndAnchoas(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Descripcion()
        {
            return "Anchoas";
        }

        public override double precio()
        {
            return 10 + _pizza.precio();
        }
    }
}
