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
            string profileImageUrl, Vehicle vehicle, string biography
        ) : base(name, lastName, id, profileImageUrl, vehicle, biography)
        {
        }

        public void ChangePassenger(Passenger passenger)
        {
            this.Passenger = passenger;
        }
    }
}