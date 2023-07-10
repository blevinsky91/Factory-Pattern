using System;
namespace FactoryPattern
{
	public interface IVehicle
	{
		public int NumberOfWheels { get; set; }

		public void Drive(); //stubbed out method
	}
}

