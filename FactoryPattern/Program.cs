namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Truck and Moto World! You can choose between a truck or a motorcycle!");
            Console.WriteLine("Please, tell me which of the two vehicles you choose today:");
            string userInput = Console.ReadLine();

            IVehicle instance = VehicleFactory.GetVehicle(userInput);
            instance.Drive();
        }
    }
}
