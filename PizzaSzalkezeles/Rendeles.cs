using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSzalkezeles
{
	internal class Rendeles
	{
		public Pizza Pizza { get; set; }
		public Megrendelo Megrendelo { get; set; }
		public int Ar { get; set; }

		public Rendeles(Pizza pizza, Megrendelo megrendelo, int ar)
		{
			Pizza = pizza;
			Megrendelo = megrendelo;
			Ar = ar;
		}

		public override string ToString()
		{
			return $"{Pizza} - {Megrendelo.Nev} ({Ar} Ft)";
		}
	}
}
