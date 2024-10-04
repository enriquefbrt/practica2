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

        public void RemoveTaxiLicense()
        {
            foreach (string infractor in policeStation.Infractors)
            {
                for (int i = taxis.Count - 1; i >= 0; i--)
                {
                    if (taxis[i].GetPlate() == infractor)
                    {
                        taxis.RemoveAt(i);
                        Console.WriteLine($"Removed Taxi license for Taxi with plate {infractor}.");
                    }
                }
            }
        }
    }
}
