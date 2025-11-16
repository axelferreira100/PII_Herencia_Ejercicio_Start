namespace Library
{
    public abstract class Driver
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
    }
}