using System;

namespace ejemplos_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [10];
            int a, b = 1;
            // indices | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |  
            // valores | 7 |   |   |   |   |   | 1 |   |   |32450| 
            numeros [6] = 1;
            numeros [0] = 7;
            numeros [9] = 32450;

            a = numeros [0] + numeros [6] + numeros [9] + b;
            Console.WriteLine(numeros[0]);
            Console.WriteLine(a);


            //-Si quiero cargar el vector de 10 elementos con pocas lineas de codigo puedo hacer
            
            // int nota;
            // int [] numeros = new int [10];
            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese la nota:");
            //     nota = int.Parse(Console.ReadLine());
            //     numeros [x] = nota;
            // }

            //-Si quiero sacar el promedio de esos 10 valores puedo luego hacer esto

            // int acu = 0;
            // for (int x = 0; x < 10; x++)
            // {
            //     acu += numeros [x];
            // }
            // int promedio = acu / 10;

            //-Si quiero mostrar los elementos del vector en orden puedo hacer

            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("El valor en la posición " + (x + 1) + "del vector es: " + numeros[x]);
            // }
        }
    }
}
