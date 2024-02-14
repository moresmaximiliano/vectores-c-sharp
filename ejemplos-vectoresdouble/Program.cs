using System;

namespace ejemplos_vectoresdouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            double temperatura;
            double [] muestraMatutina = new double [31];
            double [] muestraVespertina = new double [31];
            double [] muestraNocturna = new double [31];
            Console.WriteLine("Cargue el resgistro matutino:");
            for (int x = 0; x < 31; x++)
            {
                Console.WriteLine("Ingrese dia:");
                dia = int.Parse (Console.ReadLine());
                Console.WriteLine("Ingrese temepratura registrada:");
                temperatura =  double.Parse (Console.ReadLine());
                muestraMatutina[dia - 1] = temperatura;
            }

            //luego para leer el vector
            
            // for (int x = 0; x < 31; x++)
            // {
            //     muestraMatutina [x];
            // }

            //AHORA NINGUNO DE LOS DATOS ES CONSECUTIVO
            
            // double [] sueldos = new double [50];
            // int [] legajos = new int [50];
            // for (int x = 0; x < 50; x++)
            // {
            //     sueldos [x] = 123;
            //     legajos [x] = 456;
            // }

            //tengo que crear 2 vectores diferentes, uno para cada dato, no pudiendo aprovechar los indices de uno para guardar el otro dato (primer caso)
        }
    }
}
