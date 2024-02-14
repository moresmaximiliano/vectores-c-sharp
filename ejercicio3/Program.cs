using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. 
            // Ejemplo:
            // CADENA FUENTE: “La mar estaba serena"
            // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // CADENA RESULTADO: “Li mir estibi sereni"

            
            
            // FORMA 1 DE HACERLO (UN WHILE Y DOS FOR)
            
            
            
            // char [] frases = new char [100];
            // int indice;
            // char letra,caracter1,caracter2;
            // Console.WriteLine("Ingrese una frase o texto cualquiera (letra por letra), finalizando con punto:");
            // letra = char.Parse (Console.ReadLine());
            // indice = 0;
            // while (letra != '.' && indice < 100)
            // {
            //     frases[indice] = letra;
            //     indice ++;
            //     Console.WriteLine("Ingrese la siguiente letra o finalice con punto:");
            //     letra = char.Parse (Console.ReadLine());
            // }
            // Console.WriteLine("Ingrese el caracter que desea reemplazar:");
            // caracter1 = char.Parse (Console.ReadLine());
            // Console.WriteLine("Ingrese el caracter que desea introducir en cambio:");
            // caracter2 = char.Parse (Console.ReadLine());
            // for (int x = 0; x < indice; x++)
            // {
            //     if (frases[x] == caracter1)
            //     {
            //         frases[x] = caracter2;
            //     }
            // }
            // for (int x = 0; x < 100; x++)
            // {
            //     Console.Write(frases[x]);
            // }


            
            // FORMA 2 DE HACERLO (3 WHILE CON EL '\0')

            
            
            // char [] frases = new char [100];
            // int indice;
            // char letra,caracter1,caracter2;
            // Console.WriteLine("Ingrese una frase o texto cualquiera (letra por letra), finalizando con punto:");
            // letra = char.Parse (Console.ReadLine());
            // indice = 0;
            // while (letra != '.' && indice < 100)
            // {
            //     frases[indice] = letra;
            //     indice ++;
            //     Console.WriteLine("Ingrese la siguiente letra o finalice con punto:");
            //     letra = char.Parse (Console.ReadLine());
            // }
            // Console.WriteLine("Ingrese el caracter que desea reemplazar:");
            // caracter1 = char.Parse (Console.ReadLine());
            // Console.WriteLine("Ingrese el caracter que desea introducir en cambio:");
            // caracter2 = char.Parse (Console.ReadLine());
            // frases[indice] = '\0';
            // indice = 0;
            // while (frases[indice] != '\0')
            // {
            //     if (frases[indice] == caracter1)
            //     {
            //         frases[indice] = caracter2;
            //     }
            //     indice ++;
            // }
            // indice = 0;
            // while (frases[indice] != '\0')
            // {
            //     Console.Write(frases[indice]);
            //     indice ++;
            // }


            string frase;
            char letraActual;
            char letraNueva;
            Console.WriteLine("Ingrese la frase:");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a reemplazar:");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva:");
            letraNueva = char.Parse(Console.ReadLine());
            frase = frase.Replace(letraActual,letraNueva);
            Console.WriteLine("La frase nueva es:");
            Console.WriteLine(frase);
        }
    }
}
