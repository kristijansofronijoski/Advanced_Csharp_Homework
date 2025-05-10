

namespace Task_02
{
    public static class VehicleExtensions
    {
        public static void Drive(this Car car)
        {
            Console.WriteLine("Driving");
        }

        public static void Wheelie(this MotorBike bike)
        {
            Console.WriteLine("Driving on one wheel");
        }

        public static void Sail(this Boat boat)
        {
            Console.WriteLine("Sailing");
        }

        public static void Fly(this AirPlane plane)
        {
            Console.WriteLine("Flying");
        }
    }
}
