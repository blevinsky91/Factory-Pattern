using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public int NumberOfWheels { get; set; } = 2;

		public void Drive()
		{
			Console.WriteLine($"Awesome! You chose a motorcycle! This bike is very fast, and will come with {NumberOfWheels} very sticky tires that will improve traction. Have fun!");
		}
	}
}

