using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSzalkezeles
{
	internal class PizzaKemence
	{
		private SzinkronPuffer<Pizza> puffer;

		public PizzaKemence(int meret)
		{
			puffer = new SzinkronPuffer<Pizza>(meret);
		}

		public void FeladPizza(Pizza p)
		{
			puffer.Hozzaad(p);
		}

		public Pizza KiveszPizza()
		{
			return puffer.Kivesz();
		}
	}
}