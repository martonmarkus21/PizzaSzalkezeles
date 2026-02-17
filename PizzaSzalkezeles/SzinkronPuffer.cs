using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PizzaSzalkezeles
{
	internal class SzinkronPuffer<T>
	{
		private Queue<T> sor = new Queue<T>();
		private int maxMeret;
		private readonly object zar = new object();

		public SzinkronPuffer(int maxMeret)
		{
			this.maxMeret = maxMeret;
		}

		public void Hozzaad(T elem)
		{
			lock (zar)
			{
				while (sor.Count == maxMeret)
				{
					Monitor.Wait(zar);
				}

				sor.Enqueue(elem);
				Monitor.PulseAll(zar);
			}
		}

		public T Kivesz()
		{
			lock (zar)
			{
				while (sor.Count == 0)
				{
					Monitor.Wait(zar);
				}

				T elem = sor.Dequeue();
				Monitor.PulseAll(zar);
				return elem;
			}
		}
	}
}