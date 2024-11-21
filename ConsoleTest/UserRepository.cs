namespace ConsoleTest
{
    public class UserRepository : IRepository<User>
    {/*
        private readonly DbContext _context;
        public UserRepository(DbContext context) { _context = context; }

        public User GetUser(int id) { return _context.Users.Find(id); }*/
    }

    public interface IRepository<T>
    {
    }

    public class User
    {
    }
}