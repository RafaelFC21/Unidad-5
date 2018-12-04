using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix
{
    class Sort
    {
        //Creacion de arreglos con valores predefinidos
        int[] arreglo1 = { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };
        int[] arreglo2 = { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
        int[] arreglo3 = { 10, 40, 36, 5, 24, 2, 5, 8 };
        int[] arreglo4 = { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
        int[] arreglo5 = { 25, 108, 1024, 12, 351, 251, 39 };
        public Sort()
        {
            Console.WriteLine("\nOriginal: ");
            //Se despliega el arreglo original.
            Desplegar(arreglo1, 1);
            Desplegar(arreglo2, 2);
            Desplegar(arreglo3, 3);
            Desplegar(arreglo4, 4);
            Desplegar(arreglo5, 5);
            //Se ordena cada arreglo por separado.
            Sorting(arreglo1);
            Sorting(arreglo2);
            Sorting(arreglo3);
            Sorting(arreglo4);
            Sorting(arreglo5);
            Console.WriteLine("\nOrdenado: ");
            //Se despliega el arreglo ordenado.
            Desplegar(arreglo1, 1);
            Desplegar(arreglo2, 2);
            Desplegar(arreglo3, 3);
            Desplegar(arreglo4, 4);
            Desplegar(arreglo5, 5);
            Console.WriteLine("\n");
            Console.ReadKey();
        }
        public void Desplegar(int[]arreglo, int n_arreglo)//Metodo que despliega los arreglos dependiendo de los datos instanciados.
        {
            Console.WriteLine("Vector {0}: ", n_arreglo);
            foreach (var item in arreglo)//Se imprime cada valor del arreglo.
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }

        public void Sorting(int [] arreglo)//Metodo para ordenar los valores del arreglo instanciado.
        {
            int[] temp = new int[arreglo.Length];//Arreglo temporal que tiene como limite el largo del arreglo instanciado.
            for (int shift = 31; shift > -1; --shift)
            {
                int j = 0;
                for (int i = 0; i < arreglo.Length; ++i)
                {
                    bool move = (arreglo[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arreglo[i - j] = arreglo[i];
                    else
                        temp[j++] = arreglo[i];
                }
                Array.Copy(temp, 0, arreglo, arreglo.Length - j, j);
            }

        }
    }
}
