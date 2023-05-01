namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newCar = VehicleFactory.GetVehicle();

            newCar.Drive();
        }


    }
}
