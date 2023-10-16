namespace AutoMapper1
{
    public interface IUserRepository
    {
        public User GetUser();
    }
    public class UserRepository:IUserRepository
    {
        public User GetUser()
        {
            return new User { ID = 1, Name = "Pratheeksha" };
        }
    }
}
