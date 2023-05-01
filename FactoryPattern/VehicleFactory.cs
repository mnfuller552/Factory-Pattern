using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{

		public static IVehicle GetVehicle()
		{
			Console.WriteLine($"Enter the number of wheels you would like on your vehicle, and I will make your vehicle!");

			var answer = Console.ReadLine();

			switch (answer.ToLower())
			{
				case "2":
					return new Motorcycle();
				case "4":
					return new Car();
				default:
					return new Car();
			}
		}
	}
}

