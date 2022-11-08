using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POTENCIA_DE_UN_NUMERO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y; 
            float resultado = 1;
            Console.WriteLine("Ingresa un numero: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("valor de la exponente? ");
            y = int.Parse(Console.ReadLine());

            if (y == 0)
            {
                             
            }
            else if (y > 0)
            {
                for (int i = 1; i <= y; ++i)
                {
                    resultado *= x;
                }
            }
            else if (y < 0)
            {
                for (int i = -1; i >= y; --i)
                {
                    resultado /= x;
                }
            }

            Console.WriteLine("resultado es " + resultado);
            Console.ReadKey();
        }
    }
}
