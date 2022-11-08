using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_BILLETES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Double Dinero, B1 = 0, B5 = 0, B10 = 0, B20 = 0, B50 = 0, B100 = 0;
                Console.WriteLine("Ingrese la cantidad de dinero a desglosar: ");
                Dinero = Convert.ToDouble(Console.ReadLine());

                if (Dinero >= 100)
                    B100 = Math.Abs(Dinero) / 100;
                Dinero = Dinero - (B100 * 100);
                if (Dinero >= 50)
                    B50 = Math.Abs(Dinero) / 50;
                Dinero = Dinero - (B100 * 50);
                if (Dinero >= 20)
                    B100 = Math.Abs(Dinero) / 20;
                Dinero = Dinero - (B20 * 20);
                if (Dinero >= 10)
                    B10 = Math.Abs(Dinero) / 10;
                Dinero = Dinero - (B10 * 10);
                if (Dinero >= 5)
                    B5 = Math.Abs(Dinero) / 5;
                Dinero = Dinero - (B5 * 5);
                if (Dinero >= 1)
                    B1 = Math.Abs(Dinero) / 1;
                Dinero = Dinero - (B1 * 1);
                Console.WriteLine("La cantidad en billetes de $100: " + B100);
                Console.WriteLine("La cantidad en billetes de $50: " + B50);
                Console.WriteLine("La cantidad en billetes de $20: " + B20);
                Console.WriteLine("La cantidad en billetes de $10: " + B10);
                Console.WriteLine("La cantidad en billetes de $5: " + B5);
                Console.WriteLine("La cantidad en billetes de $1: " + B1);
                Console.ReadLine();
            }

        }
    }
}
