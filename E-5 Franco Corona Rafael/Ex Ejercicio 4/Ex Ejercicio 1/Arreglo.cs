using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Ejercicio_4
{
    class Arreglo
    {
        //Se crean nuevos vectores, 1 para cada acomodo.
        string oracion = "lorem ipsum dolor sit amet, consectetur adipiscing elit. fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. duis ac massa est.";        
        public Arreglo()
        {
            char[] A = oracion.ToCharArray();
            Console.WriteLine("------------------Quick Sort------------------\n");
            Console.WriteLine("Vectores normales: ");
            Desplegar(A);//Se manda a llamar el metodo desplegar.
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("------------------Quick Sort------------------\n");
            //Se manda a llamar el metodo Quicksort, uno por cada arreglo.
            Quicksort(A, 0, A.Length-1);
            Console.WriteLine("Vectores ordenados: ");
            Desplegar(A);//Se manda a llamar el metodo desplegar.
            Console.WriteLine("Presione <Enter> para salir...");
            Console.ReadLine();
        }
        public void Quicksort(char[] vector, int primero, int ultimo)//Metodo Quicksort que instancia las variables que se le mandaron cuando lo mandan a llamar.
        {
            int i, j, central;//Se crean las variables
            //Se utiliza int para evitar decimales a la hora de calcular el central.
            char pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];//El valor que quedo en el numero central del arreglo sera utilizado como pivote.
            i = primero;//Se guadan los valores del primero y el ultimo en las variables i y j para que estos puedan ser cambiados.
            j = ultimo;
            byte[] Compara;//Se genera un arreglo de bytes con los ascii por el cual mide el tamaño en bytes de las letras
            byte[] Compara2;
            do
            {
                while (vector[i] < pivote) i++;//Mientras el valor i del vector sea menor al pivote incrementa 1.
                while (vector[j] > pivote) j--;//Mientras el valor j del vector sea mayor al pivote incrementa 2.
                Compara = Encoding.ASCII.GetBytes(vector[i].ToString());//Se generan 2 arreglos de bytes con los ascii por el cual mide el tamaño en bytes de las letras
                Compara2 = Encoding.ASCII.GetBytes(vector[j].ToString());
                int IntCompara = Convert.ToInt32(Compara[0]);
                int IntCompara2 = Convert.ToInt32(Compara2[0]);
                if (i <= j)//Si el valor i es menor o igual al j del vector.
                {
                    char temp;
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

        public void Desplegar(char[] A)//Metodo para desplegar cada uno de los vectores ya ordenados.
        {
            //Cada vez que el contador aumente en 1 despliega el valor del elemento del arreglo en la posicion del contador.
            Console.WriteLine("Vector: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            Console.WriteLine();
        }
    }
}
