namespace Library
{
    public class CommonDriver : Driver
    {
        private Passenger _passenger;

        public Passenger Passenger
        {
            get { return this._passenger; }
            private set { this._passenger = value; }
        }

        public CommonDriver(
            string name, string lastName, string id, 
            Vehicle vehicle, string biography
        )
        {
            this.Name = name;
            this.LastName = lastName;
            this.Id = id;
            this.Vehicle = vehicle;
            this.Biography = biography;
        }

        public void ChangePassenger(Passenger passenger)
        {
            this.Passenger = passenger;
        }
    }
}