using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_JCSA_1020022
{
    internal class Program
	{
        {
	string CalcularMes(int num)
		{
			string res;
			switch (num)
			{
				case 1:
					res = "Enero";
					break;
				case 2:
					res = "Febrero";
					break;
				case 3:
					res = "Marzo";
					break;
				case 4:
					res = "Abril";
					break;
				case 5:
					res = "Mayo";
					break;
				case 6:
					res = "Junio";
					break;
				case 7:
					res = "Julio";
					break;
				case 8:
					res = "Agosto";
					break;
				case 9:
					res = "Septiembre";
					break;
				case 10:
					res = "Octubre";
					break;
				case 11:
					res = "Nobiembre";
					break;
				case 12:
					res = "Dicicembre";
					break;
				default: res = "Numero de Mes no valido";
			}
			return res;
		}
		void main()
		{
			string NumMes;
			write("Ingrese numero del Mes");
			read(NumMes);
			write(CalcularMes(NumMes));
		}

	}
}
}
