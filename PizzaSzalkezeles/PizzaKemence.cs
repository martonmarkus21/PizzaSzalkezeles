using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSzalkezeles
{
	internal class PizzaKemence
	{
		private SzinkronPuffer<Rendeles> puffer;

		public PizzaKemence(int meret)
		{
			puffer = new SzinkronPuffer<Rendeles>(meret);
		}

		public void FeladRendeles(Rendeles r)
		{
			puffer.Hozzaad(r);
		}

		public Rendeles KiveszRendeles()
		{
			return puffer.Kivesz();
		}
	}
}