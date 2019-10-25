using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    class BordeMixto : Pizza
    {
        public BordeMixto()
        {
            descripcion = "Borde Misto";
        }

        public override double precio()
        {
            return 50;
        }
    }
}
