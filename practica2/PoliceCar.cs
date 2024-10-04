namespace Practice1
{
    class PoliceCar : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar? speedRadar;
        private string? infractor = null;
        private bool chasing = false;

        public PoliceCar(string plate, bool radar) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            if (radar) { speedRadar = new SpeedRadar(); }
        }

        public void UseRadar(Vehicle vehicle, PoliceStation policeStation)
        {
            if (speedRadar != null)
            {
                if (isPatrolling)
                {
                    bool infraction = false;
                    float speed = speedRadar.TriggerRadar(vehicle);
                    string meassurement = speedRadar.GetLastReading(ref infraction);
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));

                    if (infraction) { policeStation.StartAlarm(vehicle.GetPlate()); }
                }
                else
                {
                    Console.WriteLine(WriteMessage($"has no active radar."));
                }
            }
            else { Console.WriteLine(WriteMessage("has no associated radar.")); }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void ChaseInfractor(string plate)
        {
            infractor = plate;
            chasing = true;
            Console.WriteLine(WriteMessage($"Chasing infractor vehicle with plate {plate}"));
        }

        public void PrintRadarHistory()
        {
            if (speedRadar != null)
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else { Console.WriteLine(WriteMessage("Can't print radar history because this police car has no associated radar.")); }
        }
    }
}