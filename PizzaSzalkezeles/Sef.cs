using PizzaSzalkezeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

internal class Sef
{
	private PizzaKemence kemence;
	private static Random r = new Random();
	private static string[] pizzaNevek = { "Margherita", "Sonkás", "Hawaii", "Texas", "Négysajtos" };
	private static string[] megrendelok = { "János", "Anna", "Péter", "Gyula", "Béla" };

	public Sef(PizzaKemence kemence)
	{
		this.kemence = kemence;
	}

	public void Futtat()
	{
		while (true)
		{
			Thread.Sleep(r.Next(4000, 6000));

			string nev = pizzaNevek[r.Next(pizzaNevek.Length)];
			int meret = r.Next(20, 41);
			Pizza p = new Pizza(nev, meret);

			string mNev = megrendelok[r.Next(megrendelok.Length)];
			Megrendelo m = new Megrendelo(mNev, r.Next(2000, 5000));

			int ar = meret * 50;

			Rendeles rendl = new Rendeles(p, m, ar);
			kemence.FeladRendeles(rendl);

			Console.WriteLine($"Séf elkészítette a rendelést: {rendl}");
		}
	}
}