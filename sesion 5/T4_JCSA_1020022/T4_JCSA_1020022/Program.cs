using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_JCSA_1020022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double Velocidadfin, Velocidadini, aceleraion, tiempo, operacion,respuesta;
            Console.WriteLine("menu de opciones");
            Console.WriteLine("opcion 1 = Velocidad Final");
            Console.WriteLine("opcion 2 = Velocidad Inicial");
            Console.WriteLine("opcion 3 = Aceleracion");
            Console.WriteLine("opcion 4 = Tiempo");
            Console.WriteLine("Ejemplo: si desea calcular Velocidad Final escriba a continuacion solamente numero 1");
            Console.WriteLine("seleccione la opcion que desea calcular, solo aceptar numero de opcion");
            operacion = Convert.ToDouble(Console.ReadLine());
            if (operacion == 1 )
            {
                Console.WriteLine("ingrese Velocidad inicial");
                Velocidadini = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese Aceleracion");
                aceleraion = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese Tiempo");
                tiempo = Convert.ToDouble( Console.ReadLine());
                respuesta = Velocidadini + (aceleraion * tiempo);
                Console.WriteLine("La velocidad final es : " + respuesta);
                Console.WriteLine();
            }

            if (operacion == 2)
            {
                Console.WriteLine("ingrese Velocidad Final");
                Velocidadfin = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese Aceleracion");
                aceleraion = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese Tiempo");
                tiempo = Convert.ToDouble(Console.ReadLine());
                respuesta = Velocidadfin - (aceleraion*tiempo);
                Console.WriteLine("La velocidad inicial es : " + respuesta);
                Console.WriteLine();
            }
            if (operacion == 3)
            {
                Console.WriteLine("ingrese Velocidad Inicial");
                Velocidadini = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese Velocidad Final");
                Velocidadfin = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese Tiempo");
                tiempo = Convert.ToDouble(Console.ReadLine());
                respuesta = (Velocidadfin-Velocidadini)/tiempo;
                Console.WriteLine("La aceleracion es : " + respuesta);
                Console.WriteLine();
            }
            if (operacion == 4)
            {
                Console.WriteLine("ingrese Velocidad inicial");
                Velocidadini = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese Aceleracion");
                aceleraion = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ingrese Velocidad Final");
                Velocidadfin = Convert.ToDouble(Console.ReadLine());
                respuesta = (Velocidadfin - Velocidadini) / aceleraion;
                Console.WriteLine("El tiempo es : " + respuesta);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Gracias por usar el programa :)");
                Console.WriteLine();
            }

            Console.WriteLine("Tarea 4 problema 2 ");
            Console.Write("Ingrese la cantidad en quetzales (entre 0 y 999.99): ");
            double cantidad = double.Parse(Console.ReadLine());
            int billetes100 = (int)cantidad / 100;
            cantidad %= 100;
            int billetes50 = (int)cantidad / 50;
            cantidad %= 50;
            int billetes20 = (int)cantidad / 20;
            cantidad %= 20;
            int billetes10 = (int)cantidad / 10;
            cantidad %= 10;
            int billetes5 = (int)cantidad / 5;
            cantidad %= 5;
            int monedas1 = (int)cantidad / 1;
            cantidad %= 1;
            int monedas25 = (int)(cantidad / 0.25);
            cantidad %= 0.25;
            int monedas1c = (int)(cantidad / 0.01);
            Console.WriteLine();
            Console.WriteLine("Cantidad de billetes y monedas correspondientes:");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Billetes de Q100: {billetes100}");
            Console.WriteLine($"Billetes de Q50: {billetes50}");
            Console.WriteLine($"Billetes de Q20: {billetes20}");
            Console.WriteLine($"Billetes de Q10: {billetes10}");
            Console.WriteLine($"Billetes de Q5: {billetes5}");
            Console.WriteLine($"Monedas de Q1: {monedas1}");
            Console.WriteLine($"Monedas de 25 centavos: {monedas25}");
            Console.WriteLine($"Monedas de 1 centavo: {monedas1c}");


            Console.ReadKey();
        }
    }
}
