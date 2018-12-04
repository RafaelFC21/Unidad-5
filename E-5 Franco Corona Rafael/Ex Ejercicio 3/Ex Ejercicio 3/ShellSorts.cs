using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Ejercicio_3
{
    class ShellSorts
    {
        public int[] numeros;//Inicializamos vector para ingresar numeros...

        public void Ingresar()
        {
            //Declaración de variables.
            int linea;
            Console.WriteLine("-----------ShellSort-----------");
            Console.Write("Cuantos numeros desea ingresar: ");
            linea = int.Parse(Console.ReadLine());//Se ingresa cantidad de numeros a ingresar.
            numeros = new int[linea];//Se delimita el arreglo.
            for (int contador = 0; contador < numeros.Length; contador++)
            {
                Console.Write("Ingrese elemento " + (contador + 1) + ": ");
                numeros[contador] = int.Parse(Console.ReadLine());//Se ingresan los numeros en el arreglo.
            }
        }

        public void Ordenar()
        {
            //Declaración de las variables.
            int salto = 0;
            int condicion = 0;
            int temp = 0;
            int contador = 0;
            salto = numeros.Length / 2;//Al salto se le da el valor de la mitad del numero de valores en el arreglo.
            while (salto > 0)//Mientras el salto es menor a 0.
            {
                condicion = 1;
                while (condicion != 0)//Mientras la condicion sea diferente de cero.
                {
                    condicion = 0;//La condicion toma valor 0 de nuevo, si esta condicion pasa sin tocar el if saldrá del while.
                    contador = 1;//El contador empieza en uno.
                    while (contador <= (numeros.Length - salto))//Mientras contador sea menor o igual a la longitud del arreglo menos el salto...
                    {
                        if (numeros[contador - 1] > numeros[(contador - 1) + salto])//Si los el numero anterior al que marca el contador es mayor al numero de la posicion (contador - 1 más el salto)...
                        {
                            temp = numeros[(contador - 1) + salto];//La temporal resive el valor de el numero del la poosicion de (el contador -1 y eso más el salto).
                            numeros[(contador - 1) + salto] = numeros[contador - 1];//Ese numero toma el valor del numero anterior al que marca el contador
                            numeros[(contador - 1)] = temp;//Ahora el numero que dio su valor toma el valor del numero que lo perdío.
                            condicion = 1;//Condición toma valor 1 para repetir el primer while
                        }
                        contador++;
                    }
                }
                salto = salto / 2;//Regla de ShellSort para reducir el salto.
            }
        }

        public void Desplegar()
        {
            Console.WriteLine("Numeros ordenados de menor a mayor: ");
            for (int contador = 0; contador < numeros.Length; contador++)//Ciclo para desplegar cada valor del arreglo.
            {
                Console.Write(numeros[contador] + "  ");
            }
            Console.WriteLine("\nPresione <ENTER> para salir");
            Console.ReadKey();
        }
    }
}
