namespace Practice1
{
    class City
    {
        private PoliceStation policeStation = new PoliceStation();
        private List<Taxi> taxis = new List<Taxi>();


        public PoliceStation PoliceStation => policeStation;

        public PoliceCar AddPoliceCar(string plate, bool radar)
        {
            PoliceCar policeCar = new PoliceCar(plate, radar);
            Console.WriteLine(policeCar.WriteMessage("Created"));
            policeStation.AddPoliceCar(policeCar);
            return policeCar;
        }

        public Taxi AddTaxi(string plate)
        {
            Taxi taxi = new Taxi(plate);
            Console.WriteLine(taxi.WriteMessage("Created"));
            taxis.Add(taxi);
            return taxi;
        }

        public void RemoveTaxiLicense(string plate)
        {
            for (int i = taxis.Count - 1; i >= 0; i--)
            {
                if (taxis[i].GetPlate() == plate)
                {
                    taxis.RemoveAt(i);
                    Console.WriteLine($"License of taxi with plate {plate} was removed due to exceeding the speed limit.");
                }
            }
        }
    }
}
