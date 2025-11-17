namespace Library
{
    public abstract class User
    {
        protected string name, lastName, id;
        protected int calification = 0;

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            protected set { this.lastName = value; }
        }

        public string Id
        {
            get { return this.id; }
            protected set { this.id = value; }
        }

        public int Calification
        {
            get { return this.calification; }
            protected set { this.calification = value; }
        }

        public User(string name, string lastName, string id)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Id = id;
        }
    }
}