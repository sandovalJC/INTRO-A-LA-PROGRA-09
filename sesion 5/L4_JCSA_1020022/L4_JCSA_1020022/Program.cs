using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_JCSA_1020022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio.1 operaciones aritmeticas");

            Console.WriteLine("ingrese numero A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese numero B");
            int B = Convert.ToInt32(Console.ReadLine());
            int suma = (A + B);
            Console.Write("la suma de " + A);
            Console.Write("+" + B);
            Console.Write("=" + suma);
            Console.ReadLine();
            int resta = (A - B);
            Console.Write("la resta de " + A);
            Console.Write("-" + B);
            Console.Write("=" + resta);
            Console.ReadLine();
            int multip = (A * B);
            Console.Write("la multiplicacion de " + A);
            Console.Write("*" + B);
            Console.Write("=" + multip);
            Console.ReadLine();
            int divid = (A / B);
            Console.Write("la divicion entre " + A);
            Console.Write("/" + B);
            Console.Write("=" + divid);
            Console.ReadLine();
            int resid = (A % B);
            Console.Write("el residuo de la divicion entre " + A);
            Console.Write("/" + B);
            Console.Write("=" + resid);
            Console.WriteLine();

            Console.WriteLine("Ejercicio.2: operaciones booleanas");
            if (A < B)
            {
                Console.WriteLine(A + " es menor a " + B);
            }
            if (A == B)
            {
                Console.WriteLine(A + " es igual a " + B);
            }
            if( A > B) 
            { 
                Console.WriteLine(A + " es mayor a " + B); 
            }
            Console.WriteLine();

            Console.WriteLine("Ejercicio.3: Jerarquía de operaciones");
            Console.WriteLine("ingrese numero A");
            int A2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese numero B");
            int B2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese numero C");
            int C2 = Convert.ToInt32(Console.ReadLine());
            int operacon1 = (A2 * B2)+C2;
            int operacon2 = A2 *( B2 + C2);
            int operacon3 = A2/ (B2 * C2);
            int operacon4 = ((3*A2)+(2*B2))/(C2*C2);
            Console.WriteLine("el resultado de la operacion 1 es " + operacon1);
            Console.WriteLine("el resultado de la operacion 2 es " + operacon2);
            Console.WriteLine("el resultado de la operacion 3 es " + operacon3);
            Console.WriteLine("el resultado de la operacion 4 es " + operacon4);

            double a, b, c, discriminante, x1;
            double x2;
            Console.Write("Ingresa el valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de c: ");
            c = double.Parse(Console.ReadLine());
            discriminante = b * b - 4.0 * a * c;
            if (discriminante < 0)
            {
                discriminante = -discriminante;
                Console.WriteLine("Soluciones imaginarias");
            }
            else
                Console.WriteLine("Soluciones reales");
            if (a != 0)
            {
                x1 = (-b + Math.Sqrt(discriminante)) / 2.0 / a;
                x2 = (-b - Math.Sqrt(discriminante)) / 2.0 / a;
            }
            else
            {
                x1 = 0;
                x2 = 0;
                Console.WriteLine("No es una ecuaci\u00F3n cuadr\u00E1tica");
            }
            Console.WriteLine("Valor de discriminante: " + discriminante);
            Console.WriteLine("Valor de x1: " + x1);
            Console.WriteLine("Valor de x2: " + x2);


            Console.ReadLine();
        }
    }
}
