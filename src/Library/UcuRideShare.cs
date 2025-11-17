using System.Collections.Generic;

namespace Library
{
    public class UcuRideShare
    {
        private List<Driver> _listOfDrivers = new List<Driver>();
        private List<Passenger> _listOfPassengers = new List<Passenger>();

        public List<Driver> ListOfDrivers
        {
            get { return this._listOfDrivers; }
            private set { this._listOfDrivers = value; }
        }

        public List<Passenger> ListOfPassengers
        {
            get { return this._listOfPassengers; }
            private set { this._listOfPassengers = value; }
        }

        public void AddUser(Driver user)
        {
            this.ListOfDrivers.Add(user);
            this.PostOnTwitter(user);
        }

        public void AddUser(Passenger user)
        {
            this.ListOfPassengers.Add(user);
            this.PostOnTwitter(user);
        }

        private void PostOnTwitter(Driver user)
        {
            
        }

        private void PostOnTwitter(Passenger user)
        {
            
        }
    }
}