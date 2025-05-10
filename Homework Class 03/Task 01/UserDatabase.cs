

namespace Task_01
{
    public static class UserDatabase
    {
        private static List<User> users = new List<User>();
        static UserDatabase()
        {
            users.Add(new User(1, "Alice", 30));
            users.Add(new User(2, "Bob", 25));
            users.Add(new User(3, "Charlie", 35));
        }
        public static List<User> SearchById(int id)
        {
            return users.Where(user => user.Id == id).ToList();
        }
        public static List<User> SearchByName(string name)
        {
            return users.Where(user => user.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public static List<User> SearchByAge(int age)
        {
            return users.Where(user => user.Age == age).ToList();
        }
    }
}
