using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
	class Motorcycle : IVehicle
	{
		public int NumberOfTires { get; set; }
		public bool CanDrive { get; set; }

		public void Drive()
		{
			throw new NotImplementedException();
		}
	}
}
