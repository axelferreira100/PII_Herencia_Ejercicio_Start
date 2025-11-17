namespace Library
{
    public abstract class Driver : User
    {
        protected Vehicle vehicle;
        protected string biography;

        public Vehicle Vehicle
        {
            get { return this.vehicle; }
            protected set { this.vehicle = value; }
        }

        public string Biography
        {
            get { return this.biography; }
            protected set { this.biography = value; }
        }

        public Driver(
            string name, string lastName, string id, 
            string profileImageUrl, Vehicle vehicle, string biography
        ) : base(name, lastName, id, profileImageUrl)
        {
            this.Vehicle = vehicle;
            this.Biography = biography;
        }
    }
}