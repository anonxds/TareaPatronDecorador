using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    class BordeDelgado : Pizza
    {
        public BordeDelgado()
        {
            descripcion = "Borde Delgado";
        }

        public override double precio()
        {
            return 40;
        }
    }
}
