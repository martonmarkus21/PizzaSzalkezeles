using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSzalkezeles
{
	internal class Megrendelo
	{
		public string Nev { get; set; }
		public int Penz { get; set; }

		public Megrendelo(string nev, int penz)
		{
			Nev = nev;
			Penz = penz;
		}

		public bool Fizet(int osszeg)
		{
			if (Penz >= osszeg)
			{
				Penz -= osszeg;
				return true;
			}
			return false;
		}

		public override string ToString()
		{
			return $"{Nev} (pénz: {Penz} Ft)";
		}
	}
}
