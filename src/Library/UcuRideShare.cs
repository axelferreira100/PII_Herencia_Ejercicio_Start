using System.Collections.Generic;
using System;
using System.IO;
using Ucu.Poo.Twitter;

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

        public void AddUser(CommonDriver user)
        {
            this.ListOfDrivers.Add(user);
            this.PostOnTwitter(user);
        }

        public void AddUser(PoolDriver user)
        {
            this.ListOfDrivers.Add(user);
            this.PostOnTwitter(user);
        }

        public void AddUser(Passenger user)
        {
            this.ListOfPassengers.Add(user);
            this.PostOnTwitter(user);
        }

        private void PostOnTwitter(CommonDriver user)
        {
            TwitterImage twitter = new TwitterImage();
            string profileImageUrl = user.ProfileImageUrl;
            string path = File.Exists($@"../../../{profileImageUrl}") ? $@"../../../{profileImageUrl}" : $@"{profileImageUrl}";
            
            Console.WriteLine(twitter.PublishToTwitter(
                $"¡Bienvenido {user.Name}! Nuevo conductor del UCU RideShare.\n" +
                    $"Biografía del nuevo conductor: {user.Biography}", path
            ));
        }

        private void PostOnTwitter(PoolDriver user)
        {
            TwitterImage twitter = new TwitterImage();
            string profileImageUrl = user.ProfileImageUrl;
            string path = File.Exists($@"../../../{profileImageUrl}") ? $@"../../../{profileImageUrl}" : $@"{profileImageUrl}";
            
            Console.WriteLine(twitter.PublishToTwitter(
                $"¡Bienvenido {user.Name}! Nuevo conductor del UCU RideShare.\n" +
                $"Biografía del nuevo conductor: {user.Biography}", path
            ));
        }

        private void PostOnTwitter(Passenger user)
        {
            TwitterImage twitter = new TwitterImage();
            string profileImageUrl = user.ProfileImageUrl;
            string path = File.Exists($@"../../../{profileImageUrl}") ? $@"../../../{profileImageUrl}" : $@"{profileImageUrl}";

            Console.WriteLine(twitter.PublishToTwitter(
                $"¡Bienvenido {user.Name}! Nuevo pasajero del UCU RideShare.", path
            ));
        }
    }
}