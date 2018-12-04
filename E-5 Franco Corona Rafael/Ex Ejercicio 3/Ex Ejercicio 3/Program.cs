using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShellSorts shellSorts = new ShellSorts();//Creación del objeto de la clase ShellSorts
            //Llamamiento de metodos.
            shellSorts.Ingresar();
            shellSorts.Ordenar();
            shellSorts.Desplegar();
        }
    }
}
