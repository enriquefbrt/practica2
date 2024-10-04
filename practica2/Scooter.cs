namespace Practice1
{
    class Scooter : Vehicle
    {
        public static string typeOfVehicle = "Scooter";

        public Scooter() : base(typeOfVehicle, null)
        {
            SetSpeed(25.0f);
        }

        public void StartRide()
        {
            Console.WriteLine(WriteMessage("starts riding."));
        }

        public void StopRide()
        {
            Console.WriteLine(WriteMessage("stopped riding."));
        }
    }
}
