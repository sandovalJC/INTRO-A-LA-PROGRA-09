using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMERO_INVERTIDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int num, centenas, decenas, unidades, resultado;
			string linea;

			Console.WriteLine("Ingrese un numero de 3 cifras.");             
			linea = Console.ReadLine();                                             
			num = int.Parse(linea);                                                 
			Console.WriteLine("El numero que ingresaste es: " + num);       

			centenas = num / 100;                                                               
			Console.WriteLine("El número en la posicion de centenas es: " + centenas);   
			num = num % 100;                                                                    
			Console.WriteLine("El residuo en la posicion de centenas es: " + num);       

			decenas = num / 10;                                                                 
			Console.WriteLine("El numero en la posicion de decenas es: " + decenas);     

			unidades = num % 10;                                                                
			Console.WriteLine("El residuo en la posicion de unidades es: " + unidades);  

			resultado = (unidades * 100) + (decenas * 10) + centenas;
			Console.WriteLine("El nuevo numero es: " + resultado);
			Console.ReadKey();

		}
	}
}
 