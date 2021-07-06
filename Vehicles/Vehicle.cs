namespace Vehicles
{
    public class Vehicle
    {
        private string vehicleId;

        public string Vehicleid
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int wheels;

        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }

        public Vehicle(string vehicleId, string color, int wheels)
        {
            this.Vehicleid = vehicleId;
            this.Color = color;
            this.Wheels = wheels;
        }

        public override string ToString()
        {
            return $"ID {Vehicleid} , color {Color}, # wheels {Wheels}";
        }
    }
}