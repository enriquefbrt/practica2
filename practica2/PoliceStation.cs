namespace Practice1
{
    class PoliceStation
    {
        private List<PoliceCar> policeCars = new List<PoliceCar>();

        public void AddPoliceCar(PoliceCar car)
        {
            policeCars.Add(car);
        }

        public void StartAlarm(string plate)
        {
            foreach (PoliceCar car in policeCars)
            {
                if (car.IsPatrolling()) {
                    car.ChaseInfractor(plate);
                }
            }
        }
    }
}
