using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbasaur
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseBulbasaur bulbasaur = new ClaseBulbasaur();//Creación de la clase bulbasaur
            bulbasaur.Ordenar();//Se llama al metodo Ordenar de la clase bulbasaur
            Console.ReadKey();
        }
    }
}
