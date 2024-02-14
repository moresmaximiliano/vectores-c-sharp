using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int [] numeros = new int [10];
            int acu = 0;
            float promedio;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número");
                numeros [x] = int.Parse(Console.ReadLine());
                acu += numeros [x];
            }
                
            promedio = acu / 10F;
            Console.WriteLine("El promedio de los números ingresados es igual a " + promedio);
            for (int x = 0; x < 10; x++)
            {
                if (numeros [x] > promedio)
                {
                    Console.WriteLine("El número " + numeros[x] + " es mayor al promedio");
                }
            }
        }
    }
}
