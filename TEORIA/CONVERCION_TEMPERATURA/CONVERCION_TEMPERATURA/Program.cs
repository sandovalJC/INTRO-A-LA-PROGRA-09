using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERCION_TEMPERATURA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("ingrese temperatura en grados farenheit");
            F = Console.ReadLine();
            C = (F - 32)*59;
            Console.WriteLine(+F + "grados fahrenheit corresponden a " + C + " grados celsius ");
           
            
        }
    }

