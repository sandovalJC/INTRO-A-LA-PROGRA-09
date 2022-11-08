using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DECIMAL_A_BINARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero decimal");
            int numero = Convert.ToInt32(Console.ReadLine());

            long binario = decimalBinario(numero);
            Console.WriteLine("El numero decimal " + numero  + " en binario es " + binario)

            Console.ReadLine();
        }
        public static long decimalBinario(int numero)
        {

            long binario = 0;

            const int DIVISOR = 2;
            long digito = 0;

            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                binario += digito * (long)Math.Pow(10, j);
            }


            return binario;
        }
    }
}
