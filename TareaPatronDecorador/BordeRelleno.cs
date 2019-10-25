using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    class BordeRelleno : Pizza
    {
        public BordeRelleno()
        {
            descripcion = "Borde Relleno";
        }

        public override double precio()
        {
            return 45;
        }
    }
}
