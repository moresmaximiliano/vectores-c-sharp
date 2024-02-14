using System;

namespace ejemplos_vectoresbool
{
    class Program
    {
        static void Main(string[] args)
        {
            // registro algo en el tiempo cuyo resultado puede ser vd o falso, ej faltas del trabajo

            bool [] asistenciasQuincena1 = new bool [15];
            for (int x = 0; x < 15; x++)
            {
                //llenamos el vector con P o A segun vino o no
            }

            // ahora tenemos 16 clases y queremos registrar si faltan o no, registrando en conjunto con sus legajos (tengo 100 alumnos)
            bool [] asistencia = new bool [100];
            int [] legajos = new int [100];
            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 100; y++)
                {
                    //controlo si faltaron o no llenando el vector bool
                }
            }
        }
    }
}
