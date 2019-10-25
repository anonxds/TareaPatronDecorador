using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    class CndQueso : DecoradorPizza
    {
        private Pizza _pizza;

        public CndQueso(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Descripcion()
        {
            return "Queso";
        }

        public override double precio()
        {
            return 40 + _pizza.precio();
        }
    }
}
