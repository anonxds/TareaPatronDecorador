using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    class CndJamon : DecoradorPizza
    {
        private Pizza _pizza;

        public CndJamon(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Descripcion()
        {
            return "Jamón";
        }

        public override double precio()
        {
            return 15 + _pizza.precio();
        }
    }
}
