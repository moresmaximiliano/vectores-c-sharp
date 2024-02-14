using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.

            int [] articulos = new int [15];
            int numArt,cantVendida,maximo,posMaximo;
            for (int x = 0; x < 15; x++)
            {
                articulos[x] = 0;
            }
            Console.WriteLine("Ingrese el número de artículo (del 1 al 15):");
            numArt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            cantVendida = int.Parse(Console.ReadLine());
            while (numArt != 0)
            {
                articulos [numArt - 1] += cantVendida;
                Console.WriteLine("Ingrese el número de artículo (del 1 al 15):");
                numArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida:");
               cantVendida = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Del artículo número 10 se vendieron " + articulos[9] + " unidades.");
            for (int x = 0; x < 15; x++)
            {
                if (articulos[x] == 0)
                {
                    Console.WriteLine("El artículo número " + (x + 1) + " no registró ventas.");
                }
            }
            maximo = articulos[0];
            posMaximo = 1;
            for (int x = 0; x < 15; x++)
            {
                if (articulos[x] > maximo)
                {
                    maximo = articulos[x];
                    posMaximo = x + 1;
                }
            }
            Console.WriteLine("El número de artículo que mas ventas registró en total es el articulo " + posMaximo + " con " + maximo + " unidades vendidas.");
        }
    }
}
