namespace Library
{
    public class Passenger : User
    {
        public Passenger(
            string name, string lastName, string id, string profileImageUrl
        ) : base(name, lastName, id, profileImageUrl)
        {
        }
    }
}