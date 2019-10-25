using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    class CndSalchicha : DecoradorPizza
    {
        private Pizza _pizza;

        public CndSalchicha(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string Descripcion()
        {
            return "Salchicha";
        }

        public override double precio()
        {
            return 20 + _pizza.precio();
        }
    }
}
