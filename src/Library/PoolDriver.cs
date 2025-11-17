using System.Collections.Generic;

namespace Library
{
    public class PoolDriver : Driver
    {
        private int _maximumCapacity;
        private List<Passenger> _listOfPassengers = new List<Passenger>();

        public int MaximumCapacity
        {
            get { return this._maximumCapacity; }
            private set { this._maximumCapacity = value; }
        }

        public List<Passenger> ListOfPassengers
        {
            get { return this._listOfPassengers; }
            private set { this._listOfPassengers = value; }
        }

        public PoolDriver(
            string name, string lastName, string id, 
            string profileImageUrl, Vehicle vehicle, 
            string biography, int maximumCapacity
        ) : base(name, lastName, id, profileImageUrl, vehicle, biography)
        {
            this.MaximumCapacity = maximumCapacity;
        }

        public void AddPassenger(Passenger passenger)
        {
            this.ListOfPassengers.Add(passenger);
        }

        public void RemovePassenger(Passenger passenger)
        {
            this.ListOfPassengers.Remove(passenger);
        }
    }
}