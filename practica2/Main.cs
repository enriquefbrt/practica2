namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            City city = new City();
            Taxi taxi1 = city.AddTaxi("0001 AAA");
            Taxi taxi2 = city.AddTaxi("0002 BBB");
            Taxi taxi3 = city.AddTaxi("0003 CCC");
            PoliceCar policeCar1 = city.AddPoliceCar("0001 CNP", true);
            PoliceCar policeCar2 = city.AddPoliceCar("0002 CNP", true);
            PoliceCar policeCar3 = city.AddPoliceCar("0003 CNP", false);

            policeCar3.UseRadar(taxi1, city.PoliceStation);

            policeCar1.StartPatrolling();
            policeCar2.StartPatrolling();
            policeCar3.StartPatrolling();

            taxi1.StartRide();
            policeCar1.UseRadar(taxi1, city.PoliceStation);
            taxi1.StopRide();
            policeCar1.EndPatrolling();
            taxi2.StartRide();
            policeCar2.UseRadar(taxi2, city.PoliceStation);
            taxi2.StopRide();
            policeCar2.EndPatrolling();

            city.RemoveTaxiLicense();
        }
    }
}
    

