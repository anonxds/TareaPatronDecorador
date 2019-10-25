using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPatronDecorador
{
    public abstract class nueva
    {
        //La clase abstracta solo puede contenr funciones con cuerpo osea lleva() {}
        public abstract int suma();
        public abstract int resta();
        int suma1()
        {
            return 4;
        }
        void hola()
        {
            string hello = "hola!";
        }
    }

    interface nueva2
    {
        //La interface tambien puede contener funciones y en caso de herencias se deben inplementar TODAS las funciones
        void summa();
        void resta();

    }
    class ejemplo1 : nueva //Usando herencia con una clase abstracta
    {
        public override int resta()
        {
            throw new NotImplementedException();
        }

        public override int suma()
        {
            throw new NotImplementedException();
        }
    }
    class ejemplo2 : nueva2 //Usando herencia con una interfaz
    {
        public void resta()
        {
            throw new NotImplementedException();
        }

        public void summa()
        {
            throw new NotImplementedException();
        }
    }
    //En caso de herencia ya sea abstract o interface no hay diferencia. PERO ES MAS RECOMENDABLE USAR INTERFACE
    //POR QUE NO ES MUY ESCRICTO AL MOMENTO DE DECLARAR METODOS
}
