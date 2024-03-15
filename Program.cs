namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Vehicle vehicleCar = new Car();
            Vehicle vehicleMotorcycle = new Motorcycle();

            Console.WriteLine(vehicleCar);
            vehicleCar.Move();
            vehicleCar.SpeedUp(30);
            vehicleCar.SpeedDown(31);
            // Console.WriteLine(vehicleCar.Speed);

            Console.WriteLine(vehicleMotorcycle);
            vehicleMotorcycle.Move();
            vehicleMotorcycle.SpeedUp(50);
        }
    }
}
