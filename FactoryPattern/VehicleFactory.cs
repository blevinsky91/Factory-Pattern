using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static IVehicle GetVehicle(string wheels)
		{
			switch(wheels)
			{
				case "truck":
				case "Truck":
				case "TRUCK":
					return new Truck();
				case "motorcycle":
				case "Motorcycle":
				case "MOTORCYCLE":
					return new Motorcycle();
				default:
					return new Truck();
			}
		}
	}
}

