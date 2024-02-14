using System;

namespace cadena_de_caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vector de char
            // char [] asistencias = new char [10];
            // asistencias [0] = 'P';
            // asistencias [1] = 'P';
            // asistencias [2] = 'A';

            // |P|A|A|P|P|P|P|A|A|P| ---> Vector de char
            // |H|O|L|A|\0| | | | | | ---> Cadena de caracteres    

            //Quiero cargar un nombre y que ponga "hola -mi nombre-" puedo hacer:
            // 1)
            
            // char [] nombre = new char [11];
            // char letra;
            // int indice = 0;
            // Console.WriteLine("Ingrese su nombre letra por letra (termina con '.')");
            // letra = char.Parse (Console.ReadLine());
            // while (letra != '.' && indice < 10)
            // {
            //     nombre [indice] = letra;
            //     indice ++;
            //     letra = char.Parse (Console.ReadLine());
            // }
            // nombre [indice] = '\0';
            // Console.Write("Hola ");
            // indice = 0;
            // while (nombre [indice] != '\0')
            // {
            //     Console.Write(nombre [indice]);
            //     indice ++;
            // }

            // 2) ----> resume todo el proceso anterior con el tipo de dato string

            string nombre;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
        }
    }
}
