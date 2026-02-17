using System;
using System.Threading;

namespace PizzaSzalkezeles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PizzaKemence kemence = new PizzaKemence(5);

			Sef sef1 = new Sef(kemence);
			Sef sef2 = new Sef(kemence);
			Futar futar = new Futar(kemence);

			Thread t1 = new Thread(sef1.Futtat);
			Thread t2 = new Thread(sef2.Futtat);
			Thread t3 = new Thread(futar.Futtat);

			t1.Start();
			t2.Start();
			t3.Start();

			Console.ReadLine();
		}
	}
}