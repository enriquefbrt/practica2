﻿namespace Practice1
{
    class PoliceStation
    {
        private List<PoliceCar> policeCars = new List<PoliceCar>();
        private List<string> infractors = new List<string>();

        public List<string> Infractors => infractors;

        public void AddPoliceCar(PoliceCar car)
        {
            policeCars.Add(car);
        }

        public void StartAlarm(string? plate)
        {
            if (plate != null)
            {
                infractors.Add(plate);
                foreach (PoliceCar car in policeCars)
                {
                    if (car.IsPatrolling())
                    {
                        car.ChaseInfractor(plate);
                    }
                }
            }
            else { Console.WriteLine("Can't alert police cars: the vehicle has no plate."); }
        }
    }
}
