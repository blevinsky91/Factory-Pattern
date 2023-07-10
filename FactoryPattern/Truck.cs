using System;
namespace FactoryPattern
{
	public class Truck : IVehicle
	{
		public int NumberOfWheels { get; set; } = 4;

		public void Drive()
		{
			Console.WriteLine($"Very nice! You chose a truck. The truck you chose today will have {NumberOfWheels} huge offroad tires! Have fun!");
		}
	}
}

