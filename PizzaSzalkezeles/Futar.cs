using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PizzaSzalkezeles
{
	internal class Futar
	{
		private PizzaKemence kemence;

		public Futar(PizzaKemence kemence)
		{
			this.kemence = kemence;
		}

		public void Futtat()
		{
			while (true)
			{
				Pizza p = kemence.KiveszPizza();

				Thread.Sleep(p.Meret * 100);

				Console.WriteLine($"Futár szállította: {p}");
			}
		}
	}
}