using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_JCSA_1020022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo ");
            Console.WriteLine("soy Juan Carlos");
            /* la diferencia entre las dos es que al poner write line la frase dentro de forma separada y el write lo ejecuta seguido sin espacios */
            Console.Write("Hola Mundo");
            Console.Write("soy Juan Carlos");
            Console.WriteLine();

            Console.WriteLine("ingrese su nombre");
            string Nombre =Console.ReadLine();
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("soy " + Nombre);
            Console.WriteLine("Tarea 1");
            Console.WriteLine("MI SEGUNDO PROGRAMA");
            string sNombre, sEdad, sCarrera, sCarne;
            Console.WriteLine("ingrese su nombre");
            sNombre = Console.ReadLine();
            Console.WriteLine("ingrese su edad");
            sEdad = Console.ReadLine();
            Console.WriteLine("ingrese su carrera");
            sCarrera = Console.ReadLine();
            Console.WriteLine("ingrese su carné");
            sCarne = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nombre: " + sNombre);
            Console.WriteLine("Nombre: " + sEdad);
            Console.WriteLine("Nombre: " + sCarrera);
            Console.WriteLine("Nombre: " + sCarne);
            Console.WriteLine("soy " + sNombre + " tengo " + sEdad + " años y estudio la carrera de " + sCarrera + " Mi numero de carné es " + sCarne);

            Console.ReadKey();

        }
    }
}
