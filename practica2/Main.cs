namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            City city = new City();
            Taxi taxi1 = city.AddTaxi("0001 AAA");
            Taxi taxi2 = city.AddTaxi("0002 BBB");
            PoliceCar policeCar1 = city.AddPoliceCar("0001 CNP", true);
            PoliceCar policeCar2 = city.AddPoliceCar("0002 CNP", true);

            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1, city.PoliceStation);

            taxi2.StartRide();
            policeCar2.UseRadar(taxi2, city.PoliceStation);
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2, city.PoliceStation);
            taxi2.StopRide();
            policeCar2.EndPatrolling();

            taxi1.StartRide();
            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1, city.PoliceStation);
            taxi1.StopRide();
            taxi1.StopRide();
            policeCar1.EndPatrolling();

            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();

        }
    }
}
    

