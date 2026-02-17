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
				Rendeles r = kemence.KiveszRendeles();

				Thread.Sleep(r.Pizza.Meret * 150);

				bool fizetett = r.Megrendelo.Fizet(r.Ar);

				if (fizetett)
				{
					Console.WriteLine($"Futár kiszállította: {r}. Fizetve!");
				}
				else
				{
					Console.WriteLine($"Futár kiszállította: {r}. NINCS ELÉG PÉNZ!");
				}
			}
		}
	}

}