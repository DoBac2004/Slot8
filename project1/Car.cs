using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Car
    {
		public string make;
		public string model;
		public string color;
		public int yearBuilt;

		public void Strart()
		{
			System.Console.WriteLine(model + "started");
		}
		public void Stop()
		{
			System.Console.WriteLine(model + "stopped");
		}
	}
}
