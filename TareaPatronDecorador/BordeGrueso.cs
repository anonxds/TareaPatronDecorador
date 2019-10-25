using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    class BordeGrueso : Pizza
    {
        public BordeGrueso()
        {
            descripcion = "Borde Grueso";
        }

        public override double precio()
        {
            return 30;
        }

    }
}
