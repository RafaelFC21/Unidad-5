using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Arreglos
    {   //Se crean nuevos vectores, 1 para cada acomodo.
        double[] A = { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 };
        double[] B = { 1, 3, 5, 7, 8, 3, 9, Math.Sqrt(2)/2, 16.5664, 12, 0, 10 };
        double[] C = { 3, 7, 15, 4 / 3, 155, 100, 15, Math.Sqrt(3), 5, 2, 3, 2 };
        double[] D = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };

        public Arreglos()
        {
            Console.WriteLine("------------------Quick Sort------------------\n");
            Console.WriteLine("Vectores normales: ");
            Desplegar(1, A.Length, A);
            Desplegar(2, B.Length, B);
            Desplegar(3, C.Length, C);
            Desplegar(4, D.Length, D); //Se manda a llamar el metodo desplegar.
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("------------------Quick Sort------------------\n");
            //Se manda a llamar el metodo Quicksort, uno por cada arreglo.
            Quicksort(A, 0, 9);
            Quicksort(B, 0, 11);
            Quicksort(C, 0, 11);
            Quicksort(D, 0, 9);
            Console.WriteLine("Vectores ordenados: ");
            Desplegar(1, A.Length, A);
            Desplegar(2, B.Length, B);
            Desplegar(3, C.Length, C);
            Desplegar(4, D.Length, D);//Se manda a llamar el metodo desplegar.
            Console.WriteLine("Presione <Enter> para salir...");
            Console.ReadLine();
        }
        public void Quicksort(double[] vector, int primero, int ultimo)//Metodo Quicksort que instancia las variables que se le mandaron cuando lo mandan a llamar.
        {
            int i, j, central;//Se crean las variables
            //Se utiliza int para evitar decimales a la hora de calcular el central.
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];//El valor que quedo en el numero central del arreglo sera utilizado como pivote.
            i = primero;//Se guadan los valores del primero y el ultimo en las variables i y j para que estos puedan ser cambiados.
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;//Mientras el valor i del vector sea menor al pivote incrementa 1.
                while (vector[j] > pivote) j--;//Mientras el valor j del vector sea mayor al pivote incrementa 2.
                if (i <= j)//Si el valor i es menor o igual al j del vector.
                {
                    double temp;
                    temp = vector[i];//Se guarda el valor i en una temporal.
                    vector[i] = vector[j];//El valor j es colocado en el i.
                    vector[j] = temp;//El valor i guardado en la temporal es guardado en el donde estaba el valor j del vector.
                    i++;//i incrementa en 1.
                    j--;//j decrece en 1.
                }
            }
            while (i <= j);//Mientras i sea menor o igual a j.

            if (primero < j)//Si el primer valor del vector es menor al valor alacenado en j del vector.
            {
                Quicksort(vector, primero, j);//Se manda a llamar el metodo por medio de recursividad.
            }
            if (i < ultimo)//Si el ultimo valor del vector es menor al ultimo valor del vector.
            {
                Quicksort(vector, i, ultimo);//Se manda a llamar el metodo por medio de recursividad.
            }
        }

        public void Desplegar(int n_arreglo, int valor, double[] arreglo)//Metodo para desplegar cada uno de los vectores ya ordenados.
        {
            //Cada vez que el contador aumente en 1 despliega el valor del elemento del arreglo en la posicion del contador.
            Console.WriteLine("Vector {0}: ", n_arreglo);
            for (int i = 0; i < valor; i++)
            {
                Console.Write("{0} ", arreglo[i]);
            }
            Console.WriteLine();
        }
    }
}
