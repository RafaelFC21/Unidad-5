using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbasaur
{
    class ClaseBulbasaur
    {
        public void Ordenar()
        {
            int temp;
            int[] bubble = new int[4] { 3, 5, 2, 1 };//Se crea arreglo con valores predefinidos.
            Console.Write("Números en el arreglo: ");
            foreach (var item in bubble)//Se despliegan los valores del arreglo originales.
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            for (int cont = 0; cont < bubble.Length; cont++)//for para que se repita el procedimiento de acomodar los numeros para que se ordenen completamente.
            {
                for (int cont2 = 1; cont2 < bubble.Length; cont2++)//for para que se acomoden los numeros
                {
                    if (bubble[cont2 - 1] > bubble[cont2])//Si el numero anterior es mayor al anterior se realiza lo siguiete...
                    {
                        temp = bubble[cont2];//Se guarda el numero actual para ser utilizado despues.
                        bubble[cont2] = bubble[cont2 - 1]; //Se sustituye el numero actual por el anterior.
                        bubble[cont2 - 1] = temp;//Se sustituye el valor del numero anterior por el actual.
                    }
                }
            }
            Console.Write("Números ordenados: ");
            foreach (var item in bubble)//Se despliegan los valores ordenados.
            {
                Console.Write(item + " ");
            }
        }
    }
}
