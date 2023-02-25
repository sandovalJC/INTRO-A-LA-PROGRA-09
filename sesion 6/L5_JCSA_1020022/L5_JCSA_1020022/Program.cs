using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_JCSA_1020022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO 1*/
            Console.WriteLine("Ejercicio 1");

            Console.Write("Número ENTERO: ");
            string numeroingresado = Console.ReadLine();

            int numero;
            if (int.TryParse(numeroingresado, out numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine("RESULTADO: El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("RESULTADO: El número es negativo.");
                }
                else
                {
                    Console.WriteLine("RESULTADO: El número es cero.");
                }
            }
            else
            {
                Console.WriteLine("Error: El valor ingresado no es un número entero válido.");
            }
            /*EJERCICIO 2*/

            Console.WriteLine("Ejercicio 2");

            Console.Write("Ingrese el número de día (1-7): ");
            int dia = int.Parse(Console.ReadLine());
            if (dia < 1 || dia > 7)
            {
                Console.WriteLine("El numero de dia ingresado no esta entre el 1 y el 7");

            }
            else
            {
                string nombreDia = "";
                if (dia == 1)
                {
                    nombreDia = "LUNES";
                }
                else if (dia == 2)
                {
                    nombreDia = "MARTES";
                }
                else if (dia == 3)
                {
                    nombreDia = "MIERCOLES";
                }
                else if (dia == 4)
                {
                    nombreDia = "JUEVES";
                }
                else if (dia == 5)
                {
                    nombreDia = "VIERNES";
                }
                else if (dia == 6)
                {
                    nombreDia = "SABADO";
                }
                else if (dia == 7)
                {
                    nombreDia = "DOMINGO";
                }
                Console.WriteLine(" El dia de la semana es : " + nombreDia);
            }


            Console.ReadKey();

        }
    }
}
