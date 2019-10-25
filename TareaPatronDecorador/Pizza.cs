using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    public abstract class Pizza
    {
        protected string descripcion = "Pizza Generica";

        public virtual string Descripcion()
        {
            return descripcion;
        }

        public abstract double precio();
    }

}
