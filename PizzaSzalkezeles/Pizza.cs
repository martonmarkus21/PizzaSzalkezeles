using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSzalkezeles
{
	internal class Pizza
	{
		public string Nev { get; set; }
		public int Meret { get; set; }

		public Pizza(string nev, int meret)
		{
			Nev = nev;
			Meret = meret;
		}

		public override string ToString()
		{
			return $"{Nev} ({Meret} cm)";
		}
	}
}