using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PizzaSzalkezeles
{
	internal class Sef
	{
		private PizzaKemence kemence;
		private static Random r = new Random();
		private static string[] pizzaNevek = { "Margherita", "Sonkás", "Hawaii", "Pepperoni", "Négysajtos" };

		public Sef(PizzaKemence kemence)
		{
			this.kemence = kemence;
		}

		public void Futtat()
		{
			while (true)
			{
				Thread.Sleep(r.Next(2000, 3000));

				string nev = pizzaNevek[r.Next(pizzaNevek.Length)];
				int meret = r.Next(20, 41);

				Pizza p = new Pizza(nev, meret);
				kemence.FeladPizza(p);

				Console.WriteLine($"Séf készítette: {p}");
			}
		}
	}
}