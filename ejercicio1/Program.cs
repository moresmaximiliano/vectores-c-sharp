using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int [] numeros = new int [10];
            int mayor,posMayor;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                numeros [x] = int.Parse(Console.ReadLine());
            }
            mayor = numeros [0];
            posMayor = 1;
            for (int x = 0; x < 10; x++)
            {
                if (numeros [x] > mayor)
                {
                    mayor = numeros [x];
                    posMayor = x + 1;
                }
            }
            Console.WriteLine("El valor maximo de los 10 números ingresados es " + mayor + " ubicado en la posición número " + posMayor + ".");
        }
    }
}
